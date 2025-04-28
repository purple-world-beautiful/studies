namespace studentRegistration
{
    partial class addStudentForm
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
            fullNameLab = new Label();
            fullNameTxt = new TextBox();
            groupLab = new Label();
            groupComboBox = new ComboBox();
            messageLab = new Label();
            backBtn = new Button();
            addStudentBtn = new Button();
            SuspendLayout();
            // 
            // fullNameLab
            // 
            fullNameLab.AutoSize = true;
            fullNameLab.Location = new Point(51, 91);
            fullNameLab.Name = "fullNameLab";
            fullNameLab.Size = new Size(139, 15);
            fullNameLab.TabIndex = 47;
            fullNameLab.Text = "Фамилия Имя Отчество";
            // 
            // fullNameTxt
            // 
            fullNameTxt.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            fullNameTxt.Location = new Point(51, 109);
            fullNameTxt.Name = "fullNameTxt";
            fullNameTxt.Size = new Size(300, 22);
            fullNameTxt.TabIndex = 46;
            // 
            // groupLab
            // 
            groupLab.AutoSize = true;
            groupLab.Location = new Point(51, 168);
            groupLab.Name = "groupLab";
            groupLab.Size = new Size(46, 15);
            groupLab.TabIndex = 49;
            groupLab.Text = "Группа";
            // 
            // groupComboBox
            // 
            groupComboBox.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupComboBox.FormattingEnabled = true;
            groupComboBox.Location = new Point(51, 186);
            groupComboBox.Name = "groupComboBox";
            groupComboBox.Size = new Size(121, 23);
            groupComboBox.TabIndex = 48;
            // 
            // messageLab
            // 
            messageLab.AutoSize = true;
            messageLab.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            messageLab.Location = new Point(118, 33);
            messageLab.Name = "messageLab";
            messageLab.Size = new Size(0, 19);
            messageLab.TabIndex = 60;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.FromArgb(128, 128, 255);
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            backBtn.Location = new Point(347, 0);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(37, 29);
            backBtn.TabIndex = 61;
            backBtn.Text = "<=";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // addStudentBtn
            // 
            addStudentBtn.BackColor = Color.FromArgb(128, 128, 255);
            addStudentBtn.FlatStyle = FlatStyle.Flat;
            addStudentBtn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addStudentBtn.Location = new Point(106, 277);
            addStudentBtn.Name = "addStudentBtn";
            addStudentBtn.Size = new Size(164, 29);
            addStudentBtn.TabIndex = 62;
            addStudentBtn.Text = "Добавить студента";
            addStudentBtn.UseVisualStyleBackColor = false;
            addStudentBtn.Click += addStudentBtn_Click;
            // 
            // addStudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(addStudentBtn);
            Controls.Add(backBtn);
            Controls.Add(messageLab);
            Controls.Add(groupLab);
            Controls.Add(groupComboBox);
            Controls.Add(fullNameLab);
            Controls.Add(fullNameTxt);
            Name = "addStudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "addStudentForm";
            Load += addStudentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label fullNameLab;
        private TextBox fullNameTxt;
        private Label groupLab;
        private ComboBox groupComboBox;
        private Label messageLab;
        private Button backBtn;
        private Button addStudentBtn;
    }
}