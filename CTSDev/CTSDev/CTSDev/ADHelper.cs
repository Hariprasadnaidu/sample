using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;

namespace CTSDEV
{
	public class ADHelper
	{
		#region Declaration

		DirectoryEntry oDE = null;
		DirectorySearcher oDS = null;

		#endregion Declaration

		#region Private Variables

		private string sADPath = System.Configuration.ConfigurationManager.ConnectionStrings["ADConnectionString"].ToString();
		private string sADPathPrefix = string.Empty;
		private string sADUser = string.Empty;
		private string sADPassword = string.Empty;
		private string sADServer = string.Empty;
		private string sCharactersToTrim = string.Empty;
		#endregion Private Variables
		public DirectoryEntry GetUser(string sUserName, string sPassword)
		{

			try
			{
				//Create an Instance of the DirectoryEntry
				oDE = GetDirectoryObject(sUserName, sPassword);

				//Create Instance fo the Direcory Searcher
				oDS = new DirectorySearcher();
				oDS.SearchRoot = oDE;

				//Set the Search Filter
				oDS.Filter = "(&(objectClass=user)(sAMAccountName=" + sUserName + "))";
				oDS.SearchScope = SearchScope.Subtree;
				oDS.PageSize = 10000;

				//Find the First Instance
				SearchResult oResults = oDS.FindOne();

				//If a Match is Found, Return Directory Object, Otherwise return Null
				if (oResults != null)
				{
					oDE = new DirectoryEntry(oResults.Path);
					//  _log.Debug("Directory Entry Completed....");
					return oDE;
				}
				else
				{
					return null;
				}
			}
			catch (Exception ex)
			{
				//  _log.Error(ex.Message);
				return null;
			}

		}
		private DirectoryEntry GetDirectoryObject(string sUserName, string sPassword)
		{
			oDE = new DirectoryEntry(sADPath, sUserName, sPassword, AuthenticationTypes.Secure);
			return oDE;
		}

	}
}