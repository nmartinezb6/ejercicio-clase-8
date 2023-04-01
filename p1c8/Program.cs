
void matriz()
{
    string[] nombre = new string[]
    {
        "anderson", "brandon", "yeimi", "fatima","vivian"
    };

    foreach (string n in nombre)
    {
        Console.WriteLine("nombre=" + n);

    }
    int[] notas = new int[]
    {
        51, 80, 96,76,61
    };

    int promedio = 0;
    foreach (int n in notas)
    {
        promedio = promedio + n; ;


    }
    promedio = promedio / notas.Length;
    Console.WriteLine("el promedio es=" + promedio);

    int notaMaxima = notas[0];
    int indiceMaximo = 0;

    for (int i = 1; i < notas.Length; i++)
    {
        if (notas[i] > notaMaxima)
        {
            notaMaxima = notas[i];
            indiceMaximo = i;
        }
    }

    string nombreNotaMaxima = nombre[indiceMaximo];
    Console.WriteLine("La persona con la nota más alta es " + nombreNotaMaxima + " con una nota de " + notaMaxima);

}

matriz();
