namespace DelaySend
{
    partial class DelaySendOptions
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LayoutTableSaveCancel = new System.Windows.Forms.TableLayoutPanel();
            this.CancelSettings = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Start_Monday = new System.Windows.Forms.DateTimePicker();
            this.End_Monday = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.End_Tuesday = new System.Windows.Forms.DateTimePicker();
            this.Start_Tuesday = new System.Windows.Forms.DateTimePicker();
            this.Start_Wednesday = new System.Windows.Forms.DateTimePicker();
            this.End_Wednesday = new System.Windows.Forms.DateTimePicker();
            this.Start_Thursday = new System.Windows.Forms.DateTimePicker();
            this.End_Thursday = new System.Windows.Forms.DateTimePicker();
            this.Start_Friday = new System.Windows.Forms.DateTimePicker();
            this.End_Friday = new System.Windows.Forms.DateTimePicker();
            this.Start_Saturday = new System.Windows.Forms.DateTimePicker();
            this.Start_Sunday = new System.Windows.Forms.DateTimePicker();
            this.End_Saturday = new System.Windows.Forms.DateTimePicker();
            this.End_Sunday = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.LayoutTableSaveCancel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.LayoutTableSaveCancel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(723, 231);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // LayoutTableSaveCancel
            // 
            this.LayoutTableSaveCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LayoutTableSaveCancel.AutoSize = true;
            this.LayoutTableSaveCancel.ColumnCount = 2;
            this.LayoutTableSaveCancel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LayoutTableSaveCancel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LayoutTableSaveCancel.Controls.Add(this.CancelSettings, 1, 0);
            this.LayoutTableSaveCancel.Controls.Add(this.SaveButton, 0, 0);
            this.LayoutTableSaveCancel.Location = new System.Drawing.Point(561, 202);
            this.LayoutTableSaveCancel.Margin = new System.Windows.Forms.Padding(0);
            this.LayoutTableSaveCancel.Name = "LayoutTableSaveCancel";
            this.LayoutTableSaveCancel.RowCount = 1;
            this.LayoutTableSaveCancel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutTableSaveCancel.Size = new System.Drawing.Size(162, 29);
            this.LayoutTableSaveCancel.TabIndex = 0;
            // 
            // CancelSettings
            // 
            this.CancelSettings.Location = new System.Drawing.Point(84, 3);
            this.CancelSettings.Name = "CancelSettings";
            this.CancelSettings.Size = new System.Drawing.Size(75, 23);
            this.CancelSettings.TabIndex = 0;
            this.CancelSettings.Text = "Cancel";
            this.CancelSettings.UseVisualStyleBackColor = true;
            this.CancelSettings.Click += new System.EventHandler(this.CancelSettings_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(3, 3);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 196);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Send Immediately";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.Start_Monday, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.End_Monday, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.label8, 6, 1);
            this.tableLayoutPanel2.Controls.Add(this.label9, 7, 1);
            this.tableLayoutPanel2.Controls.Add(this.End_Tuesday, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.Start_Tuesday, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.Start_Wednesday, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.End_Wednesday, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.Start_Thursday, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.End_Thursday, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.Start_Friday, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.End_Friday, 5, 3);
            this.tableLayoutPanel2.Controls.Add(this.Start_Saturday, 6, 2);
            this.tableLayoutPanel2.Controls.Add(this.Start_Sunday, 7, 2);
            this.tableLayoutPanel2.Controls.Add(this.End_Saturday, 6, 3);
            this.tableLayoutPanel2.Controls.Add(this.End_Sunday, 7, 3);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(711, 177);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stop";
            // 
            // Start_Monday
            // 
            this.Start_Monday.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Start_Monday.Location = new System.Drawing.Point(38, 34);
            this.Start_Monday.Name = "Start_Monday";
            this.Start_Monday.ShowUpDown = true;
            this.Start_Monday.Size = new System.Drawing.Size(90, 20);
            this.Start_Monday.TabIndex = 2;
            // 
            // End_Monday
            // 
            this.End_Monday.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.End_Monday.Location = new System.Drawing.Point(38, 60);
            this.End_Monday.Name = "End_Monday";
            this.End_Monday.ShowUpDown = true;
            this.End_Monday.Size = new System.Drawing.Size(90, 20);
            this.End_Monday.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Monday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tuesday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Wednesday";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Thursday";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(422, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Friday";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(518, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Saturday";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(614, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Sunday";
            // 
            // End_Tuesday
            // 
            this.End_Tuesday.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.End_Tuesday.Location = new System.Drawing.Point(134, 60);
            this.End_Tuesday.Name = "End_Tuesday";
            this.End_Tuesday.ShowUpDown = true;
            this.End_Tuesday.Size = new System.Drawing.Size(90, 20);
            this.End_Tuesday.TabIndex = 5;
            // 
            // Start_Tuesday
            // 
            this.Start_Tuesday.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Start_Tuesday.Location = new System.Drawing.Point(134, 34);
            this.Start_Tuesday.Name = "Start_Tuesday";
            this.Start_Tuesday.ShowUpDown = true;
            this.Start_Tuesday.Size = new System.Drawing.Size(90, 20);
            this.Start_Tuesday.TabIndex = 4;
            // 
            // Start_Wednesday
            // 
            this.Start_Wednesday.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Start_Wednesday.Location = new System.Drawing.Point(230, 34);
            this.Start_Wednesday.Name = "Start_Wednesday";
            this.Start_Wednesday.ShowUpDown = true;
            this.Start_Wednesday.Size = new System.Drawing.Size(90, 20);
            this.Start_Wednesday.TabIndex = 6;
            // 
            // End_Wednesday
            // 
            this.End_Wednesday.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.End_Wednesday.Location = new System.Drawing.Point(230, 60);
            this.End_Wednesday.Name = "End_Wednesday";
            this.End_Wednesday.ShowUpDown = true;
            this.End_Wednesday.Size = new System.Drawing.Size(90, 20);
            this.End_Wednesday.TabIndex = 7;
            // 
            // Start_Thursday
            // 
            this.Start_Thursday.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Start_Thursday.Location = new System.Drawing.Point(326, 34);
            this.Start_Thursday.Name = "Start_Thursday";
            this.Start_Thursday.ShowUpDown = true;
            this.Start_Thursday.Size = new System.Drawing.Size(90, 20);
            this.Start_Thursday.TabIndex = 8;
            // 
            // End_Thursday
            // 
            this.End_Thursday.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.End_Thursday.Location = new System.Drawing.Point(326, 60);
            this.End_Thursday.Name = "End_Thursday";
            this.End_Thursday.ShowUpDown = true;
            this.End_Thursday.Size = new System.Drawing.Size(90, 20);
            this.End_Thursday.TabIndex = 9;
            // 
            // Start_Friday
            // 
            this.Start_Friday.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Start_Friday.Location = new System.Drawing.Point(422, 34);
            this.Start_Friday.Name = "Start_Friday";
            this.Start_Friday.ShowUpDown = true;
            this.Start_Friday.Size = new System.Drawing.Size(90, 20);
            this.Start_Friday.TabIndex = 10;
            // 
            // End_Friday
            // 
            this.End_Friday.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.End_Friday.Location = new System.Drawing.Point(422, 60);
            this.End_Friday.Name = "End_Friday";
            this.End_Friday.ShowUpDown = true;
            this.End_Friday.Size = new System.Drawing.Size(90, 20);
            this.End_Friday.TabIndex = 11;
            // 
            // Start_Saturday
            // 
            this.Start_Saturday.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Start_Saturday.Location = new System.Drawing.Point(518, 34);
            this.Start_Saturday.Name = "Start_Saturday";
            this.Start_Saturday.ShowUpDown = true;
            this.Start_Saturday.Size = new System.Drawing.Size(90, 20);
            this.Start_Saturday.TabIndex = 12;
            // 
            // Start_Sunday
            // 
            this.Start_Sunday.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Start_Sunday.Location = new System.Drawing.Point(614, 34);
            this.Start_Sunday.Name = "Start_Sunday";
            this.Start_Sunday.ShowUpDown = true;
            this.Start_Sunday.Size = new System.Drawing.Size(90, 20);
            this.Start_Sunday.TabIndex = 14;
            // 
            // End_Saturday
            // 
            this.End_Saturday.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.End_Saturday.Location = new System.Drawing.Point(518, 60);
            this.End_Saturday.Name = "End_Saturday";
            this.End_Saturday.ShowUpDown = true;
            this.End_Saturday.Size = new System.Drawing.Size(90, 20);
            this.End_Saturday.TabIndex = 13;
            // 
            // End_Sunday
            // 
            this.End_Sunday.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.End_Sunday.Location = new System.Drawing.Point(614, 60);
            this.End_Sunday.Name = "End_Sunday";
            this.End_Sunday.ShowUpDown = true;
            this.End_Sunday.Size = new System.Drawing.Size(90, 20);
            this.End_Sunday.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label10, 8);
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label10.Size = new System.Drawing.Size(301, 18);
            this.label10.TabIndex = 24;
            this.label10.Text = "Send all emails immediately when between the following hours:";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label11, 8);
            this.label11.Location = new System.Drawing.Point(215, 83);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label11.Size = new System.Drawing.Size(493, 18);
            this.label11.TabIndex = 25;
            this.label11.Text = "Set the Start and Stop time to the same on days where you do not want to send ema" +
    "ils (IE: Weekends) ";
            // 
            // DelaySendOptions
            // 
            this.AcceptButton = this.SaveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelSettings;
            this.ClientSize = new System.Drawing.Size(723, 231);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DelaySendOptions";
            this.Text = "Delay Send Options";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.LayoutTableSaveCancel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel LayoutTableSaveCancel;
        private System.Windows.Forms.Button CancelSettings;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Start_Monday;
        private System.Windows.Forms.DateTimePicker End_Monday;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker End_Tuesday;
        private System.Windows.Forms.DateTimePicker Start_Tuesday;
        private System.Windows.Forms.DateTimePicker Start_Wednesday;
        private System.Windows.Forms.DateTimePicker End_Wednesday;
        private System.Windows.Forms.DateTimePicker Start_Thursday;
        private System.Windows.Forms.DateTimePicker End_Thursday;
        private System.Windows.Forms.DateTimePicker Start_Friday;
        private System.Windows.Forms.DateTimePicker End_Friday;
        private System.Windows.Forms.DateTimePicker Start_Saturday;
        private System.Windows.Forms.DateTimePicker Start_Sunday;
        private System.Windows.Forms.DateTimePicker End_Saturday;
        private System.Windows.Forms.DateTimePicker End_Sunday;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}