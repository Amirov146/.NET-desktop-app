using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Melodii
{
    public partial class Form5 : Form
    {
        String connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Melodii_13\Melodii\melodii.mdf;Integrated Security=True";
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            MinimizeBox = false;
            MaximizeBox = false;
            
        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection(connString);
            SqlCommand com = new SqlCommand();
            sc.Open();

            try
            {
                com.Connection = sc;
                com.CommandText = "DELETE FROM Melodii WHERE ID_Melodie = '" + Int32.Parse(textBox1.Text) + "'";

                com.ExecuteNonQuery();
                MessageBox.Show("Melodia a fost exclusa!");
                textBox1.Text = "";
            }
            catch
            {
                MessageBox.Show("Ati introdus datele incorect / cheia straina apartine Intervievatului");
                textBox1.Text = "";
            }
            sc.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
