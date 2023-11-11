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
using MySql.Data.MySqlClient;
namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {

        MySqlConnection con = new MySqlConnection(
       "server = localhost; userid = root; password = ; database = project"
       );
        int order_id;
        public Form2()
        {
            InitializeComponent();
            show_where_house();
        }

        
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            con.Open();
            string qur = "INSERT INTO `item`(`id`, `iteamName`, `stock`, `adrress`, `note`, `dateAdd`) VALUES ('" + ID.Text+"','"+item_name_textBox.Text+ "', " + item_stok_numericUpDown.Text + ", '"+ address_combobox.SelectedItem+ "', '"+note_textbox.Text+ "','"+dateTimePicker1.Value+"')";

            MySqlCommand cmd = new MySqlCommand(qur, con);
            cmd.ExecuteNonQuery();
           
            con.Close();
            MessageBox.Show("item have been inserted");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void note_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void show_where_house ()
        {
            string quri = "select adrress from center ";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(quri, con);
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string address = reader.GetString("adrress");
                address_combobox.Items.Add(address);

            }
            con.Close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}



   
   
