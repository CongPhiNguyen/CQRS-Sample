using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_Sample.ResponseModels.CommandResponseModels
{
	public class UploadResponseModel
	{
		public bool isSuccess { get; set; }
		// Này thì trả về là đc hay không
		public int rowsAffected { get; set; }
		// Này thì trả về rows affected
		public String error { get; set; }
	}
}
