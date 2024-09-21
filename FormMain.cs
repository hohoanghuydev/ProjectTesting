using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibraries;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TestingApp
{
    public partial class FormMain : Form
    {
        DatabaseConnection database = new DatabaseConnection();
        public FormMain()
        {
            InitializeComponent();
            database.getConnection(Properties.Settings.Default.connectionString);

            this.Load += FormMain_Load;
            btnOrder.Click += BtnOrder_Click;
            lvOrderList.MouseDoubleClick += LvOrderList_MouseDoubleClick;
            btnUpdate.Click += BtnUpdate_Click;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int quantity = (int)nudUpdate.Value;

            ListViewItem itemSelected = lvOrderList.SelectedItems[0];
            int productId = int.Parse(itemSelected.Tag.ToString());

            Orders order = new Orders();
            order.ProductId = productId;
            order.Quantity = quantity;
            order.Email = Properties.Settings.Default.emailLogin;

            bool checkOrder = false;

            if (quantity == 0)
            {
                checkOrder = database.deleteOrder(order);
            }
            else
            {
                checkOrder = database.updateOrder(order);
            }

            if (checkOrder)
            {
                MessageBox.Show("Cập nhật thành công");
                lvOrderList.Items.Clear();
                loadOrders();
                gbUpdateQuantity.Enabled = false;
                return;
            }

            MessageBox.Show("Cập nhật thất bại");
        }

        private void LvOrderList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvOrderList.SelectedItems.Count > 0)
            {
                gbUpdateQuantity.Enabled = true;

                ListViewItem itemSelected = lvOrderList.SelectedItems[0];
                int quantity = int.Parse(itemSelected.SubItems[1].Text.ToString());

                nudUpdate.Value = quantity;
            }
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            if (cbProducts.SelectedItem == null) { return; }
            int productId = (cbProducts.SelectedItem as Products).Id;
            int quantity = int.Parse(nudQuantity.Value.ToString());
            string email = Properties.Settings.Default.emailLogin;

            bool checkOrder = database.orderProduct(email, productId, quantity);

            if (checkOrder)
            {
                MessageBox.Show("Order thành công");
                lvOrderList.Items.Clear();
                loadOrders();
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            lvOrderList.Columns.Add("Tên món", 200, HorizontalAlignment.Left);
            lvOrderList.Columns.Add("Số lượng", 100, HorizontalAlignment.Left);
            lvOrderList.Columns.Add("Thành tiền", 100, HorizontalAlignment.Left);

            txtUserLogin.Text = "Hello " + Properties.Settings.Default.emailLogin;

            loadProducts();
            loadOrders();
        }

        private void loadProducts()
        {
            List<Products> products = database.getProducts();

            if (products == null || products.Count == 0) { return; }

            cbProducts.DataSource = products;
            cbProducts.DisplayMember = "Name";
            cbProducts.ValueMember = "Id";
        }

        private void loadOrders()
        {
            List<Orders> orders = database.getOrders(Properties.Settings.Default.emailLogin);

            foreach (Orders order in orders)
            {
                Products product = database.getOneProduct(order.ProductId);

                if (product == null) { continue; }

                ListViewItem item = new ListViewItem(product.Name);
                item.SubItems.Add(order.Quantity.ToString());
                item.SubItems.Add(order.TotalAmount.ToString());
                item.Tag = product.Id;

                lvOrderList.Items.Add(item);
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Load lại form login
            Properties.Settings.Default.emailLogin = "";
        }
    }
}
