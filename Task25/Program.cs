// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int exponentiation(int A, int B) {
    if (A == 0 && B == 0) {
        return 0;
    } else if (B == 0) {
        return 1;
    } else if (B == 1) {
        return A;
    } else {
        int result = A;
        for (int i = 1; i < B; i++) {
            result *= A; 
        }
        return result;
    }
}

Console.Write("Введите основание степени: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите показатель степени(натуральное число): ");
int B = Convert.ToInt32(Console.ReadLine());

if (B < 0) {
    Console.WriteLine("Некорректные данные");
    return;
} else {
    int exp = exponentiation(A, B);
    Console.WriteLine($"Степень числа {A} с показателем {B} равна {exp}");
}


