using System.Globalization;

namespace ObjetosClase
{

    class Persona
    {

        private string nombre;
        private int edad;
        private string direccion;
        private string teléfono;
        private string email;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public string Dirección
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string Teléfono
        {
            get { return teléfono; }
            set { teléfono = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        public Persona()
        {
            nombre = "Sin nombre";
            edad = 0;
            direccion = "Sin dirección";
            teléfono = "Sin teléfono";
            email = "Sin email";
        }

        public Persona(string nombre, int edad, string direccion, string telefono, string email)
        {
            this.Nombre = nombre;
            this.edad = edad;
            this.direccion = direccion;
            this.teléfono= telefono;
            this.email = email;
        }

        public void MostrarInformacionCompleta()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
            Console.WriteLine($"Dirección: {Dirección}, Teléfono: {Teléfono}");
            Console.WriteLine($"Email: {Email}");
        }


    }
        internal class Program
        {
            static void Main(string[] args)
            {
                Persona persona = new Persona();
                Persona persona2 = new Persona("Pedro", 25, "palalal", "936117842", "pepito@gmail"); 
                persona.Nombre = "Juanito";
                persona2.MostrarInformacionCompleta();
                persona.MostrarInformacionCompleta();

            }
        }
}
