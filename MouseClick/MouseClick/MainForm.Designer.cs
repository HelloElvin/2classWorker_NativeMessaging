/*
 * 由SharpDevelop创建。
 * 用户： Elvin
 * 日期: 2018/12/15
 * 时间: 20:57
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace MouseClick
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.clickBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// clickBtn
			// 
			this.clickBtn.Location = new System.Drawing.Point(98, 219);
			this.clickBtn.Name = "clickBtn";
			this.clickBtn.Size = new System.Drawing.Size(75, 23);
			this.clickBtn.TabIndex = 0;
			this.clickBtn.Text = "Click";
			this.clickBtn.UseVisualStyleBackColor = true;
			this.clickBtn.Click += new System.EventHandler(this.ClickBtnClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(38, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(209, 194);
			this.label1.TabIndex = 1;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.clickBtn);
			this.Name = "MainForm";
			this.Text = "MouseClick";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button clickBtn;
	}
}
