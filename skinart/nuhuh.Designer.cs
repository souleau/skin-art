namespace skinart
{
    partial class SkinArt
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SkinArt));
            this.FadeTimer = new System.Windows.Forms.Timer(this.components);
            this.zoomTimer = new System.Windows.Forms.Timer(this.components);
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.skinPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.skin = new System.Windows.Forms.Label();
            this.mapPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.ResizeButton = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.skinPanel.SuspendLayout();
            this.mapPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FadeTimer
            // 
            this.FadeTimer.Enabled = true;
            this.FadeTimer.Tick += new System.EventHandler(this.FadeTimer_Tick);
            // 
            // zoomTimer
            // 
            this.zoomTimer.Enabled = true;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderRadius = 4;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button1.Font = new System.Drawing.Font("Inter Italic", 12F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(12, 362);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(111, 28);
            this.guna2Button1.TabIndex = 3;
            this.guna2Button1.Text = "select skin";
            this.guna2Button1.Click += new System.EventHandler(this.skinbtn_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.BorderRadius = 4;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button2.Font = new System.Drawing.Font("Inter Italic", 12F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(288, 362);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(126, 28);
            this.guna2Button2.TabIndex = 4;
            this.guna2Button2.Text = "image select";
            this.guna2Button2.Click += new System.EventHandler(this.mapbtn_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.Animated = true;
            this.guna2Button3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button3.BorderRadius = 4;
            this.guna2Button3.BorderThickness = 1;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.White;
            this.guna2Button3.Font = new System.Drawing.Font("Inter Italic", 12F);
            this.guna2Button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button3.Location = new System.Drawing.Point(169, 362);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(89, 28);
            this.guna2Button3.TabIndex = 5;
            this.guna2Button3.Text = "process";
            this.guna2Button3.Click += new System.EventHandler(this.process_Click);
            // 
            // skinPanel
            // 
            this.skinPanel.BorderColor = System.Drawing.Color.Silver;
            this.skinPanel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.skinPanel.BorderThickness = 1;
            this.skinPanel.Controls.Add(this.skin);
            this.skinPanel.CustomBorderColor = System.Drawing.Color.Silver;
            this.skinPanel.Location = new System.Drawing.Point(12, 72);
            this.skinPanel.Name = "skinPanel";
            this.skinPanel.Size = new System.Drawing.Size(185, 182);
            this.skinPanel.TabIndex = 6;
            this.skinPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.skinPanel_DragDrop_1);
            this.skinPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.skinPanel_DragEnter_1);
            // 
            // skin
            // 
            this.skin.AutoSize = true;
            this.skin.Font = new System.Drawing.Font("Inter Italic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skin.Location = new System.Drawing.Point(73, 4);
            this.skin.Name = "skin";
            this.skin.Size = new System.Drawing.Size(39, 19);
            this.skin.TabIndex = 8;
            this.skin.Text = "skin";
            // 
            // mapPanel
            // 
            this.mapPanel.BorderColor = System.Drawing.Color.Silver;
            this.mapPanel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.mapPanel.BorderThickness = 1;
            this.mapPanel.Controls.Add(this.label1);
            this.mapPanel.CustomBorderColor = System.Drawing.Color.Silver;
            this.mapPanel.Location = new System.Drawing.Point(229, 72);
            this.mapPanel.Name = "mapPanel";
            this.mapPanel.Size = new System.Drawing.Size(185, 182);
            this.mapPanel.TabIndex = 7;
            this.mapPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.mapPanel_DragDrop_1);
            this.mapPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.mapPanel_DragEnter_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter Italic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "image";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.DragStartTransparencyValue = 1D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2ProgressBar1
            // 
            this.guna2ProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ProgressBar1.BorderRadius = 6;
            this.guna2ProgressBar1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2ProgressBar1.BorderThickness = 1;
            this.guna2ProgressBar1.FillColor = System.Drawing.Color.White;
            this.guna2ProgressBar1.Location = new System.Drawing.Point(63, 281);
            this.guna2ProgressBar1.Name = "guna2ProgressBar1";
            this.guna2ProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2ProgressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2ProgressBar1.ShadowDecoration.Enabled = true;
            this.guna2ProgressBar1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.guna2ProgressBar1.Size = new System.Drawing.Size(300, 30);
            this.guna2ProgressBar1.TabIndex = 8;
            this.guna2ProgressBar1.Text = "guna2ProgressBar1";
            this.guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // ResizeButton
            // 
            this.ResizeButton.Animated = true;
            this.ResizeButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ResizeButton.BorderRadius = 4;
            this.ResizeButton.BorderThickness = 1;
            this.ResizeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ResizeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ResizeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ResizeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ResizeButton.FillColor = System.Drawing.Color.White;
            this.ResizeButton.Font = new System.Drawing.Font("Inter Italic", 12F);
            this.ResizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ResizeButton.Location = new System.Drawing.Point(288, 328);
            this.ResizeButton.Name = "ResizeButton";
            this.ResizeButton.Size = new System.Drawing.Size(126, 28);
            this.ResizeButton.TabIndex = 9;
            this.ResizeButton.Text = "resize image";
            this.ResizeButton.Click += new System.EventHandler(this.processmap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter Italic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "join my discord for more";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.Animated = true;
            this.guna2Button4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button4.BorderRadius = 4;
            this.guna2Button4.BorderThickness = 1;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.White;
            this.guna2Button4.Font = new System.Drawing.Font("Inter Italic", 12F);
            this.guna2Button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button4.Location = new System.Drawing.Point(169, 328);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(89, 28);
            this.guna2Button4.TabIndex = 11;
            this.guna2Button4.Text = "discord";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // SkinArt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(426, 413);
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ResizeButton);
            this.Controls.Add(this.guna2ProgressBar1);
            this.Controls.Add(this.mapPanel);
            this.Controls.Add(this.skinPanel);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SkinArt";
            this.Text = "Skin Art";
            this.skinPanel.ResumeLayout(false);
            this.skinPanel.PerformLayout();
            this.mapPanel.ResumeLayout(false);
            this.mapPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer FadeTimer;
        private System.Windows.Forms.Timer zoomTimer;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Panel skinPanel;
        private Guna.UI2.WinForms.Guna2Panel mapPanel;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Label skin;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar1;
        private Guna.UI2.WinForms.Guna2Button ResizeButton;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
    }
}

