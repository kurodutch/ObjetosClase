using System.Globalization;
using System.Security.Cryptography.X509Certificates;

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
            this.teléfono = telefono;
            this.email = email;
        }

        public void MostrarInformacionCompleta()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
            Console.WriteLine($"Dirección: {Dirección}, Teléfono: {Teléfono}");
            Console.WriteLine($"Email: {Email}");
        }


    }


    class Animal
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Animal(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"El animal es {Nombre} y la edad es {Edad}");
        }

        public virtual void PedirComida()
        {
            Console.WriteLine($"{Nombre} está pidiendo comida");
        }
    }
    class Perro : Animal // al colocar ":" indica que la clase Perro está heredando las características de la calse Animal.
    {
        public string Raza { get; set; }
        public Perro(string nombre, int edad, string raza) : base(nombre, edad)
        {
            this.Raza = raza;
        }


        public void Ladrar()
        {
            Console.WriteLine($"{Nombre} está ladrando");
        }

        public override void PedirComida()
        {
            //base.PedirComida();
            Console.WriteLine($"{Nombre}(perro) mueve la cola y salta para pedir comida");
        }

    }

    class Gato : Animal
    {
        public bool EsDomestico { get; set; }
        public Gato(string nombre, int edad, bool domestico) : base(nombre, edad)
        {
            EsDomestico = domestico;
        }

        public void Maullar()
        {
            Console.WriteLine($"{Nombre} está maullando");
        }

        public override void PedirComida()
        {
            //base.PedirComida();
            Console.WriteLine($"{Nombre}(gato) exige comida con sus maullidos insistentes");
        }
    }

    class Pajaro : Animal
    {
        public bool pajaroCanta { get; set; }

        public Pajaro(string nombre, int edad, bool canta) : base(nombre, edad)
        {
            pajaroCanta = canta;

        }

    }
    
    class Reptil: Animal
    {
        public bool Escamoso { get; set; }
        public Reptil (string nombre, int edad, bool escamoso): base (nombre, edad)
        {
            Escamoso = escamoso;
        }

        public override void PedirComida() 
        {
            Console.WriteLine($"{Nombre} está pidiendo comida como buen reptil que es");        
        
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal miAnimal = new Animal("Canela", 3);
            miAnimal.MostrarInformacion();
            miAnimal.PedirComida();

            Perro miPerro = new Perro("Ronaldo", 15, "cocker");
            miPerro.MostrarInformacion();

            Gato miGato = new Gato("Cucho", 1, true);
            miGato.MostrarInformacion();

            Pajaro miPajaro = new Pajaro("pepe", 4, true);
            miPajaro.MostrarInformacion();

            Reptil miReptil = new Reptil("Luna", 13, true);

            //miPerro.PedirComida();
            //miGato.PedirComida();

            Animal[] animales = { miPerro, miGato, miPajaro, miReptil };
            foreach (Animal animal in animales)
            {
                animal.PedirComida();
            }

        }
    }
}
