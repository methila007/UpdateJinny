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
    public partial class SettingsUI : MetroFramework.Forms.MetroForm
    {

        MainForm m1;
        MainFramework mf;
        string url;
        public SettingsUI(MainForm m1,MainFramework mf)
        {
            this.m1 = m1;
            this.mf = mf;
            InitializeComponent();
            this.StyleManager = msmMain;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "ddddd . MMM .    dd,yyyy";
            m1.DateLabel.Text = dateTimePicker1.Value.Day.ToString();
            m1.DayLabel.Text = dateTimePicker1.Value.DayOfWeek.ToString();
            m1.MonthLabel.Text = dateTimePicker1.Value.ToString("MMM");

            //m1.StyleManager = this.StyleManager;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SettingsUI_Load(object sender, EventArgs e)
        {
            using (var context = new UpdateJinnyDBEntities())
            {
                var countries = context.TableCityByCountries.Select(c => c.country).Distinct().ToList();
                comboBoxCountries.Items.AddRange(countries.ToArray());
            }
        }

        private void comboBoxCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var context = new UpdateJinnyDBEntities())
            {
                var rr = context.TableCityByCountries.Where(m => m.country == comboBoxCountries.Text).Select(c => c.city);
                comboBoxCities.Items.Clear();
                comboBoxCities.Items.AddRange(rr.ToArray());
            }
        }

        private void comboBoxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valuePass = Convert.ToString(comboBoxCities.Text);
            if (valuePass != null)
            {
                m1.labelCity.Text = valuePass;
                m1.recievedValueCity = valuePass;
                mf.GetWeather(valuePass);
                double temp = double.Parse(mf.weather[0].temperature) - 273.16;
                m1.WeatherLabel.Text = temp.ToString("N1") + "C";
            }
        }

        private void RadioButtonLight_CheckedChanged(object sender, EventArgs e)
        {
            msmMain.Theme = MetroFramework.MetroThemeStyle.Light;
            m1.msmMainForm.Theme = MetroFramework.MetroThemeStyle.Light;
        }

        private void RadioButtonDark_CheckedChanged(object sender, EventArgs e)
        {
            msmMain.Theme = MetroFramework.MetroThemeStyle.Dark;
            m1.msmMainForm.Theme = MetroFramework.MetroThemeStyle.Dark;
        }
        private void radioButtonYahoo_CheckedChanged(object sender, EventArgs e)
        {
            mf.allNews.Clear();

            url = "http://news.yahoo.com/rss/";
            m1.getNewsFirstRow(url);
            m1.labelSource.Text = "Yahoo:";
            m1.groupBoxTopRow.Refresh();
        }

        private void radioButtonBBC_CheckedChanged(object sender, EventArgs e)
        {
            mf.allNews.Clear();
            
            url = "http://feeds.bbci.co.uk/news/world/rss.xml";
            m1.getNewsFirstRow(url);
            m1.labelSource.Text = "BBC:";
            m1.groupBoxTopRow.Refresh();
        }

        private void radioButtonCNN_CheckedChanged(object sender, EventArgs e)
        {
            mf.allNews.Clear();
           
            url = "http://rss.cnn.com/rss/edition.rss";
            m1.getNewsFirstRow(url);
            m1.labelSource.Text = "CNN:";
            m1.groupBoxTopRow.Refresh();
        }

        private void radioButtonDS_CheckedChanged(object sender, EventArgs e)
        {
            mf.allNews.Clear();
            
            url = "http://www.dailystar.com.lb/RSS.aspx?live=1";
            m1.getNewsFirstRow(url);
            m1.labelSource.Text = "Daily Star:";
            m1.groupBoxTopRow.Refresh();
        }

        private void radioButtonCI_CheckedChanged(object sender, EventArgs e)
        {
            mf.allNews.Clear();
            
            url = "http://www.espncricinfo.com/rss/content/story/feeds/25.xml";           
            m1.getNewsFirstRow(url);      
            m1.labelSource.Text = "CricInfo:";
            m1.groupBoxTopRow.Refresh();
        }

        

        private void radioButtonWN_CheckedChanged(object sender, EventArgs e)
        {
            mf.allNewsMiddle.Clear();
            url = "http://www.dailystar.com.lb/RSS.aspx?id=113";
            m1.getNewsSecondRow(url);
            m1.labelCategory.Text = "World News:";
            m1.groupBoxMiddleRow.Refresh();

        }

        private void radioButtonBusi_CheckedChanged(object sender, EventArgs e)
        {
            mf.allNewsMiddle.Clear();
            
            url = "http://www.dailystar.com.lb/RSS.aspx?id=109";
            m1.getNewsSecondRow(url);
            m1.labelCategory.Text = "Business:";
            m1.groupBoxMiddleRow.Refresh();
        }

        private void radioButtonNational_CheckedChanged(object sender, EventArgs e)
        {
            //mf.allNewsMiddle.Clear();
            //m1.groupBoxMiddleRow.Refresh();
            //m1.getNewsFirstRow("feeds.bbci.co.uk/news/world/rss.xml");
            //m1.labelCategory.Text = "National:";
        }

        private void radioButtonTT_CheckedChanged(object sender, EventArgs e)
        {
            mf.allNewsMiddle.Clear();           
            url = "http://www.dailystar.com.lb/RSS.aspx?id=121";
            m1.getNewsSecondRow(url);
            m1.labelCategory.Text = "Travel & Tourism:";
            m1.groupBoxMiddleRow.Refresh();
        }

        private void radioButtonEnt_CheckedChanged(object sender, EventArgs e)
        {
            mf.allNewsMiddle.Clear();            
            url = "http://www.dailystar.com.lb/RSS.aspx?id=192";
            m1.getNewsSecondRow(url);
            m1.labelCategory.Text = "Entertainment:";
            m1.groupBoxMiddleRow.Refresh();
        }

        private void radioButtonCric_CheckedChanged(object sender, EventArgs e)
        {
            mf.allNewsMiddle.Clear();           
            url = "http://feeds.bbci.co.uk/sport/0/cricket/rss.xml?edition=uk";
            m1.getNewsSecondRow(url);
            m1.labelCategory.Text = "Cricket:";
            m1.groupBoxMiddleRow.Refresh();
        }

        private void radioButtonFootball_CheckedChanged(object sender, EventArgs e)
        {
            mf.allNewsMiddle.Clear();           
            url = "http://www.dailystar.com.lb/RSS.aspx?id=117";
            m1.getNewsSecondRow(url);
            m1.labelCategory.Text = "Football:";
            m1.groupBoxMiddleRow.Refresh();
        }

        private void radioButtonTech_CheckedChanged(object sender, EventArgs e)
        {
            mf.allNewsMiddle.Clear();            
            url = "http://www.dailystar.com.lb/RSS.aspx?id=188";
            m1.getNewsSecondRow(url);
            m1.labelCategory.Text = "Sci and Tech:";
            m1.groupBoxMiddleRow.Refresh();
        }
    }
}
