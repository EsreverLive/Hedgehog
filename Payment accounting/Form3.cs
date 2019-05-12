using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payment_accounting
{
	public partial class Form3 : Form
	{

		SqlConnection con = new SqlConnection();

		public Form3()
		{
			InitializeComponent();
		}

		private void Form3_Load(object sender, EventArgs e)
		{
			this.positionTableAdapter.Fill(this.formsDataSet2.Position);
			this.formTableAdapter.Fill(this.formsDataSet2.Form);
			string dBName = "Forms.mdf";
			string dBPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, dBName);

			con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + dBPath + ";Integrated Security=True;MultipleActiveResultSets=true"; // @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\bin\Debug\Forms.mdf;Integrated Security=True;Connect Timeout=30"; //

		}

		private void label1_Click(object sender, EventArgs e)
		{
			if (label1.Text == "")
			{
				return;
			}
			if (MessageBox.Show("Открыть файл?", "Открытие файла", MessageBoxButtons.OKCancel) == DialogResult.OK)
			{
				string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files\\");
				Process.Start(path + label1.Text);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (заявленная_суммаTextBox.Text == "")
			{
				errorProvider1.SetError(заявленная_суммаTextBox, "Поле должно быть заполнено");
				return;
			}
			try
			{
				con.Open();
				using (SqlCommand command = new SqlCommand("Update Form Set [Общая сумма] = @Sum, Дата= @date, ФИО= @FIO, Тип=@Type Where [Номер заявки]=" + номер_заявкиTextBox.Text, con))
				{
					command.Parameters.AddWithValue("date", Convert.ToDateTime(датаDateTimePicker.Text));
					command.Parameters.AddWithValue("FIO", фИОTextBox.Text);
					command.Parameters.AddWithValue("Type", comboBox1.Text);
					command.Parameters.AddWithValue("Sum", Convert.ToDouble(Convert.ToDouble(общая_суммаTextBox.Text).ToString("N")));
					command.ExecuteNonQuery();
				}
				using (SqlCommand command1 = new SqlCommand("Update Position Set [Заявленная сумма]= @Summ, Комментарий= @Com, [Вложенные файлы]= @Files Where [idPos]=" + idPosTextBox.Text, con))
				{
					command1.Parameters.AddWithValue("Summ", Convert.ToDouble(Convert.ToDouble(заявленная_суммаTextBox.Text).ToString("N")));
					command1.Parameters.AddWithValue("Com", richTextBox1.Text);
					command1.Parameters.AddWithValue("Files", Convert.ToString(Path.GetFileName(PathBox.Text)));
					command1.ExecuteNonQuery();
				}
				if (PathBox.Text != "")
				{
					string name = Path.GetFileName(PathBox.Text);
					string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files\\" + name);

					File.Copy(PathBox.Text, path, true);
				}
				this.positionTableAdapter.Update(this.formsDataSet2);
				this.formTableAdapter.Update(this.formsDataSet2);
				
				label1.Visible = true;
				PathBox.Visible = false;

				this.formTableAdapter.Fill(this.formsDataSet2.Form);
				this.positionTableAdapter.Fill(this.formsDataSet2.Position);
			}
			catch
			{
				MessageBox.Show("Некорректные данные");
			}
			finally
			{
				con.Close();
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление", MessageBoxButtons.OKCancel) == DialogResult.OK)
			{
				try
				{
					con.Open();

					string delPos = "DELETE FROM Position Where [idPos]=" + idPosTextBox.Text;
					SqlCommand delp = new SqlCommand(delPos, con);
					delp.ExecuteNonQuery();

					double sum = 0;
					SqlCommand sel = new SqlCommand("Select [Заявленная сумма] From Position Where idPos <>'" + idPosTextBox.Text + "' AND idForm='" + номер_заявкиTextBox.Text + "'", con);
					SqlDataReader reader = sel.ExecuteReader();
					while (reader.Read())
						sum += Convert.ToDouble(reader[0].ToString());
					общая_суммаTextBox.Text = sum.ToString("N");

					using (SqlCommand command = new SqlCommand("Update Form Set [Общая сумма] = @Sum Where [Номер заявки]=" + номер_заявкиTextBox.Text, con))
					{
						command.Parameters.AddWithValue("Sum", Convert.ToDouble(Convert.ToDouble(общая_суммаTextBox.Text).ToString("N")));
						command.ExecuteNonQuery();
					}
					this.positionTableAdapter.Update(this.formsDataSet2);
					this.formTableAdapter.Update(this.formsDataSet2);
					this.formTableAdapter.Fill(this.formsDataSet2.Form);
					this.positionTableAdapter.Fill(this.formsDataSet2.Position);
				}
				catch
				{
					MessageBox.Show("Запись не найдена");
				}
				finally
				{
					con.Close();
				}
			}

	
		}

		private void button1_Click(object sender, EventArgs e)
		{
			con.Open();
			try
			{
				using (SqlCommand command1 = new SqlCommand("Insert Into Position ([Заявленная сумма], Комментарий, [Вложенные файлы], idForm) Values(@Summ, @Com, @Files, @idForm)", con))
				{
					command1.Parameters.AddWithValue("Summ", Convert.ToDouble(Convert.ToDouble(заявленная_суммаTextBox.Text).ToString("0.00")));
					command1.Parameters.AddWithValue("Com", richTextBox1.Text);
					command1.Parameters.AddWithValue("Files", Path.GetFileName(PathBox.Text));
					command1.Parameters.AddWithValue("idForm", int.Parse(номер_заявкиTextBox.Text));
					command1.ExecuteNonQuery();
				}
				this.positionTableAdapter.Update(this.formsDataSet2);
				this.formTableAdapter.Update(this.formsDataSet2);
				this.formTableAdapter.Fill(this.formsDataSet2.Form);
				this.positionTableAdapter.Fill(this.formsDataSet2.Position);

				if (PathBox.Text != "")
				{
					string name = Path.GetFileName(PathBox.Text);
					string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files\\" + name);

					File.Copy(PathBox.Text, path, true);
				}
			}
			catch
			{
				MessageBox.Show("Неверные данные");
			}
			finally
			{
				con.Close();
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog();
			
			if (open.ShowDialog() != DialogResult.OK) return;
			label1.Visible = false;
			PathBox.Visible = true;
			PathBox.Text = open.FileName;
		}

		private void заявленная_суммаTextBox_Leave(object sender, EventArgs e)
		{
			if (заявленная_суммаTextBox.Text == "0")
				return;
			try
			{
				con.Open();

				double sum = Convert.ToDouble(заявленная_суммаTextBox.Text);
				заявленная_суммаTextBox.Text = Convert.ToDouble(заявленная_суммаTextBox.Text).ToString("N");
				
				SqlCommand sel = new SqlCommand("Select [Заявленная сумма] From Position Where idPos <>'" + idPosTextBox.Text + "' AND idForm='" + номер_заявкиTextBox.Text + "'", con);
				SqlDataReader reader = sel.ExecuteReader();
				while (reader.Read())
					sum += Convert.ToDouble(reader[0].ToString());
				общая_суммаTextBox.Text = sum.ToString("N");
			}
			catch
			{
				MessageBox.Show("Неверный формат");
			}
			finally
			{
				con.Close();
			}
		}

		private void общая_суммаTextBox_Leave(object sender, EventArgs e)
		{
			if (общая_суммаTextBox.Text == "")
				return;
			try
			{
				общая_суммаTextBox.Text = Convert.ToDouble(общая_суммаTextBox.Text).ToString("N");
			}
			catch
			{
				MessageBox.Show("Неверный формат");
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
