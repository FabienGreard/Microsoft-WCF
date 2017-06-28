using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dll_service_contract;
using dll_client_cut;
using dll_stg;

namespace form_client_cu
{
    public partial class Form1 : Form
    {
        private IServiceContract serviceContract;
        private dll_cut cut;
        private STG msg;

        public Form1(IServiceContract serviceContract)
        {
            InitializeComponent();
            this.serviceContract = serviceContract;
            this.cut = new dll_cut();
            this.msg = new STG
            {
                tokenApll = "GEN_WCF",
            };

        }

        private void Form1_Load(object sender, EventArgs e)
        {
 
        }

        private void click_validate_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(this.email.Text) && !string.IsNullOrEmpty(this.password.Text))
            {
                this.msg.data = new object[2];
                this.msg.data[0] = this.email.Text;
                this.msg.data[1] = this.password.Text;

                this.msg.operationName = "auth";

                try
                {
                    this.msg = cut.checkData(this.serviceContract.m_service(cut.checkData(this.msg)));
                }
                catch
                {
                    this.connect.Text = "Erreur de connexion";
                }
                
                if(this.msg.info == "13, user connected")
                {
                    this.connect.Text = "Connected";
                    this.token.Text = "Token : " + this.msg.tokenUser;
                }
            }
        }

    }
}
