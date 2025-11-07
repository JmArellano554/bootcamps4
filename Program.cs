// Ejercicios Clase 4

//1. Dado que se tiene almacenado en una lista, los resultados de los últimos 10
//exámenes de un alumno, calcular su promedio y mostrar por pantalla las 10 notas de
//los exámenes y el promedio resultante.

using System.Reflection;

Console.WriteLine("--------------------------------------------");
Console.WriteLine("Ejercicio 1: Promedio de notas de exámenes");

// Se utiliza una lista de tipo double para almacenar las notas de los exámenes.
List<double> notasExamenes = new List<double> { 85.5, 90.0, 78.5, 88.0, 92.5, 80.0, 76.5, 89.0, 91.5, 84.0 };
double sumaNotas = 0;
// Se recorre la lista para calcular la suma de las notas.
foreach (double nota in notasExamenes)
{
    sumaNotas += nota;
}
// Se calcula el promedio dividiendo la suma de las notas entre la cantidad de exámenes.
double promedio = sumaNotas / notasExamenes.Count;
// Se muestran las notas de los exámenes y el promedio por pantalla.
Console.WriteLine("Notas de los exámenes:");
for (int i = 0; i < notasExamenes.Count; i++)
{
    Console.WriteLine($"Examen {i + 1}: {notasExamenes[i]}");
}
Console.WriteLine($"Promedio de notas: {promedio}");

//---------------------------------------------------------------

//2.Dada las edades de 20 personas guardadas en una lista, imprimir por pantalla cuántos son mayores de edad y cuántos no.

Console.WriteLine("--------------------------------------------");
Console.WriteLine("Ejercicio 2: Conteo de mayores y menores de edad");

List<int> edadesPersonas = new List<int> { 15, 22, 18, 17, 30, 25, 16, 19, 14, 21, 20, 13, 28, 24, 12, 27, 23, 11, 29, 26 };

int mayoresDeEdad = 0;
int menoresDeEdad = 0;

// Se recorre la lista para contar cuántas personas son mayores y menores de edad.
foreach (int edad in edadesPersonas)
{
    if (edad >= 18)
    {
        mayoresDeEdad++;
    }
    else
    {
        menoresDeEdad++;
    }
}

// Se muestran los resultados por pantalla.
Console.WriteLine($"Cantidad de personas mayores de edad: {mayoresDeEdad}");
Console.WriteLine($"Cantidad de personas menores de edad: {menoresDeEdad}");

//---------------------------------------------------------------

//3.Dado una lista de nombres de estudiantes, imprimir el que tenga más letras, y el que
//tenga menos letras de todos.

Console.WriteLine("--------------------------------------------");
Console.WriteLine("Ejercicio 3: Nombres más largo y más corto");

List<string> nombresEstudiantes = new List<string> { "Ana", "Sebastián", "María", "Juan", "Valentina", "Carlos", "Isabella", "Pedro", "Sofía", "Diego" };

string nombreMasLargo = nombresEstudiantes[0];
string nombreMasCorto = nombresEstudiantes[0];

// Se recorre la lista para encontrar el nombre más largo y el más corto.
foreach (string nombre in nombresEstudiantes)
{
    if (nombre.Length > nombreMasLargo.Length)
    {
        nombreMasLargo = nombre;
    }
    if (nombre.Length < nombreMasCorto.Length)
    {
        nombreMasCorto = nombre;
    }
}

// Se muestran los resultados por pantalla.
Console.WriteLine($"Nombre más largo: {nombreMasLargo}");
    
Console.WriteLine($"Nombre más corto: {nombreMasCorto}");

//---------------------------------------------------------------

//4.Crear una variable para guardar los nombres de elementos para una “lista de supermercado”. Solicitar al usuario que ingrese
//el nombre de un elemento que va a comprar en el super y verificar que el elemento esté en la lista. Si no está, agregarlo e
//indicar que no estaba. Si está, quitarlo de la lista, y avisar que sí estaba. Al finalizar mostrar por pantalla los elementos
//que no compró y los que compró, pero no estaban en la lista. Si se quiere, mostrar también todos los elementos que el
//usuario compró. Para salir el usuario debe ingresar “fin”.

Console.WriteLine("--------------------------------------------");
Console.WriteLine("Ejercicio 4: Lista de supermercado");

List<string> listaSupermercado = new List<string> { "Leche", "Pan", "Huevos", "Queso", "Frutas", "Verduras" };
List<string> elementosNoComprados = new List<string>(listaSupermercado);
List<string> elementosCompradosNoEnLista = new List<string>();

