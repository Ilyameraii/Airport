namespace Airport.Forms
{
    partial class EditListForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            labelType = new Label();
            labelArrivedTime = new Label();
            labelCountPassengers = new Label();
            labelTaxPassenger = new Label();
            labelCountCrew = new Label();
            labelTaxCrew = new Label();
            labelPercent = new Label();
            airplaneTypePicker = new TextBox();
            passengerTaxPicker = new NumericUpDown();
            numberOfCrewPicker = new NumericUpDown();
            crewTaxPicker = new NumericUpDown();
            servicePercentagePicker = new NumericUpDown();
            arrivalTimePicker = new DateTimePicker();
            numberOfPassengersPicker = new NumericUpDown();
            buttonSave = new Button();
            buttonClear = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)passengerTaxPicker).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numberOfCrewPicker).BeginInit();
            ((System.ComponentModel.ISupportInitialize)crewTaxPicker).BeginInit();
            ((System.ComponentModel.ISupportInitialize)servicePercentagePicker).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numberOfPassengersPicker).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.plane;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(405, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.BackColor = SystemColors.GradientInactiveCaption;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.3786964F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.6213036F));
            tableLayoutPanel1.Controls.Add(labelType, 0, 0);
            tableLayoutPanel1.Controls.Add(labelArrivedTime, 0, 1);
            tableLayoutPanel1.Controls.Add(labelCountPassengers, 0, 2);
            tableLayoutPanel1.Controls.Add(labelTaxPassenger, 0, 3);
            tableLayoutPanel1.Controls.Add(labelCountCrew, 0, 4);
            tableLayoutPanel1.Controls.Add(labelTaxCrew, 0, 5);
            tableLayoutPanel1.Controls.Add(labelPercent, 0, 6);
            tableLayoutPanel1.Controls.Add(airplaneTypePicker, 1, 0);
            tableLayoutPanel1.Controls.Add(passengerTaxPicker, 1, 3);
            tableLayoutPanel1.Controls.Add(numberOfCrewPicker, 1, 4);
            tableLayoutPanel1.Controls.Add(crewTaxPicker, 1, 5);
            tableLayoutPanel1.Controls.Add(servicePercentagePicker, 1, 6);
            tableLayoutPanel1.Controls.Add(arrivalTimePicker, 1, 1);
            tableLayoutPanel1.Controls.Add(numberOfPassengersPicker, 1, 2);
            tableLayoutPanel1.Location = new Point(22, 30);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(360, 287);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // labelType
            // 
            labelType.Anchor = AnchorStyles.Right;
            labelType.AutoSize = true;
            labelType.Location = new Point(73, 7);
            labelType.Margin = new Padding(3, 0, 3, 10);
            labelType.Name = "labelType";
            labelType.Size = new Size(83, 15);
            labelType.TabIndex = 0;
            labelType.Text = "Тип самолета";
            // 
            // labelArrivedTime
            // 
            labelArrivedTime.Anchor = AnchorStyles.Right;
            labelArrivedTime.AutoSize = true;
            labelArrivedTime.Location = new Point(56, 47);
            labelArrivedTime.Margin = new Padding(3, 0, 3, 10);
            labelArrivedTime.Name = "labelArrivedTime";
            labelArrivedTime.Size = new Size(100, 15);
            labelArrivedTime.TabIndex = 1;
            labelArrivedTime.Text = "Время прибытия";
            // 
            // labelCountPassengers
            // 
            labelCountPassengers.Anchor = AnchorStyles.Right;
            labelCountPassengers.AutoSize = true;
            labelCountPassengers.Location = new Point(14, 87);
            labelCountPassengers.Margin = new Padding(3, 0, 3, 10);
            labelCountPassengers.Name = "labelCountPassengers";
            labelCountPassengers.Size = new Size(142, 15);
            labelCountPassengers.TabIndex = 2;
            labelCountPassengers.Text = "Количество пассажиров";
            // 
            // labelTaxPassenger
            // 
            labelTaxPassenger.Anchor = AnchorStyles.Right;
            labelTaxPassenger.AutoSize = true;
            labelTaxPassenger.Location = new Point(41, 127);
            labelTaxPassenger.Margin = new Padding(3, 0, 3, 10);
            labelTaxPassenger.Name = "labelTaxPassenger";
            labelTaxPassenger.Size = new Size(115, 15);
            labelTaxPassenger.TabIndex = 3;
            labelTaxPassenger.Text = "Сбор на пассажира";
            // 
            // labelCountCrew
            // 
            labelCountCrew.Anchor = AnchorStyles.Right;
            labelCountCrew.AutoSize = true;
            labelCountCrew.Location = new Point(34, 167);
            labelCountCrew.Margin = new Padding(3, 0, 3, 10);
            labelCountCrew.Name = "labelCountCrew";
            labelCountCrew.Size = new Size(122, 15);
            labelCountCrew.TabIndex = 4;
            labelCountCrew.Text = "Количество экипажа";
            // 
            // labelTaxCrew
            // 
            labelTaxCrew.Anchor = AnchorStyles.Right;
            labelTaxCrew.AutoSize = true;
            labelTaxCrew.Location = new Point(60, 207);
            labelTaxCrew.Margin = new Padding(3, 0, 3, 10);
            labelTaxCrew.Name = "labelTaxCrew";
            labelTaxCrew.Size = new Size(96, 15);
            labelTaxCrew.TabIndex = 5;
            labelTaxCrew.Text = "Сбор на экипаж";
            // 
            // labelPercent
            // 
            labelPercent.Anchor = AnchorStyles.Right;
            labelPercent.AutoSize = true;
            labelPercent.Location = new Point(30, 243);
            labelPercent.Margin = new Padding(3, 0, 3, 10);
            labelPercent.Name = "labelPercent";
            labelPercent.Size = new Size(126, 30);
            labelPercent.TabIndex = 6;
            labelPercent.Text = "Процент надбавки за обслуживание";
            // 
            // airplaneTypePicker
            // 
            airplaneTypePicker.Anchor = AnchorStyles.Left;
            airplaneTypePicker.Location = new Point(162, 8);
            airplaneTypePicker.Name = "airplaneTypePicker";
            airplaneTypePicker.Size = new Size(156, 23);
            airplaneTypePicker.TabIndex = 7;
            // 
            // passengerTaxPicker
            // 
            passengerTaxPicker.Anchor = AnchorStyles.Left;
            passengerTaxPicker.DecimalPlaces = 2;
            passengerTaxPicker.Location = new Point(162, 128);
            passengerTaxPicker.Name = "passengerTaxPicker";
            passengerTaxPicker.Size = new Size(120, 23);
            passengerTaxPicker.TabIndex = 9;
            // 
            // numberOfCrewPicker
            // 
            numberOfCrewPicker.Anchor = AnchorStyles.Left;
            numberOfCrewPicker.Location = new Point(162, 168);
            numberOfCrewPicker.Name = "numberOfCrewPicker";
            numberOfCrewPicker.Size = new Size(120, 23);
            numberOfCrewPicker.TabIndex = 10;
            // 
            // crewTaxPicker
            // 
            crewTaxPicker.Anchor = AnchorStyles.Left;
            crewTaxPicker.DecimalPlaces = 2;
            crewTaxPicker.Location = new Point(162, 208);
            crewTaxPicker.Name = "crewTaxPicker";
            crewTaxPicker.Size = new Size(120, 23);
            crewTaxPicker.TabIndex = 11;
            // 
            // servicePercentagePicker
            // 
            servicePercentagePicker.Anchor = AnchorStyles.Left;
            servicePercentagePicker.DecimalPlaces = 2;
            servicePercentagePicker.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            servicePercentagePicker.Location = new Point(162, 252);
            servicePercentagePicker.Name = "servicePercentagePicker";
            servicePercentagePicker.Size = new Size(120, 23);
            servicePercentagePicker.TabIndex = 12;
            // 
            // arrivalTimePicker
            // 
            arrivalTimePicker.Anchor = AnchorStyles.Left;
            arrivalTimePicker.Format = DateTimePickerFormat.Time;
            arrivalTimePicker.Location = new Point(162, 48);
            arrivalTimePicker.Name = "arrivalTimePicker";
            arrivalTimePicker.Size = new Size(156, 23);
            arrivalTimePicker.TabIndex = 13;
            // 
            // numberOfPassengersPicker
            // 
            numberOfPassengersPicker.Anchor = AnchorStyles.Left;
            numberOfPassengersPicker.Location = new Point(162, 88);
            numberOfPassengersPicker.Name = "numberOfPassengersPicker";
            numberOfPassengersPicker.Size = new Size(120, 23);
            numberOfPassengersPicker.TabIndex = 8;
            // 
            // buttonSave
            // 
            buttonSave.Dock = DockStyle.Fill;
            buttonSave.Location = new Point(3, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 26);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonClear
            // 
            buttonClear.Dock = DockStyle.Fill;
            buttonClear.Location = new Point(103, 3);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(94, 26);
            buttonClear.TabIndex = 3;
            buttonClear.Text = "Очистить";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 105);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 86.81948F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 13.1805153F));
            tableLayoutPanel2.Size = new Size(405, 401);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(buttonClear, 1, 0);
            tableLayoutPanel3.Controls.Add(buttonSave, 0, 0);
            tableLayoutPanel3.Location = new Point(202, 358);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(200, 32);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // errorProvider
            // 
            errorProvider.BlinkRate = 1;
            errorProvider.ContainerControl = this;
            // 
            // EditListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 506);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "EditListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление/редактирование";
            Load += EditListForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)passengerTaxPicker).EndInit();
            ((System.ComponentModel.ISupportInitialize)numberOfCrewPicker).EndInit();
            ((System.ComponentModel.ISupportInitialize)crewTaxPicker).EndInit();
            ((System.ComponentModel.ISupportInitialize)servicePercentagePicker).EndInit();
            ((System.ComponentModel.ISupportInitialize)numberOfPassengersPicker).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelType;
        private Label labelArrivedTime;
        private Label labelCountPassengers;
        private Label labelTaxPassenger;
        private Label labelCountCrew;
        private Label labelTaxCrew;
        private Label labelPercent;
        private TextBox airplaneTypePicker;
        private NumericUpDown passengerTaxPicker;
        private NumericUpDown numberOfCrewPicker;
        private NumericUpDown crewTaxPicker;
        private NumericUpDown servicePercentagePicker;
        private DateTimePicker arrivalTimePicker;
        private NumericUpDown numberOfPassengersPicker;
        private Button buttonSave;
        private Button buttonClear;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private ErrorProvider errorProvider;
    }
}