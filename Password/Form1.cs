namespace Password
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            int passSize = (int)nupSize.Value;            
            txtPass.Text = PassGen.GeneratePass(passSize);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(txtPass.Text);
        }
    }
}