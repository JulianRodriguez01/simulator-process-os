namespace ProyectProcess.models
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.progressBarPorcent = new System.Windows.Forms.ProgressBar();
            this.btnSimulate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.boxProcess = new System.Windows.Forms.NumericUpDown();
            this.boxDelay = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProcess = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPorcent = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableEvents = new System.Windows.Forms.DataGridView();
            this.columnEvents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnPrint = new System.Windows.Forms.Button();
            this.tableFinishProcess = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableBlockProcess = new System.Windows.Forms.DataGridView();
            this.columnProcess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableFinishProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBlockProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBarPorcent
            // 
            resources.ApplyResources(this.progressBarPorcent, "progressBarPorcent");
            this.progressBarPorcent.Name = "progressBarPorcent";
            // 
            // btnSimulate
            // 
            resources.ApplyResources(this.btnSimulate, "btnSimulate");
            this.btnSimulate.Name = "btnSimulate";
            this.btnSimulate.UseVisualStyleBackColor = true;
            this.btnSimulate.Click += new System.EventHandler(this.btnSimulate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectProcess.Properties.Resources.Logo_de_la_UPTC_svg;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // boxProcess
            // 
            resources.ApplyResources(this.boxProcess, "boxProcess");
            this.boxProcess.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.boxProcess.Name = "boxProcess";
            this.boxProcess.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // boxDelay
            // 
            resources.ApplyResources(this.boxDelay, "boxDelay");
            this.boxDelay.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.boxDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.boxDelay.Name = "boxDelay";
            this.boxDelay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lblProcess
            // 
            resources.ApplyResources(this.lblProcess, "lblProcess");
            this.lblProcess.Name = "lblProcess";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // lblPorcent
            // 
            resources.ApplyResources(this.lblPorcent, "lblPorcent");
            this.lblPorcent.Name = "lblPorcent";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // tableEvents
            // 
            this.tableEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnEvents});
            resources.ApplyResources(this.tableEvents, "tableEvents");
            this.tableEvents.Name = "tableEvents";
            this.tableEvents.ReadOnly = true;
            this.tableEvents.RowTemplate.Height = 33;
            this.tableEvents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableEvents_CellContentClick);
            // 
            // columnEvents
            // 
            this.columnEvents.FillWeight = 800F;
            resources.ApplyResources(this.columnEvents, "columnEvents");
            this.columnEvents.Name = "columnEvents";
            this.columnEvents.ReadOnly = true;
            // 
            // btnPrint
            // 
            resources.ApplyResources(this.btnPrint, "btnPrint");
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // tableFinishProcess
            // 
            this.tableFinishProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableFinishProcess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnProcess});
            resources.ApplyResources(this.tableFinishProcess, "tableFinishProcess");
            this.tableFinishProcess.Name = "tableFinishProcess";
            this.tableFinishProcess.ReadOnly = true;
            this.tableFinishProcess.RowTemplate.Height = 33;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tableBlockProcess
            // 
            this.tableBlockProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableBlockProcess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            resources.ApplyResources(this.tableBlockProcess, "tableBlockProcess");
            this.tableBlockProcess.Name = "tableBlockProcess";
            this.tableBlockProcess.ReadOnly = true;
            this.tableBlockProcess.RowTemplate.Height = 33;
            this.tableBlockProcess.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableBlockProcess_CellContentClick);
            // 
            // columnProcess
            // 
            resources.ApplyResources(this.columnProcess, "columnProcess");
            this.columnProcess.Name = "columnProcess";
            this.columnProcess.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableBlockProcess);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableFinishProcess);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.tableEvents);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPorcent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblProcess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxDelay);
            this.Controls.Add(this.boxProcess);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSimulate);
            this.Controls.Add(this.progressBarPorcent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableFinishProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBlockProcess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProgressBar progressBarPorcent;
        private Button btnSimulate;
        private PictureBox pictureBox1;
        private NumericUpDown boxProcess;
        private NumericUpDown boxDelay;
        private Label label1;
        private Label lblProcess;
        private Label label3;
        private Label lblPorcent;
        private Label label5;
        private DataGridView tableEvents;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Button button1;
        private Button btnPrint;
        private DataGridView tableFinishProcess;
        private Label label2;
        private Label label4;
        private DataGridViewTextBoxColumn columnEvents;
        private DataGridViewTextBoxColumn columnClock;
        private DataGridView tableBlockProcess;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn columnProcess;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}