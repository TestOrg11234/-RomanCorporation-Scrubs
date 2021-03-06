﻿using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Net;
//переделать удаление пациентов!!!скорее всего сделано
namespace DAL
{
    public class DBDAL : IDAL
    {
        private string connectionstring;
        public DBDAL()
        {
            connectionstring = "Data Source=VATO;Initial Catalog=B1;Integrated Security=True";
        }
        public int CreateNewPatients(Patient patient)
        {
            int ID = 0;
            using (SqlConnection scon = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("CreateNewPatients", scon))
                {
                    #region sParams
                    SqlParameter[] sParams =
                    {
                        //new SqlParameter()
                        //{
                        //    ParameterName = "@login",
                        //    SqlDbType = SqlDbType.NVarChar,
                        //    Size = 50,
                        //    Value = patient.Login
                        //},
                        //new SqlParameter()
                        //{
                        //    ParameterName = "@password",
                        //    SqlDbType = SqlDbType.NVarChar,
                        //    Size = 50,
                        //    Value = patient.Password
                        //},
                        new SqlParameter()
                        {
                            ParameterName = "@phoneNumer",
                            SqlDbType = SqlDbType.NVarChar,
                            Size = 50,
                            Value = patient.PhoneNumer
                        },
                         new SqlParameter()
                        {
                            ParameterName = "cardNumer",
                            SqlDbType = SqlDbType.Int,
                            Value = patient.CardNumer
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@gender",
                            SqlDbType = SqlDbType.NVarChar,
                            Size = 50,
                            Value = patient.Gender
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@address",
                            SqlDbType = SqlDbType.NVarChar,
                            Value = patient.Address
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@fullName",
                            SqlDbType = SqlDbType.NVarChar,
                            Size = 50,
                            Value = patient.FullName
                        },
                        new SqlParameter()//тут возможно будет ошибка
                        {
                            ParameterName = "@birthDay",
                            SqlDbType = SqlDbType.Date,
                            Value = patient.BirthDay.ToString("yyyy-MM-dd")
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@id",
                            SqlDbType = SqlDbType.Int,
                            Value = patient.ID,
                            Direction = ParameterDirection.Output
                        }
                    };
                    #endregion

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(sParams);
                    scon.Open();
                    cmd.ExecuteNonQuery();
                    ID = (int)cmd.Parameters["@id"].Value;
                }
            }
            return ID;
        }
        public void CreateNewDoctorsCredantials(Doctor doctor)
        {
            using (SqlConnection scon = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("CreateNewDoctorsCredantials", scon))
                {
                    #region sParams
                    SqlParameter[] sParams =
                    {
                        //new SqlParameter()
                        //{
                        //    ParameterName = "@login",
                        //    SqlDbType = SqlDbType.NVarChar,
                        //    Size = 50,
                        //    Value = doctor.Login
                        //},
                        //new SqlParameter()
                        //{
                        //    ParameterName = "@password",
                        //    SqlDbType = SqlDbType.NVarChar,
                        //    Size = 50,
                        //    Value = doctor.Password
                        //},
                        new SqlParameter()
                        {
                            ParameterName = "@spetialisation",
                            SqlDbType = SqlDbType.Int,
                            Value = doctor.Spetialisation.ID
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@employmentDate",
                            SqlDbType = SqlDbType.Date,
                            Value = doctor.EmploymentDate
                        },
                         new SqlParameter()
                        {
                            ParameterName = "@cabinetNumber",
                            SqlDbType = SqlDbType.Int,
                            Value = doctor.CabinetNumber
                        },
                          new SqlParameter()
                        {
                            ParameterName = "@shedule",
                            SqlDbType = SqlDbType.Int,
                            Value = doctor._Schedule.ID
                        },
                        //new SqlParameter()
                        //{
                        //    ParameterName = "@eMail",
                        //    SqlDbType = SqlDbType.NVarChar,
                        //    Size = 50,
                        //    Value = doctor.EMail
                        //},                        
                        new SqlParameter()
                        {
                            ParameterName = "@fullName",
                            SqlDbType = SqlDbType.NVarChar,
                            Size = 50,
                            Value = doctor.FullName
                        },
                        new SqlParameter()//тут возможно будет ошибка
                        {
                            ParameterName = "@birthDay",
                            SqlDbType = SqlDbType.Date,
                            Value = doctor.BirthDay
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@id",
                            SqlDbType = SqlDbType.Int,
                            Value = doctor.ID
                        }
                    };
                    #endregion

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(sParams);
                    scon.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public int CreateNewListOfVisit(Visit visit)
        {
            int ID = 0;
            using (SqlConnection scon = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("CreateNewListOfVisit", scon))
                {
                    #region sParams
                    SqlParameter[] sParams =
                    {
                        new SqlParameter()
                        {
                            ParameterName = "@numberCard",
                            SqlDbType = SqlDbType.NVarChar,
                            Size = 50,
                            Value = visit.NumberCard
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@data",
                            SqlDbType = SqlDbType.Date,
                            Value = visit.Data
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@doctorID",
                            SqlDbType = SqlDbType.Int,
                            Value = visit.DoctorID
                        },
                         new SqlParameter()
                        {
                            ParameterName = "@patientID",
                            SqlDbType = SqlDbType.Int,
                            Value = visit.PatientID
                        },
                         new SqlParameter()
                        {
                            ParameterName = "@diagnosisID",
                            SqlDbType = SqlDbType.Int,
                            Value = visit.DiagnosisID
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@id",
                            SqlDbType = SqlDbType.Int,
                            Value = visit.ID,
                            Direction = ParameterDirection.Output
                        }
                    };
                    #endregion

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(sParams);
                    scon.Open();
                    cmd.ExecuteNonQuery();
                    ID = (int)cmd.Parameters["@id"].Value;
                }
            }
            return ID;
        }
        public int CreateNewMedicines(Medicines medicines)
        {
            int ID = 0;
            using (SqlConnection scon = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("CreateNewMedicines", scon))
                {
                    #region sParams
                    SqlParameter[] sParams =
                    {
                        new SqlParameter()
                        {
                            ParameterName = "@name",
                            SqlDbType = SqlDbType.NVarChar,
                            Size = 50,
                            Value = medicines.Name
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@description",
                            SqlDbType = SqlDbType.NVarChar,
                            Size = 50,
                            Value = medicines.Description
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@diagnosisID",
                            SqlDbType = SqlDbType.Int,
                            Value = medicines._Diagnosis.ID
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@id",
                            SqlDbType = SqlDbType.Int,
                            Value = medicines.ID,
                            Direction = ParameterDirection.Output
                        }
                    };
                    #endregion

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(sParams);
                    scon.Open();
                    cmd.ExecuteNonQuery();
                    ID = (int)cmd.Parameters["@id"].Value;
                }
            }
            return ID;
        }
        public int CreateNewCredentials(Credential credentials)
        {
            int ID = 0;
            using (SqlConnection scon = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("CreateNewCredentials", scon))
                {
                    #region sParams
                    SqlParameter[] sParams =
                    {
                        new SqlParameter()
                        {
                            ParameterName = "@login",
                            SqlDbType = SqlDbType.NVarChar,
                            Size = 50,
                            Value = credentials.Login
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@password",
                            SqlDbType = SqlDbType.NVarChar,
                            Size = 64,
                            Value = credentials.Password
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@role",
                            SqlDbType = SqlDbType.Int,
                            Value = credentials._Role.ID
                        },

                        new SqlParameter()
                        {
                            ParameterName = "@id",
                            SqlDbType = SqlDbType.Int,
                            Value = credentials.ID,
                            Direction = ParameterDirection.Output
                        }
                    };
                    #endregion

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(sParams);
                    scon.Open();
                    cmd.ExecuteNonQuery();
                    ID = (int)cmd.Parameters["@id"].Value;
                }
            }
            return ID;
        }
        public int CreateNewSchedule(Schedule schedule)
        {
            int ID = 0;
            using (SqlConnection scon = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("CreateNewSchedule", scon))
                {
                    #region sParams
                    SqlParameter[] sParams =
                    {
                        new SqlParameter()
                        {
                            ParameterName = "@data",
                            SqlDbType = SqlDbType.Date,
                            Value = schedule.Data
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@cabinetNumber",
                            SqlDbType = SqlDbType.Int,
                            Value = schedule.CabinetNumber
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@startTime",
                            SqlDbType = SqlDbType.Time,
                            Value = schedule.StartTime
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@endTime",
                            SqlDbType = SqlDbType.Time,
                            Value = schedule.EndTime
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@id",
                            SqlDbType = SqlDbType.Int,
                            Value = schedule.ID,
                            Direction = ParameterDirection.Output
                        }
                    };
                    #endregion

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(sParams);
                    scon.Open();
                    cmd.ExecuteNonQuery();
                    ID = (int)cmd.Parameters["@id"].Value;
                }
            }
            return ID;
        }
        public int CreateNewSpetialisations(Spetialisations spetialisations)
        {
            int ID = 0;
            using (SqlConnection scon = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("CreateNewSpetialisations", scon))
                {
                    #region sParams
                    SqlParameter[] sParams =
                    {
                        new SqlParameter()
                        {
                            ParameterName = "@name",
                            SqlDbType = SqlDbType.NVarChar,
                            Size = 50,
                            Value = spetialisations.Name
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@id",
                            SqlDbType = SqlDbType.Int,
                            Value = spetialisations.ID,
                            Direction = ParameterDirection.Output
                        }
                    };
                    #endregion

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(sParams);
                    scon.Open();
                    cmd.ExecuteNonQuery();
                    ID = (int)cmd.Parameters["@id"].Value;
                }
            }
            return ID;
        }
        public int CreateNewRoles(Roles roles)
        {
            int ID = 0;
            using (SqlConnection scon = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("CreateNewRoles", scon))
                {
                    #region sParams
                    SqlParameter[] sParams =
                    {
                        new SqlParameter()
                        {
                            ParameterName = "@nameRole",
                            SqlDbType = SqlDbType.NVarChar,
                            Size = 50,
                            Value = roles.NameRole
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@id",
                            SqlDbType = SqlDbType.Int,
                            Value = roles.ID,
                            Direction = ParameterDirection.Output
                        }
                    };
                    #endregion

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(sParams);
                    scon.Open();
                    cmd.ExecuteNonQuery();
                    ID = (int)cmd.Parameters["@id"].Value;
                }
            }
            return ID;
        }
        public int CreateNewListsOfDiseases(Diseases diseases)
        {
            int ID = 0;
            using (SqlConnection scon = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("CreateNewListsOfDiseases", scon))
                {
                    #region sParams
                    SqlParameter[] sParams =
                    {
                        new SqlParameter()
                        {
                            ParameterName = "@name",
                            SqlDbType = SqlDbType.NVarChar,
                            Size = 50,
                            Value = diseases.Name
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@description",
                            SqlDbType = SqlDbType.NVarChar,
                            Size = 50,
                            Value = diseases.Description
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@id",
                            SqlDbType = SqlDbType.Int,
                            Value = diseases.ID,
                            Direction = ParameterDirection.Output
                        }
                    };
                    #endregion

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(sParams);
                    scon.Open();
                    cmd.ExecuteNonQuery();
                    ID = (int)cmd.Parameters["@id"].Value;
                }
            }
            return ID;
        }
        public bool DeleteCredentials(long ID)
        {
            using (SqlConnection scon = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("DeleteCredentials", scon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@id",
                        SqlDbType = SqlDbType.Int,
                        Value = ID
                    });
                    scon.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            return true; //!!!
        }
        public bool DeleteRoles(long ID)
        {
            using (SqlConnection scon = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("DeleteRoles", scon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@id",
                        SqlDbType = SqlDbType.Int,
                        Value = ID
                    });
                    scon.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            return true; //!!!
        }
        public bool DeleteListOfVisit(long ID)
        {
            using (SqlConnection scon = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("DeleteListOfVisit", scon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@id",
                        SqlDbType = SqlDbType.Int,
                        Value = ID
                    });
                    scon.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            return true; //!!!
        }
        public bool DeleteListsOfDiseases(long ID)
        {
            using (SqlConnection scon = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("DeleteListsOfDiseases", scon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@id",
                        SqlDbType = SqlDbType.Int,
                        Value = ID
                    });
                    scon.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            return true; //!!!
        }
        public bool DeleteMedicines(long ID)
        {
            using (SqlConnection scon = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("DeleteMedicines", scon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@id",
                        SqlDbType = SqlDbType.Int,
                        Value = ID
                    });
                    scon.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            return true; //!!!
        }
        public IEnumerable<Credential> GetCredentials()
        {
            using (SqlConnection scon = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("GetCredentials", scon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    scon.Open();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        yield return new Credential()
                        {
                            ID = (int)reader["ID"],
                            Login = ((string)reader["[Login]"]).Trim(),
                            Password = ((string)reader["[Password]"]).Trim(),
                            _Role = new Roles()
                            {
                                ID = (int)reader["[Role]"], //!!!
                            }
                        };
                    };
                }
            }
        }
        public IEnumerable<Doctor> GetDoctors()
        {
            using (SqlConnection scon = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("GetDoctorsCredantials", scon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    scon.Open();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        yield return new Doctor()
                        {
                            ID = (int)reader["ID"],
                            BirthDay = (DateTime)reader["Birthday"],
                            FullName = ((string)reader["FullName"]).Trim(),
                            Spetialisation = new Spetialisations()
                            {
                                ID = (int)reader["Spetialisation"],
                            },
                            EmploymentDate = (DateTime)reader["EmploymentDate"],
                            CabinetNumber = (int)reader["CabinetNumber"],
                            _Schedule = new Schedule()
                            {
                                ID = (int)reader["Shedule"],//!!!
                            }
                        };
                    };
                }
            }
        }
        public IEnumerable<Visit> GetVisits()
        {
            using (SqlConnection scon = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("GetListOfVisit", scon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    scon.Open();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        yield return new Visit()
                        {
                            ID = (int)reader["ID"],
                            NumberCard = ((string)reader["NumberCard"]).Trim(),
                            Data = (DateTime)reader["[Data]"],
                            DoctorID = (int)reader["DoctorID"],
                            PatientID = (int)reader["PatientID"],
                            DiagnosisID = (int)reader["DiagnosisID"], //!!!
                        };
                    };
                }
            }
        }
        public IEnumerable<Diseases> GetDiagnosis()
        {
            using (SqlConnection scon = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("GetListsOfDiseases", scon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    scon.Open();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        yield return new Diseases()
                        {
                            ID = (int)reader["ID"],
                            Name = ((string)reader["Name"]).Trim(),
                            Description = ((string)reader["Description"]).Trim(),
                        };
                    };
                }
            }
        }
        public IEnumerable<Medicines> GetMedicines()
        {
            using (SqlConnection scon = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("GetMedicines", scon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    scon.Open();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        yield return new Medicines()
                        {
                            ID = (int)reader["ID"],
                            Name = ((string)reader["Name"]).Trim(),
                            Description = ((string)reader["Description"]).Trim(),
                            _Diagnosis = new Diseases()
                            {
                                ID = (int)reader["DiagnosisID"],//!!!
                            }
                        };
                    };
                }
            }
        }
        public IEnumerable<Patient> GetPatients()
        {
            using (SqlConnection scon = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("GetPatients", scon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    scon.Open();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        yield return new Patient()
                        {
                            ID = (int)reader["ID"],
                            FullName = ((string)reader["FullName"]).Trim(),
                            BirthDay = (DateTime)reader["Birthday"],
                            Gender = ((string)reader["Gender"]).Trim(),
                            Address = ((string)reader["Address"]).Trim(),
                            PhoneNumer = ((string)reader["PhoneNumer"]).Trim(),
                            CardNumer = (int)reader["CardNumer"],
                        };
                    };
                }
            }
        }
        public IEnumerable<Roles> GetRoles()
        {
            using (SqlConnection scon = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("GetRoles", scon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    scon.Open();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        yield return new Roles()
                        {
                            ID = (int)reader["ID"],
                            NameRole = ((string)reader["NameRole"]).Trim(),
                        };
                    };
                }
            }
        }
        public IEnumerable<Schedule> GetSChedules()
        {
            using (SqlConnection scon = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("GetSchedules", scon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    scon.Open();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        yield return new Schedule()
                        {
                            ID = (int)reader["ID"],
                            Data = (DateTime)reader["Data"],
                            CabinetNumber = ((int)reader["CabinetNumber"]),
                            StartTime = (DateTime)reader["StartTime"],
                            EndTime = (DateTime)reader["EndTime"],
                        };
                    };
                }
            }
        }
        public IEnumerable<Spetialisations> GetSpetialisations()
        {
            using (SqlConnection scon = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("GetSpetialisations", scon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    scon.Open();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        yield return new Spetialisations()
                        {
                            ID = (int)reader["ID"],
                            Name = ((string)reader["Name"]).Trim(),
                        };
                    };
                }
            }
        }
        //public void UpdateCredentials(Credential u)//!!!
        //{
        //    using (SqlConnection scon = new SqlConnection(connectionstring))
        //    {
        //        using (SqlCommand cmd = new SqlCommand("UpdateCredentials", scon))
        //        {
        //            #region sParams
        //            SqlParameter[] sParams =
        //            {
        //                new SqlParameter()
        //                {
        //                    ParameterName = "@personnelnum",
        //                    SqlDbType = SqlDbType.Int,
        //                    Value = u.PersonnelNum
        //                },
        //                new SqlParameter()
        //                {
        //                    ParameterName = "@fullname",
        //                    SqlDbType = SqlDbType.NVarChar,
        //                    Size=100,
        //                    Value = u.PersonnelNum
        //                },
        //                 new SqlParameter()
        //                {
        //                    ParameterName = "@dateOfbirth",
        //                    SqlDbType = SqlDbType.Date,
        //                    Value = u.PersonnelNum
        //                },
        //                  new SqlParameter()
        //                {
        //                    ParameterName = "@homeaddress",
        //                    SqlDbType = SqlDbType.NVarChar,
        //                    Size=-1,
        //                    Value = u.PersonnelNum
        //                },
        //                   new SqlParameter()
        //                {
        //                    ParameterName = "@homenumberphone",
        //                    SqlDbType = SqlDbType.NVarChar,
        //                    Size=50,
        //                    Value = u.PersonnelNum
        //                },
        //                new SqlParameter()
        //                {
        //                    ParameterName = "@worknumberphone",
        //                    SqlDbType = SqlDbType.NVarChar,
        //                    Size=50,
        //                    Value = u.PersonnelNum
        //                },
        //            };
        //            #endregion

        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.AddRange(sParams);
        //            scon.Open();
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //}

        public Patient GetPatient(int ID)
        {
            throw new NotImplementedException();
        }

        public Diseases GetDiagnosis(int ID)
        {
            throw new NotImplementedException();
        }

        public Doctor GetDoctor(int ID)
        {
            throw new NotImplementedException();
        }

        public Medicines GetMedicines(int ID)
        {
            throw new NotImplementedException();
        }

        public Schedule GetSChedule(int ID)
        {
            throw new NotImplementedException();
        }

        public Visit GetVisit(int ID)
        {
            throw new NotImplementedException();
        }




        public Credential GetCredentialByLogin(string login)
        {
            var u = new Credential()
            {
                Login = login,
                _Role = new Roles()
            };
            using (SqlConnection scon = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("GetCredentialByLogin", scon))
                {

                    #region sParams
                    SqlParameter[] sParams =
                    {
                                    new SqlParameter()
                                    {
                                        ParameterName = "@login",
                                        SqlDbType = SqlDbType.NVarChar,
                                        Size = 50,
                                        Value = u.Login
                                    },
                                    new SqlParameter()
                                    {
                                        ParameterName = "@ID",
                                        SqlDbType = SqlDbType.Int,
                                        Value = u.ID,
                                        Direction = ParameterDirection.Output
                                    },
                                    new SqlParameter()
                                    {
                                        ParameterName = "@password",
                                        SqlDbType = SqlDbType.NVarChar,
                                        Size = 64,
                                        Value = u.Password,
                                        Direction = ParameterDirection.Output
                                    },
                                    new SqlParameter()
                                    {
                                        ParameterName = "@role",
                                        SqlDbType = SqlDbType.Int,
                                        Value = u._Role.ID,
                                        Direction = ParameterDirection.Output
                                    }
                                };
                    #endregion

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(sParams);
                    scon.Open();
                    cmd.ExecuteNonQuery();
                    try
                    {
                        u.ID = (int)cmd.Parameters["@ID"].Value;
                        u.Password = (string)cmd.Parameters["@password"].Value;
                        u._Role.ID = (int)cmd.Parameters["@role"].Value;
                    }
                    catch
                    {
                        u = null;
                    }

                }
            }
            if (u != null)
            {
                u._Role = this.GetRoleByID(u._Role.ID);
            }
            return u;
        }
        public Roles GetRoleByID(int ID)
        {
            var u = new Roles()
            {
                ID = ID
            };
            using (SqlConnection scon = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("GetRoleByID", scon))
                {

                    #region sParams
                    SqlParameter[] sParams =
                    {
                                    new SqlParameter()
                                    {
                                        ParameterName = "@ID",
                                        SqlDbType = SqlDbType.Int,
                                        Value = u.ID
                                    },
                                    new SqlParameter()
                                    {
                                        ParameterName = "@NameRole",
                                        SqlDbType = SqlDbType.NVarChar,
                                        Size = 50,
                                        Value = u.NameRole,
                                        Direction = ParameterDirection.Output
                                    }
                                };
                    #endregion

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(sParams);
                    scon.Open();
                    cmd.ExecuteNonQuery();
                    try
                    {
                        u.ID = (int)cmd.Parameters["@ID"].Value;
                        u.NameRole = (string)cmd.Parameters["@NameRole"].Value;
                    }
                    catch
                    {
                        u = null;
                    }

                }
            }
            return u;
        }

        public void UpdatePatient(Patient p)
        {
            using (SqlConnection scon = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("UpdatePatients", scon))
                {
                    #region sParams
                    SqlParameter[] sParams =
                    {
                        new SqlParameter()
                        {
                            ParameterName = "@id",
                            SqlDbType = SqlDbType.Int,
                            Value = p.ID
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@fullname",
                            SqlDbType = SqlDbType.NVarChar,
                            Size = 50,
                            Value = p.FullName
                        },
                        new SqlParameter()
                         {
                            ParameterName = "@birthday",
                            SqlDbType = SqlDbType.Date,
                            Value = p.BirthDay
                        },
                        new SqlParameter()
                         {
                            ParameterName = "@gender",
                            SqlDbType = SqlDbType.NVarChar,
                            Size = 50,
                            Value = p.Gender
                        },
                         new SqlParameter()
                         {
                            ParameterName = "@address",
                            SqlDbType = SqlDbType.NVarChar,
                            Size = -1,
                            Value = p.Address
                        },
                         new SqlParameter()
                         {
                            ParameterName = "@phonenumer",
                            SqlDbType = SqlDbType.NVarChar,
                            Size = 50,
                            Value = p.PhoneNumer
                         },
                          new SqlParameter()
                         {
                            ParameterName = "@cardnumer",
                            SqlDbType = SqlDbType.Int,
                            Value = p.CardNumer
                         }
                    };
                    #endregion

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(sParams);
                    scon.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateDoctor(Doctor d)
        {
            using (SqlConnection scon = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("UpdateDoctor", scon))
                {
                    #region sParams
                    SqlParameter[] sParams =
                    {
                        new SqlParameter()
                        {
                            ParameterName = "@id",
                            SqlDbType = SqlDbType.Int,
                            Value = d.ID
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@fullname",
                            SqlDbType = SqlDbType.NVarChar,
                            Size = 50,
                            Value = d.FullName
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@spetialisation",
                            SqlDbType = SqlDbType.NVarChar,
                            Size = 50,
                            Value = d.Spetialisation
                        },
                        new SqlParameter()
                         {
                            ParameterName = "@birthday",
                            SqlDbType = SqlDbType.Date,
                            Value = d.BirthDay
                        },
                         new SqlParameter()
                         {
                            ParameterName = "@employmentDate",
                            SqlDbType = SqlDbType.Date,
                            Value = d.EmploymentDate
                        },
                         new SqlParameter()
                        {
                            ParameterName = "@cabinetNumber",
                            SqlDbType = SqlDbType.Int,
                            Value = d.CabinetNumber
                        },
                         new SqlParameter()
                        {
                            ParameterName = "@shedule",
                            SqlDbType = SqlDbType.Int,
                            Value = d._Schedule
                        },
                    };
                    #endregion

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(sParams);
                    scon.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateVisit(Visit v)
        {
            using (SqlConnection scon = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("UpdateVisit", scon))
                {
                    #region sParams
                    SqlParameter[] sParams =
                    {
                        new SqlParameter()
                        {
                            ParameterName = "@id",
                            SqlDbType = SqlDbType.Int,
                            Value = v.ID
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@numberCard",
                            SqlDbType = SqlDbType.NVarChar,
                            Size = 50,
                            Value = v.NumberCard
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@data",
                            SqlDbType = SqlDbType.Date,
                            Value = v.Data
                        },
                        new SqlParameter()
                         {
                            ParameterName = "@doctorID",
                            SqlDbType = SqlDbType.Int,
                            Value = v.DoctorID
                        },
                         new SqlParameter()
                         {
                            ParameterName = "@patientID",
                            SqlDbType = SqlDbType.Int,
                            Value = v.PatientID
                        },
                         new SqlParameter()
                        {
                            ParameterName = "@diagnosisID",
                            SqlDbType = SqlDbType.Int,
                            Value = v.DiagnosisID
                        },
                    };
                    #endregion

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(sParams);
                    scon.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateDiagnose(Diseases d)
        {
            using (SqlConnection scon = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("UpdateDiagnose", scon))
                {
                    #region sParams
                    SqlParameter[] sParams =
                    {
                        new SqlParameter()
                        {
                            ParameterName = "@id",
                            SqlDbType = SqlDbType.Int,
                            Value = d.ID
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@name",
                            SqlDbType = SqlDbType.NVarChar,
                            Size = 50,
                            Value = d.Name
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@description",
                            SqlDbType = SqlDbType.NVarChar,
                            Size = 50,
                            Value = d.Description
                        },
                    };
                    #endregion

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(sParams);
                    scon.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateMedicine(Medicines m)
        {
            using (SqlConnection scon = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("UpdateMedicine", scon))
                {
                    #region sParams
                    SqlParameter[] sParams =
                    {
                        new SqlParameter()
                        {
                            ParameterName = "@id",
                            SqlDbType = SqlDbType.Int,
                            Value = m.ID
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@name",
                            SqlDbType = SqlDbType.NVarChar,
                            Size = 50,
                            Value = m.Name
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@diagnosisID",
                            SqlDbType = SqlDbType.Int,
                            Value = m._Diagnosis.ID
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@description",
                            SqlDbType = SqlDbType.NVarChar,
                            Size = 50,
                            Value = m.Description
                        },
                    };
                    #endregion

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(sParams);
                    scon.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateSchedule(Schedule s)
        {
            using (SqlConnection scon = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("UpdateSchedule", scon))
                {
                    #region sParams
                    SqlParameter[] sParams =
                    {
                        new SqlParameter()
                        {
                            ParameterName = "@id",
                            SqlDbType = SqlDbType.Int,
                            Value = s.ID
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@data",
                            SqlDbType = SqlDbType.Date,
                            Value = s.Data
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@cabinetnumber",
                            SqlDbType = SqlDbType.Int,
                            Value = s.CabinetNumber
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@starttime",
                            SqlDbType = SqlDbType.DateTime,
                            Value = s.StartTime
                        },
                         new SqlParameter()
                        {
                            ParameterName = "@endtime",
                            SqlDbType = SqlDbType.DateTime,
                            Value = s.EndTime
                        },
                    };
                    #endregion

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(sParams);
                    scon.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool DeleteSedule(int value)
        {
            using (SqlConnection scon = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("DeleteSchedule", scon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@ID",
                        SqlDbType = SqlDbType.Int,
                        Value = value
                    });
                    scon.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            return true; //!!!
        }

       
        public int AddSchedule(Schedule s)
        {
            int ID = 0;
            using (SqlConnection scon = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("CreateNewSchedule", scon))
                {
                    #region sParams
                    SqlParameter[] sParams =
                    {
                        new SqlParameter()
                        {
                            ParameterName = "@data",
                            SqlDbType = SqlDbType.Date,
                            Value = s.Data
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@cabinetNumber",
                            SqlDbType = SqlDbType.Int,
                            Value = s.CabinetNumber
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@startTime",
                            SqlDbType = SqlDbType.DateTime,
                            Value = s.StartTime
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@endTime",
                            SqlDbType = SqlDbType.DateTime,
                            Value = s.EndTime
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@id",
                            SqlDbType = SqlDbType.Int,
                            Value = s.ID,
                            Direction = ParameterDirection.Output
                        }
                    };
                    #endregion

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(sParams);
                    scon.Open();
                    cmd.ExecuteNonQuery();
                    ID = (int)cmd.Parameters["@id"].Value;
                }
            }
            return ID;
        }

        public bool DeletePatient(int ID)
        {
            using (SqlConnection scon = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("DeletePatients", scon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@ID",
                        SqlDbType = SqlDbType.Int,
                        Value = ID
                    });
                    scon.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            return true; //!!!
        }

        public void UpdateSpetialisations(Spetialisations s)
        {
            using (SqlConnection scon = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("UpdateSpetialisations", scon))
                {
                    #region sParams
                    SqlParameter[] sParams =
                    {
                        new SqlParameter()
                        {
                            ParameterName = "@id",
                            SqlDbType = SqlDbType.Int,
                            Value = s.ID
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@name",
                            SqlDbType = SqlDbType.NVarChar,
                            Size = 50,
                            Value = s.Name
                        },                        
                    };
                    #endregion

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(sParams);
                    scon.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool DeleteSpetialisations(int ID)
        {
            using (SqlConnection scon = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("DeleteSpetialisations", scon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@ID",
                        SqlDbType = SqlDbType.Int,
                        Value = ID
                    });
                    scon.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            return true; //!!!
        }

        public int AddSpetialisations(Spetialisations s)
        {
            int ID = 0;
            using (SqlConnection scon = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("CreateNewSpetialisations", scon))
                {
                    #region sParams
                    SqlParameter[] sParams =
                    {                        
                        new SqlParameter()
                        {
                            ParameterName = "@name",
                            SqlDbType = SqlDbType.NVarChar,
                            Size = 50,
                            Value = s.Name
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@id",
                            SqlDbType = SqlDbType.Int,
                            Value = s.ID,
                            Direction = ParameterDirection.Output
                        }
                    };
                    #endregion

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(sParams);
                    scon.Open();
                    cmd.ExecuteNonQuery();
                    ID = (int)cmd.Parameters["@id"].Value;
                }
            }
            return ID;
        }

        public void AddLog(string message)
        {
            using (SqlConnection scon = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("AddLog", scon))
                {
                    #region sParams
                    SqlParameter[] sParams =
                    {
                        new SqlParameter()
                        {
                            ParameterName = "@message",
                            SqlDbType = SqlDbType.NVarChar,
                            Size = -1,
                            Value = message
                        }
                    };
                    #endregion
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(sParams);
                    scon.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

