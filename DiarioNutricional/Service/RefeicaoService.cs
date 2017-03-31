using DiarioNutricional.Model;
using DiarioNutricional.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiarioNutricional.Service
{
    public class RefeicaoService
    {
        private static RefeicaoService _instance;
        private List<Refeicao> _todasRefeicoes;

        private RefeicaoService()
        {
            _todasRefeicoes = RefeicaoRepository.GetAll();
        }

        public static RefeicaoService GetInstance()
        {
            if (_instance == null)
                _instance = new RefeicaoService();

            return _instance;
        }

        public Refeicao GetRefeicaoDoDia(DateTime data, TipoRefeicao tipoRefeicao)
        {
            var refeicao = _todasRefeicoes.Where(r => r.Data == data.Date
                && r.TipoDeRefeicao == tipoRefeicao).SingleOrDefault();
            if(refeicao == null)
                refeicao = new Refeicao();

            return refeicao;
        }

        public Refeicao AdicionarPorcao(TipoRefeicao tipoRefeicao, DateTime data, Porcao porcao)
        {
            Refeicao refeicao = _todasRefeicoes.Where(r => (r.Data == data) && (r.TipoDeRefeicao == tipoRefeicao)).SingleOrDefault();

            if (refeicao == null)
            {
                refeicao = new Refeicao { TipoDeRefeicao = tipoRefeicao };
                refeicao.SetData(data);
                refeicao.Porcoes.Add(porcao);
            }

            return refeicao;
        }
    }
}
