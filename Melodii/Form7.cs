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
    public partial class Form7 : Form
    {
        String con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Melodii_13\Melodii\melodii.mdf;Integrated Security=True";
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            MinimizeBox = false;
            MaximizeBox = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection(con);
            SqlCommand com = new SqlCommand();
            sc.Open();

            try
            {
                com.Connection = sc;
                com.CommandText = "DELETE FROM Intervievati WHERE ID_Intervievat = '" + textBox1.Text + "'";

                com.ExecuteNonQuery();
                MessageBox.Show("Intervievatul a fost exclus!");
                textBox1.Text = "";
            }
            catch
            {
                MessageBox.Show("Ati introdus datele incorect!");
                textBox1.Text = "";
            }
            sc.Close();
        }
    }
}
