namespace Payment_accounting
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.idBox = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.TypeBox = new System.Windows.Forms.ComboBox();
			this.SumBox = new System.Windows.Forms.TextBox();
			this.FIOBox = new System.Windows.Forms.TextBox();
			this.DateBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.button6 = new System.Windows.Forms.Button();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.заявленнаяСуммаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.комментарийDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.вложенныеФайлыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idFormDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idPosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fKPositionToFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.formBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.formsDataSet2 = new Payment_accounting.FormsDataSet2();
			this.button5 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.номерЗаявкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.типDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.общаяСуммаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.formTableAdapter = new Payment_accounting.FormsDataSet2TableAdapters.FormTableAdapter();
			this.positionTableAdapter = new Payment_accounting.FormsDataSet2TableAdapters.PositionTableAdapter();
			this.formBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.fKPositionToFormBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.fKPositionToFormBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.fKPositionToFormBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
			this.positionBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tableAdapterManager = new Payment_accounting.FormsDataSet2TableAdapters.TableAdapterManager();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fKPositionToFormBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.formBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.formsDataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.formBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fKPositionToFormBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fKPositionToFormBindingSource2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fKPositionToFormBindingSource3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(608, 574);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.idBox);
			this.tabPage1.Controls.Add(this.button3);
			this.tabPage1.Controls.Add(this.TypeBox);
			this.tabPage1.Controls.Add(this.SumBox);
			this.tabPage1.Controls.Add(this.FIOBox);
			this.tabPage1.Controls.Add(this.DateBox);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.button1);
			this.tabPage1.Location = new System.Drawing.Point(4, 24);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(600, 546);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Создание заявок";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// idBox
			// 
			this.idBox.Location = new System.Drawing.Point(232, 51);
			this.idBox.Name = "idBox";
			this.idBox.ReadOnly = true;
			this.idBox.Size = new System.Drawing.Size(121, 22);
			this.idBox.TabIndex = 24;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(340, 251);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 23;
			this.button3.Text = "Закрыть";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// TypeBox
			// 
			this.TypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.TypeBox.FormattingEnabled = true;
			this.TypeBox.Items.AddRange(new object[] {
            "тип1",
            "тип2",
            "тип3"});
			this.TypeBox.Location = new System.Drawing.Point(232, 138);
			this.TypeBox.Name = "TypeBox";
			this.TypeBox.Size = new System.Drawing.Size(121, 23);
			this.TypeBox.TabIndex = 22;
			// 
			// SumBox
			// 
			this.SumBox.Location = new System.Drawing.Point(232, 170);
			this.SumBox.Name = "SumBox";
			this.SumBox.ReadOnly = true;
			this.SumBox.Size = new System.Drawing.Size(121, 22);
			this.SumBox.TabIndex = 21;
			this.SumBox.Text = "0,00";
			// 
			// FIOBox
			// 
			this.FIOBox.Location = new System.Drawing.Point(232, 111);
			this.FIOBox.Name = "FIOBox";
			this.FIOBox.Size = new System.Drawing.Size(121, 22);
			this.FIOBox.TabIndex = 20;
			// 
			// DateBox
			// 
			this.DateBox.Location = new System.Drawing.Point(232, 81);
			this.DateBox.Name = "DateBox";
			this.DateBox.ReadOnly = true;
			this.DateBox.Size = new System.Drawing.Size(121, 22);
			this.DateBox.TabIndex = 19;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(146, 173);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(85, 15);
			this.label5.TabIndex = 18;
			this.label5.Text = "Общая сумма";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(172, 144);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 15);
			this.label4.TabIndex = 17;
			this.label4.Text = "Тип";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(172, 114);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 15);
			this.label3.TabIndex = 16;
			this.label3.Text = "ФИО";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(172, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(33, 15);
			this.label2.TabIndex = 15;
			this.label2.Text = "Дата";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(142, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 15);
			this.label1.TabIndex = 14;
			this.label1.Text = "Номер заявки";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(136, 248);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(122, 26);
			this.button1.TabIndex = 0;
			this.button1.Text = "Создать позицию";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// tabPage2
			// 
			this.tabPage2.AutoScroll = true;
			this.tabPage2.Controls.Add(this.button6);
			this.tabPage2.Controls.Add(this.dataGridView2);
			this.tabPage2.Controls.Add(this.button5);
			this.tabPage2.Controls.Add(this.button2);
			this.tabPage2.Controls.Add(this.dataGridView1);
			this.tabPage2.Location = new System.Drawing.Point(4, 24);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(600, 546);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Список заявок";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(232, 408);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(102, 23);
			this.button6.TabIndex = 5;
			this.button6.Text = "Открыть файл";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.AutoGenerateColumns = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.заявленнаяСуммаDataGridViewTextBoxColumn,
            this.комментарийDataGridViewTextBoxColumn,
            this.вложенныеФайлыDataGridViewTextBoxColumn,
            this.idFormDataGridViewTextBoxColumn,
            this.idPosDataGridViewTextBoxColumn});
			this.dataGridView2.DataSource = this.fKPositionToFormBindingSource;
			this.dataGridView2.Location = new System.Drawing.Point(3, 247);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.ReadOnly = true;
			this.dataGridView2.Size = new System.Drawing.Size(594, 155);
			this.dataGridView2.TabIndex = 4;
			// 
			// заявленнаяСуммаDataGridViewTextBoxColumn
			// 
			this.заявленнаяСуммаDataGridViewTextBoxColumn.DataPropertyName = "Заявленная сумма";
			this.заявленнаяСуммаDataGridViewTextBoxColumn.HeaderText = "Заявленная сумма";
			this.заявленнаяСуммаDataGridViewTextBoxColumn.Name = "заявленнаяСуммаDataGridViewTextBoxColumn";
			this.заявленнаяСуммаDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// комментарийDataGridViewTextBoxColumn
			// 
			this.комментарийDataGridViewTextBoxColumn.DataPropertyName = "Комментарий";
			this.комментарийDataGridViewTextBoxColumn.HeaderText = "Комментарий";
			this.комментарийDataGridViewTextBoxColumn.Name = "комментарийDataGridViewTextBoxColumn";
			this.комментарийDataGridViewTextBoxColumn.ReadOnly = true;
			this.комментарийDataGridViewTextBoxColumn.Width = 300;
			// 
			// вложенныеФайлыDataGridViewTextBoxColumn
			// 
			this.вложенныеФайлыDataGridViewTextBoxColumn.DataPropertyName = "Вложенные файлы";
			this.вложенныеФайлыDataGridViewTextBoxColumn.HeaderText = "Вложенные файлы";
			this.вложенныеФайлыDataGridViewTextBoxColumn.Name = "вложенныеФайлыDataGridViewTextBoxColumn";
			this.вложенныеФайлыDataGridViewTextBoxColumn.ReadOnly = true;
			this.вложенныеФайлыDataGridViewTextBoxColumn.Width = 150;
			// 
			// idFormDataGridViewTextBoxColumn
			// 
			this.idFormDataGridViewTextBoxColumn.DataPropertyName = "idForm";
			this.idFormDataGridViewTextBoxColumn.HeaderText = "idForm";
			this.idFormDataGridViewTextBoxColumn.Name = "idFormDataGridViewTextBoxColumn";
			this.idFormDataGridViewTextBoxColumn.ReadOnly = true;
			this.idFormDataGridViewTextBoxColumn.Visible = false;
			// 
			// idPosDataGridViewTextBoxColumn
			// 
			this.idPosDataGridViewTextBoxColumn.DataPropertyName = "idPos";
			this.idPosDataGridViewTextBoxColumn.HeaderText = "idPos";
			this.idPosDataGridViewTextBoxColumn.Name = "idPosDataGridViewTextBoxColumn";
			this.idPosDataGridViewTextBoxColumn.ReadOnly = true;
			this.idPosDataGridViewTextBoxColumn.Visible = false;
			// 
			// fKPositionToFormBindingSource
			// 
			this.fKPositionToFormBindingSource.DataMember = "FK_Position_ToForm";
			this.fKPositionToFormBindingSource.DataSource = this.formBindingSource;
			// 
			// formBindingSource
			// 
			this.formBindingSource.DataMember = "Form";
			this.formBindingSource.DataSource = this.bindingSource1;
			// 
			// bindingSource1
			// 
			this.bindingSource1.DataSource = this.formsDataSet2;
			this.bindingSource1.Position = 0;
			// 
			// formsDataSet2
			// 
			this.formsDataSet2.DataSetName = "FormsDataSet2";
			this.formsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(307, 197);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(107, 23);
			this.button5.TabIndex = 3;
			this.button5.Text = "Удалить форму";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(142, 197);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(103, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "Редактировать";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерЗаявкиDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.типDataGridViewTextBoxColumn,
            this.общаяСуммаDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.formBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(597, 170);
			this.dataGridView1.TabIndex = 0;
			// 
			// номерЗаявкиDataGridViewTextBoxColumn
			// 
			this.номерЗаявкиDataGridViewTextBoxColumn.DataPropertyName = "Номер заявки";
			this.номерЗаявкиDataGridViewTextBoxColumn.HeaderText = "Номер заявки";
			this.номерЗаявкиDataGridViewTextBoxColumn.Name = "номерЗаявкиDataGridViewTextBoxColumn";
			this.номерЗаявкиDataGridViewTextBoxColumn.ReadOnly = true;
			this.номерЗаявкиDataGridViewTextBoxColumn.Width = 70;
			// 
			// датаDataGridViewTextBoxColumn
			// 
			this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
			this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
			this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
			this.датаDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// фИОDataGridViewTextBoxColumn
			// 
			this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
			this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
			this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
			this.фИОDataGridViewTextBoxColumn.ReadOnly = true;
			this.фИОDataGridViewTextBoxColumn.Width = 210;
			// 
			// типDataGridViewTextBoxColumn
			// 
			this.типDataGridViewTextBoxColumn.DataPropertyName = "Тип";
			this.типDataGridViewTextBoxColumn.HeaderText = "Тип";
			this.типDataGridViewTextBoxColumn.Name = "типDataGridViewTextBoxColumn";
			this.типDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// общаяСуммаDataGridViewTextBoxColumn
			// 
			this.общаяСуммаDataGridViewTextBoxColumn.DataPropertyName = "Общая сумма";
			this.общаяСуммаDataGridViewTextBoxColumn.HeaderText = "Общая сумма";
			this.общаяСуммаDataGridViewTextBoxColumn.Name = "общаяСуммаDataGridViewTextBoxColumn";
			this.общаяСуммаDataGridViewTextBoxColumn.ReadOnly = true;
			this.общаяСуммаDataGridViewTextBoxColumn.Width = 70;
			// 
			// formTableAdapter
			// 
			this.formTableAdapter.ClearBeforeFill = true;
			// 
			// positionTableAdapter
			// 
			this.positionTableAdapter.ClearBeforeFill = true;
			// 
			// formBindingSource1
			// 
			this.formBindingSource1.DataMember = "Form";
			this.formBindingSource1.DataSource = this.bindingSource1;
			// 
			// fKPositionToFormBindingSource1
			// 
			this.fKPositionToFormBindingSource1.DataMember = "FK_Position_ToForm";
			this.fKPositionToFormBindingSource1.DataSource = this.formBindingSource;
			// 
			// fKPositionToFormBindingSource2
			// 
			this.fKPositionToFormBindingSource2.DataMember = "FK_Position_ToForm";
			this.fKPositionToFormBindingSource2.DataSource = this.formBindingSource1;
			// 
			// fKPositionToFormBindingSource3
			// 
			this.fKPositionToFormBindingSource3.DataMember = "FK_Position_ToForm";
			this.fKPositionToFormBindingSource3.DataSource = this.formBindingSource1;
			// 
			// positionBindingSource
			// 
			this.positionBindingSource.DataMember = "Position";
			this.positionBindingSource.DataSource = this.formsDataSet2;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.FormTableAdapter = this.formTableAdapter;
			this.tableAdapterManager.PositionTableAdapter = this.positionTableAdapter;
			this.tableAdapterManager.UpdateOrder = Payment_accounting.FormsDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(608, 574);
			this.Controls.Add(this.tabControl1);
			this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Name = "Form1";
			this.Text = "Учет платежей";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fKPositionToFormBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.formBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.formsDataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.formBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fKPositionToFormBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fKPositionToFormBindingSource2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fKPositionToFormBindingSource3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.ComboBox TypeBox;
		private System.Windows.Forms.TextBox FIOBox;
		private System.Windows.Forms.TextBox DateBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource bindingSource1;
		private FormsDataSet2 formsDataSet2;
		private System.Windows.Forms.BindingSource formBindingSource;
		private FormsDataSet2TableAdapters.FormTableAdapter formTableAdapter;
		private System.Windows.Forms.BindingSource fKPositionToFormBindingSource;
		private FormsDataSet2TableAdapters.PositionTableAdapter positionTableAdapter;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox idBox;
		public System.Windows.Forms.TextBox SumBox;
		public System.Windows.Forms.TabPage tabPage1;
		public System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.BindingSource formBindingSource1;
		private System.Windows.Forms.BindingSource fKPositionToFormBindingSource1;
		private System.Windows.Forms.BindingSource fKPositionToFormBindingSource2;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.BindingSource fKPositionToFormBindingSource3;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.DataGridViewTextBoxColumn заявленнаяСуммаDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn комментарийDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn вложенныеФайлыDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idFormDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idPosDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn номерЗаявкиDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn типDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn общаяСуммаDataGridViewTextBoxColumn;
		public System.Windows.Forms.Button button1;
		private System.Windows.Forms.BindingSource positionBindingSource;
		private FormsDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}

