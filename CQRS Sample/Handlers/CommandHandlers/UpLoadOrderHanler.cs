using CQRS_Sample.Interfaces.ICommandHandlers;
using CQRS_Sample.RequestModels.CommandRequestModels;
using CQRS_Sample.ResponseModels.CommandResponseModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace CQRS_Sample.Handlers.CommandHandler
{
	public class UpLoadOrderHanler:IUploadCommandHandler
	{
		public UploadResponseModel UploadOrder(UploadRequestModel requestModel)
		{
			UploadResponseModel result = new UploadResponseModel();
            int rowsAffected = 0 ;
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "nguyencongphi.database.windows.net";
                builder.UserID = "nguyencongphi";
                builder.Password = "kratos123@";
                builder.InitialCatalog = "QLSV";

                SqlConnection connection = new SqlConnection(builder.ConnectionString);
                connection.Open();
                string query = "set dateformat DMY insert into SINHVIEN(MSSV,HoTen,NgaySinh) values (@MSSV, @HoTen, @NgaySinh)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add(new SqlParameter("@MSSV", requestModel.MSSV));
                cmd.Parameters.Add(new SqlParameter("@HoTen", requestModel.HoTen));
                cmd.Parameters.Add(new SqlParameter("@NgaySinh", requestModel.NgaySinh));

                rowsAffected = cmd.ExecuteNonQuery();

                connection.Close();
                result.isSuccess = true;
                result.rowsAffected = rowsAffected;
                result.error = "";
            }
            catch (SqlException e)
            {
                //MessageBox.Show(e.ToString());
                result.isSuccess = false;
                result.rowsAffected = 0;
                result.error = e.ToString();
            }
            return result;
		}
	}
}
