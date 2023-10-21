using System.Windows.Forms;

namespace lab3.View
{
    partial class DishSelectForm
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
            this.shotPicture = new System.Windows.Forms.PictureBox();
            this.glassPicture = new System.Windows.Forms.PictureBox();
            this.mugPicture = new System.Windows.Forms.PictureBox();
            this.mugRadioButton = new System.Windows.Forms.RadioButton();
            this.glassRadioButton = new System.Windows.Forms.RadioButton();
            this.shotRadioButton = new System.Windows.Forms.RadioButton();
            this.selectDishButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.shotPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glassPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mugPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // shotPicture
            // 
            this.shotPicture.Image = global::lab3.Properties.Resources.shot;
            this.shotPicture.Location = new System.Drawing.Point(332, 12);
            this.shotPicture.Name = "shotPicture";
            this.shotPicture.Size = new System.Drawing.Size(128, 128);
            this.shotPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.shotPicture.TabIndex = 2;
            this.shotPicture.TabStop = false;
            // 
            // glassPicture
            // 
            this.glassPicture.Image = global::lab3.Properties.Resources.glass;
            this.glassPicture.Location = new System.Drawing.Point(171, 12);
            this.glassPicture.Name = "glassPicture";
            this.glassPicture.Size = new System.Drawing.Size(128, 128);
            this.glassPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.glassPicture.TabIndex = 1;
            this.glassPicture.TabStop = false;
            // 
            // mugPicture
            // 
            this.mugPicture.Image = global::lab3.Properties.Resources.mug;
            this.mugPicture.Location = new System.Drawing.Point(12, 12);
            this.mugPicture.Name = "mugPicture";
            this.mugPicture.Size = new System.Drawing.Size(128, 128);
            this.mugPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mugPicture.TabIndex = 0;
            this.mugPicture.TabStop = false;
            // 
            // mugRadioButton
            // 
            this.mugRadioButton.AutoSize = true;
            this.mugRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mugRadioButton.Location = new System.Drawing.Point(35, 146);
            this.mugRadioButton.Name = "mugRadioButton";
            this.mugRadioButton.Size = new System.Drawing.Size(58, 24);
            this.mugRadioButton.TabIndex = 3;
            this.mugRadioButton.TabStop = true;
            this.mugRadioButton.Text = "Mug";
            this.mugRadioButton.UseVisualStyleBackColor = true;
            // 
            // glassRadioButton
            // 
            this.glassRadioButton.AutoSize = true;
            this.glassRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.glassRadioButton.Location = new System.Drawing.Point(200, 146);
            this.glassRadioButton.Name = "glassRadioButton";
            this.glassRadioButton.Size = new System.Drawing.Size(68, 24);
            this.glassRadioButton.TabIndex = 4;
            this.glassRadioButton.TabStop = true;
            this.glassRadioButton.Text = "Glass";
            this.glassRadioButton.UseVisualStyleBackColor = true;
            // 
            // shotRadioButton
            // 
            this.shotRadioButton.AutoSize = true;
            this.shotRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.shotRadioButton.Location = new System.Drawing.Point(367, 146);
            this.shotRadioButton.Name = "shotRadioButton";
            this.shotRadioButton.Size = new System.Drawing.Size(61, 24);
            this.shotRadioButton.TabIndex = 5;
            this.shotRadioButton.TabStop = true;
            this.shotRadioButton.Text = "Shot";
            this.shotRadioButton.UseVisualStyleBackColor = true;
            // 
            // selectDishButton
            // 
            this.selectDishButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectDishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectDishButton.Location = new System.Drawing.Point(189, 176);
            this.selectDishButton.Name = "selectDishButton";
            this.selectDishButton.Size = new System.Drawing.Size(91, 30);
            this.selectDishButton.TabIndex = 6;
            this.selectDishButton.Text = "Select";
            this.selectDishButton.UseVisualStyleBackColor = true;
            this.selectDishButton.Click += new System.EventHandler(this.selectDishButton_Click);
            // 
            // DishSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 219);
            this.Controls.Add(this.selectDishButton);
            this.Controls.Add(this.shotRadioButton);
            this.Controls.Add(this.glassRadioButton);
            this.Controls.Add(this.mugRadioButton);
            this.Controls.Add(this.shotPicture);
            this.Controls.Add(this.glassPicture);
            this.Controls.Add(this.mugPicture);
            this.Name = "DishSelectForm";
            this.Text = "Dish Selection";
            ((System.ComponentModel.ISupportInitialize)(this.shotPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glassPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mugPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mugPicture;
        private System.Windows.Forms.PictureBox glassPicture;
        private System.Windows.Forms.PictureBox shotPicture;
        private System.Windows.Forms.RadioButton mugRadioButton;
        private System.Windows.Forms.RadioButton glassRadioButton;
        private System.Windows.Forms.RadioButton shotRadioButton;
        private System.Windows.Forms.Button selectDishButton;
    }
}