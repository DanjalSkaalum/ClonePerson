using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClonePerson
{
    internal class Person : ICloneable
    {
        private string _name;
        private int _height;
        private int _weight;
        public string Name { get; set;}
        public int Height { get; set; }
        public int Weight { get; set; }

        public Person()
        {
            
        }

        public override string ToString()
        {
            return $"Name: {Name}\nHeight: {Height}\nWeight: {Weight}\n";
        }

        public object Clone()
        {

            return MemberwiseClone();
        }
    }
}
