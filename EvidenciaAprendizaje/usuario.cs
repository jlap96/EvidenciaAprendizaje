using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidenciaAprendizaje
{    class usuario
    {   //Se declaran variables
        int clave;
        string nombre, tipo;
        float balance = 0;
        int deposito = 0;
        int retiro = 0;


        //Metodo para el ingreso del usuario.
        public void ingresar ()
        {

            Console.WriteLine("BIENVENIDO. \n");
            Console.WriteLine("Ingresa la clave de usuario: "); //Se solicita la clave del usuario
            clave= int.Parse(Console.ReadLine()); //Se guarda la clave del usuario en su variable
            Console.WriteLine("Ingresa el nombre: "); //Se solicita el nombre del usuario
            nombre= Console.ReadLine(); //Se guarda el nombre del usuario en su variable
            Console.WriteLine("Ingresa el tipo de usuario: "); //Se solicita el tipo de usuario
            tipo= Console.ReadLine(); //Se guarda el tipo de usuario en su variable
            return;
        }

        //Metodo para mostrar la informacion del usuario
        public void mostrarDatos ()
        {
            //Se imprime la informacion del usuario, como lo es su nombrem, clave y tipo de cliente
            Console.WriteLine("Nombre: " +nombre + " Clave: " +clave + " Tipo de cliente: " +tipo);
            return;
        }

        //Metodo para mostrar el balance del usuario.
        public void mostrarBalance ()
        {
            //Se imprime el balance del usuario.
            Console.WriteLine("Su balance es de: " +balance);
            return;
        }

        //Metodo para realizar depositos.
        public void realizarDeposito()
        {
            //Variables que se usaran en el metodo
            float cantidad;
            int op;  

            //Se crea una sentencia do/while para permitir que el usuario continue haciendo depositos hasta que el lo desee o llegue a su limite
            do
            {
                if (tipo == "Premium") //Se crea un if para validar el tipo de usuario
                {
                        
                        if (deposito == 8) //Se crea un if para si el usuario llego a su limite, se imprima un mensaje indicando que se llego al limite
                        {
                            Console.WriteLine(nombre + "," + " alcanzaste el limite de depositos. ");
                            return;
                        }
                        Console.WriteLine("Ingrese la cantidad a depositar: ");
                        cantidad = float.Parse(Console.ReadLine()); //Se lee la cantidad a depositar
                        balance = balance + cantidad; //Se suma la cantidad al balance
                        Console.WriteLine("Nuevo balance: " + balance); //Se imprime el nuevo balance
                        Console.WriteLine("Presione 1 para realizar otro deposito, o 0 si desea salir"); 
                        op = int.Parse(Console.ReadLine());
                        deposito++; //Contador para sumar el numero de depositos que se estan realizando y asi indicar el tope de depositos
                }
                else if (tipo == "Priority")
                {   
                        if (deposito == 5 )
                        {
                            Console.WriteLine(nombre + "," + " alcanzaste el limite de depositos. ");
                            return ;
                        }
                        Console.WriteLine("Ingrese la cantidad a depositar: ");
                        cantidad = float.Parse(Console.ReadLine());
                        balance = balance + cantidad;
                        Console.WriteLine("Nuevo balance: " + balance);
                       
                        Console.WriteLine("Presione 1 para realizar otro deposito, o 0 si desea salir");
                        op = int.Parse(Console.ReadLine());
                        deposito++; 

                }
                else
                {
                        if (deposito == 3)
                        {
                            Console.WriteLine(nombre + "," + " alcanzaste el limite de depositos. ");
                            return;
                        }
                        Console.WriteLine("Ingrese la cantidad a depositar: ");
                        cantidad = float.Parse(Console.ReadLine());
                        balance = balance + cantidad;
                        Console.WriteLine("Nuevo balance: " + balance);
                        Console.WriteLine("Presione 1 para realizar otro deposito, o 0 si desea salir");
                        op = int.Parse(Console.ReadLine());
                        deposito++;
                }

            } while (op != 0);

            return;
        }
        //Metodo para realizar retiros
        public void realizarRetiro()
        {
            //Variables que se usaran en el metodo
            float cantidad;
            int op;

            //Se crea una sentencia do/while para permitir que el usuario continue haciendo retiros hasta que el lo desee o llegue a su limite
            do
            {
                if (tipo == "Premium") //Se crea un if para validar el tipo de usuario
                {

                    if (retiro == 8) //Se crea un if para si el usuario llego a su limite, se imprima un mensaje indicando que se llego al limite
                    {
                        Console.WriteLine(nombre +","+ " alcanzaste el limite de retiros. ");
                        return;
                    }
                    Console.WriteLine("Ingrese la cantidad a retirar: ");
                    cantidad = float.Parse(Console.ReadLine());  //Se lee la cantidad a retirar
                    balance = balance - cantidad; //Se resta el retiro a la balance.
                    Console.WriteLine("Nuevo balance: " + balance);
                    Console.WriteLine("Presione 1 para realizar otro deposito, o 0 si desea salir");
                    op = int.Parse(Console.ReadLine());
                    retiro++;
                }
                else if (tipo == "Priority")
                {
                    if (retiro == 4)
                    {
                        Console.WriteLine(nombre + "," + " alcanzaste el limite de retiros. ");
                        return;
                    }
                    Console.WriteLine("Ingrese la cantidad a retirar: ");
                    cantidad = float.Parse(Console.ReadLine());
                    balance = balance - cantidad;
                    Console.WriteLine("Nuevo balance: " + balance);

                    Console.WriteLine("Presione 1 para realizar otro deposito, o 0 si desea salir");
                    op = int.Parse(Console.ReadLine());
                    retiro++;

                }
                else
                {
                    if (retiro == 2)
                    {
                        Console.WriteLine(nombre + "," + " alcanzaste el limite de retiros. ");
                        return;
                    }
                    Console.WriteLine("Ingrese la cantidad a retirar: ");
                    cantidad = float.Parse(Console.ReadLine());
                    balance = balance - cantidad;
                    Console.WriteLine("Nuevo balance: " + balance);
                    Console.WriteLine("Presione 1 para realizar otro retiro, o 0 si desea salir");
                    op = int.Parse(Console.ReadLine());
                    retiro++;
                }

            } while (op != 0);

            return;
        }
    
    }

}
