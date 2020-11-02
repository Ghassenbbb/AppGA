namespace AppGA.Forms.GS
{
    partial class FormStocks
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
            this.PanelStocksHeader = new System.Windows.Forms.Panel();
            this.PanelStockSearch = new System.Windows.Forms.Panel();
            this.lbFiltre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRechercher = new FontAwesome.Sharp.IconButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbUntVente = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tBPUVMax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tBPUVMin = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbUntAchat = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tBPUAMax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBPUAMin = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbQnt = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tBQntMax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tBQntMin = new System.Windows.Forms.TextBox();
            this.textBoxRecherche = new System.Windows.Forms.TextBox();
            this.cbRefFourn = new System.Windows.Forms.RadioButton();
            this.lbRecherche = new System.Windows.Forms.Label();
            this.cbFourn = new System.Windows.Forms.RadioButton();
            this.cbID = new System.Windows.Forms.RadioButton();
            this.cbArt = new System.Windows.Forms.RadioButton();
            this.cbRefArt = new System.Windows.Forms.RadioButton();
            this.btnAjouter = new FontAwesome.Sharp.IconButton();
            this.btnModifier = new FontAwesome.Sharp.IconButton();
            this.btnSupprimer = new FontAwesome.Sharp.IconButton();
            this.btnActualiser = new FontAwesome.Sharp.IconButton();
            this.PanelStocksBody = new System.Windows.Forms.Panel();
            this.dataGridViewStocks = new System.Windows.Forms.DataGridView();
            this.PanelStocksHeader.SuspendLayout();
            this.PanelStockSearch.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.PanelStocksBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStocks)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelStocksHeader
            // 
            this.PanelStocksHeader.Controls.Add(this.PanelStockSearch);
            this.PanelStocksHeader.Controls.Add(this.btnAjouter);
            this.PanelStocksHeader.Controls.Add(this.btnModifier);
            this.PanelStocksHeader.Controls.Add(this.btnSupprimer);
            this.PanelStocksHeader.Controls.Add(this.btnActualiser);
            this.PanelStocksHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelStocksHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelStocksHeader.Name = "PanelStocksHeader";
            this.PanelStocksHeader.Size = new System.Drawing.Size(756, 200);
            this.PanelStocksHeader.TabIndex = 0;
            // 
            // PanelStockSearch
            // 
            this.PanelStockSearch.Controls.Add(this.lbFiltre);
            this.PanelStockSearch.Controls.Add(this.panel1);
            this.PanelStockSearch.Controls.Add(this.textBoxRecherche);
            this.PanelStockSearch.Controls.Add(this.cbRefFourn);
            this.PanelStockSearch.Controls.Add(this.lbRecherche);
            this.PanelStockSearch.Controls.Add(this.cbFourn);
            this.PanelStockSearch.Controls.Add(this.cbID);
            this.PanelStockSearch.Controls.Add(this.cbArt);
            this.PanelStockSearch.Controls.Add(this.cbRefArt);
            this.PanelStockSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelStockSearch.Location = new System.Drawing.Point(0, 0);
            this.PanelStockSearch.Name = "PanelStockSearch";
            this.PanelStockSearch.Size = new System.Drawing.Size(756, 140);
            this.PanelStockSearch.TabIndex = 8;
            this.PanelStockSearch.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelStockSearch_Paint);
            // 
            // lbFiltre
            // 
            this.lbFiltre.AutoSize = true;
            this.lbFiltre.Location = new System.Drawing.Point(262, 23);
            this.lbFiltre.Name = "lbFiltre";
            this.lbFiltre.Size = new System.Drawing.Size(39, 15);
            this.lbFiltre.TabIndex = 2;
            this.lbFiltre.Text = "Filtre :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRechercher);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(150, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 58);
            this.panel1.TabIndex = 15;
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
            this.btnRechercher.Location = new System.Drawing.Point(408, 28);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Rotation = 0D;
            this.btnRechercher.Size = new System.Drawing.Size(98, 25);
            this.btnRechercher.TabIndex = 16;
            this.btnRechercher.Text = "  Rechercher";
            this.btnRechercher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRechercher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lbUntVente);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(253, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(117, 58);
            this.panel6.TabIndex = 2;
            // 
            // lbUntVente
            // 
            this.lbUntVente.AutoSize = true;
            this.lbUntVente.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbUntVente.Location = new System.Drawing.Point(14, 11);
            this.lbUntVente.Name = "lbUntVente";
            this.lbUntVente.Size = new System.Drawing.Size(82, 13);
            this.lbUntVente.TabIndex = 1;
            this.lbUntVente.Text = "Prix Unt. Vente";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.tBPUVMax);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.tBPUVMin);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 28);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(117, 30);
            this.panel7.TabIndex = 0;
            // 
            // tBPUVMax
            // 
            this.tBPUVMax.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBPUVMax.Location = new System.Drawing.Point(70, 7);
            this.tBPUVMax.Name = "tBPUVMax";
            this.tBPUVMax.Size = new System.Drawing.Size(36, 23);
            this.tBPUVMax.TabIndex = 2;
            this.tBPUVMax.TextChanged += new System.EventHandler(this.tBPUVMax_TextChanged);
            this.tBPUVMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBPUVMax_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(52, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "-";
            // 
            // tBPUVMin
            // 
            this.tBPUVMin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBPUVMin.Location = new System.Drawing.Point(14, 7);
            this.tBPUVMin.Name = "tBPUVMin";
            this.tBPUVMin.Size = new System.Drawing.Size(36, 23);
            this.tBPUVMin.TabIndex = 0;
            this.tBPUVMin.TextChanged += new System.EventHandler(this.tBPUVMin_TextChanged);
            this.tBPUVMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBPUVMin_KeyPress);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbUntAchat);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(130, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(123, 58);
            this.panel4.TabIndex = 1;
            // 
            // lbUntAchat
            // 
            this.lbUntAchat.AutoSize = true;
            this.lbUntAchat.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbUntAchat.Location = new System.Drawing.Point(14, 11);
            this.lbUntAchat.Name = "lbUntAchat";
            this.lbUntAchat.Size = new System.Drawing.Size(82, 13);
            this.lbUntAchat.TabIndex = 1;
            this.lbUntAchat.Text = "Prix Unt. Achat";
            this.lbUntAchat.Click += new System.EventHandler(this.lbUntAchat_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tBPUAMax);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.tBPUAMin);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 28);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(123, 30);
            this.panel5.TabIndex = 0;
            // 
            // tBPUAMax
            // 
            this.tBPUAMax.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBPUAMax.Location = new System.Drawing.Point(70, 7);
            this.tBPUAMax.Name = "tBPUAMax";
            this.tBPUAMax.Size = new System.Drawing.Size(36, 23);
            this.tBPUAMax.TabIndex = 2;
            this.tBPUAMax.TextChanged += new System.EventHandler(this.tBPUAMax_TextChanged);
            this.tBPUAMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBPUAMax_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(52, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "-";
            // 
            // tBPUAMin
            // 
            this.tBPUAMin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBPUAMin.Location = new System.Drawing.Point(14, 7);
            this.tBPUAMin.Name = "tBPUAMin";
            this.tBPUAMin.Size = new System.Drawing.Size(36, 23);
            this.tBPUAMin.TabIndex = 0;
            this.tBPUAMin.TextChanged += new System.EventHandler(this.tBPUAMin_TextChanged);
            this.tBPUAMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBPUAMin_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbQnt);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 58);
            this.panel2.TabIndex = 0;
            // 
            // lbQnt
            // 
            this.lbQnt.AutoSize = true;
            this.lbQnt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbQnt.Location = new System.Drawing.Point(14, 11);
            this.lbQnt.Name = "lbQnt";
            this.lbQnt.Size = new System.Drawing.Size(110, 13);
            this.lbQnt.TabIndex = 1;
            this.lbQnt.Text = "Quantité disponible";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tBQntMax);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.tBQntMin);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(130, 30);
            this.panel3.TabIndex = 0;
            // 
            // tBQntMax
            // 
            this.tBQntMax.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBQntMax.Location = new System.Drawing.Point(70, 7);
            this.tBQntMax.Name = "tBQntMax";
            this.tBQntMax.Size = new System.Drawing.Size(36, 23);
            this.tBQntMax.TabIndex = 2;
            this.tBQntMax.TextChanged += new System.EventHandler(this.tBQntMax_TextChanged);
            this.tBQntMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBQntMax_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "-";
            // 
            // tBQntMin
            // 
            this.tBQntMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBQntMin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBQntMin.Location = new System.Drawing.Point(14, 7);
            this.tBQntMin.Name = "tBQntMin";
            this.tBQntMin.Size = new System.Drawing.Size(36, 23);
            this.tBQntMin.TabIndex = 0;
            this.tBQntMin.TextChanged += new System.EventHandler(this.tBQntMin_TextChanged);
            this.tBQntMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBQntMin_KeyPress);
            // 
            // textBoxRecherche
            // 
            this.textBoxRecherche.Location = new System.Drawing.Point(10, 53);
            this.textBoxRecherche.Name = "textBoxRecherche";
            this.textBoxRecherche.Size = new System.Drawing.Size(225, 23);
            this.textBoxRecherche.TabIndex = 1;
            this.textBoxRecherche.TextChanged += new System.EventHandler(this.textBoxRecherche_TextChanged);
            // 
            // cbRefFourn
            // 
            this.cbRefFourn.AutoSize = true;
            this.cbRefFourn.Location = new System.Drawing.Point(547, 54);
            this.cbRefFourn.Name = "cbRefFourn";
            this.cbRefFourn.Size = new System.Drawing.Size(109, 19);
            this.cbRefFourn.TabIndex = 14;
            this.cbRefFourn.TabStop = true;
            this.cbRefFourn.Text = "Réf. Fournisseur";
            this.cbRefFourn.UseVisualStyleBackColor = true;
            this.cbRefFourn.CheckedChanged += new System.EventHandler(this.cbRefFourn_CheckedChanged);
            // 
            // lbRecherche
            // 
            this.lbRecherche.AutoSize = true;
            this.lbRecherche.Location = new System.Drawing.Point(10, 23);
            this.lbRecherche.Name = "lbRecherche";
            this.lbRecherche.Size = new System.Drawing.Size(68, 15);
            this.lbRecherche.TabIndex = 0;
            this.lbRecherche.Text = "Recherche :";
            // 
            // cbFourn
            // 
            this.cbFourn.AutoSize = true;
            this.cbFourn.Location = new System.Drawing.Point(455, 54);
            this.cbFourn.Name = "cbFourn";
            this.cbFourn.Size = new System.Drawing.Size(86, 19);
            this.cbFourn.TabIndex = 13;
            this.cbFourn.TabStop = true;
            this.cbFourn.Text = "Fournisseur";
            this.cbFourn.UseVisualStyleBackColor = true;
            this.cbFourn.CheckedChanged += new System.EventHandler(this.cbFourn_CheckedChanged);
            // 
            // cbID
            // 
            this.cbID.AutoSize = true;
            this.cbID.Checked = true;
            this.cbID.Location = new System.Drawing.Point(260, 54);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(36, 19);
            this.cbID.TabIndex = 11;
            this.cbID.TabStop = true;
            this.cbID.Text = "ID";
            this.cbID.UseVisualStyleBackColor = true;
            this.cbID.CheckedChanged += new System.EventHandler(this.cbID_CheckedChanged);
            // 
            // cbArt
            // 
            this.cbArt.AutoSize = true;
            this.cbArt.Location = new System.Drawing.Point(302, 54);
            this.cbArt.Name = "cbArt";
            this.cbArt.Size = new System.Drawing.Size(59, 19);
            this.cbArt.TabIndex = 10;
            this.cbArt.TabStop = true;
            this.cbArt.Text = "Article";
            this.cbArt.UseVisualStyleBackColor = true;
            this.cbArt.CheckedChanged += new System.EventHandler(this.cbArt_CheckedChanged);
            // 
            // cbRefArt
            // 
            this.cbRefArt.AutoSize = true;
            this.cbRefArt.Location = new System.Drawing.Point(367, 54);
            this.cbRefArt.Name = "cbRefArt";
            this.cbRefArt.Size = new System.Drawing.Size(82, 19);
            this.cbRefArt.TabIndex = 12;
            this.cbRefArt.TabStop = true;
            this.cbRefArt.Text = "Réf. Article";
            this.cbRefArt.UseVisualStyleBackColor = true;
            this.cbRefArt.CheckedChanged += new System.EventHandler(this.cbRefArt_CheckedChanged);
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
            this.btnAjouter.Location = new System.Drawing.Point(462, 164);
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
            this.btnModifier.Location = new System.Drawing.Point(556, 164);
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
            this.btnSupprimer.Location = new System.Drawing.Point(650, 164);
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
            this.btnActualiser.Location = new System.Drawing.Point(10, 164);
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
            // PanelStocksBody
            // 
            this.PanelStocksBody.Controls.Add(this.dataGridViewStocks);
            this.PanelStocksBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelStocksBody.Location = new System.Drawing.Point(0, 200);
            this.PanelStocksBody.Name = "PanelStocksBody";
            this.PanelStocksBody.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.PanelStocksBody.Size = new System.Drawing.Size(756, 243);
            this.PanelStocksBody.TabIndex = 2;
            // 
            // dataGridViewStocks
            // 
            this.dataGridViewStocks.AllowUserToAddRows = false;
            this.dataGridViewStocks.AllowUserToDeleteRows = false;
            this.dataGridViewStocks.AllowUserToOrderColumns = true;
            this.dataGridViewStocks.AllowUserToResizeColumns = false;
            this.dataGridViewStocks.AllowUserToResizeRows = false;
            this.dataGridViewStocks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStocks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewStocks.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewStocks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewStocks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewStocks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStocks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStocks.Location = new System.Drawing.Point(10, 5);
            this.dataGridViewStocks.MultiSelect = false;
            this.dataGridViewStocks.Name = "dataGridViewStocks";
            this.dataGridViewStocks.ReadOnly = true;
            this.dataGridViewStocks.RowHeadersVisible = false;
            this.dataGridViewStocks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStocks.Size = new System.Drawing.Size(736, 233);
            this.dataGridViewStocks.TabIndex = 0;
            this.dataGridViewStocks.Text = "dataGridView1";
            this.dataGridViewStocks.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewStocks_DataBindingComplete);
            // 
            // FormStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(756, 443);
            this.Controls.Add(this.PanelStocksBody);
            this.Controls.Add(this.PanelStocksHeader);
            this.Name = "FormStocks";
            this.Text = "FormStocks";
            this.Load += new System.EventHandler(this.FormStocks_Load);
            this.PanelStocksHeader.ResumeLayout(false);
            this.PanelStocksHeader.PerformLayout();
            this.PanelStockSearch.ResumeLayout(false);
            this.PanelStockSearch.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.PanelStocksBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStocks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelStocksHeader;
        private System.Windows.Forms.Panel PanelStocksBody;
        private System.Windows.Forms.DataGridView dataGridViewStocks;
        private FontAwesome.Sharp.IconButton btnAjouter;
        private FontAwesome.Sharp.IconButton btnModifier;
        private FontAwesome.Sharp.IconButton btnSupprimer;
        private FontAwesome.Sharp.IconButton btnActualiser;
        private System.Windows.Forms.Panel PanelStockSearch;
        private System.Windows.Forms.RadioButton cbFourn;
        private System.Windows.Forms.RadioButton cbRefArt;
        private System.Windows.Forms.Label lbFiltre;
        private System.Windows.Forms.RadioButton cbArt;
        private System.Windows.Forms.TextBox textBoxRecherche;
        private System.Windows.Forms.RadioButton cbID;
        private System.Windows.Forms.Label lbRecherche;
        private System.Windows.Forms.RadioButton cbRefFourn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbQnt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tBQntMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBQntMin;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbUntVente;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox tBPUVMax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBPUVMin;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbUntAchat;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tBPUAMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBPUAMin;
        private FontAwesome.Sharp.IconButton btnRechercher;
    }
}