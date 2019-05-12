namespace Payment_accounting
{
	partial class Form2
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
			this.components = new System.ComponentModel.Container();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.SummBox = new System.Windows.Forms.TextBox();
			this.CommBox = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.idBox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.PathBox = new System.Windows.Forms.TextBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(20, 86);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(98, 15);
			this.label6.TabIndex = 5;
			this.label6.Text = "Заявленная сумма";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(17, 111);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(101, 15);
			this.label7.TabIndex = 6;
			this.label7.Text = "Вложенные файлы";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(30, 141);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(74, 15);
			this.label8.TabIndex = 7;
			this.label8.Text = "Комментарий";
			// 
			// SummBox
			// 
			this.SummBox.BackColor = System.Drawing.Color.White;
			this.SummBox.Location = new System.Drawing.Point(120, 83);
			this.SummBox.Name = "SummBox";
			this.SummBox.Size = new System.Drawing.Size(121, 21);
			this.SummBox.TabIndex = 11;
			this.SummBox.Leave += new System.EventHandler(this.SummBox_Leave);
			// 
			// CommBox
			// 
			this.CommBox.Location = new System.Drawing.Point(111, 138);
			this.CommBox.Name = "CommBox";
			this.CommBox.Size = new System.Drawing.Size(280, 93);
			this.CommBox.TabIndex = 12;
			this.CommBox.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(30, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 15);
			this.label1.TabIndex = 13;
			this.label1.Text = "Номер заявки";
			// 
			// idBox
			// 
			this.idBox.Enabled = false;
			this.idBox.Location = new System.Drawing.Point(120, 57);
			this.idBox.Name = "idBox";
			this.idBox.ReadOnly = true;
			this.idBox.Size = new System.Drawing.Size(121, 21);
			this.idBox.TabIndex = 14;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(247, 111);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(24, 23);
			this.button1.TabIndex = 15;
			this.button1.Text = "...";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(111, 251);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 16;
			this.button2.Text = "Добавить";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(264, 251);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 17;
			this.button3.Text = "Закрыть";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// PathBox
			// 
			this.PathBox.Location = new System.Drawing.Point(120, 111);
			this.PathBox.Name = "PathBox";
			this.PathBox.ReadOnly = true;
			this.PathBox.Size = new System.Drawing.Size(121, 21);
			this.PathBox.TabIndex = 18;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(410, 308);
			this.Controls.Add(this.PathBox);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.idBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.CommBox);
			this.Controls.Add(this.SummBox);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Name = "Form2";
			this.Text = "Добавление позиций";
			this.Load += new System.EventHandler(this.Form2_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox SummBox;
		private System.Windows.Forms.RichTextBox CommBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		public System.Windows.Forms.TextBox idBox;
		private System.Windows.Forms.TextBox PathBox;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}