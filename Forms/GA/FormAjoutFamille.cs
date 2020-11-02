using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace AppGA.Forms.GA
{
    public partial class FormAjoutFamille : Form
    {
        private DataGridViewRow row;
        private string rowDesign;
        private string rowCode;
        public FormAjoutFamille(DataGridViewRow row)
        {
            InitializeComponent();
            this.row = row;
            this.rowDesign = row?.Cells[0].Value.ToString();
            this.rowCode = row?.Cells[1].Value.ToString();
        }

        private void FormAjoutFamille_Load(object sender, EventArgs e)
        {
            reset();
            loadTheme();
        }

        private void reset()
        {
            PanelBarTB.BackColor = ThemeColor.SecondaryColor;
            if (row == null) textBoxDesign.Text = string.Empty;
            else textBoxDesign.Text = this.rowDesign;
            lbControlmsg.Text = string.Empty;
            lbMainMSG.Text = string.Empty;
        }

        private void loadTheme()
        {
            //Buttons Theme Apply
            foreach (Control btns in MainPanel.Controls)
            {
                if (btns.GetType() == typeof(IconButton))
                {
                    IconButton btn = (IconButton)btns;
                    btn.BackColor = ThemeColor.SecondaryColor;
                    btn.ForeColor = Color.Black;
                    btn.FlatAppearance.BorderColor = ThemeColor.PrimaryColor;
                }
            }

            lbTitle.ForeColor = ThemeColor.DarkColor;
            PaneltexBoxDesignBg.BackColor = ThemeColor.DarkColor;

            if (this.row != null)
            {
                btnDone.Text = "Appliquer";
                lbTitle.Text = "| Modifier la désignation d'une famille d'article";
            }
        }

        private void AjoutFamille()
        {
            if (FormControl())
            {
                string query;

                if (row == null) query = "INSERT INTO FamilleArt([Design]) VALUES (@Design)"; 
                    else query = "UPDATE FamilleArt SET Design = (@Design) WHERE CodeFamille = (@Code)";

                   



                SqlCommand sqlcommand = new SqlCommand(query, dbCon.con);
                sqlcommand.Parameters.AddWithValue("@Design", textBoxDesign.Text);
                if (row != null) sqlcommand.Parameters.Add("@Code", SqlDbType.Int).Value = this.rowCode;

                if (dbCon.queryInsert(sqlcommand) == 1)
                {
                    if (this.row == null) {
                        reset();
                        lbMainMSG.Text = "Famille a été modifiée avec succès !"; }
                    else {
                        this.rowDesign = textBoxDesign.Text;
                        reset();
                        lbMainMSG.Text = "Famille a été modifiée avec succès !"; }

                    lbMainMSG.ForeColor = ThemeColor.PrimaryColor;
                } else
                {
                    if (this.row == null) lbMainMSG.Text = "Ajout echoué !";
                    else lbMainMSG.Text = "Modification echouée";
                    lbMainMSG.ForeColor = Color.Red;
                }
            }
        }

        private bool FormControl()
        {
            int errorCount = 0;
            if (textBoxDesign.Text == String.Empty)
            {
                lbControlmsg.Text = "Vous devez remplir ce champ !";
                lbControlmsg.ForeColor = Color.Red;
                PanelBarTB.BackColor = Color.Red;
                errorCount++;
            }
            else
            {
                if (dbCon.CheckExistDB("FamilleArt", "Design", textBoxDesign.Text))
                {
                    lbControlmsg.Text = "Cette famille existe deja !";
                    lbControlmsg.ForeColor = Color.Red;
                    PanelBarTB.BackColor = Color.Red;
                    errorCount++;
                }
            }

            return errorCount == 0;

        }

        private void textBoxDesign_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDesign.Text != string.Empty)
            {
                lbControlmsg.Text = string.Empty;
                PanelBarTB.BackColor = ThemeColor.SecondaryColor;
            }
        }

        private void textBoxDesign_Enter(object sender, EventArgs e)
        {
            PaneltexBoxDesignBg.BackColor = ThemeColor.PrimaryColor;
        }

        private void textBoxDesign_Leave(object sender, EventArgs e)
        {
            PaneltexBoxDesignBg.BackColor = ThemeColor.DarkColor;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            if (AppGA.activeForm2Exit != null)
                AppGA.activeForm2Exit.PerformClick();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            lbMainMSG.Text = string.Empty;
            AjoutFamille();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
