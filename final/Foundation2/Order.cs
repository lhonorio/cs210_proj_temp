public class Order
{
    List<Product> _products = new List<Product>();
    Customer _customer = new Customer();


    public Order()
    {

    }


    public void AddProductDetails(string productName, int productId, float price, int quantity)
    {
        Product product = new Product();

        product.SetProductName(productName);
        product.SetProductId(productId);
        product.SetPrice(price);
        product.SetQuantity(quantity);

        _products.Add(product);
    }

    public void SetCustomerDetails(string customerName, string streetName, string city, string state, string country)
    {
        _customer.SetCustomerName(customerName);
        _customer.SetAddress(streetName, city, state, country);
    }

    public float CalculateCost()
    {
        float purchase = 0;

        foreach (Product product in _products)
        {
            purchase = purchase + product.CalculateTotalPrice();
        }

        float delivery = _customer.CalculateDelivery();

        return purchase + delivery;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";

        foreach (Product product in _products)
        {
            packingLabel = packingLabel + $"\nProduct Name: {product.GetProductName()} | Product ID: {product.GetProductId()}";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Customer Name: {_customer.GetCustomerName()} | Customer Address: {_customer.GetCustomerAddress()}";
    }
}