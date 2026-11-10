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
            this.lblMenuTitle = new System.Windows.Forms.Label();
            this.btnItem1 = new System.Windows.Forms.Button();
            this.btnItem2 = new System.Windows.Forms.Button();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.lblSummaryTitle = new System.Windows.Forms.Label();
            this.lstOrder = new System.Windows.Forms.ListBox();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.pnlSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(8)))), ((int)(((byte)(0))))); // #7e0800
            this.pnlMenu.Controls.Add(this.btnItem2);
            this.pnlMenu.Controls.Add(this.btnItem1);
            this.pnlMenu.Controls.Add(this.lblMenuTitle);
            this.pnlMenu.Location = new System.Drawing.Point(20, 20);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(400, 500);
            this.pnlMenu.TabIndex = 0;
            // 
            // lblMenuTitle
            // 
            this.lblMenuTitle.AutoSize = true;
            this.lblMenuTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMenuTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(181)))), ((int)(((byte)(2))))); // #e5b502
            this.lblMenuTitle.Location = new System.Drawing.Point(20, 20);
            this.lblMenuTitle.Name = "lblMenuTitle";
            this.lblMenuTitle.Size = new System.Drawing.Size(73, 30);
            this.lblMenuTitle.TabIndex = 0;
            this.lblMenuTitle.Text = "Menu";
            // 
            // btnItem1
            // 
            this.btnItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(38)))), ((int)(((byte)(15))))); // #5e260f
            this.btnItem1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItem1.ForeColor = System.Drawing.Color.White;
            this.btnItem1.Location = new System.Drawing.Point(20, 70);
            this.btnItem1.Name = "btnItem1";
            this.btnItem1.Size = new System.Drawing.Size(150, 100);
            this.btnItem1.TabIndex = 1;
            this.btnItem1.Text = "Single Pork Ribs\n₱240.00";
            this.btnItem1.UseVisualStyleBackColor = false;
            // 
            // btnItem2
            // 
            this.btnItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(38)))), ((int)(((byte)(15)))));
            this.btnItem2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItem2.ForeColor = System.Drawing.Color.White;
            this.btnItem2.Location = new System.Drawing.Point(190, 70);
            this.btnItem2.Name = "btnItem2";
            this.btnItem2.Size = new System.Drawing.Size(150, 100);
            this.btnItem2.TabIndex = 2;
            this.btnItem2.Text = "Pulled Pork\n₱280.00";
            this.btnItem2.UseVisualStyleBackColor = false;
            // 
            // pnlSummary
            // 
            this.pnlSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.pnlSummary.Controls.Add(this.btnCheckout);
            this.pnlSummary.Controls.Add(this.lstOrder);
            this.pnlSummary.Controls.Add(this.lblSummaryTitle);
            this.pnlSummary.Location = new System.Drawing.Point(440, 20);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Size = new System.Drawing.Size(300, 500);
            this.pnlSummary.TabIndex = 1;
            // 
            // lblSummaryTitle
            // 
            this.lblSummaryTitle.AutoSize = true;
            this.lblSummaryTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSummaryTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(181)))), ((int)(((byte)(2)))));
            this.lblSummaryTitle.Location = new System.Drawing.Point(20, 20);
            this.lblSummaryTitle.Name = "lblSummaryTitle";
            this.lblSummaryTitle.Size = new System.Drawing.Size(176, 30);
            this.lblSummaryTitle.TabIndex = 0;
            this.lblSummaryTitle.Text = "Order Summary";
            // 
            // lstOrder
            // 
            this.lstOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(38)))), ((int)(((byte)(15)))));
            this.lstOrder.ForeColor = System.Drawing.Color.White;
            this.lstOrder.FormattingEnabled = true;
            this.lstOrder.ItemHeight = 15;
            this.lstOrder.Location = new System.Drawing.Point(20, 70);
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(260, 334);
            this.lstOrder.TabIndex = 1;
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(104)))), ((int)(((byte)(74))))); // #e1684a
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Location = new System.Drawing.Point(20, 420);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(260, 50);
            this.btnCheckout.TabIndex = 2;
            this.btnCheckout.Text = "CHECKOUT";
            this.btnCheckout.UseVisualStyleBackColor = false;
            // 
            // KioskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(38)))), ((int)(((byte)(15))))); // #5e260f
            this.ClientSize = new System.Drawing.Size(760, 540);
            this.Controls.Add(this.pnlSummary);
            this.Controls.Add(this.pnlMenu);
            this.Name = "KioskForm";
            this.Text = "Fuego BBQ Kiosk";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlSummary.ResumeLayout(false);
            this.pnlSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblMenuTitle;
        private System.Windows.Forms.Button btnItem1;
        private System.Windows.Forms.Button btnItem2;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Label lblSummaryTitle;
        private System.Windows.Forms.ListBox lstOrder;
        private System.Windows.Forms.Button btnCheckout;
    }
}
