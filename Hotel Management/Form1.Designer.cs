namespace Hotel_Management
{
    partial class frmHotel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHotel));
            lblHotel = new Label();
            gbInfo = new GroupBox();
            numPax = new NumericUpDown();
            numAge = new NumericUpDown();
            txtContact = new TextBox();
            txtName = new TextBox();
            lblPax = new Label();
            lblAge = new Label();
            lblContact = new Label();
            lblName = new Label();
            gbAccommodation = new GroupBox();
            radExclusive = new RadioButton();
            radDeluxe = new RadioButton();
            radEconomy = new RadioButton();
            radStandard = new RadioButton();
            radRegular = new RadioButton();
            radSilver = new RadioButton();
            radGold = new RadioButton();
            radPlat = new RadioButton();
            gbDiscount = new GroupBox();
            gbBilling = new GroupBox();
            btnCalculate = new Button();
            txtPayment = new TextBox();
            txtDue = new TextBox();
            txtDiscount = new TextBox();
            txtAmount = new TextBox();
            lblDue = new Label();
            lblPayment = new Label();
            lblDiscount = new Label();
            lblAmount = new Label();
            gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAge).BeginInit();
            gbAccommodation.SuspendLayout();
            gbDiscount.SuspendLayout();
            gbBilling.SuspendLayout();
            SuspendLayout();
            // 
            // lblHotel
            // 
            lblHotel.AutoSize = true;
            lblHotel.Font = new Font("Poppins SemiBold", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lblHotel.ForeColor = SystemColors.ButtonFace;
            lblHotel.Location = new Point(3, -5);
            lblHotel.Name = "lblHotel";
            lblHotel.Size = new Size(391, 70);
            lblHotel.TabIndex = 0;
            lblHotel.Text = "Hotel Reservation";
            // 
            // gbInfo
            // 
            gbInfo.BackColor = SystemColors.ControlDark;
            gbInfo.Controls.Add(numPax);
            gbInfo.Controls.Add(numAge);
            gbInfo.Controls.Add(txtContact);
            gbInfo.Controls.Add(txtName);
            gbInfo.Controls.Add(lblPax);
            gbInfo.Controls.Add(lblAge);
            gbInfo.Controls.Add(lblContact);
            gbInfo.Controls.Add(lblName);
            gbInfo.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gbInfo.Location = new Point(23, 68);
            gbInfo.Name = "gbInfo";
            gbInfo.Size = new Size(488, 206);
            gbInfo.TabIndex = 1;
            gbInfo.TabStop = false;
            gbInfo.Text = "Personal Information";
            // 
            // numPax
            // 
            numPax.Location = new Point(226, 160);
            numPax.Name = "numPax";
            numPax.Size = new Size(63, 31);
            numPax.TabIndex = 3;
            // 
            // numAge
            // 
            numAge.Location = new Point(226, 117);
            numAge.Name = "numAge";
            numAge.Size = new Size(63, 31);
            numAge.TabIndex = 3;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(110, 81);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(311, 31);
            txtContact.TabIndex = 1;
            txtContact.KeyPress += txtContact_KeyPress;
            // 
            // txtName
            // 
            txtName.Location = new Point(88, 32);
            txtName.Name = "txtName";
            txtName.Size = new Size(333, 31);
            txtName.TabIndex = 1;
            txtName.TextChanged += txtName_TextChanged;
            txtName.KeyPress += txtName_KeyPress;
            // 
            // lblPax
            // 
            lblPax.AutoSize = true;
            lblPax.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPax.Location = new Point(159, 160);
            lblPax.Name = "lblPax";
            lblPax.Size = new Size(47, 28);
            lblPax.TabIndex = 0;
            lblPax.Text = "Pax:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAge.Location = new Point(156, 117);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(50, 28);
            lblAge.TabIndex = 0;
            lblAge.Text = "Age:";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblContact.Location = new Point(4, 81);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(100, 28);
            lblContact.TabIndex = 0;
            lblContact.Text = "Contact #:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(14, 33);
            lblName.Name = "lblName";
            lblName.Size = new Size(67, 28);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // gbAccommodation
            // 
            gbAccommodation.BackColor = SystemColors.AppWorkspace;
            gbAccommodation.Controls.Add(radExclusive);
            gbAccommodation.Controls.Add(radDeluxe);
            gbAccommodation.Controls.Add(radEconomy);
            gbAccommodation.Controls.Add(radStandard);
            gbAccommodation.Enabled = false;
            gbAccommodation.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gbAccommodation.Location = new Point(23, 294);
            gbAccommodation.Name = "gbAccommodation";
            gbAccommodation.Size = new Size(232, 197);
            gbAccommodation.TabIndex = 2;
            gbAccommodation.TabStop = false;
            gbAccommodation.Text = "Accomodation";
            gbAccommodation.Enter += gbAccommodation_Enter;
            // 
            // radExclusive
            // 
            radExclusive.AutoSize = true;
            radExclusive.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radExclusive.Location = new Point(7, 133);
            radExclusive.Name = "radExclusive";
            radExclusive.Size = new Size(199, 32);
            radExclusive.TabIndex = 0;
            radExclusive.TabStop = true;
            radExclusive.Text = "Exclusive ($1000.00)";
            radExclusive.UseVisualStyleBackColor = true;
            radExclusive.CheckedChanged += radExclusive_CheckedChanged;
            // 
            // radDeluxe
            // 
            radDeluxe.AutoSize = true;
            radDeluxe.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radDeluxe.Location = new Point(7, 101);
            radDeluxe.Name = "radDeluxe";
            radDeluxe.Size = new Size(172, 32);
            radDeluxe.TabIndex = 0;
            radDeluxe.TabStop = true;
            radDeluxe.Text = "Deluxe ($850.00)";
            radDeluxe.UseVisualStyleBackColor = true;
            radDeluxe.CheckedChanged += radDeluxe_CheckedChanged;
            // 
            // radEconomy
            // 
            radEconomy.AutoSize = true;
            radEconomy.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radEconomy.Location = new Point(7, 69);
            radEconomy.Name = "radEconomy";
            radEconomy.Size = new Size(192, 32);
            radEconomy.TabIndex = 0;
            radEconomy.TabStop = true;
            radEconomy.Text = "Economy ($300.00)";
            radEconomy.UseVisualStyleBackColor = true;
            radEconomy.CheckedChanged += radEconomy_CheckedChanged;
            // 
            // radStandard
            // 
            radStandard.AutoSize = true;
            radStandard.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radStandard.Location = new Point(7, 37);
            radStandard.Name = "radStandard";
            radStandard.Size = new Size(194, 32);
            radStandard.TabIndex = 0;
            radStandard.TabStop = true;
            radStandard.Text = "Standard ($400.00)";
            radStandard.UseVisualStyleBackColor = true;
            radStandard.CheckedChanged += radStandard_CheckedChanged;
            // 
            // radRegular
            // 
            radRegular.AutoSize = true;
            radRegular.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radRegular.Location = new Point(7, 37);
            radRegular.Name = "radRegular";
            radRegular.Size = new Size(95, 32);
            radRegular.TabIndex = 0;
            radRegular.TabStop = true;
            radRegular.Text = "Regular";
            radRegular.UseVisualStyleBackColor = true;
            radRegular.CheckedChanged += radRegular_CheckedChanged;
            // 
            // radSilver
            // 
            radSilver.AutoSize = true;
            radSilver.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radSilver.Location = new Point(7, 69);
            radSilver.Name = "radSilver";
            radSilver.Size = new Size(120, 32);
            radSilver.TabIndex = 0;
            radSilver.TabStop = true;
            radSilver.Text = "Silver (5%)";
            radSilver.UseVisualStyleBackColor = true;
            radSilver.CheckedChanged += radSilver_CheckedChanged;
            // 
            // radGold
            // 
            radGold.AutoSize = true;
            radGold.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radGold.Location = new Point(7, 101);
            radGold.Name = "radGold";
            radGold.Size = new Size(117, 32);
            radGold.TabIndex = 0;
            radGold.TabStop = true;
            radGold.Text = "Gold (10%)";
            radGold.UseVisualStyleBackColor = true;
            radGold.CheckedChanged += radGold_CheckedChanged;
            // 
            // radPlat
            // 
            radPlat.AutoSize = true;
            radPlat.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radPlat.Location = new Point(7, 133);
            radPlat.Name = "radPlat";
            radPlat.Size = new Size(158, 32);
            radPlat.TabIndex = 0;
            radPlat.TabStop = true;
            radPlat.Text = "Platinum (20%)";
            radPlat.UseVisualStyleBackColor = true;
            radPlat.CheckedChanged += radPlat_CheckedChanged;
            // 
            // gbDiscount
            // 
            gbDiscount.BackColor = SystemColors.AppWorkspace;
            gbDiscount.Controls.Add(radPlat);
            gbDiscount.Controls.Add(radGold);
            gbDiscount.Controls.Add(radSilver);
            gbDiscount.Controls.Add(radRegular);
            gbDiscount.Enabled = false;
            gbDiscount.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gbDiscount.Location = new Point(279, 294);
            gbDiscount.Name = "gbDiscount";
            gbDiscount.Size = new Size(232, 197);
            gbDiscount.TabIndex = 2;
            gbDiscount.TabStop = false;
            gbDiscount.Text = "Discount";
            gbDiscount.Enter += gbDiscount_Enter;
            // 
            // gbBilling
            // 
            gbBilling.BackColor = SystemColors.AppWorkspace;
            gbBilling.Controls.Add(btnCalculate);
            gbBilling.Controls.Add(txtPayment);
            gbBilling.Controls.Add(txtDue);
            gbBilling.Controls.Add(txtDiscount);
            gbBilling.Controls.Add(txtAmount);
            gbBilling.Controls.Add(lblDue);
            gbBilling.Controls.Add(lblPayment);
            gbBilling.Controls.Add(lblDiscount);
            gbBilling.Controls.Add(lblAmount);
            gbBilling.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gbBilling.Location = new Point(530, 66);
            gbBilling.Name = "gbBilling";
            gbBilling.Size = new Size(242, 425);
            gbBilling.TabIndex = 3;
            gbBilling.TabStop = false;
            gbBilling.Text = "Billing Information";
            // 
            // btnCalculate
            // 
            btnCalculate.Enabled = false;
            btnCalculate.Location = new Point(50, 376);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(128, 34);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtPayment
            // 
            txtPayment.BackColor = Color.Cornsilk;
            txtPayment.Location = new Point(33, 328);
            txtPayment.Name = "txtPayment";
            txtPayment.Size = new Size(163, 31);
            txtPayment.TabIndex = 1;
            txtPayment.TextChanged += txtPayment_TextChanged;
            txtPayment.KeyPress += textBox1_KeyPress;
            // 
            // txtDue
            // 
            txtDue.BackColor = Color.Cornsilk;
            txtDue.Enabled = false;
            txtDue.Location = new Point(33, 211);
            txtDue.Name = "txtDue";
            txtDue.ReadOnly = true;
            txtDue.Size = new Size(163, 31);
            txtDue.TabIndex = 1;
            // 
            // txtDiscount
            // 
            txtDiscount.BackColor = Color.Cornsilk;
            txtDiscount.Enabled = false;
            txtDiscount.Location = new Point(33, 141);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.ReadOnly = true;
            txtDiscount.Size = new Size(163, 31);
            txtDiscount.TabIndex = 1;
            // 
            // txtAmount
            // 
            txtAmount.BackColor = Color.Cornsilk;
            txtAmount.Enabled = false;
            txtAmount.Location = new Point(33, 65);
            txtAmount.Name = "txtAmount";
            txtAmount.ReadOnly = true;
            txtAmount.Size = new Size(163, 31);
            txtAmount.TabIndex = 1;
            // 
            // lblDue
            // 
            lblDue.AutoSize = true;
            lblDue.Location = new Point(50, 180);
            lblDue.Name = "lblDue";
            lblDue.Size = new Size(120, 28);
            lblDue.TabIndex = 0;
            lblDue.Text = "Amount Due:";
            // 
            // lblPayment
            // 
            lblPayment.AutoSize = true;
            lblPayment.Location = new Point(50, 299);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(138, 28);
            lblPayment.TabIndex = 0;
            lblPayment.Text = "Enter Payment:";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(50, 110);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(135, 28);
            lblDiscount.TabIndex = 0;
            lblDiscount.Text = "Total Discount:";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(50, 34);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(128, 28);
            lblAmount.TabIndex = 0;
            lblAmount.Text = "Total Amount:";
            // 
            // frmHotel
            // 
            AutoScaleDimensions = new SizeF(7F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(788, 529);
            Controls.Add(gbBilling);
            Controls.Add(gbDiscount);
            Controls.Add(gbAccommodation);
            Controls.Add(gbInfo);
            Controls.Add(lblHotel);
            Font = new Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmHotel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hotel Reservation";
            TransparencyKey = SystemColors.ActiveBorder;
            Load += Form1_Load;
            gbInfo.ResumeLayout(false);
            gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPax).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAge).EndInit();
            gbAccommodation.ResumeLayout(false);
            gbAccommodation.PerformLayout();
            gbDiscount.ResumeLayout(false);
            gbDiscount.PerformLayout();
            gbBilling.ResumeLayout(false);
            gbBilling.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHotel;
        private GroupBox gbInfo;
        private TextBox txtContact;
        private TextBox txtName;
        private Label lblContact;
        private Label lblName;
        private Label lblPax;
        private Label lblAge;
        private NumericUpDown numPax;
        private NumericUpDown numAge;
        private GroupBox gbAccommodation;
        private RadioButton radExclusive;
        private RadioButton radDeluxe;
        private RadioButton radEconomy;
        private RadioButton radStandard;
        private RadioButton radRegular;
        private RadioButton radSilver;
        private RadioButton radGold;
        private RadioButton radPlat;
        private GroupBox gbDiscount;
        private GroupBox gbBilling;
        private Label lblAmount;
        private TextBox txtDue;
        private TextBox txtDiscount;
        private TextBox txtAmount;
        private Label lblDue;
        private Label lblDiscount;
        private Label lblPayment;
        private Button btnCalculate;
        private TextBox txtPayment;
    }
}