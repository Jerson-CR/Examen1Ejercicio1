using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidadOperarios = 0;
            decimal acumuladoSalarioNetoOperarios = 0;
            int cantidadTecnicos = 0;
            decimal acumuladoSalarioNetoTecnicos = 0;
            int cantidadProfesionales = 0;
            decimal acumuladoSalarioNetoProfesionales = 0;


            while (true)
            {
                Console.WriteLine("Ingrese los datos del empleado:");
                Console.Write("Cedula: "); string cedula = Console.ReadLine();
                Console.WriteLine("Nombre: "); string nombre = Console.ReadLine();
                Console.WriteLine("Tipo de empleado (1-Operario, 2-Tecnico, 3-Profesional): "); int tipoEmpleado = int.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad de horas laboradas: "); int cantidadHoras = int.Parse(Console.ReadLine());
                Console.WriteLine("Precio por hora: "); decimal precioHora = decimal.Parse(Console.ReadLine());
                decimal salarioOrdinario = cantidadHoras * precioHora;

                decimal aumento;
                switch (tipoEmpleado)
                {
                    case 1:
                        aumento = salarioOrdinario * 0.15m;
                        break;
                    case 2:
                        aumento = salarioOrdinario * 0.10m;
                        break;
                    case 3:
                        aumento = salarioOrdinario * 0.05m;
                        break;
                    default:
                        aumento = 0;
                        break;
                }

                decimal salarioBruto = salarioOrdinario + aumento;
                decimal deduccionCCSS = salarioBruto * 0.0917m;
                decimal salarioNeto = salarioBruto - deduccionCCSS;

                Console.WriteLine("Datos del empleado:");
                Console.WriteLine($"Cédula: {cedula}");
                Console.WriteLine($"Nombre: {nombre}");
                Console.WriteLine($"Tipo de empleado: {tipoEmpleado}");
                Console.WriteLine($"Salario por hora: {precioHora}");
                Console.WriteLine($"Cantidad de horas: {cantidadHoras}");
                Console.WriteLine($"Salario ordinario: {salarioOrdinario}");
                Console.WriteLine($"Aumento: {aumento}");
                Console.WriteLine($"Salario bruto: {salarioBruto}");
                Console.WriteLine($"Deducción CCSS: {deduccionCCSS}");
                Console.WriteLine($"Salario neto: {salarioNeto}");

                switch (tipoEmpleado)
                {
                    case 1:
                        cantidadOperarios++;
                        acumuladoSalarioNetoOperarios += salarioNeto;
                        break;
                    case 2:
                        cantidadTecnicos++;
                        acumuladoSalarioNetoTecnicos += salarioNeto;
                        break;
                    case 3:
                        cantidadProfesionales++;
                        acumuladoSalarioNetoProfesionales += salarioNeto;
                        break;
                }

                Console.Write("¿Desea ingresar más empleados? (s/n): "); string respuesta = Console.ReadLine();
                if (respuesta.ToLower() == "n")
                {
                    break;
                }
            }


            Console.WriteLine("Estadísticas:");
            Console.WriteLine($"Cantidad empleados tipo Operario: {cantidadOperarios}");
            Console.WriteLine($"Acumulado salario neto para Operarios: {acumuladoSalarioNetoOperarios}");
            Console.WriteLine($"Promedio salario neto para Operarios: {acumuladoSalarioNetoOperarios / cantidadOperarios}");

            Console.WriteLine($"Cantidad empleados tipo Técnico: {cantidadTecnicos}");
            Console.WriteLine($"Acumulado salrio neto para Tecnicos: {acumuladoSalarioNetoTecnicos}");
            Console.WriteLine($"Promedio salario neto para Opererios:{acumuladoSalarioNetoTecnicos / cantidadTecnicos}");

            Console.WriteLine($"Cantidad empleados tipo Técnico: {cantidadProfesionales}");
            Console.WriteLine($"Acumulado salrio neto para Tecnicos: {acumuladoSalarioNetoProfesionales}");
            Console.WriteLine($"Promedio salario neto para Opererios:{acumuladoSalarioNetoProfesionales / cantidadProfesionales}");

            Console.ReadLine();
        }
    }
}
