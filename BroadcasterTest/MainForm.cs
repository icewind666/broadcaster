using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BroadcasterTest.Enums;
using BroadcasterTest.Interfaces;

namespace BroadcasterTest
{
    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
            this.AddToolTipsToControls();
        }

        #region MainFormEvents

        private void btn_GetAvailableDevs_Click( object sender, EventArgs e )
        {
            InvokeEvent( this.GetAvailableDevicesEventHandler );
        }

        private void btn_Start_Click( object sender, EventArgs e )
        {
            this.tb_LogOutput.Clear();
            InvokeEvent( this.StartEventHandler );
        }

        private void btn_Stop_Click( object sender, EventArgs e )
        {
            InvokeEvent( this.StopEventHandler );
        }

        private void btn_Kill_FFMPEG_Process_Click( object sender, EventArgs e )
        {
            InvokeEvent( this.KillFfmpegProcessEventHandler );
        }

        private void trb_MicrophoneVolume_Scroll( object sender, EventArgs e )
        {
            InvokeEvent( this.MicrophoneVolumeChangeEventHandler );
        }

        private void cb_AudioInput_SelectedIndexChanged( object sender, EventArgs e )
        {
            InvokeEvent( this.AudioInputChangeEventHandler );
        }

        private void btn_FindOpenWindows_Click( object sender, EventArgs e )
        {
            InvokeEvent( this.CaptreWindowEventHander );
        }

        private void btn_AddConfig_Click( object sender, EventArgs e )
        {
            InvokeEvent( this.AddNewConfig );
        }

        private void btn_CloneConfig_Click( object sender, EventArgs e )
        {
            InvokeEvent( this.CloneConfig );
        }

        private void btn_UpdateConfig_Click( object sender, EventArgs e )
        {
            InvokeEvent( this.UpdateConfig );
        }

        private void btn_RenameConfig_Click( object sender, EventArgs e )
        {
            InvokeEvent( this.RenameConfig );
        }

        private void btn_RemoveConfig_Click( object sender, EventArgs e )
        {
            InvokeEvent( this.RemoveConfig );
        }

        private void lb_configNames_SelectedValueChanged( object sender, EventArgs e )
        {
            InvokeEvent( this.SelectedConfigChanged );
        }

        #endregion

        #region IMainForm

        public event EventHandler AddNewConfig;
        public event EventHandler CloneConfig;
        public event EventHandler UpdateConfig;
        public event EventHandler RenameConfig;
        public event EventHandler RemoveConfig;
        public event EventHandler SelectedConfigChanged;
        public event EventHandler GetAvailableDevicesEventHandler;
        public event EventHandler StartEventHandler;
        public event EventHandler StopEventHandler;
        public event EventHandler KillFfmpegProcessEventHandler;
        public event EventHandler MicrophoneVolumeChangeEventHandler;
        public event EventHandler AudioInputChangeEventHandler;
        public event EventHandler CaptreWindowEventHander;
        public event EventHandler OnLoadEventHandler;

        public string CurrentConfigName
        {
            get { return this.lb_configNames.SelectedValue as string; }
        }

        public string FfmpegPath
        {
            get { return this.tb_FFMPEG_Path.Text; }
            set { this.tb_FFMPEG_Path.Text = value; }
        }
        public string FfmpegArgs
        {
            get { return this.tb_FFMPEG_Args.Text; }
            set { this.tb_FFMPEG_Args.Text = value; }
        }
        public string SaveToFile
        {
            get { return this.tb_SaveToFile.Text; }
            set { this.tb_SaveToFile.Text = value; }
        }
        public string StreamUrl
        {
            get { return this.tb_Stream_Url.Text; }
            set { this.tb_Stream_Url.Text = value; }
        }
        public string StreamKey
        {
            get { return this.tb_StreamKey.Text; }
            set { this.tb_StreamKey.Text = value; }
        }

        #region VideoOptions

        public void SetVideoBitrate( IEnumerable<string> videoBitrate )
        {
            this.cb_VideoBitrate.DataSource = videoBitrate;
        }
        public string GetVideoBitrate
        {
            get { return this.cb_VideoBitrate.SelectedItem.ToString(); }
        }
        public void SelectVideoBitrate( string videoBitrate )
        {
            if ( videoBitrate != null )
            {
                this.cb_VideoBitrate.SelectedItem = videoBitrate;

            }
        }

        public string VoVframes
        {
            get { return this.tb_vo_vframes.Text; }
            set { this.tb_vo_vframes.Text = value; }
        }
        public string VoR
        {
            get { return this.tb_vo_r.Text; }
            set { this.tb_vo_r.Text = value; }
        }
        public string VoS
        {
            get { return this.tb_vo_s.Text; }
            set { this.tb_vo_s.Text = value; }
        }
        public string VoAspect
        {
            get { return this.tb_vo_aspect.Text; }
            set { this.tb_vo_aspect.Text = value; }
        }
        public string VoVn
        {
            get { return this.tb_vo_vn.Text; }
            set { this.tb_vo_vn.Text = value; }
        }
        public string VoVcodec
        {
            get { return this.tb_vo_vcodec.Text; }
            set { this.tb_vo_vcodec.Text = value; }
        }
        public string VoPass
        {
            get { return this.tb_vo_pass.Text; }
            set { this.tb_vo_pass.Text = value; }
        }
        public string VoPasslogfile
        {
            get { return this.tb_vo_passlogfile.Text; }
            set { this.tb_vo_passlogfile.Text = value; }
        }
        public string VoVf
        {
            get { return this.tb_vo_vf.Text; }
            set { this.tb_vo_vf.Text = value; }
        }

        #endregion VideOptions

        #region AdvancedVideoOptions

        public string AvoPixFmt
        {
            get { return this.tb_avo_pix_fmt.Text; }
            set { this.tb_avo_pix_fmt.Text = value; }
        }
        public string AvoSwsFlags
        {
            get { return this.tb_avo_sws_flags.Text; }
            set { this.tb_avo_sws_flags.Text = value; }
        }
        public string AvoVdt
        {
            get { return this.tb_avo_vdt.Text; }
            set { this.tb_avo_vdt.Text = value; }
        }
        public string AvoRcOverride
        {
            get { return this.tb_avo_rc_override.Text; }
            set { this.tb_avo_rc_override.Text = value; }
        }
        public string AvoIlme
        {
            get { return this.tb_avo_ilme.Text; }
            set { this.tb_avo_ilme.Text = value; }
        }
        public string AvoPsnr
        {
            get { return this.tb_avo_psnr.Text; }
            set { this.tb_avo_psnr.Text = value; }
        }
        public string AvoVstats
        {
            get { return this.tb_avo_vstats.Text; }
            set { this.tb_avo_vstats.Text = value; }
        }
        public string AvoVstatsFile
        {
            get { return this.tb_avo_vstats_file.Text; }
            set { this.tb_avo_vstats_file.Text = value; }
        }
        public string AvoTop
        {
            get { return this.tb_avo_top.Text; }
            set { this.tb_avo_top.Text = value; }
        }
        public string AvoDc
        {
            get { return this.tb_avo_dc.Text; }
            set { this.tb_avo_dc.Text = value; }
        }
        public string AvoVtag
        {
            get { return this.tb_avo_vtag.Text; }
            set { this.tb_avo_vtag.Text = value; }
        }
        public string AvoQphist
        {
            get { return this.tb_avo_qphist.Text; }
            set { this.tb_avo_qphist.Text = value; }
        }
        public string AvoVbsf
        {
            get { return this.tb_avo_vbsf.Text; }
            set { this.tb_avo_vbsf.Text = value; }
        }
        public string AvoForceKeyFrames
        {
            get { return this.tb_avo_force_key_frames.Text; }
            set { this.tb_avo_force_key_frames.Text = value; }
        }
        public string AvoCopyinkf
        {
            get { return this.tb_avo_copyinkf.Text; }
            set { this.tb_avo_copyinkf.Text = value; }
        }
        public string AvoHwaccel
        {
            get { return this.tb_avo_hwaccel.Text; }
            set { this.tb_avo_hwaccel.Text = value; }
        }
        public string AvoHwaccelDevice
        {
            get { return this.tb_avo_hwaccel_device.Text; }
            set { this.tb_avo_hwaccel_device.Text = value; }
        }

        #endregion AdvancedVideoOptions

        #region AudioOptions

        public void SetAudioBitrate( IEnumerable<string> audioBitrate )
        {
            this.cb_AudioBitrate.DataSource = audioBitrate;
        }
        public string GetAudioBitrate
        {
            get { return this.cb_AudioBitrate.SelectedItem.ToString(); }
        }
        public void SelectAudioBitrate( string audioBitrate )
        {
            if ( audioBitrate != null )
            {
                this.cb_AudioBitrate.SelectedItem = audioBitrate;
            }
        }

        public string AoAframes
        {
            get { return this.tb_ao_aframes.Text; }
            set { this.tb_ao_aframes.Text = value; }
        }
        public string AoAr
        {
            get { return this.tb_ao_ar.Text; }
            set { this.tb_ao_ar.Text = value; }
        }
        public string AoAq
        {
            get { return this.tb_ao_aq.Text; }
            set { this.tb_ao_aq.Text = value; }
        }
        public string AoAc
        {
            get { return this.tb_ao_ac.Text; }
            set { this.tb_ao_ac.Text = value; }
        }
        public string AoAn
        {
            get { return this.tb_ao_an.Text; }
            set { this.tb_ao_an.Text = value; }
        }
        public string AoAcodec
        {
            get { return this.tb_ao_acodec.Text; }
            set { this.tb_ao_acodec.Text = value; }
        }
        public string AoSampleFmt
        {
            get { return this.tb_ao_sample_fmt.Text; }
            set { this.tb_ao_sample_fmt.Text = value; }
        }
        public string AoAf
        {
            get { return this.tb_ao_af.Text; }
            set { this.tb_ao_af.Text = value; }
        }

        #endregion AudioOptions

        #region AdvancedAudioOptions

        public string AaoAtag
        {
            get { return this.tb_aao_atag.Text; }
            set { this.tb_aao_atag.Text = value; }
        }
        public string AaoAbsf
        {
            get { return this.tb_aao_absf.Text; }
            set { this.tb_aao_absf.Text = value; }
        }
        public string AaoGuessLayoutMax
        {
            get { return this.tb_aao_guess_layout_max.Text; }
            set { this.tb_aao_guess_layout_max.Text = value; }
        }

        #endregion AdvancedAudioOptions

        public void WriteToMainLog( string logMessage )
        {
            if ( this.tb_LogOutput.InvokeRequired )
            {
                this.tb_LogOutput.Invoke( new Action( () => { this.tb_LogOutput.AppendText( logMessage + Environment.NewLine ); } ) );
            }
            else
            {
                this.tb_LogOutput.AppendText( logMessage + Environment.NewLine );
            }
        }
        public void WriteToFfmpegLog( string logMessage )
        {
            if ( this.tb_FFMPEG_LogOutput.InvokeRequired )
            {
                this.tb_FFMPEG_LogOutput.Invoke( new Action( () =>
                {
                    this.tb_FFMPEG_LogOutput.AppendText( logMessage + Environment.NewLine );
                } ) );
            }
            else
            {
                this.tb_FFMPEG_LogOutput.AppendText( logMessage + Environment.NewLine );
            }
        }
        public string GetVideoInput
        {
            get { return this.cb_VideoInput.SelectedValue as string; }
        }
        public string GetAduioInput
        {
            get { return this.cb_AudioInput.SelectedValue as string; }
        }
        public IntPtr GetWindowTitleIntPtr
        {
            get
            {
                if ( this.cb_OpenedWindows.SelectedValue != null )
                {
                    return ( IntPtr ) this.cb_OpenedWindows.SelectedValue;
                }
                else
                {
                    return IntPtr.Zero;
                }
            }
        }
        public string GetWindowTitleName
        {
            get
            {
                if ( this.cb_OpenedWindows.SelectedItem != null )
                {
                    return ( ( KeyValuePair<IntPtr, string> ) this.cb_OpenedWindows.SelectedItem ).Value;
                }
                else
                {
                    return string.Empty;
                }
            }
        }
        public int MicrophoneVolume
        {
            get { return this.trb_MicrophoneVolume.Value; }
            set { this.trb_MicrophoneVolume.Value = value; }
        }
        public WindowCaptureType GetWindowCaptureType
        {
            get { return ( this.rb_UseIntPtr.Checked ) ? WindowCaptureType.VfCrop : WindowCaptureType.Title; }
        }
        public void SetVideoInput( Dictionary<string, string> videoInput )
        {
            if ( videoInput == null ) { return; }
            this.cb_VideoInput.DataSource = new BindingSource( videoInput, null );
            this.cb_VideoInput.DisplayMember = "Value";
            this.cb_VideoInput.ValueMember = "Key";
        }
        public void SetAudioInput( Dictionary<string, string> audioInput )
        {
            if ( audioInput == null ) { return; }
            this.cb_AudioInput.DataSource = new BindingSource( audioInput, null );
            this.cb_AudioInput.DisplayMember = "Value";
            this.cb_AudioInput.ValueMember = "Key";
        }
        public void SetOpenedWindows( Dictionary<IntPtr, string> openedWindows )
        {
            if ( openedWindows == null ) { return; }
            this.cb_OpenedWindows.DataSource = new BindingSource( openedWindows, null );
            this.cb_OpenedWindows.DisplayMember = "Value";
            this.cb_OpenedWindows.ValueMember = "Key";
        }
        public void SetConfigNames( IEnumerable<string> names )
        {
            if ( names.Count() >= 1 )
            {
                this.lb_configNames.DataSource = new BindingSource( names, null );
            }
            else
            {
                this.lb_configNames.DataSource = null;
            }
        }
        public void StartButtonAvailability( bool enable )
        {
            this.btn_Start.Enabled = enable;
        }
        public void StopButtonAvailability( bool enable )
        {
            this.btn_Stop.Enabled = enable;
        }
        public void KillFfmpegButtonAvailability( bool enable )
        {
            this.btn_Kill_FFMPEG_Process.Enabled = enable;
        }

        #endregion

        #region Override

        protected override void OnFormClosing( FormClosingEventArgs e )
        {
            this.btn_Kill_FFMPEG_Process_Click( null, null );
            base.OnFormClosing( e );
        }

        protected override void OnLoad( EventArgs e )
        {
            InvokeEvent( this.OnLoadEventHandler );
            base.OnLoad( e );
        }

        #endregion

        private void AddToolTipsToControls()
        {
            SetTooltipToControl( this.rb_UseTitle, @"Video source will be replaced." );
            SetTooltipToControl( this.tb_SaveToFile, @"If only the file name, it will be created in path of the application." );

            SetTooltipToControl( this.btn_AddConfig, @"Add config." );
            SetTooltipToControl( this.btn_CloneConfig, @"Clone config." );
            SetTooltipToControl( this.btn_UpdateConfig, @"Save config." );
            SetTooltipToControl( this.btn_RenameConfig, @"Rename config." );
            SetTooltipToControl( this.btn_RemoveConfig, @"Remove config." );

            #region Video Options
            SetTooltipToControl( this.tb_vo_vframes, @"Set the number of video frames to output." );
            SetTooltipToControl( this.tb_vo_r,
                @"-r[:stream_specifier] fps (input/output,per-stream)
Set frame rate (Hz value, fraction or abbreviation). As an input option, ignore any timestamps stored in the file and instead generate timestamps assuming constant frame rate fps.
This is not the same as the -framerate option used for some input formats like image2 or v4l2 (it used to be the same in older versions of FFmpeg).
If in doubt use -framerate instead of the input option -r." );
            SetTooltipToControl( this.tb_vo_s, @"-s[:stream_specifier] size (input/output,per-stream)
Set frame size.
As an input option, this is a shortcut for the video_size private option, recognized by some demuxers for which the frame size is either not stored in the file or is configurable – e.g. raw video or video grabbers.
As an output option, this inserts the scale video filter to the end of the corresponding filtergraph. Please use the scale filter directly to insert it at the beginning or some other place.
The format is ‘wxh’ (default - same as source)." );
            SetTooltipToControl( this.tb_vo_aspect, @"-aspect[:stream_specifier] aspect (output,per-stream)
Set the video display aspect ratio specified by aspect.
aspect can be a floating point number string, or a string of the form num:den, where num and den are the numerator and denominator of the aspect ratio. For example '4:3', '16:9', '1.3333', and '1.7777' are valid argument values.
If used together with - vcodec copy, it will affect the aspect ratio stored at container level, but not the aspect ratio stored in encoded frames, if it exists." );
            SetTooltipToControl( this.tb_vo_vn, @"-vn (output)
Disable video recording." );
            SetTooltipToControl( this.tb_vo_vcodec, @"-vcodec codec (output)
Set the video codec." );
            SetTooltipToControl( this.tb_vo_pass, @"-pass[:stream_specifier] n (output,per-stream)
Select the pass number (1 or 2). It is used to do two-pass video encoding.
The statistics of the video are recorded in the first pass into a log file (see also the option -passlogfile), and in the second pass that log file is used to generate the video at the exact requested bitrate.
On pass 1, you may just deactivate audio and set output to null, examples for Windows and Unix:

ffmpeg -i foo.mov -c:v libxvid -pass 1 -an -f rawvideo -y NUL
ffmpeg -i foo.mov -c:v libxvid -pass 1 -an -f rawvideo -y /dev/null" );
            SetTooltipToControl( this.tb_vo_passlogfile, @"-passlogfile[:stream_specifier] prefix (output,per-stream)
Set two-pass log file name prefix to prefix, the default file name prefix is “ffmpeg2pass”.
The complete file name will be PREFIX-N.log, where N is a number specific to the output stream" );
            SetTooltipToControl( this.tb_vo_vf, @"-vf filtergraph (output)
Create the filtergraph specified by filtergraph and use it to filter the stream." );
            #endregion

            #region Advanced Video options
            SetTooltipToControl( this.tb_avo_pix_fmt, @"-pix_fmt[:stream_specifier] format (input/output,per-stream)
Set pixel format. Use -pix_fmts to show all the supported pixel formats.
If the selected pixel format can not be selected, ffmpeg will print a warning and select the best pixel format supported by the encoder.
If pix_fmt is prefixed by a +, ffmpeg will exit with an error if the requested pixel format can not be selected, and automatic conversions inside filtergraphs are disabled.
If pix_fmt is a single +, ffmpeg selects the same pixel format as the input (or graph output) and automatic conversions are disabled." );
            SetTooltipToControl( this.tb_avo_sws_flags, @"-sws_flags flags (input/output)
Set SwScaler flags." );
            SetTooltipToControl( this.tb_avo_vdt, @"-vdt n
Discard threshold." );
            SetTooltipToControl( this.tb_avo_rc_override, @"-rc_override[:stream_specifier] override (output,per-stream)
Rate control override for specific intervals, formatted as 'int, int, int' list separated with slashes.
Two first values are the beginning and end frame numbers, last one is quantizer to use if positive, or quality factor if negative." );
            SetTooltipToControl( this.tb_avo_ilme, @"-ilme
Force interlacing support in encoder (MPEG-2 and MPEG-4 only). Use this option if your input file is interlaced and you want to keep the interlaced format for minimum losses.
The alternative is to deinterlace the input stream with -deinterlace, but deinterlacing introduces losses." );
            SetTooltipToControl( this.tb_avo_psnr, @"-psnr
Calculate PSNR of compressed frames." );
            SetTooltipToControl( this.tb_avo_vstats, @"-vstats
Dump video coding statistics to vstats_HHMMSS.log." );
            SetTooltipToControl( tb_avo_vstats_file, @"-vstats_file file
Dump video coding statistics to file." );
            SetTooltipToControl( tb_avo_top, @"-top[:stream_specifier] n (output,per-stream)
top=1/bottom=0/auto=-1 field first" );
            SetTooltipToControl( tb_avo_dc, @"-dc precision
Intra_dc_precision." );
            SetTooltipToControl( tb_avo_vtag, @"-vtag fourcc/tag (output)
Force video tag/fourcc." );
            SetTooltipToControl( tb_avo_qphist, @"-qphist (global)
Show QP histogram" );
            SetTooltipToControl( tb_avo_vbsf, @"-vbsf bitstream_filter
Deprecated see -bsf" );
            SetTooltipToControl( tb_avo_force_key_frames, @"-force_key_frames[:stream_specifier] time[,time...] (output,per-stream)
-force_key_frames[:stream_specifier] expr:expr (output,per-stream)
Force key frames at the specified timestamps, more precisely at the first frames after each specified time.

If the argument is prefixed with expr:, the string expr is interpreted like an expression and is evaluated for each frame. A key frame is forced in case the evaluation is non-zero.

If one of the times is 'chapters[delta]', it is expanded into the time of the beginning of all chapters in the file, shifted by delta, expressed as a time in seconds.
This option can be useful to ensure that a seek point is present at a chapter mark or any other designated place in the output file.

For example, to insert a key frame at 5 minutes, plus key frames 0.1 second before the beginning of every chapter:

-force_key_frames 0:05:00, chapters - 0.1
The expression in expr can contain the following constants:

n
    the number of current processed frame, starting from 0
n_forced
    the number of forced frames
prev_forced_n
    the number of the previous forced frame, it is NAN when no keyframe was forced yet
prev_forced_t
    the time of the previous forced frame, it is NAN when no keyframe was forced yet
t
    the time of the current processed frame

For example to force a key frame every 5 seconds, you can specify:

-force_key_frames expr: gte(t, n_forced * 5)
To force a key frame 5 seconds after the time of the last forced one, starting from second 13:

-force_key_frames expr:if (isnan(prev_forced_t),gte(t, 13),gte(t, prev_forced_t + 5))
Note that forcing too many keyframes is very harmful for the lookahead algorithms of certain encoders: using fixed-GOP options or similar would be more efficient." );
            SetTooltipToControl( tb_avo_copyinkf, @"-copyinkf[:stream_specifier] (output,per-stream)
When doing stream copy, copy also non-key frames found at the beginning." );
            SetTooltipToControl( tb_avo_hwaccel, @"-hwaccel[:stream_specifier] hwaccel (input,per-stream)
Use hardware acceleration to decode the matching stream(s). The allowed values of hwaccel are:

none
    Do not use any hardware acceleration (the default).
auto
    Automatically select the hardware acceleration method.
vda
    Use Apple VDA hardware acceleration.
vdpau
    Use VDPAU (Video Decode and Presentation API for Unix) hardware acceleration.
dxva2
    Use DXVA2 (DirectX Video Acceleration) hardware acceleration.

This option has no effect if the selected hwaccel is not available or not supported by the chosen decoder.

Note that most acceleration methods are intended for playback and will not be faster than software decoding on modern CPUs.
Additionally, ffmpeg will usually need to copy the decoded frames from the GPU memory into the system memory, resulting in further performance loss.
This option is thus mainly useful for testing." );
            SetTooltipToControl( this.tb_avo_hwaccel_device, @"-hwaccel_device[:stream_specifier] hwaccel_device (input,per-stream)
Select a device to use for hardware acceleration.

This option only makes sense when the -hwaccel option is also specified. Its exact meaning depends on the specific hardware acceleration method chosen.

vdpau
For VDPAU, this option specifies the X11 display/screen to use.
If this option is not specified, the value of the DISPLAY environment variable is used

dxva2
For DXVA2, this option should contain the number of the display adapter to use.
If this option is not specified, the default adapter is used." );
            #endregion

            #region Audio Options
            SetTooltipToControl( this.tb_ao_aframes, @"-aframes number (output)
Set the number of audio frames to output." );
            SetTooltipToControl( tb_ao_ar, @"-ar[:stream_specifier] freq (input/output,per-stream)
Set the audio sampling frequency.
For output streams it is set by default to the frequency of the corresponding input stream.
For input streams this option only makes sense for audio grabbing devices and raw demuxers and is mapped to the corresponding demuxer options." );
            SetTooltipToControl( tb_ao_aq, @"-aq q (output)
Set the audio quality (codec-specific, VBR). This is an alias for -q:a." );
            SetTooltipToControl( this.tb_ao_ac, @"-ac[:stream_specifier] channels (input/output,per-stream)
Set the number of audio channels.
For output streams it is set by default to the number of input audio channels.
For input streams this option only makes sense for audio grabbing devices and raw demuxers and is mapped to the corresponding demuxer options." );
            SetTooltipToControl( tb_ao_an, @"-an (output)
Disable audio recording." );
            SetTooltipToControl( tb_ao_acodec, @"-acodec codec (input/output)
Set the audio codec. This is an alias for -codec:a" );
            SetTooltipToControl( tb_ao_sample_fmt, @"-sample_fmt[:stream_specifier] sample_fmt (output,per-stream)
Set the audio sample format. Use -sample_fmts to get a list of supported sample formats." );
            SetTooltipToControl( tb_ao_af, @"-af filtergraph (output)
Create the filtergraph specified by filtergraph and use it to filter the stream." );
            #endregion

            #region Advanced Audio options
            SetTooltipToControl( tb_aao_atag, @"-atag fourcc/tag (output)
Force audio tag/fourcc. This is an alias for -tag:a." );
            SetTooltipToControl( this.tb_aao_absf, @"-absf bitstream_filter
Deprecated, see -bsf" );
            SetTooltipToControl( tb_aao_guess_layout_max, @"-guess_layout_max channels (input,per-stream)
If some input channel layout is not known, try to guess only if it corresponds to at most the specified number of channels.
For example, 2 tells to ffmpeg to recognize 1 channel as mono and 2 channels as stereo but not 6 channels as 5.1.
The default is to always try to guess. Use 0 to disable all guessing." );
            #endregion

        }

        private static void SetTooltipToControl( Control control, string message )
        {
            // CodeAnlysis error http://haacked.com/archive/2013/01/11/hidden-pitfalls-with-object-initializers.aspx/
            // Don’t use the initializer and set the property the old fashioned way.
            ToolTip toolTip1 = new ToolTip
            {
                AutoPopDelay = 25000,
                InitialDelay = 100,
                ReshowDelay = 500,
                ShowAlways = true
            };

            toolTip1.SetToolTip( control, message );
        }

        private static void InvokeEvent( EventHandler eh )
        {
            if ( eh != null )
            {
                eh.Invoke( null, null );
            }
        }
    }
}
