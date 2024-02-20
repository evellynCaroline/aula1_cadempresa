using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace aula1.Properties
{
    public class Empresa
    {
        // Atributos da empresa
        public string CNPJ { get; set; }    //
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string SituacaoCadastral { get; set; }
        public string RegimeTributario { get; set; }
        public DateTime DataInicioAtividade { get; set; }
        public string Telefone { get; set; }
        public decimal CapitalSocial { get; set; }
        public string TipoEmpresa { get; set; }
        public string PorteEmpresa { get; set; }
        public string NaturezaJuridica { get; set; }
        public string NomeProprietario { get; set; }
        public string CPFProprietario { get; set; }

        // Construtor da classe
        public Empresa(string cnpj, string razaoSocial, string nomeFantasia, string situacaoCadastral,
                       string regimeTributario, DateTime dataInicioAtividade, string telefone,
                       decimal capitalSocial, string tipoEmpresa, string porteEmpresa,
                       string naturezaJuridica, string nomeProprietario, string cpfProprietario)
        {
            CNPJ = cnpj;
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            SituacaoCadastral = situacaoCadastral;
            RegimeTributario = regimeTributario;
            DataInicioAtividade = dataInicioAtividade;
            Telefone = telefone;
            CapitalSocial = capitalSocial;
            TipoEmpresa = tipoEmpresa;
            PorteEmpresa = porteEmpresa;
            NaturezaJuridica = naturezaJuridica;
            NomeProprietario = nomeProprietario;
            CPFProprietario = cpfProprietario;
        }
    }

}
