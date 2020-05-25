namespace ManagerAirport.GUI
{
    partial class frmScheduleEdit
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
            this.grboxFlightRoute = new System.Windows.Forms.GroupBox();
            this.cbbTo = new System.Windows.Forms.ComboBox();
            this.cbbFrom = new System.Windows.Forms.ComboBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtEconomyPrice = new System.Windows.Forms.TextBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.txtAircraft = new System.Windows.Forms.TextBox();
            this.grboxFlightRoute.SuspendLayout();
            this.SuspendLayout();
            // 
            // grboxFlightRoute
            // 
            this.grboxFlightRoute.Controls.Add(this.txtAircraft);
            this.grboxFlightRoute.Controls.Add(this.cbbTo);
            this.grboxFlightRoute.Controls.Add(this.cbbFrom);
            this.grboxFlightRoute.Controls.Add(this.lbl3);
            this.grboxFlightRoute.Controls.Add(this.lbl2);
            this.grboxFlightRoute.Controls.Add(this.lbl1);
            this.grboxFlightRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grboxFlightRoute.Location = new System.Drawing.Point(77, 58);
            this.grboxFlightRoute.Margin = new System.Windows.Forms.Padding(4);
            this.grboxFlightRoute.Name = "grboxFlightRoute";
            this.grboxFlightRoute.Padding = new System.Windows.Forms.Padding(4);
            this.grboxFlightRoute.Size = new System.Drawing.Size(768, 101);
            this.grboxFlightRoute.TabIndex = 0;
            this.grboxFlightRoute.TabStop = false;
            this.grboxFlightRoute.Text = "Flight route";
            // 
            // cbbTo
            // 
            this.cbbTo.FormattingEnabled = true;
            this.cbbTo.Location = new System.Drawing.Point(320, 38);
            this.cbbTo.Name = "cbbTo";
            this.cbbTo.Size = new System.Drawing.Size(145, 28);
            this.cbbTo.TabIndex = 7;
            // 
            // cbbFrom
            // 
            this.cbbFrom.FormattingEnabled = true;
            this.cbbFrom.Location = new System.Drawing.Point(97, 38);
            this.cbbFrom.Name = "cbbFrom";
            this.cbbFrom.Size = new System.Drawing.Size(121, 28);
            this.cbbFrom.TabIndex = 6;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(508, 46);
            this.lbl3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(64, 20);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Aircraft";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(261, 46);
            this.lbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(28, 20);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "To";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(23, 46);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(48, 20);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 222);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(339, 222);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(599, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Economy Price $";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(412, 297);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 32);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(728, 297);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 32);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(121, 217);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(161, 22);
            this.dtpDate.TabIndex = 6;
            this.dtpDate.Value = new System.DateTime(2020, 5, 21, 0, 0, 0, 0);
            // 
            // txtEconomyPrice
            // 
            this.txtEconomyPrice.Location = new System.Drawing.Point(768, 217);
            this.txtEconomyPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtEconomyPrice.Multiline = true;
            this.txtEconomyPrice.Name = "txtEconomyPrice";
            this.txtEconomyPrice.Size = new System.Drawing.Size(96, 29);
            this.txtEconomyPrice.TabIndex = 8;
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(412, 217);
            this.dtpTime.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(116, 22);
            this.dtpTime.TabIndex = 9;
            // 
            // txtAircraft
            // 
            this.txtAircraft.Location = new System.Drawing.Point(623, 38);
            this.txtAircraft.Name = "txtAircraft";
            this.txtAircraft.Size = new System.Drawing.Size(138, 26);
            this.txtAircraft.TabIndex = 8;
            // 
            // frmScheduleEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 361);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.txtEconomyPrice);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grboxFlightRoute);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmScheduleEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule Edit";
            this.Load += new System.EventHandler(this.frmScheduleEdit_Load);
            this.grboxFlightRoute.ResumeLayout(false);
            this.grboxFlightRoute.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grboxFlightRoute;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtEconomyPrice;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.ComboBox cbbFrom;
        private System.Windows.Forms.ComboBox cbbTo;
        private System.Windows.Forms.TextBox txtAircraft;
    }
}