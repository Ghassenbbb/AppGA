using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace AppGA.Forms.GA
{
    public partial class FormFamilles : Form
    {
        private Panel basePanel;
        private static string queryDataGrid = "SELECT F.Design as 'Désignation', F.CodeFamille as 'Code Famille', ISNULL(S.nbr, 0) as 'Nombre des articles inclus' FROM FamilleArt F LEFT JOIN (SELECT F.CodeFamille, COUNT(*) as nbr FROM FamilleArt F INNER JOIN Article A ON A.codeFamille = F.CodeFamille GROUP BY F.CodeFamille) as S ON S.codeFamille = F.CodeFamille";
        public static Button Actualiser;
        private DataGridView dgFamilles;
        public FormFamilles(Panel panel)
        {
            InitializeComponent();
            this.basePanel = panel;
        }

        private void FormFamilles_Load(object sender, EventArgs e)
        {
            LoadTheme();
            dataGridGenerator();
            dgFamilles = this.dataGridViewFamilles;
            Actualiser = this.btnActualiser;
        }

        private void LoadTheme()
        {
            //Buttons Theme Apply
            foreach (Control btns in PanelFamilleHeader.Controls)
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
            dataGridViewFamilles.EnableHeadersVisualStyles = false;
            dataGridViewFamilles.ColumnHeadersDefaultCellStyle.Padding = new Padding(6, 4, 0, 4);
            dataGridViewFamilles.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
            dataGridViewFamilles.ColumnHeadersDefaultCellStyle.SelectionBackColor = ThemeColor.PrimaryColor;
            dataGridViewFamilles.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewFamilles.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewFamilles.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridViewFamilles.RowsDefaultCellStyle.Font = new Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewFamilles.RowsDefaultCellStyle.SelectionBackColor = ThemeColor.DarkColor;
            dataGridViewFamilles.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            dataGridViewFamilles.RowsDefaultCellStyle.Padding = new Padding(6, 6, 50, 6);


        }

        private void dataGridViewRowsTheme()
        {
            int rowsCount = dataGridViewFamilles.RowCount;
            for (var i = 1; i < rowsCount; i += 2)
            {
                dataGridViewFamilles.Rows[i].DefaultCellStyle.BackColor = ThemeColor.SecondaryColor;
            };
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewArticles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (AppGA.subForm != null)
            {
                AppGA.subForm.Close();
            }
            Form childForm = new Forms.GA.FormAjoutFamille(null);
            AppGA.subForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.basePanel.Controls.Add(childForm);
            this.basePanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            dgFamilles.Columns.Remove("");
            dataGridGenerator();
        }

        private void dataGridGenerator()
        {
            textBoxRecherche.Text = string.Empty;
            var ds = dbCon.querySelect(queryDataGrid);
            dataGridViewFamilles.ReadOnly = true;
            dataGridViewFamilles.DataSource = ds.Tables[0];
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            string SearchValue = textBoxRecherche.Text;
            string SelCol = "F.Design";

            if (cbDesign.Checked || cbCodeFamille.Checked)
            {
                if (cbCodeFamille.Checked) SelCol = "F.CodeFamille";

                var select = queryDataGrid + " WHERE " + SelCol + " LIKE '%" + SearchValue + "%';";
                var ds = dbCon.querySelect(select);
                dgFamilles.Columns.Remove("");
                dataGridViewFamilles.ReadOnly = true;
                dataGridViewFamilles.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Vous devez selectionner un filtre de recherche !");
            }
        }

        private void cbDesign_CheckedChanged(object sender, EventArgs e)
        {
            btnRechercher.PerformClick();
        }

        private void cbCodeFamille_CheckedChanged(object sender, EventArgs e)
        {
            btnRechercher.PerformClick();
        }

        private void textBoxRecherche_TextChanged(object sender, EventArgs e)
        {
            btnRechercher.PerformClick();
        }



   
        private void btnModifier_Click(object sender, EventArgs e)
        {
            Form childForm = new Forms.GA.FormAjoutFamille(dgFamilles.CurrentRow);
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
            string sFamille = dgFamilles.CurrentRow.Cells[0].Value.ToString();
            string sCode = dgFamilles.CurrentRow.Cells[1].Value.ToString();
            AppGA.tempForm = new Forms.CMB.FormSuppMsgBox("CodeFamille", sCode, sFamille, 0);
            AppGA.tempForm.ShowDialog();
        }

        private void dataGridViewFamilles_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgFamilles != null)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                if (dgFamilles.Columns[dgFamilles.ColumnCount - 1].HeaderText != string.Empty)
                {
                    column.HeaderText = string.Empty;
                    dgFamilles.Columns.Add(column);
                }
                dgFamilles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgFamilles.Columns[dgFamilles.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgFamilles.AutoResizeColumns();
            }
            dataGridViewRowsTheme();
        }
    }
}
