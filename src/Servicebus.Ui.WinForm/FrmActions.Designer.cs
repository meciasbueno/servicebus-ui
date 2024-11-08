namespace Servicebus.Ui.WinForm
{
    partial class FrmActions
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
            btPurgeDeadLetterAllTopics = new Button();
            btRemoveSubsWithActiveMsg = new Button();
            SuspendLayout();
            // 
            // btPurgeDeadLetterAllTopics
            // 
            btPurgeDeadLetterAllTopics.Location = new Point(12, 59);
            btPurgeDeadLetterAllTopics.Name = "btPurgeDeadLetterAllTopics";
            btPurgeDeadLetterAllTopics.Size = new Size(255, 23);
            btPurgeDeadLetterAllTopics.TabIndex = 10;
            btPurgeDeadLetterAllTopics.Text = "Purge dead letter all topics";
            btPurgeDeadLetterAllTopics.UseVisualStyleBackColor = true;
            btPurgeDeadLetterAllTopics.Click += btPurgeDeadLetterAllTopics_Click;
            // 
            // btRemoveSubsWithActiveMsg
            // 
            btRemoveSubsWithActiveMsg.Enabled = false;
            btRemoveSubsWithActiveMsg.Location = new Point(12, 14);
            btRemoveSubsWithActiveMsg.Name = "btRemoveSubsWithActiveMsg";
            btRemoveSubsWithActiveMsg.Size = new Size(255, 23);
            btRemoveSubsWithActiveMsg.TabIndex = 9;
            btRemoveSubsWithActiveMsg.Text = "Remove subscriptions with active msgs >=2";
            btRemoveSubsWithActiveMsg.UseVisualStyleBackColor = true;
            btRemoveSubsWithActiveMsg.Click += btRemoveSubsWithActiveMsg_Click;
            // 
            // FrmActions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 98);
            Controls.Add(btPurgeDeadLetterAllTopics);
            Controls.Add(btRemoveSubsWithActiveMsg);
            Name = "FrmActions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actions";
            ResumeLayout(false);
        }

        #endregion

        private Button btPurgeDeadLetterAllTopics;
        private Button btRemoveSubsWithActiveMsg;
    }
}