


Random random = new Random();
int[,] CreateMatrix(int rowCount, int columsCount){

    int[,] matrix = new int[rowCount, columsCount];

    for(int i = 0; i < matrix.GetLength(0); i++){

        for(int j = 0; j < matrix.GetLength(1); j++){

            matrix[i,j] = random.Next(1, 1000);

        }
    }

    return matrix;
}

int[,] matrix = CreateMatrix(3, 4);
ShowMatrix(matrix);


foreach(int elem in matrix){

    if(isInteresting(elem) == true){
        System.Console.WriteLine(elem);
    }
}

bool isInteresting(int value){

   int sumOfDigits = GetSumOFDigits(value);
   
   if(sumOfDigits % 2 == 0){
    return true;
   }else{
    return false;
   }
}

int GetSumOFDigits(int value){
    int sum = 0;

    while(value > 0){
        sum = sum + value % 10;
        value = value / 10;
    }
    return sum;
}

void ShowMatrix(int[,] matrix){

    for(int i = 0; i < matrix.GetLength(0); i++){

        for(int j = 0; j < matrix.GetLength(1); j++){

            System.Console.Write($"{matrix[i,j]} ");
            
        }
        System.Console.WriteLine(" ");
    }
}