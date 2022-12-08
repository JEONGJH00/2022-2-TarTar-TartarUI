namespace TartarUI
{
    partial class SignupForm
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
            this.PWreLab = new System.Windows.Forms.Label();
            this.PWretxt = new System.Windows.Forms.TextBox();
            this.JoinBtn = new System.Windows.Forms.Button();
            this.PWLab = new System.Windows.Forms.Label();
            this.PWtxt = new System.Windows.Forms.TextBox();
            this.IDLab = new System.Windows.Forms.Label();
            this.IDtxt = new System.Windows.Forms.TextBox();
            this.TitleLab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PWreLab
            // 
            this.PWreLab.AutoSize = true;
            this.PWreLab.Location = new System.Drawing.Point(65, 183);
            this.PWreLab.Name = "PWreLab";
            this.PWreLab.Size = new System.Drawing.Size(102, 15);
            this.PWreLab.TabIndex = 15;
            this.PWreLab.Text = "비밀번호 확인";
            // 
            // PWretxt
            // 
            this.PWretxt.Location = new System.Drawing.Point(186, 180);
            this.PWretxt.Name = "PWretxt";
            this.PWretxt.Size = new System.Drawing.Size(112, 25);
            this.PWretxt.TabIndex = 14;
            this.PWretxt.TextChanged += new System.EventHandler(this.PWretxt_TextChanged);
            // 
            // JoinBtn
            // 
            this.JoinBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.JoinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JoinBtn.Location = new System.Drawing.Point(214, 234);
            this.JoinBtn.Name = "JoinBtn";
            this.JoinBtn.Size = new System.Drawing.Size(84, 33);
            this.JoinBtn.TabIndex = 13;
            this.JoinBtn.Text = "가입";
            this.JoinBtn.UseVisualStyleBackColor = false;
            this.JoinBtn.Click += new System.EventHandler(this.JoinBtn_Click);
            // 
            // PWLab
            // 
            this.PWLab.AutoSize = true;
            this.PWLab.Location = new System.Drawing.Point(65, 141);
            this.PWLab.Name = "PWLab";
            this.PWLab.Size = new System.Drawing.Size(67, 15);
            this.PWLab.TabIndex = 12;
            this.PWLab.Text = "비밀번호";
            // 
            // PWtxt
            // 
            this.PWtxt.Location = new System.Drawing.Point(186, 138);
            this.PWtxt.Name = "PWtxt";
            this.PWtxt.Size = new System.Drawing.Size(112, 25);
            this.PWtxt.TabIndex = 11;
            this.PWtxt.TextChanged += new System.EventHandler(this.PWtxt_TextChanged);
            // 
            // IDLab
            // 
            this.IDLab.AutoSize = true;
            this.IDLab.Location = new System.Drawing.Point(65, 97);
            this.IDLab.Name = "IDLab";
            this.IDLab.Size = new System.Drawing.Size(52, 15);
            this.IDLab.TabIndex = 10;
            this.IDLab.Text = "이메일";
            // 
            // IDtxt
            // 
            this.IDtxt.Location = new System.Drawing.Point(186, 94);
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.Size = new System.Drawing.Size(112, 25);
            this.IDtxt.TabIndex = 9;
            this.IDtxt.TextChanged += new System.EventHandler(this.IDtxt_TextChanged);
            // 
            // TitleLab
            // 
            this.TitleLab.AutoSize = true;
            this.TitleLab.Font = new System.Drawing.Font("나눔고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TitleLab.Location = new System.Drawing.Point(118, 35);
            this.TitleLab.Name = "TitleLab";
            this.TitleLab.Size = new System.Drawing.Size(127, 35);
            this.TitleLab.TabIndex = 8;
            this.TitleLab.Text = "회원가입";
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(362, 303);
            this.Controls.Add(this.PWreLab);
            this.Controls.Add(this.PWretxt);
            this.Controls.Add(this.JoinBtn);
            this.Controls.Add(this.PWLab);
            this.Controls.Add(this.PWtxt);
            this.Controls.Add(this.IDLab);
            this.Controls.Add(this.IDtxt);
            this.Controls.Add(this.TitleLab);
            this.Name = "SignupForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SignupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PWreLab;
        private System.Windows.Forms.TextBox PWretxt;
        private System.Windows.Forms.Button JoinBtn;
        private System.Windows.Forms.Label PWLab;
        private System.Windows.Forms.TextBox PWtxt;
        private System.Windows.Forms.Label IDLab;
        private System.Windows.Forms.TextBox IDtxt;
        private System.Windows.Forms.Label TitleLab;
    }
}