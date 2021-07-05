using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BTLW_BuiQuocAnh.Model;

namespace BTLW_BuiQuocAnh.Controller
{
    class BALController
    {
        DAL dal = new DAL();
        //Query for Quanlynhanvien
        public DataTable getAllNhanvien()
        {
            String sql = "select * from NguoiDung where loaitk = 0";
            DataTable table = new DataTable();
            table = dal.getTable(sql);
            return table;
        }
        public List<NguoiDung> getListNhanvien()
        {
            List<NguoiDung> tempList = new List<NguoiDung>();
            SqlConnection conn = dal.getConnection();
            String sql = "select * from nguoidung where loaitk = 0";
            SqlCommand cmd = new SqlCommand(sql, conn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                TaiKhoan tk = new TaiKhoan(
                        reader["username"].ToString(),
                        reader["passwordd"].ToString(),
                        Convert.ToInt32(reader["loaitk"])
                    );
                tempList.Add(new NguoiDung(
                    reader["manguoidung"].ToString(),
                    reader["hoten"].ToString(),
                    reader["gioitinh"].ToString(),
                    Convert.ToDateTime( reader["ngaysinh"]),
                    reader["email"].ToString(),
                    tk,
                    reader["dienthoai"].ToString(),
                    reader["diachi"].ToString()
                    ));
            }
            return tempList;
        }
        public void insertNhanVien(String manhanvien, String hoten, String gioitinh, String email, String username, String passWord, String ngaysinh, String dienthoai, String diachi)
        {
            String sql = "insert into NguoiDung values('" + manhanvien + "', N'" + hoten + "', '" + gioitinh + "', '" + email + "', '" + username + "', '" + passWord + "', 0, '" + ngaysinh + "', '" + dienthoai + "', '" + diachi + "')";
            dal.execNonQuery(sql);
        }
        public void updateNhanVien(String manhanvien, String hoten, String gioitinh, String email, String username, String passWord, String ngaysinh, String dienthoai, String diachi)
        {
            String sql = " update nguoiDung set hoten=N'" + hoten + "', gioitinh='" + gioitinh + "', email='" + email + "', username='" + username + "', passwordd='" + passWord + "', ngaysinh='" + ngaysinh + "', dienthoai='" + dienthoai + "', diachi=N'" + diachi + "' where manguoidung='" + manhanvien + "'";
            dal.execNonQuery(sql);
        }
        public void deleteNhanVien(String manhanvien)
        {
            String sql = "delete from NguoiDung where manguoidung='" + manhanvien + "'";
            dal.execNonQuery(sql);
        }
        public DataTable findByManv(String manv)
        {
            String sql = "select * from nguoiDUng where manguoidung = '" + manv + "'";
            DataTable table = new DataTable();
            table = dal.getTable(sql);
            return table;
        }
        public DataTable findByHoten(String hoten)
        {
            String sql = "select * from Nguoidung where hoten Like N'%"+hoten+"%'";
            DataTable table = new DataTable();
            table = dal.getTable(sql);
            return table;
        }
        public DataTable findByDiaChi(String diachi)
        {
            String sql = "select * from nguoidung where diachi Like N'%" + diachi + "%'";
            DataTable table = new DataTable();
            table = dal.getTable(sql);
            return table;
        }

        //End

        //Query for QuanlyKho
        public DataTable getAllInQuanlykho()
        {
            String sql = "select makho, tennguyenlieu, tenncc, dongia, soluong from quanlykho inner join nguyenlieu on quanlykho.manguyenlieu=nguyenlieu.manguyenlieu inner join nhacungcap on quanlykho.mancc = nhacungcap.mancc";
            DataTable table = new DataTable();
            table = dal.getTable(sql);
            return table;
        }

