public class Customer
{
    string _customerName;
    Address _address = new Address();


    public Customer()
    {

    }


    public void SetCustomerName(string customerName)
    {
        _customerName = customerName;
    }
    
    public void SetAddress(string streetName, string city, string state, string country)
    {
        _address.SetStreetAddress(streetName);
        _address.SetCity(city);
        _address.SetState(state);
        _address.SetCountry(country);

        _address.ChangeCountryBool();
    }

    public float CalculateDelivery()
    {
        float delivery = 0;
        if (_address.GetDomesticOrInt() == true)
        {
            delivery = 5;
        }

        else
        {
            delivery = 35;
        }

        return delivery;
    }

    public string GetCustomerName()
    {
        return _customerName;
    }

    public string GetCustomerAddress()
    {
        return _address.GetAddress();
    }
}