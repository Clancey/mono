//
// System.Web.Security.PassportIdentity.cs
//
// Authors:
//   Gonzalo Paniagua Javier (gonzalo@ximian.com)
//   Andreas Nahr (ClassDevelopment@A-SoftTech.com)
//
// (C) 2002 Ximian, Inc (http://www.ximian.com)
//

//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Security.Principal;

namespace System.Web.Security
{
	public sealed class PassportIdentity : IIdentity
	{
		[MonoTODO]
		public PassportIdentity ()
		{
			throw new NotImplementedException ();
		}

		~PassportIdentity ()
		{
		}

		public string AuthUrl ()
		{
			return AuthUrl (null, -1, -1, null, -1, null, -1, -1);
		}

#if (!NET_1_0)
		public string AuthUrl (String strReturnUrl)
		{
			return AuthUrl (strReturnUrl, -1, -1, null, -1, null, -1, -1);
		}
#endif

		public string AuthUrl (string strReturnUrl,
				       int iTimeWindow,
				       bool fForceLogin,
				       string strCoBrandedArgs,
				       int iLangID,
				       string strNameSpace,
				       int iKPP,
				       bool bUseSecureAuth)
		{
			return AuthUrl (strReturnUrl, iTimeWindow, (fForceLogin ? 1 : 0), strCoBrandedArgs, iLangID, strNameSpace, iKPP, (bUseSecureAuth ? 1 : 0));
		}

		[MonoTODO]
		public string AuthUrl (string strReturnUrl,
				       int iTimeWindow,
				       int iForceLogin,
				       string strCoBrandedArgs,
				       int iLangID,
				       string strNameSpace,
				       int iKPP,
				       int iUseSecureAuth)
		{
			throw new NotImplementedException ();
		}

		public string AuthUrl2 ()
		{
			return AuthUrl2 (null, -1, -1, null, -1, null, -1, -1);
		}

#if (!NET_1_0)
		public string AuthUrl2 (String strReturnUrl)
		{
			return AuthUrl2 (strReturnUrl, -1, -1, null, -1, null, -1, -1);
		}
#endif

		public string AuthUrl2 (string strReturnUrl,
					int iTimeWindow,
					bool fForceLogin,
					string strCoBrandedArgs,
					int iLangID,
					string strNameSpace,
					int iKPP,
					bool bUseSecureAuth)
		{
			return AuthUrl2 (strReturnUrl, iTimeWindow, (fForceLogin ? 1 : 0), strCoBrandedArgs, iLangID, strNameSpace, iKPP, (bUseSecureAuth ? 1 : 0));
		}

		[MonoTODO]
		public string AuthUrl2 (string strReturnUrl,
					int iTimeWindow,
					int iForceLogin,
					string strCoBrandedArgs,
					int iLangID,
					string strNameSpace,
					int iKPP,
					int iUseSecureAuth)
		{
			throw new NotImplementedException ();
		}

		[MonoTODO]
		public static string Compress (string strData)
		{
			throw new NotImplementedException ();
		}

		[MonoTODO]
		public static bool CryptIsValid ()
		{
			throw new NotImplementedException ();
		}

		[MonoTODO]
		public static int CryptPutHost (string strHost)
		{
			throw new NotImplementedException ();
		}

		[MonoTODO]
		public static int CryptPutSite (string strSite)
		{
			throw new NotImplementedException ();
		}

		[MonoTODO]
		public static string Decompress (string strData)
		{
			throw new NotImplementedException ();
		}

		[MonoTODO]
		public static string Decrypt (string strData)
		{
			throw new NotImplementedException ();
		}

		[MonoTODO]
		public static string Encrypt (string strData)
		{
			throw new NotImplementedException ();
		}

		[MonoTODO]
		public object GetCurrentConfig (string strAttribute)
		{
			throw new NotImplementedException ();
		}

