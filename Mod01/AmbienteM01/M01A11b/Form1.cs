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
            lblMsg.Text = "Olá,";
            lblMsg.Visible = true;
            await Task.Delay(2000); //Ao colocar await o VS propõe a criação de um método assíncrono... Escolher o async void. 
            lblMsg.Text += " tudo bem?";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
