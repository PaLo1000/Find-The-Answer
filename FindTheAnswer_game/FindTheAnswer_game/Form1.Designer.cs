namespace FindTheAnswer_game
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
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rchtxtQuestiontbl = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHeart = new System.Windows.Forms.Label();
            this.addNewQuestionForm1 = new FindTheAnswer_game.AddNewQuestionForm();
            this.SuspendLayout();
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(260, 250);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(200, 34);
            this.txtAnswer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Find the Answer\r\n";
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(260, 360);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(200, 75);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Enter";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreen.Location = new System.Drawing.Point(325, 308);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(28, 32);
            this.lblGreen.TabIndex = 6;
            this.lblGreen.Text = "  ";
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRed.Location = new System.Drawing.Point(359, 308);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(28, 32);
            this.lblRed.TabIndex = 7;
            this.lblRed.Text = "  ";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(593, 468);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 63);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rchtxtQuestiontbl
            // 
            this.rchtxtQuestiontbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchtxtQuestiontbl.Location = new System.Drawing.Point(219, 106);
            this.rchtxtQuestiontbl.Name = "rchtxtQuestiontbl";
            this.rchtxtQuestiontbl.Size = new System.Drawing.Size(286, 96);
            this.rchtxtQuestiontbl.TabIndex = 10;
            this.rchtxtQuestiontbl.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Score :";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(20, 40);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(27, 32);
            this.lblScore.TabIndex = 11;
            this.lblScore.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "Heart :";
            // 
            // lblHeart
            // 
            this.lblHeart.AutoSize = true;
            this.lblHeart.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeart.ForeColor = System.Drawing.Color.Red;
            this.lblHeart.Location = new System.Drawing.Point(20, 500);
            this.lblHeart.Name = "lblHeart";
            this.lblHeart.Size = new System.Drawing.Size(184, 32);
            this.lblHeart.TabIndex = 11;
            this.lblHeart.Text = "❤❤❤❤❤";
            // 
            // addNewQuestionForm1
            // 
            this.addNewQuestionForm1.Location = new System.Drawing.Point(3, 1);
            this.addNewQuestionForm1.Name = "addNewQuestionForm1";
            this.addNewQuestionForm1.Size = new System.Drawing.Size(720, 540);
            this.addNewQuestionForm1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 543);
            this.Controls.Add(this.addNewQuestionForm1);
            this.Controls.Add(this.lblHeart);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rchtxtQuestiontbl);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAnswer);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find The Answer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RichTextBox rchtxtQuestiontbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHeart;
        private AddNewQuestionForm addNewQuestionForm1;
    }
}

