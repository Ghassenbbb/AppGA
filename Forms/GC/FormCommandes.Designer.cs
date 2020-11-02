namespace AppGA.Forms.GC
{
    partial class FormCommandes
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
            this.PanelCommandesHeader = new System.Windows.Forms.Panel();
            this.PanelCommandesSearch = new System.Windows.Forms.Panel();
            this.cbCancel = new System.Windows.Forms.CheckBox();
            this.cbLiv = new System.Windows.Forms.CheckBox();
            this.cbNotLiv = new System.Windows.Forms.CheckBox();
            this.cbidStock = new System.Windows.Forms.RadioButton();
            this.cbRefArt = new System.Windows.Forms.RadioButton();
            this.cbArticle = new System.Windows.Forms.RadioButton();
            this.cbidClient = new System.Windows.Forms.RadioButton();
            this.cbClient = new System.Windows.Forms.RadioButton();
            this.lbFiltre = new System.Windows.Forms.Label();
            this.cbID = new System.Windows.Forms.RadioButton();
            this.btnRechercher = new FontAwesome.Sharp.IconButton();
            this.lbRecherche = new System.Windows.Forms.Label();
            this.textBoxRecherche = new System.Windows.Forms.TextBox();
            this.btnAjouter = new FontAwesome.Sharp.IconButton();
            this.btnModifier = new FontAwesome.Sharp.IconButton();
            this.btnSupprimer = new FontAwesome.Sharp.IconButton();
            this.btnActualiser = new FontAwesome.Sharp.IconButton();
            this.PanelCommandesBody = new System.Windows.Forms.Panel();
            this.dataGridViewCommandes = new System.Windows.Forms.DataGridView();
            this.PanelCommandesHeader.SuspendLayout();
            this.PanelCommandesSearch.SuspendLayout();
            this.PanelCommandesBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCommandes)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelCommandesHeader
            // 
            this.PanelCommandesHeader.Controls.Add(this.PanelCommandesSearch);
            this.PanelCommandesHeader.Controls.Add(this.btnAjouter);
            this.PanelCommandesHeader.Controls.Add(this.btnModifier);
            this.PanelCommandesHeader.Controls.Add(this.btnSupprimer);
            this.PanelCommandesHeader.Controls.Add(this.btnActualiser);
            this.PanelCommandesHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelCommandesHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelCommandesHeader.Name = "PanelCommandesHeader";
            this.PanelCommandesHeader.Size = new System.Drawing.Size(756, 200);
            this.PanelCommandesHeader.TabIndex = 0;
            // 
            // PanelCommandesSearch
            // 
            this.PanelCommandesSearch.Controls.Add(this.cbCancel);
            this.PanelCommandesSearch.Controls.Add(this.cbLiv);
            this.PanelCommandesSearch.Controls.Add(this.cbNotLiv);
            this.PanelCommandesSearch.Controls.Add(this.cbidStock);
            this.PanelCommandesSearch.Controls.Add(this.cbRefArt);
            this.PanelCommandesSearch.Controls.Add(this.cbArticle);
            this.PanelCommandesSearch.Controls.Add(this.cbidClient);
            this.PanelCommandesSearch.Controls.Add(this.cbClient);
            this.PanelCommandesSearch.Controls.Add(this.lbFiltre);
            this.PanelCommandesSearch.Controls.Add(this.cbID);
            this.PanelCommandesSearch.Controls.Add(this.btnRechercher);
            this.PanelCommandesSearch.Controls.Add(this.lbRecherche);
            this.PanelCommandesSearch.Controls.Add(this.textBoxRecherche);
            this.PanelCommandesSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelCommandesSearch.Location = new System.Drawing.Point(0, 0);
            this.PanelCommandesSearch.Name = "PanelCommandesSearch";
            this.PanelCommandesSearch.Size = new System.Drawing.Size(756, 140);
            this.PanelCommandesSearch.TabIndex = 12;
            // 
            // cbCancel
            // 
            this.cbCancel.AutoSize = true;
            this.cbCancel.Location = new System.Drawing.Point(378, 107);
            this.cbCancel.Name = "cbCancel";
            this.cbCancel.Size = new System.Drawing.Size(64, 19);
            this.cbCancel.TabIndex = 31;
            this.cbCancel.Text = "Annulé";
            this.cbCancel.UseVisualStyleBackColor = true;
            this.cbCancel.CheckedChanged += new System.EventHandler(this.cbCancel_CheckedChanged);
            // 
            // cbLiv
            // 
            this.cbLiv.AutoSize = true;
            this.cbLiv.Location = new System.Drawing.Point(321, 107);
            this.cbLiv.Name = "cbLiv";
            this.cbLiv.Size = new System.Drawing.Size(51, 19);
            this.cbLiv.TabIndex = 30;
            this.cbLiv.Text = "Livré";
            this.cbLiv.UseVisualStyleBackColor = true;
            this.cbLiv.CheckedChanged += new System.EventHandler(this.cbLiv_CheckedChanged);
            // 
            // cbNotLiv
            // 
            this.cbNotLiv.AutoSize = true;
            this.cbNotLiv.Location = new System.Drawing.Point(241, 107);
            this.cbNotLiv.Name = "cbNotLiv";
            this.cbNotLiv.Size = new System.Drawing.Size(74, 19);
            this.cbNotLiv.TabIndex = 29;
            this.cbNotLiv.Text = "Non livré";
            this.cbNotLiv.UseVisualStyleBackColor = true;
            this.cbNotLiv.CheckedChanged += new System.EventHandler(this.cbNotLiv_CheckedChanged);
            // 
            // cbidStock
            // 
            this.cbidStock.AutoSize = true;
            this.cbidStock.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbidStock.Location = new System.Drawing.Point(629, 78);
            this.cbidStock.Name = "cbidStock";
            this.cbidStock.Size = new System.Drawing.Size(67, 17);
            this.cbidStock.TabIndex = 28;
            this.cbidStock.Text = "ID Stock";
            this.cbidStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbidStock.UseVisualStyleBackColor = true;
            this.cbidStock.CheckedChanged += new System.EventHandler(this.cbidStock_CheckedChanged);
            // 
            // cbRefArt
            // 
            this.cbRefArt.AutoSize = true;
            this.cbRefArt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbRefArt.Location = new System.Drawing.Point(543, 79);
            this.cbRefArt.Name = "cbRefArt";
            this.cbRefArt.Size = new System.Drawing.Size(80, 17);
            this.cbRefArt.TabIndex = 27;
            this.cbRefArt.Text = "Réf. Article";
            this.cbRefArt.UseVisualStyleBackColor = true;
            this.cbRefArt.CheckedChanged += new System.EventHandler(this.cbRefArt_CheckedChanged);
            // 
            // cbArticle
            // 
            this.cbArticle.AutoSize = true;
            this.cbArticle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbArticle.Location = new System.Drawing.Point(480, 78);
            this.cbArticle.Name = "cbArticle";
            this.cbArticle.Size = new System.Drawing.Size(57, 17);
            this.cbArticle.TabIndex = 26;
            this.cbArticle.Text = "Article";
            this.cbArticle.UseVisualStyleBackColor = true;
            this.cbArticle.CheckedChanged += new System.EventHandler(this.cbArticle_CheckedChanged);
            // 
            // cbidClient
            // 
            this.cbidClient.AutoSize = true;
            this.cbidClient.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbidClient.Location = new System.Drawing.Point(405, 78);
            this.cbidClient.Name = "cbidClient";
            this.cbidClient.Size = new System.Drawing.Size(69, 17);
            this.cbidClient.TabIndex = 25;
            this.cbidClient.Text = "ID Client";
            this.cbidClient.UseVisualStyleBackColor = true;
            this.cbidClient.CheckedChanged += new System.EventHandler(this.cbidClient_CheckedChanged);
            // 
            // cbClient
            // 
            this.cbClient.AutoSize = true;
            this.cbClient.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbClient.Location = new System.Drawing.Point(344, 79);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(55, 17);
            this.cbClient.TabIndex = 24;
            this.cbClient.Text = "Client";
            this.cbClient.UseVisualStyleBackColor = true;
            this.cbClient.CheckedChanged += new System.EventHandler(this.cbClient_CheckedChanged);
            // 
            // lbFiltre
            // 
            this.lbFiltre.AutoSize = true;
            this.lbFiltre.Location = new System.Drawing.Point(241, 50);
            this.lbFiltre.Name = "lbFiltre";
            this.lbFiltre.Size = new System.Drawing.Size(39, 15);
            this.lbFiltre.TabIndex = 25;
            this.lbFiltre.Text = "Filtre :";
            // 
            // cbID
            // 
            this.cbID.AutoSize = true;
            this.cbID.Checked = true;
            this.cbID.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbID.Location = new System.Drawing.Point(241, 78);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(97, 17);
            this.cbID.TabIndex = 23;
            this.cbID.TabStop = true;
            this.cbID.Text = "ID Commande";
            this.cbID.UseVisualStyleBackColor = true;
            this.cbID.CheckedChanged += new System.EventHandler(this.cbID_CheckedChanged);
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
            this.btnRechercher.Location = new System.Drawing.Point(652, 101);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Rotation = 0D;
            this.btnRechercher.Size = new System.Drawing.Size(98, 25);
            this.btnRechercher.TabIndex = 22;
            this.btnRechercher.Text = "  Rechercher";
            this.btnRechercher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRechercher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // lbRecherche
            // 
            this.lbRecherche.AutoSize = true;
            this.lbRecherche.Location = new System.Drawing.Point(12, 50);
            this.lbRecherche.Name = "lbRecherche";
            this.lbRecherche.Size = new System.Drawing.Size(68, 15);
            this.lbRecherche.TabIndex = 21;
            this.lbRecherche.Text = "Recherche :";
            // 
            // textBoxRecherche
            // 
            this.textBoxRecherche.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxRecherche.Location = new System.Drawing.Point(12, 75);
            this.textBoxRecherche.Name = "textBoxRecherche";
            this.textBoxRecherche.Size = new System.Drawing.Size(202, 25);
            this.textBoxRecherche.TabIndex = 20;
            this.textBoxRecherche.TextChanged += new System.EventHandler(this.textBoxRecherche_TextChanged);
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
            this.btnAjouter.Location = new System.Drawing.Point(464, 164);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Rotation = 0D;
            this.btnAjouter.Size = new System.Drawing.Size(88, 30);
            this.btnAjouter.TabIndex = 11;
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
            this.btnModifier.Location = new System.Drawing.Point(558, 164);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Rotation = 0D;
            this.btnModifier.Size = new System.Drawing.Size(88, 30);
            this.btnModifier.TabIndex = 10;
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
            this.btnSupprimer.Location = new System.Drawing.Point(652, 164);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Rotation = 0D;
            this.btnSupprimer.Size = new System.Drawing.Size(94, 30);
            this.btnSupprimer.TabIndex = 9;
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
            this.btnActualiser.TabIndex = 8;
            this.btnActualiser.Text = "  Actualiser";
            this.btnActualiser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualiser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualiser.UseVisualStyleBackColor = true;
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
            // 
            // PanelCommandesBody
            // 
            this.PanelCommandesBody.Controls.Add(this.dataGridViewCommandes);
            this.PanelCommandesBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCommandesBody.Location = new System.Drawing.Point(0, 200);
            this.PanelCommandesBody.Name = "PanelCommandesBody";
            this.PanelCommandesBody.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.PanelCommandesBody.Size = new System.Drawing.Size(756, 243);
            this.PanelCommandesBody.TabIndex = 3;
            // 
            // dataGridViewCommandes
            // 
            this.dataGridViewCommandes.AllowUserToAddRows = false;
            this.dataGridViewCommandes.AllowUserToDeleteRows = false;
            this.dataGridViewCommandes.AllowUserToOrderColumns = true;
            this.dataGridViewCommandes.AllowUserToResizeColumns = false;
            this.dataGridViewCommandes.AllowUserToResizeRows = false;
            this.dataGridViewCommandes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCommandes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCommandes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewCommandes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCommandes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewCommandes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewCommandes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCommandes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCommandes.Location = new System.Drawing.Point(10, 5);
            this.dataGridViewCommandes.MultiSelect = false;
            this.dataGridViewCommandes.Name = "dataGridViewCommandes";
            this.dataGridViewCommandes.ReadOnly = true;
            this.dataGridViewCommandes.RowHeadersVisible = false;
            this.dataGridViewCommandes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCommandes.Size = new System.Drawing.Size(736, 233);
            this.dataGridViewCommandes.TabIndex = 0;
            this.dataGridViewCommandes.Text = "dataGridView1";
            this.dataGridViewCommandes.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewCommandes_DataBindingComplete);
            // 
            // FormCommandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(756, 443);
            this.Controls.Add(this.PanelCommandesBody);
            this.Controls.Add(this.PanelCommandesHeader);
            this.Name = "FormCommandes";
            this.Text = "FormCommandes";
            this.Load += new System.EventHandler(this.FormCommandes_Load);
            this.PanelCommandesHeader.ResumeLayout(false);
            this.PanelCommandesHeader.PerformLayout();
            this.PanelCommandesSearch.ResumeLayout(false);
            this.PanelCommandesSearch.PerformLayout();
            this.PanelCommandesBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCommandes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelCommandesHeader;
        private System.Windows.Forms.Panel PanelCommandesBody;
        private System.Windows.Forms.DataGridView dataGridViewCommandes;
        private FontAwesome.Sharp.IconButton btnAjouter;
        private FontAwesome.Sharp.IconButton btnModifier;
        private FontAwesome.Sharp.IconButton btnSupprimer;
        private FontAwesome.Sharp.IconButton btnActualiser;
        private System.Windows.Forms.Panel PanelCommandesSearch;
        private System.Windows.Forms.RadioButton cbidStock;
        private System.Windows.Forms.RadioButton cbRefArt;
        private System.Windows.Forms.RadioButton cbArticle;
        private System.Windows.Forms.RadioButton cbidClient;
        private System.Windows.Forms.RadioButton cbClient;
        private System.Windows.Forms.Label lbFiltre;
        private System.Windows.Forms.RadioButton cbID;
        private FontAwesome.Sharp.IconButton btnRechercher;
        private System.Windows.Forms.Label lbRecherche;
        private System.Windows.Forms.TextBox textBoxRecherche;
        private System.Windows.Forms.CheckBox cbCancel;
        private System.Windows.Forms.CheckBox cbLiv;
        private System.Windows.Forms.CheckBox cbNotLiv;
    }
}