using DiarioNutricional.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DiarioNutricional.Repository
{
    class AlimentoRepository
    {
        public static List<Alimento> GetAll()
        {
            DataSet InformacoesNutricionaisDataSet = GetExcelToDataSet();
            List<Alimento> todosAlimentos = new List<Alimento>();

            foreach (DataRow row in InformacoesNutricionaisDataSet.Tables[0].Rows)
            {
                var informacoesNutricionais = new Alimento();
                informacoesNutricionais.Codigo = Int32.Parse(row[0].ToString());
                informacoesNutricionais.Descricao = row[1].ToString();
                informacoesNutricionais.EnergiaKcal = Decimal.Parse(TratarValores(row[3].ToString()));
                informacoesNutricionais.ProteinasEmGramas = Decimal.Parse(TratarValores(row[4].ToString()));
                informacoesNutricionais.GordurasEmGramas = Decimal.Parse(TratarValores(row[5].ToString()));
                informacoesNutricionais.CarboidratosEmGramas = Decimal.Parse(TratarValores(row[7].ToString()));
                todosAlimentos.Add(informacoesNutricionais);
            }

            return todosAlimentos;
        }

        private static string TratarValores(string valor)
        {
            switch(valor)
            {
                case "":
                    return "0,0";
                default:
                    return valor;
            }
        }

        private static DataSet GetExcelToDataSet()
        {
            var data = new DataSet();
            var pastaDoExecutavel = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var caminhoDaPlanilha = pastaDoExecutavel + "\\Taco_4a_edicao_2011.xls";
            string connectionString = string.Format("provider=Microsoft.Jet.OLEDB.4.0; data source={0};Extended Properties=Excel 8.0;", caminhoDaPlanilha);

            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                var dataTable = new DataTable();
                string query = "SELECT * FROM [CMVCol_taco3$]";
                con.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, con);
                adapter.Fill(dataTable);
                data.Tables.Add(dataTable);
            }

            return data;
        }
    }
}
