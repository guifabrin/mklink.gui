/*
 * Created by SharpDevelop.
 * User: Guilherme
 * Date: 16/02/2016
 * Time: 19:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Mklink_GUI
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Btn_select_sourceClick(object sender, EventArgs e)
		{
			DialogResult dr = fbd.ShowDialog();
			if (dr == DialogResult.OK){
				txt_source.Text = fbd.SelectedPath;
			}
		}
		void Btn_select_destinyClick(object sender, EventArgs e)
		{
			DialogResult dr = fbd.ShowDialog();
			if (dr == DialogResult.OK){
				txt_destiny.Text = fbd.SelectedPath;
			}
		}
		void Btn_createClick(object sender, EventArgs e)
		{
			String parameter = "/D";
			if (String.IsNullOrEmpty(txt_source.Text) || String.IsNullOrEmpty(txt_destiny.Text)){
				MessageBox.Show("Erro: Pasta ou destino em branco!");
			} else {
				if (radioButton2.Checked) {
					parameter = "/H";
				}
				if (radioButton3.Checked){
					parameter = "/J";
				}
				Process.Start("mklink.exe",parameter+" \""+txt_destiny.Text+"\" \""+txt_source.Text+"\"");
			}	
		}
	}
}
