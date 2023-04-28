using UnitConverterMOMTest.Data;
using UnitConverterMOMTest.Models;

namespace UnitConverterMOMTest.Services
{
    public class Converter : IConverter
    {

        private readonly ConverterDataAccess objConverterDataAccess;

        public Converter(ConverterDataAccess ConverterDA)
        {
            objConverterDataAccess = ConverterDA;
        }
        public async Task<IEnumerable<ConverterOutput>> ConvertAny(ConverterInput converterInput)
        {
           // ConverterDataAccess objConverterDataAccess = new ConverterDataAccess();
            return await objConverterDataAccess.GetConversion(converterInput);

        }

      
    }
}
