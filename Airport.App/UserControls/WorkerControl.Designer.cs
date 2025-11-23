namespace Airport.UserControls
{
    partial class WorkerControl
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
            buttonGoBack = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridView = new DataGridView();
            tableButtons = new TableLayoutPanel();
            buttonDelete = new Button();
            buttonAdd = new Button();
            buttonEdit = new Button();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            tableButtons.SuspendLayout();
            SuspendLayout();
            // 
            // buttonGoBack
            // 
            buttonGoBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonGoBack.Location = new Point(677, 3);
            buttonGoBack.Name = "buttonGoBack";
            buttonGoBack.Size = new Size(100, 30);
            buttonGoBack.TabIndex = 1;
            buttonGoBack.Text = "Назад";
            buttonGoBack.UseVisualStyleBackColor = true;
            buttonGoBack.Click += buttonGoBack_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(buttonGoBack);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(780, 32);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridView, 0, 1);
            tableLayoutPanel1.Controls.Add(tableButtons, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.652174F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 89.3478241F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 97F));
            tableLayoutPanel1.Size = new Size(786, 460);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 41);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(780, 318);
            dataGridView.TabIndex = 3;
            dataGridView.CellClick += dataGridView_CellClick;
            // 
            // tableButtons
            // 
            tableButtons.Anchor = AnchorStyles.None;
            tableButtons.ColumnCount = 3;
            tableButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 101F));
            tableButtons.Controls.Add(buttonDelete, 2, 0);
            tableButtons.Controls.Add(buttonAdd, 0, 0);
            tableButtons.Controls.Add(buttonEdit, 1, 0);
            tableButtons.Location = new Point(234, 394);
            tableButtons.Name = "tableButtons";
            tableButtons.RowCount = 1;
            tableButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableButtons.Size = new Size(317, 34);
            tableButtons.TabIndex = 4;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Red;
            buttonDelete.Dock = DockStyle.Fill;
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(219, 3);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(95, 28);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.Lime;
            buttonAdd.Dock = DockStyle.Fill;
            buttonAdd.Location = new Point(3, 3);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(102, 28);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Dock = DockStyle.Fill;
            buttonEdit.Location = new Point(111, 3);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(102, 28);
            buttonEdit.TabIndex = 1;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // WorkerControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(0);
            Name = "WorkerControl";
            Size = new Size(786, 460);
            Load += WorkerControl_Load;
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            tableButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button buttonGoBack;
        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView;
        private TableLayoutPanel tableButtons;
        private Button buttonDelete;
        private Button buttonAdd;
        private Button buttonEdit;
    }
}
