using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace FindDate
{
    public partial class Form1 : Form
    {
        public Form1()

        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Günlük");
            comboBox1.Items.Add("Haftalýk");
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox1.SelectedIndex == 0)
            {
                for(int i = 1; i < 32; i++) 
                {
                    comboBox2.Items.Add(i + " Günlük" );
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                for (int i = 1; i < 9; i++)
                {
                    comboBox2.Items.Add(i + " Haftalýk");
                }

            }

        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

            DateTime StartDate = monthCalendar1.SelectionRange.Start;
        }
        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {

            DateTime EndDate = monthCalendar2.SelectionRange.Start;

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (comboBox1.SelectedIndex == 0)
            {
                DateTime StartDate = monthCalendar1.SelectionRange.Start;
                DateTime EndDate = monthCalendar2.SelectionRange.Start;
                int Day = comboBox2.SelectedIndex + 1;
                for (DateTime theDate = StartDate; theDate <= EndDate; theDate = theDate.AddDays(Day))
                {
                    listBox1.Items.Add(theDate);
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                DateTime StartDate = monthCalendar1.SelectionRange.Start;
                DateTime EndDate = monthCalendar2.SelectionRange.Start;
                int Week = comboBox2.SelectedIndex+1;
                int Day = Week * 7;
                for (DateTime theDate = StartDate; theDate <= EndDate; theDate = theDate.AddDays(Day))
                {
                    listBox1.Items.Add(theDate);
                }

                DayOfWeek StartDate2 = monthCalendar1.SelectionRange.Start.DayOfWeek;
                DayOfWeek EndDate2 = monthCalendar2.SelectionRange.Start.DayOfWeek;

                switch (StartDate2)
                {
                    case DayOfWeek.Monday:
                        button1.BackColor = Color.Red;
                        break;
                    case DayOfWeek.Tuesday:
                        button2.BackColor = Color.Red;
                        break;
                    case DayOfWeek.Wednesday:
                        button3.BackColor = Color.Red;
                        listBox1.Items.Add(StartDate);
                        break;
                    case DayOfWeek.Thursday:
                        button4.BackColor = Color.Red;
                        break;
                    case DayOfWeek.Friday:
                        button5.BackColor = Color.Red;
                        break;
                    case DayOfWeek.Saturday:
                        button6.BackColor = Color.Red;
                        break;
                    case DayOfWeek.Sunday:
                        button7.BackColor = Color.Red;
                        break;
                }

                switch (EndDate2)
                {
                    case DayOfWeek.Monday:
                        button1.BackColor = Color.Red;
                        break;
                    case DayOfWeek.Tuesday:
                        button2.BackColor = Color.Red;
                        break;
                    case DayOfWeek.Wednesday:
                        button3.BackColor = Color.Red;
                        break;
                    case DayOfWeek.Thursday:
                        button4.BackColor = Color.Red;
                        break;
                    case DayOfWeek.Friday:
                        button5.BackColor = Color.Red;
                        break;
                    case DayOfWeek.Saturday:
                        button6.BackColor = Color.Red;
                        break;
                    case DayOfWeek.Sunday:
                        button7.BackColor = Color.Red;
                        break;
                }

                listBox1.Items.Add(StartDate);
                listBox1.Items.Add(EndDate);

            }
        }
    }
}