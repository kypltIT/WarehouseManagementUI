﻿namespace WarehouseManagementUI.View
{
    partial class frmProfitByEmployee
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvSr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvuserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvuserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgtotalProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSr,
            this.dgvuserId,
            this.dgvuserName,
            this.dvgtotalProfit,
            this.dgvEdit,
            this.dgvDelete});
            this.dataGridView1.Location = new System.Drawing.Point(9, 93);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(582, 262);
            this.dataGridView1.TabIndex = 3;
            // 
            // dgvSr
            // 
            this.dgvSr.HeaderText = "Sr #";
            this.dgvSr.MinimumWidth = 6;
            this.dgvSr.Name = "dgvSr";
            this.dgvSr.ReadOnly = true;
            this.dgvSr.Width = 125;
            // 
            // dgvuserId
            // 
            this.dgvuserId.HeaderText = "User ID";
            this.dgvuserId.MinimumWidth = 6;
            this.dgvuserId.Name = "dgvuserId";
            this.dgvuserId.ReadOnly = true;
            this.dgvuserId.Width = 125;
            // 
            // dgvuserName
            // 
            this.dgvuserName.HeaderText = "User Name";
            this.dgvuserName.MinimumWidth = 6;
            this.dgvuserName.Name = "dgvuserName";
            this.dgvuserName.ReadOnly = true;
            this.dgvuserName.Width = 125;
            // 
            // dvgtotalProfit
            // 
            this.dvgtotalProfit.HeaderText = "Total Profit";
            this.dvgtotalProfit.Name = "dvgtotalProfit";
            this.dvgtotalProfit.ReadOnly = true;
            // 
            // dgvEdit
            // 
            this.dgvEdit.HeaderText = "";
            this.dgvEdit.MinimumWidth = 6;
            this.dgvEdit.Name = "dgvEdit";
            this.dgvEdit.ReadOnly = true;
            this.dgvEdit.Text = "Edit";
            this.dgvEdit.Width = 125;
            // 
            // dgvDelete
            // 
            this.dgvDelete.HeaderText = "";
            this.dgvDelete.MinimumWidth = 6;
            this.dgvDelete.Name = "dgvDelete";
            this.dgvDelete.ReadOnly = true;
            this.dgvDelete.Text = "Delete";
            this.dgvDelete.Width = 125;
            // 
            // frmProfitByEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 361);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmProfitByEmployee";
            this.Text = "frmProfitByEmployee";
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvuserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvuserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgtotalProfit;
        private System.Windows.Forms.DataGridViewButtonColumn dgvEdit;
        private System.Windows.Forms.DataGridViewButtonColumn dgvDelete;
    }
}