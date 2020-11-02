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
    public partial class FormGestionCommandes : Form
    {
        public static string designForm = "Gestion des Commandes et Clients";
        private IconButton currentButtonGC;
        public FormGestionCommandes()
        {
            InitializeComponent();
        }

        private void FormGestionCommandes_Load(object sender, EventArgs e)
        {
            ThemeLoad();
        }

        private void ThemeLoad()
        {
            this.PanelGCMenu.BackColor = ThemeColor.SecondaryColor;
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
            ActivateButtonGC(sender);
            AppGA.subForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.PanelGCBody.Controls.Add(childForm);
            this.PanelGCBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ActivateButtonGC(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButtonGC != (IconButton)btnSender)
                {
                    DisableButtonGC();
                    currentButtonGC = (IconButton)btnSender;
                    currentButtonGC.BackColor = ThemeColor.PrimaryColor;
                    currentButtonGC.ForeColor = Color.White;
                    currentButtonGC.IconColor = Color.White;
                    currentButtonGC.Font = new Font("SF UI Display", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);

                }
            }
        }

        private void DisableButtonGC()
        {
            foreach (Control previousBtn in PanelGCMenu.Controls)
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
            OpenChildFormArticle(new Forms.GC.FormCommandes(this.PanelGCBody), sender);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            OpenChildFormArticle(new Forms.GC.FormClients(this.PanelGCBody), sender);
        }

        public void OpenHome()
        {
            OpenChildFormArticle(new Forms.GC.FormCommandes(this.PanelGCBody), this.iconButton1);
        }
    }
}
