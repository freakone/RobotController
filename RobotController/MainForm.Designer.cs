namespace RobotController
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ądzeniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajRęcznieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlFunctions = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageWykres = new System.Windows.Forms.TabPage();
            this.checkBoxChart = new System.Windows.Forms.CheckBox();
            this.button6 = new System.Windows.Forms.Button();
            this.listBoxChartSeries = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxChannelY = new System.Windows.Forms.ComboBox();
            this.comboBoxChannelX = new System.Windows.Forms.ComboBox();
            this.textBoxSeriesName = new System.Windows.Forms.TextBox();
            this.btnChartAddSeries = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDeviceX = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxDeviceY = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.zapiszWykresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPageCurrent = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.checkBoxAnalog1 = new System.Windows.Forms.CheckBox();
            this.comboBoxAnalog1Channel = new System.Windows.Forms.ComboBox();
            this.comboBoxAnalog1Device = new System.Windows.Forms.ComboBox();
            this.checkBoxAnalog2 = new System.Windows.Forms.CheckBox();
            this.comboBoxAnalog2Channel = new System.Windows.Forms.ComboBox();
            this.comboBoxAnalog2Device = new System.Windows.Forms.ComboBox();
            this.checkBoxADCTable = new System.Windows.Forms.CheckBox();
            this.comboBoxADCValuesChannel = new System.Windows.Forms.ComboBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBoxADCValuesDevice = new System.Windows.Forms.ComboBox();
            this.listViewCurrentValues = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageUstawienia = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownADCRefresh = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button8 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.trackBarMotorSpeed = new System.Windows.Forms.TrackBar();
            this.comboBoxMotorChannel = new System.Windows.Forms.ComboBox();
            this.comboBoxMotorDevice = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkedListBoxGPIOWrite = new System.Windows.Forms.CheckedListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkedListBoxGIPORead = new System.Windows.Forms.CheckedListBox();
            this.comboBoxGPIOChannel = new System.Windows.Forms.ComboBox();
            this.comboBoxGPIODevice = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.treeViewDevices = new System.Windows.Forms.TreeView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.labelMotorVal = new System.Windows.Forms.Label();
            this.analogMeter1 = new Instruments.AnalogMeter();
            this.analogMeter2 = new Instruments.AnalogMeter();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownADCSamples = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            this.tabControlFunctions.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageWykres.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPageCurrent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tabPageUstawienia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownADCRefresh)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMotorSpeed)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownADCSamples)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ądzeniaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(826, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ądzeniaToolStripMenuItem
            // 
            this.ądzeniaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajRęcznieToolStripMenuItem});
            this.ądzeniaToolStripMenuItem.Name = "ądzeniaToolStripMenuItem";
            this.ądzeniaToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.ądzeniaToolStripMenuItem.Text = "Urządzenia";
            // 
            // dodajRęcznieToolStripMenuItem
            // 
            this.dodajRęcznieToolStripMenuItem.Name = "dodajRęcznieToolStripMenuItem";
            this.dodajRęcznieToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.dodajRęcznieToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.dodajRęcznieToolStripMenuItem.Text = "Skanuj";
            this.dodajRęcznieToolStripMenuItem.Click += new System.EventHandler(this.dodajRęcznieToolStripMenuItem_Click);
            // 
            // tabControlFunctions
            // 
            this.tabControlFunctions.Controls.Add(this.tabPage1);
            this.tabControlFunctions.Controls.Add(this.tabPage2);
            this.tabControlFunctions.Controls.Add(this.tabPage3);
            this.tabControlFunctions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlFunctions.Location = new System.Drawing.Point(0, 0);
            this.tabControlFunctions.Multiline = true;
            this.tabControlFunctions.Name = "tabControlFunctions";
            this.tabControlFunctions.SelectedIndex = 0;
            this.tabControlFunctions.Size = new System.Drawing.Size(672, 483);
            this.tabControlFunctions.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(664, 457);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ADC";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPageWykres);
            this.tabControl1.Controls.Add(this.tabPageCurrent);
            this.tabControl1.Controls.Add(this.tabPageUstawienia);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(658, 451);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageWykres
            // 
            this.tabPageWykres.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageWykres.Controls.Add(this.checkBoxChart);
            this.tabPageWykres.Controls.Add(this.button6);
            this.tabPageWykres.Controls.Add(this.listBoxChartSeries);
            this.tabPageWykres.Controls.Add(this.groupBox1);
            this.tabPageWykres.Controls.Add(this.chart1);
            this.tabPageWykres.Controls.Add(this.button3);
            this.tabPageWykres.Controls.Add(this.button1);
            this.tabPageWykres.Location = new System.Drawing.Point(4, 4);
            this.tabPageWykres.Name = "tabPageWykres";
            this.tabPageWykres.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWykres.Size = new System.Drawing.Size(650, 425);
            this.tabPageWykres.TabIndex = 1;
            this.tabPageWykres.Text = "Wykresy";
            // 
            // checkBoxChart
            // 
            this.checkBoxChart.AutoSize = true;
            this.checkBoxChart.Location = new System.Drawing.Point(88, 401);
            this.checkBoxChart.Name = "checkBoxChart";
            this.checkBoxChart.Size = new System.Drawing.Size(58, 17);
            this.checkBoxChart.TabIndex = 15;
            this.checkBoxChart.Text = "Pomiar";
            this.checkBoxChart.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(509, 385);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 14;
            this.button6.Text = "Usuń serię";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // listBoxChartSeries
            // 
            this.listBoxChartSeries.FormattingEnabled = true;
            this.listBoxChartSeries.Location = new System.Drawing.Point(421, 284);
            this.listBoxChartSeries.Name = "listBoxChartSeries";
            this.listBoxChartSeries.Size = new System.Drawing.Size(163, 95);
            this.listBoxChartSeries.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxChannelY);
            this.groupBox1.Controls.Add(this.comboBoxChannelX);
            this.groupBox1.Controls.Add(this.textBoxSeriesName);
            this.groupBox1.Controls.Add(this.btnChartAddSeries);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxDeviceX);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxDeviceY);
            this.groupBox1.Location = new System.Drawing.Point(6, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 106);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj serię danych";
            // 
            // comboBoxChannelY
            // 
            this.comboBoxChannelY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChannelY.FormattingEnabled = true;
            this.comboBoxChannelY.Location = new System.Drawing.Point(184, 44);
            this.comboBoxChannelY.Name = "comboBoxChannelY";
            this.comboBoxChannelY.Size = new System.Drawing.Size(121, 21);
            this.comboBoxChannelY.TabIndex = 14;
            // 
            // comboBoxChannelX
            // 
            this.comboBoxChannelX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChannelX.FormattingEnabled = true;
            this.comboBoxChannelX.Location = new System.Drawing.Point(184, 20);
            this.comboBoxChannelX.Name = "comboBoxChannelX";
            this.comboBoxChannelX.Size = new System.Drawing.Size(121, 21);
            this.comboBoxChannelX.TabIndex = 13;
            // 
            // textBoxSeriesName
            // 
            this.textBoxSeriesName.Location = new System.Drawing.Point(9, 73);
            this.textBoxSeriesName.Name = "textBoxSeriesName";
            this.textBoxSeriesName.Size = new System.Drawing.Size(217, 20);
            this.textBoxSeriesName.TabIndex = 12;
            // 
            // btnChartAddSeries
            // 
            this.btnChartAddSeries.Location = new System.Drawing.Point(232, 71);
            this.btnChartAddSeries.Name = "btnChartAddSeries";
            this.btnChartAddSeries.Size = new System.Drawing.Size(75, 23);
            this.btnChartAddSeries.TabIndex = 11;
            this.btnChartAddSeries.Text = "Dodaj";
            this.btnChartAddSeries.UseVisualStyleBackColor = true;
            this.btnChartAddSeries.Click += new System.EventHandler(this.btnChartAddSeries_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Oś x";
            // 
            // comboBoxDeviceX
            // 
            this.comboBoxDeviceX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDeviceX.FormattingEnabled = true;
            this.comboBoxDeviceX.Location = new System.Drawing.Point(57, 20);
            this.comboBoxDeviceX.Name = "comboBoxDeviceX";
            this.comboBoxDeviceX.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDeviceX.TabIndex = 2;
            this.comboBoxDeviceX.SelectedIndexChanged += new System.EventHandler(this.comboBoxDeviceX_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Oś y";
            // 
            // comboBoxDeviceY
            // 
            this.comboBoxDeviceY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDeviceY.FormattingEnabled = true;
            this.comboBoxDeviceY.Location = new System.Drawing.Point(57, 44);
            this.comboBoxDeviceY.Name = "comboBoxDeviceY";
            this.comboBoxDeviceY.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDeviceY.TabIndex = 3;
            this.comboBoxDeviceY.SelectedIndexChanged += new System.EventHandler(this.comboBoxDeviceY_SelectedIndexChanged);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.ContextMenuStrip = this.contextMenuStrip1;
            this.chart1.Dock = System.Windows.Forms.DockStyle.Top;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(644, 264);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            this.chart1.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapiszWykresToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(147, 26);
            // 
            // zapiszWykresToolStripMenuItem
            // 
            this.zapiszWykresToolStripMenuItem.Name = "zapiszWykresToolStripMenuItem";
            this.zapiszWykresToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.zapiszWykresToolStripMenuItem.Text = "Zapisz wykres";
            this.zapiszWykresToolStripMenuItem.Click += new System.EventHandler(this.zapiszWykresToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(421, 385);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Zapisz serię";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Wyczyść";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPageCurrent
            // 
            this.tabPageCurrent.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageCurrent.Controls.Add(this.splitContainer2);
            this.tabPageCurrent.Location = new System.Drawing.Point(4, 4);
            this.tabPageCurrent.Name = "tabPageCurrent";
            this.tabPageCurrent.Size = new System.Drawing.Size(650, 425);
            this.tabPageCurrent.TabIndex = 2;
            this.tabPageCurrent.Text = "Wartość chwilowa";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.checkBoxADCTable);
            this.splitContainer2.Panel2.Controls.Add(this.comboBoxADCValuesChannel);
            this.splitContainer2.Panel2.Controls.Add(this.button7);
            this.splitContainer2.Panel2.Controls.Add(this.button4);
            this.splitContainer2.Panel2.Controls.Add(this.comboBoxADCValuesDevice);
            this.splitContainer2.Panel2.Controls.Add(this.listViewCurrentValues);
            this.splitContainer2.Size = new System.Drawing.Size(650, 425);
            this.splitContainer2.SplitterDistance = 170;
            this.splitContainer2.TabIndex = 2;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.checkBoxAnalog1);
            this.splitContainer3.Panel1.Controls.Add(this.comboBoxAnalog1Channel);
            this.splitContainer3.Panel1.Controls.Add(this.comboBoxAnalog1Device);
            this.splitContainer3.Panel1.Controls.Add(this.analogMeter1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.checkBoxAnalog2);
            this.splitContainer3.Panel2.Controls.Add(this.comboBoxAnalog2Channel);
            this.splitContainer3.Panel2.Controls.Add(this.comboBoxAnalog2Device);
            this.splitContainer3.Panel2.Controls.Add(this.analogMeter2);
            this.splitContainer3.Size = new System.Drawing.Size(650, 170);
            this.splitContainer3.SplitterDistance = 325;
            this.splitContainer3.TabIndex = 0;
            // 
            // checkBoxAnalog1
            // 
            this.checkBoxAnalog1.AutoSize = true;
            this.checkBoxAnalog1.Location = new System.Drawing.Point(292, 152);
            this.checkBoxAnalog1.Name = "checkBoxAnalog1";
            this.checkBoxAnalog1.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAnalog1.TabIndex = 3;
            this.checkBoxAnalog1.UseVisualStyleBackColor = true;
            // 
            // comboBoxAnalog1Channel
            // 
            this.comboBoxAnalog1Channel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAnalog1Channel.FormattingEnabled = true;
            this.comboBoxAnalog1Channel.Location = new System.Drawing.Point(146, 149);
            this.comboBoxAnalog1Channel.Name = "comboBoxAnalog1Channel";
            this.comboBoxAnalog1Channel.Size = new System.Drawing.Size(140, 21);
            this.comboBoxAnalog1Channel.TabIndex = 2;
            this.comboBoxAnalog1Channel.SelectedIndexChanged += new System.EventHandler(this.comboBoxAnalog1Channel_SelectedIndexChanged);
            // 
            // comboBoxAnalog1Device
            // 
            this.comboBoxAnalog1Device.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAnalog1Device.FormattingEnabled = true;
            this.comboBoxAnalog1Device.Location = new System.Drawing.Point(0, 149);
            this.comboBoxAnalog1Device.Name = "comboBoxAnalog1Device";
            this.comboBoxAnalog1Device.Size = new System.Drawing.Size(140, 21);
            this.comboBoxAnalog1Device.TabIndex = 1;
            this.comboBoxAnalog1Device.SelectedIndexChanged += new System.EventHandler(this.comboBoxAnalog1Device_SelectedIndexChanged);
            // 
            // checkBoxAnalog2
            // 
            this.checkBoxAnalog2.AutoSize = true;
            this.checkBoxAnalog2.Location = new System.Drawing.Point(295, 152);
            this.checkBoxAnalog2.Name = "checkBoxAnalog2";
            this.checkBoxAnalog2.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAnalog2.TabIndex = 4;
            this.checkBoxAnalog2.UseVisualStyleBackColor = true;
            // 
            // comboBoxAnalog2Channel
            // 
            this.comboBoxAnalog2Channel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAnalog2Channel.DropDownWidth = 158;
            this.comboBoxAnalog2Channel.FormattingEnabled = true;
            this.comboBoxAnalog2Channel.Location = new System.Drawing.Point(149, 149);
            this.comboBoxAnalog2Channel.Name = "comboBoxAnalog2Channel";
            this.comboBoxAnalog2Channel.Size = new System.Drawing.Size(140, 21);
            this.comboBoxAnalog2Channel.TabIndex = 3;
            this.comboBoxAnalog2Channel.SelectedIndexChanged += new System.EventHandler(this.comboBoxAnalog2Channel_SelectedIndexChanged);
            // 
            // comboBoxAnalog2Device
            // 
            this.comboBoxAnalog2Device.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAnalog2Device.DropDownWidth = 158;
            this.comboBoxAnalog2Device.FormattingEnabled = true;
            this.comboBoxAnalog2Device.Location = new System.Drawing.Point(3, 149);
            this.comboBoxAnalog2Device.Name = "comboBoxAnalog2Device";
            this.comboBoxAnalog2Device.Size = new System.Drawing.Size(140, 21);
            this.comboBoxAnalog2Device.TabIndex = 2;
            this.comboBoxAnalog2Device.SelectedIndexChanged += new System.EventHandler(this.comboBoxAnalog2Device_SelectedIndexChanged);
            // 
            // checkBoxADCTable
            // 
            this.checkBoxADCTable.AutoSize = true;
            this.checkBoxADCTable.Location = new System.Drawing.Point(529, 229);
            this.checkBoxADCTable.Name = "checkBoxADCTable";
            this.checkBoxADCTable.Size = new System.Drawing.Size(58, 17);
            this.checkBoxADCTable.TabIndex = 5;
            this.checkBoxADCTable.Text = "Pomiar";
            this.checkBoxADCTable.UseVisualStyleBackColor = true;
            // 
            // comboBoxADCValuesChannel
            // 
            this.comboBoxADCValuesChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxADCValuesChannel.FormattingEnabled = true;
            this.comboBoxADCValuesChannel.Location = new System.Drawing.Point(198, 227);
            this.comboBoxADCValuesChannel.Name = "comboBoxADCValuesChannel";
            this.comboBoxADCValuesChannel.Size = new System.Drawing.Size(163, 21);
            this.comboBoxADCValuesChannel.TabIndex = 4;
            this.comboBoxADCValuesChannel.SelectedIndexChanged += new System.EventHandler(this.comboBoxADCValuesChannel_SelectedIndexChanged);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(448, 225);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 3;
            this.button7.Text = "Usuń";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(367, 225);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Dodaj";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBoxADCValuesDevice
            // 
            this.comboBoxADCValuesDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxADCValuesDevice.FormattingEnabled = true;
            this.comboBoxADCValuesDevice.Location = new System.Drawing.Point(3, 227);
            this.comboBoxADCValuesDevice.Name = "comboBoxADCValuesDevice";
            this.comboBoxADCValuesDevice.Size = new System.Drawing.Size(189, 21);
            this.comboBoxADCValuesDevice.TabIndex = 1;
            this.comboBoxADCValuesDevice.SelectedIndexChanged += new System.EventHandler(this.comboBoxADCValuesDevice_SelectedIndexChanged);
            // 
            // listViewCurrentValues
            // 
            this.listViewCurrentValues.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewCurrentValues.Dock = System.Windows.Forms.DockStyle.Top;
            this.listViewCurrentValues.FullRowSelect = true;
            this.listViewCurrentValues.Location = new System.Drawing.Point(0, 0);
            this.listViewCurrentValues.Name = "listViewCurrentValues";
            this.listViewCurrentValues.Size = new System.Drawing.Size(650, 219);
            this.listViewCurrentValues.TabIndex = 0;
            this.listViewCurrentValues.UseCompatibleStateImageBehavior = false;
            this.listViewCurrentValues.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kanał";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Wartość";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Wartość przeliczona";
            this.columnHeader3.Width = 100;
            // 
            // tabPageUstawienia
            // 
            this.tabPageUstawienia.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageUstawienia.Controls.Add(this.label8);
            this.tabPageUstawienia.Controls.Add(this.numericUpDownADCSamples);
            this.tabPageUstawienia.Controls.Add(this.textBox1);
            this.tabPageUstawienia.Controls.Add(this.label4);
            this.tabPageUstawienia.Controls.Add(this.label1);
            this.tabPageUstawienia.Controls.Add(this.numericUpDownADCRefresh);
            this.tabPageUstawienia.Location = new System.Drawing.Point(4, 4);
            this.tabPageUstawienia.Name = "tabPageUstawienia";
            this.tabPageUstawienia.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUstawienia.Size = new System.Drawing.Size(650, 425);
            this.tabPageUstawienia.TabIndex = 0;
            this.tabPageUstawienia.Text = "Ustawienia";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Przeliczanie wartości";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Częstość odświeżania";
            // 
            // numericUpDownADCRefresh
            // 
            this.numericUpDownADCRefresh.Location = new System.Drawing.Point(137, 17);
            this.numericUpDownADCRefresh.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownADCRefresh.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownADCRefresh.Name = "numericUpDownADCRefresh";
            this.numericUpDownADCRefresh.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownADCRefresh.TabIndex = 0;
            this.numericUpDownADCRefresh.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownADCRefresh.ValueChanged += new System.EventHandler(this.numericUpDownADCRefresh_ValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelMotorVal);
            this.tabPage2.Controls.Add(this.button10);
            this.tabPage2.Controls.Add(this.button9);
            this.tabPage2.Controls.Add(this.numericUpDown3);
            this.tabPage2.Controls.Add(this.numericUpDown2);
            this.tabPage2.Controls.Add(this.numericUpDown1);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.trackBarMotorSpeed);
            this.tabPage2.Controls.Add(this.comboBoxMotorChannel);
            this.tabPage2.Controls.Add(this.comboBoxMotorDevice);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(664, 457);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Motor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(605, 73);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(31, 23);
            this.button10.TabIndex = 20;
            this.button10.Text = "-";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(562, 73);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(31, 23);
            this.button9.TabIndex = 19;
            this.button9.Text = "+";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(168, 149);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown3.TabIndex = 18;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(315, 149);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 17;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(26, 150);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 16;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(561, 146);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 15;
            this.button8.Text = "Ustaw";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(294, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "D";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "I";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "P";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 428);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(484, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(71, 74);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 44);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(41, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Tył";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Przód";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(561, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Ustaw";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // trackBarMotorSpeed
            // 
            this.trackBarMotorSpeed.Location = new System.Drawing.Point(6, 52);
            this.trackBarMotorSpeed.Name = "trackBarMotorSpeed";
            this.trackBarMotorSpeed.Size = new System.Drawing.Size(429, 45);
            this.trackBarMotorSpeed.TabIndex = 5;
            this.trackBarMotorSpeed.ValueChanged += new System.EventHandler(this.trackBarMotorSpeed_ValueChanged);
            // 
            // comboBoxMotorChannel
            // 
            this.comboBoxMotorChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMotorChannel.FormattingEnabled = true;
            this.comboBoxMotorChannel.Location = new System.Drawing.Point(348, 6);
            this.comboBoxMotorChannel.Name = "comboBoxMotorChannel";
            this.comboBoxMotorChannel.Size = new System.Drawing.Size(308, 21);
            this.comboBoxMotorChannel.TabIndex = 4;
            this.comboBoxMotorChannel.SelectedIndexChanged += new System.EventHandler(this.comboBoxMotorChannel_SelectedIndexChanged);
            // 
            // comboBoxMotorDevice
            // 
            this.comboBoxMotorDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMotorDevice.FormattingEnabled = true;
            this.comboBoxMotorDevice.Location = new System.Drawing.Point(6, 6);
            this.comboBoxMotorDevice.Name = "comboBoxMotorDevice";
            this.comboBoxMotorDevice.Size = new System.Drawing.Size(336, 21);
            this.comboBoxMotorDevice.TabIndex = 3;
            this.comboBoxMotorDevice.SelectedIndexChanged += new System.EventHandler(this.comboBoxMotorDevice_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.comboBoxGPIOChannel);
            this.tabPage3.Controls.Add(this.comboBoxGPIODevice);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(664, 457);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "GPIO";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkedListBoxGPIOWrite);
            this.groupBox4.Location = new System.Drawing.Point(348, 48);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(308, 336);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Zapis";
            // 
            // checkedListBoxGPIOWrite
            // 
            this.checkedListBoxGPIOWrite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxGPIOWrite.FormattingEnabled = true;
            this.checkedListBoxGPIOWrite.Location = new System.Drawing.Point(3, 16);
            this.checkedListBoxGPIOWrite.Name = "checkedListBoxGPIOWrite";
            this.checkedListBoxGPIOWrite.Size = new System.Drawing.Size(302, 317);
            this.checkedListBoxGPIOWrite.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkedListBoxGIPORead);
            this.groupBox3.Location = new System.Drawing.Point(6, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(304, 336);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Odczyt";
            // 
            // checkedListBoxGIPORead
            // 
            this.checkedListBoxGIPORead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxGIPORead.FormattingEnabled = true;
            this.checkedListBoxGIPORead.Location = new System.Drawing.Point(3, 16);
            this.checkedListBoxGIPORead.Name = "checkedListBoxGIPORead";
            this.checkedListBoxGIPORead.Size = new System.Drawing.Size(298, 317);
            this.checkedListBoxGIPORead.TabIndex = 7;
            // 
            // comboBoxGPIOChannel
            // 
            this.comboBoxGPIOChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGPIOChannel.FormattingEnabled = true;
            this.comboBoxGPIOChannel.Location = new System.Drawing.Point(348, 3);
            this.comboBoxGPIOChannel.Name = "comboBoxGPIOChannel";
            this.comboBoxGPIOChannel.Size = new System.Drawing.Size(308, 21);
            this.comboBoxGPIOChannel.TabIndex = 6;
            // 
            // comboBoxGPIODevice
            // 
            this.comboBoxGPIODevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGPIODevice.FormattingEnabled = true;
            this.comboBoxGPIODevice.Location = new System.Drawing.Point(6, 3);
            this.comboBoxGPIODevice.Name = "comboBoxGPIODevice";
            this.comboBoxGPIODevice.Size = new System.Drawing.Size(301, 21);
            this.comboBoxGPIODevice.TabIndex = 5;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 507);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(826, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Step = 1;
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // treeViewDevices
            // 
            this.treeViewDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewDevices.Location = new System.Drawing.Point(0, 0);
            this.treeViewDevices.Name = "treeViewDevices";
            this.treeViewDevices.Size = new System.Drawing.Size(150, 483);
            this.treeViewDevices.TabIndex = 5;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeViewDevices);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControlFunctions);
            this.splitContainer1.Size = new System.Drawing.Size(826, 483);
            this.splitContainer1.SplitterDistance = 150;
            this.splitContainer1.TabIndex = 6;
            // 
            // labelMotorVal
            // 
            this.labelMotorVal.AutoSize = true;
            this.labelMotorVal.Location = new System.Drawing.Point(445, 67);
            this.labelMotorVal.Name = "labelMotorVal";
            this.labelMotorVal.Size = new System.Drawing.Size(13, 13);
            this.labelMotorVal.TabIndex = 21;
            this.labelMotorVal.Text = "0";
            // 
            // analogMeter1
            // 
            this.analogMeter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.analogMeter1.FrameColor = System.Drawing.Color.Black;
            this.analogMeter1.FramePadding = new System.Windows.Forms.Padding(5);
            this.analogMeter1.InternalPadding = new System.Windows.Forms.Padding(5);
            this.analogMeter1.Location = new System.Drawing.Point(0, 0);
            this.analogMeter1.MaxValue = 15F;
            this.analogMeter1.MinValue = 0F;
            this.analogMeter1.Name = "analogMeter1";
            this.analogMeter1.Size = new System.Drawing.Size(325, 173);
            this.analogMeter1.Stretch = true;
            this.analogMeter1.TabIndex = 0;
            this.analogMeter1.Text = "analogMeter1";
            this.analogMeter1.TickStartAngle = 20F;
            this.analogMeter1.Value = 3F;
            // 
            // analogMeter2
            // 
            this.analogMeter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.analogMeter2.FrameColor = System.Drawing.Color.Black;
            this.analogMeter2.FramePadding = new System.Windows.Forms.Padding(5);
            this.analogMeter2.InternalPadding = new System.Windows.Forms.Padding(5);
            this.analogMeter2.Location = new System.Drawing.Point(0, 0);
            this.analogMeter2.MaxValue = 15F;
            this.analogMeter2.MinValue = 0F;
            this.analogMeter2.Name = "analogMeter2";
            this.analogMeter2.Size = new System.Drawing.Size(321, 173);
            this.analogMeter2.TabIndex = 1;
            this.analogMeter2.Text = "analogMeter2";
            this.analogMeter2.TickStartAngle = 20F;
            this.analogMeter2.Value = 0F;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Ilość próbek na wykresie";
            // 
            // numericUpDownADCSamples
            // 
            this.numericUpDownADCSamples.Location = new System.Drawing.Point(137, 42);
            this.numericUpDownADCSamples.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownADCSamples.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownADCSamples.Name = "numericUpDownADCSamples";
            this.numericUpDownADCSamples.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownADCSamples.TabIndex = 4;
            this.numericUpDownADCSamples.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownADCSamples.ValueChanged += new System.EventHandler(this.numericUpDownADCSamples_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 529);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControlFunctions.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageWykres.ResumeLayout(false);
            this.tabPageWykres.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPageCurrent.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tabPageUstawienia.ResumeLayout(false);
            this.tabPageUstawienia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownADCRefresh)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMotorSpeed)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownADCSamples)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ądzeniaToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlFunctions;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TreeView treeViewDevices;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageUstawienia;
        private System.Windows.Forms.TabPage tabPageWykres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxDeviceY;
        private System.Windows.Forms.ComboBox comboBoxDeviceX;
        private System.Windows.Forms.TabPage tabPageCurrent;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ListBox listBoxChartSeries;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxSeriesName;
        private System.Windows.Forms.Button btnChartAddSeries;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zapiszWykresToolStripMenuItem;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.ComboBox comboBoxAnalog1Device;
        private Instruments.AnalogMeter analogMeter1;
        private System.Windows.Forms.ComboBox comboBoxAnalog2Device;
        private Instruments.AnalogMeter analogMeter2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBoxADCValuesDevice;
        private System.Windows.Forms.ListView listViewCurrentValues;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem dodajRęcznieToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ComboBox comboBoxChannelX;
        private System.Windows.Forms.ComboBox comboBoxChannelY;
        private System.Windows.Forms.ComboBox comboBoxAnalog1Channel;
        private System.Windows.Forms.ComboBox comboBoxAnalog2Channel;
        private System.Windows.Forms.ComboBox comboBoxADCValuesChannel;
        private System.Windows.Forms.CheckBox checkBoxChart;
        private System.Windows.Forms.CheckBox checkBoxAnalog1;
        private System.Windows.Forms.CheckBox checkBoxAnalog2;
        private System.Windows.Forms.CheckBox checkBoxADCTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownADCRefresh;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TrackBar trackBarMotorSpeed;
        private System.Windows.Forms.ComboBox comboBoxMotorChannel;
        private System.Windows.Forms.ComboBox comboBoxMotorDevice;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckedListBox checkedListBoxGPIOWrite;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckedListBox checkedListBoxGIPORead;
        private System.Windows.Forms.ComboBox comboBoxGPIOChannel;
        private System.Windows.Forms.ComboBox comboBoxGPIODevice;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label labelMotorVal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownADCSamples;
    }
}

