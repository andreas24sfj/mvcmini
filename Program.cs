namespace mvcmini;

class Program
{
    static void Main(string[] args)
    {
        Model model = new Model();
        View view = new View();

        Controller controller = new Controller(model, view);
        //Calling StoreApplication from Controller.
        controller.StoreApplication();
    }
}
