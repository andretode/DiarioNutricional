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
        private RefeicaoRepository refeicaoRepository;

        private RefeicaoService()
        {
            refeicaoRepository = RefeicaoRepository.GetInstance();
        }

        public static RefeicaoService GetInstance()
        {
            if (_instance == null)
                _instance = new RefeicaoService();

            return _instance;
        }

        public Refeicao GetRefeicaoDoDia(DateTime data, TipoRefeicao tipoRefeicao)
        {
            var refeicao = refeicaoRepository.GetByDia(data, tipoRefeicao);
            var porcaoRepository = PorcaoRepository.GetInstance();
            refeicao.Porcoes = porcaoRepository.GetByRefeicaoId(refeicao.RefeicaoId).ToList();
            return refeicao;
        }

        public void AdicionaPorcao(TipoRefeicao tipoRefeicao, DateTime data, Porcao porcao)
        {
            Refeicao refeicao = refeicaoRepository.GetByDia(data, tipoRefeicao);

            if (refeicao == null)
            {
                refeicao = new Refeicao { TipoRefeicaoId = tipoRefeicao };
                refeicao.SetData(data);
                refeicao.RefeicaoId = refeicaoRepository.Add(refeicao);
            }

            porcao.RefeicaoId = refeicao.RefeicaoId;
            porcao.AlimentoId = porcao.Alimento.Codigo;
            var porcaoRepository = PorcaoRepository.GetInstance();
            porcaoRepository.Add(porcao);
        }
    }
}
