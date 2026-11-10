namespace FuegoOrderingSystem
{
    partial class KioskForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pbItem1 = new System.Windows.Forms.PictureBox();
            this.lblItem1 = new System.Windows.Forms.Label();
            this.pbItem2 = new System.Windows.Forms.PictureBox();
            this.lblItem2 = new System.Windows.Forms.Label();
            this.pbItem3 = new System.Windows.Forms.PictureBox();
            this.lblItem3 = new System.Windows.Forms.Label();
            this.pbItem4 = new System.Windows.Forms.PictureBox();
            this.lblItem4 = new System.Windows.Forms.Label();
            this.pbItem5 = new System.Windows.Forms.PictureBox();
            this.lblItem5 = new System.Windows.Forms.Label();
            this.cboPackage = new System.Windows.Forms.ComboBox();
            this.lblMenuTitle = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.lblSummaryTitle = new System.Windows.Forms.Label();
            this.lstOrder = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItem5)).BeginInit();
            this.pnlSummary.SuspendLayout();
            this.SuspendLayout();
            
            // pnlMenu
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.pnlMenu.Controls.Add(this.btnAdd);
            this.pnlMenu.Controls.Add(this.cboPackage);
            this.pnlMenu.Controls.Add(this.pbItem1);
            this.pnlMenu.Controls.Add(this.lblItem1);
            this.pnlMenu.Controls.Add(this.pbItem2);
            this.pnlMenu.Controls.Add(this.lblItem2);
            this.pnlMenu.Controls.Add(this.pbItem3);
            this.pnlMenu.Controls.Add(this.lblItem3);
            this.pnlMenu.Controls.Add(this.pbItem4);
            this.pnlMenu.Controls.Add(this.lblItem4);
            this.pnlMenu.Controls.Add(this.pbItem5);
            this.pnlMenu.Controls.Add(this.lblItem5);
            this.pnlMenu.Controls.Add(this.lblMenuTitle);
            this.pnlMenu.Location = new System.Drawing.Point(20, 20);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(400, 500);
            this.pnlMenu.TabIndex = 0;
            
            // lblMenuTitle
            this.lblMenuTitle.AutoSize = true;
            this.lblMenuTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMenuTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(181)))), ((int)(((byte)(2)))));
            this.lblMenuTitle.Location = new System.Drawing.Point(20, 10);
            this.lblMenuTitle.Name = "lblMenuTitle";
            this.lblMenuTitle.Size = new System.Drawing.Size(73, 30);
            this.lblMenuTitle.TabIndex = 0;
            this.lblMenuTitle.Text = "Menu";
            
            // pbItem1
            this.pbItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(38)))), ((int)(((byte)(15)))));
            this.pbItem1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbItem1.Location = new System.Drawing.Point(20, 50);
            this.pbItem1.Name = "pbItem1";
            this.pbItem1.Size = new System.Drawing.Size(110, 80);
            this.pbItem1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbItem1.TabIndex = 1;
            this.pbItem1.TabStop = false;
            this.pbItem1.Click += new System.EventHandler(this.MenuItem_Click);

            // lblItem1
            this.lblItem1.ForeColor = System.Drawing.Color.White;
            this.lblItem1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblItem1.Location = new System.Drawing.Point(20, 135);
            this.lblItem1.Size = new System.Drawing.Size(110, 30);
            this.lblItem1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblItem1.Text = "BBQ Wings";
            this.lblItem1.Click += new System.EventHandler(this.MenuItem_Click);

            // pbItem2
            this.pbItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(38)))), ((int)(((byte)(15)))));
            this.pbItem2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbItem2.Location = new System.Drawing.Point(145, 50);
            this.pbItem2.Name = "pbItem2";
            this.pbItem2.Size = new System.Drawing.Size(110, 80);
            this.pbItem2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbItem2.TabIndex = 2;
            this.pbItem2.TabStop = false;
            this.pbItem2.Click += new System.EventHandler(this.MenuItem_Click);

            // lblItem2
            this.lblItem2.ForeColor = System.Drawing.Color.White;
            this.lblItem2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblItem2.Location = new System.Drawing.Point(145, 135);
            this.lblItem2.Size = new System.Drawing.Size(110, 30);
            this.lblItem2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblItem2.Text = "Sausage";
            this.lblItem2.Click += new System.EventHandler(this.MenuItem_Click);

            // pbItem3
            this.pbItem3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(38)))), ((int)(((byte)(15)))));
            this.pbItem3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbItem3.Location = new System.Drawing.Point(270, 50);
            this.pbItem3.Name = "pbItem3";
            this.pbItem3.Size = new System.Drawing.Size(110, 80);
            this.pbItem3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbItem3.TabIndex = 3;
            this.pbItem3.TabStop = false;
            this.pbItem3.Click += new System.EventHandler(this.MenuItem_Click);

            // lblItem3
            this.lblItem3.ForeColor = System.Drawing.Color.White;
            this.lblItem3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblItem3.Location = new System.Drawing.Point(270, 135);
            this.lblItem3.Size = new System.Drawing.Size(110, 30);
            this.lblItem3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblItem3.Text = "Pad Krapao";
            this.lblItem3.Click += new System.EventHandler(this.MenuItem_Click);

            // pbItem4
            this.pbItem4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(38)))), ((int)(((byte)(15)))));
            this.pbItem4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbItem4.Location = new System.Drawing.Point(80, 180);
            this.pbItem4.Name = "pbItem4";
            this.pbItem4.Size = new System.Drawing.Size(110, 80);
            this.pbItem4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbItem4.TabIndex = 4;
            this.pbItem4.TabStop = false;
            this.pbItem4.Click += new System.EventHandler(this.MenuItem_Click);

            // lblItem4
            this.lblItem4.ForeColor = System.Drawing.Color.White;
            this.lblItem4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblItem4.Location = new System.Drawing.Point(80, 265);
            this.lblItem4.Size = new System.Drawing.Size(110, 30);
            this.lblItem4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblItem4.Text = "Pork Ribs";
            this.lblItem4.Click += new System.EventHandler(this.MenuItem_Click);

            // pbItem5
            this.pbItem5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(38)))), ((int)(((byte)(15)))));
            this.pbItem5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbItem5.Location = new System.Drawing.Point(210, 180);
            this.pbItem5.Name = "pbItem5";
            this.pbItem5.Size = new System.Drawing.Size(110, 80);
            this.pbItem5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbItem5.TabIndex = 5;
            this.pbItem5.TabStop = false;
            this.pbItem5.Click += new System.EventHandler(this.MenuItem_Click);

            // lblItem5
            this.lblItem5.ForeColor = System.Drawing.Color.White;
            this.lblItem5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblItem5.Location = new System.Drawing.Point(210, 265);
            this.lblItem5.Size = new System.Drawing.Size(110, 30);
            this.lblItem5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblItem5.Text = "BBQ Skewers";
            this.lblItem5.Click += new System.EventHandler(this.MenuItem_Click);
            
            // cboPackage
            this.cboPackage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboPackage.FormattingEnabled = true;
            this.cboPackage.Location = new System.Drawing.Point(20, 380);
            this.cboPackage.Name = "cboPackage";
            this.cboPackage.Size = new System.Drawing.Size(360, 29);
            this.cboPackage.TabIndex = 6;
            
            // btnAdd
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(8)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(20, 420);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(360, 50);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "ADD DB ITEM";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            
            // pnlSummary
            this.pnlSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.pnlSummary.Controls.Add(this.btnSave);
            this.pnlSummary.Controls.Add(this.lstOrder);
            this.pnlSummary.Controls.Add(this.lblSummaryTitle);
            this.pnlSummary.Location = new System.Drawing.Point(440, 20);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Size = new System.Drawing.Size(300, 500);
            this.pnlSummary.TabIndex = 1;
            
            // lblSummaryTitle
            this.lblSummaryTitle.AutoSize = true;
            this.lblSummaryTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSummaryTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(181)))), ((int)(((byte)(2)))));
            this.lblSummaryTitle.Location = new System.Drawing.Point(20, 10);
            this.lblSummaryTitle.Name = "lblSummaryTitle";
            this.lblSummaryTitle.Size = new System.Drawing.Size(176, 30);
            this.lblSummaryTitle.TabIndex = 0;
            this.lblSummaryTitle.Text = "Order Summary";
            
            // lstOrder
            this.lstOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(38)))), ((int)(((byte)(15)))));
            this.lstOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstOrder.ForeColor = System.Drawing.Color.White;
            this.lstOrder.FormattingEnabled = true;
            this.lstOrder.ItemHeight = 21;
            this.lstOrder.Location = new System.Drawing.Point(20, 50);
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(260, 319);
            this.lstOrder.TabIndex = 1;
            
            // btnSave
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(104)))), ((int)(((byte)(74)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(20, 400);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(260, 50);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "CHECKOUT (SAVE)";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            
            // KioskForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(38)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(760, 540);
            this.Controls.Add(this.pnlSummary);
            this.Controls.Add(this.pnlMenu);
            this.Name = "KioskForm";
            this.Text = "Fuego BBQ Kiosk";
            this.Load += new System.EventHandler(this.KioskForm_Load);
            
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItem5)).EndInit();
            this.pnlSummary.ResumeLayout(false);
            this.pnlSummary.PerformLayout();
            this.ResumeLayout(false);
        }
        // 
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblMenuTitle;
        private System.Windows.Forms.PictureBox pbItem1;
        private System.Windows.Forms.Label lblItem1;
        private System.Windows.Forms.PictureBox pbItem2;
        private System.Windows.Forms.Label lblItem2;
        private System.Windows.Forms.PictureBox pbItem3;
        private System.Windows.Forms.Label lblItem3;
        private System.Windows.Forms.PictureBox pbItem4;
        private System.Windows.Forms.Label lblItem4;
        private System.Windows.Forms.PictureBox pbItem5;
        private System.Windows.Forms.Label lblItem5;
        private System.Windows.Forms.ComboBox cboPackage;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Label lblSummaryTitle;
        private System.Windows.Forms.ListBox lstOrder;
        private System.Windows.Forms.Button btnSave;
    }
}
