
namespace KomisSamochodowy
{
    partial class TestDriveForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.carListBox = new System.Windows.Forms.ListBox();
            this.separatePanel = new System.Windows.Forms.Panel();
            this.panelHedaer = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.secondSeparatePanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.saveBtn = new System.Windows.Forms.Button();
            this.carCalendar = new System.Windows.Forms.MonthCalendar();
            this.panel1.SuspendLayout();
            this.panelHedaer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.carListBox);
            this.panel1.Controls.Add(this.separatePanel);
            this.panel1.Controls.Add(this.panelHedaer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 450);
            this.panel1.TabIndex = 1;
            // 
            // carListBox
            // 
            this.carListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.carListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.carListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carListBox.Font = new System.Drawing.Font("Calibri", 15F);
            this.carListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.carListBox.FormattingEnabled = true;
            this.carListBox.ItemHeight = 24;
            this.carListBox.Location = new System.Drawing.Point(0, 69);
            this.carListBox.Name = "carListBox";
            this.carListBox.Size = new System.Drawing.Size(350, 381);
            this.carListBox.TabIndex = 8;
            this.carListBox.SelectedIndexChanged += new System.EventHandler(this.carListBox_Select);
            // 
            // separatePanel
            // 
            this.separatePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.separatePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.separatePanel.Location = new System.Drawing.Point(0, 59);
            this.separatePanel.Name = "separatePanel";
            this.separatePanel.Size = new System.Drawing.Size(350, 10);
            this.separatePanel.TabIndex = 7;
            // 
            // panelHedaer
            // 
            this.panelHedaer.Controls.Add(this.titleLabel);
            this.panelHedaer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHedaer.Location = new System.Drawing.Point(0, 0);
            this.panelHedaer.Name = "panelHedaer";
            this.panelHedaer.Size = new System.Drawing.Size(350, 59);
            this.panelHedaer.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.titleLabel.Location = new System.Drawing.Point(76, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(230, 40);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Twoje samochody";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secondSeparatePanel
            // 
            this.secondSeparatePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.secondSeparatePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.secondSeparatePanel.Location = new System.Drawing.Point(350, 0);
            this.secondSeparatePanel.Name = "secondSeparatePanel";
            this.secondSeparatePanel.Size = new System.Drawing.Size(10, 450);
            this.secondSeparatePanel.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.saveBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(360, 370);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 80);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(360, 360);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(540, 10);
            this.panel3.TabIndex = 7;
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(50)))));
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Calibri", 15F);
            this.saveBtn.ForeColor = System.Drawing.Color.Black;
            this.saveBtn.Location = new System.Drawing.Point(170, 22);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(200, 36);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Zapisz";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // carCalendar
            // 
            this.carCalendar.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.carCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carCalendar.Location = new System.Drawing.Point(360, 0);
            this.carCalendar.MaxSelectionCount = 365;
            this.carCalendar.Name = "carCalendar";
            this.carCalendar.TabIndex = 8;
            // 
            // TestDriveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.carCalendar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.secondSeparatePanel);
            this.Controls.Add(this.panel1);
            this.Name = "TestDriveForm";
            this.Text = "TestDriveForm";
            this.panel1.ResumeLayout(false);
            this.panelHedaer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel secondSeparatePanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel panelHedaer;
        private System.Windows.Forms.ListBox carListBox;
        private System.Windows.Forms.Panel separatePanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.MonthCalendar carCalendar;
    }
}