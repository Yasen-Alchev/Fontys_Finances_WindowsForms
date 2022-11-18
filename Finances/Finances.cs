namespace Finances
{
    public partial class Finances : Form
    {
        private List<Expences> transactionLog = new List<Expences>();
        public Finances()
        {
            InitializeComponent();
        }
        private void addProduct(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(lb_name.Text) || nud_amount.Value < 0)
            {
                MessageBox.Show("Please enter a valid expence!");
                return;
            }
            Expences expence = new Expences(tb_product.Text, (double)nud_amount.Value);
            transactionLog.Add(expence);
        }

        private void showAllExpences(object sender, EventArgs e)
        {
            listBox_products.Items.Clear();
            for (int i = 0; i < transactionLog.Count; ++i) 
            {
                listBox_products.Items.Add(transactionLog[i].GetInfo());
            }
        }
        private void showExpencesSameAmount(object sender, EventArgs e)
        {
            listBox_products.Items.Clear();
            for (int i = 0; i < transactionLog.Count; ++i)
            {
                if (transactionLog[i].getAmount() == (double)nud_sameAmount.Value)
                {
                    listBox_products.Items.Add(transactionLog[i].GetInfo());
                }
            }
        }
    }
}