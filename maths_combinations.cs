using System;

class MainClass {

  public static int BracketCombinations(int num) {

    return validar(0, 0, num);

  }

  public static int validar(int open, int close, int n){

    if (open == n && close == n) return 1;

    int total = 0;
    
    if (open < n){
      total += validar(open + 1, close, n);
    }

    if (close < open){
      total += validar(open, close + 1, n);
    }

    return total;
  }

  static void Main() {

    Console.WriteLine(BracketCombinations(Console.ReadLine()));
    
  } 

}