        public DataTable getNameofNL()
        {
            String sql = "select manguyenlieu, tennguyenlieu from nguyenlieu ";
            DataTable table = new DataTable();
            table = dal.getTable(sql);
            return table;
        }
        public DataTable getNameOfNCC()
        {
            String sql = "select mancc, tenncc from nhacungcap";
            DataTable table = new DataTable();
            table = dal.getTable(sql);
            return table;
        }
        public void insertintoQuanlykho(String makho, String manguyenlieu, String mancc, int dongia, int soluong)
        {
            String sql = "insert into quanlykho values('" + makho + "', '" + manguyenlieu + "', '" + mancc + "', '" + dongia + "', '" + soluong + "') ";
            dal.execNonQuery(sql);
        }
        public void updateQuanlykho(String makho, String manguyenlieu, String mancc, int dongia, int soluong)
        {
            String sql = "update quanlykho set manguyenlieu='" + manguyenlieu + "', mancc='" + mancc + "', dongia='" + dongia + "', soluong='" + soluong + "' where makho='"+makho+"'";
            dal.execNonQuery(sql);
        }
        public void deleteQuanlykho(String makho)
        {
            String sql = "delete from quanlykho where makho = '" + makho + "'";
            dal.execNonQuery(sql);
        }
        public DataTable findBytenNguyenlieu(String tennguyenlieu)
        {
            String sql = "select makho, tennguyenlieu, tenncc, dongia, soluong from quanlykho inner join nguyenlieu on quanlykho.manguyenlieu=nguyenlieu.manguyenlieu inner join nhacungcap on quanlykho.mancc = nhacungcap.mancc where tennguyenlieu like N'%"+tennguyenlieu+"%'";
            DataTable table = new DataTable();
            table = dal.getTable(sql);
            return table;
        }
        public DataTable findBytenNhacungcap(String tennhacungcap)
        {
            String sql = "select makho, tennguyenlieu, tenncc, dongia, soluong from quanlykho inner join nguyenlieu on quanlykho.manguyenlieu = nguyenlieu.manguyenlieu inner join nhacungcap on quanlykho.mancc = nhacungcap.mancc where tenncc like N'%"+tennhacungcap+"%'";
            DataTable table = new DataTable();
            table = dal.getTable(sql);
            return table;
        }
        //Querry for quanlynhacungcap
        public DataTable getNCC()
        {
            String sql = "select * from nhacungcap";
            DataTable table = new DataTable();
            table = dal.getTable(sql);
            return table;
        }
        public void insertintoNCC(String mancc, String tenncc, String diachincc)
        {
            String sql = "insert into nhacungcap values('" + mancc + "', N'" + tenncc + "', N'" + diachincc + "')";
            dal.execNonQuery(sql);
        }
        public void updateItemInNCC(String mancc, String tenncc, String diachincc)
        {
            String sql = "update nhacungcap set tenncc=N'" + tenncc + "', diachi=N'" + diachincc + "' where mancc='"+mancc+"'";
            dal.execNonQuery(sql);
        }
        public void deleteIteminNCC(String mancc)
        {
            String sql = "delete from nhacungcap where mancc='" + mancc + "'";
            dal.execNonQuery(sql);
        }

        //query for quanlynguyenlieu
        public DataTable getNL()
        {
            String sql = "select * from Nguyenlieu";
            DataTable table = new DataTable();
            table = dal.getTable(sql);
            return table;
        }
        public void insertIteminNL(String manl, String tennl, String mota)
        {
            String sql = "insert into nguyenlieu values('" + manl + "', N'" + tennl + "', N'" + mota + "')";
            dal.execNonQuery(sql);
        }
        public void updateIteminNL(String manl, String tennl, String mota)
        {
            String sql = "update nguyenlieu set tennguyenlieu=N'" + tennl + "', mota=N'" + mota + "' where manguyenlieu = '"+manl+"'";
            dal.execNonQuery(sql);
        }
        public void deleteIteminNL(String manl)
        {
            String sql = "delete from nguyenlieu where manguyenlieu='" + manl + "'";
            dal.execNonQuery(sql);
        }
        //Query for quanlythucdon

        public DataTable getThucDon()
        {
            String sql = "select maqlthucdon, tenThucDon, tensp from quanlythucdon inner join sanpham on quanlythucdon.masp = sanpham.masp  inner join Thucdon on quanlythucdon.mathucdon=thucdon.mathucdon";
            DataTable table = new DataTable();
            table = dal.getTable(sql);
            return table;
        }

