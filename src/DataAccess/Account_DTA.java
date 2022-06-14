/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package DataAccess;

import ClassEntity.Account;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.util.ArrayList;
import javax.swing.JOptionPane;


public class Account_DTA {
    public void ghiFile(ArrayList<Account> list){
        FileOutputStream fos = null;
        ObjectOutputStream oos = null;
        try {
            fos = new FileOutputStream("Account.dat", false);
            oos = new ObjectOutputStream(fos);
            oos.writeObject(list);
        } catch (FileNotFoundException ex) {
           JOptionPane.showMessageDialog(null,"loi: " + ex);
        } catch (IOException ex) {
            JOptionPane.showMessageDialog(null,"loi: " + ex);
        } finally{
            try {
                fos.close();
                oos.close();
            } catch (IOException ex) {
                JOptionPane.showMessageDialog(null,"loi: " + ex);
            }
        }
    }
    
    public ArrayList<Account> docFile(){
        ArrayList<Account> list = null;
        FileInputStream fis = null;
        ObjectInputStream ois = null;
        File f = new File("Account.dat");
        if(f.exists()){
            try {
            fis = new FileInputStream(f);
            ois = new ObjectInputStream(fis);
            if(ois != null){
                list = (ArrayList<Account>) ois.readObject();
            }
            } catch (IOException ex) {
                JOptionPane.showMessageDialog(null,"loi: " + ex);
            } catch (ClassNotFoundException ex) {
                JOptionPane.showMessageDialog(null,"loi: " + ex);
            } finally{
                try {
                    fis.close();
                    ois.close();
                } catch (IOException ex) {
                    JOptionPane.showMessageDialog(null,"loi: " + ex);
                }
            }
        }
        return list;
    }
}
