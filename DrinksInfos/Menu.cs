using static DrinksInfos.Helpers;
using static DrinksInfos.APIManager;
using DrinksInfos.Models;
using ConsoleTableExt;

namespace DrinksInfos;

public static class Menu
{   public static void DrinksCategoriesMenu(string message = "")
    {
        Console.WriteLine(message);

        //DisplayDrinkCategoriesAsync();
        var categories = GetCategoriesAsync();
        int id = 1;

        foreach (var category in categories)
        {
            category.id = id;
            id++;
        }

        ConsoleTableBuilder
            .From(categories.ToList())
            .WithColumn("CATEGORIES:", "ID")
            .ExportAndWriteLine();

        Console.WriteLine("\nEnter the ID of the category of your drink:\n");
        int choice = Console.ReadLine(); //replace by data validation method for category ids
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
