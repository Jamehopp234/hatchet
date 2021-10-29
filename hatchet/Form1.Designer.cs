
namespace hatchet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.storyLabel = new System.Windows.Forms.Label();
            this.option1Label = new System.Windows.Forms.Label();
            this.option2Label = new System.Windows.Forms.Label();
            this.option2Button = new System.Windows.Forms.Button();
            this.option3Button = new System.Windows.Forms.Button();
            this.option3Label = new System.Windows.Forms.Label();
            this.option1Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // storyLabel
            // 
            this.storyLabel.AutoSize = true;
            this.storyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storyLabel.Location = new System.Drawing.Point(27, 18);
            this.storyLabel.Name = "storyLabel";
            this.storyLabel.Size = new System.Drawing.Size(121, 25);
            this.storyLabel.TabIndex = 0;
            this.storyLabel.Text = "Story Label";
            // 
            // option1Label
            // 
            this.option1Label.AutoSize = true;
            this.option1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1Label.Location = new System.Drawing.Point(111, 242);
            this.option1Label.Name = "option1Label";
            this.option1Label.Size = new System.Drawing.Size(152, 25);
            this.option1Label.TabIndex = 1;
            this.option1Label.Text = "Option 1 Label";
            this.option1Label.Click += new System.EventHandler(this.option1Label_Click);
            // 
            // option2Label
            // 
            this.option2Label.AutoSize = true;
            this.option2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2Label.Location = new System.Drawing.Point(111, 284);
            this.option2Label.Name = "option2Label";
            this.option2Label.Size = new System.Drawing.Size(152, 25);
            this.option2Label.TabIndex = 2;
            this.option2Label.Text = "Option 2 Label";
            // 
            // option2Button
            // 
            this.option2Button.BackColor = System.Drawing.Color.Transparent;
            this.option2Button.BackgroundImage = global::hatchet.Properties.Resources.hatchet;
            this.option2Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.option2Button.FlatAppearance.BorderSize = 0;
            this.option2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option2Button.ForeColor = System.Drawing.Color.Transparent;
            this.option2Button.Location = new System.Drawing.Point(30, 280);
            this.option2Button.Name = "option2Button";
            this.option2Button.Size = new System.Drawing.Size(118, 31);
            this.option2Button.TabIndex = 4;
            this.option2Button.UseVisualStyleBackColor = false;
            this.option2Button.Click += new System.EventHandler(this.option2Button_Click);
            // 
            // option3Button
            // 
            this.option3Button.BackColor = System.Drawing.Color.Transparent;
            this.option3Button.BackgroundImage = global::hatchet.Properties.Resources.hatchet;
            this.option3Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.option3Button.FlatAppearance.BorderSize = 0;
            this.option3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option3Button.ForeColor = System.Drawing.Color.Transparent;
            this.option3Button.Location = new System.Drawing.Point(32, 317);
            this.option3Button.Name = "option3Button";
            this.option3Button.Size = new System.Drawing.Size(116, 35);
            this.option3Button.TabIndex = 5;
            this.option3Button.UseVisualStyleBackColor = false;
            this.option3Button.Visible = false;
            this.option3Button.Click += new System.EventHandler(this.option3Button_Click);
            // 
            // option3Label
            // 
            this.option3Label.AutoSize = true;
            this.option3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option3Label.Location = new System.Drawing.Point(113, 320);
            this.option3Label.Name = "option3Label";
            this.option3Label.Size = new System.Drawing.Size(141, 25);
            this.option3Label.TabIndex = 6;
            this.option3Label.Text = "option 3 label";
            this.option3Label.Visible = false;
            // 
            // option1Button
            // 
            this.option1Button.BackColor = System.Drawing.Color.Transparent;
            this.option1Button.BackgroundImage = global::hatchet.Properties.Resources.hatchet;
            this.option1Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.option1Button.FlatAppearance.BorderSize = 0;
            this.option1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option1Button.ForeColor = System.Drawing.Color.Transparent;
            this.option1Button.Location = new System.Drawing.Point(30, 241);
            this.option1Button.Name = "option1Button";
            this.option1Button.Size = new System.Drawing.Size(116, 33);
            this.option1Button.TabIndex = 7;
            this.option1Button.UseVisualStyleBackColor = false;
            this.option1Button.Click += new System.EventHandler(this.option1Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::hatchet.Properties.Resources.planeCrash;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(258, 360);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(426, 306);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 696);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.option3Label);
            this.Controls.Add(this.option3Button);
            this.Controls.Add(this.option2Label);
            this.Controls.Add(this.option1Label);
            this.Controls.Add(this.storyLabel);
            this.Controls.Add(this.option1Button);
            this.Controls.Add(this.option2Button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label storyLabel;
        private System.Windows.Forms.Label option1Label;
        private System.Windows.Forms.Label option2Label;
        private System.Windows.Forms.Button option2Button;
        private System.Windows.Forms.Button option3Button;
        private System.Windows.Forms.Label option3Label;
        private System.Windows.Forms.Button option1Button;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

