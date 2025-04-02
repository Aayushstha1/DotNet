namespace inheritanceExample
public class program 
{
    public static void Main(string[] args)
    {
        vehical v = new vehical("V1002");;
        v.display();
        v = new Truck(T1002 , "Truck1003");
        v.display();
    }
}
public class vehicle 
{
    protected string vehicalNO=null;
    protected string brand=null;
    protected float fuelCapscity ; 
    }
    public class car: vehical
    {
        private int seatCapacity;

    }
    public class Truck: vehical
    {
        private float
    }