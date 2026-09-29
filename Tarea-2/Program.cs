int opcion = 0;

do
{
    Console.WriteLine("1-Agregar empleado");
    Console.WriteLine("2-Imprimir");
    Console.WriteLine("Seleccione una opción:");
    opcion = int.Parse(Console.ReadLine());

    if (opcion == 1)
    {
        Console.WriteLine("Ingrese su numero de cedula: ");
        string cedula = Console.ReadLine();

        Console.WriteLine("Ingrese su nombre: ");
        string nombre = Console.ReadLine();


        while (string.IsNullOrEmpty(cedula) || string.IsNullOrEmpty(nombre))
        {
            Console.WriteLine("Error: La cédula y el nombre no pueden estar vacíos.");
            Console.WriteLine("Ingrese su numero de cedula: ");
            cedula = Console.ReadLine();

            Console.WriteLine("Ingrese su nombre: ");
            nombre = Console.ReadLine();
        }

        Console.WriteLine("Ingrese las horas trabajadas: ");
        int horasTrabajadas = int.Parse(Console.ReadLine());

        if (horasTrabajadas <= 0)
        {
            Console.WriteLine("Error: Las horas trabajadas no pueden ser negativas.");
            continue; // en vez de return
        }

        Console.WriteLine("Tipo de empleado (1-Operario, 2-Tecnico, 3-Profecional): ");
        int tipoEmpleado = int.Parse(Console.ReadLine());

        int salarioHora = 0;
        double porcentajeAumento = 0;

        if (tipoEmpleado == 1) // Operario
        {
            salarioHora = 2000;
            porcentajeAumento = 0.15;
        }
        else if (tipoEmpleado == 2) // Tecnico
        {
            salarioHora = 2500;
            porcentajeAumento = 0.10;
        }
        else if (tipoEmpleado == 3) // Profesional
        {
            salarioHora = 3500;
            porcentajeAumento = 0.05;
        }
        else
        {
            Console.WriteLine("Error: Tipo de empleado inválido.");
            return;
        }

        // Calcular el salario total
        double salarioBase = horasTrabajadas * salarioHora;
        double aumento = salarioBase * porcentajeAumento;
        double salarioBruto = salarioBase + aumento;
        double deduccion = salarioBruto * 0.0917; // ccss
        double salarioNeto = salarioBruto - deduccion;

        // Resultados
        Console.WriteLine($"Cédula: {cedula}");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Tipo de empleado: {tipoEmpleado}");
        Console.WriteLine($"salario por hora: {salarioHora}");
        Console.WriteLine($"Horas trabajadas: {horasTrabajadas}");
        Console.WriteLine($"Salario base: {salarioBase}");
        Console.WriteLine($"Aumento: {aumento}");
        Console.WriteLine($"Salario bruto: {salarioBruto}");
        Console.WriteLine($"Deduccion: {deduccion}");
        Console.WriteLine($"Salario neto: {salarioNeto}");
    }
    else if (opcion == 2)
    {
        Console.WriteLine("Saliendo del programa...");
    }
    else
    {
        Console.WriteLine("Opción inválida, intente de nuevo.");
    }

} while (opcion != 2);

