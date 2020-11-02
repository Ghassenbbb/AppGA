namespace AppGA.Forms.GA
{
    partial class FormFamilles
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
            this.PanelFamilleHeader = new System.Windows.Forms.Panel();
            this.btnAjouter = new FontAwesome.Sharp.IconButton();
            this.btnModifier = new FontAwesome.Sharp.IconButton();
            this.btnSupprimer = new FontAwesome.Sharp.IconButton();
            this.btnActualiser = new FontAwesome.Sharp.IconButton();
            this.PanelFamilleSearch = new System.Windows.Forms.Panel();
            this.cbCodeFamille = new System.Windows.Forms.RadioButton();
            this.lbFiltre = new System.Windows.Forms.Label();
            this.cbDesign = new System.Windows.Forms.RadioButton();
            this.btnRechercher = new FontAwesome.Sharp.IconButton();
            this.lbRecherche = new System.Windows.Forms.Label();
            this.textBoxRecherche = new System.Windows.Forms.TextBox();
            this.PanelFamilleBody = new System.Windows.Forms.Panel();
            this.dataGridViewFamilles = new System.Windows.Forms.DataGridView();
            this.PanelFamilleHeader.SuspendLayout();
            this.PanelFamilleSearch.SuspendLayout();
            this.PanelFamilleBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFamilles)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelFamilleHeader
            // 
            this.PanelFamilleHeader.Controls.Add(this.btnAjouter);
            this.PanelFamilleHeader.Controls.Add(this.btnModifier);
            this.PanelFamilleHeader.Controls.Add(this.btnSupprimer);
            this.PanelFamilleHeader.Controls.Add(this.btnActualiser);
            this.PanelFamilleHeader.Controls.Add(this.PanelFamilleSearch);
            this.PanelFamilleHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelFamilleHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelFamilleHeader.Name = "PanelFamilleHeader";
            this.PanelFamilleHeader.Size = new System.Drawing.Size(756, 180);
            this.PanelFamilleHeader.TabIndex = 0;
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
            this.btnAjouter.Location = new System.Drawing.Point(465, 144);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Rotation = 0D;
            this.btnAjouter.Size = new System.Drawing.Size(88, 30);
            this.btnAjouter.TabIndex = 7;
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
            this.btnModifier.Location = new System.Drawing.Point(559, 144);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Rotation = 0D;
            this.btnModifier.Size = new System.Drawing.Size(88, 30);
            this.btnModifier.TabIndex = 6;
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
            this.btnSupprimer.Location = new System.Drawing.Point(653, 144);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Rotation = 0D;
            this.btnSupprimer.Size = new System.Drawing.Size(94, 30);
            this.btnSupprimer.TabIndex = 5;
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
            this.btnActualiser.Location = new System.Drawing.Point(12, 144);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Rotation = 0D;
            this.btnActualiser.Size = new System.Drawing.Size(91, 30);
            this.btnActualiser.TabIndex = 4;
            this.btnActualiser.Text = "  Actualiser";
            this.btnActualiser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualiser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualiser.UseVisualStyleBackColor = true;
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
            // 
            // PanelFamilleSearch
            // 
            this.PanelFamilleSearch.Controls.Add(this.cbCodeFamille);
            this.PanelFamilleSearch.Controls.Add(this.lbFiltre);
            this.PanelFamilleSearch.Controls.Add(this.cbDesign);
            this.PanelFamilleSearch.Controls.Add(this.btnRechercher);
            this.PanelFamilleSearch.Controls.Add(this.lbRecherche);
            this.PanelFamilleSearch.Controls.Add(this.textBoxRecherche);
            this.PanelFamilleSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelFamilleSearch.Location = new System.Drawing.Point(0, 0);
            this.PanelFamilleSearch.Name = "PanelFamilleSearch";
            this.PanelFamilleSearch.Size = new System.Drawing.Size(756, 120);
            this.PanelFamilleSearch.TabIndex = 0;
            this.PanelFamilleSearch.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // cbCodeFamille
            // 
            this.cbCodeFamille.AutoSize = true;
            this.cbCodeFamille.Location = new System.Drawing.Point(380, 85);
            this.cbCodeFamille.Name = "cbCodeFamille";
            this.cbCodeFamille.Size = new System.Drawing.Size(94, 19);
            this.cbCodeFamille.TabIndex = 18;
            this.cbCodeFamille.Text = "Code Famille";
            this.cbCodeFamille.UseVisualStyleBackColor = true;
            this.cbCodeFamille.CheckedChanged += new System.EventHandler(this.cbCodeFamille_CheckedChanged);
            // 
            // lbFiltre
            // 
            this.lbFiltre.AutoSize = true;
            this.lbFiltre.Location = new System.Drawing.Point(286, 57);
            this.lbFiltre.Name = "lbFiltre";
            this.lbFiltre.Size = new System.Drawing.Size(39, 15);
            this.lbFiltre.TabIndex = 19;
            this.lbFiltre.Text = "Filtre :";
            // 
            // cbDesign
            // 
            this.cbDesign.AutoSize = true;
            this.cbDesign.Checked = true;
            this.cbDesign.Location = new System.Drawing.Point(286, 85);
            this.cbDesign.Name = "cbDesign";
            this.cbDesign.Size = new System.Drawing.Size(88, 19);
            this.cbDesign.TabIndex = 17;
            this.cbDesign.TabStop = true;
            this.cbDesign.Text = "Désignation";
            this.cbDesign.UseVisualStyleBackColor = true;
            this.cbDesign.CheckedChanged += new System.EventHandler(this.cbDesign_CheckedChanged);
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
            this.btnRechercher.Location = new System.Drawing.Point(480, 79);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Rotation = 0D;
            this.btnRechercher.Size = new System.Drawing.Size(98, 25);
            this.btnRechercher.TabIndex = 14;
            this.btnRechercher.Text = "  Rechercher";
            this.btnRechercher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRechercher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // lbRecherche
            // 
            this.lbRecherche.AutoSize = true;
            this.lbRecherche.Location = new System.Drawing.Point(12, 57);
            this.lbRecherche.Name = "lbRecherche";
            this.lbRecherche.Size = new System.Drawing.Size(68, 15);
            this.lbRecherche.TabIndex = 13;
            this.lbRecherche.Text = "Recherche :";
            // 
            // textBoxRecherche
            // 
            this.textBoxRecherche.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxRecherche.Location = new System.Drawing.Point(12, 82);
            this.textBoxRecherche.Name = "textBoxRecherche";
            this.textBoxRecherche.Size = new System.Drawing.Size(225, 25);
            this.textBoxRecherche.TabIndex = 12;
            this.textBoxRecherche.TextChanged += new System.EventHandler(this.textBoxRecherche_TextChanged);
            // 
            // PanelFamilleBody
            // 
            this.PanelFamilleBody.Controls.Add(this.dataGridViewFamilles);
            this.PanelFamilleBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFamilleBody.Location = new System.Drawing.Point(0, 180);
            this.PanelFamilleBody.Name = "PanelFamilleBody";
            this.PanelFamilleBody.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.PanelFamilleBody.Size = new System.Drawing.Size(756, 263);
            this.PanelFamilleBody.TabIndex = 1;
            // 
            // dataGridViewFamilles
            // 
            this.dataGridViewFamilles.AllowUserToAddRows = false;
            this.dataGridViewFamilles.AllowUserToDeleteRows = false;
            this.dataGridViewFamilles.AllowUserToResizeColumns = false;
            this.dataGridViewFamilles.AllowUserToResizeRows = false;
            this.dataGridViewFamilles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFamilles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewFamilles.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewFamilles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewFamilles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewFamilles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewFamilles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFamilles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFamilles.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewFamilles.Location = new System.Drawing.Point(10, 5);
            this.dataGridViewFamilles.MultiSelect = false;
            this.dataGridViewFamilles.Name = "dataGridViewFamilles";
            this.dataGridViewFamilles.ReadOnly = true;
            this.dataGridViewFamilles.RowHeadersVisible = false;
            this.dataGridViewFamilles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFamilles.Size = new System.Drawing.Size(736, 253);
            this.dataGridViewFamilles.TabIndex = 1;
            this.dataGridViewFamilles.Text = "dataGridView1";
            this.dataGridViewFamilles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewArticles_CellContentClick);
            this.dataGridViewFamilles.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewFamilles_DataBindingComplete);
            // 
            // FormFamilles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(756, 443);
            this.Controls.Add(this.PanelFamilleBody);
            this.Controls.Add(this.PanelFamilleHeader);
            this.Name = "FormFamilles";
            this.Text = "FormFamilles";
            this.Load += new System.EventHandler(this.FormFamilles_Load);
            this.PanelFamilleHeader.ResumeLayout(false);
            this.PanelFamilleHeader.PerformLayout();
            this.PanelFamilleSearch.ResumeLayout(false);
            this.PanelFamilleSearch.PerformLayout();
            this.PanelFamilleBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFamilles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelFamilleHeader;
        private System.Windows.Forms.Panel PanelFamilleSearch;
        private System.Windows.Forms.Panel PanelFamilleBody;
        private System.Windows.Forms.DataGridView dataGridViewFamilles;
        private FontAwesome.Sharp.IconButton btnAjouter;
        private FontAwesome.Sharp.IconButton btnModifier;
        private FontAwesome.Sharp.IconButton btnSupprimer;
        private FontAwesome.Sharp.IconButton btnActualiser;
        private System.Windows.Forms.Label lbRecherche;
        private System.Windows.Forms.TextBox textBoxRecherche;
        private System.Windows.Forms.RadioButton cbCodeFamille;
        private System.Windows.Forms.Label lbFiltre;
        private System.Windows.Forms.RadioButton cbDesign;
        private FontAwesome.Sharp.IconButton btnRechercher;
    }
}