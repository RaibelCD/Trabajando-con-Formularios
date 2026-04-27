// See EJERCICIOS DE C# 
// ============================================================

using System;

class Ejercicios
{
    // ============================================================
    // EJERCICIO 01
    // Un trabajador le pagan según sus horas y una tarifa de pago
    // por horas. Si la cantidad de horas trabajadas es mayor a 40,
    // la tarifa se incrementa en un 50% para las horas extras.
    // Calcular el salario del trabajador.
    // ============================================================
    static void Ejercicio01()
    {
        double tarifa, horastrabajadas, horasextra, salario, tarifaextra;
        Console.WriteLine("ingrese horas trabajadas");
        horastrabajadas = double.Parse(Console.ReadLine());
        Console.WriteLine("ingrese tarifa");
        tarifa = double.Parse(Console.ReadLine());
        if (horastrabajadas <= 40 && horastrabajadas >= 0)
        {
            salario = horastrabajadas * tarifa;
            Console.WriteLine("el salario es: " + salario);
        }
        else if (horastrabajadas > 40)
        {
            horasextra = horastrabajadas - 40;
            tarifaextra = tarifa + 0.5 * tarifa;
            salario = horasextra * tarifaextra + 40 * tarifa;
            Console.WriteLine("el salario es: " + salario);
        }
        else
            Console.WriteLine("las horas trabajadas no pueden ser negativas");
        Console.ReadLine();
    }

    // ============================================================
    // EJERCICIO 02
    // A un trabajador le descuentan de su sueldo el 10% si su
    // sueldo es menor o igual a 1000. Por encima de 1000 y hasta
    // 2000 el 5% adicional, y por encima de 2000 el 3% adicional.
    // Calcular el descuento y sueldo neto.
    // ============================================================
    static void Ejercicio02()
    {
        double sueldo, sueldoneto, descuento;
        Console.WriteLine("ingrese el sueldo");
        sueldo = double.Parse(Console.ReadLine());
        if (sueldo <= 1000 && sueldo >= 0)
        {
            descuento = sueldo * 0.1;
            sueldoneto = sueldo - descuento;
            Console.WriteLine("el descuento es: {0} y el sueldo neto es: {1}", descuento, sueldoneto);
        }
        else if (sueldo <= 2000 && sueldo >= 0)
        {
            descuento = (sueldo - 1000) * 0.05 + (1000 * 0.1);
            sueldoneto = sueldo - descuento;
            Console.WriteLine("el descuento es: {0} y el sueldo neto es: {1}", descuento, sueldoneto);
        }
        else if (sueldo > 2000)
        {
            descuento = (sueldo - 2000) * 0.03 + (1000 * 0.05) + (1000 * 0.10);
            sueldoneto = sueldo - descuento;
            Console.WriteLine("el descuento es: {0} y el sueldo neto es: {1}", descuento, sueldoneto);
        }
        else
            Console.WriteLine("error el sueldo no puede ser negativo");
        Console.ReadLine();
    }

    // ============================================================
    // EJERCICIO 03
    // Dado un monto calcular el descuento considerando que por
    // encima de 100 el descuento es el 10% y por debajo de 100
    // el descuento es el 2%.
    // ============================================================
    static void Ejercicio03()
    {
        double monto, descuento;
        Console.WriteLine("ingrese monto");
        monto = double.Parse(Console.ReadLine());
        if (monto > 100)
        {
            descuento = monto * 0.1;
            Console.WriteLine("el monto  {0} tiene un descuento del {1}", monto, descuento);
        }
        else if (monto <= 100 && monto > 0)
        {
            descuento = monto * 0.2;
            Console.WriteLine("el monto  {0} tiene un descuento del {1}", monto, descuento);
        }
        else
        {
            Console.WriteLine("error el monto no puede ser negativo");
        }
        Console.ReadLine();
    }

