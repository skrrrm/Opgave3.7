using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opgave3._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        
        private void buttonOk_Click(object sender, EventArgs e)
        {
            // Variables
            string _date = maskedTextBoxInput.Text;
            string _day = _date.Substring(0, 2);
            string _month = _date.Substring(3, 2);
            string _year = _date.Substring(6, 4);
            //string _monthText = "";
            //string changed_date = $"{_day}-{_month}-{_year}";

            switch (_month)
            {
                case "01":
                    _month = "January";
                    break;
                case "02":
                    _month = "February";
                    break;
                case "03":
                    _month = "March";
                    break;
                case "04":
                    _month = "April";
                    break;
                case "05":
                    _month = "May";
                    break;
                case "06":
                    _month = "June";
                    break;
                case "07":
                    _month = "July";
                    break;
                case "08":
                    _month = "August";
                    break;
                case "09":
                    _month = "September";
                    break;
                case "10":
                    _month = "Oktober";
                    break;
                case "11":
                    _month = "November";
                    break;
                case "12":
                    _month = "December";
                    break;
                default:
                    labelDate.Text = "Something went wrong!";
                    break;
            }
            labelDate.Text = $"The date is {_day}st of {_month} {_year}";
        }
    }
}
