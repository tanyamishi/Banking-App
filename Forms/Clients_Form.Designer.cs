namespace Banking_App
{
    partial class Clients_Form
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
            panel1 = new Panel();
            searchButton = new Button();
            passportBoxSrc = new TextBox();
            rnoBoxSrc = new TextBox();
            idBoxSrc = new TextBox();
            nameBoxSrc = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            clientBindingSource = new BindingSource(components);
            resultGridView = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            LastOperation = new DataGridViewTextBoxColumn();
            DepositCategory = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rNOKPPDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passportNumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            balanceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resultGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(searchButton);
            panel1.Controls.Add(passportBoxSrc);
            panel1.Controls.Add(rnoBoxSrc);
            panel1.Controls.Add(idBoxSrc);
            panel1.Controls.Add(nameBoxSrc);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(155, 28);
            panel1.MinimumSize = new Size(545, 204);
            panel1.Name = "panel1";
            panel1.Size = new Size(717, 204);
            panel1.TabIndex = 0;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(549, 156);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(143, 35);
            searchButton.TabIndex = 8;
            searchButton.Text = "Пошук";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // passportBoxSrc
            // 
            passportBoxSrc.Location = new Point(188, 116);
            passportBoxSrc.Name = "passportBoxSrc";
            passportBoxSrc.Size = new Size(333, 27);
            passportBoxSrc.TabIndex = 7;
            // 
            // rnoBoxSrc
            // 
            rnoBoxSrc.Location = new Point(188, 83);
            rnoBoxSrc.Name = "rnoBoxSrc";
            rnoBoxSrc.Size = new Size(333, 27);
            rnoBoxSrc.TabIndex = 6;
            // 
            // idBoxSrc
            // 
            idBoxSrc.Location = new Point(188, 47);
            idBoxSrc.Name = "idBoxSrc";
            idBoxSrc.Size = new Size(333, 27);
            idBoxSrc.TabIndex = 5;
            // 
            // nameBoxSrc
            // 
            nameBoxSrc.Location = new Point(188, 10);
            nameBoxSrc.Name = "nameBoxSrc";
            nameBoxSrc.Size = new Size(333, 27);
            nameBoxSrc.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 123);
            label4.Name = "label4";
            label4.Size = new Size(126, 20);
            label4.TabIndex = 3;
            label4.Text = "Номер паспорта";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 90);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "РНОКПП";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 50);
            label2.Name = "label2";
            label2.Size = new Size(140, 20);
            label2.TabIndex = 1;
            label2.Text = "Особовий рахунок";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 17);
            label1.Name = "label1";
            label1.Size = new Size(33, 20);
            label1.TabIndex = 0;
            label1.Text = "ПІБ";
            // 
            // clientBindingSource
            // 
            clientBindingSource.DataSource = typeof(Models.Client);
            // 
            // resultGridView
            // 
            resultGridView.Anchor = AnchorStyles.Top;
            resultGridView.AutoGenerateColumns = false;
            resultGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, LastOperation, DepositCategory, nameDataGridViewTextBoxColumn, rNOKPPDataGridViewTextBoxColumn, passportNumDataGridViewTextBoxColumn, balanceDataGridViewTextBoxColumn });
            resultGridView.DataSource = clientBindingSource;
            resultGridView.GridColor = SystemColors.InfoText;
            resultGridView.Location = new Point(35, 248);
            resultGridView.MultiSelect = false;
            resultGridView.Name = "resultGridView";
            resultGridView.ReadOnly = true;
            resultGridView.RowHeadersWidth = 51;
            resultGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            resultGridView.Size = new Size(972, 414);
            resultGridView.TabIndex = 10;
            resultGridView.CellContentClick += resultGridView_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Особистий рахунок";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // LastOperation
            // 
            LastOperation.DataPropertyName = "LastOperation";
            LastOperation.HeaderText = "Дата останньої операції";
            LastOperation.MinimumWidth = 6;
            LastOperation.Name = "LastOperation";
            LastOperation.ReadOnly = true;
            LastOperation.Width = 125;
            // 
            // DepositCategory
            // 
            DepositCategory.DataPropertyName = "DepositCategory";
            DepositCategory.HeaderText = "Категорія депозиту";
            DepositCategory.MinimumWidth = 6;
            DepositCategory.Name = "DepositCategory";
            DepositCategory.ReadOnly = true;
            DepositCategory.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "ПІБ";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // rNOKPPDataGridViewTextBoxColumn
            // 
            rNOKPPDataGridViewTextBoxColumn.DataPropertyName = "RNOKPP";
            rNOKPPDataGridViewTextBoxColumn.HeaderText = "РНОКПП";
            rNOKPPDataGridViewTextBoxColumn.MinimumWidth = 6;
            rNOKPPDataGridViewTextBoxColumn.Name = "rNOKPPDataGridViewTextBoxColumn";
            rNOKPPDataGridViewTextBoxColumn.ReadOnly = true;
            rNOKPPDataGridViewTextBoxColumn.Width = 125;
            // 
            // passportNumDataGridViewTextBoxColumn
            // 
            passportNumDataGridViewTextBoxColumn.DataPropertyName = "PassportNum";
            passportNumDataGridViewTextBoxColumn.HeaderText = "Номер паспорта";
            passportNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            passportNumDataGridViewTextBoxColumn.Name = "passportNumDataGridViewTextBoxColumn";
            passportNumDataGridViewTextBoxColumn.ReadOnly = true;
            passportNumDataGridViewTextBoxColumn.Width = 125;
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            balanceDataGridViewTextBoxColumn.HeaderText = "Рахунок";
            balanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            balanceDataGridViewTextBoxColumn.ReadOnly = true;
            balanceDataGridViewTextBoxColumn.Width = 125;
            // 
            // timer1
            // 
            timer1.Interval = 86400000;
            timer1.Tick += timer1_Tick;
            // 
            // Clients_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 686);
            Controls.Add(resultGridView);
            Controls.Add(panel1);
            MinimumSize = new Size(1081, 733);
            Name = "Clients_Form";
            Text = "Clients_Form";
            FormClosing += Clients_Form_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)resultGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox idBoxSrc;
        private TextBox nameBoxSrc;
        private Label label4;
        private Button searchButton;
        private TextBox passportBoxSrc;
        private TextBox rnoBoxSrc;
        private BindingSource clientBindingSource;
        private DataGridView resultGridView;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn LastOperation;
        private DataGridViewTextBoxColumn DepositCategory;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rNOKPPDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passportNumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Timer timer1;
    }
}