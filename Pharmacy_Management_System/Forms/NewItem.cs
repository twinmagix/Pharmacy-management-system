using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy_Management_System.Windows
{
    public partial class NewItem : Form
    {
        public NewItem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text)|| string.IsNullOrWhiteSpace(textBox3.Text)|| string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("One or more of the fields is empty!");
            }
            else if(string.IsNullOrWhiteSpace(textBox2.Text))
            {
                String ConnectionString = "Data Source=Server=LEARNERAIO11;Database=DB_SAF.mdf;Trusted_Connection=True;Column Encryption Setting=Enabled;MultipleActiveResultSets=True;Persist Security Info=True;Encrypt=True;TrustServerCertificate=True;";
                String sql = "insert into Catalogue (item, stock, price) values ('" + textBox1.Text + "', " + textBox3.Text + "," + textBox4.Text + ")";
                SqlConnection conn = new SqlConnection(ConnectionString);
                SqlCommand sqlCmd = new SqlCommand(sql, conn);

                //DataTable dt = new DataTable();

                sqlCmd.Connection.Open();
                sqlCmd.ExecuteNonQuery();
                sqlCmd.Dispose();
                //dataGridView1.DataSource = dt;
                sqlCmd.Connection.Close();
                conn.Close();
                MessageBox.Show("Successfully inserted new data!");
                this.Dispose();
            }
            else
            {
                String ConnectionString = "Data Source=Server=LEARNERAIO11;Database=DB_SAF.mdf;Trusted_Connection=True;Column Encryption Setting=Enabled;MultipleActiveResultSets=True;Persist Security Info=True;Encrypt=True;TrustServerCertificate=True;";
                String sql = "insert into Catalogue (item, details, stock, price) values ('" + textBox1.Text + "', '" + textBox2.Text + "'," + textBox3.Text + "," + textBox4.Text + ")";
                SqlConnection conn = new SqlConnection(ConnectionString);
                SqlCommand sqlCmd = new SqlCommand(sql, conn);

                //DataTable dt = new DataTable();

                sqlCmd.Connection.Open();
                sqlCmd.ExecuteNonQuery();
                sqlCmd.Dispose();
                //dataGridView1.DataSource = dt;
                sqlCmd.Connection.Close();
                conn.Close();
                MessageBox.Show("Successfully inserted new data!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
