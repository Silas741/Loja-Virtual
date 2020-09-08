using System;
using System.Collections.Generic;
using System.Text;

namespace Loja.Dominio.Entidades
{
   public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public virtual ICollection<Pedido> pedidos { get; set; }           

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email)) {
                AdicionarCritica("Email não informado");
            }
            if (string.IsNullOrEmpty(Senha)) {
                AdicionarCritica("Senha não informada");
            }
            if (string.IsNullOrEmpty(Nome)) {
                AdicionarCritica("Nome não informado");
            }
        }
    }
}
