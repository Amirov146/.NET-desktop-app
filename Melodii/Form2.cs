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
using System.Data.SqlClient;

namespace Melodii
{
    public partial class Form2 : Form
    {
        String con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Melodii_13\Melodii\melodii.mdf;Integrated Security=True";
        Thread Thread;
        public Form2()
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
            Application.Run(new Form1());
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'melodiiDataSet.Melodii' table. You can move, or remove it, as needed.
            this.melodiiTableAdapter.Fill(this.melodiiDataSet.Melodii);
            MaximizeBox = false;
            MinimizeBox = false;
            dataGridView1.Hide();
        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
           
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Melodii", con);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT ID_Intervievat,Nume,Puncte,ID_Melodie FROM Intervievati", con);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String command = "DELETE FROM TOP5_Intervievati; " +
                "INSERT INTO TOP5_Intervievati " +
                "SELECT TOP 5 Nume,Puncte FROM Intervievati ORDER BY Puncte DESC";
            SqlConnection sc = new SqlConnection(con);
            SqlCommand com = new SqlCommand(command);
            sc.Open();

            com.Connection = sc;
            com.ExecuteNonQuery();

            dataGridView1.Show();
            String query = "SELECT * FROM TOP5_Intervievati";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

            sc.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            String command = "DELETE FROM TOP3_Melodii; " +
                "INSERT INTO TOP3_Melodii " +
                "SELECT TOP 3 Nume,Puncte FROM Melodii ORDER BY Puncte DESC";
            SqlConnection sc = new SqlConnection(con);
            SqlCommand com = new SqlCommand(command);
            sc.Open();

            com.Connection = sc;
            com.ExecuteNonQuery();

            dataGridView1.Show();
            String query = "SELECT * FROM TOP3_Melodii";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

            sc.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();
            String query = "SELECT TOP 10 ID_Intervievat,Nume,Puncte,ID_Melodie FROM Intervievati " +
                "ORDER BY Puncte DESC";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.ShowDialog();
        }
    }
}
