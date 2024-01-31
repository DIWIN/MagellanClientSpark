using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace MagellanClient
{
    public partial class Form1 : Form
    {
        #region Mebers

        Magellan2.IOleMagellan _iMagellan;
        RdrOleDll4.IOleReaderServer _iReaderServer;
        RdrOleDll4.IOleInstrument _iInstrument;
        Magellan2.IOleWorkspace _iWorkspace;
        string _DeviceName = "ConnectDotNet"; //"ConnectDotNet:NAME=SPARK10M_(LUM_ENH):Instrument1";

        #endregion

        public Form1()
        {
            InitializeComponent();
            textBox_DeviceName.Text = _DeviceName;
        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            _iMagellan = new Magellan2.Application();
            Debug.Assert(_iMagellan != null);
            richTextBox_Output.AppendText("iMagellan: " + _iMagellan + "\n");
            richTextBox_Output.AppendText("iMagellan Version: " + _iMagellan.ServerVersion + "\n");
            richTextBox_Output.AppendText("iMagellan Language: " + _iMagellan.Language + "\n");

            bool loginOk = _iMagellan.Login("", "", 1);
            richTextBox_Output.AppendText("iMagellan Login successful? " + (loginOk ? "Yes" : "No (or user amdinistration not enabled)") + "\n");

            _iReaderServer = _iMagellan.CreateRdrOleObject();
            Debug.Assert(_iReaderServer != null);
            richTextBox_Output.AppendText("iReaderServer: " + _iReaderServer + "\n");
            richTextBox_Output.AppendText("iReaderServer: ServerVersion = " + _iReaderServer.ServerVersion + "\n");
        }

        private void button_Name_Click(object sender, EventArgs e)
        {
            _DeviceName = textBox_DeviceName.Text;
            richTextBox_Output.AppendText("Device Name = " + _DeviceName + "\n");
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            _iReaderServer.InstrumentName = _DeviceName;    //"Sunrise"; //"Infinite Series" // "ConnectDotNet" (for Spark);
            _iReaderServer.CommType = 1; // 1 == Simulate
            _iInstrument = _iReaderServer.CreateInstrumentObject();
            Debug.Assert(_iInstrument != null);
            _iMagellan.InstrumentObject = _iInstrument;
            richTextBox_Output.AppendText("iInstrument: " + _iInstrument + "\n");
            richTextBox_Output.AppendText("iInstrument: InstrumentName = " + _iInstrument.InstrumentName + "\n");
            _iWorkspace = _iMagellan.CreateWorkspaceObject();
            Debug.Assert(_iWorkspace != null);
            richTextBox_Output.AppendText("iWorkspace: " + _iWorkspace + "\n");
            richTextBox_Output.AppendText("iWorkspace: DocumentVersion = " + _iWorkspace.DocumentVersion + "\n");
            textBox_Filename.Text = "D:\\Temp\\MyWorkspace";
        }

        private void button_Disconnect_Click(object sender, EventArgs e)
        {
            comboBox_Methods.Items.Clear();
            richTextBox_Output.Clear();
            _iMagellan = null;
            GC.Collect();
        }

        private void button_AvailableMethods_Click(object sender, EventArgs e)
        {
            string sMethods = _iMagellan.AvailableMethodFiles(_iInstrument.InstrumentName);
            string [] sMethodsArray = sMethods.Split('\t');
            richTextBox_Output.AppendText("Available Methods = ");
            comboBox_Methods.Items.Clear();
            foreach (string s in sMethodsArray)
            {
                comboBox_Methods.Items.Add(s);
                richTextBox_Output.AppendText(s + ", ");
            }
            if (comboBox_Methods.Items.Count > 0)
            {
                comboBox_Methods.SelectedIndex = 0;
            }
            richTextBox_Output.AppendText("\n");
        }

        private void button_SetEmpty_Click(object sender, EventArgs e)
        {
            _iWorkspace.Empty = true;
        }

        private void button_InsertMethod_Click(object sender, EventArgs e)
        {
            string sMethod = comboBox_Methods.Text;
            if (!string.IsNullOrEmpty(sMethod))
            {
                bool bOk = _iWorkspace.InsertMethod(sMethod);
                richTextBox_Output.AppendText("iWorkspace: InsertMethod (" + sMethod + ") = " + bOk + "\n");
            }
        }

        private void button_ResetLastError_Click(object sender, EventArgs e)
        {
            _iInstrument.ResetLastError();
        }

        private void button_GetLastError_Click(object sender, EventArgs e)
        {
            richTextBox_Output.AppendText("Last error = " + _iInstrument.GetLastError() + "\n");
        }

        private void button_PlateOut_Click(object sender, EventArgs e)
        {
            richTextBox_Output.AppendText("Send plate out\n");
            _iMagellan.InstrumentObject.PlateInOut = "Out";
            Debug.WriteLine("Plate is: " + _iInstrument.PlateInOut);
        }

        private void button_PlateIn_Click(object sender, EventArgs e)
        {
            richTextBox_Output.AppendText("Send plate in\n");
            _iInstrument.PlateInOut = "In";
        }

        private void button_SetFileName_Click(object sender, EventArgs e)
        {
            _iWorkspace.FileName = textBox_Filename.Text;
            richTextBox_Output.AppendText("iWorkspace: Filename = " + _iWorkspace.FileName + "\n");
        }

        private void button_StartRun_Click(object sender, EventArgs e)
        {
            richTextBox_Output.AppendText("iWorkspace: Start Run\n");

            //string sError = iInstrument.GetLastError();
            //iInstrument.ResetLastError();
            //iInstrument.PowerDownAfter = 0;
            _iWorkspace.ErrorProtocol = null;
            //iWorkspace.FileName = "D:\\Temp\\MyWorkspace";
            //iWorkspace.Empty = true;
            //bool bOK = iWorkspace.InsertMethod("F200_Sim_Lumi_SampleTracking.mth");
            richTextBox_Output.AppendText("iWorkspace: Method = " + _iWorkspace.LoadedMethod + "\n");

            //int nRuntime = _iWorkspace.ExpectedRunTime;
            bool bOk = _iWorkspace.StartRun();
            richTextBox_Output.AppendText("iWorkspace: Start Run = " + bOk + "\n");
            while (_iWorkspace.Status < 1)
            {
                richTextBox_Output.AppendText(".");
                Thread.Sleep(1000);
                Application.DoEvents();
            }
            richTextBox_Output.AppendText("iWorkspace: Run finished with status: " + _iWorkspace.Status + "\n");
            richTextBox_Output.AppendText("iWorkspace: Run status = " + GetRunStatusAsText(_iWorkspace.Status) + "\n");
            richTextBox_Output.AppendText("iWorkspace: Run error protocol = " + _iWorkspace.ErrorProtocol + "\n");
        }

        private string GetRunStatusAsText(int nStatus)
        {
            string sStatus = "Run is active";
            switch (nStatus)
            {
                case 1:
                    sStatus = "Run finished successfully";
                    break;
                case 2:
                    sStatus = "Run finished not successfully";
                    break;
                case 3:
                    sStatus = "No raw data available";
                    break;
                case 4:
                    sStatus = "Validation failed";
                    break;
                case 5:
                    sStatus = "Not monotone standard curve";
                    break;
                case 6:
                    sStatus = "Validation failed and not monotone standard curve";
                    break;
                case 7:
                    sStatus = "Control moved";
                    break;
                case 8:
                    sStatus = "Control moved and validation failed";
                    break;
                case 9:
                    sStatus = "Control moved and standard curve not monotone";
                    break;
                case 10:
                    sStatus = "Control moved and validation failed and standard curve not monotone";
                    break;
                default:
                    sStatus = "Unknown";
                    break;
            }
            return sStatus;
        }

        private void button_DataExport_Click(object sender, EventArgs e)
        {
            bool bOk = _iWorkspace.AutomatedDataHandling();
            richTextBox_Output.AppendText("iWorkspace: Automated Data Handling = " + bOk + "\n");
            richTextBox_Output.AppendText("iWorkspace: Status = " + GetRunStatusAsText(_iWorkspace.Status) + "\n");
            richTextBox_Output.AppendText("iWorkspace: Error protocol = " + _iWorkspace.ErrorProtocol + "\n");
        }

        private void button_SaveWorkspace_Click(object sender, EventArgs e)
        {
            bool bOk = _iWorkspace.DoSerialization(1);
            richTextBox_Output.AppendText("iWorkspace: Save Workspace = " + bOk + "\n");
            richTextBox_Output.AppendText("iWorkspace: Save Workspace error protocol = " + _iWorkspace.ErrorProtocol + "\n");
        }

        private void button_DataNames_Click(object sender, EventArgs e)
        {
            string sNames = _iWorkspace.DataNames;
            richTextBox_Output.AppendText("iWorkspace: Data names = " + sNames + "\n");
            string[] sDataArray = sNames.Split('\t');
            richTextBox_Output.AppendText("Available output names = ");
            comboBox_DataNames.Items.Clear();
            foreach (string s in sDataArray)
            {
                comboBox_DataNames.Items.Add(s);
                richTextBox_Output.AppendText(s + ", ");
            }
            if (comboBox_DataNames.Items.Count > 0)
            {
                comboBox_DataNames.SelectedIndex = 0;
            }
            richTextBox_Output.AppendText("\n");

        }

        private void button_DataAsTable_Click(object sender, EventArgs e)
        {
            string sDataAsTable = _iWorkspace.DataAsTable(comboBox_DataNames.Text, 0);
            richTextBox_Output.AppendText(sDataAsTable + "\n");
        }

        private void button_ModifyLayout_Click(object sender, EventArgs e)
        {
            string s1 = "NC1\tA1\tneg1\t0\nNC1\tA2\tneg2\t0\n";
            string s2 = "PC1\tB1\tpos1\t0\nPC1\tB2\tpos2\t0\n";
            string s3 = "SM1_1\tC1\tsm11\t0\nSM1_1\tC2\tsm12\t0\nSM1_1\tD1\tsm13\t0\nSM1_1\tD2\tsm14\t0\n";
            string s4 = "SM1_2\tE1\tsm21\t0\nSM1_2\tE2\tsm22\t0\nSM1_2\tF1\tsm23\t0\nSM1_2\tF2\tsm24\t0\n";
            string s5 = "SM1_3\tG1\tsm31\t0\nSM1_3\tG2\tsm32\t0\nSM1_3\tH1\tsm33\t0\nSM1_3\tH2\tsm34\t0\n";
            string sNewLayout = s1 + s2 + s3 + s4 + s5;

            bool bOk = _iWorkspace.ModifyLayout(sNewLayout);
            richTextBox_Output.AppendText("iWorkspace: ModifyLayout = " + bOk + "\n");
            richTextBox_Output.AppendText("iWorkspace: ModifyLayouts error protocol = " + _iWorkspace.ErrorProtocol + "\n");
        }

        private void button_Samples_Click(object sender, EventArgs e)
        {
            bool bOk = _iWorkspace.InsertSampleIDs(@"D:\Temp\Test.tpl", 1);
            richTextBox_Output.AppendText("iWorkspace: Insert Sample ID´s = " + bOk + "\n");
            richTextBox_Output.AppendText("iWorkspace: Insert Sample ID´s error protocol = " + _iWorkspace.ErrorProtocol + "\n");
        }
    }
}