
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
    public void speletajaGajiens(){
        int izvele;
        int rinda=0;
        int kolonna=0;
        if(iet=='X'){
            System.out.println("Spēlētāja nr.1 gājiens (X}:");
        }else if(iet =='O'){
            System.out.println("Spēlētaāja Nr.2 gājiens (O)");
        }
        switch(izvele){
          case '1':
            rinda=0;
            kolonna=0;
            break;
            
          case '2':
            rinda=0;
            kolonna=1;
            break;
            
          case '3':
            rinda=0;
            kolonna=2;
            break;
            
          case '4':
            rinda=1;
            kolonna=0;
            break;
            
          case '5':
            rinda=1;
            kolonna=1;
            break;
            
          case '6':
            rinda=1;
            kolonna=2;
            break;
            
          case '7':
            rinda=2;
            kolonna=0;
            break;
            
          case '8':
            rinda=2;
            kolonna=1;
            break;
            
          case '9':
            rinda=2;
            kolonna=2;
            
            default:
                System.out.println("Kļūda ievadē");
                speletajaGajiens();
            break;
            
        }
        if (iet == 'X' && funkcija[rinda][kolonna] != 'X' && funkcija[rinda][kolonna] != 'O')
    {
        funkcija[rinda][kolonna] = 'X';
        iet = 'O';
    }
    else if (iet == 'O' && funkcija[rinda][kolonna] != 'X' && funkcija[rinda][kolonna] != 'O')
    {
        funkcija[rinda][kolonna] = 'O';
        iet = 'X';
    }
    else
    {
        System.out.println("Laukums jau ir izmantots, ludzu izvelieties citu laukumu");
        
        speletajaGajiens();
    }
    }
}
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



    
    //uztaisīt funkciju, kura zīmē laukumu, ja nekā nav tad - zīme
    //uztaisīt, lai mainītos spēlētājs, kas ievada 0 vai x
    //ja ievada kaut ko citu nevis 0 vai x paprasīt, lai izvēlas vēlreiz
    //pārbaudīt uzvaras nosacījumus un beigt spēli, ja masīvs ir aizpildīts
    //drīkst izpildīt gājienu tikai brīvajā vietā

