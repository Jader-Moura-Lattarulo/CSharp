namespace M01A08b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            lblMsg.Text = "Muito prazer em te conhecer, " + nome + "!";
            lblMsg.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
