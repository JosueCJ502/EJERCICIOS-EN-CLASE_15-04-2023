//DECLARACION DE VARIABLES
int opcion;

//MENU PRINCIPAL
Console.WriteLine("E J E R C  I C I O  E N  C L A S E");
Console.WriteLine("MENÚ");
Console.WriteLine("1 >> Numero a Meses del Año");
Console.WriteLine("2 >> Par / Impar ");
Console.WriteLine("3 >> Servicio de Estacionamiento");
Console.WriteLine("Elije una Opcion: ");
opcion = int.Parse(Console.ReadLine());

switch (opcion)
{
    case 1:
        /*PEDIR AL USUARIO UN NUMERO DE 1 AL 12
         *DEVOLVER EL NUMERO CON EL NOMBRE DEL MES
         *QUE CORRESPONDE EN EL CALENDARIO*/

        //DECLARACION DE VARIABLES
        int opt;

        //PEDIR EL NUMERO AL USUARIO
        Console.WriteLine("INGRESE UN NUMERO DE 1 AL 12: ");
        opt = int.Parse(Console.ReadLine());

        switch (opt)
        {
            case 1:
                Console.WriteLine("Elegiste el mes de Enero");
                break;
            case 2:
                Console.WriteLine("Elegiste el mes de Febrero");
                break;
            case 3:
                Console.WriteLine("Elegiste el mes de Marzo");
                break;
            case 4:
                Console.WriteLine("Elegiste el mes de Abril");
                break;
            case 5:
                Console.WriteLine("Elegiste el mes de Mayo");
                break;
            case 6:
                Console.WriteLine("Elegiste el mes de Junio");
                break;
            case 7:
                Console.WriteLine("Elegiste el mes de Julio");
                break;
            case 8:
                Console.WriteLine("Elegiste el mes de Agosto");
                break;
            case 9:
                Console.WriteLine("Elegiste el mes de Septiembre");
                break;
            case 10:
                Console.WriteLine("Elegiste el mes de Octubre");
                break;
            case 11:
                Console.WriteLine("Elegiste el mes de Nomviembre");
                break;
            case 12:
                Console.WriteLine("Elegiste el mes de Diciembre");
                break;
            default:
                Console.WriteLine("Error!!!");
                Console.WriteLine("El Numero Ingresado es Invalido");
                break;
        }
        break;
    case 2:
        /*PEDIR AL USUARIO UN NUMERO
         *Y DECIRLE SI ES PAR O IMPAR*/

        //DECLARACION DE VARIABLES
        int numero;
        int ecuacion;

        //PEDIRLE AL USUARIO UN NUMERO
        Console.WriteLine("Escribe un número: ");
        numero = Convert.ToInt32(Console.ReadLine());
        ecuacion = numero % 2;

        if (ecuacion == 0) //SI LA ECUACION DA ENTERO ENTONCES ES PAR
        {
            Console.WriteLine("El número es par");
        }
        else // SI LA ECUACION DA DECIMAL ENTONCES ES IMPAR
        {
            Console.WriteLine("El número es impar");
        }
        break;

    case 3:
        /*DECIR AL USUARIO EL PRECIO QUE DEBE PAGAR
         *POR EL SERVICIO DE ESTACIONAMIENTO DE
         *UN CENTRO COMERCIAL CON BASE EN EL TIEMPO
         *QUE HA PERMANECIDO AHI, LOS PRIMEROS 60 MIN: $5.00,
         *LAS PRIMERAS 2 HRS $15.00 Y DE 2 HRS EN ADELANTE: $40.00*/

        //DECLARACION DE VARIABLES
        int tiempo;

        //PEDIR EL TIEMPO AL USUARIO
        Console.WriteLine("INGRESE EL TIEMPO DE ESTACIONAMIENTO (en minutos)");
        tiempo = int.Parse(Console.ReadLine());

        //CONDICION IF
        if (tiempo <= 60)//1 HORA
        {
            Console.WriteLine("DEBE PAGAR: $5.00");
        }
        else if (tiempo > 60 && tiempo <= 120)// 2 HORA
        {
            Console.WriteLine("DEBE PAGAR: $15.00");
        }
        else //2 HORA EN ADELANTE
        {
            Console.WriteLine("DEBE PAGAR: $40.00");
        }

        break;
    
    default:
        Console.WriteLine("Error!!!");
        Console.WriteLine("Opcion Invalida");
        break;
        
}
