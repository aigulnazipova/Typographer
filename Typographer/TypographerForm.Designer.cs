namespace Typographer
{
    partial class TypographerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TypographerForm));
            outputTextbox = new RichTextBox();
            inputTextbox = new RichTextBox();
            label1 = new Label();
            editTextButton = new Button();
            copyButton = new Button();
            ClearButton = new Button();
            RulesLabel = new Label();
            SuspendLayout();
            // 
            // outputTextbox
            // 
            outputTextbox.BorderStyle = BorderStyle.None;
            outputTextbox.Font = new Font("Sitka Small", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            outputTextbox.Location = new Point(603, 143);
            outputTextbox.Name = "outputTextbox";
            outputTextbox.ReadOnly = true;
            outputTextbox.Size = new Size(560, 588);
            outputTextbox.TabIndex = 1;
            outputTextbox.Text = "";
            // 
            // inputTextbox
            // 
            inputTextbox.BorderStyle = BorderStyle.None;
            inputTextbox.Font = new Font("Sitka Small", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            inputTextbox.Location = new Point(23, 143);
            inputTextbox.Name = "inputTextbox";
            inputTextbox.Size = new Size(560, 588);
            inputTextbox.TabIndex = 0;
            inputTextbox.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(23, 22);
            label1.Name = "label1";
            label1.Size = new Size(250, 52);
            label1.TabIndex = 3;
            label1.Text = "Типограф \r\n";
            // 
            // editTextButton
            // 
            editTextButton.BackColor = Color.FromArgb(126, 147, 112);
            editTextButton.Cursor = Cursors.Hand;
            editTextButton.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            editTextButton.ForeColor = SystemColors.Control;
            editTextButton.Location = new Point(194, 748);
            editTextButton.Name = "editTextButton";
            editTextButton.Size = new Size(210, 51);
            editTextButton.TabIndex = 4;
            editTextButton.Text = "Оттипографить";
            editTextButton.UseVisualStyleBackColor = false;
            editTextButton.Click += EditTextButton_Click;
            // 
            // copyButton
            // 
            copyButton.BackColor = Color.FromArgb(126, 147, 112);
            copyButton.Cursor = Cursors.Hand;
            copyButton.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            copyButton.ForeColor = SystemColors.Control;
            copyButton.Location = new Point(793, 748);
            copyButton.Name = "copyButton";
            copyButton.Size = new Size(210, 51);
            copyButton.TabIndex = 7;
            copyButton.Text = "Скопировать";
            copyButton.UseVisualStyleBackColor = false;
            copyButton.Visible = false;
            copyButton.Click += copyButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.FromArgb(126, 147, 112);
            ClearButton.Cursor = Cursors.Hand;
            ClearButton.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ClearButton.ForeColor = SystemColors.Control;
            ClearButton.Location = new Point(421, 105);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(162, 32);
            ClearButton.TabIndex = 9;
            ClearButton.Text = "Очистить";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // RulesLabel
            // 
            RulesLabel.AutoSize = true;
            RulesLabel.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RulesLabel.Location = new Point(1184, 74);
            RulesLabel.Name = "RulesLabel";
            RulesLabel.Size = new Size(353, 644);
            RulesLabel.TabIndex = 10;
            RulesLabel.Text = resources.GetString("RulesLabel.Text");
            // 
            // TypographerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(196, 210, 186);
            ClientSize = new Size(1549, 839);
            Controls.Add(RulesLabel);
            Controls.Add(ClearButton);
            Controls.Add(copyButton);
            Controls.Add(editTextButton);
            Controls.Add(label1);
            Controls.Add(inputTextbox);
            Controls.Add(outputTextbox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "TypographerForm";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button editTextButton;
        private Button copyButton;
        private Button ClearButton;
        private Label RulesLabel;
        public RichTextBox inputTextbox;
        public RichTextBox outputTextbox;
    }
}
