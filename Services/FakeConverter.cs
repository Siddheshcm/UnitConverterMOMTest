using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Plugins;
using UnitConverterMOMTest.Data;
using UnitConverterMOMTest.Models;

namespace UnitConverterMOMTest.Services
{
    public class FakeConverter : IConverter
    {

        private readonly List<ConverterOutput> _ConverterOutput;
        private readonly ConverterInput _ConverterInput;

        public FakeConverter()
        {
            _ConverterOutput = new List<ConverterOutput>()
            {
                new ConverterOutput() { Unit = "Foot", Type = "Imperial", Class = "Length", Value = 0.66 },
            };
            _ConverterInput = new ConverterInput()
            {
                Unit = "Centimeter",
                OutputUnit = "Foot",
                Inputvalue = 20,
                MetricORImperial = "Imperial"
            };

        }
        public Task<IEnumerable<ConverterOutput>> ConvertAny(ConverterInput converterInput)
        {
            return Task.FromResult<IEnumerable<ConverterOutput>>(_ConverterOutput);
        }


    }
}
