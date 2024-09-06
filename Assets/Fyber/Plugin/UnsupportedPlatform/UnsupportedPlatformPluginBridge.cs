/*
http://www.cgsoso.com/forum-211-1.html

CG搜搜 Unity3d 每日Unity3d插件免费更新 更有VIP资源！

CGSOSO 主打游戏开发，影视设计等CG资源素材。

插件如若商用，请务必官网购买！

daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

using UnityEngine;

namespace FyberPlugin
{
#if UNITY_EDITOR || (!UNITY_IPHONE && !UNITY_IOS && !UNITY_ANDROID)
    internal class PluginBridgeComponent : IPluginBridge
	{
		
		public void StartSDK(string json)
		{
			Debug.Log("Version - " + Application.unityVersion);
			Utils.printWarningMessage();
		}

        public bool Cache(string action)
		{	
			Utils.printWarningMessage();
			return false;
		}
		
		public void Request(string json)
		{
			Utils.printWarningMessage();
		}
		
		public void StartAd(string json)
		{
			Utils.printWarningMessage();
		}

		public bool Banner(string json)
		{
			Utils.printWarningMessage();
			return false;
		}

		public void Report(string json)	
		{	
			Utils.printWarningMessage();
		}
		
		public string Settings(string json)
		{
			Utils.printWarningMessage();
			return "no yet implemented";
        }

        public void EnableLogging(bool shouldLog)
        {
            Utils.printWarningMessage();
		}

		public void GameObjectStarted()	
		{
			Utils.printWarningMessage();
		}
		public void ApplicationQuit()
		{
			Utils.printWarningMessage();
		}
    }
#endif
}
