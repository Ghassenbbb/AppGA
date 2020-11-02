using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppGA.Forms.GS
{
    public partial class FormStocks : Form
    {
        private Panel basePanel;
        public static Button Actualiser;
        private DataGridView dgStocks;
        public FormStocks(Panel P)
        {
            this.basePanel = P;
            InitializeComponent();
        }

        private void FormStocks_Load(object sender, EventArgs e)
        {
            LoadTheme();
            dataGridGenerator();
            dgStocks = this.dataGridViewStocks;
            Actualiser = this.btnActualiser;
        }

        private void LoadTheme()
        {
            //Buttons Theme Apply
            foreach (Control btns in PanelStocksHeader.Controls)
            {
                if (btns.GetType() == typeof(IconButton))
                {
                    IconButton btn = (IconButton)btns;
                    btn.BackColor = ThemeColor.SecondaryColor;
                    btn.ForeColor = Color.Black;
                    btn.FlatAppearance.BorderColor = ThemeColor.PrimaryColor;
                }
            }


            // Recherche Theme Apply
            btnRechercher.BackColor = ThemeColor.SecondaryColor;
            btnRechercher.ForeColor = Color.Black;
            btnRechercher.FlatAppearance.BorderColor = ThemeColor.PrimaryColor;




            //dataGrid Theme Apply
            dataGridViewStocks.EnableHeadersVisualStyles = false;
            dataGridViewStocks.ColumnHeadersDefaultCellStyle.Padding = new Padding(6, 4, 0, 4);
            dataGridViewStocks.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
            dataGridViewStocks.ColumnHeadersDefaultCellStyle.SelectionBackColor = ThemeColor.PrimaryColor;
            dataGridViewStocks.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewStocks.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewStocks.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridViewStocks.RowsDefaultCellStyle.Font = new Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewStocks.RowsDefaultCellStyle.SelectionBackColor = ThemeColor.DarkColor;
            dataGridViewStocks.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            dataGridViewStocks.RowsDefaultCellStyle.Padding = new Padding(6, 6, 30, 6);
            dataGridViewStocks.ScrollBars = ScrollBars.Both;

        }

        private void dateGridViewRowsTheme()
        {
            int rowsCount = dataGridViewStocks.RowCount;
            for (var i = 1; i < rowsCount; i += 2)
            {
                dataGridViewStocks.Rows[i].DefaultCellStyle.BackColor = ThemeColor.SecondaryColor;
            };
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            textBoxRecherche.Text = string.Empty;
            tBPUAMax.Text = string.Empty;
            tBPUAMin.Text = string.Empty;
            tBPUVMax.Text = string.Empty;
            tBPUVMin.Text = string.Empty;
            tBQntMin.Text = string.Empty;
            tBQntMax.Text = string.Empty;
            dgStocks.Columns.Remove("");
            dataGridGenerator();
        }

        private void dataGridGenerator()
        {
            string query = "SELECT"
                                + " S.idStock as 'ID',"
                                + " A.Design as 'Article',"
                                + " F.NomF as 'Fournisseur',"
                                + " S.qnt - S.qntVendu - qntRes as 'Quantité disponible',"
                                + " S.puAchat as 'Prix Unt. Achat',"
                                + " S.puVente as 'Prix Unt. Vente',"
                                + " S.tva as 'TVA',"
                                + " S.garantMois as 'Garantie (Mois)',"
                                + " FORMAT (S.dateExp, 'dd/MM/yyyy') as [Date d'expiration],"
                                + " S.ajDate as [Date d'ajout]"
                        + " FROM Stock AS S INNER JOIN Article AS A ON S.article = A.refArt INNER JOIN Fournisseur AS F ON S.frn = F.RefFour";

            var ds = dbCon.querySelect(query);
            dataGridViewStocks.ReadOnly = true;
            dataGridViewStocks.DataSource = ds.Tables[0];
        }


        private void dataGridViewStocks_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgStocks != null)
            {
                
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                if (dgStocks.Columns[dgStocks.ColumnCount - 1].HeaderText != string.Empty)
                {          
                    column.HeaderText = string.Empty;
                    dgStocks.Columns.Add(column);
                }
                dgStocks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgStocks.Columns[dgStocks.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgStocks.AutoResizeColumns();

            }
            dateGridViewRowsTheme();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            string SearchValue = textBoxRecherche.Text;
            string SelCol = "S.idStock";

            if (cbID.Checked || cbArt.Checked || cbRefArt.Checked || cbFourn.Checked || cbRefFourn.Checked)
            {
                if (cbArt.Checked) SelCol = "A.Design";
                if (cbRefArt.Checked) SelCol = "A.refArt";
                if (cbFourn.Checked) SelCol = "F.NomF";
                if (cbRefFourn.Checked) SelCol = "F.RefFour";


                string query = "SELECT"
                                + " S.idStock as 'ID',"
                                + " A.Design as 'Article',"
                                + " F.NomF as 'Fournisseur',"
                                + " S.qnt - S.qntVendu - qntRes as [Quantité disponible],"
                                + " S.puAchat as 'Prix Unt. Achat',"
                                + " S.puVente as 'Prix Unt. Vente',"
                                + " S.tva as 'TVA',"
                                + " S.garantMois as 'Garantie (Mois)',"
                                + " FORMAT (S.dateExp, 'dd/MM/yyyy') as [Date d'expiration],"
                                + " S.ajDate as [Date d'ajout]"
                        + " FROM Stock AS S INNER JOIN Article AS A ON S.article = A.refArt INNER JOIN Fournisseur AS F ON S.frn = F.RefFour"
                        + " WHERE "+SelCol+" LIKE @txtboxValue"
                        + dbCon.GetIntervalQuery("S.qnt - S.qntVendu - qntRes", tBQntMin.Text, tBQntMax.Text, "Qnt")
                        + dbCon.GetIntervalQuery("S.puAchat", tBPUAMin.Text, tBPUAMax.Text, "PUA")
                        + dbCon.GetIntervalQuery("S.puVente", tBPUVMin.Text, tBPUVMax.Text, "PUV")
                        +";";

                try { 
                System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, dbCon.con);
                command.Parameters.AddWithValue("@txtboxValue", "%"+textBoxRecherche.Text+ "%");

                    if (tBQntMin.Text != string.Empty)
                        command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@MinQnt", SqlDbType.Decimal){Precision = 18, Scale = 8}).Value = tBQntMin.Text;
                    if(tBQntMax.Text != string.Empty)
                        command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@MaxQnt", SqlDbType.Decimal) { Precision = 18, Scale = 8 }).Value = tBQntMax.Text;
                    if (tBPUAMin.Text != string.Empty)
                        command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@MinPUA", SqlDbType.NVarChar) { Precision = 23, Scale = 3 }).Value = tBPUAMin.Text;
                    if (tBPUAMax.Text != string.Empty)
                        command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@MaxPUA", SqlDbType.NVarChar) { Precision = 23, Scale = 3 }).Value = tBPUAMax.Text;
                    if (tBPUVMin.Text != string.Empty)
                        command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@MinPUV", SqlDbType.NVarChar) { Precision = 23, Scale = 3 }).Value = tBPUVMin.Text;
                    if (tBPUVMax.Text != string.Empty)
                        command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@MaxPUV", SqlDbType.NVarChar) { Precision = 23, Scale = 3 }).Value = tBPUVMax.Text;
                        
                    var ds = dbCon.querySelect2(command);
                    dgStocks.Columns.Remove("");
                    dataGridViewStocks.ReadOnly = true;
                    dataGridViewStocks.DataSource = ds.Tables[0];
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

        private void tBQntMin_TextChanged(object sender, EventArgs e)
        {
            btnRechercher.PerformClick();
        }

        private void tBQntMax_TextChanged(object sender, EventArgs e)
        {
            btnRechercher.PerformClick();
        }

        private void tBPUAMin_TextChanged(object sender, EventArgs e)
        {
            btnRechercher.PerformClick();
        }

        private void tBPUAMax_TextChanged(object sender, EventArgs e)
        {
            btnRechercher.PerformClick();
        }

        private void tBPUVMin_TextChanged(object sender, EventArgs e)
        {
            btnRechercher.PerformClick();
        }

        private void tBPUVMax_TextChanged(object sender, EventArgs e)
        {
            btnRechercher.PerformClick();
        }

        private void cbID_CheckedChanged(object sender, EventArgs e)
        {
            btnRechercher.PerformClick();
        }

        private void cbArt_CheckedChanged(object sender, EventArgs e)
        {
            btnRechercher.PerformClick();
        }

        private void cbRefArt_CheckedChanged(object sender, EventArgs e)
        {
            btnRechercher.PerformClick();
        }

        private void cbFourn_CheckedChanged(object sender, EventArgs e)
        {
            btnRechercher.PerformClick();
        }

        private void cbRefFourn_CheckedChanged(object sender, EventArgs e)
        {
            btnRechercher.PerformClick();
        }

        private void tBQntMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar, dotControl = '.';

            if (tBQntMin.Text.IndexOf('.') != -1)
                dotControl = '0';

            if (!char.IsDigit(chr) && !char.IsControl(chr) && chr != dotControl)
                e.Handled = true;
        }

        private void tBQntMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar, dotControl = '.';

            if (tBQntMax.Text.IndexOf('.') != -1)
                dotControl = '0';

            if (!char.IsDigit(chr) && !char.IsControl(chr) && chr != dotControl)
                e.Handled = true;
        }

        private void tBPUAMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar, dotControl = '.';

            if (tBPUAMin.Text.IndexOf('.') != -1)
                dotControl = '0';

            if (!char.IsDigit(chr) && !char.IsControl(chr) && chr != dotControl)
                e.Handled = true;
        }

        private void tBPUAMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar, dotControl = '.';

            if (tBPUAMax.Text.IndexOf('.') != -1)
                dotControl = '0';

            if (!char.IsDigit(chr) && !char.IsControl(chr) && chr != dotControl)
                e.Handled = true;
        }

        private void tBPUVMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar, dotControl = '.';

            if (tBPUVMin.Text.IndexOf('.') != -1)
                dotControl = '0';

            if (!char.IsDigit(chr) && !char.IsControl(chr) && chr != dotControl)
                e.Handled = true;
        }

        private void tBPUVMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar, dotControl = '.';

            if (tBPUVMax.Text.IndexOf('.') != -1)
                dotControl = '0';

            if (!char.IsDigit(chr) && !char.IsControl(chr) && chr != dotControl)
                e.Handled = true;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (AppGA.subForm != null)
            {
                AppGA.subForm.Close();
            }
            Form childForm = new Forms.GS.AjouterStock(string.Empty);
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
            Form childForm = new Forms.GS.AjouterStock(dataGridViewStocks.CurrentRow.Cells[0].Value.ToString());
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

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            string sRefArt = dgStocks.CurrentRow.Cells[0].Value.ToString();
            string sDesign = dgStocks.CurrentRow.Cells[1].Value.ToString();
            AppGA.tempForm = new Forms.CMB.FormSuppMsgBox("idStock", sRefArt, sDesign, 2);
            AppGA.tempForm.ShowDialog();
        }

        private void PanelStockSearch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbUntAchat_Click(object sender, EventArgs e)
        {

        }
    }
}
