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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpInterfaceInformation = new System.Windows.Forms.GroupBox();
            this.lstInterfaceInformation = new System.Windows.Forms.ListView();
            this.grpInterfaces = new System.Windows.Forms.GroupBox();
            this.lstInterfaces = new System.Windows.Forms.ListView();
            this.colInterfacesName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabOptions = new System.Windows.Forms.TabControl();
            this.tabProfiles = new System.Windows.Forms.TabPage();
            this.tabNetworks = new System.Windows.Forms.TabPage();
            this.mnuInterfaces = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuInterfacesReload = new System.Windows.Forms.ToolStripMenuItem();
            this.colInterfaceInformationKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colInterfaceInformationValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpInterfaceInformation.SuspendLayout();
            this.grpInterfaces.SuspendLayout();
            this.tabOptions.SuspendLayout();
            this.mnuInterfaces.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grpInterfaceInformation);
            this.splitContainer1.Panel1.Controls.Add(this.grpInterfaces);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabOptions);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // grpInterfaceInformation
            // 
            this.grpInterfaceInformation.Controls.Add(this.lstInterfaceInformation);
            this.grpInterfaceInformation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpInterfaceInformation.Location = new System.Drawing.Point(0, 265);
            this.grpInterfaceInformation.Name = "grpInterfaceInformation";
            this.grpInterfaceInformation.Size = new System.Drawing.Size(266, 185);
            this.grpInterfaceInformation.TabIndex = 1;
            this.grpInterfaceInformation.TabStop = false;
            this.grpInterfaceInformation.Text = "Information";
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
            this.lstInterfaceInformation.Location = new System.Drawing.Point(3, 16);
            this.lstInterfaceInformation.MultiSelect = false;
            this.lstInterfaceInformation.Name = "lstInterfaceInformation";
            this.lstInterfaceInformation.Size = new System.Drawing.Size(260, 166);
            this.lstInterfaceInformation.TabIndex = 0;
            this.lstInterfaceInformation.UseCompatibleStateImageBehavior = false;
            this.lstInterfaceInformation.View = System.Windows.Forms.View.Details;
            this.lstInterfaceInformation.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LstInterfaceInformation_ItemSelectionChanged);
            // 
            // grpInterfaces
            // 
            this.grpInterfaces.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInterfaces.Controls.Add(this.lstInterfaces);
            this.grpInterfaces.Location = new System.Drawing.Point(3, 3);
            this.grpInterfaces.Name = "grpInterfaces";
            this.grpInterfaces.Size = new System.Drawing.Size(260, 256);
            this.grpInterfaces.TabIndex = 0;
            this.grpInterfaces.TabStop = false;
            this.grpInterfaces.Text = "Interfaces";
            // 
            // lstInterfaces
            // 
            this.lstInterfaces.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colInterfacesName});
            this.lstInterfaces.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstInterfaces.FullRowSelect = true;
            this.lstInterfaces.GridLines = true;
            this.lstInterfaces.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstInterfaces.Location = new System.Drawing.Point(3, 16);
            this.lstInterfaces.MultiSelect = false;
            this.lstInterfaces.Name = "lstInterfaces";
            this.lstInterfaces.Size = new System.Drawing.Size(254, 237);
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
            this.tabOptions.Controls.Add(this.tabProfiles);
            this.tabOptions.Controls.Add(this.tabNetworks);
            this.tabOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabOptions.Location = new System.Drawing.Point(0, 0);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.SelectedIndex = 0;
            this.tabOptions.Size = new System.Drawing.Size(530, 450);
            this.tabOptions.TabIndex = 0;
            // 
            // tabProfiles
            // 
            this.tabProfiles.Location = new System.Drawing.Point(4, 22);
            this.tabProfiles.Name = "tabProfiles";
            this.tabProfiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfiles.Size = new System.Drawing.Size(522, 424);
            this.tabProfiles.TabIndex = 0;
            this.tabProfiles.Text = "Profiles";
            this.tabProfiles.UseVisualStyleBackColor = true;
            // 
            // tabNetworks
            // 
            this.tabNetworks.Location = new System.Drawing.Point(4, 22);
            this.tabNetworks.Name = "tabNetworks";
            this.tabNetworks.Padding = new System.Windows.Forms.Padding(3);
            this.tabNetworks.Size = new System.Drawing.Size(522, 424);
            this.tabNetworks.TabIndex = 1;
            this.tabNetworks.Text = "Networks";
            this.tabNetworks.UseVisualStyleBackColor = true;
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
            // colInterfaceInformationKey
            // 
            this.colInterfaceInformationKey.Text = "Key";
            this.colInterfaceInformationKey.Width = 100;
            // 
            // colInterfaceInformationValue
            // 
            this.colInterfaceInformationValue.Text = "Value";
            this.colInterfaceInformationValue.Width = 156;
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
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.grpInterfaceInformation.ResumeLayout(false);
            this.grpInterfaces.ResumeLayout(false);
            this.tabOptions.ResumeLayout(false);
            this.mnuInterfaces.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabOptions;
        private System.Windows.Forms.TabPage tabProfiles;
        private System.Windows.Forms.TabPage tabNetworks;
        private System.Windows.Forms.GroupBox grpInterfaceInformation;
        private System.Windows.Forms.GroupBox grpInterfaces;
        private System.Windows.Forms.ListView lstInterfaceInformation;
        private System.Windows.Forms.ContextMenuStrip mnuInterfaces;
        private System.Windows.Forms.ToolStripMenuItem mnuInterfacesReload;
        private System.Windows.Forms.ListView lstInterfaces;
        private System.Windows.Forms.ColumnHeader colInterfacesName;
        private System.Windows.Forms.ColumnHeader colInterfaceInformationKey;
        private System.Windows.Forms.ColumnHeader colInterfaceInformationValue;
    }
}

