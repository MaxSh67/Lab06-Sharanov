// Задание 1.1.
// for (int i = 10; i >= 1; i--) {
//     Console.WriteLine(i);
// }

// Задание 1.2.
// for (int i = 2; i <= 50; i+=2) {
//     Console.WriteLine(i);
// }

// int n = 1;
// while (n <= 5) {
//     Console.WriteLine(n);
//     n++;
// }

// int answer;
// do {
//     Console.Write("Введите число больше 0: ");
//     answer = Convert.ToInt32(Console.ReadLine());
// }
// while (answer <= 0);

// for (int i = 1; i <= 10; i++) {
//     if (i == 3) continue;
//     if (i == 7) break;
//     Console.WriteLine(i);
// }

// int sum = 0;
// for (int i = 1; i <= 10; i++) {
//     sum += i;
// }
// Console.WriteLine($"Сумма: {sum}");

// int count = 0;
// for (int i = 1; i <= 20; i++) {
//     if (i % 5 == 0) {
//         count++;       
//     }
// }
// Console.WriteLine($"Чисел, кратных 5: {count}");

// Задание 2.
// int sum = 0;
// int count = 0;
// for (int i = 1; i <= 100; i++) {
//     if (i % 3 == 0) {
//         sum += i;
//     }
//     if (i % 7 == 0) {
//         count++;
//     }
// }
// Console.WriteLine($"Сумма чисел, кратных 3: {sum}");
// Console.WriteLine($"Количество чисел, кратных 7: {count}");

// Задание 3.
// int number = Convert.ToInt32(Console.ReadLine());
// int total = 0;
// int total2 = 0;
// while (number != 0) {
//     if (number > 0) {
//         total++;
//     } 
//     else if (number < 0) {
//         total2++;
//     }
//     number = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine($"Положительных: {total}");
// Console.WriteLine($"Отрицательных: {total2}");

// string password;
// do
// {
//     Console.Write("Введите пароль: ");
//     password = Console.ReadLine();
// }
// while (password != "qwerty");
// Console.WriteLine("Доступ разрешен");

// Задание 4. 
// int i;
// for (i = 1; i <= 3; i++) {
//     string password = Console.ReadLine();
//     if (password == "qwerty") {
//         Console.WriteLine("Доступ разрешен");
//         break;
//     }
// }
// if (i == 4) {
//     Console.WriteLine("Доступ заблокирован");
// }

// Задание 5.
// int n = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= 10; i++) {
//     Console.WriteLine($"{n} x {i} = {n * i}");
// }

// Задание 6.
// for (int i = 1; i <= 30; i++) {
//     if (i % 3 == 0) continue;
//     if (i % 10 == 0 && i > 20) break;
//     Console.WriteLine(i);
// }

// Итоговая задача. «Угадайчисло»
// int secret = 42;
// int i;
// Console.WriteLine("Угадай число:");
// for (i = 1; i <= 5; i++) {
//     int n = Convert.ToInt32(Console.ReadLine());
//     if (n == secret) {
//         Console.WriteLine($"Победа! Попыток: {i}");
//         break;
//     }
//     else if (n < secret) {
//         Console.WriteLine("Больше");
//     }
//     else {
//         Console.WriteLine("Меньше");
//     }
// }
// if (i == 6) {
//     Console.WriteLine($"Вы проиграли, число было {secret}");
// }

// Дополнительное задание ★★★
// int n = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// int count = 0;
// while (n > 0) {
//     sum += n % 10;
//     count++;
//     n /= 10;
// }
// Console.WriteLine($"Сумма цифр: {sum}");
// Console.WriteLine($"Количество цифр: {count}");

