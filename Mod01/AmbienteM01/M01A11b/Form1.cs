namespace M01A11b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnOk_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "Ol�,";
            lblMsg.Visible = true;
            await Task.Delay(2000); //Ao colocar await o VS prop�e a cria��o de um m�todo ass�ncrono... Escolher o async void. 
            lblMsg.Text += " tudo bem?";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
