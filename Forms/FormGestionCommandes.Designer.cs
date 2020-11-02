namespace AppGA.Forms
{
    partial class FormGestionCommandes
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
            this.PanelGCBody = new System.Windows.Forms.Panel();
            this.PanelGCMenu = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.PanelGCMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelGCBody
            // 
            this.PanelGCBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelGCBody.Location = new System.Drawing.Point(0, 40);
            this.PanelGCBody.Name = "PanelGCBody";
            this.PanelGCBody.Size = new System.Drawing.Size(772, 482);
            this.PanelGCBody.TabIndex = 6;
            // 
            // PanelGCMenu
            // 
            this.PanelGCMenu.BackColor = System.Drawing.SystemColors.Control;
            this.PanelGCMenu.Controls.Add(this.iconButton2);
            this.PanelGCMenu.Controls.Add(this.iconButton1);
            this.PanelGCMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelGCMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelGCMenu.Name = "PanelGCMenu";
            this.PanelGCMenu.Size = new System.Drawing.Size(772, 40);
            this.PanelGCMenu.TabIndex = 5;
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.Font = new System.Drawing.Font("SF UI Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconSize = 24;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(144, 0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(100, 40);
            this.iconButton2.TabIndex = 1;
            this.iconButton2.Text = "  Clients";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("SF UI Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ShoppingBasket;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconSize = 24;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(144, 40);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "  Commandes";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // FormGestionCommandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 522);
            this.Controls.Add(this.PanelGCBody);
            this.Controls.Add(this.PanelGCMenu);
            this.Name = "FormGestionCommandes";
            this.Text = "FormGestionCommandes";
            this.Load += new System.EventHandler(this.FormGestionCommandes_Load);
            this.PanelGCMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelGCBody;
        private System.Windows.Forms.Panel PanelGCMenu;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}