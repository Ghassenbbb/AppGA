namespace AppGA.Forms.GC
{
    partial class ArticleItem
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
            this.lbDesign = new System.Windows.Forms.Label();
            this.lbidStock = new System.Windows.Forms.Label();
            this.btnCancelItem = new FontAwesome.Sharp.IconButton();
            this.lbQnt = new System.Windows.Forms.Label();
            this.Panelitem = new System.Windows.Forms.Panel();
            this.PanelBotBar = new System.Windows.Forms.Panel();
            this.Panelitem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbDesign
            // 
            this.lbDesign.AutoSize = true;
            this.lbDesign.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDesign.Location = new System.Drawing.Point(12, 41);
            this.lbDesign.Name = "lbDesign";
            this.lbDesign.Size = new System.Drawing.Size(44, 15);
            this.lbDesign.TabIndex = 1;
            this.lbDesign.Text = "Design";
            // 
            // lbidStock
            // 
            this.lbidStock.AutoSize = true;
            this.lbidStock.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbidStock.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbidStock.Location = new System.Drawing.Point(100, 8);
            this.lbidStock.Name = "lbidStock";
            this.lbidStock.Size = new System.Drawing.Size(45, 13);
            this.lbidStock.TabIndex = 2;
            this.lbidStock.Text = "idStock";
            // 
            // btnCancelItem
            // 
            this.btnCancelItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelItem.FlatAppearance.BorderSize = 0;
            this.btnCancelItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelItem.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCancelItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelItem.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCancelItem.IconColor = System.Drawing.Color.Black;
            this.btnCancelItem.IconSize = 16;
            this.btnCancelItem.Location = new System.Drawing.Point(210, 0);
            this.btnCancelItem.Name = "btnCancelItem";
            this.btnCancelItem.Rotation = 0D;
            this.btnCancelItem.Size = new System.Drawing.Size(34, 21);
            this.btnCancelItem.TabIndex = 3;
            this.btnCancelItem.Text = "X";
            this.btnCancelItem.UseVisualStyleBackColor = true;
            this.btnCancelItem.Click += new System.EventHandler(this.M_Click);
            // 
            // lbQnt
            // 
            this.lbQnt.AutoSize = true;
            this.lbQnt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbQnt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbQnt.Location = new System.Drawing.Point(12, 8);
            this.lbQnt.Name = "lbQnt";
            this.lbQnt.Size = new System.Drawing.Size(38, 13);
            this.lbQnt.TabIndex = 4;
            this.lbQnt.Text = "label1";
            // 
            // Panelitem
            // 
            this.Panelitem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Panelitem.Controls.Add(this.btnCancelItem);
            this.Panelitem.Controls.Add(this.PanelBotBar);
            this.Panelitem.Controls.Add(this.lbQnt);
            this.Panelitem.Controls.Add(this.lbidStock);
            this.Panelitem.Controls.Add(this.lbDesign);
            this.Panelitem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panelitem.Location = new System.Drawing.Point(0, 0);
            this.Panelitem.Name = "Panelitem";
            this.Panelitem.Size = new System.Drawing.Size(244, 75);
            this.Panelitem.TabIndex = 5;
            // 
            // PanelBotBar
            // 
            this.PanelBotBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBotBar.Location = new System.Drawing.Point(0, 74);
            this.PanelBotBar.Name = "PanelBotBar";
            this.PanelBotBar.Size = new System.Drawing.Size(244, 1);
            this.PanelBotBar.TabIndex = 5;
            this.PanelBotBar.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelBotBar_Paint);
            // 
            // ArticleItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 75);
            this.Controls.Add(this.Panelitem);
            this.Name = "ArticleItem";
            this.Text = "ArticleItem";
            this.Load += new System.EventHandler(this.ArticleItem_Load);
            this.Panelitem.ResumeLayout(false);
            this.Panelitem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbDesign;
        private System.Windows.Forms.Label lbidStock;
        private FontAwesome.Sharp.IconButton btnCancelItem;
        private System.Windows.Forms.Label lbQnt;
        private System.Windows.Forms.Panel Panelitem;
        private System.Windows.Forms.Panel PanelBotBar;
    }
}