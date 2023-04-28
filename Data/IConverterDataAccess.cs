using UnitConverterMOMTest.Models;

namespace UnitConverterMOMTest.Data
{
    public interface IConverterDataAccess
    {
        public  Task<IEnumerable<ConverterOutput>> GetConversion(ConverterInput input);
    }
}