    // ============================================================
    // EJERCICIO 04
    // Dado un tiempo en segundos, calcular los segundos restantes
    // que le correspondan para convertirse exactamente en minutos.
    // ============================================================
    static void Ejercicio04()
    {
        int tiemposegundos, minutos, segundosrestantes;
        Console.WriteLine("ingrese el tiempo en segundos");
        tiemposegundos = int.Parse(Console.ReadLine());
        if (tiemposegundos < 60 && tiemposegundos > 0)
        {
            segundosrestantes = 60 - tiemposegundos;
            Console.WriteLine("Le falta {0} segundos para convertirse en minuto", segundosrestantes);
        }
        else if (tiemposegundos >= 60)
        {
            minutos = (tiemposegundos - (tiemposegundos % 60)) / 60;
            segundosrestantes = tiemposegundos % 60;
            Console.WriteLine("equivale a {0} minutos y le faltan {1} segundos para convertirse en minuto", minutos, segundosrestantes);
        }
        else
        {
            Console.WriteLine("la cantidad de segundos debe ser un numero positivo");
        }
        Console.ReadLine();
    }

    // ============================================================
    // EJERCICIO 05
    // Dado un tiempo en minutos, calcular los dias, horas y
    // minutos que le corresponden.
    // ============================================================
    static void Ejercicio05()
    {
        int tiempo, dias, horas, minutos, x;
        Console.WriteLine("ingrese un tiempo en minutos");
        tiempo = int.Parse(Console.ReadLine());
        if (tiempo >= 0)
        {
            dias = (tiempo - (tiempo % 60)) / 1440;
            x = tiempo % 1440;
            horas = (x - (x % 60)) / 60;
            minutos = x % 60;
            Console.WriteLine("equivale a {0} dias con {1} horas y {2} minutos", dias, horas, minutos);
        }
        else
        {
            Console.WriteLine("el tiempo no puede ser negativo");
        }
        Console.ReadLine();
    }

    // ============================================================
    // EJERCICIO 06
    // Calcular mediante un algoritmo repetitivo la suma de los
    // N primeros números naturales.
    // ============================================================
    static void Ejercicio06()
    {
        int x, numero, suma;
        Console.Write("ingrese el numero N :  ");
        numero = int.Parse(Console.ReadLine());
        suma = 0;
        for (x = 1; x <= numero; x = x + 1)
        {
            suma = suma + x;
            Console.WriteLine("n{0}: {1}", x, x);
        }
        Console.WriteLine("");
        Console.WriteLine("La suma de la serie es: {0}", suma);
        Console.ReadLine();
    }

    // ============================================================
    // EJERCICIO 07
    // Modificar el ejercicio 1 para obtener la suma de los
    // salarios de todos los trabajadores.
    // ============================================================
    static void Ejercicio07()
    {
        double x, salario, horastrabajadas, tarifa, suma, numerotrabajadores;
        suma = 0;
        Console.Write("ingrese la cantidad de trabajadores: ");
        numerotrabajadores = double.Parse(Console.ReadLine());
        for (x = 1; x <= numerotrabajadores; x = x + 1)
        {
            Console.WriteLine(" trabajador {0}: ", x);
            Console.Write(" horas trabajasdas : ");
            horastrabajadas = double.Parse(Console.ReadLine());
            Console.Write(" tarifa : ");
            tarifa = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            salario = horastrabajadas * tarifa;
            suma = suma + salario;
        }
        Console.WriteLine("la suma de los salarios es : {0}", suma);
        Console.ReadLine();
    }

    // ============================================================
    // EJERCICIO 08
    // Dada las horas trabajadas de una persona la tarifa de pago.
    // Calcular su salario e imprimirla.
    // ============================================================
    static void Ejercicio08()
    {
        double horastrabajadas, tarifa, salario;
        Console.Write("ingrese horas trabajadas: ");
        horastrabajadas = double.Parse(Console.ReadLine());
        Console.Write("ingrese tarifa:  ");
        tarifa = double.Parse(Console.ReadLine());
        salario = horastrabajadas * tarifa;
        Console.WriteLine("El salario del trabajador es: " + salario);
        Console.ReadLine();
    }

