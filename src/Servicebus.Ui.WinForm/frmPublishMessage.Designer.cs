namespace Servicebus.Ui.WinForm
{
    partial class FrmPublishMessage
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
            txtPayload = new RichTextBox();
            gridProperties = new DataGridView();
            key = new DataGridViewTextBoxColumn();
            value = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            btPublish = new Button();
            panel1 = new Panel();
            rbXml = new RadioButton();
            rbText = new RadioButton();
            rbJson = new RadioButton();
            txtQuantity = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridProperties).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtPayload
            // 
            txtPayload.Location = new Point(0, 21);
            txtPayload.Name = "txtPayload";
            txtPayload.Size = new Size(359, 299);
            txtPayload.TabIndex = 0;
            txtPayload.Text = "";
            // 
            // gridProperties
            // 
            gridProperties.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridProperties.Columns.AddRange(new DataGridViewColumn[] { key, value });
            gridProperties.Location = new Point(363, 21);
            gridProperties.Name = "gridProperties";
            gridProperties.RowHeadersWidth = 20;
            gridProperties.RowTemplate.Height = 20;
            gridProperties.Size = new Size(253, 299);
            gridProperties.TabIndex = 1;
            // 
            // key
            // 
            key.HeaderText = "Key";
            key.Name = "key";
            key.Width = 110;
            // 
            // value
            // 
            value.HeaderText = "Value";
            value.Name = "value";
            value.Width = 110;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(363, 4);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 2;
            label1.Text = "Properties:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 4);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 3;
            label2.Text = "Message:";
            // 
            // btPublish
            // 
            btPublish.Location = new Point(532, 328);
            btPublish.Name = "btPublish";
            btPublish.Size = new Size(75, 23);
            btPublish.TabIndex = 4;
            btPublish.Text = "Publish";
            btPublish.UseVisualStyleBackColor = true;
            btPublish.Click += btPublish_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(rbXml);
            panel1.Controls.Add(rbText);
            panel1.Controls.Add(rbJson);
            panel1.Location = new Point(294, 324);
            panel1.Name = "panel1";
            panel1.Size = new Size(155, 31);
            panel1.TabIndex = 7;
            // 
            // rbXml
            // 
            rbXml.AutoSize = true;
            rbXml.Location = new Point(105, 6);
            rbXml.Name = "rbXml";
            rbXml.Size = new Size(46, 19);
            rbXml.TabIndex = 3;
            rbXml.TabStop = true;
            rbXml.Text = "Xml";
            rbXml.UseVisualStyleBackColor = true;
            // 
            // rbText
            // 
            rbText.AutoSize = true;
            rbText.Location = new Point(55, 6);
            rbText.Name = "rbText";
            rbText.Size = new Size(46, 19);
            rbText.TabIndex = 2;
            rbText.TabStop = true;
            rbText.Text = "Text";
            rbText.UseVisualStyleBackColor = true;
            // 
            // rbJson
            // 
            rbJson.AutoSize = true;
            rbJson.Checked = true;
            rbJson.Location = new Point(7, 6);
            rbJson.Name = "rbJson";
            rbJson.Size = new Size(48, 19);
            rbJson.TabIndex = 1;
            rbJson.TabStop = true;
            rbJson.Text = "Json";
            rbJson.UseVisualStyleBackColor = true;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(488, 328);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(26, 23);
            txtQuantity.TabIndex = 4;
            txtQuantity.Text = "1";
            txtQuantity.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(515, 335);
            label3.Name = "label3";
            label3.Size = new Size(13, 15);
            label3.TabIndex = 8;
            label3.Text = "x";
            // 
            // FrmPublishMessage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 358);
            Controls.Add(label3);
            Controls.Add(txtQuantity);
            Controls.Add(panel1);
            Controls.Add(btPublish);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(gridProperties);
            Controls.Add(txtPayload);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            Name = "FrmPublishMessage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Publish Message to";
            Load += frmPublishMessage_Load;
            ((System.ComponentModel.ISupportInitialize)gridProperties).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtPayload;
        private DataGridView gridProperties;
        private Label label1;
        private Label label2;
        private Button btPublish;
        private Panel panel1;
        private RadioButton rbJson;
        private RadioButton rbText;
        private RadioButton rbXml;
        private DataGridViewTextBoxColumn key;
        private DataGridViewTextBoxColumn value;
        private TextBox txtQuantity;
        private Label label3;
    }
}