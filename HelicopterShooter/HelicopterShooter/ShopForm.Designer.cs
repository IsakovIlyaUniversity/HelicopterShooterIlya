using System;
namespace HelicopterShooter
{
    partial class ShopForm
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
            this.CloseShopButton = new System.Windows.Forms.Button();
            this.HeroSkinsButton = new System.Windows.Forms.Button();
            this.BackGroundSkinsButton = new System.Windows.Forms.Button();
            this.PicBackGroundSkinsMenu = new System.Windows.Forms.PictureBox();
            this.PicHeroSkinsMenu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBackGroundSkinsMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicHeroSkinsMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseShopButton
            // 
            this.CloseShopButton.Location = new System.Drawing.Point(59, 39);
            this.CloseShopButton.Name = "CloseShopButton";
            this.CloseShopButton.Size = new System.Drawing.Size(422, 180);
            this.CloseShopButton.TabIndex = 0;
            this.CloseShopButton.Text = "Назад";
            this.CloseShopButton.UseVisualStyleBackColor = true;
            this.CloseShopButton.Click += new System.EventHandler(this.CloseShopButton_click);
            // 
            // HeroSkinsButton
            // 
            this.HeroSkinsButton.Location = new System.Drawing.Point(633, 610);
            this.HeroSkinsButton.Name = "HeroSkinsButton";
            this.HeroSkinsButton.Size = new System.Drawing.Size(320, 150);
            this.HeroSkinsButton.TabIndex = 1;
            this.HeroSkinsButton.Text = "Герой";
            this.HeroSkinsButton.UseVisualStyleBackColor = true;
            this.HeroSkinsButton.Click += new System.EventHandler(this.HeroSkinsButton_Click);
            // 
            // BackGroundSkinsButton
            // 
            this.BackGroundSkinsButton.Location = new System.Drawing.Point(1065, 610);
            this.BackGroundSkinsButton.Name = "BackGroundSkinsButton";
            this.BackGroundSkinsButton.Size = new System.Drawing.Size(320, 150);
            this.BackGroundSkinsButton.TabIndex = 2;
            this.BackGroundSkinsButton.Text = "Окружение";
            this.BackGroundSkinsButton.UseVisualStyleBackColor = true;
            this.BackGroundSkinsButton.Click += new System.EventHandler(this.BackGroundSkinsButton_Click);
            // 
            // PicBackGroundSkinsMenu
            // 
            this.PicBackGroundSkinsMenu.BackgroundImage = global::HelicopterShooter.Properties.Resources.OIP__2_;
            this.PicBackGroundSkinsMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBackGroundSkinsMenu.Location = new System.Drawing.Point(1028, 204);
            this.PicBackGroundSkinsMenu.Name = "PicBackGroundSkinsMenu";
            this.PicBackGroundSkinsMenu.Size = new System.Drawing.Size(400, 400);
            this.PicBackGroundSkinsMenu.TabIndex = 8;
            this.PicBackGroundSkinsMenu.TabStop = false;
            // 
            // PicHeroSkinsMenu
            // 
            this.PicHeroSkinsMenu.BackgroundImage = global::HelicopterShooter.Properties.Resources.OIP__1_;
            this.PicHeroSkinsMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicHeroSkinsMenu.Location = new System.Drawing.Point(588, 204);
            this.PicHeroSkinsMenu.Name = "PicHeroSkinsMenu";
            this.PicHeroSkinsMenu.Size = new System.Drawing.Size(400, 400);
            this.PicHeroSkinsMenu.TabIndex = 7;
            this.PicHeroSkinsMenu.TabStop = false;
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1940, 1100);
            this.ControlBox = false;
            this.Controls.Add(this.PicBackGroundSkinsMenu);
            this.Controls.Add(this.PicHeroSkinsMenu);
            this.Controls.Add(this.BackGroundSkinsButton);
            this.Controls.Add(this.HeroSkinsButton);
            this.Controls.Add(this.CloseShopButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShopForm";
            this.Text = "ShopForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.PicBackGroundSkinsMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicHeroSkinsMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseShopButton;
        private System.Windows.Forms.Button HeroSkinsButton;
        private System.Windows.Forms.Button BackGroundSkinsButton;
        private System.Windows.Forms.PictureBox PicHeroSkinsMenu;
        private System.Windows.Forms.PictureBox PicBackGroundSkinsMenu;
    }
}