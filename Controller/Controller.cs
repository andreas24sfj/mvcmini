using System.Runtime.CompilerServices;

class Controller
{
    private Model _model;
    private View _view;

    public Controller(Model model, View view)
    {
        _model = model;
        _view = view;
    }
    //Method to add products
    public void AddProducts()
    {
        _view.DisplayMessage("\nEnter the name of the product you want to add: ");
        string? productName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(productName))
        {
            _view.DisplayMessage("\nName of the product cannot be null or empty, please write something");
            return;
        }
        //Adds a new product, or updates the quantity of an already existing product in _model.Products
        _view.DisplayMessage("\nHow many of the product do you wish to add?");
        if (int.TryParse(Console.ReadLine(), out int quantity))
        {
            if (_model.Products.ContainsKey(productName))
            {
                _model.Products[productName] += quantity;
                _view.DisplayMessage($"\nThe new stock of {productName} is {_model.Products[productName]}.");
            }
            else
            {
                _model.Products[productName] = quantity;
                _view.DisplayMessage($"\nAdded {quantity} x {productName} to the store.");
            }
        }
        else
        {
            _view.DisplayMessage("\nYour input is invalid. Quantity needs to be a number.");
        }
    }

    public void ShowModel()
    {
        _view.Display(_model);
    }

    public void StoreApplication()
    {
        bool isRunning = true;
        while (isRunning)
        {
            _view.DisplayMessage("\nWould you like to ADD or LIST products? EXIT to exit");
            //using Trim and ToUpper on null would give error. ensuring if userinput is null, that it gets converted
            //to an empty string instead.
            string? userChoice = (Console.ReadLine() ?? string.Empty).Trim().ToUpper();

            switch (userChoice)
            {
                case "ADD":
                    AddProducts();
                    break;

                case "LIST":
                    ShowModel();
                    break;
                case "EXIT":
                    isRunning = false;
                    _view.DisplayMessage("\nExiting the program...");
                    break;
                default:
                    _view.DisplayMessage("\nYou need to write either ADD, LIST or EXIT.");
                    break;
            }
        }
    }

}
