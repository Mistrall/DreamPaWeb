using Microsoft.Web.WebPages.OAuth;

namespace VirtualAssistant.Web.App_Start
{
	public static class AuthConfig
	{
		public static void RegisterAuth()
		{
			// To let users of this site log in using their accounts from other sites such as Microsoft, Facebook, and Twitter,
			// you must update this site. For more information visit http://go.microsoft.com/fwlink/?LinkID=252166

			//OAuthWebSecurity.RegisterMicrosoftClient(
			//    clientId: "",
			//    clientSecret: "");
			OAuthWebSecurity.RegisterFacebookClient(
				appId: "1419590428264107",
				appSecret: "ff3864334ec86bc63b4c327da5e6e1df");

			OAuthWebSecurity.RegisterTwitterClient(
				consumerKey: "U19Px06YoRQyG40eHxN5LA",
				consumerSecret: "J5cLkLpUxagjKUAQhtWdHfrEJobhLOr9ZiKoai0");

			OAuthWebSecurity.RegisterGoogleClient();
		}
	}
}
