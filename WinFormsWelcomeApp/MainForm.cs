namespace WinFormsWelcomeApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.Text = "HELLO!";

            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result;

            //if (textBox1.Text.Trim().Length > 0)
            //{
            //    //label1.Text = "Привет " + textBox1.Text;
            //    result = MessageBox.Show("Привет " + textBox1.Text,
            //                            "Hello message window",
            //                            MessageBoxButtons.YesNo,
            //                            MessageBoxIcon.Information,
            //                            MessageBoxDefaultButton.Button1,
            //                            MessageBoxOptions.RightAlign);
            //    if (result == DialogResult.Yes)
            //        MessageBox.Show("YES");
            //    else
            //        MessageBox.Show("NO");
            //}

            ChildForm child = new(this);
            child.Show();
                
        }
    }
}