		[MonoTODO]
		public string GetDomainAttribute (string strAttribute, int iLCID, string strDomain)
		{
			throw new NotImplementedException ();
		}

		[MonoTODO]
		public string GetDomainFromMemberName (string strMemberName)
		{
			throw new NotImplementedException ();
		}

		public bool GetIsAuthenticated (int iTimeWindow, bool bForceLogin, bool bCheckSecure)
		{
			return this.GetIsAuthenticated (iTimeWindow, (bForceLogin ? 1 : 0), (bCheckSecure ? 1 : 0));
		}

		[MonoTODO]
		public bool GetIsAuthenticated (int iTimeWindow, int iForceLogin, int iCheckSecure)
		{
			throw new NotImplementedException ();
		}

		public string GetLoginChallenge ()
		{
			return GetLoginChallenge (null, -1, -1, null, -1, null, -1, -1, null);
		}

#if (!NET_1_0)
		public string GetLoginChallenge (String strReturnUrl)
		{
			return GetLoginChallenge (strReturnUrl, -1, -1, null, -1, null, -1, -1, null);
		}
#endif

		[MonoTODO]
		public string GetLoginChallenge (string szRetURL,
						 int iTimeWindow,
						 int fForceLogin,
						 string szCOBrandArgs,
						 int iLangID,
						 string strNameSpace,
						 int iKPP,
						 int iUseSecureAuth,
						 object oExtraParams)
		{
			throw new NotImplementedException ();
		}

		[MonoTODO]
		public object GetOption (string strOpt)
		{
			throw new NotImplementedException ();
		}

		[MonoTODO]
		public object GetProfileObject (string strProfileName)
		{
			throw new NotImplementedException ();
		}

		[MonoTODO]
		public bool HasFlag (int iFlagMask)
		{
			throw new NotImplementedException ();
		}

		[MonoTODO]
		public bool HasProfile (string strProfile)
		{
			throw new NotImplementedException ();
		}

		[MonoTODO]
		public bool HaveConsent (bool bNeedFullConsent, bool bNeedBirthdate)
		{
			throw new NotImplementedException ();
		}

		public int LoginUser ()
		{
			return LoginUser (null, -1, -1, null, -1, null, -1, -1, null);
		}

#if (!NET_1_0)
		public int LoginUser (String strReturnUrl)
		{
			return LoginUser (strReturnUrl, -1, -1, null, -1, null, -1, -1, null);
		}
#endif

		public int LoginUser (string szRetURL,
				      int iTimeWindow,
				      bool fForceLogin,
				      string szCOBrandArgs,
				      int iLangID,
				      string strNameSpace,
				      int iKPP,
				      bool fUseSecureAuth,
				      object oExtraParams)
		{
			return LoginUser (szRetURL, iTimeWindow, (fForceLogin ? 1 : 0), szCOBrandArgs, iLangID, strNameSpace, iKPP, (fUseSecureAuth ? 1 : 0), null);
		}

		[MonoTODO]
		public int LoginUser (string szRetURL,
				      int iTimeWindow,
				      int fForceLogin,
				      string szCOBrandArgs,
				      int iLangID,
				      string strNameSpace,
				      int iKPP,
				      int iUseSecureAuth,
				      object oExtraParams)
		{
			throw new NotImplementedException ();
		}

		public string LogoTag ()
		{
			return LogoTag (null, -1, -1, null, -1, -1, null, -1, -1);
		}

#if (!NET_1_0)
		public string LogoTag (String strReturnUrl)
		{
			return LogoTag (strReturnUrl, -1, -1, null, -1, -1, null, -1, -1);
		}
#endif

		public string LogoTag (string strReturnUrl,
				       int iTimeWindow,
				       bool fForceLogin,
				       string strCoBrandedArgs,
				       int iLangID,
				       bool fSecure,
				       string strNameSpace,
				       int iKPP,
				       bool bUseSecureAuth)
		{
			return LogoTag (strReturnUrl, iTimeWindow, (fForceLogin ? 1 : 0), strCoBrandedArgs, iLangID, (fSecure ? 1 : 0), strNameSpace, iKPP, (bUseSecureAuth ? 1 : 0));
		}

