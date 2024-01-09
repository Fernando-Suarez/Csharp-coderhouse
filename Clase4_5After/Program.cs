

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
//8.Ingresar x cant de pesos y mostrar la cantidad de personas que pesan + de 80 y - de 80.
//9.	Ingresar 3 datos y decir que clase de triangulo es. Para formar un triangulo hay que tener en cuenta que la suma de sus dos las inferiores
//tiene que ser mayor a el lado superior
//10.	Dados 3 números donde el primero y el último son límites de un intervalo, indicar si el tercero pertenece a dicho intervalo
//11.	Por teclado se ingresa el valor hora de un empleado.Posteriormente se ingresa el nombre del empleado, la antiguedad y la cantidad de horas trabajadas en el mes. Se pide calcular el importe a cobrar teniendo en cuenta que al total que resuelta de multiplicar el valor hora por la cantidad de horas trabajadas, hay que sumarle la cantidad de años trabajados multiplicados por $30, y al total de todas esas operaciones restarle el 13% en concepto de descuentos. Imprimir el recibo correspondiente con el nombre, la antiguedad, el valor hora, el total a cobrar en bruto, el total de descuentos y el valor neto a cobrar.
//12.	Se registran 10 empleados de una empresa Número de legajo, sueldo, sexo(1 = femenino y 2 = masculino).Mostrar cuantas mujeres ganan más de $500 pesos y cuantos hombres ganan menos de $400.
//13.	Se ingresa por teclado la cantidad de agua caida, en mílimetros día a día durante un mes.Se pide determinar el día de mayor lluvia, el de menor y el promedio.
//14.	Hacer el algoritmo que imprima el mayor y el menor de una serie de 5 números que vamos introduciendo por teclado.