        public DataTable getNameOfTenthucdon()
        {
            String sql = "select * from ThucDon";
            DataTable table = new DataTable();
            table = dal.getTable(sql);
            return table;
        }
        public DataTable getNameOfSanpham()
        {
            String sql = "select masp, tensp from sanpham";
            DataTable table = new DataTable();
            table = dal.getTable(sql);
            return table;
        }
        public void insertIntoQuanlythucdon(String maqlThucdon, String masp, String maThucdon)
        {
            String sql = "insert into Quanlythucdon values('" + maqlThucdon + "', '" + masp + "', '" + maThucdon + "')";
            dal.execNonQuery(sql);
        }
        public void updateQuanlythucdon(String maqlThucdon, String masp, String mathucdon)
        {
            String sql = "update Quanlythucdon set masp='" + masp + "', mathucdon='" + mathucdon + "' where maqlthucdon='"+ maqlThucdon + "'";
            dal.execNonQuery(sql);
        }
        public void deleteQuanlythucdon(String maqlThucdon)
        {
            String sql = "delete from quanlythucdon where maqlthucdon ='" + maqlThucdon + "'";
            dal.execNonQuery(sql);
        }
        public DataTable findByMaThucDon(String mathucdon)
        {
            String sql = "select maqlthucdon, tenThucDon, tensp from quanlythucdon inner join sanpham on quanlythucdon.masp = sanpham.masp  inner join Thucdon on quanlythucdon.mathucdon=thucdon.mathucdon where quanlythucdon.mathucdon = '" + mathucdon + "'";
            DataTable table = new DataTable();
            table = dal.getTable(sql);
            return table;
        }


        //Query for quanly san pham
        public DataTable getListSanpham()
        {
            String sql = "select * from sanpham";
            DataTable table = new DataTable();
            table = dal.getTable(sql);
            return table;
        }
        public void insertIntoSanpham(String masp, String tensp, String mota, float giaban, String loai)
        {
            String sql = "insert into sanpham(masp, tensp, mota, giaban, loai) values ('" + masp + "', N'" + tensp + "', N'" + mota + "', '" + giaban + "', N'" + loai + "')";
            dal.execNonQuery(sql);
        }
        public void updateSanPham(String masp, String tensp, String mota, float giaban, String loai)
        {
            String sql = "update sanpham set tensp=N'" + tensp + "', mota=N'" + mota + "', giaban='" + giaban + "', loai='" + loai + "' where masp = '"+masp+"'";
            dal.execNonQuery(sql);
        }
        public void deleteSanpham(String masp)
        {
            String sql = "delete from sanpham where masp='" + masp + "'";
            dal.execNonQuery(sql);
        }
        public DataTable findbyNameOfSanpham(String tensp)
        {
            String sql = "select * from sanpham where tensp like '%" + tensp + "%'";
            DataTable table = new DataTable();
            table = dal.getTable(sql);
            return table;
        }

        //Querry for quanly thucdon
        public DataTable getListLoaiThucdon()
        {
            String sql = "select *from thucdon";
            DataTable table = new DataTable();
            table = dal.getTable(sql);
            return table;
        }
        public void insertIntoQuanlyloaithucdon(String mathucdon, String tenthucdon)
        {
            String sql = "insert into thucdon values('" + mathucdon.ToUpper() + "', N'" + tenthucdon + "')";
            dal.execNonQuery(sql);
        }
        public void updateQuanlyloaithucdon(String mathucdon, String tenthucdon)
        {
            String sql = "update thucdon set tenthucdon=N'" + tenthucdon + "' where mathucdon = N'" + mathucdon + "'";
            dal.execNonQuery(sql);
        }
        public void deleteQuanlyloaithucdon(String mathucdon)
        {
            String sql = "delete from thucdon where mathucdon ='" + mathucdon + "'";
            dal.execNonQuery(sql);
        }

