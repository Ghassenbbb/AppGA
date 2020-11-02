using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace AppGA.Forms
{

    public partial class FormGestionArticles : Form
    {
        public static string designForm = "Gestion des Articles et Familles";
        private IconButton currentButtonGA;

        public FormGestionArticles()
        {
            InitializeComponent();
        }

        private void ThemeLoad()
        {
            this.PanelGAMenu.BackColor = ThemeColor.SecondaryColor;
        }
        private void FormGestionArticles_Load(object sender, EventArgs e)
        {
            ThemeLoad();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OpenChildFormArticle(Form childForm, object sender)
        {
            if (AppGA.subForm != null)
            {
                AppGA.subForm.Close();
            }

            if (AppGA.tempForm!= null)
            {
                AppGA.tempForm.Close();
            }

            AppGA.activeForm2Exit = (Button) sender;
            ActivateButtonGA(sender);
            AppGA.subForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.PanelGABody.Controls.Add(childForm);
            this.PanelGABody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ActivateButtonGA(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButtonGA != (IconButton)btnSender)
                {
                    DisableButtonGA();
                    currentButtonGA = (IconButton)btnSender;
                    currentButtonGA.BackColor = ThemeColor.PrimaryColor;
                    currentButtonGA.ForeColor = Color.White;
                    currentButtonGA.IconColor = Color.White;
                    currentButtonGA.Font = new Font("SF UI Display", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);

                }    
            }
        }

        private void DisableButtonGA()
        {
            foreach (Control previousBtn in PanelGAMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(IconButton))
                {
                    IconButton btn = (IconButton) previousBtn;
                    btn.BackColor = ThemeColor.SecondaryColor;
                    btn.ForeColor = Color.Black;
                    btn.IconColor = Color.Black;
                    btn.Font = new Font("SF UI Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                }
            }
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            OpenChildFormArticle(new Forms.GA.FormArticles(this.PanelGABody), sender);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            OpenChildFormArticle(new Forms.GA.FormFamilles(this.PanelGABody), sender);
        }

        public void OpenHome()
        {
            OpenChildFormArticle(new Forms.GA.FormArticles(this.PanelGABody), this.iconButton1);
        }
    }
}
