using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loja.Dominio.Entidades
{
   public abstract class Entidade
    { 
        public List<string> _MensagemValidacao { get; set; }

        private  List<string> MensagemValidacao
        {
            get { return _MensagemValidacao ?? (_MensagemValidacao = new List<string>()); } 
        }

        public abstract void Validate();
        protected bool Valido {
            get { return !MensagemValidacao.Any(); }
        }
        protected void LimparMensagem() {
            MensagemValidacao.Clear();
        }

        protected void AdicionarCritica(string mensagem) {
            MensagemValidacao.Add(mensagem);
        }
    }
}
