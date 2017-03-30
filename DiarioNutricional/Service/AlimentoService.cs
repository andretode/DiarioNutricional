using DiarioNutricional.Model;
using DiarioNutricional.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiarioNutricional.Service
{
    public class AlimentoService
    {
        private static AlimentoService _instance;
        private List<Alimento> _todosAlimentos;

        private AlimentoService()
        {
            _todosAlimentos = AlimentoRepository.GetAll();
        }

        public static AlimentoService GetInstance()
        {
            if (_instance == null)
                _instance = new AlimentoService();

            return _instance;
        }

        public List<Alimento> FilterAlimentoByName(string nomeAlimento )
        {
            IEnumerable<Alimento> alimentosFiltrados = _todosAlimentos.Where(a => a.Descricao.ToLowerInvariant().Contains(nomeAlimento.ToLowerInvariant()));
            return alimentosFiltrados.ToList();
        }

        public List<Alimento> GetAll()
        {
            return _todosAlimentos;
        }

        public Alimento GetById(int codigo)
        {
            return _todosAlimentos.Where(a => a.Codigo == codigo).SingleOrDefault(); ;
        }
    }
}
