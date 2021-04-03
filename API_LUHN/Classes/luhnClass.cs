using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_LUHN.Classes
{
    public class luhnClass
    {

        public String generate()
        {
            //GET RANDOM VALUE 15 DIGITS
            String randomNumber = DateTime.UtcNow.Ticks.ToString().Substring(0, 15);


            //CALCULATE VERIFIED DIGIT
            String DV = new luhnCalculatorClass().calculateFinalDigit(randomNumber);


            //RETURN NUMBER
            return randomNumber + DV;

        }



        public Boolean validate(String value)
        {

            //GET LUHN NUMBER WITHOUT LAST DIGIT
            String luhnNumberGiven = value.Substring(0, value.Length - 1);
            String luhnDigitGiven = value.Substring(value.Length - 1);

            //CALCULATE VERIFIED DIGIT
            String DV = new luhnCalculatorClass().calculateFinalDigit(luhnNumberGiven);

            //CONTROL POINT
            if(DV.Length > 1)
            {
                //EXCEPTION OCURR
                throw new Exception(DV);

            }

            //RETURN VALIDATION
            if (luhnDigitGiven == DV)
            {
                return true;

            } else
            {
                return false;
            }
            
        }

    }
}
