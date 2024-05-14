// See https://aka.ms/new-console-template for more information




//SUMA Y RESTA DE VARIABLES:



//string mensaje = "Hola Mundo!!";

//Console.WriteLine(mensaje);

//int num1;
//int num2;

//Console.WriteLine("Ingrese el primer numero a sumar.");
//num1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Ingrese el primer numero a sumar.");
//num2 = Convert.ToInt32(Console.ReadLine());

//int total = num1 + num2;

//Console.WriteLine("El resultado de la suma es: " + total);

//Console.ReadKey();





//BUCLES FOR Y WHILE:



//int numero;
//Console.WriteLine("Ingrese un numero");
//Console.WriteLine("Ingrese 0 para salir");

//numero = int.Parse(Console.ReadLine());

//while (numero != 0)
//{
//    if (numero > 0)
//    {
//        Console.WriteLine("El numero ingresado es positivo");
//    }
//    else if (numero < 0)
//    {
//        Console.WriteLine("El numero ingresado es negativo");
//    }
//    numero = int.Parse(Console.ReadLine());
//}

//int numeroTopeParaCalcular; 

//Console.WriteLine("Ingrese el numero maximo para calcular los multiplos de 5:");

//numeroTopeParaCalcular = int.Parse(Console.ReadLine());

//for (int i = 1; i <= numeroTopeParaCalcular; i++)
//{
//    if (i % 5 == 0)
//    {
//        Console.WriteLine(i + ", "); 
//    }
//}




//FUNCIONES




//saludar();
//void saludar()
//{
//    Console.WriteLine("Hola buenas tardes");
//}



//int sumando1 = int.Parse(Console.ReadLine());
//int sumando2 = int.Parse(Console.ReadLine());

//int suma = sumaDeNumeros(sumando1, sumando2);
//int sumaDeNumeros(int primerNumero, int segundoNumero)
//{
//    return (
//        primerNumero + segundoNumero
//    );
//}

//Console.WriteLine(suma);


//DESAFIO FUNCIONES: HACER QUE EL USUARIO SE LOGEE


//string contraseñaCreadaPorPrimeraVez;
//string usuarioCreadoPorPrimeraVez;

//string contraseñaDeLogeo;
//string usuarioDeLogeo;


//CreateAccount();
//LogIn(usuarioCreadoPorPrimeraVez, contraseñaCreadaPorPrimeraVez);

//void CreateAccount()
//{
//    Console.WriteLine("Cree su perfil, ingrese su nombre de usuario");
//    usuarioCreadoPorPrimeraVez = Console.ReadLine();


//    while (usuarioCreadoPorPrimeraVez == null || usuarioCreadoPorPrimeraVez == "")
//    {
//        Console.WriteLine("Intentelo de nuevo");
//        usuarioCreadoPorPrimeraVez = Console.ReadLine();
//    }

//    Console.WriteLine("Cree su perfil, ahora ingrese su contraseña");

//    contraseñaCreadaPorPrimeraVez = Console.ReadLine();

//    while (contraseñaCreadaPorPrimeraVez == null || contraseñaCreadaPorPrimeraVez == "")
//    {
//        Console.WriteLine("Intentelo de nuevo");
//        contraseñaCreadaPorPrimeraVez = Console.ReadLine();
//    }

//    Console.WriteLine("Cuenta creada exitosamente, ahora intente logearse");
//}

//void LogIn(string usuarioCreadoAnteriormente, string contraseñaCreadaAnteriormente)
//{
//    Console.WriteLine("Ingrese su nombre de usuario creado anteriormente");

//    usuarioDeLogeo = Console.ReadLine();

//    while (usuarioDeLogeo == null || usuarioDeLogeo == "" || !usuarioDeLogeo.Equals(usuarioCreadoAnteriormente))
//    {
//        Console.WriteLine("Usuario incorrecto, intentelo de nuevo");
//        usuarioDeLogeo = Console.ReadLine();
//    }

//    Console.WriteLine("Ingrese su contraseña creada anteriormente");

//    contraseñaDeLogeo = Console.ReadLine();

//    while (contraseñaDeLogeo == null || contraseñaDeLogeo == "" || !contraseñaDeLogeo.Equals(contraseñaCreadaAnteriormente))
//    {
//        Console.WriteLine("Usuario incorrecto, intentelo de nuevo");
//        contraseñaDeLogeo = Console.ReadLine();
//    }

//    Console.WriteLine("Ha ingresado exitosamente");
//}



//int precioCodigo(string codigo)
//{
//    int precio = 0;

//    switch (codigo)
//    {
//        case "DES":
//            precio = 200;
//            break;
//        case "JP":
//            precio = 300;
//            break;
//        case "DET":
//            precio = 250;
//            break;
//        default:
//            precio = 0;
//            break;
//    }

//    return precio;
//}

//void venta()
//{
//    string codigo = "";
//    int cantProductos;
//    int montoAPagar = 0;
//    string confirmacion = "-";

//    Console.WriteLine("Bienvenido, estos son nuestros productos.");
//    Console.WriteLine("Código        Descripción        Precio\r\nDES          Desodorante        200\r\nJP           Jabón en Polvo        300\r\nDET         Detergente       250");



//    while (codigo != "FIN")
//    {
//        Console.WriteLine("Ingrese el codigo que desea comprar");
//        codigo = Console.ReadLine().ToUpper();

//        if (codigo == "FIN")
//        {
//            break;
//        }
//        int precio = precioCodigo(codigo);

//        Console.WriteLine("Ingrese la cantidad que desea comprar");
//        cantProductos = int.Parse(Console.ReadLine());

//        montoAPagar += cantProductos * precio;

//    }
//    //TODO el final de la compra
//    Console.WriteLine("Su monto a pagar es {0}", montoAPagar);
//    Console.WriteLine("Desea realizar la compra? Si/No");
//    confirmacion = Console.ReadLine().ToUpper();

//    if (confirmacion == "SI")
//    {
//        Console.WriteLine("Gracias por la compra!!");
//    }
//}

//venta();


////FUNCION MAIN PARA INSTANCIAR OBJETOS, INSTANCIAS DE OBJETOS (usuario_1, usuario_2) Y MANEJOS CON LA CONSOLA.S

//namespace Curso_C__Clase_1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            bool mayorEdad;
//            string nuevaDireccion;
//            bool gmail;

//            Usuario usuario_1 = new Usuario("Juan", "Bida", 28123123, "bida@gmail.com", 44, "Cabildo 2668");
//            Usuario usuario_2 = new Usuario("Luis", "Lopez", 45000000, "luis@mail.com", 17, "Piedras 8500");

//            mayorEdad = usuario_1.EsMayorDeEdad();
//            Console.WriteLine("Usuario 1 es mayor de edad: " + mayorEdad);
//            mayorEdad = usuario_2.EsMayorDeEdad();
//            Console.WriteLine("Usuario 2 es mayor de edad: " + mayorEdad);

//            gmail = usuario_1.EsGmail();
//            Console.WriteLine("Usuario 1 tiene correo Gmail?: " + gmail);
//            gmail = usuario_2.EsGmail();
//            Console.WriteLine("Usuario 2 tiene correo Gmail?: " + gmail);

//            nuevaDireccion = usuario_1.CambiarDireccion("Congreso 2500");
//            Console.WriteLine("Usuario 1 tiene una nueva direccion: " + nuevaDireccion);
//            nuevaDireccion = usuario_2.CambiarDireccion("Avellaneda 500");
//            Console.WriteLine("Usuario 2 tiene una nueva direccion: " + nuevaDireccion);


//        }
//    }
//}

