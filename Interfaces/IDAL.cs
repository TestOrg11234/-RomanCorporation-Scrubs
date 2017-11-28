using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IDAL
    {
        int CreateNewPatients(Patient patient);
        void CreateNewDoctorsCredantials(Doctor doctor);
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

        Patient GetPatient(int ID);
        Diseases GetDiagnosis(int ID);
        Doctor GetDoctor(int ID);
        Medicines GetMedicines(int ID);
        Schedule GetSChedule(int ID);
        Visit GetVisit(int ID);
        Roles GetRoleByID(int ID);

        IEnumerable<Patient> GetPatients();
        IEnumerable<Diseases> GetDiagnosis();
        IEnumerable<Doctor> GetDoctors();
        IEnumerable<Medicines> GetMedicines();
        IEnumerable<Schedule> GetSChedules();
        IEnumerable<Visit> GetVisits();
        Credential GetCredentialByLogin(string login);
        void UpdatePatient(Patient p);
        void UpdateDoctor(Doctor d);
        void UpdateVisit(Visit v);
        void UpdateDiagnose(Diseases d);
        void UpdateMedicine(Medicines m);
        void UpdateSchedule(Schedule s);
        bool DeleteSedule(int value);
        int AddSchedule(Schedule s);
        bool DeletePatient(int ID);
        void UpdateSpetialisations(Spetialisations s);
        bool DeleteSpetialisations(int value);
        int AddSpetialisations(Spetialisations s);
        IEnumerable<Spetialisations> GetSpetialisations();
    }
}
