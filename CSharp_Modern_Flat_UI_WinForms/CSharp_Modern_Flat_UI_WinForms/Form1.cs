namespace CSharp_Modern_Flat_UI_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void customizeDesing()
        {
            panelMediaSubmenu.Visible = false;
            panelPlaylistSubMenu.Visible = false;
            panel2.Visible = false;

        }


    }
}
