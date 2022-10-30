namespace Enhancer
{
	partial class Name
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Name));
			this.text = new System.Windows.Forms.TextBox();
			this.create = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// text
			// 
			this.text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.text.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.text.Location = new System.Drawing.Point(12, 12);
			this.text.Name = "text";
			this.text.Size = new System.Drawing.Size(426, 40);
			this.text.TabIndex = 0;
			this.text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_KeyDown);
			// 
			// create
			// 
			this.create.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.create.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.create.Location = new System.Drawing.Point(12, 58);
			this.create.Name = "create";
			this.create.Size = new System.Drawing.Size(426, 40);
			this.create.TabIndex = 1;
			this.create.Text = "Create";
			this.create.UseVisualStyleBackColor = true;
			this.create.Click += new System.EventHandler(this.create_Click);
			// 
			// Name
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(450, 110);
			this.Controls.Add(this.create);
			this.Controls.Add(this.text);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Name";
			this.Text = "Enhancer (TTMC Corporation)";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TextBox text;
		private Button create;
	}
}