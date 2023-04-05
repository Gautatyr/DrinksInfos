using static DrinksInfos.APIManager;

namespace DrinksInfos;

public static class Helpers
{
    public static void DisplayError(string error)
    {
        Console.WriteLine($"\n|---> Error: {error} <---|\n");
    }

    public static Categories[] GetSequencedCategoriesList()
    {
        var categories = GetCategoriesAsync();
        int id = 1;

        foreach (var category in categories)
        {
            category.id = id;
            id++;
        }

        return categories;
    }
}
