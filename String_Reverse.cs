using System;

class MainClass {

  public static string FirstReverse(string str) {

    char[] Letras = str.ToCharArray();

    Array.Reverse(Letras);

    return new String (Letras);

  }

  static void Main() {

    Console.WriteLine(FirstReverse(Console.ReadLine()));
    
  } 

}
