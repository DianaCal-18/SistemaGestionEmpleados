namespace GestorEmpleados.domain.models
{
    public class EmpleadoAsalariado : Empleado
    {

        public EmpleadoAsalariado(string idEmpleado, string nombre) : base(idEmpleado, nombre)
        {
        }

        public override double GetSalario()
        {
            throw new NotImplementedException();
        }
    }
}
