//using DataModel;
//using System.Reflection;

//namespace DataAccessLayer
//{
//    public class TaiKhoanRepository : ITaiKhoanRepository
//    {
//        private IDatabaseHelper _dbHelper;
//        public TaiKhoanRepository(IDatabaseHelper dbHelper)
//        {
//            _dbHelper = dbHelper;
//        }
//        public bool Login(string taikhoan, string matkhau)
//        {
//            string msgError = "";
//            try
//            {
//                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_khach_create",
//                "@TenKH", model.TenKH,
//                "@GioiTinh", model.GioiTinh,
//                "@DiaChi", model.DiaChi,
//                "@SDT", model.SDT,
//                "@Email", model.Email);
//            }
//        }
//    }
//}
