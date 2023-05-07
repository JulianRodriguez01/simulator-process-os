using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;  
using System.IO; 

using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Metadata;
using System.Drawing.Printing;
using TextBox = System.Windows.Forms.TextBox;
using Button = System.Windows.Forms.Button;
using System.Security;
using Document = iTextSharp.text.Document;

namespace ProyectProcess.models
{
    public partial class MainForm : Form
    {

        private Simulator simulator;

        public MainForm()
        {
            simulator = new Simulator();
            InitializeComponent();
        }

        private void btnSimulate_Click(object sender, EventArgs e)
        {
            clearElements();
            startBarProgress();
            simulator.writteHeader();
            startSimulator();
            fillBoxEvents();
            fillBlockedProcess();
            fillBoxFinishProcess();
            openDialog();
        }

        public void clearElements()
        {
            progressBarPorcent.Value = 0;
            tableEvents.Rows.Clear();
        }

        public void startBarProgress() {
            double total = 0;
            while (total <= 100)
            {
                progressBarPorcent.Value = (int)total;
                total++;
                Thread.Sleep((int)boxDelay.Value * 10);
                /*total += (100 / (int) boxProcess.Value);
                Thread.Sleep((int)boxDelay.Value * 1000);*/
            }
        }

        public void startSimulator()
        {
            double total = 0;
            while (total <= (int) boxProcess.Value)
            {
                simulator.startSimulator();
                total ++;
            }
        }

        public void fillBoxEvents()
        {
            List<string> aux = simulator.getListEvents();
            foreach (string a in aux)
            {
                int n = tableEvents.Rows.Add();
                tableEvents.Rows[n].Cells[0].Value = a;
            }
        }

        public void fillBlockedProcess()
        {
            List<Process> aux = simulator.getListProcessStatus(Status.blocked);
            foreach (Process a in aux)
            {
                int n = tableBlockProcess.Rows.Add();
                tableBlockProcess.Rows[n].Cells[0].Value = "  -> Process: " + "[ID: " + a.getIdProcess() + ", Life Time:" + a.getLifeTime()
                + "/20, Next IO: " + a.getNextIo() + "/4, IO: " + a.getIO() + "/1, Status: " +
                a.getStatus() + ", Quantum: " + a.getQuantum() + "] \n";
            }
        }

        public void fillBoxFinishProcess()
        {
            List<Process> aux = simulator.getListProcessStatus(Status.finish);
            foreach (Process a in aux)
            {
                int n = tableFinishProcess.Rows.Add();
                tableFinishProcess.Rows[n].Cells[0].Value = "  -> Process: " + "[ID: " + a.getIdProcess() + ", Life Time:" + a.getLifeTime()
                + "/20, Next IO: " + a.getNextIo() + "/4, IO: " + a.getIO() + "/1, Status: " +
                a.getStatus() + ", Quantum: " + a.getQuantum() + "] \n";
            }
        }

        public void openDialog() {
            MessageBox.Show("Documento creado correctamente, dirigase a la carpeta output/register.txt", "Impresión", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream("../../../output/result.pdf", FileMode.Create));
            document.Open();
            Paragraph p = new Paragraph(simulator.getTextFile());
            document.Add(p);
            document.Close();
        }

        private void tableEvents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tableBlockProcess_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
