using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_Sample.RequestModels.CommandRequestModels
{
	public class UploadRequestModel
	{
		// Những nội dung cần upload lên ở đây
		public String MSSV { get; set; }
		public String HoTen {get; set; }
		public String NgaySinh { get; set; }
	}
}
