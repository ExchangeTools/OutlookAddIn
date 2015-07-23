namespace OutlookAddIn
{
    partial class MoveForm
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
            this._srcFolderSelection = new System.Windows.Forms.Button();
            this._txtSrcFolder = new System.Windows.Forms.TextBox();
            this._btnTrgFolder = new System.Windows.Forms.Button();
            this._txtTrgFolder = new System.Windows.Forms.TextBox();
            this._btnMove = new System.Windows.Forms.Button();
            this._txtOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // _srcFolderSelection
            // 
            this._srcFolderSelection.Location = new System.Drawing.Point(7, 13);
            this._srcFolderSelection.Name = "_srcFolderSelection";
            this._srcFolderSelection.Size = new System.Drawing.Size(127, 27);
            this._srcFolderSelection.TabIndex = 0;
            this._srcFolderSelection.Text = "Select source folder";
            this._srcFolderSelection.UseVisualStyleBackColor = true;
            this._srcFolderSelection.Click += new System.EventHandler(this.m_srcFolderSelection_Click);
            // 
            // _txtSrcFolder
            // 
            this._txtSrcFolder.Enabled = false;
            this._txtSrcFolder.Location = new System.Drawing.Point(140, 17);
            this._txtSrcFolder.Name = "_txtSrcFolder";
            this._txtSrcFolder.Size = new System.Drawing.Size(388, 20);
            this._txtSrcFolder.TabIndex = 1;
            // 
            // _btnTrgFolder
            // 
            this._btnTrgFolder.Location = new System.Drawing.Point(7, 58);
            this._btnTrgFolder.Name = "_btnTrgFolder";
            this._btnTrgFolder.Size = new System.Drawing.Size(127, 27);
            this._btnTrgFolder.TabIndex = 2;
            this._btnTrgFolder.Text = "Select target folder";
            this._btnTrgFolder.UseVisualStyleBackColor = true;
            this._btnTrgFolder.Click += new System.EventHandler(this.m_btnTrgFolder_Click);
            // 
            // _txtTrgFolder
            // 
            this._txtTrgFolder.Enabled = false;
            this._txtTrgFolder.Location = new System.Drawing.Point(140, 62);
            this._txtTrgFolder.Name = "_txtTrgFolder";
            this._txtTrgFolder.Size = new System.Drawing.Size(388, 20);
            this._txtTrgFolder.TabIndex = 3;
            this._txtTrgFolder.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // _btnMove
            // 
            this._btnMove.Location = new System.Drawing.Point(11, 106);
            this._btnMove.Name = "_btnMove";
            this._btnMove.Size = new System.Drawing.Size(516, 103);
            this._btnMove.TabIndex = 4;
            this._btnMove.Text = "Move";
            this._btnMove.UseVisualStyleBackColor = true;
            this._btnMove.Click += new System.EventHandler(this.m_btnMove_Click);
            // 
            // _txtOutput
            // 
            this._txtOutput.Location = new System.Drawing.Point(11, 225);
            this._txtOutput.Name = "_txtOutput";
            this._txtOutput.Size = new System.Drawing.Size(515, 171);
            this._txtOutput.TabIndex = 5;
            this._txtOutput.Text = "";
            // 
            // MoveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 408);
            this.Controls.Add(this._txtOutput);
            this.Controls.Add(this._btnMove);
            this.Controls.Add(this._txtTrgFolder);
            this.Controls.Add(this._btnTrgFolder);
            this.Controls.Add(this._txtSrcFolder);
            this.Controls.Add(this._srcFolderSelection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MoveForm";
            this.ShowIcon = false;
            this.Text = "Move Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _srcFolderSelection;
        private System.Windows.Forms.TextBox _txtSrcFolder;
        private System.Windows.Forms.Button _btnTrgFolder;
        private System.Windows.Forms.TextBox _txtTrgFolder;
        private System.Windows.Forms.Button _btnMove;
        private System.Windows.Forms.RichTextBox _txtOutput;
    }
}