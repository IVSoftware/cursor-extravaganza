namespace cursor_extravaganza
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Click += onAnyClick;
            IterateControlTree(this, (control) => control.Click += onAnyClick);
        }
        // Set a wait cursor on the control that is clicked.
        private async void onAnyClick(object? sender, EventArgs e)
        {
            if(sender is Control control)
            {
                control.UseWaitCursor = true;
                displayCursors();
                await Task.Delay(1000);
                control.UseWaitCursor = false;
            }
        }
        private void displayCursors()
        {
            richTextBoxCursors.Clear();
            IterateControlTree(this, (control) => localAddEntry(control));
            void localAddEntry(Control control)
            {
                Color color = control.UseWaitCursor? Color.Red : Color.Green;
                richTextBoxCursors.SelectionColor = color;
                richTextBoxCursors.AppendText($"{control.Name} : {control.UseWaitCursor} {Environment.NewLine}");
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