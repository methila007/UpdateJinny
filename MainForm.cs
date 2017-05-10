using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UpdateJinny.Framework;
using UpdateJinny.Entity;


namespace UpdateJinny
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        MainFramework mf = new MainFramework();

        public string recievedValueCity;
        public MainForm()
        {
            InitializeComponent();

            //timer for Time
            timerTime.Start();
            timerLiveScore.Start();
            //timerWeather.Start();

            DayLabel.Text = System.DateTime.Now.DayOfWeek.ToString();
            DateLabel.Text = DateTime.Now.ToString("dd");
            MonthLabel.Text = DateTime.Now.ToString("MMM");
            this.StyleManager = msmMainForm;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            mf.GetWeather(recievedValueCity);
            double temp = double.Parse(mf.weather[0].temperature) - 273.16;
            WeatherLabel.Text = temp.ToString("N1") + "C";

            getNewsFirstRow("http://feeds.bbci.co.uk/news/world/rss.xml");
            getNewsSecondRow("http://feeds.bbci.co.uk/sport/0/cricket/rss.xml?edition=uk");
            labelSource.Text = "BBC:";
            labelCategory.Text = "Cricket:";
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToString("h:mm \ntt");
        }

        public void getNewsFirstRow(string url)
        {
            mf.GetTopStories(url);
            topNewsLabel.Text = mf.allNews[0].title;
            richTextBox1.Text = mf.allNews[0].descp;
            richTextBoxLink1.Text = mf.allNews[0].link;

            timerNews.Interval = 20000;
            timerNews.Tick += new EventHandler(timerNews_Tick);
            timerNews.Start();
        }

        private void timerNews_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            int index = r.Next(0, mf.allNews.Count);

            topNewsLabel.Text = mf.allNews[index].title;
            richTextBox1.Text = mf.allNews[index].descp;
            richTextBoxLink1.Text = mf.allNews[index].link;
        }
        private void topNewsLabel_MouseClick(object sender, MouseEventArgs e)
        {
            NewsDescriptionUI des1 = new NewsDescriptionUI(this);
            des1.ShowDialog();
        }
        public void getNewsSecondRow(string url2)
        {
            mf.GetNewsMiddleRowNews(url2);
            SportsNewsLabel.Text = mf.allNewsMiddle[0].title;
            richTextBox2.Text = mf.allNewsMiddle[0].descp;
            richTextBoxLink2.Text = mf.allNewsMiddle[0].link;

            timerNews2.Interval = 20000;
            timerNews2.Tick += new EventHandler(timerNews2_Tick);
            timerNews2.Start();
        }

        private void timerNews2_Tick(object sender, EventArgs e)
        {
            Random r2 = new Random();
            int index2 = r2.Next(0, mf.allNewsMiddle.Count);

            SportsNewsLabel.Text = mf.allNewsMiddle[index2].title;
            richTextBox2.Text = mf.allNewsMiddle[index2].descp;
            richTextBoxLink2.Text = mf.allNewsMiddle[index2].link;
        }

        private void SportsNewsLabel_MouseClick(object sender, MouseEventArgs e)
        {
            SportsNewsDescriptionUI des2 = new SportsNewsDescriptionUI(this);
            des2.ShowDialog();
        }

        private void timerLiveScore_Tick(object sender, EventArgs e)
        {
            mf.GetLiveScore();
                matchStatusLabel.Text = mf.liveScore[0].matchStatus;
            
            if (mf.liveScore[0].sname1 == null && mf.liveScore[0].run1==null && mf.liveScore[0].wckts1==null && mf.liveScore[0].sname2==null
                && mf.liveScore[0].run2==null && mf.liveScore[0].wckts2==null)
            {
                liveScore1.Text = "started yet!!!";
                liveScore2.Text = "Match hasn't ";
                overCountLabel2.Text = " ";
                overCountLabel1.Text = " ";
            }
            else
            {
                liveScore1.Text = mf.liveScore[0].sname1 + ":" + mf.liveScore[0].run1 + "/" + mf.liveScore[0].wckts1;
                liveScore2.Text = mf.liveScore[0].sname2 + ":" + mf.liveScore[0].run2 + "/" + mf.liveScore[0].wckts2;
                overCountLabel2.Text = mf.liveScore[0].overs2 + " overs";
                overCountLabel1.Text = mf.liveScore[0].overs1 + " overs";
            }
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsUI s1 = new SettingsUI(this,mf);
            s1.Show();
        }

        private void buttonNet1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure?" , "Go To webpage", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)==DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(richTextBoxLink1.Text);
            }
        }

        private void buttonNet2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure?", "Go To webpage", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(richTextBoxLink2.Text);
            }
        }
    }
}
