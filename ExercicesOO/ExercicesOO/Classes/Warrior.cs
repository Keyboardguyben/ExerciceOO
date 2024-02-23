using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicesOO.Classes
{
    public class Warrior
    {
        private string _name;
        public string CharacterName 
        {
            get { return _name ;}
            set { _name = value ; }
        }

        public int _strength;
        public int Strength 
        {
            get { return _strength + 3; }
            set { Console.WriteLine("Error"); }
        }

        public int _stamina;
        public int Stamina
        {
            get { return _stamina + 3; }
            set { Console.WriteLine("Error"); }
        }

        public int _intelligence;
        public int Intelligence
        {
            get { return _intelligence ; }
            set { Console.WriteLine("Error"); }
        }

        public int _wisdom;
        public int Wisdom
        {
            get { return _wisdom; }
            set { Console.WriteLine("Error"); }
        }

        public void FillCar() 
        {
            _strength = new Random().Next(10,20);
            _stamina = new Random().Next(10, 20);
            _intelligence = new Random().Next(10, 20);
            _wisdom = new Random().Next(10, 20);
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
