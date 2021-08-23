using System;
using System.Collections.Generic;
using System.Linq;


namespace ProjetoLetsCode2
{
    public class User : IUser<Seller>
    {

        public List<Seller> sellers = new List<Seller>();
        public void Atualizar(int id, Seller entidade)
        {
            sellers[id] = entidade;
        }

        public void Exclui(int id)
        {
            sellers[id].Excluir();
        }

        public void Insere(Seller entidade)
        {
            sellers.Add(entidade);
        }

        public List<Seller> Lista()
        {
            return sellers;
            
        }
       
        public int ProximoId()
        {
            return sellers.Count;  //coleção baseada na primeira posição 0.
        }

       public Seller RetornaPorId(int id)
        {
          
           return sellers[id];
        }
    }
}