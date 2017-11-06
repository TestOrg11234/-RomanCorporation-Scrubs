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
        int CreateNewPatients(Patient patient);
        int CreateNewDoctorsCredantials(Doctor doctor);
        int CreateNewListOfVisit(Visit visit);
        int CreateNewMedicines(Medicines medicines);
        int CreateNewCredentials(Credential credentials);
        int CreateNewSchedule(Schedule schedule);
        int CreateNewSpetialisations(Spetialisations spetialisations);
        int CreateNewRoles(Roles roles);
        int CreateNewListsOfDiseases(Diseases diseases);
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
    }
}
