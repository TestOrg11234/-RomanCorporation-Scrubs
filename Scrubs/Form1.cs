using Entity;
using Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scrubs
{
    public partial class Form1 : Form
    {
        IBLL bll;
        Credential credAuth;
        public Form1()
        {
            InitializeComponent();
            bll = new BLL.BLL();
            credAuth = new Credential();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void auth_but_login_Click(object sender, EventArgs e)
        {
            var cred = new Credential()
            {
                Login = auth_login.Text,
                Password = auth_password.Text
            };
            Credential us = bll.GetCredentialFor(cred);
            if (us != null)
            {
                HideBoxes();
                credAuth = us;
            }

        }

        private void HideBoxes()
        {
            auth_but_login.Visible = !auth_but_login.Visible;
            auth_but_logout.Visible = !auth_but_logout.Visible;
            auth_login.Visible = !auth_login.Visible;
            auth_password.Visible = !auth_password.Visible;
        }
    }
}
