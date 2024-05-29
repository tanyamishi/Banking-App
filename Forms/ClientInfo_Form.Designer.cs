namespace Banking_App
{
    partial class ClientInfo_Form
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
            splitContainer1 = new SplitContainer();
            passportBoxInf = new TextBox();
            rnoBoxInf = new TextBox();
            nameBoxInf = new TextBox();
            idBoxInf = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            terminBox = new TextBox();
            categoryTextBox = new TextBox();
            label9 = new Label();
            label8 = new Label();
            lastOperationBox = new TextBox();
            label7 = new Label();
            balanceBox = new TextBox();
            label6 = new Label();
            withdrawButton = new Button();
            dpositButton = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.ActiveBorder;
            splitContainer1.Panel1.Controls.Add(passportBoxInf);
            splitContainer1.Panel1.Controls.Add(rnoBoxInf);
            splitContainer1.Panel1.Controls.Add(nameBoxInf);
            splitContainer1.Panel1.Controls.Add(idBoxInf);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.Linen;
            splitContainer1.Panel2.Controls.Add(terminBox);
            splitContainer1.Panel2.Controls.Add(categoryTextBox);
            splitContainer1.Panel2.Controls.Add(label9);
            splitContainer1.Panel2.Controls.Add(label8);
            splitContainer1.Panel2.Controls.Add(lastOperationBox);
            splitContainer1.Panel2.Controls.Add(label7);
            splitContainer1.Panel2.Controls.Add(balanceBox);
            splitContainer1.Panel2.Controls.Add(label6);
            splitContainer1.Panel2.Controls.Add(withdrawButton);
            splitContainer1.Panel2.Controls.Add(dpositButton);
            splitContainer1.Size = new Size(1153, 611);
            splitContainer1.SplitterDistance = 414;
            splitContainer1.TabIndex = 0;
            // 
            // passportBoxInf
            // 
            passportBoxInf.Location = new Point(12, 400);
            passportBoxInf.Name = "passportBoxInf";
            passportBoxInf.Size = new Size(378, 27);
            passportBoxInf.TabIndex = 9;
            // 
            // rnoBoxInf
            // 
            rnoBoxInf.Location = new Point(13, 311);
            rnoBoxInf.Name = "rnoBoxInf";
            rnoBoxInf.Size = new Size(377, 27);
            rnoBoxInf.TabIndex = 8;
            // 
            // nameBoxInf
            // 
            nameBoxInf.Location = new Point(13, 215);
            nameBoxInf.Name = "nameBoxInf";
            nameBoxInf.Size = new Size(377, 27);
            nameBoxInf.TabIndex = 7;
            // 
            // idBoxInf
            // 
            idBoxInf.Enabled = false;
            idBoxInf.Location = new Point(13, 123);
            idBoxInf.Name = "idBoxInf";
            idBoxInf.Size = new Size(377, 27);
            idBoxInf.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 357);
            label5.Name = "label5";
            label5.Size = new Size(126, 20);
            label5.TabIndex = 5;
            label5.Text = "Номер паспорта";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 273);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 4;
            label4.Text = "РНОКПП";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 182);
            label3.Name = "label3";
            label3.Size = new Size(33, 20);
            label3.TabIndex = 3;
            label3.Text = "ПІБ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 89);
            label2.Name = "label2";
            label2.Size = new Size(197, 20);
            label2.TabIndex = 2;
            label2.Text = "Номер особового рахунку:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(158, 27);
            label1.Name = "label1";
            label1.Size = new Size(122, 25);
            label1.TabIndex = 0;
            label1.Text = "Інформація";
            // 
            // terminBox
            // 
            terminBox.Location = new Point(217, 328);
            terminBox.Name = "terminBox";
            terminBox.Size = new Size(360, 27);
            terminBox.TabIndex = 9;
            // 
            // categoryTextBox
            // 
            categoryTextBox.Location = new Point(220, 249);
            categoryTextBox.Name = "categoryTextBox";
            categoryTextBox.ReadOnly = true;
            categoryTextBox.Size = new Size(357, 27);
            categoryTextBox.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(37, 335);
            label9.Name = "label9";
            label9.Size = new Size(93, 20);
            label9.TabIndex = 7;
            label9.Text = "Термін(міс.)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 256);
            label8.Name = "label8";
            label8.Size = new Size(126, 20);
            label8.TabIndex = 6;
            label8.Text = "Категорія внеску";
            // 
            // lastOperationBox
            // 
            lastOperationBox.Location = new Point(230, 89);
            lastOperationBox.Name = "lastOperationBox";
            lastOperationBox.ReadOnly = true;
            lastOperationBox.Size = new Size(347, 27);
            lastOperationBox.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 89);
            label7.Name = "label7";
            label7.Size = new Size(178, 20);
            label7.TabIndex = 4;
            label7.Text = "Дата останньої операції";
            // 
            // balanceBox
            // 
            balanceBox.Location = new Point(230, 163);
            balanceBox.Name = "balanceBox";
            balanceBox.ReadOnly = true;
            balanceBox.Size = new Size(347, 27);
            balanceBox.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 170);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 2;
            label6.Text = "Баланс";
            // 
            // withdrawButton
            // 
            withdrawButton.Location = new Point(445, 437);
            withdrawButton.Name = "withdrawButton";
            withdrawButton.Size = new Size(132, 50);
            withdrawButton.TabIndex = 1;
            withdrawButton.Text = "Зняти кошти";
            withdrawButton.UseVisualStyleBackColor = true;
            withdrawButton.Click += withdrawButton_Click;
            // 
            // dpositButton
            // 
            dpositButton.Location = new Point(143, 437);
            dpositButton.Name = "dpositButton";
            dpositButton.Size = new Size(126, 50);
            dpositButton.TabIndex = 0;
            dpositButton.Text = "Зробити внесок";
            dpositButton.UseVisualStyleBackColor = true;
            dpositButton.Click += dpositButton_Click;
            // 
            // ClientInfo_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1153, 611);
            Controls.Add(splitContainer1);
            MinimumSize = new Size(1171, 658);
            Name = "ClientInfo_Form";
            Text = "ClientInfo_Form";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox passportBoxInf;
        private TextBox rnoBoxInf;
        private TextBox nameBoxInf;
        private TextBox idBoxInf;
        private Label label5;
        private Label label6;
        private Button withdrawButton;
        private Button dpositButton;
        private Label label7;
        private TextBox balanceBox;
        private TextBox lastOperationBox;
        private TextBox terminBox;
        private TextBox categoryTextBox;
        private Label label9;
        private Label label8;
    }
}