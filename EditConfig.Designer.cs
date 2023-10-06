namespace Enhancer
{
	partial class EditConfig
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditConfig));
			qemuTitle = new Label();
			qemu = new TextBox();
			nasmTitle = new Label();
			nasm = new TextBox();
			ok = new Button();
			cancel = new Button();
			qemuBrowse = new Button();
			nasmBrowse = new Button();
			openFileDialog1 = new OpenFileDialog();
			SuspendLayout();
			// 
			// qemuTitle
			// 
			qemuTitle.Font = new Font("Roboto", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			qemuTitle.Location = new Point(12, 9);
			qemuTitle.Name = "qemuTitle";
			qemuTitle.Size = new Size(500, 40);
			qemuTitle.TabIndex = 0;
			qemuTitle.Text = "QEMU executable path:";
			qemuTitle.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// qemu
			// 
			qemu.Font = new Font("Roboto", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			qemu.Location = new Point(12, 52);
			qemu.Name = "qemu";
			qemu.Size = new Size(460, 40);
			qemu.TabIndex = 0;
			qemu.TabStop = false;
			// 
			// nasmTitle
			// 
			nasmTitle.Font = new Font("Roboto", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			nasmTitle.Location = new Point(12, 95);
			nasmTitle.Name = "nasmTitle";
			nasmTitle.Size = new Size(500, 40);
			nasmTitle.TabIndex = 2;
			nasmTitle.Text = "NASM executable path:";
			nasmTitle.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// nasm
			// 
			nasm.Font = new Font("Roboto", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			nasm.Location = new Point(12, 138);
			nasm.Name = "nasm";
			nasm.Size = new Size(460, 40);
			nasm.TabIndex = 0;
			nasm.TabStop = false;
			// 
			// ok
			// 
			ok.Font = new Font("Roboto", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			ok.Location = new Point(12, 184);
			ok.Name = "ok";
			ok.Size = new Size(250, 40);
			ok.TabIndex = 4;
			ok.Text = "OK";
			ok.UseVisualStyleBackColor = true;
			ok.Click += ok_Click;
			// 
			// cancel
			// 
			cancel.Font = new Font("Roboto", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			cancel.Location = new Point(262, 184);
			cancel.Name = "cancel";
			cancel.Size = new Size(250, 40);
			cancel.TabIndex = 5;
			cancel.Text = "Cancel";
			cancel.UseVisualStyleBackColor = true;
			cancel.Click += cancel_Click;
			// 
			// qemuBrowse
			// 
			qemuBrowse.Font = new Font("Roboto", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			qemuBrowse.Location = new Point(472, 52);
			qemuBrowse.Name = "qemuBrowse";
			qemuBrowse.Size = new Size(40, 40);
			qemuBrowse.TabIndex = 6;
			qemuBrowse.Text = "...";
			qemuBrowse.UseVisualStyleBackColor = true;
			qemuBrowse.Click += qemuBrowse_Click;
			// 
			// nasmBrowse
			// 
			nasmBrowse.Font = new Font("Roboto", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			nasmBrowse.Location = new Point(472, 138);
			nasmBrowse.Name = "nasmBrowse";
			nasmBrowse.Size = new Size(40, 40);
			nasmBrowse.TabIndex = 7;
			nasmBrowse.Text = "...";
			nasmBrowse.UseVisualStyleBackColor = true;
			nasmBrowse.Click += nasmBrowse_Click;
			// 
			// openFileDialog1
			// 
			openFileDialog1.FileName = "openFileDialog1";
			openFileDialog1.Filter = "Executable (*.exe)|*.exe|All files (*.*)|*.*";
			// 
			// EditConfig
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(525, 234);
			Controls.Add(nasmBrowse);
			Controls.Add(qemuBrowse);
			Controls.Add(cancel);
			Controls.Add(ok);
			Controls.Add(nasm);
			Controls.Add(nasmTitle);
			Controls.Add(qemu);
			Controls.Add(qemuTitle);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "EditConfig";
			Text = "Edit Config";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label qemuTitle;
		private TextBox qemu;
		private Label nasmTitle;
		private TextBox nasm;
		private Button ok;
		private Button cancel;
		private Button qemuBrowse;
		private Button nasmBrowse;
		private OpenFileDialog openFileDialog1;
	}
}