using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Conrad.Models
{
    public class Contato
    {
        public string Nome { get; set; }
        public string Empresa { get; set; }
        public string EMail { get; set; }
        public string RamoAtividade { get; set; }
        public string DDDTelefone { get; set; }
        public string Telefone { get; set; }
        public string DDDCelular { get; set; }
        public string Celular { get; set; }
        public string Mensagem { get; set; }
    }
}