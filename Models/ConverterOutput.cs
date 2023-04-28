
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
#nullable disable
namespace UnitConverterMOMTest.Models
{
     
    public class ConverterOutput
    {
        //[Key]
        //public Int64 ID { get; set; }
        public string Unit { get; set; }
        public string Type { get; set; }
        public string Class { get; set; }
       
        public double? Value { get; set; }

    }
}
