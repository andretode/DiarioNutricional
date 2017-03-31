using DiarioNutricional.Model;
using DiarioNutricional.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiarioNutricional
{
    public partial class FormQuantidade : Form
    {
        private static Form1 _formPrincipal;
        private static FormQuantidade _instance;
        public Alimento alimento { get; set; }
        
        private FormQuantidade()
        {
            InitializeComponent();
        }

        public static FormQuantidade GetInstance(Form1 formPrincipal)
        {
            if(_instance == null)
                _instance = new FormQuantidade();

            _formPrincipal = formPrincipal;

            return _instance;
        }

        private void FormQuantidade_Load(object sender, EventArgs e)
        {
            carregarComboBoxTipoRefeicao();
        }

        private void carregarComboBoxTipoRefeicao()
        {
            foreach (var item in Enum.GetValues(typeof(TipoRefeicao)))
            {
                campoTipoRefeicao.Items.Add(item);
            }
        }

        private void FormQuantidade_Shown(object sender, EventArgs e)
        {
            labelDescricaoAlimento.Text = alimento.Descricao;
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            var refeicaoService = RefeicaoService.GetInstance();
            var refeicao = refeicaoService.GetRefeicaoDoDia(DateTime.Now, 
                (TipoRefeicao)campoTipoRefeicao.SelectedItem);

            var porcao = new Porcao();
            porcao.Alimento = alimento;
            porcao.QuantidadeEmGramas = (int) campoQuantidade.Value;

            refeicao.Porcoes.Add(porcao);
            _formPrincipal.IncluirRefeicao(refeicao);
            
            this.Close();
        }
    }
}
