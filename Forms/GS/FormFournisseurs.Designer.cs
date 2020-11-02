namespace AppGA.Forms.GS
{
    partial class FormFournisseurs
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
            this.dataGridViewFourns = new System.Windows.Forms.DataGridView();
            this.PanelFournsBody = new System.Windows.Forms.Panel();
            this.PanelFournsHeader = new System.Windows.Forms.Panel();
            this.btnAjouter = new FontAwesome.Sharp.IconButton();
            this.btnModifier = new FontAwesome.Sharp.IconButton();
            this.btnSupprimer = new FontAwesome.Sharp.IconButton();
            this.btnActualiser = new FontAwesome.Sharp.IconButton();
            this.PanelArticleSearch = new System.Windows.Forms.Panel();
            this.cbAdr = new System.Windows.Forms.RadioButton();
            this.lbRecherche = new System.Windows.Forms.Label();
            this.cbGSM = new System.Windows.Forms.RadioButton();
            this.lbFiltre = new System.Windows.Forms.Label();
            this.cbEmail = new System.Windows.Forms.RadioButton();
            this.cbRefFour = new System.Windows.Forms.RadioButton();
            this.cbNom = new System.Windows.Forms.RadioButton();
            this.textBoxRecherche = new System.Windows.Forms.TextBox();
            this.btnRechercher = new FontAwesome.Sharp.IconButton();
            this.cbFax = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFourns)).BeginInit();
            this.PanelFournsBody.SuspendLayout();
            this.PanelFournsHeader.SuspendLayout();
            this.PanelArticleSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewFourns
            // 
            this.dataGridViewFourns.AllowUserToAddRows = false;
            this.dataGridViewFourns.AllowUserToDeleteRows = false;
            this.dataGridViewFourns.AllowUserToOrderColumns = true;
            this.dataGridViewFourns.AllowUserToResizeColumns = false;
            this.dataGridViewFourns.AllowUserToResizeRows = false;
            this.dataGridViewFourns.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFourns.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewFourns.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewFourns.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewFourns.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewFourns.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewFourns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFourns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFourns.Location = new System.Drawing.Point(10, 5);
            this.dataGridViewFourns.MultiSelect = false;
            this.dataGridViewFourns.Name = "dataGridViewFourns";
            this.dataGridViewFourns.ReadOnly = true;
            this.dataGridViewFourns.RowHeadersVisible = false;
            this.dataGridViewFourns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFourns.Size = new System.Drawing.Size(736, 233);
            this.dataGridViewFourns.TabIndex = 0;
            this.dataGridViewFourns.Text = "dataGridView1";
            this.dataGridViewFourns.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewFourns_DataBindingComplete);
            // 
            // PanelFournsBody
            // 
            this.PanelFournsBody.Controls.Add(this.dataGridViewFourns);
            this.PanelFournsBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFournsBody.Location = new System.Drawing.Point(0, 200);
            this.PanelFournsBody.Name = "PanelFournsBody";
            this.PanelFournsBody.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.PanelFournsBody.Size = new System.Drawing.Size(756, 243);
            this.PanelFournsBody.TabIndex = 4;
            // 
            // PanelFournsHeader
            // 
            this.PanelFournsHeader.Controls.Add(this.btnAjouter);
            this.PanelFournsHeader.Controls.Add(this.btnModifier);
            this.PanelFournsHeader.Controls.Add(this.btnSupprimer);
            this.PanelFournsHeader.Controls.Add(this.btnActualiser);
            this.PanelFournsHeader.Controls.Add(this.PanelArticleSearch);
            this.PanelFournsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelFournsHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelFournsHeader.Name = "PanelFournsHeader";
            this.PanelFournsHeader.Size = new System.Drawing.Size(756, 200);
            this.PanelFournsHeader.TabIndex = 3;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjouter.AutoSize = true;
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAjouter.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAjouter.IconColor = System.Drawing.Color.Black;
            this.btnAjouter.IconSize = 16;
            this.btnAjouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouter.Location = new System.Drawing.Point(468, 164);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Rotation = 0D;
            this.btnAjouter.Size = new System.Drawing.Size(88, 30);
            this.btnAjouter.TabIndex = 16;
            this.btnAjouter.Text = "  Ajouter";
            this.btnAjouter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifier.AutoSize = true;
            this.btnModifier.FlatAppearance.BorderSize = 0;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnModifier.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnModifier.IconColor = System.Drawing.Color.Black;
            this.btnModifier.IconSize = 16;
            this.btnModifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifier.Location = new System.Drawing.Point(562, 164);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Rotation = 0D;
            this.btnModifier.Size = new System.Drawing.Size(88, 30);
            this.btnModifier.TabIndex = 15;
            this.btnModifier.Text = "  Modifier";
            this.btnModifier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprimer.AutoSize = true;
            this.btnSupprimer.FlatAppearance.BorderSize = 0;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSupprimer.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnSupprimer.IconColor = System.Drawing.Color.Black;
            this.btnSupprimer.IconSize = 16;
            this.btnSupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupprimer.Location = new System.Drawing.Point(656, 164);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Rotation = 0D;
            this.btnSupprimer.Size = new System.Drawing.Size(94, 30);
            this.btnSupprimer.TabIndex = 14;
            this.btnSupprimer.Text = "  Supprimer";
            this.btnSupprimer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupprimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnActualiser
            // 
            this.btnActualiser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnActualiser.AutoSize = true;
            this.btnActualiser.FlatAppearance.BorderSize = 0;
            this.btnActualiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualiser.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnActualiser.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.btnActualiser.IconColor = System.Drawing.Color.Black;
            this.btnActualiser.IconSize = 16;
            this.btnActualiser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualiser.Location = new System.Drawing.Point(12, 164);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Rotation = 0D;
            this.btnActualiser.Size = new System.Drawing.Size(91, 30);
            this.btnActualiser.TabIndex = 13;
            this.btnActualiser.Text = "  Actualiser";
            this.btnActualiser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualiser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualiser.UseVisualStyleBackColor = true;
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
            // 
            // PanelArticleSearch
            // 
            this.PanelArticleSearch.Controls.Add(this.cbAdr);
            this.PanelArticleSearch.Controls.Add(this.cbFax);
            this.PanelArticleSearch.Controls.Add(this.lbRecherche);
            this.PanelArticleSearch.Controls.Add(this.cbGSM);
            this.PanelArticleSearch.Controls.Add(this.lbFiltre);
            this.PanelArticleSearch.Controls.Add(this.cbEmail);
            this.PanelArticleSearch.Controls.Add(this.cbRefFour);
            this.PanelArticleSearch.Controls.Add(this.cbNom);
            this.PanelArticleSearch.Controls.Add(this.textBoxRecherche);
            this.PanelArticleSearch.Controls.Add(this.btnRechercher);
            this.PanelArticleSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelArticleSearch.Location = new System.Drawing.Point(0, 0);
            this.PanelArticleSearch.Name = "PanelArticleSearch";
            this.PanelArticleSearch.Padding = new System.Windows.Forms.Padding(10);
            this.PanelArticleSearch.Size = new System.Drawing.Size(756, 140);
            this.PanelArticleSearch.TabIndex = 12;
            // 
            // cbAdr
            // 
            this.cbAdr.AutoSize = true;
            this.cbAdr.Location = new System.Drawing.Point(580, 105);
            this.cbAdr.Name = "cbAdr";
            this.cbAdr.Size = new System.Drawing.Size(66, 19);
            this.cbAdr.TabIndex = 13;
            this.cbAdr.Text = "Adresse";
            this.cbAdr.UseVisualStyleBackColor = true;
            this.cbAdr.CheckedChanged += new System.EventHandler(this.cbAdr_CheckedChanged);
            // 
            // lbRecherche
            // 
            this.lbRecherche.AutoSize = true;
            this.lbRecherche.Location = new System.Drawing.Point(12, 78);
            this.lbRecherche.Name = "lbRecherche";
            this.lbRecherche.Size = new System.Drawing.Size(68, 15);
            this.lbRecherche.TabIndex = 11;
            this.lbRecherche.Text = "Recherche :";
            // 
            // cbGSM
            // 
            this.cbGSM.AutoSize = true;
            this.cbGSM.Location = new System.Drawing.Point(473, 105);
            this.cbGSM.Name = "cbGSM";
            this.cbGSM.Size = new System.Drawing.Size(50, 19);
            this.cbGSM.TabIndex = 9;
            this.cbGSM.TabStop = true;
            this.cbGSM.Text = "GSM";
            this.cbGSM.UseVisualStyleBackColor = true;
            this.cbGSM.CheckedChanged += new System.EventHandler(this.cbGSM_CheckedChanged);
            // 
            // lbFiltre
            // 
            this.lbFiltre.AutoSize = true;
            this.lbFiltre.Location = new System.Drawing.Point(272, 78);
            this.lbFiltre.Name = "lbFiltre";
            this.lbFiltre.Size = new System.Drawing.Size(39, 15);
            this.lbFiltre.TabIndex = 10;
            this.lbFiltre.Text = "Filtre :";
            // 
            // cbEmail
            // 
            this.cbEmail.AutoSize = true;
            this.cbEmail.Location = new System.Drawing.Point(413, 105);
            this.cbEmail.Name = "cbEmail";
            this.cbEmail.Size = new System.Drawing.Size(54, 19);
            this.cbEmail.TabIndex = 8;
            this.cbEmail.TabStop = true;
            this.cbEmail.Text = "eMail";
            this.cbEmail.UseVisualStyleBackColor = true;
            this.cbEmail.CheckedChanged += new System.EventHandler(this.cbEmail_CheckedChanged);
            // 
            // cbRefFour
            // 
            this.cbRefFour.AutoSize = true;
            this.cbRefFour.Location = new System.Drawing.Point(330, 105);
            this.cbRefFour.Name = "cbRefFour";
            this.cbRefFour.Size = new System.Drawing.Size(77, 19);
            this.cbRefFour.TabIndex = 6;
            this.cbRefFour.TabStop = true;
            this.cbRefFour.Text = "Référance";
            this.cbRefFour.UseVisualStyleBackColor = true;
            this.cbRefFour.CheckedChanged += new System.EventHandler(this.cbRefFour_CheckedChanged);
            // 
            // cbNom
            // 
            this.cbNom.AutoSize = true;
            this.cbNom.Checked = true;
            this.cbNom.Location = new System.Drawing.Point(272, 105);
            this.cbNom.Name = "cbNom";
            this.cbNom.Size = new System.Drawing.Size(52, 19);
            this.cbNom.TabIndex = 7;
            this.cbNom.TabStop = true;
            this.cbNom.Text = "Nom";
            this.cbNom.UseVisualStyleBackColor = true;
            this.cbNom.CheckedChanged += new System.EventHandler(this.cbNom_CheckedChanged);
            // 
            // textBoxRecherche
            // 
            this.textBoxRecherche.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxRecherche.Location = new System.Drawing.Point(12, 105);
            this.textBoxRecherche.Name = "textBoxRecherche";
            this.textBoxRecherche.Size = new System.Drawing.Size(225, 25);
            this.textBoxRecherche.TabIndex = 0;
            this.textBoxRecherche.TextChanged += new System.EventHandler(this.textBoxRecherche_TextChanged);
            // 
            // btnRechercher
            // 
            this.btnRechercher.AutoSize = true;
            this.btnRechercher.FlatAppearance.BorderSize = 0;
            this.btnRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRechercher.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnRechercher.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnRechercher.IconColor = System.Drawing.Color.Black;
            this.btnRechercher.IconSize = 16;
            this.btnRechercher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRechercher.Location = new System.Drawing.Point(652, 102);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Rotation = 0D;
            this.btnRechercher.Size = new System.Drawing.Size(98, 25);
            this.btnRechercher.TabIndex = 5;
            this.btnRechercher.Text = "  Rechercher";
            this.btnRechercher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRechercher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // cbFax
            // 
            this.cbFax.AutoSize = true;
            this.cbFax.Location = new System.Drawing.Point(529, 105);
            this.cbFax.Name = "cbFax";
            this.cbFax.Size = new System.Drawing.Size(45, 19);
            this.cbFax.TabIndex = 12;
            this.cbFax.TabStop = true;
            this.cbFax.Text = "FAX";
            this.cbFax.UseVisualStyleBackColor = true;
            this.cbFax.CheckedChanged += new System.EventHandler(this.cbFax_CheckedChanged);
            // 
            // FormFournisseurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(756, 443);
            this.Controls.Add(this.PanelFournsBody);
            this.Controls.Add(this.PanelFournsHeader);
            this.Name = "FormFournisseurs";
            this.Text = "FormFournisseurs";
            this.Load += new System.EventHandler(this.FormFournisseurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFourns)).EndInit();
            this.PanelFournsBody.ResumeLayout(false);
            this.PanelFournsHeader.ResumeLayout(false);
            this.PanelFournsHeader.PerformLayout();
            this.PanelArticleSearch.ResumeLayout(false);
            this.PanelArticleSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFourns;
        private System.Windows.Forms.Panel PanelFournsBody;
        private System.Windows.Forms.Panel PanelFournsHeader;
        private System.Windows.Forms.Panel PanelArticleSearch;
        private System.Windows.Forms.Label lbRecherche;
        private System.Windows.Forms.RadioButton cbGSM;
        private System.Windows.Forms.Label lbFiltre;
        private System.Windows.Forms.RadioButton cbEmail;
        private System.Windows.Forms.RadioButton cbRefFour;
        private System.Windows.Forms.RadioButton cbNom;
        private System.Windows.Forms.TextBox textBoxRecherche;
        private FontAwesome.Sharp.IconButton btnRechercher;
        private System.Windows.Forms.RadioButton cbAdr;
        private FontAwesome.Sharp.IconButton btnAjouter;
        private FontAwesome.Sharp.IconButton btnModifier;
        private FontAwesome.Sharp.IconButton btnSupprimer;
        private FontAwesome.Sharp.IconButton btnActualiser;
        private System.Windows.Forms.RadioButton cbFax;
    }
}