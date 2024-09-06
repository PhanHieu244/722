/*
http://www.cgsoso.com/forum-211-1.html

CG搜搜 Unity3d 每日Unity3d插件免费更新 更有VIP资源！

CGSOSO 主打游戏开发，影视设计等CG资源素材。

插件如若商用，请务必官网购买！

daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

namespace FyberPlugin
{
#if UNITY_EDITOR || (!UNITY_IPHONE && !UNITY_IOS && !UNITY_ANDROID)
    public partial class User
	{

		static protected void NativePut(string json)
		{
			Utils.printWarningMessage();
		}

		static protected string GetJsonMessage(string key)
		{
			Utils.printWarningMessage();
			return "{\"success\":false,\"error\":\"Unsupported platform\":\"key\":" + key + "}";
		}

	}
#endif
}
