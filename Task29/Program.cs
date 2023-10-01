// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] createArray(int min, int max, int len) {
    int[] array = new int[len];
    var rnd = new Random();
    for(int i = 0; i < array.Length; i++) {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;    
}

void printArray(int[] arr) {
    for(int i = 0; i < arr.Length; i++) {
        if (i == arr.Length - 1) Console.Write(arr[i]);
        else Console.Write($"{arr[i]}, ");
    }
    Console.Write(" -> [");
    for(int i = 0; i < arr.Length; i++) {
        if (i == arr.Length - 1) Console.Write($"{arr[i]}]");
        else Console.Write($"{arr[i]}, ");
    }
}


int[] rndArray = createArray(0, 100, 10);
printArray(rndArray);