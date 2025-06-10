namespace GestorEmpleados.domain.models
{
    public class EmpleadoPorHora : Empleado
    {
        double horas_trabajadas;
        double tarifa_hora;
        public EmpleadoPorHora(string idEmpleado, string nombre, double horas_trabajadas, double tarifa_hora) : base(idEmpleado, nombre)
        {
        }

        public override double GetSalario()
        {
            throw new NotImplementedException();
        }
    }
} 
