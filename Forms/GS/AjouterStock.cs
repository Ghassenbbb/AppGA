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
    public partial class AjouterStock : Form
    {
        string sRefArt, sRefFour, sQntTot, sQntRes, sGaran, sExp, sID, sTVA, sPUA, sPUV;
        public AjouterStock(string sID)
        {
            this.sID = sID;
            if (sID != string.Empty)
            {
                DataRow dr = dbCon.querySelect("SELECT * FROM Stock WHERE idStock = " + sID).Tables[0].Rows[0];
                this.sRefArt = dr["article"].ToString();
                this.sRefFour = dr["frn"].ToString();
                this.sTVA = dr["tva"].ToString();
                this.sExp = dr["dateExp"].ToString();
                this.sGaran = dr["garantMois"].ToString();
                this.sQntTot = dr["qnt"].ToString();
                this.sPUA = dr["puAchat"].ToString();
                this.sPUV = dr["puVente"].ToString();
                this.sQntRes = dr["qntRes"].ToString();
            }
            InitializeComponent();
        }

        private void AjouterStock_Load(object sender, EventArgs e)
        {
            loadTheme();
            LoadComboBoxArticles();
            LoadComboBoxFourn();
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

            if (sID != string.Empty)
            {
                lbTitle.Text = "| Modifier un Stock";
                btnConfirm.Text = "Appliquer";
            }
        }


        private void Reset()
        {
            // PanelBar Theme Apply
            PanelBarArticle.BackColor = ThemeColor.SecondaryColor;
            PanelBarFourn.BackColor = ThemeColor.SecondaryColor;
            PanelBarQntTot.BackColor = ThemeColor.SecondaryColor;
            PanelBarQntRes.BackColor = ThemeColor.SecondaryColor;
            PanelBarPUA.BackColor = ThemeColor.SecondaryColor;
            PanelBarPUV.BackColor = ThemeColor.SecondaryColor;
            PanelBarExp.BackColor = ThemeColor.SecondaryColor;
            PanelBarTVA.BackColor = ThemeColor.SecondaryColor;
            PanelBarGaran.BackColor = ThemeColor.SecondaryColor;

            // Panel  Background Theme Apply
            PaneltexBoxBgArticle.BackColor = ThemeColor.DarkColor;
            PaneltexBoxBgFourn.BackColor = ThemeColor.DarkColor;
            PaneltexBoxBgQntTot.BackColor = ThemeColor.DarkColor;
            PaneltexBoxBgQntRes.BackColor = ThemeColor.DarkColor;
            PaneltexBoxBgPUA.BackColor = ThemeColor.DarkColor;
            PaneltexBoxBgPUV.BackColor = ThemeColor.DarkColor;
            PaneltexBoxBgTVA.BackColor = ThemeColor.DarkColor;
            PaneltexBoxBgGaran.BackColor = ThemeColor.DarkColor;
            PaneltexBoxBgExp.BackColor = ThemeColor.DarkColor;

            // PanelMBars
            PanelMBarArt.BackColor = ThemeColor.DarkColor;
            PanelBarFourn.BackColor = ThemeColor.DarkColor;

            // Reset Control msg
            lbMainMSG.Text = string.Empty;
            lbControlArticle.Text = string.Empty;
            lbControlFourn.Text = string.Empty;
            lbControlQntTot.Text = string.Empty;
            lbControlQntTot.Text = string.Empty;
            lbControlPUA.Text = string.Empty;
            lbControlPUV.Text = string.Empty;
            lbControlGaran.Text = string.Empty;
            lbControlTVA.Text = string.Empty;
            lbControlExp.Text = string.Empty;

            if (this.sID == string.Empty)
            {

                // Reset TextBoxes
                textBoxRefArt.Text = string.Empty;
                textBoxRefFourn.Text = string.Empty;
                textBoxQntTot.Text = string.Empty;
                textBoxQntRes.Text = string.Empty;
                textBoxPUA.Text = string.Empty;
                textBoxPUV.Text = string.Empty;
                textBoxGaran.Text = string.Empty;
                textBoxTVA.Text = string.Empty;

                //Reset ComboBox
                comboBoxArticle.SelectedIndex = -1;
                comboBoxFourn.SelectedIndex = -1;

                //Reset Date Picket
                dateTimePickerExp.Value = DateTime.Now;
                dateTimePickerExp.Checked = false;

            }
            else
            {
                // Reset TextBoxes
                textBoxRefArt.Text = this.sRefArt;
                textBoxRefFourn.Text = this.sRefFour;
                textBoxQntTot.Text = this.sQntTot;
                textBoxQntRes.Text = this.sQntRes;
                textBoxPUA.Text = this.sPUA;
                textBoxPUV.Text = this.sPUV;
                textBoxGaran.Text = this.sGaran;
                textBoxTVA.Text = this.sTVA;

                //Reset ComboBox
                comboBoxArticle.SelectedValue = this.sRefArt;
                comboBoxFourn.SelectedValue = this.sRefFour;

                //Reset Date Picket
                if (this.sExp != string.Empty)
                {
                    dateTimePickerExp.Checked = true;
                    dateTimePickerExp.Text = this.sExp;
                }
               
            }

        }


        private void LoadComboBoxArticles()
        {
            var ds = dbCon.querySelect("SELECT refArt, Design FROM Article;");
            comboBoxArticle.ValueMember = "refArt";
            comboBoxArticle.DisplayMember = "Design";
            comboBoxArticle.DataSource = ds.Tables[0];
        }


        private void LoadComboBoxFourn()
        {
            var ds = dbCon.querySelect("SELECT RefFour, NomF FROM Fournisseur;");
            comboBoxFourn.ValueMember = "RefFour";
            comboBoxFourn.DisplayMember = "NomF";
            comboBoxFourn.DataSource = ds.Tables[0];
        }


        private bool FormControl()
        {

            int control = 0;

            // Article Control
            if (textBoxRefArt.Text == string.Empty)
            {
                PanelBarArticle.BackColor = Color.Red;
                lbControlArticle.Text = "Vous devez remplir ce champ.";
                control++;
            }
            else if (!Regex.Match(textBoxRefArt.Text, @"^[a-zA-Z0-9]*$").Success)
            {
                PanelBarArticle.BackColor = Color.Red;
                lbControlArticle.Text = "Ce champ doit contenir que des caractères Alphanumériques.";
                control++;
            }
            else if (!dbCon.CheckExistDB("Article", "refArt", textBoxRefArt.Text))
            {
                PanelBarArticle.BackColor = Color.Red;
                lbControlArticle.Text = "Cet article n'existe pas !";
                control++;
            }

            // Fournisseur Control
            if (textBoxRefFourn.Text == string.Empty)
            {
                PanelBarFourn.BackColor = Color.Red;
                lbControlFourn.Text = "Vous devez remplir ce champ.";
                control++;
            }
            else if (!Regex.Match(textBoxRefFourn.Text, @"^[a-zA-Z0-9]*$").Success)
            {
                PanelBarFourn.BackColor = Color.Red;
                lbControlFourn.Text = "Ce champ doit contenir que des caractères Alphanumériques.";
                control++;
            }
            else if (!dbCon.CheckExistDB("Fournisseur", "RefFour", textBoxRefFourn.Text))
            {
                PanelBarFourn.BackColor = Color.Red;
                lbControlFourn.Text = "Ce fournisseur n'existe pas !";
                control++;
            }

            if (textBoxQntTot.Text == string.Empty)
            {
                PanelBarQntTot.BackColor = Color.Red;
                lbControlQntTot.Text = "Vous devez remplir ce champ.";
                control++;
            }

            if (textBoxPUA.Text == string.Empty)
            {
                PanelBarPUA.BackColor = Color.Red;
                lbControlPUA.Text = "Vous devez remplir ce champ.";
                control++;
            }

            if (textBoxPUV.Text == string.Empty)
            {
                PanelBarPUV.BackColor = Color.Red;
                lbControlPUV.Text = "Vous devez remplir ce champ.";
                control++;
            }

            if (textBoxTVA.Text == string.Empty)
            {
                PanelBarTVA.BackColor = Color.Red;
                lbControlTVA.Text = "Vous devez remplir ce champ.";
                control++;
            }

            if(this.sID == string.Empty && dateTimePickerExp.Checked)
            {
                if (dateTimePickerExp.Value < DateTime.Now)
                {
                    PanelBarExp.BackColor = Color.Red;
                    lbControlExp.Text = "Date incorrect !.";
                    control++;
                }
            }

            return control == 0;
        }

        private void AjoutStock()
        {
            if (FormControl())
            {

                string query = "INSERT INTO Stock"
                                + " ([article], [frn], [tva], [qnt], [puAchat], [puVente]";
                                    if (textBoxQntRes.Text != string.Empty) query += ", [qntRes]";
                                    if (textBoxGaran.Text != string.Empty) query += ", [garantMois]";
                                    if (dateTimePickerExp.Checked) query += ", [dateExp]";
                                query += ") Values (@RefArt, @RefFour, @TVA, @QntTot,  @PUA, @PUV";
                                    if (textBoxQntRes.Text != string.Empty) query += ", @QntRes";
                                    if (textBoxGaran.Text != string.Empty) query += ", @Garan";
                                    if (dateTimePickerExp.Checked) query += ", @Exp";
                                query += ");";

                SqlCommand sqlcommand = new SqlCommand(query, dbCon.con);

                sqlcommand.Parameters.Add("@RefArt", SqlDbType.VarChar, 50).Value = textBoxRefArt.Text;
                sqlcommand.Parameters.Add("@RefFour", SqlDbType.VarChar, 50).Value = textBoxRefFourn.Text;
                sqlcommand.Parameters.Add("@TVA", SqlDbType.Float).Value = textBoxTVA.Text;
                sqlcommand.Parameters.Add(new SqlParameter("@QntTot", SqlDbType.Decimal) { Precision = 18, Scale = 8 }).Value = textBoxQntTot.Text;
                sqlcommand.Parameters.Add(new SqlParameter("@PUA", SqlDbType.NVarChar) { Precision = 23, Scale = 3 }).Value = textBoxPUA.Text;
                sqlcommand.Parameters.Add(new SqlParameter("@PUV", SqlDbType.NVarChar) { Precision = 23, Scale = 3 }).Value = textBoxPUV.Text;
                if (dateTimePickerExp.Checked) sqlcommand.Parameters.Add("@Exp", SqlDbType.Date).Value = dateTimePickerExp.Value.Date;
                if (textBoxGaran.Text != string.Empty) sqlcommand.Parameters.Add("@Garan", SqlDbType.Int).Value = textBoxGaran.Text;
                if (textBoxQntRes.Text != string.Empty) sqlcommand.Parameters.Add(new SqlParameter("@QntRes", SqlDbType.Decimal) { Precision = 18, Scale = 8 }).Value = textBoxQntRes.Text;



                if (dbCon.queryInsert(sqlcommand) == 1)
                {
                    Reset();
                    lbMainMSG.Text = "Stock a été ajouté avec succès !";

                    lbMainMSG.ForeColor = ThemeColor.PrimaryColor;
                }
                else
                {
                    lbMainMSG.Text = "Ajout echoué !";
                    lbMainMSG.ForeColor = Color.Red;
                }
            }
        }

        private void comboBoxFourn_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBoxFourn.SelectedIndex != -1)
            {
                if (textBoxRefFourn.Text != comboBoxFourn.SelectedValue.ToString())
                {
                    textBoxRefFourn.Text = comboBoxFourn.SelectedValue.ToString();
                }
            }
        }

        private void textBoxQntTot_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar, dotControl = '.';

            if (textBoxQntTot.Text.IndexOf('.') != -1)
                dotControl = '0';

            if (!char.IsDigit(chr) && !char.IsControl(chr) && chr != dotControl)
                e.Handled = true;
        }

        private void textBoxQntRes_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar, dotControl = '.';

            if (textBoxQntRes.Text.IndexOf('.') != -1)
                dotControl = '0';

            if (!char.IsDigit(chr) && !char.IsControl(chr) && chr != dotControl)
                e.Handled = true;
        }

        private void textBoxPUA_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar, dotControl = '.';

            if (textBoxPUA.Text.IndexOf('.') != -1)
                dotControl = '0';

            if (!char.IsDigit(chr) && !char.IsControl(chr) && chr != dotControl)
                e.Handled = true;
        }

        private void textBoxPUV_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar, dotControl = '.';

            if (textBoxPUV.Text.IndexOf('.') != -1)
                dotControl = '0';

            if (!char.IsDigit(chr) && !char.IsControl(chr) && chr != dotControl)
                e.Handled = true;
        }

        private void textBoxTVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar, dotControl = '.';

            if (textBoxTVA.Text.IndexOf('.') != -1)
                dotControl = '0';

            if (!char.IsDigit(chr) && !char.IsControl(chr) && chr != dotControl)
                e.Handled = true;
        }

        private void textBoxGaran_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar, dotControl = '.';

            if (textBoxGaran.Text.IndexOf('.') != -1)
                dotControl = '0';

            if (!char.IsDigit(chr) && !char.IsControl(chr) && chr != dotControl)
                e.Handled = true;
        }

        private void ModifierStock()
        {
            if (FormControl())
            {

                string query = "UPDATE Stock SET"
                                + " article = (@RefArt), frn = (@RefFour), tva = (@TVA), qnt = (@QntTot), puAchat = (@PUA), puVente = (@PUV)";
                if (textBoxQntRes.Text != string.Empty) query += ", qntRes = (@QntRes)";
                if (textBoxGaran.Text != string.Empty) query += ", garantMois = (@Garan)";
                if (dateTimePickerExp.Checked) query += ", dateExp = (@Exp)";
                query += " WHERE idStock = " + this.sID + ";";
                

                SqlCommand sqlcommand = new SqlCommand(query, dbCon.con);

                sqlcommand.Parameters.Add("@RefArt", SqlDbType.VarChar, 50).Value = textBoxRefArt.Text;
                sqlcommand.Parameters.Add("@RefFour", SqlDbType.VarChar, 50).Value = textBoxRefFourn.Text;
                sqlcommand.Parameters.Add("@TVA", SqlDbType.Float).Value = textBoxTVA.Text;
                sqlcommand.Parameters.Add(new SqlParameter("@QntTot", SqlDbType.Decimal) { Precision = 18, Scale = 8 }).Value = textBoxQntTot.Text;
                sqlcommand.Parameters.Add(new SqlParameter("@PUA", SqlDbType.NVarChar) { Precision = 23, Scale = 3 }).Value = textBoxPUA.Text;
                sqlcommand.Parameters.Add(new SqlParameter("@PUV", SqlDbType.NVarChar) { Precision = 23, Scale = 3 }).Value = textBoxPUV.Text;
                if (dateTimePickerExp.Checked) sqlcommand.Parameters.Add("@Exp", SqlDbType.Date).Value = dateTimePickerExp.Value.Date;
                if (textBoxGaran.Text != string.Empty) sqlcommand.Parameters.Add("@Garan", SqlDbType.Int).Value = textBoxGaran.Text;
                if (textBoxQntRes.Text != string.Empty) sqlcommand.Parameters.Add(new SqlParameter("@QntRes", SqlDbType.Decimal) { Precision = 18, Scale = 8 }).Value = textBoxQntRes.Text;



                if (dbCon.queryInsert(sqlcommand) == 1)
                {
                    this.sRefArt = textBoxRefArt.Text;
                    this.sRefFour = textBoxRefFourn.Text;
                    this.sQntTot = textBoxQntTot.Text = this.sQntTot;
                    this.sQntRes = textBoxQntRes.Text;
                    this.sPUA = textBoxPUA.Text;
                    this.sPUV = textBoxPUV.Text;
                    this.sGaran = textBoxGaran.Text;
                    this.sTVA = textBoxTVA.Text;

                    Reset();
                    lbMainMSG.Text = "Stock a été modifié avec succès !";
                    lbMainMSG.ForeColor = ThemeColor.PrimaryColor;
                }
                else
                {
                    lbMainMSG.Text = "Modifiation echoué !";
                    lbMainMSG.ForeColor = Color.Red;
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (this.sID == string.Empty) AjoutStock();
                else ModifierStock();
        }


        private void textBoxRefFourn_TextChanged_1(object sender, EventArgs e)
        {
            var txtV = textBoxRefFourn.Text;
            if (txtV == string.Empty)
            {
                if (comboBoxFourn.SelectedIndex != -1)
                    comboBoxFourn.SelectedIndex = -1;
            }
            else if (dbCon.CheckExistDB("Fournisseur", "RefFour", txtV))
            {
                comboBoxFourn.SelectedValue = txtV;
            }
            else
            {
                if (comboBoxFourn.SelectedIndex != -1) comboBoxFourn.SelectedIndex = -1;
            }

            if (textBoxRefFourn.Text != string.Empty)
            {
                lbControlFourn.Text = string.Empty;
                PanelBarFourn.BackColor = ThemeColor.SecondaryColor;
            }
        }

        private void textBoxRefArt_TextChanged(object sender, EventArgs e)
        {
            var txtV = textBoxRefArt.Text;
            if (txtV == string.Empty)
            {
                if (comboBoxArticle.SelectedIndex != -1)
                    comboBoxArticle.SelectedIndex = -1;
            }else if (dbCon.CheckExistDB("Article", "refArt", txtV))
            {
                comboBoxArticle.SelectedValue = txtV;
            }
            else
            {
                if (comboBoxArticle.SelectedIndex != -1) comboBoxArticle.SelectedIndex = -1;
            }

            if (textBoxRefArt.Text != string.Empty)
            {
                lbControlArticle.Text = string.Empty;
                PanelBarArticle.BackColor = ThemeColor.SecondaryColor;
            }
        }

        private void comboBoxArticle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxArticle.SelectedIndex != -1)
            {
                if (textBoxRefArt.Text != comboBoxArticle.SelectedValue.ToString())
                {
                    textBoxRefArt.Text = comboBoxArticle.SelectedValue.ToString();
                }
            }
        }

        private void textBoxRefFourn_TextChanged(object sender, EventArgs e)
        {
            var txtV = textBoxRefFourn.Text;
            if (txtV == string.Empty)
            {
                if (comboBoxFourn.SelectedIndex != -1)
                    comboBoxFourn.SelectedIndex = -1;
            }
            else if (dbCon.CheckExistDB("Fournisseur", "RefFour", txtV))
            {
                comboBoxFourn.SelectedValue = txtV;
            }
            else
            {
                if (comboBoxFourn.SelectedIndex != -1) comboBoxFourn.SelectedIndex = -1;
            }

            if (textBoxRefFourn.Text != string.Empty)
            {
                lbControlFourn.Text = string.Empty;
                PanelBarFourn.BackColor = ThemeColor.SecondaryColor;
            }
        }

        private void comboBoxFourn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFourn.SelectedIndex != -1)
            {
                if (textBoxRefFourn.Text != comboBoxFourn.SelectedValue.ToString())
                {
                    textBoxRefFourn.Text = comboBoxFourn.SelectedValue.ToString();
                }
            }
        }

        private void btnReinitialiser_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void bnRetour_Click(object sender, EventArgs e)
        {
            if (AppGA.activeForm2Exit != null)
                AppGA.activeForm2Exit.PerformClick();
        }
    }
}
