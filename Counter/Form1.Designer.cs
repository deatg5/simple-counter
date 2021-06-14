
namespace Counter
{
    partial class Form1
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
            this.lstCounters = new System.Windows.Forms.ListBox();
            this.btnNotStonks = new System.Windows.Forms.Button();
            this.btnStonks = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnIncreaseChange = new System.Windows.Forms.Button();
            this.btnDecreaseChange = new System.Windows.Forms.Button();
            this.lblIncreaseKey = new System.Windows.Forms.Label();
            this.lblDecreaseKey = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnClearIncreaseHotkey = new System.Windows.Forms.Button();
            this.btnClearDecreaseHotkey = new System.Windows.Forms.Button();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.numIncAmount = new System.Windows.Forms.NumericUpDown();
            this.lblIncAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numIncAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // lstCounters
            // 
            this.lstCounters.FormattingEnabled = true;
            this.lstCounters.ItemHeight = 15;
            this.lstCounters.Location = new System.Drawing.Point(12, 31);
            this.lstCounters.Name = "lstCounters";
            this.lstCounters.Size = new System.Drawing.Size(220, 259);
            this.lstCounters.TabIndex = 0;
            this.lstCounters.SelectedIndexChanged += new System.EventHandler(this.lstCounters_SelectedIndexChanged);
            // 
            // btnNotStonks
            // 
            this.btnNotStonks.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNotStonks.Location = new System.Drawing.Point(285, 270);
            this.btnNotStonks.Name = "btnNotStonks";
            this.btnNotStonks.Size = new System.Drawing.Size(75, 73);
            this.btnNotStonks.TabIndex = 2;
            this.btnNotStonks.Text = "-";
            this.btnNotStonks.UseVisualStyleBackColor = true;
            this.btnNotStonks.Click += new System.EventHandler(this.btnNotStonks_Click);
            // 
            // btnStonks
            // 
            this.btnStonks.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStonks.Location = new System.Drawing.Point(285, 190);
            this.btnStonks.Name = "btnStonks";
            this.btnStonks.Size = new System.Drawing.Size(75, 73);
            this.btnStonks.TabIndex = 3;
            this.btnStonks.Text = "+";
            this.btnStonks.UseVisualStyleBackColor = true;
            this.btnStonks.Click += new System.EventHandler(this.btnStonks_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(12, 297);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(125, 23);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "New Counter";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(12, 326);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(125, 23);
            this.btnChange.TabIndex = 5;
            this.btnChange.Text = "Change Name";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 355);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Symbol", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCount.Location = new System.Drawing.Point(275, 83);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(66, 78);
            this.lblCount.TabIndex = 7;
            this.lblCount.Text = "0";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(143, 297);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(89, 23);
            this.txtName.TabIndex = 8;
            this.txtName.Text = "Name";
            // 
            // btnIncreaseChange
            // 
            this.btnIncreaseChange.Location = new System.Drawing.Point(12, 429);
            this.btnIncreaseChange.Name = "btnIncreaseChange";
            this.btnIncreaseChange.Size = new System.Drawing.Size(75, 23);
            this.btnIncreaseChange.TabIndex = 9;
            this.btnIncreaseChange.Text = "Change";
            this.btnIncreaseChange.UseVisualStyleBackColor = true;
            this.btnIncreaseChange.Click += new System.EventHandler(this.btnIncreaseChange_Click);
            // 
            // btnDecreaseChange
            // 
            this.btnDecreaseChange.Location = new System.Drawing.Point(226, 429);
            this.btnDecreaseChange.Name = "btnDecreaseChange";
            this.btnDecreaseChange.Size = new System.Drawing.Size(76, 23);
            this.btnDecreaseChange.TabIndex = 10;
            this.btnDecreaseChange.Text = "Change";
            this.btnDecreaseChange.UseVisualStyleBackColor = true;
            this.btnDecreaseChange.Click += new System.EventHandler(this.btnDecreaseChange_Click);
            // 
            // lblIncreaseKey
            // 
            this.lblIncreaseKey.AutoSize = true;
            this.lblIncreaseKey.Location = new System.Drawing.Point(12, 411);
            this.lblIncreaseKey.Name = "lblIncreaseKey";
            this.lblIncreaseKey.Size = new System.Drawing.Size(154, 15);
            this.lblIncreaseKey.TabIndex = 11;
            this.lblIncreaseKey.Text = "Increase hotkey set to: none";
            this.lblIncreaseKey.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDecreaseKey
            // 
            this.lblDecreaseKey.AutoSize = true;
            this.lblDecreaseKey.Location = new System.Drawing.Point(226, 411);
            this.lblDecreaseKey.Name = "lblDecreaseKey";
            this.lblDecreaseKey.Size = new System.Drawing.Size(158, 15);
            this.lblDecreaseKey.TabIndex = 12;
            this.lblDecreaseKey.Text = "Decrease hotkey set to: none";
            this.lblDecreaseKey.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Location = new System.Drawing.Point(12, 482);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(429, 30);
            this.lblWarning.TabIndex = 13;
            this.lblWarning.Text = "Note: you\'ll unfortunately be unable to use these hotkeys for anything else;\r\nyou" +
    " won\'t be able to type \"E\" in any other applications if you set the hotkey to E." +
    "";
            // 
            // btnClearIncreaseHotkey
            // 
            this.btnClearIncreaseHotkey.Location = new System.Drawing.Point(12, 456);
            this.btnClearIncreaseHotkey.Name = "btnClearIncreaseHotkey";
            this.btnClearIncreaseHotkey.Size = new System.Drawing.Size(75, 23);
            this.btnClearIncreaseHotkey.TabIndex = 14;
            this.btnClearIncreaseHotkey.Text = "Clear";
            this.btnClearIncreaseHotkey.UseVisualStyleBackColor = true;
            this.btnClearIncreaseHotkey.Click += new System.EventHandler(this.btnClearIncreaseHotkey_Click);
            // 
            // btnClearDecreaseHotkey
            // 
            this.btnClearDecreaseHotkey.Location = new System.Drawing.Point(227, 456);
            this.btnClearDecreaseHotkey.Name = "btnClearDecreaseHotkey";
            this.btnClearDecreaseHotkey.Size = new System.Drawing.Size(75, 23);
            this.btnClearDecreaseHotkey.TabIndex = 15;
            this.btnClearDecreaseHotkey.Text = "Clear";
            this.btnClearDecreaseHotkey.UseVisualStyleBackColor = true;
            this.btnClearDecreaseHotkey.Click += new System.EventHandler(this.btnClearDecreaseHotkey_Click);
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(143, 326);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(89, 23);
            this.txtNewName.TabIndex = 16;
            this.txtNewName.Text = "New name";
            // 
            // numIncAmount
            // 
            this.numIncAmount.Location = new System.Drawing.Point(367, 349);
            this.numIncAmount.Name = "numIncAmount";
            this.numIncAmount.Size = new System.Drawing.Size(74, 23);
            this.numIncAmount.TabIndex = 17;
            this.numIncAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblIncAmount
            // 
            this.lblIncAmount.AutoSize = true;
            this.lblIncAmount.Location = new System.Drawing.Point(263, 351);
            this.lblIncAmount.Name = "lblIncAmount";
            this.lblIncAmount.Size = new System.Drawing.Size(98, 15);
            this.lblIncAmount.TabIndex = 18;
            this.lblIncAmount.Text = "Increase amount:";
            this.lblIncAmount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 518);
            this.Controls.Add(this.lblIncAmount);
            this.Controls.Add(this.numIncAmount);
            this.Controls.Add(this.txtNewName);
            this.Controls.Add(this.btnClearDecreaseHotkey);
            this.Controls.Add(this.btnClearIncreaseHotkey);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.lblDecreaseKey);
            this.Controls.Add(this.lblIncreaseKey);
            this.Controls.Add(this.btnDecreaseChange);
            this.Controls.Add(this.btnIncreaseChange);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnStonks);
            this.Controls.Add(this.btnNotStonks);
            this.Controls.Add(this.lstCounters);
            this.Name = "Form1";
            this.Text = "Counter of deatg";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.numIncAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCounters;
        private System.Windows.Forms.Button btnNotStonks;
        private System.Windows.Forms.Button btnStonks;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnIncreaseChange;
        private System.Windows.Forms.Button btnDecreaseChange;
        private System.Windows.Forms.Label lblIncreaseKey;
        private System.Windows.Forms.Label lblDecreaseKey;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Button btnClearIncreaseHotkey;
        private System.Windows.Forms.Button btnClearDecreaseHotkey;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.NumericUpDown numIncAmount;
        private System.Windows.Forms.Label lblIncAmount;
    }
}

