namespace Project
{
    partial class frmMain
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnNewPrj = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnLoadPrj = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnNewPrj
            // 
            this.btnNewPrj.AllowToggling = false;
            this.btnNewPrj.AnimationSpeed = 200;
            this.btnNewPrj.AutoGenerateColors = false;
            this.btnNewPrj.BackColor = System.Drawing.Color.Transparent;
            this.btnNewPrj.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnNewPrj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewPrj.BackgroundImage")));
            this.btnNewPrj.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNewPrj.ButtonText = "Créer un nouveu projet";
            this.btnNewPrj.ButtonTextMarginLeft = 0;
            this.btnNewPrj.ColorContrastOnClick = 45;
            this.btnNewPrj.ColorContrastOnHover = 45;
            this.btnNewPrj.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnNewPrj.CustomizableEdges = borderEdges2;
            this.btnNewPrj.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNewPrj.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnNewPrj.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNewPrj.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnNewPrj.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnNewPrj.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnNewPrj.ForeColor = System.Drawing.Color.White;
            this.btnNewPrj.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewPrj.IconMarginLeft = 11;
            this.btnNewPrj.IconPadding = 10;
            this.btnNewPrj.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewPrj.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnNewPrj.IdleBorderRadius = 3;
            this.btnNewPrj.IdleBorderThickness = 1;
            this.btnNewPrj.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnNewPrj.IdleIconLeftImage = null;
            this.btnNewPrj.IdleIconRightImage = null;
            this.btnNewPrj.IndicateFocus = false;
            this.btnNewPrj.Location = new System.Drawing.Point(98, 142);
            this.btnNewPrj.Name = "btnNewPrj";
            this.btnNewPrj.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnNewPrj.onHoverState.BorderRadius = 3;
            this.btnNewPrj.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNewPrj.onHoverState.BorderThickness = 1;
            this.btnNewPrj.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnNewPrj.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnNewPrj.onHoverState.IconLeftImage = null;
            this.btnNewPrj.onHoverState.IconRightImage = null;
            this.btnNewPrj.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnNewPrj.OnIdleState.BorderRadius = 3;
            this.btnNewPrj.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNewPrj.OnIdleState.BorderThickness = 1;
            this.btnNewPrj.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnNewPrj.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnNewPrj.OnIdleState.IconLeftImage = null;
            this.btnNewPrj.OnIdleState.IconRightImage = null;
            this.btnNewPrj.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnNewPrj.OnPressedState.BorderRadius = 3;
            this.btnNewPrj.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNewPrj.OnPressedState.BorderThickness = 1;
            this.btnNewPrj.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnNewPrj.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnNewPrj.OnPressedState.IconLeftImage = null;
            this.btnNewPrj.OnPressedState.IconRightImage = null;
            this.btnNewPrj.Size = new System.Drawing.Size(210, 45);
            this.btnNewPrj.TabIndex = 0;
            this.btnNewPrj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewPrj.TextMarginLeft = 0;
            this.btnNewPrj.UseDefaultRadiusAndThickness = true;
            this.btnNewPrj.Click += new System.EventHandler(this.btnNewPrj_Click);
            // 
            // btnLoadPrj
            // 
            this.btnLoadPrj.AllowToggling = false;
            this.btnLoadPrj.AnimationSpeed = 200;
            this.btnLoadPrj.AutoGenerateColors = false;
            this.btnLoadPrj.BackColor = System.Drawing.Color.Transparent;
            this.btnLoadPrj.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnLoadPrj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoadPrj.BackgroundImage")));
            this.btnLoadPrj.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLoadPrj.ButtonText = "Ouvrir un projet";
            this.btnLoadPrj.ButtonTextMarginLeft = 0;
            this.btnLoadPrj.ColorContrastOnClick = 45;
            this.btnLoadPrj.ColorContrastOnHover = 45;
            this.btnLoadPrj.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnLoadPrj.CustomizableEdges = borderEdges1;
            this.btnLoadPrj.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLoadPrj.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnLoadPrj.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLoadPrj.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLoadPrj.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnLoadPrj.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnLoadPrj.ForeColor = System.Drawing.Color.White;
            this.btnLoadPrj.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadPrj.IconMarginLeft = 11;
            this.btnLoadPrj.IconPadding = 10;
            this.btnLoadPrj.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadPrj.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnLoadPrj.IdleBorderRadius = 3;
            this.btnLoadPrj.IdleBorderThickness = 1;
            this.btnLoadPrj.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnLoadPrj.IdleIconLeftImage = null;
            this.btnLoadPrj.IdleIconRightImage = null;
            this.btnLoadPrj.IndicateFocus = false;
            this.btnLoadPrj.Location = new System.Drawing.Point(98, 232);
            this.btnLoadPrj.Name = "btnLoadPrj";
            this.btnLoadPrj.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnLoadPrj.onHoverState.BorderRadius = 3;
            this.btnLoadPrj.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLoadPrj.onHoverState.BorderThickness = 1;
            this.btnLoadPrj.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnLoadPrj.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnLoadPrj.onHoverState.IconLeftImage = null;
            this.btnLoadPrj.onHoverState.IconRightImage = null;
            this.btnLoadPrj.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnLoadPrj.OnIdleState.BorderRadius = 3;
            this.btnLoadPrj.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLoadPrj.OnIdleState.BorderThickness = 1;
            this.btnLoadPrj.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnLoadPrj.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnLoadPrj.OnIdleState.IconLeftImage = null;
            this.btnLoadPrj.OnIdleState.IconRightImage = null;
            this.btnLoadPrj.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnLoadPrj.OnPressedState.BorderRadius = 3;
            this.btnLoadPrj.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLoadPrj.OnPressedState.BorderThickness = 1;
            this.btnLoadPrj.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnLoadPrj.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnLoadPrj.OnPressedState.IconLeftImage = null;
            this.btnLoadPrj.OnPressedState.IconRightImage = null;
            this.btnLoadPrj.Size = new System.Drawing.Size(210, 45);
            this.btnLoadPrj.TabIndex = 1;
            this.btnLoadPrj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLoadPrj.TextMarginLeft = 0;
            this.btnLoadPrj.UseDefaultRadiusAndThickness = true;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(456, 79);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(244, 254);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.btnLoadPrj);
            this.Controls.Add(this.btnNewPrj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnLoadPrj;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnNewPrj;
    }
}

