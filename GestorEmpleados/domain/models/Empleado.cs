namespace GestorEmpleados.domain.models
{
    public abstract class Empleado
    {
        string idEmpleado { get; set; }
        string nombre { get; set; }

    public Empleado(string idEmpleado, string nombre)
        {
            this.idEmpleado = idEmpleado;
            this.nombre = nombre;
          
        }

        public abstract double GetSalario();


    }

}