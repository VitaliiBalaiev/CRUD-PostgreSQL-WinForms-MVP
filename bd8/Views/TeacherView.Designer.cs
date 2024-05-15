namespace bd8.Views
{
    partial class TeacherView
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabTeacherList = new System.Windows.Forms.TabPage();
            this.btnResetFilters = new System.Windows.Forms.Button();
            this.btnSortByNameTeacher = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSortBySurnameTeacher = new System.Windows.Forms.Button();
            this.btnDeleteTeacher = new System.Windows.Forms.Button();
            this.btnEditTeacher = new System.Windows.Forms.Button();
            this.btnAddNewTeacher = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnTeacherSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTeacherSearch = new System.Windows.Forms.TextBox();
            this.tabTeacherDetails = new System.Windows.Forms.TabPage();
            this.schoolComboBox = new System.Windows.Forms.ComboBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTeacherDegree = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTeacherPicker = new System.Windows.Forms.DateTimePicker();
            this.btnCancelTeacher = new System.Windows.Forms.Button();
            this.btnSaveChangesTeacher = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTeacherPatronymic = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTeacherSurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdTeacher = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabTeacherList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabTeacherDetails.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(1641, 855);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1633, 822);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1633, 822);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabTeacherList);
            this.tabControl2.Controls.Add(this.tabTeacherDetails);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Font = new System.Drawing.Font("Source Sans Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1641, 855);
            this.tabControl2.TabIndex = 3;
            // 
            // tabTeacherList
            // 
            this.tabTeacherList.BackColor = System.Drawing.Color.White;
            this.tabTeacherList.Controls.Add(this.btnResetFilters);
            this.tabTeacherList.Controls.Add(this.btnSortByNameTeacher);
            this.tabTeacherList.Controls.Add(this.label10);
            this.tabTeacherList.Controls.Add(this.btnSortBySurnameTeacher);
            this.tabTeacherList.Controls.Add(this.btnDeleteTeacher);
            this.tabTeacherList.Controls.Add(this.btnEditTeacher);
            this.tabTeacherList.Controls.Add(this.btnAddNewTeacher);
            this.tabTeacherList.Controls.Add(this.dataGridView2);
            this.tabTeacherList.Controls.Add(this.btnTeacherSearch);
            this.tabTeacherList.Controls.Add(this.label2);
            this.tabTeacherList.Controls.Add(this.txtTeacherSearch);
            this.tabTeacherList.Font = new System.Drawing.Font("Source Sans Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabTeacherList.ForeColor = System.Drawing.Color.Black;
            this.tabTeacherList.Location = new System.Drawing.Point(4, 34);
            this.tabTeacherList.Name = "tabTeacherList";
            this.tabTeacherList.Padding = new System.Windows.Forms.Padding(3);
            this.tabTeacherList.Size = new System.Drawing.Size(1633, 817);
            this.tabTeacherList.TabIndex = 0;
            this.tabTeacherList.Text = "Список вчителів";
            // 
            // btnResetFilters
            // 
            this.btnResetFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetFilters.BackColor = System.Drawing.Color.DimGray;
            this.btnResetFilters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetFilters.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnResetFilters.ForeColor = System.Drawing.Color.White;
            this.btnResetFilters.Location = new System.Drawing.Point(1404, 667);
            this.btnResetFilters.Name = "btnResetFilters";
            this.btnResetFilters.Size = new System.Drawing.Size(210, 49);
            this.btnResetFilters.TabIndex = 14;
            this.btnResetFilters.Text = "Скинути фільтри";
            this.btnResetFilters.UseVisualStyleBackColor = false;
            // 
            // btnSortByNameTeacher
            // 
            this.btnSortByNameTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSortByNameTeacher.BackColor = System.Drawing.Color.DimGray;
            this.btnSortByNameTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSortByNameTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortByNameTeacher.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSortByNameTeacher.ForeColor = System.Drawing.Color.White;
            this.btnSortByNameTeacher.Location = new System.Drawing.Point(1404, 547);
            this.btnSortByNameTeacher.Name = "btnSortByNameTeacher";
            this.btnSortByNameTeacher.Size = new System.Drawing.Size(210, 49);
            this.btnSortByNameTeacher.TabIndex = 11;
            this.btnSortByNameTeacher.Text = "За іменем (А-Я)";
            this.btnSortByNameTeacher.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1439, 436);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 31);
            this.label10.TabIndex = 10;
            this.label10.Text = "Сортування:";
            // 
            // btnSortBySurnameTeacher
            // 
            this.btnSortBySurnameTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSortBySurnameTeacher.BackColor = System.Drawing.Color.DimGray;
            this.btnSortBySurnameTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSortBySurnameTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortBySurnameTeacher.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSortBySurnameTeacher.ForeColor = System.Drawing.Color.White;
            this.btnSortBySurnameTeacher.Location = new System.Drawing.Point(1404, 479);
            this.btnSortBySurnameTeacher.Name = "btnSortBySurnameTeacher";
            this.btnSortBySurnameTeacher.Size = new System.Drawing.Size(210, 49);
            this.btnSortBySurnameTeacher.TabIndex = 9;
            this.btnSortBySurnameTeacher.Text = "За прізвищем (А-Я)";
            this.btnSortBySurnameTeacher.UseVisualStyleBackColor = false;
            // 
            // btnDeleteTeacher
            // 
            this.btnDeleteTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteTeacher.BackColor = System.Drawing.Color.DimGray;
            this.btnDeleteTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTeacher.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteTeacher.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTeacher.Location = new System.Drawing.Point(1404, 309);
            this.btnDeleteTeacher.Name = "btnDeleteTeacher";
            this.btnDeleteTeacher.Size = new System.Drawing.Size(210, 49);
            this.btnDeleteTeacher.TabIndex = 6;
            this.btnDeleteTeacher.Text = "Видалити";
            this.btnDeleteTeacher.UseVisualStyleBackColor = false;
            // 
            // btnEditTeacher
            // 
            this.btnEditTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditTeacher.BackColor = System.Drawing.Color.DimGray;
            this.btnEditTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTeacher.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditTeacher.ForeColor = System.Drawing.Color.White;
            this.btnEditTeacher.Location = new System.Drawing.Point(1404, 226);
            this.btnEditTeacher.Name = "btnEditTeacher";
            this.btnEditTeacher.Size = new System.Drawing.Size(210, 49);
            this.btnEditTeacher.TabIndex = 5;
            this.btnEditTeacher.Text = "Редагувати";
            this.btnEditTeacher.UseVisualStyleBackColor = false;
            // 
            // btnAddNewTeacher
            // 
            this.btnAddNewTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewTeacher.BackColor = System.Drawing.Color.DimGray;
            this.btnAddNewTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewTeacher.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddNewTeacher.ForeColor = System.Drawing.Color.White;
            this.btnAddNewTeacher.Location = new System.Drawing.Point(1404, 145);
            this.btnAddNewTeacher.Name = "btnAddNewTeacher";
            this.btnAddNewTeacher.Size = new System.Drawing.Size(210, 49);
            this.btnAddNewTeacher.TabIndex = 4;
            this.btnAddNewTeacher.Text = "Додати";
            this.btnAddNewTeacher.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(35, 145);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(1342, 593);
            this.dataGridView2.TabIndex = 3;
            // 
            // btnTeacherSearch
            // 
            this.btnTeacherSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTeacherSearch.BackColor = System.Drawing.Color.DimGray;
            this.btnTeacherSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeacherSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTeacherSearch.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTeacherSearch.ForeColor = System.Drawing.Color.White;
            this.btnTeacherSearch.Location = new System.Drawing.Point(1224, 82);
            this.btnTeacherSearch.Name = "btnTeacherSearch";
            this.btnTeacherSearch.Size = new System.Drawing.Size(153, 36);
            this.btnTeacherSearch.TabIndex = 2;
            this.btnTeacherSearch.Text = "Пошук";
            this.btnTeacherSearch.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пошук вчителя:";
            // 
            // txtTeacherSearch
            // 
            this.txtTeacherSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTeacherSearch.Location = new System.Drawing.Point(35, 83);
            this.txtTeacherSearch.Name = "txtTeacherSearch";
            this.txtTeacherSearch.Size = new System.Drawing.Size(1143, 33);
            this.txtTeacherSearch.TabIndex = 0;
            // 
            // tabTeacherDetails
            // 
            this.tabTeacherDetails.Controls.Add(this.txtIdTeacher);
            this.tabTeacherDetails.Controls.Add(this.label9);
            this.tabTeacherDetails.Controls.Add(this.schoolComboBox);
            this.tabTeacherDetails.Controls.Add(this.genderComboBox);
            this.tabTeacherDetails.Controls.Add(this.label1);
            this.tabTeacherDetails.Controls.Add(this.txtTeacherDegree);
            this.tabTeacherDetails.Controls.Add(this.label8);
            this.tabTeacherDetails.Controls.Add(this.dateTeacherPicker);
            this.tabTeacherDetails.Controls.Add(this.btnCancelTeacher);
            this.tabTeacherDetails.Controls.Add(this.btnSaveChangesTeacher);
            this.tabTeacherDetails.Controls.Add(this.label7);
            this.tabTeacherDetails.Controls.Add(this.label5);
            this.tabTeacherDetails.Controls.Add(this.txtTeacherPatronymic);
            this.tabTeacherDetails.Controls.Add(this.label6);
            this.tabTeacherDetails.Controls.Add(this.txtTeacherSurname);
            this.tabTeacherDetails.Controls.Add(this.label4);
            this.tabTeacherDetails.Controls.Add(this.txtTeacherName);
            this.tabTeacherDetails.Controls.Add(this.label3);
            this.tabTeacherDetails.Location = new System.Drawing.Point(4, 34);
            this.tabTeacherDetails.Name = "tabTeacherDetails";
            this.tabTeacherDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabTeacherDetails.Size = new System.Drawing.Size(1633, 817);
            this.tabTeacherDetails.TabIndex = 1;
            this.tabTeacherDetails.Text = "Деталі";
            this.tabTeacherDetails.UseVisualStyleBackColor = true;
            // 
            // schoolComboBox
            // 
            this.schoolComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.schoolComboBox.FormattingEnabled = true;
            this.schoolComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.schoolComboBox.Location = new System.Drawing.Point(136, 622);
            this.schoolComboBox.Name = "schoolComboBox";
            this.schoolComboBox.Size = new System.Drawing.Size(341, 33);
            this.schoolComboBox.TabIndex = 21;
            // 
            // genderComboBox
            // 
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "M",
            "F"});
            this.genderComboBox.Location = new System.Drawing.Point(136, 437);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(341, 33);
            this.genderComboBox.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(135, 575);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 36);
            this.label1.TabIndex = 18;
            this.label1.Text = "ID Школи:";
            // 
            // txtTeacherDegree
            // 
            this.txtTeacherDegree.Location = new System.Drawing.Point(136, 527);
            this.txtTeacherDegree.Name = "txtTeacherDegree";
            this.txtTeacherDegree.Size = new System.Drawing.Size(341, 33);
            this.txtTeacherDegree.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(130, 480);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 36);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ступінь:";
            // 
            // dateTeacherPicker
            // 
            this.dateTeacherPicker.Location = new System.Drawing.Point(136, 343);
            this.dateTeacherPicker.Name = "dateTeacherPicker";
            this.dateTeacherPicker.Size = new System.Drawing.Size(341, 33);
            this.dateTeacherPicker.TabIndex = 12;
            // 
            // btnCancelTeacher
            // 
            this.btnCancelTeacher.BackColor = System.Drawing.Color.DimGray;
            this.btnCancelTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelTeacher.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancelTeacher.ForeColor = System.Drawing.Color.White;
            this.btnCancelTeacher.Location = new System.Drawing.Point(328, 716);
            this.btnCancelTeacher.Name = "btnCancelTeacher";
            this.btnCancelTeacher.Size = new System.Drawing.Size(149, 48);
            this.btnCancelTeacher.TabIndex = 11;
            this.btnCancelTeacher.Text = "Відміна";
            this.btnCancelTeacher.UseVisualStyleBackColor = false;
            // 
            // btnSaveChangesTeacher
            // 
            this.btnSaveChangesTeacher.BackColor = System.Drawing.Color.DimGray;
            this.btnSaveChangesTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChangesTeacher.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveChangesTeacher.ForeColor = System.Drawing.Color.White;
            this.btnSaveChangesTeacher.Location = new System.Drawing.Point(136, 716);
            this.btnSaveChangesTeacher.Name = "btnSaveChangesTeacher";
            this.btnSaveChangesTeacher.Size = new System.Drawing.Size(149, 48);
            this.btnSaveChangesTeacher.TabIndex = 10;
            this.btnSaveChangesTeacher.Text = "Зберегти";
            this.btnSaveChangesTeacher.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(130, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 36);
            this.label7.TabIndex = 8;
            this.label7.Text = "Стать:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(130, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 36);
            this.label5.TabIndex = 6;
            this.label5.Text = "Дата народження:";
            // 
            // txtTeacherPatronymic
            // 
            this.txtTeacherPatronymic.Location = new System.Drawing.Point(136, 244);
            this.txtTeacherPatronymic.Name = "txtTeacherPatronymic";
            this.txtTeacherPatronymic.Size = new System.Drawing.Size(341, 33);
            this.txtTeacherPatronymic.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(130, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 36);
            this.label6.TabIndex = 4;
            this.label6.Text = "По-батькові:";
            // 
            // txtTeacherSurname
            // 
            this.txtTeacherSurname.Location = new System.Drawing.Point(136, 71);
            this.txtTeacherSurname.Name = "txtTeacherSurname";
            this.txtTeacherSurname.Size = new System.Drawing.Size(341, 33);
            this.txtTeacherSurname.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(130, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 36);
            this.label4.TabIndex = 2;
            this.label4.Text = "Прізвище:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.Location = new System.Drawing.Point(136, 156);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.Size = new System.Drawing.Size(341, 33);
            this.txtTeacherName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(130, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ім\'я:";
            // 
            // txtIdTeacher
            // 
            this.txtIdTeacher.Location = new System.Drawing.Point(730, 71);
            this.txtIdTeacher.Name = "txtIdTeacher";
            this.txtIdTeacher.Size = new System.Drawing.Size(341, 33);
            this.txtIdTeacher.TabIndex = 23;
            this.txtIdTeacher.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(724, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 36);
            this.label9.TabIndex = 22;
            this.label9.Text = "ID вчителя:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.Visible = false;
            // 
            // TeacherView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1641, 855);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Name = "TeacherView";
            this.tabControl1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabTeacherList.ResumeLayout(false);
            this.tabTeacherList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabTeacherDetails.ResumeLayout(false);
            this.tabTeacherDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabTeacherList;
        private System.Windows.Forms.Button btnDeleteTeacher;
        private System.Windows.Forms.Button btnEditTeacher;
        private System.Windows.Forms.Button btnAddNewTeacher;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnTeacherSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTeacherSearch;
        private System.Windows.Forms.TabPage tabTeacherDetails;
        private System.Windows.Forms.TextBox txtTeacherDegree;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTeacherPicker;
        private System.Windows.Forms.Button btnCancelTeacher;
        private System.Windows.Forms.Button btnSaveChangesTeacher;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTeacherPatronymic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTeacherSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSortBySurnameTeacher;
        private System.Windows.Forms.Button btnSortByNameTeacher;
        private System.Windows.Forms.Button btnResetFilters;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.ComboBox schoolComboBox;
        private System.Windows.Forms.TextBox txtIdTeacher;
        private System.Windows.Forms.Label label9;
    }
}