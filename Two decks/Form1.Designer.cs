namespace Two_decks
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.resetDeckOne = new System.Windows.Forms.Button();
            this.shuffleDeckOne = new System.Windows.Forms.Button();
            this.resetDeckTwo = new System.Windows.Forms.Button();
            this.shuffleDeckTwo = new System.Windows.Forms.Button();
            this.moveCardToDeckTwo = new System.Windows.Forms.Button();
            this.moveCardToDeckOne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(195, 368);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(289, 13);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(195, 368);
            this.listBox2.TabIndex = 1;
            // 
            // resetDeckOne
            // 
            this.resetDeckOne.Location = new System.Drawing.Point(13, 387);
            this.resetDeckOne.Name = "resetDeckOne";
            this.resetDeckOne.Size = new System.Drawing.Size(195, 23);
            this.resetDeckOne.TabIndex = 2;
            this.resetDeckOne.Text = "Reset Deck";
            this.resetDeckOne.UseVisualStyleBackColor = true;
            this.resetDeckOne.Click += new System.EventHandler(this.resetDeckOne_Click);
            // 
            // shuffleDeckOne
            // 
            this.shuffleDeckOne.Location = new System.Drawing.Point(13, 416);
            this.shuffleDeckOne.Name = "shuffleDeckOne";
            this.shuffleDeckOne.Size = new System.Drawing.Size(195, 23);
            this.shuffleDeckOne.TabIndex = 3;
            this.shuffleDeckOne.Text = "Shuffle Deck";
            this.shuffleDeckOne.UseVisualStyleBackColor = true;
            this.shuffleDeckOne.Click += new System.EventHandler(this.shuffleDeckOne_Click);
            // 
            // resetDeckTwo
            // 
            this.resetDeckTwo.Location = new System.Drawing.Point(289, 387);
            this.resetDeckTwo.Name = "resetDeckTwo";
            this.resetDeckTwo.Size = new System.Drawing.Size(195, 23);
            this.resetDeckTwo.TabIndex = 4;
            this.resetDeckTwo.Text = "Reset Deck";
            this.resetDeckTwo.UseVisualStyleBackColor = true;
            this.resetDeckTwo.Click += new System.EventHandler(this.resetDeckTwo_Click);
            // 
            // shuffleDeckTwo
            // 
            this.shuffleDeckTwo.Location = new System.Drawing.Point(289, 416);
            this.shuffleDeckTwo.Name = "shuffleDeckTwo";
            this.shuffleDeckTwo.Size = new System.Drawing.Size(195, 23);
            this.shuffleDeckTwo.TabIndex = 5;
            this.shuffleDeckTwo.Text = "Shuffle Deck";
            this.shuffleDeckTwo.UseVisualStyleBackColor = true;
            this.shuffleDeckTwo.Click += new System.EventHandler(this.shuffleDeckTwo_Click);
            // 
            // moveCardToDeckTwo
            // 
            this.moveCardToDeckTwo.Location = new System.Drawing.Point(214, 157);
            this.moveCardToDeckTwo.Name = "moveCardToDeckTwo";
            this.moveCardToDeckTwo.Size = new System.Drawing.Size(69, 23);
            this.moveCardToDeckTwo.TabIndex = 6;
            this.moveCardToDeckTwo.Text = ">>";
            this.moveCardToDeckTwo.UseVisualStyleBackColor = true;
            this.moveCardToDeckTwo.Click += new System.EventHandler(this.moveCardToDeckTwo_Click);
            // 
            // moveCardToDeckOne
            // 
            this.moveCardToDeckOne.Location = new System.Drawing.Point(214, 186);
            this.moveCardToDeckOne.Name = "moveCardToDeckOne";
            this.moveCardToDeckOne.Size = new System.Drawing.Size(69, 23);
            this.moveCardToDeckOne.TabIndex = 7;
            this.moveCardToDeckOne.Text = "<<";
            this.moveCardToDeckOne.UseVisualStyleBackColor = true;
            this.moveCardToDeckOne.Click += new System.EventHandler(this.moveCardToDeckOne_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 450);
            this.Controls.Add(this.moveCardToDeckOne);
            this.Controls.Add(this.moveCardToDeckTwo);
            this.Controls.Add(this.shuffleDeckTwo);
            this.Controls.Add(this.resetDeckTwo);
            this.Controls.Add(this.shuffleDeckOne);
            this.Controls.Add(this.resetDeckOne);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Two decks";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button resetDeckOne;
        private System.Windows.Forms.Button shuffleDeckOne;
        private System.Windows.Forms.Button resetDeckTwo;
        private System.Windows.Forms.Button shuffleDeckTwo;
        private System.Windows.Forms.Button moveCardToDeckTwo;
        private System.Windows.Forms.Button moveCardToDeckOne;
    }
}

