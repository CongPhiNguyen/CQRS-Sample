using CQRS_Sample.RequestModels.CommandRequestModels;
using CQRS_Sample.ResponseModels.CommandResponseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_Sample.Interfaces.ICommandHandlers
{
	public interface IUploadCommandHandler
	{
		UploadResponseModel UploadOrder(UploadRequestModel requestModel);
	}
}