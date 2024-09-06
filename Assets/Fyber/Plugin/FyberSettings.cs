/*
http://www.cgsoso.com/forum-211-1.html

CG搜搜 Unity3d 每日Unity3d插件免费更新 更有VIP资源！

CGSOSO 主打游戏开发，影视设计等CG资源素材。

插件如若商用，请务必官网购买！

daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FyberPlugin.LitJson;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace FyberPlugin
{

#if UNITY_EDITOR
	[InitializeOnLoad]
#endif
	public class FyberSettings : ScriptableObject
	{

		const string fyberSettingsAssetName = "FyberSettings";
		const string fyberSettingsPath = "Fyber/Resources";
		const string fyberSettingsAssetExtension = ".asset";

		private static FyberSettings instance;

#if UNITY_EDITOR
		static FyberSettings(){
#if !UNITY_5_4_OR_NEWER
			GetInstance();
#endif
		}
#else
		void OnEnable()
		{
			GetInstance();
		}
#endif
#if	UNITY_5_4_OR_NEWER && UNITY_EDITOR
		[InitializeOnLoadMethod]
#endif
		private static FyberSettings GetInstance()
		{
			if (instance == null)
			{
				PluginBridge.bridge = new PluginBridgeComponent();
				instance = Resources.Load(fyberSettingsAssetName) as FyberSettings;
				if (instance == null)
				{
					// If not found, autocreate the asset object.
					instance = CreateInstance<FyberSettings>();
#if UNITY_EDITOR
					string properPath = Path.Combine(Application.dataPath, fyberSettingsPath);
					if (!Directory.Exists(properPath))
					{
						AssetDatabase.CreateFolder("Assets/Fyber", "Resources");
					}

					string fullPath = Path.Combine(Path.Combine("Assets", fyberSettingsPath),
					                               fyberSettingsAssetName + fyberSettingsAssetExtension
					                               );
					instance.hideFlags = HideFlags.HideInInspector;
					AssetDatabase.CreateAsset(instance, fullPath);
#endif
				}
			}
			return instance;
		}

		public static FyberSettings Instance
		{
			get
			{
				return GetInstance();
			}
		}

		[SerializeField]
		[HideInInspector]
		private string bundlesJson;

		[SerializeField]
		[HideInInspector]
		private string configJson;

		[SerializeField]
		[HideInInspector]
		private int bundlesCount;

		internal string BundlesInfoJson()
		{
			return bundlesJson;
		}

		internal string BundlesConfigJson()
		{
			return configJson;
		}

		internal int BundlesCount()
		{
			return bundlesCount;
		}
	}

}
