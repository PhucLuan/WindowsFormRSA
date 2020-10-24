using ConsoleAppRSA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormRSA
{
    public partial class FormRSA : Form
    {
        public FormRSA()
        {
            InitializeComponent();
            btnGenKey.Enabled = false;
            btnResultSign.Enabled = false;
            btnResultAuthen.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
        }
        HelpGCD HelpGCD = new HelpGCD();
        int Phi;
        int N;
        int PrivateKey;
        int[] Prime = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
        int[] primePandQ;
        int PrivateKeyVal;
        public void autoGenPrime()
        {
            primePandQ = new int[2];
            Random random = new Random();
            Random random1 = new Random();
            int firstIndex = random.Next(0, 19);
            txtP.Text = Prime[firstIndex].ToString();
            txtQ.Text = Prime[firstIndex + random1.Next(1, 5)].ToString();
            Phi = (Convert.ToInt32(txtP.Text) - 1) * (Convert.ToInt32(txtQ.Text) - 1);
            PrivateKey = HelpGCD.Find_eA(Phi);
            EuclidExtended ee = new EuclidExtended(PrivateKey, Phi);
            EuclidExtendedSolution result = ee.solve();
            PrivateKeyVal = (int)result.X;
            if (result.X < 0)
            {
                autoGenPrime();
            }
        }
        private void btnGenKey_Click(object sender, EventArgs e)
        {   
            txtPrivateKey.Text = PrivateKey.ToString();
            txtPublicKey.Text = PrivateKeyVal.ToString();
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
        }

        private void btnSelectSign_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            var OpenFile = new System.IO.StreamReader(openFileDialog1.FileName);
            txtDocSign.Text = OpenFile.ReadToEnd();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDocSign.Text))
            {
                N = Convert.ToInt32(txtP.Text) * Convert.ToInt32(txtQ.Text);
                HelpRSA helpRSA = new HelpRSA();
                int[] resuls = helpRSA.SigRSA(PrivateKey, N, txtDocSign.Text.Trim());
                txtResultSign.Text = String.Join(" ", helpRSA.encry) + ";" + String.Join(" ", resuls);
                btnResultSign.Enabled = true;
            }
            else
                MessageBox.Show("Không có văn bản để ký");
            
        }
        //Click xác thực
        private void btnAuthen_Click(object sender, EventArgs e)
        {
            N = Convert.ToInt32(txtP.Text) * Convert.ToInt32(txtQ.Text);
            string[] DocAndSign = txtDocAuthen.Text.Split(';');
            byte[] encry = DocAndSign[0].Split(' ').Select(byte.Parse).ToArray();
            int[] signRSA = DocAndSign[1].Split(' ').Select(int.Parse).ToArray();
            HelpRSA helpRSA = new HelpRSA();
            if (helpRSA.sigAuthentication(Convert.ToInt32(txtPublicKey.Text), N, signRSA, encry))
            {
                MessageBox.Show("Chữ ký đúng");
                txtResultAuthen.Text = System.Text.Encoding.UTF8.GetString(encry);
                btnResultAuthen.Enabled = true;
            }
            else
            {
                MessageBox.Show("Chữ ký sai");
            }
            
        }

        private void btnResultSign_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                sfd.FilterIndex = 2;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, txtResultSign.Text);
                }
            }
        }
        //Click chọn file cần xác thực chữ ký
        private void btnSelectAuthen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            var OpenFile = new System.IO.StreamReader(openFileDialog1.FileName);
            txtDocAuthen.Text = OpenFile.ReadToEnd();
        }

        private void btnAutoGenP_Click(object sender, EventArgs e)
        {
            autoGenPrime();
            btnGenKey.Enabled = true;
        }
        /// <summary>
        /// Lưu file đã mã hóa sau khi giải mã
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResultAuthen_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                sfd.FilterIndex = 2;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, txtResultAuthen.Text);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPrivateKey.PasswordChar = '\0';
            }
            else
                txtPrivateKey.PasswordChar = '*';
            
        }
    }
}
