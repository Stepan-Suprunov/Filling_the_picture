// Закрашивание рисунка.

int [,] pic = new int[,] // Задать массив

void PrintImage(int[,] mimage)
{
    for (int i = 0; i < mimage.GetLength(0); i++)
    {
       for (int j = 0; j < mimage.GetLength(1); j++)
        {
            if (imge[i,j] == 0) Console.Write($" ");
            else Console.Write($"+");
        }
    Console.WriteLine();
    }
}

void FillImage(int row, int col)
{
    if (pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row-1, col);
        FillImage(row, col-1);
        FillImage(row+1, col);
        FillImage(row, col+1);
    }
}

PrintImage(pic);
FillImage(13, 13);
PrintImage(pic);