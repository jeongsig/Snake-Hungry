namespace Snake_Hungry
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
            this.start_btn = new System.Windows.Forms.Button();
            this.snap_btn = new System.Windows.Forms.Button();
            this.score_lbl = new System.Windows.Forms.Label();
            this.hgh_scre_lbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // start_btn
            // 
            this.start_btn.BackColor = System.Drawing.SystemColors.GrayText;
            this.start_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_btn.Location = new System.Drawing.Point(12, 191);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(85, 39);
            this.start_btn.TabIndex = 0;
            this.start_btn.Text = "START";
            this.start_btn.UseVisualStyleBackColor = false;
            this.start_btn.Click += new System.EventHandler(this.StartGame);
            // 
            // snap_btn
            // 
            this.snap_btn.BackColor = System.Drawing.SystemColors.GrayText;
            this.snap_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snap_btn.Location = new System.Drawing.Point(12, 246);
            this.snap_btn.Name = "snap_btn";
            this.snap_btn.Size = new System.Drawing.Size(85, 39);
            this.snap_btn.TabIndex = 1;
            this.snap_btn.Text = "SNAP";
            this.snap_btn.UseVisualStyleBackColor = false;
            this.snap_btn.Click += new System.EventHandler(this.TakesnapShot);
            // 
            // score_lbl
            // 
            this.score_lbl.AutoSize = true;
            this.score_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_lbl.Location = new System.Drawing.Point(22, 134);
            this.score_lbl.Name = "score_lbl";
            this.score_lbl.Size = new System.Drawing.Size(64, 16);
            this.score_lbl.TabIndex = 2;
            this.score_lbl.Text = "Score: 0";
            // 
            // hgh_scre_lbl
            // 
            this.hgh_scre_lbl.AutoSize = true;
            this.hgh_scre_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hgh_scre_lbl.Location = new System.Drawing.Point(12, 160);
            this.hgh_scre_lbl.Name = "hgh_scre_lbl";
            this.hgh_scre_lbl.Size = new System.Drawing.Size(88, 16);
            this.hgh_scre_lbl.TabIndex = 3;
            this.hgh_scre_lbl.Text = "High Score:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.Location = new System.Drawing.Point(231, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 360);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdatePictureBoxGraphics);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 40;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 384);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.hgh_scre_lbl);
            this.Controls.Add(this.score_lbl);
            this.Controls.Add(this.snap_btn);
            this.Controls.Add(this.start_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button snap_btn;
        private System.Windows.Forms.Label score_lbl;
        private System.Windows.Forms.Label hgh_scre_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer gameTimer;
    }
}

