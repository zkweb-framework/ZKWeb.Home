using ZKWeb.Web;
using ZKWeb.Web.ActionResults;
using ZKWebStandard.Ioc;

namespace ZKWeb.Home.Plugins.ZKWeb.Home.src.Controllers {
	/// <summary>
	/// Example controller
	/// </summary>
	[ExportMany]
	public class HelloController : IController {
		[Action("/")]
		public IActionResult Index() {
			return new TemplateResult("zkweb.home/index.html");
		}
	}
}