		[MonoTODO]
		public string LogoTag (string strReturnUrl,
				       int iTimeWindow,
				       int iForceLogin,
				       string strCoBrandedArgs,
				       int iLangID,
				       int iSecure,
				       string strNameSpace,
				       int iKPP,
				       int iUseSecureAuth)
		{
			throw new NotImplementedException ();
		}

		public string LogoTag2 ()
		{
			return LogoTag2 (null, -1, -1, null, -1, -1, null, -1, -1);
		}

#if (!NET_1_0)
		public string LogoTag2 (String strReturnUrl)
		{
			return LogoTag2 (strReturnUrl, -1, -1, null, -1, -1, null, -1, -1);
		}
#endif

		public string LogoTag2 (string strReturnUrl,
				        int iTimeWindow,
				        bool fForceLogin,
				        string strCoBrandedArgs,
				        int iLangID,
				        bool fSecure,
				        string strNameSpace,
				        int iKPP,
				        bool bUseSecureAuth)
		{
			return LogoTag2 (strReturnUrl, iTimeWindow, (fForceLogin ? 1 : 0), strCoBrandedArgs, iLangID, (fSecure ? 1 : 0), strNameSpace, iKPP, (bUseSecureAuth ? 1 : 0));
		}

		[MonoTODO]
		public string LogoTag2 (string strReturnUrl,
				        int iTimeWindow,
				        int iForceLogin,
				        string strCoBrandedArgs,
				        int iLangID,
				        int iSecure,
				        string strNameSpace,
				        int iKPP,
				        int iUseSecureAuth)
		{
			throw new NotImplementedException ();
		}

		public string LogoutURL ()
		{
			return LogoutURL (null, null, -1, null, -1);
		}

		[MonoTODO]
		public string LogoutURL (string szReturnURL,
					 string szCOBrandArgs,
					 int iLangID,
					 string strDomain,
					 int iUseSecureAuth)
		{
			throw new NotImplementedException ();
		}

		[MonoTODO]
		public void SetOption (string strOpt, object vOpt)
		{
			throw new NotImplementedException ();
		}

		[MonoTODO]
		public static void SignOut (string strSignOutDotGifFileName)
		{
			throw new NotImplementedException ();
		}

		[MonoTODO]
		public object Ticket (string strAttribute)
		{
			throw new NotImplementedException ();
		}

		[MonoTODO]
		public string AuthenticationType
		{
			get {
				throw new NotImplementedException ();
			}
		}

		[MonoTODO]
		public int Error
		{
			get {
				throw new NotImplementedException ();
			}
		}

		[MonoTODO]
		public bool GetFromNetworkServer
		{
			get {
				throw new NotImplementedException ();
			}
		}

		[MonoTODO]
		public bool HasSavedPassword
		{
			get {
				throw new NotImplementedException ();
			}
		}

		[MonoTODO]
		public bool HasTicket
		{
			get {
				throw new NotImplementedException ();
			}
		}

		[MonoTODO]
		public string HexPUID
		{
			get {
				throw new NotImplementedException ();
			}
		}

		[MonoTODO]
		public bool IsAuthenticated
		{
			get {
				throw new NotImplementedException ();
			}
		}

		[MonoTODO]
		public string this [string strProfileName]
		{
			get {
				throw new NotImplementedException ();
			}
		}

		[MonoTODO]
		public string Name
		{
			get {
				throw new NotImplementedException ();
			}
		}

		[MonoTODO]
		public int TicketAge
		{
			get {
				throw new NotImplementedException ();
			}
		}

		[MonoTODO]
		public int TimeSinceSignIn
		{
			get {
				throw new NotImplementedException ();
			}
		}
	}
}

