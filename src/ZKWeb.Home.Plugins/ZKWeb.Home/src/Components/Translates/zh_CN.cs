using System.Collections.Generic;
using ZKWeb.Localize;
using ZKWebStandard.Extensions;
using ZKWebStandard.Ioc;

namespace ZKWeb.Home.Plugins.ZKWeb.Demo.src.Components.Translates {
	/// <summary>
	/// 中文翻译
	/// </summary>
	[ExportMany, SingletonReuse]
	public class zh_CN : ITranslateProvider {
		private static HashSet<string> Codes = new HashSet<string>() { "zh-CN" };
		private static Dictionary<string, string> Translates = new Dictionary<string, string>()
		{
			{ "Demo", "演示" },
			{ "Edit or delete demo account is not allowed", "不允许编辑或删除演示用的账号" },
			{ "View on GITHUB", "在GITHUB上查看" },
			{ "A flexible web framework support .Net Framework and .Net Core",
				"灵活高效的网站开发框架，支持.Net Framework和.Net Core" },
			{ "Dynamic Plugins", "动态插件" },
			{ "Powered by roslyn, support automatic recompile after source code changed.",
				"基于Roslyn，支持修改源代码后自动重新编译和加载插件。" },
			{ "Disinct Web Layer", "独立的Web层" },
			{ "Support running on Asp.Net, Asp.Net Core, Owin, no code difference.",
				"支持同一份代码运行在Asp.Net, Asp.Net Core, Owin上。" },
			{ "Custom MVC routing and pipeline.", "拥有独自的MVC路由和管道。" },
			{ "Multiple ORM Support", "支持不同的ORM" },
			{ "Support EFCore, NHibernate, Dapper, MongoDB, InMemory, through the same interface.",
				"支持EFCore, NHibernate, Dapper, MongoDB, InMemory，通过统一的接口操作。" },
			{ "Powered by roslyn, support c# 6.0 features.", "基于Roslyn，完整支持c# 6.0的功能。" },
			{ "Support runtime plugin reload.", "支持运行时重新加载插件。" },
			{ "Support automatic recompile and reload after plugin source code changed.",
				"支持修改源代码后自动重新编译和加载插件。" },
			{ "Directory based, small memory footprint.", "一个文件夹一个插件，较小的内存占用。" },
			{ "Support automatic database scheme migration for EFCore and NHibernate.",
				"使用EFCore, NHibernate时支持自动添加和更新数据表。" },
			{ "Dotliquid Template", "Dotliquid模板引擎" },
			{ "Dotliquid template engine, django and rails like syntax.", "Dotliquid模板引擎拥有类似Django和Rails模板的语法。" },
			{ "Support django style template overriding over plugins.", "支持Django风格的跨插件重载模板文件。" },
			{ "Support mobile specialized templates.", "支持定义手机版专用的模板文件。" },
			{ "Support dynamic contents (area-widget model).", "支持区域-部件模型的动态内容系统。" },
			{ "Support per-widget render cache for extremely fast rending.", "支持按部件缓存描画结果，大幅提升页面的描画性能。" },
			{ "Project toolkits", "项目工具" },
			{ "Provide custom project creator, include command-line and gui version.",
				"提供独自的项目创建工具，包括命令行版本和界面版本。" },
			{ "Provide custom project publisher, include command-line and gui version.",
				"提供独自的项目发布工具，包括命令行版本和界面版本。" },
			{ "Demo site", "演示站点" },
			{ "Provide free and open source default plugins.", "提供免费和开源的默认插件。" },
			{ "Include admin panel, form builder, CRUD page scaffolding.",
				"包含管理面板，表单构建器和增删查改页面生成器。" },
			{ "Visit demo site (Username: demo, Password: 123456)",
				"访问示例站点 (用户名: demo, 密码: 123456)" },
			{ "ZKWeb demo site", "ZKWeb演示站点" },
			{ "DemoIndex", "演示首页" },
			{ "DemoNavMenu", "演示导航栏" },
			// TODO: 翻译到其他语言
			{ "View MPA Demo", "查看多页面演示" },
			{ "View SPA Demo", "查看单页面演示" },
			{ "Username: [0], Password: [1]", "用户名: [0], 密码: [1]" },
			{ "Getting Started", "开发入门" },
			{ "Create a MPA website with default plugins", "创建一个多页面站点, 并使用默认插件集" },
			{ "Download [0] from Github", "从Github下载[0]" },
			{ "Open '[0]'", "打开'[0]'" },
			{ "Create a new project, please choose NHibernate because it support all default plugins",
				"创建一个新项目, 请选择NHibernate因为它支持所有默认插件" },
			{ "Open created project and run it", "打开创建的项目并运行" },
			{ "Create a SPA website", "创建一个单页面站点" },
			{ "Open 'project_rename.sh' to rename project, you may need Git Bash",
				"打开'project_rename.sh'重命名项目, 您可能需要Git Bash" },
			{ "Build website files, install NodeJS and NPM first, then execute following commands",
				"编译网站文件, 安装NodeJS和NPM, 然后执行以下命令" },
			{ "Open project and run it", "打开项目并运行" },
			{ "More Informations", "更多信息" },
			{ "You can get more informations from documents:", "您可以从文档获取更多信息:" },
			{ "Documents for ZKWeb and MPA plugins", "ZKWeb和多页面站点的插件文档" },
			{ "Documents for MVVM plugins", "单页面站点的插件文档" },
			{ "Join US", "加入我们" },
			{ "Welcome to open issues or sending PR on github", "欢迎在Github上打开Issue或者发送PR" },
			{ "Also you can join our QQ group:", "也可以加入我们的QQ群:" },
		};

		public bool CanTranslate(string code) {
			return Codes.Contains(code);
		}

		public string Translate(string text) {
			return Translates.GetOrDefault(text);
		}
	}
}