    // ============================================================
    // EJERCICIO 09
    // Ingresar notas hasta que el usuario diga "no". Calcular:
    // cantidad aprobados/desaprobados, promedios y promedio final.
    // Aprobado >= 10.5
    // ============================================================
    static void Ejercicio09()
    {
        double nota, sumaAprobadas = 0, sumaDesaprobadas = 0, sumaTotal = 0;
        int cantAprobadas = 0, cantDesaprobadas = 0, total = 0;
        string respuesta;
        do
        {
            Console.Write("Introduce la nota: ");
            nota = double.Parse(Console.ReadLine());
            sumaTotal += nota;
            total++;
            if (nota >= 10.5)
            {
                sumaAprobadas += nota;
                cantAprobadas++;
            }
            else
            {
                sumaDesaprobadas += nota;
                cantDesaprobadas++;
            }
            Console.Write("¿deseas ingresar otra nota?: ");
            respuesta = Console.ReadLine();
        } while (respuesta == "si");

        Console.WriteLine("la cantidad de notas desaprobadas es: " + cantDesaprobadas);
        Console.WriteLine("la cantidad de notas aprobadas es: " + cantAprobadas);
        Console.WriteLine("el promedio de las notas aprobadas es: " + (cantAprobadas > 0 ? sumaAprobadas / cantAprobadas : 0));
        Console.WriteLine("el promedio de las notas desaprobadas es: " + (cantDesaprobadas > 0 ? sumaDesaprobadas / cantDesaprobadas : 0));
        Console.WriteLine("el promedio final es: " + Math.Round(sumaTotal / total, 1));
        Console.ReadLine();
    }

    // ============================================================
    // EJERCICIO 10
    // Dado un número determinar la suma de sus dígitos.
    // ============================================================
    static void Ejercicio10()
    {
        int numero, suma, residuo;
        suma = 0;
        Console.WriteLine("ingresar un numero");
        numero = int.Parse(Console.ReadLine());
        do
        {
            residuo = numero % 10;
            suma = suma + residuo;
            numero = (numero - (numero % 10)) / 10;
        }
        while (numero != 0);
        {
            Console.WriteLine("");
            Console.WriteLine("la suma es de los digitos es:  {0} ", suma);
        }
        Console.ReadLine();
    }

    // ============================================================
    // EJERCICIO 11
    // Emitir la factura de una compra. IVA del 15%. Si el precio
    // bruto (precio venta más IVA) es mayor de 50 se debe
    // realizar un descuento del 5%.
    // ============================================================
    static void Ejercicio11()
    {
        double precio, numeroarticulos, precioventa, descuento, preciobruto, iva, totalpagar;
        Console.Write("ingrese el precio: ");
        precio = double.Parse(Console.ReadLine());
        Console.Write("ingrese numero de articulos: ");
        numeroarticulos = double.Parse(Console.ReadLine());
        precioventa = precio * numeroarticulos;
        iva = Math.Round(precioventa * 0.15, 2);
        preciobruto = precioventa + iva;
        if (preciobruto >= 50)
        {
            descuento = Math.Round((preciobruto * 5) / 100, 2);
        }
        else
        {
            descuento = 0;
        }
        totalpagar = preciobruto - descuento;
        Console.WriteLine(" ");
        Console.WriteLine(" Datos de la factura ");
        Console.WriteLine(" ");
        Console.WriteLine(" Precio de venta : " + precioventa);
        Console.WriteLine(" Impuesto sobre el valor añadido (IVA) es: " + iva);
        Console.WriteLine(" Precio bruto es : " + preciobruto);
        Console.WriteLine(" Descuento es : " + descuento);
        Console.WriteLine(" Total a pagar: " + totalpagar);
        Console.ReadLine();
    }

    // ============================================================
    // EJERCICIO 13
    // Desarrollar un algoritmo para calcular e imprimir el
    // factorial de un número.
    // ============================================================
    static void Ejercicio13()
    {
        int numero, factorial, i;
        Console.Write("ingresar numero: ");
        numero = int.Parse(Console.ReadLine());
        factorial = 1;
        for (i = 1; i <= numero; i++)
            factorial = factorial * i; // factorial *= i
        Console.WriteLine("");
        Console.WriteLine("Factorial: ");
        Console.WriteLine(" {0}! = {1} ", numero, factorial);
        Console.ReadLine();
    }

    // ============================================================
    // EJERCICIO 14
    // Calcular la media de 100 números e imprimir su resultado.
    // ============================================================
    static void Ejercicio14()
    {
        double suma, media, x, numero;
        suma = 0;
        for (x = 1; x <= 100; x = x + 1)
        {
            Console.Write("ingrese  {0}° numero:  ", x);
            numero = double.Parse(Console.ReadLine());
            suma = suma + numero;
        }
        media = Math.Round(suma / 100, 2);
        Console.WriteLine("");
        Console.WriteLine("la media de los 100 numero ingresados es: " + media);
        Console.ReadLine();
    }

