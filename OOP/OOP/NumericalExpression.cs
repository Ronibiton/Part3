using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class NumericalExpression
    {
        private long _number { get; set; }

        public NumericalExpression(long number)
        {
            _number = number;
        }

        private string Units(string num)
        {
            string number = num.ToString();
            switch (number)
            {
                case "0":
                    return "";
                case "1":
                    return "One";
                case "2":
                    return "Two";
                case "3":
                    return "Three";
                case "4":
                    return "Four";
                case "5":
                    return "Five";
                case "6":
                    return "Six";
                case "7":
                    return "Seven";
                case "8":
                    return "Eight";
                case "9":
                    return "Nine";
            }
            return "Not a valid number";
        }

        private string Tens(string number)
        {
            switch (number)
            {
                case "10":
                    return "Ten";
                case "11":
                    return "Eleven";
                case "12":
                    return "Twelve";
                case "13":
                    return "Thirteen";
                case "14":
                    return "Fourteen";
                case "15":
                    return "Fifteen";
                case "16":
                    return "Sixteen";
                case "17":
                    return "Seventeen";
                case "18":
                    return "Eighteen";
                case "19":
                    return "Nineteen";
            }
            return "Not a valid number";
        }


        private string MultiplesOf10(string number)
        {
            switch (number)
            {
                case "0":
                    return "";
                case "2":
                    return "Twenty";
                case "3":
                    return "Thirty";
                case "4":
                    return "Fourty";
                case "5":
                    return "Fifty";
                case "6":
                    return "Sixty";
                case "7":
                    return "Seventy";
                case "8":
                    return "Eighty";
                case "9":
                    return "Ninety";
            }
            return "Not a valid number";
        }

        private string LargeNumbers(long num)
        {
            string number = num.ToString();
            switch (number)
            {
                case "0":
                    return "";
                case "1":
                    return " Hundred ";
                case "2":
                    return " Thousand ";
                case "3":
                    return " Million ";
                case "4":
                    return " Billion ";
            }
            return "";
        }

        private string[] SplitNumber(string number)
        {
            string[] splitedNumber = number.Split(',');
            return splitedNumber;
        }

        private string[] NumberAfterArrangement(string[] number)
        {
            for (int i = 0; i < number.Length; i++)
            {

                if (number[i].Count(f => f == '0') == 3)
                {
                    number[i] = "";
                    break;
                }
                if (number[i][0] == '0')
                {
                    number[i] = number[i].Remove(0, 1);
                }
                if (number[i][0] == '0')
                {
                    number[i] = number[i].Remove(0, 1);
                }
            }
            return number;
        }

        private string Hundred(string number)
        {
            string numberInWords = "";
            if (number == "")
            {
                return "";
            }
            numberInWords += Units(number[0].ToString()) + LargeNumbers(1);
            
            if (number[1].ToString() == "0" && number[2].ToString() == "0")
            {
                return numberInWords ;
            }
            numberInWords += "and ";
            if (number[1].ToString() == "0")
            {
                numberInWords += Units(number[2].ToString());
            }
            else if (number[1].ToString() == "1")
            {
                numberInWords += Tens(number.Remove(0, 1));
            }
            else
            {
                numberInWords += MultiplesOf10(number[1].ToString()) + " ";
                numberInWords += Units(number[2].ToString());
            }
            return numberInWords;
        }

        private string AddComma()
        {
            string number = _number.ToString();
            string newNumber = "";
            int count = number.Length-1;
            for (int i = 0;i < number.Length;i++)
            {
                newNumber += number[i];
                if (count % 3 == 0 && count!=0)
                {
                    newNumber += ",";
                }
                count--;
            }
            return newNumber;
        }

        private string ConvertNumber()
        {
            string numberInWords = "";
            string number = AddComma();
            if (number == "0")
            {
                return "Zero";
            }
            string[] arrNumber = NumberAfterArrangement(SplitNumber(number));
            int arrLength = arrNumber.Length;
            if (arrLength == 1)
            {
                if (number == "0")
                {
                    return "Zero";
                }
                if (number.Length ==1)
                {
                    return numberInWords += Units(number);
                }
                else if (number.Length ==2 && arrNumber[0][0].ToString() == "1")
                {
                    return numberInWords += Tens(number);
                }
                else if (number.Length == 2)
                {
                    return MultiplesOf10(number[0].ToString()) + " " + Units(number[1].ToString());
                }
            }
            for (int i = 0; i < arrNumber.Length; i++)
            {
                if (arrNumber[i] != "")
                {
                    if (i == arrNumber.Length - 1 && arrNumber[i].Length == 1)
                    {
                        numberInWords += "and " + Units(arrNumber[i]);
                    }
                    else if (arrNumber[i].Length == 1)
                    {
                        numberInWords += Units(arrNumber[i]) + LargeNumbers(arrLength);
                    }

                    else if (arrNumber[i].Length == 2)
                    {
                        if (arrNumber[i][0] == '1')
                        {
                            numberInWords += Tens(arrNumber[i]) + LargeNumbers(arrLength);
                        }
                        else
                        {
                            numberInWords += MultiplesOf10(arrNumber[i][0].ToString()) + " " + Units(arrNumber[i][1].ToString()) + LargeNumbers(arrLength);
                        }
                    }
                    else
                    {
                        if (arrLength > 1)
                        {
                            numberInWords += Hundred(arrNumber[i]) + LargeNumbers(arrLength);
                        }
                        else
                        {
                            numberInWords += Hundred(arrNumber[i]);
                        }
                    }
                }
                arrLength--;
            }
            return numberInWords;
        }

        public long GetValue()
        {
            return _number;
        }

        public override string ToString()
        {
            return ConvertNumber();
        }

        //העקרון הבא לידי ביטוי הוא פולימורפיזם
        //פולימורפיזם (עקרון הרב צורתיות) מאפשר הסתכלות על עצם אחד בכמה דרכים וההרצה תרוץ בהתאם לטיפוס עליו הוא עובד
        //עקרון הפולימורפיזם מכיל בתוכו את 
        //Overloading
        //אשר מאפשר שיהיו שתי פונקציות באותה ההמחלקה בעלות אותו השם אך שמקבלות טיפוסים ופרמטרים שונים
        //במילים אחרות פולימורפיזם סטטי
        //בזמן הריצה של הקוד, על פי טיפוס הפרמטרים המועברים לפונקציה תבחר ותרוץ הפונקציה הנכונה
        public static long SumLetters(long number)
        {
            if (number < 0)
            {
                return 0;
            }
            NumericalExpression num = new NumericalExpression(number);
            string numberWithoutSpaces = num.ToString().Replace(" ", "");
            return numberWithoutSpaces.Length + SumLetters(number - 1);
        }
        public static long SumLetters(NumericalExpression number)
        {
            if(number.GetValue()<0)
            {
                return 0;
            }
            string numberWithoutSpaces = number.ToString().Replace(" ", "");
            return numberWithoutSpaces.Length + SumLetters(new NumericalExpression(number.GetValue()-1));
        }


    }
}
