//Двуменрыне массивы.
//Первый индекс (3) - строки, второй индекс (5) - столбцы
Random random = new Random();


int[,] CreateMatrix(int rowCount, int columsCount){

    int[,] matrix = new int[rowCount, columsCount];

    for(int i = 0; i < matrix.GetLength(0); i++){

        for(int j = 0; j < matrix.GetLength(1); j++){

            matrix[i,j] = random.Next(1, 11);

        }
    }

    return matrix;
}

void ShowMatrix(int[,] matrix){

    for(int i = 0; i < matrix.GetLength(0); i++){

        for(int j = 0; j < matrix.GetLength(1); j++){

            System.Console.Write($"{matrix[i,j]} ");
            
        }
        System.Console.WriteLine(" ");
    }
}

int[,] matrix = CreateMatrix(4, 5);
ShowMatrix(matrix);