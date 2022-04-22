
namespace KomisSamochodowy
{
    partial class ConfigurationForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.additionalLabel = new System.Windows.Forms.Label();
            this.colorSelect = new System.Windows.Forms.ComboBox();
            this.colorLabel = new System.Windows.Forms.Label();
            this.engineSelect = new System.Windows.Forms.ComboBox();
            this.engineLabel = new System.Windows.Forms.Label();
            this.carModelSelect = new System.Windows.Forms.ComboBox();
            this.carModelLabel = new System.Windows.Forms.Label();
            this.brandSelect = new System.Windows.Forms.ComboBox();
            this.brandLabel = new System.Windows.Forms.Label();
            this.additionalListBox = new System.Windows.Forms.CheckedListBox();
            this.separatePanel = new System.Windows.Forms.Panel();
            this.footerPanel = new System.Windows.Forms.TableLayoutPanel();
            this.saveBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.secondSeparatePanel = new System.Windows.Forms.Panel();
            this.carPictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.footerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.additionalLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.colorSelect, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.colorLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.engineSelect, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.engineLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.carModelSelect, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.carModelLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.brandSelect, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.brandLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.additionalListBox, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(290, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // additionalLabel
            // 
            this.additionalLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.additionalLabel.AutoSize = true;
            this.additionalLabel.Font = new System.Drawing.Font("Calibri", 15F);
            this.additionalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.additionalLabel.Location = new System.Drawing.Point(31, 347);
            this.additionalLabel.Name = "additionalLabel";
            this.additionalLabel.Size = new System.Drawing.Size(80, 24);
            this.additionalLabel.TabIndex = 9;
            this.additionalLabel.Text = "Dodatki:";
            // 
            // colorSelect
            // 
            this.colorSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.colorSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorSelect.Font = new System.Drawing.Font("Calibri", 15F);
            this.colorSelect.FormattingEnabled = true;
            this.colorSelect.Location = new System.Drawing.Point(145, 218);
            this.colorSelect.Name = "colorSelect";
            this.colorSelect.Size = new System.Drawing.Size(136, 32);
            this.colorSelect.TabIndex = 7;
            // 
            // colorLabel
            // 
            this.colorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.colorLabel.AutoSize = true;
            this.colorLabel.Font = new System.Drawing.Font("Calibri", 15F);
            this.colorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.colorLabel.Location = new System.Drawing.Point(10, 222);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(121, 24);
            this.colorLabel.TabIndex = 6;
            this.colorLabel.Text = "Kolor lakieru:";
            // 
            // engineSelect
            // 
            this.engineSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.engineSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.engineSelect.Font = new System.Drawing.Font("Calibri", 15F);
            this.engineSelect.FormattingEnabled = true;
            this.engineSelect.Location = new System.Drawing.Point(145, 151);
            this.engineSelect.Name = "engineSelect";
            this.engineSelect.Size = new System.Drawing.Size(136, 32);
            this.engineSelect.TabIndex = 5;
            // 
            // engineLabel
            // 
            this.engineLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.engineLabel.AutoSize = true;
            this.engineLabel.Font = new System.Drawing.Font("Calibri", 15F);
            this.engineLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.engineLabel.Location = new System.Drawing.Point(41, 155);
            this.engineLabel.Name = "engineLabel";
            this.engineLabel.Size = new System.Drawing.Size(59, 24);
            this.engineLabel.TabIndex = 4;
            this.engineLabel.Text = "Silnik:";
            // 
            // carModelSelect
            // 
            this.carModelSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.carModelSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carModelSelect.Font = new System.Drawing.Font("Calibri", 15F);
            this.carModelSelect.FormattingEnabled = true;
            this.carModelSelect.Location = new System.Drawing.Point(145, 84);
            this.carModelSelect.Name = "carModelSelect";
            this.carModelSelect.Size = new System.Drawing.Size(136, 32);
            this.carModelSelect.TabIndex = 3;
            this.carModelSelect.TextChanged += new System.EventHandler(this.carModelSelect_Changed);
            // 
            // carModelLabel
            // 
            this.carModelLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.carModelLabel.AutoSize = true;
            this.carModelLabel.Font = new System.Drawing.Font("Calibri", 15F);
            this.carModelLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.carModelLabel.Location = new System.Drawing.Point(36, 88);
            this.carModelLabel.Name = "carModelLabel";
            this.carModelLabel.Size = new System.Drawing.Size(69, 24);
            this.carModelLabel.TabIndex = 2;
            this.carModelLabel.Text = "Model:";
            // 
            // brandSelect
            // 
            this.brandSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.brandSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.brandSelect.Font = new System.Drawing.Font("Calibri", 15F);
            this.brandSelect.FormattingEnabled = true;
            this.brandSelect.Location = new System.Drawing.Point(145, 17);
            this.brandSelect.Name = "brandSelect";
            this.brandSelect.Size = new System.Drawing.Size(136, 32);
            this.brandSelect.TabIndex = 1;
            this.brandSelect.TextChanged += new System.EventHandler(this.brandSelect_Changed);
            // 
            // brandLabel
            // 
            this.brandLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.brandLabel.AutoSize = true;
            this.brandLabel.Font = new System.Drawing.Font("Calibri", 15F);
            this.brandLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.brandLabel.Location = new System.Drawing.Point(37, 21);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(68, 24);
            this.brandLabel.TabIndex = 1;
            this.brandLabel.Text = "Marka:";
            // 
            // additionalListBox
            // 
            this.additionalListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.additionalListBox.Font = new System.Drawing.Font("Calibri", 10F);
            this.additionalListBox.FormattingEnabled = true;
            this.additionalListBox.Location = new System.Drawing.Point(145, 271);
            this.additionalListBox.Name = "additionalListBox";
            this.additionalListBox.Size = new System.Drawing.Size(136, 176);
            this.additionalListBox.TabIndex = 8;
            // 
            // separatePanel
            // 
            this.separatePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.separatePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.separatePanel.Location = new System.Drawing.Point(290, 0);
            this.separatePanel.Name = "separatePanel";
            this.separatePanel.Size = new System.Drawing.Size(10, 450);
            this.separatePanel.TabIndex = 2;
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.footerPanel.ColumnCount = 2;
            this.footerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.footerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.footerPanel.Controls.Add(this.saveBtn, 0, 0);
            this.footerPanel.Controls.Add(this.clearBtn, 0, 0);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(300, 370);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.RowCount = 1;
            this.footerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.footerPanel.Size = new System.Drawing.Size(600, 80);
            this.footerPanel.TabIndex = 3;
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(50)))));
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Calibri", 15F);
            this.saveBtn.ForeColor = System.Drawing.Color.Black;
            this.saveBtn.Location = new System.Drawing.Point(350, 22);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(200, 36);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Zapisz";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Calibri", 15F);
            this.clearBtn.ForeColor = System.Drawing.Color.Black;
            this.clearBtn.Location = new System.Drawing.Point(50, 22);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(200, 36);
            this.clearBtn.TabIndex = 2;
            this.clearBtn.Text = "Reset";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // secondSeparatePanel
            // 
            this.secondSeparatePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.secondSeparatePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.secondSeparatePanel.Location = new System.Drawing.Point(300, 360);
            this.secondSeparatePanel.Name = "secondSeparatePanel";
            this.secondSeparatePanel.Size = new System.Drawing.Size(600, 10);
            this.secondSeparatePanel.TabIndex = 4;
            // 
            // carPictureBox
            // 
            this.carPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.carPictureBox.Location = new System.Drawing.Point(300, 0);
            this.carPictureBox.Name = "carPictureBox";
            this.carPictureBox.Size = new System.Drawing.Size(600, 360);
            this.carPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.carPictureBox.TabIndex = 5;
            this.carPictureBox.TabStop = false;
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.carPictureBox);
            this.Controls.Add(this.secondSeparatePanel);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.separatePanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ConfigurationForm";
            this.Text = "ConfigurationForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.footerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.ComboBox brandSelect;
        private System.Windows.Forms.Panel separatePanel;
        private System.Windows.Forms.ComboBox carModelSelect;
        private System.Windows.Forms.Label carModelLabel;
        private System.Windows.Forms.Label additionalLabel;
        private System.Windows.Forms.ComboBox colorSelect;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.ComboBox engineSelect;
        private System.Windows.Forms.Label engineLabel;
        private System.Windows.Forms.CheckedListBox additionalListBox;
        private System.Windows.Forms.TableLayoutPanel footerPanel;
        private System.Windows.Forms.Panel secondSeparatePanel;
        private System.Windows.Forms.PictureBox carPictureBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button clearBtn;
    }
}