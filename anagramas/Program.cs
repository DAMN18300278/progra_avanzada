using System;
using static System.Console;

namespace program{
    public static class program{
        public static void Main(){
            string? primerPalabra, segundaPalabra;
            WriteLine($"Ingrese la primer palabra: ");
            primerPalabra = ReadLine();

            WriteLine($"Ingrese la segunda palabra: ");
            segundaPalabra = ReadLine();

            char[] primera = primerPalabra.ToCharArray();
            char[] segunda = segundaPalabra.ToCharArray();

            int? cont = 0;

            for(int i = 0; i < primera.Length; i++){
                for(int j = 0; j < segunda.Length; j++){
                    if(primera[i].Equals(segunda[j])){
                        segunda[j] = '\0';
                        cont += 1;
                        break;
                    }
                }
                if(cont.Equals(primera.Length) && i.Equals(primera.Length - 1) && primera.Length.Equals(segunda.Length)){
                    WriteLine($"Sí eeeeeees");
                    break;
                }else if(i.Equals(primera.Length - 1)){
                    WriteLine($"No eeeeeeees");
                }
            }
        }
    }
}