        //Query for Dinhluong nguyen lieu
        public DataTable getListDinhluongnguyenlieu()
        {
            String sql = "select madinhluong, tensp, tennguyenlieu, dinhluong from Dinhluongnguyenlieu inner join sanpham on Dinhluongnguyenlieu.masp = sanpham.masp inner join NguyenLieu on Dinhluongnguyenlieu.manguyenlieu = nguyenlieu.manguyenlieu";
            DataTable table = new DataTable();
            table = dal.getTable(sql);
            return table;
        }


        
        public void insertIntoDinhluong(String madinhluong, String masp, String manl, String dinhluong)
        {
            string sql = "insert into Dinhluongnguyenlieu values('" + madinhluong.ToUpper() + "', '" + masp + "', '" + manl + "', N'" + dinhluong + "')";
            dal.execNonQuery(sql);
        }
        public void updateDinhluong(String madinhluong, String masp, String manl, String dinhluong)
        {
            String sql = "update Dinhluongnguyenlieu set masp='" + masp + "', manguyenlieu='" + manl + "', dinhluong=N'" + dinhluong + "' where madinhluong = '"+madinhluong+"'";
            dal.execNonQuery(sql);
        }
        public void deleteDinhluong(String madinhluong)
        {
            String sql = "delete from Dinhluongnguyenlieu where madinhluong = '" + madinhluong + "'";
            dal.execNonQuery(sql);
        }

        //Quẻy for Quanlyban
        public DataTable getListBan()
        {
            String sql = "select * from ban";
            DataTable table = new DataTable();
            table = dal.getTable(sql);
            return table;
        }
        public void insertintoBan(String maban, String tenban, String vitri, String tinhtrang)
        {
            String sql = "insert into ban values('" + maban.ToUpper() + "', N'" + tenban + "', N'" + vitri + "', '" + tinhtrang + "')";
            dal.execNonQuery(sql);
        }
        public void updateBan(String maban, String tenban, String vitri, String tinhtrang)
        {
            String sql = "update ban set tenban=N'" + tenban + "', vitri=N'" + vitri + "', tinhtrang='" + tinhtrang + "' where maban='"+maban+"'";
            dal.execNonQuery(sql);
        }
        public void deleteBan(String maban)
        {
            String sql = "delete from ban where maban='" + maban + "'";
            dal.execNonQuery(sql);
        }

        //Query for Quan ly hoadon
        public DataTable getListHoadon()
        {
            String sql = "select mahd, hoten, tenban, ngaylap, trangthaihd from hoadon inner join nguoidung on hoadon.manguoidung = nguoidung.manguoidung inner join ban on hoadon.maban = ban.maban";

            DataTable table = new DataTable();
            table = dal.getTable(sql);
            return table;
        }
        public DataTable getListHoaDon1()
        {
            String sql = "select mahd, manguoidung, maban, ngaylap, trangthaihd from hoadon";
            DataTable table = new DataTable();
            table = dal.getTable(sql);
            return table;
        }
        public DataTable getNameOfNv()
        {
            String sql = "select manguoidung, hoten from nguoidung where loaitk=0";
            DataTable table = new DataTable();
            table = dal.getTable(sql);
            return table;
        }
        public DataTable getNameOfBan()
        {
            String sql = "select maban, tenban from ban";
            DataTable table = new DataTable();
            table = dal.getTable(sql);
            return table;
        }
        public void insertIntoHoadon(String manguoidung, String maban, String ngaylap, String tinhtrang)
        {
            String sql = "insert into hoadon values('" + manguoidung + "', '" + maban + "', '" + ngaylap + "', '" + tinhtrang + "')";
            dal.execNonQuery(sql);
        }
        public void updateHoadon(String mahoadon, String manguoidung, String maban, String ngaylap, String tinhtrang)
        {
            String sql = "update hoadon set  manguoidung='" + manguoidung + "', maban='"+maban+"', ngaylap='" + ngaylap + "', trangthaihd='" + tinhtrang + "' where mahd='" + mahoadon + "'";
            dal.execNonQuery(sql);
        }
        public void deleteHoaDon(String mahd)
        {
            String sql = "delete from hoadon where mahd='" + mahd + "'";
            dal.execNonQuery(sql);
        }
        
