namespace TartarUI
{
    partial class LoginForm
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
            this.TitleLab = new System.Windows.Forms.Label();
            this.SignupBtn = new System.Windows.Forms.Button();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.PWtxt = new System.Windows.Forms.TextBox();
            this.IDtxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TitleLab
            // 
            this.TitleLab.AutoSize = true;
            this.TitleLab.Font = new System.Drawing.Font("나눔고딕", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TitleLab.Location = new System.Drawing.Point(57, 30);
            this.TitleLab.Name = "TitleLab";
            this.TitleLab.Size = new System.Drawing.Size(252, 38);
            this.TitleLab.TabIndex = 7;
            this.TitleLab.Text = "치석 진단 시스템";
            // 
            // SignupBtn
            // 
            this.SignupBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.SignupBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.SignupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignupBtn.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SignupBtn.Location = new System.Drawing.Point(64, 233);
            this.SignupBtn.Name = "SignupBtn";
            this.SignupBtn.Size = new System.Drawing.Size(230, 41);
            this.SignupBtn.TabIndex = 11;
            this.SignupBtn.Text = "회원가입";
            this.SignupBtn.UseVisualStyleBackColor = false;
            this.SignupBtn.Click += new System.EventHandler(this.SignupBtn_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LoginBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LoginBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LoginBtn.Location = new System.Drawing.Point(64, 183);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(230, 41);
            this.LoginBtn.TabIndex = 10;
            this.LoginBtn.Text = "로그인";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // PWtxt
            // 
            this.PWtxt.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PWtxt.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.PWtxt.Location = new System.Drawing.Point(64, 141);
            this.PWtxt.Name = "PWtxt";
            this.PWtxt.PasswordChar = '*';
            this.PWtxt.Size = new System.Drawing.Size(230, 25);
            this.PWtxt.TabIndex = 9;
            this.PWtxt.Text = "비밀번호";
            this.PWtxt.TextChanged += new System.EventHandler(this.PWtxt_TextChanged);
            // 
            // IDtxt
            // 
            this.IDtxt.BackColor = System.Drawing.SystemColors.Window;
            this.IDtxt.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.IDtxt.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.IDtxt.Location = new System.Drawing.Point(65, 103);
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.Size = new System.Drawing.Size(230, 25);
            this.IDtxt.TabIndex = 8;
            this.IDtxt.Text = "이메일";
            this.IDtxt.TextChanged += new System.EventHandler(this.IDtxt_TextChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(362, 303);
            this.Controls.Add(this.SignupBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PWtxt);
            this.Controls.Add(this.IDtxt);
            this.Controls.Add(this.TitleLab);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLab;
        private System.Windows.Forms.Button SignupBtn;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox PWtxt;
        private System.Windows.Forms.TextBox IDtxt;
    }
}