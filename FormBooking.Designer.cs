
namespace CarRentalProject
{
    partial class FormBooking
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
            this.btnClose = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPhnNmbr = new System.Windows.Forms.TextBox();
            this.txtCardNmbr = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblCreateBooking = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblPhNmbr = new System.Windows.Forms.Label();
            this.lblCardNbmr = new System.Windows.Forms.Label();
            this.datePickFrom = new System.Windows.Forms.DateTimePicker();
            this.datePickTo = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.btnViewBooking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(951, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(47, 37);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(212, 177);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(235, 30);
            this.txtFirstName.TabIndex = 8;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(689, 177);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(261, 30);
            this.txtLastName.TabIndex = 9;
            // 
            // txtPhnNmbr
            // 
            this.txtPhnNmbr.Location = new System.Drawing.Point(212, 286);
            this.txtPhnNmbr.Name = "txtPhnNmbr";
            this.txtPhnNmbr.Size = new System.Drawing.Size(235, 30);
            this.txtPhnNmbr.TabIndex = 10;
            // 
            // txtCardNmbr
            // 
            this.txtCardNmbr.Location = new System.Drawing.Point(689, 286);
            this.txtCardNmbr.Name = "txtCardNmbr";
            this.txtCardNmbr.Size = new System.Drawing.Size(285, 30);
            this.txtCardNmbr.TabIndex = 11;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Black;
            this.btnSubmit.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.Location = new System.Drawing.Point(324, 516);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(176, 76);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit Order";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblCreateBooking
            // 
            this.lblCreateBooking.AutoSize = true;
            this.lblCreateBooking.BackColor = System.Drawing.Color.Transparent;
            this.lblCreateBooking.Font = new System.Drawing.Font("Eras Bold ITC", 28.2F, System.Drawing.FontStyle.Italic);
            this.lblCreateBooking.ForeColor = System.Drawing.Color.Maroon;
            this.lblCreateBooking.Location = new System.Drawing.Point(323, 12);
            this.lblCreateBooking.Name = "lblCreateBooking";
            this.lblCreateBooking.Size = new System.Drawing.Size(424, 56);
            this.lblCreateBooking.TabIndex = 13;
            this.lblCreateBooking.Text = " Create Booking ";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.Location = new System.Drawing.Point(71, 180);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(116, 23);
            this.lblFName.TabIndex = 14;
            this.lblFName.Text = "First Name:";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Italic);
            this.lblLName.Location = new System.Drawing.Point(545, 180);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(114, 23);
            this.lblLName.TabIndex = 15;
            this.lblLName.Text = "Last Name:";
            // 
            // lblPhNmbr
            // 
            this.lblPhNmbr.AutoSize = true;
            this.lblPhNmbr.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Italic);
            this.lblPhNmbr.Location = new System.Drawing.Point(28, 289);
            this.lblPhNmbr.Name = "lblPhNmbr";
            this.lblPhNmbr.Size = new System.Drawing.Size(159, 23);
            this.lblPhNmbr.TabIndex = 16;
            this.lblPhNmbr.Text = "Phone Number:";
            // 
            // lblCardNbmr
            // 
            this.lblCardNbmr.AutoSize = true;
            this.lblCardNbmr.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Italic);
            this.lblCardNbmr.Location = new System.Drawing.Point(516, 289);
            this.lblCardNbmr.Name = "lblCardNbmr";
            this.lblCardNbmr.Size = new System.Drawing.Size(143, 23);
            this.lblCardNbmr.TabIndex = 17;
            this.lblCardNbmr.Text = "Card Number:";
            // 
            // datePickFrom
            // 
            this.datePickFrom.CalendarFont = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Italic);
            this.datePickFrom.CustomFormat = "MM/dd/yyyy";
            this.datePickFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickFrom.Location = new System.Drawing.Point(212, 390);
            this.datePickFrom.Name = "datePickFrom";
            this.datePickFrom.Size = new System.Drawing.Size(241, 30);
            this.datePickFrom.TabIndex = 18;
            this.datePickFrom.Value = new System.DateTime(2023, 4, 4, 0, 0, 0, 0);
            // 
            // datePickTo
            // 
            this.datePickTo.CalendarFont = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Italic);
            this.datePickTo.CustomFormat = "MM/dd/yyyy";
            this.datePickTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickTo.Location = new System.Drawing.Point(689, 390);
            this.datePickTo.Name = "datePickTo";
            this.datePickTo.Size = new System.Drawing.Size(241, 30);
            this.datePickTo.TabIndex = 19;
            this.datePickTo.Value = new System.DateTime(2023, 4, 4, 0, 0, 0, 0);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Italic);
            this.lblStartDate.Location = new System.Drawing.Point(80, 395);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(107, 23);
            this.lblStartDate.TabIndex = 20;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Italic);
            this.lblEndDate.Location = new System.Drawing.Point(557, 395);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(102, 23);
            this.lblEndDate.TabIndex = 21;
            this.lblEndDate.Text = "End Date:";
            // 
            // btnViewBooking
            // 
            this.btnViewBooking.BackColor = System.Drawing.Color.Black;
            this.btnViewBooking.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewBooking.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnViewBooking.Location = new System.Drawing.Point(520, 516);
            this.btnViewBooking.Name = "btnViewBooking";
            this.btnViewBooking.Size = new System.Drawing.Size(176, 76);
            this.btnViewBooking.TabIndex = 22;
            this.btnViewBooking.Text = "View Booking";
            this.btnViewBooking.UseVisualStyleBackColor = false;
            this.btnViewBooking.Click += new System.EventHandler(this.btnViewBooking_Click);
            // 
            // FormBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1020, 624);
            this.ControlBox = false;
            this.Controls.Add(this.btnViewBooking);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.datePickTo);
            this.Controls.Add(this.datePickFrom);
            this.Controls.Add(this.lblCardNbmr);
            this.Controls.Add(this.lblPhNmbr);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.lblCreateBooking);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtCardNmbr);
            this.Controls.Add(this.txtPhnNmbr);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Your Car";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPhnNmbr;
        private System.Windows.Forms.TextBox txtCardNmbr;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblCreateBooking;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblPhNmbr;
        private System.Windows.Forms.Label lblCardNbmr;
        private System.Windows.Forms.DateTimePicker datePickFrom;
        private System.Windows.Forms.DateTimePicker datePickTo;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Button btnViewBooking;
    }
}