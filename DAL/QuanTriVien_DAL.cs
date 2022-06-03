//using QuanLyShopGiayDep.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class QuanTriVien_DAL
    {
        private QuanTriVien_DAL() { }
        private static QuanTriVien_DAL _instance;
		public static QuanTriVien_DAL Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new QuanTriVien_DAL();
				}
				return _instance;
			}
		}
		public bool Login(string tenDangNhap, string matKhau)
		{
			string query = "EXEC sp_select_DangNhap @TenDangNhap , @MatKhau";
			object[] param = new object[] { tenDangNhap, matKhau };
			DataTable result = DataProvider.Instance.ExecuteQuery(query, param);
			return result.Rows.Count > 0;
		}

		public QuanTriVien_DTO GetAccountByUserName(string username)
		{
			string query = "EXEC sp_select_Account_By_UserName @username";
			object[] param = new object[] { username };
			DataTable data = DataProvider.Instance.ExecuteQuery(query, param);

			foreach (DataRow row in data.Rows)
			{
				return new QuanTriVien_DTO(row);
			}

			return null;
		}
		public List<QuanTriVien_DTO> GetListAccount()
		{
			string query = "EXEC sp_select_GetAccount";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			List<QuanTriVien_DTO> dsQuanTriVien = new List<QuanTriVien_DTO>();
			foreach (DataRow row in data.Rows)
			{
				QuanTriVien_DTO quantrivien = new QuanTriVien_DTO(row);
				dsQuanTriVien.Add(quantrivien);
			}

			return dsQuanTriVien;
		}

		public bool ThemTaiKhoan(int ID_KTK, string tenDangNhap, string matKhau)
		{
			string query = "EXEC sp_insert_QuanTriVien @ID_KTK , @TenDangNhap , @MatKhau";
			object[] param = new object[] { ID_KTK, tenDangNhap, matKhau };
			int rows = DataProvider.Instance.ExecuteNonQuery(query, param);

			if (rows > 0)
			{
				return true;
			}

			return false;
		}

		public bool XoaTaiKhoan(int id_qtv)
		{
			string query = "EXEC sp_delete_QuanTriVien @id_qtv";
			object[] param = new object[] { id_qtv };
			int rows = DataProvider.Instance.ExecuteNonQuery(query, param);

			if (rows > 0)
				return true;

			return false;

		}
	}
}
