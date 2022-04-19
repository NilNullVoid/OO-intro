namespace cars
{
public class Car
{
    public string make;
    public string model;
    public string rego;
    public int maxRange;
    public int range;
    public driver driver;
    public Car(string make, string model, string rego, int maxRange, driver driver)
    {
        this.make = make;
        this.model = model;
        this.rego = rego;
        this.maxRange = maxRange;
        this.driver = driver;
        range = maxRange;
    }
    public string getDetails()
    { return $"the car is a {make} of model: {model}. Its registration is {rego}."; }
    public void travel(int distance)
    {
        if (range <= distance)
        { range = 0; }
        range -= distance;
    }
    public int getRange()
    { return range; }
    public void changeDriver(driver driver)
    { this.driver = driver; }
}
}