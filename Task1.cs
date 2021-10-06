using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Fish
    {
        public int size;
        public string color;
        public double weight;
        public Fish(int size, double weight, string color)
        {
            this.size = size;
            this.weight = weight;
            this.color = color;
        }
        public virtual void GetFish()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(size);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(weight);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(color);
        }
    }
    class Piranha : Fish
    {
        public string name;
        public Piranha(int size, double weight, string color, string name) : base(size, weight, color)
        {
            this.name = name;
        }
        public override void GetFish()
        {
            base.GetFish();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(name);
        }
    }
}
