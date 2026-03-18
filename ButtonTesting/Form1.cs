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
            string selectedOption = "";
            if (Option1.Checked) selectedOption = Option1.Text;
            else if (Option2.Checked) selectedOption = Option2.Text;


            this.Hide();
            Form2 form2 = new Form2(NameInputText1.Text, selectedOption);
            form2.Show();

        }
    }
}
