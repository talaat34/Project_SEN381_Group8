using System;
using System.Text.RegularExpressions;
using System.Windows.Threading;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace SEN381_Project_Call_Center_Group_8
{
    class commonMethods
    {
        //This is for getting the text height in a label
        public int getTextHeight(Label lbl)
        {
            using (Graphics g = lbl.CreateGraphics())
            {
                SizeF size = g.MeasureString(lbl.Text, lbl.Font, 400);
                return (int)Math.Ceiling(size.Height);
            }
        }

        //This is for the alert functionality
        public bool checkForLetters(string wordToBeChecked)
        {
            string pattern = @"[a-zA-Z]";
            if (Regex.IsMatch(wordToBeChecked, pattern) == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //This is for the custom ALERT BOX
        public void alertt(string msg)
        {
            alert frm = new alert();
            frm.showAlert(msg);
        }

        //This is for waiting some time
        public void delaySomeTime(int millisecond, Action act)
        {
            var timer = new DispatcherTimer();
            timer.Tick += delegate
            {
                act.Invoke();
                timer.Stop();
            };
            timer.Interval = TimeSpan.FromMilliseconds(millisecond);
            timer.Start();
        }
        
        //This is for generating user unique id when registration
        public string generateUserID(string name, string surname)
        {
            string firstTwoLettters = name.Substring(0, 2).ToUpper();
            string secondTwoLetters = surname.Substring(0, 2).ToUpper();
            string uniqueNumber = DateTime.Now.Ticks.ToString().Substring(0, 11);
            string uniqueID = firstTwoLettters + secondTwoLetters + uniqueNumber;
            return uniqueID;
        }

        public int generateRandomNumber(int strt, int end)
        {
            Random random = new Random();
            int randomNum = random.Next(strt, end);
            return randomNum;
        }

        public string generateID(int length)
        {
            Random rand = new Random();
            string id = string.Empty;
            for (int i = 0; i < 15; i++)
            {
                id = string.Concat(id, rand.Next(length).ToString());
            }
            return id;
        }

        public string date_time()
        {
            DateTime dt = DateTime.Now;
            string datetimeFormat = dt.ToString("yyyy-MM-dd HH:mm:ss");
            return datetimeFormat;
        }
    }
}
