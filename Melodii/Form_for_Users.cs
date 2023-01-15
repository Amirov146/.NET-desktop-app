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
    public partial class Form_for_Users : Form
    {
        Thread Thread;
        public Form_for_Users()
        {
            InitializeComponent();
        }

        private void Form_for_Users_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'melodiiDataSet2.Intervievati' table. You can move, or remove it, as needed.
            this.IntervievatiTableAdapter.Fill(this.melodiiDataSet2.Intervievati);
            // TODO: This line of code loads data into the 'melodiiDataSet1.Melodii' table. You can move, or remove it, as needed.
            this.MelodiiTableAdapter.Fill(this.melodiiDataSet1.Melodii);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            MinimizeBox = false;
            MaximizeBox = false;
            this.reportViewer2.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        public void open()
        {
            Application.Run(new Start());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread = new Thread(open);
            Thread.SetApartmentState(ApartmentState.STA);
            Thread.Start();
        }
    }
}
