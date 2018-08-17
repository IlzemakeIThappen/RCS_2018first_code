
package day5;

import java.util.Scanner;

public class Desas {
   
    Scanner sc = new Scanner(System.in);
    char[][] funkcija= new char [3][3];
    
    char iet;
    char reset;
    //char spele[3][3]={{"1","2","3"}{"4","5","6"}{"7","8","9"}};
    public void izvaditLaukumu(){
    for(int i=0;i<3;i++)
    {
        for(int j=0; j<3;j++) {
           // System.out.println("-");
             System.out.print("-  ");
             System.out.print(funkcija[i][j] + "  ");
        }
        System.out.println();
        System.out.println();
    }
   /*
    while (funkcija[i][j] == 'x' || funkcija[i][j] == 'o') {
                System.out.println("šis laukums ir aizņemts!");
            }
            if(player1 == 'x'){
        System.out.println("x");}
            
        else if  (player2 == 'o'){
                System.out.println("o");            
        }
        else if (player1 != 'x' || player2 != 'o'){
            System.out.println("lūdzu, ievadiet pareizo simbolu! ");
        }
    switch 
    
  */
}
}


    
    //uztaisīt funkciju, kura zīmē laukumu, ja nekā nav tad - zīme
    //uztaisīt, lai mainītos spēlētājs, kas ievada 0 vai x
    //ja ievada kaut ko citu nevis 0 vai x paprasīt, lai izvēlas vēlreiz
    //pārbaudīt uzvaras nosacījumus un beigt spēli, ja masīvs ir aizpildīts
    //drīkst izpildīt gājienu tikai brīvajā vietā

