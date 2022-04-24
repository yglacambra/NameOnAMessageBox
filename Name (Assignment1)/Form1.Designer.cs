namespace Name__Assignment1_
{
    partial class MyName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyName));
            this.NameButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MyPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MyPic)).BeginInit();
            this.SuspendLayout();
            // 
            // NameButton
            // 
            this.NameButton.BackColor = System.Drawing.Color.Cyan;
            this.NameButton.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameButton.ForeColor = System.Drawing.Color.Purple;
            this.NameButton.Location = new System.Drawing.Point(243, 145);
            this.NameButton.Name = "NameButton";
            this.NameButton.Size = new System.Drawing.Size(136, 42);
            this.NameButton.TabIndex = 0;
            this.NameButton.Text = "Name";
            this.NameButton.UseVisualStyleBackColor = false;
            this.NameButton.Click += new System.EventHandler(this.Name_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(151, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hi!, Click the button to learn about my name.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MyPic
            // 
            this.MyPic.Image = ((System.Drawing.Image)(resources.GetObject("MyPic.Image")));
            this.MyPic.Location = new System.Drawing.Point(12, 55);
            this.MyPic.Name = "MyPic";
            this.MyPic.Size = new System.Drawing.Size(121, 132);
            this.MyPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MyPic.TabIndex = 2;
            this.MyPic.TabStop = false;
            this.MyPic.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // MyName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(509, 218);
            this.Controls.Add(this.MyPic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameButton);
            this.MaximizeBox = false;
            this.Name = "MyName";
            this.Text = "MyName";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MyPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button NameButton;
        private Label label1;
        private PictureBox MyPic;
    }
}