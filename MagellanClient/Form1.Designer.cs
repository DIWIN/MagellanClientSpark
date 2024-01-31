namespace MagellanClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox_Connect = new System.Windows.Forms.GroupBox();
            this.button_PlateIn = new System.Windows.Forms.Button();
            this.button_PlateOut = new System.Windows.Forms.Button();
            this.button_GetLastError = new System.Windows.Forms.Button();
            this.button_ResetLastError = new System.Windows.Forms.Button();
            this.button_Disconnect = new System.Windows.Forms.Button();
            this.button_Connect = new System.Windows.Forms.Button();
            this.groupBox_Output = new System.Windows.Forms.GroupBox();
            this.richTextBox_Output = new System.Windows.Forms.RichTextBox();
            this.groupBox_Methods = new System.Windows.Forms.GroupBox();
            this.button_AvailableMethods = new System.Windows.Forms.Button();
            this.groupBox_Workspace = new System.Windows.Forms.GroupBox();
            this.button_SaveWorkspace = new System.Windows.Forms.Button();
            this.button_DataExport = new System.Windows.Forms.Button();
            this.button_StartRun = new System.Windows.Forms.Button();
            this.textBox_Filename = new System.Windows.Forms.TextBox();
            this.button_SetFileName = new System.Windows.Forms.Button();
            this.comboBox_Methods = new System.Windows.Forms.ComboBox();
            this.button_InsertMethod = new System.Windows.Forms.Button();
            this.button_SetEmpty = new System.Windows.Forms.Button();
            this.button_ModifyLyout = new System.Windows.Forms.Button();
            this.groupBox_Data = new System.Windows.Forms.GroupBox();
            this.button_DataAsTable = new System.Windows.Forms.Button();
            this.comboBox_DataNames = new System.Windows.Forms.ComboBox();
            this.button_DataNames = new System.Windows.Forms.Button();
            this.groupBox_Layout = new System.Windows.Forms.GroupBox();
            this.button_Samples = new System.Windows.Forms.Button();
            this.groupBox_Magellan = new System.Windows.Forms.GroupBox();
            this.textBox_DeviceName = new System.Windows.Forms.TextBox();
            this.button_Name = new System.Windows.Forms.Button();
            this.button_Create = new System.Windows.Forms.Button();
            this.saveFileDialogStandards = new System.Windows.Forms.SaveFileDialog();
            this.groupBox_Connect.SuspendLayout();
            this.groupBox_Output.SuspendLayout();
            this.groupBox_Methods.SuspendLayout();
            this.groupBox_Workspace.SuspendLayout();
            this.groupBox_Data.SuspendLayout();
            this.groupBox_Layout.SuspendLayout();
            this.groupBox_Magellan.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Connect
            // 
            this.groupBox_Connect.Controls.Add(this.button_PlateIn);
            this.groupBox_Connect.Controls.Add(this.button_PlateOut);
            this.groupBox_Connect.Controls.Add(this.button_GetLastError);
            this.groupBox_Connect.Controls.Add(this.button_ResetLastError);
            this.groupBox_Connect.Controls.Add(this.button_Disconnect);
            this.groupBox_Connect.Controls.Add(this.button_Connect);
            this.groupBox_Connect.Location = new System.Drawing.Point(13, 117);
            this.groupBox_Connect.Name = "groupBox_Connect";
            this.groupBox_Connect.Size = new System.Drawing.Size(531, 90);
            this.groupBox_Connect.TabIndex = 0;
            this.groupBox_Connect.TabStop = false;
            this.groupBox_Connect.Text = "Instrument Functions";
            // 
            // button_PlateIn
            // 
            this.button_PlateIn.Location = new System.Drawing.Point(244, 49);
            this.button_PlateIn.Name = "button_PlateIn";
            this.button_PlateIn.Size = new System.Drawing.Size(114, 23);
            this.button_PlateIn.TabIndex = 6;
            this.button_PlateIn.Text = "Plate in";
            this.button_PlateIn.UseVisualStyleBackColor = true;
            this.button_PlateIn.Click += new System.EventHandler(this.button_PlateIn_Click);
            // 
            // button_PlateOut
            // 
            this.button_PlateOut.Location = new System.Drawing.Point(244, 19);
            this.button_PlateOut.Name = "button_PlateOut";
            this.button_PlateOut.Size = new System.Drawing.Size(114, 23);
            this.button_PlateOut.TabIndex = 5;
            this.button_PlateOut.Text = "Plate out";
            this.button_PlateOut.UseVisualStyleBackColor = true;
            this.button_PlateOut.Click += new System.EventHandler(this.button_PlateOut_Click);
            // 
            // button_GetLastError
            // 
            this.button_GetLastError.Location = new System.Drawing.Point(126, 50);
            this.button_GetLastError.Name = "button_GetLastError";
            this.button_GetLastError.Size = new System.Drawing.Size(111, 23);
            this.button_GetLastError.TabIndex = 4;
            this.button_GetLastError.Text = "Get Last Error";
            this.button_GetLastError.UseVisualStyleBackColor = true;
            this.button_GetLastError.Click += new System.EventHandler(this.button_GetLastError_Click);
            // 
            // button_ResetLastError
            // 
            this.button_ResetLastError.Location = new System.Drawing.Point(125, 20);
            this.button_ResetLastError.Name = "button_ResetLastError";
            this.button_ResetLastError.Size = new System.Drawing.Size(112, 23);
            this.button_ResetLastError.TabIndex = 3;
            this.button_ResetLastError.Text = "ResetLastError";
            this.button_ResetLastError.UseVisualStyleBackColor = true;
            this.button_ResetLastError.Click += new System.EventHandler(this.button_ResetLastError_Click);
            // 
            // button_Disconnect
            // 
            this.button_Disconnect.Location = new System.Drawing.Point(7, 50);
            this.button_Disconnect.Name = "button_Disconnect";
            this.button_Disconnect.Size = new System.Drawing.Size(112, 23);
            this.button_Disconnect.TabIndex = 1;
            this.button_Disconnect.Text = "Disconnect";
            this.button_Disconnect.UseVisualStyleBackColor = true;
            this.button_Disconnect.Click += new System.EventHandler(this.button_Disconnect_Click);
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(7, 20);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(112, 23);
            this.button_Connect.TabIndex = 0;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // groupBox_Output
            // 
            this.groupBox_Output.Controls.Add(this.richTextBox_Output);
            this.groupBox_Output.Location = new System.Drawing.Point(550, 13);
            this.groupBox_Output.Name = "groupBox_Output";
            this.groupBox_Output.Size = new System.Drawing.Size(658, 708);
            this.groupBox_Output.TabIndex = 1;
            this.groupBox_Output.TabStop = false;
            this.groupBox_Output.Text = "Output";
            // 
            // richTextBox_Output
            // 
            this.richTextBox_Output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_Output.Location = new System.Drawing.Point(3, 16);
            this.richTextBox_Output.Name = "richTextBox_Output";
            this.richTextBox_Output.Size = new System.Drawing.Size(652, 689);
            this.richTextBox_Output.TabIndex = 0;
            this.richTextBox_Output.Text = "";
            // 
            // groupBox_Methods
            // 
            this.groupBox_Methods.Controls.Add(this.button_AvailableMethods);
            this.groupBox_Methods.Location = new System.Drawing.Point(13, 214);
            this.groupBox_Methods.Name = "groupBox_Methods";
            this.groupBox_Methods.Size = new System.Drawing.Size(531, 59);
            this.groupBox_Methods.TabIndex = 2;
            this.groupBox_Methods.TabStop = false;
            this.groupBox_Methods.Text = "Methods";
            // 
            // button_AvailableMethods
            // 
            this.button_AvailableMethods.Location = new System.Drawing.Point(7, 20);
            this.button_AvailableMethods.Name = "button_AvailableMethods";
            this.button_AvailableMethods.Size = new System.Drawing.Size(112, 23);
            this.button_AvailableMethods.TabIndex = 0;
            this.button_AvailableMethods.Text = "Available Methods";
            this.button_AvailableMethods.UseVisualStyleBackColor = true;
            this.button_AvailableMethods.Click += new System.EventHandler(this.button_AvailableMethods_Click);
            // 
            // groupBox_Workspace
            // 
            this.groupBox_Workspace.Controls.Add(this.button_SaveWorkspace);
            this.groupBox_Workspace.Controls.Add(this.button_DataExport);
            this.groupBox_Workspace.Controls.Add(this.button_StartRun);
            this.groupBox_Workspace.Controls.Add(this.textBox_Filename);
            this.groupBox_Workspace.Controls.Add(this.button_SetFileName);
            this.groupBox_Workspace.Controls.Add(this.comboBox_Methods);
            this.groupBox_Workspace.Controls.Add(this.button_InsertMethod);
            this.groupBox_Workspace.Controls.Add(this.button_SetEmpty);
            this.groupBox_Workspace.Location = new System.Drawing.Point(13, 282);
            this.groupBox_Workspace.Name = "groupBox_Workspace";
            this.groupBox_Workspace.Size = new System.Drawing.Size(531, 188);
            this.groupBox_Workspace.TabIndex = 3;
            this.groupBox_Workspace.TabStop = false;
            this.groupBox_Workspace.Text = "Workspace";
            // 
            // button_SaveWorkspace
            // 
            this.button_SaveWorkspace.Location = new System.Drawing.Point(125, 140);
            this.button_SaveWorkspace.Name = "button_SaveWorkspace";
            this.button_SaveWorkspace.Size = new System.Drawing.Size(112, 23);
            this.button_SaveWorkspace.TabIndex = 7;
            this.button_SaveWorkspace.Text = "Save Workspace";
            this.button_SaveWorkspace.UseVisualStyleBackColor = true;
            this.button_SaveWorkspace.Click += new System.EventHandler(this.button_SaveWorkspace_Click);
            // 
            // button_DataExport
            // 
            this.button_DataExport.Location = new System.Drawing.Point(7, 140);
            this.button_DataExport.Name = "button_DataExport";
            this.button_DataExport.Size = new System.Drawing.Size(112, 23);
            this.button_DataExport.TabIndex = 6;
            this.button_DataExport.Text = "Data Export";
            this.button_DataExport.UseVisualStyleBackColor = true;
            this.button_DataExport.Click += new System.EventHandler(this.button_DataExport_Click);
            // 
            // button_StartRun
            // 
            this.button_StartRun.Location = new System.Drawing.Point(7, 110);
            this.button_StartRun.Name = "button_StartRun";
            this.button_StartRun.Size = new System.Drawing.Size(112, 23);
            this.button_StartRun.TabIndex = 5;
            this.button_StartRun.Text = "Start Run";
            this.button_StartRun.UseVisualStyleBackColor = true;
            this.button_StartRun.Click += new System.EventHandler(this.button_StartRun_Click);
            // 
            // textBox_Filename
            // 
            this.textBox_Filename.Location = new System.Drawing.Point(126, 82);
            this.textBox_Filename.Name = "textBox_Filename";
            this.textBox_Filename.Size = new System.Drawing.Size(399, 20);
            this.textBox_Filename.TabIndex = 4;
            // 
            // button_SetFileName
            // 
            this.button_SetFileName.Location = new System.Drawing.Point(7, 80);
            this.button_SetFileName.Name = "button_SetFileName";
            this.button_SetFileName.Size = new System.Drawing.Size(112, 23);
            this.button_SetFileName.TabIndex = 3;
            this.button_SetFileName.Text = "Set Filename";
            this.button_SetFileName.UseVisualStyleBackColor = true;
            this.button_SetFileName.Click += new System.EventHandler(this.button_SetFileName_Click);
            // 
            // comboBox_Methods
            // 
            this.comboBox_Methods.FormattingEnabled = true;
            this.comboBox_Methods.Location = new System.Drawing.Point(125, 52);
            this.comboBox_Methods.Name = "comboBox_Methods";
            this.comboBox_Methods.Size = new System.Drawing.Size(400, 21);
            this.comboBox_Methods.TabIndex = 2;
            // 
            // button_InsertMethod
            // 
            this.button_InsertMethod.Location = new System.Drawing.Point(7, 50);
            this.button_InsertMethod.Name = "button_InsertMethod";
            this.button_InsertMethod.Size = new System.Drawing.Size(112, 23);
            this.button_InsertMethod.TabIndex = 1;
            this.button_InsertMethod.Text = "Insert Method";
            this.button_InsertMethod.UseVisualStyleBackColor = true;
            this.button_InsertMethod.Click += new System.EventHandler(this.button_InsertMethod_Click);
            // 
            // button_SetEmpty
            // 
            this.button_SetEmpty.Location = new System.Drawing.Point(7, 20);
            this.button_SetEmpty.Name = "button_SetEmpty";
            this.button_SetEmpty.Size = new System.Drawing.Size(112, 23);
            this.button_SetEmpty.TabIndex = 0;
            this.button_SetEmpty.Text = "Set Empty";
            this.button_SetEmpty.UseVisualStyleBackColor = true;
            this.button_SetEmpty.Click += new System.EventHandler(this.button_SetEmpty_Click);
            // 
            // button_ModifyLyout
            // 
            this.button_ModifyLyout.Location = new System.Drawing.Point(7, 19);
            this.button_ModifyLyout.Name = "button_ModifyLyout";
            this.button_ModifyLyout.Size = new System.Drawing.Size(112, 23);
            this.button_ModifyLyout.TabIndex = 8;
            this.button_ModifyLyout.Text = "Modify Layout";
            this.button_ModifyLyout.UseVisualStyleBackColor = true;
            this.button_ModifyLyout.Click += new System.EventHandler(this.button_ModifyLayout_Click);
            // 
            // groupBox_Data
            // 
            this.groupBox_Data.Controls.Add(this.button_DataAsTable);
            this.groupBox_Data.Controls.Add(this.comboBox_DataNames);
            this.groupBox_Data.Controls.Add(this.button_DataNames);
            this.groupBox_Data.Location = new System.Drawing.Point(13, 542);
            this.groupBox_Data.Name = "groupBox_Data";
            this.groupBox_Data.Size = new System.Drawing.Size(531, 84);
            this.groupBox_Data.TabIndex = 4;
            this.groupBox_Data.TabStop = false;
            this.groupBox_Data.Text = "Data";
            // 
            // button_DataAsTable
            // 
            this.button_DataAsTable.Location = new System.Drawing.Point(7, 50);
            this.button_DataAsTable.Name = "button_DataAsTable";
            this.button_DataAsTable.Size = new System.Drawing.Size(112, 23);
            this.button_DataAsTable.TabIndex = 2;
            this.button_DataAsTable.Text = "DataAsTable";
            this.button_DataAsTable.UseVisualStyleBackColor = true;
            this.button_DataAsTable.Click += new System.EventHandler(this.button_DataAsTable_Click);
            // 
            // comboBox_DataNames
            // 
            this.comboBox_DataNames.FormattingEnabled = true;
            this.comboBox_DataNames.Location = new System.Drawing.Point(126, 21);
            this.comboBox_DataNames.Name = "comboBox_DataNames";
            this.comboBox_DataNames.Size = new System.Drawing.Size(399, 21);
            this.comboBox_DataNames.TabIndex = 1;
            // 
            // button_DataNames
            // 
            this.button_DataNames.Location = new System.Drawing.Point(7, 20);
            this.button_DataNames.Name = "button_DataNames";
            this.button_DataNames.Size = new System.Drawing.Size(112, 23);
            this.button_DataNames.TabIndex = 0;
            this.button_DataNames.Text = "Data Names";
            this.button_DataNames.UseVisualStyleBackColor = true;
            this.button_DataNames.Click += new System.EventHandler(this.button_DataNames_Click);
            // 
            // groupBox_Layout
            // 
            this.groupBox_Layout.Controls.Add(this.button_Samples);
            this.groupBox_Layout.Controls.Add(this.button_ModifyLyout);
            this.groupBox_Layout.Location = new System.Drawing.Point(13, 478);
            this.groupBox_Layout.Name = "groupBox_Layout";
            this.groupBox_Layout.Size = new System.Drawing.Size(531, 56);
            this.groupBox_Layout.TabIndex = 5;
            this.groupBox_Layout.TabStop = false;
            this.groupBox_Layout.Text = "Layout and Samples";
            // 
            // button_Samples
            // 
            this.button_Samples.Location = new System.Drawing.Point(126, 19);
            this.button_Samples.Name = "button_Samples";
            this.button_Samples.Size = new System.Drawing.Size(112, 23);
            this.button_Samples.TabIndex = 9;
            this.button_Samples.Text = "Insert Sample IDs";
            this.button_Samples.UseVisualStyleBackColor = true;
            this.button_Samples.Click += new System.EventHandler(this.button_Samples_Click);
            // 
            // groupBox_Magellan
            // 
            this.groupBox_Magellan.Controls.Add(this.textBox_DeviceName);
            this.groupBox_Magellan.Controls.Add(this.button_Name);
            this.groupBox_Magellan.Controls.Add(this.button_Create);
            this.groupBox_Magellan.Location = new System.Drawing.Point(13, 13);
            this.groupBox_Magellan.Name = "groupBox_Magellan";
            this.groupBox_Magellan.Size = new System.Drawing.Size(531, 100);
            this.groupBox_Magellan.TabIndex = 6;
            this.groupBox_Magellan.TabStop = false;
            this.groupBox_Magellan.Text = "Magellan";
            // 
            // textBox_DeviceName
            // 
            this.textBox_DeviceName.Location = new System.Drawing.Point(126, 52);
            this.textBox_DeviceName.Name = "textBox_DeviceName";
            this.textBox_DeviceName.Size = new System.Drawing.Size(399, 20);
            this.textBox_DeviceName.TabIndex = 2;
            // 
            // button_Name
            // 
            this.button_Name.Location = new System.Drawing.Point(7, 50);
            this.button_Name.Name = "button_Name";
            this.button_Name.Size = new System.Drawing.Size(112, 23);
            this.button_Name.TabIndex = 1;
            this.button_Name.Text = "Set Device Name";
            this.button_Name.UseVisualStyleBackColor = true;
            this.button_Name.Click += new System.EventHandler(this.button_Name_Click);
            // 
            // button_Create
            // 
            this.button_Create.Location = new System.Drawing.Point(7, 20);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(112, 23);
            this.button_Create.TabIndex = 0;
            this.button_Create.Text = "Create Magellan";
            this.button_Create.UseVisualStyleBackColor = true;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // saveFileDialogStandards
            // 
            this.saveFileDialogStandards.DefaultExt = "std";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 659);
            this.Controls.Add(this.groupBox_Magellan);
            this.Controls.Add(this.groupBox_Layout);
            this.Controls.Add(this.groupBox_Data);
            this.Controls.Add(this.groupBox_Workspace);
            this.Controls.Add(this.groupBox_Methods);
            this.Controls.Add(this.groupBox_Output);
            this.Controls.Add(this.groupBox_Connect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Magellan Client App";
            this.groupBox_Connect.ResumeLayout(false);
            this.groupBox_Output.ResumeLayout(false);
            this.groupBox_Methods.ResumeLayout(false);
            this.groupBox_Workspace.ResumeLayout(false);
            this.groupBox_Workspace.PerformLayout();
            this.groupBox_Data.ResumeLayout(false);
            this.groupBox_Layout.ResumeLayout(false);
            this.groupBox_Magellan.ResumeLayout(false);
            this.groupBox_Magellan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Connect;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.Button button_Disconnect;
        private System.Windows.Forms.GroupBox groupBox_Output;
        private System.Windows.Forms.RichTextBox richTextBox_Output;
        private System.Windows.Forms.GroupBox groupBox_Methods;
        private System.Windows.Forms.Button button_AvailableMethods;
        private System.Windows.Forms.GroupBox groupBox_Workspace;
        private System.Windows.Forms.Button button_SetEmpty;
        private System.Windows.Forms.ComboBox comboBox_Methods;
        private System.Windows.Forms.Button button_InsertMethod;
        private System.Windows.Forms.Button button_ResetLastError;
        private System.Windows.Forms.Button button_GetLastError;
        private System.Windows.Forms.Button button_PlateOut;
        private System.Windows.Forms.Button button_PlateIn;
        private System.Windows.Forms.TextBox textBox_Filename;
        private System.Windows.Forms.Button button_SetFileName;
        private System.Windows.Forms.Button button_StartRun;
        private System.Windows.Forms.Button button_DataExport;
        private System.Windows.Forms.Button button_SaveWorkspace;
        private System.Windows.Forms.GroupBox groupBox_Data;
        private System.Windows.Forms.Button button_DataNames;
        private System.Windows.Forms.ComboBox comboBox_DataNames;
        private System.Windows.Forms.Button button_DataAsTable;
        private System.Windows.Forms.Button button_ModifyLyout;
        private System.Windows.Forms.GroupBox groupBox_Layout;
        private System.Windows.Forms.Button button_Samples;
        private System.Windows.Forms.GroupBox groupBox_Magellan;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.TextBox textBox_DeviceName;
        private System.Windows.Forms.Button button_Name;
        private System.Windows.Forms.SaveFileDialog saveFileDialogStandards;
    }
}

