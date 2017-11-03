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
            this.workBtn = new System.Windows.Forms.Button();
            this.listOfReceptionBtn = new System.Windows.Forms.Button();
            this.cardBtn = new System.Windows.Forms.Button();
            this.patientBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Patients = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.IDPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullNamePatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BithdayPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenderPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumerPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardNumerPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doctors = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.IDDoctors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullNameDoctors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpetialisationDoctors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthdayDoctors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmploymentDateDoctors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CabinetNumberDoctors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListsOfVisit = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.IDListOfVisit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberCardListOfVisit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataListOfVisit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorIDListOfVisit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientIDListOfVisit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiagnosisIDListOfVisit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Schedule = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDShedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataSchedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CabinetNumberSchedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTimeSchedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTimeSchedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListsOfDiseases = new System.Windows.Forms.TabPage();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.IDListsOfDiseases = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameListsOfDiseases = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionListsOfDiseases = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medicines = new System.Windows.Forms.TabPage();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.IDMedicines = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameMedicines = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiagnosisIDMedicines = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionMedicines = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spetialisations = new System.Windows.Forms.TabPage();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.IDSpetialisations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameSpetialisations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.Patients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.Doctors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.ListsOfVisit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.Schedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ListsOfDiseases.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.Medicines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.Spetialisations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
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
            // 
            // workBtn
            // 
            this.workBtn.Location = new System.Drawing.Point(13, 238);
            this.workBtn.Name = "workBtn";
            this.workBtn.Size = new System.Drawing.Size(75, 23);
            this.workBtn.TabIndex = 4;
            this.workBtn.Text = "График работы";
            this.workBtn.UseVisualStyleBackColor = true;
            // 
            // listOfReceptionBtn
            // 
            this.listOfReceptionBtn.Location = new System.Drawing.Point(12, 209);
            this.listOfReceptionBtn.Name = "listOfReceptionBtn";
            this.listOfReceptionBtn.Size = new System.Drawing.Size(75, 23);
            this.listOfReceptionBtn.TabIndex = 5;
            this.listOfReceptionBtn.Text = "Список посещений";
            this.listOfReceptionBtn.UseVisualStyleBackColor = true;
            // 
            // cardBtn
            // 
            this.cardBtn.Location = new System.Drawing.Point(12, 180);
            this.cardBtn.Name = "cardBtn";
            this.cardBtn.Size = new System.Drawing.Size(75, 23);
            this.cardBtn.TabIndex = 6;
            this.cardBtn.Text = "Мед. карты";
            this.cardBtn.UseVisualStyleBackColor = true;
            // 
            // patientBtn
            // 
            this.patientBtn.Location = new System.Drawing.Point(13, 151);
            this.patientBtn.Name = "patientBtn";
            this.patientBtn.Size = new System.Drawing.Size(75, 23);
            this.patientBtn.TabIndex = 7;
            this.patientBtn.Text = "Пациенты";
            this.patientBtn.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Patients);
            this.tabControl1.Controls.Add(this.Doctors);
            this.tabControl1.Controls.Add(this.ListsOfVisit);
            this.tabControl1.Controls.Add(this.Schedule);
            this.tabControl1.Controls.Add(this.ListsOfDiseases);
            this.tabControl1.Controls.Add(this.Medicines);
            this.tabControl1.Controls.Add(this.Spetialisations);
            this.tabControl1.Location = new System.Drawing.Point(118, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(886, 294);
            this.tabControl1.TabIndex = 8;
            // 
            // Patients
            // 
            this.Patients.Controls.Add(this.dataGridView2);
            this.Patients.Location = new System.Drawing.Point(4, 22);
            this.Patients.Name = "Patients";
            this.Patients.Padding = new System.Windows.Forms.Padding(3);
            this.Patients.Size = new System.Drawing.Size(878, 268);
            this.Patients.TabIndex = 0;
            this.Patients.Text = "Пациены";
            this.Patients.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPatient,
            this.FullNamePatient,
            this.BithdayPatient,
            this.GenderPatient,
            this.AddressPatient,
            this.PhoneNumerPatient,
            this.CardNumerPatient});
            this.dataGridView2.Location = new System.Drawing.Point(-4, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(759, 149);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
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
            this.Doctors.Controls.Add(this.dataGridView3);
            this.Doctors.Location = new System.Drawing.Point(4, 22);
            this.Doctors.Name = "Doctors";
            this.Doctors.Padding = new System.Windows.Forms.Padding(3);
            this.Doctors.Size = new System.Drawing.Size(878, 268);
            this.Doctors.TabIndex = 1;
            this.Doctors.Text = "Doctors";
            this.Doctors.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDDoctors,
            this.FullNameDoctors,
            this.SpetialisationDoctors,
            this.BirthdayDoctors,
            this.EmploymentDateDoctors,
            this.CabinetNumberDoctors});
            this.dataGridView3.Location = new System.Drawing.Point(9, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(666, 256);
            this.dataGridView3.TabIndex = 0;
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
            // ListsOfVisit
            // 
            this.ListsOfVisit.Controls.Add(this.dataGridView4);
            this.ListsOfVisit.Location = new System.Drawing.Point(4, 22);
            this.ListsOfVisit.Name = "ListsOfVisit";
            this.ListsOfVisit.Size = new System.Drawing.Size(878, 268);
            this.ListsOfVisit.TabIndex = 2;
            this.ListsOfVisit.Text = "СписокПосещений";
            this.ListsOfVisit.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDListOfVisit,
            this.NumberCardListOfVisit,
            this.DataListOfVisit,
            this.DoctorIDListOfVisit,
            this.PatientIDListOfVisit,
            this.DiagnosisIDListOfVisit});
            this.dataGridView4.Location = new System.Drawing.Point(13, 5);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(662, 150);
            this.dataGridView4.TabIndex = 0;
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
            // Schedule
            // 
            this.Schedule.Controls.Add(this.dataGridView1);
            this.Schedule.Location = new System.Drawing.Point(4, 22);
            this.Schedule.Name = "Schedule";
            this.Schedule.Size = new System.Drawing.Size(878, 268);
            this.Schedule.TabIndex = 3;
            this.Schedule.Text = "График";
            this.Schedule.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDShedule,
            this.DataSchedule,
            this.CabinetNumberSchedule,
            this.StartTimeSchedule,
            this.EndTimeSchedule});
            this.dataGridView1.Location = new System.Drawing.Point(3, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(548, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // IDShedule
            // 
            this.IDShedule.HeaderText = "ID";
            this.IDShedule.Name = "IDShedule";
            this.IDShedule.ReadOnly = true;
            // 
            // DataSchedule
            // 
            this.DataSchedule.HeaderText = "Data";
            this.DataSchedule.Name = "DataSchedule";
            // 
            // CabinetNumberSchedule
            // 
            this.CabinetNumberSchedule.HeaderText = "CabinetNumber";
            this.CabinetNumberSchedule.Name = "CabinetNumberSchedule";
            // 
            // StartTimeSchedule
            // 
            this.StartTimeSchedule.HeaderText = "StartTime";
            this.StartTimeSchedule.Name = "StartTimeSchedule";
            // 
            // EndTimeSchedule
            // 
            this.EndTimeSchedule.HeaderText = "EndTime";
            this.EndTimeSchedule.Name = "EndTimeSchedule";
            // 
            // ListsOfDiseases
            // 
            this.ListsOfDiseases.Controls.Add(this.dataGridView5);
            this.ListsOfDiseases.Location = new System.Drawing.Point(4, 22);
            this.ListsOfDiseases.Name = "ListsOfDiseases";
            this.ListsOfDiseases.Size = new System.Drawing.Size(878, 268);
            this.ListsOfDiseases.TabIndex = 4;
            this.ListsOfDiseases.Text = "СписокДиагнозов";
            this.ListsOfDiseases.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDListsOfDiseases,
            this.NameListsOfDiseases,
            this.DescriptionListsOfDiseases});
            this.dataGridView5.Location = new System.Drawing.Point(3, 3);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(583, 150);
            this.dataGridView5.TabIndex = 0;
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
            this.Medicines.Controls.Add(this.dataGridView6);
            this.Medicines.Location = new System.Drawing.Point(4, 22);
            this.Medicines.Name = "Medicines";
            this.Medicines.Size = new System.Drawing.Size(878, 268);
            this.Medicines.TabIndex = 5;
            this.Medicines.Text = "Медикаменты";
            this.Medicines.UseVisualStyleBackColor = true;
            // 
            // dataGridView6
            // 
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDMedicines,
            this.NameMedicines,
            this.DiagnosisIDMedicines,
            this.DescriptionMedicines});
            this.dataGridView6.Location = new System.Drawing.Point(12, 5);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.Size = new System.Drawing.Size(569, 150);
            this.dataGridView6.TabIndex = 0;
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
            // Spetialisations
            // 
            this.Spetialisations.Controls.Add(this.dataGridView7);
            this.Spetialisations.Location = new System.Drawing.Point(4, 22);
            this.Spetialisations.Name = "Spetialisations";
            this.Spetialisations.Size = new System.Drawing.Size(878, 268);
            this.Spetialisations.TabIndex = 6;
            this.Spetialisations.Text = "Специализация";
            this.Spetialisations.UseVisualStyleBackColor = true;
            // 
            // dataGridView7
            // 
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDSpetialisations,
            this.NameSpetialisations});
            this.dataGridView7.Location = new System.Drawing.Point(3, 3);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.Size = new System.Drawing.Size(566, 150);
            this.dataGridView7.TabIndex = 0;
            // 
            // IDSpetialisations
            // 
            this.IDSpetialisations.HeaderText = "ID";
            this.IDSpetialisations.Name = "IDSpetialisations";
            this.IDSpetialisations.ReadOnly = true;
            // 
            // NameSpetialisations
            // 
            this.NameSpetialisations.HeaderText = "Name";
            this.NameSpetialisations.Name = "NameSpetialisations";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 349);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.patientBtn);
            this.Controls.Add(this.cardBtn);
            this.Controls.Add(this.listOfReceptionBtn);
            this.Controls.Add(this.workBtn);
            this.Controls.Add(this.auth_but_logout);
            this.Controls.Add(this.auth_password);
            this.Controls.Add(this.auth_login);
            this.Controls.Add(this.auth_but_login);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Patients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.Doctors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ListsOfVisit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.Schedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ListsOfDiseases.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.Medicines.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.Spetialisations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button auth_but_login;
        private System.Windows.Forms.TextBox auth_login;
        private System.Windows.Forms.TextBox auth_password;
        private System.Windows.Forms.Button auth_but_logout;
        private System.Windows.Forms.Button workBtn;
        private System.Windows.Forms.Button listOfReceptionBtn;
        private System.Windows.Forms.Button cardBtn;
        private System.Windows.Forms.Button patientBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Patients;
        private System.Windows.Forms.TabPage Doctors;
        private System.Windows.Forms.TabPage ListsOfVisit;
        private System.Windows.Forms.TabPage Schedule;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullNamePatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn BithdayPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenderPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumerPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardNumerPatient;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDoctors;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullNameDoctors;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpetialisationDoctors;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthdayDoctors;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmploymentDateDoctors;
        private System.Windows.Forms.DataGridViewTextBoxColumn CabinetNumberDoctors;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDShedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn CabinetNumberSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTimeSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTimeSchedule;
        private System.Windows.Forms.TabPage ListsOfDiseases;
        private System.Windows.Forms.TabPage Medicines;
        private System.Windows.Forms.TabPage Spetialisations;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.DataGridView dataGridView7;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSpetialisations;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameSpetialisations;
    }
}

