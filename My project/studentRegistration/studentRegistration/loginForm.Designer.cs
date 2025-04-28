namespace studentRegistration
{
    partial class loginForm
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
            loginLab = new Label();
            logTxt = new TextBox();
            passTxt = new TextBox();
            passBtn = new Label();
            logLab = new Label();
            regBtn = new Button();
            logBtn = new Button();
            backBtn = new Button();
            SuspendLayout();
            // 
            // loginLab
            // 
            loginLab.AutoSize = true;
            loginLab.Font = new Font("Times New Roman", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginLab.Location = new Point(256, 23);
            loginLab.Name = "loginLab";
            loginLab.Size = new Size(307, 40);
            loginLab.TabIndex = 0;
            loginLab.Text = "Регистрация и вход";
            // 
            // logTxt
            // 
            logTxt.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            logTxt.Location = new Point(256, 191);
            logTxt.Name = "logTxt";
            logTxt.Size = new Size(300, 22);
            logTxt.TabIndex = 1;
            // 
            // passTxt
            // 
            passTxt.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passTxt.Location = new Point(256, 268);
            passTxt.Name = "passTxt";
            passTxt.Size = new Size(300, 22);
            passTxt.TabIndex = 2;
            // 
            // passBtn
            // 
            passBtn.AutoSize = true;
            passBtn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passBtn.Location = new Point(256, 246);
            passBtn.Name = "passBtn";
            passBtn.Size = new Size(58, 19);
            passBtn.TabIndex = 3;
            passBtn.Text = "Пароль";
            // 
            // logLab
            // 
            logLab.AutoSize = true;
            logLab.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            logLab.Location = new Point(256, 169);
            logLab.Name = "logLab";
            logLab.Size = new Size(52, 19);
            logLab.TabIndex = 4;
            logLab.Text = "Логин";
            // 
            // regBtn
            // 
            regBtn.BackColor = Color.FromArgb(128, 128, 255);
            regBtn.FlatStyle = FlatStyle.Flat;
            regBtn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            regBtn.Location = new Point(256, 414);
            regBtn.Name = "regBtn";
            regBtn.Size = new Size(116, 32);
            regBtn.TabIndex = 5;
            regBtn.Text = "Регистрация";
            regBtn.UseVisualStyleBackColor = false;
            regBtn.Click += regBtn_Click;
            // 
            // logBtn
            // 
            logBtn.BackColor = Color.FromArgb(128, 128, 255);
            logBtn.FlatStyle = FlatStyle.Flat;
            logBtn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            logBtn.Location = new Point(447, 414);
            logBtn.Name = "logBtn";
            logBtn.Size = new Size(116, 32);
            logBtn.TabIndex = 6;
            logBtn.Text = "Вход";
            logBtn.UseVisualStyleBackColor = false;
            logBtn.Click += logBtn_Click;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.FromArgb(128, 128, 255);
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            backBtn.Location = new Point(746, 0);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(37, 29);
            backBtn.TabIndex = 49;
            backBtn.Text = "<=";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 561);
            Controls.Add(backBtn);
            Controls.Add(logBtn);
            Controls.Add(regBtn);
            Controls.Add(logLab);
            Controls.Add(passBtn);
            Controls.Add(passTxt);
            Controls.Add(logTxt);
            Controls.Add(loginLab);
            Name = "loginForm";
            Text = "loginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loginLab;
        private TextBox logTxt;
        private TextBox passTxt;
        private Label passBtn;
        private Label logLab;
        private Button regBtn;
        private Button logBtn;
        private Button backBtn;
    }
}