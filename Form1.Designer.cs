namespace Enhancer
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.save = new System.Windows.Forms.Button();
			this.load = new System.Windows.Forms.Button();
			this.build = new System.Windows.Forms.Button();
			this.list = new System.Windows.Forms.ListBox();
			this.plus = new System.Windows.Forms.Button();
			this.minus = new System.Windows.Forms.Button();
			this.text = new System.Windows.Forms.RichTextBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.SuspendLayout();
			// 
			// save
			// 
			this.save.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.save.Location = new System.Drawing.Point(12, 12);
			this.save.Name = "save";
			this.save.Size = new System.Drawing.Size(150, 40);
			this.save.TabIndex = 0;
			this.save.TabStop = false;
			this.save.Text = "Save";
			this.save.UseVisualStyleBackColor = true;
			this.save.Click += new System.EventHandler(this.save_Click);
			// 
			// load
			// 
			this.load.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.load.Location = new System.Drawing.Point(168, 12);
			this.load.Name = "load";
			this.load.Size = new System.Drawing.Size(150, 40);
			this.load.TabIndex = 1;
			this.load.TabStop = false;
			this.load.Text = "Load";
			this.load.UseVisualStyleBackColor = true;
			this.load.Click += new System.EventHandler(this.load_Click);
			// 
			// build
			// 
			this.build.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.build.Location = new System.Drawing.Point(324, 12);
			this.build.Name = "build";
			this.build.Size = new System.Drawing.Size(150, 40);
			this.build.TabIndex = 2;
			this.build.TabStop = false;
			this.build.Text = "Build";
			this.build.UseVisualStyleBackColor = true;
			this.build.Click += new System.EventHandler(this.build_Click);
			// 
			// list
			// 
			this.list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.list.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.list.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.list.FormattingEnabled = true;
			this.list.ItemHeight = 33;
			this.list.Location = new System.Drawing.Point(12, 58);
			this.list.Name = "list";
			this.list.Size = new System.Drawing.Size(150, 332);
			this.list.TabIndex = 3;
			this.list.TabStop = false;
			this.list.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged);
			// 
			// plus
			// 
			this.plus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.plus.Enabled = false;
			this.plus.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.plus.Location = new System.Drawing.Point(12, 398);
			this.plus.Name = "plus";
			this.plus.Size = new System.Drawing.Size(75, 40);
			this.plus.TabIndex = 4;
			this.plus.TabStop = false;
			this.plus.Text = "+";
			this.plus.UseVisualStyleBackColor = true;
			this.plus.Click += new System.EventHandler(this.plus_Click);
			// 
			// minus
			// 
			this.minus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.minus.Enabled = false;
			this.minus.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.minus.Location = new System.Drawing.Point(87, 398);
			this.minus.Name = "minus";
			this.minus.Size = new System.Drawing.Size(75, 40);
			this.minus.TabIndex = 5;
			this.minus.TabStop = false;
			this.minus.Text = "-";
			this.minus.UseVisualStyleBackColor = true;
			this.minus.Click += new System.EventHandler(this.minus_Click);
			// 
			// text
			// 
			this.text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.text.Enabled = false;
			this.text.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.text.Location = new System.Drawing.Point(168, 58);
			this.text.Name = "text";
			this.text.Size = new System.Drawing.Size(620, 380);
			this.text.TabIndex = 6;
			this.text.TabStop = false;
			this.text.Text = "";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.Filter = "Enhancer files (*.enh)|*.enh|All files (*.*)|*.*";
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.Filter = "Enhancer files (*.enh)|*.enh|All files (*.*)|*.*";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.text);
			this.Controls.Add(this.minus);
			this.Controls.Add(this.plus);
			this.Controls.Add(this.list);
			this.Controls.Add(this.build);
			this.Controls.Add(this.load);
			this.Controls.Add(this.save);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Enhancer (TTMC Corporation)";
			this.ResumeLayout(false);

		}

		#endregion

		private Button save;
		private Button load;
		private Button build;
		private ListBox list;
		private Button plus;
		private Button minus;
		private RichTextBox text;
		private OpenFileDialog openFileDialog1;
		private SaveFileDialog saveFileDialog1;
	}
}