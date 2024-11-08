namespace Servicebus.Ui.WinForm
{
    partial class FrmMessage
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
            gridMessages = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            gridProperties = new DataGridView();
            key = new DataGridViewTextBoxColumn();
            value = new DataGridViewTextBoxColumn();
            txtPayload = new RichTextBox();
            panel1 = new Panel();
            label3 = new Label();
            txtQuantity = new TextBox();
            rbDeadLetterMessages = new RadioButton();
            rbActiveMessages = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)gridMessages).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridProperties).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // gridMessages
            // 
            gridMessages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridMessages.Location = new Point(3, 37);
            gridMessages.Name = "gridMessages";
            gridMessages.RowHeadersVisible = false;
            gridMessages.RowHeadersWidth = 62;
            gridMessages.RowTemplate.Height = 25;
            gridMessages.Size = new Size(617, 128);
            gridMessages.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 173);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 7;
            label2.Text = "Message:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(364, 173);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 6;
            label1.Text = "Properties:";
            // 
            // gridProperties
            // 
            gridProperties.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridProperties.Columns.AddRange(new DataGridViewColumn[] { key, value });
            gridProperties.Location = new Point(365, 190);
            gridProperties.Name = "gridProperties";
            gridProperties.RowHeadersWidth = 20;
            gridProperties.RowTemplate.Height = 20;
            gridProperties.Size = new Size(253, 196);
            gridProperties.TabIndex = 5;
            // 
            // key
            // 
            key.HeaderText = "Key";
            key.MinimumWidth = 8;
            key.Name = "key";
            key.Width = 110;
            // 
            // value
            // 
            value.HeaderText = "Value";
            value.MinimumWidth = 8;
            value.Name = "value";
            value.Width = 110;
            // 
            // txtPayload
            // 
            txtPayload.BorderStyle = BorderStyle.FixedSingle;
            txtPayload.Location = new Point(2, 190);
            txtPayload.Name = "txtPayload";
            txtPayload.Size = new Size(358, 196);
            txtPayload.TabIndex = 4;
            txtPayload.Text = "";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtQuantity);
            panel1.Controls.Add(rbDeadLetterMessages);
            panel1.Controls.Add(rbActiveMessages);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(347, 31);
            panel1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(214, 7);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 10;
            label3.Text = "Message Count";
            // 
            // txtQuantity
            // 
            txtQuantity.BorderStyle = BorderStyle.None;
            txtQuantity.Location = new Point(302, 7);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(30, 16);
            txtQuantity.TabIndex = 9;
            txtQuantity.Text = "1";
            txtQuantity.TextAlign = HorizontalAlignment.Center;
            // 
            // rbDeadLetterMessages
            // 
            rbDeadLetterMessages.AutoSize = true;
            rbDeadLetterMessages.Location = new Point(125, 5);
            rbDeadLetterMessages.Name = "rbDeadLetterMessages";
            rbDeadLetterMessages.Size = new Size(85, 19);
            rbDeadLetterMessages.TabIndex = 2;
            rbDeadLetterMessages.TabStop = true;
            rbDeadLetterMessages.Text = "Dead Letter";
            rbDeadLetterMessages.UseVisualStyleBackColor = true;
            // 
            // rbActiveMessages
            // 
            rbActiveMessages.AutoSize = true;
            rbActiveMessages.Checked = true;
            rbActiveMessages.Location = new Point(7, 5);
            rbActiveMessages.Name = "rbActiveMessages";
            rbActiveMessages.Size = new Size(112, 19);
            rbActiveMessages.TabIndex = 1;
            rbActiveMessages.TabStop = true;
            rbActiveMessages.Text = "Active Messages";
            rbActiveMessages.UseVisualStyleBackColor = true;
            // 
            // FrmMessage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 401);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(gridProperties);
            Controls.Add(txtPayload);
            Controls.Add(gridMessages);
            KeyPreview = true;
            Margin = new Padding(2);
            Name = "FrmMessage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Messages";
            Load += FrmMessage_Load;
            ((System.ComponentModel.ISupportInitialize)gridMessages).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridProperties).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridMessages;
        private Label label2;
        private Label label1;
        private DataGridView gridProperties;
        private DataGridViewTextBoxColumn key;
        private DataGridViewTextBoxColumn value;
        private RichTextBox txtPayload;
        private Panel panel1;
        private RadioButton rbDeadLetterMessages;
        private RadioButton rbActiveMessages;
        private TextBox txtQuantity;
        private Label label3;
    }
}