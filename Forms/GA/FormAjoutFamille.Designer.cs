namespace AppGA.Forms.GA
{
    partial class FormAjoutFamille
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
            this.PaneltexBoxDesignBg = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxDesign = new System.Windows.Forms.TextBox();
            this.lbDesign = new System.Windows.Forms.Label();
            this.PanelBarTB = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbMainMSG = new System.Windows.Forms.Label();
            this.lbControlmsg = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.btnDone = new FontAwesome.Sharp.IconButton();
            this.btnReset = new FontAwesome.Sharp.IconButton();
            this.btnRetour = new FontAwesome.Sharp.IconButton();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.PaneltexBoxDesignBg.SuspendLayout();
            this.panel1.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PaneltexBoxDesignBg
            // 
            this.PaneltexBoxDesignBg.BackColor = System.Drawing.Color.Black;
            this.PaneltexBoxDesignBg.Controls.Add(this.panel1);
            this.PaneltexBoxDesignBg.Controls.Add(this.lbDesign);
            this.PaneltexBoxDesignBg.Controls.Add(this.PanelBarTB);
            this.PaneltexBoxDesignBg.Location = new System.Drawing.Point(102, 160);
            this.PaneltexBoxDesignBg.Name = "PaneltexBoxDesignBg";
            this.PaneltexBoxDesignBg.Size = new System.Drawing.Size(545, 29);
            this.PaneltexBoxDesignBg.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textBoxDesign);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(141, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 25);
            this.panel1.TabIndex = 9;
            // 
            // textBoxDesign
            // 
            this.textBoxDesign.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDesign.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBoxDesign.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDesign.Location = new System.Drawing.Point(4, 0);
            this.textBoxDesign.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.textBoxDesign.Name = "textBoxDesign";
            this.textBoxDesign.Size = new System.Drawing.Size(400, 25);
            this.textBoxDesign.TabIndex = 0;
            this.textBoxDesign.TextChanged += new System.EventHandler(this.textBoxDesign_TextChanged);
            this.textBoxDesign.Enter += new System.EventHandler(this.textBoxDesign_Enter);
            this.textBoxDesign.Leave += new System.EventHandler(this.textBoxDesign_Leave);
            // 
            // lbDesign
            // 
            this.lbDesign.AutoSize = true;
            this.lbDesign.BackColor = System.Drawing.Color.Transparent;
            this.lbDesign.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbDesign.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDesign.ForeColor = System.Drawing.Color.White;
            this.lbDesign.Location = new System.Drawing.Point(0, 0);
            this.lbDesign.Name = "lbDesign";
            this.lbDesign.Padding = new System.Windows.Forms.Padding(10, 3, 0, 0);
            this.lbDesign.Size = new System.Drawing.Size(109, 23);
            this.lbDesign.TabIndex = 2;
            this.lbDesign.Text = "Désignation :";
            // 
            // PanelBarTB
            // 
            this.PanelBarTB.BackColor = System.Drawing.SystemColors.Control;
            this.PanelBarTB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBarTB.Location = new System.Drawing.Point(0, 25);
            this.PanelBarTB.Name = "PanelBarTB";
            this.PanelBarTB.Size = new System.Drawing.Size(545, 4);
            this.PanelBarTB.TabIndex = 1;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(109, 40);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(286, 21);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "| Ajouter une nouvelle famille d\'article";
            // 
            // lbMainMSG
            // 
            this.lbMainMSG.AutoSize = true;
            this.lbMainMSG.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMainMSG.Location = new System.Drawing.Point(243, 89);
            this.lbMainMSG.Name = "lbMainMSG";
            this.lbMainMSG.Size = new System.Drawing.Size(71, 21);
            this.lbMainMSG.TabIndex = 7;
            this.lbMainMSG.Text = "Bonjour";
            this.lbMainMSG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbControlmsg
            // 
            this.lbControlmsg.AutoSize = true;
            this.lbControlmsg.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbControlmsg.Location = new System.Drawing.Point(243, 142);
            this.lbControlmsg.Name = "lbControlmsg";
            this.lbControlmsg.Size = new System.Drawing.Size(77, 15);
            this.lbControlmsg.TabIndex = 7;
            this.lbControlmsg.Text = "Tout est bon!";
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MainPanel.Controls.Add(this.btnDone);
            this.MainPanel.Controls.Add(this.btnReset);
            this.MainPanel.Controls.Add(this.btnRetour);
            this.MainPanel.Controls.Add(this.PanelTop);
            this.MainPanel.Controls.Add(this.lbControlmsg);
            this.MainPanel.Controls.Add(this.lbMainMSG);
            this.MainPanel.Controls.Add(this.lbTitle);
            this.MainPanel.Controls.Add(this.PaneltexBoxDesignBg);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(800, 450);
            this.MainPanel.TabIndex = 0;
            // 
            // btnDone
            // 
            this.btnDone.AutoSize = true;
            this.btnDone.FlatAppearance.BorderSize = 0;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDone.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            this.btnDone.IconColor = System.Drawing.Color.Black;
            this.btnDone.IconSize = 24;
            this.btnDone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDone.Location = new System.Drawing.Point(413, 212);
            this.btnDone.Name = "btnDone";
            this.btnDone.Rotation = 0D;
            this.btnDone.Size = new System.Drawing.Size(92, 30);
            this.btnDone.TabIndex = 11;
            this.btnDone.Text = " Ajouter";
            this.btnDone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btnReset.IconColor = System.Drawing.Color.Black;
            this.btnReset.IconSize = 24;
            this.btnReset.Location = new System.Drawing.Point(532, 212);
            this.btnReset.Name = "btnReset";
            this.btnReset.Rotation = 0D;
            this.btnReset.Size = new System.Drawing.Size(115, 30);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = " Réinitialiser";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.AutoSize = true;
            this.btnRetour.BackColor = System.Drawing.Color.White;
            this.btnRetour.FlatAppearance.BorderSize = 0;
            this.btnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetour.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnRetour.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRetour.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnRetour.IconColor = System.Drawing.Color.Black;
            this.btnRetour.IconSize = 24;
            this.btnRetour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRetour.Location = new System.Drawing.Point(12, 36);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Rotation = 0D;
            this.btnRetour.Size = new System.Drawing.Size(91, 30);
            this.btnRetour.TabIndex = 10;
            this.btnRetour.Text = " Quitter";
            this.btnRetour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRetour.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // PanelTop
            // 
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(800, 30);
            this.PanelTop.TabIndex = 9;
            // 
            // FormAjoutFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanel);
            this.Name = "FormAjoutFamille";
            this.Text = "FormAjoutFamille";
            this.Load += new System.EventHandler(this.FormAjoutFamille_Load);
            this.PaneltexBoxDesignBg.ResumeLayout(false);
            this.PaneltexBoxDesignBg.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PaneltexBoxDesignBg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxDesign;
        private System.Windows.Forms.Label lbDesign;
        private System.Windows.Forms.Panel PanelBarTB;
        private System.Windows.Forms.Label lbTitle;
        private FontAwesome.Sharp.IconButton btnRetour;
        private FontAwesome.Sharp.IconButton btnReset;
        private FontAwesome.Sharp.IconButton btnDone;
        private System.Windows.Forms.Label lbMainMSG;
        private System.Windows.Forms.Label lbControlmsg;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel PanelTop;
    }
}