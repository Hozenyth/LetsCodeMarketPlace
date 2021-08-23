
using System.Collections.Generic;

namespace ProjetoLetsCode2

{
    public interface IUser<T>
    {
         List<T> Lista(); // Metodo que se chama lista, retorna lista de T.
        T RetornaPorId(int  id);
        
        void Insere(T  entidade);

        void Exclui( int id);

        void Atualizar(int id, T entidade);

        int ProximoId();
    }
}