while (true)
{
    Console.Write("Ingrese el nombre del elemento que va a comprar (o 'fin' para terminar): ");
    string elemento = Console.ReadLine();
    if (elemento.ToLower() == "fin")
    {
        break;
    }
    if (listaSupermercado.Contains(elemento))
    {
        listaSupermercado.Remove(elemento);
        elementosNoComprados.Remove(elemento);
        Console.WriteLine($"El elemento '{elemento}' estaba en la lista y ha sido quitado.");
    }
    else
    {
        elementosCompradosNoEnLista.Add(elemento);
        Console.WriteLine($"El elemento '{elemento}' no estaba en la lista y ha sido agregado a los comprados.");
    }
}

// Se muestran los resultados por pantalla.
Console.WriteLine("Elementos que no compró:");
foreach (string elemento in elementosNoComprados)
{
    Console.WriteLine($"- {elemento}");
}
Console.WriteLine("Elementos que compró pero no estaban en la lista:");
foreach (string elemento in elementosCompradosNoEnLista)
{
    Console.WriteLine($"- {elemento}");
}

//5.Crear una matriz de 5 x 5. Almacenar una ‘I’ en lugares impares y una ‘P’ en lugares
//pares. Imprimir la matriz por pantalla

Console.WriteLine("--------------------------------------------");
Console.WriteLine("Ejercicio 5: Matriz de I y P");

char[,] matriz = new char[5, 5];

// Se llena la matriz con 'I' en posiciones impares y 'P' en posiciones pares.
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if ((i + j) % 2 == 0)
        {
            matriz[i, j] = 'P';
        }
        else
        {
            matriz[i, j] = 'I';
        }
    }
}

// Se imprime la matriz por pantalla.
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(matriz[i, j] + " ");
    }
    Console.WriteLine();
}

//6.Se tiene una matriz de 5x7, donde 5 representa la semana de un mes y 7 los días de la semana.
//La estructura es para registrar la temperatura diaria de una cabina de pago, estos oscilan entre los 7 y 38 grados.
//Deberá llenar la matriz de forma aleatoria para el mes de mayo donde el primer día inicia en lunes y el último (31) se ubica
//en el miércoles (la matriz puede ser inicializada con valores aleatorios desde el principio del programa, no es necesario
//pedir los valores al usuario para cada posición). Se nos pide hacer lo siguiente:
//a.Obtener la temperatura más alta y baja de la semana y que día se produjo (lunes, martes, etc.)
//b. Promedio de temperatura de la semana.
//c. Temperatura más alta del mes y su día.

Console.WriteLine("--------------------------------------------");
Console.WriteLine("Ejercicio 6: Temperaturas diarias de mayo");

// Matriz de 5 semanas (filas) por 7 días (columnas)
const int SEMANAS = 5;
const int DIAS = 7;
int[,] temperaturas = new int[SEMANAS, DIAS];
Random random = new Random();

// Nombres de los días para la impresión y reportes
string[] nombresDias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };

// Variables para el seguimiento de la temperatura más alta del MES
int tempMaxMes = -1;
int diaMaxMes = -1;
int semanaMaxMes = -1;

// Llenado de la Matriz con Temperaturas Aleatorias (7 a 38 grados)

int contadorDias = 1;
Console.WriteLine("--- Registro de Temperaturas de Mayo ---");
for (int i = 0; i < SEMANAS; i++)
{
    for (int j = 0; j < DIAS; j++)
    {
        if (contadorDias <= 31)
        {
            // Genera de manera aleatoria la temperatura entre 7 y 38
            temperaturas[i, j] = random.Next(7, 39);
            contadorDias++;
        }
        else
        {
            temperaturas[i, j] = 0;
        }
    }
}

//Impresión y Cálculos por Semana (Puntos a, b)
for (int i = 0; i < SEMANAS; i++)
{
    Console.WriteLine($"\n--- Semana {i + 1} ---");

    // Inicializar variables para la semana
    int tempMaxSemana = -1;
    int tempMinSemana = 100; // Inicializamos con un valor alto (mayor a 38)
    int diaMax = -1;
    int diaMin = -1;
    double sumaTemperaturas = 0;
    int diasContados = 0; // Para manejar el promedio de la última semana

    for (int j = 0; j < DIAS; j++)
    {
        int tempActual = temperaturas[i, j];

        if (tempActual > 0)
        {
            Console.Write($"{nombresDias[j]}: {tempActual}°C | ");

            sumaTemperaturas += tempActual;
            diasContados++;

            // a. Obtener Max y Min de la semana
            if (tempActual > tempMaxSemana)
            {
                tempMaxSemana = tempActual;
                diaMax = j;
            }
            if (tempActual < tempMinSemana)
            {
                tempMinSemana = tempActual;
                diaMin = j;
            }

            // c. Obtener Max del Mes
            if (tempActual > tempMaxMes)
            {
                tempMaxMes = tempActual;
                diaMaxMes = j;
                semanaMaxMes = i;
            }
        }
    }

    // Mostrar resultados semanales
    if (diasContados > 0)
    {
        // a. Reporte Semanal Max y Min
        Console.WriteLine($"\n[a] Máxima: {tempMaxSemana}°C el {nombresDias[diaMax]}. Mínima: {tempMinSemana}°C el {nombresDias[diaMin]}.");

        // b. Promedio Semanal
        double promedioSemanal = sumaTemperaturas / diasContados;
        Console.WriteLine($"[b] Promedio Semanal: {promedioSemanal:F2}°C");
    }
}

