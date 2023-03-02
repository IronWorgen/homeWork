//воод данных
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int delitel =1;
int lenNum = 0;
//вычисление длины числа
while ( num/delitel != 0 ){
    lenNum ++;
    delitel *=10;
}

if (lenNum == 1 ){
    Console.WriteLine("да");
    return;
}
// помещаем каждую цифру в массив равный длине чила num  
int[] nums = new int [lenNum];
int temp =  num;

for ( int i =0 ; i<lenNum; i ++ )
{
    nums[i] = temp / Convert.ToInt32(Math.Pow(10, lenNum-1-i));
    temp = temp % Convert.ToInt32(Math.Pow(10, lenNum-1-i));
}

//поэлементно сравниваем значения в массиве первый с последним, второй с предпоследним...
bool itsPalindrome = true;

for ( int i =0 ; i<nums.Length/2; i++)
{
    if (nums[i] != nums[nums.Length-1-i]) {itsPalindrome = false;}
}

if (itsPalindrome) Console.WriteLine( "да");
else Console.WriteLine("нет");



