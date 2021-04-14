using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;



namespace EgyptExcavation.Models
{
	public class Helpers
	{
		public static string GetRDSConnectionString()
		{
			var appConfig = ConfigurationManager.AppSettings;


			string dbname = appConfig["RDS_DB_NAME"];

			if (string.IsNullOrEmpty(dbname)) return null;

			string username = appConfig["RDS_USERNAME"];
			string password = appConfig["RDS_PASSWORD"];
			string hostname = appConfig["RDS_HOSTNAME"];
			string port = appConfig["RDS_PORT"];



			return "Data Source=" + hostname + ";Initial Catalog=" + dbname + ";User ID=" + username + ";Password=" + password + ";";
			//return "Data Source=aa1sarcy4oebfsj.ctxcsdgunbrh.us-east-1.rds.amazonaws.com;Initial Catalog=ebdb;User ID=intexmummy;Password=thatsawrap!;";
		}
	}
}