namespace Plugin1
{
    partial class XtraUserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.testDataSet = new Plugin1.testDataSet();
            this.testDataSetBindingSource = new System.Windows.Forms.BindingSource();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource();
            this.paymentTableAdapter = new Plugin1.testDataSetTableAdapters.paymentTableAdapter();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.payment_idTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForpayment_id = new DevExpress.XtraLayout.LayoutControlItem();
            this.customer_idTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForcustomer_id = new DevExpress.XtraLayout.LayoutControlItem();
            this.staff_idTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForstaff_id = new DevExpress.XtraLayout.LayoutControlItem();
            this.rental_idTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForrental_id = new DevExpress.XtraLayout.LayoutControlItem();
            this.amountTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForamount = new DevExpress.XtraLayout.LayoutControlItem();
            this.payment_dateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ItemForpayment_date = new DevExpress.XtraLayout.LayoutControlItem();
            this.last_updateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ItemForlast_update = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payment_idTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForpayment_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_idTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForcustomer_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staff_idTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForstaff_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rental_idTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForrental_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForamount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payment_dateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payment_dateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForpayment_date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_updateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_updateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForlast_update)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "testDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testDataSetBindingSource
            // 
            this.testDataSetBindingSource.DataSource = this.testDataSet;
            this.testDataSetBindingSource.Position = 0;
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "payment";
            this.paymentBindingSource.DataSource = this.testDataSetBindingSource;
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.payment_idTextEdit);
            this.dataLayoutControl1.Controls.Add(this.customer_idTextEdit);
            this.dataLayoutControl1.Controls.Add(this.staff_idTextEdit);
            this.dataLayoutControl1.Controls.Add(this.rental_idTextEdit);
            this.dataLayoutControl1.Controls.Add(this.amountTextEdit);
            this.dataLayoutControl1.Controls.Add(this.payment_dateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.last_updateDateEdit);
            this.dataLayoutControl1.DataSource = this.paymentBindingSource;
            this.dataLayoutControl1.Location = new System.Drawing.Point(8, 80);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(594, 215);
            this.dataLayoutControl1.TabIndex = 1;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(594, 215);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForpayment_id,
            this.ItemForcustomer_id,
            this.ItemForstaff_id,
            this.ItemForrental_id,
            this.ItemForamount,
            this.ItemForpayment_date,
            this.ItemForlast_update});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(574, 195);
            // 
            // payment_idTextEdit
            // 
            this.payment_idTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.paymentBindingSource, "payment_id", true));
            this.payment_idTextEdit.Location = new System.Drawing.Point(86, 12);
            this.payment_idTextEdit.Name = "payment_idTextEdit";
            this.payment_idTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.payment_idTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.payment_idTextEdit.Properties.Mask.EditMask = "N0";
            this.payment_idTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.payment_idTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.payment_idTextEdit.Size = new System.Drawing.Size(209, 20);
            this.payment_idTextEdit.StyleController = this.dataLayoutControl1;
            this.payment_idTextEdit.TabIndex = 4;
            // 
            // ItemForpayment_id
            // 
            this.ItemForpayment_id.Control = this.payment_idTextEdit;
            this.ItemForpayment_id.Location = new System.Drawing.Point(0, 0);
            this.ItemForpayment_id.Name = "ItemForpayment_id";
            this.ItemForpayment_id.Size = new System.Drawing.Size(287, 24);
            this.ItemForpayment_id.Text = "payment_id";
            this.ItemForpayment_id.TextSize = new System.Drawing.Size(70, 13);
            // 
            // customer_idTextEdit
            // 
            this.customer_idTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.paymentBindingSource, "customer_id", true));
            this.customer_idTextEdit.Location = new System.Drawing.Point(373, 12);
            this.customer_idTextEdit.Name = "customer_idTextEdit";
            this.customer_idTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.customer_idTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.customer_idTextEdit.Properties.Mask.EditMask = "N0";
            this.customer_idTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.customer_idTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.customer_idTextEdit.Size = new System.Drawing.Size(209, 20);
            this.customer_idTextEdit.StyleController = this.dataLayoutControl1;
            this.customer_idTextEdit.TabIndex = 5;
            // 
            // ItemForcustomer_id
            // 
            this.ItemForcustomer_id.Control = this.customer_idTextEdit;
            this.ItemForcustomer_id.Location = new System.Drawing.Point(287, 0);
            this.ItemForcustomer_id.Name = "ItemForcustomer_id";
            this.ItemForcustomer_id.Size = new System.Drawing.Size(287, 24);
            this.ItemForcustomer_id.Text = "customer_id";
            this.ItemForcustomer_id.TextSize = new System.Drawing.Size(70, 13);
            // 
            // staff_idTextEdit
            // 
            this.staff_idTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.paymentBindingSource, "staff_id", true));
            this.staff_idTextEdit.Location = new System.Drawing.Point(86, 36);
            this.staff_idTextEdit.Name = "staff_idTextEdit";
            this.staff_idTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.staff_idTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.staff_idTextEdit.Properties.Mask.EditMask = "N0";
            this.staff_idTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.staff_idTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.staff_idTextEdit.Size = new System.Drawing.Size(209, 20);
            this.staff_idTextEdit.StyleController = this.dataLayoutControl1;
            this.staff_idTextEdit.TabIndex = 6;
            // 
            // ItemForstaff_id
            // 
            this.ItemForstaff_id.Control = this.staff_idTextEdit;
            this.ItemForstaff_id.Location = new System.Drawing.Point(0, 24);
            this.ItemForstaff_id.Name = "ItemForstaff_id";
            this.ItemForstaff_id.Size = new System.Drawing.Size(287, 24);
            this.ItemForstaff_id.Text = "staff_id";
            this.ItemForstaff_id.TextSize = new System.Drawing.Size(70, 13);
            // 
            // rental_idTextEdit
            // 
            this.rental_idTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.paymentBindingSource, "rental_id", true));
            this.rental_idTextEdit.Location = new System.Drawing.Point(373, 36);
            this.rental_idTextEdit.Name = "rental_idTextEdit";
            this.rental_idTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.rental_idTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.rental_idTextEdit.Properties.Mask.EditMask = "N0";
            this.rental_idTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.rental_idTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.rental_idTextEdit.Size = new System.Drawing.Size(209, 20);
            this.rental_idTextEdit.StyleController = this.dataLayoutControl1;
            this.rental_idTextEdit.TabIndex = 7;
            // 
            // ItemForrental_id
            // 
            this.ItemForrental_id.Control = this.rental_idTextEdit;
            this.ItemForrental_id.Location = new System.Drawing.Point(287, 24);
            this.ItemForrental_id.Name = "ItemForrental_id";
            this.ItemForrental_id.Size = new System.Drawing.Size(287, 24);
            this.ItemForrental_id.Text = "rental_id";
            this.ItemForrental_id.TextSize = new System.Drawing.Size(70, 13);
            // 
            // amountTextEdit
            // 
            this.amountTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.paymentBindingSource, "amount", true));
            this.amountTextEdit.Location = new System.Drawing.Point(86, 60);
            this.amountTextEdit.Name = "amountTextEdit";
            this.amountTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.amountTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.amountTextEdit.Properties.Mask.EditMask = "G";
            this.amountTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.amountTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.amountTextEdit.Size = new System.Drawing.Size(209, 20);
            this.amountTextEdit.StyleController = this.dataLayoutControl1;
            this.amountTextEdit.TabIndex = 8;
            // 
            // ItemForamount
            // 
            this.ItemForamount.Control = this.amountTextEdit;
            this.ItemForamount.Location = new System.Drawing.Point(0, 48);
            this.ItemForamount.Name = "ItemForamount";
            this.ItemForamount.Size = new System.Drawing.Size(287, 24);
            this.ItemForamount.Text = "amount";
            this.ItemForamount.TextSize = new System.Drawing.Size(70, 13);
            // 
            // payment_dateDateEdit
            // 
            this.payment_dateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.paymentBindingSource, "payment_date", true));
            this.payment_dateDateEdit.EditValue = null;
            this.payment_dateDateEdit.Location = new System.Drawing.Point(373, 60);
            this.payment_dateDateEdit.Name = "payment_dateDateEdit";
            this.payment_dateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.payment_dateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.payment_dateDateEdit.Size = new System.Drawing.Size(209, 20);
            this.payment_dateDateEdit.StyleController = this.dataLayoutControl1;
            this.payment_dateDateEdit.TabIndex = 9;
            // 
            // ItemForpayment_date
            // 
            this.ItemForpayment_date.Control = this.payment_dateDateEdit;
            this.ItemForpayment_date.Location = new System.Drawing.Point(287, 48);
            this.ItemForpayment_date.Name = "ItemForpayment_date";
            this.ItemForpayment_date.Size = new System.Drawing.Size(287, 24);
            this.ItemForpayment_date.Text = "payment_date";
            this.ItemForpayment_date.TextSize = new System.Drawing.Size(70, 13);
            // 
            // last_updateDateEdit
            // 
            this.last_updateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.paymentBindingSource, "last_update", true));
            this.last_updateDateEdit.EditValue = null;
            this.last_updateDateEdit.Location = new System.Drawing.Point(86, 84);
            this.last_updateDateEdit.Name = "last_updateDateEdit";
            this.last_updateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.last_updateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.last_updateDateEdit.Size = new System.Drawing.Size(496, 20);
            this.last_updateDateEdit.StyleController = this.dataLayoutControl1;
            this.last_updateDateEdit.TabIndex = 10;
            // 
            // ItemForlast_update
            // 
            this.ItemForlast_update.Control = this.last_updateDateEdit;
            this.ItemForlast_update.Location = new System.Drawing.Point(0, 72);
            this.ItemForlast_update.Name = "ItemForlast_update";
            this.ItemForlast_update.Size = new System.Drawing.Size(574, 123);
            this.ItemForlast_update.Text = "last_update";
            this.ItemForlast_update.TextSize = new System.Drawing.Size(70, 13);
            // 
            // XtraUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.button1);
            this.Name = "XtraUserControl1";
            this.Size = new System.Drawing.Size(605, 438);
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payment_idTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForpayment_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_idTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForcustomer_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staff_idTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForstaff_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rental_idTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForrental_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForamount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payment_dateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payment_dateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForpayment_date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_updateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_updateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForlast_update)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private testDataSet testDataSet;
        private System.Windows.Forms.BindingSource testDataSetBindingSource;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private testDataSetTableAdapters.paymentTableAdapter paymentTableAdapter;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit payment_idTextEdit;
        private DevExpress.XtraEditors.TextEdit customer_idTextEdit;
        private DevExpress.XtraEditors.TextEdit staff_idTextEdit;
        private DevExpress.XtraEditors.TextEdit rental_idTextEdit;
        private DevExpress.XtraEditors.TextEdit amountTextEdit;
        private DevExpress.XtraEditors.DateEdit payment_dateDateEdit;
        private DevExpress.XtraEditors.DateEdit last_updateDateEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForpayment_id;
        private DevExpress.XtraLayout.LayoutControlItem ItemForcustomer_id;
        private DevExpress.XtraLayout.LayoutControlItem ItemForstaff_id;
        private DevExpress.XtraLayout.LayoutControlItem ItemForrental_id;
        private DevExpress.XtraLayout.LayoutControlItem ItemForamount;
        private DevExpress.XtraLayout.LayoutControlItem ItemForpayment_date;
        private DevExpress.XtraLayout.LayoutControlItem ItemForlast_update;
    }
}
