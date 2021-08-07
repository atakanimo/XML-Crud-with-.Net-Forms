
namespace AdvancoTask
{
    partial class MainForm
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
            this.dgwPersonal = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxHireDate = new System.Windows.Forms.TextBox();
            this.lblHireDate = new System.Windows.Forms.Label();
            this.tbxPersonalId = new System.Windows.Forms.TextBox();
            this.lblPersonalId = new System.Windows.Forms.Label();
            this.tbxSurname = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxHireDateUpdate = new System.Windows.Forms.TextBox();
            this.tbxSurnameUpdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxNameUpdate = new System.Windows.Forms.TextBox();
            this.tbxPersonalIdUpdate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnXmlImport = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnXmlExp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersonal)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwPersonal
            // 
            this.dgwPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPersonal.Location = new System.Drawing.Point(41, 345);
            this.dgwPersonal.Name = "dgwPersonal";
            this.dgwPersonal.RowHeadersWidth = 51;
            this.dgwPersonal.RowTemplate.Height = 24;
            this.dgwPersonal.Size = new System.Drawing.Size(1020, 380);
            this.dgwPersonal.TabIndex = 0;
            this.dgwPersonal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwPersonal_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxHireDate);
            this.groupBox1.Controls.Add(this.lblHireDate);
            this.groupBox1.Controls.Add(this.tbxPersonalId);
            this.groupBox1.Controls.Add(this.lblPersonalId);
            this.groupBox1.Controls.Add(this.tbxSurname);
            this.groupBox1.Controls.Add(this.lblStock);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.tbxName);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(41, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(512, 226);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Personal";
            // 
            // tbxHireDate
            // 
            this.tbxHireDate.Location = new System.Drawing.Point(123, 183);
            this.tbxHireDate.Margin = new System.Windows.Forms.Padding(4);
            this.tbxHireDate.Name = "tbxHireDate";
            this.tbxHireDate.Size = new System.Drawing.Size(132, 22);
            this.tbxHireDate.TabIndex = 9;
            // 
            // lblHireDate
            // 
            this.lblHireDate.AutoSize = true;
            this.lblHireDate.Location = new System.Drawing.Point(39, 183);
            this.lblHireDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHireDate.Name = "lblHireDate";
            this.lblHireDate.Size = new System.Drawing.Size(76, 17);
            this.lblHireDate.TabIndex = 8;
            this.lblHireDate.Text = "Hire Date :";
            // 
            // tbxPersonalId
            // 
            this.tbxPersonalId.Location = new System.Drawing.Point(123, 138);
            this.tbxPersonalId.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPersonalId.Name = "tbxPersonalId";
            this.tbxPersonalId.Size = new System.Drawing.Size(132, 22);
            this.tbxPersonalId.TabIndex = 7;
            // 
            // lblPersonalId
            // 
            this.lblPersonalId.AutoSize = true;
            this.lblPersonalId.Location = new System.Drawing.Point(28, 138);
            this.lblPersonalId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPersonalId.Name = "lblPersonalId";
            this.lblPersonalId.Size = new System.Drawing.Size(87, 17);
            this.lblPersonalId.TabIndex = 6;
            this.lblPersonalId.Text = "Personal Id :";
            // 
            // tbxSurname
            // 
            this.tbxSurname.Location = new System.Drawing.Point(123, 92);
            this.tbxSurname.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.Size = new System.Drawing.Size(132, 22);
            this.tbxSurname.TabIndex = 5;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(42, 93);
            this.lblStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(73, 17);
            this.lblStock.TabIndex = 4;
            this.lblStock.Text = "Surname :";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(354, 177);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 28);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(123, 43);
            this.tbxName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(132, 22);
            this.tbxName.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(62, 45);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxHireDateUpdate);
            this.groupBox2.Controls.Add(this.tbxSurnameUpdate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.tbxNameUpdate);
            this.groupBox2.Controls.Add(this.tbxPersonalIdUpdate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(573, 46);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(488, 226);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Personal";
            // 
            // tbxHireDateUpdate
            // 
            this.tbxHireDateUpdate.Location = new System.Drawing.Point(123, 180);
            this.tbxHireDateUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.tbxHireDateUpdate.Name = "tbxHireDateUpdate";
            this.tbxHireDateUpdate.Size = new System.Drawing.Size(132, 22);
            this.tbxHireDateUpdate.TabIndex = 13;
            // 
            // tbxSurnameUpdate
            // 
            this.tbxSurnameUpdate.Location = new System.Drawing.Point(123, 89);
            this.tbxSurnameUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSurnameUpdate.Name = "tbxSurnameUpdate";
            this.tbxSurnameUpdate.Size = new System.Drawing.Size(132, 22);
            this.tbxSurnameUpdate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Surname :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Hire Date :";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(327, 172);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(107, 28);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxNameUpdate
            // 
            this.tbxNameUpdate.Location = new System.Drawing.Point(123, 43);
            this.tbxNameUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNameUpdate.Name = "tbxNameUpdate";
            this.tbxNameUpdate.Size = new System.Drawing.Size(132, 22);
            this.tbxNameUpdate.TabIndex = 4;
            // 
            // tbxPersonalIdUpdate
            // 
            this.tbxPersonalIdUpdate.Location = new System.Drawing.Point(123, 135);
            this.tbxPersonalIdUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPersonalIdUpdate.Name = "tbxPersonalIdUpdate";
            this.tbxPersonalIdUpdate.Size = new System.Drawing.Size(132, 22);
            this.tbxPersonalIdUpdate.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 138);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Personal Id :";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(38, 745);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(107, 28);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove ";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnXmlImport
            // 
            this.btnXmlImport.Location = new System.Drawing.Point(954, 745);
            this.btnXmlImport.Margin = new System.Windows.Forms.Padding(4);
            this.btnXmlImport.Name = "btnXmlImport";
            this.btnXmlImport.Size = new System.Drawing.Size(107, 28);
            this.btnXmlImport.TabIndex = 9;
            this.btnXmlImport.Text = "XML İmport";
            this.btnXmlImport.UseVisualStyleBackColor = true;
            this.btnXmlImport.Click += new System.EventHandler(this.btnXmlImport_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(164, 301);
            this.tbxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(132, 22);
            this.tbxSearch.TabIndex = 11;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(35, 301);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(121, 17);
            this.lblSearch.TabIndex = 10;
            this.lblSearch.Text = "Search by Name :";
            // 
            // btnXmlExp
            // 
            this.btnXmlExp.Location = new System.Drawing.Point(816, 745);
            this.btnXmlExp.Margin = new System.Windows.Forms.Padding(4);
            this.btnXmlExp.Name = "btnXmlExp";
            this.btnXmlExp.Size = new System.Drawing.Size(107, 28);
            this.btnXmlExp.TabIndex = 12;
            this.btnXmlExp.Text = "XML Export";
            this.btnXmlExp.UseVisualStyleBackColor = true;
            this.btnXmlExp.Click += new System.EventHandler(this.btnXmlExp_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 807);
            this.Controls.Add(this.btnXmlExp);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnXmlImport);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwPersonal);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersonal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwPersonal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxHireDate;
        private System.Windows.Forms.Label lblHireDate;
        private System.Windows.Forms.TextBox tbxPersonalId;
        private System.Windows.Forms.Label lblPersonalId;
        private System.Windows.Forms.TextBox tbxSurname;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbxHireDateUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxPersonalIdUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxSurnameUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxNameUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnXmlImport;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnXmlExp;
    }
}

