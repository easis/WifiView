using ListViewGroupCollapse;

namespace WifiView
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mnuInterfaces = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuInterfacesReload = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpInterfaces = new System.Windows.Forms.GroupBox();
            this.lstInterfaces = new System.Windows.Forms.ListView();
            this.colInterfacesName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabOptions = new System.Windows.Forms.TabControl();
            this.tabInformation = new System.Windows.Forms.TabPage();
            this.lstInterfaceInformation = new ListViewGroupCollapse.ListViewExtended();
            this.colInterfaceInformationKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colInterfaceInformationValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabProfiles = new System.Windows.Forms.TabPage();
            this.lstProfiles = new ListViewGroupCollapse.ListViewExtended();
            this.colInterfaceNetworkKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colInterfaceNetworkValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabNetworks = new System.Windows.Forms.TabPage();
            this.tblNetworks = new System.Windows.Forms.DataGridView();
            this.colNetworkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNetworkAlgorithm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNetworkEncryption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNetworkSignal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabStatistics = new System.Windows.Forms.TabPage();
            this.lstStatistics = new ListViewGroupCollapse.ListViewExtended();
            this.colStatisticsKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatisticsValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mnuInterfaces.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpInterfaces.SuspendLayout();
            this.tabOptions.SuspendLayout();
            this.tabInformation.SuspendLayout();
            this.tabProfiles.SuspendLayout();
            this.tabNetworks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblNetworks)).BeginInit();
            this.tabStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuInterfaces
            // 
            this.mnuInterfaces.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuInterfacesReload});
            this.mnuInterfaces.Name = "mnuInterfaces";
            this.mnuInterfaces.Size = new System.Drawing.Size(111, 26);
            // 
            // mnuInterfacesReload
            // 
            this.mnuInterfacesReload.Name = "mnuInterfacesReload";
            this.mnuInterfacesReload.Size = new System.Drawing.Size(110, 22);
            this.mnuInterfacesReload.Text = "Reload";
            this.mnuInterfacesReload.Click += new System.EventHandler(this.MnuInterfacesReload_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grpInterfaces);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabOptions);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // grpInterfaces
            // 
            this.grpInterfaces.Controls.Add(this.lstInterfaces);
            this.grpInterfaces.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpInterfaces.Location = new System.Drawing.Point(0, 0);
            this.grpInterfaces.Name = "grpInterfaces";
            this.grpInterfaces.Size = new System.Drawing.Size(266, 450);
            this.grpInterfaces.TabIndex = 0;
            this.grpInterfaces.TabStop = false;
            this.grpInterfaces.Text = "Interfaces";
            // 
            // lstInterfaces
            // 
            this.lstInterfaces.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colInterfacesName});
            this.lstInterfaces.ContextMenuStrip = this.mnuInterfaces;
            this.lstInterfaces.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstInterfaces.FullRowSelect = true;
            this.lstInterfaces.GridLines = true;
            this.lstInterfaces.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstInterfaces.Location = new System.Drawing.Point(3, 16);
            this.lstInterfaces.MultiSelect = false;
            this.lstInterfaces.Name = "lstInterfaces";
            this.lstInterfaces.Size = new System.Drawing.Size(260, 431);
            this.lstInterfaces.TabIndex = 0;
            this.lstInterfaces.UseCompatibleStateImageBehavior = false;
            this.lstInterfaces.View = System.Windows.Forms.View.Details;
            this.lstInterfaces.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LstInterfaces_ItemSelectionChanged);
            // 
            // colInterfacesName
            // 
            this.colInterfacesName.Text = "Name";
            this.colInterfacesName.Width = 250;
            // 
            // tabOptions
            // 
            this.tabOptions.Controls.Add(this.tabInformation);
            this.tabOptions.Controls.Add(this.tabProfiles);
            this.tabOptions.Controls.Add(this.tabNetworks);
            this.tabOptions.Controls.Add(this.tabStatistics);
            this.tabOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabOptions.Enabled = false;
            this.tabOptions.Location = new System.Drawing.Point(0, 0);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.SelectedIndex = 0;
            this.tabOptions.Size = new System.Drawing.Size(530, 450);
            this.tabOptions.TabIndex = 0;
            // 
            // tabInformation
            // 
            this.tabInformation.Controls.Add(this.lstInterfaceInformation);
            this.tabInformation.Location = new System.Drawing.Point(4, 22);
            this.tabInformation.Name = "tabInformation";
            this.tabInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tabInformation.Size = new System.Drawing.Size(522, 424);
            this.tabInformation.TabIndex = 3;
            this.tabInformation.Text = "Information";
            this.tabInformation.UseVisualStyleBackColor = true;
            // 
            // lstInterfaceInformation
            // 
            this.lstInterfaceInformation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colInterfaceInformationKey,
            this.colInterfaceInformationValue});
            this.lstInterfaceInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstInterfaceInformation.FullRowSelect = true;
            this.lstInterfaceInformation.GridLines = true;
            this.lstInterfaceInformation.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstInterfaceInformation.Location = new System.Drawing.Point(3, 3);
            this.lstInterfaceInformation.MultiSelect = false;
            this.lstInterfaceInformation.Name = "lstInterfaceInformation";
            this.lstInterfaceInformation.Size = new System.Drawing.Size(516, 418);
            this.lstInterfaceInformation.TabIndex = 2;
            this.lstInterfaceInformation.UseCompatibleStateImageBehavior = false;
            this.lstInterfaceInformation.View = System.Windows.Forms.View.Details;
            // 
            // colInterfaceInformationKey
            // 
            this.colInterfaceInformationKey.Text = "Key";
            this.colInterfaceInformationKey.Width = 120;
            // 
            // colInterfaceInformationValue
            // 
            this.colInterfaceInformationValue.Text = "Value";
            this.colInterfaceInformationValue.Width = 392;
            // 
            // tabProfiles
            // 
            this.tabProfiles.Controls.Add(this.lstProfiles);
            this.tabProfiles.Location = new System.Drawing.Point(4, 22);
            this.tabProfiles.Name = "tabProfiles";
            this.tabProfiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfiles.Size = new System.Drawing.Size(522, 424);
            this.tabProfiles.TabIndex = 0;
            this.tabProfiles.Text = "Profiles";
            this.tabProfiles.UseVisualStyleBackColor = true;
            // 
            // lstProfiles
            // 
            this.lstProfiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colInterfaceNetworkKey,
            this.colInterfaceNetworkValue});
            this.lstProfiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstProfiles.FullRowSelect = true;
            this.lstProfiles.GridLines = true;
            this.lstProfiles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstProfiles.Location = new System.Drawing.Point(3, 3);
            this.lstProfiles.Name = "lstProfiles";
            this.lstProfiles.Size = new System.Drawing.Size(516, 418);
            this.lstProfiles.TabIndex = 0;
            this.lstProfiles.UseCompatibleStateImageBehavior = false;
            this.lstProfiles.View = System.Windows.Forms.View.Details;
            // 
            // colInterfaceNetworkKey
            // 
            this.colInterfaceNetworkKey.Text = "Key";
            this.colInterfaceNetworkKey.Width = 120;
            // 
            // colInterfaceNetworkValue
            // 
            this.colInterfaceNetworkValue.Text = "Value";
            this.colInterfaceNetworkValue.Width = 392;
            // 
            // tabNetworks
            // 
            this.tabNetworks.Controls.Add(this.tblNetworks);
            this.tabNetworks.Location = new System.Drawing.Point(4, 22);
            this.tabNetworks.Name = "tabNetworks";
            this.tabNetworks.Padding = new System.Windows.Forms.Padding(3);
            this.tabNetworks.Size = new System.Drawing.Size(522, 424);
            this.tabNetworks.TabIndex = 1;
            this.tabNetworks.Text = "Networks";
            this.tabNetworks.UseVisualStyleBackColor = true;
            // 
            // tblNetworks
            // 
            this.tblNetworks.AllowUserToAddRows = false;
            this.tblNetworks.AllowUserToDeleteRows = false;
            this.tblNetworks.AllowUserToResizeRows = false;
            this.tblNetworks.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.tblNetworks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblNetworks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNetworkName,
            this.colNetworkAlgorithm,
            this.colNetworkEncryption,
            this.colNetworkSignal});
            this.tblNetworks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblNetworks.Location = new System.Drawing.Point(3, 3);
            this.tblNetworks.MultiSelect = false;
            this.tblNetworks.Name = "tblNetworks";
            this.tblNetworks.ReadOnly = true;
            this.tblNetworks.RowHeadersVisible = false;
            this.tblNetworks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblNetworks.Size = new System.Drawing.Size(516, 418);
            this.tblNetworks.TabIndex = 0;
            // 
            // colNetworkName
            // 
            this.colNetworkName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNetworkName.HeaderText = "Name";
            this.colNetworkName.Name = "colNetworkName";
            this.colNetworkName.ReadOnly = true;
            // 
            // colNetworkAlgorithm
            // 
            this.colNetworkAlgorithm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNetworkAlgorithm.HeaderText = "Algorithm";
            this.colNetworkAlgorithm.Name = "colNetworkAlgorithm";
            this.colNetworkAlgorithm.ReadOnly = true;
            // 
            // colNetworkEncryption
            // 
            this.colNetworkEncryption.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNetworkEncryption.HeaderText = "Encryption";
            this.colNetworkEncryption.Name = "colNetworkEncryption";
            this.colNetworkEncryption.ReadOnly = true;
            // 
            // colNetworkSignal
            // 
            this.colNetworkSignal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNetworkSignal.HeaderText = "Signal";
            this.colNetworkSignal.Name = "colNetworkSignal";
            this.colNetworkSignal.ReadOnly = true;
            // 
            // tabStatistics
            // 
            this.tabStatistics.Controls.Add(this.lstStatistics);
            this.tabStatistics.Location = new System.Drawing.Point(4, 22);
            this.tabStatistics.Name = "tabStatistics";
            this.tabStatistics.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatistics.Size = new System.Drawing.Size(522, 424);
            this.tabStatistics.TabIndex = 2;
            this.tabStatistics.Text = "Statistics";
            this.tabStatistics.UseVisualStyleBackColor = true;
            // 
            // lstStatistics
            // 
            this.lstStatistics.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colStatisticsKey,
            this.colStatisticsValue});
            this.lstStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstStatistics.FullRowSelect = true;
            this.lstStatistics.GridLines = true;
            this.lstStatistics.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstStatistics.Location = new System.Drawing.Point(3, 3);
            this.lstStatistics.MultiSelect = false;
            this.lstStatistics.Name = "lstStatistics";
            this.lstStatistics.Size = new System.Drawing.Size(516, 418);
            this.lstStatistics.TabIndex = 0;
            this.lstStatistics.UseCompatibleStateImageBehavior = false;
            this.lstStatistics.View = System.Windows.Forms.View.Details;
            // 
            // colStatisticsKey
            // 
            this.colStatisticsKey.Text = "Key";
            this.colStatisticsKey.Width = 175;
            // 
            // colStatisticsValue
            // 
            this.colStatisticsValue.Text = "Value";
            this.colStatisticsValue.Width = 337;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WifiView";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mnuInterfaces.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.grpInterfaces.ResumeLayout(false);
            this.tabOptions.ResumeLayout(false);
            this.tabInformation.ResumeLayout(false);
            this.tabProfiles.ResumeLayout(false);
            this.tabNetworks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblNetworks)).EndInit();
            this.tabStatistics.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabOptions;
        private System.Windows.Forms.TabPage tabProfiles;
        private System.Windows.Forms.TabPage tabNetworks;
        private System.Windows.Forms.ContextMenuStrip mnuInterfaces;
        private System.Windows.Forms.ToolStripMenuItem mnuInterfacesReload;
        private System.Windows.Forms.TabPage tabStatistics;
        private System.Windows.Forms.TabPage tabInformation;
        private System.Windows.Forms.GroupBox grpInterfaces;
        private System.Windows.Forms.ListView lstInterfaces;
        private System.Windows.Forms.ColumnHeader colInterfacesName;
        private ListViewExtended lstInterfaceInformation;
        private System.Windows.Forms.ColumnHeader colInterfaceInformationKey;
        private System.Windows.Forms.ColumnHeader colInterfaceInformationValue;
        private ListViewExtended lstProfiles;
        private System.Windows.Forms.ColumnHeader colInterfaceNetworkKey;
        private System.Windows.Forms.ColumnHeader colInterfaceNetworkValue;
        private System.Windows.Forms.DataGridView tblNetworks;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNetworkName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNetworkAlgorithm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNetworkEncryption;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNetworkSignal;
        private ListViewExtended lstStatistics;
        private System.Windows.Forms.ColumnHeader colStatisticsKey;
        private System.Windows.Forms.ColumnHeader colStatisticsValue;
    }
}

