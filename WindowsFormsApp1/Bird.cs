using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalForm
{
    class Bird : Animal
    {

        public Bird(string name, int age) : base()
        {
            /*initiera attributen i objektet*/
            SetSpecies(SPECIES.BIRD); // CAT=0, DOG=1, BIRD=2
            SetCanFly(true);
            SetName(name);
            SetAge(age);
        }

        public override void IntroduceYourself()
        {
            Console.WriteLine("Piip. Jag är en fågel som heter " + GetName());
            base.IntroduceYourself();
        }
    }
}
