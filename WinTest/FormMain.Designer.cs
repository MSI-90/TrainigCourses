namespace WinTest
{
    partial class FormMain
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
            dataGridViewMain = new DataGridView();
            LableTitle = new Label();
            labelHours = new Label();
            textBoxTitle = new TextBox();
            textBoxHours = new TextBox();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDel = new Button();
            buttonReload = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelId = new ToolStripStatusLabel();
            toolStripStatusLabelRow = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewMain
            // 
            dataGridViewMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMain.Location = new Point(44, 80);
            dataGridViewMain.Name = "dataGridViewMain";
            dataGridViewMain.RowTemplate.Height = 25;
            dataGridViewMain.Size = new Size(710, 338);
            dataGridViewMain.TabIndex = 0;
            dataGridViewMain.SelectionChanged += dataGridViewMain_SelectionChanged;
            // 
            // LableTitle
            // 
            LableTitle.AutoSize = true;
            LableTitle.Location = new Point(44, 21);
            LableTitle.Name = "LableTitle";
            LableTitle.Size = new Size(33, 15);
            LableTitle.TabIndex = 1;
            LableTitle.Text = "Курс";
            // 
            // labelHours
            // 
            labelHours.AutoSize = true;
            labelHours.Location = new Point(313, 21);
            labelHours.Name = "labelHours";
            labelHours.Size = new Size(36, 15);
            labelHours.TabIndex = 2;
            labelHours.Text = "Часы";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(88, 18);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(190, 23);
            textBoxTitle.TabIndex = 3;
            // 
            // textBoxHours
            // 
            textBoxHours.Location = new Point(357, 18);
            textBoxHours.Name = "textBoxHours";
            textBoxHours.Size = new Size(191, 23);
            textBoxHours.TabIndex = 4;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(44, 51);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(156, 51);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(75, 23);
            buttonEdit.TabIndex = 6;
            buttonEdit.Text = "Изменить";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDel
            // 
            buttonDel.Location = new Point(263, 51);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(75, 23);
            buttonDel.TabIndex = 7;
            buttonDel.Text = "Удалить";
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += buttonDel_Click;
            // 
            // buttonReload
            // 
            buttonReload.Location = new Point(368, 51);
            buttonReload.Name = "buttonReload";
            buttonReload.Size = new Size(107, 23);
            buttonReload.TabIndex = 8;
            buttonReload.Text = "Перезагрузить";
            buttonReload.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelId, toolStripStatusLabelRow });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 9;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelId
            // 
            toolStripStatusLabelId.Name = "toolStripStatusLabelId";
            toolStripStatusLabelId.Size = new Size(17, 17);
            toolStripStatusLabelId.Text = "Id";
            // 
            // toolStripStatusLabelRow
            // 
            toolStripStatusLabelRow.Name = "toolStripStatusLabelRow";
            toolStripStatusLabelRow.Size = new Size(46, 17);
            toolStripStatusLabelRow.Text = "Запись";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(buttonReload);
            Controls.Add(buttonDel);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxHours);
            Controls.Add(textBoxTitle);
            Controls.Add(labelHours);
            Controls.Add(LableTitle);
            Controls.Add(dataGridViewMain);
            Name = "FormMain";
            Text = "Тест";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewMain;
        private Label LableTitle;
        private Label labelHours;
        private TextBox textBoxTitle;
        private TextBox textBoxHours;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDel;
        private Button buttonReload;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelId;
        private ToolStripStatusLabel toolStripStatusLabelRow;
    }
}