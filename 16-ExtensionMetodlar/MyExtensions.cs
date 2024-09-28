using System;
using System.Data.SqlClient;

namespace _16_ExtensionMetodlar
{
	#region Konu Anlatimi

	/*Extension Metodlar static class'larda , 
	 * static metodlar olarak tanimlanir.
	 * Yazilacak ture gore this keyword'u basa gertitilmelidir.
	 */

	public static class MyExtensions
	{

		public static bool BaglantiDurumuNedir(this SqlConnection connection)
		{
			if (connection.State == System.Data.ConnectionState.Open)
			{
				return true;

			}

			else
			{
				return false;
			}
		}

        public static string  TurkceKarakterleriTemizle(this string cumle)
		{
			return cumle.Replace('ç', 'c')
						.Replace('ı', 'i')
						.Replace('ğ', 'g')
						.Replace('ö', 'o')
						.Replace('ü', 'u');

        }
	}

    #endregion

}

