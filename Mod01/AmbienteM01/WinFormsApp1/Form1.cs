namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float n = 0;
            float.TryParse(txtNum.Text, out n);
            lblTxt01.Text = $"Você digitou o valor {n:N3}";
            lblTxt02.Text = $"A parte inteira é {(int)n}";
            lblTxt03.Text = $"Arredondando temos {Convert.ToInt16(n)}";
            lblTxt01.Visible = true; lblTxt02.Visible = true; lblTxt03.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
