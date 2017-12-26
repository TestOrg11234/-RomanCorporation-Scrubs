using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
using System.Security.Cryptography;

namespace BLL
{
    public class BLL : IBLL
    {
        IDAL dal;
        Random r;
        List<Credential> authCreds = new List<Credential>();
        public BLL()
        {
            dal = new DBDAL();
        }

        private void AddLog(string secretKey, string action)
        {
            var u = authCreds.FirstOrDefault(x => x.AuthKey == secretKey);
            dal.AddLog("User: " + u.ID + "Action: " + action);
        }
        private void AddLog(int idUser, string action)
        {
            dal.AddLog("User: " + idUser + "Action: " + action);
        }

        private bool CheckAuth(string authKey)
        {
            return authCreds.FirstOrDefault(x => x.AuthKey == authKey) != null;
        }

        private string Hash(string text)
        {
            byte[] data = Encoding.Default.GetBytes(text);
            var result = new SHA256Managed().ComputeHash(data);
            return BitConverter.ToString(result).Replace("-", "").ToLower();
        }

        public int CreateNewCredentials(Credential credentials, string authKey)
        {
            if (CheckAuth(authKey))
            {
                AddLog(authKey, "CreateNewCredentials");
                return dal.CreateNewCredentials(credentials);
            }
            return 0;
        }

        public void CreateNewDoctorsCredantials(Doctor doctor, string authKey)
        {
            if (CheckAuth(authKey))
            {
                dal.CreateNewDoctorsCredantials(doctor);
                AddLog(authKey, "CreateNewDoctorsCredantials");
            }
        }

        public int CreateNewListOfVisit(Visit visit, string authKey)
        {
            if (CheckAuth(authKey))
            {
                AddLog(authKey, "CreateNewListOfVisit");
                return dal.CreateNewListOfVisit(visit);
            }
            return 0;
        }

        public int CreateNewListsOfDiseases(Diseases diseases, string authKey)
        {
            if (CheckAuth(authKey))
            {
                AddLog(authKey, "CreateNewListsOfDiseases");
                return dal.CreateNewListsOfDiseases(diseases);
            }
            return 0;
        }

        public int CreateNewMedicines(Medicines medicines, string authKey)
        {
            if (CheckAuth(authKey))
            {
                AddLog(authKey, "CreateNewMedicines");
                return dal.CreateNewMedicines(medicines);
            }
            return 0;
        }

        public int CreateNewPatients(Patient patient, string authKey)
        {
            if (CheckAuth(authKey))
            {
                AddLog(authKey, "CreateNewPatients");
                return dal.CreateNewPatients(patient);
            }
            return 0;
        }

        public int CreateNewRoles(Roles roles, string authKey)
        {
            if (CheckAuth(authKey))
            {
                AddLog(authKey, "CreateNewRoles");
                return dal.CreateNewRoles(roles);
            }
            return 0;
        }

        public int CreateNewSchedule(Schedule schedule, string authKey)
        {
            if (CheckAuth(authKey))
            {
                AddLog(authKey, "CreateNewSchedule");
                return dal.CreateNewSchedule(schedule);
            }
            return 0;
        }

        public int CreateNewSpetialisations(Spetialisations spetialisations, string authKey)
        {
            if (CheckAuth(authKey))
            {
                AddLog(authKey, "CreateNewSpetialisations");
                return dal.CreateNewSpetialisations(spetialisations);
            }
            return 0;
        }

        public bool DeleteCredentials(int ID, string authKey)
        {
            if (CheckAuth(authKey))
            {
                AddLog(authKey, "DeleteCredentials");
                return dal.DeleteCredentials(ID);
            }
            return false;
        }

        public bool DeleteListOfVisit(int ID, string authKey)
        {
            if (CheckAuth(authKey))
            {
                AddLog(authKey, "DeleteListOfVisit");
                return dal.DeleteListOfVisit(ID);
            }
            return false;
        }

        public bool DeleteListsOfDiseases(int ID, string authKey)
        {
            if (CheckAuth(authKey))
            {
                AddLog(authKey, "DeleteListsOfDiseases");
                return dal.DeleteListsOfDiseases(ID);
            }
            return false;
        }

        public bool DeleteMedicines(int ID, string authKey)
        {
            if (CheckAuth(authKey))
            {
                AddLog(authKey, "DeleteMedicines");
                return dal.DeleteMedicines(ID);
            }
            return false;
        }

        public bool DeleteRoles(int ID, string authKey)
        {
            if (CheckAuth(authKey))
            {
                AddLog(authKey, "DeleteRoles");
                return dal.DeleteRoles(ID);
            }
            return false;
        }

        public Credential GetCredentialFor(Credential cred)
        {
            Credential us = dal.GetCredentialByLogin(cred.Login);
            if (us != null)
            {
                if (Hash(cred.Password) == us.Password)
                {
                    r = new Random();
                    us.AuthKey = r.Next(0, 999999) + "";
                    authCreds.Add(us);
                }
            }
            return us;
        }

        public IEnumerable<Diseases> GetDiagnosis()
        {
            throw new NotImplementedException();
        }

