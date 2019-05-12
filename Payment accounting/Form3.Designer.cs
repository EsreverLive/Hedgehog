namespace Payment_accounting
{
	partial class Form3
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
			System.Windows.Forms.Label заявленная_суммаLabel;
			System.Windows.Forms.Label комментарийLabel;
			System.Windows.Forms.Label вложенные_файлыLabel;
			System.Windows.Forms.Label номер_заявкиLabel;
			System.Windows.Forms.Label датаLabel;
			System.Windows.Forms.Label фИОLabel;
			System.Windows.Forms.Label типLabel;
			System.Windows.Forms.Label общая_суммаLabel;
			this.formsDataSet2 = new Payment_accounting.FormsDataSet2();
			this.formBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.formTableAdapter = new Payment_accounting.FormsDataSet2TableAdapters.FormTableAdapter();
			this.tableAdapterManager = new Payment_accounting.FormsDataSet2TableAdapters.TableAdapterManager();
			this.positionTableAdapter = new Payment_accounting.FormsDataSet2TableAdapters.PositionTableAdapter();
			this.formDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.positionBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.positionDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.заявленная_суммаTextBox = new System.Windows.Forms.TextBox();
			this.idFormTextBox = new System.Windows.Forms.TextBox();
			this.idPosTextBox = new System.Windows.Forms.TextBox();
			this.номер_заявкиTextBox = new System.Windows.Forms.TextBox();
			this.датаDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.фИОTextBox = new System.Windows.Forms.TextBox();
			this.общая_суммаTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.PathBox = new System.Windows.Forms.TextBox();
			this.button5 = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			заявленная_суммаLabel = new System.Windows.Forms.Label();
			комментарийLabel = new System.Windows.Forms.Label();
			вложенные_файлыLabel = new System.Windows.Forms.Label();
			номер_заявкиLabel = new System.Windows.Forms.Label();
			датаLabel = new System.Windows.Forms.Label();
			фИОLabel = new System.Windows.Forms.Label();
			типLabel = new System.Windows.Forms.Label();
			общая_суммаLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.formsDataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.formBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.formDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.positionDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// заявленная_суммаLabel
			// 
			заявленная_суммаLabel.AutoSize = true;
			заявленная_суммаLabel.Location = new System.Drawing.Point(385, 260);
			заявленная_суммаLabel.Name = "заявленная_суммаLabel";
			заявленная_суммаLabel.Size = new System.Drawing.Size(107, 13);
			заявленная_суммаLabel.TabIndex = 3;
			заявленная_суммаLabel.Text = "Заявленная сумма:";
			// 
			// комментарийLabel
			// 
			комментарийLabel.AutoSize = true;
			комментарийLabel.Location = new System.Drawing.Point(404, 288);
			комментарийLabel.Name = "комментарийLabel";
			комментарийLabel.Size = new System.Drawing.Size(80, 13);
			комментарийLabel.TabIndex = 5;
			комментарийLabel.Text = "Комментарий:";
			// 
			// вложенные_файлыLabel
			// 
			вложенные_файлыLabel.AutoSize = true;
			вложенные_файлыLabel.Location = new System.Drawing.Point(385, 416);
			вложенные_файлыLabel.Name = "вложенные_файлыLabel";
			вложенные_файлыLabel.Size = new System.Drawing.Size(106, 13);
			вложенные_файлыLabel.TabIndex = 7;
			вложенные_файлыLabel.Text = "Вложенные файлы:";
			// 
			// номер_заявкиLabel
			// 
			номер_заявкиLabel.AutoSize = true;
			номер_заявкиLabel.Location = new System.Drawing.Point(408, 91);
			номер_заявкиLabel.Name = "номер_заявкиLabel";
			номер_заявкиLabel.Size = new System.Drawing.Size(83, 13);
			номер_заявкиLabel.TabIndex = 13;
			номер_заявкиLabel.Text = "Номер заявки:";
			// 
			// датаLabel
			// 
			датаLabel.AutoSize = true;
			датаLabel.Location = new System.Drawing.Point(408, 118);
			датаLabel.Name = "датаLabel";
			датаLabel.Size = new System.Drawing.Size(36, 13);
			датаLabel.TabIndex = 15;
			датаLabel.Text = "Дата:";
			// 
			// фИОLabel
			// 
			фИОLabel.AutoSize = true;
			фИОLabel.Location = new System.Drawing.Point(408, 143);
			фИОLabel.Name = "фИОLabel";
			фИОLabel.Size = new System.Drawing.Size(37, 13);
			фИОLabel.TabIndex = 17;
			фИОLabel.Text = "ФИО:";
			// 
			// типLabel
			// 
			типLabel.AutoSize = true;
			типLabel.Location = new System.Drawing.Point(408, 169);
			типLabel.Name = "типLabel";
			типLabel.Size = new System.Drawing.Size(29, 13);
			типLabel.TabIndex = 19;
			типLabel.Text = "Тип:";
			// 
			// общая_суммаLabel
			// 
			общая_суммаLabel.AutoSize = true;
			общая_суммаLabel.Location = new System.Drawing.Point(408, 195);
			общая_суммаLabel.Name = "общая_суммаLabel";
			общая_суммаLabel.Size = new System.Drawing.Size(81, 13);
			общая_суммаLabel.TabIndex = 21;
			общая_суммаLabel.Text = "Общая сумма:";
			// 
			// formsDataSet2
			// 
			this.formsDataSet2.DataSetName = "FormsDataSet2";
			this.formsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// formBindingSource
			// 
			this.formBindingSource.DataMember = "Form";
			this.formBindingSource.DataSource = this.formsDataSet2;
			// 
			// formTableAdapter
			// 
			this.formTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.FormTableAdapter = this.formTableAdapter;
			this.tableAdapterManager.PositionTableAdapter = this.positionTableAdapter;
			this.tableAdapterManager.UpdateOrder = Payment_accounting.FormsDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// positionTableAdapter
			// 
			this.positionTableAdapter.ClearBeforeFill = true;
			// 
			// formDataGridView
			// 
			this.formDataGridView.AllowUserToAddRows = false;
			this.formDataGridView.AllowUserToDeleteRows = false;
			this.formDataGridView.AutoGenerateColumns = false;
			this.formDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.formDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
			this.formDataGridView.DataSource = this.formBindingSource;
			this.formDataGridView.Location = new System.Drawing.Point(12, 28);
			this.formDataGridView.Name = "formDataGridView";
			this.formDataGridView.Size = new System.Drawing.Size(143, 220);
			this.formDataGridView.TabIndex = 1;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Номер заявки";
			this.dataGridViewTextBoxColumn1.HeaderText = "Номер заявки";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// positionBindingSource
			// 
			this.positionBindingSource.DataMember = "FK_Position_ToForm";
			this.positionBindingSource.DataSource = this.formBindingSource;
			// 
			// positionDataGridView
			// 
			this.positionDataGridView.AutoGenerateColumns = false;
			this.positionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.positionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
			this.positionDataGridView.DataSource = this.positionBindingSource;
			this.positionDataGridView.Location = new System.Drawing.Point(12, 254);
			this.positionDataGridView.Name = "positionDataGridView";
			this.positionDataGridView.Size = new System.Drawing.Size(344, 220);
			this.positionDataGridView.TabIndex = 2;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "Заявленная сумма";
			this.dataGridViewTextBoxColumn6.HeaderText = "Заявленная сумма";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "Комментарий";
			this.dataGridViewTextBoxColumn7.HeaderText = "Комментарий";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.DataPropertyName = "Вложенные файлы";
			this.dataGridViewTextBoxColumn8.HeaderText = "Вложенные файлы";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			// 
			// заявленная_суммаTextBox
			// 
			this.заявленная_суммаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.positionBindingSource, "Заявленная сумма", true));
			this.заявленная_суммаTextBox.Location = new System.Drawing.Point(498, 257);
			this.заявленная_суммаTextBox.Name = "заявленная_суммаTextBox";
			this.заявленная_суммаTextBox.Size = new System.Drawing.Size(100, 20);
			this.заявленная_суммаTextBox.TabIndex = 4;
			this.заявленная_суммаTextBox.Leave += new System.EventHandler(this.заявленная_суммаTextBox_Leave);
			// 
			// idFormTextBox
			// 
			this.idFormTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.positionBindingSource, "idForm", true));
			this.idFormTextBox.Location = new System.Drawing.Point(289, 146);
			this.idFormTextBox.Name = "idFormTextBox";
			this.idFormTextBox.Size = new System.Drawing.Size(100, 20);
			this.idFormTextBox.TabIndex = 10;
			this.idFormTextBox.Visible = false;
			// 
			// idPosTextBox
			// 
			this.idPosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.positionBindingSource, "idPos", true));
			this.idPosTextBox.Location = new System.Drawing.Point(12, 2);
			this.idPosTextBox.Name = "idPosTextBox";
			this.idPosTextBox.Size = new System.Drawing.Size(37, 20);
			this.idPosTextBox.TabIndex = 12;
			// 
			// номер_заявкиTextBox
			// 
			this.номер_заявкиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.formBindingSource, "Номер заявки", true));
			this.номер_заявкиTextBox.Location = new System.Drawing.Point(497, 88);
			this.номер_заявкиTextBox.Name = "номер_заявкиTextBox";
			this.номер_заявкиTextBox.ReadOnly = true;
			this.номер_заявкиTextBox.Size = new System.Drawing.Size(200, 20);
			this.номер_заявкиTextBox.TabIndex = 14;
			// 
			// датаDateTimePicker
			// 
			this.датаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.formBindingSource, "Дата", true));
			this.датаDateTimePicker.Location = new System.Drawing.Point(497, 114);
			this.датаDateTimePicker.Name = "датаDateTimePicker";
			this.датаDateTimePicker.Size = new System.Drawing.Size(200, 20);
			this.датаDateTimePicker.TabIndex = 16;
			// 
			// фИОTextBox
			// 
			this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.formBindingSource, "ФИО", true));
			this.фИОTextBox.Location = new System.Drawing.Point(497, 140);
			this.фИОTextBox.Name = "фИОTextBox";
			this.фИОTextBox.Size = new System.Drawing.Size(200, 20);
			this.фИОTextBox.TabIndex = 18;
			// 
			// общая_суммаTextBox
			// 
			this.общая_суммаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.formBindingSource, "Общая сумма", true));
			this.общая_суммаTextBox.Location = new System.Drawing.Point(497, 192);
			this.общая_суммаTextBox.Name = "общая_суммаTextBox";
			this.общая_суммаTextBox.ReadOnly = true;
			this.общая_суммаTextBox.Size = new System.Drawing.Size(200, 20);
			this.общая_суммаTextBox.TabIndex = 22;
			this.общая_суммаTextBox.Text = "0,00";
			this.общая_суммаTextBox.Leave += new System.EventHandler(this.общая_суммаTextBox_Leave);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.positionBindingSource, "Вложенные файлы", true));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label1.Location = new System.Drawing.Point(515, 420);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 23;
			this.label1.Text = "label1";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.positionBindingSource, "Комментарий", true));
			this.richTextBox1.Location = new System.Drawing.Point(498, 283);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(258, 122);
			this.richTextBox1.TabIndex = 24;
			this.richTextBox1.Text = "";
			// 
			// comboBox1
			// 
			this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.formBindingSource, "Тип", true));
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "тип1",
            "тип2",
            "тип3"});
			this.comboBox1.Location = new System.Drawing.Point(497, 165);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(200, 21);
			this.comboBox1.TabIndex = 25;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(364, 470);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(118, 23);
			this.button1.TabIndex = 26;
			this.button1.Text = "Добавить позицию";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(488, 470);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(141, 23);
			this.button2.TabIndex = 27;
			this.button2.Text = "Сохранить изменения";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(635, 470);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(120, 23);
			this.button3.TabIndex = 28;
			this.button3.Text = "Удалить позицию";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(488, 413);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(24, 23);
			this.button4.TabIndex = 29;
			this.button4.Text = "...";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// PathBox
			// 
			this.PathBox.Location = new System.Drawing.Point(518, 415);
			this.PathBox.Name = "PathBox";
			this.PathBox.Size = new System.Drawing.Size(100, 20);
			this.PathBox.TabIndex = 30;
			this.PathBox.Visible = false;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(336, 513);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 31;
			this.button5.Text = "Закрыть";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(811, 548);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.PathBox);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(номер_заявкиLabel);
			this.Controls.Add(this.номер_заявкиTextBox);
			this.Controls.Add(датаLabel);
			this.Controls.Add(this.датаDateTimePicker);
			this.Controls.Add(фИОLabel);
			this.Controls.Add(this.фИОTextBox);
			this.Controls.Add(типLabel);
			this.Controls.Add(общая_суммаLabel);
			this.Controls.Add(this.общая_суммаTextBox);
			this.Controls.Add(заявленная_суммаLabel);
			this.Controls.Add(this.заявленная_суммаTextBox);
			this.Controls.Add(комментарийLabel);
			this.Controls.Add(вложенные_файлыLabel);
			this.Controls.Add(this.idFormTextBox);
			this.Controls.Add(this.idPosTextBox);
			this.Controls.Add(this.positionDataGridView);
			this.Controls.Add(this.formDataGridView);
			this.Name = "Form3";
			this.Text = "Редактирование заявок";
			this.Load += new System.EventHandler(this.Form3_Load);
			((System.ComponentModel.ISupportInitialize)(this.formsDataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.formBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.formDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.positionDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private FormsDataSet2 formsDataSet2;
		private System.Windows.Forms.BindingSource formBindingSource;
		private FormsDataSet2TableAdapters.FormTableAdapter formTableAdapter;
		private FormsDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.DataGridView formDataGridView;
		private FormsDataSet2TableAdapters.PositionTableAdapter positionTableAdapter;
		private System.Windows.Forms.BindingSource positionBindingSource;
		private System.Windows.Forms.DataGridView positionDataGridView;
		private System.Windows.Forms.TextBox заявленная_суммаTextBox;
		private System.Windows.Forms.TextBox idFormTextBox;
		private System.Windows.Forms.TextBox idPosTextBox;
		private System.Windows.Forms.TextBox номер_заявкиTextBox;
		private System.Windows.Forms.DateTimePicker датаDateTimePicker;
		private System.Windows.Forms.TextBox фИОTextBox;
		private System.Windows.Forms.TextBox общая_суммаTextBox;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		public System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.TextBox PathBox;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}