    // ============================================================
    // EJERCICIO 15
    // Calcular y visualizar la suma y el producto de los números
    // pares comprendidos entre 20 y 400 ambos inclusive.
    // ============================================================
    static void Ejercicio15()
    {
        int suma, producto, x;
        suma = 0;
        producto = 1;
        for (x = 20; x <= 30; x = x + 2)
        {
            suma = suma + x;
            producto = producto * x;
        }
        Console.WriteLine("Rango : numeros pares del 20 al 30");
        Console.WriteLine("");
        Console.WriteLine("La suma es: " + suma);
        Console.WriteLine("El producto es: " + producto);
        Console.ReadLine();
    }

    // ============================================================
    // EJERCICIO 18
    // Hacer un programa para escribir la primera vocal leída del
    // teclado (se leen caracteres uno a uno hasta encontrar vocal).
    // ============================================================
    static void Ejercicio18()
    {
        string caracter;
        int x;
        x = 1;
        do
        {
            Console.WriteLine("ingrese caracter");
            caracter = Console.ReadLine();
            if (caracter.Equals("a") || caracter.Equals("e") ||
                caracter.Equals("i") || caracter.Equals("o") || caracter.Equals("u"))
                x = 0;
        }
        while (x == 1);
        Console.WriteLine("");
        Console.WriteLine("La primera vocal ingresada fue: " + caracter);
        Console.ReadLine();
    }

    // ============================================================
    // EJERCICIO 19
    // Hacer un programa que no determine un número tiene o no
    // parte fraccionaria.
    // ============================================================
    static void Ejercicio19()
    {
        double numero, pf;
        Console.WriteLine("ingrese un numero");
        numero = double.Parse(Console.ReadLine());
        pf = Math.Truncate(numero);
        if (numero == pf)
            Console.WriteLine("no tiene parte fraccionaria");
        else
            Console.WriteLine("tiene parte fraccionaria");
        Console.ReadLine();
    }

