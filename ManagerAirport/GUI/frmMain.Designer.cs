namespace ManagerAirport
{
    partial class frmMain
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.grboxFilterBy = new System.Windows.Forms.GroupBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.txtFlightNumber = new System.Windows.Forms.TextBox();
            this.dtpOutbound = new System.Windows.Forms.DateTimePicker();
            this.lblFlightNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbSortBy = new System.Windows.Forms.ComboBox();
            this.lblSortBy = new System.Windows.Forms.Label();
            this.cbbTo = new System.Windows.Forms.ComboBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.cbbFrom = new System.Windows.Forms.ComboBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.btnConfirmlFlight = new System.Windows.Forms.Button();
            this.btnImportChanges = new System.Windows.Forms.Button();
            this.btnEditFlight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.grboxFilterBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(16, 249);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1496, 263);
            this.dgv.TabIndex = 1;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // grboxFilterBy
            // 
            this.grboxFilterBy.Controls.Add(this.btnApply);
            this.grboxFilterBy.Controls.Add(this.txtFlightNumber);
            this.grboxFilterBy.Controls.Add(this.dtpOutbound);
            this.grboxFilterBy.Controls.Add(this.lblFlightNumber);
            this.grboxFilterBy.Controls.Add(this.label1);
            this.grboxFilterBy.Controls.Add(this.cbbSortBy);
            this.grboxFilterBy.Controls.Add(this.lblSortBy);
            this.grboxFilterBy.Controls.Add(this.cbbTo);
            this.grboxFilterBy.Controls.Add(this.lblTo);
            this.grboxFilterBy.Controls.Add(this.cbbFrom);
            this.grboxFilterBy.Controls.Add(this.lblFrom);
            this.grboxFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grboxFilterBy.Location = new System.Drawing.Point(32, 43);
            this.grboxFilterBy.Margin = new System.Windows.Forms.Padding(4);
            this.grboxFilterBy.Name = "grboxFilterBy";
            this.grboxFilterBy.Padding = new System.Windows.Forms.Padding(4);
            this.grboxFilterBy.Size = new System.Drawing.Size(1419, 175);
            this.grboxFilterBy.TabIndex = 2;
            this.grboxFilterBy.TabStop = false;
            this.grboxFilterBy.Text = "Filter by";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(1070, 105);
            this.btnApply.Margin = new System.Windows.Forms.Padding(4);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(104, 33);
            this.btnApply.TabIndex = 15;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // txtFlightNumber
            // 
            this.txtFlightNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlightNumber.Location = new System.Drawing.Point(631, 112);
            this.txtFlightNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtFlightNumber.Name = "txtFlightNumber";
            this.txtFlightNumber.Size = new System.Drawing.Size(88, 27);
            this.txtFlightNumber.TabIndex = 14;
            // 
            // dtpOutbound
            // 
            this.dtpOutbound.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpOutbound.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOutbound.Location = new System.Drawing.Point(121, 114);
            this.dtpOutbound.Margin = new System.Windows.Forms.Padding(4);
            this.dtpOutbound.Name = "dtpOutbound";
            this.dtpOutbound.Size = new System.Drawing.Size(149, 29);
            this.dtpOutbound.TabIndex = 13;
            // 
            // lblFlightNumber
            // 
            this.lblFlightNumber.AutoSize = true;
            this.lblFlightNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightNumber.Location = new System.Drawing.Point(484, 118);
            this.lblFlightNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlightNumber.Name = "lblFlightNumber";
            this.lblFlightNumber.Size = new System.Drawing.Size(127, 20);
            this.lblFlightNumber.TabIndex = 9;
            this.lblFlightNumber.Text = "Flight Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Outbound";
            // 
            // cbbSortBy
            // 
            this.cbbSortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSortBy.FormattingEnabled = true;
            this.cbbSortBy.Items.AddRange(new object[] {
            "Date-Time",
            "Price",
            "Confirmed"});
            this.cbbSortBy.Location = new System.Drawing.Point(1070, 41);
            this.cbbSortBy.Margin = new System.Windows.Forms.Padding(4);
            this.cbbSortBy.Name = "cbbSortBy";
            this.cbbSortBy.Size = new System.Drawing.Size(149, 28);
            this.cbbSortBy.TabIndex = 6;
            // 
            // lblSortBy
            // 
            this.lblSortBy.AutoSize = true;
            this.lblSortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortBy.Location = new System.Drawing.Point(962, 50);
            this.lblSortBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Size = new System.Drawing.Size(69, 20);
            this.lblSortBy.TabIndex = 5;
            this.lblSortBy.Text = "Sort by";
            // 
            // cbbTo
            // 
            this.cbbTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTo.FormattingEnabled = true;
            this.cbbTo.Location = new System.Drawing.Point(570, 41);
            this.cbbTo.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTo.Name = "cbbTo";
            this.cbbTo.Size = new System.Drawing.Size(149, 28);
            this.cbbTo.TabIndex = 4;
            this.cbbTo.Text = "[Airport List]";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(484, 50);
            this.lblTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(30, 20);
            this.lblTo.TabIndex = 3;
            this.lblTo.Text = "To";
            // 
            // cbbFrom
            // 
            this.cbbFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbFrom.FormattingEnabled = true;
            this.cbbFrom.Location = new System.Drawing.Point(121, 44);
            this.cbbFrom.Margin = new System.Windows.Forms.Padding(4);
            this.cbbFrom.Name = "cbbFrom";
            this.cbbFrom.Size = new System.Drawing.Size(149, 28);
            this.cbbFrom.TabIndex = 2;
            this.cbbFrom.Text = "[Airport List]";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(36, 50);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(52, 20);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "From";
            // 
            // btnConfirmlFlight
            // 
            this.btnConfirmlFlight.AutoSize = true;
            this.btnConfirmlFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmlFlight.Location = new System.Drawing.Point(106, 575);
            this.btnConfirmlFlight.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmlFlight.Name = "btnConfirmlFlight";
            this.btnConfirmlFlight.Size = new System.Drawing.Size(159, 47);
            this.btnConfirmlFlight.TabIndex = 3;
            this.btnConfirmlFlight.Text = "Cancel Flight";
            this.btnConfirmlFlight.UseVisualStyleBackColor = true;
            this.btnConfirmlFlight.Click += new System.EventHandler(this.btnConfirmFlight_Click);
            // 
            // btnImportChanges
            // 
            this.btnImportChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportChanges.Location = new System.Drawing.Point(674, 575);
            this.btnImportChanges.Margin = new System.Windows.Forms.Padding(4);
            this.btnImportChanges.Name = "btnImportChanges";
            this.btnImportChanges.Size = new System.Drawing.Size(212, 47);
            this.btnImportChanges.TabIndex = 5;
            this.btnImportChanges.Text = "Import Changes";
            this.btnImportChanges.UseVisualStyleBackColor = true;
            this.btnImportChanges.Click += new System.EventHandler(this.btnImportChanges_Click);
            // 
            // btnEditFlight
            // 
            this.btnEditFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditFlight.Location = new System.Drawing.Point(362, 575);
            this.btnEditFlight.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditFlight.Name = "btnEditFlight";
            this.btnEditFlight.Size = new System.Drawing.Size(161, 47);
            this.btnEditFlight.TabIndex = 6;
            this.btnEditFlight.Text = "Edit Flight";
            this.btnEditFlight.UseVisualStyleBackColor = true;
            this.btnEditFlight.Click += new System.EventHandler(this.btnEditFlight_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1525, 718);
            this.Controls.Add(this.btnEditFlight);
            this.Controls.Add(this.btnImportChanges);
            this.Controls.Add(this.btnConfirmlFlight);
            this.Controls.Add(this.grboxFilterBy);
            this.Controls.Add(this.dgv);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Fight Schedules";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.grboxFilterBy.ResumeLayout(false);
            this.grboxFilterBy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox grboxFilterBy;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.ComboBox cbbFrom;
        private System.Windows.Forms.ComboBox cbbSortBy;
        private System.Windows.Forms.Label lblSortBy;
        private System.Windows.Forms.ComboBox cbbTo;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpOutbound;
        private System.Windows.Forms.Label lblFlightNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFlightNumber;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnConfirmlFlight;
        private System.Windows.Forms.Button btnImportChanges;
        private System.Windows.Forms.Button btnEditFlight;
    }
}

