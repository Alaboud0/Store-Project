using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection(
      "server = localhost; userid = root; password = ; database = project"
      );
        String product_id = "";
        int stoke;
        String store_in = "";
        int id_order;
        String count;
        String quaary = "select count(id_order) from kargo_order";
        public Form1()
        {
            InitializeComponent();
            show_req();
            find_count(quaary);
        }
        
        private void find_count(String quaary)
        {

            con.Open();
            MySqlCommand cmd = new MySqlCommand(quaary,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                count = dr.GetString(0);
            }
            con.Close();
            count_label.Text = count;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

      
            

        

        private void ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void show_req()
        {
            con.Open();
            String quary = "select * from kargo_order";
            MySqlCommand cmd = new MySqlCommand(quary, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            show_requst.DataSource = dt;
            con.Close();
            if (status.Items.Count == 0)
            {
                status.Items.Add("approved");
                status.Items.Add("declined");
            }
                
        }
        private void show_requst_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.show_requst.Rows[e.RowIndex];
                id_order = Convert.ToInt32(row.Cells["id_order"].Value.ToString());
                status.Text = row.Cells["status"].Value.ToString();
                MessageBox.Show("there is ");
            }
            
        }

        internal class sqlConneet
        {
            private string v;

            public sqlConneet(string v)
            {
                this.v = v;
            }
        }

        internal class sqlConnection
        {
            public sqlConnection()
            {
            }

            public sqlConnection(string v)
            {
            }

            internal void open()
            {
                throw new NotImplementedException();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            con.Open();
            string qur = "UPDATE kargo_order SET `status` = '"+ status.SelectedItem + "', `estimated_departure` ='"+dateTimePicker2.Value+ "', `estimated_arrival` = '"+dateTimePicker1.Value+ "',	kargo_volume = '"+volume_textBox.Text+ "', kargo_weight = '"+weight_textBox.Text+"'  WHERE id_order = '" + id_order+"' ; ";
            MySqlCommand sss = new MySqlCommand(qur , con);
            int i = sss.ExecuteNonQuery();
            if (i > 0)
            { MessageBox.Show("Order has been updated"); }
            con.Close();
            show_req();
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            String quary = "select * from kargo_order where id_item = '"+filter_item_textBox.Text+"'";
            MySqlCommand cmd = new MySqlCommand(quary, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            show_requst.DataSource = dt;
            con.Close();
            String quary_count = "select count(id_order) from kargo_order where id_item = '" + filter_item_textBox.Text + "'";
            find_count(quary_count);


        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            String quary = "select * from kargo_order where status = '" + filter_status_textBox.Text+ "'";
            MySqlCommand cmd = new MySqlCommand(quary, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            show_requst.DataSource = dt;
            con.Close();
            String quary_count = "select count(id_order) from kargo_order where status = '" + filter_status_textBox.Text + "'";
            find_count(quary_count);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void status_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void status_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
