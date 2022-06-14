/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package DataAccess;

import ClassEntity.Luong;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.util.ArrayList;
import javax.swing.JOptionPane;

public class Luong_DTA {

    public void ghiFile(ArrayList<Luong> list) {
        File file = new File("Luong.dat");
        FileOutputStream fos = null;
        ObjectOutputStream oos = null;
        if (file.exists()) {
            int yn = JOptionPane.showConfirmDialog(null, "Bạn có muốn ghi đè không?", "Xác nhận", 
                    JOptionPane.YES_NO_OPTION, JOptionPane.QUESTION_MESSAGE);
            if (yn == JOptionPane.YES_OPTION) {
                try {
                    fos = new FileOutputStream(file);
                    oos = new ObjectOutputStream(fos);
                    oos.writeObject(list);
                } catch (FileNotFoundException ex) {
                    JOptionPane.showMessageDialog(null, "loi: " + ex);
                } catch (IOException ex) {
                    JOptionPane.showMessageDialog(null, "loi: " + ex);
                } finally {
                    try {
                        fos.close();
                        oos.close();
                    } catch (IOException ex) {
                        JOptionPane.showMessageDialog(null, "loi: " + ex);
                    }
                }
                JOptionPane.showMessageDialog(null,  "Lưu file thành công!","Thông báo", JOptionPane.INFORMATION_MESSAGE);
                //nếu không đồng ý ghi đè thì hiển thị thông báo
            } else {
                JOptionPane.showMessageDialog(null, "Lưu file không thành công!", "Thông báo", JOptionPane.INFORMATION_MESSAGE);
            }
        } else {
            int yna = JOptionPane.showConfirmDialog(null, "File không tồn tại bạn có muốn tạo mới file không?", 
                    "Xác nhận", JOptionPane.YES_NO_OPTION, JOptionPane.QUESTION_MESSAGE);
            if (yna == JOptionPane.YES_OPTION) {
                try {
                    fos = new FileOutputStream(file);
                    oos = new ObjectOutputStream(fos);
                    oos.writeObject(list);
                } catch (FileNotFoundException ex) {
                    JOptionPane.showMessageDialog(null, "loi: " + ex);
                } catch (IOException ex) {
                    JOptionPane.showMessageDialog(null, "loi: " + ex);
                } finally {
                    try {
                        fos.close();
                        oos.close();
                    } catch (IOException ex) {
                        JOptionPane.showMessageDialog(null, "loi: " + ex);
                    }
                }
                JOptionPane.showMessageDialog(null,  "Lưu file thành công!","Thông báo", JOptionPane.INFORMATION_MESSAGE);
            } else {
                JOptionPane.showMessageDialog(null,  "Lưu file không thành công!","Thông báo", JOptionPane.INFORMATION_MESSAGE);
            }
        }
    }

    public ArrayList<Luong> docFile() {
        ArrayList<Luong> list = null;
        FileInputStream fis = null;
        ObjectInputStream ois = null;
        File f = new File("Luong.dat");
        if (f.exists()) {
            try {
                fis = new FileInputStream(f);
                ois = new ObjectInputStream(fis);
                if (ois != null) {
                    list = (ArrayList<Luong>) ois.readObject();
                }
            } catch (IOException ex) {
                JOptionPane.showMessageDialog(null, "Lỗi: " + ex);
            } catch (ClassNotFoundException ex) {
                JOptionPane.showMessageDialog(null, "Lỗi: " + ex);
            } finally {
                try {
                    fis.close();
                    ois.close();
                } catch (IOException ex) {
                    JOptionPane.showMessageDialog(null, "Lỗi: " + ex);
                }
            }

        } else {
            JOptionPane.showMessageDialog(null, "File không tồn tại.", "Thông báo!", JOptionPane.INFORMATION_MESSAGE);
        }
        return list;
    }
}
