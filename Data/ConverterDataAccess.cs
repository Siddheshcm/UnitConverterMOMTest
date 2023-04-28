using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using UnitConverterMOMTest.Models;

namespace UnitConverterMOMTest.Data
{
    public class ConverterDataAccess //: IConverterDataAccess
    {
        private readonly UnitConverterDBContext _context;

        public ConverterDataAccess(UnitConverterDBContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<ConverterOutput>> GetConversion(ConverterInput input)
        {

            //string StoredProc = "exec USP_UnitConversion " +
            //                   "@Unit = '" + input.Unit + "'," +
            //                   "@Inputvalue = " + input.Inputvalue + "," +
            //                   "@OutputUnit= '" + input.OutputUnit + "'," +
            //                   "@OutputType= '" + input.OutputType + "'," +
            //                   "@ConversionType= '" + input.ConversionType + "'";

            string StoredProc = "exec USP_UnitConversion @Unit ,@Inputvalue ,@OutputUnit,@MetricORImperial";


            var parameter = new List<SqlParameter>();
            parameter.Add(new SqlParameter("@Unit", input.Unit));
            parameter.Add(new SqlParameter("@Inputvalue", input.Inputvalue));
            parameter.Add(new SqlParameter("@OutputUnit", input.OutputUnit));
            parameter.Add(new SqlParameter("@MetricORImperial", input.MetricORImperial));
            //parameter.Add(new SqlParameter("@ConversionType", input.ConversionType));


            
                var data = await _context.converterOutput.FromSqlRaw(StoredProc, parameter.ToArray()).AsNoTracking().ToListAsync();
                return data;
            

        }

    }
}
