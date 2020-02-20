namespace GuessingGameTemplate4U
{
    partial class ResultsScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.youGotItLabel1 = new System.Windows.Forms.Label();
            this.sortedOrderLabel1 = new System.Windows.Forms.Label();
            this.originalOrderLabel1 = new System.Windows.Forms.Label();
            this.guessesLabel1 = new System.Windows.Forms.Label();
            this.resultsLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // youGotItLabel1
            // 
            this.youGotItLabel1.AutoSize = true;
            this.youGotItLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.youGotItLabel1.ForeColor = System.Drawing.Color.White;
            this.youGotItLabel1.Location = new System.Drawing.Point(77, 38);
            this.youGotItLabel1.Name = "youGotItLabel1";
            this.youGotItLabel1.Size = new System.Drawing.Size(101, 24);
            this.youGotItLabel1.TabIndex = 0;
            this.youGotItLabel1.Text = "You Got It!!";
            // 
            // sortedOrderLabel1
            // 
            this.sortedOrderLabel1.AutoSize = true;
            this.sortedOrderLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortedOrderLabel1.ForeColor = System.Drawing.Color.White;
            this.sortedOrderLabel1.Location = new System.Drawing.Point(31, 207);
            this.sortedOrderLabel1.Name = "sortedOrderLabel1";
            this.sortedOrderLabel1.Size = new System.Drawing.Size(88, 16);
            this.sortedOrderLabel1.TabIndex = 1;
            this.sortedOrderLabel1.Text = "Sorted Order:";
            // 
            // originalOrderLabel1
            // 
            this.originalOrderLabel1.AutoSize = true;
            this.originalOrderLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originalOrderLabel1.ForeColor = System.Drawing.Color.White;
            this.originalOrderLabel1.Location = new System.Drawing.Point(31, 144);
            this.originalOrderLabel1.Name = "originalOrderLabel1";
            this.originalOrderLabel1.Size = new System.Drawing.Size(94, 16);
            this.originalOrderLabel1.TabIndex = 2;
            this.originalOrderLabel1.Text = "Original Order:";
            // 
            // guessesLabel1
            // 
            this.guessesLabel1.AutoSize = true;
            this.guessesLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessesLabel1.ForeColor = System.Drawing.Color.White;
            this.guessesLabel1.Location = new System.Drawing.Point(31, 115);
            this.guessesLabel1.Name = "guessesLabel1";
            this.guessesLabel1.Size = new System.Drawing.Size(103, 16);
            this.guessesLabel1.TabIndex = 3;
            this.guessesLabel1.Text = "Guesses made:";
            // 
            // resultsLabel1
            // 
            this.resultsLabel1.AutoSize = true;
            this.resultsLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsLabel1.ForeColor = System.Drawing.Color.White;
            this.resultsLabel1.Location = new System.Drawing.Point(30, 83);
            this.resultsLabel1.Name = "resultsLabel1";
            this.resultsLabel1.Size = new System.Drawing.Size(67, 20);
            this.resultsLabel1.TabIndex = 4;
            this.resultsLabel1.Text = "Results:";
            // 
            // ResultsScreen
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.resultsLabel1);
            this.Controls.Add(this.guessesLabel1);
            this.Controls.Add(this.originalOrderLabel1);
            this.Controls.Add(this.sortedOrderLabel1);
            this.Controls.Add(this.youGotItLabel1);
            this.Name = "ResultsScreen";
            this.Size = new System.Drawing.Size(286, 270);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label youGotItLabel;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.Label guessesMadeLabel;
        private System.Windows.Forms.Label originalOrderLabel;
        private System.Windows.Forms.Label sortedOrderLabel;
        private System.Windows.Forms.Label youGotItLabel1;
        private System.Windows.Forms.Label sortedOrderLabel1;
        private System.Windows.Forms.Label originalOrderLabel1;
        private System.Windows.Forms.Label guessesLabel1;
        private System.Windows.Forms.Label resultsLabel1;
    }
}
