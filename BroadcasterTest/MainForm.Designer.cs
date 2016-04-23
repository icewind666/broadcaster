using System.ComponentModel;
using System.Windows.Forms;

namespace BroadcasterTest
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.tb_LogOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Kill_FFMPEG_Process = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_FFMPEG_LogOutput = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tc_main = new System.Windows.Forms.TabControl();
            this.tp_Main = new System.Windows.Forms.TabPage();
            this.tp_Options = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cb_OpenedWindows = new System.Windows.Forms.ComboBox();
            this.rb_UseTitle = new System.Windows.Forms.RadioButton();
            this.label20 = new System.Windows.Forms.Label();
            this.btn_FindOpenWindows = new System.Windows.Forms.Button();
            this.rb_UseIntPtr = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_FFMPEG_Path = new System.Windows.Forms.TextBox();
            this.tb_FFMPEG_Args = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.trb_MicrophoneVolume = new System.Windows.Forms.TrackBar();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_AudioInput = new System.Windows.Forms.ComboBox();
            this.cb_VideoInput = new System.Windows.Forms.ComboBox();
            this.videoDeviceInput = new System.Windows.Forms.Label();
            this.audioDeviceInput = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btn_GetAvailableDevs = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_SaveToFile = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_Stream_Url = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_StreamKey = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tp_QualitySettings = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tb_vo_vf = new System.Windows.Forms.TextBox();
            this.lb_vo_vf = new System.Windows.Forms.Label();
            this.tb_vo_passlogfile = new System.Windows.Forms.TextBox();
            this.lb_vo_passlogfile = new System.Windows.Forms.Label();
            this.tb_vo_pass = new System.Windows.Forms.TextBox();
            this.lb_vo_pass = new System.Windows.Forms.Label();
            this.tb_vo_vcodec = new System.Windows.Forms.TextBox();
            this.lb_vo_vcodec = new System.Windows.Forms.Label();
            this.tb_vo_vn = new System.Windows.Forms.TextBox();
            this.lb_vo_vn = new System.Windows.Forms.Label();
            this.tb_vo_aspect = new System.Windows.Forms.TextBox();
            this.lb_vo_aspect = new System.Windows.Forms.Label();
            this.tb_vo_s = new System.Windows.Forms.TextBox();
            this.lb_vo_s = new System.Windows.Forms.Label();
            this.tb_vo_r = new System.Windows.Forms.TextBox();
            this.lb_vo_r = new System.Windows.Forms.Label();
            this.tb_vo_vframes = new System.Windows.Forms.TextBox();
            this.lb_vframes = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.tb_avo_force_key_frames = new System.Windows.Forms.TextBox();
            this.lb_avo_force_key_frames = new System.Windows.Forms.Label();
            this.tb_avo_vbsf = new System.Windows.Forms.TextBox();
            this.lb_avo_vbsf = new System.Windows.Forms.Label();
            this.tb_avo_qphist = new System.Windows.Forms.TextBox();
            this.lb_avo_qphist = new System.Windows.Forms.Label();
            this.tb_avo_vstats = new System.Windows.Forms.TextBox();
            this.lb_avo_vstats = new System.Windows.Forms.Label();
            this.tb_avo_psnr = new System.Windows.Forms.TextBox();
            this.lb_avo_psnr = new System.Windows.Forms.Label();
            this.tb_avo_ilme = new System.Windows.Forms.TextBox();
            this.lb_avo_ilme = new System.Windows.Forms.Label();
            this.tb_avo_hwaccel_device = new System.Windows.Forms.TextBox();
            this.lb_avo_hwaccel_device = new System.Windows.Forms.Label();
            this.tb_avo_hwaccel = new System.Windows.Forms.TextBox();
            this.lb_avo_hwaccel = new System.Windows.Forms.Label();
            this.tb_avo_copyinkf = new System.Windows.Forms.TextBox();
            this.lb_avo_copyinkf = new System.Windows.Forms.Label();
            this.tb_avo_vstats_file = new System.Windows.Forms.TextBox();
            this.tb_avo_vtag = new System.Windows.Forms.TextBox();
            this.lb_avo_vtag = new System.Windows.Forms.Label();
            this.tb_avo_dc = new System.Windows.Forms.TextBox();
            this.lb_avo_dc = new System.Windows.Forms.Label();
            this.tb_avo_top = new System.Windows.Forms.TextBox();
            this.lb_avo_top = new System.Windows.Forms.Label();
            this.lb_avo_vstats_file = new System.Windows.Forms.Label();
            this.tb_avo_rc_override = new System.Windows.Forms.TextBox();
            this.lb_avo_rc_override = new System.Windows.Forms.Label();
            this.tb_avo_vdt = new System.Windows.Forms.TextBox();
            this.lb_avo_vdt = new System.Windows.Forms.Label();
            this.tb_avo_sws_flags = new System.Windows.Forms.TextBox();
            this.lb_avo_sws_flags = new System.Windows.Forms.Label();
            this.tb_avo_pix_fmt = new System.Windows.Forms.TextBox();
            this.lb_avo_pix_fmt = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tb_ao_af = new System.Windows.Forms.TextBox();
            this.lb_ao_af = new System.Windows.Forms.Label();
            this.tb_ao_sample_fmt = new System.Windows.Forms.TextBox();
            this.lb_ao_sample_fmt = new System.Windows.Forms.Label();
            this.tb_ao_acodec = new System.Windows.Forms.TextBox();
            this.lb_ao_acodec = new System.Windows.Forms.Label();
            this.tb_ao_an = new System.Windows.Forms.TextBox();
            this.lb_ao_an = new System.Windows.Forms.Label();
            this.tb_ao_ac = new System.Windows.Forms.TextBox();
            this.lb_ao_ac = new System.Windows.Forms.Label();
            this.tb_ao_aq = new System.Windows.Forms.TextBox();
            this.lb_ao_aq = new System.Windows.Forms.Label();
            this.tb_ao_ar = new System.Windows.Forms.TextBox();
            this.lb_ao_ar = new System.Windows.Forms.Label();
            this.tb_ao_aframes = new System.Windows.Forms.TextBox();
            this.lv_ao_aframes = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.tb_aao_guess_layout_max = new System.Windows.Forms.TextBox();
            this.lb_aao_guess_layout_max = new System.Windows.Forms.Label();
            this.tb_aao_absf = new System.Windows.Forms.TextBox();
            this.lb_aao_absf = new System.Windows.Forms.Label();
            this.tb_aao_atag = new System.Windows.Forms.TextBox();
            this.lb_aao_atag = new System.Windows.Forms.Label();
            this.lb_videoBitrate = new System.Windows.Forms.Label();
            this.cb_VideoBitrate = new System.Windows.Forms.ComboBox();
            this.lb_audioBitrate = new System.Windows.Forms.Label();
            this.cb_AudioBitrate = new System.Windows.Forms.ComboBox();
            this.lb_configNames = new System.Windows.Forms.ListBox();
            this.btn_AddConfig = new System.Windows.Forms.Button();
            this.btn_CloneConfig = new System.Windows.Forms.Button();
            this.btn_UpdateConfig = new System.Windows.Forms.Button();
            this.btn_RenameConfig = new System.Windows.Forms.Button();
            this.btn_RemoveConfig = new System.Windows.Forms.Button();
            this.tc_main.SuspendLayout();
            this.tp_Main.SuspendLayout();
            this.tp_Options.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_MicrophoneVolume)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tp_QualitySettings.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.Enabled = false;
            this.btn_Start.Location = new System.Drawing.Point(297, 17);
            this.btn_Start.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(110, 37);
            this.btn_Start.TabIndex = 1;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Stop.Enabled = false;
            this.btn_Stop.Location = new System.Drawing.Point(412, 18);
            this.btn_Stop.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(110, 37);
            this.btn_Stop.TabIndex = 2;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // tb_LogOutput
            // 
            this.tb_LogOutput.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.tb_LogOutput.Location = new System.Drawing.Point(5, 83);
            this.tb_LogOutput.Margin = new System.Windows.Forms.Padding(2);
            this.tb_LogOutput.Multiline = true;
            this.tb_LogOutput.Name = "tb_LogOutput";
            this.tb_LogOutput.ReadOnly = true;
            this.tb_LogOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_LogOutput.Size = new System.Drawing.Size(402, 306);
            this.tb_LogOutput.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // btn_Kill_FFMPEG_Process
            // 
            this.btn_Kill_FFMPEG_Process.Enabled = false;
            this.btn_Kill_FFMPEG_Process.Location = new System.Drawing.Point(554, 17);
            this.btn_Kill_FFMPEG_Process.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Kill_FFMPEG_Process.Name = "btn_Kill_FFMPEG_Process";
            this.btn_Kill_FFMPEG_Process.Size = new System.Drawing.Size(242, 37);
            this.btn_Kill_FFMPEG_Process.TabIndex = 4;
            this.btn_Kill_FFMPEG_Process.Text = "Kill ffmpeg process (video can be corrupted)";
            this.btn_Kill_FFMPEG_Process.UseVisualStyleBackColor = true;
            this.btn_Kill_FFMPEG_Process.Click += new System.EventHandler(this.btn_Kill_FFMPEG_Process_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(717, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "FFMPEG raw output";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(82, 25);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 25);
            this.label16.TabIndex = 43;
            this.label16.Text = "streaming";
            // 
            // tb_FFMPEG_LogOutput
            // 
            this.tb_FFMPEG_LogOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_FFMPEG_LogOutput.ForeColor = System.Drawing.Color.DarkRed;
            this.tb_FFMPEG_LogOutput.Location = new System.Drawing.Point(411, 83);
            this.tb_FFMPEG_LogOutput.Margin = new System.Windows.Forms.Padding(2);
            this.tb_FFMPEG_LogOutput.Multiline = true;
            this.tb_FFMPEG_LogOutput.Name = "tb_FFMPEG_LogOutput";
            this.tb_FFMPEG_LogOutput.ReadOnly = true;
            this.tb_FFMPEG_LogOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_FFMPEG_LogOutput.Size = new System.Drawing.Size(429, 306);
            this.tb_FFMPEG_LogOutput.TabIndex = 47;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(21, 65);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 13);
            this.label19.TabIndex = 48;
            this.label19.Text = "Log output";
            // 
            // tc_main
            // 
            this.tc_main.Controls.Add(this.tp_Main);
            this.tc_main.Controls.Add(this.tp_Options);
            this.tc_main.Controls.Add(this.tp_QualitySettings);
            this.tc_main.Location = new System.Drawing.Point(12, 12);
            this.tc_main.Name = "tc_main";
            this.tc_main.SelectedIndex = 0;
            this.tc_main.Size = new System.Drawing.Size(853, 420);
            this.tc_main.TabIndex = 0;
            // 
            // tp_Main
            // 
            this.tp_Main.BackColor = System.Drawing.SystemColors.Control;
            this.tp_Main.Controls.Add(this.label16);
            this.tp_Main.Controls.Add(this.label19);
            this.tp_Main.Controls.Add(this.btn_Start);
            this.tp_Main.Controls.Add(this.tb_FFMPEG_LogOutput);
            this.tp_Main.Controls.Add(this.btn_Stop);
            this.tp_Main.Controls.Add(this.tb_LogOutput);
            this.tp_Main.Controls.Add(this.btn_Kill_FFMPEG_Process);
            this.tp_Main.Controls.Add(this.label5);
            this.tp_Main.Location = new System.Drawing.Point(4, 22);
            this.tp_Main.Name = "tp_Main";
            this.tp_Main.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Main.Size = new System.Drawing.Size(845, 394);
            this.tp_Main.TabIndex = 0;
            this.tp_Main.Text = "      Main      ";
            // 
            // tp_Options
            // 
            this.tp_Options.BackColor = System.Drawing.SystemColors.Control;
            this.tp_Options.Controls.Add(this.btn_RemoveConfig);
            this.tp_Options.Controls.Add(this.btn_RenameConfig);
            this.tp_Options.Controls.Add(this.btn_UpdateConfig);
            this.tp_Options.Controls.Add(this.btn_CloneConfig);
            this.tp_Options.Controls.Add(this.btn_AddConfig);
            this.tp_Options.Controls.Add(this.lb_configNames);
            this.tp_Options.Controls.Add(this.label7);
            this.tp_Options.Controls.Add(this.groupBox5);
            this.tp_Options.Controls.Add(this.groupBox4);
            this.tp_Options.Controls.Add(this.trb_MicrophoneVolume);
            this.tp_Options.Controls.Add(this.label17);
            this.tp_Options.Controls.Add(this.groupBox3);
            this.tp_Options.Controls.Add(this.groupBox1);
            this.tp_Options.Controls.Add(this.groupBox2);
            this.tp_Options.Location = new System.Drawing.Point(4, 22);
            this.tp_Options.Name = "tp_Options";
            this.tp_Options.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Options.Size = new System.Drawing.Size(845, 394);
            this.tp_Options.TabIndex = 1;
            this.tp_Options.Text = "      Options      ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(730, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 62;
            this.label7.Text = "Audio input volume";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cb_OpenedWindows);
            this.groupBox5.Controls.Add(this.rb_UseTitle);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.btn_FindOpenWindows);
            this.groupBox5.Controls.Add(this.rb_UseIntPtr);
            this.groupBox5.Location = new System.Drawing.Point(15, 300);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(699, 84);
            this.groupBox5.TabIndex = 61;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Window capture";
            // 
            // cb_OpenedWindows
            // 
            this.cb_OpenedWindows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_OpenedWindows.FormattingEnabled = true;
            this.cb_OpenedWindows.Location = new System.Drawing.Point(78, 22);
            this.cb_OpenedWindows.Margin = new System.Windows.Forms.Padding(2);
            this.cb_OpenedWindows.Name = "cb_OpenedWindows";
            this.cb_OpenedWindows.Size = new System.Drawing.Size(485, 21);
            this.cb_OpenedWindows.TabIndex = 49;
            // 
            // rb_UseTitle
            // 
            this.rb_UseTitle.AutoSize = true;
            this.rb_UseTitle.Checked = true;
            this.rb_UseTitle.Location = new System.Drawing.Point(578, 61);
            this.rb_UseTitle.Name = "rb_UseTitle";
            this.rb_UseTitle.Size = new System.Drawing.Size(41, 17);
            this.rb_UseTitle.TabIndex = 55;
            this.rb_UseTitle.TabStop = true;
            this.rb_UseTitle.Text = "title";
            this.rb_UseTitle.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(27, 25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(46, 13);
            this.label20.TabIndex = 52;
            this.label20.Text = "Window";
            // 
            // btn_FindOpenWindows
            // 
            this.btn_FindOpenWindows.Location = new System.Drawing.Point(576, 13);
            this.btn_FindOpenWindows.Name = "btn_FindOpenWindows";
            this.btn_FindOpenWindows.Size = new System.Drawing.Size(110, 37);
            this.btn_FindOpenWindows.TabIndex = 51;
            this.btn_FindOpenWindows.Text = "Rerresh";
            this.btn_FindOpenWindows.UseVisualStyleBackColor = true;
            this.btn_FindOpenWindows.Click += new System.EventHandler(this.btn_FindOpenWindows_Click);
            // 
            // rb_UseIntPtr
            // 
            this.rb_UseIntPtr.AutoSize = true;
            this.rb_UseIntPtr.Location = new System.Drawing.Point(625, 61);
            this.rb_UseIntPtr.Name = "rb_UseIntPtr";
            this.rb_UseIntPtr.Size = new System.Drawing.Size(61, 17);
            this.rb_UseIntPtr.TabIndex = 54;
            this.rb_UseIntPtr.Text = "-vf crop";
            this.rb_UseIntPtr.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.tb_FFMPEG_Path);
            this.groupBox4.Controls.Add(this.tb_FFMPEG_Args);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(15, 5);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(610, 81);
            this.groupBox4.TabIndex = 57;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "FFMPEG settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Path";
            // 
            // tb_FFMPEG_Path
            // 
            this.tb_FFMPEG_Path.Location = new System.Drawing.Point(78, 21);
            this.tb_FFMPEG_Path.Margin = new System.Windows.Forms.Padding(2);
            this.tb_FFMPEG_Path.Name = "tb_FFMPEG_Path";
            this.tb_FFMPEG_Path.Size = new System.Drawing.Size(524, 20);
            this.tb_FFMPEG_Path.TabIndex = 12;
            this.tb_FFMPEG_Path.Text = "E:\\Distib\\VisualStudioProjects\\CSharp\\A_Other\\ffmpeg-20150803-git-5750d6c-win64-s" +
    "tatic\\bin\\ffmpeg.exe";
            // 
            // tb_FFMPEG_Args
            // 
            this.tb_FFMPEG_Args.Location = new System.Drawing.Point(78, 55);
            this.tb_FFMPEG_Args.Margin = new System.Windows.Forms.Padding(2);
            this.tb_FFMPEG_Args.Name = "tb_FFMPEG_Args";
            this.tb_FFMPEG_Args.Size = new System.Drawing.Size(524, 20);
            this.tb_FFMPEG_Args.TabIndex = 13;
            this.tb_FFMPEG_Args.Text = " -rtbufsize 500M -framerate 10 -f dshow";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Arguments";
            // 
            // trb_MicrophoneVolume
            // 
            this.trb_MicrophoneVolume.LargeChange = 10;
            this.trb_MicrophoneVolume.Location = new System.Drawing.Point(759, 224);
            this.trb_MicrophoneVolume.Maximum = 100;
            this.trb_MicrophoneVolume.Name = "trb_MicrophoneVolume";
            this.trb_MicrophoneVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trb_MicrophoneVolume.Size = new System.Drawing.Size(45, 154);
            this.trb_MicrophoneVolume.SmallChange = 5;
            this.trb_MicrophoneVolume.TabIndex = 60;
            this.trb_MicrophoneVolume.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trb_MicrophoneVolume.Scroll += new System.EventHandler(this.trb_MicrophoneVolume_Scroll);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(382, 138);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(16, 13);
            this.label17.TabIndex = 58;
            this.label17.Text = "or";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_AudioInput);
            this.groupBox3.Controls.Add(this.cb_VideoInput);
            this.groupBox3.Controls.Add(this.videoDeviceInput);
            this.groupBox3.Controls.Add(this.audioDeviceInput);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.btn_GetAvailableDevs);
            this.groupBox3.Location = new System.Drawing.Point(15, 191);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(699, 104);
            this.groupBox3.TabIndex = 56;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Input devices";
            // 
            // cb_AudioInput
            // 
            this.cb_AudioInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_AudioInput.FormattingEnabled = true;
            this.cb_AudioInput.Location = new System.Drawing.Point(78, 63);
            this.cb_AudioInput.Margin = new System.Windows.Forms.Padding(2);
            this.cb_AudioInput.Name = "cb_AudioInput";
            this.cb_AudioInput.Size = new System.Drawing.Size(485, 21);
            this.cb_AudioInput.TabIndex = 53;
            this.cb_AudioInput.SelectedValueChanged += new System.EventHandler(this.cb_AudioInput_SelectedIndexChanged);
            // 
            // cb_VideoInput
            // 
            this.cb_VideoInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_VideoInput.FormattingEnabled = true;
            this.cb_VideoInput.Location = new System.Drawing.Point(79, 32);
            this.cb_VideoInput.Margin = new System.Windows.Forms.Padding(2);
            this.cb_VideoInput.Name = "cb_VideoInput";
            this.cb_VideoInput.Size = new System.Drawing.Size(484, 21);
            this.cb_VideoInput.TabIndex = 10;
            // 
            // videoDeviceInput
            // 
            this.videoDeviceInput.AutoSize = true;
            this.videoDeviceInput.Location = new System.Drawing.Point(15, 35);
            this.videoDeviceInput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.videoDeviceInput.Name = "videoDeviceInput";
            this.videoDeviceInput.Size = new System.Drawing.Size(60, 13);
            this.videoDeviceInput.TabIndex = 7;
            this.videoDeviceInput.Text = "Video input";
            // 
            // audioDeviceInput
            // 
            this.audioDeviceInput.AutoSize = true;
            this.audioDeviceInput.Location = new System.Drawing.Point(16, 66);
            this.audioDeviceInput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.audioDeviceInput.Name = "audioDeviceInput";
            this.audioDeviceInput.Size = new System.Drawing.Size(60, 13);
            this.audioDeviceInput.TabIndex = 8;
            this.audioDeviceInput.Text = "Audio input";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(307, 86);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 9);
            this.label11.TabIndex = 31;
            this.label11.Text = "leave blank to mute sound";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.label18.Location = new System.Drawing.Point(264, 21);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(184, 9);
            this.label18.TabIndex = 59;
            this.label18.Text = "ffmpeg will try to detect all devices available for using";
            // 
            // btn_GetAvailableDevs
            // 
            this.btn_GetAvailableDevs.Location = new System.Drawing.Point(576, 43);
            this.btn_GetAvailableDevs.Margin = new System.Windows.Forms.Padding(2);
            this.btn_GetAvailableDevs.Name = "btn_GetAvailableDevs";
            this.btn_GetAvailableDevs.Size = new System.Drawing.Size(110, 37);
            this.btn_GetAvailableDevs.TabIndex = 51;
            this.btn_GetAvailableDevs.Text = "Get available devices";
            this.btn_GetAvailableDevs.UseVisualStyleBackColor = true;
            this.btn_GetAvailableDevs.Click += new System.EventHandler(this.btn_GetAvailableDevs_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_SaveToFile);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(15, 106);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(363, 81);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Save to file";
            // 
            // tb_SaveToFile
            // 
            this.tb_SaveToFile.Location = new System.Drawing.Point(41, 29);
            this.tb_SaveToFile.Margin = new System.Windows.Forms.Padding(2);
            this.tb_SaveToFile.Name = "tb_SaveToFile";
            this.tb_SaveToFile.Size = new System.Drawing.Size(306, 20);
            this.tb_SaveToFile.TabIndex = 20;
            this.tb_SaveToFile.Text = "S:\\test.mp4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "File";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_Stream_Url);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tb_StreamKey);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(402, 106);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(432, 81);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stream to server";
            // 
            // tb_Stream_Url
            // 
            this.tb_Stream_Url.Location = new System.Drawing.Point(70, 17);
            this.tb_Stream_Url.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Stream_Url.Name = "tb_Stream_Url";
            this.tb_Stream_Url.Size = new System.Drawing.Size(348, 20);
            this.tb_Stream_Url.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "URL";
            // 
            // tb_StreamKey
            // 
            this.tb_StreamKey.Location = new System.Drawing.Point(70, 52);
            this.tb_StreamKey.Margin = new System.Windows.Forms.Padding(2);
            this.tb_StreamKey.Name = "tb_StreamKey";
            this.tb_StreamKey.PasswordChar = '*';
            this.tb_StreamKey.Size = new System.Drawing.Size(348, 20);
            this.tb_StreamKey.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 55);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "StreamKey";
            // 
            // tp_QualitySettings
            // 
            this.tp_QualitySettings.BackColor = System.Drawing.SystemColors.Control;
            this.tp_QualitySettings.Controls.Add(this.label9);
            this.tp_QualitySettings.Controls.Add(this.tabControl1);
            this.tp_QualitySettings.Controls.Add(this.lb_videoBitrate);
            this.tp_QualitySettings.Controls.Add(this.cb_VideoBitrate);
            this.tp_QualitySettings.Controls.Add(this.lb_audioBitrate);
            this.tp_QualitySettings.Controls.Add(this.cb_AudioBitrate);
            this.tp_QualitySettings.Location = new System.Drawing.Point(4, 22);
            this.tp_QualitySettings.Name = "tp_QualitySettings";
            this.tp_QualitySettings.Padding = new System.Windows.Forms.Padding(3);
            this.tp_QualitySettings.Size = new System.Drawing.Size(845, 394);
            this.tp_QualitySettings.TabIndex = 2;
            this.tp_QualitySettings.Text = "Quality settings";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(131, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Main settings:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(833, 348);
            this.tabControl1.TabIndex = 41;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox9);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(825, 322);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "   Video   ";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tb_vo_vf);
            this.groupBox6.Controls.Add(this.lb_vo_vf);
            this.groupBox6.Controls.Add(this.tb_vo_passlogfile);
            this.groupBox6.Controls.Add(this.lb_vo_passlogfile);
            this.groupBox6.Controls.Add(this.tb_vo_pass);
            this.groupBox6.Controls.Add(this.lb_vo_pass);
            this.groupBox6.Controls.Add(this.tb_vo_vcodec);
            this.groupBox6.Controls.Add(this.lb_vo_vcodec);
            this.groupBox6.Controls.Add(this.tb_vo_vn);
            this.groupBox6.Controls.Add(this.lb_vo_vn);
            this.groupBox6.Controls.Add(this.tb_vo_aspect);
            this.groupBox6.Controls.Add(this.lb_vo_aspect);
            this.groupBox6.Controls.Add(this.tb_vo_s);
            this.groupBox6.Controls.Add(this.lb_vo_s);
            this.groupBox6.Controls.Add(this.tb_vo_r);
            this.groupBox6.Controls.Add(this.lb_vo_r);
            this.groupBox6.Controls.Add(this.tb_vo_vframes);
            this.groupBox6.Controls.Add(this.lb_vframes);
            this.groupBox6.Location = new System.Drawing.Point(6, 10);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(257, 306);
            this.groupBox6.TabIndex = 37;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Video Options";
            // 
            // tb_vo_vf
            // 
            this.tb_vo_vf.Location = new System.Drawing.Point(70, 239);
            this.tb_vo_vf.Name = "tb_vo_vf";
            this.tb_vo_vf.Size = new System.Drawing.Size(167, 20);
            this.tb_vo_vf.TabIndex = 54;
            // 
            // lb_vo_vf
            // 
            this.lb_vo_vf.AutoSize = true;
            this.lb_vo_vf.Location = new System.Drawing.Point(45, 242);
            this.lb_vo_vf.Name = "lb_vo_vf";
            this.lb_vo_vf.Size = new System.Drawing.Size(19, 13);
            this.lb_vo_vf.TabIndex = 53;
            this.lb_vo_vf.Text = "-vf";
            // 
            // tb_vo_passlogfile
            // 
            this.tb_vo_passlogfile.Location = new System.Drawing.Point(70, 213);
            this.tb_vo_passlogfile.Name = "tb_vo_passlogfile";
            this.tb_vo_passlogfile.Size = new System.Drawing.Size(167, 20);
            this.tb_vo_passlogfile.TabIndex = 52;
            // 
            // lb_vo_passlogfile
            // 
            this.lb_vo_passlogfile.AutoSize = true;
            this.lb_vo_passlogfile.Location = new System.Drawing.Point(5, 216);
            this.lb_vo_passlogfile.Name = "lb_vo_passlogfile";
            this.lb_vo_passlogfile.Size = new System.Drawing.Size(59, 13);
            this.lb_vo_passlogfile.TabIndex = 51;
            this.lb_vo_passlogfile.Text = "-passlogfile";
            // 
            // tb_vo_pass
            // 
            this.tb_vo_pass.Location = new System.Drawing.Point(70, 187);
            this.tb_vo_pass.Name = "tb_vo_pass";
            this.tb_vo_pass.Size = new System.Drawing.Size(167, 20);
            this.tb_vo_pass.TabIndex = 50;
            // 
            // lb_vo_pass
            // 
            this.lb_vo_pass.AutoSize = true;
            this.lb_vo_pass.Location = new System.Drawing.Point(32, 186);
            this.lb_vo_pass.Name = "lb_vo_pass";
            this.lb_vo_pass.Size = new System.Drawing.Size(32, 13);
            this.lb_vo_pass.TabIndex = 49;
            this.lb_vo_pass.Text = "-pass";
            // 
            // tb_vo_vcodec
            // 
            this.tb_vo_vcodec.Location = new System.Drawing.Point(70, 161);
            this.tb_vo_vcodec.Name = "tb_vo_vcodec";
            this.tb_vo_vcodec.Size = new System.Drawing.Size(167, 20);
            this.tb_vo_vcodec.TabIndex = 48;
            // 
            // lb_vo_vcodec
            // 
            this.lb_vo_vcodec.AutoSize = true;
            this.lb_vo_vcodec.Location = new System.Drawing.Point(18, 160);
            this.lb_vo_vcodec.Name = "lb_vo_vcodec";
            this.lb_vo_vcodec.Size = new System.Drawing.Size(46, 13);
            this.lb_vo_vcodec.TabIndex = 47;
            this.lb_vo_vcodec.Text = "-vcodec";
            // 
            // tb_vo_vn
            // 
            this.tb_vo_vn.Location = new System.Drawing.Point(70, 135);
            this.tb_vo_vn.Name = "tb_vo_vn";
            this.tb_vo_vn.Size = new System.Drawing.Size(167, 20);
            this.tb_vo_vn.TabIndex = 46;
            // 
            // lb_vo_vn
            // 
            this.lb_vo_vn.AutoSize = true;
            this.lb_vo_vn.Location = new System.Drawing.Point(42, 138);
            this.lb_vo_vn.Name = "lb_vo_vn";
            this.lb_vo_vn.Size = new System.Drawing.Size(22, 13);
            this.lb_vo_vn.TabIndex = 45;
            this.lb_vo_vn.Text = "-vn";
            // 
            // tb_vo_aspect
            // 
            this.tb_vo_aspect.Location = new System.Drawing.Point(69, 107);
            this.tb_vo_aspect.Name = "tb_vo_aspect";
            this.tb_vo_aspect.Size = new System.Drawing.Size(167, 20);
            this.tb_vo_aspect.TabIndex = 44;
            // 
            // lb_vo_aspect
            // 
            this.lb_vo_aspect.AutoSize = true;
            this.lb_vo_aspect.Location = new System.Drawing.Point(20, 110);
            this.lb_vo_aspect.Name = "lb_vo_aspect";
            this.lb_vo_aspect.Size = new System.Drawing.Size(42, 13);
            this.lb_vo_aspect.TabIndex = 43;
            this.lb_vo_aspect.Text = "-aspect";
            // 
            // tb_vo_s
            // 
            this.tb_vo_s.Location = new System.Drawing.Point(69, 81);
            this.tb_vo_s.Name = "tb_vo_s";
            this.tb_vo_s.Size = new System.Drawing.Size(167, 20);
            this.tb_vo_s.TabIndex = 42;
            // 
            // lb_vo_s
            // 
            this.lb_vo_s.AutoSize = true;
            this.lb_vo_s.Location = new System.Drawing.Point(47, 84);
            this.lb_vo_s.Name = "lb_vo_s";
            this.lb_vo_s.Size = new System.Drawing.Size(15, 13);
            this.lb_vo_s.TabIndex = 41;
            this.lb_vo_s.Text = "-s";
            // 
            // tb_vo_r
            // 
            this.tb_vo_r.Location = new System.Drawing.Point(69, 55);
            this.tb_vo_r.Name = "tb_vo_r";
            this.tb_vo_r.Size = new System.Drawing.Size(167, 20);
            this.tb_vo_r.TabIndex = 40;
            // 
            // lb_vo_r
            // 
            this.lb_vo_r.AutoSize = true;
            this.lb_vo_r.Location = new System.Drawing.Point(49, 58);
            this.lb_vo_r.Name = "lb_vo_r";
            this.lb_vo_r.Size = new System.Drawing.Size(13, 13);
            this.lb_vo_r.TabIndex = 39;
            this.lb_vo_r.Text = "-r";
            // 
            // tb_vo_vframes
            // 
            this.tb_vo_vframes.Location = new System.Drawing.Point(69, 29);
            this.tb_vo_vframes.Name = "tb_vo_vframes";
            this.tb_vo_vframes.Size = new System.Drawing.Size(167, 20);
            this.tb_vo_vframes.TabIndex = 38;
            // 
            // lb_vframes
            // 
            this.lb_vframes.AutoSize = true;
            this.lb_vframes.Location = new System.Drawing.Point(15, 32);
            this.lb_vframes.Name = "lb_vframes";
            this.lb_vframes.Size = new System.Drawing.Size(47, 13);
            this.lb_vframes.TabIndex = 37;
            this.lb_vframes.Text = "-vframes";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.tb_avo_force_key_frames);
            this.groupBox9.Controls.Add(this.lb_avo_force_key_frames);
            this.groupBox9.Controls.Add(this.tb_avo_vbsf);
            this.groupBox9.Controls.Add(this.lb_avo_vbsf);
            this.groupBox9.Controls.Add(this.tb_avo_qphist);
            this.groupBox9.Controls.Add(this.lb_avo_qphist);
            this.groupBox9.Controls.Add(this.tb_avo_vstats);
            this.groupBox9.Controls.Add(this.lb_avo_vstats);
            this.groupBox9.Controls.Add(this.tb_avo_psnr);
            this.groupBox9.Controls.Add(this.lb_avo_psnr);
            this.groupBox9.Controls.Add(this.tb_avo_ilme);
            this.groupBox9.Controls.Add(this.lb_avo_ilme);
            this.groupBox9.Controls.Add(this.tb_avo_hwaccel_device);
            this.groupBox9.Controls.Add(this.lb_avo_hwaccel_device);
            this.groupBox9.Controls.Add(this.tb_avo_hwaccel);
            this.groupBox9.Controls.Add(this.lb_avo_hwaccel);
            this.groupBox9.Controls.Add(this.tb_avo_copyinkf);
            this.groupBox9.Controls.Add(this.lb_avo_copyinkf);
            this.groupBox9.Controls.Add(this.tb_avo_vstats_file);
            this.groupBox9.Controls.Add(this.tb_avo_vtag);
            this.groupBox9.Controls.Add(this.lb_avo_vtag);
            this.groupBox9.Controls.Add(this.tb_avo_dc);
            this.groupBox9.Controls.Add(this.lb_avo_dc);
            this.groupBox9.Controls.Add(this.tb_avo_top);
            this.groupBox9.Controls.Add(this.lb_avo_top);
            this.groupBox9.Controls.Add(this.lb_avo_vstats_file);
            this.groupBox9.Controls.Add(this.tb_avo_rc_override);
            this.groupBox9.Controls.Add(this.lb_avo_rc_override);
            this.groupBox9.Controls.Add(this.tb_avo_vdt);
            this.groupBox9.Controls.Add(this.lb_avo_vdt);
            this.groupBox9.Controls.Add(this.tb_avo_sws_flags);
            this.groupBox9.Controls.Add(this.lb_avo_sws_flags);
            this.groupBox9.Controls.Add(this.tb_avo_pix_fmt);
            this.groupBox9.Controls.Add(this.lb_avo_pix_fmt);
            this.groupBox9.Location = new System.Drawing.Point(269, 10);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(550, 306);
            this.groupBox9.TabIndex = 40;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Advanced Video options";
            // 
            // tb_avo_force_key_frames
            // 
            this.tb_avo_force_key_frames.Location = new System.Drawing.Point(121, 252);
            this.tb_avo_force_key_frames.Name = "tb_avo_force_key_frames";
            this.tb_avo_force_key_frames.Size = new System.Drawing.Size(409, 20);
            this.tb_avo_force_key_frames.TabIndex = 96;
            // 
            // lb_avo_force_key_frames
            // 
            this.lb_avo_force_key_frames.AutoSize = true;
            this.lb_avo_force_key_frames.Location = new System.Drawing.Point(21, 255);
            this.lb_avo_force_key_frames.Name = "lb_avo_force_key_frames";
            this.lb_avo_force_key_frames.Size = new System.Drawing.Size(94, 13);
            this.lb_avo_force_key_frames.TabIndex = 95;
            this.lb_avo_force_key_frames.Text = "-force_key_frames";
            // 
            // tb_avo_vbsf
            // 
            this.tb_avo_vbsf.Location = new System.Drawing.Point(364, 123);
            this.tb_avo_vbsf.Name = "tb_avo_vbsf";
            this.tb_avo_vbsf.Size = new System.Drawing.Size(166, 20);
            this.tb_avo_vbsf.TabIndex = 94;
            // 
            // lb_avo_vbsf
            // 
            this.lb_avo_vbsf.AutoSize = true;
            this.lb_avo_vbsf.Location = new System.Drawing.Point(326, 126);
            this.lb_avo_vbsf.Name = "lb_avo_vbsf";
            this.lb_avo_vbsf.Size = new System.Drawing.Size(30, 13);
            this.lb_avo_vbsf.TabIndex = 93;
            this.lb_avo_vbsf.Text = "-vbsf";
            // 
            // tb_avo_qphist
            // 
            this.tb_avo_qphist.Location = new System.Drawing.Point(364, 148);
            this.tb_avo_qphist.Name = "tb_avo_qphist";
            this.tb_avo_qphist.Size = new System.Drawing.Size(166, 20);
            this.tb_avo_qphist.TabIndex = 86;
            // 
            // lb_avo_qphist
            // 
            this.lb_avo_qphist.AutoSize = true;
            this.lb_avo_qphist.Location = new System.Drawing.Point(318, 151);
            this.lb_avo_qphist.Name = "lb_avo_qphist";
            this.lb_avo_qphist.Size = new System.Drawing.Size(38, 13);
            this.lb_avo_qphist.TabIndex = 85;
            this.lb_avo_qphist.Text = "-qphist";
            // 
            // tb_avo_vstats
            // 
            this.tb_avo_vstats.Location = new System.Drawing.Point(80, 174);
            this.tb_avo_vstats.Name = "tb_avo_vstats";
            this.tb_avo_vstats.Size = new System.Drawing.Size(166, 20);
            this.tb_avo_vstats.TabIndex = 84;
            // 
            // lb_avo_vstats
            // 
            this.lb_avo_vstats.AutoSize = true;
            this.lb_avo_vstats.Location = new System.Drawing.Point(36, 177);
            this.lb_avo_vstats.Name = "lb_avo_vstats";
            this.lb_avo_vstats.Size = new System.Drawing.Size(38, 13);
            this.lb_avo_vstats.TabIndex = 83;
            this.lb_avo_vstats.Text = "-vstats";
            // 
            // tb_avo_psnr
            // 
            this.tb_avo_psnr.Location = new System.Drawing.Point(80, 148);
            this.tb_avo_psnr.Name = "tb_avo_psnr";
            this.tb_avo_psnr.Size = new System.Drawing.Size(166, 20);
            this.tb_avo_psnr.TabIndex = 82;
            // 
            // lb_avo_psnr
            // 
            this.lb_avo_psnr.AutoSize = true;
            this.lb_avo_psnr.Location = new System.Drawing.Point(44, 151);
            this.lb_avo_psnr.Name = "lb_avo_psnr";
            this.lb_avo_psnr.Size = new System.Drawing.Size(30, 13);
            this.lb_avo_psnr.TabIndex = 81;
            this.lb_avo_psnr.Text = "-psnr";
            // 
            // tb_avo_ilme
            // 
            this.tb_avo_ilme.Location = new System.Drawing.Point(80, 122);
            this.tb_avo_ilme.Name = "tb_avo_ilme";
            this.tb_avo_ilme.Size = new System.Drawing.Size(166, 20);
            this.tb_avo_ilme.TabIndex = 80;
            // 
            // lb_avo_ilme
            // 
            this.lb_avo_ilme.AutoSize = true;
            this.lb_avo_ilme.Location = new System.Drawing.Point(46, 125);
            this.lb_avo_ilme.Name = "lb_avo_ilme";
            this.lb_avo_ilme.Size = new System.Drawing.Size(28, 13);
            this.lb_avo_ilme.TabIndex = 79;
            this.lb_avo_ilme.Text = "-ilme";
            // 
            // tb_avo_hwaccel_device
            // 
            this.tb_avo_hwaccel_device.Location = new System.Drawing.Point(121, 277);
            this.tb_avo_hwaccel_device.Name = "tb_avo_hwaccel_device";
            this.tb_avo_hwaccel_device.Size = new System.Drawing.Size(409, 20);
            this.tb_avo_hwaccel_device.TabIndex = 76;
            // 
            // lb_avo_hwaccel_device
            // 
            this.lb_avo_hwaccel_device.AutoSize = true;
            this.lb_avo_hwaccel_device.Location = new System.Drawing.Point(27, 280);
            this.lb_avo_hwaccel_device.Name = "lb_avo_hwaccel_device";
            this.lb_avo_hwaccel_device.Size = new System.Drawing.Size(88, 13);
            this.lb_avo_hwaccel_device.TabIndex = 75;
            this.lb_avo_hwaccel_device.Text = "-hwaccel_device";
            // 
            // tb_avo_hwaccel
            // 
            this.tb_avo_hwaccel.Location = new System.Drawing.Point(364, 97);
            this.tb_avo_hwaccel.Name = "tb_avo_hwaccel";
            this.tb_avo_hwaccel.Size = new System.Drawing.Size(166, 20);
            this.tb_avo_hwaccel.TabIndex = 74;
            // 
            // lb_avo_hwaccel
            // 
            this.lb_avo_hwaccel.AutoSize = true;
            this.lb_avo_hwaccel.Location = new System.Drawing.Point(306, 100);
            this.lb_avo_hwaccel.Name = "lb_avo_hwaccel";
            this.lb_avo_hwaccel.Size = new System.Drawing.Size(50, 13);
            this.lb_avo_hwaccel.TabIndex = 73;
            this.lb_avo_hwaccel.Text = "-hwaccel";
            // 
            // tb_avo_copyinkf
            // 
            this.tb_avo_copyinkf.Location = new System.Drawing.Point(364, 71);
            this.tb_avo_copyinkf.Name = "tb_avo_copyinkf";
            this.tb_avo_copyinkf.Size = new System.Drawing.Size(166, 20);
            this.tb_avo_copyinkf.TabIndex = 72;
            // 
            // lb_avo_copyinkf
            // 
            this.lb_avo_copyinkf.AutoSize = true;
            this.lb_avo_copyinkf.Location = new System.Drawing.Point(306, 74);
            this.lb_avo_copyinkf.Name = "lb_avo_copyinkf";
            this.lb_avo_copyinkf.Size = new System.Drawing.Size(50, 13);
            this.lb_avo_copyinkf.TabIndex = 71;
            this.lb_avo_copyinkf.Text = "-copyinkf";
            // 
            // tb_avo_vstats_file
            // 
            this.tb_avo_vstats_file.Location = new System.Drawing.Point(80, 200);
            this.tb_avo_vstats_file.Name = "tb_avo_vstats_file";
            this.tb_avo_vstats_file.Size = new System.Drawing.Size(166, 20);
            this.tb_avo_vstats_file.TabIndex = 64;
            // 
            // tb_avo_vtag
            // 
            this.tb_avo_vtag.Location = new System.Drawing.Point(364, 45);
            this.tb_avo_vtag.Name = "tb_avo_vtag";
            this.tb_avo_vtag.Size = new System.Drawing.Size(166, 20);
            this.tb_avo_vtag.TabIndex = 70;
            // 
            // lb_avo_vtag
            // 
            this.lb_avo_vtag.AutoSize = true;
            this.lb_avo_vtag.Location = new System.Drawing.Point(325, 48);
            this.lb_avo_vtag.Name = "lb_avo_vtag";
            this.lb_avo_vtag.Size = new System.Drawing.Size(31, 13);
            this.lb_avo_vtag.TabIndex = 69;
            this.lb_avo_vtag.Text = "-vtag";
            // 
            // tb_avo_dc
            // 
            this.tb_avo_dc.Location = new System.Drawing.Point(364, 19);
            this.tb_avo_dc.Name = "tb_avo_dc";
            this.tb_avo_dc.Size = new System.Drawing.Size(166, 20);
            this.tb_avo_dc.TabIndex = 68;
            // 
            // lb_avo_dc
            // 
            this.lb_avo_dc.AutoSize = true;
            this.lb_avo_dc.Location = new System.Drawing.Point(334, 22);
            this.lb_avo_dc.Name = "lb_avo_dc";
            this.lb_avo_dc.Size = new System.Drawing.Size(22, 13);
            this.lb_avo_dc.TabIndex = 67;
            this.lb_avo_dc.Text = "-dc";
            // 
            // tb_avo_top
            // 
            this.tb_avo_top.Location = new System.Drawing.Point(80, 226);
            this.tb_avo_top.Name = "tb_avo_top";
            this.tb_avo_top.Size = new System.Drawing.Size(166, 20);
            this.tb_avo_top.TabIndex = 66;
            // 
            // lb_avo_top
            // 
            this.lb_avo_top.AutoSize = true;
            this.lb_avo_top.Location = new System.Drawing.Point(49, 229);
            this.lb_avo_top.Name = "lb_avo_top";
            this.lb_avo_top.Size = new System.Drawing.Size(25, 13);
            this.lb_avo_top.TabIndex = 65;
            this.lb_avo_top.Text = "-top";
            // 
            // lb_avo_vstats_file
            // 
            this.lb_avo_vstats_file.AutoSize = true;
            this.lb_avo_vstats_file.Location = new System.Drawing.Point(17, 203);
            this.lb_avo_vstats_file.Name = "lb_avo_vstats_file";
            this.lb_avo_vstats_file.Size = new System.Drawing.Size(57, 13);
            this.lb_avo_vstats_file.TabIndex = 63;
            this.lb_avo_vstats_file.Text = "-vstats_file";
            // 
            // tb_avo_rc_override
            // 
            this.tb_avo_rc_override.Location = new System.Drawing.Point(80, 96);
            this.tb_avo_rc_override.Name = "tb_avo_rc_override";
            this.tb_avo_rc_override.Size = new System.Drawing.Size(166, 20);
            this.tb_avo_rc_override.TabIndex = 62;
            // 
            // lb_avo_rc_override
            // 
            this.lb_avo_rc_override.AutoSize = true;
            this.lb_avo_rc_override.Location = new System.Drawing.Point(11, 99);
            this.lb_avo_rc_override.Name = "lb_avo_rc_override";
            this.lb_avo_rc_override.Size = new System.Drawing.Size(63, 13);
            this.lb_avo_rc_override.TabIndex = 61;
            this.lb_avo_rc_override.Text = "-rc_override";
            // 
            // tb_avo_vdt
            // 
            this.tb_avo_vdt.Location = new System.Drawing.Point(80, 70);
            this.tb_avo_vdt.Name = "tb_avo_vdt";
            this.tb_avo_vdt.Size = new System.Drawing.Size(166, 20);
            this.tb_avo_vdt.TabIndex = 60;
            // 
            // lb_avo_vdt
            // 
            this.lb_avo_vdt.AutoSize = true;
            this.lb_avo_vdt.Location = new System.Drawing.Point(49, 73);
            this.lb_avo_vdt.Name = "lb_avo_vdt";
            this.lb_avo_vdt.Size = new System.Drawing.Size(25, 13);
            this.lb_avo_vdt.TabIndex = 59;
            this.lb_avo_vdt.Text = "-vdt";
            // 
            // tb_avo_sws_flags
            // 
            this.tb_avo_sws_flags.Location = new System.Drawing.Point(80, 44);
            this.tb_avo_sws_flags.Name = "tb_avo_sws_flags";
            this.tb_avo_sws_flags.Size = new System.Drawing.Size(166, 20);
            this.tb_avo_sws_flags.TabIndex = 58;
            // 
            // lb_avo_sws_flags
            // 
            this.lb_avo_sws_flags.AutoSize = true;
            this.lb_avo_sws_flags.Location = new System.Drawing.Point(18, 47);
            this.lb_avo_sws_flags.Name = "lb_avo_sws_flags";
            this.lb_avo_sws_flags.Size = new System.Drawing.Size(56, 13);
            this.lb_avo_sws_flags.TabIndex = 57;
            this.lb_avo_sws_flags.Text = "-sws_flags";
            // 
            // tb_avo_pix_fmt
            // 
            this.tb_avo_pix_fmt.Location = new System.Drawing.Point(80, 18);
            this.tb_avo_pix_fmt.Name = "tb_avo_pix_fmt";
            this.tb_avo_pix_fmt.Size = new System.Drawing.Size(166, 20);
            this.tb_avo_pix_fmt.TabIndex = 56;
            // 
            // lb_avo_pix_fmt
            // 
            this.lb_avo_pix_fmt.AutoSize = true;
            this.lb_avo_pix_fmt.Location = new System.Drawing.Point(31, 21);
            this.lb_avo_pix_fmt.Name = "lb_avo_pix_fmt";
            this.lb_avo_pix_fmt.Size = new System.Drawing.Size(43, 13);
            this.lb_avo_pix_fmt.TabIndex = 55;
            this.lb_avo_pix_fmt.Text = "-pix_fmt";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Controls.Add(this.groupBox8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(825, 322);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "   Audio   ";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tb_ao_af);
            this.groupBox7.Controls.Add(this.lb_ao_af);
            this.groupBox7.Controls.Add(this.tb_ao_sample_fmt);
            this.groupBox7.Controls.Add(this.lb_ao_sample_fmt);
            this.groupBox7.Controls.Add(this.tb_ao_acodec);
            this.groupBox7.Controls.Add(this.lb_ao_acodec);
            this.groupBox7.Controls.Add(this.tb_ao_an);
            this.groupBox7.Controls.Add(this.lb_ao_an);
            this.groupBox7.Controls.Add(this.tb_ao_ac);
            this.groupBox7.Controls.Add(this.lb_ao_ac);
            this.groupBox7.Controls.Add(this.tb_ao_aq);
            this.groupBox7.Controls.Add(this.lb_ao_aq);
            this.groupBox7.Controls.Add(this.tb_ao_ar);
            this.groupBox7.Controls.Add(this.lb_ao_ar);
            this.groupBox7.Controls.Add(this.tb_ao_aframes);
            this.groupBox7.Controls.Add(this.lv_ao_aframes);
            this.groupBox7.Location = new System.Drawing.Point(6, 10);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(813, 168);
            this.groupBox7.TabIndex = 38;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Audio Options";
            // 
            // tb_ao_af
            // 
            this.tb_ao_af.Location = new System.Drawing.Point(455, 111);
            this.tb_ao_af.Name = "tb_ao_af";
            this.tb_ao_af.Size = new System.Drawing.Size(286, 20);
            this.tb_ao_af.TabIndex = 112;
            // 
            // lb_ao_af
            // 
            this.lb_ao_af.AutoSize = true;
            this.lb_ao_af.Location = new System.Drawing.Point(430, 114);
            this.lb_ao_af.Name = "lb_ao_af";
            this.lb_ao_af.Size = new System.Drawing.Size(19, 13);
            this.lb_ao_af.TabIndex = 111;
            this.lb_ao_af.Text = "-af";
            // 
            // tb_ao_sample_fmt
            // 
            this.tb_ao_sample_fmt.Location = new System.Drawing.Point(106, 111);
            this.tb_ao_sample_fmt.Name = "tb_ao_sample_fmt";
            this.tb_ao_sample_fmt.Size = new System.Drawing.Size(286, 20);
            this.tb_ao_sample_fmt.TabIndex = 110;
            // 
            // lb_ao_sample_fmt
            // 
            this.lb_ao_sample_fmt.AutoSize = true;
            this.lb_ao_sample_fmt.Location = new System.Drawing.Point(37, 114);
            this.lb_ao_sample_fmt.Name = "lb_ao_sample_fmt";
            this.lb_ao_sample_fmt.Size = new System.Drawing.Size(63, 13);
            this.lb_ao_sample_fmt.TabIndex = 109;
            this.lb_ao_sample_fmt.Text = "-sample_fmt";
            // 
            // tb_ao_acodec
            // 
            this.tb_ao_acodec.Location = new System.Drawing.Point(455, 85);
            this.tb_ao_acodec.Name = "tb_ao_acodec";
            this.tb_ao_acodec.Size = new System.Drawing.Size(286, 20);
            this.tb_ao_acodec.TabIndex = 108;
            // 
            // lb_ao_acodec
            // 
            this.lb_ao_acodec.AutoSize = true;
            this.lb_ao_acodec.Location = new System.Drawing.Point(403, 88);
            this.lb_ao_acodec.Name = "lb_ao_acodec";
            this.lb_ao_acodec.Size = new System.Drawing.Size(46, 13);
            this.lb_ao_acodec.TabIndex = 107;
            this.lb_ao_acodec.Text = "-acodec";
            // 
            // tb_ao_an
            // 
            this.tb_ao_an.Location = new System.Drawing.Point(455, 59);
            this.tb_ao_an.Name = "tb_ao_an";
            this.tb_ao_an.Size = new System.Drawing.Size(286, 20);
            this.tb_ao_an.TabIndex = 106;
            // 
            // lb_ao_an
            // 
            this.lb_ao_an.AutoSize = true;
            this.lb_ao_an.Location = new System.Drawing.Point(427, 59);
            this.lb_ao_an.Name = "lb_ao_an";
            this.lb_ao_an.Size = new System.Drawing.Size(22, 13);
            this.lb_ao_an.TabIndex = 105;
            this.lb_ao_an.Text = "-an";
            // 
            // tb_ao_ac
            // 
            this.tb_ao_ac.Location = new System.Drawing.Point(455, 33);
            this.tb_ao_ac.Name = "tb_ao_ac";
            this.tb_ao_ac.Size = new System.Drawing.Size(286, 20);
            this.tb_ao_ac.TabIndex = 104;
            // 
            // lb_ao_ac
            // 
            this.lb_ao_ac.AutoSize = true;
            this.lb_ao_ac.Location = new System.Drawing.Point(427, 32);
            this.lb_ao_ac.Name = "lb_ao_ac";
            this.lb_ao_ac.Size = new System.Drawing.Size(22, 13);
            this.lb_ao_ac.TabIndex = 103;
            this.lb_ao_ac.Text = "-ac";
            // 
            // tb_ao_aq
            // 
            this.tb_ao_aq.Location = new System.Drawing.Point(106, 85);
            this.tb_ao_aq.Name = "tb_ao_aq";
            this.tb_ao_aq.Size = new System.Drawing.Size(286, 20);
            this.tb_ao_aq.TabIndex = 102;
            // 
            // lb_ao_aq
            // 
            this.lb_ao_aq.AutoSize = true;
            this.lb_ao_aq.Location = new System.Drawing.Point(78, 88);
            this.lb_ao_aq.Name = "lb_ao_aq";
            this.lb_ao_aq.Size = new System.Drawing.Size(22, 13);
            this.lb_ao_aq.TabIndex = 101;
            this.lb_ao_aq.Text = "-aq";
            // 
            // tb_ao_ar
            // 
            this.tb_ao_ar.Location = new System.Drawing.Point(106, 59);
            this.tb_ao_ar.Name = "tb_ao_ar";
            this.tb_ao_ar.Size = new System.Drawing.Size(286, 20);
            this.tb_ao_ar.TabIndex = 100;
            // 
            // lb_ao_ar
            // 
            this.lb_ao_ar.AutoSize = true;
            this.lb_ao_ar.Location = new System.Drawing.Point(81, 62);
            this.lb_ao_ar.Name = "lb_ao_ar";
            this.lb_ao_ar.Size = new System.Drawing.Size(19, 13);
            this.lb_ao_ar.TabIndex = 99;
            this.lb_ao_ar.Text = "-ar";
            // 
            // tb_ao_aframes
            // 
            this.tb_ao_aframes.Location = new System.Drawing.Point(106, 33);
            this.tb_ao_aframes.Name = "tb_ao_aframes";
            this.tb_ao_aframes.Size = new System.Drawing.Size(286, 20);
            this.tb_ao_aframes.TabIndex = 98;
            // 
            // lv_ao_aframes
            // 
            this.lv_ao_aframes.AutoSize = true;
            this.lv_ao_aframes.Location = new System.Drawing.Point(53, 36);
            this.lv_ao_aframes.Name = "lv_ao_aframes";
            this.lv_ao_aframes.Size = new System.Drawing.Size(47, 13);
            this.lv_ao_aframes.TabIndex = 97;
            this.lv_ao_aframes.Text = "-aframes";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.tb_aao_guess_layout_max);
            this.groupBox8.Controls.Add(this.lb_aao_guess_layout_max);
            this.groupBox8.Controls.Add(this.tb_aao_absf);
            this.groupBox8.Controls.Add(this.lb_aao_absf);
            this.groupBox8.Controls.Add(this.tb_aao_atag);
            this.groupBox8.Controls.Add(this.lb_aao_atag);
            this.groupBox8.Location = new System.Drawing.Point(6, 186);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(813, 130);
            this.groupBox8.TabIndex = 39;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Advanced Audio options";
            // 
            // tb_aao_guess_layout_max
            // 
            this.tb_aao_guess_layout_max.Location = new System.Drawing.Point(123, 82);
            this.tb_aao_guess_layout_max.Name = "tb_aao_guess_layout_max";
            this.tb_aao_guess_layout_max.Size = new System.Drawing.Size(618, 20);
            this.tb_aao_guess_layout_max.TabIndex = 118;
            // 
            // lb_aao_guess_layout_max
            // 
            this.lb_aao_guess_layout_max.AutoSize = true;
            this.lb_aao_guess_layout_max.Location = new System.Drawing.Point(19, 85);
            this.lb_aao_guess_layout_max.Name = "lb_aao_guess_layout_max";
            this.lb_aao_guess_layout_max.Size = new System.Drawing.Size(97, 13);
            this.lb_aao_guess_layout_max.TabIndex = 117;
            this.lb_aao_guess_layout_max.Text = "-guess_layout_max";
            // 
            // tb_aao_absf
            // 
            this.tb_aao_absf.Location = new System.Drawing.Point(123, 56);
            this.tb_aao_absf.Name = "tb_aao_absf";
            this.tb_aao_absf.Size = new System.Drawing.Size(618, 20);
            this.tb_aao_absf.TabIndex = 116;
            // 
            // lb_aao_absf
            // 
            this.lb_aao_absf.AutoSize = true;
            this.lb_aao_absf.Location = new System.Drawing.Point(86, 59);
            this.lb_aao_absf.Name = "lb_aao_absf";
            this.lb_aao_absf.Size = new System.Drawing.Size(30, 13);
            this.lb_aao_absf.TabIndex = 115;
            this.lb_aao_absf.Text = "-absf";
            // 
            // tb_aao_atag
            // 
            this.tb_aao_atag.Location = new System.Drawing.Point(123, 30);
            this.tb_aao_atag.Name = "tb_aao_atag";
            this.tb_aao_atag.Size = new System.Drawing.Size(618, 20);
            this.tb_aao_atag.TabIndex = 114;
            // 
            // lb_aao_atag
            // 
            this.lb_aao_atag.AutoSize = true;
            this.lb_aao_atag.Location = new System.Drawing.Point(85, 33);
            this.lb_aao_atag.Name = "lb_aao_atag";
            this.lb_aao_atag.Size = new System.Drawing.Size(31, 13);
            this.lb_aao_atag.TabIndex = 113;
            this.lb_aao_atag.Text = "-atag";
            // 
            // lb_videoBitrate
            // 
            this.lb_videoBitrate.AutoSize = true;
            this.lb_videoBitrate.Location = new System.Drawing.Point(208, 16);
            this.lb_videoBitrate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_videoBitrate.Name = "lb_videoBitrate";
            this.lb_videoBitrate.Size = new System.Drawing.Size(65, 13);
            this.lb_videoBitrate.TabIndex = 33;
            this.lb_videoBitrate.Text = "video bitrate";
            // 
            // cb_VideoBitrate
            // 
            this.cb_VideoBitrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_VideoBitrate.FormattingEnabled = true;
            this.cb_VideoBitrate.Location = new System.Drawing.Point(278, 13);
            this.cb_VideoBitrate.Name = "cb_VideoBitrate";
            this.cb_VideoBitrate.Size = new System.Drawing.Size(134, 21);
            this.cb_VideoBitrate.TabIndex = 36;
            // 
            // lb_audioBitrate
            // 
            this.lb_audioBitrate.AutoSize = true;
            this.lb_audioBitrate.Location = new System.Drawing.Point(437, 16);
            this.lb_audioBitrate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_audioBitrate.Name = "lb_audioBitrate";
            this.lb_audioBitrate.Size = new System.Drawing.Size(65, 13);
            this.lb_audioBitrate.TabIndex = 34;
            this.lb_audioBitrate.Text = "audio bitrate";
            // 
            // cb_AudioBitrate
            // 
            this.cb_AudioBitrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_AudioBitrate.FormattingEnabled = true;
            this.cb_AudioBitrate.Location = new System.Drawing.Point(507, 13);
            this.cb_AudioBitrate.Name = "cb_AudioBitrate";
            this.cb_AudioBitrate.Size = new System.Drawing.Size(134, 21);
            this.cb_AudioBitrate.TabIndex = 35;
            // 
            // lb_configNames
            // 
            this.lb_configNames.FormattingEnabled = true;
            this.lb_configNames.Location = new System.Drawing.Point(639, 7);
            this.lb_configNames.Name = "lb_configNames";
            this.lb_configNames.ScrollAlwaysVisible = true;
            this.lb_configNames.Size = new System.Drawing.Size(195, 69);
            this.lb_configNames.TabIndex = 63;
            this.lb_configNames.SelectedValueChanged += new System.EventHandler(this.lb_configNames_SelectedValueChanged);
            // 
            // btn_AddConfig
            // 
            this.btn_AddConfig.BackgroundImage = global::BroadcasterTest.Properties.Resources.Add_icon;
            this.btn_AddConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_AddConfig.Location = new System.Drawing.Point(639, 81);
            this.btn_AddConfig.Name = "btn_AddConfig";
            this.btn_AddConfig.Size = new System.Drawing.Size(35, 23);
            this.btn_AddConfig.TabIndex = 64;
            this.btn_AddConfig.UseVisualStyleBackColor = true;
            this.btn_AddConfig.Click += new System.EventHandler(this.btn_AddConfig_Click);
            // 
            // btn_CloneConfig
            // 
            this.btn_CloneConfig.BackgroundImage = global::BroadcasterTest.Properties.Resources.Copy_icon;
            this.btn_CloneConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_CloneConfig.Location = new System.Drawing.Point(679, 81);
            this.btn_CloneConfig.Name = "btn_CloneConfig";
            this.btn_CloneConfig.Size = new System.Drawing.Size(35, 23);
            this.btn_CloneConfig.TabIndex = 65;
            this.btn_CloneConfig.UseVisualStyleBackColor = true;
            this.btn_CloneConfig.Click += new System.EventHandler(this.btn_CloneConfig_Click);
            // 
            // btn_UpdateConfig
            // 
            this.btn_UpdateConfig.BackgroundImage = global::BroadcasterTest.Properties.Resources.Save_icon;
            this.btn_UpdateConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_UpdateConfig.Location = new System.Drawing.Point(720, 81);
            this.btn_UpdateConfig.Name = "btn_UpdateConfig";
            this.btn_UpdateConfig.Size = new System.Drawing.Size(35, 23);
            this.btn_UpdateConfig.TabIndex = 66;
            this.btn_UpdateConfig.UseVisualStyleBackColor = true;
            this.btn_UpdateConfig.Click += new System.EventHandler(this.btn_UpdateConfig_Click);
            // 
            // btn_RenameConfig
            // 
            this.btn_RenameConfig.BackgroundImage = global::BroadcasterTest.Properties.Resources.Edit_icon;
            this.btn_RenameConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_RenameConfig.Location = new System.Drawing.Point(759, 81);
            this.btn_RenameConfig.Name = "btn_RenameConfig";
            this.btn_RenameConfig.Size = new System.Drawing.Size(35, 23);
            this.btn_RenameConfig.TabIndex = 67;
            this.btn_RenameConfig.UseVisualStyleBackColor = true;
            this.btn_RenameConfig.Click += new System.EventHandler(this.btn_RenameConfig_Click);
            // 
            // btn_RemoveConfig
            // 
            this.btn_RemoveConfig.BackgroundImage = global::BroadcasterTest.Properties.Resources.Delete_icon;
            this.btn_RemoveConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_RemoveConfig.Location = new System.Drawing.Point(800, 81);
            this.btn_RemoveConfig.Name = "btn_RemoveConfig";
            this.btn_RemoveConfig.Size = new System.Drawing.Size(35, 23);
            this.btn_RemoveConfig.TabIndex = 68;
            this.btn_RemoveConfig.UseVisualStyleBackColor = true;
            this.btn_RemoveConfig.Click += new System.EventHandler(this.btn_RemoveConfig_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btn_Start;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Stop;
            this.ClientSize = new System.Drawing.Size(874, 445);
            this.Controls.Add(this.tc_main);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "PENTESTIT BLOADCASTER";
            this.tc_main.ResumeLayout(false);
            this.tp_Main.ResumeLayout(false);
            this.tp_Main.PerformLayout();
            this.tp_Options.ResumeLayout(false);
            this.tp_Options.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_MicrophoneVolume)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tp_QualitySettings.ResumeLayout(false);
            this.tp_QualitySettings.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Start;
        private Button btn_Stop;
        private TextBox tb_LogOutput;
        private Label label1;
        private Button btn_Kill_FFMPEG_Process;
        private Label label5;
        private Label label16;
        private TextBox tb_FFMPEG_LogOutput;
        private Label label19;
        private TabControl tc_main;
        private TabPage tp_Main;
        private TabPage tp_Options;
        private GroupBox groupBox4;
        private Label label2;
        private TextBox tb_FFMPEG_Path;
        private TextBox tb_FFMPEG_Args;
        private Label label3;
        private TrackBar trb_MicrophoneVolume;
        private Label label18;
        private Button btn_GetAvailableDevs;
        private Label label17;
        private GroupBox groupBox3;
        private RadioButton rb_UseTitle;
        private RadioButton rb_UseIntPtr;
        private ComboBox cb_AudioInput;
        private Label label20;
        private Button btn_FindOpenWindows;
        private ComboBox cb_VideoInput;
        private Label videoDeviceInput;
        private ComboBox cb_OpenedWindows;
        private Label audioDeviceInput;
        private Label label11;
        private GroupBox groupBox1;
        private TextBox tb_SaveToFile;
        private Label label6;
        private GroupBox groupBox2;
        private TextBox tb_Stream_Url;
        private Label label4;
        private TextBox tb_StreamKey;
        private Label label8;
        private GroupBox groupBox5;
        private TabPage tp_QualitySettings;
        private Label lb_videoBitrate;
        private Label lb_audioBitrate;
        private Label label7;
        private ComboBox cb_AudioBitrate;
        private ComboBox cb_VideoBitrate;
        private GroupBox groupBox9;
        private GroupBox groupBox8;
        private GroupBox groupBox7;
        private GroupBox groupBox6;
        private TextBox tb_vo_vframes;
        private Label lb_vframes;
        private TextBox tb_vo_r;
        private Label lb_vo_r;
        private TextBox tb_vo_pass;
        private Label lb_vo_pass;
        private TextBox tb_vo_vcodec;
        private Label lb_vo_vcodec;
        private TextBox tb_vo_vn;
        private Label lb_vo_vn;
        private TextBox tb_vo_aspect;
        private Label lb_vo_aspect;
        private TextBox tb_vo_s;
        private Label lb_vo_s;
        private TextBox tb_vo_passlogfile;
        private Label lb_vo_passlogfile;
        private TextBox tb_vo_vf;
        private Label lb_vo_vf;
        private TextBox tb_avo_pix_fmt;
        private Label lb_avo_pix_fmt;
        private TextBox tb_avo_sws_flags;
        private Label lb_avo_sws_flags;
        private TextBox tb_avo_force_key_frames;
        private Label lb_avo_force_key_frames;
        private TextBox tb_avo_vbsf;
        private Label lb_avo_vbsf;
        private TextBox tb_avo_qphist;
        private Label lb_avo_qphist;
        private TextBox tb_avo_vstats;
        private Label lb_avo_vstats;
        private TextBox tb_avo_psnr;
        private Label lb_avo_psnr;
        private TextBox tb_avo_ilme;
        private Label lb_avo_ilme;
        private TextBox tb_avo_hwaccel_device;
        private Label lb_avo_hwaccel_device;
        private TextBox tb_avo_hwaccel;
        private Label lb_avo_hwaccel;
        private TextBox tb_avo_copyinkf;
        private Label lb_avo_copyinkf;
        private TextBox tb_avo_vtag;
        private Label lb_avo_vtag;
        private TextBox tb_avo_dc;
        private Label lb_avo_dc;
        private TextBox tb_avo_top;
        private Label lb_avo_top;
        private TextBox tb_avo_vstats_file;
        private Label lb_avo_vstats_file;
        private TextBox tb_avo_rc_override;
        private Label lb_avo_rc_override;
        private TextBox tb_avo_vdt;
        private Label lb_avo_vdt;
        private TextBox tb_ao_aframes;
        private Label lv_ao_aframes;
        private TextBox tb_ao_acodec;
        private Label lb_ao_acodec;
        private TextBox tb_ao_an;
        private Label lb_ao_an;
        private TextBox tb_ao_ac;
        private Label lb_ao_ac;
        private TextBox tb_ao_aq;
        private Label lb_ao_aq;
        private TextBox tb_ao_ar;
        private Label lb_ao_ar;
        private TextBox tb_ao_af;
        private Label lb_ao_af;
        private TextBox tb_ao_sample_fmt;
        private Label lb_ao_sample_fmt;
        private TextBox tb_aao_guess_layout_max;
        private Label lb_aao_guess_layout_max;
        private TextBox tb_aao_absf;
        private Label lb_aao_absf;
        private TextBox tb_aao_atag;
        private Label lb_aao_atag;
        private Label label9;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListBox lb_configNames;
        private Button btn_RenameConfig;
        private Button btn_UpdateConfig;
        private Button btn_CloneConfig;
        private Button btn_AddConfig;
        private Button btn_RemoveConfig;
    }
}

