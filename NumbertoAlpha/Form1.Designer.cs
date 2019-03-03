namespace NumbertoAlpha
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
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.userinput = new System.Windows.Forms.TextBox();
            this.ConvertStringBreak = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Show = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // userinput
            // 
            this.userinput.Location = new System.Drawing.Point(34, 31);
            this.userinput.Name = "userinput";
            this.userinput.Size = new System.Drawing.Size(204, 20);
            this.userinput.TabIndex = 0;
            this.userinput.TextChanged += new System.EventHandler(this.userinput_TextChanged);
            // 
            // ConvertStringBreak
            // 
            this.ConvertStringBreak.Location = new System.Drawing.Point(274, 29);
            this.ConvertStringBreak.Name = "ConvertStringBreak";
            this.ConvertStringBreak.Size = new System.Drawing.Size(75, 23);
            this.ConvertStringBreak.TabIndex = 1;
            this.ConvertStringBreak.Text = "Search";
            this.ConvertStringBreak.UseVisualStyleBackColor = true;
            this.ConvertStringBreak.Click += new System.EventHandler(this.ConvertStringBreak_Click);
            // 
            // Show
            // 
            this.Show.AutoSize = true;
            this.Show.Location = new System.Drawing.Point(236, 92);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(87, 13);
            this.Show.TabIndex = 2;
            this.Show.Text = "Total will go here";
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Location = new System.Drawing.Point(59, 92);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(146, 13);
            this.Number.TabIndex = 3;
            this.Number.Text = "Assigned Number will go here";
            this.Number.Click += new System.EventHandler(this.Number_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.ConvertStringBreak);
            this.Controls.Add(this.userinput);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox userinput;
        private System.Windows.Forms.Button ConvertStringBreak;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label Show;
        private System.Windows.Forms.Label Number;
    }
}

