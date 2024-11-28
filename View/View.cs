class View
{
    public void Display(Model model)
    {
        Console.WriteLine("\n===== Displaying products =====");
        Console.WriteLine(model.ToString());
        Console.WriteLine("===============================");
    }

    public void DisplayMessage(string message)
    {
        Console.WriteLine(message);
    }
}