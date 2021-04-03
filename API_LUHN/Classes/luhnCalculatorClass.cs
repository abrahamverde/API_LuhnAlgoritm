using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_LUHN.Classes
{
    public class luhnCalculatorClass
    {
        public String calculateFinalDigit(String LuhnNumber)
        {
            try
            {

                //REVERSE THE ORIGN NUMBER
                List<char> originalNumber = LuhnNumber.Reverse().ToList();
                //
                Int32 finalSum = 0;
                //
                Boolean parity = true;

                //FOREACH NUMBER, CALCULATE FINAL SUM
                originalNumber.ForEach(item =>
                {
                //CAST
                Int32 number = Convert.ToInt32(item.ToString());


                    if (parity == true)
                    {
                    //MULTIPLY BY TWO
                    number = number * 2;

                    //IF NUMBER IS GREATER THAN 9, SO SUBSTRACT IT
                    number = (number > 9) ? (number - 9) : number;

                    }


                //POPULATE SUM VARIABLE
                finalSum = finalSum + number;

                //CHANGE PARITY
                parity = !parity;

                });


                //CONTROL DIGIT - FINAL DIGIT
                Int32 controlDigit = (finalSum * 9) % 10;


                //RETURN CONTROL DIGIT
                return controlDigit.ToString();



            }catch(Exception EX)
            {
                return EX.Message;
            }

        }


    }
}
