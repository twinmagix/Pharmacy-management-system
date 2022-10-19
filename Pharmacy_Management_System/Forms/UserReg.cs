﻿using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pharmacy_Management_System.Windows
{
    public partial class UserReg : Form
    {
        public UserReg()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox5.Visible == true && textBox6.Visible == true)
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox6.Text))
                {
                    MessageBox.Show("One or more of the fields is empty!");
                }
                else
                {
                    if (textBox5.Text != textBox6.Text)
                    {
                        MessageBox.Show("The passwords do not match!");
                    }
                    else
                    {
                        String ConnectionString = "Data Source=Server=LEARNERAIO11;Database=DB_SAF.mdf;Trusted_Connection=True;Column Encryption Setting=Enabled;MultipleActiveResultSets=True;Persist Security Info=True;Encrypt=True;TrustServerCertificate=True;";
                        String sql = "insert into UserLogIn (password, name, designation, email, administration, phone) values ('" + textBox6.Text + "', '" + textBox1.Text + "','" + textBox2.Text + "', '" + textBox3.Text + "', 'n', '" + textBox4.Text + "')";
                        SqlConnection conn = new SqlConnection(ConnectionString);
                        SqlCommand sqlCmd = new SqlCommand(sql, conn);

                        sqlCmd.Connection.Open();
                        sqlCmd.ExecuteNonQuery();
                        sqlCmd.Dispose();
                        sqlCmd.Connection.Close();
                        conn.Close();
                        MessageBox.Show("Successfully added new user!");
                    }
                }
            }
            else if (textBox5.Visible == false && textBox6.Visible == false)
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox6.Text))
                {
                    MessageBox.Show("One or more of the fields is empty!");
                }
                else
                {
                    if (textBox5.Text != textBox6.Text)
                    {
                        MessageBox.Show("The passwords do not match!");
                    }
                    else
                    {
                        String ConnectionString = "Data Source = Server = LEARNERAIO11; Database = DB_SAF.mdf; Trusted_Connection = True; Column Encryption Setting = Enabled; MultipleActiveResultSets = True; Persist Security Info = True; Encrypt = True; TrustServerCertificate = True; ";
                        String sql = "update UserLogIn set name = '"+textBox1.Text+"', designation = '"+textBox2.Text+"', email = '" + textBox3.Text +"', phone = '"+textBox4.Text+"' where id = "+privateID;
                        SqlConnection conn = new SqlConnection(ConnectionString);
                        SqlCommand sqlCmd = new SqlCommand(sql, conn);

                        sqlCmd.Connection.Open();
                        sqlCmd.ExecuteNonQuery();
                        sqlCmd.Dispose();
                        sqlCmd.Connection.Close();
                        conn.Close();
                        MessageBox.Show("Successfully updated user's info!");
                    }
                }
            }
        }

        private void UserReg_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
