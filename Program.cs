// {{{ Task 1
// #region Task1
// int[] array = { 5, 4, 6 };
//
// for (int i = 0; i < array.Length; i++) {
//     int factor = 1;
//     for (int j = 2; j <= array[i]; j++) {
//         factor *= j;
//     }
//
//     array[i] = factor;
// }
//
// foreach (var element in array) {
//     Console.Write($"{element} ");
// }
//
// Console.WriteLine();
// #endregion
// }}}
// {{{ Task 2
// #region Task 2
//
// int[] array = { 7, 12, 5, 8 };
// int[] array_no_min = new int[array.Length - 1];
// int min = array[0];
//
// for (int i = 1; i < array.Length; i++) {
//     if (array[i] < min) {
//         min = array[i];
//     }
// }
//
// int new_index = 0; // index of array without minimum element
// for (int i = 0; i < array.Length; i++) {
//     if (array[i] == min) {
//         continue;
//     }
//     array_no_min[new_index] = array[i];
//
//     new_index++;
// }
//
// foreach (var item in array_no_min) {
//     Console.Write($"{item}, ");
// }
//
// #endregion
// }}}
// Task 3 {{{
#region Task 3

string text = "kərtənkələ";
char letter = ' ';

for (int i = 0; i < text.Length; i++) {
    int counter = 0;

    for (int j = 0; j < text.Length; j++) {
        if (text[i] == text[j]) {
            counter++;
        }
    }

    if (counter == 1) {
        letter = text[i];
        break;
    }
}

Console.WriteLine(letter);

#endregion
// }}}
