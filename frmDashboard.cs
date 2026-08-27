namespace Kasir_ExampleApp
{
    public partial class frmDashboard : Form
    {
        private UserControl? activeControl = null;

        public frmDashboard()
        {
            InitializeComponent();
            OpenChildControl(new Views.ucDashboardContent());
        }

        private void OpenChildControl(UserControl childControl)
        {
            if(activeControl != null)
            {
                panelContent.Controls.Remove(activeControl);
                activeControl.Dispose();
            }

            activeControl = childControl;
            childControl.Dock = DockStyle.Fill;

            panelContent.Controls.Add(childControl);
            childControl.BringToFront();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenChildControl(new Views.ucDashboardContent());
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            OpenChildControl(new Views.ucTransactionContent());
        }
    }
}
