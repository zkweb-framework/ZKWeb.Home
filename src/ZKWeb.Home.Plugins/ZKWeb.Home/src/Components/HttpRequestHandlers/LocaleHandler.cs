using ZKWeb.Web;
using ZKWebStandard.Ioc;
using ZKWebStandard.Utils;

namespace ZKWeb.Home.Plugins.src.Components.HttpRequestHandlers {
	/// <summary>
	/// 设置语言和时区
	/// </summary>
	[ExportMany, SingletonReuse]
	public class LocaleHandler : IHttpRequestPreHandler {
		/// <summary>
		/// 处理请求
		/// </summary>
		public void OnRequest() {
			LocaleUtils.SetThreadLanguageAutomatic(true, "en-US");
		}
	}
}
