using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using UnitConverterMOMTest.Data;
using UnitConverterMOMTest.Models;
using UnitConverterMOMTest.Services;

namespace UnitConverterMOMTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConverterOutputController : ControllerBase
    {
        private IConverter _IConverter;

        public ConverterOutputController(IConverter ConverterService)
        {
            _IConverter = ConverterService;
        }

        // GET: api/ConverterOutput
        [HttpPost]
        [Route("Convert")]
        public  Task<IEnumerable<ConverterOutput>> Getconverter(ConverterInput input)
        {
            return  _IConverter.ConvertAny(input);
        }

    }
}
