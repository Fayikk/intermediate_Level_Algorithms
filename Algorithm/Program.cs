using System;
using System.Collections;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        //iki sayının toplamını veren
        private static int Sum(int x, int y)
        {
            return x + y;
        }
        //dizideki en büyük sayıyı bulan
        private static int Max(int[] arr)
        {
            int maxNumber = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (maxNumber < arr[i])
                {
                    maxNumber = arr[i];
                }
                else if (maxNumber == arr[i])
                {
                    maxNumber = arr[i];
                }
                else
                {
                    maxNumber = maxNumber;
                }
            }
            return maxNumber;
        }

        //Sıralı verilen iki diziyi sıralı olarak birleştirme

        private static void Birlestirme(int[] arr1, int[] arr2)
        {
            int[] arr3 = new int[(arr1.Length + arr2.Length)];
            int pivot = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                arr3[i] = arr1[i];
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                arr3[arr1.Length + i] = arr2[i];
            }

            //1-3-5-7-9-11-2-4-6-8-10-12
            //arr3[i]
            for (int i = 0; i < arr3.Length - 1; i++)
            {

                for (int j = i + 1; j < arr3.Length - 1; j++)
                {
                    if (arr3[i] > arr3[j])
                    {
                        pivot = arr3[i];
                        arr3[i] = arr3[j];
                        arr3[j] = pivot;
                    }

                }
            }
            for (int i = 0; i <= arr3.Length - 1; i++)
            {
                Console.WriteLine(arr3[i]);
            }
        }



        //Faktoriyel hesaplama
        private static int Factorial(int a)
        {
            int pivot = 1;
            for (int i = 1; i <= a; i++)
            {
                pivot = pivot * i;
            }
            return pivot;
        }
        


        //dizi içindeki tek sayıların toplamaını
        private static int SumOdd(int[] arr)
        {
            int pivot = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    pivot = pivot + arr[i];
                }
            }
            return pivot;
        }

        //Bir diziyi tersine çeviren algoritma
        private static void Reverse(int[] arr)
        {
            int pivot = 0;
            //   0           0<6              
            for (int i = 0; i < arr.Length / 2; i++)
            {      //1-2
                pivot = arr[i];

                // 7-6             7
                arr[i] = arr[arr.Length - i - 1];

                // 1-2                 
                arr[arr.Length - i - 1] = pivot;


            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        //Bir dizi içerisindeki bir elemanın kaç kez tekrarlandığını bulan algorita
        private static void Repeat(int[] arr)
        {
            int counter = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                counter = 0;
                for (int j = 0; j < arr.Length; j++)
                {

                    for (int k = j; k < 0; k--)
                    {
                        if (arr[j] == arr[k])
                        {
                            return;
                        }
                    }

                    if (arr[i] == arr[j])
                    {
                        counter++;
                    }


                }
                Console.WriteLine(arr[i] + " sayısı " + counter + " defa tekrarladı ");
                //counter = 0;
            }

        }
        //dizideki en küçük sayıyı bulan algoritma?
        private static int MinNumber(int[] arr)
        {
            int min = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {

                if (arr[i] > min)
                {
                    min = arr[i];
                }
            };

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;

        }
        //İki sayının Obebini bulan program
        private static int Obeb(int a, int b)
        {
            int min = 0;
            int max = 0;
            int pivot = 0;
            int c = 0;
            if (b < a)
            {
                min = b;
                max = a;
            }
            else if (a < b)
            {
                max = b;
                min = a;
            }
            else
            {
                max = a;
                min = a;
            }
            int[] arr = new int[max];

            for (int i = min; i > 1; i--)
            {
                if (min % i == 0 && max % i == 0)
                {
                    arr[i] = i;
                }

            }
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (c < arr[i])
                {
                    c = arr[i];
                }
                else if (c == arr[i])
                {
                    c = arr[i];
                }
                else
                {
                    c = c;
                }
            }
            return c;

        }

        //bir dizideki elemanları birbirleriyle karşılaştırıp en büyük artışın bulunmasını sağlayan algoritma
        private static int Jumper(int[] arr)
        {
            int min = 0;
            int size = 1;
            int temp = 1;
            int forArr3 = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                size = i + size;
            }
            int[] arr2 = new int[size];
            int[] arr3 = new int[size];
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    temp = arr[j] - arr[i];
                    if (temp<0)
                    {
                        temp = temp * -1;
                    }

                    arr2[j] = temp;
                    if (min < arr2[j])
                    {
                        min = arr2[j];
                    }
                }
                arr3[i] = min;
            }

            for (int i = 0; i < arr3.Length; i++)
            {
                if (forArr3 < arr3[i])
                {
                    forArr3 = arr3[i];
                }
            }
            return forArr3;
        }

        //Verilen bir dizideki elemanların arasındaki farkın en büyük olduğu alt diziyi bulan algoritma?
        private static void Jumper2(int[] arr)
        {
            int min = 0;
            int pivot = 0;
            int size = 1;
            int temp = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                size = i + size;
            }
            int[] arr2 = new int[size];
            int[] arr3 = new int[size];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                min = 0;
                for (int j = i; j < arr.Length; j++)
                {
                  
                    temp = arr[j] - arr[i];
                    if (temp < 0)
                    {
                        temp = temp * -1;
                    }

                    arr2[j] = temp;
                    if (min < arr2[j])
                    {
                        min = arr2[j];
                    }
                }
                arr3[i] = min;
            }

            for (int i = 0; i < arr3.Length; i++)
            {
                if (arr3[i]!=0)
                {
                    Console.WriteLine(arr3[i]);

                }
            }

        }
        //Dizide toplamları en büyük olan 2 sayı
        private static void DoubleMaxSum(int[] arr)
        {
            int counter = 0;
            int counter2 = 0;
            int pivot = 0;
            int maxNumber = 0;
            int[] arr2 = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    counter = arr[i] + arr[j];
                    if (pivot < counter)
                    {
                        pivot = counter;
                    }

                }
                arr2[i] = pivot;
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                if (counter2 < arr2[i])
                {
                    counter2 = arr2[i];
                }
            }
            maxNumber = counter2;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (maxNumber == arr[i] + arr[j])
                    {
                        Console.WriteLine("Dizide toplamları en büyük olan sayılar ->" + arr[i] + "--" + arr[j] +" Toplamları ise -->" + maxNumber);
                    }
                }
            }
            
        
        }
        //Verilen tam sayı dizisini sıralayın ve her elemanın kendinden önceki eleman ile toplamını bulan algoritma.

        private static void Mixed(int[] arr)
        {
            int counter = 0;
            int sum = 0;
            int[] arr2 = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0 ; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        sum = arr[i];
                        arr[i]= arr[j];
                        arr[j]=sum;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("------------------");

            for (int i = 1; i < arr.Length; i++)
            {
                if (i!=arr.Length)
                {
                    sum = arr[i] + arr[i -1];
                }
                Console.WriteLine(sum);
            }

        }


        static void Main(string[] args)
        {

            //10+9+8+7+6+5+4+3+2+1

            int[] arr = { 38,6,111,88,24,62,-1,15,-8,32};


            Mixed(arr);

            ////Reverse(arr);
            ////Repeat(arr);

            ////Console.WriteLine(MinNumber(arr));  
            //int a = 100;
            //int b = 250;
            //Console.WriteLine(Obeb(a, b));
            //Console.WriteLine(Jumper(arr));
            //Jumper2(arr);
           
        }
    }
}