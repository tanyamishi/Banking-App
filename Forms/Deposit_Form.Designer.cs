namespace Banking_App.Forms
{
    partial class Deposit_Form
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
            panel1 = new Panel();
            cancelButton = new Button();
            saveButton = new Button();
            terminUpDown = new NumericUpDown();
            label4 = new Label();
            categoryBox = new ComboBox();
            sumUpDown = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            percentUpDown = new NumericUpDown();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)terminUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sumUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)percentUpDown).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Linen;
            panel1.Controls.Add(percentUpDown);
            panel1.Controls.Add(cancelButton);
            panel1.Controls.Add(saveButton);
            panel1.Controls.Add(terminUpDown);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(categoryBox);
            panel1.Controls.Add(sumUpDown);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(107, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(536, 411);
            panel1.TabIndex = 0;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(315, 326);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(123, 45);
            cancelButton.TabIndex = 9;
            cancelButton.Text = "Відміна";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(100, 326);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(118, 45);
            saveButton.TabIndex = 8;
            saveButton.Text = "Зберегти";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // terminUpDown
            // 
            terminUpDown.Location = new Point(214, 241);
            terminUpDown.Name = "terminUpDown";
            terminUpDown.Size = new Size(213, 27);
            terminUpDown.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 248);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 6;
            label4.Text = "Термін(міс.):";
            // 
            // categoryBox
            // 
            categoryBox.FormattingEnabled = true;
            categoryBox.Items.AddRange(new object[] { "Терміновий вклад", "Вклад до запитанння" });
            categoryBox.Location = new Point(214, 99);
            categoryBox.Name = "categoryBox";
            categoryBox.Size = new Size(213, 28);
            categoryBox.TabIndex = 4;
            // 
            // sumUpDown
            // 
            sumUpDown.Location = new Point(214, 30);
            sumUpDown.Maximum = new decimal(new int[] { -402653184, -1613725636, 54210108, 0 });
            sumUpDown.Name = "sumUpDown";
            sumUpDown.Size = new Size(213, 27);
            sumUpDown.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 174);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 2;
            label3.Text = "Відсоток:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 107);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 1;
            label2.Text = "Категорія вкладу:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 37);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 0;
            label1.Text = "Сума вкладу:";
            // 
            // percentUpDown
            // 
            percentUpDown.Location = new Point(214, 167);
            percentUpDown.Name = "percentUpDown";
            percentUpDown.Size = new Size(213, 27);
            percentUpDown.TabIndex = 5;
            // 
            // Deposit_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Deposit_Form";
            Text = "Внесок";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)terminUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)sumUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)percentUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown sumUpDown;
        private ComboBox categoryBox;
        private NumericUpDown terminUpDown;
        private Label label4;
        private Button cancelButton;
        private Button saveButton;
        private NumericUpDown percentUpDown;
    }
}