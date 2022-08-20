namespace PresentationL
{
    partial class Ruta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ruta));
            this.AllPanel = new Guna.UI.WinForms.GunaGradient2Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SearchBtn = new Guna.UI.WinForms.GunaCircleButton();
            this.SearchBox = new Guna.UI.WinForms.GunaTextBox();
            this.EditBtn = new Guna.UI.WinForms.GunaCircleButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gunaCircleButton2 = new Guna.UI.WinForms.GunaCircleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.returnBtn = new Guna.UI.WinForms.GunaCircleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DistBox = new Guna.UI.WinForms.GunaTextBox();
            this.Deletebtn = new Guna.UI.WinForms.GunaCircleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Save = new Guna.UI.WinForms.GunaCircleButton();
            this.RutaBox = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AllPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllPanel
            // 
            this.AllPanel.BackColor = System.Drawing.Color.Transparent;
            this.AllPanel.Controls.Add(this.panel2);
            this.AllPanel.Controls.Add(this.gunaCircleButton2);
            this.AllPanel.Controls.Add(this.panel1);
            this.AllPanel.Controls.Add(this.groupBox1);
            this.AllPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllPanel.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.AllPanel.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.AllPanel.Location = new System.Drawing.Point(0, 0);
            this.AllPanel.Name = "AllPanel";
            this.AllPanel.Size = new System.Drawing.Size(800, 450);
            this.AllPanel.TabIndex = 4;
            this.AllPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AllPanel_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SearchBtn);
            this.panel2.Controls.Add(this.SearchBox);
            this.panel2.Controls.Add(this.EditBtn);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(82, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 417);
            this.panel2.TabIndex = 6;
            // 
            // SearchBtn
            // 
            this.SearchBtn.AnimationHoverSpeed = 0.07F;
            this.SearchBtn.AnimationSpeed = 0.03F;
            this.SearchBtn.BaseColor = System.Drawing.Color.Empty;
            this.SearchBtn.BorderColor = System.Drawing.Color.Black;
            this.SearchBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SearchBtn.FocusedColor = System.Drawing.Color.Empty;
            this.SearchBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.Image = ((System.Drawing.Image)(resources.GetObject("SearchBtn.Image")));
            this.SearchBtn.ImageSize = new System.Drawing.Size(45, 45);
            this.SearchBtn.Location = new System.Drawing.Point(261, 359);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.OnHoverBaseColor = System.Drawing.Color.Empty;
            this.SearchBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SearchBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.SearchBtn.OnHoverImage = null;
            this.SearchBtn.OnPressedColor = System.Drawing.Color.Black;
            this.SearchBtn.Size = new System.Drawing.Size(38, 45);
            this.SearchBtn.TabIndex = 11;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click_1);
            // 
            // SearchBox
            // 
            this.SearchBox.BaseColor = System.Drawing.Color.White;
            this.SearchBox.BorderColor = System.Drawing.Color.Silver;
            this.SearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchBox.FocusedBaseColor = System.Drawing.Color.White;
            this.SearchBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SearchBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.SearchBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchBox.Location = new System.Drawing.Point(93, 374);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.PasswordChar = '\0';
            this.SearchBox.Size = new System.Drawing.Size(155, 30);
            this.SearchBox.TabIndex = 3;
            this.SearchBox.Tag = "Buscar";
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged_1);
            // 
            // EditBtn
            // 
            this.EditBtn.AnimationHoverSpeed = 0.07F;
            this.EditBtn.AnimationSpeed = 0.03F;
            this.EditBtn.BaseColor = System.Drawing.Color.Empty;
            this.EditBtn.BorderColor = System.Drawing.Color.Black;
            this.EditBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.EditBtn.FocusedColor = System.Drawing.Color.Empty;
            this.EditBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.Image = ((System.Drawing.Image)(resources.GetObject("EditBtn.Image")));
            this.EditBtn.ImageSize = new System.Drawing.Size(45, 45);
            this.EditBtn.Location = new System.Drawing.Point(42, 359);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.OnHoverBaseColor = System.Drawing.Color.Empty;
            this.EditBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.EditBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.EditBtn.OnHoverImage = null;
            this.EditBtn.OnPressedColor = System.Drawing.Color.Black;
            this.EditBtn.Size = new System.Drawing.Size(38, 45);
            this.EditBtn.TabIndex = 1;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(336, 352);
            this.dataGridView1.TabIndex = 0;
            // 
            // gunaCircleButton2
            // 
            this.gunaCircleButton2.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton2.AnimationSpeed = 0.03F;
            this.gunaCircleButton2.BaseColor = System.Drawing.Color.Empty;
            this.gunaCircleButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton2.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaCircleButton2.Image")));
            this.gunaCircleButton2.ImageSize = new System.Drawing.Size(150, 150);
            this.gunaCircleButton2.Location = new System.Drawing.Point(659, 318);
            this.gunaCircleButton2.Name = "gunaCircleButton2";
            this.gunaCircleButton2.OnHoverBaseColor = System.Drawing.Color.Empty;
            this.gunaCircleButton2.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.gunaCircleButton2.OnHoverForeColor = System.Drawing.Color.Empty;
            this.gunaCircleButton2.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaCircleButton2.OnHoverImage")));
            this.gunaCircleButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton2.Size = new System.Drawing.Size(120, 120);
            this.gunaCircleButton2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.returnBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(53, 450);
            this.panel1.TabIndex = 3;
            // 
            // returnBtn
            // 
            this.returnBtn.AnimationHoverSpeed = 0.07F;
            this.returnBtn.AnimationSpeed = 0.03F;
            this.returnBtn.BaseColor = System.Drawing.Color.Empty;
            this.returnBtn.BorderColor = System.Drawing.Color.Black;
            this.returnBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.returnBtn.FocusedColor = System.Drawing.Color.Empty;
            this.returnBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.returnBtn.ForeColor = System.Drawing.Color.White;
            this.returnBtn.Image = ((System.Drawing.Image)(resources.GetObject("returnBtn.Image")));
            this.returnBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.returnBtn.Location = new System.Drawing.Point(9, 390);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.OnHoverBaseColor = System.Drawing.Color.Empty;
            this.returnBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.returnBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.returnBtn.OnHoverImage = null;
            this.returnBtn.OnPressedColor = System.Drawing.Color.Black;
            this.returnBtn.Size = new System.Drawing.Size(35, 35);
            this.returnBtn.TabIndex = 2;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DistBox);
            this.groupBox1.Controls.Add(this.Deletebtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Save);
            this.groupBox1.Controls.Add(this.RutaBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Silver;
            this.groupBox1.Location = new System.Drawing.Point(452, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 277);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ruta de Patrullaje";
            // 
            // DistBox
            // 
            this.DistBox.BaseColor = System.Drawing.Color.White;
            this.DistBox.BorderColor = System.Drawing.Color.Silver;
            this.DistBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DistBox.FocusedBaseColor = System.Drawing.Color.White;
            this.DistBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DistBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.DistBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DistBox.Location = new System.Drawing.Point(115, 108);
            this.DistBox.Name = "DistBox";
            this.DistBox.PasswordChar = '\0';
            this.DistBox.Size = new System.Drawing.Size(100, 30);
            this.DistBox.TabIndex = 10;
            this.DistBox.Tag = "";
            // 
            // Deletebtn
            // 
            this.Deletebtn.AnimationHoverSpeed = 0.07F;
            this.Deletebtn.AnimationSpeed = 0.03F;
            this.Deletebtn.BaseColor = System.Drawing.Color.Empty;
            this.Deletebtn.BorderColor = System.Drawing.Color.Black;
            this.Deletebtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Deletebtn.FocusedColor = System.Drawing.Color.Empty;
            this.Deletebtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Deletebtn.ForeColor = System.Drawing.Color.White;
            this.Deletebtn.Image = ((System.Drawing.Image)(resources.GetObject("Deletebtn.Image")));
            this.Deletebtn.ImageSize = new System.Drawing.Size(45, 45);
            this.Deletebtn.Location = new System.Drawing.Point(219, 217);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.OnHoverBaseColor = System.Drawing.Color.Empty;
            this.Deletebtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Deletebtn.OnHoverForeColor = System.Drawing.Color.White;
            this.Deletebtn.OnHoverImage = null;
            this.Deletebtn.OnPressedColor = System.Drawing.Color.Black;
            this.Deletebtn.Size = new System.Drawing.Size(38, 45);
            this.Deletebtn.TabIndex = 2;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "de ruta";
            // 
            // Save
            // 
            this.Save.AnimationHoverSpeed = 0.07F;
            this.Save.AnimationSpeed = 0.03F;
            this.Save.BaseColor = System.Drawing.Color.Empty;
            this.Save.BorderColor = System.Drawing.Color.Black;
            this.Save.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Save.FocusedColor = System.Drawing.Color.Empty;
            this.Save.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Save.ForeColor = System.Drawing.Color.White;
            this.Save.Image = ((System.Drawing.Image)(resources.GetObject("Save.Image")));
            this.Save.ImageSize = new System.Drawing.Size(45, 45);
            this.Save.Location = new System.Drawing.Point(274, 217);
            this.Save.Name = "Save";
            this.Save.OnHoverBaseColor = System.Drawing.Color.Empty;
            this.Save.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Save.OnHoverForeColor = System.Drawing.Color.White;
            this.Save.OnHoverImage = null;
            this.Save.OnPressedColor = System.Drawing.Color.Black;
            this.Save.Size = new System.Drawing.Size(38, 45);
            this.Save.TabIndex = 4;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // RutaBox
            // 
            this.RutaBox.BaseColor = System.Drawing.Color.White;
            this.RutaBox.BorderColor = System.Drawing.Color.Silver;
            this.RutaBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RutaBox.FocusedBaseColor = System.Drawing.Color.White;
            this.RutaBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.RutaBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.RutaBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RutaBox.Location = new System.Drawing.Point(115, 58);
            this.RutaBox.Name = "RutaBox";
            this.RutaBox.PasswordChar = '\0';
            this.RutaBox.Size = new System.Drawing.Size(197, 30);
            this.RutaBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Distancia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre ";
            // 
            // Ruta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AllPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ruta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ruta ";
            this.Load += new System.EventHandler(this.Ruta_Load);
            this.AllPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradient2Panel AllPanel;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaCircleButton returnBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI.WinForms.GunaTextBox DistBox;
        private Guna.UI.WinForms.GunaCircleButton Deletebtn;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaCircleButton Save;
        private Guna.UI.WinForms.GunaTextBox RutaBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaCircleButton SearchBtn;
        private Guna.UI.WinForms.GunaTextBox SearchBox;
        private Guna.UI.WinForms.GunaCircleButton EditBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}