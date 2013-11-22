using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace wake_on_lan
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btn_wake_Click(object sender, EventArgs e)
		{
			using (UdpClient udpClient = new UdpClient())
			{
				Console.WriteLine("Enter mac address");
				byte[] mac = StrToMac(txt_mac.Text);
				udpClient.Send(mac, mac.Length, new IPEndPoint(IPAddress.Broadcast, 9));
			}
		}

		static byte[] StrToMac(string s)
		{
			List<byte> arr = new List<byte>(102);

			string[] macs = s.ToUpper().Split(' ', ':', '-');

			for (int i = 0; i < 6; i++)
				arr.Add(0xff);

			for (int j = 0; j < 16; j++)
				for (int i = 0; i < 6; i++)
					arr.Add(Convert.ToByte(macs[i], 16));

			return arr.ToArray();
		}
	}
}
