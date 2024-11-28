class Model
{
    public Dictionary<string, int> Products { get; set; } = new Dictionary<string, int>();



    // Method that takes the data from Products and converts it to string.
    public override string ToString()
    {
        if (Products == null || Products.Count == 0)
        {
            return "==== No products available ====";
        }
        else
            // Goes through every keyvaluepair in the dictionary Products to join them together in a string
            // and prints each product on a new line

            return string.Join(Environment.NewLine, Products.Select(p => $"product: {p.Key} | stock: {p.Value}"));

    }
}