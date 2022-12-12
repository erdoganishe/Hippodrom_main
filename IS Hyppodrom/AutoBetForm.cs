using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Newtonsoft.Json;
using Data = Google.Apis.Sheets.v4.Data;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using System.IO;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;


namespace IS_Hyppodrom
{
    
    public partial class AutoBetForm : Form
    {
        const string ConnectionString = "Data Source=LAPTOP-NBBP6UE1;Initial Catalog = Hyppodrom; Integrated Security = True";
        
      
        List<string> Values = new List<string>();
        string range = "B2:D2000";
        static readonly string[] Scopes = { SheetsService.Scope.Spreadsheets };

        private GoogleCredential GetCredentialsFromFile()
        {
            GoogleCredential credential;
            using (var stream = new FileStream("autobetproject-850230a9ef5d.json", FileMode.Open, FileAccess.Read))
            {
                credential = GoogleCredential.FromStream(stream).CreateScoped(Scopes);
            }
            return credential;
        }

        
        public AutoBetForm()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SheetsService sheetsService = new SheetsService(new BaseClientService.Initializer
            {
                HttpClientInitializer = GetCredentialsFromFile(),
                ApplicationName = "Google-SheetsSample/0.1",
            });

            SpreadsheetsResource.ValuesResource.GetRequest request =
                 sheetsService.Spreadsheets.Values.Get("1LNarratiEe1ApzfnghwYs_j_YiVobxcMcWkSXfH_FlA", range);
            Data.ValueRange response = request.Execute();
            
            Values = JsonConvert.SerializeObject(response.Values).ToString().
                Split(',').Select(s => s.Trim(new Char[] { '"', '[', ']' })).
                ToList();
            for(int i = 0; i < 3; i++)
            {
                Values[i] = Values[Values.Count + i - 3];
            }
            SqlConnection sqlcon = new SqlConnection(ConnectionString);
            sqlcon.Open();
            string sql ="select bet.sum, bet.result_id, users.login from bet, users where bet_id = (select max(bet_id) from bet) and bet.user_id= users.user_id";
            
            SqlDataAdapter oda = new SqlDataAdapter(sql, sqlcon);
            DataSet dataSet = new DataSet();
            oda.Fill(dataSet);
            
            if ((dataSet.Tables[0].Rows[0][0].ToString() == Values[1]) && (dataSet.Tables[0].Rows[0][1].ToString() == Values[2]) && (dataSet.Tables[0].Rows[0][2].ToString() == Values[0])) { label3.Text = "Ця ставка вже прийнята"; }
            else
            {
                sql = $"insert into bet(bet_id, sum, coeficient, result_id, user_id) values ((select max(bet_id) from bet)+1, {Values[1]}, 0.02, {Values[2]}, (select user_id from users where login = '{Values[0]}'))";

                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                cmd.ExecuteNonQuery();

                string sql0 = $"select users.email from users where login = '{Values[0]}'";

                SqlDataAdapter oda0 = new SqlDataAdapter(sql0, sqlcon);
                DataSet dataSet0 = new DataSet();
                oda0.Fill(dataSet0);
                string email = dataSet0.Tables[0].Rows[0][0].ToString();


                var fromAddress = new MailAddress("mykhailo.khotian@nure.ua", "Hyppodrom");
                var toAddress = new MailAddress(email, Values[0]);
                const string fromPassword = "Q7UTYBxH";
                const string subject = "Your bet accepted";
                string body;
                body = $"Sum: {Values[1]}\nResult number: {Values[2]}";
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                    
                    
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                                      
            })
                {
                    smtp.Send(message);
                }

            }
            sqlcon.Close();
                       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string source = "https://docs.google.com/forms/d/e/1FAIpQLSdsNf7B9mwAJKSKBuMmWPHS7cdifzLlrRO1jt2HLClJ5qJATg/viewform?usp=sf_link";
            System.Diagnostics.Process.Start(source);
        }

    }
}
