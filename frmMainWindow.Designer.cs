namespace Agenda
{
    partial class MainWindowForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindowForm));
            this.lblFilter = new System.Windows.Forms.Label();
            this.tbInputFilter = new System.Windows.Forms.TextBox();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.dgViewAgenda = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbTelephone = new System.Windows.Forms.TextBox();
            this.btnAddEntry = new System.Windows.Forms.Button();
            this.btnRemoveEntry = new System.Windows.Forms.Button();
            this.btnValidateChanges = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFilter
            // 
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(16, 21);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(52, 29);
            this.lblFilter.TabIndex = 0;
            this.lblFilter.Text = "Filtru";
            this.lblFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbInputFilter
            // 
            this.tbInputFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbInputFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInputFilter.Location = new System.Drawing.Point(74, 21);
            this.tbInputFilter.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbInputFilter.Name = "tbInputFilter";
            this.tbInputFilter.Size = new System.Drawing.Size(232, 29);
            this.tbInputFilter.TabIndex = 1;
            this.tbInputFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbInputFilter.Click += new System.EventHandler(this.tbInputFilter_Click);
            this.tbInputFilter.TextChanged += new System.EventHandler(this.tbInputFilter_TextChanged);
            this.tbInputFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbInputFilter_KeyDown);
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyFilter.Location = new System.Drawing.Point(312, 21);
            this.btnApplyFilter.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(80, 29);
            this.btnApplyFilter.TabIndex = 2;
            this.btnApplyFilter.Text = "Aplică";
            this.btnApplyFilter.UseVisualStyleBackColor = true;
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
            this.btnApplyFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnApplyFilter_KeyDown);
            // 
            // dgViewAgenda
            // 
            this.dgViewAgenda.AllowUserToOrderColumns = true;
            this.dgViewAgenda.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgViewAgenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgViewAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewAgenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colTelephone});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgViewAgenda.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgViewAgenda.GridColor = System.Drawing.Color.White;
            this.dgViewAgenda.Location = new System.Drawing.Point(16, 62);
            this.dgViewAgenda.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgViewAgenda.Name = "dgViewAgenda";
            this.dgViewAgenda.RowHeadersVisible = false;
            this.dgViewAgenda.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgViewAgenda.Size = new System.Drawing.Size(376, 442);
            this.dgViewAgenda.TabIndex = 3;
            this.dgViewAgenda.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgViewAgenda_CellBeginEdit);
            this.dgViewAgenda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgViewAgenda_CellClick);
            this.dgViewAgenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgViewAgenda_CellContentClick);
            this.dgViewAgenda.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgViewAgenda_CellValueChanged);
            this.dgViewAgenda.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgViewAgenda_RowsAdded);
            this.dgViewAgenda.SelectionChanged += new System.EventHandler(this.dgViewAgenda_SelectionChanged);
            this.dgViewAgenda.Click += new System.EventHandler(this.dgViewAgenda_Click);
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(398, 62);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(293, 24);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Nume";
            // 
            // lblTelephone
            // 
            this.lblTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephone.Location = new System.Drawing.Point(398, 128);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(293, 24);
            this.lblTelephone.TabIndex = 5;
            this.lblTelephone.Text = "Telefon:";
            // 
            // tbName
            // 
            this.tbName.AcceptsTab = true;
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.Location = new System.Drawing.Point(398, 97);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbName.MaxLength = 50;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(293, 20);
            this.tbName.TabIndex = 6;
            this.tbName.Click += new System.EventHandler(this.tbName_Click);
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            this.tbName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbName_KeyDown);
            // 
            // tbTelephone
            // 
            this.tbTelephone.AcceptsReturn = true;
            this.tbTelephone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTelephone.Location = new System.Drawing.Point(398, 174);
            this.tbTelephone.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbTelephone.MaxLength = 10;
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.Size = new System.Drawing.Size(293, 20);
            this.tbTelephone.TabIndex = 7;
            this.tbTelephone.WordWrap = false;
            this.tbTelephone.Click += new System.EventHandler(this.tbTelephone_Click);
            this.tbTelephone.TextChanged += new System.EventHandler(this.tbTelephone_TextChanged);
            this.tbTelephone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbTelephone_KeyDown);
            // 
            // btnAddEntry
            // 
            this.btnAddEntry.BackColor = System.Drawing.Color.Transparent;
            this.btnAddEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEntry.Location = new System.Drawing.Point(398, 431);
            this.btnAddEntry.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAddEntry.Name = "btnAddEntry";
            this.btnAddEntry.Size = new System.Drawing.Size(75, 74);
            this.btnAddEntry.TabIndex = 8;
            this.btnAddEntry.Text = "Adaugă";
            this.btnAddEntry.UseVisualStyleBackColor = false;
            this.btnAddEntry.Click += new System.EventHandler(this.btnAddEntry_Click);
            // 
            // btnRemoveEntry
            // 
            this.btnRemoveEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveEntry.Location = new System.Drawing.Point(504, 431);
            this.btnRemoveEntry.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnRemoveEntry.Name = "btnRemoveEntry";
            this.btnRemoveEntry.Size = new System.Drawing.Size(80, 74);
            this.btnRemoveEntry.TabIndex = 9;
            this.btnRemoveEntry.Text = "Şterge";
            this.btnRemoveEntry.UseVisualStyleBackColor = true;
            this.btnRemoveEntry.Click += new System.EventHandler(this.btnRemoveEntry_Click);
            // 
            // btnValidateChanges
            // 
            this.btnValidateChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidateChanges.Location = new System.Drawing.Point(616, 431);
            this.btnValidateChanges.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnValidateChanges.Name = "btnValidateChanges";
            this.btnValidateChanges.Size = new System.Drawing.Size(75, 74);
            this.btnValidateChanges.TabIndex = 10;
            this.btnValidateChanges.Text = "OK";
            this.btnValidateChanges.UseVisualStyleBackColor = true;
            this.btnValidateChanges.Click += new System.EventHandler(this.btnValidateChanges_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInfo.Location = new System.Drawing.Point(398, 208);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(293, 218);
            this.lblInfo.TabIndex = 11;
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInfo.Click += new System.EventHandler(this.lblInfo_Click);
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colName.Frozen = true;
            this.colName.HeaderText = "Nume";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colName.Width = 210;
            // 
            // colTelephone
            // 
            this.colTelephone.HeaderText = "Telefon";
            this.colTelephone.MaxInputLength = 10;
            this.colTelephone.Name = "colTelephone";
            this.colTelephone.ReadOnly = true;
            this.colTelephone.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTelephone.Width = 160;
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 520);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnValidateChanges);
            this.Controls.Add(this.btnRemoveEntry);
            this.Controls.Add(this.btnAddEntry);
            this.Controls.Add(this.tbTelephone);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dgViewAgenda);
            this.Controls.Add(this.btnApplyFilter);
            this.Controls.Add(this.tbInputFilter);
            this.Controls.Add(this.lblFilter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "MainWindowForm";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.MainWindowForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox tbInputFilter;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.DataGridView dgViewAgenda;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbTelephone;
        private System.Windows.Forms.Button btnAddEntry;
        private System.Windows.Forms.Button btnRemoveEntry;
        private System.Windows.Forms.Button btnValidateChanges;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelephone;
    }
}

