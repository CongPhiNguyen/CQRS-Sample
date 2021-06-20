using CQRS_Sample.Interfaces.ICommandHandlers;
using CQRS_Sample.Interfaces.IQueryHandlers;
using CQRS_Sample.RequestModels.CommandRequestModels;
using CQRS_Sample.RequestModels.QueryRequestModels;
using CQRS_Sample.ResponseModels.CommandResponseModels;
using CQRS_Sample.ResponseModels.QueryResponseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_Sample.Controllers
{
	public class Load_UpLoadController 
	{
		private readonly ILoadHandler _loadHandler;
		private readonly IUploadCommandHandler _uploadHandler;

		public Load_UpLoadController(ILoadHandler loadHandler, IUploadCommandHandler uploadCommandHandler)
		{
			_loadHandler = loadHandler;
			_uploadHandler = uploadCommandHandler;
		}
		public UploadResponseModel UploadOder(UploadRequestModel requestModel)
		{
			UploadResponseModel k = _uploadHandler.UploadOrder(requestModel);
			return k;
		}
		public LoadResponseModel LoadOder(LoadRequestModel requestModel)
		{
			LoadResponseModel k = _loadHandler.LoadOrder(requestModel);
			return k;
		}

	}
}
