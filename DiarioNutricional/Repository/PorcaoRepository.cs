using DiarioNutricional.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiarioNutricional.Repository
{
    public class PorcaoRepository : AccessDatabaseRepository<Porcao>
    {
        private static PorcaoRepository _instance;

        private PorcaoRepository()
        {
        }

        public static PorcaoRepository GetInstance()
        {
            if (_instance == null)
                _instance = new PorcaoRepository();

            return _instance;
        }

        public int Add(Porcao porcao)
        {
            string sql = "INSERT INTO Porcao (AlimentoId, QuantidadeEmGramas, RefeicaoId) VALUES ({0},{1},{2})";
            sql = String.Format(sql, porcao.AlimentoId, porcao.QuantidadeEmGramas, porcao.RefeicaoId);
            return this.ExecuteSqlInsert(sql);
        }

        public IEnumerable<Porcao> GetByRefeicaoId(int RefeicaoId)
        {
            string sql = "SELECT PorcaoId, AlimentoId, QuantidadeEmGramas FROM Porcao"
                + " WHERE RefeicaoId={0}";
            sql = String.Format(sql, RefeicaoId);
            
            var porcoes = this.ExecuteSqlQuery(sql, CastPorcao);

            //inserir o alimento referenciado na porção
            foreach(var porcao in porcoes)
            {
                porcao.Alimento = AlimentoRepository.GetAll().Where(a => a.Codigo == porcao.AlimentoId).SingleOrDefault();
            }

            return porcoes;
        }

        private IEnumerable<Porcao> CastPorcao(List<IEnumerable<object>> valores)
        {
            var porcoes = new List<Porcao>();
            foreach (var linha in valores)
            {
                var porcao = new Porcao();
                porcao.PorcaoId = (Int32)linha.ElementAt(0);
                porcao.AlimentoId = (Int32)linha.ElementAt(1);
                porcao.QuantidadeEmGramas = (Int32)linha.ElementAt(2);
                porcoes.Add(porcao);
            }

            return porcoes;
        }
    }
}