// Reporte Final del Mes (Punto c)
Console.WriteLine("\n===================================");
Console.WriteLine("--- Reporte Mensual ---");

// se convierte el día de la semana y la semana del mes al día real de Mayo
// (Semana * 7) + (Día de la semana + 1)
int diaReal = (semanaMaxMes * 7) + (diaMaxMes + 1);

Console.WriteLine($"La temperatura más alta del mes fue: {tempMaxMes}°C");
Console.WriteLine($"Se produjo el día {diaReal} de Mayo ({nombresDias[diaMaxMes]}, Semana {semanaMaxMes + 1}).");
Console.WriteLine("===================================");

//7.Almacenar en una matriz las tablas del 1 al 9, teniendo en cuenta que en la primera fila y la primera columna se debe
//guardar los números (de 0 a 9), estando el cero en la primera posición (fila 0, columna 0). El resto de los lugares debe ser
//calculado usando los números que se dispone, por ejemplo, en la fila 1, calcular 1*1, 1*2, 1*3, etc. usando las posiciones
//del array o arreglo. Al finalizar el cálculo, mostrar la matriz por pantalla

Console.WriteLine("--------------------------------------------");
Console.WriteLine("Ejercicio 7: Tablas de multiplicar del 1 al 9");

int[,] tablaMultiplicar = new int[10, 10];

// Se llena la primera fila y la primera columna con los números del 0 al 9.
for (int i = 0; i < 10; i++)
{
    tablaMultiplicar[0, i] = i;
    tablaMultiplicar[i, 0] = i;
}

// Se calcula el resto de la tabla de multiplicar.
for (int i = 1; i < 10; i++)
{
    for (int j = 1; j < 10; j++)
    {
        tablaMultiplicar[i, j] = tablaMultiplicar[i, 0] * tablaMultiplicar[0, j];
    }
}

// Se imprime la tabla de multiplicar por pantalla.
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        Console.Write(tablaMultiplicar[i, j].ToString().PadLeft(3));
    }
    Console.WriteLine();
}

//8.Crear una matriz de 10 x 10, y “esconder” varias ‘X’ en lugares aleatorios (la cantidad que el programador decida, pero
//no más de la mitad de los lugares disponibles en la matriz). El usuario deberá ingresar el lugar donde cree que hay una X,
//ingresando la fila y la columna por separado. Informar si acertó o no por cada ingreso. Se debe pedir al usuario ingresar
//valores por tantas X que se haya guardado. El usuario tiene 3 intentos para fallar. Al finalizar (Ya sea porque se terminaron
//los 3 intentos, o el jugador acertó todas las X) imprimir por pantalla la matriz con sus correspondientes X,
//mostrando un * donde no haya nada.

Console.WriteLine("--------------------------------------------");
Console.WriteLine("Ejercicio 8: Juego de encontrar las X");

// Configuración del Tablero y Reglas
const int tamaño = 10;
const int maxFallos = 3;
const int cantidadX = 40; // Decidimos esconder 15 'X' (menos de la mitad de 100)

char[,] tablero = new char[tamaño, tamaño];
Random random8 = new Random();

int aciertos = 0;
int fallosRestantes = maxFallos;
int intentosRealizados = 0;

// Inicializar el tablero con '*'
for (int i = 0; i < tamaño; i++)
{
    for (int j = 0; j < tamaño; j++)
    {
        tablero[i, j] = '*';
    }
}

// se coloca las 'X' en posiciones aleatorias
while (aciertos < cantidadX)
{
    int fila = random.Next(tamaño); // Número aleatorio entre 0 y 9
    int columna = random.Next(tamaño);

    if (tablero[fila, columna] != 'X')
    {
        tablero[fila, columna] = 'X';
        aciertos++; // Usamos 'aciertos' como contador de X colocadas inicialmente
    }
}
aciertos = 0; // Reiniciamos 'aciertos' a 0 para el juego del usuario

