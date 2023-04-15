using System;

namespace Veracity.ApiClients.Common
{
	public interface IApiClient
	{
		Uri BaseUri { get; set; }
	}
}
