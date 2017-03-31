using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DiarioNutricional.Repository
{
    public abstract class AccessDatabaseRepository<TEntity>
        where TEntity : class
    {
        private static AccessDatabaseRepository<TEntity> _instance;
        private static OleDbConnection conn;

        public AccessDatabaseRepository()
        {
            var pastaDoExecutavel = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var caminhoAccessDb = pastaDoExecutavel + "\\..\\..\\Data" + "\\DiarioNutricional.accdb";

            conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + caminhoAccessDb;
        }

        /// <summary>
        /// Executa a inserção e retorna o Id no BD.
        /// </summary>
        /// <param name="query">O SQL a ser executado</param>
        /// <returns>Retorna o ID do registro inserido</returns>
        protected int ExecuteSqlInsert(string query)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand(query);
                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();

                //Pegar o Id
                string sqlId = "Select @@Identity";
                cmd.CommandText = sqlId;
                var id = (int)cmd.ExecuteScalar();

                conn.Close();

                return id;
            }
            catch (OleDbException ex)
            {
                throw new Exception("Falha ao inserir dados no BD Access da aplicação: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao conectar no BD Access da aplicação: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        protected IEnumerable<TEntity> ExecuteSqlQuery(string query, Func<List<IEnumerable<object>>, IEnumerable<TEntity>> CastResultado)
        {
            OleDbDataReader reader = null;
            try
            {
                OleDbCommand cmd = new OleDbCommand(query);
                cmd.Connection = conn;
                conn.Open();
                
                reader = cmd.ExecuteReader();
                var linhas = new List<IEnumerable<object>>();
                while (reader.Read())
                {
                    var colunas = new object[reader.FieldCount];
                    reader.GetValues(colunas);
                    linhas.Add(colunas);
                }

                return CastResultado(linhas);
            }
            catch (OleDbException ex)
            {
                throw new Exception("Falha ao consultar dados no BD Access da aplicação: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao conectar no BD Access da aplicação: " + ex.Message);
            }
            finally
            {
                if(reader != null)
                    reader.Close();

                conn.Close();
            }
        }
    }
}