// Bucle Principal del Juego
Console.WriteLine($"\n¡Busca las {cantidadX} 'X' escondidas en la matriz {tamaño}x{tamaño}!");

// El juego continúa MIENTRAS le queden fallos Y NO haya encontrado todas las 'X'.
while (fallosRestantes > 0 && aciertos < cantidadX)
{
    Console.WriteLine($"\n--- Intentos: {intentosRealizados} | Aciertos: {aciertos}/{cantidadX} | Fallos restantes: {fallosRestantes} ---");

    int filaInput, colInput;

    // Pedir Fila (con manejo básico de errores)
    Console.Write("Ingresa la Fila (0-9): ");
    if (!int.TryParse(Console.ReadLine(), out filaInput) || filaInput < 0 || filaInput >= tamaño)
    {
        Console.WriteLine("Entrada de fila inválida. Intenta de nuevo.");
        continue; // Volver al inicio del bucle
    }

    // Pedir Columna (con manejo básico de errores)
    Console.Write("Ingresa la Columna (0-9): ");
    if (!int.TryParse(Console.ReadLine(), out colInput) || colInput < 0 || colInput >= tamaño)
    {
        Console.WriteLine("Entrada de columna inválida. Intenta de nuevo.");
        continue; // Volver al inicio del bucle
    }

    intentosRealizados++;

    // Lógica del Acertijo
    char celda = tablero[filaInput, colInput];

    if (celda == 'X')
    {
        Console.WriteLine("¡ACIERTO! Encontraste una 'X'.");
        tablero[filaInput, colInput] = 'O'; // Marcar como "encontrada"
        aciertos++;
    }
    else if (celda == 'O')
    {
        Console.WriteLine("Ya habías acertado en esta posición. Intenta otra.");
    }
    else // Aquí es donde estaba el '*' original
    {
        Console.WriteLine("FALLO. No hay una 'X' ahí.");
        fallosRestantes--;
    }
}

// Reporte Final
Console.WriteLine("\n==============================================");
if (aciertos == cantidadX)
{
    Console.WriteLine("🏆 ¡FELICIDADES! ¡Encontraste todas las 'X'! 🏆");
}
else
{
    Console.WriteLine($"GAME OVER. Te quedaste sin intentos. (Aciertos: {aciertos}/{cantidadX})");
}

Console.WriteLine("\n--- Tablero Revelado ---");
ImprimirTablero(tablero, tamaño);

// Función auxiliar para imprimir el tablero
void ImprimirTablero(char[,] mat, int size)
{
    Console.Write("   "); // Espacio para la columna de índices de fila
    for (int j = 0; j < size; j++)
    {
        Console.Write($" {j:D2}"); // Imprime los índices de columna (00, 01, ...)
    }
    Console.WriteLine();

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{i:D2} "); // Imprime el índice de fila
        for (int j = 0; j < size; j++)
        {
            // Revertir 'O' a 'X' para mostrar el tablero final, o mantener 'O' si lo deseas
            char simbolo = (mat[i, j] == 'O') ? 'X' : mat[i, j];
            Console.Write($" {simbolo} ");
        }
        Console.WriteLine();
    }
}

//9.Diccionario de calificaciones: Crear un diccionario donde la clave sea el nombre del alumno y el valor sea su nota.
//El programa debe permitir:
//a.Agregar alumnos y sus notas.
//b. Mostrar el promedio general del curso.
//c. Indicar el alumno con mejor nota y el de peor nota.
//d. Hint: usar Dictionary<string, double> y recorrer con foreach

Console.WriteLine("--------------------------------------------");
Console.WriteLine("Ejercicio 9: Diccionario de calificaciones");

Dictionary<string, double> calificaciones = new Dictionary<string, double>();

// a. Agregar alumnos y sus notas.
calificaciones["Ana"] = 85.5;
calificaciones["Juan"] = 92.0;
calificaciones["María"] = 78.5;
calificaciones["Pedro"] = 88.0;
calificaciones["Lucía"] = 91.5;

double sumaNotasDict = 0;
double notaMax = double.MinValue;
double notaMin = double.MaxValue;
string alumnoMax = "";
string alumnoMin = "";

// Se recorre el diccionario para calcular el promedio, y encontrar el alumno con mejor y peor nota.
foreach (var entry in calificaciones)
{
    string alumno = entry.Key;
    double nota = entry.Value;
    sumaNotasDict += nota;
    if (nota > notaMax)
    {
        notaMax = nota;
        alumnoMax = alumno;
    }
    if (nota < notaMin)
    {
        notaMin = nota;
        alumnoMin = alumno;
    }
}
double promedioDict = sumaNotasDict / calificaciones.Count;

