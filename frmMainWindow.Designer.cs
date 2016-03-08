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
            ((System.ComponentModel.ISupportInitialize)(this.dgViewAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFilter
            // 
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(16, 8);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(56, 32);
            this.lblFilter.TabIndex = 0;
            this.lblFilter.Text = "Filtru";
            this.lblFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbInputFilter
            // 
            this.tbInputFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInputFilter.Location = new System.Drawing.Point(72, 8);
            this.tbInputFilter.Name = "tbInputFilter";
            this.tbInputFilter.Size = new System.Drawing.Size(232, 29);
            this.tbInputFilter.TabIndex = 1;
            this.tbInputFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbInputFilter.Click += new System.EventHandler(this.tbInputFilter_Click);
            this.tbInputFilter.TextChanged += new System.EventHandler(this.tbInputFilter_TextChanged);
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.Location = new System.Drawing.Point(312, 8);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(83, 29);
            this.btnApplyFilter.TabIndex = 2;
            this.btnApplyFilter.Text = "Aplică";
            this.btnApplyFilter.UseVisualStyleBackColor = true;
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
            // 
            // dgViewAgenda
            // 
            this.dgViewAgenda.BackgroundColor = System.Drawing.Color.White;
            this.dgViewAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewAgenda.Location = new System.Drawing.Point(16, 40);
            this.dgViewAgenda.Name = "dgViewAgenda";
            this.dgViewAgenda.Size = new System.Drawing.Size(376, 287);
            this.dgViewAgenda.TabIndex = 3;
            this.dgViewAgenda.Click += new System.EventHandler(this.dgViewAgenda_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(394, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 24);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Nume";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephone.Location = new System.Drawing.Point(394, 86);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(79, 24);
            this.lblTelephone.TabIndex = 5;
            this.lblTelephone.Text = "Telefon:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(398, 63);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(293, 20);
            this.tbName.TabIndex = 6;
            this.tbName.Text = "Introduceţi numele aici";
            this.tbName.Click += new System.EventHandler(this.tbName_Click);
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // tbTelephone
            // 
            this.tbTelephone.Location = new System.Drawing.Point(398, 113);
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.Size = new System.Drawing.Size(293, 20);
            this.tbTelephone.TabIndex = 7;
            this.tbTelephone.Text = "Introduceţi numărul de telefon aici";
            this.tbTelephone.Click += new System.EventHandler(this.tbTelephone_Click);
            this.tbTelephone.TextChanged += new System.EventHandler(this.tbTelephone_TextChanged);
            // 
            // btnAddEntry
            // 
            this.btnAddEntry.Location = new System.Drawing.Point(398, 280);
            this.btnAddEntry.Name = "btnAddEntry";
            this.btnAddEntry.Size = new System.Drawing.Size(75, 48);
            this.btnAddEntry.TabIndex = 8;
            this.btnAddEntry.Text = "Adaugă";
            this.btnAddEntry.UseVisualStyleBackColor = true;
            this.btnAddEntry.Click += new System.EventHandler(this.btnAddEntry_Click);
            // 
            // btnRemoveEntry
            // 
            this.btnRemoveEntry.Location = new System.Drawing.Point(504, 280);
            this.btnRemoveEntry.Name = "btnRemoveEntry";
            this.btnRemoveEntry.Size = new System.Drawing.Size(80, 48);
            this.btnRemoveEntry.TabIndex = 9;
            this.btnRemoveEntry.Text = "Şterge";
            this.btnRemoveEntry.UseVisualStyleBackColor = true;
            this.btnRemoveEntry.Click += new System.EventHandler(this.btnRemoveEntry_Click);
            // 
            // btnValidateChanges
            // 
            this.btnValidateChanges.Location = new System.Drawing.Point(616, 280);
            this.btnValidateChanges.Name = "btnValidateChanges";
            this.btnValidateChanges.Size = new System.Drawing.Size(75, 48);
            this.btnValidateChanges.TabIndex = 10;
            this.btnValidateChanges.Text = "OK";
            this.btnValidateChanges.UseVisualStyleBackColor = true;
            this.btnValidateChanges.Click += new System.EventHandler(this.btnValidateChanges_Click);
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 338);
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
    }
}

