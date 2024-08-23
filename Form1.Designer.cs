
namespace CronometroC_
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            lbCronometro = new Label();
            label3 = new Label();
            btnStart = new Button();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            btnStop = new Button();
            btnReset = new Button();
            btnReiniciar = new Button();
            lbCro = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(25, 67);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 1;
            label1.Text = "Time";
            // 
            // lbCronometro
            // 
            lbCronometro.Location = new Point(0, 0);
            lbCronometro.Name = "lbCronometro";
            lbCronometro.Size = new Size(100, 23);
            lbCronometro.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label3.Location = new Point(351, 68);
            label3.Name = "label3";
            label3.Size = new Size(88, 37);
            label3.TabIndex = 3;
            label3.Text = "00:00";
            label3.Click += label3_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(351, 108);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(88, 23);
            btnStart.TabIndex = 4;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 198);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 201);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(351, 137);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(88, 23);
            btnStop.TabIndex = 6;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(351, 208);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(88, 23);
            btnReset.TabIndex = 8;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnReiniciar
            // 
            btnReiniciar.Location = new Point(351, 172);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(88, 23);
            btnReiniciar.TabIndex = 9;
            btnReiniciar.Text = "Reinicar";
            btnReiniciar.UseVisualStyleBackColor = true;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // lbCro
            // 
            lbCro.AutoSize = true;
            lbCro.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lbCro.Location = new Point(351, 298);
            lbCro.Name = "lbCro";
            lbCro.Size = new Size(88, 37);
            lbCro.TabIndex = 11;
            lbCro.Text = "00:00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 450);
            Controls.Add(lbCro);
            Controls.Add(btnReiniciar);
            Controls.Add(btnReset);
            Controls.Add(btnStop);
            Controls.Add(pictureBox1);
            Controls.Add(btnStart);
            Controls.Add(label3);
            Controls.Add(lbCronometro);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Cronometro";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Label label1;
        private Label lbCronometro;
        private Label label3;
        private Button btnStart;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Button btnStop;
        private Button btnReset;
        private Button btnReiniciar;
        private Label lbCro;
    }
}
