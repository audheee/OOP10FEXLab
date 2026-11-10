using System;
using System.Drawing;
using System.Windows.Forms;

namespace FuegoOrderingSystem
{
    public partial class QueueMonitorForm : Form
    {
        public QueueMonitorForm()
        {
            InitializeComponent();
        }

        private void QueueMonitorForm_Load(object sender, EventArgs e)
        {
            RefreshQueueDisplay();
        }

        private void RefreshQueueDisplay()
        {
            lblPreparingList.Text = string.Join("   ", QueueData.PreparingQueue);
            lblServingList.Text = string.Join("   ", QueueData.ServingQueue);
        }
    }
}
