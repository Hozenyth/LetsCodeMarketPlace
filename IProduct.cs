using System.Collections.Generic;

namespace ProjetoLetsCode2
{
    public interface IProduct<P>
    {
        List<P> Lista(); // Metodo que se chama lista, retorna lista de P.
        P RetornaPorId(int  id);
        
        void Insere(P  entidade);

        void Exclui( int id);

        void Atualizar(int id, P entidade);

        int ProximoId();
    }
}