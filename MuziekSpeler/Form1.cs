using Windows.Media.Core;
using Windows.Media.Playback;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Navigation;
using Xamarin.Forms.PlatformConfiguration;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Media.PlayTo;
using System.Text;
using Xamarin.Forms;
using Windows.ApplicationModel.UserDataTasks;
using System.Xml.Linq;

namespace MuziekSpeler
{
    public partial class Form1 : Form
    {
        /// <summary> 
        /// Update as regards to the changes this project went on.
        /// 
        /// It started with the idea of making an audio visualizer. 
        /// To make a visualizer for audio you first need to aqquire said audio. I searched a bit on the possibility of aquiring the system audio and found this to be a step way too big to be the first.
        /// So instead I thought about just playing a .mp3 file first. This started off with MCISendString which I hold dear as a simple means of effectifly acieving said goal. In the documentation however
        /// I read that there were new and better means of achieving the desired effect. Namely "Media Player" at first I got confused and implemented windows mediaplayer. 
        /// after realizing my mistake I went and got mediaplayer working through it's interface in winforms using the .net framework. When I had that working I realized that that was not the full implementation.
        /// Upon this thought I did some more reading and started working on making the app with the .Net Core instead. 
        /// 
        /// All this led me to discover multiple things:
        ///     Xaml islands,
        ///     The Mediaplayer namespace, Https://learn.microsoft.com/en-us/uwp/api/windows.media.playback.mediaplayer
        ///     Windows.Media.Core,
        ///     Windows.Media.Playback,
        ///     .Forms / .Uwp and XAML interopability.
        ///     
        /// In the end to get it working again. I had to downgrade the .Net version back to the .Net Core (instead of the more modern .Net 5 or greater)
        /// and laid some groundwork as to videoplaying by installing the Microsoft.Toolkit.Forms.Ui.Controlls (in order to use the "MediaPlayerElement") more info: https://learn.microsoft.com/en-us/windows/apps/desktop/modernize/xaml-islands
        /// 
        /// Look into WASAPI : https://learn.microsoft.com/en-us/windows/win32/coreaudio/wasapi
        /// 
        /// 
        /// 
        ///     TODO:
        ///  [X]    UI
        ///  [X]    Play mp3 files.
        ///  [X]    Basic UI functionality.
        ///  [X]    Working trackbar.
        ///  [X]    Choose path of song library.
        ///  [X]    Volume slider.
        ///  []     Display metadata.
        ///  []     Drag & drop song playing.
        ///  []     Full UI functionality.
        ///  []     Visualizer.
        ///  []     Video playing.
        ///  []     Tap into system audio for visualizer?
        /// 
        /// </summary>

        // Instead of getting confused I found the right thing this time. MediaPlayer and not WindowsMediaPlayer.
        // And we are using MediaPlayer here instead of BackgroundMediaPlayer because that is deprecated as of win 10 V-1703~ 
        MediaPlayer _player;
        Thread trackPosition;

        // This loads each track in memmory in advance, maybe use a different method so as to not flood the system memmory.
        List<MediaSource> _tracks = new List<MediaSource>();

        // Putting this outside of RandomBtn_Click saves about 20 Mbs of memmory being used on rapid clicking.
        // Do need to have a way of updating this directory upon addition of new files though.
        IEnumerable<string> songsFolder = Directory.EnumerateDirectories("D:\\osu!\\Songs");

        List<Bitmap> covers = new List<Bitmap>();

        private bool trackPlaying;
        private bool trackbarMax;
        private bool trackbarMouseDown;

        public Form1()
        {
            InitializeComponent();
            // Create a new mediaplayer instance, multiple are allowed.
            _player = new MediaPlayer
            {
                AutoPlay = AutoChb.Checked,
                IsLoopingEnabled = LoopChb.Checked,
                Volume = VolumeBar.Value / 100d
            };

            _player.MediaEnded += Ended;
            _player.MediaFailed += Failed;
            _player.MediaOpened += Opened;

            trackBar1.ValueChanged += Changed;
            trackBar1.MouseDown += OnMouseDown;
            trackBar1.MouseUp += OnMouseUp;

            trackPosition = new Thread(TrackPos);
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            _player.PlaybackSession.Position = TimeSpan.FromMilliseconds(trackBar1.Value * 100);
            trackbarMouseDown = false;
        }

        private void OnMouseDown(object? sender, EventArgs e)
        {
            trackbarMouseDown = true;
        }

