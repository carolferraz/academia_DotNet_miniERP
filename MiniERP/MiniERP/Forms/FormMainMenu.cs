using Microsoft.EntityFrameworkCore.Diagnostics;

namespace MiniERP
{
    public partial class FormMainMenu : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        //Constructor
        public FormMainMenu()
        {
            InitializeComponent();
            random = new Random();
        }

        //Métodos
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

        private void ActivateButton(Object btnSender)
        {
            if (btnSender != null)
            {
                DisabledButton();
                if (currentButton != (Button)btnSender)
                {
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;

                }
            }
        }

        private void DisabledButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(91, 38, 63);
                    previousBtn.ForeColor = Color.White;

                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormProdutos(), sender);
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormFornecedor(), sender);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormClientes(), sender);
        }

        private void btnEmitirPedido_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormPedido(), sender);
        }
    }
}