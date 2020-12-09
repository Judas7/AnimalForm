using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalForm
{
    public partial class Form1 : Form
    {

        private List<Animal> animals = new List<Animal>();

        public Form1()
        {
            InitializeComponent();

            Console.SetConsole(rtbConsole);

            Animal.SetYear(2019); // Så här anropar man en klassmetod, 
            // dvs en statisk metod. 
            // Hur ska koden för setYear se ut? 

            Animal kurre = new Cat("Kurre", 6);
            Animal vilma = new Dog("Vilma", 3);



            kurre.IntroduceYourself();
            vilma.IntroduceYourself();

            Animal.SetYear(2020); // Nu blir är ett nytt år för alla djur. 

            kurre.IntroduceYourself();
            vilma.IntroduceYourself();

            Animal.SetYear(2030); // Nu blir är ett nytt år för alla djur. 

            kurre.IntroduceYourself();
            vilma.IntroduceYourself();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
