namespace Lab05
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colLapTopID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLapTopName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLaptopType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProcessor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonUpDateData = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonLoadDatafromSQL = new System.Windows.Forms.Button();
            this.buttonLoadDataExcel = new System.Windows.Forms.Button();
            this.pictureBoxLaptop = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLaptop)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLapTopID,
            this.ColLapTopName,
            this.ColLaptopType,
            this.ColProductDate,
            this.ColProcessor,
            this.ColHDD,
            this.ColRAM,
            this.ColPrice});
            this.dataGridView1.Location = new System.Drawing.Point(39, 76);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(917, 529);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.datagridview_editingControlShowing);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.datagridview_selectionchange);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ColumnPrice_Keypess);
            // 
            // colLapTopID
            // 
            this.colLapTopID.DataPropertyName = "LapTopID";
            this.colLapTopID.HeaderText = "LapTopID";
            this.colLapTopID.MinimumWidth = 8;
            this.colLapTopID.Name = "colLapTopID";
            this.colLapTopID.Width = 150;
            // 
            // ColLapTopName
            // 
            this.ColLapTopName.DataPropertyName = "LapTopName";
            this.ColLapTopName.HeaderText = "LapTopName";
            this.ColLapTopName.MinimumWidth = 8;
            this.ColLapTopName.Name = "ColLapTopName";
            this.ColLapTopName.Width = 150;
            // 
            // ColLaptopType
            // 
            this.ColLaptopType.DataPropertyName = "LaptopType";
            this.ColLaptopType.HeaderText = "LaptopType";
            this.ColLaptopType.MinimumWidth = 8;
            this.ColLaptopType.Name = "ColLaptopType";
            this.ColLaptopType.Width = 150;
            // 
            // ColProductDate
            // 
            this.ColProductDate.DataPropertyName = "ProductDate";
            this.ColProductDate.HeaderText = "ProductDate";
            this.ColProductDate.MinimumWidth = 8;
            this.ColProductDate.Name = "ColProductDate";
            this.ColProductDate.Width = 150;
            // 
            // ColProcessor
            // 
            this.ColProcessor.DataPropertyName = "Processor";
            this.ColProcessor.HeaderText = "Processor";
            this.ColProcessor.MinimumWidth = 8;
            this.ColProcessor.Name = "ColProcessor";
            this.ColProcessor.Width = 150;
            // 
            // ColHDD
            // 
            this.ColHDD.DataPropertyName = "HDD";
            this.ColHDD.HeaderText = "HDD";
            this.ColHDD.MinimumWidth = 8;
            this.ColHDD.Name = "ColHDD";
            this.ColHDD.Width = 150;
            // 
            // ColRAM
            // 
            this.ColRAM.DataPropertyName = "RAM";
            this.ColRAM.HeaderText = "RAM";
            this.ColRAM.MinimumWidth = 8;
            this.ColRAM.Name = "ColRAM";
            this.ColRAM.Width = 150;
            // 
            // ColPrice
            // 
            this.ColPrice.DataPropertyName = "Price";
            this.ColPrice.HeaderText = "Price";
            this.ColPrice.MinimumWidth = 8;
            this.ColPrice.Name = "ColPrice";
            this.ColPrice.Width = 150;
            // 
            // buttonUpDateData
            // 
            this.buttonUpDateData.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUpDateData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpDateData.Image = global::Lab05.Properties.Resources._218499_11zon;
            this.buttonUpDateData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpDateData.Location = new System.Drawing.Point(650, 611);
            this.buttonUpDateData.Name = "buttonUpDateData";
            this.buttonUpDateData.Size = new System.Drawing.Size(306, 43);
            this.buttonUpDateData.TabIndex = 7;
            this.buttonUpDateData.Text = "Update to Data Source";
            this.buttonUpDateData.UseVisualStyleBackColor = false;
            this.buttonUpDateData.Click += new System.EventHandler(this.buttonUpDateData_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Image = global::Lab05.Properties.Resources.Clear;
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.Location = new System.Drawing.Point(397, 611);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(151, 43);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Detele";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Image = global::Lab05.Properties.Resources._11zon_resized;
            this.buttonUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpdate.Location = new System.Drawing.Point(218, 611);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(151, 43);
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.btn_update);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Image = global::Lab05.Properties.Resources.Add;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(39, 611);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(151, 43);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.btn_add);
            // 
            // buttonLoadDatafromSQL
            // 
            this.buttonLoadDatafromSQL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLoadDatafromSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadDatafromSQL.Image = global::Lab05.Properties.Resources.sql_icon_major_database_format_vector_illustration_208686189_11zon;
            this.buttonLoadDatafromSQL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLoadDatafromSQL.Location = new System.Drawing.Point(448, 12);
            this.buttonLoadDatafromSQL.Name = "buttonLoadDatafromSQL";
            this.buttonLoadDatafromSQL.Size = new System.Drawing.Size(372, 43);
            this.buttonLoadDatafromSQL.TabIndex = 3;
            this.buttonLoadDatafromSQL.Text = "Load Data Form SQL";
            this.buttonLoadDatafromSQL.UseVisualStyleBackColor = false;
            this.buttonLoadDatafromSQL.Click += new System.EventHandler(this.btn_DataSQL);
            // 
            // buttonLoadDataExcel
            // 
            this.buttonLoadDataExcel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLoadDataExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadDataExcel.Image = global::Lab05.Properties.Resources.th_11zon;
            this.buttonLoadDataExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLoadDataExcel.Location = new System.Drawing.Point(39, 12);
            this.buttonLoadDataExcel.Name = "buttonLoadDataExcel";
            this.buttonLoadDataExcel.Size = new System.Drawing.Size(372, 43);
            this.buttonLoadDataExcel.TabIndex = 2;
            this.buttonLoadDataExcel.Text = "Load Data From Excel";
            this.buttonLoadDataExcel.UseVisualStyleBackColor = false;
            this.buttonLoadDataExcel.Click += new System.EventHandler(this.btn_LoadExcel);
            // 
            // pictureBoxLaptop
            // 
            this.pictureBoxLaptop.Image = global::Lab05.Properties.Resources.the_best_lenovo_laptop_for_students;
            this.pictureBoxLaptop.Location = new System.Drawing.Point(962, 158);
            this.pictureBoxLaptop.Name = "pictureBoxLaptop";
            this.pictureBoxLaptop.Size = new System.Drawing.Size(285, 304);
            this.pictureBoxLaptop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLaptop.TabIndex = 1;
            this.pictureBoxLaptop.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1259, 675);
            this.Controls.Add(this.buttonUpDateData);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonLoadDatafromSQL);
            this.Controls.Add(this.buttonLoadDataExcel);
            this.Controls.Add(this.pictureBoxLaptop);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLaptop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBoxLaptop;
        private System.Windows.Forms.Button buttonLoadDataExcel;
        private System.Windows.Forms.Button buttonLoadDatafromSQL;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpDateData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLapTopID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLapTopName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLaptopType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProcessor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrice;
    }
}

