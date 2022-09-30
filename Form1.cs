using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practiceCalendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void testButton_Click(object sender, EventArgs e)
        {
            
            // sets the days of the week
            string[] daysOfWeek = System.Globalization.DateTimeFormatInfo.CurrentInfo.DayNames;


            int daysOfMonth = DateTime.DaysInMonth(2022, 9);
            DateTime todaysDate = DateTime.Today;
            //MessageBox.Show(todaysDate.ToShortDateString());
            int[,] dayArray = new int[5, 7];
            Label[] labelArray = new Label[40];
            string[] dayNames = new string[7] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Firday", "Saturday" };

            // counter is used to set the days
            int counter = 0;


            for (int i = 0; i < 5; i++)
            {
               for (int j = 0; j < 7; j++)
                {
                    // initialize with number
                    dayArray[i, j] = ++counter;

                    // initialize labels for numbers
                    labelArray[j] = new Label();
                    this.Controls.Add(labelArray[j]);

                    labelArray[j].Text = dayArray[i, j].ToString();
                    labelArray[j].Visible = true;
                    labelArray[j].Size = new Size(50, 50);
                    labelArray[j].Location = new Point(j * 245 + 100, 225 + (i * 225));
                    labelArray[j].Font = new Font("Ariel", 16, FontStyle.Regular);
                    //labelArray[j].BackColor = Color.Gray;
                }
            }

            

            // places the days of the weeks 
            Label[] l2 = new Label[7];
            for (int i = 0; i < daysOfWeek.Length; i++)
            {
                l2[i] = new Label();
                this.Controls.Add(l2[i]);
                l2[i].Text = daysOfWeek[i];
                l2[i].Visible = true;
                l2[i].Size = new Size(175, 125);
                l2[i].Location = new Point(i * 245 + 100, 100);
                l2[i].Font = new Font("Ariel", 16, FontStyle.Regular);
            }


            /*
            Transaction t1 = new Transaction();
            t1.setDate(9, 6, 2011, 11, 51, 45);
            t1.setDescription("Food");
            t1.setPrice(10);
            MessageBox.Show($"{t1.getDate().ToString()} Description: {t1.getDescription()} Price: {t1.getPrice()}");
            */
        }
    }
}
