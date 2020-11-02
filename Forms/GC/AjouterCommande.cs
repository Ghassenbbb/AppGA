using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace AppGA.Forms.GC
{
    public partial class AjouterCommande : Form
    {

        private string sID, sClient;
        private float UniArts;
        private double PrixTot;

        static public List<ArticleItem> SelectedArticles = new List<ArticleItem>();
        static public List<ArticleItem> DeletedArticles = new List<ArticleItem>();

        public AjouterCommande(string sID)
        {
            UniArts = 0;
            PrixTot = 0;
            this.sID = sID;
            if(sID != null) this.sClient = SeekClient(sID);
            InitializeComponent();
        }

        private string SeekClient(string sID)
        {
            string query = "SELECT Client FROM Commande WHERE idComm = @sID;";
            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, dbCon.con);
            command.Parameters.Add("@sID", SqlDbType.BigInt).Value = this.sID;
            var ds = dbCon.querySelect2(command);

            return ds.Tables[0].Rows[0]["Client"].ToString();
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
            PanelInfoTop.BackColor = ThemeColor.PrimaryColor;
            PanelInfoBottom.BackColor = ThemeColor.SecondaryColor;

            if (sID != null)
            {
                lbTitle.Text = "| Modifier une Commande";
                btnConfirm.Text = "Appliquer";
            }
        }

        private void Reset()
        {
            // PanelBar Theme Apply
            PanelBarArticle.BackColor = ThemeColor.SecondaryColor;
            PanelBarClient.BackColor = ThemeColor.SecondaryColor;
            PanelBarQnt.BackColor = ThemeColor.SecondaryColor;

            // Panel  Background Theme Apply
            PaneltexBoxBgArticle.BackColor = ThemeColor.DarkColor;
            PaneltexBoxBgClient.BackColor = ThemeColor.DarkColor;
            PaneltexBoxBgQnt.BackColor = ThemeColor.DarkColor;
            PanelArtList.BackColor = ThemeColor.PrimaryColor;

            // PanelMBars
            PanelMBarArt.BackColor = ThemeColor.DarkColor;
            PanelMBarClient.BackColor = ThemeColor.DarkColor;

            // Reset Control msg
            lbMainMSG.Text = string.Empty;
            lbControlArticle.Text = string.Empty;
            lbControlClient.Text = string.Empty;
            lbControlQnt.Text = string.Empty;

            textBoxRefArt.Text = string.Empty;
            comboBoxArticle.SelectedIndex = -1;

            // Reset TextBoxes
            textBoxClient.Text = string.Empty;
            textBoxQnt.Text = string.Empty;


            //Reset ComboBox
            comboBoxClient.SelectedIndex = -1;

            //Reset Liste des Articles
            foreach (ArticleItem sItem in SelectedArticles)
            {
                sItem.Close();
            }
            SelectedArticles.Clear();

            foreach (ArticleItem sItem in DeletedArticles)
            {
                sItem.Close();
            }
            DeletedArticles.Clear();

            lbPrixTot.Text = "0";
            lbNbrUniArt.Text = "0";
            UniArts = 0;
            PrixTot = 0;

            if (this.sID != null)
            {
                // Reset TextBoxes
                textBoxClient.Text = this.sClient;
                Fill_SelectedArticles(this.sID);
            }

           
        }

        private void LoadComboBoxArticles()
        {
            var ds = dbCon.querySelect("SELECT refArt, Design FROM Article;");
            comboBoxArticle.ValueMember = "refArt";
            comboBoxArticle.DisplayMember = "Design";
            comboBoxArticle.DataSource = ds.Tables[0];
        }


        private void LoadComboBoxClient()
        {
            var ds = dbCon.querySelect("SELECT idCl, NomC FROM Client;");
            comboBoxClient.ValueMember = "idCl";
            comboBoxClient.DisplayMember = "NomC";
            comboBoxClient.DataSource = ds.Tables[0];
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBoxRefArt_TextChanged(object sender, EventArgs e)
        {
            lbMainMSG.Text = string.Empty;
            var txtV = textBoxRefArt.Text;
            if (txtV == string.Empty)
            {
                if (comboBoxArticle.SelectedIndex != -1)
                    comboBoxArticle.SelectedIndex = -1;
            }
            else if (dbCon.CheckExistDB("Article", "refArt", txtV))
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
            lbMainMSG.Text = string.Empty;
            if (comboBoxArticle.SelectedIndex != -1)
            {
                if (textBoxRefArt.Text != comboBoxArticle.SelectedValue.ToString())
                {
                    textBoxRefArt.Text = comboBoxArticle.SelectedValue.ToString();
                }
            }
        }

        private void textBoxClient_TextChanged(object sender, EventArgs e)
        {
            var txtV = textBoxClient.Text;
            if (txtV == string.Empty)
            {
                if (comboBoxClient.SelectedIndex != -1)
                    comboBoxClient.SelectedIndex = -1;
            }
            else if (dbCon.CheckExistDB("Client", "idCl", txtV))
            {
                comboBoxClient.SelectedValue = txtV;
            }
            else
            {
                if (comboBoxClient.SelectedIndex != -1) comboBoxClient.SelectedIndex = -1;
            }

            if (textBoxClient.Text != string.Empty)
            {
                lbControlClient.Text = string.Empty;
                PanelBarClient.BackColor = ThemeColor.SecondaryColor;
            }
        }

        private void comboBoxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxClient.SelectedIndex != -1)
            {
                if (textBoxClient.Text != comboBoxClient.SelectedValue.ToString())
                {
                    textBoxClient.Text = comboBoxClient.SelectedValue.ToString();
                    lbClientSelec.Text = comboBoxClient.Text;
                }
            }
            else
            {
                lbClientSelec.Text = "";
            }
        }

        private void bnRetour_Click(object sender, EventArgs e)
        {
            if (AppGA.activeForm2Exit != null)
                AppGA.activeForm2Exit.PerformClick();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Forms.GC.AjouterClient T = new Forms.GC.AjouterClient(null);
            T.temp = true;
            AppGA.tempForm = T;
            AppGA.tempForm.ShowDialog();
            LoadComboBoxClient();
        }


        private void AjouterCommande_Load(object sender, EventArgs e)
        {
            loadTheme();
            LoadComboBoxArticles();
            LoadComboBoxClient();
            Reset();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (CommControl() == 0) {
                if (this.sID == null)
                {
                    AjoutCommande();
                }else
                {
                    UpdateCommande();
                }
            }
        }

        private void AjoutCommande()
        {
            string query = "INSERT INTO Commande ([Client], [prixtotal]) VALUES (@Client, @Prixtot); ";
            SqlCommand sqlcommand = new SqlCommand(query, dbCon.con);
            sqlcommand.Parameters.Add("@Client", SqlDbType.BigInt).Value = textBoxClient.Text;
            sqlcommand.Parameters.Add("@Prixtot", SqlDbType.NVarChar).Value = this.PrixTot;

            if (dbCon.queryInsert(sqlcommand) == 1)
            {
                query = "SELECT IDENT_CURRENT('Commande') AS idComm;";
                System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, dbCon.con);
                var ds = dbCon.querySelect2(command);
                string idCommCurrent = ds.Tables[0].Rows[0]["idComm"].ToString();

                foreach (ArticleItem Item in SelectedArticles)
                {
                    Item.updateDBArticle(idCommCurrent);

                }

                Reset();
                lbMainMSG.Text = "Commande ajoutée avec succès";

            }
            else
            {
                lbMainMSG.Text = "Ajout echoué !";
                lbMainMSG.ForeColor = Color.Red;
            }
        }

        private void UpdateCommande()
        {
            string query = "UPDATE Commande SET Client = @Client,  prixtotal = @Prixtot WHERE idComm = @sID;";
            SqlCommand sqlcommand = new SqlCommand(query, dbCon.con);
            sqlcommand.Parameters.Add("@Client", SqlDbType.BigInt).Value = textBoxClient.Text;
            sqlcommand.Parameters.Add("@Prixtot", SqlDbType.NVarChar).Value = this.PrixTot;
            sqlcommand.Parameters.Add("@sID", SqlDbType.BigInt).Value = this.sID;

            if (dbCon.queryInsert(sqlcommand) == 1)
            {
                foreach (ArticleItem Item in DeletedArticles)
                {
                    Item.deleteDBArticle();

                }

                foreach (ArticleItem Item in SelectedArticles)
                {
                    Item.updateDBArticle(this.sID);

                }

                Reset();
                lbMainMSG.Text = "Commande modifié avec succès";

            }
            else
            {
                lbMainMSG.Text = "Modification echoué !";
                lbMainMSG.ForeColor = Color.Red;
            }
        }

        private string ChercherStock(string StockQnt)
        {

            string query = "SELECT TOP 1 idStock FROM Stock WHERE article = @txtboxValue AND (qnt - qntVendu - qntRes) > @Qnt";
            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, dbCon.con);
            command.Parameters.AddWithValue("@txtboxValue", textBoxRefArt.Text);
            command.Parameters.Add("@Qnt", SqlDbType.NVarChar).Value = StockQnt;

            try
            {

                var ds = dbCon.querySelect2(command);
                return ds.Tables[0].Rows[0]["idStock"].ToString();
            }
            catch
            {
                return "";
            }
        }


        private string QntDispoTot(string Art)
        {
            string query = "SELECT SUM(qnt - qntVendu - qntRes) as SumTot FROM Stock WHERE article = @Art;";
            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, dbCon.con);
            command.Parameters.AddWithValue("@Art", Art);
            try
            {

                var ds = dbCon.querySelect2(command);
                string W = ds.Tables[0].Rows[0]["SumTot"].ToString();

                if (W != null && W != string.Empty)
                {
                    return ds.Tables[0].Rows[0]["SumTot"].ToString();
                }else return "0";
            }
            catch
            {
                return "0";
            }

        }

        private string QntDispoStock(string IDS)
        {
            string query = "SELECT (qnt - qntVendu - qntRes) as QntDispo FROM Stock WHERE idStock = @idSt;";
            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, dbCon.con);
            command.Parameters.Add("@idSt", SqlDbType.BigInt).Value = IDS;
            try
            {
                var ds = dbCon.querySelect2(command);
                return ds.Tables[0].Rows[0]["QntDispo"].ToString();
            }
            catch
            {
                return "0";
            }
        }

        public void UpdateInfos(ArticleItem Item, bool B)
        {
            if (B)
            {
                this.UniArts += 1;
                this.PrixTot += Item.GetTotPrice();
            }
            else
            {
                this.UniArts -= 1;
                this.PrixTot -= Item.GetTotPrice();
            }

            this.lbPrixTot.Text = this.PrixTot.ToString();
            this.lbNbrUniArt.Text = this.UniArts.ToString();
        }

        public ArticleItem CheckArtExist(string IDS)
        {
            foreach (ArticleItem item in SelectedArticles)
            {
                if (item.idSt == IDS) return item;
            }
            return null;
        }

        public bool CheckArtExistDesign(string DES)
        {
            foreach (ArticleItem item in SelectedArticles)
            {
                if (item.Design == DES) return true;
            }
            return false;
        }

        public int CommControl()
        {
            int CtlCount = 0; 
            if (textBoxClient.Text == string.Empty)
            {
                lbControlClient.Text = "Vous devez choisir un Client !";
                PanelBarClient.BackColor = Color.Red;
                CtlCount++;
            }

            if (!SelectedArticles.Any())
            {
                lbMainMSG.Text = "Vous devez ajouter au moins un article !";
                lbMainMSG.ForeColor = Color.Red;
                CtlCount++;
            }


            return CtlCount;
        }

        private void textBoxQnt_TextChanged(object sender, EventArgs e)
        {
            lbMainMSG.Text = string.Empty;
            lbControlQnt.Text = string.Empty;
            PanelBarQnt.BackColor = ThemeColor.SecondaryColor;
        }

        private void btnAjArt_Click(object sender, EventArgs e)
        {
                if (textBoxRefArt.Text == string.Empty)
                {
                    lbControlArticle.Text = "Vous devez remplir ce champ !";
                    PanelBarArticle.BackColor = Color.Red;
                }
                else if (textBoxQnt.Text == string.Empty)
                {
                    lbControlQnt.Text = "Vous devez remplir ce champ !";
                    PanelBarQnt.BackColor = Color.Red;
                }
                else
                {
                    double QntBes = Convert.ToDouble(this.textBoxQnt.Text);
                    if (Convert.ToDouble(QntDispoTot(this.textBoxRefArt.Text)) >= QntBes)
                    {
                        string query = "SELECT idStock, (qnt - qntVendu - qntRes) AS QntDispo FROM Stock WHERE article = @Art AND  (qnt - qntVendu - qntRes) > 0 AND  (dateExp is NULL OR dateExp > GETDATE()) ORDER BY ajDate ASC;";
                        System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, dbCon.con);
                        command.Parameters.AddWithValue("@Art", this.textBoxRefArt.Text);
                        var ds = dbCon.querySelect2(command);

                            foreach (DataRow row in ds.Tables[0].Rows)
                            {
                                                     
                                var SItem = CheckArtExist(row["idStock"].ToString());
                                if (SItem != null)
                                {
                                    string NvQnt = (Convert.ToDouble(row["QntDispo"]) - Convert.ToDouble(SItem.Qnt)).ToString();
                                    if (Convert.ToDouble(NvQnt) > 0) {
                                        if (QntBes < Convert.ToDouble(NvQnt)) NvQnt = QntBes.ToString();

                                        UpdateInfos(SItem, false);
                                        SItem.UpdateQnt(NvQnt);
                                        UpdateInfos(SItem, true);

                                        QntBes -= Convert.ToDouble(NvQnt);
                                    }
                                    
                                }
                                else
                                {
                                    string NvQnt = (Convert.ToDouble(row["QntDispo"])).ToString();
                                    if (QntBes < Convert.ToDouble(NvQnt)) NvQnt = QntBes.ToString();
                                    if (Convert.ToDouble(NvQnt) > 0)
                                    {
                                        Forms.GC.ArticleItem item = new Forms.GC.ArticleItem(row["idStock"].ToString(), NvQnt, comboBoxArticle.Text, null);
                                        SelectedArticles.Add(item);
                                        UpdateInfos(item, true);
                                        item.TopLevel = false;
                                        item.FormBorderStyle = FormBorderStyle.None;
                                        item.Dock = DockStyle.Top;
                                        this.PanelItems.Controls.Add(item);
                                        item.BringToFront();
                                        item.Show();
                                        QntBes -= Convert.ToDouble(NvQnt);
                                    }
                                    
                                }
                                if (QntBes == 0) break;
                            }

                            if(QntBes == 0)
                            {
                                textBoxRefArt.Text = string.Empty;
                                textBoxQnt.Text = string.Empty;
                                lbMainMSG.Text = "Article Ajouté au Panier";
                            }else
                            {
                                lbMainMSG.Text = "Stock insuffisant ! Seulement quantité disponible ajouté au Panier ";
                            }
                    }else
                    {
                        lbMainMSG.Text = "Cette Quantité n'est pas disponible dans le Stock ! ";
                    }

           
                }
        }

        private void Fill_SelectedArticles(string sID)
        {
            SelectedArticles.Clear();
            string query = "SELECT idVente, idStock, qnt FROM Vente WHERE idComm = @sID;";
            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, dbCon.con);
            command.Parameters.Add("@sID", SqlDbType.BigInt).Value = this.sID;
            var ds = dbCon.querySelect2(command);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                string query2 = "SELECT Article.Design as Design FROM Stock INNER JOIN Article ON Stock.article = Article.RefArt WHERE idStock = @idStock;";
                System.Data.SqlClient.SqlCommand command2 = new System.Data.SqlClient.SqlCommand(query2, dbCon.con);
                command2.Parameters.Add("@idStock", SqlDbType.BigInt).Value = row["idStock"].ToString();
                var dn = dbCon.querySelect2(command2);

                Forms.GC.ArticleItem item = new Forms.GC.ArticleItem(row["idStock"].ToString(), row["qnt"].ToString(), dn.Tables[0].Rows[0]["Design"].ToString(), row["idVente"].ToString());
                SelectedArticles.Add(item);
                UpdateInfos(item, true);
                item.TopLevel = false;
                item.FormBorderStyle = FormBorderStyle.None;
                item.Dock = DockStyle.Top;
                this.PanelItems.Controls.Add(item);
                item.BringToFront();
                item.Show();
            }

        }

        private void textBoxQnt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar, dotControl = '.';

            if (textBoxQnt.Text.IndexOf('.') != -1)
                dotControl = '0';

            if (!char.IsDigit(chr) && !char.IsControl(chr) && chr != dotControl)
                e.Handled = true;
        }

        private void btnReinitialiser_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
