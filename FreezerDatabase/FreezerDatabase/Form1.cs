using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FreezerDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveRecord_Click(object sender, EventArgs e)
        {
            string connectionString = null;
            connectionString = @"Data Source=LAPTOP-P8FVG6F4\SQLEXPRESS;Initial Catalog=FreezerDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            cmd.CommandText = ("INSERT into Stock VALUES(@itemName,@useBy,@additionalNotes,@locationDescription)");
            cmd.Parameters.AddWithValue("@itemName", itemName.Text);
            cmd.Parameters.AddWithValue("@useBy", useBy.Value);
            cmd.Parameters.AddWithValue("@additionalNotes", additionalNotes.Text);
            cmd.Parameters.AddWithValue("@locationDescription", locationDescription.Text);
            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("The item was added ! ");
                cnn.Close();
                itemName.Text = "";
                additionalNotes.Text = "";
                locationDescription.Text = "";
                useBy.Value = DateTime.Today;
                itemName.Focus();
                this.stockTableAdapter.Fill(this.freezerDatabaseDataSet.Stock);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection ! ");
            }

        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            if (sortExpiryDate.Checked == true)
            {
                this.dataGridView1.Sort(this.dataGridView1.Columns[2], ListSortDirection.Ascending); //sort by expiry date (closest expiry date first)
            }
            else
            {
                this.dataGridView1.Sort(this.dataGridView1.Columns[0], ListSortDirection.Ascending); //sort by ID (also identical to input order)
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'freezerDatabaseDataSet.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.freezerDatabaseDataSet.Stock);

        }

        private void sortExpiryDate_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
