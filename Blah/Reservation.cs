public class Reservation
{
    string _name;
    int _hours;
    string _place;
    string _date;

    
    public Reservation(string name, int hours, string place, string date)
    {
        _name = name;
        _hours = hours;
        _place = place;
        _date = date;
    }

    
    public void MakeRVSP()
    {

    }

    public void DisplayRSVP()
    {
        Console.WriteLine($"{_name} reserved {_place} for {_hours} hours at {_date}");
    }
}