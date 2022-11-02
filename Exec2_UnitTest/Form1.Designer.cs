namespace Exec2_UnitTest
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.TextBoxIn = new System.Windows.Forms.TextBox();
			this.LabelRe = new System.Windows.Forms.Label();
			this.ButtonRun = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// TextBoxIn
			// 
			this.TextBoxIn.Location = new System.Drawing.Point(33, 47);
			this.TextBoxIn.Name = "TextBoxIn";
			this.TextBoxIn.Size = new System.Drawing.Size(100, 22);
			this.TextBoxIn.TabIndex = 0;
			// 
			// LabelRe
			// 
			this.LabelRe.AutoSize = true;
			this.LabelRe.Location = new System.Drawing.Point(174, 50);
			this.LabelRe.Name = "LabelRe";
			this.LabelRe.Size = new System.Drawing.Size(53, 12);
			this.LabelRe.TabIndex = 1;
			this.LabelRe.Text = "判定結果";
			// 
			// ButtonRun
			// 
			this.ButtonRun.Location = new System.Drawing.Point(33, 109);
			this.ButtonRun.Name = "ButtonRun";
			this.ButtonRun.Size = new System.Drawing.Size(75, 23);
			this.ButtonRun.TabIndex = 2;
			this.ButtonRun.Text = "檢測";
			this.ButtonRun.UseVisualStyleBackColor = true;
			this.ButtonRun.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(440, 450);
			this.Controls.Add(this.ButtonRun);
			this.Controls.Add(this.LabelRe);
			this.Controls.Add(this.TextBoxIn);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TextBoxIn;
		private System.Windows.Forms.Label LabelRe;
		private System.Windows.Forms.Button ButtonRun;
	}
}

