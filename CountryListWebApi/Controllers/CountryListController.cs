using CountryList.Application;
using CountryListWebApi;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace CountryList.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryListController : ControllerBase
    {

        private readonly ICheckDoc _checkDoc;
        //string countryCode;

        public CountryListController(ICheckDoc checkDoc)
        {
            _checkDoc = checkDoc;
        }

        [Route("{countryCode}")]
        [HttpGet]
        public string[] Get(string countryCode)
        {
            return _checkDoc.checkDocuments(countryCode);
        }
    }
}

