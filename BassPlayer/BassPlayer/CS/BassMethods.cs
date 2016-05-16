using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Un4seen.Bass;

namespace MusicLibrary
{
    public static class BassMethods
    {
        // частота дискретизации;
        public static int HZ = 44100;
        // состояние инициализации библиотеки;
        public static bool InitDefaultDevice;
        //канал
        public static int Stream;
        public static int Volume = 100;

        private static bool InitBass(int hz)
        {
            if(!InitDefaultDevice)
                InitDefaultDevice = Bass.BASS_Init(-1, hz, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);
                return InitDefaultDevice;
            
        }

        public static void Play(string filename, int vol)
        {
            Stop();
            if (InitBass(HZ))
            {
                Stream = Bass.BASS_StreamCreateFile(filename, 0, 0, BASSFlag.BASS_DEFAULT);
                if ( Stream != 0)
                {
                    Volume = vol;
                    Bass.BASS_ChannelSetAttribute(Stream, BASSAttribute.BASS_ATTRIB_VOL, Volume / 100F);
                    Bass.BASS_ChannelPlay(Stream, false);
                }
            }
            else
                Bass.BASS_ChannelPlay(Stream, false);

        }

        public static void Resume()
        {
            Bass.BASS_ChannelPlay(Stream, false);
        }

        public static bool Pause()
        {
            if (Bass.BASS_ChannelIsActive(Stream) == BASSActive.BASS_ACTIVE_PLAYING)
            {
                Bass.BASS_ChannelPause(Stream);
                return true;
            }
            return false;
        }

        public static void Stop()
        {
            Bass.BASS_ChannelStop(Stream);
            Bass.BASS_StreamFree(Stream);
        }

        public static int GetTimeOfStream(int stream)
        {
            long TimeBytes = Bass.BASS_ChannelGetLength(stream);
            double Time = Bass.BASS_ChannelBytes2Seconds(stream, TimeBytes);
            return (int)Time;
        }

        public static int GetPosOfStream(int stream)
        {
            long pos = Bass.BASS_ChannelGetPosition(stream);
            int posSec = (int)Bass.BASS_ChannelBytes2Seconds(stream, pos);
            return posSec;
        }

        public static void SetPosOfScroll(int stream, int pos)
        {
            Bass.BASS_ChannelSetPosition(stream, (double)pos);
        }

        public static void SetVolumeToStream(int stream, int vol)
        {
            Volume = vol;
            Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, Volume / 100F);
        }

        public static string[] GetStreamTags(string filename)
        {
            string[] tags = new string[7];
            if (InitBass(HZ))
            {
                Stream = Bass.BASS_StreamCreateFile(filename, 0, 0, BASSFlag.BASS_DEFAULT);
                if (Stream != 0)
                {
                    Stream = Bass.BASS_StreamCreateFile(filename, 0, 0, BASSFlag.BASS_DEFAULT);
                    tags = Bass.BASS_ChannelGetTagsID3V1(Stream);
                }
            }
            return tags;
        }

    }
}
