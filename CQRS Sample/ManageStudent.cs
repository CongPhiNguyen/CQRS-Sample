using CQRS_Sample.Controllers;
using CQRS_Sample.Handlers;
using CQRS_Sample.Handlers.CommandHandler;
using CQRS_Sample.Interfaces.ICommandHandlers;
using CQRS_Sample.Interfaces.IQueryHandlers;
using CQRS_Sample.RequestModels.CommandRequestModels;
using CQRS_Sample.RequestModels.QueryRequestModels;
using CQRS_Sample.ResponseModels.CommandResponseModels;
using CQRS_Sample.ResponseModels.QueryResponseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CQRS_Sample
{
	public partial class ManageStudent : Form
	{
		Load_UpLoadController _controller;
		ILoadHandler loadHandler;
		IUploadCommandHandler uploadCommandHandler;
		public ManageStudent()
		{
			InitializeComponent();
			loadHandler = new LoadOrderHandler();
			uploadCommandHandler = new UpLoadOrderHanler();
			_controller = new Load_UpLoadController(loadHandler, uploadCommandHandler);
			DataTable dt = new DataTable();
			dt.Columns.Add("STT", typeof(int));
			dt.Columns.Add("MSSV", typeof(string));
			dt.Columns.Add("Họ Tên", typeof(string));
			dt.Columns.Add("Ngày Sinh", typeof(string));
			this.dataGridView1.DataSource = dt;

		}
		bool checkValidInfor()
		{
			if (dtNgaySinh.Value == null || tbName.Text.Length == 0 || tbMSSV.Text.Length == 0)
			{
				MessageBox.Show("Thông tin không chính xác hoặc bị thiếu");
				return false;
			}
			else return true;
		}
		private void btAdd_Click(object sender, EventArgs e)
		{
			bool k = checkValidInfor();
			if (k == false) return;

			string ngaySinh = dtNgaySinh.Value.ToString().Substring(0, 10);

			UploadRequestModel uploadRequest = new UploadRequestModel();
			uploadRequest.NgaySinh = ngaySinh;
			uploadRequest.MSSV = tbMSSV.Text;
			uploadRequest.HoTen = tbName.Text;

			UploadResponseModel result =_controller.UploadOder(uploadRequest);
			String message = "";
			if (result.isSuccess == true)
			{
				message += "Successed\n";
				message += "Rows affected: " + result.rowsAffected;
			}
			else
			{
				message += "Failed\n";
				message += "Rows affected: " + result.rowsAffected;
				message += "Error: " + result.error;
			}
			

			MessageBox.Show(message, "Message");
		}

		private void btFind_Click(object sender, EventArgs e)
		{
			LoadRequestModel loadRequest = new LoadRequestModel();
			loadRequest.MSSV = tbMS.Text;

			LoadResponseModel result = _controller.LoadOder(loadRequest);
			String message = "";
			if (result.isSuccess == true)
			{
				message += "Successed\n";
				//load những SV vào datagridview
				DataTable dt = new DataTable();
				dt.Columns.Add("STT", typeof(int));
				dt.Columns.Add("MSSV", typeof(string));
				dt.Columns.Add("Họ Tên", typeof(string));
				dt.Columns.Add("Ngày Sinh", typeof(string));
				for (int i=0;i<result.sinhViens.Count;i++)
				{
					dt.Rows.Add(i + 1, result.sinhViens[i].MSSV, result.sinhViens[i].HoTen, result.sinhViens[i].NgaySinh.Substring(0,10));
				}
				this.dataGridView1.DataSource = dt;
			}
			else
			{
				message += "Failed\n";
				message += "Error: " + result.error;
			}
			MessageBox.Show(message, "Message");
		}
	}
}
