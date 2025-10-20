namespace Airport.UserControls
{
    partial class AdministratorControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanelInfo = new TableLayoutPanel();
            textBoxTotalRevenue = new TextBox();
            textBoxTotalCrew = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxTotalPassangers = new TextBox();
            textBoxTotalArrivingFlights = new TextBox();
            buttonGoBack = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanelInfo.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanelInfo
            // 
            tableLayoutPanelInfo.Anchor = AnchorStyles.None;
            tableLayoutPanelInfo.ColumnCount = 2;
            tableLayoutPanelInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.2990341F));
            tableLayoutPanelInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.7009659F));
            tableLayoutPanelInfo.Controls.Add(textBoxTotalRevenue, 1, 3);
            tableLayoutPanelInfo.Controls.Add(textBoxTotalCrew, 1, 2);
            tableLayoutPanelInfo.Controls.Add(label1, 0, 0);
            tableLayoutPanelInfo.Controls.Add(label2, 0, 1);
            tableLayoutPanelInfo.Controls.Add(label3, 0, 2);
            tableLayoutPanelInfo.Controls.Add(label4, 0, 3);
            tableLayoutPanelInfo.Controls.Add(textBoxTotalPassangers, 1, 0);
            tableLayoutPanelInfo.Controls.Add(textBoxTotalArrivingFlights, 1, 1);
            tableLayoutPanelInfo.Location = new Point(237, 179);
            tableLayoutPanelInfo.Name = "tableLayoutPanelInfo";
            tableLayoutPanelInfo.RowCount = 4;
            tableLayoutPanelInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelInfo.Size = new Size(311, 145);
            tableLayoutPanelInfo.TabIndex = 0;
            tableLayoutPanelInfo.Paint += tableLayoutPanel1_Paint;
            // 
            // textBoxTotalRevenue
            // 
            textBoxTotalRevenue.Anchor = AnchorStyles.Left;
            textBoxTotalRevenue.Location = new Point(119, 115);
            textBoxTotalRevenue.Name = "textBoxTotalRevenue";
            textBoxTotalRevenue.Size = new Size(171, 23);
            textBoxTotalRevenue.TabIndex = 8;
            // 
            // textBoxTotalCrew
            // 
            textBoxTotalCrew.Anchor = AnchorStyles.Left;
            textBoxTotalCrew.Location = new Point(119, 78);
            textBoxTotalCrew.Name = "textBoxTotalCrew";
            textBoxTotalCrew.Size = new Size(171, 23);
            textBoxTotalCrew.TabIndex = 7;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 0;
            label1.Text = "Всего пассажиров";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 46);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 1;
            label2.Text = "Всего рейсов";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 82);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 2;
            label3.Text = "Всего экипажа";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 119);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 3;
            label4.Text = "Всего выручки";
            // 
            // textBoxTotalPassangers
            // 
            textBoxTotalPassangers.Anchor = AnchorStyles.Left;
            textBoxTotalPassangers.Location = new Point(119, 6);
            textBoxTotalPassangers.Name = "textBoxTotalPassangers";
            textBoxTotalPassangers.Size = new Size(171, 23);
            textBoxTotalPassangers.TabIndex = 5;
            // 
            // textBoxTotalArrivingFlights
            // 
            textBoxTotalArrivingFlights.Anchor = AnchorStyles.Left;
            textBoxTotalArrivingFlights.Location = new Point(119, 42);
            textBoxTotalArrivingFlights.Name = "textBoxTotalArrivingFlights";
            textBoxTotalArrivingFlights.Size = new Size(171, 23);
            textBoxTotalArrivingFlights.TabIndex = 6;
            // 
            // buttonGoBack
            // 
            buttonGoBack.Location = new Point(677, 3);
            buttonGoBack.Name = "buttonGoBack";
            buttonGoBack.Size = new Size(100, 30);
            buttonGoBack.TabIndex = 1;
            buttonGoBack.Text = "Назад";
            buttonGoBack.UseVisualStyleBackColor = true;
            buttonGoBack.Click += buttonGoBack_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanelInfo, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.565217F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 90.4347839F));
            tableLayoutPanel2.Size = new Size(786, 460);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(buttonGoBack);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(780, 38);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // AdministratorControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Name = "AdministratorControl";
            Size = new Size(786, 460);
            tableLayoutPanelInfo.ResumeLayout(false);
            tableLayoutPanelInfo.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelInfo;
        private TextBox textBoxTotalCrew;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxTotalPassangers;
        private TextBox textBoxTotalArrivingFlights;
        private TextBox textBoxTotalRevenue;
        private Button buttonGoBack;
        private TableLayoutPanel tableLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
