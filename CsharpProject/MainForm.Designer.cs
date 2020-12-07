
namespace CsharpProject
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Temperature",
            "-"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Feels like",
            "-"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Humidity",
            "-"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Preasure",
            "-"}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Wind speed",
            "-"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "Wind direction",
            "-"}, -1);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "Visibility",
            "-"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.materialTabControl1 = new MaterialThemeCore.MaterialControls.MaterialTabControl();
            this.currentPage = new System.Windows.Forms.TabPage();
            this.errorLabel = new System.Windows.Forms.Label();
            this.btnKiev = new MaterialThemeCore.MaterialControls.MaterialFlatButton();
            this.btnBucharest = new MaterialThemeCore.MaterialControls.MaterialFlatButton();
            this.btnMoscow = new MaterialThemeCore.MaterialControls.MaterialFlatButton();
            this.btnStockholm = new MaterialThemeCore.MaterialControls.MaterialFlatButton();
            this.btnVienna = new MaterialThemeCore.MaterialControls.MaterialFlatButton();
            this.btwVilnius = new MaterialThemeCore.MaterialControls.MaterialFlatButton();
            this.btnRome = new MaterialThemeCore.MaterialControls.MaterialFlatButton();
            this.btnParis = new MaterialThemeCore.MaterialControls.MaterialFlatButton();
            this.btnLondom = new MaterialThemeCore.MaterialControls.MaterialFlatButton();
            this.btnMadrid = new MaterialThemeCore.MaterialControls.MaterialFlatButton();
            this.btnBerlin = new MaterialThemeCore.MaterialControls.MaterialFlatButton();
            this.btnAthens = new MaterialThemeCore.MaterialControls.MaterialFlatButton();
            this.CurrentWeatherGroupBox = new System.Windows.Forms.GroupBox();
            this.currentWeatherListView = new MaterialThemeCore.MaterialControls.MaterialListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.Value = new System.Windows.Forms.ColumnHeader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.regionLabel = new MaterialThemeCore.MaterialControls.MaterialLabel();
            this.weatherConditionLabel = new MaterialThemeCore.MaterialControls.MaterialLabel();
            this.materialLabel6 = new MaterialThemeCore.MaterialControls.MaterialLabel();
            this.searchCityTextField = new MaterialThemeCore.MaterialControls.MaterialSingleLineTextField();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchButton = new MaterialThemeCore.MaterialControls.MaterialRaisedButton();
            this.searchCountryCodeTextField = new MaterialThemeCore.MaterialControls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialThemeCore.MaterialControls.MaterialLabel();
            this.weeklyPage = new System.Windows.Forms.TabPage();
            this.flowWeekForecastPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.settingsPage = new System.Windows.Forms.TabPage();
            this.applySettingsButton = new MaterialThemeCore.MaterialControls.MaterialRaisedButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.settingsCountryCodeTextField = new MaterialThemeCore.MaterialControls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialThemeCore.MaterialControls.MaterialLabel();
            this.materialLabel3 = new MaterialThemeCore.MaterialControls.MaterialLabel();
            this.materialLabel1 = new MaterialThemeCore.MaterialControls.MaterialLabel();
            this.settingsCityTextField = new MaterialThemeCore.MaterialControls.MaterialSingleLineTextField();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialLabel2 = new MaterialThemeCore.MaterialControls.MaterialLabel();
            this.metricMaterialRadioButton = new MaterialThemeCore.MaterialControls.MaterialRadioButton();
            this.ImperialMaterialRadioButton = new MaterialThemeCore.MaterialControls.MaterialRadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.materialTabSelector1 = new MaterialThemeCore.MaterialControls.MaterialTabSelector();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.materialTabControl1.SuspendLayout();
            this.currentPage.SuspendLayout();
            this.CurrentWeatherGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.weeklyPage.SuspendLayout();
            this.settingsPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.materialTabControl1.Controls.Add(this.currentPage);
            this.materialTabControl1.Controls.Add(this.weeklyPage);
            this.materialTabControl1.Controls.Add(this.settingsPage);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(13, 70);
            this.materialTabControl1.MaximumSize = new System.Drawing.Size(100000, 10000);
            this.materialTabControl1.MouseState = MaterialThemeCore.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(994, 720);
            this.materialTabControl1.TabIndex = 0;
            this.materialTabControl1.SelectedIndexChanged += new System.EventHandler(this.materialTabControl1_SelectedIndexChanged);
            // 
            // currentPage
            // 
            this.currentPage.BackColor = System.Drawing.Color.White;
            this.currentPage.Controls.Add(this.errorLabel);
            this.currentPage.Controls.Add(this.btnKiev);
            this.currentPage.Controls.Add(this.btnBucharest);
            this.currentPage.Controls.Add(this.btnMoscow);
            this.currentPage.Controls.Add(this.btnStockholm);
            this.currentPage.Controls.Add(this.btnVienna);
            this.currentPage.Controls.Add(this.btwVilnius);
            this.currentPage.Controls.Add(this.btnRome);
            this.currentPage.Controls.Add(this.btnParis);
            this.currentPage.Controls.Add(this.btnLondom);
            this.currentPage.Controls.Add(this.btnMadrid);
            this.currentPage.Controls.Add(this.btnBerlin);
            this.currentPage.Controls.Add(this.btnAthens);
            this.currentPage.Controls.Add(this.CurrentWeatherGroupBox);
            this.currentPage.Controls.Add(this.materialLabel6);
            this.currentPage.Controls.Add(this.searchCityTextField);
            this.currentPage.Controls.Add(this.pictureBox1);
            this.currentPage.Controls.Add(this.searchButton);
            this.currentPage.Controls.Add(this.searchCountryCodeTextField);
            this.currentPage.Controls.Add(this.materialLabel5);
            this.currentPage.Location = new System.Drawing.Point(4, 24);
            this.currentPage.Name = "currentPage";
            this.currentPage.Size = new System.Drawing.Size(986, 692);
            this.currentPage.TabIndex = 5;
            this.currentPage.Text = "Current";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(433, 20);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(189, 30);
            this.errorLabel.TabIndex = 23;
            this.errorLabel.Text = "Can\'t locate city :(";
            // 
            // btnKiev
            // 
            this.btnKiev.AutoSize = true;
            this.btnKiev.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnKiev.Depth = 0;
            this.btnKiev.Icon = null;
            this.btnKiev.Location = new System.Drawing.Point(479, 384);
            this.btnKiev.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnKiev.MouseState = MaterialThemeCore.MouseState.HOVER;
            this.btnKiev.Name = "btnKiev";
            this.btnKiev.Primary = false;
            this.btnKiev.Size = new System.Drawing.Size(50, 36);
            this.btnKiev.TabIndex = 22;
            this.btnKiev.Text = "Kiev";
            this.btnKiev.UseVisualStyleBackColor = true;
            this.btnKiev.Click += new System.EventHandler(this.btnKiev_Click);
            // 
            // btnBucharest
            // 
            this.btnBucharest.AutoSize = true;
            this.btnBucharest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBucharest.Depth = 0;
            this.btnBucharest.Icon = null;
            this.btnBucharest.Location = new System.Drawing.Point(416, 478);
            this.btnBucharest.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBucharest.MouseState = MaterialThemeCore.MouseState.HOVER;
            this.btnBucharest.Name = "btnBucharest";
            this.btnBucharest.Primary = false;
            this.btnBucharest.Size = new System.Drawing.Size(99, 36);
            this.btnBucharest.TabIndex = 21;
            this.btnBucharest.Text = "Bucharest";
            this.btnBucharest.UseVisualStyleBackColor = true;
            this.btnBucharest.Click += new System.EventHandler(this.btnBucharest_Click);
            // 
            // btnMoscow
            // 
            this.btnMoscow.AutoSize = true;
            this.btnMoscow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMoscow.Depth = 0;
            this.btnMoscow.Icon = null;
            this.btnMoscow.Location = new System.Drawing.Point(479, 240);
            this.btnMoscow.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMoscow.MouseState = MaterialThemeCore.MouseState.HOVER;
            this.btnMoscow.Name = "btnMoscow";
            this.btnMoscow.Primary = false;
            this.btnMoscow.Size = new System.Drawing.Size(81, 36);
            this.btnMoscow.TabIndex = 20;
            this.btnMoscow.Text = "Moscow";
            this.btnMoscow.UseVisualStyleBackColor = true;
            this.btnMoscow.Click += new System.EventHandler(this.btnMoscow_Click);
            // 
            // btnStockholm
            // 
            this.btnStockholm.AutoSize = true;
            this.btnStockholm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStockholm.Depth = 0;
            this.btnStockholm.Icon = null;
            this.btnStockholm.Location = new System.Drawing.Point(262, 249);
            this.btnStockholm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStockholm.MouseState = MaterialThemeCore.MouseState.HOVER;
            this.btnStockholm.Name = "btnStockholm";
            this.btnStockholm.Primary = false;
            this.btnStockholm.Size = new System.Drawing.Size(103, 36);
            this.btnStockholm.TabIndex = 13;
            this.btnStockholm.Text = "Stockholm";
            this.btnStockholm.UseVisualStyleBackColor = true;
            this.btnStockholm.Click += new System.EventHandler(this.btnStockholm_Click);
            // 
            // btnVienna
            // 
            this.btnVienna.AutoSize = true;
            this.btnVienna.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVienna.Depth = 0;
            this.btnVienna.Icon = null;
            this.btnVienna.Location = new System.Drawing.Point(295, 454);
            this.btnVienna.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVienna.MouseState = MaterialThemeCore.MouseState.HOVER;
            this.btnVienna.Name = "btnVienna";
            this.btnVienna.Primary = false;
            this.btnVienna.Size = new System.Drawing.Size(70, 36);
            this.btnVienna.TabIndex = 19;
            this.btnVienna.Text = "Vienna";
            this.btnVienna.UseVisualStyleBackColor = true;
            this.btnVienna.Click += new System.EventHandler(this.btnVienna_Click);
            // 
            // btwVilnius
            // 
            this.btwVilnius.AutoSize = true;
            this.btwVilnius.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btwVilnius.Depth = 0;
            this.btwVilnius.Icon = null;
            this.btwVilnius.Location = new System.Drawing.Point(376, 321);
            this.btwVilnius.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btwVilnius.MouseState = MaterialThemeCore.MouseState.HOVER;
            this.btwVilnius.Name = "btwVilnius";
            this.btwVilnius.Primary = false;
            this.btwVilnius.Size = new System.Drawing.Size(72, 36);
            this.btwVilnius.TabIndex = 12;
            this.btwVilnius.Text = "Vilnius";
            this.btwVilnius.UseVisualStyleBackColor = true;
            this.btwVilnius.Click += new System.EventHandler(this.btwVilnius_Click);
            // 
            // btnRome
            // 
            this.btnRome.AutoSize = true;
            this.btnRome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRome.Depth = 0;
            this.btnRome.Icon = null;
            this.btnRome.Location = new System.Drawing.Point(283, 546);
            this.btnRome.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRome.MouseState = MaterialThemeCore.MouseState.HOVER;
            this.btnRome.Name = "btnRome";
            this.btnRome.Primary = false;
            this.btnRome.Size = new System.Drawing.Size(59, 36);
            this.btnRome.TabIndex = 14;
            this.btnRome.Text = "Rome";
            this.btnRome.UseVisualStyleBackColor = true;
            this.btnRome.Click += new System.EventHandler(this.btnRome_Click);
            // 
            // btnParis
            // 
            this.btnParis.AutoSize = true;
            this.btnParis.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnParis.Depth = 0;
            this.btnParis.Icon = null;
            this.btnParis.Location = new System.Drawing.Point(162, 454);
            this.btnParis.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnParis.MouseState = MaterialThemeCore.MouseState.HOVER;
            this.btnParis.Name = "btnParis";
            this.btnParis.Primary = false;
            this.btnParis.Size = new System.Drawing.Size(60, 36);
            this.btnParis.TabIndex = 18;
            this.btnParis.Text = "Paris";
            this.btnParis.UseVisualStyleBackColor = true;
            this.btnParis.Click += new System.EventHandler(this.btnParis_Click);
            // 
            // btnLondom
            // 
            this.btnLondom.AutoSize = true;
            this.btnLondom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLondom.Depth = 0;
            this.btnLondom.Icon = null;
            this.btnLondom.Location = new System.Drawing.Point(128, 384);
            this.btnLondom.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLondom.MouseState = MaterialThemeCore.MouseState.HOVER;
            this.btnLondom.Name = "btnLondom";
            this.btnLondom.Primary = false;
            this.btnLondom.Size = new System.Drawing.Size(76, 36);
            this.btnLondom.TabIndex = 11;
            this.btnLondom.Text = "London";
            this.btnLondom.UseVisualStyleBackColor = true;
            this.btnLondom.Click += new System.EventHandler(this.btnLondom_Click);
            // 
            // btnMadrid
            // 
            this.btnMadrid.AutoSize = true;
            this.btnMadrid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMadrid.Depth = 0;
            this.btnMadrid.Icon = null;
            this.btnMadrid.Location = new System.Drawing.Point(75, 574);
            this.btnMadrid.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMadrid.MouseState = MaterialThemeCore.MouseState.HOVER;
            this.btnMadrid.Name = "btnMadrid";
            this.btnMadrid.Primary = false;
            this.btnMadrid.Size = new System.Drawing.Size(72, 36);
            this.btnMadrid.TabIndex = 15;
            this.btnMadrid.Text = "Madrid";
            this.btnMadrid.UseVisualStyleBackColor = true;
            this.btnMadrid.Click += new System.EventHandler(this.btnMadrid_Click);
            // 
            // btnBerlin
            // 
            this.btnBerlin.AutoSize = true;
            this.btnBerlin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBerlin.Depth = 0;
            this.btnBerlin.Icon = null;
            this.btnBerlin.Location = new System.Drawing.Point(262, 384);
            this.btnBerlin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBerlin.MouseState = MaterialThemeCore.MouseState.HOVER;
            this.btnBerlin.Name = "btnBerlin";
            this.btnBerlin.Primary = false;
            this.btnBerlin.Size = new System.Drawing.Size(67, 36);
            this.btnBerlin.TabIndex = 17;
            this.btnBerlin.Text = "Berlin";
            this.btnBerlin.UseVisualStyleBackColor = true;
            this.btnBerlin.Click += new System.EventHandler(this.btnBerlin_Click);
            // 
            // btnAthens
            // 
            this.btnAthens.AutoSize = true;
            this.btnAthens.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAthens.Depth = 0;
            this.btnAthens.Icon = null;
            this.btnAthens.Location = new System.Drawing.Point(416, 586);
            this.btnAthens.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAthens.MouseState = MaterialThemeCore.MouseState.HOVER;
            this.btnAthens.Name = "btnAthens";
            this.btnAthens.Primary = false;
            this.btnAthens.Size = new System.Drawing.Size(74, 36);
            this.btnAthens.TabIndex = 16;
            this.btnAthens.Text = "Athens";
            this.btnAthens.UseVisualStyleBackColor = true;
            this.btnAthens.Click += new System.EventHandler(this.btnAthens_Click);
            // 
            // CurrentWeatherGroupBox
            // 
            this.CurrentWeatherGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.CurrentWeatherGroupBox.Controls.Add(this.currentWeatherListView);
            this.CurrentWeatherGroupBox.Controls.Add(this.panel1);
            this.CurrentWeatherGroupBox.Controls.Add(this.regionLabel);
            this.CurrentWeatherGroupBox.Controls.Add(this.weatherConditionLabel);
            this.CurrentWeatherGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CurrentWeatherGroupBox.Location = new System.Drawing.Point(664, 61);
            this.CurrentWeatherGroupBox.MaximumSize = new System.Drawing.Size(312, 400);
            this.CurrentWeatherGroupBox.MinimumSize = new System.Drawing.Size(312, 400);
            this.CurrentWeatherGroupBox.Name = "CurrentWeatherGroupBox";
            this.CurrentWeatherGroupBox.Size = new System.Drawing.Size(312, 400);
            this.CurrentWeatherGroupBox.TabIndex = 6;
            this.CurrentWeatherGroupBox.TabStop = false;
            // 
            // currentWeatherListView
            // 
            this.currentWeatherListView.BackColor = System.Drawing.Color.DimGray;
            this.currentWeatherListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentWeatherListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.Value});
            this.currentWeatherListView.Depth = 0;
            this.currentWeatherListView.Enabled = false;
            this.currentWeatherListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentWeatherListView.FullRowSelect = true;
            this.currentWeatherListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.currentWeatherListView.HideSelection = false;
            this.currentWeatherListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7});
            this.currentWeatherListView.Location = new System.Drawing.Point(6, 66);
            this.currentWeatherListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.currentWeatherListView.MouseState = MaterialThemeCore.MouseState.OUT;
            this.currentWeatherListView.Name = "currentWeatherListView";
            this.currentWeatherListView.OwnerDraw = true;
            this.currentWeatherListView.Scrollable = false;
            this.currentWeatherListView.Size = new System.Drawing.Size(300, 328);
            this.currentWeatherListView.TabIndex = 1;
            this.currentWeatherListView.TileSize = new System.Drawing.Size(50, 50);
            this.currentWeatherListView.UseCompatibleStateImageBehavior = false;
            this.currentWeatherListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Name = "columnHeader1";
            this.columnHeader1.Text = "Contition";
            this.columnHeader1.Width = 200;
            // 
            // Value
            // 
            this.Value.Name = "Value";
            this.Value.Text = "Value";
            this.Value.Width = 100;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(6, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 1);
            this.panel1.TabIndex = 4;
            // 
            // regionLabel
            // 
            this.regionLabel.AutoSize = true;
            this.regionLabel.Depth = 0;
            this.regionLabel.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.regionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.regionLabel.Location = new System.Drawing.Point(17, 15);
            this.regionLabel.MouseState = MaterialThemeCore.MouseState.HOVER;
            this.regionLabel.Name = "regionLabel";
            this.regionLabel.Size = new System.Drawing.Size(79, 19);
            this.regionLabel.TabIndex = 2;
            this.regionLabel.Text = "Vilnius, LT";
            // 
            // weatherConditionLabel
            // 
            this.weatherConditionLabel.AutoSize = true;
            this.weatherConditionLabel.Depth = 0;
            this.weatherConditionLabel.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.weatherConditionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.weatherConditionLabel.Location = new System.Drawing.Point(17, 34);
            this.weatherConditionLabel.MouseState = MaterialThemeCore.MouseState.HOVER;
            this.weatherConditionLabel.Name = "weatherConditionLabel";
            this.weatherConditionLabel.Size = new System.Drawing.Size(55, 19);
            this.weatherConditionLabel.TabIndex = 3;
            this.weatherConditionLabel.Text = "Cloudy";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(25, 19);
            this.materialLabel6.MouseState = MaterialThemeCore.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(35, 19);
            this.materialLabel6.TabIndex = 6;
            this.materialLabel6.Text = "City";
            // 
            // searchCityTextField
            // 
            this.searchCityTextField.Depth = 0;
            this.searchCityTextField.Hint = "";
            this.searchCityTextField.Location = new System.Drawing.Point(28, 41);
            this.searchCityTextField.MaxLength = 32767;
            this.searchCityTextField.MouseState = MaterialThemeCore.MouseState.HOVER;
            this.searchCityTextField.Name = "searchCityTextField";
            this.searchCityTextField.PasswordChar = '\0';
            this.searchCityTextField.SelectedText = "";
            this.searchCityTextField.SelectionLength = 0;
            this.searchCityTextField.SelectionStart = 0;
            this.searchCityTextField.Size = new System.Drawing.Size(160, 23);
            this.searchCityTextField.TabIndex = 7;
            this.searchCityTextField.TabStop = false;
            this.searchCityTextField.UseSystemPasswordChar = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(599, 598);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // searchButton
            // 
            this.searchButton.AutoSize = true;
            this.searchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchButton.Depth = 0;
            this.searchButton.Icon = null;
            this.searchButton.Location = new System.Drawing.Point(325, 20);
            this.searchButton.MouseState = MaterialThemeCore.MouseState.HOVER;
            this.searchButton.Name = "searchButton";
            this.searchButton.Primary = true;
            this.searchButton.Size = new System.Drawing.Size(73, 36);
            this.searchButton.TabIndex = 10;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchCountryCodeTextField
            // 
            this.searchCountryCodeTextField.Depth = 0;
            this.searchCountryCodeTextField.Hint = "";
            this.searchCountryCodeTextField.Location = new System.Drawing.Point(206, 41);
            this.searchCountryCodeTextField.MaxLength = 32767;
            this.searchCountryCodeTextField.MouseState = MaterialThemeCore.MouseState.HOVER;
            this.searchCountryCodeTextField.Name = "searchCountryCodeTextField";
            this.searchCountryCodeTextField.PasswordChar = '\0';
            this.searchCountryCodeTextField.SelectedText = "";
            this.searchCountryCodeTextField.SelectionLength = 0;
            this.searchCountryCodeTextField.SelectionStart = 0;
            this.searchCountryCodeTextField.Size = new System.Drawing.Size(90, 23);
            this.searchCountryCodeTextField.TabIndex = 9;
            this.searchCountryCodeTextField.TabStop = false;
            this.searchCountryCodeTextField.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(201, 19);
            this.materialLabel5.MouseState = MaterialThemeCore.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(98, 19);
            this.materialLabel5.TabIndex = 8;
            this.materialLabel5.Text = "Country code";
            // 
            // weeklyPage
            // 
            this.weeklyPage.Controls.Add(this.flowWeekForecastPanel);
            this.weeklyPage.Location = new System.Drawing.Point(4, 24);
            this.weeklyPage.Name = "weeklyPage";
            this.weeklyPage.Size = new System.Drawing.Size(986, 692);
            this.weeklyPage.TabIndex = 3;
            this.weeklyPage.Text = "Weekly ";
            this.weeklyPage.UseVisualStyleBackColor = true;
            // 
            // flowWeekForecastPanel
            // 
            this.flowWeekForecastPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowWeekForecastPanel.AutoScroll = true;
            this.flowWeekForecastPanel.Location = new System.Drawing.Point(42, 3);
            this.flowWeekForecastPanel.Name = "flowWeekForecastPanel";
            this.flowWeekForecastPanel.Size = new System.Drawing.Size(900, 686);
            this.flowWeekForecastPanel.TabIndex = 0;
            // 
            // settingsPage
            // 
            this.settingsPage.BackColor = System.Drawing.Color.White;
            this.settingsPage.Controls.Add(this.applySettingsButton);
            this.settingsPage.Controls.Add(this.groupBox2);
            this.settingsPage.Controls.Add(this.groupBox1);
            this.settingsPage.Location = new System.Drawing.Point(4, 24);
            this.settingsPage.Name = "settingsPage";
            this.settingsPage.Size = new System.Drawing.Size(986, 692);
            this.settingsPage.TabIndex = 4;
            this.settingsPage.Text = "Settings";
            // 
            // applySettingsButton
            // 
            this.applySettingsButton.AutoSize = true;
            this.applySettingsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.applySettingsButton.Depth = 0;
            this.applySettingsButton.Icon = null;
            this.applySettingsButton.Location = new System.Drawing.Point(465, 337);
            this.applySettingsButton.MouseState = MaterialThemeCore.MouseState.HOVER;
            this.applySettingsButton.Name = "applySettingsButton";
            this.applySettingsButton.Primary = true;
            this.applySettingsButton.Size = new System.Drawing.Size(63, 36);
            this.applySettingsButton.TabIndex = 6;
            this.applySettingsButton.Text = "Apply";
            this.applySettingsButton.UseVisualStyleBackColor = true;
            this.applySettingsButton.Click += new System.EventHandler(this.applySettingsButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.settingsCountryCodeTextField);
            this.groupBox2.Controls.Add(this.materialLabel4);
            this.groupBox2.Controls.Add(this.materialLabel3);
            this.groupBox2.Controls.Add(this.materialLabel1);
            this.groupBox2.Controls.Add(this.settingsCityTextField);
            this.groupBox2.Location = new System.Drawing.Point(125, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 123);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // settingsCountryCodeTextField
            // 
            this.settingsCountryCodeTextField.Depth = 0;
            this.settingsCountryCodeTextField.Hint = "";
            this.settingsCountryCodeTextField.Location = new System.Drawing.Point(210, 88);
            this.settingsCountryCodeTextField.MaxLength = 32767;
            this.settingsCountryCodeTextField.MouseState = MaterialThemeCore.MouseState.HOVER;
            this.settingsCountryCodeTextField.Name = "settingsCountryCodeTextField";
            this.settingsCountryCodeTextField.PasswordChar = '\0';
            this.settingsCountryCodeTextField.SelectedText = "";
            this.settingsCountryCodeTextField.SelectionLength = 0;
            this.settingsCountryCodeTextField.SelectionStart = 0;
            this.settingsCountryCodeTextField.Size = new System.Drawing.Size(90, 23);
            this.settingsCountryCodeTextField.TabIndex = 5;
            this.settingsCountryCodeTextField.TabStop = false;
            this.settingsCountryCodeTextField.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(205, 66);
            this.materialLabel4.MouseState = MaterialThemeCore.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(97, 18);
            this.materialLabel4.TabIndex = 4;
            this.materialLabel4.Text = "Country code";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.materialLabel3.Location = new System.Drawing.Point(7, 23);
            this.materialLabel3.MouseState = MaterialThemeCore.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(110, 18);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Default location";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(7, 66);
            this.materialLabel1.MouseState = MaterialThemeCore.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(33, 18);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "City";
            // 
            // settingsCityTextField
            // 
            this.settingsCityTextField.Depth = 0;
            this.settingsCityTextField.Hint = "";
            this.settingsCityTextField.Location = new System.Drawing.Point(10, 88);
            this.settingsCityTextField.MaxLength = 32767;
            this.settingsCityTextField.MouseState = MaterialThemeCore.MouseState.HOVER;
            this.settingsCityTextField.Name = "settingsCityTextField";
            this.settingsCityTextField.PasswordChar = '\0';
            this.settingsCityTextField.SelectedText = "";
            this.settingsCityTextField.SelectionLength = 0;
            this.settingsCityTextField.SelectionStart = 0;
            this.settingsCityTextField.Size = new System.Drawing.Size(160, 23);
            this.settingsCityTextField.TabIndex = 3;
            this.settingsCityTextField.TabStop = false;
            this.settingsCityTextField.UseSystemPasswordChar = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.metricMaterialRadioButton);
            this.groupBox1.Controls.Add(this.ImperialMaterialRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(125, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 126);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(7, 23);
            this.materialLabel2.MouseState = MaterialThemeCore.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(42, 18);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Units";
            // 
            // metricMaterialRadioButton
            // 
            this.metricMaterialRadioButton.AutoSize = true;
            this.metricMaterialRadioButton.Checked = true;
            this.metricMaterialRadioButton.Depth = 0;
            this.metricMaterialRadioButton.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metricMaterialRadioButton.Location = new System.Drawing.Point(7, 55);
            this.metricMaterialRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.metricMaterialRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.metricMaterialRadioButton.MouseState = MaterialThemeCore.MouseState.HOVER;
            this.metricMaterialRadioButton.Name = "metricMaterialRadioButton";
            this.metricMaterialRadioButton.Ripple = true;
            this.metricMaterialRadioButton.Size = new System.Drawing.Size(117, 30);
            this.metricMaterialRadioButton.TabIndex = 0;
            this.metricMaterialRadioButton.TabStop = true;
            this.metricMaterialRadioButton.Text = "Metric system";
            this.metricMaterialRadioButton.UseVisualStyleBackColor = true;
            // 
            // ImperialMaterialRadioButton
            // 
            this.ImperialMaterialRadioButton.AutoSize = true;
            this.ImperialMaterialRadioButton.Checked = true;
            this.ImperialMaterialRadioButton.Depth = 0;
            this.ImperialMaterialRadioButton.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ImperialMaterialRadioButton.Location = new System.Drawing.Point(7, 85);
            this.ImperialMaterialRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.ImperialMaterialRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ImperialMaterialRadioButton.MouseState = MaterialThemeCore.MouseState.HOVER;
            this.ImperialMaterialRadioButton.Name = "ImperialMaterialRadioButton";
            this.ImperialMaterialRadioButton.Ripple = true;
            this.ImperialMaterialRadioButton.Size = new System.Drawing.Size(127, 30);
            this.ImperialMaterialRadioButton.TabIndex = 1;
            this.ImperialMaterialRadioButton.TabStop = true;
            this.ImperialMaterialRadioButton.Text = "Imperial system";
            this.ImperialMaterialRadioButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 15);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(40, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Weather";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.materialTabSelector1.Location = new System.Drawing.Point(161, 26);
            this.materialTabSelector1.MouseState = MaterialThemeCore.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(323, 38);
            this.materialTabSelector1.TabIndex = 5;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 800);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.materialTabControl1);
            this.MinimumSize = new System.Drawing.Size(1020, 800);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.currentPage.ResumeLayout(false);
            this.currentPage.PerformLayout();
            this.CurrentWeatherGroupBox.ResumeLayout(false);
            this.CurrentWeatherGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.weeklyPage.ResumeLayout(false);
            this.settingsPage.ResumeLayout(false);
            this.settingsPage.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialThemeCore.MaterialControls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage weeklyPage;
        private System.Windows.Forms.TabPage settingsPage;
        private System.Windows.Forms.Label label1;
        private MaterialThemeCore.MaterialControls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.Timer timer1;
        private MaterialThemeCore.MaterialControls.MaterialRadioButton metricMaterialRadioButton;
        private MaterialThemeCore.MaterialControls.MaterialRadioButton ImperialMaterialRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialThemeCore.MaterialControls.MaterialSingleLineTextField settingsCountryCodeTextField;
        private MaterialThemeCore.MaterialControls.MaterialLabel materialLabel4;
        private MaterialThemeCore.MaterialControls.MaterialLabel materialLabel3;
        private MaterialThemeCore.MaterialControls.MaterialLabel materialLabel1;
        private MaterialThemeCore.MaterialControls.MaterialSingleLineTextField settingsCityTextField;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialThemeCore.MaterialControls.MaterialLabel materialLabel2;
        private MaterialThemeCore.MaterialControls.MaterialRaisedButton applySettingsButton;
        private System.Windows.Forms.TabPage currentPage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialThemeCore.MaterialControls.MaterialRaisedButton searchButton;
        private MaterialThemeCore.MaterialControls.MaterialSingleLineTextField searchCountryCodeTextField;
        private MaterialThemeCore.MaterialControls.MaterialLabel materialLabel5;
        private MaterialThemeCore.MaterialControls.MaterialLabel materialLabel6;
        private MaterialThemeCore.MaterialControls.MaterialSingleLineTextField searchCityTextField;
        private MaterialThemeCore.MaterialControls.MaterialFlatButton btnKiev;
        private MaterialThemeCore.MaterialControls.MaterialFlatButton btnBucharest;
        private MaterialThemeCore.MaterialControls.MaterialFlatButton btnMoscow;
        private MaterialThemeCore.MaterialControls.MaterialFlatButton btnVienna;
        private MaterialThemeCore.MaterialControls.MaterialFlatButton btnParis;
        private MaterialThemeCore.MaterialControls.MaterialFlatButton btnBerlin;
        private MaterialThemeCore.MaterialControls.MaterialFlatButton btnAthens;
        private MaterialThemeCore.MaterialControls.MaterialFlatButton btnMadrid;
        private MaterialThemeCore.MaterialControls.MaterialFlatButton btnRome;
        private MaterialThemeCore.MaterialControls.MaterialFlatButton btnStockholm;
        private MaterialThemeCore.MaterialControls.MaterialFlatButton btwVilnius;
        private MaterialThemeCore.MaterialControls.MaterialFlatButton btnLondom;
        private System.Windows.Forms.GroupBox CurrentWeatherGroupBox;
        private MaterialThemeCore.MaterialControls.MaterialListView currentWeatherListView;
        private System.Windows.Forms.Panel panel1;
        private MaterialThemeCore.MaterialControls.MaterialLabel regionLabel;
        private MaterialThemeCore.MaterialControls.MaterialLabel weatherConditionLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.FlowLayoutPanel flowWeekForecastPanel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader Value;
    }
}