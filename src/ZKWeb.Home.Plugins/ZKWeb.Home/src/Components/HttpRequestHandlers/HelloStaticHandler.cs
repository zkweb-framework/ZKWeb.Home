using ZKWeb.Storage;
using ZKWeb.Web;
using ZKWeb.Web.ActionResults;
using ZKWebStandard.Extensions;
using ZKWebStandard.Ioc;
using ZKWebStandard.Utils;
using ZKWebStandard.Web;

namespace ZKWeb.Home.Plugins.ZKWeb.Home.src.Components.HttpRequestHandlers {
	/// <summary>
	/// Static file handler
	/// </summary>
	[ExportMany]
	public class HelloStaticHandler : IHttpRequestHandler {
		public const string Prefix = "/static/";

		public void OnRequest() {
			var context = HttpManager.CurrentContext;
			var path = context.Request.Path;
			if (path.StartsWith(Prefix)) {
				var fileStorage = Application.Ioc.Resolve<IFileStorage>();
				var subPath = HttpUtils.UrlDecode(path.Substring(Prefix.Length));
				var fileEntry = fileStorage.GetResourceFile("static", subPath);
				if (fileEntry.Exists) {
					var ifModifiedSince = context.Request.GetIfModifiedSince();
					new FileEntryResult(fileEntry, ifModifiedSince).WriteResponse(context.Response);
					context.Response.End();
				}
			}
		}
	}
}