    // ============================================================
    // EJERCICIO 21
    // Al ingresar 2 números calcular la suma, resta, multiplicación
    // y división. El proceso debe terminar cuando se hayan realizado
    // 10 procesos (usando contadores).
    // ============================================================
    static void Ejercicio21()
    {
        double num1, num2, c, suma, resta, multiplicacion, division;
        c = 0;
        do
        {
            c = c + 1;
            Console.WriteLine("PROCESO N°{0}:", c);
            Console.Write("ingrese primer numero: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("ingrese segundo numero: ");
            num2 = double.Parse(Console.ReadLine());
            suma = num1 + num2;
            resta = num1 - num2;
            multiplicacion = num1 * num2;
            division = Math.Round(num1 / num2, 2);
            Console.WriteLine("");
            Console.WriteLine("La suma es: " + suma);
            Console.WriteLine("La resta es : " + resta);
            Console.WriteLine("La multiplicacion es: " + multiplicacion);
            Console.WriteLine("La division es: " + division);
            Console.WriteLine(" ");
        }
        while (c <= 9);
        Console.WriteLine("final del proceso");
        Console.ReadLine();
    }

    // ============================================================
    // EJERCICIO 22
    // Imprimir el cubo y la raíz cuadrada de un número ingresado.
    // El proceso es repetitivo y termina cuando se ingresa 0.
    // ============================================================
    static void Ejercicio22()
    {
        double numero, c, cubo, raizcuadrada;
        c = 0;
        do
        {
            c = c + 1;
            Console.WriteLine("PROCESO N°{0}:", c);
            Console.Write("ingrese un numero:  ");
            numero = double.Parse(Console.ReadLine());
            if (numero != 0)
            {
                cubo = Math.Pow(numero, 3);
                raizcuadrada = Math.Round(Math.Pow(numero, 0.5), 2);
                Console.WriteLine("El cubo es: " + cubo);
                Console.WriteLine("La raiz cuadrada es: " + raizcuadrada);
                Console.WriteLine("");
            }
        }
        while (numero != 0);
        Console.WriteLine("");
        Console.WriteLine("FINAL DEL PROCESO");
        Console.ReadLine();
    }

    // ============================================================
    // EJERCICIO 23
    // Ingresados dos números calcular suma, diferencia, producto
    // y división. El proceso finaliza al ingresar el primer
    // número igual a cero.
    // ============================================================
    static void Ejercicio23()
    {
        double num1, num2, c, suma, resta, multiplicacion, division;
        c = 0;
        do
        {
            c = c + 1;
            Console.WriteLine("PROCESO N°{0}:", c);
            Console.Write("ingrese primer numero: ");
            num1 = double.Parse(Console.ReadLine());
            if (num1 != 0)
            {
                Console.Write("ingrese segundo numero: ");
                num2 = double.Parse(Console.ReadLine());
                suma = num1 + num2;
                resta = num1 - num2;
                multiplicacion = num1 * num2;
                division = Math.Round(num1 / num2, 2);
                Console.WriteLine("");
                Console.WriteLine("La suma es: " + suma);
                Console.WriteLine("La resta es : " + resta);
                Console.WriteLine("La multiplicacion es: " + multiplicacion);
                Console.WriteLine("La division es: " + division);
                Console.WriteLine(" ");
            }
        }
        while (num1 != 0);
        Console.WriteLine(" ");
        Console.WriteLine("FINAL DEL PROCESO");
        Console.ReadLine();
    }

    // ============================================================
    // EJERCICIO 24
    // Calcular el área de un triángulo cualquiera donde los
    // valores de los lados son ingresados por el teclado.
    // (Fórmula de Herón)
    // ============================================================
    static void Ejercicio24()
    {
        double ladoa, ladob, ladoc, sm, areatriangulo;
        Console.Write("ingrese lado A: ");
        ladoa = double.Parse(Console.ReadLine());
        Console.Write("ingrese lado B: ");
        ladob = double.Parse(Console.ReadLine());
        Console.Write("ingrese lado C: ");
        ladoc = double.Parse(Console.ReadLine());
        sm = (ladoa + ladob + ladoc) / 2;
        areatriangulo = Math.Round(Math.Pow(sm * (sm - ladoa) * sm * (sm - ladob) * sm * (sm - ladoc), 0.5), 2);
        Console.WriteLine("El area del triangulo es: " + areatriangulo);
        Console.ReadLine();
    }

    // ============================================================
    // EJERCICIO 25
    // Calcular el valor de la hipotenusa de un triángulo
    // rectángulo, ingresando sus catetos (Teorema de Pitágoras).
    // ============================================================
    static void Ejercicio25()
    {
        double catetoa, catetob, hipotenusa;
        Console.Write("Ingrese primer cateto: ");
        catetoa = double.Parse(Console.ReadLine());
        Console.Write("Ingrese segundo cateto: ");
        catetob = double.Parse(Console.ReadLine());
        hipotenusa = Math.Round(Math.Pow(Math.Pow(catetoa, 2) + Math.Pow(catetob, 2), 0.5), 2);
        Console.WriteLine("");
        Console.WriteLine("La hipotenusa es: {0}", hipotenusa);
        Console.ReadLine();
    }

    // ============================================================
    // EJERCICIO 26
    // Calcular la longitud de la circunferencia, el área del
    // círculo y el volumen de la esfera para un radio dado.
    // ============================================================
    static void Ejercicio26()
    {
        double pi, radio, area, volumen, longitud;
        pi = 3.14;
        Console.Write("Ingrese el radio de la circunferencia: ");
        radio = int.Parse(Console.ReadLine());
        longitud = 2 * pi * radio;
        area = Math.Round(pi * Math.Pow(radio, 2), 2);
        volumen = Math.Round((4.0 / 3) * pi * Math.Pow(radio, 3), 2);
        Console.WriteLine("");
        Console.WriteLine("Longitud de la circunferencia: " + longitud);
        Console.WriteLine("Area de la circunferencia: " + area);
        Console.WriteLine("Volumen de la circunferencia: " + volumen);
        Console.ReadLine();
    }

    // ============================================================
    // EJERCICIO 28
    // Calcular la suma de los n primeros números enteros desde
    // el número 8: S = 8+9+10+11+...+N
    // ============================================================
    static void Ejercicio28()
    {
        int numero, suma, x;
        suma = 0;
        Console.Write("Ingrese el numero enesimo:  ");
        numero = int.Parse(Console.ReadLine());
        if (numero < 8)
        {
            Console.WriteLine("");
            Console.WriteLine("Error el numero ingresado es menor a 8");
        }
        else
        {
            for (x = 8; x <= numero; x = x + 1)
            {
                suma = suma + x;
            }
            Console.WriteLine("");
            Console.WriteLine("La suma de la serie de rango 8 hasta {0}, con un incremento de 1 es: {1}", numero, suma);
        }
        Console.ReadLine();
    }

    // ============================================================
    // EJERCICIO 29
    // La compañía Barner posee una caja con $3.71. Diariamente
    // se registran egresos. Calcular los egresos de la compañía
    // y mostrar cuanto queda en caja.
    // (El programa termina cuando se ingresa -1)
    // ============================================================
    static void Ejercicio29()
    {
        double caja, egreso, cont, totalegresos, restocaja;
        totalegresos = 0;
        caja = 371;
        cont = 0;
        do
        {
            cont = cont + 1;
            Console.Write("Ingrese {0} egreso: ", cont);
            egreso = double.Parse(Console.ReadLine());
            totalegresos = totalegresos + egreso;
            restocaja = caja - totalegresos;
        }
        while (egreso != -1);
        {
            Console.WriteLine("");
            Console.WriteLine("El total de egresos es: {0}", totalegresos + 1);
            Console.WriteLine("Lo sobrante en caja es: {0}", restocaja - 1);
            Console.ReadLine();
        }
    }

    // ============================================================
    // EJERCICIO 30
    // Diseñar un formulario que permita ingresar dos notas y
    // determine su promedio. Mostrar un comentario si está
    // aprobado o desaprobado.
    // ============================================================
    static void Ejercicio30()
    {
        double nota1, nota2, promedio;
        Console.Write("ingrese primera nota: ");
        nota1 = double.Parse(Console.ReadLine());
        Console.Write("ingrese seunda nota: ");
        nota2 = double.Parse(Console.ReadLine());
        promedio = (nota1 + nota2) / 2;
        if (nota1 >= 0 && nota1 <= 20 && nota2 >= 0 && nota2 <= 20)
        {
            if (promedio >= 10.5 && promedio <= 20)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Promedio: " + promedio);
                Console.WriteLine("aprobado");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Promedio: " + promedio);
                Console.WriteLine("desaprobado");
            }
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("EROR... Las notas ingresadas no se encuentran en la escala vigesimal (0-20)");
        }
        Console.ReadLine();
    }

