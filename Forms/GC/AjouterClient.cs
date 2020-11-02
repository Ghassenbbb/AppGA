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

namespace AppGA.Forms.GC
{
    public partial class AjouterClient : Form
    {
        private string sidCl, sNom, sGSM, sEmail, sAdr;
        public bool temp;

        private DataGridViewRow row;
        public AjouterClient(DataGridViewRow row)
        {
            this.temp = false;
            this.row = row;
            if (row != null)
            {
                this.sidCl = row.Cells[0].Value.ToString();
                this.sNom = row.Cells[1].Value.ToString();
                this.sGSM = row.Cells[2].Value.ToString();
                this.sEmail = row.Cells[3].Value.ToString();
                this.sAdr = row.Cells[4].Value.ToString();
            }
            InitializeComponent();
        }

        private void AjouterClient_Load(object sender, EventArgs e)
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
                lbTitle.Text = "| Modifier données Client";
                btnConfirm.Text = "Appliquer";
            }
        }


        private void Reset()
        {
            // PanelBar Theme Apply
            PanelBarNom.BackColor = ThemeColor.SecondaryColor;
            PanelBarGSM.BackColor = ThemeColor.SecondaryColor;
            PanelBarEmail.BackColor = ThemeColor.SecondaryColor;
            PanelBarAdr.BackColor = ThemeColor.SecondaryColor;

            // Panel  Background Theme Apply
            PaneltexBoxBgNom.BackColor = ThemeColor.DarkColor;
            PaneltexBoxBgGSM.BackColor = ThemeColor.DarkColor;
            PaneltexBoxBgEmail.BackColor = ThemeColor.DarkColor;
            PaneltexBoxBgAdr.BackColor = ThemeColor.DarkColor;


            // Reset Control msg
            lbMainMSG.Text = string.Empty;
            lbControlNom.Text = string.Empty;
            lbControlGSM.Text = string.Empty;
            lbControlAdr.Text = string.Empty;
            lbControlEmail.Text = string.Empty;

            if (row == null)
            {

                // Reset TextBoxes
                textBoxNom.Text = string.Empty;
                textBoxGSM.Text = string.Empty;
                textBoxEmail.Text = string.Empty;
                textBoxAdr.Text = string.Empty;


            }
            else
            {
                textBoxNom.Text = this.sNom;
                textBoxGSM.Text = this.sGSM;
                textBoxEmail.Text = this.sEmail;
                textBoxAdr.Text = this.sAdr;
            }

        }


        private bool FormControl()
        {
            int control = 0;

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

        private void AjoutClient()
        {
            if (FormControl())
            {
                string query;

                query = "INSERT INTO Client ([NomC], [gsmC], [emailC], [adrC]) VALUES (@Nom, @GSM, @Email, @Adr);";
                SqlCommand sqlcommand = new SqlCommand(query, dbCon.con);

                sqlcommand.Parameters.Add("@Nom", SqlDbType.VarChar, 100).Value = textBoxNom.Text;
                sqlcommand.Parameters.Add("@GSM", SqlDbType.VarChar, 15).Value = textBoxGSM.Text;
                sqlcommand.Parameters.Add("@Email", SqlDbType.VarChar, 320).Value = textBoxEmail.Text;
                sqlcommand.Parameters.Add("@Adr", SqlDbType.VarChar, 320).Value = textBoxAdr.Text;

                if (dbCon.queryInsert(sqlcommand) == 1)
                {
                    Reset();
                    lbMainMSG.Text = "Client a été ajouté avec succès !";

                    lbMainMSG.ForeColor = ThemeColor.PrimaryColor;

                    if (this.temp) this.Close();
                }
                else
                {
                    lbMainMSG.Text = "Ajout echoué !";
                    lbMainMSG.ForeColor = Color.Red;
                }
            }
        }

        private void ModifierClient()
        {
            if (FormControl()) {
                string query = "UPDATE Client SET NomC = (@Nom), emailC = (@Email), gsmC = (@GSM), adrC = (@Adr) WHERE idCl = (@idCl)";
                SqlCommand sqlcommand = new SqlCommand(query, dbCon.con);

                this.sNom = textBoxNom.Text;
                this.sGSM = textBoxGSM.Text;
                this.sEmail = textBoxEmail.Text;
                this.sAdr = textBoxAdr.Text;

                sqlcommand.Parameters.Add("@Nom", SqlDbType.VarChar, 100).Value = this.sNom;
                sqlcommand.Parameters.Add("@GSM", SqlDbType.VarChar, 15).Value = this.sGSM;
                sqlcommand.Parameters.Add("@Email", SqlDbType.VarChar, 320).Value = this.sEmail;
                sqlcommand.Parameters.Add("@Adr", SqlDbType.VarChar, 320).Value = this.sAdr;
                sqlcommand.Parameters.Add("@idCl", SqlDbType.VarChar, 50).Value = this.sidCl;

                if (dbCon.queryInsert(sqlcommand) == 1)
                {
                    Reset();
                    lbMainMSG.Text = "Client a été modifié avec succès !";
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
            if (this.temp) this.Close();
            else
            {
                if (AppGA.activeForm2Exit != null)
                    AppGA.activeForm2Exit.PerformClick();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (this.row == null) AjoutClient();
            else ModifierClient();
        }

        private void btnReinitialiser_Click(object sender, EventArgs e)
        {
            Reset();
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

        private void textBoxAdr_Enter(object sender, EventArgs e)
        {
            PaneltexBoxBgAdr.BackColor = ThemeColor.PrimaryColor;
        }

        private void textBoxAdr_Leave(object sender, EventArgs e)
        {
            PaneltexBoxBgAdr.BackColor = ThemeColor.DarkColor;
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

        private void textBoxAdr_TextChanged(object sender, EventArgs e)
        {
            if (textBoxAdr.Text != string.Empty)
            {
                lbControlAdr.Text = string.Empty;
                PanelBarAdr.BackColor = ThemeColor.SecondaryColor;
            }
        }


    }
}
