using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace AppGA.Forms.CMB
{
    public partial class FormSuppMsgBox : Form
    {
        private string keycol, value, design;
        int tableNum;
      
        public FormSuppMsgBox(string keycol, string value, string design, int tableNum)
        {
            this.keycol = keycol;
            this.value = value;
            this.tableNum = tableNum;
            this.design = design;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            switch (this.tableNum)
            {
                case 0:
                     SuppFamille();
                     break;
                case 1:
                    SuppArticle();
                    break;
                case 2:
                    SuppStock();
                    break;
                case 3:
                    SuppFourn();
                    break;
                case 4:
                    SuppClient();
                    break;
                case 5:
                    SuppComm();
                    break;
                default:
                    break;
            }
        }


        private void FormSuppMsgBox_Load(object sender, EventArgs e)
        {
            PanelTopBar.BackColor = ThemeColor.PrimaryColor;
            btnCancel.BackColor = ThemeColor.SecondaryColor;
            btnConfirm.BackColor = ThemeColor.SecondaryColor;
            btnCancel.IconColor = ThemeColor.PrimaryColor;
            btnConfirm.IconColor = ThemeColor.PrimaryColor;
            

            switch (this.tableNum)
            {

                /*
                 * case 0 : Suppression de Famille
                 * case 1 : Suppression d'Article
                 * case 2 : Suppression de Stock
                 * case 3 : Supression de Fournisseur
                 */
                case 0 :
                    lbtitle.Text = "Suppression d'une famille d'article";
                    textBoxMsg.Text = " Êtes-vous sûr(e) de vouloir supprimer \"" + this.design + "\", Cela serait supprimer définitivement de la base des données.";
                    textBoxMsg.Select(0, 0);
                    break;
                case 1 :
                    lbtitle.Text = "Suppression d'un Article";
                    textBoxMsg.Text = " Êtes-vous sûr(e) de vouloir supprimer \"" + this.design + "\", Cela serait supprimer définitivement de la base des données.";
                    textBoxMsg.Select(0, 0);
                    break;
                case 2 :
                    lbtitle.Text = "Suppression de Stock";
                    textBoxMsg.Text = " Êtes-vous sûr(e) de vouloir supprimer Stock de \"" + this.design + "\" (ID = " + this.value+"), Cela serait supprimer définitivement de la base des données.";
                    textBoxMsg.Select(0, 0);
                    break;
                case 3:
                    lbtitle.Text = "Suppression de Fournisseur";
                    textBoxMsg.Text = " Êtes-vous sûr(e) de vouloir supprimer le fournisseur \"" + this.design + "\", Cela serait supprimer définitivement de la base des données.";
                    textBoxMsg.Select(0, 0);
                    break;
                case 4:
                    lbtitle.Text = "Suppression de Client";
                    textBoxMsg.Text = " Êtes-vous sûr(e) de vouloir supprimer ce client : \"" + this.design + "\", Cela serait supprimer définitivement de la base des données.";
                    textBoxMsg.Select(0, 0);
                    break;
                case 5:
                    lbtitle.Text = "Suppression de Commande";
                    textBoxMsg.Text = " Êtes-vous sûr(e) de vouloir supprimer cette commandes (ID : \"" + this.value + "\"), Cela serait supprimer définitivement de la base des données.";
                    textBoxMsg.Select(0, 0);
                    break;
                default :
                    break;
            }
        }


        private void SuppFamille()
        {
           if (dbCon.CheckExistDB("Article", "CodeFamille", this.value))
            {
                lbtitle.Text = "Suppression impossible";
                textBoxMsg.Text = " Impossible de supprimer \"" + this.design + "\", car il existe un ou plusieurs articles liés a cette famille.";
                textBoxMsg.SelectionLength = 0;
                textBoxMsg.Select(0, 0);
                btnConfirm.Visible = false;
                btnCancel.Text = "OK";
            }
            else
            {
                dbCon.deleteRowDB("FamilleArt", this.keycol, this.value);
                Forms.GA.FormFamilles.Actualiser.PerformClick();
                this.Close();
            }
        }

        private void SuppArticle()
        {
            if (dbCon.CheckExistDB("Stock", "article", this.value))
            {
                lbtitle.Text = "Suppression impposible";
                textBoxMsg.Text = " Impossible de supprimer \"" + this.design + "\", car il existe un ou plusieurs stock liés a cet Article.";
                textBoxMsg.SelectionLength = 0;
                textBoxMsg.Select(0, 0);
                btnConfirm.Visible = false;
                btnCancel.Text = "OK";
            }
            else
            {
                dbCon.deleteRowDB("Article", this.keycol, this.value);
                Forms.GA.FormArticles.Actualiser.PerformClick();
                this.Close();
            }
        }


        private void SuppStock()
        {
            if (dbCon.CheckExistDB("Vente", "idStock", this.value))
            {
                lbtitle.Text = "Suppression impposible";
                textBoxMsg.Text = " Impossible de supprimer \" Stock de \"" + this.design + "\" (ID = " + this.value + "), car il existe un ou plusieurs Commandes liés a cet Stock.";
                textBoxMsg.SelectionLength = 0;
                textBoxMsg.Select(0, 0);
                btnConfirm.Visible = false;
                btnCancel.Text = "OK";
            }
            else
            {
                dbCon.deleteRowDB("Stock", this.keycol, this.value);
                Forms.GS.FormStocks.Actualiser.PerformClick();
                this.Close();
            }
        }

        private void SuppFourn()
        {
            if (dbCon.CheckExistDB("Stock", "frn", this.value))
            {
                lbtitle.Text = "Suppression impposible";
                textBoxMsg.Text = " Impossible de supprimer Fournisseur \"" + this.design + "\", car il existe un ou plusieurs Stocks liés a ce fournisseur.";
                textBoxMsg.SelectionLength = 0;
                textBoxMsg.Select(0, 0);
                btnConfirm.Visible = false;
                btnCancel.Text = "OK";
            }
            else
            {
                dbCon.deleteRowDB("Fournisseur", this.keycol, this.value);
                Forms.GS.FormFournisseurs.Actualiser.PerformClick();
                this.Close();
            }
        }

        private void SuppClient()
        {
            if (dbCon.CheckExistDB("Commande", "Client", this.value))
            {
                lbtitle.Text = "Suppression impposible";
                textBoxMsg.Text = " Impossible de supprimer ce Client : \"" + this.design + "\", car il existe un ou plusieurs commandes liés a ce client.";
                textBoxMsg.SelectionLength = 0;
                textBoxMsg.Select(0, 0);
                btnConfirm.Visible = false;
                btnCancel.Text = "OK";
            }
            else
            {
                dbCon.deleteRowDB("Client", this.keycol, this.value);
                Forms.GC.FormClients.Actualiser.PerformClick();
                this.Close();
            }
        }

        private void SuppComm()
        {
            string query = "DELETE FROM Vente WHERE idComm = @idComm;";
            System.Data.SqlClient.SqlCommand sqlcommand = new System.Data.SqlClient.SqlCommand(query, dbCon.con);
            sqlcommand.Parameters.Add("@idComm", SqlDbType.BigInt).Value = this.value;
            dbCon.queryInsert(sqlcommand);

            dbCon.deleteRowDB("Commande", "idComm", this.value);

            Forms.GC.FormCommandes.Actualiser.PerformClick();
            this.Close();
        }



        private void FormSuppMsgBox_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lbtitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // DRAG WINDOW
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

    }
}
