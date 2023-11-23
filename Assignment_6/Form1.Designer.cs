
namespace Assignment_6
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.scissors = new System.Windows.Forms.PictureBox();
            this.paper = new System.Windows.Forms.PictureBox();
            this.rock = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.computerPictureBox = new System.Windows.Forms.PictureBox();
            this.youPictureBox = new System.Windows.Forms.PictureBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.playerScorelabel = new System.Windows.Forms.Label();
            this.computerScorelabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.youPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // scissors
            // 
            this.scissors.Image = global::Assignment_6.Properties.Resources.scissors;
            this.scissors.Location = new System.Drawing.Point(814, 514);
            this.scissors.Name = "scissors";
            this.scissors.Size = new System.Drawing.Size(201, 209);
            this.scissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.scissors.TabIndex = 2;
            this.scissors.TabStop = false;
            this.scissors.Click += new System.EventHandler(this.scissors_Click);
            // 
            // paper
            // 
            this.paper.Image = global::Assignment_6.Properties.Resources.paper;
            this.paper.Location = new System.Drawing.Point(519, 514);
            this.paper.Name = "paper";
            this.paper.Size = new System.Drawing.Size(201, 209);
            this.paper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.paper.TabIndex = 1;
            this.paper.TabStop = false;
            this.paper.Click += new System.EventHandler(this.paper_Click);
            // 
            // rock
            // 
            this.rock.Image = global::Assignment_6.Properties.Resources.stone;
            this.rock.Location = new System.Drawing.Point(208, 514);
            this.rock.Name = "rock";
            this.rock.Size = new System.Drawing.Size(201, 209);
            this.rock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rock.TabIndex = 0;
            this.rock.TabStop = false;
            this.rock.Click += new System.EventHandler(this.rock_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(203, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "Computer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(929, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 44);
            this.label2.TabIndex = 4;
            this.label2.Text = "You:";
            // 
            // computerPictureBox
            // 
            this.computerPictureBox.Location = new System.Drawing.Point(211, 86);
            this.computerPictureBox.Name = "computerPictureBox";
            this.computerPictureBox.Size = new System.Drawing.Size(201, 209);
            this.computerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.computerPictureBox.TabIndex = 5;
            this.computerPictureBox.TabStop = false;
            // 
            // youPictureBox
            // 
            this.youPictureBox.Location = new System.Drawing.Point(814, 86);
            this.youPictureBox.Name = "youPictureBox";
            this.youPictureBox.Size = new System.Drawing.Size(201, 209);
            this.youPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.youPictureBox.TabIndex = 6;
            this.youPictureBox.TabStop = false;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLabel.Location = new System.Drawing.Point(501, 413);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(243, 44);
            this.resultLabel.TabIndex = 7;
            this.resultLabel.Text = "Choose One!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(397, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 44);
            this.label3.TabIndex = 8;
            // 
            // playerScorelabel
            // 
            this.playerScorelabel.AutoSize = true;
            this.playerScorelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playerScorelabel.Location = new System.Drawing.Point(1021, 39);
            this.playerScorelabel.Name = "playerScorelabel";
            this.playerScorelabel.Size = new System.Drawing.Size(30, 44);
            this.playerScorelabel.TabIndex = 9;
            this.playerScorelabel.Text = " ";
            // 
            // computerScorelabel
            // 
            this.computerScorelabel.AutoSize = true;
            this.computerScorelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.computerScorelabel.Location = new System.Drawing.Point(403, 39);
            this.computerScorelabel.Name = "computerScorelabel";
            this.computerScorelabel.Size = new System.Drawing.Size(30, 44);
            this.computerScorelabel.TabIndex = 10;
            this.computerScorelabel.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 782);
            this.Controls.Add(this.computerScorelabel);
            this.Controls.Add(this.playerScorelabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.youPictureBox);
            this.Controls.Add(this.computerPictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scissors);
            this.Controls.Add(this.paper);
            this.Controls.Add(this.rock);
            this.Name = "Form1";
            this.Text = "Rock Paper Scissors";
            ((System.ComponentModel.ISupportInitialize)(this.scissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.youPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox rock;
        private System.Windows.Forms.PictureBox paper;
        private System.Windows.Forms.PictureBox scissors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox computerPictureBox;
        private System.Windows.Forms.PictureBox youPictureBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label playerScorelabel;
        private System.Windows.Forms.Label computerScorelabel;
    }
}

