/* Média de notas: 
Leia 3 notas (double)
Calcule e mostre a média
*/

using System;
class MediaFinal {
    static void Main (String [] args){
        double Nota1, Nota2, Nota3, Media;
        
        Nota1 = 8.5;
        Nota2 = 6.2;
        Nota3 = 9.4;
        Media = (Nota1 + Nota2 + Nota3) / 3;
        
        Console.WriteLine("A média da sua nota é: {0:F2}", Media);
    }
}