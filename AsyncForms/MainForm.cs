namespace AsyncForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private async void buttonShow_Click(object sender, EventArgs e)
        {
            var form = CreateForm();

            if (checkMdiChild.Checked)
                form.MdiParent = this;

            try
            {
                if (checkDialog.Checked)
                {
                    if (checkAsync.Checked)
                    {
                        if (checkSetOwner.Checked)
                            await form.ShowDialogAsync(this);
                        else
                            await form.ShowDialogAsync();
                    }
                    else
                    {
                        if (checkSetOwner.Checked)
                            form.ShowDialog(this);
                        else
                            form.ShowDialog();
                    }
                }
                else
                {
                    if (checkAsync.Checked)
                    {
                        if (checkSetOwner.Checked)
                            await form.ShowAsync(this);
                        else
                            await form.ShowAsync();
                    }
                    else
                    {
                        if (checkSetOwner.Checked)
                            form.Show(this);
                        else
                            form.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Form CreateForm()
        {
            var form = new Form() 
            {
                Padding = new Padding(8),
                StartPosition = FormStartPosition.CenterScreen 
            };

            var label = new Label()
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
            };
            form.Controls.Add(label);

            // Button Show()
            var buttonShow = new Button
            {
                Text = "Call Show()",
                Dock = DockStyle.Bottom,
            };
            buttonShow.Click += (s, _) =>
            {
                try
                {
                    form.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            form.Controls.Add(buttonShow);

            // Button ShowAsync()
            var buttonShowAsync = new Button
            {
                Text = "Call ShowAsync()",
                Dock = DockStyle.Bottom,
            };
            buttonShowAsync.Click += async (s, _) =>
            {
                try
                {
                    await form.ShowAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            form.Controls.Add(buttonShowAsync);

            form.Load += (_, _) => 
            {
                label.Text = $"""
                    Is MDI child: {form.MdiParent is object}
                    Has owner: {form.Owner is object}
                    Is dialog: {checkDialog.Checked}
                    Shown async: {checkAsync.Checked}
                    """;
            };

            return form;
        }

        private void Form_Load(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void checkMdiChild_CheckedChanged(object sender, EventArgs e)
        {
            var hint = string.Empty;

            var isMdiChildAndAsync = checkMdiChild.Checked && checkAsync.Checked;
            var isMdiChildWithOwner = checkMdiChild.Checked && checkSetOwner.Checked;
            var isMdiChildAsDialog = checkMdiChild.Checked && checkDialog.Checked;
            var isOnlyAsync = checkAsync.Checked && !checkMdiChild.Checked && !checkSetOwner.Checked && !checkDialog.Checked;

            if (isMdiChildAndAsync)
                hint = "\u279c Issue 1";

            if (isOnlyAsync)
                hint = "\u279c Issue 2";

            if (isMdiChildWithOwner)
                hint = "MDI children cannot have an owner.";

            if (isMdiChildAsDialog)
                hint = "MDI children cannot be shown as dialog.";

            var isError = isMdiChildWithOwner || isMdiChildAsDialog;

            lblHint.ForeColor = isError ? Color.Red : labelIssue.ForeColor;
            lblHint.Text = hint;
        }
    }
}
