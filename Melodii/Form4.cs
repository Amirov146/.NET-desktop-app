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
    public partial class Form4 : Form
    {
        String connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Melodii_13\Melodii\melodii.mdf;Integrated Security=True";
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;

            string Sql = "SELECT Nume FROM Melodii";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(Sql, conn);
            SqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                comboBox1.Items.Add(DR[0]);
            }

             
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
                com.CommandText = "INSERT INTO Intervievati VALUES(@nume,@puncte,@id_melodie,@datan)";
                com.Parameters.AddWithValue("@nume", textBox2.Text);
                com.Parameters.AddWithValue("@puncte", Int32.Parse(comboBox2.SelectedItem.ToString()));
                com.Parameters.AddWithValue("@id_melodie", Int32.Parse(label5.Text));
                com.Parameters.AddWithValue("@datan",DateTime.Parse(textBox1.Text));


                com.ExecuteNonQuery();
                MessageBox.Show("Intervievatul a fost adaugat!");
                textBox2.Text = "";
                comboBox2.Text = "";
                comboBox1.Text = "";
                label5.Text = "";
                textBox1.Text = "";
            }
            catch
            {
                MessageBox.Show("Ati introdus datele incorect!");
                textBox2.Text = "";
                comboBox2.Text = "";
                comboBox1.Text = "";
                label5.Text = "";
                textBox1.Text = "";
            }
            
            sc.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString);
            String Sql2 = "Select * FROM Melodii WHERE Nume = '" + comboBox1.SelectedItem.ToString() + "'";
            conn.Open();
            SqlCommand com = new SqlCommand(Sql2, conn);
            SqlDataReader reader = com.ExecuteReader();
            reader.Read();
            label5.Text = reader["ID_Melodie"].ToString();
            reader.Close();
            conn.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
