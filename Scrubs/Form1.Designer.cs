namespace Scrubs
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.auth_but_login = new System.Windows.Forms.Button();
            this.auth_login = new System.Windows.Forms.TextBox();
            this.auth_password = new System.Windows.Forms.TextBox();
            this.auth_but_logout = new System.Windows.Forms.Button();
            this.tcTabs = new System.Windows.Forms.TabControl();
            this.Patients = new System.Windows.Forms.TabPage();
            this.butAddPatient = new System.Windows.Forms.Button();
            this.butDeletePatient = new System.Windows.Forms.Button();
            this.butUpdatePatient = new System.Windows.Forms.Button();
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.IDPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullNamePatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BithdayPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenderPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumerPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardNumerPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doctors = new System.Windows.Forms.TabPage();
            this.butAddDoctor = new System.Windows.Forms.Button();
            this.butDeleteDoctor = new System.Windows.Forms.Button();
            this.butUpdateDoctor = new System.Windows.Forms.Button();
            this.dgvDoctors = new System.Windows.Forms.DataGridView();
            this.IDDoctors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullNameDoctors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpetialisationDoctors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthdayDoctors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmploymentDateDoctors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CabinetNumberDoctors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SheduleDoctorsCredantials = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListsOfVisit = new System.Windows.Forms.TabPage();
            this.butAddVisit = new System.Windows.Forms.Button();
            this.butDeleteVisit = new System.Windows.Forms.Button();
            this.butUpdateVisit = new System.Windows.Forms.Button();
            this.dgvVisit = new System.Windows.Forms.DataGridView();
            this.IDListOfVisit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberCardListOfVisit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataListOfVisit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorIDListOfVisit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientIDListOfVisit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiagnosisIDListOfVisit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListsOfDiseases = new System.Windows.Forms.TabPage();
            this.butAddDiagnose = new System.Windows.Forms.Button();
            this.butDeleteDiagnose = new System.Windows.Forms.Button();
            this.butUpdateDiagnose = new System.Windows.Forms.Button();
            this.dgvDiagnos = new System.Windows.Forms.DataGridView();
            this.IDListsOfDiseases = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameListsOfDiseases = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionListsOfDiseases = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medicines = new System.Windows.Forms.TabPage();
            this.butAddMedicine = new System.Windows.Forms.Button();
            this.butDeleteMedicine = new System.Windows.Forms.Button();
            this.butUpdateMedicine = new System.Windows.Forms.Button();
            this.dgvMed = new System.Windows.Forms.DataGridView();
            this.IDMedicines = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameMedicines = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiagnosisIDMedicines = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionMedicines = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shedules = new System.Windows.Forms.TabPage();
            this.butAddShedule = new System.Windows.Forms.Button();
            this.butDeleteShedule = new System.Windows.Forms.Button();
            this.butUpdateShedule = new System.Windows.Forms.Button();
            this.dgvShedule = new System.Windows.Forms.DataGridView();
            this.IDShedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataShedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CabinetNumberShedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTimeShedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTimeShedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcTabs.SuspendLayout();
            this.Patients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.Doctors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).BeginInit();
            this.ListsOfVisit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisit)).BeginInit();
            this.ListsOfDiseases.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnos)).BeginInit();
            this.Medicines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMed)).BeginInit();
            this.Shedules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShedule)).BeginInit();
            this.SuspendLayout();
            // 
            // auth_but_login
            // 
            this.auth_but_login.Location = new System.Drawing.Point(12, 65);
            this.auth_but_login.Name = "auth_but_login";
            this.auth_but_login.Size = new System.Drawing.Size(75, 23);
            this.auth_but_login.TabIndex = 0;
            this.auth_but_login.Text = "Вход";
            this.auth_but_login.UseVisualStyleBackColor = true;
            this.auth_but_login.Click += new System.EventHandler(this.auth_but_login_Click);
            // 
            // auth_login
            // 
            this.auth_login.Location = new System.Drawing.Point(12, 12);
            this.auth_login.Name = "auth_login";
            this.auth_login.Size = new System.Drawing.Size(100, 20);
            this.auth_login.TabIndex = 1;
            this.auth_login.Text = "Login";
            // 
            // auth_password
            // 
            this.auth_password.Location = new System.Drawing.Point(12, 39);
            this.auth_password.Name = "auth_password";
            this.auth_password.Size = new System.Drawing.Size(100, 20);
            this.auth_password.TabIndex = 2;
            this.auth_password.Text = "Password";
            // 
            // auth_but_logout
            // 
            this.auth_but_logout.Location = new System.Drawing.Point(13, 95);
            this.auth_but_logout.Name = "auth_but_logout";
            this.auth_but_logout.Size = new System.Drawing.Size(75, 23);
            this.auth_but_logout.TabIndex = 3;
            this.auth_but_logout.Text = "Выход";
            this.auth_but_logout.UseVisualStyleBackColor = true;
            this.auth_but_logout.Visible = false;
            this.auth_but_logout.Click += new System.EventHandler(this.auth_but_logout_Click);
            // 
            // tcTabs
            // 
            this.tcTabs.Controls.Add(this.Patients);
            this.tcTabs.Controls.Add(this.Doctors);
            this.tcTabs.Controls.Add(this.ListsOfVisit);
            this.tcTabs.Controls.Add(this.ListsOfDiseases);
            this.tcTabs.Controls.Add(this.Medicines);
            this.tcTabs.Controls.Add(this.Shedules);
            this.tcTabs.Location = new System.Drawing.Point(118, 12);
            this.tcTabs.Name = "tcTabs";
            this.tcTabs.SelectedIndex = 0;
            this.tcTabs.Size = new System.Drawing.Size(886, 294);
            this.tcTabs.TabIndex = 8;
            this.tcTabs.Visible = false;
            // 
            // Patients
            // 
            this.Patients.Controls.Add(this.butAddPatient);
            this.Patients.Controls.Add(this.butDeletePatient);
            this.Patients.Controls.Add(this.butUpdatePatient);
            this.Patients.Controls.Add(this.dgvPatients);
            this.Patients.Location = new System.Drawing.Point(4, 22);
            this.Patients.Name = "Patients";
            this.Patients.Padding = new System.Windows.Forms.Padding(3);
            this.Patients.Size = new System.Drawing.Size(878, 268);
            this.Patients.TabIndex = 0;
            this.Patients.Text = "Пациены";
            this.Patients.UseVisualStyleBackColor = true;
            // 
            // butAddPatient
            // 
            this.butAddPatient.Location = new System.Drawing.Point(210, 158);
            this.butAddPatient.Name = "butAddPatient";
            this.butAddPatient.Size = new System.Drawing.Size(75, 23);
            this.butAddPatient.TabIndex = 2;
            this.butAddPatient.Text = "Add";
            this.butAddPatient.UseVisualStyleBackColor = true;
            this.butAddPatient.Click += new System.EventHandler(this.butAddPatient_Click);
            // 
            // butDeletePatient
            // 
            this.butDeletePatient.Location = new System.Drawing.Point(99, 158);
            this.butDeletePatient.Name = "butDeletePatient";
            this.butDeletePatient.Size = new System.Drawing.Size(75, 23);
            this.butDeletePatient.TabIndex = 1;
            this.butDeletePatient.Text = "Delete";
            this.butDeletePatient.UseVisualStyleBackColor = true;
            this.butDeletePatient.Click += new System.EventHandler(this.butDeletePatient_Click);
            // 
            // butUpdatePatient
            // 
            this.butUpdatePatient.Location = new System.Drawing.Point(6, 158);
            this.butUpdatePatient.Name = "butUpdatePatient";
            this.butUpdatePatient.Size = new System.Drawing.Size(75, 23);
            this.butUpdatePatient.TabIndex = 1;
            this.butUpdatePatient.Text = "Update";
            this.butUpdatePatient.UseVisualStyleBackColor = true;
            this.butUpdatePatient.Click += new System.EventHandler(this.butUpdatePatient_Click);
            // 
            // dgvPatients
            // 
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPatient,
            this.FullNamePatient,
            this.BithdayPatient,
            this.GenderPatient,
            this.AddressPatient,
            this.PhoneNumerPatient,
            this.CardNumerPatient});
            this.dgvPatients.Location = new System.Drawing.Point(-4, 3);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.Size = new System.Drawing.Size(759, 149);
            this.dgvPatients.TabIndex = 0;
            this.dgvPatients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // IDPatient
            // 
            this.IDPatient.HeaderText = "ID";
            this.IDPatient.Name = "IDPatient";
            this.IDPatient.ReadOnly = true;
            // 
            // FullNamePatient
            // 
            this.FullNamePatient.HeaderText = "FullName";
            this.FullNamePatient.Name = "FullNamePatient";
            // 
            // BithdayPatient
            // 
            this.BithdayPatient.HeaderText = "Bithday";
            this.BithdayPatient.Name = "BithdayPatient";
            // 
            // GenderPatient
            // 
            this.GenderPatient.HeaderText = "Gender";
            this.GenderPatient.Name = "GenderPatient";
            // 
            // AddressPatient
            // 
            this.AddressPatient.HeaderText = "Address";
            this.AddressPatient.Name = "AddressPatient";
            // 
            // PhoneNumerPatient
            // 
            this.PhoneNumerPatient.HeaderText = "PhoneNumber";
            this.PhoneNumerPatient.Name = "PhoneNumerPatient";
            // 
            // CardNumerPatient
            // 
            this.CardNumerPatient.HeaderText = "CardNumber";
            this.CardNumerPatient.Name = "CardNumerPatient";
            // 
            // Doctors
            // 
            this.Doctors.Controls.Add(this.butAddDoctor);
            this.Doctors.Controls.Add(this.butDeleteDoctor);
            this.Doctors.Controls.Add(this.butUpdateDoctor);
            this.Doctors.Controls.Add(this.dgvDoctors);
            this.Doctors.Location = new System.Drawing.Point(4, 22);
            this.Doctors.Name = "Doctors";
            this.Doctors.Padding = new System.Windows.Forms.Padding(3);
            this.Doctors.Size = new System.Drawing.Size(878, 268);
            this.Doctors.TabIndex = 1;
            this.Doctors.Text = "Doctors";
            this.Doctors.UseVisualStyleBackColor = true;
            // 
            // butAddDoctor
            // 
            this.butAddDoctor.Location = new System.Drawing.Point(183, 157);
            this.butAddDoctor.Name = "butAddDoctor";
            this.butAddDoctor.Size = new System.Drawing.Size(75, 23);
            this.butAddDoctor.TabIndex = 3;
            this.butAddDoctor.Text = "Add";
            this.butAddDoctor.UseVisualStyleBackColor = true;
            this.butAddDoctor.Click += new System.EventHandler(this.butAddDoctor_Click);
            // 
            // butDeleteDoctor
            // 
            this.butDeleteDoctor.Location = new System.Drawing.Point(90, 157);
            this.butDeleteDoctor.Name = "butDeleteDoctor";
            this.butDeleteDoctor.Size = new System.Drawing.Size(75, 23);
            this.butDeleteDoctor.TabIndex = 1;
            this.butDeleteDoctor.Text = "DELETE";
            this.butDeleteDoctor.UseVisualStyleBackColor = true;
            this.butDeleteDoctor.Click += new System.EventHandler(this.butDeleteDoctor_Click);
            // 
            // butUpdateDoctor
            // 
            this.butUpdateDoctor.Location = new System.Drawing.Point(9, 157);
            this.butUpdateDoctor.Name = "butUpdateDoctor";
            this.butUpdateDoctor.Size = new System.Drawing.Size(75, 23);
            this.butUpdateDoctor.TabIndex = 1;
            this.butUpdateDoctor.Text = "UPDATE";
            this.butUpdateDoctor.UseVisualStyleBackColor = true;
            this.butUpdateDoctor.Click += new System.EventHandler(this.butUpdateDoctor_Click);
            // 
            // dgvDoctors
            // 
            this.dgvDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDDoctors,
            this.FullNameDoctors,
            this.SpetialisationDoctors,
            this.BirthdayDoctors,
            this.EmploymentDateDoctors,
            this.CabinetNumberDoctors,
            this.SheduleDoctorsCredantials});
            this.dgvDoctors.Location = new System.Drawing.Point(9, 3);
            this.dgvDoctors.Name = "dgvDoctors";
            this.dgvDoctors.Size = new System.Drawing.Size(702, 137);
            this.dgvDoctors.TabIndex = 0;
            // 
            // IDDoctors
            // 
            this.IDDoctors.HeaderText = "ID";
            this.IDDoctors.Name = "IDDoctors";
            this.IDDoctors.ReadOnly = true;
            // 
            // FullNameDoctors
            // 
            this.FullNameDoctors.HeaderText = "FullName";
            this.FullNameDoctors.Name = "FullNameDoctors";
            // 
            // SpetialisationDoctors
            // 
            this.SpetialisationDoctors.HeaderText = "Spetialisation";
            this.SpetialisationDoctors.Name = "SpetialisationDoctors";
            // 
            // BirthdayDoctors
            // 
            this.BirthdayDoctors.HeaderText = "Birthday";
            this.BirthdayDoctors.Name = "BirthdayDoctors";
            // 
            // EmploymentDateDoctors
            // 
            this.EmploymentDateDoctors.HeaderText = "EmploymentDate";
            this.EmploymentDateDoctors.Name = "EmploymentDateDoctors";
            // 
            // CabinetNumberDoctors
            // 
            this.CabinetNumberDoctors.HeaderText = "CabinetNumber";
            this.CabinetNumberDoctors.Name = "CabinetNumberDoctors";
            // 
            // SheduleDoctorsCredantials
            // 
            this.SheduleDoctorsCredantials.HeaderText = "Shedule";
            this.SheduleDoctorsCredantials.Name = "SheduleDoctorsCredantials";
            // 
            // ListsOfVisit
            // 
            this.ListsOfVisit.Controls.Add(this.butAddVisit);
            this.ListsOfVisit.Controls.Add(this.butDeleteVisit);
            this.ListsOfVisit.Controls.Add(this.butUpdateVisit);
            this.ListsOfVisit.Controls.Add(this.dgvVisit);
            this.ListsOfVisit.Location = new System.Drawing.Point(4, 22);
            this.ListsOfVisit.Name = "ListsOfVisit";
            this.ListsOfVisit.Size = new System.Drawing.Size(878, 268);
            this.ListsOfVisit.TabIndex = 2;
            this.ListsOfVisit.Text = "СписокПосещений";
            this.ListsOfVisit.UseVisualStyleBackColor = true;
            // 
            // butAddVisit
            // 
            this.butAddVisit.Location = new System.Drawing.Point(192, 175);
            this.butAddVisit.Name = "butAddVisit";
            this.butAddVisit.Size = new System.Drawing.Size(75, 23);
            this.butAddVisit.TabIndex = 4;
            this.butAddVisit.Text = "Add";
            this.butAddVisit.UseVisualStyleBackColor = true;
            this.butAddVisit.Click += new System.EventHandler(this.butAddVisit_Click);
            // 
            // butDeleteVisit
            // 
            this.butDeleteVisit.Location = new System.Drawing.Point(94, 175);
            this.butDeleteVisit.Name = "butDeleteVisit";
            this.butDeleteVisit.Size = new System.Drawing.Size(75, 23);
            this.butDeleteVisit.TabIndex = 2;
            this.butDeleteVisit.Text = "DELETE";
            this.butDeleteVisit.UseVisualStyleBackColor = true;
            this.butDeleteVisit.Click += new System.EventHandler(this.butDeleteVisit_Click);
            // 
            // butUpdateVisit
            // 
            this.butUpdateVisit.Location = new System.Drawing.Point(13, 175);
            this.butUpdateVisit.Name = "butUpdateVisit";
            this.butUpdateVisit.Size = new System.Drawing.Size(75, 23);
            this.butUpdateVisit.TabIndex = 3;
            this.butUpdateVisit.Text = "UPDATE";
            this.butUpdateVisit.UseVisualStyleBackColor = true;
            this.butUpdateVisit.Click += new System.EventHandler(this.butUpdateVisit_Click);
            // 
            // dgvVisit
            // 
            this.dgvVisit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDListOfVisit,
            this.NumberCardListOfVisit,
            this.DataListOfVisit,
            this.DoctorIDListOfVisit,
            this.PatientIDListOfVisit,
            this.DiagnosisIDListOfVisit});
            this.dgvVisit.Location = new System.Drawing.Point(13, 5);
            this.dgvVisit.Name = "dgvVisit";
            this.dgvVisit.Size = new System.Drawing.Size(662, 150);
            this.dgvVisit.TabIndex = 0;
            // 
            // IDListOfVisit
            // 
            this.IDListOfVisit.HeaderText = "ID";
            this.IDListOfVisit.Name = "IDListOfVisit";
            this.IDListOfVisit.ReadOnly = true;
            // 
            // NumberCardListOfVisit
            // 
            this.NumberCardListOfVisit.HeaderText = "NumberCard";
            this.NumberCardListOfVisit.Name = "NumberCardListOfVisit";
            // 
            // DataListOfVisit
            // 
            this.DataListOfVisit.HeaderText = "Data";
            this.DataListOfVisit.Name = "DataListOfVisit";
            // 
            // DoctorIDListOfVisit
            // 
            this.DoctorIDListOfVisit.HeaderText = "DoctorID";
            this.DoctorIDListOfVisit.Name = "DoctorIDListOfVisit";
            // 
            // PatientIDListOfVisit
            // 
            this.PatientIDListOfVisit.HeaderText = "PatientID";
            this.PatientIDListOfVisit.Name = "PatientIDListOfVisit";
            // 
            // DiagnosisIDListOfVisit
            // 
            this.DiagnosisIDListOfVisit.HeaderText = "DiagnosisID";
            this.DiagnosisIDListOfVisit.Name = "DiagnosisIDListOfVisit";
            // 
            // ListsOfDiseases
            // 
            this.ListsOfDiseases.Controls.Add(this.butAddDiagnose);
            this.ListsOfDiseases.Controls.Add(this.butDeleteDiagnose);
            this.ListsOfDiseases.Controls.Add(this.butUpdateDiagnose);
            this.ListsOfDiseases.Controls.Add(this.dgvDiagnos);
            this.ListsOfDiseases.Location = new System.Drawing.Point(4, 22);
            this.ListsOfDiseases.Name = "ListsOfDiseases";
            this.ListsOfDiseases.Size = new System.Drawing.Size(878, 268);
            this.ListsOfDiseases.TabIndex = 4;
            this.ListsOfDiseases.Text = "СписокДиагнозов";
            this.ListsOfDiseases.UseVisualStyleBackColor = true;
            // 
            // butAddDiagnose
            // 
            this.butAddDiagnose.Location = new System.Drawing.Point(176, 159);
            this.butAddDiagnose.Name = "butAddDiagnose";
            this.butAddDiagnose.Size = new System.Drawing.Size(75, 23);
            this.butAddDiagnose.TabIndex = 6;
            this.butAddDiagnose.Text = "Add";
            this.butAddDiagnose.UseVisualStyleBackColor = true;
            this.butAddDiagnose.Click += new System.EventHandler(this.butAddDiagnose_Click);
            // 
            // butDeleteDiagnose
            // 
            this.butDeleteDiagnose.Location = new System.Drawing.Point(84, 159);
            this.butDeleteDiagnose.Name = "butDeleteDiagnose";
            this.butDeleteDiagnose.Size = new System.Drawing.Size(75, 23);
            this.butDeleteDiagnose.TabIndex = 4;
            this.butDeleteDiagnose.Text = "DELETE";
            this.butDeleteDiagnose.UseVisualStyleBackColor = true;
            this.butDeleteDiagnose.Click += new System.EventHandler(this.butDeleteDiagnose_Click);
            // 
            // butUpdateDiagnose
            // 
            this.butUpdateDiagnose.Location = new System.Drawing.Point(3, 159);
            this.butUpdateDiagnose.Name = "butUpdateDiagnose";
            this.butUpdateDiagnose.Size = new System.Drawing.Size(75, 23);
            this.butUpdateDiagnose.TabIndex = 5;
            this.butUpdateDiagnose.Text = "UPDATE";
            this.butUpdateDiagnose.UseVisualStyleBackColor = true;
            this.butUpdateDiagnose.Click += new System.EventHandler(this.butUpdateDiagnose_Click);
            // 
            // dgvDiagnos
            // 
            this.dgvDiagnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiagnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDListsOfDiseases,
            this.NameListsOfDiseases,
            this.DescriptionListsOfDiseases});
            this.dgvDiagnos.Location = new System.Drawing.Point(3, 3);
            this.dgvDiagnos.Name = "dgvDiagnos";
            this.dgvDiagnos.Size = new System.Drawing.Size(583, 150);
            this.dgvDiagnos.TabIndex = 0;
            // 
            // IDListsOfDiseases
            // 
            this.IDListsOfDiseases.HeaderText = "ID";
            this.IDListsOfDiseases.Name = "IDListsOfDiseases";
            this.IDListsOfDiseases.ReadOnly = true;
            // 
            // NameListsOfDiseases
            // 
            this.NameListsOfDiseases.HeaderText = "Name";
            this.NameListsOfDiseases.Name = "NameListsOfDiseases";
            // 
            // DescriptionListsOfDiseases
            // 
            this.DescriptionListsOfDiseases.HeaderText = "Description";
            this.DescriptionListsOfDiseases.Name = "DescriptionListsOfDiseases";
            // 
            // Medicines
            // 
            this.Medicines.Controls.Add(this.butAddMedicine);
            this.Medicines.Controls.Add(this.butDeleteMedicine);
            this.Medicines.Controls.Add(this.butUpdateMedicine);
            this.Medicines.Controls.Add(this.dgvMed);
            this.Medicines.Location = new System.Drawing.Point(4, 22);
            this.Medicines.Name = "Medicines";
            this.Medicines.Size = new System.Drawing.Size(878, 268);
            this.Medicines.TabIndex = 5;
            this.Medicines.Text = "Медикаменты";
            this.Medicines.UseVisualStyleBackColor = true;
            // 
            // butAddMedicine
            // 
            this.butAddMedicine.Location = new System.Drawing.Point(191, 161);
            this.butAddMedicine.Name = "butAddMedicine";
            this.butAddMedicine.Size = new System.Drawing.Size(75, 23);
            this.butAddMedicine.TabIndex = 8;
            this.butAddMedicine.Text = "Add";
            this.butAddMedicine.UseVisualStyleBackColor = true;
            this.butAddMedicine.Click += new System.EventHandler(this.butAddMedicine_Click);
            // 
            // butDeleteMedicine
            // 
            this.butDeleteMedicine.Location = new System.Drawing.Point(93, 161);
            this.butDeleteMedicine.Name = "butDeleteMedicine";
            this.butDeleteMedicine.Size = new System.Drawing.Size(75, 23);
            this.butDeleteMedicine.TabIndex = 6;
            this.butDeleteMedicine.Text = "DELETE";
            this.butDeleteMedicine.UseVisualStyleBackColor = true;
            this.butDeleteMedicine.Click += new System.EventHandler(this.butDeleteMedicine_Click);
            // 
            // butUpdateMedicine
            // 
            this.butUpdateMedicine.Location = new System.Drawing.Point(12, 161);
            this.butUpdateMedicine.Name = "butUpdateMedicine";
            this.butUpdateMedicine.Size = new System.Drawing.Size(75, 23);
            this.butUpdateMedicine.TabIndex = 7;
            this.butUpdateMedicine.Text = "UPDATE";
            this.butUpdateMedicine.UseVisualStyleBackColor = true;
            this.butUpdateMedicine.Click += new System.EventHandler(this.butUpdateMedicine_Click);
            // 
            // dgvMed
            // 
            this.dgvMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDMedicines,
            this.NameMedicines,
            this.DiagnosisIDMedicines,
            this.DescriptionMedicines});
            this.dgvMed.Location = new System.Drawing.Point(12, 5);
            this.dgvMed.Name = "dgvMed";
            this.dgvMed.Size = new System.Drawing.Size(569, 150);
            this.dgvMed.TabIndex = 0;
            // 
            // IDMedicines
            // 
            this.IDMedicines.HeaderText = "ID";
            this.IDMedicines.Name = "IDMedicines";
            this.IDMedicines.ReadOnly = true;
            // 
            // NameMedicines
            // 
            this.NameMedicines.HeaderText = "Name";
            this.NameMedicines.Name = "NameMedicines";
            // 
            // DiagnosisIDMedicines
            // 
            this.DiagnosisIDMedicines.HeaderText = "DiagnosisID";
            this.DiagnosisIDMedicines.Name = "DiagnosisIDMedicines";
            // 
            // DescriptionMedicines
            // 
            this.DescriptionMedicines.HeaderText = "Description";
            this.DescriptionMedicines.Name = "DescriptionMedicines";
            // 
            // Shedules
            // 
            this.Shedules.Controls.Add(this.butAddShedule);
            this.Shedules.Controls.Add(this.butDeleteShedule);
            this.Shedules.Controls.Add(this.butUpdateShedule);
            this.Shedules.Controls.Add(this.dgvShedule);
            this.Shedules.Location = new System.Drawing.Point(4, 22);
            this.Shedules.Name = "Shedules";
            this.Shedules.Size = new System.Drawing.Size(878, 268);
            this.Shedules.TabIndex = 6;
            this.Shedules.Text = "Графики";
            this.Shedules.UseVisualStyleBackColor = true;
            // 
            // butAddShedule
            // 
            this.butAddShedule.Location = new System.Drawing.Point(192, 218);
            this.butAddShedule.Name = "butAddShedule";
            this.butAddShedule.Size = new System.Drawing.Size(75, 23);
            this.butAddShedule.TabIndex = 11;
            this.butAddShedule.Text = "Add";
            this.butAddShedule.UseVisualStyleBackColor = true;
            this.butAddShedule.Click += new System.EventHandler(this.butAddShedule_Click);
            // 
            // butDeleteShedule
            // 
            this.butDeleteShedule.Location = new System.Drawing.Point(94, 218);
            this.butDeleteShedule.Name = "butDeleteShedule";
            this.butDeleteShedule.Size = new System.Drawing.Size(75, 23);
            this.butDeleteShedule.TabIndex = 9;
            this.butDeleteShedule.Text = "DELETE";
            this.butDeleteShedule.UseVisualStyleBackColor = true;
            this.butDeleteShedule.Click += new System.EventHandler(this.butDeleteShedule_Click);
            // 
            // butUpdateShedule
            // 
            this.butUpdateShedule.Location = new System.Drawing.Point(13, 218);
            this.butUpdateShedule.Name = "butUpdateShedule";
            this.butUpdateShedule.Size = new System.Drawing.Size(75, 23);
            this.butUpdateShedule.TabIndex = 10;
            this.butUpdateShedule.Text = "UPDATE";
            this.butUpdateShedule.UseVisualStyleBackColor = true;
            this.butUpdateShedule.Click += new System.EventHandler(this.butUpdateShedule_Click);
            // 
            // dgvShedule
            // 
            this.dgvShedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDShedule,
            this.DataShedule,
            this.CabinetNumberShedule,
            this.StartTimeShedule,
            this.EndTimeShedule});
            this.dgvShedule.Location = new System.Drawing.Point(3, 5);
            this.dgvShedule.Name = "dgvShedule";
            this.dgvShedule.Size = new System.Drawing.Size(565, 180);
            this.dgvShedule.TabIndex = 0;
            // 
            // IDShedule
            // 
            this.IDShedule.HeaderText = "ID";
            this.IDShedule.Name = "IDShedule";
            this.IDShedule.ReadOnly = true;
            // 
            // DataShedule
            // 
            this.DataShedule.HeaderText = "Data";
            this.DataShedule.Name = "DataShedule";
            // 
            // CabinetNumberShedule
            // 
            this.CabinetNumberShedule.HeaderText = "CabinetNumber";
            this.CabinetNumberShedule.Name = "CabinetNumberShedule";
            // 
            // StartTimeShedule
            // 
            this.StartTimeShedule.HeaderText = "StartTime";
            this.StartTimeShedule.Name = "StartTimeShedule";
            // 
            // EndTimeShedule
            // 
            this.EndTimeShedule.HeaderText = "EndTime";
            this.EndTimeShedule.Name = "EndTimeShedule";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 349);
            this.Controls.Add(this.tcTabs);
            this.Controls.Add(this.auth_but_logout);
            this.Controls.Add(this.auth_password);
            this.Controls.Add(this.auth_login);
            this.Controls.Add(this.auth_but_login);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tcTabs.ResumeLayout(false);
            this.Patients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.Doctors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).EndInit();
            this.ListsOfVisit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisit)).EndInit();
            this.ListsOfDiseases.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnos)).EndInit();
            this.Medicines.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMed)).EndInit();
            this.Shedules.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button auth_but_login;
        private System.Windows.Forms.TextBox auth_login;
        private System.Windows.Forms.TextBox auth_password;
        private System.Windows.Forms.Button auth_but_logout;
        private System.Windows.Forms.TabControl tcTabs;
        private System.Windows.Forms.TabPage Patients;
        private System.Windows.Forms.TabPage Doctors;
        private System.Windows.Forms.TabPage ListsOfVisit;
        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullNamePatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn BithdayPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenderPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumerPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardNumerPatient;
        private System.Windows.Forms.DataGridView dgvDoctors;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDoctors;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullNameDoctors;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpetialisationDoctors;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthdayDoctors;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmploymentDateDoctors;
        private System.Windows.Forms.DataGridViewTextBoxColumn CabinetNumberDoctors;
        private System.Windows.Forms.TabPage ListsOfDiseases;
        private System.Windows.Forms.TabPage Medicines;
        private System.Windows.Forms.DataGridView dgvVisit;
        private System.Windows.Forms.DataGridView dgvDiagnos;
        private System.Windows.Forms.DataGridView dgvMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDListOfVisit;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberCardListOfVisit;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataListOfVisit;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorIDListOfVisit;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientIDListOfVisit;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiagnosisIDListOfVisit;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDListsOfDiseases;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameListsOfDiseases;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionListsOfDiseases;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMedicines;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameMedicines;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiagnosisIDMedicines;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionMedicines;
        private System.Windows.Forms.Button butDeletePatient;
        private System.Windows.Forms.Button butUpdatePatient;
        private System.Windows.Forms.Button butDeleteDoctor;
        private System.Windows.Forms.Button butUpdateDoctor;
        private System.Windows.Forms.Button butDeleteVisit;
        private System.Windows.Forms.Button butUpdateVisit;
        private System.Windows.Forms.Button butDeleteDiagnose;
        private System.Windows.Forms.Button butUpdateDiagnose;
        private System.Windows.Forms.Button butDeleteMedicine;
        private System.Windows.Forms.Button butUpdateMedicine;
        private System.Windows.Forms.Button butAddPatient;
        private System.Windows.Forms.Button butAddDoctor;
        private System.Windows.Forms.Button butAddVisit;
        private System.Windows.Forms.Button butAddDiagnose;
        private System.Windows.Forms.Button butAddMedicine;
        private System.Windows.Forms.TabPage Shedules;
        private System.Windows.Forms.Button butAddShedule;
        private System.Windows.Forms.Button butDeleteShedule;
        private System.Windows.Forms.Button butUpdateShedule;
        private System.Windows.Forms.DataGridView dgvShedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDShedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataShedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn CabinetNumberShedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTimeShedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTimeShedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn SheduleDoctorsCredantials;
    }
}

