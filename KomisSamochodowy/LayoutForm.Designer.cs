
namespace KomisSamochodowy
{
    partial class LayoutForm
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
            this.headerPanel = new System.Windows.Forms.Panel();
            this.menuPanel = new System.Windows.Forms.TableLayoutPanel();
            this.testDriveBtn = new System.Windows.Forms.Button();
            this.newCarBtn = new System.Windows.Forms.Button();
            this.configurationBtn = new System.Windows.Forms.Button();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.separatePanel = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.headerPanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.headerPanel.Controls.Add(this.menuPanel);
            this.headerPanel.Controls.Add(this.titlePanel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.ForeColor = System.Drawing.Color.White;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(900, 80);
            this.headerPanel.TabIndex = 0;
            // 
            // menuPanel
            // 
            this.menuPanel.ColumnCount = 3;
            this.menuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.menuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.menuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.menuPanel.Controls.Add(this.testDriveBtn, 2, 0);
            this.menuPanel.Controls.Add(this.newCarBtn, 1, 0);
            this.menuPanel.Controls.Add(this.configurationBtn, 0, 0);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuPanel.Location = new System.Drawing.Point(240, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.RowCount = 1;
            this.menuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.menuPanel.Size = new System.Drawing.Size(660, 80);
            this.menuPanel.TabIndex = 1;
            // 
            // testDriveBtn
            // 
            this.testDriveBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.testDriveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(50)))));
            this.testDriveBtn.FlatAppearance.BorderSize = 0;
            this.testDriveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testDriveBtn.Font = new System.Drawing.Font("Calibri", 15F);
            this.testDriveBtn.ForeColor = System.Drawing.Color.Black;
            this.testDriveBtn.Location = new System.Drawing.Point(450, 22);
            this.testDriveBtn.Name = "testDriveBtn";
            this.testDriveBtn.Size = new System.Drawing.Size(200, 36);
            this.testDriveBtn.TabIndex = 3;
            this.testDriveBtn.Text = "Jazda próbna";
            this.testDriveBtn.UseVisualStyleBackColor = false;
            this.testDriveBtn.Click += new System.EventHandler(this.testDriveBtn_Click);
            // 
            // newCarBtn
            // 
            this.newCarBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newCarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(50)))));
            this.newCarBtn.FlatAppearance.BorderSize = 0;
            this.newCarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newCarBtn.Font = new System.Drawing.Font("Calibri", 15F);
            this.newCarBtn.ForeColor = System.Drawing.Color.Black;
            this.newCarBtn.Location = new System.Drawing.Point(230, 22);
            this.newCarBtn.Name = "newCarBtn";
            this.newCarBtn.Size = new System.Drawing.Size(200, 36);
            this.newCarBtn.TabIndex = 2;
            this.newCarBtn.Text = "Dodaj samochód";
            this.newCarBtn.UseVisualStyleBackColor = false;
            this.newCarBtn.Click += new System.EventHandler(this.newCarBtn_Click);
            // 
            // configurationBtn
            // 
            this.configurationBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.configurationBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(50)))));
            this.configurationBtn.FlatAppearance.BorderSize = 0;
            this.configurationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.configurationBtn.Font = new System.Drawing.Font("Calibri", 15F);
            this.configurationBtn.ForeColor = System.Drawing.Color.Black;
            this.configurationBtn.Location = new System.Drawing.Point(10, 22);
            this.configurationBtn.Name = "configurationBtn";
            this.configurationBtn.Size = new System.Drawing.Size(200, 36);
            this.configurationBtn.TabIndex = 1;
            this.configurationBtn.Text = "Konfiguracja";
            this.configurationBtn.UseVisualStyleBackColor = false;
            this.configurationBtn.Click += new System.EventHandler(this.configurationBtn_Click);
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.titleLabel);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(240, 80);
            this.titlePanel.TabIndex = 2;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(3, 28);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(231, 23);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Komis Samochodowy";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // separatePanel
            // 
            this.separatePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.separatePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.separatePanel.Location = new System.Drawing.Point(0, 80);
            this.separatePanel.Name = "separatePanel";
            this.separatePanel.Size = new System.Drawing.Size(900, 10);
            this.separatePanel.TabIndex = 1;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 90);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(900, 650);
            this.panelChildForm.TabIndex = 2;
            // 
            // LayoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(900, 740);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.separatePanel);
            this.Controls.Add(this.headerPanel);
            this.Name = "LayoutForm";
            this.Text = "Form1";
            this.headerPanel.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.TableLayoutPanel menuPanel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button configurationBtn;
        private System.Windows.Forms.Button newCarBtn;
        private System.Windows.Forms.Button testDriveBtn;
        private System.Windows.Forms.Panel separatePanel;
        private System.Windows.Forms.Panel panelChildForm;
    }
}

