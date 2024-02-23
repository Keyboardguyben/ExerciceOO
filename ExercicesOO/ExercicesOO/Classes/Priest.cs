using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicesOO.Classes
{
    internal class Priest
    {
        private string _name;
        public string CharacterName
        {
            get { return _name; }
            set { _name = value; }
        }

        public int _strength;
        public int Strength
        {
            get { return _strength; }
            set { Console.WriteLine("Error"); }
        }

        public int _stamina;
        public int Stamina
        {
            get { return _stamina; }
            set { Console.WriteLine("Error"); }
        }

        public int _intelligence;
        public int Intelligence
        {
            get { return _intelligence + 2; }
            set { Console.WriteLine("Error"); }
        }

        public int _wisdom;
        public int Wisdom
        {
            get { return _wisdom + 4; }
            set { Console.WriteLine("Error"); }
        }

        public void FillCar()
        {
            _strength = new Random().Next(10, 21);
            _stamina = new Random().Next(10, 21);
            _intelligence = new Random().Next(10, 21);
            _wisdom = new Random().Next(10, 21);
        }

        public void Showstats()
        {
            Console.WriteLine("Nom       : " + CharacterName);
            Console.WriteLine("Force     : " + Strength);
            Console.WriteLine("Endurance : " + Stamina);
            Console.WriteLine("Intellect : " + Intelligence);
            Console.WriteLine("Sagesse   : " + Wisdom);
        }
    }
}
