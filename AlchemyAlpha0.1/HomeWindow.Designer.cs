namespace AlchemyAlpha0._1
{
    partial class HomeWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeWindow));
            this.Play_button = new System.Windows.Forms.Button();
            this.Load_Save_button = new System.Windows.Forms.Button();
            this.Author_button = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Sound_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Play_button
            // 
            this.Play_button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Play_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Play_button.Location = new System.Drawing.Point(16, 131);
            this.Play_button.Name = "Play_button";
            this.Play_button.Size = new System.Drawing.Size(200, 50);
            this.Play_button.TabIndex = 0;
            this.Play_button.Text = "Грати";
            this.Play_button.UseVisualStyleBackColor = false;
            this.Play_button.Click += new System.EventHandler(this.Play_button_Click);
            // 
            // Load_Save_button
            // 
            this.Load_Save_button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Load_Save_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Load_Save_button.Location = new System.Drawing.Point(16, 201);
            this.Load_Save_button.Name = "Load_Save_button";
            this.Load_Save_button.Size = new System.Drawing.Size(200, 50);
            this.Load_Save_button.TabIndex = 1;
            this.Load_Save_button.Text = "Завантажити збереження";
            this.Load_Save_button.UseVisualStyleBackColor = false;
            this.Load_Save_button.Click += new System.EventHandler(this.Load_Save_button_Click);
            // 
            // Author_button
            // 
            this.Author_button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Author_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Author_button.Location = new System.Drawing.Point(16, 273);
            this.Author_button.Name = "Author_button";
            this.Author_button.Size = new System.Drawing.Size(200, 50);
            this.Author_button.TabIndex = 2;
            this.Author_button.Text = "Про авторів";
            this.Author_button.UseVisualStyleBackColor = false;
            this.Author_button.Click += new System.EventHandler(this.Author_button_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Exit_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Exit_button.Location = new System.Drawing.Point(16, 354);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(200, 50);
            this.Exit_button.TabIndex = 3;
            this.Exit_button.Text = "Вихід з гри";
            this.Exit_button.UseVisualStyleBackColor = false;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(577, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 108);
            this.label1.TabIndex = 4;
            this.label1.Text = "Alchemy";
            // 
            // Sound_button
            // 
            this.Sound_button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Sound_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Sound_button.BackgroundImage = global::AlchemyAlpha0._1.Properties.Resources.volume_on;
            this.Sound_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sound_button.Location = new System.Drawing.Point(16, 423);
            this.Sound_button.Name = "Sound_button";
            this.Sound_button.Size = new System.Drawing.Size(62, 50);
            this.Sound_button.TabIndex = 6;
            this.Sound_button.UseVisualStyleBackColor = false;
            this.Sound_button.Click += new System.EventHandler(this.Sound_button_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(252, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 138);
            this.panel1.TabIndex = 7;
            this.panel1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Коновалов Микита КНТ-151";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Гунько Ігор КНТ-151";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Романік Данило КНТ-151";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Піддубчак Данило КНТ-151";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // HomeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AlchemyAlpha0._1.Properties.Resources.chemistry;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Sound_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.Author_button);
            this.Controls.Add(this.Load_Save_button);
            this.Controls.Add(this.Play_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "HomeWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alchemy";
            this.Load += new System.EventHandler(this.HomeWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Play_button;
        private Button Load_Save_button;
        private Button Author_button;
        private Button Exit_button;
        private Label label1;
        private Button Sound_button;
        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private OpenFileDialog openFileDialog1;
    }
}