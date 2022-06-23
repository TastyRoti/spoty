using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace spoty2
{
    public partial class RegistrationForm : Form
    {

        string login;
        string password;
        string res;
        int role;

        public RegistrationForm()
        {
            InitializeComponent();
        }

       

        private void LogBox_TextChanged(object sender, EventArgs e)
        {
            login = LogBox.Text;
        }

        private void PassBox_TextChanged(object sender, EventArgs e)
        {
            password = PassBox.Text;

        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            res = login + ";" + password + ";" + role + Environment.NewLine;
            File.AppendAllText("data.txt", res);
            this.Hide();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox1.SelectedIndex == 0)
            {
                role = 1;

            }
            else
            {
                role = 0;
            }
        }
    }
}
