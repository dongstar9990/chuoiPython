/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package ClassEntity;

import java.time.LocalDate;


public class Luong extends NhanSu{

    
    private int songaycong, luongcb, phucap;
    private double heso;
    private String tongluong;

    public Luong(int songaycong, int luongcb, int phucap, double heso, String tongluong, String ma, String ten, String gtinh, String ngsinh, String sdt, String email, String dchi, String bophan, String cdanh, String cvu, String ngvaolam, String ghichu) {
        super(ma, ten, gtinh, ngsinh, sdt, email, dchi, bophan, cdanh, cvu, ngvaolam, ghichu);
        this.songaycong = songaycong;
        this.luongcb = luongcb;
        this.phucap = phucap;
        this.heso = heso;
        this.tongluong = tongluong;
    }

    public Luong() {
    }

    public int getSongaycong(String ngaycong) {
        int nam = Integer.parseInt(ngaycong.substring(6, 10));
        int thang = Integer.parseInt(ngaycong.substring(3, 5));
        int ngay = Integer.parseInt(ngaycong.substring(0, 2));
        LocalDate date = LocalDate.now();
        if (nam <= date.getYear()) {
            if (thang <= date.getMonthValue()) {
                songaycong = ((date.getYear()-nam)*12+(date.getMonthValue()-thang)) * 30;
            } else {
                songaycong = ((date.getYear()-nam)*12+(date.getMonthValue()-thang)) * 30;
            }
        }
      
        return songaycong;
    }

    public void setSongaycong(int songaycong) {
        this.songaycong = songaycong;
    }

    public int getLuongcb(String chucvu) {
        NhanSu ns = new NhanSu();
        if (chucvu.equals("Bảo vệ") || chucvu.equals("Lao công")) {
            luongcb = 5000000;
        } else if (chucvu.equals("Giáo viên")) {
            luongcb = 7000000;
        } else if (chucvu.equals("Phó khoa")) {
            luongcb = 8000000;
        } else if (chucvu.equals("Trưởng khoa")) {
            luongcb = 9000000;
        }
        return luongcb;
    }

    public void setLuongcb(int luongcb) {
        this.luongcb = luongcb;
    }

    public int getPhucap() {
        
        return 300000;
    }

    public void setPhucap(int phucap) {
        this.phucap = phucap;
    }

    public double getHeso(String chucvu) {      
        if (chucvu.equals("Bảo vệ") || chucvu.equals("Lao công")) {
            heso = 1.5;
        } else if (chucvu.equals("Giáo viên")) {
            heso = 2.1;
        } else if (chucvu.equals("Phó khoa")) {
            heso = 2.3;
        } else if (chucvu.equals("Trưởng khoa")) {
            heso = 2.5;
        }
        return heso;
    }

    public void setHeso(double heso) {
        this.heso = heso;
    }

    public long getTongluong(int songaycong, String chucvu) {
        double luong = (getLuongcb(chucvu)+getPhucap())*1.0/30;      
        double tluong = luong*songaycong*getHeso(chucvu);
        long tluong2 =  Math.round(tluong);
        return tluong2;
    }

   
    
    public void setTongluong(String tongluong) {
        
        this.tongluong = tongluong;
    }

    
    @Override
    public String toString() {
        return "Luong{" + "ma=" + getMa() + ", ten=" + getTen() + ", bophan=" + getBophan() + ", chucdanh=" + getCdanh() + ", chucvu=" + getCvu() + ", songaycong=" + songaycong + ", luongcb=" + luongcb + ", phucap=" + phucap + ", heso=" + heso + ", tongluong=" + tongluong + '}';
    }

    
    
}
