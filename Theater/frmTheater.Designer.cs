
namespace Theater
{
    partial class frmTheater
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.chbDinnerPackage = new System.Windows.Forms.CheckBox();
            this.rdoVehiclesYes = new System.Windows.Forms.RadioButton();
            this.txtPriceInfo = new System.Windows.Forms.TextBox();
            this.lstNumOfVehicles = new System.Windows.Forms.ListBox();
            this.grbVehicleParking = new System.Windows.Forms.GroupBox();
            this.rdoVehiclesNo = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMezzanine = new System.Windows.Forms.TextBox();
            this.txtFloorTwo = new System.Windows.Forms.TextBox();
            this.txtFloorOne = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGallery = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grbVehicleParking.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "C&ustomer name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(215, 34);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(144, 35);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.Clear_Output);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer &phone number:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(215, 70);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(144, 35);
            this.txtPhoneNumber.TabIndex = 3;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.Clear_Output);
            // 
            // chbDinnerPackage
            // 
            this.chbDinnerPackage.AutoSize = true;
            this.chbDinnerPackage.Location = new System.Drawing.Point(261, 325);
            this.chbDinnerPackage.Margin = new System.Windows.Forms.Padding(4);
            this.chbDinnerPackage.Name = "chbDinnerPackage";
            this.chbDinnerPackage.Size = new System.Drawing.Size(208, 33);
            this.chbDinnerPackage.TabIndex = 7;
            this.chbDinnerPackage.Text = "Dinner package";
            this.chbDinnerPackage.UseVisualStyleBackColor = true;
            this.chbDinnerPackage.TextChanged += new System.EventHandler(this.Clear_Output);
            // 
            // rdoVehiclesYes
            // 
            this.rdoVehiclesYes.AutoSize = true;
            this.rdoVehiclesYes.Location = new System.Drawing.Point(9, 41);
            this.rdoVehiclesYes.Margin = new System.Windows.Forms.Padding(4);
            this.rdoVehiclesYes.Name = "rdoVehiclesYes";
            this.rdoVehiclesYes.Size = new System.Drawing.Size(80, 33);
            this.rdoVehiclesYes.TabIndex = 0;
            this.rdoVehiclesYes.TabStop = true;
            this.rdoVehiclesYes.Text = "Yes";
            this.rdoVehiclesYes.UseVisualStyleBackColor = true;
            this.rdoVehiclesYes.TextChanged += new System.EventHandler(this.Clear_Output);
            // 
            // txtPriceInfo
            // 
            this.txtPriceInfo.Location = new System.Drawing.Point(413, 34);
            this.txtPriceInfo.Margin = new System.Windows.Forms.Padding(4);
            this.txtPriceInfo.Multiline = true;
            this.txtPriceInfo.Name = "txtPriceInfo";
            this.txtPriceInfo.ReadOnly = true;
            this.txtPriceInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPriceInfo.Size = new System.Drawing.Size(378, 166);
            this.txtPriceInfo.TabIndex = 8;
            this.txtPriceInfo.TabStop = false;
            // 
            // lstNumOfVehicles
            // 
            this.lstNumOfVehicles.FormattingEnabled = true;
            this.lstNumOfVehicles.ItemHeight = 29;
            this.lstNumOfVehicles.Location = new System.Drawing.Point(198, 325);
            this.lstNumOfVehicles.Margin = new System.Windows.Forms.Padding(4);
            this.lstNumOfVehicles.Name = "lstNumOfVehicles";
            this.lstNumOfVehicles.Size = new System.Drawing.Size(40, 91);
            this.lstNumOfVehicles.TabIndex = 6;
            // 
            // grbVehicleParking
            // 
            this.grbVehicleParking.Controls.Add(this.rdoVehiclesNo);
            this.grbVehicleParking.Controls.Add(this.rdoVehiclesYes);
            this.grbVehicleParking.Location = new System.Drawing.Point(20, 325);
            this.grbVehicleParking.Margin = new System.Windows.Forms.Padding(4);
            this.grbVehicleParking.Name = "grbVehicleParking";
            this.grbVehicleParking.Padding = new System.Windows.Forms.Padding(4);
            this.grbVehicleParking.Size = new System.Drawing.Size(156, 86);
            this.grbVehicleParking.TabIndex = 5;
            this.grbVehicleParking.TabStop = false;
            this.grbVehicleParking.Text = "Vehicle parking";
            // 
            // rdoVehiclesNo
            // 
            this.rdoVehiclesNo.AutoSize = true;
            this.rdoVehiclesNo.Location = new System.Drawing.Point(94, 41);
            this.rdoVehiclesNo.Margin = new System.Windows.Forms.Padding(4);
            this.rdoVehiclesNo.Name = "rdoVehiclesNo";
            this.rdoVehiclesNo.Size = new System.Drawing.Size(70, 33);
            this.rdoVehiclesNo.TabIndex = 1;
            this.rdoVehiclesNo.TabStop = true;
            this.rdoVehiclesNo.Text = "No";
            this.rdoVehiclesNo.UseVisualStyleBackColor = true;
            this.rdoVehiclesNo.TextChanged += new System.EventHandler(this.Clear_Output);
            // 
            // btnCalculate
            // 
            this.btnCalculate.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnCalculate.Location = new System.Drawing.Point(413, 382);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(114, 48);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(536, 382);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(123, 48);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(667, 382);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 48);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(413, 225);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4);
            this.lblTotal.Multiline = true;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.ReadOnly = true;
            this.lblTotal.Size = new System.Drawing.Size(378, 149);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMezzanine);
            this.groupBox1.Controls.Add(this.txtFloorTwo);
            this.groupBox1.Controls.Add(this.txtFloorOne);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtGallery);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(20, 122);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(362, 180);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seat types";
            // 
            // txtMezzanine
            // 
            this.txtMezzanine.Location = new System.Drawing.Point(210, 131);
            this.txtMezzanine.Margin = new System.Windows.Forms.Padding(4);
            this.txtMezzanine.Name = "txtMezzanine";
            this.txtMezzanine.Size = new System.Drawing.Size(128, 35);
            this.txtMezzanine.TabIndex = 7;
            this.txtMezzanine.TextChanged += new System.EventHandler(this.Clear_Output);
            // 
            // txtFloorTwo
            // 
            this.txtFloorTwo.Location = new System.Drawing.Point(210, 95);
            this.txtFloorTwo.Margin = new System.Windows.Forms.Padding(4);
            this.txtFloorTwo.Name = "txtFloorTwo";
            this.txtFloorTwo.Size = new System.Drawing.Size(128, 35);
            this.txtFloorTwo.TabIndex = 5;
            this.txtFloorTwo.TextChanged += new System.EventHandler(this.Clear_Output);
            // 
            // txtFloorOne
            // 
            this.txtFloorOne.Location = new System.Drawing.Point(210, 62);
            this.txtFloorOne.Margin = new System.Windows.Forms.Padding(4);
            this.txtFloorOne.Name = "txtFloorOne";
            this.txtFloorOne.Size = new System.Drawing.Size(128, 35);
            this.txtFloorOne.TabIndex = 3;
            this.txtFloorOne.TextChanged += new System.EventHandler(this.Clear_Output);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 135);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "&Mezzanine seat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 102);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(291, 29);
            this.label6.TabIndex = 4;
            this.label6.Text = "Fl&oor seat (rows 21 to 40):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "&Floor seat (rows 1 to 20):";
            // 
            // txtGallery
            // 
            this.txtGallery.Location = new System.Drawing.Point(210, 28);
            this.txtGallery.Margin = new System.Windows.Forms.Padding(4);
            this.txtGallery.Name = "txtGallery";
            this.txtGallery.Size = new System.Drawing.Size(128, 35);
            this.txtGallery.TabIndex = 1;
            this.txtGallery.TextChanged += new System.EventHandler(this.Clear_Output);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "&Gallery seat:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(409, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Pricing information:";
            // 
            // frmTheater
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 445);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grbVehicleParking);
            this.Controls.Add(this.lstNumOfVehicles);
            this.Controls.Add(this.txtPriceInfo);
            this.Controls.Add(this.chbDinnerPackage);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTheater";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HFCC Theater";
            this.Load += new System.EventHandler(this.frmTheater_Load);
            this.TextChanged += new System.EventHandler(this.Clear_Output);
            this.grbVehicleParking.ResumeLayout(false);
            this.grbVehicleParking.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.CheckBox chbDinnerPackage;
        private System.Windows.Forms.RadioButton rdoVehiclesYes;
        private System.Windows.Forms.TextBox txtPriceInfo;
        private System.Windows.Forms.ListBox lstNumOfVehicles;
        private System.Windows.Forms.GroupBox grbVehicleParking;
        private System.Windows.Forms.RadioButton rdoVehiclesNo;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox lblTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMezzanine;
        private System.Windows.Forms.TextBox txtFloorTwo;
        private System.Windows.Forms.TextBox txtFloorOne;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGallery;
        private System.Windows.Forms.Label label5;
    }
}