// Se muestran los resultados por pantalla.
Console.WriteLine($"Promedio general del curso: {promedioDict}");
Console.WriteLine($"Alumno con mejor nota: {alumnoMax} con {notaMax}");
Console.WriteLine($"Alumno con peor nota: {alumnoMin} con {notaMin}");

//10.Simulador de atención en ventanilla: Usar una cola (Queue) para simular la atención de clientes en una ventanilla bancaria.
//a. Encolar nombres de clientes.
//b. Atender (desencolar) uno por uno hasta que no queden.
//c. Mostrar en pantalla quién está siendo atendido y cuántos quedan en la fila.
//d. Hint: usar Enqueue(), Dequeue() y Count.

Console.WriteLine("--------------------------------------------");
Console.WriteLine("Ejercicio 10: Simulador de atención en ventanilla");

Queue<string> filaClientes = new Queue<string>();

// a. Encolar nombres de clientes.
filaClientes.Enqueue("Cliente 1");
filaClientes.Enqueue("Cliente 2");
filaClientes.Enqueue("Cliente 3");
filaClientes.Enqueue("Cliente 4");
filaClientes.Enqueue("Cliente 5");

// b. Atender (desencolar) uno por uno hasta que no queden.
while (filaClientes.Count > 0)
{
    string clienteAtendido = filaClientes.Dequeue();
    // c. Mostrar en pantalla quién está siendo atendido y cuántos quedan en la fila.
    Console.WriteLine($"Atendiendo a: {clienteAtendido}. Quedan {filaClientes.Count} en la fila.");
}
Console.WriteLine("No quedan más clientes en la fila.");

//11.Inventario con múltiples colecciones: Diseñar un sistema de inventario básico usando distintas colecciones:
//a.Un List<string> con los productos disponibles.
//b.Un Dictionary<string, int> para registrar el stock de cada producto.
//c.Un Stack<string> para llevar el historial de acciones realizadas (agregar, quitar, vender).
//d.El programa debe permitir:
//i.Agregar un producto y su cantidad.
//ii. Vender un producto (restando stock).
//iii. Mostrar el inventario actual.
//iv. Mostrar las últimas 3 acciones registradas.
//e. Hint: combina listas, diccionarios y pilas para manipular distintos tipos de información.

Console.WriteLine("--------------------------------------------");
Console.WriteLine("Ejercicio 11: Inventario con múltiples colecciones");

List<string> productos = new List<string>();
Dictionary<string, int> stockProductos = new Dictionary<string, int>();
Stack<string> historialAcciones = new Stack<string>();
// i. Agregar un producto y su cantidad.
void AgregarProducto(string nombre, int cantidad)
{
    if (!productos.Contains(nombre))
    {
        productos.Add(nombre);
        stockProductos[nombre] = cantidad;
    }
    else
    {
        stockProductos[nombre] += cantidad;
    }
    historialAcciones.Push($"Agregado: {nombre}, Cantidad: {cantidad}");
}
// ii. Vender un producto (restando stock).
void VenderProducto(string nombre, int cantidad)
{
    if (productos.Contains(nombre) && stockProductos[nombre] >= cantidad)
    {
        stockProductos[nombre] -= cantidad;
        historialAcciones.Push($"Vendido: {nombre}, Cantidad: {cantidad}");
    }
    else
    {
        Console.WriteLine($"No hay suficiente stock de {nombre} para vender {cantidad} unidades.");
    }
}
// iii. Mostrar el inventario actual.
void MostrarInventario()
{
    Console.WriteLine("Inventario Actual:");
    foreach (var producto in productos)
    {
        Console.WriteLine($"- {producto}: {stockProductos[producto]} unidades");
    }
}
// iv. Mostrar las últimas 3 acciones registradas.
void MostrarHistorialAcciones()
{
    Console.WriteLine("Últimas 3 acciones:");
    int contador = 0;
    foreach (var accion in historialAcciones)
    {
        Console.WriteLine($"- {accion}");
        contador++;
        if (contador >= 3) break;
    }
}
// Ejemplo de uso del sistema de inventario
AgregarProducto("Manzanas", 50);
AgregarProducto("Bananas", 30);
VenderProducto("Manzanas", 10);
VenderProducto("Bananas", 5);
MostrarInventario();
MostrarHistorialAcciones();
MostrarInventario();

Console.WriteLine("--------------------------------------------");
Console.WriteLine("Fin de los ejercicios.");

