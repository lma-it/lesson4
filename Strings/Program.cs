//Способы создания строк:
//Прямая передача строкгово значения в переменную типа string
string str = "hello";
//Создание строки через массив символов и вызова контруктора String
char[] char_str = { 'h', 'e', 'l', 'l', 'o'};
string str2 = new String(char_str);
//Через повторение символа
string str3 = new String('a', 6);//результат будет "aaaaaa"

System.Console.WriteLine("Введите строку: ");
string input = Console.ReadLine();
string result = GetLettersFromString(input);
System.Console.WriteLine(result);

string GetLettersFromString(string msg){
    string letters = "";
    foreach(char e in msg){
        
        if(char.IsAsciiLetter(e) == true){
            letters = letters + e;
        }
    }
    return letters;
}