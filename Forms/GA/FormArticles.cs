using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppGA.Forms.GA
{
    public partial class FormArticles : Form
    {
        private Panel basePanel;
        public static Button Actualiser;
        private DataGridView dgArticles;
        public FormArticles(Panel panel)
        {
            InitializeComponent();
            this.basePanel = panel;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (AppGA.subForm != null)
            {
                AppGA.subForm.Close();
            }
            Form childForm = new Forms.GA.FormAjoutArticle(null);
            AppGA.subForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.basePanel.Controls.Add(childForm);
            this.basePanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void LoadTheme()
        {
            //Buttons Theme Apply
            foreach (Control btns in PanelArticleHeader.Controls)
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
            dataGridViewArticles.EnableHeadersVisualStyles = false;
            dataGridViewArticles.ColumnHeadersDefaultCellStyle.Padding = new Padding(6,4,0,4);
            dataGridViewArticles.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
            dataGridViewArticles.ColumnHeadersDefaultCellStyle.SelectionBackColor = ThemeColor.PrimaryColor;
            dataGridViewArticles.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewArticles.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewArticles.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridViewArticles.RowsDefaultCellStyle.Font = new Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewArticles.RowsDefaultCellStyle.SelectionBackColor = ThemeColor.DarkColor;
            dataGridViewArticles.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            dataGridViewArticles.RowsDefaultCellStyle.Padding = new Padding(6, 6, 30, 6);
            dataGridViewArticles.ScrollBars = ScrollBars.Both;

        }

        private void dateGridViewRowsTheme()
        {
            int rowsCount = dataGridViewArticles.RowCount;
            for(var i = 1; i<rowsCount;  i+=2)
            {
                dataGridViewArticles.Rows[i].DefaultCellStyle.BackColor = ThemeColor.SecondaryColor;
            };
        }

        private void FormArticles_Load(object sender, EventArgs e)
        {
            LoadTheme();
            dataGridGenerator();
            dgArticles = this.dataGridViewArticles;
            Actualiser = this.btnActualiser;
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            textBoxRecherche.Text = string.Empty;
            dgArticles.Columns.Remove("");
            dataGridGenerator();
        }


        private void dataGridGenerator()
        {

            var ds = dbCon.querySelect("SELECT Article.RefArt as 'Référance', Article.Design as 'Désignation', FamilleArt.Design AS Famille, Article.poids AS 'Poids (g)', Article.couleur AS 'Couleur', ajDate as [Date d'Ajout] FROM Article INNER JOIN FamilleArt ON Article.CodeFamille = FamilleArt.CodeFamille;");
            dataGridViewArticles.ReadOnly = true;
            dataGridViewArticles.DataSource = ds.Tables[0];
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            string SearchValue = textBoxRecherche.Text;
            string SelCol = "Article.Design";

            if (cbRefArt.Checked || cbDesign.Checked || cbFamille.Checked || cbCodeFamille.Checked)
            {
                if (cbRefArt.Checked) SelCol = "Article.RefArt";
                if (cbFamille.Checked) SelCol = "FamilleArt.Design";
                if (cbCodeFamille.Checked) SelCol = "Article.CodeFamille";

                var select = "SELECT Article.RefArt as 'Référance', Article.Design as 'Désignation', FamilleArt.Design AS Famille, Article.poids AS 'Poids (g)', Article.couleur AS 'Couleur', ajDate as [Date d'Ajout] FROM Article INNER JOIN FamilleArt ON Article.CodeFamille = FamilleArt.CodeFamille WHERE " + SelCol + " LIKE '%" + SearchValue + "%';";
                var ds = dbCon.querySelect(select);
                dgArticles.Columns.Remove("");
                dataGridViewArticles.ReadOnly = true;
                dataGridViewArticles.DataSource = ds.Tables[0];

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

        private void cbDesign_CheckedChanged(object sender, EventArgs e)
        {
            btnRechercher.PerformClick();
        }

        private void cbRefArt_CheckedChanged(object sender, EventArgs e)
        {
            btnRechercher.PerformClick();
        }

        private void cbFamille_CheckedChanged(object sender, EventArgs e)
        {
            btnRechercher.PerformClick();
        }

        private void cbCodeFamille_CheckedChanged(object sender, EventArgs e)
        {
            btnRechercher.PerformClick();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            string sRefArt = dgArticles.CurrentRow.Cells[0].Value.ToString();
            string sDesign = dgArticles.CurrentRow.Cells[1].Value.ToString();
            AppGA.tempForm = new Forms.CMB.FormSuppMsgBox("refArt", sRefArt, sDesign, 1);
            AppGA.tempForm.ShowDialog();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Form childForm = new Forms.GA.FormAjoutArticle(dataGridViewArticles.CurrentRow);
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

        private void dataGridViewArticles_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgArticles != null)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                if (dgArticles.Columns[dgArticles.ColumnCount - 1].HeaderText != string.Empty)
                {
                    column.HeaderText = string.Empty;
                    dgArticles.Columns.Add(column);
                }
                dgArticles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgArticles.Columns[dgArticles.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgArticles.AutoResizeColumns();

            }
            dateGridViewRowsTheme();
        }
    }
}
