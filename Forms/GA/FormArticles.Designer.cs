namespace AppGA.Forms.GA
{
    partial class FormArticles
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
            this.PanelArticleHeader = new System.Windows.Forms.Panel();
            this.PanelArticleSearch = new System.Windows.Forms.Panel();
            this.lbRecherche = new System.Windows.Forms.Label();
            this.cbCodeFamille = new System.Windows.Forms.RadioButton();
            this.lbFiltre = new System.Windows.Forms.Label();
            this.cbFamille = new System.Windows.Forms.RadioButton();
            this.cbRefArt = new System.Windows.Forms.RadioButton();
            this.cbDesign = new System.Windows.Forms.RadioButton();
            this.textBoxRecherche = new System.Windows.Forms.TextBox();
            this.btnRechercher = new FontAwesome.Sharp.IconButton();
            this.btnAjouter = new FontAwesome.Sharp.IconButton();
            this.btnModifier = new FontAwesome.Sharp.IconButton();
            this.btnSupprimer = new FontAwesome.Sharp.IconButton();
            this.btnActualiser = new FontAwesome.Sharp.IconButton();
            this.PanelArticleBody = new System.Windows.Forms.Panel();
            this.dataGridViewArticles = new System.Windows.Forms.DataGridView();
            this.PanelArticleHeader.SuspendLayout();
            this.PanelArticleSearch.SuspendLayout();
            this.PanelArticleBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticles)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelArticleHeader
            // 
            this.PanelArticleHeader.Controls.Add(this.PanelArticleSearch);
            this.PanelArticleHeader.Controls.Add(this.btnAjouter);
            this.PanelArticleHeader.Controls.Add(this.btnModifier);
            this.PanelArticleHeader.Controls.Add(this.btnSupprimer);
            this.PanelArticleHeader.Controls.Add(this.btnActualiser);
            this.PanelArticleHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelArticleHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelArticleHeader.Name = "PanelArticleHeader";
            this.PanelArticleHeader.Size = new System.Drawing.Size(756, 180);
            this.PanelArticleHeader.TabIndex = 0;
            // 
            // PanelArticleSearch
            // 
            this.PanelArticleSearch.Controls.Add(this.lbRecherche);
            this.PanelArticleSearch.Controls.Add(this.cbCodeFamille);
            this.PanelArticleSearch.Controls.Add(this.lbFiltre);
            this.PanelArticleSearch.Controls.Add(this.cbFamille);
            this.PanelArticleSearch.Controls.Add(this.cbRefArt);
            this.PanelArticleSearch.Controls.Add(this.cbDesign);
            this.PanelArticleSearch.Controls.Add(this.textBoxRecherche);
            this.PanelArticleSearch.Controls.Add(this.btnRechercher);
            this.PanelArticleSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelArticleSearch.Location = new System.Drawing.Point(0, 0);
            this.PanelArticleSearch.Name = "PanelArticleSearch";
            this.PanelArticleSearch.Padding = new System.Windows.Forms.Padding(10);
            this.PanelArticleSearch.Size = new System.Drawing.Size(756, 120);
            this.PanelArticleSearch.TabIndex = 4;
            // 
            // lbRecherche
            // 
            this.lbRecherche.AutoSize = true;
            this.lbRecherche.Location = new System.Drawing.Point(12, 58);
            this.lbRecherche.Name = "lbRecherche";
            this.lbRecherche.Size = new System.Drawing.Size(68, 15);
            this.lbRecherche.TabIndex = 11;
            this.lbRecherche.Text = "Recherche :";
            // 
            // cbCodeFamille
            // 
            this.cbCodeFamille.AutoSize = true;
            this.cbCodeFamille.Location = new System.Drawing.Point(529, 85);
            this.cbCodeFamille.Name = "cbCodeFamille";
            this.cbCodeFamille.Size = new System.Drawing.Size(94, 19);
            this.cbCodeFamille.TabIndex = 9;
            this.cbCodeFamille.TabStop = true;
            this.cbCodeFamille.Text = "Code Famille";
            this.cbCodeFamille.UseVisualStyleBackColor = true;
            this.cbCodeFamille.CheckedChanged += new System.EventHandler(this.cbCodeFamille_CheckedChanged);
            // 
            // lbFiltre
            // 
            this.lbFiltre.AutoSize = true;
            this.lbFiltre.Location = new System.Drawing.Point(286, 58);
            this.lbFiltre.Name = "lbFiltre";
            this.lbFiltre.Size = new System.Drawing.Size(39, 15);
            this.lbFiltre.TabIndex = 10;
            this.lbFiltre.Text = "Filtre :";
            // 
            // cbFamille
            // 
            this.cbFamille.AutoSize = true;
            this.cbFamille.Location = new System.Drawing.Point(460, 85);
            this.cbFamille.Name = "cbFamille";
            this.cbFamille.Size = new System.Drawing.Size(63, 19);
            this.cbFamille.TabIndex = 8;
            this.cbFamille.TabStop = true;
            this.cbFamille.Text = "Famille";
            this.cbFamille.UseVisualStyleBackColor = true;
            this.cbFamille.CheckedChanged += new System.EventHandler(this.cbFamille_CheckedChanged);
            // 
            // cbRefArt
            // 
            this.cbRefArt.AutoSize = true;
            this.cbRefArt.Location = new System.Drawing.Point(377, 85);
            this.cbRefArt.Name = "cbRefArt";
            this.cbRefArt.Size = new System.Drawing.Size(77, 19);
            this.cbRefArt.TabIndex = 6;
            this.cbRefArt.TabStop = true;
            this.cbRefArt.Text = "Référance";
            this.cbRefArt.UseVisualStyleBackColor = true;
            this.cbRefArt.CheckedChanged += new System.EventHandler(this.cbRefArt_CheckedChanged);
            // 
            // cbDesign
            // 
            this.cbDesign.AutoSize = true;
            this.cbDesign.Checked = true;
            this.cbDesign.Location = new System.Drawing.Point(286, 85);
            this.cbDesign.Name = "cbDesign";
            this.cbDesign.Size = new System.Drawing.Size(85, 19);
            this.cbDesign.TabIndex = 7;
            this.cbDesign.TabStop = true;
            this.cbDesign.Text = "Désgnation";
            this.cbDesign.UseVisualStyleBackColor = true;
            this.cbDesign.CheckedChanged += new System.EventHandler(this.cbDesign_CheckedChanged);
            // 
            // textBoxRecherche
            // 
            this.textBoxRecherche.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxRecherche.Location = new System.Drawing.Point(12, 82);
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
            this.btnRechercher.Location = new System.Drawing.Point(646, 79);
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
            this.btnAjouter.Location = new System.Drawing.Point(464, 144);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Rotation = 0D;
            this.btnAjouter.Size = new System.Drawing.Size(88, 30);
            this.btnAjouter.TabIndex = 3;
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
            this.btnModifier.Location = new System.Drawing.Point(558, 144);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Rotation = 0D;
            this.btnModifier.Size = new System.Drawing.Size(88, 30);
            this.btnModifier.TabIndex = 2;
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
            this.btnSupprimer.Location = new System.Drawing.Point(652, 144);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Rotation = 0D;
            this.btnSupprimer.Size = new System.Drawing.Size(94, 30);
            this.btnSupprimer.TabIndex = 1;
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
            this.btnActualiser.TabIndex = 0;
            this.btnActualiser.Text = "  Actualiser";
            this.btnActualiser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualiser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualiser.UseVisualStyleBackColor = true;
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
            // 
            // PanelArticleBody
            // 
            this.PanelArticleBody.Controls.Add(this.dataGridViewArticles);
            this.PanelArticleBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelArticleBody.Location = new System.Drawing.Point(0, 180);
            this.PanelArticleBody.Name = "PanelArticleBody";
            this.PanelArticleBody.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.PanelArticleBody.Size = new System.Drawing.Size(756, 263);
            this.PanelArticleBody.TabIndex = 1;
            // 
            // dataGridViewArticles
            // 
            this.dataGridViewArticles.AllowUserToAddRows = false;
            this.dataGridViewArticles.AllowUserToDeleteRows = false;
            this.dataGridViewArticles.AllowUserToResizeColumns = false;
            this.dataGridViewArticles.AllowUserToResizeRows = false;
            this.dataGridViewArticles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewArticles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewArticles.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewArticles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewArticles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewArticles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArticles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewArticles.Location = new System.Drawing.Point(10, 5);
            this.dataGridViewArticles.MultiSelect = false;
            this.dataGridViewArticles.Name = "dataGridViewArticles";
            this.dataGridViewArticles.ReadOnly = true;
            this.dataGridViewArticles.RowHeadersVisible = false;
            this.dataGridViewArticles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewArticles.Size = new System.Drawing.Size(736, 253);
            this.dataGridViewArticles.TabIndex = 0;
            this.dataGridViewArticles.Text = "dataGridView1";
            this.dataGridViewArticles.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewArticles_DataBindingComplete);
            // 
            // FormArticles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(756, 443);
            this.Controls.Add(this.PanelArticleBody);
            this.Controls.Add(this.PanelArticleHeader);
            this.Name = "FormArticles";
            this.Text = "FormArticles";
            this.Load += new System.EventHandler(this.FormArticles_Load);
            this.PanelArticleHeader.ResumeLayout(false);
            this.PanelArticleHeader.PerformLayout();
            this.PanelArticleSearch.ResumeLayout(false);
            this.PanelArticleSearch.PerformLayout();
            this.PanelArticleBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelArticleHeader;
        private System.Windows.Forms.Panel PanelArticleSearch;
        private FontAwesome.Sharp.IconButton btnRechercher;
        private System.Windows.Forms.TextBox textBoxRecherche;
        private FontAwesome.Sharp.IconButton btnAjouter;
        private FontAwesome.Sharp.IconButton btnModifier;
        private FontAwesome.Sharp.IconButton btnSupprimer;
        private FontAwesome.Sharp.IconButton btnActualiser;
        private System.Windows.Forms.Panel PanelArticleBody;
        private System.Windows.Forms.DataGridView dataGridViewArticles;
        private System.Windows.Forms.RadioButton cbCodeFamille;
        private System.Windows.Forms.RadioButton cbFamille;
        private System.Windows.Forms.RadioButton cbDesign;
        private System.Windows.Forms.RadioButton cbRefArt;
        private System.Windows.Forms.Label lbFiltre;
        private System.Windows.Forms.Label lbRecherche;
    }
}