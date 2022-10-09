namespace simple_VB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = Microsoft.VisualBasic.Interaction.InputBox("Enter Your String:","Prompt Text","");
            if (name != "")
            {
                textBox1.Text = name;
                textBox2.Text = Microsoft.VisualBasic.Strings.UCase(name);
                textBox3.Text = Microsoft.VisualBasic.Strings.LCase(name);
                textBox4.Text = Microsoft.VisualBasic.Strings.StrReverse(name);

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}