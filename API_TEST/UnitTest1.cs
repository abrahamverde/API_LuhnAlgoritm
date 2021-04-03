using Microsoft.VisualStudio.TestTools.UnitTesting;
using API_LUHN.Controllers;
using API_LUHN.Classes;
using Microsoft.AspNetCore.Mvc;


namespace API_TEST
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodCalculateFinalDigit()
        {
            luhnCalculatorClass objCalculator = new luhnCalculatorClass();

            //
            Assert.IsTrue(objCalculator.calculateFinalDigit("7992739871").Equals("3"));
            //
            
            Assert.IsTrue(objCalculator.calculateFinalDigit("637530839309409").Equals("0"));
            //


        }


        [TestMethod]
        public void TestMethodGenerateLuhnNumber()
        {
            //CONTROLLER OBJECT
            apiController objController = new apiController();


            //EXECUTE
            ObjectResult result = (ObjectResult)objController.generateLuhnNumber().Result;
            //
            apiResponse_generate objResponse = (apiResponse_generate)result.Value;

            //
            Assert.IsTrue(objResponse.generatedLuhnNumber.Length == 16);
            //
            Assert.IsNotNull(objResponse.generatedLuhnNumber);

        }



        [TestMethod]
        public void TestMethodValidateLuhnNumber()
        {
            //CONTROLLER OBJECT
            apiController objController = new apiController();



            //GENERATE
            ObjectResult resultado = (ObjectResult) objController.generateLuhnNumber().Result;
            //
            apiResponse_generate objResponse = (apiResponse_generate)resultado.Value;



            //EXECUTE VALIDATION
            apiRequest objRequest = new apiRequest()
            {
                luhnNumber = objResponse.generatedLuhnNumber
            };

            ObjectResult validateResult = (ObjectResult)objController.validateLuhnNumber(objRequest).Result;
            //
            apiResponse_validate objResponseValidate = (apiResponse_validate) validateResult.Value;


            //
            Assert.IsTrue(objResponseValidate.validation);
            //


        }






    }
}
