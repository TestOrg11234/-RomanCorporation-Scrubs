using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class BLL:IBLL
    {
        IDAL dal;

        public BLL()
        {
        }

        public BLL(DBDAL dbDAL)
        {
            dal = dbDAL;
        }

        public int CreateNewCredentials(Credential credentials)
        {
            return dal.CreateNewCredentials(credentials);
        }

        public int CreateNewDoctorsCredantials(Doctor doctor)
        {
            return dal.CreateNewDoctorsCredantials(doctor);
        }

        public int CreateNewListOfVisit(Visit visit)
        {
            return dal.CreateNewListOfVisit(visit);
        }

        public int CreateNewListsOfDiseases(Diseases diseases)
        {
            return dal.CreateNewListsOfDiseases(diseases);
        }

        public int CreateNewMedicines(Medicines medicines)
        {
            return dal.CreateNewMedicines(medicines);
        }

        public int CreateNewPatients(Patient patient)
        {
            return dal.CreateNewPatients(patient);
        }

        public int CreateNewRoles(Roles roles)
        {
            return dal.CreateNewRoles(roles);
        }

        public int CreateNewSchedule(Schedule schedule)
        {
            return dal.CreateNewSchedule(schedule);
        }

        public int CreateNewSpetialisations(Spetialisations spetialisations)
        {
            return dal.CreateNewSpetialisations(spetialisations);
        }

        public bool DeleteCredentials(long ID)
        {
            return dal.DeleteCredentials(ID);
        }

        public bool DeleteListOfVisit(long ID)
        {
            return dal.DeleteListOfVisit(ID);
        }

        public bool DeleteListsOfDiseases(long ID)
        {
            return dal.DeleteListsOfDiseases(ID);
        }

        public bool DeleteMedicines(long ID)
        {
            return dal.DeleteMedicines(ID);
        }

        public bool DeleteRoles(long ID)
        {
            return dal.DeleteRoles(ID);
        }

        public Credential GetCredentialFor(Credential cred)
        {
            Credential us = dal.GetCredentialByLogin(cred.Login);
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

    }
}
