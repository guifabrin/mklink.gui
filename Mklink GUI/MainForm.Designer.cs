/*
 * Created by SharpDevelop.
 * User: Guilherme
 * Date: 16/02/2016
 * Time: 19:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Mklink_GUI
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_source;
		private System.Windows.Forms.TextBox txt_destiny;
		private System.Windows.Forms.Button btn_select_source;
		private System.Windows.Forms.Button btn_select_destiny;
		private System.Windows.Forms.Button btn_create;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.FolderBrowserDialog fbd;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_source = new System.Windows.Forms.TextBox();
			this.txt_destiny = new System.Windows.Forms.TextBox();
			this.btn_select_source = new System.Windows.Forms.Button();
			this.btn_select_destiny = new System.Windows.Forms.Button();
			this.btn_create = new System.Windows.Forms.Button();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.fbd = new System.Windows.Forms.FolderBrowserDialog();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Selecione a Pasta:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(122, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Selecione o Destino:";
			// 
			// txt_source
			// 
			this.txt_source.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.txt_source.Enabled = false;
			this.txt_source.Location = new System.Drawing.Point(140, 6);
			this.txt_source.Name = "txt_source";
			this.txt_source.ReadOnly = true;
			this.txt_source.Size = new System.Drawing.Size(251, 20);
			this.txt_source.TabIndex = 3;
			// 
			// txt_destiny
			// 
			this.txt_destiny.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.txt_destiny.Enabled = false;
			this.txt_destiny.Location = new System.Drawing.Point(140, 29);
			this.txt_destiny.Name = "txt_destiny";
			this.txt_destiny.ReadOnly = true;
			this.txt_destiny.Size = new System.Drawing.Size(251, 20);
			this.txt_destiny.TabIndex = 4;
			// 
			// btn_select_source
			// 
			this.btn_select_source.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_select_source.Location = new System.Drawing.Point(397, 4);
			this.btn_select_source.Name = "btn_select_source";
			this.btn_select_source.Size = new System.Drawing.Size(39, 23);
			this.btn_select_source.TabIndex = 5;
			this.btn_select_source.Text = "...";
			this.btn_select_source.UseVisualStyleBackColor = true;
			this.btn_select_source.Click += new System.EventHandler(this.Btn_select_sourceClick);
			// 
			// btn_select_destiny
			// 
			this.btn_select_destiny.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_select_destiny.Location = new System.Drawing.Point(397, 27);
			this.btn_select_destiny.Name = "btn_select_destiny";
			this.btn_select_destiny.Size = new System.Drawing.Size(39, 23);
			this.btn_select_destiny.TabIndex = 6;
			this.btn_select_destiny.Text = "...";
			this.btn_select_destiny.UseVisualStyleBackColor = true;
			this.btn_select_destiny.Click += new System.EventHandler(this.Btn_select_destinyClick);
			// 
			// btn_create
			// 
			this.btn_create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_create.Location = new System.Drawing.Point(353, 77);
			this.btn_create.Name = "btn_create";
			this.btn_create.Size = new System.Drawing.Size(83, 23);
			this.btn_create.TabIndex = 7;
			this.btn_create.Text = "Criar";
			this.btn_create.UseVisualStyleBackColor = true;
			this.btn_create.Click += new System.EventHandler(this.Btn_createClick);
			// 
			// radioButton1
			// 
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(6, 15);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(116, 32);
			this.radioButton1.TabIndex = 8;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "/D - Link Simbólico";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton3);
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Location = new System.Drawing.Point(12, 49);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(335, 53);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			// 
			// radioButton3
			// 
			this.radioButton3.Location = new System.Drawing.Point(248, 19);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(81, 24);
			this.radioButton3.TabIndex = 10;
			this.radioButton3.Text = "/J - Junção";
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(131, 19);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(104, 24);
			this.radioButton2.TabIndex = 9;
			this.radioButton2.Text = "/H - Link Real";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(448, 111);
			this.Controls.Add(this.btn_create);
			this.Controls.Add(this.btn_select_destiny);
			this.Controls.Add(this.btn_select_source);
			this.Controls.Add(this.txt_destiny);
			this.Controls.Add(this.txt_source);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Name = "MainForm";
			this.Text = "Mklink GUI";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
