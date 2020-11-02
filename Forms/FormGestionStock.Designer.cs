namespace AppGA.Forms
{
    partial class FormGestionStock
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
            this.PanelGSBody = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.PanelGSMenu = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.PanelGSMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelGSBody
            // 
            this.PanelGSBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelGSBody.Location = new System.Drawing.Point(0, 40);
            this.PanelGSBody.Name = "PanelGSBody";
            this.PanelGSBody.Size = new System.Drawing.Size(772, 482);
            this.PanelGSBody.TabIndex = 4;
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.Font = new System.Drawing.Font("SF UI Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.PeopleCarry;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconSize = 24;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(120, 0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(152, 40);
            this.iconButton2.TabIndex = 1;
            this.iconButton2.Text = "  Fournisseurs";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // PanelGSMenu
            // 
            this.PanelGSMenu.BackColor = System.Drawing.SystemColors.Control;
            this.PanelGSMenu.Controls.Add(this.iconButton2);
            this.PanelGSMenu.Controls.Add(this.iconButton1);
            this.PanelGSMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelGSMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelGSMenu.Name = "PanelGSMenu";
            this.PanelGSMenu.Size = new System.Drawing.Size(772, 40);
            this.PanelGSMenu.TabIndex = 3;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("SF UI Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Th;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconSize = 24;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(120, 40);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "  Stock";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // FormGestionStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 522);
            this.Controls.Add(this.PanelGSBody);
            this.Controls.Add(this.PanelGSMenu);
            this.Name = "FormGestionStock";
            this.Text = "FormGestionStock";
            this.Load += new System.EventHandler(this.FormGestionStock_Load);
            this.PanelGSMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelGSBody;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Panel PanelGSMenu;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}