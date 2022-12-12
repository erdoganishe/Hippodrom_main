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

namespace IS_Hyppodrom
{
    public partial class Login : Form
    {
        bool isLogin = true;
        const string ConnectionString = "Data Source=LAPTOP-NBBP6UE1;Initial Catalog = Hyppodrom; Integrated Security = True";

        bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; 
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
        private void login_in_a(bool log)
        {
            if (log)
            {
                SqlConnection sqlcon = new SqlConnection(ConnectionString);
                string login;
                string password;
                login = Login_textbox.Text;
                password = Password_textBox.Text;
                sqlcon.Open();
                string select = $"select user_id from Users where login = '{login}' and password = '{password}'";
                SqlDataAdapter adapter = new SqlDataAdapter(select, sqlcon);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                if (dataSet.Tables[0].Rows.Count == 0)
                {
                    Falsepas.Text = "Wrong login or password";
                }
                else
                {
                    int a = Convert.ToInt32(dataSet.Tables[0].Rows[0][0].ToString());
                    Main_form form = new Main_form(a);
                    this.Hide();
                    form.ShowDialog();
                }
                sqlcon.Close();
            }
            else
            {
                string login = "";
                string password = "";
                string conpassword = "";
                string email = "";
                

                login = Login_textbox.Text;
                email = EmailTextBox.Text;
                password = Password_textBox.Text;
                conpassword = Confirm_TextBox.Text;
                if (login == "" || password == "" || email=="")
                {
                    Falsepas.Text = "Choose your login and password and email";
                }
                else
                if (!IsValidEmail(email))
                {
                    Falsepas.Text = "Your email isn`t correct";
                }
                else
                {
                    if (conpassword != password)
                    {
                        Falsepas.Text = "Password and confirmation aren`t same";
                    }
                    else
                    {
                        SqlConnection sqlcon = new SqlConnection(ConnectionString);
                        string select = $"select login, email from Users";
                        sqlcon.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(select, sqlcon);
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet);
                        bool isTheSame = false;
                        int count = dataSet.Tables[0].Rows.Count;
                        for (int i =0; i< count;i++)
                        {
                            if (dataSet.Tables[0].Rows[i][0].ToString() == login || dataSet.Tables[0].Rows[i][1].ToString() == email)
                            {
                                isTheSame = true;
                            }
                        }
                        if (isTheSame)
                        {
                            Falsepas.Text = "This login or email alreadey exists";
                        }
                        else
                        {
                            string update = $"Insert into Users (user_id, login, password, email, access) values ({count+1}, '{login}', '{password}', '{email}', 3)";
                            
                            SqlCommand sqlCommand = new SqlCommand();
                            sqlCommand.Connection = sqlcon;
                            sqlCommand.CommandText = update;
                            
                            sqlCommand.ExecuteNonQuery();
                            Falsepas.Text = "Registered succesfully";

                        }
                        sqlcon.Close();
                    }
                }
            }

        }

        private void create_new_a()
        {
            string login;
            string password;
            login = Login_textbox.Text;
            password = Password_textBox.Text;

        }


        public Login()
        {
            InitializeComponent();
            Confirm_label.Hide();
            Confirm_TextBox.Hide();
            label6.Hide();
            EmailTextBox.Hide();
        }

        private void Login_button_Click(object sender,
            EventArgs e) => login_in_a(isLogin);

        private void label4_Click(object sender,
            EventArgs e) => changeToReg(isLogin);


        private void changeToReg(bool a)
        {
            if (a)
            {
                label4.Text="Log in";
                label3.Text = "Back to loggining in";
                Login_button.Location = new Point(Login_button.Location.X,
                    Login_button.Location.Y + 60);
                Confirm_label.Show();
                Confirm_TextBox.Show();
                Falsepas.Text = "";
                isLogin = false;
                Login_button.Text = "Register";
                label5.Text = "Create New Account";
                label6.Show();
                EmailTextBox.Show();
            }
            else
            {
                label4.Text = "Sing up";
                label3.Text = "Do not have an account?";
                Login_button.Location = new Point(Login_button.Location.X,
                    Login_button.Location.Y - 60);
                Confirm_label.Hide();
                Confirm_TextBox.Hide();
                Confirm_TextBox.Text = "";
                Falsepas.Text = "";
                isLogin = true;
                Login_button.Text = "Login";
                label5.Text = "Login First";
                label6.Hide();                
                EmailTextBox.Hide();
                EmailTextBox.Text = "";

            }
            
        }
    }
}
