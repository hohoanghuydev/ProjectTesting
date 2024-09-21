namespace TestingApp
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbProducts = new System.Windows.Forms.ComboBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lvOrderList = new System.Windows.Forms.ListView();
            this.txtUserLogin = new System.Windows.Forms.Label();
            this.gbUpdateQuantity = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.nudUpdate = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.gbUpdateQuantity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // cbProducts
            // 
            this.cbProducts.FormattingEnabled = true;
            this.cbProducts.Location = new System.Drawing.Point(29, 25);
            this.cbProducts.Name = "cbProducts";
            this.cbProducts.Size = new System.Drawing.Size(256, 28);
            this.cbProducts.TabIndex = 0;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(292, 26);
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.ReadOnly = true;
            this.nudQuantity.Size = new System.Drawing.Size(72, 26);
            this.nudQuantity.TabIndex = 1;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(29, 68);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(107, 59);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // lvOrderList
            // 
            this.lvOrderList.FullRowSelect = true;
            this.lvOrderList.GridLines = true;
            this.lvOrderList.HideSelection = false;
            this.lvOrderList.Location = new System.Drawing.Point(29, 145);
            this.lvOrderList.Name = "lvOrderList";
            this.lvOrderList.Size = new System.Drawing.Size(741, 220);
            this.lvOrderList.TabIndex = 3;
            this.lvOrderList.UseCompatibleStateImageBehavior = false;
            this.lvOrderList.View = System.Windows.Forms.View.Details;
            // 
            // txtUserLogin
            // 
            this.txtUserLogin.AutoSize = true;
            this.txtUserLogin.Location = new System.Drawing.Point(25, 380);
            this.txtUserLogin.Name = "txtUserLogin";
            this.txtUserLogin.Size = new System.Drawing.Size(80, 20);
            this.txtUserLogin.TabIndex = 4;
            this.txtUserLogin.Text = "Hello user";
            // 
            // gbUpdateQuantity
            // 
            this.gbUpdateQuantity.Controls.Add(this.btnUpdate);
            this.gbUpdateQuantity.Controls.Add(this.nudUpdate);
            this.gbUpdateQuantity.Enabled = false;
            this.gbUpdateQuantity.Location = new System.Drawing.Point(599, 26);
            this.gbUpdateQuantity.Name = "gbUpdateQuantity";
            this.gbUpdateQuantity.Size = new System.Drawing.Size(171, 102);
            this.gbUpdateQuantity.TabIndex = 5;
            this.gbUpdateQuantity.TabStop = false;
            this.gbUpdateQuantity.Text = "Cập nhật số lượng";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(6, 57);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 39);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // nudUpdate
            // 
            this.nudUpdate.Location = new System.Drawing.Point(6, 25);
            this.nudUpdate.Name = "nudUpdate";
            this.nudUpdate.ReadOnly = true;
            this.nudUpdate.Size = new System.Drawing.Size(121, 26);
            this.nudUpdate.TabIndex = 0;
            this.nudUpdate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbUpdateQuantity);
            this.Controls.Add(this.txtUserLogin);
            this.Controls.Add(this.lvOrderList);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.cbProducts);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.gbUpdateQuantity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbProducts;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.ListView lvOrderList;
        private System.Windows.Forms.Label txtUserLogin;
        private System.Windows.Forms.GroupBox gbUpdateQuantity;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.NumericUpDown nudUpdate;
    }
}

