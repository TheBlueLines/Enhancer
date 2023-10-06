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
			list = new ListBox();
			plus = new Button();
			minus = new Button();
			text = new RichTextBox();
			openFileDialog1 = new OpenFileDialog();
			saveFileDialog1 = new SaveFileDialog();
			menuStrip1 = new MenuStrip();
			fileToolStripMenuItem = new ToolStripMenuItem();
			openToolStripMenuItem = new ToolStripMenuItem();
			saveToolStripMenuItem = new ToolStripMenuItem();
			saveAsToolStripMenuItem = new ToolStripMenuItem();
			buildToolStripMenuItem = new ToolStripMenuItem();
			configToolStripMenuItem = new ToolStripMenuItem();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// list
			// 
			list.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			list.BorderStyle = BorderStyle.FixedSingle;
			list.Font = new Font("Roboto", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			list.FormattingEnabled = true;
			list.ItemHeight = 33;
			list.Location = new Point(12, 27);
			list.Name = "list";
			list.Size = new Size(150, 365);
			list.TabIndex = 3;
			list.TabStop = false;
			list.SelectedIndexChanged += list_SelectedIndexChanged;
			// 
			// plus
			// 
			plus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			plus.Enabled = false;
			plus.Font = new Font("Roboto", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			plus.Location = new Point(12, 398);
			plus.Name = "plus";
			plus.Size = new Size(75, 40);
			plus.TabIndex = 4;
			plus.TabStop = false;
			plus.Text = "+";
			plus.UseVisualStyleBackColor = true;
			plus.Click += plus_Click;
			// 
			// minus
			// 
			minus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			minus.Enabled = false;
			minus.Font = new Font("Roboto", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			minus.Location = new Point(87, 398);
			minus.Name = "minus";
			minus.Size = new Size(75, 40);
			minus.TabIndex = 5;
			minus.TabStop = false;
			minus.Text = "-";
			minus.UseVisualStyleBackColor = true;
			minus.Click += minus_Click;
			// 
			// text
			// 
			text.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			text.BorderStyle = BorderStyle.FixedSingle;
			text.Enabled = false;
			text.Font = new Font("Roboto", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			text.Location = new Point(168, 27);
			text.Name = "text";
			text.Size = new Size(620, 411);
			text.TabIndex = 6;
			text.TabStop = false;
			text.Text = "";
			// 
			// openFileDialog1
			// 
			openFileDialog1.Filter = "Enhancer files (*.enh)|*.enh|All files (*.*)|*.*";
			// 
			// saveFileDialog1
			// 
			saveFileDialog1.Filter = "Enhancer files (*.enh)|*.enh|All files (*.*)|*.*";
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, buildToolStripMenuItem, configToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(800, 24);
			menuStrip1.TabIndex = 7;
			menuStrip1.Text = "menu";
			// 
			// fileToolStripMenuItem
			// 
			fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem });
			fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			fileToolStripMenuItem.Size = new Size(37, 20);
			fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			openToolStripMenuItem.Name = "openToolStripMenuItem";
			openToolStripMenuItem.Size = new Size(114, 22);
			openToolStripMenuItem.Text = "Open";
			openToolStripMenuItem.Click += openToolStripMenuItem_Click;
			// 
			// saveToolStripMenuItem
			// 
			saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			saveToolStripMenuItem.Size = new Size(114, 22);
			saveToolStripMenuItem.Text = "Save";
			saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
			// 
			// saveAsToolStripMenuItem
			// 
			saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			saveAsToolStripMenuItem.Size = new Size(114, 22);
			saveAsToolStripMenuItem.Text = "Save As";
			saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
			// 
			// buildToolStripMenuItem
			// 
			buildToolStripMenuItem.Name = "buildToolStripMenuItem";
			buildToolStripMenuItem.Size = new Size(46, 20);
			buildToolStripMenuItem.Text = "Build";
			buildToolStripMenuItem.Click += buildToolStripMenuItem_Click;
			// 
			// configToolStripMenuItem
			// 
			configToolStripMenuItem.Name = "configToolStripMenuItem";
			configToolStripMenuItem.Size = new Size(55, 20);
			configToolStripMenuItem.Text = "Config";
			configToolStripMenuItem.Click += configToolStripMenuItem_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(text);
			Controls.Add(minus);
			Controls.Add(plus);
			Controls.Add(list);
			Controls.Add(menuStrip1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MainMenuStrip = menuStrip1;
			Name = "Form1";
			Text = "Enhancer";
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private ListBox list;
		private Button plus;
		private Button minus;
		private RichTextBox text;
		private OpenFileDialog openFileDialog1;
		private SaveFileDialog saveFileDialog1;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem openToolStripMenuItem;
		private ToolStripMenuItem saveToolStripMenuItem;
		private ToolStripMenuItem saveAsToolStripMenuItem;
		private ToolStripMenuItem buildToolStripMenuItem;
		private ToolStripMenuItem configToolStripMenuItem;
	}
}