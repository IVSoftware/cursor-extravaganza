using System.Drawing;
using System.Windows.Forms;

namespace cursor_extravaganza
{
    public partial class MainForm : Form
    {
        public MainForm() => InitializeComponent();
        protected async override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            IterateControlTree(this, (control) => control.MouseDown += onAnyMouseDown);
            var cts = new CancellationTokenSource();
            Disposed += (sender, e) => cts.Cancel();
            while (!cts.IsCancellationRequested)
            {
                await Task.Delay(100);
                CurrentCursor = Cursor.Current;
            }
        }

        Cursor? _CurrentCursor = Cursor.Current;
        public Cursor? CurrentCursor
        {
            get => _CurrentCursor;
            set
            {
                if (!Equals(_CurrentCursor, value))
                {
                    _CurrentCursor = value;
                    displayCursors();
                }
            }
        }
        // Set a wait cursor on the control that is clicked.
        private async void onAnyMouseDown(object? sender, MouseEventArgs e)
        {
            if (sender is Control control)
            {
                switch (e.Button)
                {
                    case MouseButtons.Left:
                        control.UseWaitCursor = true;
                        await Task.Delay(DURATION);
                        control.UseWaitCursor = false;
                        break;
                    case MouseButtons.Right:
                        control.Cursor = Cursors.AppStarting;
                        await Task.Delay(DURATION);
                        control.Cursor = Cursors.Default;
                        break;
                }
                // Hack to redraw the cursor
                var positionB4 = MousePosition;
                Cursor.Position = new Point(positionB4.X + 1, positionB4.Y);
                Cursor.Position = positionB4;
                displayCursors();
            }
        }
        const int DURATION = 2500;
        int _rawCount = 0;
        private void displayCursors()
        {
            richTextBoxCursors.Clear();
            richTextBoxCursors.SelectionColor = Color.Navy;
            richTextBoxCursors.AppendText($"Cursor : {Cursor.Current} {Environment.NewLine}");
            IterateControlTree(this, (control) => localAddEntry(control));

            void localAddEntry(Control control)
            {
                if (!(control is RichTextBox))
                {
                    var isDefault = control.Cursor.Equals(Cursors.Default);
                    Color color = isDefault ? Color.Green : Color.Red;
                    richTextBoxCursors.SelectionColor = color;
                    richTextBoxCursors.AppendText($"{control.Name} : {control.Cursor} {Environment.NewLine}");
                }
            }
        }
        internal void IterateControlTree(Control control, Action<Control> fx)
        {
            fx(control);
            foreach (Control child in control.Controls)
            {
                IterateControlTree(child, fx);
            }
        }
    }
}