namespace Asm2ListView
{
    partial class FCalculateWater
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
            this.components = new System.ComponentModel.Container();
            this.TxbLast = new System.Windows.Forms.TextBox();
            this.TxbThis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxbNo = new System.Windows.Forms.TextBox();
            this.LbNo = new System.Windows.Forms.Label();
            this.BttNew = new System.Windows.Forms.Button();
            this.BttDelete = new System.Windows.Forms.Button();
            this.BttEdit = new System.Windows.Forms.Button();
            this.BttAdd = new System.Windows.Forms.Button();
            this.LbTypesCustomer = new System.Windows.Forms.Label();
            this.TxbAddress = new System.Windows.Forms.TextBox();
            this.LbAddress = new System.Windows.Forms.Label();
            this.TxbPhone = new System.Windows.Forms.TextBox();
            this.LbPhone = new System.Windows.Forms.Label();
            this.CbType = new System.Windows.Forms.ComboBox();
            this.TxbName = new System.Windows.Forms.TextBox();
            this.LbName = new System.Windows.Forms.Label();
            this.LvWaterBill = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.BttShutDown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxbLast
            // 
            this.TxbLast.Location = new System.Drawing.Point(135, 139);
            this.TxbLast.Multiline = true;
            this.TxbLast.Name = "TxbLast";
            this.TxbLast.Size = new System.Drawing.Size(147, 30);
            this.TxbLast.TabIndex = 81;
            // 
            // TxbThis
            // 
            this.TxbThis.Location = new System.Drawing.Point(136, 185);
            this.TxbThis.Multiline = true;
            this.TxbThis.Name = "TxbThis";
            this.TxbThis.Size = new System.Drawing.Size(147, 30);
            this.TxbThis.TabIndex = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 27);
            this.label2.TabIndex = 79;
            this.label2.Text = "Last";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 27);
            this.label1.TabIndex = 78;
            this.label1.Text = "This";
            // 
            // TxbNo
            // 
            this.TxbNo.Location = new System.Drawing.Point(135, 36);
            this.TxbNo.Multiline = true;
            this.TxbNo.Name = "TxbNo";
            this.TxbNo.Size = new System.Drawing.Size(147, 30);
            this.TxbNo.TabIndex = 77;
            // 
            // LbNo
            // 
            this.LbNo.AutoSize = true;
            this.LbNo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNo.Location = new System.Drawing.Point(26, 39);
            this.LbNo.Name = "LbNo";
            this.LbNo.Size = new System.Drawing.Size(42, 27);
            this.LbNo.TabIndex = 76;
            this.LbNo.Text = "No";
            // 
            // BttNew
            // 
            this.BttNew.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttNew.Location = new System.Drawing.Point(27, 403);
            this.BttNew.Name = "BttNew";
            this.BttNew.Size = new System.Drawing.Size(136, 52);
            this.BttNew.TabIndex = 75;
            this.BttNew.Text = "New";
            this.BttNew.UseVisualStyleBackColor = true;
            this.BttNew.Click += new System.EventHandler(this.BttNew_Click);
            // 
            // BttDelete
            // 
            this.BttDelete.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttDelete.Location = new System.Drawing.Point(182, 403);
            this.BttDelete.Name = "BttDelete";
            this.BttDelete.Size = new System.Drawing.Size(136, 52);
            this.BttDelete.TabIndex = 74;
            this.BttDelete.Text = "Delete";
            this.BttDelete.UseVisualStyleBackColor = true;
            this.BttDelete.Click += new System.EventHandler(this.BttDelete_Click);
            // 
            // BttEdit
            // 
            this.BttEdit.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttEdit.Location = new System.Drawing.Point(182, 311);
            this.BttEdit.Name = "BttEdit";
            this.BttEdit.Size = new System.Drawing.Size(136, 52);
            this.BttEdit.TabIndex = 73;
            this.BttEdit.Text = "Edit";
            this.BttEdit.UseVisualStyleBackColor = true;
            this.BttEdit.Click += new System.EventHandler(this.BttEdit_Click);
            // 
            // BttAdd
            // 
            this.BttAdd.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttAdd.Location = new System.Drawing.Point(27, 311);
            this.BttAdd.Name = "BttAdd";
            this.BttAdd.Size = new System.Drawing.Size(136, 52);
            this.BttAdd.TabIndex = 72;
            this.BttAdd.Text = "Add";
            this.BttAdd.UseVisualStyleBackColor = true;
            this.BttAdd.Click += new System.EventHandler(this.BttAdd_Click);
            // 
            // LbTypesCustomer
            // 
            this.LbTypesCustomer.AutoSize = true;
            this.LbTypesCustomer.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTypesCustomer.Location = new System.Drawing.Point(323, 121);
            this.LbTypesCustomer.Name = "LbTypesCustomer";
            this.LbTypesCustomer.Size = new System.Drawing.Size(158, 27);
            this.LbTypesCustomer.TabIndex = 70;
            this.LbTypesCustomer.Text = "TypeCustomer";
            // 
            // TxbAddress
            // 
            this.TxbAddress.Location = new System.Drawing.Point(432, 74);
            this.TxbAddress.Multiline = true;
            this.TxbAddress.Name = "TxbAddress";
            this.TxbAddress.Size = new System.Drawing.Size(147, 30);
            this.TxbAddress.TabIndex = 69;
            // 
            // LbAddress
            // 
            this.LbAddress.AutoSize = true;
            this.LbAddress.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbAddress.Location = new System.Drawing.Point(323, 77);
            this.LbAddress.Name = "LbAddress";
            this.LbAddress.Size = new System.Drawing.Size(93, 27);
            this.LbAddress.TabIndex = 68;
            this.LbAddress.Text = "Address";
            // 
            // TxbPhone
            // 
            this.TxbPhone.Location = new System.Drawing.Point(432, 33);
            this.TxbPhone.Multiline = true;
            this.TxbPhone.Name = "TxbPhone";
            this.TxbPhone.Size = new System.Drawing.Size(147, 30);
            this.TxbPhone.TabIndex = 67;
            // 
            // LbPhone
            // 
            this.LbPhone.AutoSize = true;
            this.LbPhone.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPhone.Location = new System.Drawing.Point(323, 36);
            this.LbPhone.Name = "LbPhone";
            this.LbPhone.Size = new System.Drawing.Size(76, 27);
            this.LbPhone.TabIndex = 66;
            this.LbPhone.Text = "Phone";
            // 
            // CbType
            // 
            this.CbType.DropDownHeight = 300;
            this.CbType.FormattingEnabled = true;
            this.CbType.IntegralHeight = false;
            this.CbType.Items.AddRange(new object[] {
            "Household customer",
            "Administrative agency, public services",
            "Production units",
            "Business services"});
            this.CbType.Location = new System.Drawing.Point(510, 126);
            this.CbType.Name = "CbType";
            this.CbType.Size = new System.Drawing.Size(92, 24);
            this.CbType.TabIndex = 65;
            this.CbType.SelectedIndexChanged += new System.EventHandler(this.CbType_SelectedIndexChanged);
            // 
            // TxbName
            // 
            this.TxbName.Location = new System.Drawing.Point(135, 81);
            this.TxbName.Multiline = true;
            this.TxbName.Name = "TxbName";
            this.TxbName.Size = new System.Drawing.Size(145, 30);
            this.TxbName.TabIndex = 64;
            // 
            // LbName
            // 
            this.LbName.AutoSize = true;
            this.LbName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbName.Location = new System.Drawing.Point(26, 81);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(73, 27);
            this.LbName.TabIndex = 62;
            this.LbName.Text = "Name";
            // 
            // LvWaterBill
            // 
            this.LvWaterBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvWaterBill.GridLines = true;
            this.LvWaterBill.HideSelection = false;
            this.LvWaterBill.Location = new System.Drawing.Point(343, 156);
            this.LvWaterBill.Name = "LvWaterBill";
            this.LvWaterBill.Size = new System.Drawing.Size(943, 380);
            this.LvWaterBill.TabIndex = 82;
            this.LvWaterBill.UseCompatibleStateImageBehavior = false;
            this.LvWaterBill.View = System.Windows.Forms.View.Details;
            this.LvWaterBill.SelectedIndexChanged += new System.EventHandler(this.LvWaterBill_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(703, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 40);
            this.label3.TabIndex = 84;
            this.label3.Text = "WaterBill-Calculate";
            // 
            // BttShutDown
            // 
            this.BttShutDown.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttShutDown.Location = new System.Drawing.Point(31, 500);
            this.BttShutDown.Name = "BttShutDown";
            this.BttShutDown.Size = new System.Drawing.Size(136, 52);
            this.BttShutDown.TabIndex = 85;
            this.BttShutDown.Text = "Shutdown";
            this.BttShutDown.UseVisualStyleBackColor = true;
            this.BttShutDown.Click += new System.EventHandler(this.button1_Click);
            // 
            // FCalculateWater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1507, 659);
            this.Controls.Add(this.BttShutDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LvWaterBill);
            this.Controls.Add(this.TxbLast);
            this.Controls.Add(this.TxbThis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxbNo);
            this.Controls.Add(this.LbNo);
            this.Controls.Add(this.BttNew);
            this.Controls.Add(this.BttDelete);
            this.Controls.Add(this.BttEdit);
            this.Controls.Add(this.BttAdd);
            this.Controls.Add(this.LbTypesCustomer);
            this.Controls.Add(this.TxbAddress);
            this.Controls.Add(this.LbAddress);
            this.Controls.Add(this.TxbPhone);
            this.Controls.Add(this.LbPhone);
            this.Controls.Add(this.CbType);
            this.Controls.Add(this.TxbName);
            this.Controls.Add(this.LbName);
            this.Name = "FCalculateWater";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.FCalculateWater_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxbLast;
        private System.Windows.Forms.TextBox TxbThis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxbNo;
        private System.Windows.Forms.Label LbNo;
        private System.Windows.Forms.Button BttNew;
        private System.Windows.Forms.Button BttDelete;
        private System.Windows.Forms.Button BttEdit;
        private System.Windows.Forms.Button BttAdd;
        private System.Windows.Forms.Label LbTypesCustomer;
        private System.Windows.Forms.TextBox TxbAddress;
        private System.Windows.Forms.Label LbAddress;
        private System.Windows.Forms.TextBox TxbPhone;
        private System.Windows.Forms.Label LbPhone;
        private System.Windows.Forms.ComboBox CbType;
        private System.Windows.Forms.TextBox TxbName;
        private System.Windows.Forms.Label LbName;
        private System.Windows.Forms.ListView LvWaterBill;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BttShutDown;
    }
}