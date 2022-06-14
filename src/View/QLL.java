/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package View;

import ClassEntity.Luong;
import ClassEntity.NhanSu;

import DataAccess.Luong_DTA;
import DataAccess.NhanSu_DTA;
import java.awt.List;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;
import javax.swing.JOptionPane;
import javax.swing.ListSelectionModel;
import javax.swing.RowSorter;
import javax.swing.SortOrder;
import javax.swing.event.ListSelectionEvent;
import javax.swing.event.ListSelectionListener;
import javax.swing.table.DefaultTableModel;
import javax.swing.table.TableModel;
import javax.swing.table.TableRowSorter;

public class QLL extends javax.swing.JPanel {

    public ArrayList<NhanSu> listNS = new ArrayList<NhanSu>();
    NhanSu_DTA nhansudta = new NhanSu_DTA();
    ArrayList<Luong> listL = new ArrayList<Luong>();
    Luong_DTA luongdta = new Luong_DTA();

    /**
     * Creates new form QLL
     */
    public QLL() {
       initComponents();
        //showTable();
        selectionTable();
    }

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
                    //tạo mới lương
                    Luong luong = new Luong();

                    //lấy số ngày công để tính tổng lương
                    int songaycong = luong.getSongaycong(String.valueOf(table.getValueAt(rows[0], 8)));
                    //lấy chức vụ để tính tổng lương
                    String chucvu = String.valueOf(table.getValueAt(rows[0], 7));

                    //gán giá trị từng cột vào label tương ứng
                    jlb_ma.setText(String.valueOf(table.getValueAt(rows[0], 0)));
                    jlb_ten.setText(String.valueOf(table.getValueAt(rows[0], 1)));
                    jlb_bp.setText(String.valueOf(table.getValueAt(rows[0], 5)));
                    jlb_cd.setText(String.valueOf(table.getValueAt(rows[0], 6)));
                    jlb_cv.setText(String.valueOf(table.getValueAt(rows[0], 7)));
                    jlb_ngay.setText(String.valueOf(songaycong));
                    jlb_luongcb.setText(String.valueOf(luong.getLuongcb(chucvu)));
                    jlb_luong.setText(String.valueOf(luong.getTongluong(songaycong, chucvu)));
                    jlb_pc.setText(String.valueOf(luong.getPhucap()));
                    jlb_hs.setText(String.valueOf(luong.getHeso(chucvu)));
                }
            }
        });
    }

