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

            List<Doctor> doctors = bll.GetAllDoctors(credAuth.AuthKey);
            for (int i = 0; i < doctors.Count; i++)
            {
                dgvDoctors.Rows.Add();
                dgvDoctors[0, i].Value = doctors[i].ID;
                dgvDoctors[1, i].Value = doctors[i].FullName;
                dgvDoctors[2, i].Value = doctors[i].Spetialisation.ID;
                dgvDoctors[3, i].Value = doctors[i].BirthDay;
                dgvDoctors[4, i].Value = doctors[i].EmploymentDate;
                dgvDoctors[5, i].Value = doctors[i].CabinetNumber;
                dgvShedule[6, i].Value = doctors[i]._Schedule.ID;
            }

            List<Visit> visits = bll.GetAllVisits(credAuth.AuthKey);
            for (int i = 0; i < visits.Count; i++)
            {
                dgvVisit.Rows.Add();
                dgvVisit[0, i].Value = visits[i].ID;
                dgvVisit[1, i].Value = visits[i].NumberCard;
                dgvVisit[2, i].Value = visits[i].Data;
                dgvVisit[3, i].Value = visits[i].DoctorID;
                dgvVisit[4, i].Value = visits[i].PatientID;
                dgvVisit[5, i].Value = visits[i].DiagnosisID;
            }

            List<Diseases> diseases = bll.GetAllDiseases(credAuth.AuthKey);
            for (int i = 0; i < diseases.Count; i++)
            {
                dgvDiagnos.Rows.Add();
                dgvDiagnos[0, i].Value = diseases[i].ID;
                dgvDiagnos[1, i].Value = diseases[i].Name;
                dgvDiagnos[2, i].Value = diseases[i].Description;
            }

            List<Medicines> meds = bll.GetAllMedicines(credAuth.AuthKey);
            for (int i = 0; i < meds.Count; i++)
            {
                dgvMed.Rows.Add();
                dgvMed[0, i].Value = meds[i].ID;
                dgvMed[1, i].Value = meds[i].Name;
                dgvMed[2, i].Value = meds[i]._Diagnosis.ID;
                dgvMed[3, i].Value = meds[i].Description;
            }

            List<Schedule> schedules = bll.GetAllSchedules(credAuth.AuthKey);
            for (int i = 0; i < schedules.Count; i++)
            {
                dgvShedule.Rows.Add();
                dgvShedule[0, i].Value = schedules[i].ID;
                dgvShedule[1, i].Value = schedules[i].Data;
                dgvShedule[2, i].Value = schedules[i].CabinetNumber;
                dgvShedule[3, i].Value = schedules[i].StartTime;
                dgvShedule[4, i].Value = schedules[i].EndTime;
            }
            List<Spetialisations> spetialisations = bll.GetAllSpetialisations(credAuth.AuthKey);
            for (int i = 0; i<spetialisations.Count; i++)
            {
                dgvSpetialisations.Rows.Add();
                dgvSpetialisations[0, i].Value = spetialisations[i].ID;
                dgvSpetialisations[1, i].Value = spetialisations[i].Name;
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

        private void butUpdateDoctor_Click(object sender, EventArgs e)
        {
            var d = new Doctor()
            {
                ID = int.Parse(dgvDoctors.CurrentRow.Cells[0].Value + ""),
                FullName = dgvDoctors.CurrentRow.Cells[1].Value + "",
                Spetialisation = new Spetialisations()
                {
                    ID = int.Parse(dgvDoctors.CurrentRow.Cells[2].Value + "")
                },
                BirthDay = DateTime.Parse(dgvDoctors.CurrentRow.Cells[3].Value + ""),
                EmploymentDate = DateTime.Parse(dgvDoctors.CurrentRow.Cells[4].Value + ""),
                CabinetNumber = int.Parse(dgvDoctors.CurrentRow.Cells[0].Value + "")
                //возможно добавить shedule
            };
            bll.UpdateDoctor(d, credAuth.AuthKey);//realisation
        }

        private void butUpdateVisit_Click(object sender, EventArgs e)
        {
            var v = new Visit()
            {
                ID = int.Parse(dgvVisit.CurrentRow.Cells[0].Value + ""),
                NumberCard = dgvVisit.CurrentRow.Cells[1].Value + "",
                Data = DateTime.Parse(dgvVisit.CurrentRow.Cells[2].Value + ""),
                DoctorID = int.Parse(dgvVisit.CurrentRow.Cells[3].Value + ""),
                PatientID = int.Parse(dgvVisit.CurrentRow.Cells[4].Value + ""),
                DiagnosisID = int.Parse(dgvVisit.CurrentRow.Cells[5].Value + "")
            };
            bll.UpdateVisit(v, credAuth.AuthKey);
        }

        private void butUpdateDiagnose_Click(object sender, EventArgs e)
        {
            var d = new Diseases()
            {
                ID = int.Parse(dgvDiagnos.CurrentRow.Cells[0].Value + ""),
                Name = dgvDiagnos.CurrentRow.Cells[1].Value + "",
                Description = dgvDiagnos.CurrentRow.Cells[2].Value + ""
            };
            bll.UpdateDiagnose(d, credAuth.AuthKey);
        }

        private void butUpdateMedicine_Click(object sender, EventArgs e)
        {
            var m = new Medicines()
            {
                ID = int.Parse(dgvMed.CurrentRow.Cells[0].Value + ""),
                Name = dgvMed.CurrentRow.Cells[1].Value + "",
                _Diagnosis = new Diseases()
                {
                    ID = int.Parse(dgvMed.CurrentRow.Cells[2].Value + "")
                },
                Description = dgvMed.CurrentRow.Cells[3].Value + ""
            };
            bll.UpdateMedicine(m, credAuth.AuthKey);
        }

        private void butDeletePatient_Click(object sender, EventArgs e)
        {
            if (bll.DeletePatient((int)dgvPatients.CurrentRow.Cells[0].Value, credAuth.AuthKey))
            {
                dgvPatients.Rows.RemoveAt(dgvPatients.CurrentRow.Index);
            }
        }

        private void butDeleteDoctor_Click(object sender, EventArgs e)
        {
            if (bll.DeleteCredentials((int)dgvDoctors.CurrentRow.Cells[0].Value, credAuth.AuthKey))
            {
                dgvDoctors.Rows.RemoveAt(dgvDoctors.CurrentRow.Index);
            }
        }

        private void butDeleteVisit_Click(object sender, EventArgs e)
        {
            if (bll.DeleteListOfVisit((int)dgvVisit.CurrentRow.Cells[0].Value, credAuth.AuthKey))
            {
                dgvVisit.Rows.RemoveAt(dgvVisit.CurrentRow.Index);
            }
        }

        private void butDeleteDiagnose_Click(object sender, EventArgs e)
        {
            if (bll.DeleteListsOfDiseases((int)dgvDiagnos.CurrentRow.Cells[0].Value, credAuth.AuthKey))
            {
                dgvDiagnos.Rows.RemoveAt(dgvDiagnos.CurrentRow.Index);
            }
        }

        private void butDeleteMedicine_Click(object sender, EventArgs e)
        {
            if (bll.DeleteMedicines((int)dgvMed.CurrentRow.Cells[0].Value, credAuth.AuthKey))
            {
                dgvMed.Rows.RemoveAt(dgvMed.CurrentRow.Index);
            }
        }

        private void butAddPatient_Click(object sender, EventArgs e)
        {
            var p = new Patient()
            {
                FullName = (string)dgvPatients.CurrentRow.Cells[1].Value,
                BirthDay = DateTime.Parse(dgvPatients.CurrentRow.Cells[2].Value + ""),
                Gender = (string)dgvPatients.CurrentRow.Cells[3].Value,
                Address = (string)dgvPatients.CurrentRow.Cells[4].Value,
                PhoneNumer = (string)dgvPatients.CurrentRow.Cells[5].Value,
                CardNumer = int.Parse(dgvPatients.CurrentRow.Cells[6].Value + "")
            };
            var id = bll.CreateNewPatients(p, credAuth.AuthKey);
            dgvPatients.CurrentRow.Cells[0].Value = id;
        }

        private void butAddDoctor_Click(object sender, EventArgs e)
        {
            var d = new Doctor()
            {
                FullName = (string)dgvDoctors.CurrentRow.Cells[1].Value,
                Spetialisation = new Spetialisations()
                {
                    ID = int.Parse(dgvDoctors.CurrentRow.Cells[2].Value + "")
                },
                BirthDay = DateTime.Parse(dgvDoctors.CurrentRow.Cells[3].Value + ""),
                EmploymentDate = DateTime.Parse(dgvDoctors.CurrentRow.Cells[4].Value + ""),
                CabinetNumber = int.Parse(dgvDoctors.CurrentRow.Cells[5].Value + ""),
                _Schedule = new Schedule()
                {
                    ID = int.Parse(dgvDoctors.CurrentRow.Cells[6].Value + "")
                },
            };
            var id = bll.CreateNewDoctorsCredantials(d, credAuth.AuthKey);
            dgvDoctors.CurrentRow.Cells[0].Value = id;
        }

        private void butAddVisit_Click(object sender, EventArgs e)
        {
            var v = new Visit()
            {
                NumberCard = (string)dgvVisit.CurrentRow.Cells[1].Value,
                Data = DateTime.Parse(dgvVisit.CurrentRow.Cells[2].Value + ""),
                DoctorID = int.Parse(dgvVisit.CurrentRow.Cells[3].Value + ""),
                PatientID = int.Parse(dgvVisit.CurrentRow.Cells[4].Value + ""),
                DiagnosisID = int.Parse(dgvVisit.CurrentRow.Cells[5].Value + ""),
            };
            var id = bll.CreateNewListOfVisit(v, credAuth.AuthKey);
            dgvVisit.CurrentRow.Cells[0].Value = id;
        }

        private void butAddDiagnose_Click(object sender, EventArgs e)
        {
            var d = new Diseases()
            {
                Name = (string)dgvDiagnos.CurrentRow.Cells[1].Value,
                Description = (string)dgvDiagnos.CurrentRow.Cells[2].Value
            };
            var id = bll.CreateNewListsOfDiseases(d, credAuth.AuthKey);
            dgvDiagnos.CurrentRow.Cells[0].Value = id;
        }

        private void butAddMedicine_Click(object sender, EventArgs e)
        {
            var m = new Medicines()
            {
                Name = (string)dgvMed.CurrentRow.Cells[1].Value,
                _Diagnosis = new Diseases()
                {
                    ID = int.Parse(dgvMed.CurrentRow.Cells[2].Value + "")
                },
                Description = (string)dgvMed.CurrentRow.Cells[3].Value
            };
            var id = bll.CreateNewMedicines(m, credAuth.AuthKey);
            dgvMed.CurrentRow.Cells[0].Value = id;
        }

        private void butUpdateShedule_Click(object sender, EventArgs e)
        {
            var s = new Schedule()
            {
                ID = int.Parse(dgvShedule.CurrentRow.Cells[0].Value + ""),
                CabinetNumber = int.Parse(dgvShedule.CurrentRow.Cells[2].Value + ""),
                Data = DateTime.Parse(dgvShedule.CurrentRow.Cells[1].Value + ""),
                StartTime = DateTime.Parse(dgvShedule.CurrentRow.Cells[3].Value + ""),
                EndTime = DateTime.Parse(dgvShedule.CurrentRow.Cells[4].Value + "")
            };
            bll.UpdateShedule(s, credAuth.AuthKey);
        }

        private void butDeleteShedule_Click(object sender, EventArgs e)
        {
            if (bll.DeleteShedule((int)dgvShedule.CurrentRow.Cells[0].Value, credAuth.AuthKey))
            {
                dgvShedule.Rows.RemoveAt(dgvShedule.CurrentRow.Index);
            }
        }

        private void butAddShedule_Click(object sender, EventArgs e)
        {
            var s = new Schedule()
            {
                Data = DateTime.Parse(dgvShedule.CurrentRow.Cells[1].Value + ""),
                CabinetNumber = int.Parse(dgvShedule.CurrentRow.Cells[2].Value + ""),
                StartTime = DateTime.Parse(dgvShedule.CurrentRow.Cells[3].Value + ""),
                EndTime = DateTime.Parse(dgvShedule.CurrentRow.Cells[4].Value + ""),
            };
            int id = bll.AddSchedule(s, credAuth.AuthKey);
            dgvShedule.CurrentRow.Cells[0].Value = id;
        }
        private void butUpdateSpetialisations_Click(object sender, EventArgs e)
        {
            var s = new Spetialisations()
            {
                ID = int.Parse(dgvSpetialisations.CurrentRow.Cells[0].Value + ""),
                Name = (string)dgvSpetialisations.CurrentRow.Cells[1].Value
            };
            bll.UpdateSpetialisations(s, credAuth.AuthKey);
        }

        private void butDeleteSpetialisations_Click(object sender, EventArgs e)
        {
            if (bll.DeleteSpetialisations((int)dgvSpetialisations.CurrentRow.Cells[0].Value, credAuth.AuthKey))
            {
                dgvSpetialisations.Rows.RemoveAt(dgvSpetialisations.CurrentRow.Index);
            }
        }

        private void butAddSpetialisations_Click(object sender, EventArgs e)
        {
            var s = new Spetialisations()
            {
                Name = (string)dgvSpetialisations.CurrentRow.Cells[1].Value
            };
            int id = bll.AddSpetialisations(s, credAuth.AuthKey);
            dgvSpetialisations.CurrentRow.Cells[0].Value = id;
        }
    }
}
