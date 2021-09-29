namespace QrCodeCourses
{
    partial class NewPanierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPanierForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbxObligatoire = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnQrCode = new System.Windows.Forms.Button();
            this.btnValiderArticle = new System.Windows.Forms.Button();
            this.numQuantite = new System.Windows.Forms.NumericUpDown();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtArticle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lstArticles = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSavePanier = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbxObligatoire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(805, 486);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.splitContainer1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(23, 23);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(759, 440);
            this.panel5.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbxObligatoire);
            this.splitContainer1.Panel1.Controls.Add(this.btnQrCode);
            this.splitContainer1.Panel1.Controls.Add(this.btnValiderArticle);
            this.splitContainer1.Panel1.Controls.Add(this.numQuantite);
            this.splitContainer1.Panel1.Controls.Add(this.panel6);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.panel7);
            this.splitContainer1.Panel1.Controls.Add(this.txtArticle);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(759, 440);
            this.splitContainer1.SplitterDistance = 351;
            this.splitContainer1.TabIndex = 0;
            // 
            // gbxObligatoire
            // 
            this.gbxObligatoire.Controls.Add(this.label4);
            this.gbxObligatoire.Controls.Add(this.panel1);
            this.gbxObligatoire.Controls.Add(this.label3);
            this.gbxObligatoire.Controls.Add(this.txtNom);
            this.gbxObligatoire.Controls.Add(this.txtTel);
            this.gbxObligatoire.Controls.Add(this.panel8);
            this.gbxObligatoire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxObligatoire.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxObligatoire.Location = new System.Drawing.Point(3, 3);
            this.gbxObligatoire.Name = "gbxObligatoire";
            this.gbxObligatoire.Size = new System.Drawing.Size(345, 171);
            this.gbxObligatoire.TabIndex = 1;
            this.gbxObligatoire.TabStop = false;
            this.gbxObligatoire.Text = "Obligatoire";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(31, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "Nom :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.panel1.Location = new System.Drawing.Point(35, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 2);
            this.panel1.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(31, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Téléphone :";
            // 
            // txtTel
            // 
            this.txtTel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTel.BackColor = System.Drawing.SystemColors.Control;
            this.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTel.Font = new System.Drawing.Font("Century Gothic", 9.2F);
            this.txtTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTel.Location = new System.Drawing.Point(55, 134);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(161, 19);
            this.txtTel.TabIndex = 15;
            this.txtTel.Text = "Votre numéro";
            this.txtTel.Enter += new System.EventHandler(this.txtTel_Enter);
            this.txtTel.Leave += new System.EventHandler(this.txtTel_Leave);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.panel8.Location = new System.Drawing.Point(35, 159);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(257, 2);
            this.panel8.TabIndex = 16;
            // 
            // btnQrCode
            // 
            this.btnQrCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQrCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnQrCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQrCode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnQrCode.ForeColor = System.Drawing.Color.White;
            this.btnQrCode.Image = ((System.Drawing.Image)(resources.GetObject("btnQrCode.Image")));
            this.btnQrCode.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQrCode.Location = new System.Drawing.Point(38, 390);
            this.btnQrCode.Name = "btnQrCode";
            this.btnQrCode.Padding = new System.Windows.Forms.Padding(0, 0, 23, 0);
            this.btnQrCode.Size = new System.Drawing.Size(277, 45);
            this.btnQrCode.TabIndex = 26;
            this.btnQrCode.Text = "Terminer";
            this.btnQrCode.UseVisualStyleBackColor = false;
            this.btnQrCode.Click += new System.EventHandler(this.btnQrCode_Click);
            // 
            // btnValiderArticle
            // 
            this.btnValiderArticle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnValiderArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValiderArticle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValiderArticle.ForeColor = System.Drawing.Color.White;
            this.btnValiderArticle.Location = new System.Drawing.Point(38, 336);
            this.btnValiderArticle.Name = "btnValiderArticle";
            this.btnValiderArticle.Size = new System.Drawing.Size(277, 45);
            this.btnValiderArticle.TabIndex = 23;
            this.btnValiderArticle.Text = "Valider";
            this.btnValiderArticle.UseVisualStyleBackColor = false;
            this.btnValiderArticle.Click += new System.EventHandler(this.btnValiderArticle_Click);
            // 
            // numQuantite
            // 
            this.numQuantite.BackColor = System.Drawing.SystemColors.Control;
            this.numQuantite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numQuantite.Font = new System.Drawing.Font("Century Gothic", 9.2F);
            this.numQuantite.Location = new System.Drawing.Point(58, 290);
            this.numQuantite.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numQuantite.Name = "numQuantite";
            this.numQuantite.Size = new System.Drawing.Size(66, 22);
            this.numQuantite.TabIndex = 22;
            this.numQuantite.ValueChanged += new System.EventHandler(this.numQuantite_ValueChanged);
            this.numQuantite.Leave += new System.EventHandler(this.numQuantite_Leave);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.panel6.Location = new System.Drawing.Point(38, 315);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(257, 2);
            this.panel6.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(34, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Quantité :";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.panel7.Location = new System.Drawing.Point(38, 234);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(257, 2);
            this.panel7.TabIndex = 19;
            // 
            // txtArticle
            // 
            this.txtArticle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArticle.BackColor = System.Drawing.SystemColors.Control;
            this.txtArticle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtArticle.Font = new System.Drawing.Font("Century Gothic", 9.2F);
            this.txtArticle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtArticle.Location = new System.Drawing.Point(58, 214);
            this.txtArticle.Name = "txtArticle";
            this.txtArticle.Size = new System.Drawing.Size(214, 19);
            this.txtArticle.TabIndex = 18;
            this.txtArticle.Text = "L\'article à acheter";
            this.txtArticle.Enter += new System.EventHandler(this.txtArticle_Enter);
            this.txtArticle.Leave += new System.EventHandler(this.txtArticle_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(34, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Article :";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lstArticles);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer2.Size = new System.Drawing.Size(404, 440);
            this.splitContainer2.SplitterDistance = 352;
            this.splitContainer2.TabIndex = 0;
            // 
            // lstArticles
            // 
            this.lstArticles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstArticles.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstArticles.FormattingEnabled = true;
            this.lstArticles.ItemHeight = 21;
            this.lstArticles.Location = new System.Drawing.Point(0, 0);
            this.lstArticles.Name = "lstArticles";
            this.lstArticles.Size = new System.Drawing.Size(404, 352);
            this.lstArticles.TabIndex = 0;
            this.lstArticles.SelectedIndexChanged += new System.EventHandler(this.lstArticles_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btnSavePanier, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnNouveau, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDelete, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(404, 84);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnSavePanier
            // 
            this.btnSavePanier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSavePanier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnSavePanier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePanier.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePanier.ForeColor = System.Drawing.Color.White;
            this.btnSavePanier.Image = ((System.Drawing.Image)(resources.GetObject("btnSavePanier.Image")));
            this.btnSavePanier.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSavePanier.Location = new System.Drawing.Point(271, 19);
            this.btnSavePanier.Name = "btnSavePanier";
            this.btnSavePanier.Size = new System.Drawing.Size(130, 45);
            this.btnSavePanier.TabIndex = 25;
            this.btnSavePanier.Text = "Enregistrer";
            this.btnSavePanier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSavePanier.UseVisualStyleBackColor = false;
            this.btnSavePanier.Click += new System.EventHandler(this.btnSavePanier_Click);
            // 
            // btnNouveau
            // 
            this.btnNouveau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNouveau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnNouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNouveau.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveau.ForeColor = System.Drawing.Color.White;
            this.btnNouveau.Image = ((System.Drawing.Image)(resources.GetObject("btnNouveau.Image")));
            this.btnNouveau.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNouveau.Location = new System.Drawing.Point(3, 19);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(128, 45);
            this.btnNouveau.TabIndex = 26;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNouveau.UseVisualStyleBackColor = false;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.Location = new System.Drawing.Point(137, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 45);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtNom
            // 
            this.txtNom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNom.BackColor = System.Drawing.SystemColors.Control;
            this.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNom.Font = new System.Drawing.Font("Century Gothic", 9.2F);
            this.txtNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNom.Location = new System.Drawing.Point(44, 62);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(161, 19);
            this.txtNom.TabIndex = 25;
            this.txtNom.Text = "Nom du panier";
            this.txtNom.Enter += new System.EventHandler(this.txtNom_Enter);
            this.txtNom.Leave += new System.EventHandler(this.txtNom_Leave);
            // 
            // NewPanierForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(805, 486);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewPanierForm";
            this.Text = "NewPanier";
            this.Load += new System.EventHandler(this.NewPanierForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbxObligatoire.ResumeLayout(false);
            this.gbxObligatoire.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantite)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnValiderArticle;
        private System.Windows.Forms.NumericUpDown numQuantite;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtArticle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnQrCode;
        private System.Windows.Forms.Button btnSavePanier;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lstArticles;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.GroupBox gbxObligatoire;
        private System.Windows.Forms.TextBox txtNom;
    }
}