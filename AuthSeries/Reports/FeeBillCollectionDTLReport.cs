using System;
using DevExpress.XtraReports.Security;
using DevExpress.XtraReports.UI;

namespace StudentWebAPI.Reports
{
    public partial class FeeBillCollectionDTLReport : DevExpress.XtraReports.UI.XtraReport
    {
        public FeeBillCollectionDTLReport()
        {
            //ScriptPermissionManager.GlobalInstance = new ScriptPermissionManager(ExecutionMode.Unrestricted);
            InitializeComponent();
        }

        //private void Label78_PrintOnPage(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
        //{
        //    XRLabel label = (XRLabel)sender;
        //    //double AMOUNT = Convert.ToDouble(GetCurrentColumnValue("sumSum([AMOUNT])"));
        //    //string txt = changeToWords(AMOUNT.ToString());
        //    (sender as XRLabel).Text = "test";

        //}

        public static String changeToWords(String numb)
        {
            String val = "";
            String wholeNo = numb;
            String points = "";
            String andStr = "";
            String pointStr = "";
            String endStr = "";
            try
            {
                int decimalPlace = numb.IndexOf(".");
                if (decimalPlace > 0)
                {
                    wholeNo = numb.Substring(0, decimalPlace);
                    points = numb.Substring(decimalPlace + 1);
                    if (Convert.ToInt32(points) > 0)
                    {
                        andStr = "point";
                        // just to separate whole numbers from points  
                        pointStr = translateCents(points);
                    }
                }
                val = String.Format("{0} {1}{2} {3}", translateWholeNumber(wholeNo).Trim(), andStr, pointStr, endStr);

            }
            catch
            {

            }
            return val;
        }
        private static String translateWholeNumber(String number)
        {
            string word = "";
            try
            {
                bool beginsZero = false;
                //tests for 0XX  
                bool isDone = false;
                //test if already translated  
                double dblAmt = (Convert.ToDouble(number));
                //if ((dblAmt > 0) && number.StartsWith("0"))  
                if (dblAmt > 0)
                {
                    //test for zero or digit zero in a nuemric  
                    beginsZero = number.StartsWith("0");

                    int numDigits = number.Length;
                    int pos = 0;
                    //store digit grouping  
                    String place = "";
                    //digit grouping name:hundres,thousand,etc...  
                    switch (numDigits)
                    {
                        case 1:
                            //ones' range  
                            word = ones(number);
                            isDone = true;
                            break; // TODO: might not be correct. Was : Exit Select  
                        case 2:
                            //tens' range  
                            word = tens(number);
                            isDone = true;
                            break; // TODO: might not be correct. Was : Exit Select  
                        case 3:
                            //hundreds' range  
                            pos = (numDigits % 3) + 1;
                            place = " Hundred ";
                            break; // TODO: might not be correct. Was : Exit Select  
                        //thousands' range  
                        case 4:
                        case 5:
                        case 6:
                            pos = (numDigits % 4) + 1;
                            place = " Thousand ";
                            break; // TODO: might not be correct. Was : Exit Select  
                        //millions' range  
                        case 7:
                        case 8:
                        case 9:
                            pos = (numDigits % 7) + 1;
                            place = " Million ";
                            break; // TODO: might not be correct. Was : Exit Select  
                        case 10:
                            //Billions's range  
                            pos = (numDigits % 10) + 1;
                            place = " Billion ";
                            break; // TODO: might not be correct. Was : Exit Select  

                        default:
                            //add extra case options for anything above Billion...  
                            isDone = true;
                            break; // TODO: might not be correct. Was : Exit Select  

                    }
                    if (!isDone)
                    {
                        //if transalation is not done, continue...(Recursion comes in now!!)  
                        word = translateWholeNumber(number.Substring(0, pos)) + place + translateWholeNumber(number.Substring(pos));
                        //check for trailing zeros  
                        if (beginsZero)
                        {
                            word = " and " + word.Trim();
                        }
                    }
                    //ignore digit grouping names  
                    if (word.Trim().Equals(place.Trim()))
                    {
                        word = "";
                    }
                }

            }
            catch
            {

            }
            return word.Trim();
        }
        private static String tens(String digit)
        {
            int digt = Convert.ToInt32(digit);
            String name = null;
            switch (digt)
            {
                case 10:
                    name = "Ten";
                    break; // TODO: might not be correct. Was : Exit Select        \  
                case 11:
                    name = "Eleven";
                    break; // TODO: might not be correct. Was : Exit Select  
                case 12:
                    name = "Twelve";
                    break; // TODO: might not be correct. Was : Exit Select  
                case 13:
                    name = "Thirteen";
                    break; // TODO: might not be correct. Was : Exit Select  
                case 14:
                    name = "Fourteen";
                    break; // TODO: might not be correct. Was : Exit Select  
                case 15:
                    name = "Fifteen";
                    break; // TODO: might not be correct. Was : Exit Select  
                case 16:
                    name = "Sixteen";
                    break; // TODO: might not be correct. Was : Exit Select  
                case 17:
                    name = "Seventeen";
                    break; // TODO: might not be correct. Was : Exit Select  
                case 18:
                    name = "Eighteen";
                    break; // TODO: might not be correct. Was : Exit Select  
                case 19:
                    name = "Nineteen";
                    break; // TODO: might not be correct. Was : Exit Select  
                case 20:
                    name = "Twenty";
                    break; // TODO: might not be correct. Was : Exit Select  
                case 30:
                    name = "Thirty";
                    break; // TODO: might not be correct. Was : Exit Select  
                case 40:
                    name = "Fourty";
                    break; // TODO: might not be correct. Was : Exit Select  
                case 50:
                    name = "Fifty";
                    break; // TODO: might not be correct. Was : Exit Select  
                case 60:
                    name = "Sixty";
                    break; // TODO: might not be correct. Was : Exit Select  
                case 70:
                    name = "Seventy";
                    break; // TODO: might not be correct. Was : Exit Select  
                case 80:
                    name = "Eighty";
                    break; // TODO: might not be correct. Was : Exit Select  
                case 90:
                    name = "Ninety";
                    break; // TODO: might not be correct. Was : Exit Select  
                default:
                    if (digt > 0)
                    {
                        name = (tens(digit.Substring(0, 1) + "0") + " ") + ones(digit.Substring(1));
                    }
                    break; // TODO: might not be correct. Was : Exit Select  
            }
            return name;
        }
        private static String ones(String digit)
        {
            int digt = Convert.ToInt32(digit);
            String name = "";
            switch (digt)
            {
                case 1:
                    name = "One";
                    break; // TODO: might not be correct. Was : Exit Select  
                case 2:
                    name = "Two";
                    break; // TODO: might not be correct. Was : Exit Select  
                case 3:
                    name = "Three";
                    break; // TODO: might not be correct. Was : Exit Select  
                case 4:
                    name = "Four";
                    break; // TODO: might not be correct. Was : Exit Select  
                case 5:
                    name = "Five";
                    break; // TODO: might not be correct. Was : Exit Select  
                case 6:
                    name = "Six";
                    break; // TODO: might not be correct. Was : Exit Select  
                case 7:
                    name = "Seven";
                    break; // TODO: might not be correct. Was : Exit Select  
                case 8:
                    name = "Eight";
                    break; // TODO: might not be correct. Was : Exit Select  
                case 9:
                    name = "Nine";
                    break; // TODO: might not be correct. Was : Exit Select  

            }
            return name;
        }
        private static String translateCents(String cents)
        {
            String cts = "";
            String digit = "";
            String engOne = "";
            for (int i = 0; i <= cents.Length - 1; i++)
            {
                digit = cents[i].ToString();
                if (digit.Equals("0"))
                {
                    engOne = "Zero";
                }
                else
                {
                    engOne = ones(digit);
                }
                cts += " " + engOne;
            }
            return cts;
        }
    }
}
