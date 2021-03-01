
namespace GroverGamingCodeAssessment_GriffinFlaxman
{
    partial class DirectoryForm
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
            this.Directory = new System.Windows.Forms.DataGridView();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeDirectory_GroverGamingDataSet = new GroverGamingCodeAssessment_GriffinFlaxman.EmployeeDirectory_GroverGamingDataSet();
            this.directoryTableAdapter = new GroverGamingCodeAssessment_GriffinFlaxman.EmployeeDirectory_GroverGamingDataSetTableAdapters.DirectoryTableAdapter();
            this.employeeDirectoryGroverGamingDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taskLog = new System.Windows.Forms.TextBox();
            this.directoryLbl = new System.Windows.Forms.Label();
            this.taskLogLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Directory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDirectory_GroverGamingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDirectoryGroverGamingDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Directory
            // 
            this.Directory.AutoGenerateColumns = false;
            this.Directory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Directory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn,
            this.titleColumn,
            this.ID});
            this.Directory.DataSource = this.directoryBindingSource;
            this.Directory.Location = new System.Drawing.Point(13, 36);
            this.Directory.Name = "Directory";
            this.Directory.Size = new System.Drawing.Size(243, 510);
            this.Directory.TabIndex = 0;
            this.Directory.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DoCheck);
            this.Directory.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.InsertAndUpdateRecord);
            this.Directory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DeleteRecord);
            // 
            // nameColumn
            // 
            this.nameColumn.DataPropertyName = "Name";
            this.nameColumn.Frozen = true;
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // titleColumn
            // 
            this.titleColumn.DataPropertyName = "Title";
            this.titleColumn.Frozen = true;
            this.titleColumn.HeaderText = "Title";
            this.titleColumn.Name = "titleColumn";
            this.titleColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // directoryBindingSource
            // 
            this.directoryBindingSource.DataMember = "Directory";
            this.directoryBindingSource.DataSource = this.employeeDirectory_GroverGamingDataSet;
            // 
            // employeeDirectory_GroverGamingDataSet
            // 
            this.employeeDirectory_GroverGamingDataSet.DataSetName = "EmployeeDirectory_GroverGamingDataSet";
            this.employeeDirectory_GroverGamingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // directoryTableAdapter
            // 
            this.directoryTableAdapter.ClearBeforeFill = true;
            // 
            // employeeDirectoryGroverGamingDataSetBindingSource
            // 
            this.employeeDirectoryGroverGamingDataSetBindingSource.DataSource = this.employeeDirectory_GroverGamingDataSet;
            this.employeeDirectoryGroverGamingDataSetBindingSource.Position = 0;
            // 
            // taskLog
            // 
            this.taskLog.Location = new System.Drawing.Point(262, 36);
            this.taskLog.Multiline = true;
            this.taskLog.Name = "taskLog";
            this.taskLog.ReadOnly = true;
            this.taskLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.taskLog.Size = new System.Drawing.Size(364, 510);
            this.taskLog.TabIndex = 1;
            // 
            // directoryLbl
            // 
            this.directoryLbl.AutoSize = true;
            this.directoryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.directoryLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.directoryLbl.Location = new System.Drawing.Point(12, 13);
            this.directoryLbl.Name = "directoryLbl";
            this.directoryLbl.Size = new System.Drawing.Size(72, 20);
            this.directoryLbl.TabIndex = 2;
            this.directoryLbl.Text = "Directory";
            // 
            // taskLogLbl
            // 
            this.taskLogLbl.AutoSize = true;
            this.taskLogLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.taskLogLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.taskLogLbl.Location = new System.Drawing.Point(258, 13);
            this.taskLogLbl.Name = "taskLogLbl";
            this.taskLogLbl.Size = new System.Drawing.Size(74, 20);
            this.taskLogLbl.TabIndex = 3;
            this.taskLogLbl.Text = "Task Log";
            // 
            // DirectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(636, 556);
            this.Controls.Add(this.taskLogLbl);
            this.Controls.Add(this.directoryLbl);
            this.Controls.Add(this.taskLog);
            this.Controls.Add(this.Directory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DirectoryForm";
            this.ShowIcon = false;
            this.Text = "Employee Directory";
            this.Load += new System.EventHandler(this.DirectoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Directory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDirectory_GroverGamingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDirectoryGroverGamingDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private EmployeeDirectory_GroverGamingDataSet employeeDirectory_GroverGamingDataSet;
        private System.Windows.Forms.BindingSource directoryBindingSource;
        private EmployeeDirectory_GroverGamingDataSetTableAdapters.DirectoryTableAdapter directoryTableAdapter;
        private System.Windows.Forms.BindingSource employeeDirectoryGroverGamingDataSetBindingSource;
        private System.Windows.Forms.TextBox taskLog;
        private System.Windows.Forms.DataGridView Directory;
        private System.Windows.Forms.Label directoryLbl;
        private System.Windows.Forms.Label taskLogLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}

