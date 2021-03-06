﻿using System.Configuration;
using System.Net;
using Vivantio.Samples.JsonApi.Shared;

namespace Vivantio.Samples.JsonApi
{
	public abstract class BaseApi
	{
		static BaseApi()
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
		}

		private readonly ApiUtility _utility;

		protected ApiUtility ApiUtility
		{
			get { return _utility; }
		}

		protected BaseApi()
		{
			var url = ConfigurationManager.AppSettings["Vivantio.ApiUrl"];
			var user = ConfigurationManager.AppSettings["Vivantio.ApiUser"];
			var password = ConfigurationManager.AppSettings["Vivantio.ApiPassword"];
			_utility = new ApiUtility(url, user, password);
		}
	}
}