using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Melodii
{
    public partial class Start : Form
    {
        Thread Thread;
        public Start()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            MinimizeBox = false;
            MaximizeBox= false;
        }

        public void open()
        {
            Application.Run(new Admin());
        }
        public void open2()
        {
            Application.Run(new User());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread = new Thread(open);
            Thread.SetApartmentState(ApartmentState.STA);
            Thread.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread = new Thread(open2);
            Thread.SetApartmentState(ApartmentState.STA);
            Thread.Start();
        }
    }
}
