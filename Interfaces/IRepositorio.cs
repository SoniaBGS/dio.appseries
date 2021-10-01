using System.Collections.Generic; 

namespace dio.appseries.Interfaces
{
    public interface IRepositorio<T>
    {

        List<T> Lista();

        T RetornaPorId(int id);

        void Insere(T entidade);

        void Exclui(int id);

        void Attualiza(int id, T entidade);

        int ProximoId();

    }
}