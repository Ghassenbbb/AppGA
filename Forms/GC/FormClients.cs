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
    public partial class FormClients : Form
    {
        private Panel basePanel;
        public static Button Actualiser;
        private DataGridView dgClients;
        public FormClients(Panel P)
        {
            this.basePanel = P;
            InitializeComponent();
        }

        private void FormClients_Load(object sender, EventArgs e)
        {
            LoadTheme();
            dataGridGenerator();
            dgClients = this.dataGridViewClient;
            Actualiser = this.btnActualiser;
        }


        private void LoadTheme()
        {
            //Buttons Theme Apply
            foreach (Control btns in PanelClientHeader.Controls)
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
            dataGridViewClient.EnableHeadersVisualStyles = false;
            dataGridViewClient.ColumnHeadersDefaultCellStyle.Padding = new Padding(6, 4, 0, 4);
            dataGridViewClient.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
            dataGridViewClient.ColumnHeadersDefaultCellStyle.SelectionBackColor = ThemeColor.PrimaryColor;
            dataGridViewClient.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewClient.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewClient.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridViewClient.RowsDefaultCellStyle.Font = new Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewClient.RowsDefaultCellStyle.SelectionBackColor = ThemeColor.DarkColor;
            dataGridViewClient.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            dataGridViewClient.RowsDefaultCellStyle.Padding = new Padding(6, 6, 30, 6);
            dataGridViewClient.ScrollBars = ScrollBars.Both;

        }

        private void dateGridViewRowsTheme()
        {
            int rowsCount = dataGridViewClient.RowCount;
            for (var i = 1; i < rowsCount; i += 2)
            {
                dataGridViewClient.Rows[i].DefaultCellStyle.BackColor = ThemeColor.SecondaryColor;
            };
        }

        private void dataGridGenerator()
        {
            string query = "SELECT"
                                + " idCl as 'ID',"
                                + " NomC as 'Nom',"
                                + " gsmC as 'GSM',"
                                + " emailC as 'eMail',"
                                + " adrC as 'Adresse',"
                                + " ajDate as [Date d'ajout]"
                        + " FROM Client;";

            var ds = dbCon.querySelect(query);
            dataGridViewClient.ReadOnly = true;
            dataGridViewClient.DataSource = ds.Tables[0];
        }

        private void dataGridViewClient_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgClients != null)
            {

                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                if (dgClients.Columns[dgClients.ColumnCount - 1].HeaderText != string.Empty)
                {
                    column.HeaderText = string.Empty;
                    dgClients.Columns.Add(column);
                }
                dgClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgClients.Columns[dgClients.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgClients.AutoResizeColumns();

            }
            dateGridViewRowsTheme();
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            textBoxRecherche.Text = string.Empty;
            dgClients.Columns.Remove("");
            dataGridGenerator();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            string SearchValue = textBoxRecherche.Text;
            string SelCol = "NomC";

            if (cbNom.Checked || cbidCl.Checked || cbGSM.Checked || cbEmail.Checked || cbAdr.Checked)
            {
                if (cbidCl.Checked) SelCol = "idCl";
                if (cbGSM.Checked) SelCol = "gsmC";
                if (cbEmail.Checked) SelCol = "emailC";
                if (cbAdr.Checked) SelCol = "adrC";


                string query = "SELECT"
                                    + " idCl as 'ID',"
                                    + " NomC as 'Nom',"
                                    + " gsmC as 'GSM',"
                                    + " emailC as 'eMail',"
                                    + " adrC as 'Adresse',"
                                    + " ajDate as [Date d'ajout]"
                                    + " FROM Client"
                               + " WHERE " + SelCol + " LIKE @txtboxValue;";

                try
                {
                    System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, dbCon.con);
                    command.Parameters.AddWithValue("@txtboxValue", "%" + textBoxRecherche.Text + "%");
                    var ds = dbCon.querySelect2(command);
                    dgClients.Columns.Remove("");
                    dataGridViewClient.ReadOnly = true;
                    dataGridViewClient.DataSource = ds.Tables[0];
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

        private void cbidCl_CheckedChanged(object sender, EventArgs e)
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
            Form childForm = new Forms.GC.AjouterClient(null);
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
            Form childForm = new Forms.GC.AjouterClient(dataGridViewClient.CurrentRow);
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
            string sID = dgClients.CurrentRow.Cells[0].Value.ToString();
            string sNom = dgClients.CurrentRow.Cells[1].Value.ToString();
            AppGA.tempForm = new Forms.CMB.FormSuppMsgBox("idCl", sID, sNom, 4);
            AppGA.tempForm.ShowDialog();
        }
    }
}