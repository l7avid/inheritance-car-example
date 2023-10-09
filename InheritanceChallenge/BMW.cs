using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge
{
    internal class BMW : Car
    {
        public string Model { get; set; }
        private string Brand = "BMW";
        public BMW(int hp, string color, string model) : base(hp, color)
        {
            this.Model = model;
        }

        public override void ShowDetails()
        {
            Console.WriteLine($"The car {Brand} model {Model} color {Color} has {Hp}hp");
        }

        public override void Repair()
        {
            Console.WriteLine($"{Brand} was repaired!");
        }
    }
}
