using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VivaVstoreTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TestBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(AmountTxt.Text))
            {
                string URL = "https://api.sandbox.checkout.com/payments";
                Dictionary<string, object> Myparametes = new Dictionary<string, object>();
                Myparametes = new Dictionary<string, object>();
                Myparametes.Add("amount", AmountTxt.Text);
                Myparametes.Add("currency", "KWD");
                Myparametes.Add("source", @"{ 'type': 'knet',
              'language': 'en'
            }");

                Dictionary<string, object> values = JsonConvert.
               DeserializeObject<Dictionary<string, object>>(APIClass.callApi(URL, Method.POST, Myparametes));

                ResponseLbl.Text = "";
                foreach (var response in values)
                {
                    RespnseTxt.Text += response.Key + " : " + response.Value + "\n";
                }

            }
            else
            {
                MessageBox.Show("Please Enter Amount");
            }
        }
    }
}
