using System;
using System.Linq;
using System.Windows.Forms;
using ScriptPortal.Vegas;

namespace ShortenExtendMedia
{
    // Form to show on opening the Script
    public partial class WndForm : Form
    {
        public double ShortenLength = 0;
        public string ShortenTimecode;

        public double ExtendLength = 0;
        public string ExtendTimecode;

        public WndForm()
        {
            InitializeComponent();
            nudShorten.Select();

            Helper.ChangeTheme(menuStrip);
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            // Set variables
            ShortenLength = (double)nudShorten.Value;
            ShortenTimecode = cbShortenTimecode.Text;

            ExtendLength = (double)nudExtend.Value;
            ExtendTimecode = cbExtendTimecode.Text;

            DialogResult = DialogResult.OK;
            Close();
            Dispose();
        }

        private void tsmiCreatedByRatinFX_Click(object sender, EventArgs e)
        {
            Helper.OpenRatinFXWebsite();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            Helper.ShowAbout(
                "Quickly Increase or Decrease the length of the selected Events" + "\n\n" +
                "You can select between Frames and Seconds to calculate the new lengths" + "\n\n" +
                "- However: Composite and FX Keyframes will not move"
            );
        }
    }

    // Vegas recieves this
    public class EntryPoint
    {
        public void FromVegas(Vegas myVegas)
        {
            long shortenLength;
            string shortenTimecode;

            long extendLength;
            string extendTimecode;

            using (WndForm form = new WndForm())
            {
                var result = form.ShowDialog();
                if (result != DialogResult.OK)
                    return;

                // Get variables fromm the Form after pressing Run
                shortenLength = (long)form.ShortenLength;
                shortenTimecode = form.ShortenTimecode;

                extendLength = (long)form.ExtendLength;
                extendTimecode = form.ExtendTimecode;
            }

            try
            {
                var selectedEvents = myVegas.Project.Tracks?
                    .SelectMany(x => x.Events
                    .Where(y => y.Selected))
                    .ToArray();

                if (selectedEvents.Length == 0)
                    return;

                foreach (TrackEvent trackEvent in selectedEvents)
                {
                    var tempFadeInLength = trackEvent.FadeIn.Length;
                    var tempFadeOutLength = trackEvent.FadeOut.Length;

                    // Decrease length of the selected media
                    switch (shortenTimecode)
                    {
                        case "Frames":
                            trackEvent.Length = Timecode.FromFrames(trackEvent.Length.FrameCount - shortenLength);
                            break;
                        case "Seconds":
                            if (trackEvent.Length >= Timecode.FromSeconds(shortenLength))
                            {
                                // shorten eg.: 600 frame / 60 fps (-> 10sec) - x sec
                                trackEvent.Length = Timecode.FromSeconds(trackEvent.Length.FrameCount / trackEvent.Length.FrameRate - shortenLength);
                            }
                            break;
                        // Default is "Frames"
                        default:
                            trackEvent.Length = Timecode.FromFrames(trackEvent.Length.FrameCount - shortenLength);
                            break;
                    }

                    // Increase length of the selected media
                    switch (extendTimecode)
                    {
                        case "Frames":
                            trackEvent.Length = Timecode.FromFrames(trackEvent.Length.FrameCount + extendLength);
                            break;
                        case "Seconds":
                            // extend eg.: 600 frame / 60 fps (-> 10sec) + x sec
                            trackEvent.Length = Timecode.FromSeconds(trackEvent.Length.FrameCount / trackEvent.Length.FrameRate + extendLength);
                            break;
                        // Default is "Frames"
                        default:
                            trackEvent.Length = Timecode.FromFrames(trackEvent.Length.FrameCount + extendLength);
                            break;
                    }

                    // Set FadeIn / FadeOut
                    trackEvent.FadeIn.Length = tempFadeInLength;
                    trackEvent.FadeOut.Length = tempFadeOutLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Something went wrong: " + ex.Message,
                    "Something went wrong",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
