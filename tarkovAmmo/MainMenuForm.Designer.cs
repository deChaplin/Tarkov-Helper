namespace tarkovAmmo
{
    partial class MainMenuForm
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
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTraders = new tarkovAmmo.RoundedButtons();
            this.btnAmmo = new tarkovAmmo.RoundedButtons();
            this.btnTasks = new tarkovAmmo.RoundedButtons();
            this.btnFlea = new tarkovAmmo.RoundedButtons();
            this.roundedButtons5 = new tarkovAmmo.RoundedButtons();
            this.pnlMain = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMin
            // 
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Location = new System.Drawing.Point(991, 9);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(24, 31);
            this.btnMin.TabIndex = 42;
            this.btnMin.Text = "—";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1021, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 31);
            this.btnClose.TabIndex = 41;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::tarkovAmmo.Properties.Resources.rainbow;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1059, 5);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // btnTraders
            // 
            this.btnTraders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnTraders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnTraders.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTraders.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.btnTraders.BorderRadius = 8;
            this.btnTraders.BorderRadius1 = 8;
            this.btnTraders.BorderSize = 0;
            this.btnTraders.BorderSize1 = 0;
            this.btnTraders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTraders.FlatAppearance.BorderSize = 0;
            this.btnTraders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraders.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.btnTraders.ForeColor = System.Drawing.Color.White;
            this.btnTraders.Location = new System.Drawing.Point(3, 43);
            this.btnTraders.Name = "btnTraders";
            this.btnTraders.Size = new System.Drawing.Size(188, 111);
            this.btnTraders.TabIndex = 49;
            this.btnTraders.Text = "Traders";
            this.btnTraders.TextColor = System.Drawing.Color.White;
            this.btnTraders.UseVisualStyleBackColor = false;
            this.btnTraders.Click += new System.EventHandler(this.btnTraders_Click);
            // 
            // btnAmmo
            // 
            this.btnAmmo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnAmmo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnAmmo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAmmo.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.btnAmmo.BorderRadius = 8;
            this.btnAmmo.BorderRadius1 = 8;
            this.btnAmmo.BorderSize = 0;
            this.btnAmmo.BorderSize1 = 0;
            this.btnAmmo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAmmo.FlatAppearance.BorderSize = 0;
            this.btnAmmo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmmo.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.btnAmmo.ForeColor = System.Drawing.Color.White;
            this.btnAmmo.Location = new System.Drawing.Point(3, 161);
            this.btnAmmo.Name = "btnAmmo";
            this.btnAmmo.Size = new System.Drawing.Size(188, 111);
            this.btnAmmo.TabIndex = 50;
            this.btnAmmo.Text = "Ammo";
            this.btnAmmo.TextColor = System.Drawing.Color.White;
            this.btnAmmo.UseVisualStyleBackColor = false;
            this.btnAmmo.Click += new System.EventHandler(this.btnAmmo_Click);
            // 
            // btnTasks
            // 
            this.btnTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnTasks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnTasks.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTasks.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.btnTasks.BorderRadius = 8;
            this.btnTasks.BorderRadius1 = 8;
            this.btnTasks.BorderSize = 0;
            this.btnTasks.BorderSize1 = 0;
            this.btnTasks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTasks.FlatAppearance.BorderSize = 0;
            this.btnTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTasks.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.btnTasks.ForeColor = System.Drawing.Color.White;
            this.btnTasks.Location = new System.Drawing.Point(3, 278);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Size = new System.Drawing.Size(188, 111);
            this.btnTasks.TabIndex = 51;
            this.btnTasks.Text = "Tasks";
            this.btnTasks.TextColor = System.Drawing.Color.White;
            this.btnTasks.UseVisualStyleBackColor = false;
            this.btnTasks.Click += new System.EventHandler(this.btnTasks_Click);
            // 
            // btnFlea
            // 
            this.btnFlea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnFlea.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnFlea.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnFlea.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.btnFlea.BorderRadius = 8;
            this.btnFlea.BorderRadius1 = 8;
            this.btnFlea.BorderSize = 0;
            this.btnFlea.BorderSize1 = 0;
            this.btnFlea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFlea.FlatAppearance.BorderSize = 0;
            this.btnFlea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlea.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.btnFlea.ForeColor = System.Drawing.Color.White;
            this.btnFlea.Location = new System.Drawing.Point(3, 395);
            this.btnFlea.Name = "btnFlea";
            this.btnFlea.Size = new System.Drawing.Size(188, 111);
            this.btnFlea.TabIndex = 52;
            this.btnFlea.Text = "Flea";
            this.btnFlea.TextColor = System.Drawing.Color.White;
            this.btnFlea.UseVisualStyleBackColor = false;
            this.btnFlea.Click += new System.EventHandler(this.btnFlea_Click);
            // 
            // roundedButtons5
            // 
            this.roundedButtons5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.roundedButtons5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.roundedButtons5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundedButtons5.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.roundedButtons5.BorderRadius = 8;
            this.roundedButtons5.BorderRadius1 = 8;
            this.roundedButtons5.BorderSize = 0;
            this.roundedButtons5.BorderSize1 = 0;
            this.roundedButtons5.Enabled = false;
            this.roundedButtons5.FlatAppearance.BorderSize = 0;
            this.roundedButtons5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtons5.ForeColor = System.Drawing.Color.White;
            this.roundedButtons5.Location = new System.Drawing.Point(197, 43);
            this.roundedButtons5.Name = "roundedButtons5";
            this.roundedButtons5.Size = new System.Drawing.Size(848, 463);
            this.roundedButtons5.TabIndex = 53;
            this.roundedButtons5.TextColor = System.Drawing.Color.White;
            this.roundedButtons5.UseVisualStyleBackColor = false;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlMain.Location = new System.Drawing.Point(203, 51);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(833, 449);
            this.pnlMain.TabIndex = 55;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1048, 512);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.roundedButtons5);
            this.Controls.Add(this.btnFlea);
            this.Controls.Add(this.btnTasks);
            this.Controls.Add(this.btnAmmo);
            this.Controls.Add(this.btnTraders);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnMin;
        private Button btnClose;
        private PictureBox pictureBox1;
        private RoundedButtons btnTraders;
        private RoundedButtons btnAmmo;
        private RoundedButtons btnTasks;
        private RoundedButtons btnFlea;
        private RoundedButtons roundedButtons5;
        private Panel pnlMain;
    }
}