        public Diseases GetDiagnosis(int ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Doctor> GetDoctor()
        {
            throw new NotImplementedException();
        }

        public Doctor GetDoctor(int ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Medicines> GetMedicines()
        {
            throw new NotImplementedException();
        }

        public Medicines GetMedicines(int ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Patient> GetPatient()
        {
            throw new NotImplementedException();
        }

        public Patient GetPatient(int ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Schedule> GetSChedule()
        {
            throw new NotImplementedException();
        }

        public Schedule GetSChedule(int ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Visit> GetVisit()
        {
            throw new NotImplementedException();
        }

        public Visit GetVisit(int ID)
        {
            throw new NotImplementedException();
        }

        public void LogOut(string authKey)
        {
            AddLog(authKey, "LogOut");
            authCreds.Remove(authCreds.FirstOrDefault(x => x.AuthKey == authKey));
        }

        public List<Patient> GetAllPatients(string authKey)
        {        
            if (CheckAuth(authKey))
            {
                AddLog(authKey, "GetAllPatients");
                return dal.GetPatients().ToList();
            }
            return null;
        }

        public void UpdatePatient(Patient p, string authKey)
        {
            if (CheckAuth(authKey))
            {
                AddLog(authKey, "UpdatePatient");
                dal.UpdatePatient(p);
            }
        }

        public List<Doctor> GetAllDoctors(string authKey)
        {
            if (CheckAuth(authKey))
            {
                AddLog(authKey, "GetAllDoctors");
                return dal.GetDoctors().ToList();
            }
            return null;
        }

        public List<Visit> GetAllVisits(string authKey)
        {
            if (CheckAuth(authKey))
            {
                AddLog(authKey, "GetAllVisits");
                return dal.GetVisits().ToList();
            }
            return null;
        }

        public List<Diseases> GetAllDiseases(string authKey)
        {
            if (CheckAuth(authKey))
            {
                AddLog(authKey, "GetAllDiseases");
                return dal.GetDiagnosis().ToList();
            }
            return null;
        }

        public List<Medicines> GetAllMedicines(string authKey)
        {
            if (CheckAuth(authKey))
            {
                AddLog(authKey, "GetAllMedicines");
                return dal.GetMedicines().ToList();
            }
            return null;
        }

        public void UpdateDoctor(Doctor d, string authKey)
        {
            if (CheckAuth(authKey))
            {
                AddLog(authKey, "UpdateDoctor");
                dal.UpdateDoctor(d);
            }
        }

        public void UpdateVisit(Visit v, string authKey)
        {
            if (CheckAuth(authKey))
            {
                AddLog(authKey, "UpdateVisit");
                dal.UpdateVisit(v);
            }
        }

        public void UpdateDiagnose(Diseases d, string authKey)
        {
            if (CheckAuth(authKey))
            {
                AddLog(authKey, "UpdateDiagnose");
                dal.UpdateDiagnose(d);
            }
        }

        public void UpdateMedicine(Medicines m, string authKey)
        {
            if (CheckAuth(authKey))
            {
                AddLog(authKey, "UpdateMedicine");
                dal.UpdateMedicine(m);
            }
        }

        public void UpdateShedule(Schedule s, string authKey)
        {
            if (CheckAuth(authKey))
            {
                AddLog(authKey, "UpdateShedule");
                dal.UpdateSchedule(s);
            }
        }

        public bool DeleteShedule(int value, string authKey)
        {
            if (CheckAuth(authKey))
            {
                AddLog(authKey, "DeleteShedule");
                return dal.DeleteSedule(value);
            }
            return false;
        }

        public int AddSchedule(Schedule s, string authKey)
        {
            if (CheckAuth(authKey))
            {
                AddLog(authKey, "AddSchedule");
                return dal.AddSchedule(s);
            }
            return -1;
        }

        public List<Schedule> GetAllSchedules(string authKey)
        {
            if (CheckAuth(authKey))
            {
                AddLog(authKey, "GetAllSchedules");
                return dal.GetSChedules().ToList();
            }
            return null;
        }

        public bool DeletePatient(int value, string authKey)
        {
            if (CheckAuth(authKey))
            {
                AddLog(authKey, "DeletePatient");
                return dal.DeletePatient(value);
            }
            return false;
        }

        public void UpdateSpetialisations(Spetialisations s, string authKey)
        {
            if (CheckAuth(authKey))
            {
                AddLog(authKey, "UpdateSpetialisations");
                dal.UpdateSpetialisations(s);
            }
        }

        public bool DeleteSpetialisations(int value, string authKey)
        {
            if (CheckAuth(authKey))
            {
                AddLog(authKey, "DeleteSpetialisations");
                return dal.DeleteSpetialisations(value);
            }
            return false;
        }

        public int AddSpetialisations(Spetialisations s, string authKey)
        {
            if (CheckAuth(authKey))
            {
                AddLog(authKey, "AddSpetialisations");
                return dal.AddSpetialisations(s);
            }
            return -1;
        }

        public List<Spetialisations> GetAllSpetialisations(string authKey)
        {
            if (CheckAuth(authKey))
            {
                AddLog(authKey, "GetAllSpetialisations");
                return dal.GetSpetialisations().ToList();
            }
            return null;
        }
    }
}
