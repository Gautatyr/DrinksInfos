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

        int choice = DataValidation.GetCategoryIdInput("\nEnter the ID of the category of your drink:\n");
   
    }

    private static void Drinks(int category) // Replace int with Drink.Category object
    {
        // Display all the drinks with the proper category
    }

    private static void DrinkDetails(string drinkName) // replace with drink.name object
    {
        // Display all the infos on the drink using object method from class
    }
}
