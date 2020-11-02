using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppGA.Forms.GC
{


    public partial class FormCommandes : Form
    {
        private Panel basePanel;
        public static Button Actualiser;
        private DataGridView dgCommandes;
        public FormCommandes(Panel P)
        {
            this.basePanel = P;
            InitializeComponent();
        }

        private void FormCommandes_Load(object sender, EventArgs e)
        {
            LoadTheme();
            dataGridGenerator();
            this.dgCommandes = this.dataGridViewCommandes;
            Actualiser = this.btnActualiser;
        }


        private void LoadTheme()
        {
            //Buttons Theme Apply
            foreach (Control btns in PanelCommandesHeader.Controls)
            {
                if (btns.GetType() == typeof(IconButton))
                {
                    IconButton btn = (IconButton)btns;
                    btn.BackColor = ThemeColor.SecondaryColor;
                    btn.ForeColor = Color.Black;
                    btn.FlatAppearance.BorderColor = ThemeColor.PrimaryColor;
                }
            }


            //Recherche Theme Apply
            btnRechercher.BackColor = ThemeColor.SecondaryColor;
            btnRechercher.ForeColor = Color.Black;
            btnRechercher.FlatAppearance.BorderColor = ThemeColor.PrimaryColor;




            //dataGrid Theme Apply
            dataGridViewCommandes.EnableHeadersVisualStyles = false;
            dataGridViewCommandes.ColumnHeadersDefaultCellStyle.Padding = new Padding(6, 4, 0, 4);
            dataGridViewCommandes.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
            dataGridViewCommandes.ColumnHeadersDefaultCellStyle.SelectionBackColor = ThemeColor.PrimaryColor;
            dataGridViewCommandes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewCommandes.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCommandes.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridViewCommandes.RowsDefaultCellStyle.Font = new Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCommandes.RowsDefaultCellStyle.SelectionBackColor = ThemeColor.DarkColor;
            dataGridViewCommandes.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            dataGridViewCommandes.RowsDefaultCellStyle.Padding = new Padding(6, 6, 30, 6);
            dataGridViewCommandes.ScrollBars = ScrollBars.Both;

        }

        private void dateGridViewRowsTheme()
        {
            int rowsCount = dataGridViewCommandes.RowCount;
            for (var i = 1; i < rowsCount; i += 2)
            {
                dataGridViewCommandes.Rows[i].DefaultCellStyle.BackColor = ThemeColor.SecondaryColor;
            };
        }

        private void dataGridGenerator()
        {
            string query = "SELECT"
                                + " idComm as 'ID',"
                                + " C.NomC as 'Client',"
                                + " prixtotal as 'Prix totale',"
                                + " (SELECT COUNT(*) FROM Vente WHERE Vente.idComm = Commande.idComm) as [Nombre Unique d'article],"
                                + " CASE WHEN enLiv = 0 THEN 'Non' ELSE 'Oui' END as 'Livré',"
                                + " CASE WHEN annuler = 0 THEN 'Non' ELSE 'Oui' END as 'Annulé',"
                                + " Commande.ajDate as [Date d'ajout]"
                        + " FROM Commande INNER JOIN Client AS C ON C.idCl = Commande.Client;";

            var ds = dbCon.querySelect(query);
            dataGridViewCommandes.ReadOnly = true;
            dataGridViewCommandes.DataSource = ds.Tables[0];
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            //textBoxRecherche.Text = string.Empty;
            dgCommandes.Columns.Remove("");
            dataGridGenerator();
        }

        private void dataGridViewCommandes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgCommandes != null)
            {

                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                if (dgCommandes.Columns[dgCommandes.ColumnCount - 1].HeaderText != string.Empty)
                {
                    column.HeaderText = string.Empty;
                    dgCommandes.Columns.Add(column);
                }
                dgCommandes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgCommandes.Columns[dgCommandes.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgCommandes.AutoResizeColumns();

            }
            dateGridViewRowsTheme();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            string SearchValue = textBoxRecherche.Text;
            string SelCol = "Co.idComm";
            string SelColOpt = "";

            if (cbID.Checked || cbClient.Checked || cbidClient.Checked ||  cbArticle.Checked || cbRefArt.Checked || cbidStock.Checked)
            {
                // Radio Button
                if (cbClient.Checked) SelCol = "Cl.NomC";
                if (cbidClient.Checked) SelCol = "Co.Client";
                if (cbArticle.Checked) SelCol = "Ar.Design";
                if (cbRefArt.Checked) SelCol = "St.article";
                if (cbidStock.Checked) SelCol = "idStock";

                string query = "SELECT"
                                + " Co.idComm as 'ID',"
                                + " Cl.NomC as 'Client',"
                                + " Co.prixtotal as 'Prix totale',"
                                + " (SELECT COUNT(*) FROM Vente as Ve WHERE Ve.idComm = Co.idComm) as [Nombre Unique d'article],"
                                + " CASE WHEN enLiv = 0 THEN 'Non' ELSE 'Oui' END as 'Livré',"
                                + " CASE WHEN annuler = 0 THEN 'Non' ELSE 'Oui' END as 'Annulé',"
                                + " Co.ajDate as [Date d'ajout]"
                        + " FROM Commande as Co INNER JOIN Client AS Cl ON Cl.idCl = Co.Client";

                if (cbID.Checked || cbidClient.Checked || cbClient.Checked)
                {
                    query += " WHERE " + SelCol + " LIKE @txtboxValue";
                }
                else if (cbidStock.Checked)
                {
                    query += " WHERE Co.idComm = ANY (SELECT idComm FROM Vente WHERE " + SelCol + " LIKE @txtboxValue)";

                }else if (cbArticle.Checked || cbRefArt.Checked)
                {
                    query += " WHERE Co.idComm = ANY (SELECT idComm FROM Vente WHERE idStock = ANY (SELECT idStock FROM Stock as St INNER JOIN Article AS Ar ON St.article = Ar.refArt WHERE " + SelCol + " LIKE @txtboxValue))";
                }

                if (!cbLiv.Checked || !cbNotLiv.Checked)
                {
                    if (cbLiv.Checked) query += " AND enLiv = 1";
                    if (cbNotLiv.Checked) query += " AND enLiv = 0";
                }
                if (cbCancel.Checked) query += " AND annuler = 1";

                query += ";";

                try
                {
                    System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, dbCon.con);
                    command.Parameters.AddWithValue("@txtboxValue", "%" + textBoxRecherche.Text + "%");

                    var ds = dbCon.querySelect2(command);
                    dgCommandes.Columns.Remove("");
                    dataGridViewCommandes.ReadOnly = true;
                    dataGridViewCommandes.DataSource = ds.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }


            }
            else
            {
                MessageBox.Show("Vous devez selectionner un filtre de recherche !");
            }
        }

        private void textBoxRecherche_TextChanged(object sender, EventArgs e)
        {
            btnRechercher.PerformClick();
        }

        private void cbID_CheckedChanged(object sender, EventArgs e)
        {
            btnRechercher.PerformClick();
        }

        private void cbClient_CheckedChanged(object sender, EventArgs e)
        {
            btnRechercher.PerformClick();
        }

        private void cbidClient_CheckedChanged(object sender, EventArgs e)
        {
            btnRechercher.PerformClick();
        }

        private void cbArticle_CheckedChanged(object sender, EventArgs e)
        {
            btnRechercher.PerformClick();
        }

        private void cbRefArt_CheckedChanged(object sender, EventArgs e)
        {
            btnRechercher.PerformClick();
        }

        private void cbidStock_CheckedChanged(object sender, EventArgs e)
        {
            btnRechercher.PerformClick();
        }

        private void cbNotLiv_CheckedChanged(object sender, EventArgs e)
        {
            btnRechercher.PerformClick();
        }

        private void cbLiv_CheckedChanged(object sender, EventArgs e)
        {
            btnRechercher.PerformClick();
        }

        private void cbCancel_CheckedChanged(object sender, EventArgs e)
        {
            btnRechercher.PerformClick();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (AppGA.subForm != null)
            {
                AppGA.subForm.Close();
            }
            Form childForm = new Forms.GC.AjouterCommande(null);
            AppGA.subForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.basePanel.Controls.Add(childForm);
            this.basePanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgCommandes.CurrentRow != null) { 
            Form childForm = new Forms.GC.AjouterCommande(dgCommandes.CurrentRow.Cells[0].Value.ToString());
            if (AppGA.subForm != null)
            {
                AppGA.subForm.Close();
            }
            AppGA.subForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.basePanel.Controls.Add(childForm);
            this.basePanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgCommandes.CurrentRow != null)
            {
            string sID = dgCommandes.CurrentRow.Cells[0].Value.ToString();
            AppGA.tempForm = new Forms.CMB.FormSuppMsgBox("idComm", sID, null, 5);
            AppGA.tempForm.ShowDialog();
            }
        }
    }
}
