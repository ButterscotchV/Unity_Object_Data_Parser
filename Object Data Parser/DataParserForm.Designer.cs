namespace Object_Data_Parser
{
	partial class DataParserForm
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.lblInp = new System.Windows.Forms.Label();
			this.btnBrowseIn = new System.Windows.Forms.Button();
			this.txtIn = new System.Windows.Forms.TextBox();
			this.lblOut = new System.Windows.Forms.Label();
			this.txtOut = new System.Windows.Forms.TextBox();
			this.btnBrowseOut = new System.Windows.Forms.Button();
			this.lblOutCsv = new System.Windows.Forms.Label();
			this.txtOutCsv = new System.Windows.Forms.TextBox();
			this.btnBrowseOutCsv = new System.Windows.Forms.Button();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.btnProcess = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
			this.tableLayoutPanel1.Controls.Add(this.lblInp, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnBrowseIn, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.txtIn, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.lblOut, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.txtOut, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.btnBrowseOut, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.lblOutCsv, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.txtOutCsv, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.btnBrowseOutCsv, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.progressBar, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.btnProcess, 1, 6);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 6;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.6F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.6F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.6F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.15F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 225);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// lblInp
			// 
			this.lblInp.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblInp.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.lblInp, 2);
			this.lblInp.Location = new System.Drawing.Point(213, 4);
			this.lblInp.Name = "lblInp";
			this.lblInp.Size = new System.Drawing.Size(73, 13);
			this.lblInp.TabIndex = 0;
			this.lblInp.Text = "Input Data Dir";
			// 
			// btnBrowseIn
			// 
			this.btnBrowseIn.AllowDrop = true;
			this.btnBrowseIn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnBrowseIn.Location = new System.Drawing.Point(403, 25);
			this.btnBrowseIn.Name = "btnBrowseIn";
			this.btnBrowseIn.Size = new System.Drawing.Size(94, 31);
			this.btnBrowseIn.TabIndex = 2;
			this.btnBrowseIn.Text = "Browse";
			this.btnBrowseIn.UseVisualStyleBackColor = true;
			this.btnBrowseIn.Click += new System.EventHandler(this.BtnBrowseIn_Click);
			this.btnBrowseIn.DragDrop += new System.Windows.Forms.DragEventHandler(this.DoDirDrop);
			this.btnBrowseIn.DragEnter += new System.Windows.Forms.DragEventHandler(this.DoFileHover);
			// 
			// txtIn
			// 
			this.txtIn.AllowDrop = true;
			this.txtIn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtIn.Location = new System.Drawing.Point(3, 25);
			this.txtIn.Multiline = true;
			this.txtIn.Name = "txtIn";
			this.txtIn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtIn.Size = new System.Drawing.Size(394, 31);
			this.txtIn.TabIndex = 4;
			this.txtIn.TextChanged += new System.EventHandler(this.CleanNewLines);
			this.txtIn.DragDrop += new System.Windows.Forms.DragEventHandler(this.DoDirDrop);
			this.txtIn.DragEnter += new System.Windows.Forms.DragEventHandler(this.DoFileHover);
			// 
			// lblOut
			// 
			this.lblOut.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblOut.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.lblOut, 2);
			this.lblOut.Location = new System.Drawing.Point(208, 63);
			this.lblOut.Name = "lblOut";
			this.lblOut.Size = new System.Drawing.Size(84, 13);
			this.lblOut.TabIndex = 1;
			this.lblOut.Text = "Output Data File";
			// 
			// txtOut
			// 
			this.txtOut.AllowDrop = true;
			this.txtOut.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtOut.Location = new System.Drawing.Point(3, 84);
			this.txtOut.Multiline = true;
			this.txtOut.Name = "txtOut";
			this.txtOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtOut.Size = new System.Drawing.Size(394, 31);
			this.txtOut.TabIndex = 5;
			this.txtOut.TextChanged += new System.EventHandler(this.CleanNewLines);
			this.txtOut.DragDrop += new System.Windows.Forms.DragEventHandler(this.DoFileDrop);
			this.txtOut.DragEnter += new System.Windows.Forms.DragEventHandler(this.DoFileHover);
			// 
			// btnBrowseOut
			// 
			this.btnBrowseOut.AllowDrop = true;
			this.btnBrowseOut.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnBrowseOut.Location = new System.Drawing.Point(403, 84);
			this.btnBrowseOut.Name = "btnBrowseOut";
			this.btnBrowseOut.Size = new System.Drawing.Size(94, 31);
			this.btnBrowseOut.TabIndex = 3;
			this.btnBrowseOut.Text = "Browse";
			this.btnBrowseOut.UseVisualStyleBackColor = true;
			this.btnBrowseOut.Click += new System.EventHandler(this.BtnBrowseOut_Click);
			this.btnBrowseOut.DragDrop += new System.Windows.Forms.DragEventHandler(this.DoFileDrop);
			this.btnBrowseOut.DragEnter += new System.Windows.Forms.DragEventHandler(this.DoFileHover);
			// 
			// lblOutCsv
			// 
			this.lblOutCsv.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblOutCsv.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.lblOutCsv, 2);
			this.lblOutCsv.Location = new System.Drawing.Point(196, 122);
			this.lblOutCsv.Name = "lblOutCsv";
			this.lblOutCsv.Size = new System.Drawing.Size(108, 13);
			this.lblOutCsv.TabIndex = 1;
			this.lblOutCsv.Text = "Output Data CSV File";
			// 
			// txtOutCsv
			// 
			this.txtOutCsv.AllowDrop = true;
			this.txtOutCsv.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtOutCsv.Location = new System.Drawing.Point(3, 143);
			this.txtOutCsv.Multiline = true;
			this.txtOutCsv.Name = "txtOutCsv";
			this.txtOutCsv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtOutCsv.Size = new System.Drawing.Size(394, 31);
			this.txtOutCsv.TabIndex = 5;
			this.txtOutCsv.TextChanged += new System.EventHandler(this.CleanNewLines);
			this.txtOutCsv.DragDrop += new System.Windows.Forms.DragEventHandler(this.DoFile2Drop);
			this.txtOutCsv.DragEnter += new System.Windows.Forms.DragEventHandler(this.DoFileHover);
			// 
			// btnBrowseOutCsv
			// 
			this.btnBrowseOutCsv.AllowDrop = true;
			this.btnBrowseOutCsv.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnBrowseOutCsv.Location = new System.Drawing.Point(403, 143);
			this.btnBrowseOutCsv.Name = "btnBrowseOutCsv";
			this.btnBrowseOutCsv.Size = new System.Drawing.Size(94, 31);
			this.btnBrowseOutCsv.TabIndex = 3;
			this.btnBrowseOutCsv.Text = "Browse";
			this.btnBrowseOutCsv.UseVisualStyleBackColor = true;
			this.btnBrowseOutCsv.Click += new System.EventHandler(this.BtnBrowseOutCsv_Click);
			this.btnBrowseOutCsv.DragDrop += new System.Windows.Forms.DragEventHandler(this.DoFile2Drop);
			this.btnBrowseOutCsv.DragEnter += new System.Windows.Forms.DragEventHandler(this.DoFileHover);
			// 
			// progressBar
			// 
			this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.progressBar.Location = new System.Drawing.Point(3, 180);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(394, 42);
			this.progressBar.TabIndex = 6;
			// 
			// btnProcess
			// 
			this.btnProcess.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnProcess.Location = new System.Drawing.Point(403, 180);
			this.btnProcess.Name = "btnProcess";
			this.btnProcess.Size = new System.Drawing.Size(94, 42);
			this.btnProcess.TabIndex = 7;
			this.btnProcess.Text = "Process";
			this.btnProcess.UseVisualStyleBackColor = true;
			this.btnProcess.Click += new System.EventHandler(this.BtnProcess_Click);
			// 
			// DataParserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(500, 225);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "DataParserForm";
			this.Text = "Object Data Parser";
			this.Load += new System.EventHandler(this.DataParserForm_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label lblInp;
		private System.Windows.Forms.TextBox txtIn;
		private System.Windows.Forms.Button btnBrowseIn;
		private System.Windows.Forms.Label lblOut;
		private System.Windows.Forms.TextBox txtOut;
		private System.Windows.Forms.Button btnBrowseOut;
		private System.Windows.Forms.Label lblOutCsv;
		private System.Windows.Forms.TextBox txtOutCsv;
		private System.Windows.Forms.Button btnBrowseOutCsv;
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.Button btnProcess;
	}
}

