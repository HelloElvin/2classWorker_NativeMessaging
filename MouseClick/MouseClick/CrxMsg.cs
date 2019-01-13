/*
 * 由SharpDevelop创建。
 * 用户： Elvin
 * 日期: 2018/12/15
 * 时间: 21:46
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.IO;

namespace MouseClick
{
	/// <summary>
	/// Description of CrxMsg.
	/// </summary>
	public class CrxMsg
	{
		public delegate void NewMessgeHandler(String str);
		public NewMessgeHandler onNewMsg;
		public bool flag=true;
		public CrxMsg()
		{
		}
		public void listening()
		{
			String s="err";
			while(flag)
			{
			    s=OpenStandardStreamIn();
			   
				    onNewMsg(s);
			    
			}
		}
		public string OpenStandardStreamIn()
		{
			//// We need to read first 4 bytes for length information
			Stream stdin = Console.OpenStandardInput();
			int length = 0;
			byte[] bytes = new byte[4];
			stdin.Read(bytes, 0, 4);
			length = System.BitConverter.ToInt32(bytes, 0);

			string input = "";
			for (int i = 0; i < length; i++) {
				input += (char)stdin.ReadByte();
			}

			return input;
		}
		public void OpenStandardStreamOut(string stringData)
		{
			//// We need to send the 4 btyes of length information
			string msgdata = "{\"text\":\"" + stringData + "\"}";
			int DataLength = msgdata.Length;
			Stream stdout = Console.OpenStandardOutput();
			stdout.WriteByte((byte)((DataLength >> 0) & 0xFF));
			stdout.WriteByte((byte)((DataLength >> 8) & 0xFF));
			stdout.WriteByte((byte)((DataLength >> 16) & 0xFF));
			stdout.WriteByte((byte)((DataLength >> 24) & 0xFF));
			//Available total length : 4,294,967,295 ( FF FF FF FF )
			Console.Write(msgdata);
		}
	}
}
