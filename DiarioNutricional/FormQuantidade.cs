using DiarioNutricional.Model;
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
        private static FormQuantidade _instance;
        public Alimento alimento { get; set; }
        
        private FormQuantidade()
        {
            InitializeComponent();
        }

        public static FormQuantidade GetInstance()
        {
            if(_instance == null)
                _instance = new FormQuantidade();

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
    }
}
