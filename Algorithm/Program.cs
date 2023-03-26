using KellermanSoftware.CompareNetObjects;
using NUnit.Framework;
using System;
using System.Collections;
using System.ComponentModel;

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
            for (int i = 0; i < arr.Length - 1; i++)
            {
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
                if (arr3[i] != 0)
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
                for (int j = i + 1; j < arr.Length; j++)
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
                        Console.WriteLine("Dizide toplamları en büyük olan sayılar ->" + arr[i] + "--" + arr[j] + " Toplamları ise -->" + maxNumber);
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
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        sum = arr[i];
                        arr[i] = arr[j];
                        arr[j] = sum;
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
                if (i != arr.Length)
                {
                    sum = arr[i] + arr[i - 1];
                }
                Console.WriteLine(sum);
            }

        }
        //Verilen bir dizinin ortalamasını hesaplama
        private static int SumArr(int[] arr)
        {
            int count = 0;
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                count = count + arr[i];
                counter = counter + 1;
            }

            return count / counter;
        }
        //Verilen bir dizinin medyanını hesaplama
        //Medyan dizi uzunluğu eğer tek sayı ise ortadaki sayı eğer çift ise ortdaki iki sayının ortalamısını alarak bulabilmekteyiz.
        private static decimal Median(int[] arr)
        {
            int[] arr1 = new int[arr.Length];
            int counter = 0;
            int pivot = 0;
            int temp = 0;
            // 38,6,111,88,24,62,-1,15,-8
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
                arr1[i] = arr[i];
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }

            if (arr.Length % 2 != 0)
            {
                var result = Math.Ceiling((decimal)arr.Length / 2);
                return arr1[(int)result - 1];
            }
            else if (arr.Length % 2 == 0)
            {
                var result = (arr.Length / 2);
                var result1 = (arr.Length / 2) + 1;
                var average = (decimal)(arr1[result] + arr1[result1]) / 2;
                return average;

            }
            return 0;
        }

        //Verilen dizideki elemanların toplamını ve çarpımını hesaplama
        private static void SumOdd2(int[] arr)
        {
            int count = 0;
            int multi = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                count = count + arr[i];
                multi = multi * arr[i];
            }
            Console.WriteLine("dizideki elemanların toplamı: " + count + "elemanların çarpımı: " + multi);
        }


        //En çok tekrar eden elemanı bulma
        private static int Again(int[] arr)
        {
            int number = 0;
            int count = 0;
            //int count2 = 0;
            int count1 = 0;
            int pivot = 0;
            int pivot2 = 0;
            //int order = 0;
            //int forArr3 = 0;
            int pivot3 = 0;
            //int count1 = 0;
            int[] arr2 = new int[arr.Length];
            int[] arr3 = new int[arr.Length];
            int[] arr4 = new int[arr.Length];
            int[] arr5 = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                count = 0;
                for (int j = 0; j < arr2.Length; j++)
                {
                    pivot = arr[i];
                    if (pivot == arr2[j])
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    arr2[i] = arr[i];
                }
            }

            for (int i = 0; i < arr2.Length; i++)
            {

                Console.WriteLine(arr2[i]);
            }
            Console.WriteLine("*******************************");

            for (int i = 0; i < arr.Length; i++)
            {

                count1 = 0;
                if (arr[i] != 0)
                {

                    pivot2 = arr[i];
                    for (int j = 0; j < arr.Length; j++)
                    {
                        if (arr[j] == pivot2)
                        {
                            count1++;
                        }
                    }
                }
                arr3[i] = count1;
            }


            for (int i = 0; i < arr2.Length; i++)
            {
                if (arr2[i] != 0)
                {
                    Console.WriteLine("Dizideki elemanlar ve adetleri sırası ile: " + arr2[i] + "den " + arr3[i] + "adet");
                    arr4[i] = arr3[i];
                }
                arr5[i] = arr3[i];
            }

            for (int i = 0; i < arr4.Length; i++)
            {
                number = arr4[i];
                for (int j = 0; j < arr4.Length; j++)
                {
                    if (number > arr4[j])
                    {
                        pivot3 = number;
                        number = arr4[j];
                        arr4[j] = pivot3;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr5[i] == arr4[arr4.Length - 1])
                {
                    Console.WriteLine("En sık tekrar eden eleman adedi:" + arr4[arr4.Length - 1]);
                    return arr5[i];
                    //return arr2[i];
                }
            }
            return 0;
        }

        //Verilen metindeki ekelime sayısını bulma 
        private static int Words(string word)
        {
            string[] kelimeler = word.Split(" ");

            return kelimeler.Length;
        }

        //Verilen bir metindeki en uzun kelimeyi bulan algoritma
        private static string Words2(string word)
        {
            int count = 0;
            string[] kelimeler = word.Split(" ");
            string enUzunKelime = kelimeler[0];
            int deneme = 1;
            foreach (var item in kelimeler)
            {

                count = 0;
                for (int i = 0; i < item.Length; i++)
                {
                    count++;
                }
                if (count > enUzunKelime.Length)
                {
                    enUzunKelime = item;
                }

            }
            return enUzunKelime;

        }

        //Dize!yi tersine çevirme
        private static void Reverse3(int[] arr)
        {
            int[] arr2 = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr2[arr.Length - 1 - i] = arr[i];
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
        }

        //Palindrom dizesi(Verilen bir string dizi yada kelime grubu içerisinde palindrom olanları bulma)
        //MADAM
        private static string Palindrom3(string Words)
        {
            string[] kelimeler = Words.Split(" ");
            int count = 0;
            foreach (var item in kelimeler)
            {
                count = 0;
                for (int i = 0; i < item.Length; i++)
                {
                    // 0 1                  3  4
                    if (item[i] == item[item.Length - 1 - i])
                    {
                        count++;

                        continue;
                    }

                }
                if (count == item.Length)
                {
                    return "is palindrome";

                }
            }
            return "is not palindrome";
        }

        //Verilen dizede anagram sözcük olup olmadığını bulan;(anagram harflerin yerleri değiştirilince anlamlı sözcük oluşturan)
        private static string Anagram(string kelime)
        {
            string[] kelimeler = kelime.Split(" ");
            char[] arr;
            char[] arr1;
            int count = 0;
            string deneme = "";
            string deneme1 = "";
            for (int i = 0; i < kelimeler.Length; i++)
            {
                for (int j = 0; j < kelimeler.Length; j++)
                {
                    if (kelimeler[i].Length == kelimeler[j].Length && kelimeler[i] != kelimeler[j])
                    {

                        arr = kelimeler[i].ToCharArray();
                        arr1 = kelimeler[j].ToCharArray();

                        for (int a = 0; a < arr.Length; a++)
                        {
                            for (int b = 0; b < arr.Length; b++)
                            {
                                if (arr[a] == arr[b])
                                {
                                    count++;
                                }
                            }
                            if (count == arr.Length)
                            {
                                return $"this word is anagram{kelimeler[i]}";
                            }
                        }

                    }
                }

            }

            return "this example has not anagram;";
        }

        //Verilen dizide en küçük ve en büyük elemanın yerini değiştirme
        private static void revolution(int[] arr)
        {
            int max = 0;
            int min = 0;
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            min = max;
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }

            Console.WriteLine("min" + min);
            Console.WriteLine("max" + max);
            //En küçük sayı min;
            //En büyük sayı max;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == min)
                {
                    for (int j = 0; j < arr.Length; j++)
                    {
                        if (arr[j] == max)
                        {
                            temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }
            }


            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }


        //3 boyutlu dizi için her boyuttaki elemanların toplamını bulan algoritma
        private static int dimArr(int[,,] arr)
        {
            int count = 0;
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    for (int k = 0; k <= arr.GetUpperBound(2); k++)
                    {
                        count = count + arr[i, j, k];
                    }
                }
            }

            return count;
        }

        //3 boyutlu bir dizi içerisindeki belirlenen elemana nasıl erişilir
        private static int dimArr2(int[,,] arr, int number)
        {
            int count = 0;
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    for (int k = 0; k <= arr.GetUpperBound(2); k++)
                    {
                        if (arr[i, j, k] == number)
                        {
                            Console.WriteLine("aranan eleman sırasıyla indisi içerisindedir.. : " + i + ":" + j + ":" + k);
                        }
                    }
                }
            }
            return number;
        }

        //Girilen string ifadenin ilk harfinin ve boşlultan sonraki harflerinin büyük yazdırılması
        private static void StringChallenger(string deneme)
        {
            char[] karakter = new char[deneme.Length];

            for (int i = 0; i < deneme.Length; i++)
            {
                karakter[i] = deneme[i];
            }
            for (int i = 0; i < karakter.Length; i++)
            {
                karakter[0] = Char.ToUpper(karakter[0]);
                if (karakter[i] == char.Parse(" "))
                {
                    karakter[i + 1] = Char.ToUpper(karakter[i + 1]);
                }
            }
            for (int i = 0; i < karakter.Length; i++)
            {
                Console.WriteLine(karakter[i]);
            }
        }

        //Verilen string içerisindeki tüm boşlukları silen algoritma
        private static void DeleteSpace(string text)
        {
            string texter = "";
            char[] character = new char[text.Length];
            string[] arr = new string[1];
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    character[i] = text[i];
                }
                else
                {
                    character[i] = text[i+1];
                }
            }

            for (int i = 0; i < character.Length; i++)
            {
                arr[0] += character[i].ToString();
                //arr[i] = character[i].ToString();
            }
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            Console.WriteLine(arr[0]);
        }

      //Bir string diziyi tersine çeviren algoritma
        private static string ReverseArr(string text)
        {
            char[] character = new char[text.Length];
            string[] arr = new string[1];
            for (int i = 0; i < text.Length; i++)
            {
                character[i] = text[i];
            }
            for (int i = character.Length-1; i >=0 ; i--)
            {
                arr[0] += character[i];
            }
            return arr[0];
        }
        
        //Verilen dizi içerisindeki karakterleri küçük harf ile yazdıran
        private static string LowerCharacter(string text)
        {
            char[] character = new char[text.Length];
            string[] arr = new string[1];
            for (int i = 0; i < text.Length; i++)
            {
                character[i] = text[i];
            }
            for (int i = 0; i < character.Length; i++)
            {
                character[i] = Char.ToLower(character[i]);
            }
            for (int i = 0; i < character.Length; i++)
            {
                arr[0] += character[i];
            }
            return arr[0];
        }

        //Verilen 2 string arasındaki farklı karakterlerin sayısını hesaplayan fonksiyon

        private static int CountCharacter(string text,string text1)
        {
            int count = 0;
            int total = 0;
            bool status = false;
            char[] character = new char[text.Length];
            char[] character1 = new char[text1.Length];
            for (int i = 0; i < text.Length; i++)
            {
                character[i] = text[i];
            }
            for (int i = 0; i < text1.Length; i++)
            {
                character1[i] = text1[i];
            }
            if (character.Length > character1.Length)
            {
                for (int i = 0; i < character.Length; i++)
                {
                    for (int j = 0; j < character1.Length; j++)
                    {
                        status = false;

                        if (Char.ToLower(character1[j]) == Char.ToLower(character[i]))
                        {
                            status = true;
                            break;
                        }
                    }
                    if (status == false)
                    {
                        count++;
                    }
                }
                total = count + (character1.Length - count);
            }
            else if(character.Length<character1.Length)
            {
                for (int i = 0; i < character1.Length; i++)
                {
                    status = false;
                    for (int j = 0; j < character.Length; j++)
                    {
                        if (Char.ToLower(character1[i]) == Char.ToLower(character[j]))
                        {
                            status = true;
                            break;
                        }
                    }
                    if (status == false)
                    {
                        count++;
                    }
                }
                total = count + (character.Length - count);
            }
            return total;
        }

        //Verilen bir string ifade içerisindeki karakterleri alfabetik sıraya göre
        private static string OrderAlphabet(string text)
        {
            char[] character = new char[text.Length];
            string[] arr = new string[character.Length];
            string[] arr1 = new string[1];

            for (int i = 0; i < character.Length; i++)
            {
                character[i] = text[i];
                arr[i] = character[i].ToString();
            }
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                arr1[0] += arr[i];
            }
            return arr1[0];
        }


        static void Main(string[] args)
        {

            string deneme = "Bdzwpaaaaa";
            string deneme2 = "Bahtkd";
            Console.WriteLine(OrderAlphabet(deneme));
           //b,d,a,
           //z,w,p,h,t,k
        }
    }
}
