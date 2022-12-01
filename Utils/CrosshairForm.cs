using ezOverLay;
using SusCrosshair.Utils;

namespace SusReticle.Utils
{
    public partial class CrosshairForm : Form
    {
        public static CrosshairForm Crosshair;
        public static string GameProcessName = "Overwatch";
        public static string GameWindowName = "Overwatch";
        private ez _overlay = new ez();


        private const string CROSSHAIR = "ඞ";
        public CrosshairForm()
        {
            InitializeComponent();
        }

        public bool invisCrosshair = true;
        Color transparentColor = Color.FromArgb(69, 69, 69);
        
        private void Reticle_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            TopMost = true;
            BackColor = transparentColor;
            TransparencyKey = transparentColor;
            FormBorderStyle = FormBorderStyle.None;
            _overlay.ClickThrough(this.Handle);
            Crosshair = this;

            var thread = new Thread(this.Main) { IsBackground = true };
            thread.Start();
        }

        private void Main()
        {
            while (true)
            {
                _overlay.DoStuff(GameWindowName, this);
                Refresh();
                Thread.Sleep(100);
            }       
        }

        private void Reticle_Paint(object sender, PaintEventArgs e)
        {
            if (susRet.CrosshairInvis)
                return;

            var font = new Font("Arial", CrosshairSettings.Instance.Size);
            var brush = new SolidBrush(susRet.CrosshairInvis ? transparentColor : Color.FromArgb(CrosshairSettings.Instance.R, CrosshairSettings.Instance.G, CrosshairSettings.Instance.B));

            var x = this.Width / 2;
            var y = this.Height / 2;

            x -= (int)(font.Height / 2);
            y -= (int)(font.Height / 2);

            e.Graphics.DrawString(CROSSHAIR, font, brush, new PointF(x, y));
        }
    }
}
