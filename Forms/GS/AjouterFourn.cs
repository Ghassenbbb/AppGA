using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AppGA.Forms.GS
{

    public partial class AjouterFourn : Form
    {
        private string sRefFour, sNom, sGSM, sEmail, sAdr, sFax;
        private DataGridViewRow row;

        public AjouterFourn(DataGridViewRow row)
        {
            this.row = row;
            if (row != null)
            {
                this.sRefFour = row.Cells[0].Value.ToString();
                this.sNom = row.Cells[1].Value.ToString();
                this.sGSM = row.Cells[2].Value.ToString();
                this.sFax = row.Cells[3].Value.ToString();
                this.sEmail = row.Cells[4].Value.ToString();
                this.sAdr = row.Cells[5].Value.ToString();
            }
            InitializeComponent();
        }

        private void AjouterFourn_Load(object sender, EventArgs e)
        {
            loadTheme();
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
            PanelBarRefFour.BackColor = ThemeColor.SecondaryColor;
            PanelBarNom.BackColor = ThemeColor.SecondaryColor;
            PanelBarGSM.BackColor = ThemeColor.SecondaryColor;
            PanelBarFax.BackColor = ThemeColor.SecondaryColor;
            PanelBarEmail.BackColor = ThemeColor.SecondaryColor;
            PanelBarAdr.BackColor = ThemeColor.SecondaryColor;

            // Panel  Background Theme Apply
            PaneltexBoxBgRefFour.BackColor = ThemeColor.DarkColor;
            PaneltexBoxBgNom.BackColor = ThemeColor.DarkColor;
            PaneltexBoxBgGSM.BackColor = ThemeColor.DarkColor;
            PaneltexBoxBgFax.BackColor = ThemeColor.DarkColor;
            PaneltexBoxBgEmail.BackColor = ThemeColor.DarkColor;
            PaneltexBoxBgAdr.BackColor = ThemeColor.DarkColor;


            // Reset Control msg
            lbMainMSG.Text = string.Empty;
            lbControlRefFour.Text = string.Empty;
            lbControlNom.Text = string.Empty;
            lbControlGSM.Text = string.Empty;
            lbControlFax.Text = string.Empty;
            lbControlAdr.Text = string.Empty;
            lbControlEmail.Text = string.Empty;

            if (row == null)
            {

                // Reset TextBoxes
                textBoxRefFour.Text = string.Empty;
                textBoxNom.Text = string.Empty;
                textBoxGSM.Text = string.Empty;
                textBoxEmail.Text = string.Empty;
                textBoxAdr.Text = string.Empty;
                textBoxFax.Text = string.Empty;


            }
            else
            {
                textBoxRefFour.Text = this.sRefFour;
                textBoxRefFour.ReadOnly = true;
                textBoxNom.Text = this.sNom;
                textBoxGSM.Text = this.sGSM;
                textBoxEmail.Text = this.sEmail;
                textBoxAdr.Text = this.sAdr;
                textBoxFax.Text = this.sFax;

            }

        }

        private bool FormControl()
        {
            int control = 0;
            if (textBoxRefFour.Text == string.Empty)
            {
                PanelBarRefFour.BackColor = Color.Red;
                lbControlRefFour.Text = "Vous devez remplir ce champ.";
                control++;
            }
            else if (!Regex.Match(textBoxRefFour.Text, @"^[a-zA-Z0-9]*$").Success)
            {
                PanelBarRefFour.BackColor = Color.Red;
                lbControlRefFour.Text = "Ce champ doit contenir que des caractères Alphanumériques.";
                control++;
            }
            else if (this.row == null && dbCon.CheckExistDB("Fournisseur", "RefFour", textBoxRefFour.Text))
            {
                PanelBarRefFour.BackColor = Color.Red;
                lbControlRefFour.Text = "Ce référance existe déja !";
                control++;
            }

            if (textBoxNom.Text == string.Empty)
            {
                PanelBarNom.BackColor = Color.Red;
                lbControlNom.Text = "Vous devez remplir ce champ.";
                control++;
            }
            else if (!Regex.Match(textBoxNom.Text, @"^[a-zA-Z0-9-+. ]*$").Success)
            {
                PanelBarNom.BackColor = Color.Red;
                lbControlNom.Text = "Ce champ doit contenir que des caractères Alphanumériques et ces Symboles : (\"+\", \"-\", \".\")";
                control++;
            }

            if (textBoxAdr.Text == string.Empty)
            {
                PanelBarAdr.BackColor = Color.Red;
                lbControlAdr.Text = "Vous devez remplir ce champ.";
                control++;
            }
            else if (!Regex.Match(textBoxAdr.Text, @"^[a-zA-Z0-9-+.°/, ]*$").Success)
            {
                PanelBarAdr.BackColor = Color.Red;
                lbControlAdr.Text = "Ce champ doit contenir que des caractères Alphanumériques et ces Symboles : (\"+\", \"-\", \".\", \"°\", \"/\", \",\")";
                control++;
            }

            if (textBoxGSM.Text == string.Empty)
            {
                PanelBarGSM.BackColor = Color.Red;
                lbControlGSM.Text = "Vous devez remplir ce champ.";
                control++;
            }
            else if (!Regex.Match(textBoxGSM.Text, @"^[0-9+ ]*$").Success)
            {
                PanelBarGSM.BackColor = Color.Red;
                lbControlGSM.Text = "Ce champ doit contenir que des caractères numérique et Symbole \"+\".";
                control++;
            }

            if (textBoxFax.Text == string.Empty)
            {
                PanelBarFax.BackColor = Color.Red;
                lbControlFax.Text = "Vous devez remplir ce champ.";
                control++;
            }
            else if (!Regex.Match(textBoxFax.Text, @"^[0-9+ ]*$").Success)
            {
                PanelBarFax.BackColor = Color.Red;
                lbControlFax.Text = "Ce champ doit contenir que des caractères numérique et Symbole \"+\".";
                control++;
            }

            if (textBoxEmail.Text == string.Empty)
            {
                PanelBarEmail.BackColor = Color.Red;
                lbControlEmail.Text = "Vous devez remplir ce champ.";
                control++;
            }
            else if (!Regex.Match(textBoxEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success)
            {
                PanelBarEmail.BackColor = Color.Red;
                lbControlEmail.Text = "Email Incorrecte.";
                control++;
            }


            return control == 0;
        }

        private void textBoxRefFour_TextChanged(object sender, EventArgs e)
        {
            if (textBoxRefFour.Text != string.Empty)
            {
                lbControlRefFour.Text = string.Empty;
                PanelBarRefFour.BackColor = ThemeColor.SecondaryColor;
            }
        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNom.Text != string.Empty)
            {
                lbControlNom.Text = string.Empty;
                PanelBarNom.BackColor = ThemeColor.SecondaryColor;
            }
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if (textBoxEmail.Text != string.Empty)
            {
                lbControlEmail.Text = string.Empty;
                PanelBarEmail.BackColor = ThemeColor.SecondaryColor;
            }
        }

        private void textBoxGSM_TextChanged(object sender, EventArgs e)
        {
            if (textBoxGSM.Text != string.Empty)
            {
                lbControlGSM.Text = string.Empty;
                PanelBarGSM.BackColor = ThemeColor.SecondaryColor;
            }
        }

        private void textBoxFax_TextChanged(object sender, EventArgs e)
        {
            if (textBoxFax.Text != string.Empty)
            {
                lbControlFax.Text = string.Empty;
                PanelBarFax.BackColor = ThemeColor.SecondaryColor;
            }
        }

        private void textBoxAdr_TextChanged(object sender, EventArgs e)
        {
            if (textBoxAdr.Text != string.Empty)
            {
                lbControlAdr.Text = string.Empty;
                PanelBarAdr.BackColor = ThemeColor.SecondaryColor;
            }
        }

        private void textBoxRefFour_Enter(object sender, EventArgs e)
        {
           PaneltexBoxBgRefFour.BackColor = ThemeColor.PrimaryColor;
        }

        private void textBoxRefFour_Leave(object sender, EventArgs e)
        {
            PaneltexBoxBgRefFour.BackColor = ThemeColor.DarkColor;
        }

        private void textBoxNom_Enter(object sender, EventArgs e)
        {
            PaneltexBoxBgNom.BackColor = ThemeColor.PrimaryColor;
        }

        private void textBoxNom_Leave(object sender, EventArgs e)
        {
            PaneltexBoxBgNom.BackColor = ThemeColor.DarkColor;
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            PaneltexBoxBgEmail.BackColor = ThemeColor.PrimaryColor;
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            PaneltexBoxBgEmail.BackColor = ThemeColor.DarkColor;
        }

        private void textBoxGSM_Enter(object sender, EventArgs e)
        {
            PaneltexBoxBgGSM.BackColor = ThemeColor.PrimaryColor;
        }

        private void textBoxGSM_Leave(object sender, EventArgs e)
        {
            PaneltexBoxBgGSM.BackColor = ThemeColor.DarkColor;
        }

        private void textBoxFax_Enter(object sender, EventArgs e)
        {
            PaneltexBoxBgFax.BackColor = ThemeColor.PrimaryColor;
        }

        private void textBoxFax_Leave(object sender, EventArgs e)
        {
            PaneltexBoxBgFax.BackColor = ThemeColor.DarkColor;
        }

        private void textBoxAdr_Enter(object sender, EventArgs e)
        {
            PaneltexBoxBgAdr.BackColor = ThemeColor.PrimaryColor;
        }

        private void textBoxAdr_Leave(object sender, EventArgs e)
        {
            PaneltexBoxBgFax.BackColor = ThemeColor.DarkColor;
        }

        private void AjoutFourn()
        {
            if (FormControl())
            {
                string query;

                query = "INSERT INTO Fournisseur ([RefFour], [NomF], [gsmF], [faxF], [emailF], [adrF]) VALUES (@RefFour, @Nom, @GSM, @Fax, @Email, @Adr);";
                SqlCommand sqlcommand = new SqlCommand(query, dbCon.con);

                sqlcommand.Parameters.Add("@RefFour", SqlDbType.VarChar, 50).Value = textBoxRefFour.Text;
                sqlcommand.Parameters.Add("@Nom", SqlDbType.VarChar, 100).Value = textBoxNom.Text;
                sqlcommand.Parameters.Add("@GSM", SqlDbType.VarChar, 15).Value = textBoxGSM.Text;
                sqlcommand.Parameters.Add("@Fax", SqlDbType.VarChar, 15).Value = textBoxFax.Text;
                sqlcommand.Parameters.Add("@Email", SqlDbType.VarChar, 320).Value = textBoxEmail.Text;
                sqlcommand.Parameters.Add("@Adr", SqlDbType.VarChar, 320).Value = textBoxAdr.Text;

                if (dbCon.queryInsert(sqlcommand) == 1)
                {
                    Reset();
                    lbMainMSG.Text = "Fournisseur a été ajouté avec succès !";

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
            if (FormControl())
            {
                string query = "UPDATE Fournisseur SET NomF = (@Nom), emailF = (@Email), gsmF = (@GSM), faxF = (@Fax), adrF = (@Adr) WHERE RefFour = (@RefFour)";
                SqlCommand sqlcommand = new SqlCommand(query, dbCon.con);

                this.sNom = textBoxNom.Text;
                this.sGSM = textBoxGSM.Text;
                this.sEmail = textBoxEmail.Text;
                this.sAdr = textBoxAdr.Text;
                this.sFax = textBoxFax.Text;
                this.sRefFour = textBoxRefFour.Text;

                sqlcommand.Parameters.Add("@Nom", SqlDbType.VarChar, 100).Value = this.sNom;
                sqlcommand.Parameters.Add("@GSM", SqlDbType.VarChar, 15).Value = this.sGSM;
                sqlcommand.Parameters.Add("@Fax", SqlDbType.VarChar, 15).Value = this.sFax;
                sqlcommand.Parameters.Add("@Email", SqlDbType.VarChar, 320).Value = this.sEmail;
                sqlcommand.Parameters.Add("@Adr", SqlDbType.VarChar, 320).Value = this.sAdr;
                sqlcommand.Parameters.Add("@RefFour", SqlDbType.VarChar, 50).Value = this.sRefFour;

                if (dbCon.queryInsert(sqlcommand) == 1)
                {
                    Reset();
                    lbMainMSG.Text = "Fournisseur a été modifié avec succès !";
                    lbMainMSG.ForeColor = ThemeColor.PrimaryColor;
                }
                else
                {
                    lbMainMSG.Text = "Modification echouée !";
                    lbMainMSG.ForeColor = Color.Red;
                }
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
            if (this.row == null) AjoutFourn();
                else ModifierFamille();
        }
    }
}
