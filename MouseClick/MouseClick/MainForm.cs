/*
 * 由SharpDevelop创建。
 * 用户： Elvin
 * 日期: 2018/12/15
 * 时间: 20:57
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using System.Threading;

namespace MouseClick
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MouseClick mc=new MouseClick();
		public CrxMsg cm=new CrxMsg();
		public bool flag_conn=false;
		public MainForm(string[] args)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			if (args.Length != 0) {
				
			    cm.onNewMsg+=new CrxMsg.NewMessgeHandler(cm_onNewMsg);
				Thread t=new Thread(cm.listening);
				t.IsBackground=true;
				t.Start();
				
			}
		
		}

		void cm_onNewMsg(string str)
		{
			if(flag_conn)
			{flag_conn=true;}
			else{
				String[] a=str.Split('\"');
				if(a[3]=="ok"||a[3]=="start")
				{
					click();
				}
			}
			
		}
		public void click()
		{
			mc.move (500,300);
			mc.leftClickAt(0,0);
		}
		
		void ClickBtnClick(object sender, EventArgs e)
		{
			mc.move (500,300);
			mc.leftClickAt(0,0);
			cm.OpenStandardStreamOut("OK");
		}
		
	}
}
