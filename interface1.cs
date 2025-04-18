namespace InterfaceExample
{
    internal class Program
    {
        public static void main(String[] args)
        {
            MyVehicle(new Car());
            MyVehicle(new Byd());
            //IVehicle v = new Car();
            //v.Start();
            //v.PlayHorn();
            Console.ReadKey();
        }
        public static void MyVehicle(IVehicle v)
        {
            v.Start();
            //v.PlayHorn();
        }
    }

    public interface IVehicle
    {
        public void Register();
        public void Start();
        public void Stop();
        public void PlayHorn();
    }
    public interface IPrintable
    {
        void Print();
    }
    public class Car : IVehicle, IPrintable
    {
        public void Register()
        {
            Console.WriteLine(" new car has registered.");
        }
        public void Start()
        {
            Console.WriteLine("I am ready to go");
        }
        //public abstract void stop();
        public void Stop()
        {
            Console.WriteLine("I am idle now");
        }
        public void PlayHorn()
        {
            Console.WriteLine("Car says...");
        }
        public void Print()
        {
            Console.WriteLine("This is my car");
        }
    }
    public class Byd : Car
    {
        public override void Start()
        {
            Console.WriteLine("BYD has just started");
        }
    }
}
