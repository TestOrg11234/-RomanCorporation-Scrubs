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
        bool DeleteCredentials(long ID);
        bool DeleteRoles(long ID);
        bool DeleteListOfVisit(long ID);
        bool DeleteListsOfDiseases(long ID);
        bool DeleteMedicines(long ID);
        Credential GetCredentialFor(Credential cred);
        Patient GetPatient(int ID);
        Diseases GetDiagnosis(int ID);
        Doctor GetDoctor(int ID);
        Medicines GetMedicines(int ID);
        Schedule GetSChedule(int ID);
        Visit GetVisit(int ID);

        IEnumerable<Patient> GetPatient();
        IEnumerable<Diseases> GetDiagnosis();
        IEnumerable<Doctor> GetDoctor();
        IEnumerable<Medicines> GetMedicines();
        IEnumerable<Schedule> GetSChedule();
        IEnumerable<Visit> GetVisit();
        void LogOut(string authKey);
    }
}
