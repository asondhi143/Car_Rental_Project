
namespace CarRentalProject
{
    partial class FormCarInfo
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.lblCarDetails = new System.Windows.Forms.Label();
            this.lblCarName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblFeatures = new System.Windows.Forms.Label();
            this.btnNextImage = new System.Windows.Forms.Button();
            this.btnPreviousImage = new System.Windows.Forms.Button();
            this.pictureBoxCars = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCars)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(936, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(51, 39);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Eras Bold ITC", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(256, 547);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(138, 65);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back to \r\nMain Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.Red;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBook.Font = new System.Drawing.Font("Eras Bold ITC", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBook.Location = new System.Drawing.Point(434, 547);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(138, 65);
            this.btnBook.TabIndex = 8;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // lblCarDetails
            // 
            this.lblCarDetails.AutoSize = true;
            this.lblCarDetails.BackColor = System.Drawing.Color.Black;
            this.lblCarDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCarDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCarDetails.Font = new System.Drawing.Font("Eras Bold ITC", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarDetails.ForeColor = System.Drawing.Color.Red;
            this.lblCarDetails.Location = new System.Drawing.Point(340, 23);
            this.lblCarDetails.Name = "lblCarDetails";
            this.lblCarDetails.Size = new System.Drawing.Size(287, 58);
            this.lblCarDetails.TabIndex = 9;
            this.lblCarDetails.Text = "Car Details";
            // 
            // lblCarName
            // 
            this.lblCarName.AutoSize = true;
            this.lblCarName.BackColor = System.Drawing.Color.Black;
            this.lblCarName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCarName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCarName.Font = new System.Drawing.Font("Eras Bold ITC", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarName.ForeColor = System.Drawing.Color.Red;
            this.lblCarName.Location = new System.Drawing.Point(34, 131);
            this.lblCarName.Name = "lblCarName";
            this.lblCarName.Size = new System.Drawing.Size(311, 35);
            this.lblCarName.TabIndex = 11;
            this.lblCarName.Text = "Car Name and Model";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Black;
            this.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrice.Font = new System.Drawing.Font("Eras Demi ITC", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrice.Location = new System.Drawing.Point(92, 459);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(81, 34);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "Price";
            // 
            // lblFeatures
            // 
            this.lblFeatures.AutoSize = true;
            this.lblFeatures.Location = new System.Drawing.Point(532, 131);
            this.lblFeatures.Name = "lblFeatures";
            this.lblFeatures.Size = new System.Drawing.Size(90, 24);
            this.lblFeatures.TabIndex = 13;
            this.lblFeatures.Text = "Features";
            // 
            // btnNextImage
            // 
            this.btnNextImage.BackColor = System.Drawing.Color.Black;
            this.btnNextImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextImage.Font = new System.Drawing.Font("Matura MT Script Capitals", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnNextImage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNextImage.Location = new System.Drawing.Point(376, 297);
            this.btnNextImage.Name = "btnNextImage";
            this.btnNextImage.Size = new System.Drawing.Size(37, 43);
            this.btnNextImage.TabIndex = 14;
            this.btnNextImage.Text = ">";
            this.btnNextImage.UseVisualStyleBackColor = false;
            this.btnNextImage.Click += new System.EventHandler(this.btnNextImage_Click);
            // 
            // btnPreviousImage
            // 
            this.btnPreviousImage.BackColor = System.Drawing.Color.Black;
            this.btnPreviousImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviousImage.Font = new System.Drawing.Font("Matura MT Script Capitals", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousImage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPreviousImage.Location = new System.Drawing.Point(1, 297);
            this.btnPreviousImage.Name = "btnPreviousImage";
            this.btnPreviousImage.Size = new System.Drawing.Size(37, 43);
            this.btnPreviousImage.TabIndex = 15;
            this.btnPreviousImage.Text = "<";
            this.btnPreviousImage.UseVisualStyleBackColor = false;
            this.btnPreviousImage.Click += new System.EventHandler(this.btnPreviousImage_Click);
            // 
            // pictureBoxCars
            // 
            this.pictureBoxCars.BackColor = System.Drawing.Color.Black;
            this.pictureBoxCars.Location = new System.Drawing.Point(40, 194);
            this.pictureBoxCars.Name = "pictureBoxCars";
            this.pictureBoxCars.Size = new System.Drawing.Size(334, 233);
            this.pictureBoxCars.TabIndex = 0;
            this.pictureBoxCars.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 79.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 805);
            this.label1.TabIndex = 16;
            this.label1.Text = "XX       \r\nXX\r\n\r\nXX\r\nxX";
            // 
            // FormCarInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1020, 624);
            this.ControlBox = false;
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnNextImage);
            this.Controls.Add(this.pictureBoxCars);
            this.Controls.Add(this.btnPreviousImage);
            this.Controls.Add(this.lblCarName);
            this.Controls.Add(this.lblFeatures);
            this.Controls.Add(this.lblCarDetails);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Maiandra GD", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormCarInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cars Information";
            this.Load += new System.EventHandler(this.FormCarInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCars;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Label lblCarDetails;
        private System.Windows.Forms.Label lblCarName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblFeatures;
        private System.Windows.Forms.Button btnNextImage;
        private System.Windows.Forms.Button btnPreviousImage;
        private System.Windows.Forms.Label label1;
    }
}