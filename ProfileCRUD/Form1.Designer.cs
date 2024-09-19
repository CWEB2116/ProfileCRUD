namespace ProfileCRUD
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_reg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.dataGrid_DispRec = new System.Windows.Forms.DataGridView();
            this.profDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authenticateDataSet = new ProfileCRUD.AuthenticateDataSet();
            this.btn_displayAll = new System.Windows.Forms.Button();
            this.profDetailsTableAdapter = new ProfileCRUD.AuthenticateDataSetTableAdapters.ProfDetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_DispRec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authenticateDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_reg
            // 
            this.txt_reg.Location = new System.Drawing.Point(195, 34);
            this.txt_reg.Name = "txt_reg";
            this.txt_reg.Size = new System.Drawing.Size(419, 22);
            this.txt_reg.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reg ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_firstName
            // 
            this.txt_firstName.Location = new System.Drawing.Point(195, 83);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(419, 22);
            this.txt_firstName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Name";
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(195, 111);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(419, 22);
            this.txt_lastName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Address";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(195, 162);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(419, 22);
            this.txt_address.TabIndex = 6;
            // 
            // btn_insert
            // 
            this.btn_insert.Enabled = false;
            this.btn_insert.Location = new System.Drawing.Point(243, 205);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 8;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_update
            // 
            this.btn_update.Enabled = false;
            this.btn_update.Location = new System.Drawing.Point(324, 205);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 9;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Enabled = false;
            this.btn_delete.Location = new System.Drawing.Point(405, 205);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Enabled = false;
            this.btn_cancel.Location = new System.Drawing.Point(486, 205);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 11;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(126, 269);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(419, 22);
            this.txt_search.TabIndex = 12;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(551, 269);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 13;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dataGrid_DispRec
            // 
            this.dataGrid_DispRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_DispRec.Location = new System.Drawing.Point(38, 298);
            this.dataGrid_DispRec.Name = "dataGrid_DispRec";
            this.dataGrid_DispRec.RowHeadersWidth = 51;
            this.dataGrid_DispRec.RowTemplate.Height = 24;
            this.dataGrid_DispRec.Size = new System.Drawing.Size(717, 150);
            this.dataGrid_DispRec.TabIndex = 14;
            // 
            // profDetailsBindingSource
            // 
            this.profDetailsBindingSource.DataMember = "ProfDetails";
            this.profDetailsBindingSource.DataSource = this.authenticateDataSet;
            // 
            // authenticateDataSet
            // 
            this.authenticateDataSet.DataSetName = "AuthenticateDataSet";
            this.authenticateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_displayAll
            // 
            this.btn_displayAll.Location = new System.Drawing.Point(348, 454);
            this.btn_displayAll.Name = "btn_displayAll";
            this.btn_displayAll.Size = new System.Drawing.Size(75, 28);
            this.btn_displayAll.TabIndex = 15;
            this.btn_displayAll.Text = "Display all records";
            this.btn_displayAll.UseVisualStyleBackColor = true;
            this.btn_displayAll.Click += new System.EventHandler(this.btn_displayAll_Click);
            // 
            // profDetailsTableAdapter
            // 
            this.profDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 601);
            this.Controls.Add(this.btn_displayAll);
            this.Controls.Add(this.dataGrid_DispRec);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_lastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_firstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_reg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ProfileCRUD";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_DispRec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authenticateDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_reg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dataGrid_DispRec;
        private System.Windows.Forms.Button btn_displayAll;
        private AuthenticateDataSet authenticateDataSet;
        private System.Windows.Forms.BindingSource profDetailsBindingSource;
        private AuthenticateDataSetTableAdapters.ProfDetailsTableAdapter profDetailsTableAdapter;
    }
}