        private void Changed(object? sender, EventArgs e)
        {
            trackBar1.Update();
            if (trackBar1.Value == trackBar1.Maximum)
            {
                trackbarMax = true;
            }
            // If the user resets the trackbar after song finished playing, then replay the song at the set position.
            if (!trackPlaying)
            {
                _player.Play();
                _player.PlaybackSession.Position = TimeSpan.FromMilliseconds(trackBar1.Value * 100);
                trackPlaying = true;
                trackbarMax = false;
                trackPosition = new Thread(TrackPos);
                trackPosition.Start();
            }
        }

        private void Failed(MediaPlayer sender, MediaPlayerFailedEventArgs args)
        {
            MessageBox.Show(args.ErrorMessage);
        }

        private void TrackPos()
        {// Add safety for if the trackbar is at max but somehow did not corrospond with trackended
            while (trackPlaying)
            {
                if (!trackbarMouseDown)
                {
                    if (trackbarMax)
                    {
                        trackbarMax = false;
                        return;
                    }
                    if (trackBar1.InvokeRequired)
                    {
                        Invoke(new Action(() => trackBar1.Value = (int)(_player.PlaybackSession.Position.TotalMilliseconds / 100)));

                    }
                    else
                    {
                        trackBar1.Value = (int)(_player.PlaybackSession.Position.TotalMilliseconds / 100);
                    }
                }
            }
        }

        private void WriteTextSafe(System.Windows.Forms.TextBox textBox, string text)
        {
            if (textBox.InvokeRequired)
            {
                // If an invoke is required then Invoke this method. 
                Action safeWrite = delegate { WriteTextSafe(textBox, text); };
                textBox.Invoke(safeWrite);
            }
            else
            {
                textBox.Text = text;
            }
        }

        private void Opened(MediaPlayer sender, object args)
        {
            WriteTextSafe(PathTxtb, _tracks[0].Uri.ToString());
            WriteTextSafe(DurationTxtb, _player.PlaybackSession.NaturalDuration.ToString(@"h\:mm\:ss"));

            trackPlaying = true;
            if (trackPosition.ThreadState == ThreadState.Stopped)
                trackPosition = new Thread(TrackPos);
            if (trackPosition.ThreadState != ThreadState.Running)
                trackPosition.Start();

            if (trackBar1.InvokeRequired)
            {
                trackBar1.Invoke(new Action(() => trackBar1.Maximum = (int)(_player.PlaybackSession.NaturalDuration.TotalMilliseconds / 100)));
            }
            else
            {   // Devide by 100 to get 10's of seconds. for smoother animation of the trackbar.
                trackBar1.Maximum = (int)(_player.PlaybackSession.NaturalDuration.TotalMilliseconds / 100);
            }

            /*
            PathTxtb.Text = "Path";
            DurationTxtb.Text = "Duration";
            BeatsTxtb.Text = "Bpm";
            ArtistTxtb.Text = "Artist";
            DateTxtb.Text = "Year";
            AlbumTxtb.Text = "Album";
            GenreTxtb.Text = "Genre";
            PublisherTxtb.Text = "Publisher";
            RightTxtb.Text = "Copyright";
            SampleTxtb.Text = "00,000 kHz";
            SizeTxtb.Text = "0,00 Mb";
            RateTxtb.Text = "0000 kbps";
            TitleTxtb.Text = "title";
            NumberTxtb.Text = "song number.";
            trackBar1.Maximum = Int16.Parse(_player.NaturalDuration.TotalSeconds.ToString());*/

            if (_tracks.Count > 0)
            {
                _tracks.RemoveAt(0);
            }
        }

