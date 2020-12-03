using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalForm
{
    class Animal
    {
        public enum SPECIES { CAT, DOG, BIRD };

        // Detta är instansvariablerna (ej static)
        private string name;
        private SPECIES species;
        private bool canFly;

        private int birthYear;

        //Detta är vår klassvariabel (static)
        private static int currentYear = 2020;


        public Animal()
        {

        }

        public void SetAge(int age)
        {
            birthYear = currentYear - age;
        }

        public int GetAge()
        {
            int age = currentYear - birthYear;
            return age;
        }


        public static void SetYear(int year)
        {
            currentYear = year;
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }

        public SPECIES GetSpecies()
        {
            return species;
        }

        public void SetSpecies(SPECIES species)
        {
            this.species = species;
        }

        public bool GetCanFly()
        {
            return canFly;
        }

        public void SetCanFly(bool canFly)
        {
            this.canFly = canFly;
        }

        public virtual void IntroduceYourself()
        {
            if (canFly == true)
            {
                Console.WriteLine("I can fly!");
            }
            else
            {
                Console.WriteLine("No can do... I cannot fly...  :-( ");
            }
            Console.WriteLine("My species is a :" + species);
            Console.WriteLine("I am " + GetAge() + " years old");
        }
    }
}


