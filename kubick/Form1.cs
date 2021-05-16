using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kubick
{
    public partial class Form1 : Form
    {
        public List<Double> elements = new List<Double>();
        public Random rand = new Random();
        public const double cheat_coefficient = 1.2;
        public Form1()
        {
            InitializeComponent();
        }

        private int ArrayNumber(Double k)
        {
            int counter = 0;
            while (true)
            {
                k -= elements[counter];
                if (k < 0)
                    break;
                counter++;
            }
            return counter;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            elements.Clear();
            int count = (int)numericUpDown1.Value;
            Double cheat = 1;
            for (int i = 1; i <= count; i++)
            {
                elements.Add(i * cheat);
                cheat *= cheat_coefficient;                   
            }

            var index = ArrayNumber(rand.Next(0, (int)elements[elements.Count() - 1]));
            label1.Text = $"Result: {index+1}";
        }
    }
}
