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
            this.lblPreparing = new System.Windows.Forms.Label();
            this.pnlServing = new System.Windows.Forms.Panel();
            this.lblServing = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlPreparing.SuspendLayout();
            this.pnlServing.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pnlPreparing, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlServing, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlPreparing
            // 
            this.pnlPreparing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(8)))), ((int)(((byte)(0))))); // #7e0800
            this.pnlPreparing.Controls.Add(this.lblPreparing);
            this.pnlPreparing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPreparing.Location = new System.Drawing.Point(3, 3);
            this.pnlPreparing.Name = "pnlPreparing";
            this.pnlPreparing.Size = new System.Drawing.Size(394, 444);
            this.pnlPreparing.TabIndex = 0;
            // 
            // lblPreparing
            // 
            this.lblPreparing.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPreparing.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPreparing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(104)))), ((int)(((byte)(74))))); // #e1684a
            this.lblPreparing.Location = new System.Drawing.Point(0, 0);
            this.lblPreparing.Name = "lblPreparing";
            this.lblPreparing.Size = new System.Drawing.Size(394, 60);
            this.lblPreparing.TabIndex = 0;
            this.lblPreparing.Text = "PREPARING";
            this.lblPreparing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlServing
            // 
            this.pnlServing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(100)))), ((int)(((byte)(8))))); // #676408
            this.pnlServing.Controls.Add(this.lblServing);
            this.pnlServing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlServing.Location = new System.Drawing.Point(403, 3);
            this.pnlServing.Name = "pnlServing";
            this.pnlServing.Size = new System.Drawing.Size(394, 444);
            this.pnlServing.TabIndex = 1;
            // 
            // lblServing
            // 
            this.lblServing.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblServing.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblServing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(181)))), ((int)(((byte)(2))))); // #e5b502
            this.lblServing.Location = new System.Drawing.Point(0, 0);
            this.lblServing.Name = "lblServing";
            this.lblServing.Size = new System.Drawing.Size(394, 60);
            this.lblServing.TabIndex = 0;
            this.lblServing.Text = "NOW SERVING";
            this.lblServing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QueueMonitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(38)))), ((int)(((byte)(15))))); // #5e260f
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "QueueMonitorForm";
            this.Text = "Fuego BBQ Queue Monitor";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlPreparing.ResumeLayout(false);
            this.pnlServing.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlPreparing;
        private System.Windows.Forms.Label lblPreparing;
        private System.Windows.Forms.Panel pnlServing;
        private System.Windows.Forms.Label lblServing;
    }
}
