using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TwitchChatTest1
{
    public partial class Form1 : Form
    {
        private TcpClient twitchClient;
        private StreamReader reader;
        private StreamWriter writer;


        public string username, password, channelName;

        private string pattern = @"(?<=^\:)(.*?)(?=\!)|(?<=\:{1,})(.*?)($)";
        Regex rx;

        public Form1()
        {
            InitializeComponent();
            timerTwitchChat.Stop();
            rx = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
        }

        private void BtnConnectChat_Click(object sender, EventArgs e)
        {
            username = tbTwitchLogin.Text;
            password = tbAuthTicket.Text;
            channelName = tbChannelName.Text;


            Connect();
            if (twitchClient.Connected)
            {
                tbChatLog.Text = "Connected";
                timerTwitchChat.Start();
            }   
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            ReadChat();
        }

        private void BtnGetAuthTicket_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitchapps.com/tmi");
        }

        private void Connect()
        {
            twitchClient = new TcpClient("irc.chat.twitch.tv", 6667);
            reader = new StreamReader(twitchClient.GetStream());
            writer = new StreamWriter(twitchClient.GetStream());

            writer.WriteLine("PASS " + password);
            writer.WriteLine("NICK " + username);
            writer.WriteLine("USER " + username + " 8 * :" + username);
            writer.WriteLine("JOIN #" + channelName);
            writer.Flush();
        }

        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            Disconnect();
        }

        private void Disconnect()
        {
            twitchClient.Close();
            twitchClient = null;
        }

        private void ReadChat()
        {
            if (twitchClient == null)
                return;

            if(twitchClient.Available > 0)
            {
                string message = reader.ReadLine();

                //Connected
                //: tmi.twitch.tv 001 isuroku: Welcome, GLHF!
                //:tmi.twitch.tv 002 isuroku: Your host is tmi.twitch.tv
                //:tmi.twitch.tv 003 isuroku: This server is rather new
                //:tmi.twitch.tv 004 isuroku: -
                //:tmi.twitch.tv 375 isuroku: -
                //:tmi.twitch.tv 372 isuroku: You are in a maze of twisty passages, all alike.
                //:tmi.twitch.tv 376 isuroku:>
                //:isuroku!isuroku @isuroku.tmi.twitch.tv JOIN #sodapoppin
                //:isuroku.tmi.twitch.tv 353 isuroku = #sodapoppin :isuroku
                //:isuroku.tmi.twitch.tv 366 isuroku #sodapoppin :End of /NAMES list
                //: goulz!goulz @goulz.tmi.twitch.tv PRIVMSG #sodapoppin :farm????
                //:angeloidusru!angeloidusru @angeloidusru.tmi.twitch.tv PRIVMSG #sodapoppin :mages can aoe farm
                //:humanistix!humanistix @humanistix.tmi.twitch.tv PRIVMSG #sodapoppin :name of song please
                //:00randompleb991!00randompleb991@00randompleb991.tmi.twitch.tv PRIVMSG #sodapoppin :classic is potion vs potion LUL
                //:spectrumwarrior1!spectrumwarrior1 @spectrumwarrior1.tmi.twitch.tv PRIVMSG #sodapoppin :JUST GRIND 4Head
                //:faithdimmer!faithdimmer @faithdimmer.tmi.twitch.tv PRIVMSG #sodapoppin :moneys tight
                //:imajjin!imajjin @imajjin.tmi.twitch.tv PRIVMSG #sodapoppin :Just stop being poor
                //:puzzlesen!puzzlesen @puzzlesen.tmi.twitch.tv PRIVMSG #sodapoppin :Tight's money PepeLaugh
                //:classifiedstuff!classifiedstuff @classifiedstuff.tmi.twitch.tv PRIVMSG #sodapoppin :anything goes in vanilla pvp get all the tools LUL
                //:fored00m!fored00m @fored00m.tmi.twitch.tv PRIVMSG #sodapoppin :Cmon make them pay Chance. FOR THE HORDE!
                //:crayzassaszin!crayzassaszin @crayzassaszin.tmi.twitch.tv PRIVMSG #sodapoppin :PogChamp
                //:bhaaku!bhaaku @bhaaku.tmi.twitch.tv PRIVMSG #sodapoppin :LULW
                //:koke_!koke_ @koke_.tmi.twitch.tv PRIVMSG #sodapoppin :asmon
                //:azell1234!azell1234 @azell1234.tmi.twitch.tv PRIVMSG #sodapoppin :Whats the AH like?
                //:itscominghome!itscominghome @itscominghome.tmi.twitch.tv PRIVMSG #sodapoppin :Just buy the WoW Token LULW
                //:evn1tv!evn1tv @evn1tv.tmi.twitch.tv PRIVMSG #sodapoppin :LULW FASLN'T

                //tbChatLog.AppendText(Environment.NewLine);
                //tbChatLog.AppendText(String.Format("{0}", message));

                //if (message.Contains("PRIVMSG"))
                //{
                //    var splitPoint = message.IndexOf("!", 1);
                //    var chatName = message.Substring(0, splitPoint);
                //    chatName = chatName.Substring(1);

                //    splitPoint = message.IndexOf(":", 1);
                //    message = message.Substring(splitPoint + 1);

                //    tbChatLog.AppendText(Environment.NewLine);
                //    tbChatLog.AppendText(String.Format("{0}: {1}", chatName, message));
                //}

                MatchCollection matches = rx.Matches(message);
                if (matches.Count == 2)
                {
                    tbChatLog.AppendText(Environment.NewLine);
                    tbChatLog.AppendText(String.Format("{0}: {1}", matches[0].Value, matches[1].Value));
                }

            }
        }
    }
}
