using Copernicus.ShadowsocksURi;
using System;
using System.Drawing;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MojoUnity;
using System.Net.NetworkInformation;
using System.Text;

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
                    if (labelIP1dot.Text == labelIPLocal.Text)
                    {
                        labelDnsCheck.ForeColor = Color.Green;
                    }
                    else
                    {
                        labelDnsCheck.ForeColor = Color.Red;
                        label1Dot.Text = GeoIPLocal(labelIP1dot.Text);
                    }
                    labelLocal.Text = GeoIPLocal(labelIPLocal.Text);
                }
                else
                {
                    labelIPLocal.Text = sEntity.serverIpStr;
                }

                PingReply replyPing = MyPing(sEntity.serverIpStr);
                if (replyPing.Status == IPStatus.Success)
                {
                    labelPingCheck.ForeColor = Color.Green;
                }
                else
                {
                    labelPingCheck.ForeColor = Color.Red;
                }
                labelPingTimeOut.Text = replyPing.RoundtripTime.ToString() + "ms";
            }
        }

        public static bool IsIP(string ip)
        {
            return Regex.IsMatch(ip, @"^((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){3}(2[0-4]\d|25[0-5]|[01]?\d\d?)$");
        }

        public static string HttpsDNSHostAddresses(string serverIpStr)
        {
            string dnsStr = new WebClient().DownloadString($"https://cloudflare-dns.com/dns-query?ct=application/dns-json&name={serverIpStr}&type=A");
            JsonValue dnsAnswerJson = Json.Parse(dnsStr).AsObjectGet("Answer");
            string ipAnswerStr = dnsAnswerJson.AsArrayGet(0).AsObjectGetString("data");
            if (IsIP(ipAnswerStr))
            {
                return ipAnswerStr;
            }
            else
            {
                return HttpsDNSHostAddresses(ipAnswerStr);
            }
        }

        public static string GeoIPLocal(string IpStr)
        {
            string locStr = new WebClient().DownloadString($"https://api.ip.sb/geoip/{IpStr}");
            JsonValue locJson = Json.Parse(locStr);
            string addr = locJson.AsObjectGetString("country_code3");
            if (!string.IsNullOrWhiteSpace(locJson.AsObjectGetString("city")))
            {
                addr += "," + locJson.AsObjectGetString("city");
            }
            return addr;
        }

        public static PingReply MyPing(string IpStr)
        {
            Ping ping = new Ping();
            PingOptions pingOption = new PingOptions(50, true);
            byte[] bufferBytes = {00,01,00,01,00,01,00,01};
            return ping.Send(IpStr, 50, bufferBytes);
        }
    }
}
