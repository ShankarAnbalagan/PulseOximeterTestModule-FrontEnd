namespace Pulse_OM
{
    partial class pulse_om
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.spo2_test = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bpm_test = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cOMPortsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOM1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOM2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOM3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOM4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOM5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOM6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOM7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOM8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.spo2_req = new System.Windows.Forms.NumericUpDown();
            this.bpm_req = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.pi_req = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PLGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.OK = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spo2_req)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpm_req)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi_req)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PLGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "SpO2(%) : ";
            // 
            // spo2_test
            // 
            this.spo2_test.AutoSize = true;
            this.spo2_test.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.spo2_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spo2_test.Location = new System.Drawing.Point(179, 27);
            this.spo2_test.Name = "spo2_test";
            this.spo2_test.Size = new System.Drawing.Size(0, 32);
            this.spo2_test.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "BPM : ";
            // 
            // bpm_test
            // 
            this.bpm_test.AutoSize = true;
            this.bpm_test.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bpm_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bpm_test.Location = new System.Drawing.Point(179, 67);
            this.bpm_test.Name = "bpm_test";
            this.bpm_test.Size = new System.Drawing.Size(0, 32);
            this.bpm_test.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(137, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Finger IN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(137, 525);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(226, 49);
            this.button2.TabIndex = 5;
            this.button2.Text = "Finger OUT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 104);
            this.label5.TabIndex = 6;
            this.label5.Text = "Pulse Oximeter\r\nTest Module";
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 4800;
            this.serialPort1.PortName = "COM5";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 662);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "label6";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cOMPortsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1271, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cOMPortsToolStripMenuItem
            // 
            this.cOMPortsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cOM1ToolStripMenuItem,
            this.cOM2ToolStripMenuItem,
            this.cOM3ToolStripMenuItem,
            this.cOM4ToolStripMenuItem,
            this.cOM5ToolStripMenuItem,
            this.cOM6ToolStripMenuItem,
            this.cOM7ToolStripMenuItem,
            this.cOM8ToolStripMenuItem});
            this.cOMPortsToolStripMenuItem.Name = "cOMPortsToolStripMenuItem";
            this.cOMPortsToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.cOMPortsToolStripMenuItem.Text = "COM ports";
            // 
            // cOM1ToolStripMenuItem
            // 
            this.cOM1ToolStripMenuItem.Name = "cOM1ToolStripMenuItem";
            this.cOM1ToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.cOM1ToolStripMenuItem.Text = "COM1";
            this.cOM1ToolStripMenuItem.Click += new System.EventHandler(this.cOM1ToolStripMenuItem_Click);
            // 
            // cOM2ToolStripMenuItem
            // 
            this.cOM2ToolStripMenuItem.Name = "cOM2ToolStripMenuItem";
            this.cOM2ToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.cOM2ToolStripMenuItem.Text = "COM2";
            this.cOM2ToolStripMenuItem.Click += new System.EventHandler(this.cOM2ToolStripMenuItem_Click);
            // 
            // cOM3ToolStripMenuItem
            // 
            this.cOM3ToolStripMenuItem.Name = "cOM3ToolStripMenuItem";
            this.cOM3ToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.cOM3ToolStripMenuItem.Text = "COM3";
            this.cOM3ToolStripMenuItem.Click += new System.EventHandler(this.cOM3ToolStripMenuItem_Click);
            // 
            // cOM4ToolStripMenuItem
            // 
            this.cOM4ToolStripMenuItem.Name = "cOM4ToolStripMenuItem";
            this.cOM4ToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.cOM4ToolStripMenuItem.Text = "COM4";
            this.cOM4ToolStripMenuItem.Click += new System.EventHandler(this.cOM4ToolStripMenuItem_Click);
            // 
            // cOM5ToolStripMenuItem
            // 
            this.cOM5ToolStripMenuItem.Name = "cOM5ToolStripMenuItem";
            this.cOM5ToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.cOM5ToolStripMenuItem.Text = "COM5";
            this.cOM5ToolStripMenuItem.Click += new System.EventHandler(this.cOM5ToolStripMenuItem_Click);
            // 
            // cOM6ToolStripMenuItem
            // 
            this.cOM6ToolStripMenuItem.Name = "cOM6ToolStripMenuItem";
            this.cOM6ToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.cOM6ToolStripMenuItem.Text = "COM6";
            this.cOM6ToolStripMenuItem.Click += new System.EventHandler(this.cOM6ToolStripMenuItem_Click);
            // 
            // cOM7ToolStripMenuItem
            // 
            this.cOM7ToolStripMenuItem.Name = "cOM7ToolStripMenuItem";
            this.cOM7ToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.cOM7ToolStripMenuItem.Text = "COM7";
            this.cOM7ToolStripMenuItem.Click += new System.EventHandler(this.cOM7ToolStripMenuItem_Click);
            // 
            // cOM8ToolStripMenuItem
            // 
            this.cOM8ToolStripMenuItem.Name = "cOM8ToolStripMenuItem";
            this.cOM8ToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.cOM8ToolStripMenuItem.Text = "COM8";
            this.cOM8ToolStripMenuItem.Click += new System.EventHandler(this.cOM8ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bpm_test);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.spo2_test);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(253, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 103);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test values";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "BPM : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "SpO2(%) : ";
            // 
            // spo2_req
            // 
            this.spo2_req.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spo2_req.Location = new System.Drawing.Point(146, 21);
            this.spo2_req.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.spo2_req.Name = "spo2_req";
            this.spo2_req.Size = new System.Drawing.Size(71, 38);
            this.spo2_req.TabIndex = 11;
            // 
            // bpm_req
            // 
            this.bpm_req.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bpm_req.Location = new System.Drawing.Point(146, 65);
            this.bpm_req.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.bpm_req.Name = "bpm_req";
            this.bpm_req.Size = new System.Drawing.Size(71, 38);
            this.bpm_req.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 32);
            this.label7.TabIndex = 4;
            this.label7.Text = "PI(%) : ";
            // 
            // pi_req
            // 
            this.pi_req.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pi_req.Location = new System.Drawing.Point(146, 109);
            this.pi_req.Name = "pi_req";
            this.pi_req.Size = new System.Drawing.Size(71, 38);
            this.pi_req.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pi_req);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.bpm_req);
            this.groupBox2.Controls.Add(this.spo2_req);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 155);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Required Values";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PLGraph);
            this.groupBox3.Location = new System.Drawing.Point(500, 72);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(759, 605);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Plythsmograph";
            // 
            // PLGraph
            // 
            chartArea2.AxisX.Interval = 50D;
            chartArea2.AxisX.IsStartedFromZero = false;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.MajorGrid.LineWidth = 0;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.Name = "ChartArea1";
            this.PLGraph.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.PLGraph.Legends.Add(legend2);
            this.PLGraph.Location = new System.Drawing.Point(17, 21);
            this.PLGraph.Name = "PLGraph";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.PLGraph.Series.Add(series2);
            this.PLGraph.Size = new System.Drawing.Size(723, 562);
            this.PLGraph.TabIndex = 0;
            this.PLGraph.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // OK
            // 
            this.OK.AutoSize = true;
            this.OK.BackColor = System.Drawing.Color.Yellow;
            this.OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK.Location = new System.Drawing.Point(192, 344);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(222, 38);
            this.OK.TabIndex = 17;
            this.OK.Text = " NO BOARD ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 38);
            this.label8.TabIndex = 18;
            this.label8.Text = "STATUS : ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // pulse_om
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 689);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "pulse_om";
            this.Text = "Pulse Oximeter";
            this.Load += new System.EventHandler(this.pulse_om_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spo2_req)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpm_req)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi_req)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PLGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label spo2_test;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label bpm_test;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cOMPortsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOM1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOM2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOM3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOM4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOM5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOM6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOM7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOM8ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown spo2_req;
        private System.Windows.Forms.NumericUpDown bpm_req;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown pi_req;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart PLGraph;
        private System.Windows.Forms.Label OK;
        private System.Windows.Forms.Label label8;
    }
}

