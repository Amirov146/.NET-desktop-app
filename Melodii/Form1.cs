using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Melodii
{
    public partial class Form1 : Form
    {
        Thread Thread;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread = new Thread(open);
            Thread.SetApartmentState(ApartmentState.STA);
            Thread.Start();
        }

        private void open(object obj)
        {
            Application.Run(new Form2());
        }
        private void open2(object obj)
        {
            Application.Run(new Start());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread = new Thread(open2);
            Thread.SetApartmentState(ApartmentState.STA);
            Thread.Start();
        }
    }
}
