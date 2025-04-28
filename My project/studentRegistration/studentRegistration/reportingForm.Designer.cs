namespace studentRegistration
{
    partial class reportingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            reportingBtn = new Button();
            fullNameLab = new Label();
            groupLab = new Label();
            groupComboBox = new ComboBox();
            fullNameComboBox = new ComboBox();
            itemComboBox = new ComboBox();
            itemLab = new Label();
            dateTxt = new TextBox();
            dateLab = new Label();
            gradeLab = new Label();
            gradeTxt = new TextBox();
            missedHoursLab = new Label();
            missedHoursTxt = new TextBox();
            messageLab = new Label();
            studentsDataGridView = new DataGridView();
            backBtn = new Button();
            idLab = new Label();
            idTxt = new TextBox();
            searchStudentBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)studentsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // reportingBtn
            // 
            reportingBtn.BackColor = Color.FromArgb(128, 128, 255);
            reportingBtn.FlatStyle = FlatStyle.Flat;
            reportingBtn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            reportingBtn.Location = new Point(597, 112);
            reportingBtn.Name = "reportingBtn";
            reportingBtn.Size = new Size(140, 31);
            reportingBtn.TabIndex = 37;
            reportingBtn.Text = "Отправить отчёт";
            reportingBtn.UseVisualStyleBackColor = false;
            reportingBtn.Click += reportingBtn_Click;
            // 
            // fullNameLab
            // 
            fullNameLab.AutoSize = true;
            fullNameLab.Location = new Point(122, 59);
            fullNameLab.Name = "fullNameLab";
            fullNameLab.Size = new Size(139, 15);
            fullNameLab.TabIndex = 47;
            fullNameLab.Text = "Фамилия Имя Отчество";
            // 
            // groupLab
            // 
            groupLab.AutoSize = true;
            groupLab.Location = new Point(12, 59);
            groupLab.Name = "groupLab";
            groupLab.Size = new Size(46, 15);
            groupLab.TabIndex = 49;
            groupLab.Text = "Группа";
            // 
            // groupComboBox
            // 
            groupComboBox.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupComboBox.FormattingEnabled = true;
            groupComboBox.Location = new Point(12, 77);
            groupComboBox.Name = "groupComboBox";
            groupComboBox.Size = new Size(94, 23);
            groupComboBox.TabIndex = 48;
            groupComboBox.SelectedIndexChanged += groupComboBox_SelectedIndexChanged;
            // 
            // fullNameComboBox
            // 
            fullNameComboBox.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            fullNameComboBox.FormattingEnabled = true;
            fullNameComboBox.Location = new Point(122, 77);
            fullNameComboBox.Name = "fullNameComboBox";
            fullNameComboBox.Size = new Size(250, 23);
            fullNameComboBox.TabIndex = 50;
            // 
            // itemComboBox
            // 
            itemComboBox.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            itemComboBox.FormattingEnabled = true;
            itemComboBox.Location = new Point(388, 77);
            itemComboBox.Name = "itemComboBox";
            itemComboBox.Size = new Size(130, 23);
            itemComboBox.TabIndex = 51;
            // 
            // itemLab
            // 
            itemLab.AutoSize = true;
            itemLab.Location = new Point(388, 59);
            itemLab.Name = "itemLab";
            itemLab.Size = new Size(55, 15);
            itemLab.TabIndex = 52;
            itemLab.Text = "Предмет";
            // 
            // dateTxt
            // 
            dateTxt.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateTxt.Location = new Point(12, 139);
            dateTxt.Name = "dateTxt";
            dateTxt.Size = new Size(134, 22);
            dateTxt.TabIndex = 53;
            // 
            // dateLab
            // 
            dateLab.AutoSize = true;
            dateLab.Location = new Point(12, 121);
            dateLab.Name = "dateLab";
            dateLab.Size = new Size(134, 15);
            dateLab.TabIndex = 54;
            dateLab.Text = "Дата в формате (д/м/г)";
            // 
            // gradeLab
            // 
            gradeLab.AutoSize = true;
            gradeLab.Location = new Point(166, 121);
            gradeLab.Name = "gradeLab";
            gradeLab.Size = new Size(48, 15);
            gradeLab.TabIndex = 56;
            gradeLab.Text = "Оценка";
            // 
            // gradeTxt
            // 
            gradeTxt.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            gradeTxt.Location = new Point(166, 139);
            gradeTxt.Name = "gradeTxt";
            gradeTxt.Size = new Size(48, 22);
            gradeTxt.TabIndex = 55;
            // 
            // missedHoursLab
            // 
            missedHoursLab.AutoSize = true;
            missedHoursLab.Location = new Point(242, 121);
            missedHoursLab.Name = "missedHoursLab";
            missedHoursLab.Size = new Size(120, 15);
            missedHoursLab.TabIndex = 58;
            missedHoursLab.Text = "Пропущенные часы";
            // 
            // missedHoursTxt
            // 
            missedHoursTxt.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            missedHoursTxt.Location = new Point(242, 139);
            missedHoursTxt.Name = "missedHoursTxt";
            missedHoursTxt.Size = new Size(130, 22);
            missedHoursTxt.TabIndex = 57;
            // 
            // messageLab
            // 
            messageLab.AutoSize = true;
            messageLab.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            messageLab.Location = new Point(343, 28);
            messageLab.Name = "messageLab";
            messageLab.Size = new Size(0, 19);
            messageLab.TabIndex = 59;
            // 
            // studentsDataGridView
            // 
            studentsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentsDataGridView.Location = new Point(12, 181);
            studentsDataGridView.Name = "studentsDataGridView";
            studentsDataGridView.Size = new Size(600, 368);
            studentsDataGridView.TabIndex = 60;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.FromArgb(128, 128, 255);
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            backBtn.Location = new Point(747, 0);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(37, 29);
            backBtn.TabIndex = 62;
            backBtn.Text = "<=";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // idLab
            // 
            idLab.AutoSize = true;
            idLab.Location = new Point(632, 301);
            idLab.Name = "idLab";
            idLab.Size = new Size(95, 15);
            idLab.TabIndex = 64;
            idLab.Text = "Номер студента";
            // 
            // idTxt
            // 
            idTxt.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            idTxt.Location = new Point(632, 319);
            idTxt.Name = "idTxt";
            idTxt.Size = new Size(50, 22);
            idTxt.TabIndex = 63;
            // 
            // searchStudentBtn
            // 
            searchStudentBtn.BackColor = Color.FromArgb(128, 128, 255);
            searchStudentBtn.FlatStyle = FlatStyle.Flat;
            searchStudentBtn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            searchStudentBtn.Location = new Point(632, 358);
            searchStudentBtn.Name = "searchStudentBtn";
            searchStudentBtn.Size = new Size(140, 38);
            searchStudentBtn.TabIndex = 65;
            searchStudentBtn.Text = "Поиск студента";
            searchStudentBtn.UseVisualStyleBackColor = false;
            searchStudentBtn.Click += searchStudentBtn_Click;
            // 
            // reportingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(searchStudentBtn);
            Controls.Add(idLab);
            Controls.Add(idTxt);
            Controls.Add(backBtn);
            Controls.Add(studentsDataGridView);
            Controls.Add(messageLab);
            Controls.Add(missedHoursLab);
            Controls.Add(missedHoursTxt);
            Controls.Add(gradeLab);
            Controls.Add(gradeTxt);
            Controls.Add(dateLab);
            Controls.Add(dateTxt);
            Controls.Add(itemLab);
            Controls.Add(itemComboBox);
            Controls.Add(fullNameComboBox);
            Controls.Add(groupLab);
            Controls.Add(groupComboBox);
            Controls.Add(fullNameLab);
            Controls.Add(reportingBtn);
            Name = "reportingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "reportingForm";
            Load += reportingForm_Load;
            ((System.ComponentModel.ISupportInitialize)studentsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button reportingBtn;
        private Label fullNameLab;
        private Label groupLab;
        private ComboBox groupComboBox;
        private ComboBox fullNameComboBox;
        private ComboBox itemComboBox;
        private Label itemLab;
        private TextBox dateTxt;
        private Label dateLab;
        private Label gradeLab;
        private TextBox gradeTxt;
        private Label missedHoursLab;
        private TextBox missedHoursTxt;
        private Label messageLab;
        private DataGridView studentsDataGridView;
        private Button backBtn;
        private Label idLab;
        private TextBox idTxt;
        private Button searchStudentBtn;
    }
}