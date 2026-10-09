// Ejercicio 1: Consumo eléctrico de un motor de corriente directa
Console.WriteLine("SISTEMA DE CONSUMO ELECTRICO DE MOTOR CD");                        
Console.WriteLine();                                                                  // Salto de línea

// Crear un objeto de la clase MotorCD
MotorCD motor1 = new MotorCD();                                                       // Objeto: motor1 de la clase MotorCD

// Capturar la información del objeto
Console.Write("Ingrese el identificador del motor: ");                                // Solicitud de datos
motor1.Identificador = Console.ReadLine() ?? "Sin identificador";                     // Propiedad: Identificador

Console.Write("Ingrese el voltaje de alimentación (V): ");                            // Solicitud de datos
motor1.Voltaje = Convert.ToDouble(Console.ReadLine());                                // Propiedad: Voltaje

Console.Write("Ingrese la corriente consumida (A): ");                                // Solicitud de datos
motor1.Corriente = Convert.ToDouble(Console.ReadLine());                              // Propiedad: Corriente

// Solicitar al objeto que calcule la potencia
double potencia = motor1.CalcularPotencia();                                          // Invocación del método CalcularPotencia

// Mostrar resultados con unidades correspondientes
Console.WriteLine();                                                                  // Salto de línea
Console.WriteLine($"Motor: {motor1.Identificador}");                                  // Salida del identificador
Console.WriteLine($"Potencia: {potencia:F2} W");                                        // Salida con unidades (W)
Console.WriteLine($"Estado: {motor1.ObtenerEstado()}");                                 // Invocación del método ObtenerEstado

// Definición de la clase
class MotorCD                                                                         // Clase: MotorCD
{
    // Propiedades
    public string Identificador { get; set; } = "";                                   // Propiedad: Identificador
    public double Voltaje { get; set; }                                               // Propiedad: Voltaje
    public double Corriente { get; set; }                                             // Propiedad: Corriente

    // Método para calcular la potencia eléctrica
    public double CalcularPotencia()                                                  // Método: CalcularPotencia
    {
        double potencia;                                                              // Variable auxiliar
        potencia = Voltaje * Corriente;                                               // Operación matemática
        return potencia;                                                              // Retorno del resultado
    }

    // Método para determinar el estado del consumo
    public string ObtenerEstado()                                                     // Método: ObtenerEstado
    {
        double potencia = CalcularPotencia();                                         // Variable local con el cálculo

        if (potencia <= 120)                                                          // Validación de límite
        {
            return "NORMAL";                                                          // Retorno de estado
        }
        else
        {
            return "ELEVADO";                                                         // Retorno de estado
        }
    }
}