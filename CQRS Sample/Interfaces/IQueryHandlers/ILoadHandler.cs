using CQRS_Sample.RequestModels.QueryRequestModels;
using CQRS_Sample.ResponseModels.QueryResponseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_Sample.Interfaces.IQueryHandlers
{
	public interface ILoadHandler
	{
		LoadResponseModel LoadOrder(LoadRequestModel requestModel);
	}
}
