namespace DrinksInfos;

public static class Helpers
{
    public static void DisplayError(string error)
    {
        Console.WriteLine($"\n|---> Error: {error}, press enter to continue. <---|\n");
        Console.ReadLine();
    }
}
