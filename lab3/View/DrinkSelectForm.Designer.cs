namespace lab3.View
{
    partial class DrinkSelectForm
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
            this.selectDishButton = new System.Windows.Forms.Button();
            this.whiskeyRadioButton = new System.Windows.Forms.RadioButton();
            this.wineRadioButton = new System.Windows.Forms.RadioButton();
            this.vodkaRadioButton = new System.Windows.Forms.RadioButton();
            this.whiskeyPicture = new System.Windows.Forms.PictureBox();
            this.winePicture = new System.Windows.Forms.PictureBox();
            this.vodkaPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.whiskeyPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vodkaPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // selectDishButton
            // 
            this.selectDishButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectDishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectDishButton.Location = new System.Drawing.Point(191, 177);
            this.selectDishButton.Name = "selectDishButton";
            this.selectDishButton.Size = new System.Drawing.Size(91, 30);
            this.selectDishButton.TabIndex = 10;
            this.selectDishButton.Text = "Select";
            this.selectDishButton.UseVisualStyleBackColor = true;
            this.selectDishButton.Click += new System.EventHandler(this.selectDishButton_Click);
            // 
            // whiskeyRadioButton
            // 
            this.whiskeyRadioButton.AutoSize = true;
            this.whiskeyRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.whiskeyRadioButton.Location = new System.Drawing.Point(353, 147);
            this.whiskeyRadioButton.Name = "whiskeyRadioButton";
            this.whiskeyRadioButton.Size = new System.Drawing.Size(86, 24);
            this.whiskeyRadioButton.TabIndex = 9;
            this.whiskeyRadioButton.TabStop = true;
            this.whiskeyRadioButton.Text = "Whiskey";
            this.whiskeyRadioButton.UseVisualStyleBackColor = true;
            // 
            // wineRadioButton
            // 
            this.wineRadioButton.AutoSize = true;
            this.wineRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.wineRadioButton.Location = new System.Drawing.Point(206, 147);
            this.wineRadioButton.Name = "wineRadioButton";
            this.wineRadioButton.Size = new System.Drawing.Size(63, 24);
            this.wineRadioButton.TabIndex = 8;
            this.wineRadioButton.TabStop = true;
            this.wineRadioButton.Text = "Wine";
            this.wineRadioButton.UseVisualStyleBackColor = true;
            // 
            // vodkaRadioButton
            // 
            this.vodkaRadioButton.AutoSize = true;
            this.vodkaRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vodkaRadioButton.Location = new System.Drawing.Point(31, 147);
            this.vodkaRadioButton.Name = "vodkaRadioButton";
            this.vodkaRadioButton.Size = new System.Drawing.Size(73, 24);
            this.vodkaRadioButton.TabIndex = 7;
            this.vodkaRadioButton.TabStop = true;
            this.vodkaRadioButton.Text = "Vodka";
            this.vodkaRadioButton.UseVisualStyleBackColor = true;
            // 
            // whiskeyPicture
            // 
            this.whiskeyPicture.Image = global::lab3.Properties.Resources.whiskey;
            this.whiskeyPicture.Location = new System.Drawing.Point(367, 12);
            this.whiskeyPicture.Name = "whiskeyPicture";
            this.whiskeyPicture.Size = new System.Drawing.Size(56, 128);
            this.whiskeyPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.whiskeyPicture.TabIndex = 5;
            this.whiskeyPicture.TabStop = false;
            // 
            // winePicture
            // 
            this.winePicture.Image = global::lab3.Properties.Resources.wine;
            this.winePicture.Location = new System.Drawing.Point(215, 12);
            this.winePicture.Name = "winePicture";
            this.winePicture.Size = new System.Drawing.Size(33, 128);
            this.winePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.winePicture.TabIndex = 4;
            this.winePicture.TabStop = false;
            // 
            // vodkaPicture
            // 
            this.vodkaPicture.Image = global::lab3.Properties.Resources.vodka;
            this.vodkaPicture.Location = new System.Drawing.Point(23, 12);
            this.vodkaPicture.Name = "vodkaPicture";
            this.vodkaPicture.Size = new System.Drawing.Size(85, 128);
            this.vodkaPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.vodkaPicture.TabIndex = 3;
            this.vodkaPicture.TabStop = false;
            // 
            // DrinkSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 219);
            this.Controls.Add(this.selectDishButton);
            this.Controls.Add(this.whiskeyRadioButton);
            this.Controls.Add(this.wineRadioButton);
            this.Controls.Add(this.vodkaRadioButton);
            this.Controls.Add(this.whiskeyPicture);
            this.Controls.Add(this.winePicture);
            this.Controls.Add(this.vodkaPicture);
            this.Name = "DrinkSelectForm";
            this.Text = "Drink Selection";
            ((System.ComponentModel.ISupportInitialize)(this.whiskeyPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vodkaPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox whiskeyPicture;
        private System.Windows.Forms.PictureBox winePicture;
        private System.Windows.Forms.PictureBox vodkaPicture;
        private System.Windows.Forms.Button selectDishButton;
        private System.Windows.Forms.RadioButton whiskeyRadioButton;
        private System.Windows.Forms.RadioButton wineRadioButton;
        private System.Windows.Forms.RadioButton vodkaRadioButton;
    }
}