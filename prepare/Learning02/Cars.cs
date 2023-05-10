public class Car {

// Instances
public string brand;
public int miles;
public string color;

// Constructor
public Car() {

}

// Methods (functions)
public void move_forward()
{
    Console.WriteLine("It's moving");
}

public void displayInfo()
{
    Console.WriteLine($"Brand: {brand} | Miles: {miles} | Color: {color}.");
}

}