
using System;

namespace DiarioNutricional.Model
{
    public class Alimento
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }

        private decimal energia;
        public decimal EnergiaKcal
        {
            get { return ArredondarValores(energia); }
            set { this.energia = value; }
        }

        private decimal proteinas;
        public decimal ProteinasEmGramas
        {
            get { return ArredondarValores(proteinas); }
            set { this.proteinas = value; }
        }

        private decimal carboidratos;
        public decimal CarboidratosEmGramas 
        {
            get { return ArredondarValores(carboidratos); }
            set { this.carboidratos = value; }
        }

        private decimal gorduras;
        public decimal GordurasEmGramas
        {
            get { return ArredondarValores(gorduras); }
            set { this.gorduras = value; }
        }

        private decimal ArredondarValores(decimal valor)
        {
            return Decimal.Round(valor, 3);
        }
    }
}
