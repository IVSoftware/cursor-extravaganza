namespace cursor_extravaganza
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Click += onAnyClick;
            IterateControlTree(this, (control) => control.Click += onAnyClick);
            IterateControlTree(this, (control) => control.CursorChanged += onAnyCursorChanged);
        }

        // Set a wait cursor on the control that is clicked.
        private async void onAnyClick(object? sender, EventArgs e)
        {
            if(sender is Control control)
            {
                control.Cursor = Cursors.WaitCursor;
                await Task.Delay(1000);
                control.Cursor = Cursors.Default;
            }
        }
        private async void onAnyCursorChanged(object? sender, EventArgs e)
        {
            await Task.Delay(100);
            displayCursors();
        }
        private void displayCursors()
        {
            richTextBoxCursors.Clear();
            IterateControlTree(this, (control) => localAddEntry(control));
            void localAddEntry(Control control)
            {
                var isWaitCursor = control.Cursor.Equals(Cursors.WaitCursor);
                Color color = isWaitCursor ? Color.Red : Color.Green;
                richTextBoxCursors.SelectionColor = color;
                richTextBoxCursors.AppendText($"{control.Name} : {isWaitCursor} {Environment.NewLine}");
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