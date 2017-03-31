﻿using System;

namespace DiarioNutricional.Model
{
    public class Porcao
    {
        public int PorcaoId { get; set; }
        public int AlimentoId { get; set; }
        public virtual Alimento Alimento { get; set; }
        public int QuantidadeEmGramas { get; set; }
        public int RefeicaoId { get; set; }

        public string DescricaoAlimento
        {
            get { return Alimento.Descricao; }
        }

        public decimal QuantEnergia
        {
            get { return CalcularQuantidade(Alimento.EnergiaKcal); }
        }

        public decimal QuantCarboidratos
        {
            get { return CalcularQuantidade(Alimento.CarboidratosEmGramas); }
        }

        public decimal QuantProteinas
        {
            get { return CalcularQuantidade(Alimento.ProteinasEmGramas); }
        }

        public decimal QuantGorduras
        {
            get { return CalcularQuantidade(Alimento.GordurasEmGramas); }
        }

        private decimal CalcularQuantidade(decimal valorDoNutriente)
        {
            // A tabela TACO tem os valores nutricionais por cada 100g do alimento
            // assim precisamos dividir por 100 antes de multiplicar pelas gramas.
            return Decimal.Round(valorDoNutriente / 100 * QuantidadeEmGramas, 3);
        }
    }
}
