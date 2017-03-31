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
        private Refeicao refeicaoDoDia;
        AlimentoService alimentoService;
        RefeicaoService refeicaoService;

        public Form1()
        {
            InitializeComponent();
            alimentoService = AlimentoService.GetInstance();
            refeicaoService = RefeicaoService.GetInstance();
            todosAlimentos = alimentoService.GetAll();
            refeicaoDoDia = refeicaoService.GetRefeicaoDoDia(DateTime.Now, TipoRefeicao.CafeDaManha);

            //preenche os componentes da interface
            dgwInformacoesNutricionais.DataSource = todosAlimentos;
            dgwPorcoesDoDia.DataSource = refeicaoDoDia.Porcoes;
        }

        public void IncluirRefeicao(Refeicao refeicao)
        {
            refeicaoDoDia = refeicao;
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
    }
}
