
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imposto_de_renda
{

	public partial class Mainform : Form
	{
		DateTime hora = new DateTime();
		DateTime dia = new DateTime();
		Form pagina2 = new pagina2();
		
		public Mainform()
		{

			InitializeComponent();
			
			
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			hora = DateTime.Now;
			dia = DateTime.Now;
			label4.Text = hora.ToString("HHmm");
			label5.Text = dia.ToString("ddMM");
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if(textBox1.Text == label5.Text && textBox2.Text == label4.Text){
				pagina2.Show();
				this.Hide();
			}
		}
	}
}
