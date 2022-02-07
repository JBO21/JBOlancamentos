using System.Collections.Generic;

namespace JBO_Lancamentos.Interfaces
{
    public interface IRep<J>
    {
         List<J> Lista();
         J RetornaPorId (int id);
         void Insere(J entidade );
         void Excluir(int id);
         void Atualiza(int id, J entidade);
         int ProximoId();
    }
}