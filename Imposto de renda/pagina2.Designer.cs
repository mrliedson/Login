/*
 * Created by SharpDevelop.
 * User: aliss
 * Date: 26/10/2024
 * Time: 12:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Imposto_de_renda
{
	partial class pagina2
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pagina2));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(583, 466);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Gold;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(73, 25);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(450, 80);
			this.panel1.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(14, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(415, 55);
			this.label1.TabIndex = 0;
			this.label1.Text = "Imposto de renda";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(179)))));
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.textBox3);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.textBox2);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.textBox1);
			this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel2.Location = new System.Drawing.Point(73, 127);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(450, 274);
			this.panel2.TabIndex = 4;
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox3.Location = new System.Drawing.Point(94, 217);
			this.textBox3.MaxLength = 3200;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(259, 26);
			this.textBox3.TabIndex = 8;
			this.textBox3.Text = "0";
			this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(137, 190);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(149, 24);
			this.label4.TabIndex = 7;
			this.label4.Text = "Salário liquido:";
			// 
			// button1
			// 
			this.button1.AutoSize = true;
			this.button1.BackColor = System.Drawing.Color.Blue;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
			this.button1.FlatAppearance.BorderSize = 4;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(176, 79);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(93, 42);
			this.button1.TabIndex = 6;
			this.button1.Text = "Sing In";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(94, 161);
			this.textBox2.MaxLength = 3200;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(259, 26);
			this.textBox2.TabIndex = 5;
			this.textBox2.Text = "0";
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(137, 134);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(177, 24);
			this.label3.TabIndex = 4;
			this.label3.Text = "Desconto do Inss:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(113, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(230, 24);
			this.label2.TabIndex = 3;
			this.label2.Text = "Digite seu salário bruto:";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(94, 47);
			this.textBox1.MaxLength = 3200;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(259, 26);
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = "0";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// button2
			// 
			this.button2.AutoSize = true;
			this.button2.BackColor = System.Drawing.Color.Red;
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
			this.button2.FlatAppearance.BorderSize = 4;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(250, 407);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(93, 42);
			this.button2.TabIndex = 9;
			this.button2.Text = "Logout";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// pagina2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(583, 466);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureBox1);
			this.MaximizeBox = false;
			this.Name = "pagina2";
			this.Text = "pagina2";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
