/*
http://www.cgsoso.com/forum-211-1.html

CG搜搜 Unity3d 每日Unity3d插件免费更新 更有VIP资源！

CGSOSO 主打游戏开发，影视设计等CG资源素材。

插件如若商用，请务必官网购买！

daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

using System;
using System.Runtime.InteropServices;

namespace FyberPlugin
{
#if (UNITY_IPHONE || UNITY_IOS) && !UNITY_EDITOR
	public partial class User
	{

		[DllImport ("__Internal")]
		public static extern string _User(string json);
		
		//  [DllImport ("__Internal")]
		//  public static extern void _UserReset();
				
		static public int? GetAge() {
			return (int?)Get<Object>(AGE);
		}
		
		static public UserGender? GetGender() {
			return (UserGender?)Get<Object>(GENDER);
		}
		
		static public UserSexualOrientation? GetSexualOrientation() {
			return (UserSexualOrientation?)Get<Object>(SEXUAL_ORIENTATION);
		}
		
		static public UserEthnicity? GetEthnicity() {
			return (UserEthnicity?)Get<Object>(ETHNICITY);
		}
		
		static public UserMaritalStatus? GetMaritalStatus() {
			return (UserMaritalStatus?)Get<Object>(MARITAL_STATUS);
		}
		
		static public int? GetNumberOfChildrens(){
			return (int?)Get<Object>(NUMBER_OF_CHILDRENS);
		}
		
		static public int? GetAnnualHouseholdIncome() {
			return (int?)Get<Object>(ANNUAL_HOUSEHOLD_INCOME);
		}
		
		static public UserEducation? GetEducation() {		
			return (UserEducation?)Get<Object>(EDUCATION);
		}
		
		static public UserConnection? GetConnection() {
			return (UserConnection?)Get<Object>(CONNECTION);
		}
		
		static public Boolean? GetIap() {
			return (Boolean?)Get<Object>(IAP);
		}
		
		static public float? GetIapAmount() {
			return (float?)Get<Object>(IAP_AMOUNT);
		}
		
		static public int? GetNumberOfSessions() {
			return (int?)Get<Object>(NUMBER_OF_SESSIONS);
		}
		
		static public long? GetPsTime() {
			return (long?)Get<Object>(PS_TIME);
		}
		
		static public long? GetLastSession() {
			return (long?)Get<Object>(LAST_SESSION);
		}

		static protected void NativePut(string json)
		{
			_User(json);
		}

		static protected string GetJsonMessage(string key)
		{
			return _User(GenerateGetJsonString(key));
		}

	}
#endif
}

