using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CatalogApi.Controllers
{
    [Route("api/currencies")]
    [ApiController]
    public class ValuesController : ControllerBase 
    {
    //GET API /currencies
    [HttpGet,Route("")]
    public ActionResult<IEnumerable<string>> Get ()
    {
        return new string[] {"MYR","SGD","USD"};
    }}

}