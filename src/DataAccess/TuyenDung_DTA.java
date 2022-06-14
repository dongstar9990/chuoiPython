/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package DataAccess;

import ClassEntity.Account;
import ClassEntity.TuyenDung;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.util.ArrayList;
import javax.swing.JOptionPane;

// Xây dựng lớp TuyenDung_DTA để đọc ghi dl
public class TuyenDung_DTA {
    public void ghiFile(ArrayList<TuyenDung> list){ // Tạo hàm ghi file và truyền vào tham số là danh sách các TuyenDung
        FileOutputStream fos = null;                // Tạo đối tượng fos và oos đọc dl là đối tượng
        ObjectOutputStream oos = null;
        // xử lý ngoại lệ 
        try {
            fos = new FileOutputStream("TuyenDung.dat", false); // không tìm thấy TuyenDung.dat thì hệ thống báo lỗi
            oos = new ObjectOutputStream(fos); // truyền file fos vào oos 
            oos.writeObject(list); // ghi dữ liệu vào file
        } catch (FileNotFoundException ex) {
           JOptionPane.showMessageDialog(null,"loi: " + ex);
        } catch (IOException ex) {
            JOptionPane.showMessageDialog(null,"loi: " + ex); // lỗi ko ghi được file
        } finally{ // ghi thành công
            try {
                fos.close();
                oos.close();
            } catch (IOException ex) {
                JOptionPane.showMessageDialog(null,"loi: " + ex);
            }
        }
    }
    // Tạo hàm đọc file có kiểu dữ liệu là ArrayList
    public ArrayList<TuyenDung> docFile(){
        ArrayList<TuyenDung> list = null; // Tạo 1 ds TuyenDung để khởi gán giá trị rỗng
        FileInputStream fis = null;
        ObjectInputStream ois = null;
        File f = new File("TuyenDung.dat");  // Tạo 1 đối tượng để đọc file TuyenDung.dat
        if(f.exists()){
            try {
            fis = new FileInputStream(f);
            ois = new ObjectInputStream(fis);
            if(ois != null){ // Nếu ois có giá trị
               list = (ArrayList<TuyenDung>) ois.readObject();//thì trả về ds các TuyenDung và ois.readObject để đọc dữ liệu từ file TuyenDung.dat
            }
            } catch (IOException ex) { // ko đọc ghi file
                JOptionPane.showMessageDialog(null,"loi: " + ex);
            } catch (ClassNotFoundException ex) { // file ko tồn tại
                JOptionPane.showMessageDialog(null,"loi: " + ex);
            } finally{ // đọc thành công
                try {
                    fis.close();
                    ois.close();
                } catch (IOException ex) {
                    JOptionPane.showMessageDialog(null,"loi: " + ex);
                }
            }
        }
        return list; //trả về ds
    }
}
