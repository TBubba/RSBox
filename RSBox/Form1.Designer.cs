namespace RSBox
{
    partial class Form1
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
            this._bRemoveHTML = new System.Windows.Forms.Button();
            this._browser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // _bRemoveHTML
            // 
            this._bRemoveHTML.Location = new System.Drawing.Point(4, 3);
            this._bRemoveHTML.Name = "_bRemoveHTML";
            this._bRemoveHTML.Size = new System.Drawing.Size(162, 23);
            this._bRemoveHTML.TabIndex = 1;
            this._bRemoveHTML.Text = "Remove other HTML content";
            this._bRemoveHTML.UseVisualStyleBackColor = true;
            this._bRemoveHTML.Click += new System.EventHandler(this._bRemoveHTML_Click);
            // 
            // _browser
            // 
            this._browser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._browser.Location = new System.Drawing.Point(1, 32);
            this._browser.Margin = new System.Windows.Forms.Padding(0);
            this._browser.MinimumSize = new System.Drawing.Size(20, 20);
            this._browser.Name = "_browser";
            this._browser.ScriptErrorsSuppressed = true;
            this._browser.ScrollBarsEnabled = false;
            this._browser.Size = new System.Drawing.Size(760, 500);
            this._browser.TabIndex = 0;
            this._browser.WebBrowserShortcutsEnabled = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 533);
            this.Controls.Add(this._browser);
            this.Controls.Add(this._bRemoveHTML);
            this.Name = "Form1";
            this.Text = "RSBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _bRemoveHTML;
        private System.Windows.Forms.WebBrowser _browser;
    }
}

