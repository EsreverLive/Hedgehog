using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
using System.Diagnostics;
using System.Xml.Linq;

namespace Payment_accounting
{

	public partial class Form2 : Form
	{
		public TextBox summ;
		MemoryStream ms = new MemoryStream();
		public double sum = 0;
		SqlConnection con = new SqlConnection();
		
		public Form2()
		{

			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog();

			if (open.ShowDialog() != DialogResult.OK) return;
			PathBox.Text = open.FileName;
			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (SummBox.Text == "")
			{
				errorProvider1.SetError(SummBox, "Не указано имя");
				return;
			}
			string name = "", path;
			if (PathBox.Text != "")
			{
				name = Path.GetFileName(PathBox.Text);
				path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files\\" + name);
				try
				{
					File.Copy(PathBox.Text, path, false);
				}
				catch
				{
					if (MessageBox.Show("Файл с таким именем уже существует в базе, хотите перезаписать?(Это может исказить информацию о других заявках)", "Файл с таким именем уже существует", MessageBoxButtons.OKCancel) == DialogResult.OK)
						File.Copy(PathBox.Text, path, true);
					else
						return;
				}
			}
			string dBName = "Forms.mdf";
			string dBPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, dBName);
		
			con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + dBPath + ";Integrated Security=True;MultipleActiveResultSets=true"; 
			con.Open();
			using (SqlCommand command = new SqlCommand("INSERT INTO Position(idForm, [Заявленная сумма], Комментарий, [Вложенные файлы]) VALUES(@idForm, @Sum, @Comment, @Files)", con))
			{
				command.Parameters.AddWithValue("idForm",int.Parse(idBox.Text));
				command.Parameters.AddWithValue("Sum", Convert.ToDouble(SummBox.Text));
				command.Parameters.AddWithValue("Comment", CommBox.Text);
				command.Parameters.AddWithValue("Files", name);
				command.ExecuteNonQuery();
			}
			
			con.Close();
			sum += Convert.ToDouble(SummBox.Text);
			SummBox.Text = "";
			CommBox.Text = "";
			PathBox.Text = "";
	
		}

		private void button3_Click(object sender, EventArgs e)
		{ 
			summ.Text = sum.ToString("N");
			this.Hide();
		}
		private void Form2_Load(object sender, EventArgs e)
		{
			sum = 0;
		}

		private void SummBox_Leave(object sender, EventArgs e)
		{
			if (SummBox.Text == "")
				return;
			try
			{
				SummBox.Text = Convert.ToDouble(SummBox.Text).ToString("N");
			}
			catch
			{
				SummBox.Text = "";
				MessageBox.Show("Неверный формат");
			}
		}
	}
}
