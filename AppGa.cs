using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace AppGA
{
    public partial class AppGA : Form
    {
        //Fields
        private IconButton currentButton;
        private Random random;
        private int tempIndex;
        public static Form activeForm;
        public static Form subForm;
        public static Form tempForm;
        public static Button activeForm2Exit;
        private bool dragAct;
        public static DataRow selectedRow;
        public static DataGridViewRow selectedRow2;
        //Constructor
        public AppGA()
        {
            InitializeComponent();
            random = new Random();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        // DRAG WINDOW
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (IconButton)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();

                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, 0.85);
                    ThemeColor.DarkColor = ThemeColor.ChangeColorBrightness(color, -0.3);

                    currentButton = (IconButton)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                    PanelLogo.BackColor = ThemeColor.DarkColor;
                    PanelTitleBar.BackColor = color;
                    PanelBottomBar.BackColor = ThemeColor.DarkColor;
                }
            }
        }

        private void DisableButton()
        {
            foreach(Control previousBtn in PanelMenu.Controls)
            {
                if(previousBtn.GetType() == typeof(IconButton))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender, string designForm)
        {
            if ( activeForm != null)
            {
                activeForm.Close();
            }

            if (subForm != null)
            {
                subForm.Close();
            }

            if (tempForm != null)
            {
                activeForm.Close();
            }

            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.PanelDesktop.Controls.Add(childForm);
            this.PanelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbTitle.Text = designForm.ToUpperInvariant(); 
            
        }

        private void btnGererArticle_Click(object sender, EventArgs e)
        {
            Forms.FormGestionArticles NewForm = new Forms.FormGestionArticles();
            OpenChildForm(NewForm, sender, Forms.FormGestionArticles.designForm);
            NewForm.OpenHome();
        }

        private void btnGererStock_Click(object sender, EventArgs e)
        {
            Forms.FormGestionStock NewForm = new Forms.FormGestionStock();
            OpenChildForm(NewForm, sender, Forms.FormGestionStock.designForm);
            NewForm.OpenHome();
        }

        private void btnGererComnd_Click(object sender, EventArgs e)
        {
            Forms.FormGestionCommandes NewForm = new Forms.FormGestionCommandes();
            OpenChildForm(NewForm, sender, Forms.FormGestionCommandes.designForm);
            NewForm.OpenHome();
        }


        private void AppGA_Load(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.dragAct = true;
            else
                this.dragAct = false;

            btnGererComnd.PerformClick();
        }

        private void PanelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.dragAct)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

        private void lbTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.dragAct)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaxmize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.dragAct = false;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.dragAct = true;
            }

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
