using GestorEmpleados.domain.models;

namespace GestorEmpleados.application.services.@interface
{
    public interface IEmpleadoService
    {
        List <Empleado> GetAll ();
        Empleado GetById (string id);
    }
}
