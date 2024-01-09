// See https://aka.ms/new-console-template for more information



//Consigna

//1. Supongamos que tenemos un listado de Empleados y queremos mostrar a qué categoría corresponden según su código a saber:
//A es Administrativo
//B es Profesional
//C es Maestranza
//Ninguno de los anteriores es Sin Categoria

//Observar el uso de ReadLine() en este caso al asignarse a una variable string no fue necesario convertir.


//Variables

//string categoria;


//Cuerpo del Programa
//Console.WriteLine("Por Favor Ingrese Categoria A,B o C");
//categoria = Console.ReadLine().ToUpper();

//switch (categoria)
//{
//	case "A":
//		Console.WriteLine("Administrativo");
//		break;
//	case "B":
//		Console.WriteLine("Profesional");
//		break;
//	case "C":
//		Console.WriteLine("Maestranza");
//		break;
//	default:
//		Console.WriteLine("Sin Categoria");
//		break;
//}



//Consigna

//2. La secretaria de una universidad nos pide un sistema para poder cargar los datos de sus alumnos,
//necesitan poder cargar la comisión que puede ser A si son de turno mañana, B si son de turno tarde, C si son de turno noche
//y en caso de no tener comisión indica que no tienen turno fijado.
//También cada docente califica a sus alumnos con una nota entre 0 y 10, en caso de ser menor a 4 el alumno Recursa la Materia,
//si está entre 4 y 7 es Aprobó Cursada y si es mayor que 7 Promociona la Materia..

//Variables
string comision;
int calificacionAlumno;

//Cuerpo del Programa


Console.WriteLine("BIENVENIDOS A LA UNIVERSIDAD CODERHOUSE!!!");
Console.WriteLine("EL MEJOR LUGAR PARA ESTUDIAR DEL MUNDO!!!");
Console.WriteLine("INGRESE SU COMISION ");
comision  = Console.ReadLine();


switch (comision)
{
    case "A":
        Console.WriteLine("TURNO MAÑANA");
        break;
    case "B":
        Console.WriteLine("TURNO TARDE");
        break;
    case "C":
        Console.WriteLine("TURNO NOCHE");
        break;
    default:
        Console.WriteLine("SIN TURNO FIJO");
        break;
}

Console.WriteLine("INGRESE LA NOTA DEL ALUMNO : ");
calificacionAlumno = Convert.ToInt32(Console.ReadLine());

if (calificacionAlumno >= 0 && calificacionAlumno < 4)
{
    Console.WriteLine(" RECURSA LA MATERIA");
} else if(calificacionAlumno >= 4 && calificacionAlumno <= 7) 
{
    Console.WriteLine("APROBO LA CURSADA");
} else if (calificacionAlumno > 7 && calificacionAlumno <= 10)
{
    Console.WriteLine("PROMOCIONO LA MATERIA");
} else
{
    Console.WriteLine("CALIFICAR SOLO DEL 0 AL 10");
}

