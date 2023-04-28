using UnitConverterMOMTest.Models;

namespace UnitConverterMOMTest.Services
{
    public interface IConverter
    {
      
        public  Task<IEnumerable<ConverterOutput>> ConvertAny(ConverterInput converterInput);

    }
}
