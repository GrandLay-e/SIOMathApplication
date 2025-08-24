namespace SIO_Math
{
    public partial class Form1 : Form
    {
        private HomePage home;
        private ConversionPage conversion;

        public Form1()
        {
            InitializeComponent();

            home = new HomePage();
            conversion = new ConversionPage();

            home.Dock = DockStyle.Fill;
            conversion.Dock = DockStyle.Fill;

            home.Visible = false;
            conversion.Visible = false;

            pannelContainer.Controls.Add(home);
            pannelContainer.Controls.Add(conversion);

            home.ButtonClicked += Home_ButtonClicked;
        }

        private void Home_ButtonClicked(string buttonName)
        {
            if (buttonName == "conversion") ShowPage(conversion);
            else if (buttonName == "arithmetique") ShowPage(home);
        }

        public void ShowPage(UserControl page)
        {
            home.Visible = false;
            conversion.Visible = false;

            page.Visible = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ShowPage(home);
        }

    }
}
