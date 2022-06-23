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
using System.Configuration;

namespace spoty2
{
    public partial class AddForm : Form
    {
        string connectionString = null;
        SqlConnection connection = null;
        SqlCommand com;
        SqlDataAdapter data;
        DataTable dT;
        int LenTable;
        string sql;
        string track_name;
        string track_id;
        int singername;
        int albumname;
        string length;



        public AddForm()
        {

            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            InitializeComponent();


        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            track_name = NameBox.Text;
        }


        


        private void AddLabel_Click(object sender, EventArgs k)
        {



            this.Hide();
            

            sql = "insert into track values('" + track_id + "', '" + track_name + "', '" + singername + "', '" + albumname + "', '1', '2000',  '" + length + "')";

           

            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                com = new SqlCommand(sql, connection);
                data = new SqlDataAdapter(com);
                dT = new DataTable();
                data.Fill(dT);
                LenTable = dT.Rows.Count;
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ComboBox1.SelectedIndex)
            {
                case 0:
                    singername = 3;
                    break;
                case 1:
                    singername = 4;
                    break;
                case 2:
                    singername = 1;
                    break;
                case 3:
                    singername = 2;
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    albumname = 1;
                    break;
                case 1:
                    albumname = 2;
                    break;
                case 2:
                    albumname = 3;
                    break;
                
            }
        }

        private void trackIDbox_TextChanged(object sender, EventArgs e)
        {
            track_id = trackIDbox.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            length = textBox1.Text;
        }
    }
}