        private void Ended(MediaPlayer sender, object args)
        {
            trackPlaying = false;

            try
            {
                // Now using MediaPlayer, way simpler and easier to acces than mciSendString. Mainly because it can be used with / by intellisense!
                if (_tracks.Count > 0)
                {
                    try { _player.Source = _tracks.First(); } catch (Exception ex) { MessageBox.Show(ex.Message); }
                    try { _player.Play(); } catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
                else
                {
                    return;
                }

                if (covers.First() != null && covers.First() != pB1.Image)
                {
                    pB1.Image?.Dispose();
                    pB1.Image = covers.First();
                    covers.RemoveAt(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {// to prevent duplicate code just use that method. The parameters don't matter since they are not being used anyway. They could be null for all we care.
            if (_player.PlaybackSession.PlaybackState != MediaPlaybackState.Playing && _player.PlaybackSession.PlaybackState != MediaPlaybackState.Paused && !trackbarMax) { Ended(_player, sender); }
            else if (trackBar1.Value == trackBar1.Maximum)
            {
                _player.Play();
                trackPlaying = true;
                trackbarMax = false;
                trackPosition = new Thread(TrackPos);
                trackPosition.Start();
            }
            else if (_player.PlaybackSession.PlaybackState == MediaPlaybackState.Paused) { _player.Play(); }
            else { _player.Pause(); }
        }

        private void RandomBtn_Click(object sender, EventArgs e)
        {
            // TODO: add form controlls to set the amount of songs added.
            int rolls = 1;

            Random random = new Random();

            // TODO: add parity safety for if one file fails to open the image or .mp3 that the lists do not end up uneven.
            for (int i = 0; i < rolls; i++)
            {
                int number = random.Next(songsFolder.Count());

                IEnumerable<string> f = Directory.EnumerateFiles(songsFolder.ElementAt(number));

                var name = from a in f where a.EndsWith(".mp3") select a;
                if (name.Any())
                {
                    _tracks.Add(MediaSource.CreateFromUri(new Uri(name.First())));
                }

                var avi = from a in f where a.EndsWith(".avi") select a;
                if (avi.Any())
                {
                    // do something to play the video.
                }

                var cover = from a in f where a.EndsWith(".jpg") || a.EndsWith(".png") select a;
                if (cover.Any())
                {
                    covers.Add(new Bitmap(cover.First()));
                }
            }
        }

        private void SkipBtn_Click(object sender, EventArgs e)
        {   // set the track position at it's end to let the events handle everything "naturally".
            _player.PlaybackSession.Position = _player.PlaybackSession.NaturalDuration;
        }

        private void LoopChb_CheckStateChanged(object sender, EventArgs e)
        {
            if (LoopChb.Checked) { _player.IsLoopingEnabled = true; }
            else { _player.IsLoopingEnabled = false; }
        }

        private void AutoChb_CheckStateChanged(object sender, EventArgs e)
        {
            if (AutoChb.Checked) { _player.AutoPlay = true; }
            else { _player.AutoPlay = false; }
        }

        private void VolumeBar_ValueChanged(object sender, EventArgs e)
        {
            _player.Volume = VolumeBar.Value / 100d;
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            if (diag.ShowDialog() == DialogResult.OK)
            {
                FolderCmb.Text = diag.SelectedPath;
                songsFolder = Directory.EnumerateDirectories(diag.SelectedPath);
                if (diag.SelectedPath.Contains("osu!"))
                {
                    RandomBtn.Text = "Random Osu! song";
                }
                else { RandomBtn.Text = "Random song"; }
                // Focus on the form so you can interract with the other elements without issue.
                Focus();
            }
        }

        private void FolderCmb_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {   // Change the folder by dragging a file into the box.

        }

        private void pB1_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {   // add the mp3 to trackslist and play it.
            //_tracks.Add(MediaSource.CreateFromUri(new Uri()));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

// Fuck with this to get system audio. Seems complicated and people say it so.
// [DllImport("wimm.dll", EntryPoint = "WaveOutGetVolume")] 
// public static extern void GetWaveVolume(IntPtr devicehandle, out int Volume);



/*      This was me finding old forum posts on code exchange etc to get me looking into the right direction.
 *      And it got me to Mediaplayer which is the modern up-to-date way of handling such media.
 *      All in all, respect to that one dude "yditxu on stackoverflow"
 *      
        // THIS IS LEGACY CODE, WINDOWS DECLARES THAT MEDIAPLAYER IS A MORE OPTIMIZED WAY OF DOING THINGS.
        [DllImport("winmm.dll")]
        // Returns zero if succsesfull. If not see link for a list of possible errors: https://learn.microsoft.com/en-us/windows/win32/multimedia/mcierr-return-values
        public static extern uint mciSendString(
            // MCI command string, for a list see: https://learn.microsoft.com/en-us/windows/win32/multimedia-command-strings
            string lpstrCommand,
            // Pointer to a buffer that recieves return information, if no information is needed value can be NULL.
            StringBuilder lpstrReturnString,
            // Size, in carachters of said return buffer.
            int uReturnLength,
            // Handle to a callback window if the "notify" flag was specified in the command string.
            IntPtr hWndCallback
        );  


                mciSendString(@"close temp_alias", null, 0, IntPtr.Zero);
                mciSendString($@"open ""{path}"" alias temp_alias", null, 0, IntPtr.Zero);
                mciSendString("play temp_alias", null,0,IntPtr.Zero); 



// For this to work add the windows media player in com / references.
// Works, but opens a windows media player window which I do not want.
// WindowsMediaPlayer _player;
// _player = new WindowsMediaPlayer();
// _player.openPlayer(path);

*/