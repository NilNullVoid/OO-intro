namespace cars
{
public class petrolCar : Car
{
    public string fuelType;
    public petrolCar(string make, string model, string rego, int maxRange, string fuelType, driver driver) : base (make, model, rego, maxRange, driver)
    {
        this.make = make;
        this.model = model;
        this.rego = rego;
        this.maxRange = maxRange;
        this.fuelType = fuelType;
        this.driver = driver;
        range = maxRange;
    }
    public void refuel()
    {
        range = maxRange;
    }
}
}