namespace AppGA.Forms.CMB
{
    partial class FormSuppMsgBox
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
            this.PanelTopBar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbtitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxMsg = new System.Windows.Forms.TextBox();
            this.iconPictureBox = new FontAwesome.Sharp.IconPictureBox();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnConfirm = new FontAwesome.Sharp.IconButton();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTopBar
            // 
            this.PanelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTopBar.Location = new System.Drawing.Point(0, 0);
            this.PanelTopBar.Name = "PanelTopBar";
            this.PanelTopBar.Size = new System.Drawing.Size(541, 6);
            this.PanelTopBar.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel2.Controls.Add(this.lbtitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 28);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // lbtitle
            // 
            this.lbtitle.AutoSize = true;
            this.lbtitle.BackColor = System.Drawing.Color.Transparent;
            this.lbtitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbtitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbtitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbtitle.ForeColor = System.Drawing.Color.White;
            this.lbtitle.Location = new System.Drawing.Point(0, 0);
            this.lbtitle.Name = "lbtitle";
            this.lbtitle.Padding = new System.Windows.Forms.Padding(10, 3, 0, 0);
            this.lbtitle.Size = new System.Drawing.Size(52, 24);
            this.lbtitle.TabIndex = 0;
            this.lbtitle.Text = "Title";
            this.lbtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbtitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbtitle_MouseDown);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxMsg);
            this.panel3.Location = new System.Drawing.Point(160, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(369, 112);
            this.panel3.TabIndex = 2;
            // 
            // textBoxMsg
            // 
            this.textBoxMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.textBoxMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMsg.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMsg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMsg.ForeColor = System.Drawing.Color.White;
            this.textBoxMsg.Location = new System.Drawing.Point(0, 0);
            this.textBoxMsg.Multiline = true;
            this.textBoxMsg.Name = "textBoxMsg";
            this.textBoxMsg.ReadOnly = true;
            this.textBoxMsg.Size = new System.Drawing.Size(369, 112);
            this.textBoxMsg.TabIndex = 0;
            this.textBoxMsg.Text = "Message";
            // 
            // iconPictureBox
            // 
            this.iconPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle;
            this.iconPictureBox.IconColor = System.Drawing.Color.White;
            this.iconPictureBox.IconSize = 112;
            this.iconPictureBox.Location = new System.Drawing.Point(13, 65);
            this.iconPictureBox.Name = "iconPictureBox";
            this.iconPictureBox.Size = new System.Drawing.Size(141, 112);
            this.iconPictureBox.TabIndex = 3;
            this.iconPictureBox.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Slash;
            this.btnCancel.IconColor = System.Drawing.Color.Black;
            this.btnCancel.IconSize = 32;
            this.btnCancel.Location = new System.Drawing.Point(416, 216);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Rotation = 0D;
            this.btnCancel.Size = new System.Drawing.Size(113, 36);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "  Annuler";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnConfirm.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnConfirm.IconColor = System.Drawing.Color.Black;
            this.btnConfirm.IconSize = 32;
            this.btnConfirm.Location = new System.Drawing.Point(245, 216);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Rotation = 0D;
            this.btnConfirm.Size = new System.Drawing.Size(113, 36);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "  Supprimer";
            this.btnConfirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // FormSuppMsgBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(541, 264);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.iconPictureBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PanelTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSuppMsgBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSuppMsgBox";
            this.Load += new System.EventHandler(this.FormSuppMsgBox_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormSuppMsgBox_MouseDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTopBar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox;
        private System.Windows.Forms.TextBox textBoxMsg;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnConfirm;
        private System.Windows.Forms.Label lbtitle;
    }
}