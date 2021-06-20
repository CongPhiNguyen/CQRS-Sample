using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_Sample.ResponseModels.QueryResponseModels
{
	public class SinhVien
	{
		public String MSSV { get; set; }
		public String HoTen { get; set; }
		public String NgaySinh { get; set; }

	}
	public class LoadResponseModel
	{
		// Các thông tin mình cần load ở đây
		List<SinhVien> sv { get; set;}
		public bool isSuccess { get; set; }
		// Này thì trả về là đc hay không
		public String error { get; set; }
	}
}
