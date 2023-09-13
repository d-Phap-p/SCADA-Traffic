namespace SCADAdengiaothong
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Agreen = new SymbolFactoryDotNet.StandardControl();
            this.RunSystem = new SymbolFactoryDotNet.StandardControl();
            this.buttonRUN = new System.Windows.Forms.Button();
            this.buttonSTOP = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Ayellow = new SymbolFactoryDotNet.StandardControl();
            this.Ared = new SymbolFactoryDotNet.StandardControl();
            this.Bgreen = new SymbolFactoryDotNet.StandardControl();
            this.Byellow = new SymbolFactoryDotNet.StandardControl();
            this.Bred = new SymbolFactoryDotNet.StandardControl();
            this.AgIO = new System.Windows.Forms.Label();
            this.AyIO = new System.Windows.Forms.Label();
            this.ArIO = new System.Windows.Forms.Label();
            this.BgIO = new System.Windows.Forms.Label();
            this.ByIO = new System.Windows.Forms.Label();
            this.BrIO = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CONTROLbox = new System.Windows.Forms.GroupBox();
            this.GettoHMI = new SymbolFactoryDotNet.StandardControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CHANGE = new System.Windows.Forms.GroupBox();
            this.SAVE = new System.Windows.Forms.Button();
            this.REDtext = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.YELLOWtext = new System.Windows.Forms.TextBox();
            this.GREENtext = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DateTimetxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Agreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RunSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ayellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ared)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bgreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Byellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bred)).BeginInit();
            this.CONTROLbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GettoHMI)).BeginInit();
            this.CHANGE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Agreen
            // 
            this.Agreen.AnalogIntValue1 = ((short)(0));
            this.Agreen.AnalogValue1 = 0D;
            this.Agreen.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill;
            this.Agreen.BackColor = System.Drawing.Color.Transparent;
            this.Agreen.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.Agreen.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Lime, "Band1"));
            this.Agreen.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.White, "Band2"));
            this.Agreen.BlinkColor = System.Drawing.Color.Red;
            this.Agreen.Category = "1Btn.cat2";
            this.Agreen.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("Agreen.DebugData"));
            this.Agreen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Agreen.Location = new System.Drawing.Point(365, 60);
            this.Agreen.Margin = new System.Windows.Forms.Padding(4);
            this.Agreen.Name = "Agreen";
            this.Agreen.Size = new System.Drawing.Size(93, 86);
            this.Agreen.SymbolHandle = ((long)(281886359));
            this.Agreen.TabIndex = 0;
            // 
            // RunSystem
            // 
            this.RunSystem.AnalogIntValue1 = ((short)(0));
            this.RunSystem.AnalogValue1 = 0D;
            this.RunSystem.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill;
            this.RunSystem.BackColor = System.Drawing.Color.Transparent;
            this.RunSystem.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.RunSystem.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Lime, "Band1"));
            this.RunSystem.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.White, "Band2"));
            this.RunSystem.BlinkColor = System.Drawing.Color.Red;
            this.RunSystem.Category = "1Btn.cat2";
            this.RunSystem.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("RunSystem.DebugData"));
            this.RunSystem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RunSystem.Location = new System.Drawing.Point(187, 149);
            this.RunSystem.Margin = new System.Windows.Forms.Padding(4);
            this.RunSystem.Name = "RunSystem";
            this.RunSystem.Size = new System.Drawing.Size(37, 34);
            this.RunSystem.SymbolHandle = ((long)(842488176));
            this.RunSystem.TabIndex = 0;
            // 
            // buttonRUN
            // 
            this.buttonRUN.BackColor = System.Drawing.SystemColors.Info;
            this.buttonRUN.Location = new System.Drawing.Point(47, 26);
            this.buttonRUN.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRUN.Name = "buttonRUN";
            this.buttonRUN.Size = new System.Drawing.Size(80, 49);
            this.buttonRUN.TabIndex = 1;
            this.buttonRUN.Text = "RUN";
            this.buttonRUN.UseVisualStyleBackColor = false;
            this.buttonRUN.Click += new System.EventHandler(this.buttonRUN_Click);
            // 
            // buttonSTOP
            // 
            this.buttonSTOP.BackColor = System.Drawing.Color.Red;
            this.buttonSTOP.Location = new System.Drawing.Point(149, 26);
            this.buttonSTOP.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSTOP.Name = "buttonSTOP";
            this.buttonSTOP.Size = new System.Drawing.Size(80, 49);
            this.buttonSTOP.TabIndex = 2;
            this.buttonSTOP.Text = "STOP";
            this.buttonSTOP.UseVisualStyleBackColor = false;
            this.buttonSTOP.Click += new System.EventHandler(this.buttonSTOP_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Ayellow
            // 
            this.Ayellow.AnalogIntValue1 = ((short)(0));
            this.Ayellow.AnalogValue1 = 0D;
            this.Ayellow.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill;
            this.Ayellow.BackColor = System.Drawing.Color.Transparent;
            this.Ayellow.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.Ayellow.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Yellow, "Band1"));
            this.Ayellow.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Silver, "Band2"));
            this.Ayellow.BlinkColor = System.Drawing.Color.Red;
            this.Ayellow.Category = "1Btn.cat2";
            this.Ayellow.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("Ayellow.DebugData"));
            this.Ayellow.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Ayellow.Location = new System.Drawing.Point(491, 60);
            this.Ayellow.Margin = new System.Windows.Forms.Padding(4);
            this.Ayellow.Name = "Ayellow";
            this.Ayellow.Size = new System.Drawing.Size(93, 86);
            this.Ayellow.SymbolHandle = ((long)(385312081));
            this.Ayellow.TabIndex = 3;
            // 
            // Ared
            // 
            this.Ared.AnalogIntValue1 = ((short)(0));
            this.Ared.AnalogValue1 = 0D;
            this.Ared.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill;
            this.Ared.BackColor = System.Drawing.Color.Transparent;
            this.Ared.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.Ared.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band1"));
            this.Ared.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.White, "Band2"));
            this.Ared.BlinkColor = System.Drawing.Color.Red;
            this.Ared.Category = "1Btn.cat2";
            this.Ared.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("Ared.DebugData"));
            this.Ared.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Ared.Location = new System.Drawing.Point(616, 60);
            this.Ared.Margin = new System.Windows.Forms.Padding(4);
            this.Ared.Name = "Ared";
            this.Ared.Size = new System.Drawing.Size(93, 86);
            this.Ared.SymbolHandle = ((long)(1204098846));
            this.Ared.TabIndex = 4;
            // 
            // Bgreen
            // 
            this.Bgreen.AnalogIntValue1 = ((short)(0));
            this.Bgreen.AnalogValue1 = 0D;
            this.Bgreen.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill;
            this.Bgreen.BackColor = System.Drawing.Color.Transparent;
            this.Bgreen.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.Bgreen.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Lime, "Band1"));
            this.Bgreen.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.White, "Band2"));
            this.Bgreen.BlinkColor = System.Drawing.Color.Red;
            this.Bgreen.Category = "1Btn.cat2";
            this.Bgreen.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("Bgreen.DebugData"));
            this.Bgreen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Bgreen.Location = new System.Drawing.Point(365, 334);
            this.Bgreen.Margin = new System.Windows.Forms.Padding(4);
            this.Bgreen.Name = "Bgreen";
            this.Bgreen.Size = new System.Drawing.Size(93, 86);
            this.Bgreen.SymbolHandle = ((long)(281886359));
            this.Bgreen.TabIndex = 0;
            // 
            // Byellow
            // 
            this.Byellow.AnalogIntValue1 = ((short)(0));
            this.Byellow.AnalogValue1 = 0D;
            this.Byellow.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill;
            this.Byellow.BackColor = System.Drawing.Color.Transparent;
            this.Byellow.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.Byellow.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Yellow, "Band1"));
            this.Byellow.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Silver, "Band2"));
            this.Byellow.BlinkColor = System.Drawing.Color.Red;
            this.Byellow.Category = "1Btn.cat2";
            this.Byellow.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("Byellow.DebugData"));
            this.Byellow.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Byellow.Location = new System.Drawing.Point(491, 334);
            this.Byellow.Margin = new System.Windows.Forms.Padding(4);
            this.Byellow.Name = "Byellow";
            this.Byellow.Size = new System.Drawing.Size(93, 86);
            this.Byellow.SymbolHandle = ((long)(385312081));
            this.Byellow.TabIndex = 3;
            // 
            // Bred
            // 
            this.Bred.AnalogIntValue1 = ((short)(0));
            this.Bred.AnalogValue1 = 0D;
            this.Bred.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill;
            this.Bred.BackColor = System.Drawing.Color.Transparent;
            this.Bred.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.Bred.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Red, "Band1"));
            this.Bred.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.White, "Band2"));
            this.Bred.BlinkColor = System.Drawing.Color.Red;
            this.Bred.Category = "1Btn.cat2";
            this.Bred.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("Bred.DebugData"));
            this.Bred.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Bred.Location = new System.Drawing.Point(616, 334);
            this.Bred.Margin = new System.Windows.Forms.Padding(4);
            this.Bred.Name = "Bred";
            this.Bred.Size = new System.Drawing.Size(93, 86);
            this.Bred.SymbolHandle = ((long)(1204098846));
            this.Bred.TabIndex = 4;
            // 
            // AgIO
            // 
            this.AgIO.BackColor = System.Drawing.Color.Black;
            this.AgIO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AgIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgIO.ForeColor = System.Drawing.Color.Lime;
            this.AgIO.Location = new System.Drawing.Point(471, 165);
            this.AgIO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AgIO.Name = "AgIO";
            this.AgIO.Size = new System.Drawing.Size(133, 86);
            this.AgIO.TabIndex = 5;
            this.AgIO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AyIO
            // 
            this.AyIO.BackColor = System.Drawing.Color.Black;
            this.AyIO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AyIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AyIO.ForeColor = System.Drawing.Color.Yellow;
            this.AyIO.Location = new System.Drawing.Point(471, 165);
            this.AyIO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AyIO.Name = "AyIO";
            this.AyIO.Size = new System.Drawing.Size(133, 86);
            this.AyIO.TabIndex = 5;
            this.AyIO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ArIO
            // 
            this.ArIO.BackColor = System.Drawing.Color.Black;
            this.ArIO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ArIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArIO.ForeColor = System.Drawing.Color.Red;
            this.ArIO.Location = new System.Drawing.Point(471, 165);
            this.ArIO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ArIO.Name = "ArIO";
            this.ArIO.Size = new System.Drawing.Size(133, 86);
            this.ArIO.TabIndex = 6;
            this.ArIO.Text = "A_RED";
            this.ArIO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BgIO
            // 
            this.BgIO.BackColor = System.Drawing.Color.Black;
            this.BgIO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BgIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BgIO.ForeColor = System.Drawing.Color.Lime;
            this.BgIO.Location = new System.Drawing.Point(471, 439);
            this.BgIO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BgIO.Name = "BgIO";
            this.BgIO.Size = new System.Drawing.Size(133, 86);
            this.BgIO.TabIndex = 5;
            this.BgIO.Text = "B_GREEN";
            this.BgIO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ByIO
            // 
            this.ByIO.BackColor = System.Drawing.Color.Black;
            this.ByIO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ByIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ByIO.ForeColor = System.Drawing.Color.Yellow;
            this.ByIO.Location = new System.Drawing.Point(471, 439);
            this.ByIO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ByIO.Name = "ByIO";
            this.ByIO.Size = new System.Drawing.Size(133, 86);
            this.ByIO.TabIndex = 5;
            this.ByIO.Text = "B_YELLOW";
            this.ByIO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BrIO
            // 
            this.BrIO.BackColor = System.Drawing.Color.Black;
            this.BrIO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BrIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrIO.ForeColor = System.Drawing.Color.Red;
            this.BrIO.Location = new System.Drawing.Point(471, 439);
            this.BrIO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BrIO.Name = "BrIO";
            this.BrIO.Size = new System.Drawing.Size(133, 86);
            this.BrIO.TabIndex = 6;
            this.BrIO.Text = "B_RED";
            this.BrIO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(47, 82);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 57);
            this.button1.TabIndex = 7;
            this.button1.Text = "CHANGE VALUE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(8, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 43);
            this.label1.TabIndex = 8;
            this.label1.Text = "GREEN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CONTROLbox
            // 
            this.CONTROLbox.BackColor = System.Drawing.Color.LightGray;
            this.CONTROLbox.Controls.Add(this.button1);
            this.CONTROLbox.Controls.Add(this.GettoHMI);
            this.CONTROLbox.Controls.Add(this.RunSystem);
            this.CONTROLbox.Controls.Add(this.buttonRUN);
            this.CONTROLbox.Controls.Add(this.buttonSTOP);
            this.CONTROLbox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CONTROLbox.Location = new System.Drawing.Point(33, 134);
            this.CONTROLbox.Margin = new System.Windows.Forms.Padding(4);
            this.CONTROLbox.Name = "CONTROLbox";
            this.CONTROLbox.Padding = new System.Windows.Forms.Padding(4);
            this.CONTROLbox.Size = new System.Drawing.Size(271, 196);
            this.CONTROLbox.TabIndex = 9;
            this.CONTROLbox.TabStop = false;
            this.CONTROLbox.Text = "CONTROL PANEL";
            // 
            // GettoHMI
            // 
            this.GettoHMI.AnalogIntValue1 = ((short)(0));
            this.GettoHMI.AnalogValue1 = 0D;
            this.GettoHMI.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill;
            this.GettoHMI.BackColor = System.Drawing.Color.Transparent;
            this.GettoHMI.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.GettoHMI.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Yellow, "Band1"));
            this.GettoHMI.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.White, "Band2"));
            this.GettoHMI.BlinkColor = System.Drawing.Color.Red;
            this.GettoHMI.Category = "1Btn.cat2";
            this.GettoHMI.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("GettoHMI.DebugData"));
            this.GettoHMI.FillColor = System.Drawing.Color.Yellow;
            this.GettoHMI.Location = new System.Drawing.Point(47, 149);
            this.GettoHMI.Margin = new System.Windows.Forms.Padding(4);
            this.GettoHMI.Name = "GettoHMI";
            this.GettoHMI.Size = new System.Drawing.Size(37, 34);
            this.GettoHMI.SymbolHandle = ((long)(1367219686));
            this.GettoHMI.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(445, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 33);
            this.label2.TabIndex = 10;
            this.label2.Text = "NHÁNH A";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(445, 281);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 33);
            this.label3.TabIndex = 10;
            this.label3.Text = "NHÁNH B";
            // 
            // CHANGE
            // 
            this.CHANGE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CHANGE.Controls.Add(this.SAVE);
            this.CHANGE.Controls.Add(this.REDtext);
            this.CHANGE.Controls.Add(this.label4);
            this.CHANGE.Controls.Add(this.label5);
            this.CHANGE.Controls.Add(this.YELLOWtext);
            this.CHANGE.Controls.Add(this.GREENtext);
            this.CHANGE.Controls.Add(this.label1);
            this.CHANGE.Controls.Add(this.button2);
            this.CHANGE.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHANGE.Location = new System.Drawing.Point(747, 81);
            this.CHANGE.Margin = new System.Windows.Forms.Padding(4);
            this.CHANGE.Name = "CHANGE";
            this.CHANGE.Padding = new System.Windows.Forms.Padding(4);
            this.CHANGE.Size = new System.Drawing.Size(291, 300);
            this.CHANGE.TabIndex = 11;
            this.CHANGE.TabStop = false;
            this.CHANGE.Text = "CHANGE VALUE";
            // 
            // SAVE
            // 
            this.SAVE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SAVE.Location = new System.Drawing.Point(193, 79);
            this.SAVE.Margin = new System.Windows.Forms.Padding(4);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(89, 138);
            this.SAVE.TabIndex = 9;
            this.SAVE.Text = "SAVE";
            this.SAVE.UseVisualStyleBackColor = false;
            this.SAVE.Click += new System.EventHandler(this.SAVE_Click);
            // 
            // REDtext
            // 
            this.REDtext.Location = new System.Drawing.Point(99, 78);
            this.REDtext.Margin = new System.Windows.Forms.Padding(4);
            this.REDtext.Name = "REDtext";
            this.REDtext.Size = new System.Drawing.Size(80, 32);
            this.REDtext.TabIndex = 1;
            this.REDtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(21, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 43);
            this.label4.TabIndex = 8;
            this.label4.Text = "RED";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(5, 181);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 43);
            this.label5.TabIndex = 8;
            this.label5.Text = "YELLOW";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YELLOWtext
            // 
            this.YELLOWtext.Location = new System.Drawing.Point(99, 186);
            this.YELLOWtext.Margin = new System.Windows.Forms.Padding(4);
            this.YELLOWtext.Name = "YELLOWtext";
            this.YELLOWtext.Size = new System.Drawing.Size(80, 32);
            this.YELLOWtext.TabIndex = 1;
            this.YELLOWtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GREENtext
            // 
            this.GREENtext.Location = new System.Drawing.Point(99, 133);
            this.GREENtext.Margin = new System.Windows.Forms.Padding(4);
            this.GREENtext.Name = "GREENtext";
            this.GREENtext.Size = new System.Drawing.Size(80, 32);
            this.GREENtext.TabIndex = 1;
            this.GREENtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(0, 258);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(291, 43);
            this.button2.TabIndex = 0;
            this.button2.Text = "CLOSE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(139, 561);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(788, 236);
            this.dataGridView1.TabIndex = 12;
            // 
            // DateTimetxt
            // 
            this.DateTimetxt.AutoSize = true;
            this.DateTimetxt.BackColor = System.Drawing.Color.Transparent;
            this.DateTimetxt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimetxt.Location = new System.Drawing.Point(705, 538);
            this.DateTimetxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DateTimetxt.Name = "DateTimetxt";
            this.DateTimetxt.Size = new System.Drawing.Size(62, 21);
            this.DateTimetxt.TabIndex = 13;
            this.DateTimetxt.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1072, 814);
            this.Controls.Add(this.DateTimetxt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CHANGE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CONTROLbox);
            this.Controls.Add(this.BrIO);
            this.Controls.Add(this.ByIO);
            this.Controls.Add(this.ArIO);
            this.Controls.Add(this.BgIO);
            this.Controls.Add(this.AyIO);
            this.Controls.Add(this.AgIO);
            this.Controls.Add(this.Bred);
            this.Controls.Add(this.Byellow);
            this.Controls.Add(this.Ared);
            this.Controls.Add(this.Ayellow);
            this.Controls.Add(this.Bgreen);
            this.Controls.Add(this.Agreen);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "SCADA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Agreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RunSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ayellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ared)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bgreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Byellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bred)).EndInit();
            this.CONTROLbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GettoHMI)).EndInit();
            this.CHANGE.ResumeLayout(false);
            this.CHANGE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SymbolFactoryDotNet.StandardControl Agreen;
        private SymbolFactoryDotNet.StandardControl RunSystem;
        private System.Windows.Forms.Button buttonRUN;
        private System.Windows.Forms.Button buttonSTOP;
        private System.Windows.Forms.Timer timer1;
        private SymbolFactoryDotNet.StandardControl Ayellow;
        private SymbolFactoryDotNet.StandardControl Ared;
        private SymbolFactoryDotNet.StandardControl Bgreen;
        private SymbolFactoryDotNet.StandardControl Byellow;
        private SymbolFactoryDotNet.StandardControl Bred;
        private System.Windows.Forms.Label AgIO;
        private System.Windows.Forms.Label AyIO;
        private System.Windows.Forms.Label ArIO;
        private System.Windows.Forms.Label BgIO;
        private System.Windows.Forms.Label ByIO;
        private System.Windows.Forms.Label BrIO;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox CONTROLbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox CHANGE;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button SAVE;
        private System.Windows.Forms.TextBox REDtext;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox YELLOWtext;
        private System.Windows.Forms.TextBox GREENtext;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label DateTimetxt;
        private SymbolFactoryDotNet.StandardControl GettoHMI;
    }
}

