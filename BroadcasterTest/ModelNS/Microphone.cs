using System;
using System.Collections.Generic;
using NAudio.Mixer;
using NAudio.Wave;

namespace BroadcasterTest.ModelNS
{
    public static class Microphone
    {
        //Core Audio for .NET http://whenimbored.xfx.net/2011/01/core-audio-for-net/
        //Проект не поддерживается, работает только с Vista+, но более простой для работы (легко получить уровень звука).

        //http://naudio.codeplex.com/
        //E:\Video\Lessons\Надо смотреть\C#\!!SOFT && mySource\!!AUDIO\NAudio-Release

        //.NET-диктoфон
        //http://blogs.msdn.com/b/rucoding4fun/archive/2009/11/28/net-o.aspx

        private static UnsignedMixerControl VolumeControl;

        public static Dictionary<string, string> GetMicrophones
        {
            //todo: Убрать или сделать завязку на получение устройств из этого метода. Если получится задавать устройство Audio через GUID etc., т.к. сейчас ограничение на 32 символа в имени устройства.
            get
            {
                var dictAudio = new Dictionary<string, string>();

                int waveInDevices = WaveIn.DeviceCount;
                for ( int waveInDevice = 0; waveInDevice < waveInDevices; waveInDevice++ )
                {
                    WaveInCapabilities deviceInfo = WaveIn.GetCapabilities( waveInDevice );

                    //str += string.Format("Device {0}: {1}, {2} channels",
                    //    waveInDevice, deviceInfo.ProductName, deviceInfo.Channels) + Environment.NewLine;
                    dictAudio.Add( deviceInfo.ProductName, deviceInfo.ProductName );
                }

                return dictAudio;
            }
        }

        public static void SetMicrophoneVolume( int volume )
        {
            if ( VolumeControl != null )
            {
                VolumeControl.Percent = volume;
            }
        }

        public static int GetMicrophoneVolume
        {
            get
            {
                if ( VolumeControl != null )
                {
                    return ( int ) VolumeControl.Percent;
                }

                return 0;
            }
        }

        public static void SetVolumeControlByName( string devName )
        {
            if ( devName == null )
            {
                throw new ArgumentNullException( "devName" );
            }

            int waveInDevices = WaveIn.DeviceCount;
            for ( int waveInDevice = 0; waveInDevice < waveInDevices; waveInDevice++ )
            {
                WaveInCapabilities deviceInfo = WaveIn.GetCapabilities( waveInDevice );

                if ( deviceInfo.ProductName.Equals( devName.Substring( 0, 31 ), StringComparison.OrdinalIgnoreCase ) )
                {
                    SetVolumeControlById( waveInDevice );
                }
            }
        }

        private static void SetVolumeControlById( int id )
        {
            var mixerLine = new MixerLine( ( IntPtr ) id, 0, MixerFlags.WaveIn );
            foreach ( var control in mixerLine.Controls )
            {
                if ( control.ControlType == MixerControlType.Volume )
                {
                    VolumeControl = control as UnsignedMixerControl;
                    break;
                }
            }
        }
    }
}
