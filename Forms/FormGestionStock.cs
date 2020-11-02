using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppGA.Forms
{
    public partial class FormGestionStock : Form
    {
        public static string designForm = "Gestion de Stock et des Fournisseurs";
        private IconButton currentButtonGS;
        public FormGestionStock()
        {
            InitializeComponent();
        }

        private void FormGestionStock_Load(object sender, EventArgs e)
        {
            ThemeLoad();
        }

        private void ThemeLoad()
        {
            this.PanelGSMenu.BackColor = ThemeColor.SecondaryColor;
        }


        private void OpenChildFormArticle(Form childForm, object sender)
        {
            if (AppGA.subForm != null)
            {
                AppGA.subForm.Close();
            }

            if (AppGA.tempForm != null)
            {
                AppGA.tempForm.Close();
            }

            AppGA.activeForm2Exit = (Button)sender;
            ActivateButtonGS(sender);
            AppGA.subForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.PanelGSBody.Controls.Add(childForm);
            this.PanelGSBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ActivateButtonGS(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButtonGS != (IconButton)btnSender)
                {
                    DisableButtonGS();
                    currentButtonGS = (IconButton)btnSender;
                    currentButtonGS.BackColor = ThemeColor.PrimaryColor;
                    currentButtonGS.ForeColor = Color.White;
                    currentButtonGS.IconColor = Color.White;
                    currentButtonGS.Font = new Font("SF UI Display", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);

                }
            }
        }


        private void DisableButtonGS()
        {
            foreach (Control previousBtn in PanelGSMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(IconButton))
                {
                    IconButton btn = (IconButton)previousBtn;
                    btn.BackColor = ThemeColor.SecondaryColor;
                    btn.ForeColor = Color.Black;
                    btn.IconColor = Color.Black;
                    btn.Font = new Font("SF UI Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            OpenChildFormArticle(new Forms.GS.FormStocks(this.PanelGSBody), sender);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            OpenChildFormArticle(new Forms.GS.FormFournisseurs(this.PanelGSBody), sender);
        }

        public void OpenHome()
        {
            OpenChildFormArticle(new Forms.GS.FormStocks(this.PanelGSBody), this.iconButton1);
        }

    }
   
}
