public class Product
{
    string _productName;
    int _productId;
    float _price;
    int _quantity;
    

    public Product()
    {

    }


    public void SetProductName(string productName)
    {
        _productName = productName;
    }

    public void SetProductId(int productId)
    {
        _productId = productId;
    }

    public void SetPrice(float price)
    {
        _price = price;
    }

    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }
    
    public float CalculateTotalPrice()
    {
        return _price * _quantity;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public int GetProductId()
    {
        return _productId;
    }
}