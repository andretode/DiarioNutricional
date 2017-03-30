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
        List<Alimento> todosAlimentos;
        List<Refeicao> todasRefeicoes;
        AlimentoService alimentoService;

        public Form1()
        {
            InitializeComponent();
            alimentoService = AlimentoService.GetInstance();
            todosAlimentos = alimentoService.GetAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgwInformacoesNutricionais.DataSource = todosAlimentos;
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
            var formQuantidade = FormQuantidade.GetInstance();
            formQuantidade.alimento = alimento;
            formQuantidade.Show();
        }

        private void dgwInformacoesNutricionais_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //nada
        }
    }
}
