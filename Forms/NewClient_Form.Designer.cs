namespace Banking_App
{
    partial class NewClient_Form
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
            cancelButton = new Button();
            saveButton = new Button();
            passportBox = new TextBox();
            rnoBox = new TextBox();
            nameBox = new TextBox();
            idBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            nameErrorProvider = new ErrorProvider(components);
            rnoErrorProvider = new ErrorProvider(components);
            passportErrorProvider = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nameErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rnoErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passportErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.Linen;
            panel1.Controls.Add(cancelButton);
            panel1.Controls.Add(saveButton);
            panel1.Controls.Add(passportBox);
            panel1.Controls.Add(rnoBox);
            panel1.Controls.Add(nameBox);
            panel1.Controls.Add(idBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(80, 50);
            panel1.MinimumSize = new Size(664, 491);
            panel1.Name = "panel1";
            panel1.Size = new Size(664, 491);
            panel1.TabIndex = 0;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(393, 376);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(114, 37);
            cancelButton.TabIndex = 10;
            cancelButton.Text = "Відміна";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = SystemColors.GradientInactiveCaption;
            saveButton.Location = new Point(235, 375);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(117, 39);
            saveButton.TabIndex = 9;
            saveButton.Text = "Зберегти";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // passportBox
            // 
            passportBox.Location = new Point(235, 298);
            passportBox.Name = "passportBox";
            passportBox.Size = new Size(330, 27);
            passportBox.TabIndex = 8;
            // 
            // rnoBox
            // 
            rnoBox.Location = new Point(235, 233);
            rnoBox.Name = "rnoBox";
            rnoBox.Size = new Size(330, 27);
            rnoBox.TabIndex = 7;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(235, 170);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(330, 27);
            nameBox.TabIndex = 6;
            // 
            // idBox
            // 
            idBox.Enabled = false;
            idBox.Location = new Point(235, 112);
            idBox.Name = "idBox";
            idBox.Size = new Size(330, 27);
            idBox.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 305);
            label5.Name = "label5";
            label5.Size = new Size(126, 20);
            label5.TabIndex = 4;
            label5.Text = "Номер паспорта";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 240);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "РНОКПП";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 177);
            label3.Name = "label3";
            label3.Size = new Size(33, 20);
            label3.TabIndex = 2;
            label3.Text = "ПІБ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 119);
            label2.Name = "label2";
            label2.Size = new Size(197, 20);
            label2.TabIndex = 1;
            label2.Text = "Номер особового рахунку:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(253, 13);
            label1.Name = "label1";
            label1.Size = new Size(136, 25);
            label1.TabIndex = 0;
            label1.Text = "Новий клієнт";
            // 
            // nameErrorProvider
            // 
            nameErrorProvider.ContainerControl = this;
            // 
            // rnoErrorProvider
            // 
            rnoErrorProvider.ContainerControl = this;
            // 
            // passportErrorProvider
            // 
            passportErrorProvider.ContainerControl = this;
            // 
            // NewClient_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 575);
            Controls.Add(panel1);
            MinimumSize = new Size(880, 622);
            Name = "NewClient_Form";
            Text = "NewAccount_Form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nameErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)rnoErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)passportErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Button saveButton;
        private TextBox passportBox;
        private TextBox rnoBox;
        private TextBox nameBox;
        private TextBox idBox;
        private Label label5;
        private Label label4;
        private Button cancelButton;
        private ErrorProvider nameErrorProvider;
        private ErrorProvider rnoErrorProvider;
        private ErrorProvider passportErrorProvider;
    }
}