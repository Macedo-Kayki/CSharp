using System;
using System.Collections.Generic;

class MainClass {

  public static string MinWindowSubstring(string[] strArr) {

    string N = strArr[0];
    string K = strArr[1];

    Dictionary<char, int> mapaReq = new Dictionary<char, int>();
    foreach (char c in K){
      if (!mapaReq.ContainsKey(c)){
        mapaReq[c] = 0;
      }
      mapaReq[c]++;
    }

    int inicio = 0, melhorInicio = 0;
    int contadorFaltante = K.Length;
    int menorTam = int.MaxValue;

    for (int fim = 0; fim < N.Length; fim++){
      char caractereAtual = N[fim];

      if (mapaReq.ContainsKey(caractereAtual)){
        if (mapaReq[caractereAtual] > 0){
          contadorFaltante--;
        }

        mapaReq[caractereAtual]--;
      }

      while(contadorFaltante == 0){
        int tamanhoJanelaAtual = fim - inicio + 1;

        if (tamanhoJanelaAtual < menorTam){
          menorTam = tamanhoJanelaAtual;
          melhorInicio = inicio;
        }

        char caractereEsquerda = N[inicio];

        if (mapaReq.ContainsKey(caractereEsquerda)){
          mapaReq[caractereEsquerda]++;

          if (mapaReq[caractereEsquerda] > 0){
            contadorFaltante++;
          }
        }

        inicio++;
      }
    }

    if (menorTam == int.MaxValue){
      return "";
    }

    return N.Substring(melhorInicio, menorTam);

  }

  static void Main() {

    Console.WriteLine(MinWindowSubstring(Console.ReadLine()));
    
  } 

}
