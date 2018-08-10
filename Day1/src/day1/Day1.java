/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package day1;

import java.util.Scanner;

/**
 *
 * @author Lietotajs
 */
public class calculation1 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args)
    {
        
        Calculation calc = new Calculation();
        Scanner sc = new Scanner(System.in);
        
        System.out.println("Ievadiet pirmo skaitli:  ");
        double skaitlis1 =sc.nextDouble();
        
        System.out.println("Ievadiet otro skaitli:  ");
        double skaitlis2 =sc.nextDouble();
       
        double rezultats = calc.Saskaitisana(skaitlis1, skaitlis2);
        System.out.println("Rezultāts ir: "+ rezultats);
        }
     // Scanner sc = new Scanner(System.in);
        //System.out.println("Ievadiet savu vārdu:  ");
        
        // ievade = sc.nextLine();
        
        //System.out.println("SVEIKA " + ievade);
        //System.out.println("Ievadiet savu dzimšanas gadu:  ");
        //String ievade = sc.nextLine();
       /*int a,b;
        System.out.println("Ievadiet tagadējo gadu:  ");
        a=sc.nextInt();
        System.out.println("Ievadiet savu dzimšanas gadu:  ");
        b=sc.nextInt();
        
        ievade = String.valueOf(a-b);
        ievade = a-b;
        System.out.println("Jums ir:  " + ievade + "gadi.");
        
        */
    }
    
}
