/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package day10;

/**
 *
 * @author Lietotajs
 */
public class GUI extends javax.swing.JPanel {
String Skaitlis;
    /**
     * Creates new form GUI
     */
    public GUI() {
        initComponents();
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        InputButton = new javax.swing.JButton();
        izvade = new javax.swing.JLabel();
        ievade = new java.awt.TextField();
        restes = new javax.swing.JButton();
        lielie = new javax.swing.JButton();

        InputButton.setText("ok");
        InputButton.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                InputButtonActionPerformed(evt);
            }
        });

        ievade.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                ievadeActionPerformed(evt);
            }
        });

        restes.setText("restites");
        restes.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                restesActionPerformed(evt);
            }
        });

        lielie.setText("LIELIE");
        lielie.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                lielieActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(this);
        this.setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addGap(55, 55, 55)
                .addComponent(InputButton)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 27, Short.MAX_VALUE)
                        .addComponent(izvade)
                        .addGap(275, 275, 275))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(37, 37, 37)
                        .addComponent(restes)
                        .addGap(31, 31, 31)
                        .addComponent(lielie)
                        .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))))
            .addGroup(layout.createSequentialGroup()
                .addGap(83, 83, 83)
                .addComponent(ievade, javax.swing.GroupLayout.PREFERRED_SIZE, 173, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(0, 0, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(87, 87, 87)
                .addComponent(ievade, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(22, 22, 22)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(InputButton)
                    .addComponent(restes)
                    .addComponent(lielie))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 85, Short.MAX_VALUE)
                .addComponent(izvade)
                .addGap(63, 63, 63))
        );
    }// </editor-fold>//GEN-END:initComponents

    private void InputButtonActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_InputButtonActionPerformed
       
       String ievaditaisSkaitlis = ievade.getText();
      //Int ievaditaisSkaitlis=Integer.parseInt(5);
        if(ievaditaisSkaitlis.equals("")){
            izvade.setText("Lauki ir tuksi");
        }
        
        else if(ievaditaisSkaitlis.equals("1") || ievaditaisSkaitlis.equals("2") || ievaditaisSkaitlis.equals("3")|| ievaditaisSkaitlis.equals("4")  ){
            izvade.setText("Jūs esat ievadījis skaitli, kurš ir mazāks par 5");
        }
        else if(ievaditaisSkaitlis.equals("5")){
            izvade.setText("Jūs esat ievadījis skaitli, kurš ir vienāds ar 5");
        }
        else{
            izvade.setText("Jūs esat ievadījis skaitli, kurš ir lielāks par 5");
        }        
    }//GEN-LAST:event_InputButtonActionPerformed

    private void ievadeActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_ievadeActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_ievadeActionPerformed

    private void restesActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_restesActionPerformed
        // TODO add your handling code here:
       // String skaitlis = ievade.getText();
      // String skaitlis = zv.length; 
        //String skaitlis = ievade.getText();
      String restite="";
                 
        String Skaitlis = ievade.getText();
        int skaitlis = Integer.valueOf(Skaitlis);
        for(int i = 0; i < skaitlis; i++){
            restite = restite + "#";
            if(restite.length()<=10){
            izvade.setText(restite);
            }
            else {
            izvade.setText("Ievadiet skaitli 1-10..");
            }
        }            
    }//GEN-LAST:event_restesActionPerformed

    private void lielieActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_lielieActionPerformed
        // TODO add your handling code here:
        String vards = ievade.getText();
        String vards1=ievade.getText();
        if(Character.isUpperCase(vards1.charAt(0))){
             izvade.setText(vards.toUpperCase());
             //replace()
        }
             else 
             {
                 izvade.setText(vards);
             }
             
    }//GEN-LAST:event_lielieActionPerformed

    
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton InputButton;
    private java.awt.TextField ievade;
    private javax.swing.JLabel izvade;
    private javax.swing.JButton lielie;
    private javax.swing.JButton restes;
    // End of variables declaration//GEN-END:variables
}