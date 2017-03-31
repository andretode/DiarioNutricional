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
            var filtros = nomeAlimento.Split(' ');
            IEnumerable<Alimento> alimentosFiltrados = null;

            switch(filtros.Count())
            {
                case 1:
                    alimentosFiltrados = from alimentos in _todosAlimentos
                                                               where alimentos.Descricao.ToLowerInvariant().Contains(filtros[0].ToLowerInvariant())
                                                               select alimentos;
                    break;
                case 2:
                    alimentosFiltrados = from alimentos in _todosAlimentos
                                         where alimentos.Descricao.ToLowerInvariant().Contains(filtros[0].ToLowerInvariant())
                                         && alimentos.Descricao.ToLowerInvariant().Contains(filtros[1].ToLowerInvariant())
                                         select alimentos;
                    break;
                case 3:
                    alimentosFiltrados = from alimentos in _todosAlimentos
                                         where alimentos.Descricao.ToLowerInvariant().Contains(filtros[0].ToLowerInvariant())
                                         && alimentos.Descricao.ToLowerInvariant().Contains(filtros[1].ToLowerInvariant())
                                         && alimentos.Descricao.ToLowerInvariant().Contains(filtros[2].ToLowerInvariant())
                                         select alimentos;
                    break;
                case 4:
                    alimentosFiltrados = from alimentos in _todosAlimentos
                                         where alimentos.Descricao.ToLowerInvariant().Contains(filtros[0].ToLowerInvariant())
                                         && alimentos.Descricao.ToLowerInvariant().Contains(filtros[1].ToLowerInvariant())
                                         && alimentos.Descricao.ToLowerInvariant().Contains(filtros[2].ToLowerInvariant())
                                         && alimentos.Descricao.ToLowerInvariant().Contains(filtros[3].ToLowerInvariant())
                                         select alimentos;
                    break;
                default:
                    alimentosFiltrados = from alimentos in _todosAlimentos
                                         where alimentos.Descricao.ToLowerInvariant().Contains(nomeAlimento.ToLowerInvariant())
                                         select alimentos;
                    break;
            }


            
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
