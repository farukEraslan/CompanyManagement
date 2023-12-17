namespace CompanyManagement.WinForm
{
    partial class LoginPage
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
            panel1 = new Panel();
            btnClose = new Button();
            panel3 = new Panel();
            lblPassword = new Label();
            txtPassword = new TextBox();
            panel2 = new Panel();
            lblUsername = new Label();
            txtUsername = new TextBox();
            btnLogin = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnLogin);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(560, 337);
            panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(560, 337);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(0, 0);
            btnClose.TabIndex = 5;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblPassword);
            panel3.Controls.Add(txtPassword);
            panel3.Location = new Point(46, 138);
            panel3.Name = "panel3";
            panel3.Size = new Size(470, 50);
            panel3.TabIndex = 4;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(45, 14);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(60, 21);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Parola :";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(111, 11);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(356, 29);
            txtPassword.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblUsername);
            panel2.Controls.Add(txtUsername);
            panel2.Location = new Point(46, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(470, 50);
            panel2.TabIndex = 3;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(3, 14);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(102, 21);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Kullanıcı Adı :";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(111, 11);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(356, 29);
            txtUsername.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(334, 222);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(182, 47);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "GİRİŞ YAP";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginPage
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(584, 361);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş Yap";
            TopMost = true;
            Load += LoginPage_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lblUsername;
        private Button btnLogin;
        private TextBox txtUsername;
        private Panel panel3;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnClose;
    }
}