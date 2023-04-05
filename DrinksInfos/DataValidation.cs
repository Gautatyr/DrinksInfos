using static DrinksInfos.Helpers;

namespace DrinksInfos;

public static class DataValidation
{
    public static int GetCategoryIdInput(string message = "")
    {
        bool idIsValid = false;
        int idInput = 0;
        var categories = GetSequencedCategoriesList();
     
        while (idIsValid == false)
        {
            idInput = GetNumberInput(message);

            foreach (var category in categories)
            {
                if (category.id == idInput) idIsValid = true;
            }
        }

        return idInput;
    }

    public static int GetNumberInput(string message = "")
    {
        Console.WriteLine(message);

        var input = Console.ReadLine();

        while (!int.TryParse(input, out _))
        {
            DisplayError($"{input} is not a valid id");
            Console.WriteLine(message);

            input = Console.ReadLine();
        }

        int validNumber = int.Parse(input);

        return validNumber;
    }
}
