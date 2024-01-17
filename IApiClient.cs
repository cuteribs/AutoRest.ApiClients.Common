using System;
using System.Net.Http;

namespace AutoRest.ApiClients.Common;

public interface IApiClient
{
	Uri BaseUri { get; set; }
	HttpClient HttpClient { get; set; }
}
