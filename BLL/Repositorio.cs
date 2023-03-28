using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Repositorio
    {
        public List<Telefone> Telefones { get; set; } = new List<Telefone>() { };

        public void Incluir(Telefone telefone)
        {
            Telefones.Add(telefone);
        }
        public void Remover(Telefone telefone)
        {
            Telefones.Remove(telefone);
        }
    }
}
