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

        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1224, 720);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1248, 731);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        private RichTextBox richTextBox1;
    }
}
