﻿using System;
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
    public partial class Admin : Form
    {
        String connstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Melodii_13\Melodii\melodii.mdf;Integrated Security=True";
        Thread Thread;
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            MinimizeBox = false;
            MaximizeBox = false;
        }

        public void open()
        {
            Application.Run(new Start());
        }
        public void open2()
        {
            Application.Run(new Form1());
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
            SqlConnection cn = new SqlConnection(connstring);
            cn.Open();
            if (textBox1.Text != string.Empty || textBox2.Text != string.Empty)
            {

                SqlCommand cmd = new SqlCommand("select * from Admins where Login='" + textBox1.Text + "' and Password='" + textBox2.Text + "'", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Close();
                    Thread = new Thread(open2);
                    Thread.SetApartmentState(ApartmentState.STA);
                    Thread.Start();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("Nu exista Admin cu login si parola introdusa ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cn.Close();
            }
            else
            {
                MessageBox.Show("Introduceti o valoare.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else textBox2.UseSystemPasswordChar = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }
    }
}
