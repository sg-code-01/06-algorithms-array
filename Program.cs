#region Task1

int[] array = { 5, 4, 6 };

for (int i = 0; i < array.Length; i++) {
    int factor = 1;
    for (int j = 2; j <= array[i]; j++) {
        factor *= j;
    }

    array[i] = factor;
}

foreach (var element in array) {
    Console.Write($"{element} ");
}

Console.WriteLine();
#endregion
