Console.WriteLine("***********EJERCICIO 1+++++++++++++");
int[] arr = { 1, 2, 4, 4, 2, 6, 7, 8, 8, 8 };
int cot = 0;
int final = 0;
int idxx = 0;
for (int i = 0; i < arr.Length; i++)
{
    int cot2 = 0;
    for (int j = i+1; j < arr.Length; j++)
    {
        if (arr[j] != arr[i])
        {
            break;
        }
        cot2++;
        idxx = j;
    }
    if (cot2 > cot)
    {
        final = arr[idxx];
        cot = cot2;
    }
}
Console.WriteLine("Longest: " + (cot + 1));
Console.WriteLine("Number: " + final);

Console.WriteLine("");
Console.WriteLine("***********EJERCICIO 2+++++++++++++");
int[] myArray = { 1, 2, 1, 1, 1, 1, 2, 1, 5, 1 };
string item1 = "";
string item2 = "";
string item3 = "";
string item4 = "";
string item5 = "";
bool bandera = true;
for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] < 1 || myArray[i] > 5)
    {
        bandera = false; break;
    }
    switch (myArray[i])
    {
        case 1: item1 += "*"; break;
        case 2: item2 += "*"; break;
        case 3: item3 += "*"; break;
        case 4: item4 += "*"; break;
        case 5: item5 += "*"; break;
    }
}
if (bandera)
{
    Console.WriteLine("1: " + item1);
    Console.WriteLine("2: " + item2);
    Console.WriteLine("3: " + item3);
    Console.WriteLine("4: " + item4);
    Console.WriteLine("5: " + item5);
}
Console.WriteLine("");
Console.WriteLine("***********EJERCICIO 3+++++++++++++");

int[] myArray2 = { 1, 2, 9, 2, 5, 3, 5, 1, 5 };
int dimension = 3;
int contador = 0;
int menor = myArray2.Max();
int[,] matriz = new int[dimension, dimension];
int[] busqueda = new int[dimension];
for (int i = 0; i < dimension; i++)
{
    for (int j = 0; j < dimension; j++)
    {
        matriz[i, j] = myArray2[contador];
        contador++;
        Console.Write(matriz[i, j]);
    }
    Console.WriteLine("");
}
int control = 0;
for (int i = 0; i < dimension; i++)
{
    for (int j = 0; j < dimension; j++)
    {
        if (matriz[j, i] < menor)
        {
            if (control == j)
            {
                menor = matriz[j, i];
                busqueda[i] = menor;
            }
            else if (control + 1 == j)
            {
                menor = matriz[j, i];
                busqueda[i] = menor;
            }
            else if (control - 1 == j)
            {
                menor = matriz[j, i];
                busqueda[i] = menor;
            }


        }
    }
    menor = myArray2.Max();
}
Console.WriteLine("");
for (int i = 0; i < busqueda.Length; i++)
{
    Console.Write(busqueda[i]);
}
