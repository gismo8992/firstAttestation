/*
Task1.
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

Console.WriteLine("Enter your arrays: ");
string [] array = Console.ReadLine().Split(", "); // Считываем ввод из консоли и сохраняем в массив.
Console.WriteLine("Printing arrays to console: ");
Console.WriteLine(string.Join(", ", array)); // Печатаем массив в консоль для проверки корректности сохранения введенных данных из консоли в массив.

int count = 0; // Переменная для подсчета количества строк в массиве, удовлетворяющих условию длинны не более 3 символов.
for(int i = 0; i < array.Length; i++) { 
    if(array[i].Length < 4) {
        count++;
    }
}
string[] newArray = new string[count]; // Создаем новый массив размером равным количеству найденных строк требуемой длины.
int indexOfNewArray = 0; // Переменная для прохождения по новому массиву.
for(int j = 0; j < array.Length; j++) {
    if(array[j].Length < 4) {
        newArray[indexOfNewArray] = array[j]; // Кладем в новый массив строки, которые удовлетворяют условию длины не более 3 символов.
        indexOfNewArray++;
    }
}
Console.Write("Printing new array with strings contain no more 3 characters: ");
Console.WriteLine(string.Join(", ", newArray)); // Выводим результат в консоль для проверки.