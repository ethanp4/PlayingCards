namespace PlayingCards
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
            labelPlayer = new Label();
            listBoxPlayers = new ListBox();
            picturePlayer = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)picturePlayer).BeginInit();
            SuspendLayout();
            // 
            // labelPlayer
            // 
            labelPlayer.AutoSize = true;
            labelPlayer.Location = new Point(197, 187);
            labelPlayer.Name = "labelPlayer";
            labelPlayer.Size = new Size(104, 15);
            labelPlayer.TabIndex = 0;
            labelPlayer.Text = "No player selected";
            // 
            // listBoxPlayers
            // 
            listBoxPlayers.FormattingEnabled = true;
            listBoxPlayers.ItemHeight = 15;
            listBoxPlayers.Location = new Point(12, 30);
            listBoxPlayers.Name = "listBoxPlayers";
            listBoxPlayers.Size = new Size(179, 154);
            listBoxPlayers.TabIndex = 1;
            // 
            // picturePlayer
            // 
            picturePlayer.Location = new Point(197, 30);
            picturePlayer.Name = "picturePlayer";
            picturePlayer.Size = new Size(160, 154);
            picturePlayer.SizeMode = PictureBoxSizeMode.StretchImage;
            picturePlayer.TabIndex = 2;
            picturePlayer.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(197, 12);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 3;
            label1.Text = "Player Photo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Size = new Size(149, 15);
            label2.TabIndex = 4;
            label2.Text = "Select a player from the list";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 413);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(picturePlayer);
            Controls.Add(listBoxPlayers);
            Controls.Add(labelPlayer);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picturePlayer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPlayer;
        private ListBox listBoxPlayers;
        private PictureBox picturePlayer;
        private Label label1;
        private Label label2;
    }
}
