

// Ejercicios:  

//1.Mostrar los nùmeros impares entre el 0 y el 100

void calcularNumeroPar()
{
    for (int i = 0; i <= 100; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine("El numero {0} es par", i);
        }
    }
}


//2.Mostrar los números pares entre el 0 y el 100

void calcularNumeroImpar()
{
    for (int i = 0; i <= 100; i++)
    {
        if (i % 2 != 0)
        {
            Console.WriteLine($"El numero {i} es impar");
        }
    }
}

//3.Mostrar los multiplos de 3 del 0 al 100

void multiplosDe3()
{
    for( int i = 0; i <= 100; i++)
    {
        if ( i % 3 == 0 )
        {
            Console.WriteLine($"El numero {i} es multiplo de 3");
        }
    }
}


//4.Ingresar un número y mostrar la suma de los números que lo anteceden.

void sumarNumerosAnteriores(int numero)
{
    int suma = 0;
    for(int i = 0; i < numero; i++)
    {
        suma += i;
    }
    Console.WriteLine($"La suma de los numeros que anteceden a {numero} es: {suma}");
}


//5.Mostrar los números del 1 hasta el número ingresado.

void mostrarNumeros(int numero)
{
    for( int i = 1; i <= numero; i++)
    {
        Console.WriteLine($"{i}");
    }
}

//6.Contar los multiplos de 3 desde la unidad hasta un num que ingresamos

void contarMultiplosDe3(int numero)
{
    int contador = 0;
    for (int i = 0; i < numero; i++)
    {
        if(i % 3 == 0)
        {
            contador++;
        }
    }
    Console.WriteLine($"Hay {contador} numeros que son multiplos de 3");
}


//7.Ingresar 10 números sumar los + y multiplicar los - .

void sumarMultiplicar()
{
    int suma = 0;
    int negativo;

    for(int i = 1; i <= 10; i++)
    Console.WriteLine("Ingresa un numero");
    int numero = Convert.ToInt32(Console.ReadLine());
    if ( numero > 0 )
    {
        suma += numero;
    } else
    {
        negativo = numero;
    }
}



//8.Ingresar x cant de pesos y mostrar la cantidad de personas que pesan + de 80 y - de 80.

void contarPesoPersonas()
{
    int contador1 = 0;
    int contador2 = 0;
    for ( int i = 1; i <= 5; i++)
    {
        Console.WriteLine("INGRESE UN PESO EN KG");
        int peso = Convert.ToInt32(Console.ReadLine());
        if (peso >= 80) 
        {
            contador1++;
        } else 
        {
            contador2++;
        }
    }
    Console.WriteLine($"LA CANTIDAD DE PERSONAS QUE PESAN MAS DE 80 O IGUAL ES: {contador1} Y LAS QUE PESAN MENOS DE 80 ES: {contador2}");
}


//9.	Ingresar 3 datos y decir que clase de triangulo es. Para formar un triangulo hay que tener en cuenta que la suma de sus dos las inferiores
//tiene que ser mayor a el lado superior

//10.	Dados 3 números donde el primero y el último son límites de un intervalo, indicar si el tercero pertenece a dicho intervalo

//11.	Por teclado se ingresa el valor hora de un empleado.Posteriormente se ingresa el nombre del empleado, la antiguedad y la cantidad de horas trabajadas en el mes.
//Se pide calcular el importe a cobrar teniendo en cuenta que al total que resuelta de multiplicar el valor hora por la cantidad de horas trabajadas,
//hay que sumarle la cantidad de años trabajados multiplicados por $30, y al total de todas esas operaciones restarle el 13% en concepto de descuentos.
//Imprimir el recibo correspondiente con el nombre, la antiguedad, el valor hora, el total a cobrar en bruto, el total de descuentos y el valor neto a cobrar.
void reciboSueldo()
{

    Console.WriteLine("INGRESE VALOR HORA DEL EMPLEADO");
    double valorHora = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("INGRESE EL NOMBRE DEL EMPLEADO");
    string nombreEmpleado = Console.ReadLine();
    Console.WriteLine("INGRESE LA ANTIGUEDAD DEL EMPLEADO");
    int antiguedad = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("INGRESE LA CANTIDAD DE HORAS TRABAJAS EN EL MES");
    int cantidadHorasTrabajadasMes = Convert.ToInt32(Console.ReadLine());

    double sueldoBruto = (valorHora * cantidadHorasTrabajadasMes) + (antiguedad * 30);
    double descuentos = sueldoBruto * 0.13;
    double sueldoNeto = sueldoBruto - descuentos;
    Console.WriteLine($"RECIBO DE SUELDO A NOMBRE DE :{nombreEmpleado} \n ANTIGUEDAD: {antiguedad} \n VALOR HORA: {valorHora} \n TOTAL BRUTO: {sueldoBruto} \n DESCUENTOS: {descuentos} \n TOTAL NETO: {sueldoNeto} ");
}

//12.	Se registran 10 empleados de una empresa Número de legajo, sueldo, sexo(1 = femenino y 2 = masculino).
//Mostrar cuantas mujeres ganan más de $500 pesos y cuantos hombres ganan menos de $400.

void registrarEmpleado()
{
    
    int contadorF = 0;
    int contadorM = 0;
    int seleccionUsuario;
    for (int i = 1; i <=10; i++)
    {
        Console.WriteLine("INGRESE NUMERO DE LEGAJO");
        Console.ReadLine();
        Console.WriteLine("INGRESE SUELDO");
        int sueldo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("SELECCIONAR 1-FEMENINO O 2-MASCULINO");
        seleccionUsuario = Convert.ToInt32(Console.ReadLine());
        while(seleccionUsuario !=1 && seleccionUsuario !=2)
        {
            Console.WriteLine("SELECCIONAR 1-FEMENINO O 2-MASCULINO");
            seleccionUsuario = Convert.ToInt32(Console.ReadLine());

        }
        if (seleccionUsuario == 1 && sueldo >= 500)
        {
            contadorF++;
        } else if(seleccionUsuario == 2 && sueldo <= 400)
        {
            contadorM++;
        }

    }
    Console.WriteLine($"LA CANTIDAD DE MUJERES QUE GANAN MAS DE $500 SON : {contadorF} Y LA CANTIDAD DE HOMBRES QUE GANAN MENOS DE $400 SON: {contadorM}");
}
registrarEmpleado();
//13.	Se ingresa por teclado la cantidad de agua caida, en mílimetros día a día durante un mes.Se pide determinar el día de mayor lluvia, el de menor y el promedio.

//14.	Hacer el algoritmo que imprima el mayor y el menor de una serie de 5 números que vamos introduciendo por teclado.

void mayorMenor()
{
    int mayor = 0;
    int menor = 0;
    Console.WriteLine("INGRESE UN NUMERO");
    int primerNumero = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= 4; i++)
    {
        Console.WriteLine("INGRESE UN NUMERO");
        int numero = Convert.ToInt32(Console.ReadLine());
        if (numero < primerNumero)
        {
            menor = numero;
        } else
        {
            mayor = numero;
        }
        
    }
    Console.WriteLine($"EL MAYOR NUMERO DE LOS 5 INGRESADOS ES {mayor} Y EL MENOR ES {menor}");
}
