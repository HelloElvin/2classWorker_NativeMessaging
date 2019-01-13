/*
 * 由SharpDevelop创建。
 * 用户： Elvin
 * 日期: 2018/12/15
 * 时间: 21:01
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace MouseClick
{
	/// <summary>
	/// Description of MouseClick.
	/// </summary>
	public class MouseClick
	{
		[System.Runtime.InteropServices.DllImport("user32")]
		private static extern int mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
		//移动鼠标
		const int MOUSEEVENTF_MOVE = 0x0001;
		//模拟鼠标左键按下
		const int MOUSEEVENTF_LEFTDOWN = 0x0002;
		//模拟鼠标左键抬起
		const int MOUSEEVENTF_LEFTUP = 0x0004;
		//模拟鼠标右键按下
		const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
		//模拟鼠标右键抬起
		const int MOUSEEVENTF_RIGHTUP = 0x0010;
		//模拟鼠标中键按下
		const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
		//模拟鼠标中键抬起
		const int MOUSEEVENTF_MIDDLEUP = 0x0040;
		//标示是否采用绝对坐标
		const int MOUSEEVENTF_ABSOLUTE = 0x8000;
		public MouseClick()
		{
		}
		public void move(int x ,int y)
		{
			mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, x* 65536 / 1366, y* 65536 / 768, 0, 0);
		}
		public void leftClickAt(int x,int y)
		{
			mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, x, y, 0, 0);
		}
		
		public void rightClickAt(int x,int y)
		{
			mouse_event (MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, x, y, 0, 0 );
		}
	}
}
