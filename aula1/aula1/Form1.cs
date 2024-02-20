using aula1.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Coletar os dados do formulário
            string cnpj = txtCNPJ.Text;
            string razaoSocial = txtRazaoSocial.Text;
            string nomeFantasia = txtNomeFantasia.Text;
            string situacaoCadastral = txtSituacaoCadastral.Text;
            string regimeTributario = txtRegimeTributario.Text;
            DateTime dataInicioAtividade = dateTimePickerDataInicioAtividade.Value;
            string telefone = txtTelefone.Text;
            decimal capitalSocial = Convert.ToDecimal(txtCapitalSocial.Text);
            string tipoEmpresa = txtNaturezaJuridica.Text;
            string porteEmpresa = txtPorteEmpresa.Text;
            string naturezaJuridica = txtNaturezaJuridica.Text;
            string nomeProprietario = txtNomeProprietario.Text;
            string cpfProprietario = txtCPFProprietario.Text;

            // Criar uma instância da classe Empresa com os dados coletados
            Empresa novaEmpresa = new Empresa(cnpj, razaoSocial, nomeFantasia, situacaoCadastral,
                                              regimeTributario, dataInicioAtividade, telefone,
                                              capitalSocial, tipoEmpresa, porteEmpresa,
                                              naturezaJuridica, nomeProprietario, cpfProprietario);

            // Aqui você pode adicionar o código para salvar os dados da nova empresa em um banco de dados, por exemplo.
            // Por enquanto, apenas exibiremos uma mensagem de sucesso.
            MessageBox.Show("Empresa cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpar os campos após o cadastro
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtCNPJ.Text = "";
            txtRazaoSocial.Text = "";
            txtNomeFantasia.Text = "";
            txtSituacaoCadastral.Text = "";
            txtRegimeTributario.Text = "";
            dateTimePickerDataInicioAtividade.Value = DateTime.Now;
            txtTelefone.Text = "";
            txtCapitalSocial.Text = "";
            txtNaturezaJuridica.Text = "";
            txtPorteEmpresa.Text = "";
            txtNaturezaJuridica.Text = "";
            txtNomeProprietario.Text = "";
            txtCPFProprietario.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
