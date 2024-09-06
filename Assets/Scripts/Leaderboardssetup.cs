/*
http://www.cgsoso.com/forum-211-1.html

CG搜搜 Unity3d 每日Unity3d插件免费更新 更有VIP资源！

CGSOSO 主打游戏开发，影视设计等CG资源素材。

插件如若商用，请务必官网购买！

daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

using UnityEngine;
using System.Collections;
//using GooglePlayGames;


public class Leaderboardssetup : MonoBehaviour {
	private static Leaderboardssetup _instance = null;
	public string leaderboardid = "";
	// Use this for initialization
	private Leaderboardssetup() {
//		PlayGamesPlatform.DebugLogEnabled = true;
//		PlayGamesPlatform.Activate ();
	}


	public static Leaderboardssetup Instance {
		get {
			if (_instance == null) {
				_instance = new Leaderboardssetup();
			}
			return _instance;
		}
	}

	void Start(){
		
	}

//	public void SignInAndStartMPGame() {
//		if (! PlayGamesPlatform.Instance.localUser.authenticated) {
//			PlayGamesPlatform.Instance.localUser.Authenticate((bool success) => {
//				if (success) {
//					Debug.Log ("We're signed in! Welcome " + PlayGamesPlatform.Instance.localUser.userName);
//					Debug.Log ("We're signed in! Welcome " + PlayGamesPlatform.Instance.localUser.image);
//
//					// We could start our game now
//				} else {
//					Debug.Log ("Oh... we're not signed in.");
//				}
//			});
//		} else {
//			Debug.Log ("You're already signed in.");
//			// We could also start our game now
//		}
//	}
//	public void TrySilentSignIn() {
//		if (! PlayGamesPlatform.Instance.localUser.authenticated) {
//			PlayGamesPlatform.Instance.Authenticate ((bool success) => {
//				if (success) {
//					Debug.Log ("Silently signed in! Welcome " + PlayGamesPlatform.Instance.localUser.userName);
//				} else {
//					Debug.Log ("Oh... we're not signed in.");
//				}
//			}, true);
//		} else {
//			Debug.Log("We're already signed in");
//		}
//	}
//	public bool IsAuthenticated() {
//		return PlayGamesPlatform.Instance.localUser.authenticated;
//	}
//	public bool submitscore(int iskore){
//		bool succheck = false;
//		Social.ReportScore(iskore, leaderboardid, (bool success) => {
//			if (success) {
//				Debug.Log ("score posted");
//				succheck = true;
//				// We could start our game now
//			} else {
//				Debug.Log ("score posting failed");
//				succheck = false;
//			}
//		});
//		return succheck;
//	}
//	public bool showleaderboard(){
//		PlayGamesPlatform.Instance.ShowLeaderboardUI (leaderboardid);
//		return true;
//	}
}
