using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpdateJinny
{
    public partial class NewsDescriptionUI : MetroFramework.Forms.MetroForm
    {
        MainForm m1;
        public NewsDescriptionUI(MainForm m1)
        {
            this.m1 = m1;
            InitializeComponent();
            richTextBoxDesp.Text = m1.richTextBox1.Text;
        }
    }
}
