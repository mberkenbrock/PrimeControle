using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastroCliente.Models
{
    public class CadastroCliente
    {
        public int ID { get; set; }
        public string NM_CLIENTE { get; set; }
        public string CPF { get; set; }
        public string CEL_CLIENTE { get; set; }
        public string EMAIL_CLIENTE { get; set; }
        public string CEP { get; set; }
        public string CIDADE { get; set; }
        public string ENDERECO { get; set; }
        public string BAIRRO { get; set; }
        public string ESTADO { get; set; }
        public DateTime DT_CADASTRO { get; set; }

        public CadastroCliente()
        {
            DT_CADASTRO = DateTime.Now;
        }
    }
}