// Hàm hiển thị bảng
    void showTable() {
// Lấy danh sách sinh viên tưf file NhanSu.dat
        if (nhansudta.docFile() != null) {
            listNS = nhansudta.docFile();
        }
        DefaultTableModel dtm = new DefaultTableModel();
        table.setModel(dtm);
// Thêm tiêu đề cho bảng
        dtm.addColumn("Mã NV");
        dtm.addColumn("Tên NV");
        dtm.addColumn("Giới tính");
        dtm.addColumn("Ngày sinh");
        dtm.addColumn("Số điện thoại");
        dtm.addColumn("Bộ phận");
        dtm.addColumn("Chức danh");
        dtm.addColumn("Chức vụ");
        dtm.addColumn("Ngày vào");
        dtm.addColumn("Tổng lương");
// Nếu danh sách khác null thì thực hiện tiếp
        if (listNS != null) {
            for (int i = 0; i < listNS.size(); i++) {
                NhanSu a = listNS.get(i);
                //tạo mới luong
                Luong l = new Luong();
                //dùng để tính tổng lương dựa trên ngày vào làm
                int songaycong = l.getSongaycong(a.getNgvaolam());
                //tính luong
                long luong = l.getTongluong(songaycong, a.getCvu());
                //thêm dòng vào bảng và các thuộc tính trên 1 dòng
                dtm.addRow(new Object[]{a.getMa(), a.getTen(), a.getGtinh(), a.getNgsinh(), 
                    a.getSdt(), a.getBophan(), a.getCdanh(), a.getCvu(), a.getNgvaolam(), luong});
            }
        }
    }

    //hiển thị bảng
    public void showTableT(ArrayList<NhanSu> listns) {
        DefaultTableModel dtm = new DefaultTableModel();
        table.setModel(dtm);
// Thêm tiêu đề cho bảng
        dtm.addColumn("Mã NV");
        dtm.addColumn("Tên NV");
        dtm.addColumn("Giới tính");
        dtm.addColumn("Ngày sinh");
        dtm.addColumn("Số điện thoại");
        dtm.addColumn("Bộ phận");
        dtm.addColumn("Chức danh");
        dtm.addColumn("Chức vụ");
        dtm.addColumn("Ngày vào");
        dtm.addColumn("Tổng lương");
// Nếu danh sách khác null thì thực hiện tiếp
        if (listNS != null) {
            for (int i = 0; i < listNS.size(); i++) {
                NhanSu a = listNS.get(i);
                Luong l = new Luong();
                //lấy số ngày công để tính tổng lương
                int songaycong = l.getSongaycong(a.getNgvaolam());
                //tính tổng lương
                long luong = l.getTongluong(songaycong, a.getCvu());
                dtm.addRow(new Object[]{a.getMa(), a.getTen(), a.getGtinh(), a.getNgsinh(), a.getSdt(), a.getBophan(), a.getCdanh(), a.getCvu(), a.getNgvaolam(), luong});
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

        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        jLabel4 = new javax.swing.JLabel();
        jLabel5 = new javax.swing.JLabel();
        jLabel6 = new javax.swing.JLabel();
        jLabel7 = new javax.swing.JLabel();
        jLabel8 = new javax.swing.JLabel();
        jLabel9 = new javax.swing.JLabel();
        jaja = new javax.swing.JLabel();
        jlb_ma = new javax.swing.JLabel();
        jlb_ten = new javax.swing.JLabel();
        jlb_bp = new javax.swing.JLabel();
        jlb_cd = new javax.swing.JLabel();
        jlb_ngay = new javax.swing.JLabel();
        jlb_cv = new javax.swing.JLabel();
        jlb_luongcb = new javax.swing.JLabel();
        jlb_pc = new javax.swing.JLabel();
        jlb_hs = new javax.swing.JLabel();
        jlb_luong = new javax.swing.JLabel();
        btn_timkiem = new javax.swing.JButton();
        jtf_timkiem = new javax.swing.JTextField();
        ghi = new javax.swing.JButton();
        doc = new javax.swing.JButton();
        cbb_sx = new javax.swing.JComboBox<>();
        jButton4 = new javax.swing.JButton();
        jPanel1 = new javax.swing.JPanel();
        jScrollPane1 = new javax.swing.JScrollPane();
        table = new javax.swing.JTable();
        jLabel10 = new javax.swing.JLabel();

        setPreferredSize(new java.awt.Dimension(835, 556));

        jLabel1.setFont(new java.awt.Font("Segoe UI", 0, 14)); // NOI18N
        jLabel1.setText("Mã nhân sự:");

        jLabel2.setFont(new java.awt.Font("Segoe UI", 0, 14)); // NOI18N
        jLabel2.setText("Họ và tên:");

        jLabel3.setFont(new java.awt.Font("Segoe UI", 0, 14)); // NOI18N
        jLabel3.setText("Bộ phận:");

        jLabel4.setFont(new java.awt.Font("Segoe UI", 0, 14)); // NOI18N
        jLabel4.setText("Chức danh:");

        jLabel5.setFont(new java.awt.Font("Segoe UI", 0, 14)); // NOI18N
        jLabel5.setText("Lương cơ bản:");

        jLabel6.setFont(new java.awt.Font("Segoe UI", 0, 14)); // NOI18N
        jLabel6.setText("Chức vụ:");

        jLabel7.setFont(new java.awt.Font("Segoe UI", 0, 14)); // NOI18N
        jLabel7.setText("Phụ cấp:");

        jLabel8.setFont(new java.awt.Font("Segoe UI", 0, 14)); // NOI18N
        jLabel8.setText("Hệ số:");

        jLabel9.setFont(new java.awt.Font("Segoe UI", 1, 18)); // NOI18N
        jLabel9.setText("Tổng lương:");

        jaja.setFont(new java.awt.Font("Segoe UI", 0, 14)); // NOI18N
        jaja.setText("Số ngày công:");

        jlb_ma.setFont(new java.awt.Font("Segoe UI", 1, 13)); // NOI18N

        jlb_ten.setFont(new java.awt.Font("Segoe UI", 1, 13)); // NOI18N

        jlb_bp.setFont(new java.awt.Font("Segoe UI", 1, 13)); // NOI18N

        jlb_cd.setFont(new java.awt.Font("Segoe UI", 1, 13)); // NOI18N

        jlb_ngay.setFont(new java.awt.Font("Segoe UI", 1, 13)); // NOI18N

        jlb_cv.setFont(new java.awt.Font("Segoe UI", 1, 13)); // NOI18N

        jlb_luongcb.setFont(new java.awt.Font("Segoe UI", 1, 13)); // NOI18N

        jlb_pc.setFont(new java.awt.Font("Segoe UI", 1, 13)); // NOI18N

        jlb_hs.setFont(new java.awt.Font("Segoe UI", 1, 13)); // NOI18N

        jlb_luong.setBackground(new java.awt.Color(255, 255, 255));
        jlb_luong.setFont(new java.awt.Font("Segoe UI", 1, 16)); // NOI18N
        jlb_luong.setForeground(new java.awt.Color(0, 0, 255));

        btn_timkiem.setBackground(new java.awt.Color(0, 204, 204));
        btn_timkiem.setFont(new java.awt.Font("Segoe UI", 0, 13)); // NOI18N
        btn_timkiem.setText("Tìm kiếm");
        btn_timkiem.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn_timkiemActionPerformed(evt);
            }
        });

        jtf_timkiem.setFont(new java.awt.Font("Segoe UI", 0, 13)); // NOI18N

        ghi.setBackground(new java.awt.Color(0, 204, 204));
        ghi.setFont(new java.awt.Font("Segoe UI", 0, 13)); // NOI18N
        ghi.setText("Ghi file");
        ghi.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                ghiActionPerformed(evt);
            }
        });

        doc.setBackground(new java.awt.Color(0, 204, 204));
        doc.setFont(new java.awt.Font("Segoe UI", 0, 13)); // NOI18N
        doc.setText("Đọc file");
        doc.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                docActionPerformed(evt);
            }
        });

        cbb_sx.setBackground(new java.awt.Color(0, 204, 204));
        cbb_sx.setFont(new java.awt.Font("Segoe UI", 0, 13)); // NOI18N
        cbb_sx.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Mã nhân viên", "Họ tên", "Tổng lương" }));

        jButton4.setBackground(new java.awt.Color(0, 204, 204));
        jButton4.setFont(new java.awt.Font("Segoe UI", 0, 13)); // NOI18N
        jButton4.setText("Sắp xếp");
        jButton4.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton4ActionPerformed(evt);
            }
        });

        jPanel1.setBackground(new java.awt.Color(0, 204, 204));

        table.setFont(new java.awt.Font("Segoe UI", 0, 14)); // NOI18N
        table.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {null, null, null, null, null, null, null, null, null, null},
                {null, null, null, null, null, null, null, null, null, null},
                {null, null, null, null, null, null, null, null, null, null},
                {null, null, null, null, null, null, null, null, null, null},
                {null, null, null, null, null, null, null, null, null, null},
                {null, null, null, null, null, null, null, null, null, null},
                {null, null, null, null, null, null, null, null, null, null},
                {null, null, null, null, null, null, null, null, null, null},
                {null, null, null, null, null, null, null, null, null, null},
                {null, null, null, null, null, null, null, null, null, null}
            },
            new String [] {
                "Mã nhân sự", "Họ tên", "Giới tính", "Ngày sinh", "SĐT", "Bộ phận", "Chức danh", "Chức vụ", "Ngày vào làm", "Tổng lương"
            }
        ) {
            Class[] types = new Class [] {
                java.lang.String.class, java.lang.String.class, java.lang.String.class, java.lang.String.class, java.lang.String.class, java.lang.String.class, java.lang.String.class, java.lang.String.class, java.lang.String.class, java.lang.String.class
            };
            boolean[] canEdit = new boolean [] {
                false, false, false, false, false, false, false, false, false, false
            };

            public Class getColumnClass(int columnIndex) {
                return types [columnIndex];
            }

            public boolean isCellEditable(int rowIndex, int columnIndex) {
                return canEdit [columnIndex];
            }
        });
        jScrollPane1.setViewportView(table);

        jLabel10.setBackground(new java.awt.Color(0, 204, 204));
        jLabel10.setFont(new java.awt.Font("Segoe UI", 1, 18)); // NOI18N
        jLabel10.setForeground(new java.awt.Color(0, 0, 204));
        jLabel10.setText("QUẢN LÝ LƯƠNG");
        jLabel10.setToolTipText("");

        javax.swing.GroupLayout jPanel1Layout = new javax.swing.GroupLayout(jPanel1);
        jPanel1.setLayout(jPanel1Layout);
        jPanel1Layout.setHorizontalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createSequentialGroup()
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addComponent(jLabel10)
                .addGap(340, 340, 340))
            .addComponent(jScrollPane1)
        );
        jPanel1Layout.setVerticalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createSequentialGroup()
                .addGap(21, 21, 21)
                .addComponent(jLabel10)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 27, Short.MAX_VALUE)
                .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 187, javax.swing.GroupLayout.PREFERRED_SIZE))
        );

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(this);
        this.setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addComponent(jLabel9)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jtf_timkiem, javax.swing.GroupLayout.PREFERRED_SIZE, 229, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(btn_timkiem)
                        .addGap(42, 42, 42)
                        .addComponent(cbb_sx, javax.swing.GroupLayout.PREFERRED_SIZE, 150, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jButton4)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 40, Short.MAX_VALUE)
                        .addComponent(ghi)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(doc))
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jlb_luong, javax.swing.GroupLayout.PREFERRED_SIZE, 166, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(0, 0, Short.MAX_VALUE)))
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
            .addGroup(layout.createSequentialGroup()
                .addGap(59, 59, 59)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                        .addComponent(jLabel1, javax.swing.GroupLayout.PREFERRED_SIZE, 85, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(jlb_ma, javax.swing.GroupLayout.PREFERRED_SIZE, 80, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(84, 84, 84)
                        .addComponent(jLabel4)
                        .addGap(42, 42, 42)
                        .addComponent(jlb_cd, javax.swing.GroupLayout.PREFERRED_SIZE, 120, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(35, 35, 35)
                        .addComponent(jLabel5, javax.swing.GroupLayout.PREFERRED_SIZE, 89, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(18, 18, 18))
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(layout.createSequentialGroup()
                                .addComponent(jLabel2, javax.swing.GroupLayout.PREFERRED_SIZE, 77, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addGap(18, 18, 18)
                                .addComponent(jlb_ten, javax.swing.GroupLayout.PREFERRED_SIZE, 130, javax.swing.GroupLayout.PREFERRED_SIZE))
                            .addGroup(layout.createSequentialGroup()
                                .addComponent(jLabel3, javax.swing.GroupLayout.PREFERRED_SIZE, 77, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addGap(18, 18, 18)
                                .addComponent(jlb_bp, javax.swing.GroupLayout.PREFERRED_SIZE, 130, javax.swing.GroupLayout.PREFERRED_SIZE)))
                        .addGap(34, 34, 34)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(layout.createSequentialGroup()
                                .addComponent(jLabel6)
                                .addGap(59, 59, 59)
                                .addComponent(jlb_cv, javax.swing.GroupLayout.PREFERRED_SIZE, 120, javax.swing.GroupLayout.PREFERRED_SIZE))
                            .addGroup(layout.createSequentialGroup()
                                .addComponent(jaja, javax.swing.GroupLayout.PREFERRED_SIZE, 94, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addGap(18, 18, 18)
                                .addComponent(jlb_ngay, javax.swing.GroupLayout.PREFERRED_SIZE, 80, javax.swing.GroupLayout.PREFERRED_SIZE)))
                        .addGap(35, 35, 35)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jLabel8, javax.swing.GroupLayout.PREFERRED_SIZE, 53, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(jLabel7))
                        .addGap(54, 54, 54)))
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addComponent(jlb_hs, javax.swing.GroupLayout.PREFERRED_SIZE, 80, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jlb_pc, javax.swing.GroupLayout.DEFAULT_SIZE, 114, Short.MAX_VALUE)
                    .addComponent(jlb_luongcb, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                .addGap(0, 0, Short.MAX_VALUE))
            .addComponent(jPanel1, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addComponent(jPanel1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(45, 45, 45)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jLabel1)
                    .addComponent(jlb_ma, javax.swing.GroupLayout.PREFERRED_SIZE, 25, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel4)
                    .addComponent(jlb_cd, javax.swing.GroupLayout.PREFERRED_SIZE, 25, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jlb_luongcb, javax.swing.GroupLayout.PREFERRED_SIZE, 25, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel5))
                .addGap(40, 40, 40)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jLabel2)
                    .addComponent(jlb_ten, javax.swing.GroupLayout.PREFERRED_SIZE, 25, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel6)
                    .addComponent(jlb_cv, javax.swing.GroupLayout.PREFERRED_SIZE, 25, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel7)
                    .addComponent(jlb_pc, javax.swing.GroupLayout.PREFERRED_SIZE, 25, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(34, 34, 34)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jLabel3)
                    .addComponent(jaja)
                    .addComponent(jlb_ngay, javax.swing.GroupLayout.PREFERRED_SIZE, 25, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel8)
                    .addComponent(jlb_hs, javax.swing.GroupLayout.PREFERRED_SIZE, 25, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jlb_bp, javax.swing.GroupLayout.PREFERRED_SIZE, 25, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addComponent(jLabel9)
                    .addComponent(jlb_luong, javax.swing.GroupLayout.PREFERRED_SIZE, 25, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(21, 21, 21)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(btn_timkiem)
                    .addComponent(jtf_timkiem, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(cbb_sx, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jButton4)
                    .addComponent(ghi)
                    .addComponent(doc))
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );
    }// </editor-fold>//GEN-END:initComponents

    //sự kiện khi click vào button tìm kiếm
    private void btn_timkiemActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn_timkiemActionPerformed
        //count đếm số phần tử không tìm thấy nếu count = số phần tử trong danh sách thì là không tìm thấy giá trị yêu cầu
        int count = 0;
        //Đặt bảng về mặc định không cột không hàng
        DefaultTableModel dtm = new DefaultTableModel();
        // Thêm tiêu đề cho bảng/ số cột dựa trên số tiêu đề 
        dtm.addColumn("Mã NV");
        dtm.addColumn("Tên NV");
        dtm.addColumn("Giới tính");
        dtm.addColumn("Ngày sinh");
        dtm.addColumn("Số điện thoại");

        dtm.addColumn("Bộ phận");
        dtm.addColumn("Chức danh");
        dtm.addColumn("Chức vụ");
        dtm.addColumn("Ngày vào");
        dtm.addColumn("Tổng lương");
        table.setModel(dtm);

        //kiểm tra thông tin trong bảng nếu có trong phần tìm kiếm thì xuất vào bảng
        for (NhanSu ns : listNS) {
            if (ns.getTen().contains(jtf_timkiem.getText()) || ns.getMa().contains(jtf_timkiem.getText())) {
                Luong l = new Luong();
                int ngay = l.getSongaycong(ns.getNgvaolam());
                long luong = l.getTongluong(ngay, ns.getCvu());
                dtm.addRow(new Object[]{ns.getMa(), ns.getTen(), ns.getGtinh(), ns.getNgsinh(), ns.getSdt(), ns.getBophan(), ns.getCdanh(), ns.getCvu(), ns.getNgvaolam(), luong});

            } else {
                count++;
            }
        }
        //nếu count = số phần tử trong danh sách thì là không tìm thấy giá trị yêu cầu
        if (count == listNS.size()) {
            JOptionPane.showMessageDialog(null, "Không tìm thấy!");
        }
    }//GEN-LAST:event_btn_timkiemActionPerformed

    //bắt sự kiện khi click đọc file đưa dữ liệu vào bảng và hiển thị lên màn hình
    private void docActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_docActionPerformed
        //hiển thị bảng
        showTable();
    }//GEN-LAST:event_docActionPerformed

    //bắt sự kiện khi click button Sắp xếp theo chủ đề tự chọn trong hộp comboBox
    private void jButton4ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton4ActionPerformed
        //tạo mới lương
        Luong l = new Luong();
        //nếu chọn phần tử đầu trong comboBox thì sắp xếp theo mã
        if (cbb_sx.getSelectedIndex() == 0) {
            Collections.sort(listNS, new Comparator<NhanSu>() {
                @Override
                public int compare(NhanSu o1, NhanSu o2) {
                    return o1.getMa().compareTo(o2.getMa());
                }
            });
            showTableT(listNS);

        } // chọn phần tử thứ 2 trong comboBox sắp xếp theo tên 
        else if (cbb_sx.getSelectedIndex() == 1) {
            Collections.sort(listNS, new Comparator<NhanSu>() {
                @Override
                public int compare(NhanSu o1, NhanSu o2) {
                    return o1.getTen().compareTo(o2.getTen());
                }
            });
            showTableT(listNS);
        } //chọn phần tử thứ 3 trong comboBox sắp xếp theo Tổng lương
        else if (cbb_sx.getSelectedIndex() == 2) {
            //hàm sắp xếp theo tổng lương
            TableRowSorter<TableModel> sorter = new TableRowSorter<TableModel>(table.getModel());
            //sắp xếp theo cột 
            table.setRowSorter(sorter);
            ArrayList<RowSorter.SortKey> sortKeys = new ArrayList<>(25);
            sortKeys.add(new RowSorter.SortKey(9, SortOrder.ASCENDING));
            sorter.setSortKeys(sortKeys);
        }
    }//GEN-LAST:event_jButton4ActionPerformed

   //bắt sự kiện khi click ghi file
    private void ghiActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_ghiActionPerformed
        // TODO add your handling code here:
        for (int i = 0; i < listNS.size(); i++) {
            Luong luong = new Luong();
            //gán các giá trị từ bảng vào các biến tương ứng
            int songaycong = luong.getSongaycong(String.valueOf(table.getValueAt(i, 8)));
            String chucvu = String.valueOf(table.getValueAt(i, 7));
            String ma = String.valueOf(table.getValueAt(i, 0));
            String ten = String.valueOf(table.getValueAt(i, 1));
            String bp = String.valueOf(table.getValueAt(i, 5));
            String cd = String.valueOf(table.getValueAt(i, 6));
            String cv = String.valueOf(table.getValueAt(i, 7));
            int luongcb = luong.getLuongcb(chucvu);
            String tluong = String.valueOf(luong.getTongluong(songaycong, chucvu));
            int pc = luong.getPhucap();
            double hs = luong.getHeso(chucvu);

            //set các giá trị để thêm vào list lương
            luong.setMa(ma);
            luong.setTen(ten);
            luong.setBophan(bp);
            luong.setCvu(cv);
            luong.setCdanh(cd);
            luong.setLuongcb(luongcb);
            luong.setTongluong(tluong);
            luong.setPhucap(pc);
            luong.setHeso(hs);

            //thêm vào list lương
            listL.add(luong);

        }
        //ghi file
        luongdta.ghiFile(listL);
    }//GEN-LAST:event_ghiActionPerformed


    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btn_timkiem;
    private javax.swing.JComboBox<String> cbb_sx;
    private javax.swing.JButton doc;
    private javax.swing.JButton ghi;
    private javax.swing.JButton jButton4;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel10;
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
    private javax.swing.JLabel jaja;
    private javax.swing.JLabel jlb_bp;
    private javax.swing.JLabel jlb_cd;
    private javax.swing.JLabel jlb_cv;
    private javax.swing.JLabel jlb_hs;
    private javax.swing.JLabel jlb_luong;
    private javax.swing.JLabel jlb_luongcb;
    private javax.swing.JLabel jlb_ma;
    private javax.swing.JLabel jlb_ngay;
    private javax.swing.JLabel jlb_pc;
    private javax.swing.JLabel jlb_ten;
    private javax.swing.JTextField jtf_timkiem;
    private javax.swing.JTable table;
    // End of variables declaration//GEN-END:variables

}
