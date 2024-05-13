namespace bd8.Views
{
    partial class StudentView
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabStudentList = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSortBySurname = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStudentSearch = new System.Windows.Forms.TextBox();
            this.tabStudentDetails = new System.Windows.Forms.TabPage();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStudentForm = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStudentGender = new System.Windows.Forms.TextBox();
            this.dateStudentPicker = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStudentPatronymic = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStudentSurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSortByName = new System.Windows.Forms.Button();
            this.btnResetFilters = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabStudentList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabStudentDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(663, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Студенти";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1529, 80);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabStudentList);
            this.tabControl1.Controls.Add(this.tabStudentDetails);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Source Sans Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1529, 833);
            this.tabControl1.TabIndex = 2;
            // 
            // tabStudentList
            // 
            this.tabStudentList.Controls.Add(this.btnResetFilters);
            this.tabStudentList.Controls.Add(this.btnSortByName);
            this.tabStudentList.Controls.Add(this.label10);
            this.tabStudentList.Controls.Add(this.btnSortBySurname);
            this.tabStudentList.Controls.Add(this.btnDelete);
            this.tabStudentList.Controls.Add(this.btnEdit);
            this.tabStudentList.Controls.Add(this.btnAddNew);
            this.tabStudentList.Controls.Add(this.dataGridView1);
            this.tabStudentList.Controls.Add(this.btnSearch);
            this.tabStudentList.Controls.Add(this.label2);
            this.tabStudentList.Controls.Add(this.txtStudentSearch);
            this.tabStudentList.Font = new System.Drawing.Font("Source Sans Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabStudentList.ForeColor = System.Drawing.Color.Black;
            this.tabStudentList.Location = new System.Drawing.Point(4, 34);
            this.tabStudentList.Name = "tabStudentList";
            this.tabStudentList.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudentList.Size = new System.Drawing.Size(1521, 795);
            this.tabStudentList.TabIndex = 0;
            this.tabStudentList.Text = "Список студентів";
            this.tabStudentList.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1340, 436);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 31);
            this.label10.TabIndex = 8;
            this.label10.Text = "Сортування:";
            // 
            // btnSortBySurname
            // 
            this.btnSortBySurname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSortBySurname.BackColor = System.Drawing.Color.DimGray;
            this.btnSortBySurname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSortBySurname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortBySurname.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSortBySurname.ForeColor = System.Drawing.Color.White;
            this.btnSortBySurname.Location = new System.Drawing.Point(1292, 479);
            this.btnSortBySurname.Name = "btnSortBySurname";
            this.btnSortBySurname.Size = new System.Drawing.Size(210, 49);
            this.btnSortBySurname.TabIndex = 7;
            this.btnSortBySurname.Text = "За прізвищем (А-Я)";
            this.btnSortBySurname.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.DimGray;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(1292, 309);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(210, 49);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Видалити";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.DimGray;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(1292, 226);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(210, 49);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Редагувати";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.BackColor = System.Drawing.Color.DimGray;
            this.btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Location = new System.Drawing.Point(1292, 145);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(210, 49);
            this.btnAddNew.TabIndex = 4;
            this.btnAddNew.Text = "Додати";
            this.btnAddNew.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1230, 571);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.DimGray;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1112, 82);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(153, 36);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Пошук";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пошук студента:";
            // 
            // txtStudentSearch
            // 
            this.txtStudentSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStudentSearch.Location = new System.Drawing.Point(35, 83);
            this.txtStudentSearch.Name = "txtStudentSearch";
            this.txtStudentSearch.Size = new System.Drawing.Size(1031, 33);
            this.txtStudentSearch.TabIndex = 0;
            // 
            // tabStudentDetails
            // 
            this.tabStudentDetails.Controls.Add(this.txtStudentID);
            this.tabStudentDetails.Controls.Add(this.label9);
            this.tabStudentDetails.Controls.Add(this.txtStudentForm);
            this.tabStudentDetails.Controls.Add(this.label8);
            this.tabStudentDetails.Controls.Add(this.txtStudentGender);
            this.tabStudentDetails.Controls.Add(this.dateStudentPicker);
            this.tabStudentDetails.Controls.Add(this.btnCancel);
            this.tabStudentDetails.Controls.Add(this.btnSaveChanges);
            this.tabStudentDetails.Controls.Add(this.label7);
            this.tabStudentDetails.Controls.Add(this.label5);
            this.tabStudentDetails.Controls.Add(this.txtStudentPatronymic);
            this.tabStudentDetails.Controls.Add(this.label6);
            this.tabStudentDetails.Controls.Add(this.txtStudentSurname);
            this.tabStudentDetails.Controls.Add(this.label4);
            this.tabStudentDetails.Controls.Add(this.txtStudentName);
            this.tabStudentDetails.Controls.Add(this.label3);
            this.tabStudentDetails.Location = new System.Drawing.Point(4, 34);
            this.tabStudentDetails.Name = "tabStudentDetails";
            this.tabStudentDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudentDetails.Size = new System.Drawing.Size(1521, 795);
            this.tabStudentDetails.TabIndex = 1;
            this.tabStudentDetails.Text = "Деталі";
            this.tabStudentDetails.UseVisualStyleBackColor = true;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(136, 80);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(341, 33);
            this.txtStudentID.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(130, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 36);
            this.label9.TabIndex = 16;
            this.label9.Text = "ID:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtStudentForm
            // 
            this.txtStudentForm.Location = new System.Drawing.Point(136, 631);
            this.txtStudentForm.Name = "txtStudentForm";
            this.txtStudentForm.Size = new System.Drawing.Size(341, 33);
            this.txtStudentForm.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(130, 584);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 36);
            this.label8.TabIndex = 14;
            this.label8.Text = "Клас:";
            // 
            // txtStudentGender
            // 
            this.txtStudentGender.Location = new System.Drawing.Point(136, 535);
            this.txtStudentGender.Name = "txtStudentGender";
            this.txtStudentGender.Size = new System.Drawing.Size(341, 33);
            this.txtStudentGender.TabIndex = 13;
            // 
            // dateStudentPicker
            // 
            this.dateStudentPicker.Location = new System.Drawing.Point(136, 437);
            this.dateStudentPicker.Name = "dateStudentPicker";
            this.dateStudentPicker.Size = new System.Drawing.Size(341, 33);
            this.dateStudentPicker.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DimGray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(328, 704);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(149, 48);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Відміна";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.DimGray;
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveChanges.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanges.Location = new System.Drawing.Point(136, 704);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(149, 48);
            this.btnSaveChanges.TabIndex = 10;
            this.btnSaveChanges.Text = "Зберегти";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(130, 488);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 36);
            this.label7.TabIndex = 8;
            this.label7.Text = "Стать:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(130, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 36);
            this.label5.TabIndex = 6;
            this.label5.Text = "Дата народження:";
            // 
            // txtStudentPatronymic
            // 
            this.txtStudentPatronymic.Location = new System.Drawing.Point(136, 338);
            this.txtStudentPatronymic.Name = "txtStudentPatronymic";
            this.txtStudentPatronymic.Size = new System.Drawing.Size(341, 33);
            this.txtStudentPatronymic.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(130, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 36);
            this.label6.TabIndex = 4;
            this.label6.Text = "По-батькові:";
            // 
            // txtStudentSurname
            // 
            this.txtStudentSurname.Location = new System.Drawing.Point(136, 165);
            this.txtStudentSurname.Name = "txtStudentSurname";
            this.txtStudentSurname.Size = new System.Drawing.Size(341, 33);
            this.txtStudentSurname.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(130, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 36);
            this.label4.TabIndex = 2;
            this.label4.Text = "Прізвище:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(136, 250);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(341, 33);
            this.txtStudentName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(130, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ім\'я:";
            // 
            // btnSortByName
            // 
            this.btnSortByName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSortByName.BackColor = System.Drawing.Color.DimGray;
            this.btnSortByName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSortByName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortByName.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSortByName.ForeColor = System.Drawing.Color.White;
            this.btnSortByName.Location = new System.Drawing.Point(1292, 547);
            this.btnSortByName.Name = "btnSortByName";
            this.btnSortByName.Size = new System.Drawing.Size(210, 49);
            this.btnSortByName.TabIndex = 12;
            this.btnSortByName.Text = "За іменем (А-Я)";
            this.btnSortByName.UseVisualStyleBackColor = false;
            // 
            // btnResetFilters
            // 
            this.btnResetFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetFilters.BackColor = System.Drawing.Color.DimGray;
            this.btnResetFilters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetFilters.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnResetFilters.ForeColor = System.Drawing.Color.White;
            this.btnResetFilters.Location = new System.Drawing.Point(1292, 667);
            this.btnResetFilters.Name = "btnResetFilters";
            this.btnResetFilters.Size = new System.Drawing.Size(210, 49);
            this.btnResetFilters.TabIndex = 13;
            this.btnResetFilters.Text = "Скинути фільтри";
            this.btnResetFilters.UseVisualStyleBackColor = false;
            // 
            // StudentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1529, 833);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabStudentList.ResumeLayout(false);
            this.tabStudentList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabStudentDetails.ResumeLayout(false);
            this.tabStudentDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabStudentList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStudentSearch;
        private System.Windows.Forms.TabPage tabStudentDetails;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStudentPatronymic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStudentSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateStudentPicker;
        private System.Windows.Forms.TextBox txtStudentGender;
        private System.Windows.Forms.TextBox txtStudentForm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSortBySurname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSortByName;
        private System.Windows.Forms.Button btnResetFilters;
    }
}