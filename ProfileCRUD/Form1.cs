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

namespace ProfileCRUD
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Authenticate;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"); 
        public Form1()
        {
            InitializeComponent();
        }

        public void display_data() { 
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [ProfDetails]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dta);
            dataGrid_DispRec.DataSource = dta;
            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void btn_insert_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand sqcmd = new SqlCommand("select * from [ProfDetails] where RegID='"+txt_reg.Text+"'", conn);

            SqlDataAdapter da = new SqlDataAdapter(sqcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                conn.Close();
                MessageBox.Show("Reg ID Already Exists!");
            }
            else {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"insert into [ProfDetails] (RegID, FirstName, LastName, Address) values ({txt_reg.Text}, {txt_firstName.Text}, {txt_lastName.Text}, {txt_address.Text})";

                cmd.ExecuteNonQuery();
                conn.Close();

                txt_reg.Text = "";
                txt_firstName.Text = "";
                txt_lastName.Text = "";
                txt_address.Text = "";
                display_data();

                MessageBox.Show("Record inserted");

                conn.Close();
            }
        }

        private void dataGrid_DispRec_CellContentClick(object sender, DataGridViewCellEventArgs e) { 
            int myIndex = e.RowIndex;

            DataGridViewRow row = dataGrid_DispRec.Rows[myIndex];

            string reg = row.Cells[0].Value.ToString();
            string value1 = row.Cells[1].Value.ToString();
            string value2 = row.Cells[2].Value.ToString();
            string value3 = row.Cells[3].Value.ToString();

            txt_reg.Enabled = false;

            txt_firstName.Text = value1;
            txt_lastName.Text = value2;
            txt_address.Text = value3;

            btn_insert.Enabled = false;
            btn_delete.Enabled = true;
            btn_update.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'authenticateDataSet.ProfDetails' table. You can move, or remove it, as needed.
            this.profDetailsTableAdapter.Fill(this.authenticateDataSet.ProfDetails);

        }

        private void btn_displayAll_Click(object sender, EventArgs e)
        {
            display_data();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update [ProfDetails] set FirstName={txt_firstName.Text}, LastName={txt_lastName.Text}, Address={txt_address.Text} where RegID={txt_reg.Text}";

            cmd.ExecuteNonQuery();
            conn.Close();
            display_data();

            txt_reg.Text = "";
            txt_firstName.Text = "";
            txt_lastName.Text = "";
            txt_address.Text = "";

            btn_insert.Enabled = true;
            btn_delete.Enabled = false;
            btn_update.Enabled = false;

            txt_reg.Enabled = true;

            MessageBox.Show("Data Updated!");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = $"delete from [ProfDetails] where RegID={txt_reg.Text}";
            cmd.ExecuteNonQuery();
            conn.Close();
            display_data();

            txt_reg.Text = "";
            txt_firstName.Text = "";
            txt_lastName.Text = "";
            txt_address.Text = "";

            btn_insert.Enabled = true;
            btn_delete.Enabled = false;
            btn_update.Enabled = false;

            txt_reg.Enabled = true;

            MessageBox.Show("Data Deleted!");
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            conn.Close();

            txt_reg.Text = "";
            txt_firstName.Text = "";
            txt_lastName.Text = "";
            txt_address.Text = "";

            btn_insert.Enabled = true;
            btn_delete.Enabled = false;
            btn_update.Enabled = false;

            txt_reg.Enabled = true;

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            conn.Open();
            string search = txt_search.Text;
            SqlCommand sqcmd = new SqlCommand($"select * from [ProfDetails] where FirstName LIKE '%{search}%' OR LastName LIKE '%{search}%' OR Address LIKE '%{search}%';", conn);

            SqlDataAdapter da = new SqlDataAdapter(sqcmd);
            DataTable dt = new DataTable();
            da.Fill( dt );

            if (dt.Rows.Count > 0)
            {
                dataGrid_DispRec.DataSource = dt;
                conn.Close();
            }
            else {
                MessageBox.Show("No record(s) found");
                conn.Close();
            }
        }
    }
}
