using CQRS_Sample.Interfaces.IQueryHandlers;
using CQRS_Sample.RequestModels.QueryRequestModels;
using CQRS_Sample.ResponseModels.QueryResponseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_Sample.Handlers
{
	public class LoadOrderHandler: ILoadHandler
	{
		public LoadResponseModel LoadOrder(LoadRequestModel requestModel)
		{
			var result = new LoadResponseModel();
			//SQL here
			

			return result;
		}
	}
}
