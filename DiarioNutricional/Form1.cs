using DiarioNutricional.Model;
using DiarioNutricional.Repository;
using DiarioNutricional.Service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DiarioNutricional
{
    public partial class Form1 : Form
    {
        public static List<Alimento> todosAlimentos;
        AlimentoService alimentoService;
        RefeicaoService refeicaoService;

        public Form1()
        {
            InitializeComponent();
            alimentoService = AlimentoService.GetInstance();
            refeicaoService = RefeicaoService.GetInstance();
            todosAlimentos = alimentoService.GetAll();

            //preenche os componentes da interface
            dgwInformacoesNutricionais.DataSource = todosAlimentos;
        }

        public void IncluirPorcao(TipoRefeicao tipoRefeicao, DateTime data, Porcao porcao)
        {
            refeicaoService.AdicionaPorcao(tipoRefeicao, data, porcao);
            var refeicaoDoDia = refeicaoService.GetRefeicaoDoDia(data, tipoRefeicao);
            dgwPorcoesDoDia.DataSource = refeicaoDoDia.Porcoes;
        }

        private void textBoxFiltroAlimento_TextChanged(object sender, EventArgs e)
        {
            var alimentosFiltrados = alimentoService.FilterAlimentoByName(textBoxFiltroAlimento.Text);
            dgwInformacoesNutricionais.DataSource = alimentosFiltrados;
        }

        private void dgwInformacoesNutricionais_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int codigo = (int) dgwInformacoesNutricionais.Rows[e.RowIndex].Cells[0].Value;
            var alimento = alimentoService.GetById(codigo);
            var formQuantidade = FormQuantidade.GetInstance(this);
            formQuantidade.alimento = alimento;
            formQuantidade.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var refeicaoRepository = RefeicaoRepository.GetInstance();
            var refeicao = refeicaoRepository.GetByDia(DateTime.Now, 0);
        }
    }
}
