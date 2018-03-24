using System;

namespace Module_2_Exception_Handling_Task2
{
    //В 
    public interface IProcessString
    {
        int? ConvertStringToInt(string enteredString);
    }
    public class ProcessString : IProcessString
    {
        public int? ConvertStringToInt(string enteredString)
        {
            int resultNumber = 0;
            bool negativeNumber=false ;
            var charsArray = enteredString.ToCharArray();
            try
            {
                for (int i = 0; i < charsArray.Length; i++)
                {
                    if (charsArray[i] == '-' && i == 0)
                    {
                        negativeNumber = true;
                        continue;
                    }
                    var p = (int) charsArray[i];
                    if (p > 57 || p < 48)
                    {
                        throw new InvalidCastException();
                    }
                    resultNumber += ((int)charsArray[i] - '0') * (int)(Math.Pow(10, charsArray.Length - i - 1));
                }
                if (negativeNumber)
                    resultNumber *= -1;

            }
            catch (InvalidCastException)
            {
                // not sure what way is better for class library 
                // to throw exception up or return null value (int?)
                throw new StringCanNotBeConvertedToInt("String should consist of numbers");
            }
            return resultNumber;
        }
    }
}
