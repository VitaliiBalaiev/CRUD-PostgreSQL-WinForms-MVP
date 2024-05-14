namespace bd8.Views
{
    partial class FormView
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
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabFormList = new System.Windows.Forms.TabPage();
            this.btnResetFilters = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSortByStudentNumber = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFormSearch = new System.Windows.Forms.TextBox();
            this.tabFormDetails = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.txtIdTeacher = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFormName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumberOfStudents = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl3.SuspendLayout();
            this.tabFormList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabFormDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabFormList);
            this.tabControl3.Controls.Add(this.tabFormDetails);
            this.tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl3.Font = new System.Drawing.Font("Source Sans Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl3.Location = new System.Drawing.Point(0, 0);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(1678, 855);
            this.tabControl3.TabIndex = 3;
            // 
            // tabFormList
            // 
            this.tabFormList.BackColor = System.Drawing.Color.White;
            this.tabFormList.Controls.Add(this.btnResetFilters);
            this.tabFormList.Controls.Add(this.label10);
            this.tabFormList.Controls.Add(this.btnSortByStudentNumber);
            this.tabFormList.Controls.Add(this.btnDelete);
            this.tabFormList.Controls.Add(this.btnEdit);
            this.tabFormList.Controls.Add(this.btnAddNew);
            this.tabFormList.Controls.Add(this.dataGridView3);
            this.tabFormList.Controls.Add(this.btnSearch);
            this.tabFormList.Controls.Add(this.label2);
            this.tabFormList.Controls.Add(this.txtFormSearch);
            this.tabFormList.Font = new System.Drawing.Font("Source Sans Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabFormList.ForeColor = System.Drawing.Color.Black;
            this.tabFormList.Location = new System.Drawing.Point(4, 34);
            this.tabFormList.Name = "tabFormList";
            this.tabFormList.Padding = new System.Windows.Forms.Padding(3);
            this.tabFormList.Size = new System.Drawing.Size(1670, 817);
            this.tabFormList.TabIndex = 0;
            this.tabFormList.Text = "Список класів";
            // 
            // btnResetFilters
            // 
            this.btnResetFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetFilters.BackColor = System.Drawing.Color.DimGray;
            this.btnResetFilters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetFilters.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnResetFilters.ForeColor = System.Drawing.Color.White;
            this.btnResetFilters.Location = new System.Drawing.Point(1441, 667);
            this.btnResetFilters.Name = "btnResetFilters";
            this.btnResetFilters.Size = new System.Drawing.Size(210, 49);
            this.btnResetFilters.TabIndex = 13;
            this.btnResetFilters.Text = "Скинути фільтри";
            this.btnResetFilters.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1474, 436);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 31);
            this.label10.TabIndex = 8;
            this.label10.Text = "Сортування:";
            // 
            // btnSortByStudentNumber
            // 
            this.btnSortByStudentNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSortByStudentNumber.BackColor = System.Drawing.Color.DimGray;
            this.btnSortByStudentNumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSortByStudentNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortByStudentNumber.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSortByStudentNumber.ForeColor = System.Drawing.Color.White;
            this.btnSortByStudentNumber.Location = new System.Drawing.Point(1441, 479);
            this.btnSortByStudentNumber.Name = "btnSortByStudentNumber";
            this.btnSortByStudentNumber.Size = new System.Drawing.Size(210, 71);
            this.btnSortByStudentNumber.TabIndex = 7;
            this.btnSortByStudentNumber.Text = "За кількістю студентів";
            this.btnSortByStudentNumber.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.DimGray;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(1441, 309);
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
            this.btnEdit.Location = new System.Drawing.Point(1441, 226);
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
            this.btnAddNew.Location = new System.Drawing.Point(1441, 145);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(210, 49);
            this.btnAddNew.TabIndex = 4;
            this.btnAddNew.Text = "Додати";
            this.btnAddNew.UseVisualStyleBackColor = false;
            // 
            // dataGridView3
            // 
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(35, 145);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(1379, 593);
            this.dataGridView3.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.DimGray;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1261, 82);
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
            this.label2.Size = new System.Drawing.Size(153, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пошук класу:";
            // 
            // txtFormSearch
            // 
            this.txtFormSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFormSearch.Location = new System.Drawing.Point(35, 83);
            this.txtFormSearch.Name = "txtFormSearch";
            this.txtFormSearch.Size = new System.Drawing.Size(1180, 33);
            this.txtFormSearch.TabIndex = 0;
            // 
            // tabFormDetails
            // 
            this.tabFormDetails.Controls.Add(this.btnCancel);
            this.tabFormDetails.Controls.Add(this.btnSaveChanges);
            this.tabFormDetails.Controls.Add(this.txtIdTeacher);
            this.tabFormDetails.Controls.Add(this.label6);
            this.tabFormDetails.Controls.Add(this.txtFormName);
            this.tabFormDetails.Controls.Add(this.label4);
            this.tabFormDetails.Controls.Add(this.txtNumberOfStudents);
            this.tabFormDetails.Controls.Add(this.label3);
            this.tabFormDetails.Location = new System.Drawing.Point(4, 34);
            this.tabFormDetails.Name = "tabFormDetails";
            this.tabFormDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabFormDetails.Size = new System.Drawing.Size(1670, 817);
            this.tabFormDetails.TabIndex = 1;
            this.tabFormDetails.Text = "Деталі";
            this.tabFormDetails.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DimGray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(328, 401);
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
            this.btnSaveChanges.Location = new System.Drawing.Point(136, 401);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(149, 48);
            this.btnSaveChanges.TabIndex = 10;
            this.btnSaveChanges.Text = "Зберегти";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            // 
            // txtIdTeacher
            // 
            this.txtIdTeacher.Location = new System.Drawing.Point(136, 262);
            this.txtIdTeacher.Name = "txtIdTeacher";
            this.txtIdTeacher.Size = new System.Drawing.Size(341, 33);
            this.txtIdTeacher.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(130, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 36);
            this.label6.TabIndex = 4;
            this.label6.Text = "ID вчителя:";
            // 
            // txtFormName
            // 
            this.txtFormName.Location = new System.Drawing.Point(136, 89);
            this.txtFormName.Name = "txtFormName";
            this.txtFormName.Size = new System.Drawing.Size(341, 33);
            this.txtFormName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(130, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 36);
            this.label4.TabIndex = 2;
            this.label4.Text = "Назва класу:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNumberOfStudents
            // 
            this.txtNumberOfStudents.Location = new System.Drawing.Point(136, 174);
            this.txtNumberOfStudents.Name = "txtNumberOfStudents";
            this.txtNumberOfStudents.Size = new System.Drawing.Size(341, 33);
            this.txtNumberOfStudents.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(130, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "Кількість учнів:";
            // 
            // FormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1678, 855);
            this.Controls.Add(this.tabControl3);
            this.Name = "FormView";
            this.Text = "FormView";
            this.tabControl3.ResumeLayout(false);
            this.tabFormList.ResumeLayout(false);
            this.tabFormList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabFormDetails.ResumeLayout(false);
            this.tabFormDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabFormList;
        private System.Windows.Forms.Button btnResetFilters;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSortByStudentNumber;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFormSearch;
        private System.Windows.Forms.TabPage tabFormDetails;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TextBox txtIdTeacher;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFormName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumberOfStudents;
        private System.Windows.Forms.Label label3;
    }
}