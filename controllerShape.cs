/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 9/29/2024
 * Time: 10:46 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
namespace linie
{
	/// <summary>
	/// Description of controllerShape.
	/// </summary>
	public partial class controllerShape : UserControl
	{
		public controllerShape()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public List<thelinie> dots = new List<thelinie>();
		
		void ControllerShapeLoad(object sender, EventArgs e)
		{
			for(int i = 0 ; i < 8 ;i++)
			{
				dots.Add(new thelinie());
				dots[i].Left = 0;
				dots[i].Top = 0;
				dots[i].Width = 10;
				dots[i].Height = 10;
				dots[i].BackColor = Color.Black;
				this.Controls.Add(dots[i]);
				dots[i].Visible = true;
				
				
			}
			dots[0].Left = 0;
			dots[0].Top = 0;
			
			dots[1].Left = Parent.Width/2;
			dots[1].Top = 0;
			
			dots[2].Left = Parent.Width;
			dots[2].Top = 0;
			
			dots[3].Left = Parent.Width;
			dots[3].Top = Parent.Height/2;
			
			dots[4].Left = Parent.Width;
			dots[4].Top = Parent.Height;
			
			dots[5].Left =Parent.Width/2;;
			dots[5].Top =  Parent.Height;
			
			dots[6].Left = 0;
			dots[6].Top =  Parent.Height;
			
			dots[7].Left = 0;
			dots[7].Top =  Parent.Height/2;
			
		
		}	
	}
}
