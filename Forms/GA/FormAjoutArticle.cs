using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AppGA.Forms.GA
{
    public partial class FormAjoutArticle : Form
    {
        string sRefArt, sDesign, sFamille, sPoids, sCouleur;
        private DataGridViewRow row;
        public FormAjoutArticle(DataGridViewRow row)
        {
            this.row = row;
            if (row != null) {
            this.sRefArt = row.Cells[0].Value.ToString();
            this.sDesign = row.Cells[1].Value.ToString();
            this.sFamille = row.Cells[2].Value.ToString();
            this.sPoids = row.Cells[3].Value.ToString();
            this.sCouleur = row.Cells[4].Value.ToString();
            }
            InitializeComponent();
        }

        private void FormAjoutArticle_Load(object sender, EventArgs e)
        {
            loadTheme();
            LoadComboBoxFamilles();
            Reset();
        }
        private void loadTheme()
        {
            //Buttons Theme Apply
            foreach (Control btns in PanelMain.Controls)
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

            if (this.row != null)
            {
                lbTitle.Text = "| Modifier un Article";
                btnConfirm.Text = "Appliquer";
            }
        }
        private void Reset()
        {
            // PanelBar Theme Apply
            PanelBarRefArt.BackColor = ThemeColor.SecondaryColor;
            PanelBarDesign.BackColor = ThemeColor.SecondaryColor;
            PanelBarPoids.BackColor = ThemeColor.SecondaryColor;
            PanelBarCouleur.BackColor = ThemeColor.SecondaryColor;
            PanelBarFamille.BackColor = ThemeColor.SecondaryColor;

            // Panel  Background Theme Apply
            PaneltexBoxRefArtBg.BackColor = ThemeColor.DarkColor;
            PaneltexBoxDesignBg.BackColor = ThemeColor.DarkColor;
            PaneltexBoxCouleurBg.BackColor = ThemeColor.DarkColor;
            PaneltexBoxPoidsBg.BackColor = ThemeColor.DarkColor;
            PaneltexBoxFamilleBg.BackColor = ThemeColor.DarkColor;


            // Reset Control msg
            lbMainMSG.Text = string.Empty;
            lbControlDesign.Text = string.Empty;
            lbControlRefart.Text = string.Empty;
            lbControlFamille.Text = string.Empty;
            lbControlCouleur.Text = string.Empty;
            lbControlPoids.Text = string.Empty;

            if (row == null) {

            // Reset TextBoxes
            textBoxRefArt.Text = string.Empty;
            textBoxDesign.Text = string.Empty;
            textBoxCouleur.Text = string.Empty;
            textBoxPoids.Text = string.Empty;

            //Reset ComboBox
            comboBoxFamille.SelectedIndex = -1;

            } else
            {
                textBoxRefArt.Text = this.sRefArt;
                textBoxRefArt.ReadOnly = true;
                textBoxDesign.Text = this.sDesign;
                textBoxCouleur.Text = this.sCouleur;
                textBoxPoids.Text = this.sPoids;

                //Reset ComboBox
                comboBoxFamille.SelectedIndex = comboBoxFamille.FindStringExact(this.sFamille);
            }

        }

        private bool FormControl()
        {
            int control = 0;
            if (textBoxRefArt.Text == string.Empty) {
                PanelBarRefArt.BackColor = Color.Red;
                lbControlRefart.Text = "Vous devez remplir ce champ.";
                control++;
            }
            else if (!Regex.Match(textBoxRefArt.Text, @"^[a-zA-Z0-9]*$").Success) {
                PanelBarRefArt.BackColor = Color.Red;
                lbControlRefart.Text = "Ce champ doit contenir que des caractères Alphanumériques.";
                control++;
            }else if (this.row == null && dbCon.CheckExistDB("Article", "refArt", textBoxRefArt.Text))
            {
                PanelBarRefArt.BackColor = Color.Red;
                lbControlRefart.Text = "Ce référance existe déja !";
                control++;
            }

            if (textBoxDesign.Text == string.Empty)
            {
                PanelBarDesign.BackColor = Color.Red;
                lbControlDesign.Text = "Vous devez remplir ce champ.";
                control++;
            }
            else if (!Regex.Match(textBoxDesign.Text, @"^[a-zA-Z0-9-+. ]*$").Success)
            {
                PanelBarDesign.BackColor = Color.Red;
                lbControlDesign.Text = "Ce champ doit contenir que des caractères Alphanumériques et ces Symboles : (\"+\", \"-\", \".\")";
                control++;
            }

            if (textBoxCouleur.Text == string.Empty)
            {
                PanelBarCouleur.BackColor = Color.Red;
                lbControlCouleur.Text = "Vous devez remplir ce champ.";
                control++;
            }
            else if (!Regex.Match(textBoxCouleur.Text, @"^[a-zA-Z]*$").Success)
            {
                PanelBarCouleur.BackColor = Color.Red;
                lbControlCouleur.Text = "Ce champ doit contenir que des caractères Alphabet.";
                control++;
            }


            if (textBoxPoids.Text == string.Empty)
            {
                PanelBarPoids.BackColor = Color.Red;
                lbControlPoids.Text = "Vous devez remplir ce champ.";
                control++;
            }

            if (comboBoxFamille.SelectedIndex < 0)
            {
                lbControlFamille.Text = "Vous devez Choisir une famille.";
                PanelBarFamille.BackColor = Color.Red;
                control++;
            };


            return control==0;
        }
        private void LoadComboBoxFamilles()
        {
            var ds = dbCon.querySelect("SELECT Design, CodeFamille FROM FamilleArt;");
            comboBoxFamille.DataSource = ds.Tables[0];
            comboBoxFamille.ValueMember = "CodeFamille";
            comboBoxFamille.DisplayMember = "Design";
        }

        private void AjoutFamille()
        {
            if (FormControl())
            {
                string query;

                query = "INSERT INTO Article ([refArt], [Design], [codeFamille], [Couleur], [poids]) VALUES (@refArt, @Design, @codeFamille, @Couleur, @poids);";
                SqlCommand sqlcommand = new SqlCommand(query, dbCon.con);
                
                sqlcommand.Parameters.Add("@refArt", SqlDbType.VarChar, 50).Value = textBoxRefArt.Text;
                sqlcommand.Parameters.Add("@Design", SqlDbType.VarChar, 100).Value = textBoxDesign.Text;
                sqlcommand.Parameters.Add("@codeFamille", SqlDbType.BigInt).Value = comboBoxFamille.SelectedValue;
                sqlcommand.Parameters.Add("@Couleur", SqlDbType.VarChar, 100).Value = textBoxCouleur.Text;
                sqlcommand.Parameters.Add("@Poids", SqlDbType.Float).Value = textBoxPoids.Text;

                if (dbCon.queryInsert(sqlcommand) == 1)
                {
                        Reset();
                        lbMainMSG.Text = "Article a été ajouté avec succès !";

                        lbMainMSG.ForeColor = ThemeColor.PrimaryColor;
                }
                else
                {
                    lbMainMSG.Text = "Ajout echoué !";
                    lbMainMSG.ForeColor = Color.Red;
                }
            }
        }

        private void ModifierFamille()
        {
            string query = "UPDATE Article SET design = (@Design), codeFamille = (@codeFamille), Couleur = (@Couleur), Poids = (@Poids) WHERE refArt = (@refArt)";
            SqlCommand sqlcommand = new SqlCommand(query, dbCon.con);

            this.sRefArt = textBoxRefArt.Text;
            this.sDesign = textBoxDesign.Text;
            this.sCouleur = textBoxCouleur.Text;
            this.sPoids = textBoxPoids.Text;
            this.sFamille = comboBoxFamille.Text;

            sqlcommand.Parameters.Add("@refArt", SqlDbType.VarChar, 50).Value = this.sRefArt;
            sqlcommand.Parameters.Add("@Design", SqlDbType.VarChar, 100).Value = this.sDesign;
            sqlcommand.Parameters.Add("@codeFamille", SqlDbType.BigInt).Value = comboBoxFamille.SelectedValue;
            sqlcommand.Parameters.Add("@Couleur", SqlDbType.VarChar, 100).Value = this.sCouleur;
            sqlcommand.Parameters.Add("@Poids", SqlDbType.Float).Value = this.sPoids;

            if (dbCon.queryInsert(sqlcommand) == 1)
            {
                Reset();
                lbMainMSG.Text = "Article a été modifié avec succès !";
                lbMainMSG.ForeColor = ThemeColor.PrimaryColor;
            }
            else
            {
                lbMainMSG.Text = "Modification echouée !";
                lbMainMSG.ForeColor = Color.Red;
            }
        }
        private void bnRetour_Click(object sender, EventArgs e)
        {
            if (AppGA.activeForm2Exit != null)
                AppGA.activeForm2Exit.PerformClick();
        }

        private void btnReinitialiser_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            lbMainMSG.Text = string.Empty;
            if (this.row == null) AjoutFamille();
                else ModifierFamille();
        }

        private void textBoxPoids_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar, dotControl = '.';

            if (textBoxPoids.Text.IndexOf('.') != -1)
                dotControl = '0';

            if (!char.IsDigit(chr) && !char.IsControl(chr) && chr != dotControl)
                e.Handled = true;
        }

        private void textBoxRefArt_TextChanged(object sender, EventArgs e)
        {
            if (textBoxRefArt.Text != string.Empty)
            {
                lbControlRefart.Text = string.Empty;
                PanelBarRefArt.BackColor = ThemeColor.SecondaryColor;
            }
        }

        private void textBoxDesign_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDesign.Text != string.Empty)
            {
                lbControlDesign.Text = string.Empty;
                PanelBarDesign.BackColor = ThemeColor.SecondaryColor;
            }
        }

        private void textBoxCouleur_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCouleur.Text != string.Empty)
            {
                lbControlCouleur.Text = string.Empty;
                PanelBarCouleur.BackColor = ThemeColor.SecondaryColor;
            }
        }

        private void textBoxPoids_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPoids.Text != string.Empty)
            {
                lbControlPoids.Text = string.Empty;
                PanelBarPoids.BackColor = ThemeColor.SecondaryColor;
            }
        }

        private void comboBoxFamille_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFamille.SelectedIndex > 0)
            {
                lbControlFamille.Text = string.Empty;
                PanelBarFamille.BackColor = ThemeColor.SecondaryColor;
            }
        }

        private void textBoxRefArt_Enter(object sender, EventArgs e)
        {
            PaneltexBoxRefArtBg.BackColor = ThemeColor.PrimaryColor;
        }

        private void textBoxRefArt_Leave(object sender, EventArgs e)
        {
            PaneltexBoxRefArtBg.BackColor = ThemeColor.DarkColor;
        }

        private void textBoxDesign_Enter(object sender, EventArgs e)
        {
            PaneltexBoxDesignBg.BackColor = ThemeColor.PrimaryColor;
        }

        private void textBoxDesign_Leave(object sender, EventArgs e)
        {
            PaneltexBoxDesignBg.BackColor = ThemeColor.DarkColor;
        }

        private void textBoxCouleur_Enter(object sender, EventArgs e)
        {
            PaneltexBoxCouleurBg.BackColor = ThemeColor.PrimaryColor;
        }

        private void textBoxCouleur_Leave(object sender, EventArgs e)
        {
            PaneltexBoxCouleurBg.BackColor = ThemeColor.DarkColor;
        }

        private void textBoxPoids_Enter(object sender, EventArgs e)
        {
            PaneltexBoxPoidsBg.BackColor = ThemeColor.PrimaryColor;
        }

        private void textBoxPoids_Leave(object sender, EventArgs e)
        {
            PaneltexBoxPoidsBg.BackColor = ThemeColor.DarkColor;
        }

        private void comboBoxFamille_Enter(object sender, EventArgs e)
        {
            PaneltexBoxFamilleBg.BackColor = ThemeColor.PrimaryColor;
        }

        private void comboBoxFamille_Leave(object sender, EventArgs e)
        {
            PaneltexBoxFamilleBg.BackColor = ThemeColor.DarkColor;
        }
    }
}
