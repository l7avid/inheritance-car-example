using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge
{
    internal class Car
    {
        public int Hp { get; set; }
        public string Color { get; set; }

        public Car(int hp, string color)
        { 
            this.Hp = hp;
            this.Color = color;
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine($"The car {Color} has {Hp}hp");
        }

        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired!");
        }
    }
}
