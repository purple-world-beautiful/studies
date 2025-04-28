namespace studentRegistration
{
    partial class mainForm
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
            groupLab = new Label();
            fullNameLab = new Label();
            idLab = new Label();
            fullNameTxt = new TextBox();
            idTxt = new TextBox();
            groupComboBox = new ComboBox();
            addStudentBtn = new Button();
            reportingBtn = new Button();
            searchGroupBtn = new Button();
            deleteStudentBtn = new Button();
            searchStudentBtn = new Button();
            studentsDataGridView = new DataGridView();
            resetTableBtn = new Button();
            backBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)studentsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupLab
            // 
            groupLab.AutoSize = true;
            groupLab.Location = new Point(651, 16);
            groupLab.Name = "groupLab";
            groupLab.Size = new Size(46, 15);
            groupLab.TabIndex = 46;
            groupLab.Text = "Группа";
            // 
            // fullNameLab
            // 
            fullNameLab.AutoSize = true;
            fullNameLab.Location = new Point(285, 16);
            fullNameLab.Name = "fullNameLab";
            fullNameLab.Size = new Size(139, 15);
            fullNameLab.TabIndex = 45;
            fullNameLab.Text = "Фамилия Имя Отчество";
            // 
            // idLab
            // 
            idLab.AutoSize = true;
            idLab.Location = new Point(172, 16);
            idLab.Name = "idLab";
            idLab.Size = new Size(45, 15);
            idLab.TabIndex = 44;
            idLab.Text = "Номер";
            // 
            // fullNameTxt
            // 
            fullNameTxt.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            fullNameTxt.Location = new Point(285, 34);
            fullNameTxt.Name = "fullNameTxt";
            fullNameTxt.Size = new Size(300, 22);
            fullNameTxt.TabIndex = 43;
            // 
            // idTxt
            // 
            idTxt.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            idTxt.Location = new Point(172, 34);
            idTxt.Name = "idTxt";
            idTxt.Size = new Size(50, 22);
            idTxt.TabIndex = 42;
            // 
            // groupComboBox
            // 
            groupComboBox.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupComboBox.FormattingEnabled = true;
            groupComboBox.Location = new Point(651, 34);
            groupComboBox.Name = "groupComboBox";
            groupComboBox.Size = new Size(121, 23);
            groupComboBox.TabIndex = 41;
            // 
            // addStudentBtn
            // 
            addStudentBtn.BackColor = Color.FromArgb(128, 128, 255);
            addStudentBtn.FlatStyle = FlatStyle.Flat;
            addStudentBtn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addStudentBtn.Location = new Point(15, 423);
            addStudentBtn.Name = "addStudentBtn";
            addStudentBtn.Size = new Size(140, 50);
            addStudentBtn.TabIndex = 40;
            addStudentBtn.Text = "Добавить студента =>";
            addStudentBtn.UseVisualStyleBackColor = false;
            addStudentBtn.Click += addStudentBtn_Click;
            // 
            // reportingBtn
            // 
            reportingBtn.BackColor = Color.FromArgb(128, 128, 255);
            reportingBtn.FlatStyle = FlatStyle.Flat;
            reportingBtn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            reportingBtn.Location = new Point(15, 374);
            reportingBtn.Name = "reportingBtn";
            reportingBtn.Size = new Size(140, 32);
            reportingBtn.TabIndex = 39;
            reportingBtn.Text = "Отчётность =>";
            reportingBtn.UseVisualStyleBackColor = false;
            reportingBtn.Click += reportingBtn_Click;
            // 
            // searchGroupBtn
            // 
            searchGroupBtn.BackColor = Color.FromArgb(128, 128, 255);
            searchGroupBtn.FlatStyle = FlatStyle.Flat;
            searchGroupBtn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            searchGroupBtn.Location = new Point(18, 255);
            searchGroupBtn.Name = "searchGroupBtn";
            searchGroupBtn.Size = new Size(140, 33);
            searchGroupBtn.TabIndex = 38;
            searchGroupBtn.Text = "Поиск по группе";
            searchGroupBtn.UseVisualStyleBackColor = false;
            searchGroupBtn.Click += searchGroupBtn_Click;
            // 
            // deleteStudentBtn
            // 
            deleteStudentBtn.BackColor = Color.FromArgb(128, 128, 255);
            deleteStudentBtn.FlatStyle = FlatStyle.Flat;
            deleteStudentBtn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            deleteStudentBtn.Location = new Point(15, 188);
            deleteStudentBtn.Name = "deleteStudentBtn";
            deleteStudentBtn.Size = new Size(140, 50);
            deleteStudentBtn.TabIndex = 37;
            deleteStudentBtn.Text = "Удаление студента";
            deleteStudentBtn.UseVisualStyleBackColor = false;
            deleteStudentBtn.Click += deleteStudentBtn_Click_1;
            // 
            // searchStudentBtn
            // 
            searchStudentBtn.BackColor = Color.FromArgb(128, 128, 255);
            searchStudentBtn.FlatStyle = FlatStyle.Flat;
            searchStudentBtn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            searchStudentBtn.Location = new Point(15, 124);
            searchStudentBtn.Name = "searchStudentBtn";
            searchStudentBtn.Size = new Size(140, 38);
            searchStudentBtn.TabIndex = 36;
            searchStudentBtn.Text = "Поиск студента";
            searchStudentBtn.UseVisualStyleBackColor = false;
            searchStudentBtn.Click += searchStudentBtn_Click;
            // 
            // studentsDataGridView
            // 
            studentsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentsDataGridView.Location = new Point(172, 73);
            studentsDataGridView.Name = "studentsDataGridView";
            studentsDataGridView.Size = new Size(600, 475);
            studentsDataGridView.TabIndex = 35;
            // 
            // resetTableBtn
            // 
            resetTableBtn.BackColor = Color.FromArgb(128, 128, 255);
            resetTableBtn.FlatStyle = FlatStyle.Flat;
            resetTableBtn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            resetTableBtn.Location = new Point(15, 315);
            resetTableBtn.Name = "resetTableBtn";
            resetTableBtn.Size = new Size(140, 34);
            resetTableBtn.TabIndex = 34;
            resetTableBtn.Text = "Сброс таблицы";
            resetTableBtn.UseVisualStyleBackColor = false;
            resetTableBtn.Click += resetTableBtn_Click;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.FromArgb(128, 128, 255);
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            backBtn.Location = new Point(746, 0);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(37, 29);
            backBtn.TabIndex = 48;
            backBtn.Text = "<=";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(backBtn);
            Controls.Add(groupLab);
            Controls.Add(fullNameLab);
            Controls.Add(idLab);
            Controls.Add(fullNameTxt);
            Controls.Add(idTxt);
            Controls.Add(groupComboBox);
            Controls.Add(addStudentBtn);
            Controls.Add(reportingBtn);
            Controls.Add(searchGroupBtn);
            Controls.Add(deleteStudentBtn);
            Controls.Add(searchStudentBtn);
            Controls.Add(studentsDataGridView);
            Controls.Add(resetTableBtn);
            Name = "mainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "mainForm";
            Load += mainForm_Load;
            ((System.ComponentModel.ISupportInitialize)studentsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label groupLab;
        private Label fullNameLab;
        private Label idLab;
        private TextBox fullNameTxt;
        private TextBox idTxt;
        private ComboBox groupComboBox;
        private Button addStudentBtn;
        private Button reportingBtn;
        private Button searchGroupBtn;
        private Button deleteStudentBtn;
        private Button searchStudentBtn;
        private DataGridView studentsDataGridView;
        private Button resetTableBtn;
        private Button backBtn;
    }
}