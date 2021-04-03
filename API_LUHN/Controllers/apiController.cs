using Microsoft.AspNetCore.Mvc;
using System;
using API_LUHN.Classes;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_LUHN.Controllers
{
    [Route("api/")]
    [ApiController]
    public class apiController : ControllerBase
    {
        // GET: api/<apiController>
        [HttpGet]
        [Route("generateLuhnNumber")]
        public ActionResult<apiResponse_generate> generateLuhnNumber()
        {
            //LUHN OBJECT
            luhnClass objLuhn = new luhnClass();

            try
            {
                //GENERATE
                String luhnGenerated = objLuhn.generate();


                //RETURN OK
                return StatusCode(200, new apiResponse_generate()
                {
                    generatedLuhnNumber = luhnGenerated,
                    timeStamp = DateTime.Now

                });


            }catch(Exception Ex)
            {
                return StatusCode(500, Ex.Message);
            }

        }



        // POST api/<apiController>
        [HttpPost]
        [Route("validateLuhnNumber")]
        public ActionResult<apiResponse_validate> validateLuhnNumber(apiRequest objRequest)
        {

            try
            {

                //VALIDATE
                Boolean resultValidation = new luhnClass().validate(objRequest.luhnNumber);

                //RETURN INFORMATION
                return StatusCode(200, new apiResponse_validate()
                {

                    LuhnNumberGiven = objRequest.luhnNumber,
                    validation = resultValidation,
                    timeStamp = DateTime.Now

                });

            } catch (Exception Ex)
            {
                return StatusCode(500, Ex.Message);
            }

        }

        
    }
}
