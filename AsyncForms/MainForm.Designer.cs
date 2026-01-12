namespace AsyncForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            labelIssue = new Label();
            lblHint = new Label();
            checkSetOwner = new CheckBox();
            checkAsync = new CheckBox();
            checkMdiChild = new CheckBox();
            checkDialog = new CheckBox();
            buttonShow = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(labelIssue);
            panel1.Controls.Add(lblHint);
            panel1.Controls.Add(checkSetOwner);
            panel1.Controls.Add(checkAsync);
            panel1.Controls.Add(checkMdiChild);
            panel1.Controls.Add(checkDialog);
            panel1.Controls.Add(buttonShow);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(234, 550);
            panel1.TabIndex = 1;
            // 
            // labelIssue
            // 
            labelIssue.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelIssue.ForeColor = Color.DarkViolet;
            labelIssue.Location = new Point(18, 273);
            labelIssue.Name = "labelIssue";
            labelIssue.Size = new Size(203, 268);
            labelIssue.TabIndex = 6;
            labelIssue.Text = resources.GetString("labelIssue.Text");
            labelIssue.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblHint
            // 
            lblHint.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblHint.Font = new Font("Segoe UI", 9F);
            lblHint.ForeColor = Color.FromArgb(192, 0, 0);
            lblHint.Location = new Point(18, 168);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(199, 91);
            lblHint.TabIndex = 5;
            // 
            // checkSetOwner
            // 
            checkSetOwner.AutoSize = true;
            checkSetOwner.Location = new Point(18, 47);
            checkSetOwner.Name = "checkSetOwner";
            checkSetOwner.Size = new Size(78, 19);
            checkSetOwner.TabIndex = 1;
            checkSetOwner.Text = "Set owner";
            checkSetOwner.UseVisualStyleBackColor = true;
            checkSetOwner.CheckedChanged += checkMdiChild_CheckedChanged;
            // 
            // checkAsync
            // 
            checkAsync.AutoSize = true;
            checkAsync.Location = new Point(18, 97);
            checkAsync.Name = "checkAsync";
            checkAsync.Size = new Size(58, 19);
            checkAsync.TabIndex = 3;
            checkAsync.Text = "Async";
            checkAsync.UseVisualStyleBackColor = true;
            checkAsync.CheckedChanged += checkMdiChild_CheckedChanged;
            // 
            // checkMdiChild
            // 
            checkMdiChild.AutoSize = true;
            checkMdiChild.Location = new Point(18, 22);
            checkMdiChild.Name = "checkMdiChild";
            checkMdiChild.Size = new Size(88, 19);
            checkMdiChild.TabIndex = 0;
            checkMdiChild.Text = "Is MDI child";
            checkMdiChild.UseVisualStyleBackColor = true;
            checkMdiChild.CheckedChanged += checkMdiChild_CheckedChanged;
            // 
            // checkDialog
            // 
            checkDialog.AutoSize = true;
            checkDialog.Location = new Point(18, 72);
            checkDialog.Name = "checkDialog";
            checkDialog.Size = new Size(70, 19);
            checkDialog.TabIndex = 2;
            checkDialog.Text = "Is dialog";
            checkDialog.UseVisualStyleBackColor = true;
            checkDialog.CheckedChanged += checkMdiChild_CheckedChanged;
            // 
            // buttonShow
            // 
            buttonShow.Location = new Point(18, 130);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(135, 35);
            buttonShow.TabIndex = 4;
            buttonShow.Text = "Show";
            buttonShow.UseVisualStyleBackColor = true;
            buttonShow.Click += buttonShow_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 550);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "MainForm";
            Text = "Async Forms";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonShow;
        private CheckBox checkAsync;
        private CheckBox checkMdiChild;
        private CheckBox checkDialog;
        private CheckBox checkSetOwner;
        private Label lblHint;
        private Label labelIssue;
    }
}
