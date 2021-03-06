﻿using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Globalization;

namespace MyTaskCreater
{
    
    public partial class myTaskMain : Form
    {
        public myTaskMain()
        {
            InitializeComponent();
        }

        string iniPath = Directory.GetCurrentDirectory() + "\\ini\\myTask.ini";
        DateTime today = DateTime.Now;
        int theWeek = 0;
        string currentPath = string.Empty;
        string yearStr = string.Empty;
        string weelyStr = string.Empty;
        string dateStr = string.Empty;

        

        private void MyTaskMain_Load(object sender, EventArgs e)
        {
            checkIniFileExisting();
            ChangeFormLocation();
            DirectoryInfo iniPathDirInfo = new DirectoryInfo(iniPath);
            useWeeklyCheckBox.Checked = true;
            RefreshTaskPath();
        }

        private void ChangeFormLocation()
        {
            int iActulaWidth = Screen.PrimaryScreen.Bounds.Width;
            int iActulaHeight = Screen.PrimaryScreen.Bounds.Height;
            this.Left = iActulaWidth / 2 - this.Size.Width / 2;
            this.Top = iActulaHeight / 2 - this.Size.Height / 2;
        }

        private void checkIniFileExisting()
        {
            FileInfo iniFile = new FileInfo(iniPath);
            if (!iniFile.Exists)
            {
                string template = iniFile + "\n[Global]\nPath=C:\\MyFolder";
                MessageBox.Show(iniFile + " is not found.","Init Error");
                MessageBox.Show("Please follow below sample to build:\n" + template);
                System.Environment.Exit(0);
            }
        }
        private void RefreshDateStr()
        {
            dateStr = today.ToString("MMdd");
        }

        private void RefreshYearStr()
        {
            yearStr = today.ToString("yyyy");
        }

        private void RefreshWeekStr()
        {
            CultureInfo myCI = new CultureInfo("en-US");
            Calendar myCal = myCI.Calendar;
            CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;
            theWeek = myCal.GetWeekOfYear(today, myCWR, DayOfWeek.Monday);
            myCal.GetDayOfWeek(today);
            int firstDayOfWeekDiff = GetStartDate(this.today);
            string firstDayOfWeekDateStr = this.today.AddDays(-firstDayOfWeekDiff).ToString("MMdd");
            string lastDayOfWeekDateStr = this.today.AddDays(-firstDayOfWeekDiff).AddDays(6).ToString("MMdd"); ;
            weeklyTextBox.Text = "WW" + theWeek.ToString().PadLeft(2, '0') + " " + firstDayOfWeekDateStr + "-" + lastDayOfWeekDateStr;
            RefreshWeeklyStr();
            
        }

        private int GetStartDate(DateTime dt)
        {
            int currentIndex = 0;

            switch (Convert.ToInt32(dt.DayOfWeek))
            {
                case 0: currentIndex = 6;
                    break;
                case 1: currentIndex = 0;
                    break;
                case 2: currentIndex = 1;
                    break;
                case 3: currentIndex = 2;
                    break;
                case 4: currentIndex = 3;
                    break;
                case 5: currentIndex = 4;
                    break;
                case 6: currentIndex = 5;
                    break;
            }
            int beginIndex = currentIndex;

            return beginIndex;
        }

        private void RefreshWeeklyStr()
        {
            if (useWeeklyCheckBox.Checked)
            {

                weelyStr = "\\" + weeklyTextBox.Text;
            }
            else
            {
                weelyStr = string.Empty;
            }
        }


        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string value, string filepath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder returnvalue, int intbuffersize, string filepath);

        private void writeIni(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, iniPath);
        }

        private string readIniValue(string section, string key)
        {
            StringBuilder valueBuilder = new StringBuilder(255);
            GetPrivateProfileString(section,key,"None",valueBuilder,255,iniPath);
            return valueBuilder.ToString();
        }
        private void RefreshTaskPath()
        {
            string taskPath = readIniValue("Global", "Path").Trim().TrimEnd('\\');
            if (taskPath.Length == 0)
            {
                MessageBox.Show("read ini format error. not found value Global.Path. Please check.");
                System.Environment.Exit(1);
            }
            currentPath = taskPath;
            taskPathTextBox.Text = taskPath + "\\" + yearStr;
            DirectoryInfo taskDirInfo = new DirectoryInfo(taskPath);
            if (!taskDirInfo.Exists)
            {
                try
                {
                    taskDirInfo.Create();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void DoIt_Butten_Click(object sender, EventArgs e)
        {
            DirectoryInfo myDirInfo = new DirectoryInfo(taskPathTextBox.Text.Trim());
            if (!myDirInfo.Exists)
            {
                try
                {
                    myDirInfo.Create();
                    FileInfo myFile = new FileInfo(myDirInfo.FullName + "\\" + taskTitleTextBox.Text.Trim() + ".md");
                    FileStream myFileStream = myFile.Create();
                    myFileStream.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            taskTitleTextBox.Text = "";
            RefreshTaskPath();
        }

        private void useWeeklyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            refreshDateAndStr();
        }

        private void currentDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            refreshDateAndStr();
        }

        private void refreshDateAndStr()
        {
            this.today = DateTime.Parse(currentDateTimePicker.Text);
            RefreshYearStr();
            RefreshWeekStr();
            RefreshDateStr();
            FillTaskPath();
        }

        private void taskTitleTextBox_TextChanged(object sender, EventArgs e)
        {
            FillTaskPath();
        }

        private void FillTaskPath()
        {
            if (!string.IsNullOrEmpty(taskTitleTextBox.Text.Trim()))
            {
                taskPathTextBox.Text = currentPath + "\\" + yearStr + weelyStr + "\\" + dateStr + " " + taskTitleTextBox.Text.Trim();
            }
            else
            {
                taskPathTextBox.Text = currentPath + "\\" + yearStr + weelyStr;
            }
        }

        private void myTaskMain_Activated(object sender, EventArgs e)
        {
            taskTitleTextBox.Focus();
            refreshDateAndStr();
        }
    }
}
