using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

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
          
            CuentaBancaria[] cuentas_BCO = new CuentaBancaria[6];
            bool continuar = true;
            
            
                while (continuar)
                {
                    Console.WriteLine("Ingrese operación a realizar: 1-crear Cuenta. 2-Depositar 3- Crear cuenta y saldo");
                   
                    try
                    {
                        int respuesta = Convert.ToInt32(Console.ReadLine());
                        ValidarInput(respuesta); //validar que el input del cliente sea una opción válida.
                        bool seguir = true;
                        while (seguir)
                        {
                            switch (respuesta)
                            {
                                case 1: //Crear cuenta

                                try
                                {   //ingresar y validar número de cuenta.
                                    Console.WriteLine("Ingrese número de cuenta");
                                    int cta_a_usar = Convert.ToInt32(Console.ReadLine());
                                    ValidarCuenta(cta_a_usar);

                                    //ingresar y validar el saldo incia
                                    Console.WriteLine("Ingrese saldo");
                                    double monto_inicial = Convert.ToDouble(Console.ReadLine());
                                    ValidarSaldo(monto_inicial);

                                    //ingresar los datos a la cuenta bancaria.
                                    
                                    cuentas_BCO[0] = new CuentaBancaria(Convert.ToString(cta_a_usar), monto_inicial);
                                    Console.WriteLine($"Se ha ingresado con éxito la siguiente cuenta : {cuentas_BCO[0].NumeroCuenta}" +
                                    $"con el siguiente saldo incial {cuentas_BCO[0].Saldo:C}");
                                    

                                    //preguntar al usuario si desea continuar realizando operaciones.
                                    bool repetir = true;
                                    do
                                    {
                                        Console.WriteLine("¿Desea seguir haciendo operaciones(s/n)");
                                        string respuesta2 = Console.ReadLine().ToLower();
                                        //validar que el input del usuario sea un "s" o un "n".
                                        if (respuesta2 != "s" && respuesta2 != "n" && (string.IsNullOrEmpty(respuesta2) == true))
                                        {
                                            Console.WriteLine("Ingrese una opción válida");
                                        }
                                        else if (respuesta2 == "s")
                                        {
                                            repetir = false;
                                            seguir = false;
                                            
                                        }
                                        else
                                        {
                                            repetir = false;
                                            seguir = false;
                                            continuar = false;
                                        }
                                            
                                    } while (repetir == true);
                                }
                                catch (Exception e)
                                {

                                    if (e is FormatException)
                                        Console.WriteLine("¡Error!: Debe ingresar un NÚMERO");
                                    else if (e is OverflowException)
                                        Console.WriteLine("!Error!: El número ingresado es muy alto");
                                    else
                                        Console.WriteLine($"¡Error!: {e.Message} ");

                                }
                                break;
                                    

                                case 2: //Depositar
                                try 
                                {
                                    Console.WriteLine("¿Cuánto dinero desea depositar?");
                                    int deposito = Convert.ToInt32(Console.ReadLine());
                                    ValidarSaldo(deposito);
                                    cuentas_BCO[0].Depositar(deposito);
                                    seguir = false;
                                    //if (!ContinuarOperaciones())
                                        continuar = false;


                                }
                                catch (Exception e)
                                {
                                    if (e is FormatException)
                                        Console.WriteLine("¡Error!: Debe ingresar un NÚMERO");
                                    else if (e is OverflowException)
                                        Console.WriteLine("!Error!: El número ingresado es muy alto");
                                    else
                                        Console.WriteLine($"¡Error!: {e.Message} "); ;
                                } break;

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

                                bool cont_operaciones = true;
                                while (cont_operaciones)
                                {
                                    Console.WriteLine("¿Desea seguir haciendo operaciones(s/n)");
                                    string respuesta2 = Console.ReadLine().ToLower();
                                    switch (respuesta2)
                                    {
                                        case "s":
                                            cont_operaciones = false;
                                            seguir = false;
                                            break;
                                        case "n":
                                            seguir = false;
                                            continuar = false;
                                            cont_operaciones = false;
                                            break;
                                        default:
                                            Console.WriteLine("Ingrese una opción válida (s/n)");
                                            break;
                                    }

                                }
                            }






                        }
                    }
                    catch (Exception e)
                        
                    {
                        if (e is FormatException)
                            Console.WriteLine("¡Error!: Debe ingresar un número");
                        else if (e is OverflowException)
                            Console.WriteLine("!Error!: El número ingresado es muy alto");
                        else
                            Console.WriteLine($"¡Error!: {e.Message}");
                  
                    }



                    
                }
               
            
            

        }

        

        static void ValidarSaldo(double monto_inicial)
        {
            if (monto_inicial < 0)
            {
                
                throw new Exception($"El monto a ingresar no puede ser menor a {1:C}");
            }
        }

         static void ValidarCuenta(int cta_a_usar)
        {
            
           if (cta_a_usar < 0 || cta_a_usar > int.MaxValue)
           {
                
                throw new Exception("El número no puede ser negativo ni mayor al permitido");
                
           }
        }

         static void ValidarInput(int respuesta) 
        {
            //asegurar que el usuario eliga una opción válida.
            if (respuesta < 1 || respuesta > 3) 
            {
                //no en rango
                throw new Exception("Debe elegir una opción válida.");
            
            }
        }
        static void ContinuarOperaciones(string respuesta2)
        {
            
            if (respuesta2 != "s" || respuesta2 != "y")
            {
                //throw new Exception("Ingrese una opcíon válida (s/n)");
                Console.WriteLine("Ingrese una opcíon válida (s/n)");
            }
                
            /*if (respuesta2 == "s")
            {
                //error = false;
                
            } 
            else
            {
                //error = false;
                
            }   */    
        }
    }
}