        //Query for Quan ly chi tiet hoa don
        public DataTable getlistChitietHoadon()
        {
            String sql = "select ChiTietHoaDon.maCTHD, ChiTietHoaDon.mahd, tensp, soluong, SanPham.giaban, soluong*giaban[Tổng tiền] from ChiTietHoaDon inner join hoadon on ChiTietHoaDon.mahd=HoaDon.mahd inner join SanPham on ChiTietHoaDon.masp = SanPham.masp";

            DataTable table = new DataTable();
            table = dal.getTable(sql);
            return table;
        }
        public DataTable getNameofMahd()
        {
            String sql = "select mahd from hoadon";
            DataTable table = new DataTable();
            table = dal.getTable(sql);
            return table;

        }
        public void insertIntoChitiethoadon( String mahd, String masp, int soluong)
        {
            String sql = "insert into chitiethoadon values('" + mahd + "', '" + masp + "', '" + soluong + "')";
            dal.execNonQuery(sql);
        }
        public void updateChitiethoadon(String macthd, String mahd, String masp, int soluong)
        {
            String sql = "update chitiethoadon set masp='" + masp + "', soluong='" + soluong + "' where macthd='"+macthd+"' and mahd='"+mahd+"'";
            dal.execNonQuery(sql);
        }
        public void deleteChitiethoadon(String macthd)
        {
            String sql = "delete from chitiethoadon where macthd='" + macthd + "'";
            dal.execNonQuery(sql);
        }

