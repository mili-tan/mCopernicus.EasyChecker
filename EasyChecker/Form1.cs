using Copernicus.ShadowsocksURi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBoxURL_KeyDown(object sender, KeyEventArgs e)
        {
            SSEntity sEntity = new SSEntity();

            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    sEntity = SSURi.Parse(textBoxURL.Text);
                    textBoxURL.BackColor = Color.LightGreen;
                }
                catch (Exception)
                {
                    textBoxURL.BackColor = Color.LightPink;
                }

                panelLocalDNS.Show();
                if (!IsIP(sEntity.serverIpStr))
                {
                    labelIPLocal.Text = Dns.GetHostAddresses(sEntity.serverIpStr)[0].ToString();
                    labelIP1dot.Text = HttpsDNSHostAddresses(sEntity.serverIpStr);
                    panel1dot.Show();
                }
                else
                {
                    labelIPLocal.Text = sEntity.serverIpStr;
                }

            }
        }

        public static bool IsIP(string ip)
        {
            return Regex.IsMatch(ip, @"^((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){3}(2[0-4]\d|25[0-5]|[01]?\d\d?)$");
        }

        public static string HttpsDNSHostAddresses(string serverIpStr)
        {
            string dnsStr = new WebClient().DownloadString($"https://cloudflare-dns.com/dns-query?ct=application/dns-json&name={serverIpStr}&type=A");
            MojoUnity.JsonValue dnsAnswer = MojoUnity.Json.Parse(dnsStr).AsObjectGet("Answer");
            if (IsIP(dnsAnswer.AsArrayGet(0).AsObjectGetString("data")))
            {
                return dnsAnswer.AsArrayGet(0).AsObjectGetString("data");
            }
            else
            {
                return HttpsDNSHostAddresses(dnsAnswer.AsArrayGet(0).AsObjectGetString("data"));
            }
        }
    }
}
