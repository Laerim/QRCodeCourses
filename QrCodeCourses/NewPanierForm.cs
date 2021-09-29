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
    public partial class NewPanierForm : Form
    {
        private List<Article> articles = new List<Article>();
        private QRCodePanier db = new QRCodePanier();
        private string sPHTel = string.Empty;
        private string sPHArticle = string.Empty;
        private string sPHNom = string.Empty;
        private int IDArticle = 0;
        private bool bLoaded = false;

        public Panier Panier { get; set; }

        private void LoadForm()
        {
            bLoaded = false;
            IDArticle = 0;
            lstArticles.DataSource = null;
            lstArticles.DataSource = articles;
            lstArticles.DisplayMember = "QuantiteNom";
            lstArticles.ValueMember = "ArticleId";
            if (sPHArticle.Trim() == string.Empty)
            {
                sPHArticle = txtArticle.Text.Trim();
                sPHTel = txtTel.Text.Trim();
                sPHNom = txtNom.Text.Trim();
            }
            else
            {
                txtArticle.Text = sPHArticle.Trim() ;
            }
            numQuantite.Value = 1;
            btnDelete.Enabled = false;
            bLoaded = true;
        }

        public NewPanierForm()
        {
            InitializeComponent();
        }
        


        private void btnValiderArticle_Click(object sender, EventArgs e)
        {
            Article article = new Article() ;
            article.Nom = txtArticle.Text.Trim();
            article.Quantite = int.Parse(numQuantite.Value.ToString());
            if(Panier == null)
            {
                if (articles.Count == 0)
                    article.ArticleId = 1;
                else
                {
                    int maxId = articles.Max(a=> a.ArticleId) +1;
                    article.ArticleId = maxId;
                }
            }
            articles.Add(article);
            if (articles.Count > 0)
            {
                txtTel.ReadOnly = true;
                txtNom.ReadOnly = true;
            }
            LoadForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(IDArticle != 0)
            {
                Article art = articles.Find(a => a.ArticleId == IDArticle);
                articles.Remove(art);
                LoadForm();
            }
        }

        private void btnSavePanier_Click(object sender, EventArgs e)
        {
            try
            {
                if (Panier == null)
                {
                    Panier.Date = DateTime.Now;
                    Panier.Nom = txtNom.Text.Trim();
                    Panier.Telephone = txtTel.Text.Trim();
                    db.Paniers.Add(Panier);
                    db.SaveChanges();
                }
                foreach (Article article in articles)
                {
                    if (article.Saved == false)
                        article.ArticleId = 0;
                    article.Panier = Panier;
                    db.Articles.Add(article);
                }
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue, impossible d'enregistrer le panier:\n" +
                    ex.Message, "QRCode Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            


        }

        private void btnQrCode_Click(object sender, EventArgs e)
        {
            string sMessage = string.Empty;
            foreach (Article art in articles)
            {
                sMessage += art.QuantiteNom + "\n";
            }

            PayloadGenerator.SMS mySms = new PayloadGenerator.SMS(txtTel.Text.Trim(), sMessage.Trim());
            string payload = mySms.ToString();

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            QrCodeForm form = new QrCodeForm();
            form.qrCode = qrCode.GetGraphic(5);
            form.ShowDialog();
        }

        private void txtTel_Enter(object sender, EventArgs e)
        {
            if (txtTel.Text.Trim() == sPHTel.Trim())
                txtTel.Text = string.Empty;
        }

        private void txtTel_Leave(object sender, EventArgs e)
        {
            if (txtTel.Text.Trim() == string.Empty)
                txtTel.Text = sPHTel.Trim();
        }
        private void txtNom_Enter(object sender, EventArgs e)
        {
            if (txtNom.Text.Trim() == sPHNom.Trim())
                txtNom.Text = string.Empty;
        }

        private void txtNom_Leave(object sender, EventArgs e)
        {
            if (txtNom.Text.Trim() == string.Empty)
                txtNom.Text = sPHNom.Trim();
        }

        private void txtArticle_Enter(object sender, EventArgs e)
        {
            if (txtArticle.Text.Trim() == sPHArticle.Trim())
                txtArticle.Text = string.Empty;
        }

        private void txtArticle_Leave(object sender, EventArgs e)
        {
            if (txtArticle.Text.Trim() == string.Empty)
                txtArticle.Text = sPHArticle.Trim();
        }

        private void NewPanierForm_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void numQuantite_ValueChanged(object sender, EventArgs e)
        {
            if (numQuantite.Value <= 0)
                numQuantite.Value = 1;
        }

        private void numQuantite_Leave(object sender, EventArgs e)
        {
            numQuantite.ResetText();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lstArticles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstArticles.SelectedIndex != -1 && bLoaded)
            {
                IDArticle = ((Article)lstArticles.SelectedItem).ArticleId;
                txtArticle.Text = ((Article)lstArticles.SelectedItem).Nom;
                numQuantite.Value = ((Article)lstArticles.SelectedItem).Quantite;
                btnDelete.Enabled = true;
              //  txtArticle.Text = lstArticles.Text.Trim();
              //  IDMusique = int.Parse(lstMusique.SelectedValue.ToString());
              //  btnDeleteMusique.Enabled = true;
            }
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
