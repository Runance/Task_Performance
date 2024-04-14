namespace Task_Performance
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
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.lblWordToGuess = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lstWrongGuesses = new System.Windows.Forms.ListBox();
            this.lblAttemptsLeft = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.Location = new System.Drawing.Point(141, 167);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(240, 44);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "Guest";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click_1);
            // 
            // txtGuess
            // 
            this.txtGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuess.Location = new System.Drawing.Point(13, 119);
            this.txtGuess.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(483, 29);
            this.txtGuess.TabIndex = 1;
            // 
            // lblWordToGuess
            // 
            this.lblWordToGuess.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblWordToGuess.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lblWordToGuess.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordToGuess.ForeColor = System.Drawing.Color.White;
            this.lblWordToGuess.Location = new System.Drawing.Point(13, 18);
            this.lblWordToGuess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWordToGuess.Name = "lblWordToGuess";
            this.lblWordToGuess.Size = new System.Drawing.Size(483, 84);
            this.lblWordToGuess.TabIndex = 2;
            this.lblWordToGuess.Text = "label1";
            this.lblWordToGuess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblResult.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(526, 18);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(240, 38);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "label2";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstWrongGuesses
            // 
            this.lstWrongGuesses.FormattingEnabled = true;
            this.lstWrongGuesses.ItemHeight = 20;
            this.lstWrongGuesses.Location = new System.Drawing.Point(526, 59);
            this.lstWrongGuesses.Name = "lstWrongGuesses";
            this.lstWrongGuesses.Size = new System.Drawing.Size(240, 104);
            this.lstWrongGuesses.TabIndex = 4;
            // 
            // lblAttemptsLeft
            // 
            this.lblAttemptsLeft.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblAttemptsLeft.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttemptsLeft.ForeColor = System.Drawing.Color.White;
            this.lblAttemptsLeft.Location = new System.Drawing.Point(528, 178);
            this.lblAttemptsLeft.Name = "lblAttemptsLeft";
            this.lblAttemptsLeft.Size = new System.Drawing.Size(238, 33);
            this.lblAttemptsLeft.TabIndex = 5;
            this.lblAttemptsLeft.Text = "label1";
            this.lblAttemptsLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 228);
            this.Controls.Add(this.lblAttemptsLeft);
            this.Controls.Add(this.lstWrongGuesses);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblWordToGuess);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.btnCheck);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Label lblWordToGuess;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ListBox lstWrongGuesses;
        private System.Windows.Forms.Label lblAttemptsLeft;
    }
}

