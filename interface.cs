using System;

namespace VehicleDemo
{
    public interface IVehicle
    {
        public void register();
        public void start();
        public void stop();
        public void playHorn();
    }

    public class Car : IVehicle
    {
        public void register()
        {
            Console.WriteLine("New car has been registered");
        }

        public void start()
        {
            Console.WriteLine("Car started");
        }

        public void stop()
        {
            Console.WriteLine("Car stopped");
        }

        public void playHorn()
        {
            Console.WriteLine("Car horn played");
        }
    }
}