namespace SIO_Math
{
    public partial class Form1 : Form
    {
        private HomePage homeP;
        private ConversionPage conversion;
        private Arithmetique arithmetique;
        private PgcdPage pgcd;
        private PpcmPage ppcm;
        private CongruencePage congruence;

        private List<UserControl> myPages;
        public Form1()
        {
            InitializeComponent();

            //differents pages
            homeP = new HomePage();
            conversion = new ConversionPage();
            arithmetique = new Arithmetique();
            pgcd = new PgcdPage();
            ppcm = new PpcmPage();
            congruence = new CongruencePage();

            //liste of pages
            myPages = new List<UserControl> { homeP, conversion, arithmetique, pgcd, ppcm, congruence };

            //add and adjuste page's size.
            foreach (UserControl page in myPages)
            {
                AddAndAdjustPage(page);
            }

            // catch events (clicks)
            homeP.ButtonClicked += Home_ButtonClicked;
            arithmetique.ClickedOperation += Arithmetique_ChoisenOpeartion;
        }

        private void AddAndAdjustPage(UserControl page)
        {
            page.Dock = DockStyle.Fill; // adjust size
            page.Visible = false; // hide (initial)
            pannelContainer.Controls.Add(page); // add to pannel container
        }

        private void Arithmetique_ChoisenOpeartion(string operationName)
        {
            if (operationName == "pgcd") ShowPage(pgcd);
            else if (operationName == "ppcm") ShowPage(ppcm);
            else if (operationName == "congruence") ShowPage(congruence);
        }

        private void Home_ButtonClicked(string buttonName)
        {
            if (buttonName == "conversion") ShowPage(conversion);
            else if (buttonName == "arithmetique") ShowPage(arithmetique);
        }

        public void ShowPage(UserControl page)
        {
            foreach (UserControl _page in myPages)
            {
                _page.Visible = false;
            }
            page.Visible = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ShowPage(homeP);
        }

        private void home_Click(object sender, EventArgs e)
        {
            ShowPage(homeP);
        }
    }
}
