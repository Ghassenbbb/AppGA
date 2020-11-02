namespace AppGA
{
    partial class AppGA
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.PanelBottomBar = new System.Windows.Forms.Panel();
            this.btnGererComnd = new FontAwesome.Sharp.IconButton();
            this.btnGererStock = new FontAwesome.Sharp.IconButton();
            this.btnGererArticle = new FontAwesome.Sharp.IconButton();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.PanelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaxmize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.PanelDesktop = new System.Windows.Forms.Panel();
            this.PanelMenu.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            this.PanelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.PanelMenu.Controls.Add(this.PanelBottomBar);
            this.PanelMenu.Controls.Add(this.btnGererComnd);
            this.PanelMenu.Controls.Add(this.btnGererStock);
            this.PanelMenu.Controls.Add(this.btnGererArticle);
            this.PanelMenu.Controls.Add(this.PanelLogo);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(220, 641);
            this.PanelMenu.TabIndex = 0;
            // 
            // PanelBottomBar
            // 
            this.PanelBottomBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(164)))), ((int)(((byte)(191)))));
            this.PanelBottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBottomBar.Location = new System.Drawing.Point(0, 631);
            this.PanelBottomBar.Name = "PanelBottomBar";
            this.PanelBottomBar.Size = new System.Drawing.Size(220, 10);
            this.PanelBottomBar.TabIndex = 4;
            // 
            // btnGererComnd
            // 
            this.btnGererComnd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGererComnd.FlatAppearance.BorderSize = 0;
            this.btnGererComnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGererComnd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnGererComnd.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGererComnd.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnGererComnd.IconColor = System.Drawing.Color.White;
            this.btnGererComnd.IconSize = 32;
            this.btnGererComnd.Location = new System.Drawing.Point(0, 240);
            this.btnGererComnd.Name = "btnGererComnd";
            this.btnGererComnd.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnGererComnd.Rotation = 0D;
            this.btnGererComnd.Size = new System.Drawing.Size(220, 60);
            this.btnGererComnd.TabIndex = 3;
            this.btnGererComnd.Text = "  Gestion des Commades et Clients";
            this.btnGererComnd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGererComnd.UseVisualStyleBackColor = true;
            this.btnGererComnd.Click += new System.EventHandler(this.btnGererComnd_Click);
            // 
            // btnGererStock
            // 
            this.btnGererStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGererStock.FlatAppearance.BorderSize = 0;
            this.btnGererStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGererStock.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnGererStock.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGererStock.IconChar = FontAwesome.Sharp.IconChar.Cubes;
            this.btnGererStock.IconColor = System.Drawing.Color.White;
            this.btnGererStock.IconSize = 32;
            this.btnGererStock.Location = new System.Drawing.Point(0, 180);
            this.btnGererStock.Name = "btnGererStock";
            this.btnGererStock.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnGererStock.Rotation = 0D;
            this.btnGererStock.Size = new System.Drawing.Size(220, 60);
            this.btnGererStock.TabIndex = 2;
            this.btnGererStock.Text = "  Gestion de Stock et des Fournisseurs";
            this.btnGererStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGererStock.UseVisualStyleBackColor = true;
            this.btnGererStock.Click += new System.EventHandler(this.btnGererStock_Click);
            // 
            // btnGererArticle
            // 
            this.btnGererArticle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGererArticle.FlatAppearance.BorderSize = 0;
            this.btnGererArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGererArticle.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnGererArticle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGererArticle.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGererArticle.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.btnGererArticle.IconColor = System.Drawing.Color.White;
            this.btnGererArticle.IconSize = 32;
            this.btnGererArticle.Location = new System.Drawing.Point(0, 120);
            this.btnGererArticle.Name = "btnGererArticle";
            this.btnGererArticle.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnGererArticle.Rotation = 0D;
            this.btnGererArticle.Size = new System.Drawing.Size(220, 60);
            this.btnGererArticle.TabIndex = 1;
            this.btnGererArticle.Text = "  Gestion des Articles et Familles";
            this.btnGererArticle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGererArticle.UseVisualStyleBackColor = true;
            this.btnGererArticle.Click += new System.EventHandler(this.btnGererArticle_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.PanelLogo.Controls.Add(this.iconButton1);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(220, 120);
            this.PanelLogo.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("Montserrat Alternates Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.BusinessTime;
            this.iconButton1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconSize = 36;
            this.iconButton1.Location = new System.Drawing.Point(0, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(220, 120);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = " AppGa";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // PanelTitleBar
            // 
            this.PanelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(164)))), ((int)(((byte)(191)))));
            this.PanelTitleBar.Controls.Add(this.btnMinimize);
            this.PanelTitleBar.Controls.Add(this.btnMaxmize);
            this.PanelTitleBar.Controls.Add(this.btnClose);
            this.PanelTitleBar.Controls.Add(this.lbTitle);
            this.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.PanelTitleBar.Name = "PanelTitleBar";
            this.PanelTitleBar.Size = new System.Drawing.Size(788, 80);
            this.PanelTitleBar.TabIndex = 1;
            this.PanelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitleBar_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Montserrat Alternates", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(686, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaxmize
            // 
            this.btnMaxmize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxmize.FlatAppearance.BorderSize = 0;
            this.btnMaxmize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxmize.Font = new System.Drawing.Font("Montserrat Alternates", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMaxmize.ForeColor = System.Drawing.Color.White;
            this.btnMaxmize.Location = new System.Drawing.Point(722, 0);
            this.btnMaxmize.Name = "btnMaxmize";
            this.btnMaxmize.Size = new System.Drawing.Size(30, 30);
            this.btnMaxmize.TabIndex = 2;
            this.btnMaxmize.Text = "O";
            this.btnMaxmize.UseVisualStyleBackColor = true;
            this.btnMaxmize.Click += new System.EventHandler(this.btnMaxmize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Montserrat Alternates", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(758, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(6, 27);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(157, 47);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "ACCUEIL";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbTitle_MouseDown);
            // 
            // PanelDesktop
            // 
            this.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDesktop.Location = new System.Drawing.Point(220, 80);
            this.PanelDesktop.Name = "PanelDesktop";
            this.PanelDesktop.Size = new System.Drawing.Size(788, 561);
            this.PanelDesktop.TabIndex = 2;
            // 
            // AppGA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 641);
            this.Controls.Add(this.PanelDesktop);
            this.Controls.Add(this.PanelTitleBar);
            this.Controls.Add(this.PanelMenu);
            this.MinimumSize = new System.Drawing.Size(1024, 680);
            this.Name = "AppGA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppGA";
            this.Load += new System.EventHandler(this.AppGA_Load);
            this.PanelMenu.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            this.PanelTitleBar.ResumeLayout(false);
            this.PanelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel PanelLogo;
        private FontAwesome.Sharp.IconButton btnGererArticle;
        private FontAwesome.Sharp.IconButton btnGererComnd;
        private FontAwesome.Sharp.IconButton btnGererStock;
        private System.Windows.Forms.Panel PanelTitleBar;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel PanelDesktop;
        private System.Windows.Forms.Panel PanelBottomBar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaxmize;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}