    // ============================================================
    // MAIN - Menú de ejercicios
    // ============================================================
    static void Main(string[] args)
    {
        Console.WriteLine("===== EJERCICIOS C# - Braulio Ricardo Alvarez Gonzaga =====");
        Console.WriteLine("Seleccione el ejercicio a ejecutar:");
        Console.WriteLine("01, 02, 03, 04, 05, 06, 07, 08, 09, 10");
        Console.WriteLine("11, 13, 14, 15, 18, 19, 21, 22, 23, 24, 25, 26, 28, 29, 30");
        Console.Write("Ingrese número: ");
        string opcion = Console.ReadLine();
        switch (opcion)
        {
            case "01": case "1": Ejercicio01(); break;
            case "02": case "2": Ejercicio02(); break;
            case "03": case "3": Ejercicio03(); break;
            case "04": case "4": Ejercicio04(); break;
            case "05": case "5": Ejercicio05(); break;
            case "06": case "6": Ejercicio06(); break;
            case "07": case "7": Ejercicio07(); break;
            case "08": case "8": Ejercicio08(); break;
            case "09": case "9": Ejercicio09(); break;
            case "10": Ejercicio10(); break;
            case "11": Ejercicio11(); break;
            case "13": Ejercicio13(); break;
            case "14": Ejercicio14(); break;
            case "15": Ejercicio15(); break;
            case "18": Ejercicio18(); break;
            case "19": Ejercicio19(); break;
            case "21": Ejercicio21(); break;
            case "22": Ejercicio22(); break;
            case "23": Ejercicio23(); break;
            case "24": Ejercicio24(); break;
            case "25": Ejercicio25(); break;
            case "26": Ejercicio26(); break;
            case "28": Ejercicio28(); break;
            case "29": Ejercicio29(); break;
            case "30": Ejercicio30(); break;
            default: Console.WriteLine("Ejercicio no encontrado."); break;
        }
    }
}