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
    public partial class Form8 : Form
    {
        String connstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Melodii_13\Melodii\melodii.mdf;Integrated Security=True";
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            MinimizeBox = false;
            MaximizeBox = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection();
            sc.ConnectionString = connstring;
            SqlCommand com = new SqlCommand();
            sc.Open();

                com.Connection = sc;

            try
            {
                com.CommandText = "UPDATE Melodii " +
            "SET Puncte = Puncte +'" + Int32.Parse(comboBox1.SelectedItem.ToString()) + "' WHERE ID_Melodie " +
            "= '" + Int32.Parse(textBox2.Text) + "'";

                com.ExecuteNonQuery();
                MessageBox.Show("Punctele au fost adaugate!");
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
    }
}
