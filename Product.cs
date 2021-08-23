using System.Collections.Generic;

namespace ProjetoLetsCode2
{
    public class Product : IProduct<Producter>
    {
        
        public List<Producter> produtos = new List<Producter>(); //Lista de todos os produtos
        public void Atualizar(int id, Producter entidade)
        {
            produtos[id] = entidade;
        }

        public void Exclui(int id)
        {
            produtos[id].Excluir();
        }

        public void Insere(Producter entidade)
        {
            produtos.Add(entidade);
        }

        public List<Producter> Lista()
        {
            return produtos;
            
        }
       
        public int ProximoId()
        {
            return produtos.Count;  //coleção baseada na primeira posição 0.
        }

       public Producter RetornaPorId(int id)
        {
          
           return produtos[id];
        }


    }
}