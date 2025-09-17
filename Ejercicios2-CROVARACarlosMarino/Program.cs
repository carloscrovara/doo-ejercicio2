namespace Ejercicios2_CROVARACarlosMarino
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    //-----Clases Naranja, Limón y Fruta Cítrica con sus métodos-----//
    class Naranja
    {
        public string color;
        public bool para_jugo;
        public string region;
        public bool madura;

        public void cosechar()
        {
            Console.WriteLine("Cosechando naranja");
        }

        public void comer()
        {
            Console.WriteLine("Comiendo naranja");
        }
    }

    class Limon
    {
        public string color;
        public string region;
        public bool madura;
        public string nivelAcidez;

        public void cosechar()
        {
            Console.WriteLine("Cosechando limón");
        }

        public void comer()
        {
            Console.WriteLine("Comiendo limón");
        }

        public void condimentar()
        {
            Console.WriteLine("Condimentando con limón");
        }
    }

    class frutaCitrica
    {
        public string color;
        public string region;
        public bool madura;
        public void cosechar()
        {
            Console.WriteLine("Cosechando fruta cítrica");
        }
        public void comer()
        {
            Console.WriteLine("Comiendo fruta cítrica");
        }
    }

    //-----Clases Alumno, Profesor y Persona con sus métodos-----//
    class Alumno
    {
        public string nombreApellido;
        public int DNI;
        public string domicilio;
        public string email;
        public string telefono;
        public string carrera;
        public int legajo;
        public void estudiar()
        {
            Console.WriteLine("Estudiando");
        }
        public void asistirClase()
        {
            Console.WriteLine("Asistiendo a clase");
        }

        public void entregarTrabajoPractico()
        {
            Console.WriteLine("Entregando trabajo práctico");
        }

        public void rendirExamen()
        {
            Console.WriteLine("Rindiendo examen");
        }
    }

    class Profesor
    {
        public string nombreApellido;
        public int CUIL;
        public string domicilio;
        public string email;
        public string telefono;
        public string carrera;
        public string materia;
        public bool experienciaDocente;
        public void darClase()
        {
            Console.WriteLine("Dando clase");
        }
        public void asistirClase()
        {
            Console.WriteLine("Asistiendo a clase");
        }
        public void corregirTrabajoPractico()
        {
            Console.WriteLine("Corregir trabajo práctico");
        }
        public void corregirExamen()
        {
            Console.WriteLine("Corrigiendo examen");
        }
    }

    class Persona
    {
        public string nombreApellido;
        public string domicilio;
        public string email;
        public string telefono;
        public string carrera;

        public void asistirClase()
        {
            Console.WriteLine("Asistiendo a clase");
        }
    }

    //-----Clases Animal, Pez y Reptil con sus métodos-----//
    class Animal
    {
        public string nombre;
        public string especie;
        public int edad;
        public double tamanio;
        public string color;
        public string tipoAlimentacion;
        public int nivelHambre;
        public bool estaSano;
        public decimal precioVenta;
        public void comer()
        {
            Console.WriteLine("Comiendo");
        }
        public void controlVeterinario()
        {
            Console.WriteLine("Haciendo control veterinario");
        }
    }

    class Pez
    {
        public string tipoAgua;

        public void nadar()
        {
            Console.WriteLine("Nadando");
        }
    }

    class Reptil
    {
        public double longitud;
        public double peso;
        public double temperaturaCorporal;
        public void reptar()
        {
            Console.WriteLine("Reptando");
        }

        public void tomarSol()
        {
            Console.WriteLine("Tomando sol");
        }
    }
}
