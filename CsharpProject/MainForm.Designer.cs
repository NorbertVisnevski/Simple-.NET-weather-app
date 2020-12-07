
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
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "Temperature",
            "-"}, -1);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "Feels like",
            "-"}, -1);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "Humidity",
            "-"}, -1);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new string[] {
            "Preasure",
            "-"}, -1);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            "Wind speed",
            "-"}, -1);
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem(new string[] {
            "Wind direction",
            "-"}, -1);
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem(new string[] {
            "Visibility",
            "-"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.materialTabControl1 = new MaterialThemeCore.MaterialControls.MaterialTabControl();
            this.currentPage = new System.Windows.Forms.TabPage();
            this.errorLabel = new System.Windows.Forms.Label();
            this.materialFlatButton12 = new MaterialThemeCore.MaterialControls.MaterialFlatButton();
            this.materialFlatButton11 = new MaterialThemeCore.MaterialControls.MaterialFlatButton();
            this.materialFlatButton10 = new MaterialThemeCore.MaterialControls.MaterialFlatButton();
            this.materialFlatButton3 = new MaterialThemeCore.MaterialControls.MaterialFlatButton();
            this.materialFlatButton9 = new MaterialThemeCore.MaterialControls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialThemeCore.MaterialControls.MaterialFlatButton();
            this.materialFlatButton4 = new MaterialThemeCore.MaterialControls.MaterialFlatButton();
            this.materialFlatButton8 = new MaterialThemeCore.MaterialControls.MaterialFlatButton();
            this.materialFlatButton1 = new MaterialThemeCore.MaterialControls.MaterialFlatButton();
            this.materialFlatButton5 = new MaterialThemeCore.MaterialControls.MaterialFlatButton();
            this.materialFlatButton7 = new MaterialThemeCore.MaterialControls.MaterialFlatButton();
            this.materialFlatButton6 = new MaterialThemeCore.MaterialControls.MaterialFlatButton();
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
            this.currentPage.Controls.Add(this.materialFlatButton12);
            this.currentPage.Controls.Add(this.materialFlatButton11);
            this.currentPage.Controls.Add(this.materialFlatButton10);
            this.currentPage.Controls.Add(this.materialFlatButton3);
            this.currentPage.Controls.Add(this.materialFlatButton9);
            this.currentPage.Controls.Add(this.materialFlatButton2);
            this.currentPage.Controls.Add(this.materialFlatButton4);
            this.currentPage.Controls.Add(this.materialFlatButton8);
            this.currentPage.Controls.Add(this.materialFlatButton1);
            this.currentPage.Controls.Add(this.materialFlatButton5);
            this.currentPage.Controls.Add(this.materialFlatButton7);
            this.currentPage.Controls.Add(this.materialFlatButton6);
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
            // materialFlatButton12
            // 
            this.materialFlatButton12.AutoSize = true;
            this.materialFlatButton12.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton12.Depth = 0;
            this.materialFlatButton12.Icon = null;
            this.materialFlatButton12.Location = new System.Drawing.Point(479, 384);
            this.materialFlatButton12.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton12.MouseState = MaterialThemeCore.MouseState.HOVER;
            this.materialFlatButton12.Name = "materialFlatButton12";
            this.materialFlatButton12.Primary = false;
            this.materialFlatButton12.Size = new System.Drawing.Size(50, 36);
            this.materialFlatButton12.TabIndex = 22;
            this.materialFlatButton12.Text = "Kiev";
            this.materialFlatButton12.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton11
            // 
            this.materialFlatButton11.AutoSize = true;
            this.materialFlatButton11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton11.Depth = 0;
            this.materialFlatButton11.Icon = null;
            this.materialFlatButton11.Location = new System.Drawing.Point(416, 478);
            this.materialFlatButton11.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton11.MouseState = MaterialThemeCore.MouseState.HOVER;
            this.materialFlatButton11.Name = "materialFlatButton11";
            this.materialFlatButton11.Primary = false;
            this.materialFlatButton11.Size = new System.Drawing.Size(99, 36);
            this.materialFlatButton11.TabIndex = 21;
            this.materialFlatButton11.Text = "Bucharest";
            this.materialFlatButton11.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton10
            // 
            this.materialFlatButton10.AutoSize = true;
            this.materialFlatButton10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton10.Depth = 0;
            this.materialFlatButton10.Icon = null;
            this.materialFlatButton10.Location = new System.Drawing.Point(479, 240);
            this.materialFlatButton10.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton10.MouseState = MaterialThemeCore.MouseState.HOVER;
            this.materialFlatButton10.Name = "materialFlatButton10";
            this.materialFlatButton10.Primary = false;
            this.materialFlatButton10.Size = new System.Drawing.Size(81, 36);
            this.materialFlatButton10.TabIndex = 20;
            this.materialFlatButton10.Text = "Moscow";
            this.materialFlatButton10.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Icon = null;
            this.materialFlatButton3.Location = new System.Drawing.Point(262, 249);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialThemeCore.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(103, 36);
            this.materialFlatButton3.TabIndex = 13;
            this.materialFlatButton3.Text = "Stockholm";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton9
            // 
            this.materialFlatButton9.AutoSize = true;
            this.materialFlatButton9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton9.Depth = 0;
            this.materialFlatButton9.Icon = null;
            this.materialFlatButton9.Location = new System.Drawing.Point(295, 454);
            this.materialFlatButton9.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton9.MouseState = MaterialThemeCore.MouseState.HOVER;
            this.materialFlatButton9.Name = "materialFlatButton9";
            this.materialFlatButton9.Primary = false;
            this.materialFlatButton9.Size = new System.Drawing.Size(70, 36);
            this.materialFlatButton9.TabIndex = 19;
            this.materialFlatButton9.Text = "Vienna";
            this.materialFlatButton9.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Icon = null;
            this.materialFlatButton2.Location = new System.Drawing.Point(376, 321);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialThemeCore.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(72, 36);
            this.materialFlatButton2.TabIndex = 12;
            this.materialFlatButton2.Text = "Vilnius";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton4
            // 
            this.materialFlatButton4.AutoSize = true;
            this.materialFlatButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton4.Depth = 0;
            this.materialFlatButton4.Icon = null;
            this.materialFlatButton4.Location = new System.Drawing.Point(283, 546);
            this.materialFlatButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton4.MouseState = MaterialThemeCore.MouseState.HOVER;
            this.materialFlatButton4.Name = "materialFlatButton4";
            this.materialFlatButton4.Primary = false;
            this.materialFlatButton4.Size = new System.Drawing.Size(59, 36);
            this.materialFlatButton4.TabIndex = 14;
            this.materialFlatButton4.Text = "Rome";
            this.materialFlatButton4.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton8
            // 
            this.materialFlatButton8.AutoSize = true;
            this.materialFlatButton8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton8.Depth = 0;
            this.materialFlatButton8.Icon = null;
            this.materialFlatButton8.Location = new System.Drawing.Point(162, 454);
            this.materialFlatButton8.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton8.MouseState = MaterialThemeCore.MouseState.HOVER;
            this.materialFlatButton8.Name = "materialFlatButton8";
            this.materialFlatButton8.Primary = false;
            this.materialFlatButton8.Size = new System.Drawing.Size(60, 36);
            this.materialFlatButton8.TabIndex = 18;
            this.materialFlatButton8.Text = "Paris";
            this.materialFlatButton8.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(128, 384);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialThemeCore.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(76, 36);
            this.materialFlatButton1.TabIndex = 11;
            this.materialFlatButton1.Text = "London";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton5
            // 
            this.materialFlatButton5.AutoSize = true;
            this.materialFlatButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton5.Depth = 0;
            this.materialFlatButton5.Icon = null;
            this.materialFlatButton5.Location = new System.Drawing.Point(75, 574);
            this.materialFlatButton5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton5.MouseState = MaterialThemeCore.MouseState.HOVER;
            this.materialFlatButton5.Name = "materialFlatButton5";
            this.materialFlatButton5.Primary = false;
            this.materialFlatButton5.Size = new System.Drawing.Size(72, 36);
            this.materialFlatButton5.TabIndex = 15;
            this.materialFlatButton5.Text = "Madrid";
            this.materialFlatButton5.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton7
            // 
            this.materialFlatButton7.AutoSize = true;
            this.materialFlatButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton7.Depth = 0;
            this.materialFlatButton7.Icon = null;
            this.materialFlatButton7.Location = new System.Drawing.Point(262, 384);
            this.materialFlatButton7.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton7.MouseState = MaterialThemeCore.MouseState.HOVER;
            this.materialFlatButton7.Name = "materialFlatButton7";
            this.materialFlatButton7.Primary = false;
            this.materialFlatButton7.Size = new System.Drawing.Size(67, 36);
            this.materialFlatButton7.TabIndex = 17;
            this.materialFlatButton7.Text = "Berlin";
            this.materialFlatButton7.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton6
            // 
            this.materialFlatButton6.AutoSize = true;
            this.materialFlatButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton6.Depth = 0;
            this.materialFlatButton6.Icon = null;
            this.materialFlatButton6.Location = new System.Drawing.Point(416, 586);
            this.materialFlatButton6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton6.MouseState = MaterialThemeCore.MouseState.HOVER;
            this.materialFlatButton6.Name = "materialFlatButton6";
            this.materialFlatButton6.Primary = false;
            this.materialFlatButton6.Size = new System.Drawing.Size(74, 36);
            this.materialFlatButton6.TabIndex = 16;
            this.materialFlatButton6.Text = "Athens";
            this.materialFlatButton6.UseVisualStyleBackColor = true;
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
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14});
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
            this.searchCityTextField.Text = "Vilnius";
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
            this.searchCountryCodeTextField.Text = "LT";
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
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(205, 66);
            this.materialLabel4.MouseState = MaterialThemeCore.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(98, 19);
            this.materialLabel4.TabIndex = 4;
            this.materialLabel4.Text = "Country code";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.materialLabel3.Location = new System.Drawing.Point(7, 23);
            this.materialLabel3.MouseState = MaterialThemeCore.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(116, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Default location";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(7, 66);
            this.materialLabel1.MouseState = MaterialThemeCore.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(35, 19);
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
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(7, 23);
            this.materialLabel2.MouseState = MaterialThemeCore.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(44, 19);
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
        private System.Windows.Forms.ColumnHeader ConditionColumn;
        private System.Windows.Forms.ColumnHeader ValueColumn;
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
        private MaterialThemeCore.MaterialControls.MaterialFlatButton materialFlatButton12;
        private MaterialThemeCore.MaterialControls.MaterialFlatButton materialFlatButton11;
        private MaterialThemeCore.MaterialControls.MaterialFlatButton materialFlatButton10;
        private MaterialThemeCore.MaterialControls.MaterialFlatButton materialFlatButton9;
        private MaterialThemeCore.MaterialControls.MaterialFlatButton materialFlatButton8;
        private MaterialThemeCore.MaterialControls.MaterialFlatButton materialFlatButton7;
        private MaterialThemeCore.MaterialControls.MaterialFlatButton materialFlatButton6;
        private MaterialThemeCore.MaterialControls.MaterialFlatButton materialFlatButton5;
        private MaterialThemeCore.MaterialControls.MaterialFlatButton materialFlatButton4;
        private MaterialThemeCore.MaterialControls.MaterialFlatButton materialFlatButton3;
        private MaterialThemeCore.MaterialControls.MaterialFlatButton materialFlatButton2;
        private MaterialThemeCore.MaterialControls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.GroupBox CurrentWeatherGroupBox;
        private MaterialThemeCore.MaterialControls.MaterialListView currentWeatherListView;
        private System.Windows.Forms.Panel panel1;
        private MaterialThemeCore.MaterialControls.MaterialLabel regionLabel;
        private MaterialThemeCore.MaterialControls.MaterialLabel weatherConditionLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.FlowLayoutPanel flowWeekForecastPanel;
        private System.Windows.Forms.ColumnHeader conditionColumn;
        private System.Windows.Forms.ColumnHeader valueColumn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader Value;
    }
}