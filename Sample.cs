namespace InventoryPosSystem
{
    public partial class Sample : Form
    {
        public Sample()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tasarým hatasý: " + ex.Message);
            }
        }
    }
}
