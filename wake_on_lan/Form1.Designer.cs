namespace wake_on_lan
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.cmb_mac = new System.Windows.Forms.ComboBox();
			this.txt_log = new System.Windows.Forms.RichTextBox();
			this.btn_wake = new System.Windows.Forms.Button();
			this.txt_mac = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// cmb_mac
			// 
			this.cmb_mac.FormattingEnabled = true;
			this.cmb_mac.Location = new System.Drawing.Point(12, 12);
			this.cmb_mac.Name = "cmb_mac";
			this.cmb_mac.Size = new System.Drawing.Size(298, 24);
			this.cmb_mac.TabIndex = 0;
			// 
			// txt_log
			// 
			this.txt_log.Location = new System.Drawing.Point(12, 86);
			this.txt_log.Name = "txt_log";
			this.txt_log.Size = new System.Drawing.Size(676, 273);
			this.txt_log.TabIndex = 1;
			this.txt_log.Text = "";
			// 
			// btn_wake
			// 
			this.btn_wake.Location = new System.Drawing.Point(12, 42);
			this.btn_wake.Name = "btn_wake";
			this.btn_wake.Size = new System.Drawing.Size(75, 38);
			this.btn_wake.TabIndex = 2;
			this.btn_wake.Text = "Wake!";
			this.btn_wake.UseVisualStyleBackColor = true;
			this.btn_wake.Click += new System.EventHandler(this.btn_wake_Click);
			// 
			// txt_mac
			// 
			this.txt_mac.Location = new System.Drawing.Point(316, 12);
			this.txt_mac.Name = "txt_mac";
			this.txt_mac.Size = new System.Drawing.Size(372, 22);
			this.txt_mac.TabIndex = 3;
			this.txt_mac.Text = "1c-6f-65-56-f1-c9";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(700, 371);
			this.Controls.Add(this.txt_mac);
			this.Controls.Add(this.btn_wake);
			this.Controls.Add(this.txt_log);
			this.Controls.Add(this.cmb_mac);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmb_mac;
		private System.Windows.Forms.RichTextBox txt_log;
		private System.Windows.Forms.Button btn_wake;
		private System.Windows.Forms.TextBox txt_mac;
	}
}

