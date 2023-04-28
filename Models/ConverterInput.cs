#nullable disable
namespace UnitConverterMOMTest.Models
{
    public class ConverterInput
    {
        public string Unit { get; set; }
        public string OutputUnit { get; set; }
        public float? Inputvalue { get; set; }
        public string MetricORImperial { get; set; }
        //public string ConversionType { get; set; }

    }
}
