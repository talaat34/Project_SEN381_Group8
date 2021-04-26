using System;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Threading;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace SEN381_Project_Call_Center_Group_8
{
    class commonMethods
    {
        //Objects - START
        Random rand = new Random();
        //Objects - END

        //This is a method that will contain a full list of conversations between the custimer
        //AND employee
        public List<SoundPlayer> customer_employee_conversation()
        {
            List<SoundPlayer> sp = new List<SoundPlayer>();

            //Loading calls into list
            SoundPlayer callOne = new SoundPlayer(@"C:\Users\user-pc\Desktop\TALAAT BCom 3rd YEAR\SEN381\Project\RESOURCES\sample_call_3_Trimmed.wav");
            SoundPlayer callTwo = new SoundPlayer(@"C:\Users\user-pc\Desktop\TALAAT BCom 3rd YEAR\SEN381\Project\RESOURCES\sample_call_4.wav");
            sp.Add(callOne);
            sp.Add(callTwo);

            return sp;
        }

        /*THIS METHOD IS TO GENERATE A RANDOM USER PHONE NUMBER - START*/
        public string phoneNumber()
        {
            StringBuilder phoneNumber = new StringBuilder(10);
            phoneNumber.Append("0");
            int number;

            //Creating the first two digits after the 'zero'
            for (int i = 0; i < 2; i++)
            {
                number = rand.Next(1, 9);
                phoneNumber = phoneNumber.Append(number.ToString());
            }

            //Creating the three middle numbers of the phone number
            number = rand.Next(100, 999);
            phoneNumber = phoneNumber.Append(number.ToString());

            //Creating the four last numbers of the phone number
            number = rand.Next(1000, 10000);
            phoneNumber = phoneNumber.Append(number.ToString());

            //Return the phone numebr
            return phoneNumber.ToString();
        }
        /*THIS METHOD IS TO GENERATE A RANDOM USER PHONE NUMBER - END*/

        //This is to generate user unique ID - Zero padding
        public string zeroAppend(string zeros_and_lastResord, int idLimit)
        {
            return zeros_and_lastResord.Substring(zeros_and_lastResord.Length - idLimit);
        }
        //This is also used to generate random letter for user ID
        public char randomLetter()
        {
            List<char> letters = new List<char>();
            letters.Add('A');
            letters.Add('B');
            letters.Add('C');
            letters.Add('D');
            letters.Add('E');

            Random rand = new Random();
            int index = rand.Next(letters.Count);

            char randomLetter = letters[index];
            return randomLetter; 
        }
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

        //THIS METHOD IS PRIMARILY USED FOR COLLECTIONS
        public int generateRandomColectionNumber(int collectionCount)
        {
            int number = rand.Next(collectionCount);
            return number;
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
