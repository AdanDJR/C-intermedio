using Entities;

namespace Interfaces
{
    public interface IAsientoRepository
    {
        void Agregar(Asiento asiento);
        void Actualizar(Asiento asiento);
        void Remover(Asiento asiento);
        List<Asiento> TraerTodos();
        Asiento ObtenerPorId(int asientoId);
    }
}
