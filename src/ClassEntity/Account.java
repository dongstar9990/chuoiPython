/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package ClassEntity;

import View.QuanLyTK;
import java.io.Serializable;


public class Account implements Serializable{
    private String username;
    private String password;
    private String permission;

    public Account(String username, String password, String permission) {
        this.username = username;
        this.password = password;
        this.permission = permission;
    }

    public String getUsername() {
        return username;
    }

    public void setUsername(String username) {
        this.username = username;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }

    public String getPermission() {
        return permission;
    }

    public void setPermission(String permission) {
        this.permission = permission;
    }

    @Override
    public String toString() {
        return "Account{" + "username=" + username + ", password=" + password + ", permission=" + permission + '}';
    }
    
    public static int check(String user) {
        QuanLyTK ql = new QuanLyTK();
        for (Account acc : ql.list) {
            if (acc.username.equals(user)){
                return 1;
            }
        }
        return 0;
    }
}
