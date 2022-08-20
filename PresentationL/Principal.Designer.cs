namespace PresentationL
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.AllPanel = new Guna.UI.WinForms.GunaGradient2Panel();
            this.RutaB = new Guna.UI.WinForms.GunaButton();
            this.AsignaA = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.ChofeBtn = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.lightbtn = new Guna.UI.WinForms.GunaCircleButton();
            this.AllPanel.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllPanel
            // 
            this.AllPanel.BackColor = System.Drawing.Color.Transparent;
            this.AllPanel.Controls.Add(this.RutaB);
            this.AllPanel.Controls.Add(this.AsignaA);
            this.AllPanel.Controls.Add(this.gunaButton1);
            this.AllPanel.Controls.Add(this.ChofeBtn);
            this.AllPanel.Controls.Add(this.gunaPanel1);
            this.AllPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllPanel.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.AllPanel.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.AllPanel.Location = new System.Drawing.Point(0, 0);
            this.AllPanel.Name = "AllPanel";
            this.AllPanel.Size = new System.Drawing.Size(800, 450);
            this.AllPanel.TabIndex = 0;
            // 
            // RutaB
            // 
            this.RutaB.AnimationHoverSpeed = 0.07F;
            this.RutaB.AnimationSpeed = 0.03F;
            this.RutaB.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(57)))), ((int)(((byte)(66)))));
            this.RutaB.BorderColor = System.Drawing.Color.Black;
            this.RutaB.DialogResult = System.Windows.Forms.DialogResult.None;
            this.RutaB.FocusedColor = System.Drawing.Color.Empty;
            this.RutaB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.RutaB.ForeColor = System.Drawing.Color.White;
            this.RutaB.Image = ((System.Drawing.Image)(resources.GetObject("RutaB.Image")));
            this.RutaB.ImageSize = new System.Drawing.Size(45, 45);
            this.RutaB.Location = new System.Drawing.Point(109, 223);
            this.RutaB.Name = "RutaB";
            this.RutaB.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.RutaB.OnHoverBorderColor = System.Drawing.Color.Black;
            this.RutaB.OnHoverForeColor = System.Drawing.Color.White;
            this.RutaB.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("RutaB.OnHoverImage")));
            this.RutaB.OnPressedColor = System.Drawing.Color.Black;
            this.RutaB.Size = new System.Drawing.Size(326, 105);
            this.RutaB.TabIndex = 9;
            this.RutaB.Text = "Rutas de Patrullaje";
            this.RutaB.Click += new System.EventHandler(this.RutaB_Click);
            // 
            // AsignaA
            // 
            this.AsignaA.AnimationHoverSpeed = 0.07F;
            this.AsignaA.AnimationSpeed = 0.03F;
            this.AsignaA.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(57)))), ((int)(((byte)(66)))));
            this.AsignaA.BorderColor = System.Drawing.Color.Black;
            this.AsignaA.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AsignaA.FocusedColor = System.Drawing.Color.Empty;
            this.AsignaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.AsignaA.ForeColor = System.Drawing.Color.White;
            this.AsignaA.Image = ((System.Drawing.Image)(resources.GetObject("AsignaA.Image")));
            this.AsignaA.ImageSize = new System.Drawing.Size(45, 45);
            this.AsignaA.Location = new System.Drawing.Point(441, 223);
            this.AsignaA.Name = "AsignaA";
            this.AsignaA.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.AsignaA.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AsignaA.OnHoverForeColor = System.Drawing.Color.White;
            this.AsignaA.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("AsignaA.OnHoverImage")));
            this.AsignaA.OnPressedColor = System.Drawing.Color.Black;
            this.AsignaA.Size = new System.Drawing.Size(326, 105);
            this.AsignaA.TabIndex = 8;
            this.AsignaA.Text = "Asignar Patrullas";
            this.AsignaA.Click += new System.EventHandler(this.AsignaA_Click);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(57)))), ((int)(((byte)(66)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(45, 45);
            this.gunaButton1.Location = new System.Drawing.Point(441, 112);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaButton1.OnHoverImage")));
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(326, 105);
            this.gunaButton1.TabIndex = 7;
            this.gunaButton1.Text = "Patrulla Oficial";
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // ChofeBtn
            // 
            this.ChofeBtn.AnimationHoverSpeed = 0.07F;
            this.ChofeBtn.AnimationSpeed = 0.03F;
            this.ChofeBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(57)))), ((int)(((byte)(66)))));
            this.ChofeBtn.BorderColor = System.Drawing.Color.Black;
            this.ChofeBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ChofeBtn.FocusedColor = System.Drawing.Color.Empty;
            this.ChofeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ChofeBtn.ForeColor = System.Drawing.Color.White;
            this.ChofeBtn.Image = ((System.Drawing.Image)(resources.GetObject("ChofeBtn.Image")));
            this.ChofeBtn.ImageSize = new System.Drawing.Size(45, 45);
            this.ChofeBtn.Location = new System.Drawing.Point(109, 112);
            this.ChofeBtn.Name = "ChofeBtn";
            this.ChofeBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ChofeBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ChofeBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.ChofeBtn.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("ChofeBtn.OnHoverImage")));
            this.ChofeBtn.OnPressedColor = System.Drawing.Color.Black;
            this.ChofeBtn.Size = new System.Drawing.Size(326, 105);
            this.ChofeBtn.TabIndex = 3;
            this.ChofeBtn.Text = "Oficial Policial";
            this.ChofeBtn.Click += new System.EventHandler(this.ChofeBtn_Click);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.lightbtn);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(54, 450);
            this.gunaPanel1.TabIndex = 0;
            // 
            // lightbtn
            // 
            this.lightbtn.AnimationHoverSpeed = 0.07F;
            this.lightbtn.AnimationSpeed = 0.03F;
            this.lightbtn.BaseColor = System.Drawing.Color.Empty;
            this.lightbtn.BorderColor = System.Drawing.Color.Black;
            this.lightbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.lightbtn.FocusedColor = System.Drawing.Color.Empty;
            this.lightbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lightbtn.ForeColor = System.Drawing.Color.White;
            this.lightbtn.Image = ((System.Drawing.Image)(resources.GetObject("lightbtn.Image")));
            this.lightbtn.ImageSize = new System.Drawing.Size(40, 40);
            this.lightbtn.Location = new System.Drawing.Point(6, 403);
            this.lightbtn.Name = "lightbtn";
            this.lightbtn.OnHoverBaseColor = System.Drawing.Color.Empty;
            this.lightbtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.lightbtn.OnHoverForeColor = System.Drawing.Color.White;
            this.lightbtn.OnHoverImage = null;
            this.lightbtn.OnPressedColor = System.Drawing.Color.Black;
            this.lightbtn.Size = new System.Drawing.Size(35, 35);
            this.lightbtn.TabIndex = 0;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AllPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bus 2 You";
            this.AllPanel.ResumeLayout(false);
            this.gunaPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradient2Panel AllPanel;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaCircleButton lightbtn;
        private Guna.UI.WinForms.GunaButton ChofeBtn;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaButton RutaB;
        private Guna.UI.WinForms.GunaButton AsignaA;
    }
}

