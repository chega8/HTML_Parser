namespace HTML_Parser
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.ListTitles = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NumericStart = new System.Windows.Forms.NumericUpDown();
            this.NumericEnd = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonAbort = new System.Windows.Forms.Button();
            this.httpClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lowercost = new System.Windows.Forms.TextBox();
            this.uppercost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.httpClientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ListTitles
            // 
            this.ListTitles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListTitles.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ListTitles.FormattingEnabled = true;
            this.ListTitles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ListTitles.Location = new System.Drawing.Point(12, 12);
            this.ListTitles.Name = "ListTitles";
            this.ListTitles.Size = new System.Drawing.Size(446, 290);
            this.ListTitles.TabIndex = 0;
            this.ListTitles.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListTitles_MouseClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start Point";
            // 
            // NumericStart
            // 
            this.NumericStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumericStart.Location = new System.Drawing.Point(467, 28);
            this.NumericStart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericStart.Name = "NumericStart";
            this.NumericStart.Size = new System.Drawing.Size(99, 20);
            this.NumericStart.TabIndex = 2;
            this.NumericStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumericEnd
            // 
            this.NumericEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumericEnd.Location = new System.Drawing.Point(467, 70);
            this.NumericEnd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericEnd.Name = "NumericEnd";
            this.NumericEnd.Size = new System.Drawing.Size(99, 20);
            this.NumericEnd.TabIndex = 4;
            this.NumericEnd.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "End Point";
            // 
            // ButtonStart
            // 
            this.ButtonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonStart.Location = new System.Drawing.Point(467, 109);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(99, 23);
            this.ButtonStart.TabIndex = 5;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ButtonAbort
            // 
            this.ButtonAbort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAbort.Location = new System.Drawing.Point(467, 138);
            this.ButtonAbort.Name = "ButtonAbort";
            this.ButtonAbort.Size = new System.Drawing.Size(99, 23);
            this.ButtonAbort.TabIndex = 6;
            this.ButtonAbort.Text = "Abort";
            this.ButtonAbort.UseVisualStyleBackColor = true;
            this.ButtonAbort.Click += new System.EventHandler(this.ButtonAbort_Click);
            // 
            // httpClientBindingSource
            // 
            this.httpClientBindingSource.DataSource = typeof(System.Net.Http.HttpClient);
            // 
            // lowercost
            // 
            this.lowercost.Location = new System.Drawing.Point(464, 210);
            this.lowercost.Name = "lowercost";
            this.lowercost.Size = new System.Drawing.Size(98, 20);
            this.lowercost.TabIndex = 7;
            this.lowercost.Text = "10000";
            // 
            // uppercost
            // 
            this.uppercost.Location = new System.Drawing.Point(464, 261);
            this.uppercost.Name = "uppercost";
            this.uppercost.Size = new System.Drawing.Size(98, 20);
            this.uppercost.TabIndex = 8;
            this.uppercost.Text = "17000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(464, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "lower cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "upper cost";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 311);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uppercost);
            this.Controls.Add(this.lowercost);
            this.Controls.Add(this.ButtonAbort);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.NumericEnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumericStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListTitles);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AvitoParser";
            ((System.ComponentModel.ISupportInitialize)(this.NumericStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.httpClientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListTitles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumericStart;
        private System.Windows.Forms.NumericUpDown NumericEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button ButtonAbort;
        private System.Windows.Forms.BindingSource httpClientBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox lowercost;
        private System.Windows.Forms.TextBox uppercost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

