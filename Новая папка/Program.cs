// // Task 8
// System.Console.Write("Input Text: ");
// string a=Console.ReadLine();
// System.Console.Write("Input number: ");
// int b=Convert.ToInt32(Console.ReadLine());

// void Text(string a, int b)
// {
//     if(b<=0) return;
//     System.Console.Write(a);
//     Text(a, b-1);
// }
// Text(a, b);
// // Task 7
// System.Console.Write("Input number for suming: ");
// int a =Convert.ToInt32(Console.ReadLine());
// int sum=0;
// int SumDigit(int a)
// {
//     if(a<=0) return sum;
//     sum+=a%10;
//     return SumDigit(a/10);

// }

// System.Console.WriteLine("Sum of dugits: "+SumDigit(a));

// // Task 6
// System.Console.Write("x = ");
// int x =Convert.ToInt32(Console.ReadLine());
// System.Console.Write("y = ");
// int y =Convert.ToInt32(Console.ReadLine());
// void Swap(int _x, int _y)
// {
//     x=_y;
//     y=_x;
// }
// Swap(x,y);
// System.Console.WriteLine("x = "+x);
// System.Console.WriteLine("y = "+y);

// // Task 5
// System.Console.Write("Razmer Massiva: ");
// int a=Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Kosichesva dlya perechisleniy: ");
// int n=Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[a];

//     for (int i = 0; i <= a-1; i++)
// {
//     arr[i]=Convert.ToInt32(Console.ReadLine());
// }
// void IncrementArrayElements(int[] arr , int _n)
// {
//     n =_n;
//     for (int i = 0; i <= a-1; i++)
//     {
        
//         System.Console.Write((arr[i]+n)+" ");
//     }
// }
// IncrementArrayElements(arr, n);

// // Task 4
// System.Console.Write("Adad baroi hisobkuni: ");
// int sum=0;
// int a=Convert.ToInt32(Console.ReadLine());
// int SumOfDigits(int a)
// {
//     if(a==0) return sum;
//     sum+=a%10;
//     return SumOfDigits(a/10);
// }
// System.Console.WriteLine(SumOfDigits(a));

// // Task 3
// string a =Console.ReadLine();
// char[] chars = a.ToCharArray();
// string rev=new string(chars);
// if(a==rev) System.Console.WriteLine("Palindrome");
// else System.Console.WriteLine("No Palindrome");

// // Task 2
// int a =Convert.ToInt32(Console.ReadLine());
// int even=0;
// int EvenCount(int a)
// {
//     if(a==0) return even;
//     if(a%10%2==0) even++;
//     return EvenCount(a/10);
// }
// int Odd=0;
// int OddCount(int a)
// {
//     if(a==0) return Odd;
//     if(a%10%2!=0) Odd++;
//     return EvenCount(a/10);
// }
// int digit=0;
// int DigitCount(int a)
// {
//     if(a==0) return digit;
//     if(a%10>-1) digit++;
//     return DigitCount(a/10);
// }
// int sum=0;
// int SumDigit(int a)
// {
//     if(a<=0) return sum;
//     sum+=a%10;
//    return SumDigit(a/10);
// }
// System.Console.WriteLine("Even : "+EvenCount(a));
// System.Console.WriteLine("Odd : "+OddCount(a));
// System.Console.WriteLine("Digit : "+DigitCount(a));
// System.Console.WriteLine("Sum : "+SumDigit(a));

// // Task 1
// int a=Convert.ToInt32(Console.ReadLine());
// int [] ints =new int[a];
// for (int i = 0; i <= a-1; i++)
// {
//     ints[i]=Convert.ToInt32(Console.ReadLine());
// }
// System.Console.Write("Index: ");
// int k=Convert.ToInt32(Console.ReadLine());
// for (int i = 0; i <= a-1; i++)
// {
//     if(i!=k) System.Console.Write(ints[i]+" ");
// }