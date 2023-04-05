using System.Net.Http.Headers;
using System.Text.Json;

namespace DrinksInfos;

public static class APIManager
{
    public static Categories[] GetCategoriesAsync()
    {
        using HttpClient client = new();
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        var categoriesRootTask = ProcessDrinkCategoriesAsync(client);

        CategoriesRoot categoriesRoot = new CategoriesRoot(categoriesRootTask.Result.Categories);
        return categoriesRoot.Categories;
    }

    private static async Task<CategoriesRoot> ProcessDrinkCategoriesAsync(HttpClient client)
    {
        await using Stream stream =
            await client.GetStreamAsync("https://www.thecocktaildb.com/api/json/v1/1/list.php?c=list");

        var categoriesRoot =
            await JsonSerializer.DeserializeAsync<CategoriesRoot>(stream);

        return categoriesRoot;
    }
}
 