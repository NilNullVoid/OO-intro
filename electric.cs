namespace cars
{
public class electricCar : Car
{
    public electricCar(string make, string model, string rego, int maxRange, driver driver) : base (make, model, rego, maxRange, driver)
    {
        this.make = make;
        this.model = model;
        this.rego = rego;
        this.maxRange = maxRange;
        this.driver = driver;
        range = maxRange;
    }
    public void recharge()
    {
        range = maxRange;
    }
}
}