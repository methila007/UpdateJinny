namespace UpdateJinny
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.timerNews2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.MonthLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DayLabel = new System.Windows.Forms.Label();
            this.groupBoxTopRow = new System.Windows.Forms.GroupBox();
            this.labelSource = new System.Windows.Forms.Label();
            this.topNewsLabel = new System.Windows.Forms.Label();
            this.groupBoxMiddleRow = new System.Windows.Forms.GroupBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.SportsNewsLabel = new System.Windows.Forms.Label();
            this.overCountLabel1 = new System.Windows.Forms.Label();
            this.overCountLabel2 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.matchStatusLabel = new System.Windows.Forms.Label();
            this.liveScore2 = new System.Windows.Forms.Label();
            this.liveScore1 = new System.Windows.Forms.Label();
            this.timerLiveScore = new System.Windows.Forms.Timer(this.components);
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.timerNews = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.msmMainForm = new MetroFramework.Components.MetroStyleManager(this.components);
            this.SettingsButton = new MetroFramework.Controls.MetroButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBoxLink2 = new System.Windows.Forms.RichTextBox();
            this.richTextBoxLink1 = new System.Windows.Forms.RichTextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.WeatherLabel = new System.Windows.Forms.Label();
            this.buttonNet1 = new System.Windows.Forms.Button();
            this.buttonNet2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxTopRow.SuspendLayout();
            this.groupBoxMiddleRow.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msmMainForm)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox1.Controls.Add(this.TimeLabel);
            this.groupBox1.Controls.Add(this.labelTime);
            this.groupBox1.ForeColor = System.Drawing.Color.Chocolate;
            this.groupBox1.Location = new System.Drawing.Point(2, 64);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(73, 87);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TimeLabel.Location = new System.Drawing.Point(12, 15);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(54, 29);
            this.TimeLabel.TabIndex = 1;
            this.TimeLabel.Text = "time";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(24, 30);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(0, 13);
            this.labelTime.TabIndex = 0;
            // 
            // timerNews2
            // 
            this.timerNews2.Tick += new System.EventHandler(this.timerNews2_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox3.Controls.Add(this.MonthLabel);
            this.groupBox3.Controls.Add(this.DateLabel);
            this.groupBox3.Controls.Add(this.DayLabel);
            this.groupBox3.Location = new System.Drawing.Point(2, 159);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(73, 104);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            // 
            // MonthLabel
            // 
            this.MonthLabel.AutoSize = true;
            this.MonthLabel.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MonthLabel.Location = new System.Drawing.Point(16, 67);
            this.MonthLabel.Name = "MonthLabel";
            this.MonthLabel.Size = new System.Drawing.Size(54, 22);
            this.MonthLabel.TabIndex = 2;
            this.MonthLabel.Text = "month";
            this.MonthLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Arial Narrow", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DateLabel.Location = new System.Drawing.Point(16, 32);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(50, 27);
            this.DateLabel.TabIndex = 1;
            this.DateLabel.Text = "date";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DayLabel
            // 
            this.DayLabel.AutoSize = true;
            this.DayLabel.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DayLabel.Location = new System.Drawing.Point(12, 10);
            this.DayLabel.Name = "DayLabel";
            this.DayLabel.Size = new System.Drawing.Size(35, 22);
            this.DayLabel.TabIndex = 0;
            this.DayLabel.Text = "day";
            // 
            // groupBoxTopRow
            // 
            this.groupBoxTopRow.BackColor = System.Drawing.Color.DeepPink;
            this.groupBoxTopRow.Controls.Add(this.buttonNet1);
            this.groupBoxTopRow.Controls.Add(this.labelSource);
            this.groupBoxTopRow.Controls.Add(this.topNewsLabel);
            this.groupBoxTopRow.Location = new System.Drawing.Point(81, 64);
            this.groupBoxTopRow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxTopRow.Name = "groupBoxTopRow";
            this.groupBoxTopRow.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxTopRow.Size = new System.Drawing.Size(290, 62);
            this.groupBoxTopRow.TabIndex = 18;
            this.groupBoxTopRow.TabStop = false;
            // 
            // labelSource
            // 
            this.labelSource.AutoSize = true;
            this.labelSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSource.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSource.Location = new System.Drawing.Point(6, 4);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(51, 13);
            this.labelSource.TabIndex = 2;
            this.labelSource.Text = "Source:";
            // 
            // topNewsLabel
            // 
            this.topNewsLabel.BackColor = System.Drawing.Color.DeepPink;
            this.topNewsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topNewsLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topNewsLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.topNewsLabel.Location = new System.Drawing.Point(3, 17);
            this.topNewsLabel.Name = "topNewsLabel";
            this.topNewsLabel.Size = new System.Drawing.Size(284, 41);
            this.topNewsLabel.TabIndex = 0;
            this.topNewsLabel.Text = "topNews";
            this.topNewsLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.topNewsLabel_MouseClick);
            // 
            // groupBoxMiddleRow
            // 
            this.groupBoxMiddleRow.BackColor = System.Drawing.Color.Crimson;
            this.groupBoxMiddleRow.Controls.Add(this.buttonNet2);
            this.groupBoxMiddleRow.Controls.Add(this.labelCategory);
            this.groupBoxMiddleRow.Controls.Add(this.SportsNewsLabel);
            this.groupBoxMiddleRow.Location = new System.Drawing.Point(81, 126);
            this.groupBoxMiddleRow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxMiddleRow.Name = "groupBoxMiddleRow";
            this.groupBoxMiddleRow.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxMiddleRow.Size = new System.Drawing.Size(290, 59);
            this.groupBoxMiddleRow.TabIndex = 19;
            this.groupBoxMiddleRow.TabStop = false;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCategory.Location = new System.Drawing.Point(0, 4);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(61, 13);
            this.labelCategory.TabIndex = 2;
            this.labelCategory.Text = "Category:";
            // 
            // SportsNewsLabel
            // 
            this.SportsNewsLabel.BackColor = System.Drawing.Color.Crimson;
            this.SportsNewsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SportsNewsLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SportsNewsLabel.ForeColor = System.Drawing.Color.White;
            this.SportsNewsLabel.Location = new System.Drawing.Point(3, 17);
            this.SportsNewsLabel.Name = "SportsNewsLabel";
            this.SportsNewsLabel.Size = new System.Drawing.Size(284, 38);
            this.SportsNewsLabel.TabIndex = 0;
            this.SportsNewsLabel.Text = "SportsNews";
            this.SportsNewsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SportsNewsLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SportsNewsLabel_MouseClick);
            // 
            // overCountLabel1
            // 
            this.overCountLabel1.AutoSize = true;
            this.overCountLabel1.BackColor = System.Drawing.Color.Turquoise;
            this.overCountLabel1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overCountLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.overCountLabel1.Location = new System.Drawing.Point(97, 37);
            this.overCountLabel1.Name = "overCountLabel1";
            this.overCountLabel1.Size = new System.Drawing.Size(43, 20);
            this.overCountLabel1.TabIndex = 4;
            this.overCountLabel1.Text = "overs";
            this.overCountLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // overCountLabel2
            // 
            this.overCountLabel2.AutoSize = true;
            this.overCountLabel2.BackColor = System.Drawing.Color.Turquoise;
            this.overCountLabel2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overCountLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.overCountLabel2.Location = new System.Drawing.Point(97, 17);
            this.overCountLabel2.Name = "overCountLabel2";
            this.overCountLabel2.Size = new System.Drawing.Size(43, 20);
            this.overCountLabel2.TabIndex = 3;
            this.overCountLabel2.Text = "overs";
            this.overCountLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox6.Controls.Add(this.overCountLabel1);
            this.groupBox6.Controls.Add(this.overCountLabel2);
            this.groupBox6.Controls.Add(this.matchStatusLabel);
            this.groupBox6.Controls.Add(this.liveScore2);
            this.groupBox6.Controls.Add(this.liveScore1);
            this.groupBox6.Location = new System.Drawing.Point(81, 181);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(290, 82);
            this.groupBox6.TabIndex = 20;
            this.groupBox6.TabStop = false;
            // 
            // matchStatusLabel
            // 
            this.matchStatusLabel.AutoSize = true;
            this.matchStatusLabel.BackColor = System.Drawing.Color.Turquoise;
            this.matchStatusLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchStatusLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.matchStatusLabel.Location = new System.Drawing.Point(31, 57);
            this.matchStatusLabel.Name = "matchStatusLabel";
            this.matchStatusLabel.Size = new System.Drawing.Size(151, 20);
            this.matchStatusLabel.TabIndex = 2;
            this.matchStatusLabel.Text = "Match Will Start Soon!!";
            this.matchStatusLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // liveScore2
            // 
            this.liveScore2.AutoSize = true;
            this.liveScore2.BackColor = System.Drawing.Color.Turquoise;
            this.liveScore2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liveScore2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.liveScore2.Location = new System.Drawing.Point(6, 17);
            this.liveScore2.Name = "liveScore2";
            this.liveScore2.Size = new System.Drawing.Size(74, 20);
            this.liveScore2.TabIndex = 1;
            this.liveScore2.Text = "liveScore2";
            // 
            // liveScore1
            // 
            this.liveScore1.BackColor = System.Drawing.Color.Turquoise;
            this.liveScore1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.liveScore1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.liveScore1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liveScore1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.liveScore1.Location = new System.Drawing.Point(3, 17);
            this.liveScore1.Name = "liveScore1";
            this.liveScore1.Size = new System.Drawing.Size(284, 61);
            this.liveScore1.TabIndex = 0;
            this.liveScore1.Text = "liveScore";
            this.liveScore1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerLiveScore
            // 
            this.timerLiveScore.Interval = 1000;
            this.timerLiveScore.Tick += new System.EventHandler(this.timerLiveScore_Tick);
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // timerNews
            // 
            this.timerNews.Tick += new System.EventHandler(this.timerNews_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Salmon;
            this.label1.Location = new System.Drawing.Point(177, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Update Jinny";
            // 
            // msmMainForm
            // 
            this.msmMainForm.Owner = this;
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackgroundImage = global::UpdateJinny.Properties.Resources.unnamed;
            this.SettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SettingsButton.Location = new System.Drawing.Point(308, 12);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(27, 23);
            this.SettingsButton.TabIndex = 24;
            this.SettingsButton.UseSelectable = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox2.BackgroundImage = global::UpdateJinny.Properties.Resources.fluffy_white_clouds_how_to_predict_the_weather_for_kids;
            this.groupBox2.Controls.Add(this.richTextBoxLink2);
            this.groupBox2.Controls.Add(this.richTextBoxLink1);
            this.groupBox2.Controls.Add(this.labelCity);
            this.groupBox2.Controls.Add(this.richTextBox2);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Controls.Add(this.WeatherLabel);
            this.groupBox2.Location = new System.Drawing.Point(2, 6);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(300, 38);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // richTextBoxLink2
            // 
            this.richTextBoxLink2.BackColor = System.Drawing.Color.DarkRed;
            this.richTextBoxLink2.Location = new System.Drawing.Point(217, 5);
            this.richTextBoxLink2.Name = "richTextBoxLink2";
            this.richTextBoxLink2.Size = new System.Drawing.Size(14, 10);
            this.richTextBoxLink2.TabIndex = 3;
            this.richTextBoxLink2.Text = "";
            this.richTextBoxLink2.Visible = false;
            // 
            // richTextBoxLink1
            // 
            this.richTextBoxLink1.BackColor = System.Drawing.Color.LightPink;
            this.richTextBoxLink1.Location = new System.Drawing.Point(237, 6);
            this.richTextBoxLink1.Name = "richTextBoxLink1";
            this.richTextBoxLink1.Size = new System.Drawing.Size(17, 10);
            this.richTextBoxLink1.TabIndex = 3;
            this.richTextBoxLink1.Text = "";
            this.richTextBoxLink1.Visible = false;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.BackColor = System.Drawing.Color.Transparent;
            this.labelCity.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCity.Location = new System.Drawing.Point(6, 13);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(52, 16);
            this.labelCity.TabIndex = 2;
            this.labelCity.Text = "Dhaka:";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.richTextBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(260, 5);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(20, 29);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            this.richTextBox2.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Pink;
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBox1.Location = new System.Drawing.Point(286, 5);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(14, 29);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // WeatherLabel
            // 
            this.WeatherLabel.AutoSize = true;
            this.WeatherLabel.BackColor = System.Drawing.Color.Transparent;
            this.WeatherLabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeatherLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WeatherLabel.Location = new System.Drawing.Point(109, 9);
            this.WeatherLabel.Name = "WeatherLabel";
            this.WeatherLabel.Size = new System.Drawing.Size(30, 25);
            this.WeatherLabel.TabIndex = 0;
            this.WeatherLabel.Text = "˚C";
            this.WeatherLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonNet1
            // 
            this.buttonNet1.BackgroundImage = global::UpdateJinny.Properties.Resources.internet_explorer_logo_318_40166;
            this.buttonNet1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNet1.Location = new System.Drawing.Point(261, 35);
            this.buttonNet1.Name = "buttonNet1";
            this.buttonNet1.Size = new System.Drawing.Size(26, 23);
            this.buttonNet1.TabIndex = 3;
            this.buttonNet1.UseVisualStyleBackColor = true;
            this.buttonNet1.Click += new System.EventHandler(this.buttonNet1_Click);
            // 
            // buttonNet2
            // 
            this.buttonNet2.BackgroundImage = global::UpdateJinny.Properties.Resources.ie1;
            this.buttonNet2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNet2.Location = new System.Drawing.Point(258, 32);
            this.buttonNet2.Name = "buttonNet2";
            this.buttonNet2.Size = new System.Drawing.Size(29, 23);
            this.buttonNet2.TabIndex = 3;
            this.buttonNet2.UseVisualStyleBackColor = true;
            this.buttonNet2.Click += new System.EventHandler(this.buttonNet2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 268);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxTopRow);
            this.Controls.Add(this.groupBoxMiddleRow);
            this.Controls.Add(this.groupBox6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxTopRow.ResumeLayout(false);
            this.groupBoxTopRow.PerformLayout();
            this.groupBoxMiddleRow.ResumeLayout(false);
            this.groupBoxMiddleRow.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msmMainForm)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timerNews2;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Label MonthLabel;
        public System.Windows.Forms.Label DateLabel;
        public System.Windows.Forms.Label DayLabel;
        public System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label overCountLabel1;
        private System.Windows.Forms.Label overCountLabel2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label matchStatusLabel;
        private System.Windows.Forms.Label liveScore2;
        private System.Windows.Forms.Label liveScore1;
        private System.Windows.Forms.Timer timerLiveScore;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Timer timerNews;
        public System.Windows.Forms.Label WeatherLabel;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton SettingsButton;
        public MetroFramework.Components.MetroStyleManager msmMainForm;
        public System.Windows.Forms.Label labelSource;
        public System.Windows.Forms.Label labelCategory;
        public System.Windows.Forms.GroupBox groupBoxTopRow;
        public System.Windows.Forms.GroupBox groupBoxMiddleRow;
        public System.Windows.Forms.Label topNewsLabel;
        public System.Windows.Forms.Label SportsNewsLabel;
        private System.Windows.Forms.Button buttonNet1;
        private System.Windows.Forms.Button buttonNet2;
        private System.Windows.Forms.RichTextBox richTextBoxLink2;
        private System.Windows.Forms.RichTextBox richTextBoxLink1;
    }
}

