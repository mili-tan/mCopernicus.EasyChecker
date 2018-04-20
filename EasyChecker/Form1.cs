﻿using Copernicus.ShadowsocksURi;
using System;
using System.Drawing;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using IPIP17Mon.IP;
using MojoUnity;

namespace EasyChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IPExt.Load("7monipdb.datx");
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
                        //label1Dot.Text = string.Join(",", IPExt.Find("1.1.1.1"));
                    }
                    //labelLocal.Text = string.Join(",", IPExt.Find(labelIPLocal.Text));
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
            JsonValue dnsAnswer = Json.Parse(dnsStr).AsObjectGet("Answer");
            string ipAnswer = dnsAnswer.AsArrayGet(0).AsObjectGetString("data");
            if (IsIP(ipAnswer))
            {
                return ipAnswer;
            }
            else
            {
                return HttpsDNSHostAddresses(ipAnswer);
            }
        }
    }
}
