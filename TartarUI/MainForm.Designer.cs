namespace TartarUI
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.질환정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.치아관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.자가진단ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.RecenttarBtn = new System.Windows.Forms.Button();
            this.BeforetarBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SignupBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.질환정보ToolStripMenuItem,
            this.치아관리ToolStripMenuItem,
            this.자가진단ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 402);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(797, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 질환정보ToolStripMenuItem
            // 
            this.질환정보ToolStripMenuItem.Name = "질환정보ToolStripMenuItem";
            this.질환정보ToolStripMenuItem.Size = new System.Drawing.Size(106, 32);
            this.질환정보ToolStripMenuItem.Text = "질환정보";
            this.질환정보ToolStripMenuItem.Click += new System.EventHandler(this.질환정보ToolStripMenuItem_Click);
            // 
            // 치아관리ToolStripMenuItem
            // 
            this.치아관리ToolStripMenuItem.Name = "치아관리ToolStripMenuItem";
            this.치아관리ToolStripMenuItem.Size = new System.Drawing.Size(106, 32);
            this.치아관리ToolStripMenuItem.Text = "치아관리";
            this.치아관리ToolStripMenuItem.Click += new System.EventHandler(this.치아관리ToolStripMenuItem_Click_1);
            // 
            // 자가진단ToolStripMenuItem
            // 
            this.자가진단ToolStripMenuItem.Name = "자가진단ToolStripMenuItem";
            this.자가진단ToolStripMenuItem.Size = new System.Drawing.Size(106, 32);
            this.자가진단ToolStripMenuItem.Text = "자가진단";
            this.자가진단ToolStripMenuItem.Click += new System.EventHandler(this.자가진단ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "치석 진단 시스템";
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LoginBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LoginBtn.ForeColor = System.Drawing.Color.DimGray;
            this.LoginBtn.Location = new System.Drawing.Point(594, 38);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 28);
            this.LoginBtn.TabIndex = 2;
            this.LoginBtn.Text = "로그인";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // RecenttarBtn
            // 
            this.RecenttarBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.RecenttarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RecenttarBtn.Font = new System.Drawing.Font("나눔고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RecenttarBtn.Location = new System.Drawing.Point(151, 220);
            this.RecenttarBtn.Name = "RecenttarBtn";
            this.RecenttarBtn.Size = new System.Drawing.Size(191, 53);
            this.RecenttarBtn.TabIndex = 4;
            this.RecenttarBtn.Text = "현재 치석 상태";
            this.RecenttarBtn.UseVisualStyleBackColor = false;
            this.RecenttarBtn.Click += new System.EventHandler(this.RecenttarBtn_Click);
            // 
            // BeforetarBtn
            // 
            this.BeforetarBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BeforetarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BeforetarBtn.Font = new System.Drawing.Font("나눔고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BeforetarBtn.Location = new System.Drawing.Point(443, 220);
            this.BeforetarBtn.Name = "BeforetarBtn";
            this.BeforetarBtn.Size = new System.Drawing.Size(191, 53);
            this.BeforetarBtn.TabIndex = 5;
            this.BeforetarBtn.Text = "과거 치석 상태";
            this.BeforetarBtn.UseVisualStyleBackColor = false;
            this.BeforetarBtn.Click += new System.EventHandler(this.BeforetarBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 73);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SignupBtn
            // 
            this.SignupBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.SignupBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.SignupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignupBtn.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SignupBtn.ForeColor = System.Drawing.Color.DimGray;
            this.SignupBtn.Location = new System.Drawing.Point(686, 38);
            this.SignupBtn.Name = "SignupBtn";
            this.SignupBtn.Size = new System.Drawing.Size(75, 28);
            this.SignupBtn.TabIndex = 7;
            this.SignupBtn.Text = "회원가입";
            this.SignupBtn.UseVisualStyleBackColor = false;
            this.SignupBtn.Click += new System.EventHandler(this.SignupBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(797, 438);
            this.Controls.Add(this.SignupBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BeforetarBtn);
            this.Controls.Add(this.RecenttarBtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 질환정보ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 자가진단ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button RecenttarBtn;
        private System.Windows.Forms.Button BeforetarBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SignupBtn;
        private System.Windows.Forms.ToolStripMenuItem 치아관리ToolStripMenuItem;
    }
}

