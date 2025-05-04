using System;
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

    class CuentaBancaria
    {
        private string numeroCuenta;
        private double saldo;

        public string NumeroCuenta
        {
            get 
            {
                return numeroCuenta;
            }
        }

        public double Saldo
        {
            get
            {
                return saldo;
            }
            private set
            {
                if (value >= 0)
                {
                    saldo = value;
                }
                else
                {
                    Console.WriteLine("El saldo no puede ser negativo");
                }
            }
        }

        public CuentaBancaria(string numero,double saldo)
        {
            this.numeroCuenta = numero;
            this.saldo = saldo;
        }

        public void Depositar(double monto) 
        {
            if (monto > 0)
            {
                this.saldo += monto;
                Console.WriteLine($"Se ha depositado {monto:C} a la cuenta. El saldo actual es {Saldo:C}");
            }
            else 
            {
                Console.WriteLine("El monto a depositar debe ser mayor a 0");
            }
        }

        public void Retirar(double monto)
        {
            if (monto > 0 && monto <= saldo)
            {
                this.saldo -= monto;
                Console.WriteLine($"Se ha retirado {monto:C}. El nuevo saldo es {Saldo:C}");
            }
            else 
            { 
                Console.WriteLine("No se ha podido realizar el retiro del dinero, saldo insuficiente o monto inválido.");
            
            }
        }


    }


    internal class Program
    {
        static void Main(string[] args)
        {
            /*Animal miAnimal = new Animal("Canela", 3);
            miAnimal.MostrarInformacion();
            miAnimal.PedirComida();

            Perro miPerro = new Perro("Ronaldo", 15, "cocker");
            miPerro.MostrarInformacion();

            Gato miGato = new Gato("Cucho", 1, true);
            miGato.MostrarInformacion();

            Pajaro miPajaro = new Pajaro("pepe", 4, true);
            miPajaro.MostrarInformacion();

            Reptil miReptil = new Reptil("Luna", 13, true);

            Animal[] animales = { miPerro, miGato, miPajaro, miReptil };
            foreach (Animal animal in animales)
            {
                animal.PedirComida();
            }*/

            
            //Console.WriteLine($"numero de cuenta: {cuenta.NumeroCuenta}");
            //Console.WriteLine($"Saldo inicial: {cuenta.Saldo:C}");

            //string[] cuentas_a_usar = new string [5];
            //double[] saldos_iniciales = new double[5];

            //cuentas_a_usar[0] = cta_a_usar;
            //saldos_iniciales[0] = saldo_inicial;

            CuentaBancaria[] cuentas_BCO = new CuentaBancaria[5];
            //CuentaBancaria cuenta = new CuentaBancaria("cta_a_usar", 1);
            //cuentas_BCO[0] = cuenta;
            //Console.WriteLine(cuentas_BCO[0].);



            //Console.WriteLine("Ingrese operación a realizar: 1-Depositar. 2-Retirar");
            //string respuesta = Console.ReadLine();

            bool continuar = true;
            while (continuar) 
            {

                while (true)
                {
                    try
                    {
                        Console.WriteLine("Ingrese operación a realizar: 1-crear Cuenta. 2-Depositar 3- Crear cuenta y saldo");
                        int respuesta = Convert.ToInt32(Console.ReadLine());
                        if (respuesta != 1 && respuesta !=2 && respuesta !=3)
                        {
                            throw new Exception("Ingrese una opción válida.");

                        }
                        switch (respuesta)
                        {
                            case 1: //Crear cuenta

                                    try
                                    {
                                            int value;
                                            char charResult;
                                            Console.WriteLine("Ingrese número de cuenta");
                                            string cta_a_usar = Console.ReadLine();
                                            bool exito = int.TryParse(cta_a_usar, out value);
                                            if (exito != true || string.IsNullOrEmpty(cta_a_usar))
                                            {
                                                throw new Exception("Ingrese número válido de cuenta. Tampoco puede ingresar nada.");
                                            }
                                            Console.WriteLine("Ingrese saldo");
                                            double monto_inicial = Convert.ToDouble(Console.ReadLine());
                                            if (monto_inicial < 0 || !char.TryParse("t", out charResult))
                                            {
                                                throw new Exception("Ingres número mayor a 0 y ningúna letra.");
                                            }
                                            double saldo_inicial = Convert.ToInt32(Console.ReadLine());
                                            cuentas_BCO[0] = new CuentaBancaria(cta_a_usar, saldo_inicial);
                                    }
                                    catch (Exception ex)
                                    {

                                        //Console.WriteLine("no se que estoy haciendo.");
                                        //Console.WriteLine(ex.Message);
                                        throw;
                                    }
                                    break;
                                
                            case 2: //Depositar
                                Console.WriteLine("¿Cuánto dinero desea depositra?");
                                int deposito = Convert.ToInt32(Console.ReadLine());
                                cuentas_BCO[0].Depositar(deposito);
                                break;
                            case 3:
                                try
                                {
                                    Console.WriteLine("¿Cuánto dinero desea retirar?");
                                    int retiro = Convert.ToInt32(Console.ReadLine());
                                    //cuenta.Retirar(retiro);

                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }                          
                                break;
                        }
                        break;

                    }
                    catch (Exception e)
                        
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                Console.WriteLine("¿Desea seguir haciendo operaciones(s/n)");
                string respuesta2 = Console.ReadLine().ToLower();
                if (respuesta2 == "s") 
                {
                    Console.WriteLine("¿Desea cambiar de cuenta? (s/n)");
                    try
                    {


                    }
                    catch (Exception ef) 
                    {
                        Console.WriteLine(ef.Message);
                    }
                }
                continuar = respuesta2 == "s";

            }
            
           
            
            
            
            


        }
    }
}
