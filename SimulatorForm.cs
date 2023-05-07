namespace ProyectProcess
{
    public partial class SimulatorForm : Form
    {
        private int count;

        public SimulatorForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSimulateClick(object sender, EventArgs e)
        {
            pbrSimulate.Value = 10;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tmrProgress(object sender, EventArgs e)
        {
            count++;
            



        }
    }
}