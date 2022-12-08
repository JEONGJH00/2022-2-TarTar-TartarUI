using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace TartarUI
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            DialogResult Result = loginForm.ShowDialog();

            if (Result == DialogResult.OK)
            {
                MessageBox.Show("프로그램 종료");
                this.Close();
            }
            else { }


        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            DialogResult Result = loginForm.ShowDialog();
        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            SignupForm signupForm = new SignupForm();
            DialogResult Result = signupForm.ShowDialog();
        }

        private void RecenttarBtn_Click(object sender, EventArgs e)
        {
            RecentTartarForm recenttartarForm = new RecentTartarForm();
            DialogResult Result = recenttartarForm.ShowDialog();
        }

        private void BeforetarBtn_Click(object sender, EventArgs e)
        {
            BeforeTartarForm beforetartarForm = new BeforeTartarForm();
            DialogResult Result = beforetartarForm.ShowDialog();
        }

        private void 질환정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DiseaseInfoForm diseaseinfoForm = new DiseaseInfoForm();
            DialogResult Result = diseaseinfoForm.ShowDialog();
        }


        private void 치아관리ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DentalCareForm dentalcareForm = new DentalCareForm();
            DialogResult Result = dentalcareForm.ShowDialog();
        }

        private void 자가진단ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelfDiagnosisForm selfdiagnosisForm = new SelfDiagnosisForm();
            DialogResult Result = selfdiagnosisForm.ShowDialog();
        }
    }
}
