using System;
using System.Collections.Generic;

namespace DiarioNutricional.Model
{
    public class Refeicao
    {
        public Refeicao()
        {
            Porcoes = new List<Porcao>();
        }

        public DateTime Data { get; private  set; }
        public TipoRefeicao TipoDeRefeicao { get; set; }
        public List<Porcao> Porcoes { get; set; }

        //Seta a data sem as horas
        public void SetData(DateTime data)
        {
            Data = data.Date;
        }
    }

    public enum TipoRefeicao { CafeDaManha, LancheDaManha, Almoco, LancheDaTarde, CafeDaTarde, Janta, Ceia }
}
