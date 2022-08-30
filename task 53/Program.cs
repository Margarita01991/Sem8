
/* Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива. */
Console.Clear();
// МЕТОД:
const int ROWS = 5;
const int COLUMNS = 5; 
//   метод |инициировали: строки    столбцы    начальный элемент     конечный элемент
int[,] FillMatrixRandom(int rows, int columns, int leftRange = 0, int rightRange = 10)
{
    int[,] matrix = new int[rows, columns]; // создали массив
    Random rand = new Random();             // создали объект
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.Next(leftRange, rightRange);
        }
    }
    return matrix;
}
void PrintMatrix(int[,]matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
    Console.WriteLine();
    }
}
// создаем массив по шаблону
int [,] matrix = FillMatrixRandom(ROWS, COLUMNS);    // заполнился массив 
PrintMatrix(matrix);                                 // метод передали на matrix, выводим массив
// переходим к самой задаче
Console.WriteLine();
for (int i = 0; i < matrix.GetLength(1); i++)
{
    int temp = matrix[0,i];                          // вводим временную переменную int temp равнуб первому элементу строки
    matrix[0,i] = matrix[matrix.GetLength(0) -1, i]; // подставляем вместо 1го эл. в строке последний эл. в строке
    matrix[matrix.GetLength(0) -1, i] = temp;        // подставляем последний эл. к первому (записываем в temp)
}
PrintMatrix(matrix); 
