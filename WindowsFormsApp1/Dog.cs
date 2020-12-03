using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalForm
{
    class Dog : Animal
    {
        public Dog(string name, int age) : base()
        {
            /*initiera attributen i objektet*/

            SetSpecies(SPECIES.DOG); // CAT=0, DOG=1, BIRD=2
            SetCanFly(false);
            SetName(name);
            SetAge(age);
        }

        public override void IntroduceYourself()
        {
            Console.WriteLine("Vov. Jag är en hund som heter " + GetName());
            base.IntroduceYourself();
        }
    }
}
