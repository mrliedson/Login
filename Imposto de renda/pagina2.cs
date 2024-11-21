
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Imposto_de_renda
{

	public partial class pagina2 : Form
	{
		
		public pagina2()
		{

			InitializeComponent();

		}
		
		void Button1Click(object sender, EventArgs e)
		{
			double salBruto = double.Parse(textBox1.Text);
			double desconto;
			
			if (salBruto <= 1420) {
				desconto = (salBruto*7.5)/100;
				
				textBox2.Text = desconto.ToString("C");
				textBox3.Text = (salBruto-desconto).ToString("C");	
			} else if (salBruto <= 2666.68) {
				desconto = (salBruto*9)/100;
				
				textBox2.Text = desconto.ToString("C");
				textBox3.Text = (salBruto-desconto).ToString("C");	
			}else if (salBruto <= 4000.03) {
				desconto = (salBruto*12)/100;
				
				textBox2.Text = desconto.ToString("C");
				textBox3.Text = (salBruto-desconto).ToString("C");	
			} else if (salBruto <= 7786.02) {
				desconto = (salBruto*14)/100;
				
				textBox2.Text = desconto.ToString("C");
				textBox3.Text = (salBruto-desconto).ToString("C");	
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Form MainForm = new Mainform();
			MainForm.Show();
			this.Close();
			
			
		}
		
	}
}
