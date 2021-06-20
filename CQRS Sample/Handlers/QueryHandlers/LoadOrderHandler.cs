using CQRS_Sample.Interfaces.IQueryHandlers;
using CQRS_Sample.RequestModels.QueryRequestModels;
using CQRS_Sample.ResponseModels.QueryResponseModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace CQRS_Sample.Handlers
{
	public class LoadOrderHandler: ILoadHandler
	{
		public LoadResponseModel LoadOrder(LoadRequestModel requestModel)
		{
            String mssvPattern = requestModel.MSSV;
			LoadResponseModel result = new LoadResponseModel();
            List<SinhVien> sinhViens = new List<SinhVien>();
            //SQL here
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "nguyencongphi.database.windows.net";
                builder.UserID = "nguyencongphi";
                builder.Password = "kratos123@";
                builder.InitialCatalog = "QLSV";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {

                    String sql = "SELECT MSSV, HoTen, NgaySinh FROM SINHVIEN where MSSV like '%"+ mssvPattern + "%'";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                SinhVien sinhVien = new SinhVien();
                                sinhVien.MSSV = reader[0].ToString();
                                sinhVien.HoTen = reader[1].ToString();
                                sinhVien.NgaySinh = reader[2].ToString();
                                sinhViens.Add(sinhVien);
                            }
                        }
                    }
                    
                }
                result.isSuccess = true;
                result.error = "";
                result.sinhViens = sinhViens;
            }
            catch (SqlException e)
            {
                result.isSuccess = false;
                result.error = e.ToString();
            }

            return result;
		}
	}
}
