/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package ClassEntity;

import View.QuanLyTuyenDung;
import java.io.Serializable;

// Xây dựng lớp trừu tượng kế thừa từ tuần tự hóa Serializable , khai báo các thuộc tính
public class TuyenDung implements Serializable{ 
    private String ma, ten, gtinh, ngsinh, sdt, email, dchi, trinhdo, cnganh, xeploai, vtungtuyen;
//Tạo 1 hàm contractor có đối tượng truyền vào là các tham số và gán giá trị cho chúng
    public TuyenDung(String ma, String ten, String gtinh, String ngsinh, String sdt, String email, String dchi, String trinhdo, String cnganh, String xeploai, String vtungtuyen) {
       // khởi tạo các đối cho các thuộc tính
        this.ma = ma;
        this.ten = ten;
        this.gtinh = gtinh;
        this.ngsinh = ngsinh;
        this.sdt = sdt;
        this.email = email;
        this.dchi = dchi;
        this.trinhdo = trinhdo;
        this.cnganh = cnganh;
        this.xeploai = xeploai;
        this.vtungtuyen = vtungtuyen;
    }
// gán và lấy ra các giá trị cho các thuộc tính ( hàm getter, setter)
    public String getMa() {
        return ma;
    }

    public void setMa(String ma) {
        this.ma = ma;
    }

    public String getTen() {
        return ten;
    }

    public void setTen(String ten) {
        this.ten = ten;
    }

    public String getGtinh() {
        return gtinh;
    }

    public void setGtinh(String gtinh) {
        this.gtinh = gtinh;
    }

    public String getNgsinh() {
        return ngsinh;
    }

    public void setNgsinh(String ngsinh) {
        this.ngsinh = ngsinh;
    }

    public String getSdt() {
        return sdt;
    }

    public void setSdt(String sdt) {
        this.sdt = sdt;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getDchi() {
        return dchi;
    }

    public void setDchi(String dchi) {
        this.dchi = dchi;
    }

    public String getTrinhdo() {
        return trinhdo;
    }

    public void setTrinhdo(String trinhdo) {
        this.trinhdo = trinhdo;
    }

    public String getCnganh() {
        return cnganh;
    }

    public void setCnganh(String cnganh) {
        this.cnganh = cnganh;
    }

    public String getXeploai() {
        return xeploai;
    }

    public void setXeploai(String xeploai) {
        this.xeploai = xeploai;
    }

    public String getVtungtuyen() {
        return vtungtuyen;
    }

    public void setVtungtuyen(String vtungtuyen) {
        this.vtungtuyen = vtungtuyen;
    }

    @Override // ghi đè các phương thức toString để xuất ra các giá trị
    public String toString() {
        return "TuyenDung{" + "ma=" + ma + ", ten=" + ten + ", gtinh=" + gtinh + ", ngsinh=" + ngsinh + ", sdt=" + sdt + ", email=" + email + ", dchi=" + dchi + ", trinhdo=" + trinhdo + ", cnganh=" + cnganh + ", xeploai=" + xeploai + ", vtungtuyen=" + vtungtuyen + '}';
    }
// Hàm check để kiểm tra xem mã tuyển dụng có tồn tại trong danh sách ko 
    public static int check(String matd) {
        QuanLyTuyenDung ql = new QuanLyTuyenDung(); // tạo đối tượng quản lý là QuanLyTuyenDung
        for (TuyenDung td: ql.list) { // dùng để lấy tuyển dụng trong ds và in ra 
            if (td.ma.equals(matd)) { // nếu tên người tuyển dụng trùng với dl truyền  vào thì trả về 1 , ngược lại trả về 0
                return 1;
            }
        }
        return 0;
    }
}
