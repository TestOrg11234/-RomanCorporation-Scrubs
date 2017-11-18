using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IBLL
    {
        int CreateNewPatients(Patient patient, string authKey);
        int CreateNewDoctorsCredantials(Doctor doctor, string authKey);
        int CreateNewListOfVisit(Visit visit, string authKey);
        int CreateNewMedicines(Medicines medicines, string authKey);
        int CreateNewCredentials(Credential credentials, string authKey);
        int CreateNewSchedule(Schedule schedule, string authKey);
        int CreateNewSpetialisations(Spetialisations spetialisations, string authKey);
        int CreateNewRoles(Roles roles, string authKey);
        int CreateNewListsOfDiseases(Diseases diseases, string authKey);
        bool DeleteCredentials(int ID, string authKey);
        bool DeleteRoles(int ID, string authKey);
        bool DeleteListOfVisit(int ID, string authKey);
        bool DeleteListsOfDiseases(int ID, string authKey);
        bool DeleteMedicines(int ID, string authKey);
        Credential GetCredentialFor(Credential cred);
        Patient GetPatient(int ID);
        Diseases GetDiagnosis(int ID);
        Doctor GetDoctor(int ID);
        Medicines GetMedicines(int ID);
        Schedule GetSChedule(int ID);
        Visit GetVisit(int ID);

        IEnumerable<Patient> GetPatient();
        List<Patient> GetAllPatients(string authKey);
        IEnumerable<Diseases> GetDiagnosis();
        IEnumerable<Doctor> GetDoctor();
        IEnumerable<Medicines> GetMedicines();
        IEnumerable<Schedule> GetSChedule();
        IEnumerable<Visit> GetVisit();
        void LogOut(string authKey);
        void UpdatePatient(Patient p, string authKey);
        List<Doctor> GetAllDoctors(string authKey);
        List<Visit> GetAllVisits(string authKey);
        List<Diseases> GetAllDiseases(string authKey);
        List<Medicines> GetAllMedicines(string authKey);
        void UpdateDoctor(Doctor d, string authKey);
        void UpdateVisit(Visit v, string authKey);
        void UpdateDiagnose(Diseases d, string authKey);
        void UpdateMedicine(Medicines m, string authKey);
        void UpdateShedule(Schedule s, string authKey);
        bool DeleteShedule(int value, string authKey);
        object AddShedule(object p, string authKey);
    }
}
