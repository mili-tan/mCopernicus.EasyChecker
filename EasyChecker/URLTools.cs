using System;
using System.Text;
// ReSharper disable InconsistentNaming

// ReSharper disable once CheckNamespace
namespace Copernicus.ShadowsocksURi
{
    public class SSEntity
    {
        public string Name;
        public string EncryptStr;
        public string PassStr;
        public string ServerIpStr;
        public int Port;
    }

    public static class SSUri
    {
        public static SSEntity Parse(string ssUrl)
        {
            string urlString;
            SSEntity entity = new SSEntity();

            if (!ssUrl.Contains("#"))
            {
                urlString = DeCodeBase64(ssUrl.Replace("ss://", ""));
            }
            else
            {
                entity.Name = ssUrl.Split('#')[1];
                ssUrl = ssUrl.Split('#')[0];
                urlString = DeCodeBase64(ssUrl.Replace("ss://", ""));
            }

            string[] ssArray = urlString.Split('@', ':');

            entity.EncryptStr = ssArray[0];
            entity.PassStr = ssArray[1];
            entity.ServerIpStr = ssArray[2];
            entity.Port = Convert.ToInt32(ssArray[3]);

            return entity;
        }

        // ReSharper disable once UnusedMember.Global
        public static string Create(string encryptStr, string passStr, string serverIpStr, int port)
        {
            string linkStr = $"{encryptStr}:{passStr}@{serverIpStr}:{port.ToString()}";
            string ssUrlStr = $"ss://{EnCodeBase64(linkStr)}";
            return ssUrlStr;
        }

        private static string EnCodeBase64(string sourceStr)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(sourceStr); 
            string enCode = Convert.ToBase64String(bytes);
            return enCode;
        }

        private static string DeCodeBase64(string resultStr)
        {
            byte[] bytes = Convert.FromBase64String(resultStr);
            string deCode = Encoding.UTF8.GetString(bytes);
            return deCode;
        }
    }
}
