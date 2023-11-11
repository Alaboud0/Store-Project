using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        MySqlConnection con = new MySqlConnection(
     "server = localhost; userid = root; password = ; database = project"
     );
        int stoke;
        String store_in;
        int product_id;
        String count;
        public Form3()
        {
            InitializeComponent();
            show_where_house();
            show_all_items();
        }
        private void find_count(String quaary)
        {

            con.Open();
            MySqlCommand cmd = new MySqlCommand(quaary, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                count = dr.GetString(0);
            }
            con.Close();
            count_label.Text = count;
        }
        private void show_all_items()
        {
            con.Open();
            String quary = "select id from item ";
            MySqlCommand cmd = new MySqlCommand(quary, con);
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string item = reader.GetString("id");
                item_id_textBox.Items.Add(item);

            }
            con.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void show_where_house()
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
        private void show_data()
        {
            string quri = "select * from kargo_order where 	id_customer = '"+customer_id_textBox.Text+"' ";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(quri, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            show_data_box.DataSource = dt;
            con.Close();
            String quary_count = "select count(id_order) from kargo_order where id_customer = '" + customer_id_textBox.Text + "'";
            find_count(quary_count);
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string qur0 = "select * From item where id  = '" + item_id_textBox.SelectedItem + "'";
            MySqlCommand cmd0 = new MySqlCommand(qur0, con);
            MySqlDataReader dr = cmd0.ExecuteReader();
            while (dr.Read())
            {
                product_id = Convert.ToInt32(dr.GetString(0));
                stoke = Convert.ToInt32(dr.GetString(2));
                store_in = dr.GetString(3);
            }
            con.Close();
            int m = Convert.ToInt32(amount_textBox.Text);
            if (m <= stoke)
            {
                con.Open();
                int id = Convert.ToInt32(item_id_textBox.Text);
                int d = Convert.ToInt32(amount_textBox.Text);
                DateTime currentDate = DateTime.Now;
                string formattedDate = currentDate.ToString("yyyy-MM-dd");
                string qur = "INSERT INTO `kargo_order`(`date`, `quantities`, `id_customer`, `center_addres`, `id_item`, `status`,`ship_to`) VALUES ('" + formattedDate + "','" + stoke + "','" + customer_id_textBox.Text + "','" + store_in + "','" + product_id + "','waiting','"+ship_to_textBox.Text+"')";
                MessageBox.Show("your order hase been sent wait to be accepted");
                MySqlCommand cmd1 = new MySqlCommand(qur, con);
                cmd1.ExecuteNonQuery();
                con.Close();
                show_data();
                

            }
            else
            {
                MessageBox.Show("can't get a ITEM becous there isn't any more '" + stoke + "' ");
            }
            con.Close();
        }

        private void address_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            show_data();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
