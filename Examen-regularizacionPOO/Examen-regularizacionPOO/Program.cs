
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Examen_regularizacionPOO
{
    class Program
    {
        class Productos
        {
            public string Producto;
            public int cantidad;
            public float precio;

            public Productos (string Producto, int cantidad, float precio)
            {
                this.Producto = Producto;
                this.cantidad = cantidad;
                this.precio = precio; 
            }

            public void Despliegue ()
            {
                Console.WriteLine("Producto: " + Producto);
                Console.WriteLine("Cantidad: " + cantidad);
                Console.WriteLine("Precio: " + precio);
                Console.WriteLine("Oprima < Enter > para Finalizar ");
                
            }
            ~Productos()
            {
                Console.WriteLine("Memoria Liberada Clase Productos");
            }
               

        }

        static void Main(string[] args)
        {
            try
            {
                StreamWriter Productos= new StreamWriter("Productos.txt");

                String p;                
                Console.WriteLine(" Finalice cada línea pulsando la tecla < Enter > ");
                p= Console.ReadLine();

                Console.Write("Ingrese Producto: ");
                string Producto = Console.ReadLine();
                Console.Write("Ingrese la cantidad: ");
                int cantidad = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el precio: ");
                float precio = Single.Parse(Console.ReadLine());
                Console.Clear();

                Productos.Write(Producto + cantidad + precio);
                Productos.Close();


                Productos e1 = new Productos(Producto, cantidad, precio);
                e1.Despliegue();
                
                

            }
            catch(Exception e)
            {
                Console.WriteLine("Error: " + e.Message);               
            }
            Console.ReadKey();
        }
    }
}
