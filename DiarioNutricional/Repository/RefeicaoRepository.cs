using DiarioNutricional.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiarioNutricional.Repository
{
    public class RefeicaoRepository : AccessDatabaseRepository<Refeicao>
    {
        private static RefeicaoRepository _instance;

        private RefeicaoRepository()
        {
        }

        public static RefeicaoRepository GetInstance()
        {
            if (_instance == null)
                _instance = new RefeicaoRepository();

            return _instance;
        }

        /// <summary>
        /// Adiciona a refeição no BD e retorna seu Id no BD.
        /// </summary>
        /// <param name="refeicao">Instância do objeto Refeição</param>
        /// <returns>O Id da refeição inserida no BD</returns>
        public int Add(Refeicao refeicao)
        {
            string sql = "INSERT INTO Refeicao (Data, TipoRefeicaoId) VALUES (#{0}#,{1})";
            sql = String.Format(sql, refeicao.Data, (int)refeicao.TipoRefeicaoId);
            return this.ExecuteSqlInsert(sql);
        }

        public Refeicao GetByDia(DateTime data, TipoRefeicao tipoRefeicao)
        {
            string sql = "SELECT RefeicaoId, Data, TipoRefeicaoId FROM Refeicao"
                + " WHERE Data=#{0}# AND TipoRefeicaoId={1}";
            sql = String.Format(sql, data.Date, (int)tipoRefeicao);
            return this.ExecuteSqlQuery(sql, CastRefeicao).SingleOrDefault();
        }
        
        private IEnumerable<Refeicao> CastRefeicao(List<IEnumerable<object>> valores)
        {
            var refeicoes = new List<Refeicao>();
            foreach (var linha in valores)
            {
                var refeicao = new Refeicao();
                refeicao.RefeicaoId = (Int32)linha.ElementAt(0);
                refeicao.SetData((DateTime)linha.ElementAt(1));
                refeicao.TipoRefeicaoId = (TipoRefeicao)linha.ElementAt(2);
                refeicoes.Add(refeicao);
            }

            return refeicoes;
        }
    }
}
