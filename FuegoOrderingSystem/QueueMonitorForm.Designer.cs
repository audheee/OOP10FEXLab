namespace FuegoOrderingSystem
{
    partial class QueueMonitorForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlPreparing = new System.Windows.Forms.Panel();
            this.lblPreparingList = new System.Windows.Forms.Label();
            this.lblPreparing = new System.Windows.Forms.Label();
            this.pnlServing = new System.Windows.Forms.Panel();
            this.lblServingList = new System.Windows.Forms.Label();
            this.lblServing = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlPreparing.SuspendLayout();
            this.pnlServing.SuspendLayout();
            this.SuspendLayout();
            
            // tableLayoutPanel1
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pnlPreparing, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlServing, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 70);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 480);
            this.tableLayoutPanel1.TabIndex = 0;
            
            // pnlPreparing
            this.pnlPreparing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.pnlPreparing.Controls.Add(this.lblPreparingList);
            this.pnlPreparing.Controls.Add(this.lblPreparing);
            this.pnlPreparing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPreparing.Location = new System.Drawing.Point(3, 3);
            this.pnlPreparing.Name = "pnlPreparing";
            this.pnlPreparing.Size = new System.Drawing.Size(374, 474);
            this.pnlPreparing.TabIndex = 0;
            
            // lblPreparing
            this.lblPreparing.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPreparing.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPreparing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(181)))), ((int)(((byte)(2)))));
            this.lblPreparing.Location = new System.Drawing.Point(0, 0);
            this.lblPreparing.Name = "lblPreparing";
            this.lblPreparing.Size = new System.Drawing.Size(374, 60);
            this.lblPreparing.TabIndex = 0;
            this.lblPreparing.Text = "PREPARING";
            this.lblPreparing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // lblPreparingList
            this.lblPreparingList.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPreparingList.ForeColor = System.Drawing.Color.White;
            this.lblPreparingList.Location = new System.Drawing.Point(10, 80);
            this.lblPreparingList.Name = "lblPreparingList";
            this.lblPreparingList.Size = new System.Drawing.Size(350, 380);
            this.lblPreparingList.TabIndex = 1;
            this.lblPreparingList.Text = "";
            this.lblPreparingList.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            
            // pnlServing
            this.pnlServing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(8)))));
            this.pnlServing.Controls.Add(this.lblServingList);
            this.pnlServing.Controls.Add(this.lblServing);
            this.pnlServing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlServing.Location = new System.Drawing.Point(383, 3);
            this.pnlServing.Name = "pnlServing";
            this.pnlServing.Size = new System.Drawing.Size(374, 474);
            this.pnlServing.TabIndex = 1;
            
            // lblServing
            this.lblServing.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblServing.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblServing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(181)))), ((int)(((byte)(2)))));
            this.lblServing.Location = new System.Drawing.Point(0, 0);
            this.lblServing.Name = "lblServing";
            this.lblServing.Size = new System.Drawing.Size(374, 60);
            this.lblServing.TabIndex = 0;
            this.lblServing.Text = "NOW SERVING";
            this.lblServing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // lblServingList
            this.lblServingList.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblServingList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(181)))), ((int)(((byte)(2)))));
            this.lblServingList.Location = new System.Drawing.Point(10, 80);
            this.lblServingList.Name = "lblServingList";
            this.lblServingList.Size = new System.Drawing.Size(350, 380);
            this.lblServingList.TabIndex = 1;
            this.lblServingList.Text = "";
            this.lblServingList.TextAlign = System.Drawing.ContentAlignment.TopCenter;

            // lblHeader
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(181)))), ((int)(((byte)(2)))));
            this.lblHeader.Location = new System.Drawing.Point(20, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(760, 40);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "FUEGO BBQ - LIVE QUEUE MONITOR";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // QueueMonitorForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(38)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(800, 570);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "QueueMonitorForm";
            this.Text = "Fuego BBQ Queue Monitor";
            this.Load += new System.EventHandler(this.QueueMonitorForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlPreparing.ResumeLayout(false);
            this.pnlPreparing.PerformLayout();
            this.pnlServing.ResumeLayout(false);
            this.pnlServing.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlPreparing;
        private System.Windows.Forms.Label lblPreparing;
        private System.Windows.Forms.Label lblPreparingList;
        private System.Windows.Forms.Panel pnlServing;
        private System.Windows.Forms.Label lblServing;
        private System.Windows.Forms.Label lblServingList;
        private System.Windows.Forms.Label lblHeader;
    }
}
