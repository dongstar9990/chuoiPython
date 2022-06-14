/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/GUIForms/JPanel.java to edit this template
 */
package View;

import ClassEntity.NhanSu;
import DataAccess.NhanSu_DTA;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import javax.swing.JOptionPane;
import javax.swing.ListSelectionModel;
import javax.swing.event.ListSelectionEvent;
import javax.swing.event.ListSelectionListener;
import javax.swing.table.DefaultTableModel;
import TryCatch.EmailExample;


public class QuanLyNhanSu extends javax.swing.JPanel {

    public ArrayList<NhanSu> list = new ArrayList<NhanSu>();
    NhanSu_DTA nhansudta = new NhanSu_DTA();
    EmailExample emaiexample = new EmailExample();
    
    /**
     * Creates new form QuanLyNhanSu
     */
    public QuanLyNhanSu() {
        initComponents();
        showTable();
        selectionTable();
    }

    // Hàm click vào tên sinh viên trong bảng
    void selectionTable() {
// Tạo danh sách lựa chọn của người dùng tên bảng và thiết lập chỉ chọn 1.
        ListSelectionModel listselectionmodel = table.getSelectionModel();
        listselectionmodel.setSelectionMode(ListSelectionModel.SINGLE_SELECTION);
// Thêm hàm lắng nghe sự kiện lựa chọn trên bảng
        listselectionmodel.addListSelectionListener(new ListSelectionListener() {
// Thêm hàm thay đổi giá trị lựa chọn
            @Override
            public void valueChanged(ListSelectionEvent e) {
// Lấy danh sách các cột và các hàng lựa chọn
                int[] rows = table.getSelectedRows();
                int[] colums = table.getSelectedColumns();
// Nếu có hàng được lựa chọn thì chạy tiếp
                if (colums.length > 0 && rows.length > 0) {
// Gán các giá trị từ bảng vào các ô TexField bên dưới
                    txtmanv.setText(String.valueOf(table.getValueAt(rows[0], 0)));
                    txtmanv.setEditable(false);
                    txttennv.setText(String.valueOf(table.getValueAt(rows[0], 1)));
                    txtgt.setText(String.valueOf(table.getValueAt(rows[0], 2)));
                    txtngaysinh.setText(String.valueOf(table.getValueAt(rows[0], 3)));
                    txtsdt.setText(String.valueOf(table.getValueAt(rows[0], 4)));
                    txtemail.setText(String.valueOf(table.getValueAt(rows[0], 5)));
                    txtdiachi.setText(String.valueOf(table.getValueAt(rows[0], 6)));
                    txtbophan.setText(String.valueOf(table.getValueAt(rows[0], 7)));
                    txtchucdanh.setText(String.valueOf(table.getValueAt(rows[0], 8)));
                    txtchucvu.setText(String.valueOf(table.getValueAt(rows[0], 9)));
                    txtngaygio.setText(String.valueOf(table.getValueAt(rows[0], 10)));
                    txtghichu.setText(String.valueOf(table.getValueAt(rows[0], 11)));
                }
            }
        });
    }

// Hàm hiển thị bảng
    void showTable() {
// Lấy danh sách sinh viên tưf file QuanLySV.dat
        if (nhansudta.docFile() != null) {
            list = nhansudta.docFile();
        }
        DefaultTableModel dtm = new DefaultTableModel();
        table.setModel(dtm);
// Thêm tiêu đề cho bảng
        dtm.addColumn("Mã NV");
        dtm.addColumn("Tên NV");
        dtm.addColumn("Giới tính");
        dtm.addColumn("Ngày sinh");
        dtm.addColumn("Số điện thoại");
        dtm.addColumn("Email");
        dtm.addColumn("Địa chỉ");
        dtm.addColumn("Bộ phận");
        dtm.addColumn("Chức danh");
        dtm.addColumn("Chức vụ");
        dtm.addColumn("Ngày vào");
        dtm.addColumn("Ghi chú");
// Nếu danh sách khác null thì thực hiện tiếp
        if (list != null) {
            for (int i = 0; i < list.size(); i++) {
                NhanSu a = list.get(i);
                dtm.addRow(new Object[]{a.getMa(), a.getTen(), a.getGtinh(), a.getNgsinh(), a.getSdt(), a.getEmail(), a.getDchi(), a.getBophan(), a.getCdanh(), a.getCvu(), a.getNgvaolam(), a.getGhichu()});
            }
        }
    }

