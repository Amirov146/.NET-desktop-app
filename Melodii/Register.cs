using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Melodii
{
    public partial class Register : Form
    {
        String connstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Melodii_13\Melodii\melodii.mdf;Integrated Security=True";
        Thread Thread;
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            MinimizeBox = false;
            MaximizeBox = false;
        }

        public void open()
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

        public static string EncodePasswordToBase64(string password)
        {
            try
            {
                byte[] encData_byte = new byte[password.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(password);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in base64Encode" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(connstring);
            cn.Open();
            if (textBox1.Text != string.Empty || textBox2.Text != string.Empty || textBox1.Text != string.Empty)
            {
                if (textBox2.Text == textBox3.Text)
                {
                    SqlCommand cmd = new SqlCommand("select * from Users where Login='" + textBox1.Text + "'", cn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Login-ul deja exista. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("insert into Users values(@login,@password)", cn);
                        cmd.Parameters.AddWithValue("login", textBox1.Text);
                        cmd.Parameters.AddWithValue("password", EncodePasswordToBase64(textBox2.Text));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Account-ul este creat. Logheaza-te.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Introduceti a doua parola ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Introduceti valoarea.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
