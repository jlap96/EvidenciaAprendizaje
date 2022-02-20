// See https://aka.ms/new-console-template for more information
//JUANA LILIANA AGUILAR PEÑALOZA

using EvidenciaAprendizaje;

usuario us = new usuario();
us.ingresar();

bool salir = false; //Variable que nos permite saber si el usuario quiere salir o no
while (!salir)
{ //Mientras el usuario no quiera salir se repite:
    try //Envolvemos el código que puede generar error en un bloque try-catch, el error puede ser que no nos de un número como opción
    {
        //Opciones del menú
        Console.WriteLine("1. Mostrar informacion del usuario.");
        Console.WriteLine("2. Mostrar balance.");
        Console.WriteLine("3. Realizar deposito");
        Console.WriteLine("4. Realizar retiro");
        Console.WriteLine("5. Salir");
        Console.WriteLine("Elige una de las opciones");
        //Convertimos a entero la opción introducida por el usuario, si ocurre un error al convertir se va a l bloque catch
        int opcion = Convert.ToInt32(Console.ReadLine());

        //Estructura de control que nos permite ir a una porción u otra de código
        //Opcion es la variable de control si coincide con una opcion entra a ese bloque de código
        switch (opcion)
        {
            case 1://Si coincide con 1
                us.mostrarDatos();
                break;//Salimos del bloque

            case 2://Si coincide con 2
                us.mostrarBalance();
                break;

            case 3:
                us.realizarDeposito();
                break;

            case 4:
                us.realizarRetiro();
                break;
            case 5:               
                salir = true;
                break;
            default://Si no coincide con las opciones de 1 a 5 se ejecuta esto siempre que sea un número
                Console.WriteLine("Opción no válida, elige una opcion entre 1 y 5");
                break;
        }
    }
    catch (FormatException e)//Capturamos la excepción que pueda ocurrir
    {
        Console.WriteLine("Formato incorrecto " + e.Message);//Mostramos el mensaje de la excepcioón
    }
}

Console.ReadLine();//Leemos un caracter para que haga una pausa antes de salir