    void showTableT() {
        DefaultTableModel dtm = new DefaultTableModel();
        table.setModel(dtm);
// Thêm tiêu đề cho bảng
        dtm.addColumn("Mã NV");
        dtm.addColumn("Tên NV");
        dtm.addColumn("Giới tính");
        dtm.addColumn("Ngày sinh");
        dtm.addColumn("Số điện thoại");
        dtm.addColumn("Email");
        dtm.addColumn("Địa chỉ");
        dtm.addColumn("Bộ phận");
        dtm.addColumn("Chức danh");
        dtm.addColumn("Chức vụ");
        dtm.addColumn("Ngày vào");
        dtm.addColumn("Ghi chú");
// Nếu danh sách khác null thì thực hiện tiếp
        if (list != null) {
            for (int i = 0; i < list.size(); i++) {
                NhanSu a = list.get(i);
                dtm.addRow(new Object[]{a.getMa(), a.getTen(), a.getGtinh(), a.getNgsinh(), a.getSdt(), a.getEmail(), a.getDchi(), a.getBophan(), a.getCdanh(), a.getCvu(), a.getNgvaolam(), a.getGhichu()});
            }
        }
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jScrollPane1 = new javax.swing.JScrollPane();
        table = new javax.swing.JTable();
        jLabel4 = new javax.swing.JLabel();
        btthem = new javax.swing.JButton();
        jLabel5 = new javax.swing.JLabel();
        btsua = new javax.swing.JButton();
        jLabel6 = new javax.swing.JLabel();
        btxoa = new javax.swing.JButton();
        jLabel7 = new javax.swing.JLabel();
        jLabel8 = new javax.swing.JLabel();
        jLabel13 = new javax.swing.JLabel();
        jLabel9 = new javax.swing.JLabel();
        txtghichu = new javax.swing.JTextField();
        jLabel10 = new javax.swing.JLabel();
        jLabel11 = new javax.swing.JLabel();
        jLabel12 = new javax.swing.JLabel();
        txtmanv = new javax.swing.JTextField();
        txttennv = new javax.swing.JTextField();
        txtgt = new javax.swing.JTextField();
        txtngaysinh = new javax.swing.JTextField();
        txtsdt = new javax.swing.JTextField();
        txtemail = new javax.swing.JTextField();
        txtdiachi = new javax.swing.JTextField();
        txtbophan = new javax.swing.JTextField();
        txtchucdanh = new javax.swing.JTextField();
        jPanel1 = new javax.swing.JPanel();
        jLabel1 = new javax.swing.JLabel();
        txtchucvu = new javax.swing.JTextField();
        txtngaygio = new javax.swing.JTextField();
        jLabel2 = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        btn_thoat = new javax.swing.JButton();
        btn_timkiem = new javax.swing.JButton();
        jtf_timkiem = new javax.swing.JTextField();

        setPreferredSize(new java.awt.Dimension(835, 655));

        table.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {},
                {},
                {},
                {}
            },
            new String [] {

            }
        ));
        jScrollPane1.setViewportView(table);

        jLabel4.setText("Giới Tính:");

        btthem.setBackground(new java.awt.Color(0, 204, 204));
        btthem.setText("Thêm");
        btthem.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btthemActionPerformed(evt);
            }
        });

        jLabel5.setText("Ngày sinh:");

        btsua.setBackground(new java.awt.Color(0, 204, 204));
        btsua.setText("Sửa");
        btsua.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btsuaActionPerformed(evt);
            }
        });

        jLabel6.setText("SDT:");

        btxoa.setBackground(new java.awt.Color(0, 204, 204));
        btxoa.setText("Xóa");
        btxoa.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btxoaActionPerformed(evt);
            }
        });

        jLabel7.setText("Email:");

        jLabel8.setText("Địa Chỉ:");

        jLabel13.setText("Ghi chú:");

        jLabel9.setText("Bộ Phận:");

        jLabel10.setText("Chức Danh:");

        jLabel11.setText("Chức Vụ:");

        jLabel12.setText("Ngày Vào Làm:");

        txtmanv.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                txtmanvActionPerformed(evt);
            }
        });

        txtsdt.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                txtsdtActionPerformed(evt);
            }
        });

        jPanel1.setBackground(new java.awt.Color(0, 204, 204));

        jLabel1.setFont(new java.awt.Font("Segoe UI", 1, 18)); // NOI18N
        jLabel1.setForeground(new java.awt.Color(0, 0, 204));
        jLabel1.setText("QUẢN LÝ NHÂN SỰ");

        javax.swing.GroupLayout jPanel1Layout = new javax.swing.GroupLayout(jPanel1);
        jPanel1.setLayout(jPanel1Layout);
        jPanel1Layout.setHorizontalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createSequentialGroup()
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addComponent(jLabel1, javax.swing.GroupLayout.PREFERRED_SIZE, 182, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(311, 311, 311))
        );
        jPanel1Layout.setVerticalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jLabel1)
                .addContainerGap(32, Short.MAX_VALUE))
        );

        jLabel2.setText("Mã Nhân Viên:");

        jLabel3.setText("Tên nhân viên:");

        btn_thoat.setBackground(new java.awt.Color(0, 204, 204));
        btn_thoat.setText("Hủy");
        btn_thoat.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn_thoatActionPerformed(evt);
            }
        });

        btn_timkiem.setBackground(new java.awt.Color(0, 204, 204));
        btn_timkiem.setText("Tìm kiếm");
        btn_timkiem.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn_timkiemActionPerformed(evt);
            }
        });

        jtf_timkiem.setToolTipText("");
        jtf_timkiem.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jtf_timkiemActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(this);
        this.setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jPanel1, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
            .addGroup(layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(33, 33, 33)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                            .addGroup(layout.createSequentialGroup()
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
                                    .addComponent(jLabel5, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                    .addComponent(jLabel4, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                    .addComponent(jLabel3, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(txttennv)
                                    .addComponent(txtgt)
                                    .addComponent(txtngaysinh)))
                            .addGroup(layout.createSequentialGroup()
                                .addComponent(jLabel2)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                                .addComponent(txtmanv, javax.swing.GroupLayout.PREFERRED_SIZE, 145, javax.swing.GroupLayout.PREFERRED_SIZE)))
                        .addGap(67, 67, 67)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                            .addComponent(jLabel6, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(jLabel7, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(jLabel8, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(jLabel9, javax.swing.GroupLayout.DEFAULT_SIZE, 59, Short.MAX_VALUE))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                            .addComponent(txtsdt)
                            .addComponent(txtemail)
                            .addComponent(txtdiachi)
                            .addComponent(txtbophan, javax.swing.GroupLayout.DEFAULT_SIZE, 133, Short.MAX_VALUE))
                        .addGap(41, 41, 41)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                            .addComponent(jLabel12, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(jLabel11, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(jLabel10, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(jLabel13, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                        .addGap(18, 18, 18)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(txtchucdanh, javax.swing.GroupLayout.DEFAULT_SIZE, 168, Short.MAX_VALUE)
                            .addComponent(txtchucvu)
                            .addComponent(txtngaygio)
                            .addComponent(txtghichu)))
                    .addGroup(layout.createSequentialGroup()
                        .addContainerGap()
                        .addComponent(jScrollPane1))
                    .addGroup(layout.createSequentialGroup()
                        .addContainerGap()
                        .addComponent(btthem, javax.swing.GroupLayout.PREFERRED_SIZE, 60, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(18, 18, 18)
                        .addComponent(btsua, javax.swing.GroupLayout.PREFERRED_SIZE, 60, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(18, 18, 18)
                        .addComponent(btxoa, javax.swing.GroupLayout.PREFERRED_SIZE, 60, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(18, 18, 18)
                        .addComponent(btn_thoat, javax.swing.GroupLayout.PREFERRED_SIZE, 60, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(jtf_timkiem, javax.swing.GroupLayout.PREFERRED_SIZE, 300, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(18, 18, 18)
                        .addComponent(btn_timkiem)))
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addComponent(jPanel1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(29, 29, 29)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel2)
                    .addComponent(jLabel6)
                    .addComponent(jLabel10)
                    .addComponent(txtmanv, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(txtsdt, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(txtchucdanh, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel3)
                    .addComponent(jLabel7)
                    .addComponent(jLabel11)
                    .addComponent(txttennv, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(txtemail, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(txtchucvu, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel4)
                    .addComponent(jLabel8)
                    .addComponent(jLabel12)
                    .addComponent(txtgt, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(txtdiachi, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(txtngaygio, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel5)
                    .addComponent(jLabel9)
                    .addComponent(txtngaysinh, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(txtbophan, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel13)
                    .addComponent(txtghichu, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 180, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(btthem)
                    .addComponent(btsua)
                    .addComponent(btxoa)
                    .addComponent(btn_timkiem)
                    .addComponent(jtf_timkiem, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(btn_thoat))
                .addContainerGap(192, Short.MAX_VALUE))
        );
    }// </editor-fold>//GEN-END:initComponents

    private void btthemActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btthemActionPerformed
        // TODO add your handling code here:
        if (nhansudta.docFile() != null) {
            list = nhansudta.docFile();
        }
        String ma = txtmanv.getText();
        String name = txttennv.getText();
        String gioitinh = txtgt.getText();
        String ngaysinh = txtngaysinh.getText();
        String sdt = txtsdt.getText();
        String email = txtemail.getText();
        String diachi = txtdiachi.getText();
        String bophan = txtbophan.getText();
        String chucdanh = txtchucdanh.getText();
        String chucvu = txtchucvu.getText();
        String ngayvaolam = txtngaygio.getText();
        String ghichu = txtghichu.getText();
        SimpleDateFormat df = new SimpleDateFormat("dd/MM/yyyy");
        df.setLenient(false); // set false để kiểm tra tính hợp lệ của date. VD: tháng 2 phải có 28-29 ngày, năm có 12 tháng,....
        
        if (ma.equals("") || name.equals("") || gioitinh.equals("") || ngaysinh.equals("") || sdt.equals("") || email.equals("") || diachi.equals("") || bophan.equals("") || chucdanh.equals("") || chucvu.equals("") || ngayvaolam.equals("") || ghichu.equals("")) {
            JOptionPane.showMessageDialog(this, "Các trường không được bỏ trống");
        } else {
            if(NhanSu.check(ma)==1) {
                JOptionPane.showMessageDialog(this, "Da ton tai ma!");
            } else {
            try {
                df.parse(ngaysinh);
                df.parse(ngayvaolam);
                if(!emaiexample.validate(email)){
                    JOptionPane.showMessageDialog(this, "Định dạng email không đúng", "Warning", JOptionPane.WARNING_MESSAGE);
                }
                else{
                    NhanSu a = new NhanSu(ma, name, gioitinh, ngaysinh, sdt, email, diachi, bophan, chucdanh, chucvu, ngayvaolam, ghichu);
                    list.add(a);
                    nhansudta.ghiFile(list);
                    txtmanv.setText("");
                    txttennv.setText("");
                    txtgt.setText("");
                    txtngaysinh.setText("");
                    txtsdt.setText("");
                    txtemail.setText("");
                    txtdiachi.setText("");
                    txtbophan.setText("");
                    txtchucdanh.setText("");
                    txtchucvu.setText("");
                    txtngaygio.setText("");
                    txtghichu.setText("");
                    showTable();
                    JOptionPane.showMessageDialog(this, "Thêm thành công");
                }
            }
            catch (ParseException e) { // quăng lỗi nếu dateString ko hợp lệ
               JOptionPane.showMessageDialog(this, "Định dạng ngày sinh hoặc ngày vào làm không đúng dd/MM/yyyy", "Warning", JOptionPane.WARNING_MESSAGE);
            }
            }
        }
    }//GEN-LAST:event_btthemActionPerformed

    private void btsuaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btsuaActionPerformed
        // TODO add your handling code here:
        String ma = txtmanv.getText();
        if (ma.equals("")) {
            JOptionPane.showMessageDialog(this, "click vào nhân viên muốn cập nhật");
        } else {
            if (nhansudta.docFile() != null) {
                list = nhansudta.docFile();
            }
            if (txttennv.getText().equals("") || txtgt.getText().equals("") || txtngaysinh.getText().equals("") || txtsdt.getText().equals("") 
                    || txtemail.getText().equals("") || txtdiachi.getText().equals("") || txtbophan.getText().equals("") || 
                    txtchucdanh.getText().equals("") || txtchucvu.getText().equals("") || txtngaygio.getText().equals("") || txtghichu.getText().equals("")) {
                JOptionPane.showMessageDialog(this, "Các trường không được bỏ trống");
            } else {
                try {
                    SimpleDateFormat df = new SimpleDateFormat("dd/MM/yyyy");
                    df.setLenient(false);
                    df.parse(txtngaysinh.getText());
                    df.parse(txtngaygio.getText());
                    if(!emaiexample.validate(txtemail.getText())){
                        JOptionPane.showMessageDialog(this, "Định dạng email không đúng", "Warning", JOptionPane.WARNING_MESSAGE);
                    }
                    else{
                        for (NhanSu a : list) {
                            if (a.getMa().equals(ma)) {
                                a.setTen(txttennv.getText());
                                a.setGtinh(txtgt.getText());
                                a.setNgsinh(txtngaysinh.getText());
                                a.setSdt(txtsdt.getText());
                                a.setEmail(txtemail.getText());
                                a.setDchi(txtdiachi.getText());
                                a.setBophan(txtbophan.getText());
                                a.setCdanh(txtchucdanh.getText());
                                a.setCvu(txtchucvu.getText());
                                a.setNgvaolam(txtngaygio.getText());
                                a.setGhichu(txtghichu.getText());
                            }
                        }
                        nhansudta.ghiFile(list);
                        showTable();
                        txtmanv.setText("");
                        txttennv.setText("");
                        txtgt.setText("");
                        txtngaysinh.setText("");
                        txtsdt.setText("");
                        txtemail.setText("");
                        txtdiachi.setText("");
                        txtbophan.setText("");
                        txtchucdanh.setText("");
                        txtchucvu.setText("");
                        txtngaygio.setText("");
                        txtghichu.setText("");
                        JOptionPane.showMessageDialog(this, "Cập nhật thành công");
                    }
                }
                catch (ParseException e) { // quăng lỗi nếu dateString ko hợp lệ
                   JOptionPane.showMessageDialog(this, "Định dạng ngày sinh hoặc ngày vào làm không đúng dd/MM/yyyy", "Warning", JOptionPane.WARNING_MESSAGE);
                }
            }
            
        }

    }//GEN-LAST:event_btsuaActionPerformed

    private void btxoaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btxoaActionPerformed
        // TODO add your handling code here:
        ArrayList<NhanSu> list1 = new ArrayList<NhanSu>();
        String ma = txtmanv.getText();
        if (ma.equals("")) {
            JOptionPane.showMessageDialog(this, "click vào nhân viên muốn xóa");
        } else {

            int result = JOptionPane.showConfirmDialog(this, "Bạn muốn xóa trường này?", "Confirm", JOptionPane.YES_NO_OPTION, JOptionPane.QUESTION_MESSAGE);
            if (result == JOptionPane.YES_OPTION) {
                if (nhansudta.docFile() != null) {
                    list = nhansudta.docFile();
                }
                for (NhanSu a : list) {
                    if (!a.getMa().equals(ma)) {
                        list1.add(a);
                    }
                }
                nhansudta.ghiFile(list1);
                showTable();
                txtmanv.setText("");
                txttennv.setText("");
                txtgt.setText("");
                txtngaysinh.setText("");
                txtsdt.setText("");
                txtemail.setText("");
                txtdiachi.setText("");
                txtbophan.setText("");
                txtchucdanh.setText("");
                txtchucvu.setText("");
                txtngaygio.setText("");
                txtghichu.setText("");
                JOptionPane.showMessageDialog(this, "Xóa thành công");
            }
        }

    }//GEN-LAST:event_btxoaActionPerformed

    private void btn_thoatActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn_thoatActionPerformed
        // TODO add your handling code here:
        txtmanv.setText("");
        txtmanv.setEditable(true);
        txttennv.setText("");
        txtgt.setText("");
        txtngaysinh.setText("");
        txtsdt.setText("");
        txtemail.setText("");
        txtdiachi.setText("");
        txtbophan.setText("");
        txtchucdanh.setText("");
        txtchucvu.setText("");
        txtngaygio.setText("");
        txtghichu.setText("");
    }//GEN-LAST:event_btn_thoatActionPerformed

    private void jtf_timkiemActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jtf_timkiemActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_jtf_timkiemActionPerformed

    private void btn_timkiemActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn_timkiemActionPerformed
        // TODO add your handling code here:
       int count =0;
        for (int i = 0; i < table.getRowCount(); i++) {
            if (String.valueOf(table.getValueAt(i, 0)).equals(jtf_timkiem.getText()) || 
                    String.valueOf(table.getValueAt(i, 1)).equals(jtf_timkiem.getText())) {
                count++;
                DefaultTableModel dtm = new DefaultTableModel();
                table.setModel(dtm);
                // Thêm tiêu đề cho bảng
                dtm.addColumn("Mã NV");
                dtm.addColumn("Tên NV");
                dtm.addColumn("Giới tính");
                dtm.addColumn("Ngày sinh");
                dtm.addColumn("Số điện thoại");
                dtm.addColumn("Email");
                dtm.addColumn("Địa chỉ");
                dtm.addColumn("Bộ phận");
                dtm.addColumn("Chức danh");
                dtm.addColumn("Chức vụ");
                dtm.addColumn("Ngày vào");
                dtm.addColumn("Ghi chú");
                //insert into table
                NhanSu a = list.get(i);
                dtm.addRow(new Object[]{a.getMa(), a.getTen(), a.getGtinh(), a.getNgsinh(), a.getSdt(), 
                    a.getEmail(), a.getDchi(), a.getBophan(), a.getCdanh(), a.getCvu(), a.getNgvaolam(), 
                    a.getGhichu()}); }
        }
        if(count == 0){
            JOptionPane.showMessageDialog(this, "Không tìm thấy kết quả", "Warning", JOptionPane.WARNING_MESSAGE);
            showTable(); }

    }//GEN-LAST:event_btn_timkiemActionPerformed

    private void txtsdtActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_txtsdtActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_txtsdtActionPerformed

    private void txtmanvActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_txtmanvActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_txtmanvActionPerformed


    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btn_thoat;
    private javax.swing.JButton btn_timkiem;
    private javax.swing.JButton btsua;
    private javax.swing.JButton btthem;
    private javax.swing.JButton btxoa;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel10;
    private javax.swing.JLabel jLabel11;
    private javax.swing.JLabel jLabel12;
    private javax.swing.JLabel jLabel13;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JLabel jLabel7;
    private javax.swing.JLabel jLabel8;
    private javax.swing.JLabel jLabel9;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JTextField jtf_timkiem;
    private javax.swing.JTable table;
    private javax.swing.JTextField txtbophan;
    private javax.swing.JTextField txtchucdanh;
    private javax.swing.JTextField txtchucvu;
    private javax.swing.JTextField txtdiachi;
    private javax.swing.JTextField txtemail;
    private javax.swing.JTextField txtghichu;
    private javax.swing.JTextField txtgt;
    private javax.swing.JTextField txtmanv;
    private javax.swing.JTextField txtngaygio;
    private javax.swing.JTextField txtngaysinh;
    private javax.swing.JTextField txtsdt;
    private javax.swing.JTextField txttennv;
    // End of variables declaration//GEN-END:variables
}
