using Copernicus.ShadowsocksURi;
using System;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MojoUnity;
using System.Net.NetworkInformation;

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
                    sEntity = SSUri.Parse(textBoxURL.Text);
                    textBoxURL.BackColor = Color.LightGreen;
                }
                catch (Exception)
                {
                    textBoxURL.BackColor = Color.LightPink;
                }

                panelLocalDNS.Show();

                if (!IsIp(sEntity.ServerIpStr))
                {
                    labelIPLocal.Text = Dns.GetHostAddresses(sEntity.ServerIpStr)[0].ToString();
                    labelIP1dot.Text = HttpsDnsHostAddresses(sEntity.ServerIpStr);
                    panel1dot.Show();
                    if (labelIP1dot.Text == labelIPLocal.Text)
                    {
                        labelDnsCheck.ForeColor = Color.Green;
                    }
                    else
                    {
                        labelDnsCheck.ForeColor = Color.Red;
                        label1Dot.Text = GeoIpLocal(labelIP1dot.Text);
                    }
                    labelLocal.Text = GeoIpLocal(labelIPLocal.Text);
                }
                else
                {
                    labelIPLocal.Text = sEntity.ServerIpStr;
                }


                PingReply replyPing = MyPing(sEntity.ServerIpStr);
                labelPingTimeOut.Text = replyPing.RoundtripTime + @"ms";
                if (replyPing.Status == IPStatus.Success)
                {
                    labelPingCheck.ForeColor = Color.Green;
                }
                else
                {
                    labelPingCheck.ForeColor = Color.Red;
                }

                var replyTcping = Tcping.Ping(sEntity.ServerIpStr, sEntity.Port);
                labelTCPingTimeOut.Text = $@"{replyTcping.Min()}/{replyTcping.Average()}/{replyTcping.Max()}ms";
                if (replyTcping.Average() != 0)
                {
                    labelTCPingCheck.ForeColor = Color.Green;
                }
                else
                {
                    labelTCPingCheck.ForeColor = Color.Red;
                }

            }
        }

        public static bool IsIp(string ip)
        {
            return Regex.IsMatch(ip, @"^((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){3}(2[0-4]\d|25[0-5]|[01]?\d\d?)$");
        }

        public static string HttpsDnsHostAddresses(string serverIpStr)
        {
            string dnsStr = new WebClient().DownloadString($"https://cloudflare-dns.com/dns-query?ct=application/dns-json&name={serverIpStr}&type=A");
            JsonValue dnsAnswerJson = Json.Parse(dnsStr).AsObjectGet("Answer");
            string ipAnswerStr = dnsAnswerJson.AsArrayGet(0).AsObjectGetString("data");
            return IsIp(ipAnswerStr) ? ipAnswerStr : HttpsDnsHostAddresses(ipAnswerStr);
        }

        public static string GeoIpLocal(string ipStr)
        {
            string locStr = new WebClient().DownloadString($"https://api.ip.sb/geoip/{ipStr}");
            JsonValue locJson = Json.Parse(locStr);
            string addr = locJson.AsObjectGetString("country_code3");
            if (!string.IsNullOrWhiteSpace(locJson.AsObjectGetString("city")))
            {
                addr += "," + locJson.AsObjectGetString("city");
            }
            return addr;
        }

        public static PingReply MyPing(string ipStr)
        {
            Ping ping = new Ping();
            byte[] bufferBytes = {00,01,00,01,00,01,00,01};
            return ping.Send(ipStr, 50, bufferBytes);
        }
    }
}
