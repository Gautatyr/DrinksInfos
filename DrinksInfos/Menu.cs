using static DrinksInfos.Helpers;
using ConsoleTableExt;
using static DrinksInfos.DataValidation;

namespace DrinksInfos;

public static class Menu
{   public static void DrinksCategoriesMenu(string message = "")
    {
        Console.WriteLine(message);

        var categories = GetSequencedCategoriesList();

        ConsoleTableBuilder
            .From(categories.ToList())
            .WithColumn("CATEGORIES:", "ID")
            .ExportAndWriteLine();

        int choice = GetCategoryIdInput("\nEnter the ID of the category of your drink:\n");

        Categories chosenCategory = null;

        foreach(Categories category in categories)
        {
            if (category.id == choice) chosenCategory = category;
        }

        DrinksMenu(chosenCategory);
    }

    private static void DrinksMenu(Categories category) 
    {
        Console.WriteLine($"gg wp {category.CategoryName}{category.id}");
        Console.ReadLine();
        // Display all the drinks with the proper category

    }

    private static void DrinkDetailsMenu(string drinkName) // replace with drink.name object
    {
        // Display all the infos on the drink using object method from class
    }
}
