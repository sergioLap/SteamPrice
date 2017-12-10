using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamPrice
{
    /// <summary>
    /// Отправляет запрос и получает данные.
    /// </summary>
    public static class SteamWebClient
    {
        /// <summary>
        /// 
        /// </summary>
        public static string GetResponse(Game game, string nameLot)
        {
            nameLot = nameLot.Replace(" ", "%20");
            WebRequest request = WebRequest.Create(string.Format(@"http://steamcommunity.com/market/pricehistory/?country=RU&currency=3&appid={0}&market_hash_name={1}",game.Id, nameLot));
            request.Credentials = CredentialCache.DefaultCredentials;
            WebResponse response = request.GetResponse();

            var statusDescriptiona = ((HttpWebResponse)response).StatusDescription;

            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);

            string responseFromServer = reader.ReadToEnd();
            return responseFromServer;
        }






    }
}
