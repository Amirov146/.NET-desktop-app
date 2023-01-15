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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection();
            sc.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Melodii_13\Melodii\melodii.mdf;Integrated Security=True";
            SqlCommand com = new SqlCommand();
            sc.Open();

            try
            {
                com.Connection = sc;
                com.CommandText = "INSERT INTO Melodii VALUES(@nume,@puncte)";
                com.Parameters.AddWithValue("@nume", textBox2.Text);
                com.Parameters.AddWithValue("@puncte", Int32.Parse(comboBox1.SelectedItem.ToString()));

                com.ExecuteNonQuery();
                MessageBox.Show("Melodia a fost adaugata!");
                textBox2.Text = "";
                comboBox1.Text = "";
            }
            catch
            {
                MessageBox.Show("Ati introdus datele incorect!");
                textBox2.Text = "";
                comboBox1.Text = "";
            }
            sc.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
