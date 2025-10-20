namespace Airport
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
            buttonWorker = new Button();
            buttonAdministrator = new Button();
            SuspendLayout();
            // 
            // buttonWorker
            // 
            buttonWorker.Location = new Point(449, 227);
            buttonWorker.Name = "buttonWorker";
            buttonWorker.Size = new Size(108, 39);
            buttonWorker.TabIndex = 0;
            buttonWorker.Text = "Работник";
            buttonWorker.UseVisualStyleBackColor = true;
            buttonWorker.Click += buttonWorker_Click;
            // 
            // buttonAdministrator
            // 
            buttonAdministrator.Location = new Point(226, 227);
            buttonAdministrator.Name = "buttonAdministrator";
            buttonAdministrator.Size = new Size(108, 39);
            buttonAdministrator.TabIndex = 1;
            buttonAdministrator.Text = "Администратор";
            buttonAdministrator.UseVisualStyleBackColor = true;
            buttonAdministrator.Click += buttonAdministrator_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAdministrator);
            Controls.Add(buttonWorker);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Airport";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonWorker;
        private Button buttonAdministrator;
    }
}
