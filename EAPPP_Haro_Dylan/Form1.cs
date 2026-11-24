namespace frmPedidoCafeteria
{
    //Creado por Dylan Haro 
    public partial class Form1 : Form
    {
        public int v = 1;
        public Form1()
        {
            InitializeComponent();
        }


        private void lvCatalogo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCatalogo.SelectedItems.Count > 0)
            {
                ListViewItem item = lvCatalogo.SelectedItems[0];
                txtProducto.Text = item.Text;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ListViewItem item = listView1.SelectedItems[0];
            listView1.Items.Add(txtProducto.Text);
        }
    }
}
    
