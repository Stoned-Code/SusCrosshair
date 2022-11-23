using ezOverLay;
using SusCrosshair.Utils;
using SusReticle.DllImports;
using SusReticle.Utils;
using System.Diagnostics;

namespace SusReticle
{
    public partial class susRet : Form
    {
        public static susRet Instance;
        private ez _ez = new ez();
        private Process _owProcess;
        private bool _crosshairEnabled = false;
        public static bool CrosshairInvis = false;
        private Thread _crosshairThread;
        
        public susRet()
        {
            InitializeComponent();
            Instance = this;
        }

        private void GetProc()
        {
            var processes = Process.GetProcessesByName(CrosshairForm.GameProcessName);

            processes = processes.OrderBy((proc) => proc.Id).ToArray();

            _owProcess = processes.Length > 0 ? processes[0] : null;
        }

        private bool InitCrosshairForm()
        {
            try
            {
                _crosshairThread = new Thread(CrosshairLoad) { IsBackground = true };
                _crosshairThread.Start();

                return true;
            }

            catch
            {
                return false;
            }
        }

        private void CrosshairLoad()
        {
            GetProc();

            if (_owProcess == null)
                return;

            Application.Run(new CrosshairForm());
        }
        
        private void exitButton_Click(object sender, EventArgs e) => Application.Exit();

        private void header_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                User32.DragWindow(Handle);
        }

        private void headerLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                User32.DragWindow(Handle);
        }
       
        private void susRet_Load(object sender, EventArgs e)
        {
            Instance = this;
            CrosshairSettings.Init();
            sizeTextBox.Text = CrosshairSettings.Instance.Size.ToString();
            redTextBox.Text = CrosshairSettings.Instance.R.ToString();
            greenTextBox.Text = CrosshairSettings.Instance.G.ToString();
            blueTextBox.Text = CrosshairSettings.Instance.B.ToString();
        }

        private void sizeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void crosshairToggle_Click(object sender, EventArgs e)
        {
            _crosshairEnabled = !_crosshairEnabled;

            if (_crosshairEnabled)
            {
                crosshairToggle.BackColor = Color.Red;
                crosshairToggle.Text = "Disable\r\nCrosshair";
                
                InitCrosshairForm();
            }

            else
            {
                crosshairToggle.BackColor = Color.Green;
                crosshairToggle.Text = "Enable\r\nCrosshair";

                CrosshairForm.Crosshair?.Close();
            }
        }

        private void redTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void greenTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void blueTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void sizeTextBox_Validated(object sender, EventArgs e)
        {
            CrosshairSettings.Instance.Size = Int32.Parse(sizeTextBox.Text);
            sizeTextBox.Text = CrosshairSettings.Instance.Size.ToString();

        }

        private void redTextBox_Validated(object sender, EventArgs e)
        {
            CrosshairSettings.Instance.R = Int32.Parse(redTextBox.Text);
            redTextBox.Text = CrosshairSettings.Instance.R.ToString();
        }

        private void greenTextBox_Validated(object sender, EventArgs e)
        {
            CrosshairSettings.Instance.G = Int32.Parse(greenTextBox.Text);
            greenTextBox.Text = CrosshairSettings.Instance.G.ToString();
        }

        private void blueTextBox_Validated(object sender, EventArgs e)
        {
            CrosshairSettings.Instance.B = Int32.Parse(blueTextBox.Text);
            blueTextBox.Text = CrosshairSettings.Instance.B.ToString();
        }

        private void SusRet_Click(object sender, EventArgs e) => headerLabel.Focus();

        private void header_Click(object sender, EventArgs e) => headerLabel.Focus();

        private void headerLabel_Click(object sender, EventArgs e) => headerLabel.Focus();

        private void redLabel_Click(object sender, EventArgs e) => redLabel.Focus();

        private void greenLabel_Click(object sender, EventArgs e) => headerLabel.Focus();

        private void blueLabel_Click(object sender, EventArgs e) => headerLabel.Focus();
    }
}