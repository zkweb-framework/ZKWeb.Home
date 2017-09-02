using ZKWeb.Plugin;
using ZKWeb.Templating.DynamicContents;
using ZKWebStandard.Ioc;

namespace ZKWeb.Home.Plugins.ZKWeb.Home.src {
	/// <summary>
	/// Plugin Entry Point
	/// </summary>
	[ExportMany, SingletonReuse]
	public class Plugin : IPlugin {
		/// <summary>
		/// Here will execute after plugin loaded
		/// </summary>
		public Plugin() {
			var areaManager = Application.Ioc.Resolve<TemplateAreaManager>();
			areaManager.GetArea("project_index_area").DefaultWidgets.Add("zkweb.home.widgets/project_index");
		}
	}
}
