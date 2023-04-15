using System;

namespace AutoRest.ApiClients.Common
{
	public interface IApiClient
	{
		Uri BaseUri { get; set; }
	}
}
