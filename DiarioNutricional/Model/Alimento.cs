
namespace DiarioNutricional.Model
{
    public class Alimento
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public decimal EnergiaKcal { get; set; }
        public decimal ProteinasEmGramas { get; set; }
        public decimal CarboidratosEmGramas { get; set; }
        public decimal GordurasEmGramas { get; set; }
    }
}
