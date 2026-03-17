namespace ButtonTesting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MoveButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2(NameInputText1.Text);
            form2.Show();

        }
    }
}
