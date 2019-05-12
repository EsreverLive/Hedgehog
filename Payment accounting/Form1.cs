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
using System.Diagnostics;
using System.IO;
using System.Globalization;
using System.Threading;

namespace Payment_accounting
{
	public partial class Form1 : Form
	{
		Form2 form2 = new Form2();

		public int Num;
		SqlConnection con = new SqlConnection();

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.positionTableAdapter.Fill(this.formsDataSet2.Position);
			this.formTableAdapter.Fill(this.formsDataSet2.Form);

			string dBName = "Forms.mdf";
			string dBPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, dBName);

			con.ConnectionString =@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + dBPath + ";Integrated Security=True;MultipleActiveResultSets=true";
			
			string sel = "SELECT max([Номер заявки]) FROM Form";
			
			SqlCommand command1 = new SqlCommand(sel, con);
			con.Open();
			try
			{
				Num = int.Parse(command1.ExecuteScalar().ToString()) + 1;
			}
			catch
			{
				Num = 1;
			}
			con.Close();

			idBox.Text = Num.ToString(); ;
			DateBox.Text = DateTime.Today.ToShortDateString();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (button1.Text == "Создать позицию")
			{
				form2.summ = this.SumBox;
				CreatePosition();
				button1.Text = "Создать форму";
				button3.Text = "Отмена";
			}
			else
			{
				if (TypeBox.Text == "")
				{
					errorProvider1.SetError(TypeBox, "Не заполнено поле");
					return;
				}
				CreateForm();
				button1.Text = "Создать позицию";
				button3.Text = "Закрыть";
			}

		}

		private void button2_Click(object sender, EventArgs e)
		{
				Form3 f3 = new Form3();
				f3.Show();		
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (button3.Text == "Отмена")
			{
				button3.Text = "Закрыть";
				button1.Text = "Создать позицию";
				string id = idBox.Text;
				string delForm = "DELETE FROM Form Where [Номер заявки]=" + id.ToString();
				string delPos = "DELETE FROM Position Where [idForm]=" + id.ToString();
				con.Open();
				SqlCommand delP = new SqlCommand(delPos, con);
				delP.ExecuteNonQuery();
				SqlCommand delF = new SqlCommand(delForm, con);
				delF.ExecuteNonQuery();

				con.Close();
				this.positionTableAdapter.Fill(this.formsDataSet2.Position);
				this.formTableAdapter.Fill(this.formsDataSet2.Form);
			}
			else
				Application.Exit();
		}

	
		private void LoadForm()
		{
			this.positionTableAdapter.Fill(this.formsDataSet2.Position);
			this.formTableAdapter.Fill(this.formsDataSet2.Form);
			
			string sql = "SELECT max([Номер заявки]) FROM Form";
			
			SqlCommand command1 = new SqlCommand(sql, con);
			con.Open();
			Num = int.Parse(command1.ExecuteScalar().ToString()) + 1;
			con.Close();

			DateBox.Text = DateTime.Today.ToShortDateString();
			FIOBox.Text = "";
			TypeBox.Text = "";
			SumBox.Text = "";
			idBox.Text = Num.ToString();
		}


		private void button5_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Вы действительно хотите удалить форму?", "Удаление", MessageBoxButtons.OKCancel) == DialogResult.OK)
			{
				try
				{
					var id = dataGridView1.CurrentRow.Cells[0].Value;
					string delForm = "DELETE FROM Form Where [Номер заявки]=" + id.ToString();
					string delPos = "DELETE FROM Position Where [idForm]=" + id.ToString();

					con.Open();
					SqlCommand delP = new SqlCommand(delPos, con);
					delP.ExecuteNonQuery();
					SqlCommand delF = new SqlCommand(delForm, con);
					delF.ExecuteNonQuery();

					con.Close();
				}
				catch
				{
					MessageBox.Show("Запись не найдена");
				}
			}
			this.positionTableAdapter.Fill(this.formsDataSet2.Position);
			this.formTableAdapter.Fill(this.formsDataSet2.Form);
	
		}

		private void button6_Click(object sender, EventArgs e)
		{
			if (dataGridView2.CurrentRow.Cells[2].Value.ToString() == "")
			{
				MessageBox.Show("Файл отсутствует");
				return;
			}

			string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files\\");
			Process.Start(path + dataGridView2.CurrentRow.Cells[2].Value.ToString());
		}

		private void CreatePosition()
		{
			con.Open();

			using (SqlCommand command = new SqlCommand("INSERT INTO Form([Номер заявки], Дата, ФИО, Тип) VALUES(@id, @date, @FIO, @Type)", con))
			{
				command.Parameters.AddWithValue("id", Convert.ToInt32(idBox.Text));
				command.Parameters.AddWithValue("date", Convert.ToDateTime(DateBox.Text));
				command.Parameters.AddWithValue("FIO", FIOBox.Text);
				command.Parameters.AddWithValue("Type", TypeBox.Text);
				command.ExecuteNonQuery();
			}
			con.Close();

			this.positionTableAdapter.Fill(this.formsDataSet2.Position);
			this.formTableAdapter.Fill(this.formsDataSet2.Form);
			
			form2.idBox.Text = Num.ToString();
			form2.Show();
		}

		private void CreateForm()
		{
			con.Open();
			using (SqlCommand command = new SqlCommand("Update Form Set [Общая сумма] = @Sum, [Номер заявки]= @id, Дата= @date, ФИО= @FIO, Тип=@Type Where [Номер заявки]='" + Num + "'", con))
			{
				command.Parameters.AddWithValue("id", Convert.ToInt32(idBox.Text));
				command.Parameters.AddWithValue("date", Convert.ToDateTime(DateBox.Text));
				command.Parameters.AddWithValue("FIO", FIOBox.Text);
				command.Parameters.AddWithValue("Type", TypeBox.Text);
				command.Parameters.AddWithValue("Sum", Convert.ToDouble(SumBox.Text).ToString("N"));
				command.ExecuteNonQuery();
			}
			this.positionTableAdapter.Fill(this.formsDataSet2.Position);
			this.formTableAdapter.Fill(this.formsDataSet2.Form);
			con.Close();
			LoadForm();
		}
	}
}
