using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_Sample.RequestModels.QueryRequestModels
{
	public class LoadRequestModel
	{
		public Guid OrderId { get; set; }
	}
}
