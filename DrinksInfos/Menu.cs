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

        ConsoleTableBuilder
            .From(categories.ToList())
            .WithColumn("CATEGORIES:")
            .ExportAndWriteLine();

        Console.WriteLine("\nChoose the category of your drink:\n");

        //string choice = Console.ReadLine().Trim().ToLower();

        /*switch (choice){
            case root.
            case "ordinarydrink":
                break;
            case "cocktail":
                break;
            case "shake":
                break;
            case "other/unknown":
                break;
            case "cocoa":
                break;
            case "shot":
                break;
            case "coffee/tea":
                break;
            case "homemadeliqueur":
                break;
            case "punch/partydrink":
                break;
            case "beer":
                break;
            case "softdrink":
                break;
            default: 
                DisplayError("Invalid Input");
                break;
        } */
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
