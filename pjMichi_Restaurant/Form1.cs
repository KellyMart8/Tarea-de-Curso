namespace pjMichi_Restaurant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Secciones acceder = new Secciones();    
            acceder.Visible = true;    
        }
    }
}