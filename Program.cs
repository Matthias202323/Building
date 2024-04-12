using System.Runtime.CompilerServices;

namespace Building
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public class Building
    {
        private double _height;
        private int _étages;

        public Building(double height,int étages)
        {
            _height = height;
            _étages = étages;
        }
        public Building(int étages)
        {
            _height=3*étages;
            _étages=étages;
        }

        public double GetSize()
        {
            return _height;
        }
        public double GetFloorMaxSize()
        {
            return _height / _étages;
        }
        public int GetFloorCount()
        {
            return _étages;
        }
    }
}
