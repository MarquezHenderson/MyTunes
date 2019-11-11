using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyTunes
{
    class Mplayer
    {
        //private string priv_command;
        
        public bool Repeat { get; set; }
        public string filename;
        public string command;
        private string name = "mp3";
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, IntPtr hwdCallBack);

        //construtor take in file 
        public Mplayer(string filename)
        {
 
            this.filename = filename;
        }
        public void open()
        {
            //const string FORMAT = @"open ""{0}"" type MPEGVideo alias {0}";
            //string command = String.Format(FORMAT, filename);
            //dll method
            command = "open \"" + filename + "\" type MPEGVideo alias " + name;
            mciSendString(command, null, 0, IntPtr.Zero);
        }



        //setup Play
        public void Play()
        {
            //PLAY
            //Pcommand = "play ";
           string command = "Play "+ name;
            //priv_command += " REPEAT";
            mciSendString(command, null, 0,IntPtr.Zero);
        }

        //setup Stop
        public void Stop()
        {
            //STOP
            //Pcommand = "stop MediaFile";
            string command = "Stop " + name;
            mciSendString(command, null, 0,IntPtr.Zero);

        }


    }
}
