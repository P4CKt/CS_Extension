using System;

namespace odev_13
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rekürsif (öz yinelemeli)
            //3^4 
            int result = 1;
            for (int i = 1; i < 5; i++)
                    result= result *3;
            Console.WriteLine(result);
            
            islemler instance = new();
            Console.WriteLine(instance.Expo(3,4));
                 // extension metotlar
                 string ifade = "Kendi Adim";
                 bool sonuc = ifade.CheckSpaces();
                 Console.WriteLine(sonuc);

                 if (sonuc)
                 {
                    Console.WriteLine(ifade.RemoveWhiteSpaces());
                    Console.WriteLine(ifade.MakeUpperCase());
                    Console.WriteLine(ifade.MakeLowerCase());
                 }
            int[] dizi = {9,6,3,2,1,5};
            dizi.SortArray();
            dizi.EkranaYazdir();
            int sayi =5;
            Console.WriteLine(sayi.IsEverNumber());
            Console.WriteLine(sayi.GetFirstCharacter());
        }
    }

    public class islemler
    {
         public int Expo(int sayi,int üs)
        {
        if (üs<2)
             return(sayi);
        return Expo (sayi, üs-1)*sayi;

        }
    
    }
    public static class Extension       //statik olmalı
    {
        public static bool CheckSpaces(this string param) // this eklemek extension metot haline getirir
        {
            return param.Contains(" ");
        }
            
         public static string RemoveWhiteSpaces(this string param)
         {
            string[] dizi = param.Split(" "); // Boşluklarından ayırıp dizi yapcak
            return string.Join("*",dizi);

         } 

         public static string MakeUpperCase(this string param)
         {
            return param.ToUpper();

         }  
         public static string MakeLowerCase(this string param)
         {
            return param.ToLower();
         }
         public static int[] SortArray(this int[] param)
         {
            Array.Sort(param);
            return param;
         }
         public static void EkranaYazdir(this int[] param)
         {
            foreach (int item in param)
            {
                Console.WriteLine (item);
            }
         }
         public static bool IsEverNumber( this int param)
         {
            return param%2 ==0;
         }
         public static string GetFirstCharacter(this string param)
         {
            return param.Substring(0,1);
         }
    } 


        
  
}
