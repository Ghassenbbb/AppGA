using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace AppGA.Forms.GS
{


    public partial class FormFournisseurs : Form
    {
        private Panel basePanel;
        public static Button Actualiser;
        private DataGridView dgFourn;
        public FormFournisseurs(Panel P)
        {
            this.basePanel = P;
            InitializeComponent();
        }

        private void FormFournisseurs_Load(object sender, EventArgs e)
        {
            LoadTheme();
            dataGridGenerator();
            dgFourn = this.dataGridViewFourns;
            Actualiser = this.btnActualiser;
        }

        private void LoadTheme()
        {
            //Buttons Theme Apply
            foreach (Control btns in PanelFournsHeader.Controls)
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
            dataGridViewFourns.EnableHeadersVisualStyles = false;
            dataGridViewFourns.ColumnHeadersDefaultCellStyle.Padding = new Padding(6, 4, 0, 4);
            dataGridViewFourns.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
            dataGridViewFourns.ColumnHeadersDefaultCellStyle.SelectionBackColor = ThemeColor.PrimaryColor;
            dataGridViewFourns.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewFourns.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewFourns.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridViewFourns.RowsDefaultCellStyle.Font = new Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewFourns.RowsDefaultCellStyle.SelectionBackColor = ThemeColor.DarkColor;
            dataGridViewFourns.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            dataGridViewFourns.RowsDefaultCellStyle.Padding = new Padding(6, 6, 30, 6);
            dataGridViewFourns.ScrollBars = ScrollBars.Both;

        }

        private void dateGridViewRowsTheme()
        {
            int rowsCount = dataGridViewFourns.RowCount;
            for (var i = 1; i < rowsCount; i += 2)
            {
                dataGridViewFourns.Rows[i].DefaultCellStyle.BackColor = ThemeColor.SecondaryColor;
            };
        }

        private void dataGridGenerator()
        {
            string query = "SELECT"
                                + " RefFour as 'Référance',"
                                + " NomF as 'Nom',"
                                + " gsmF as 'GSM',"
                                + " faxF as 'FAX',"
                                + " emailF as 'eMail',"
                                + " adrF as 'Adresse',"
                                + " ajDate as [Date d'ajout]"
                        + " FROM Fournisseur;";

            var ds = dbCon.querySelect(query);
            dataGridViewFourns.ReadOnly = true;
            dataGridViewFourns.DataSource = ds.Tables[0];
        }

        private void dataGridViewFourns_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgFourn != null)
            {

                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                if (dgFourn.Columns[dgFourn.ColumnCount - 1].HeaderText != string.Empty)
                {
                    column.HeaderText = string.Empty;
                    dgFourn.Columns.Add(column);
                }
                dgFourn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgFourn.Columns[dgFourn.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgFourn.AutoResizeColumns();

            }
            dateGridViewRowsTheme();
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            textBoxRecherche.Text = string.Empty;
            dgFourn.Columns.Remove("");
            dataGridGenerator();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            string SearchValue = textBoxRecherche.Text;
            string SelCol = "NomF";

            if (cbNom.Checked || cbRefFour.Checked || cbGSM.Checked || cbEmail.Checked || cbFax.Checked || cbAdr.Checked)
            {
                if (cbRefFour.Checked) SelCol = "RefFour";
                if (cbGSM.Checked) SelCol = "gsmF";
                if (cbEmail.Checked) SelCol = "emailF";
                if (cbFax.Checked) SelCol = "faxF";
                if (cbAdr.Checked) SelCol = "adrF";


                string query = "SELECT"
                                    + " RefFour as 'Référance',"
                                    + " NomF as 'Nom',"
                                    + " gsmF as 'GSM',"
                                    + " faxF as 'FAX',"
                                    + " emailF as 'eMail',"
                                    + " adrF as 'Adresse',"
                                    + " ajDate as [Date d'ajout]"
                                    + " FROM Fournisseur"
                               + " WHERE " + SelCol + " LIKE @txtboxValue;";

                try
                {
                    System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, dbCon.con);
                    command.Parameters.AddWithValue("@txtboxValue", "%" + textBoxRecherche.Text + "%");
                    var ds = dbCon.querySelect2(command);
                    dgFourn.Columns.Remove("");
                    dataGridViewFourns.ReadOnly = true;
                    dataGridViewFourns.DataSource = ds.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void textBoxRecherche_TextChanged(object sender, EventArgs e)
        {
            btnRechercher.PerformClick();
        }

        private void cbNom_CheckedChanged(object sender, EventArgs e)
        {
            btnRechercher.PerformClick();
        }

        private void cbRefFour_CheckedChanged(object sender, EventArgs e)
        {
            btnRechercher.PerformClick();
        }

        private void cbEmail_CheckedChanged(object sender, EventArgs e)
        {
            btnRechercher.PerformClick();
        }

        private void cbGSM_CheckedChanged(object sender, EventArgs e)
        {
            btnRechercher.PerformClick();
        }

        private void cbFax_CheckedChanged(object sender, EventArgs e)
        {
            btnRechercher.PerformClick();
        }

        private void cbAdr_CheckedChanged(object sender, EventArgs e)
        {
            btnRechercher.PerformClick();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (AppGA.subForm != null)
            {
                AppGA.subForm.Close();
            }
            Form childForm = new Forms.GS.AjouterFourn(null);
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
            Form childForm = new Forms.GS.AjouterFourn(dataGridViewFourns.CurrentRow);
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
            string sRefFour = dgFourn.CurrentRow.Cells[0].Value.ToString();
            string sNom = dgFourn.CurrentRow.Cells[1].Value.ToString();
            AppGA.tempForm = new Forms.CMB.FormSuppMsgBox("RefFour", sRefFour, sNom, 3);
            AppGA.tempForm.ShowDialog();
        }
    }
}
