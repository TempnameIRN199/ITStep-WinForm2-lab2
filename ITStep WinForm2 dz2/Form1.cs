using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITStep_WinForm2_dz2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void button_Find(object sender, EventArgs e)
        {
            int day = int.Parse(textBoxDay.Text);
            int month = int.Parse(textBoxMonth.Text);
            int year = int.Parse(textBoxYear.Text);

            DateTime birthday = new DateTime(year, month, day);

            monthCalendar1.SelectionStart = birthday;
            monthCalendar1.SelectionEnd = birthday;
        }
    }
}
