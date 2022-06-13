using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

//LENGOCHOA_01301061
namespace QuanLyTienNuoc
{
    class kenoicosodulieu
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BTLQuanLySinhVien.mdf;Integrated Security=True");
        public static SqlConnection conn;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
        public static void OpenConnection()
        {
            
                string strConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BTLQuanLySinhVien.mdf;Integrated Security=True";

                conn = new SqlConnection(strConnectionString);
                conn.Open();// mo ket noi
            
            
        }
        public static void DisConnection()
        {
            conn.Close();// dong ket noi
        }
        //Phương thức thực hiện câu truy vấn chọn, kết quả trả về của hàm là một DataTable
        public static DataTable getDataInTable(string sql)
        {
            cmd = new SqlCommand(sql, conn);//truy van
            da = new SqlDataAdapter(cmd);//van chuyen du lieu ve
            DataTable db = new DataTable();//tao 1 kho ao de luu tru du lieu
            da.Fill(db);//do du lieu vao kho
            return db;
        }
        //Phương thức thực hiện truy vấn thêm, xóa, sửa
        public static void ExecuteSQL(string sql)
        {
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        public static bool excuteSQL(string sql, SqlParameter[] _params) 
        {
            try
            {
                //string sqlTemp = "insert into HOADON (MaHD, MADH, MaKH,TenKH,MaLoai,Thang,ChiSoCu,ChiSoMoi,SoSD,DonGia,ThanhTien) VALUES ('a123', 'a', 'KH001','a','KD','a',1,2,3,4,5)";
                cmd = new SqlCommand(sql, conn);
                if (_params != null)
                    cmd.Parameters.AddRange(_params);
                return cmd.ExecuteNonQuery() > 0;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

            
        }


        
        public DataTable HienDL(string sql)
        {
            OpenConnection();

            SqlDataAdapter adap = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adap.Fill(dt);

            return dt;


        }
    }
}
