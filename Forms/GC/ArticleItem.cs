using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace AppGA.Forms.GC
{
    public partial class ArticleItem : Form
    {
        public string idSt, Qnt, QntInitial, Design, idVen;
 
        private void M_Click(object sender, EventArgs e)
        {
            var CInstance = (AjouterCommande)AppGA.subForm;
            CInstance.UpdateInfos(this, false);
            if (this.idVen == null) {
                this.Close();
            }else
            {
                AjouterCommande.SelectedArticles.Remove(this);
                AjouterCommande.DeletedArticles.Add(this);
                this.Hide();
            }
        }

        public ArticleItem(string idS, string Qnt, string Design, string idVen)
        {
            this.idSt = idS;
            this.Qnt = Qnt;
            this.QntInitial = Qnt;
            this.Design = Design;
            this.idVen = idVen;
            InitializeComponent();
        }

        private void PanelBotBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ArticleItem_Load(object sender, EventArgs e)
        {
            lbDesign.Text = this.Design;
            lbDesign.ForeColor = Color.White;
            lbQnt.Text = "x"+this.Qnt;
            lbidStock.Text = "Stock ID #"+this.idSt;
            Panelitem.BackColor = ThemeColor.DarkColor;
            PanelBotBar.BackColor = ThemeColor.SecondaryColor;

            btnCancelItem.BackColor = ThemeColor.SecondaryColor;
            btnCancelItem.ForeColor = Color.Black;
            btnCancelItem.FlatAppearance.BorderColor = ThemeColor.DarkColor;
        }


        public void updateDBArticle(string idComm)
        {
                string query;
                SqlCommand sqlcommand;

                if (this.idVen == null)
                {
                    // Ajout Nouveaux Ventes
                    query = "INSERT INTO Vente(idComm, idStock, qnt) values(@idComm, @idSt, @Qnt);";
                    sqlcommand = new SqlCommand(query, dbCon.con);
                    sqlcommand.Parameters.Add("@Qnt", SqlDbType.NVarChar).Value = this.Qnt;
                    sqlcommand.Parameters.Add("@idComm", SqlDbType.BigInt).Value = idComm;
                    sqlcommand.Parameters.Add("@idSt", SqlDbType.BigInt).Value = this.idSt;
                    if (dbCon.queryInsert(sqlcommand) > 0)
                    {
                        string query2 = "UPDATE Stock SET qntVendu = qntVendu + @Qnt WHERE idStock = @idSt;";
                        SqlCommand sqlcommand2 = new SqlCommand(query2, dbCon.con);
                        sqlcommand2.Parameters.Add("@Qnt", SqlDbType.NVarChar).Value = this.Qnt;
                        sqlcommand2.Parameters.Add("@idSt", SqlDbType.BigInt).Value = this.idSt;
                        dbCon.queryInsert(sqlcommand2);
                    };
                }
                else
                {
                    // Modifier Ventes 
                    query = "UPDATE Vente SET qnt = @Qnt WHERE idVente = @idVen;";
                    sqlcommand = new SqlCommand(query, dbCon.con);
                    sqlcommand.Parameters.Add("@Qnt", SqlDbType.NVarChar).Value = this.Qnt;
                    sqlcommand.Parameters.Add("@idVen", SqlDbType.BigInt).Value = this.idVen;
                    if (dbCon.queryInsert(sqlcommand) > 0)
                    {
                        string query2 = "UPDATE Stock SET qntVendu = qntVendu + @QntDiff WHERE idStock = @idSt;";
                        SqlCommand sqlcommand2 = new SqlCommand(query2, dbCon.con);
                        sqlcommand2.Parameters.Add("@QntDiff", SqlDbType.NVarChar).Value = Convert.ToDouble(this.Qnt)- Convert.ToDouble(this.QntInitial);
                        sqlcommand2.Parameters.Add("@idSt", SqlDbType.BigInt).Value = this.idSt;
                        dbCon.queryInsert(sqlcommand2);
                    }
                 }
        }


        public void deleteDBArticle()
        {
            if (this.idVen != null)
            {
                string query;
                SqlCommand sqlcommand;
                query = "DELETE FROM Vente WHERE idVente = @idVen;";
                sqlcommand = new SqlCommand(query, dbCon.con);
                sqlcommand.Parameters.Add("@idVen", SqlDbType.BigInt).Value = this.idVen;
                if (dbCon.queryInsert(sqlcommand) > 0)
                {
                    string query2 = "UPDATE Stock SET qntVendu = qntVendu - @Qnt WHERE idStock = @idSt;";
                    SqlCommand sqlcommand2 = new SqlCommand(query2, dbCon.con);
                    sqlcommand2.Parameters.Add("@Qnt", SqlDbType.NVarChar).Value = Convert.ToDouble(this.Qnt);
                    sqlcommand2.Parameters.Add("@idSt", SqlDbType.BigInt).Value = this.idSt;
                    dbCon.queryInsert(sqlcommand2);
                }
            }
        }

        public double GetTotPrice()
        {
            double Ptot = 0;
            string query = "SELECT puVente FROM Stock WHERE idStock = "+this.idSt+";";
            var ds = dbCon.querySelect(query);
            Ptot = Convert.ToDouble(ds.Tables[0].Rows[0]["puVente"].ToString()) * Convert.ToDouble(this.Qnt);
            return Ptot;
        }

        public void UpdateQnt(string AddQnt)
        {
            this.Qnt = (Convert.ToDouble(this.Qnt) + Convert.ToDouble(AddQnt)).ToString();
            this.lbQnt.Text = "x"+this.Qnt;
        }

    }
}
