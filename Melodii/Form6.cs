using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Melodii
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            MinimizeBox = false;
            MaximizeBox = false;
            label1.Text = "Concursul 'Melodii' este o competiție \n\nanuală " +
                "desfășurată între multe dintre\n țările ale lumii!" +
                "\n\n" + 
                "Participă și tu în acest concurs!";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            this.Close();
        }
    }
}
