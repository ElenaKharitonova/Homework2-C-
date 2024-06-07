//Напишите программу, которая принимает на вход число и проверяет, 
//кратно ли оно одновременно 7 и 23.

// bool Result (int x)
// {
//     if (x % 7 == 0 && x % 23 == 0)
//     {
//         return true;
//     }
//     return false;
// }

// Console.WriteLine("Input number:   ");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(Result(x));

//Задача 2
// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, 
// в которой находится эта точка.

// bool NotZero(int num)
// {
//     if (num == 0)
//     {
//         return false;
//     }
//     return true;
// }

// void Quarters(int x, int y)
// {
//     if(NotZero(x) && NotZero(y))
//     {
//         if (x > 0 && y > 0)
//         {
//            System.Console.WriteLine("The point" + (x,y) + " belongs to the first quarter"); 
//         }
//         if (x < 0 && y > 0)
//         {
//            System.Console.WriteLine("The point" + (x,y) + " belongs to the second quarter"); 
//         }  
//         if (x < 0 && y < 0)
//         {
//            System.Console.WriteLine("The point" + (x,y) + " belongs to the third quarter"); 
//         }         
//         if (x > 0 && y < 0)
//         {
//             System.Console.WriteLine("The point" + (x,y) + " belongs to the fourth quarter");
//         }
//     }
//     else
//     {
//         System.Console.WriteLine("The point" + (x,y) + "  is located on the coordinate axis"); 
//     }
// }

// Console.WriteLine("Input x:   ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input y:   ");
// int y = Convert.ToInt32(Console.ReadLine());
// Quarters(x,y);

// Задача 3
// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
// и показывает наибольшую цифру числа

// bool IsTwoDigit(int num)
// {
//     if (num >= 10 && num <= 99)
//     {
//         return true;
//     }
//     return false;
// }

// void LargestDigit(int num)  
// {
//     if(IsTwoDigit(num))
//     {
//         int ed = num % 10;
//         int dec = num /10;
//         if (ed >= dec)
//         {
//             System.Console.WriteLine("The largest digit is " + ed);   
//         }
//         if (ed < dec)
//         {
//             System.Console.WriteLine("The largest digit is " + dec);   
//         }
//     }
//     else
//     {
//         System.Console.WriteLine("You input not two-digit number"); 
//     }
// }

// System.Console.WriteLine("Input number: " );
// int x = Convert.ToInt32(Console.ReadLine());
// LargestDigit(x);

// Задача 4
// Напишите программу, которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую. 
// Цифры выводим с конца числа, так как не знаем длину числа.

bool NaturalDigit(int num)
{
    if (num > 0)
    {
        return true;
    }
    return false;
}

void DigitsOfNumber(int num)  
{
    if(NaturalDigit(num))
    {
        int firstDigit = num % 10;
        num /= 10;
        System.Console.Write(firstDigit);
        while (num > 0)
        {
            int result = num % 10;
            num /= 10;
            System.Console.Write("," + result);
        }  
        
    }  
    else
    {
        System.Console.WriteLine("A non-natural number has been entered"); 
    }
}

System.Console.WriteLine("Input number: " );
int x = Convert.ToInt32(Console.ReadLine());
DigitsOfNumber(x);