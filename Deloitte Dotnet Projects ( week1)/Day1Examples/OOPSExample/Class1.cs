using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExample
{
    class Bird : IFlying
    {
        public void fly()
        {
            Console.WriteLine(" Flap Flap Flap ");
        }
    }
    class Kite : IFlying
    {
        public void fly()
        {
            Console.WriteLine("Flies colourfully with tail adn thread ");
             
        }
    }

    class Plane : IFlying, IPassengerInfo
    {
        public void fly()
        {
            Console.WriteLine("UP UP in the sky");
        }

        public void PrintTicket()
        {
            Console.WriteLine("  name : Nikhil ");
            Console.WriteLine(" Source : Bangalore ");
            Console.WriteLine(" Destination : South Africa ");
        }
    }

}
