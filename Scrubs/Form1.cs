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
                LoadDataes();
            }

        }

        private void LoadDataes()
        {
            List<Patient> patients = bll.GetAllPatients(credAuth.AuthKey);
            for (int i = 0; i < patients.Count; i++)
            {
                dgvPatients.Rows.Add();
                dgvPatients[0, i].Value = patients[i].ID;
                dgvPatients[1, i].Value = patients[i].FullName;
                dgvPatients[2, i].Value = patients[i].BirthDay;
                dgvPatients[3, i].Value = patients[i].Gender;
                dgvPatients[4, i].Value = patients[i].Address;
                dgvPatients[5, i].Value = patients[i].PhoneNumer;
                dgvPatients[6, i].Value = patients[i].CardNumer;
            }
        }

        private void HideBoxes()
        {
            auth_but_login.Visible = !auth_but_login.Visible;
            auth_but_logout.Visible = !auth_but_logout.Visible;
            auth_login.Visible = !auth_login.Visible;
            auth_password.Visible = !auth_password.Visible;
            tcTabs.Visible = !tcTabs.Visible;
        }

        private void auth_but_logout_Click(object sender, EventArgs e)
        {
            bll.LogOut(credAuth.AuthKey);
            credAuth = new Credential();
            HideBoxes();

            dgvPatients.Rows.Clear();
        }

        private void butUpdatePatient_Click(object sender, EventArgs e)
        {
            var p = new Patient()
            {
                ID = int.Parse(dgvPatients.CurrentRow.Cells[0].Value + ""),
                FullName = dgvPatients.CurrentRow.Cells[1].Value + "",
                BirthDay = DateTime.Parse(dgvPatients.CurrentRow.Cells[2].Value + ""),
                Gender = dgvPatients.CurrentRow.Cells[3].Value + "",
                Address = dgvPatients.CurrentRow.Cells[4].Value + "",
                PhoneNumer = dgvPatients.CurrentRow.Cells[5].Value + "",
                CardNumer = int.Parse(dgvPatients.CurrentRow.Cells[6].Value + "")
            };
            bll.UpdatePatient(p, credAuth.AuthKey);
        }

        private void butDeletePatient_Click(object sender, EventArgs e)
        {
            if (bll.DeleteCredentials((int)dgvPatients.CurrentRow.Cells[0].Value, credAuth.AuthKey))
            {
                dgvPatients.Rows.RemoveAt(dgvPatients.CurrentRow.Index);
            }
        }
    }
}
