using System.Windows.Forms;

namespace ProyectoGraficaP1
{
    partial class FigureAnimation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FigureAnimation));
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnAdelatar = new System.Windows.Forms.Button();
            this.btnChangeFigureForward = new System.Windows.Forms.Button();
            this.btnAtrasar = new System.Windows.Forms.Button();
            this.btnChangeFigure = new System.Windows.Forms.Button();
            this.pBrProgreso = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picCanvas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCanvas.BackgroundImage")));
            this.picCanvas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCanvas.Location = new System.Drawing.Point(46, 14);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(983, 458);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.White;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPlay.Location = new System.Drawing.Point(518, 494);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(3, 3, 3, 4);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(51, 43);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = " ▶";
            this.btnPlay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnAdelatar
            // 
            this.btnAdelatar.BackColor = System.Drawing.Color.Black;
            this.btnAdelatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdelatar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdelatar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdelatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdelatar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdelatar.Location = new System.Drawing.Point(575, 494);
            this.btnAdelatar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 4);
            this.btnAdelatar.Name = "btnAdelatar";
            this.btnAdelatar.Size = new System.Drawing.Size(61, 43);
            this.btnAdelatar.TabIndex = 5;
            this.btnAdelatar.Text = " ▶️▶️";
            this.btnAdelatar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdelatar.UseVisualStyleBackColor = false;
            this.btnAdelatar.Click += new System.EventHandler(this.btnAdelatar_Click);
            // 
            // btnChangeFigureForward
            // 
            this.btnChangeFigureForward.BackColor = System.Drawing.Color.Black;
            this.btnChangeFigureForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnChangeFigureForward.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnChangeFigureForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeFigureForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeFigureForward.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnChangeFigureForward.Location = new System.Drawing.Point(642, 494);
            this.btnChangeFigureForward.Margin = new System.Windows.Forms.Padding(3, 3, 3, 4);
            this.btnChangeFigureForward.Name = "btnChangeFigureForward";
            this.btnChangeFigureForward.Size = new System.Drawing.Size(51, 43);
            this.btnChangeFigureForward.TabIndex = 6;
            this.btnChangeFigureForward.Text = " ▶️|";
            this.btnChangeFigureForward.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnChangeFigureForward.UseVisualStyleBackColor = false;
            this.btnChangeFigureForward.Click += new System.EventHandler(this.btnNextFigure_Click);
            // 
            // btnAtrasar
            // 
            this.btnAtrasar.BackColor = System.Drawing.Color.Black;
            this.btnAtrasar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAtrasar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAtrasar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtrasar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtrasar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAtrasar.Location = new System.Drawing.Point(451, 494);
            this.btnAtrasar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 4);
            this.btnAtrasar.Name = "btnAtrasar";
            this.btnAtrasar.Size = new System.Drawing.Size(61, 43);
            this.btnAtrasar.TabIndex = 8;
            this.btnAtrasar.Text = "◀◀";
            this.btnAtrasar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAtrasar.UseVisualStyleBackColor = false;
            this.btnAtrasar.Click += new System.EventHandler(this.btnAtrasar_Click);
            // 
            // btnChangeFigure
            // 
            this.btnChangeFigure.BackColor = System.Drawing.Color.Black;
            this.btnChangeFigure.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnChangeFigure.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnChangeFigure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeFigure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeFigure.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnChangeFigure.Location = new System.Drawing.Point(394, 494);
            this.btnChangeFigure.Margin = new System.Windows.Forms.Padding(3, 3, 3, 4);
            this.btnChangeFigure.Name = "btnChangeFigure";
            this.btnChangeFigure.Size = new System.Drawing.Size(51, 43);
            this.btnChangeFigure.TabIndex = 7;
            this.btnChangeFigure.Text = " |◀";
            this.btnChangeFigure.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnChangeFigure.UseVisualStyleBackColor = false;
            this.btnChangeFigure.Click += new System.EventHandler(this.btnPreviousFigure_Click);
            // 
            // pBrProgreso
            // 
            this.pBrProgreso.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pBrProgreso.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pBrProgreso.Location = new System.Drawing.Point(296, 478);
            this.pBrProgreso.Name = "pBrProgreso";
            this.pBrProgreso.RightToLeftLayout = true;
            this.pBrProgreso.Size = new System.Drawing.Size(487, 10);
            this.pBrProgreso.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 497);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "FIGURAS ANIMADAS";
            // 
            // FigureAnimation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1070, 560);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pBrProgreso);
            this.Controls.Add(this.btnAtrasar);
            this.Controls.Add(this.btnChangeFigure);
            this.Controls.Add(this.btnChangeFigureForward);
            this.Controls.Add(this.btnAdelatar);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.picCanvas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FigureAnimation";
            this.Text = "FigureAnimation";
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnAdelatar;
        private System.Windows.Forms.Button btnChangeFigureForward;
        private System.Windows.Forms.Button btnAtrasar;
        private System.Windows.Forms.Button btnChangeFigure;
        private System.Windows.Forms.ProgressBar pBrProgreso;
        private System.Windows.Forms.Label label1;
    }
}