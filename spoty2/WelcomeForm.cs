using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spoty2
{
    public partial class WelcomeForm : Form
    {

        private const string FileName = "data.txt";

        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void Authentication1()
        {
            
            {
                if (usernamebox.Text != "" && passbox.Text != "")
                {
                    CheckAccessRight();
                }
                else
                {
                    MessageBox.Show("Необходимо заполнить все поля авторизации.");
                }
            }
        }

        private void CheckAccessRight()
        {
            Authority NewAuthority = new Authority(FileName, usernamebox.Text, passbox.Text);

            var X = NewAuthority.IncorrectInput();

            if (X.Count() != 0)
            {
                foreach (var Row in X)
                {
                    if (Row.Role == 1)
                    {
                        this.Hide();
                        AdminMain mainForm = new AdminMain();
                        mainForm.Show();
                    }
                    else
                    {
                        this.Hide();
                        UserMain mainForm = new UserMain();
                        mainForm.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль. Повторите вход.");
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Authentication1();
        }



       

        private void newlabel_Click(object sender, EventArgs e)
        {
            RegistrationForm redform = new RegistrationForm();
            redform.Show();
        }

        public class Authority
        {
            private readonly string _FileName;

            private readonly string _Login;

            private readonly string _Password;

            public Authority(string FileName, string Login, string Password)
            {
                this._FileName = FileName;

                this._Login = Login;

                this._Password = Password;
            }




            public List<Authentication> IncorrectInput()
            {
                string[] Data = File.ReadAllLines(_FileName);

                List<Authentication> Lst = new List<Authentication>();

                for (int i = 0; i < Data.Length; i++)
                {
                    Authentication Auth = new Authentication();

                    string[] Row = Data[i].Split(';');

                    Auth.User = Row[0];

                    Auth.Password = Row[1];

                    Auth.Role = Convert.ToInt32(Row[2]);

                    Lst.Add(Auth);
                }

                return Lst.Where(w => w.User == _Login && w.Password == _Password).ToList();
            }
        }

        public struct Authentication
        {
            public string User { get; set; }

            public string Password { get; set; }

            public int Role { get; set; }
        }
        



        
    }
}