        public List<ChiTietHoaDon> getChiTietHoaDon(String mahd)
        {
            List<ChiTietHoaDon> tempList = new List<ChiTietHoaDon>();
            SqlConnection conn = dal.getConnection();
            String sql = "select * from Chitiethoadon inner join hoadon on chitiethoadon.mahd = hoadon.mahd inner join nguoidung on hoadon.manguoidung = nguoidung.manguoidung inner join sanpham on chitiethoadon.masp = sanpham.masp inner join ban on hoadon.maban = ban.maban where chitiethoadon.mahd='"+mahd+"'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                TaiKhoan tk = new TaiKhoan(
                    reader["username"].ToString(),
                    reader["passwordd"].ToString(),
                    Convert.ToInt32(reader["loaitk"])
                    );
                Ban ban = new Ban(
                    reader["maban"].ToString(),
                    reader["tenban"].ToString(),
                    reader["vitri"].ToString(),
                    Convert.ToInt32(reader["tinhtrang"])
                    );
                NguoiDung nd = new NguoiDung(
                    reader["manguoidung"].ToString(),
                    reader["hoten"].ToString(),
                    reader["gioitinh"].ToString(),
                    Convert.ToDateTime(reader["ngaysinh"]),
                    reader["email"].ToString(),
                    tk,
                    reader["dienthoai"].ToString(),
                    reader["diachi"].ToString()
                    );
                HoaDon hd = new HoaDon(
                    reader["mahd"].ToString(),
                    reader["manguoidung"].ToString(),
                    reader["maban"].ToString(),
                    nd,
                    ban,
                    Convert.ToDateTime(reader["ngaylap"]),
                    Convert.ToInt32(reader["trangthaihd"])
                    );
                SanPham sp = new SanPham(
                    reader["masp"].ToString(),
                    reader["tensp"].ToString(),
                    reader["mota"].ToString(),
                    Convert.ToInt32(reader["giaban"]),
                    reader["loai"].ToString(),
                    reader["anh"].ToString()
                    );
                tempList.Add( new ChiTietHoaDon(
                    reader["macthd"].ToString(),
                    hd,
                    sp,
                    Convert.ToInt32(reader["soluong"])
                    ));
            }
            return tempList;
        }

        public DataTable getListChitiethoadonByMahd(String mahd)
        {
            String sql = "select macthd, mahd, tensp, soluong, giaban from chitiethoadon inner join sanpham on chitiethoadon.masp = sanpham.masp where mahd='" + mahd + "'";
            DataTable table = new DataTable();
            table = dal.getTable(sql);
            return table;
        }

        //Query for FrmNhanvien
        public SqlDataReader getDataForDatmon(String mahd)
        {
            
            using(SqlConnection conn = dal.getConnection())
            {

                String sql = "select chitiethoadon.mahd, maban, tensp, soluong, dongia, ngaylap, trangthaihd from chitiethoadon inner join hoadon on chitiethoadon.mahd = hoadon.mahd inner join sanpham on chitiethoadon.masp=sanpham.masp where chitiethoadon.mahd='" + mahd + "'";

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
        }
        public DataTable getListDatmon(String mahd)
        {
            String sql = "select ChiTietHoaDon.mahd, tensp, maban, ngaylap, giaban, soluong, trangthaihd from ChiTietHoaDon inner join hoadon on ChiTietHoaDon.mahd = hoadon.mahd inner join sanpham on ChiTietHoaDon.masp = sanpham.masp where ChiTietHoaDon.mahd = '" + mahd + "'";

            DataTable table = new DataTable();
            table = dal.getTable(sql);
            return table;
        }

        public DataTable findByMaban(String maban)
        {
            String sql = "select ChiTietHoaDon.mahd, tensp, maban, ngaylap, giaban, soluong, trangthaihd from ChiTietHoaDon inner join hoadon on ChiTietHoaDon.mahd = hoadon.mahd inner join sanpham on ChiTietHoaDon.masp = sanpham.masp where hoadon.maban = '" + maban + "' and trangthaihd = 0";

            DataTable table = new DataTable();
            table = dal.getTable(sql);
            return table;
        }
        public String getLastMahd()
        {
            String mahd;
            using (SqlConnection conn = dal.getConnection())
            {
                String sql = "SELECT top 1 mahd FROM hoadon order by mahd DESC";
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                mahd = reader["mahd"].ToString();
                return mahd;
            }
        }

        public List<HoaDon> getListTypeHoaDon()
        {
            List<HoaDon> tempList = new List<HoaDon>();
            using (SqlConnection conn = dal.getConnection())
            {
                if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                String sql = "select * from hoadon";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tempList.Add(new HoaDon(
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        null, null,
                        reader.GetDateTime(4),
                        Convert.ToInt32(reader.GetBoolean(5))
                        ));
                }
            }

                return tempList;
        }

        public void ThanhToan(String mahd)
        {
            String sql = "update hoadon set trangthaihd=1 where mahd='" + mahd + "'";
            dal.execNonQuery(sql);
        }

        public List<NguoiDung> listNguoiDungForDangNhap()
        {
            List<NguoiDung> tempList = new List<NguoiDung>();
            using (SqlConnection conn = dal.getConnection())
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                String sql = "select * from nguoidung";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TaiKhoan tk = new TaiKhoan(
                       reader["username"].ToString(),
                       reader["passwordd"].ToString(),
                       Convert.ToInt32(reader["loaitk"])
                   );
                    tempList.Add(new NguoiDung(
                          reader["manguoidung"].ToString(),
                        reader["hoten"].ToString(),
                        reader["gioitinh"].ToString(),
                        Convert.ToDateTime(reader["ngaysinh"]),
                        reader["email"].ToString(),
                        tk,
                        reader["dienthoai"].ToString(),
                        reader["diachi"].ToString()
                        ));
                }
                return tempList;
            }
        }

        //query for Thong ke

        //public List<ChiTietHoaDon> getListChiTietHoaDon()
        //{
        //    List<ChiTietHoaDon> tempList = new List<ChiTietHoaDon>();
        //    SqlConnection conn = dal.getConnection();
        //    String sql = "select * from Chitiethoadon inner join hoadon on chitiethoadon.mahd = hoadon.mahd inner join nguoidung on hoadon.manguoidung = nguoidung.manguoidung inner join sanpham on chitiethoadon.masp = sanpham.masp inner join ban on hoadon.maban = ban.maban";
        //    SqlCommand cmd = new SqlCommand(sql, conn);
        //    if (conn.State == ConnectionState.Closed)
        //        conn.Open();
        //    SqlDataReader reader = cmd.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        TaiKhoan tk = new TaiKhoan(
        //            reader["username"].ToString(),
        //            reader["passwordd"].ToString(),
        //            Convert.ToInt32(reader["loaitk"])
        //            );
        //        Ban ban = new Ban(
        //            reader["maban"].ToString(),
        //            reader["tenban"].ToString(),
        //            reader["vitri"].ToString(),
        //            Convert.ToInt32(reader["tinhtrang"])
        //            );
        //        NguoiDung nd = new NguoiDung(
        //            reader["manguoidung"].ToString(),
        //            reader["hoten"].ToString(),
        //            reader["gioitinh"].ToString(),
        //            Convert.ToDateTime(reader["ngaysinh"]),
        //            reader["email"].ToString(),
        //            tk,
        //            reader["dienthoai"].ToString(),
        //            reader["diachi"].ToString()
        //            );
        //        HoaDon hd = new HoaDon(
        //            reader["mahd"].ToString(),
        //            reader["manguoidung"].ToString(),
        //            reader["maban"].ToString(),
        //            nd,
        //            ban,
        //            Convert.ToDateTime(reader["ngaylap"]),
        //            Convert.ToInt32(reader["trangthaihd"])
        //            );
        //        SanPham sp = new SanPham(
        //            reader["masp"].ToString(),
        //            reader["tensp"].ToString(),
        //            reader["mota"].ToString(),
        //            Convert.ToInt32(reader["giaban"]),
        //            reader["loai"].ToString(),
        //            reader["anh"].ToString()
        //            );
        //        tempList.Add(new ChiTietHoaDon(
        //            reader["macthd"].ToString(),
        //            hd,
        //            sp,
        //            Convert.ToInt32(reader["soluong"])
        //            ));
        //    }
        //    return tempList;
        //}

        public DataTable TKByYear(String nam)
        {
            String sql = "select Sum(Chitiethoadon.soluong*sanpham.giaban)[tongtien] from Chitiethoadon inner join hoadon on chitiethoadon.mahd = hoadon.mahd inner join nguoidung on hoadon.manguoidung = nguoidung.manguoidung inner join sanpham on chitiethoadon.masp = sanpham.masp inner join ban on hoadon.maban = ban.maban where year(hoadon.ngaylap) = '"+nam+"'";
            DataTable table = new DataTable();
            table = dal.getTable(sql);
            return table;
        }
        public DataTable TKByMonth_Year(String monthh, String yearr)
        {
            String sql = "select Sum(Chitiethoadon.soluong*sanpham.giaban)[tongtien] from Chitiethoadon inner join hoadon on chitiethoadon.mahd = hoadon.mahd inner join nguoidung on hoadon.manguoidung = nguoidung.manguoidung inner join sanpham on chitiethoadon.masp = sanpham.masp inner join ban on hoadon.maban = ban.maban where year(hoadon.ngaylap) = '" + yearr + "' and month(hoadon.ngaylap) = '"+monthh+"'";
            DataTable table = new DataTable();
            table = dal.getTable(sql);
            return table;
        }
        public DataTable TKByDay_Month_Year(String dayy, String monthh, String yearr)
        {
            String sql = "select Sum(Chitiethoadon.soluong*sanpham.giaban)[tongtien] from Chitiethoadon inner join hoadon on chitiethoadon.mahd = hoadon.mahd inner join nguoidung on hoadon.manguoidung = nguoidung.manguoidung inner join sanpham on chitiethoadon.masp = sanpham.masp inner join ban on hoadon.maban = ban.maban where year(hoadon.ngaylap) = '" + yearr + "' and month(hoadon.ngaylap) = '" + monthh + "' and day(hoadon.ngaylap) = '"+dayy+"'";
            DataTable table = new DataTable();
            table = dal.getTable(sql);
            return table;
        }

        //chi
        public DataTable TKChi()
        {
            String sql = "select Sum(dongia*soluong)[tongchi] from quanlykho";
            DataTable table = new DataTable();
            table = dal.getTable(sql);
            return table;
        }
    }
}
