namespace Banking_App.Forms
{
    partial class Withdraw_Form
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
            withdrawSaveButton = new Button();
            withdrawSumUpDown = new NumericUpDown();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)withdrawSumUpDown).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Linen;
            panel1.Controls.Add(cancelButton);
            panel1.Controls.Add(withdrawSaveButton);
            panel1.Controls.Add(withdrawSumUpDown);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(81, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(623, 384);
            panel1.TabIndex = 0;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(376, 283);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(112, 51);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "Відміна";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // withdrawSaveButton
            // 
            withdrawSaveButton.Location = new Point(86, 283);
            withdrawSaveButton.Name = "withdrawSaveButton";
            withdrawSaveButton.Size = new Size(126, 51);
            withdrawSaveButton.TabIndex = 2;
            withdrawSaveButton.Text = "Зняти";
            withdrawSaveButton.UseVisualStyleBackColor = true;
            withdrawSaveButton.Click += withdrawSaveButton_Click;
            // 
            // withdrawSumUpDown
            // 
            withdrawSumUpDown.BackColor = SystemColors.Control;
            withdrawSumUpDown.Location = new Point(133, 133);
            withdrawSumUpDown.Maximum = new decimal(new int[] { -402653184, -1613725636, 54210108, 0 });
            withdrawSumUpDown.Name = "withdrawSumUpDown";
            withdrawSumUpDown.Size = new Size(336, 27);
            withdrawSumUpDown.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 140);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 0;
            label1.Text = "Сума";
            // 
            // Withdraw_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Withdraw_Form";
            Text = "Withdraw_Form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)withdrawSumUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private NumericUpDown withdrawSumUpDown;
        private Label label1;
        private Button cancelButton;
        private Button withdrawSaveButton;
    }
}