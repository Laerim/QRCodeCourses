namespace QrCodeCourses
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLoadPanier = new System.Windows.Forms.Button();
            this.btnNewPanier = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(142)))), ((int)(((byte)(110)))));
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1000, 30);
            this.panelTop.TabIndex = 0;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            this.panelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(132)))), ((int)(((byte)(109)))));
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(952, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.panel1.Controls.Add(this.btnLoadPanier);
            this.panel1.Controls.Add(this.btnNewPanier);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 488);
            this.panel1.TabIndex = 1;
            // 
            // btnLoadPanier
            // 
            this.btnLoadPanier.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoadPanier.Enabled = false;
            this.btnLoadPanier.FlatAppearance.BorderSize = 0;
            this.btnLoadPanier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadPanier.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadPanier.ForeColor = System.Drawing.Color.Gray;
            this.btnLoadPanier.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadPanier.Image")));
            this.btnLoadPanier.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadPanier.Location = new System.Drawing.Point(0, 180);
            this.btnLoadPanier.Name = "btnLoadPanier";
            this.btnLoadPanier.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnLoadPanier.Size = new System.Drawing.Size(169, 80);
            this.btnLoadPanier.TabIndex = 5;
            this.btnLoadPanier.Text = "Charger un panier";
            this.btnLoadPanier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadPanier.UseVisualStyleBackColor = true;
            this.btnLoadPanier.Click += new System.EventHandler(this.btnLoadPanier_Click);
            // 
            // btnNewPanier
            // 
            this.btnNewPanier.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewPanier.FlatAppearance.BorderSize = 0;
            this.btnNewPanier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewPanier.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPanier.ForeColor = System.Drawing.Color.White;
            this.btnNewPanier.Image = ((System.Drawing.Image)(resources.GetObject("btnNewPanier.Image")));
            this.btnNewPanier.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewPanier.Location = new System.Drawing.Point(0, 100);
            this.btnNewPanier.Name = "btnNewPanier";
            this.btnNewPanier.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnNewPanier.Size = new System.Drawing.Size(169, 80);
            this.btnNewPanier.TabIndex = 4;
            this.btnNewPanier.Text = "Nouveau panier";
            this.btnNewPanier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewPanier.UseVisualStyleBackColor = true;
            this.btnNewPanier.Click += new System.EventHandler(this.btnNewPanier_Click);
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(169, 100);
            this.panel9.TabIndex = 1;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(169, 30);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(831, 488);
            this.panelChildForm.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1000, 518);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLoadPanier;
        private System.Windows.Forms.Button btnNewPanier;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panelChildForm;
    }
}

