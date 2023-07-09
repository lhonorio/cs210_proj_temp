public class Address
{
    string _streetAddress;
    string _city;
    string _state;
    string _country;
    bool _usOrNot = false;


    public Address()
    {
        
    }


    public void SetStreetAddress(string streetAddress)
    {
        _streetAddress = streetAddress;
    }

    public void SetCity(string city)
    {
        _city = city;
    }

    public void SetState(string state)
    {
        _state = state;
    }

    public void SetCountry(string country)
    {
        _country = country;
    }

    public void ChangeCountryBool()
    {
        if (_country == "USA")
        {
            _usOrNot = true;
        }

        else
        {
            _usOrNot = false;
        }
    }

    public bool GetDomesticOrInt()
    {
        return _usOrNot;
    }

    public string GetAddress()
    {
        return $"{_streetAddress},\n{_city}, {_state}, {_country}";
    }
}