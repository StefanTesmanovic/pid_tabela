namespace pid_tabela
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public Form1()
        {
            InitializeComponent();
            instance = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (brojFaza.Text == "0") return;
            Form2 forma = new Form2();
            forma.Show();
        }
    }
}
