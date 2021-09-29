using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace QrCodeCourses
{
    public partial class Form1 : Form
    {
        private Form activeForm = null;
        int mov;
        int movX;
        int movY;
        private void LoadForm()
        {
     
        }
        private void OpenChildForm(Form ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.Owner = this;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(ChildForm);
            ChildForm.Tag = ChildForm;
            ChildForm.BringToFront();

            ChildForm.Show();

        }
        public Form1()
        {
            InitializeComponent();
        //    MessageBox.Show("Data Source" + Environment.CurrentDirectory + @"\QrCodePanier.db");
            CreateCode();
        }

        private void CreateCode()
        {
            PayloadGenerator.SMS mySms = new PayloadGenerator.SMS("0666810488", "Test QR Code");
            string payload = mySms.ToString();

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            var qrCodeAsBitmap = qrCode.GetGraphic(5);
            
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveArticle_Click(object sender, EventArgs e)
        {
           /* Article article = new Article(txtArticle.Text, int.Parse(txtQt.Value.ToString()));
            articles.Add(article);
            txtArticle.Text = string.Empty;
            txtQt.Value = 1;
            LoadForm();*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            LoadForm();
        }

        private void btnQrCode_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNewPanier_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NewPanierForm());
        }
        private void btnLoadPanier_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LoadPanier());

        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if(mov ==1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panelTop_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        
    }
}
