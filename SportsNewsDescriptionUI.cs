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
    public partial class SportsNewsDescriptionUI : MetroFramework.Forms.MetroForm
    {
        MainForm m2;
        public SportsNewsDescriptionUI(MainForm m2)
        {
            this.m2 = m2;
            InitializeComponent();
            richTextBoxDesp.Text = m2.richTextBox2.Text;
        }
    }
}
