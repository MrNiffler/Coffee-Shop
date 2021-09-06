
namespace CMPG223_Test1
{
    partial class waiterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(waiterForm));
            this.Order = new System.Windows.Forms.TabControl();
            this.addOrderTab = new System.Windows.Forms.TabPage();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.table = new System.Windows.Forms.Label();
            this.addStarter = new System.Windows.Forms.Label();
            this.addBeverage = new System.Windows.Forms.Label();
            this.addOrder = new System.Windows.Forms.Button();
            this.orderList = new System.Windows.Forms.DataGridView();
            this.removeItemTab = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.itemBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.timeTab = new System.Windows.Forms.TabPage();
            this.displayButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.waiterBox = new System.Windows.Forms.TextBox();
            this.timeSchedule = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Order.SuspendLayout();
            this.addOrderTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderList)).BeginInit();
            this.removeItemTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.timeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // Order
            // 
            this.Order.Controls.Add(this.addOrderTab);
            this.Order.Controls.Add(this.removeItemTab);
            this.Order.Controls.Add(this.timeTab);
            this.Order.Controls.Add(this.tabPage1);
            this.Order.Location = new System.Drawing.Point(12, 12);
            this.Order.Name = "Order";
            this.Order.Padding = new System.Drawing.Point(6, 14);
            this.Order.SelectedIndex = 0;
            this.Order.Size = new System.Drawing.Size(776, 426);
            this.Order.TabIndex = 0;
            // 
            // addOrderTab
            // 
            this.addOrderTab.BackColor = System.Drawing.Color.Black;
            this.addOrderTab.Controls.Add(this.comboBox3);
            this.addOrderTab.Controls.Add(this.comboBox2);
            this.addOrderTab.Controls.Add(this.comboBox1);
            this.addOrderTab.Controls.Add(this.table);
            this.addOrderTab.Controls.Add(this.addStarter);
            this.addOrderTab.Controls.Add(this.addBeverage);
            this.addOrderTab.Controls.Add(this.addOrder);
            this.addOrderTab.Controls.Add(this.orderList);
            this.addOrderTab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addOrderTab.Location = new System.Drawing.Point(4, 47);
            this.addOrderTab.Name = "addOrderTab";
            this.addOrderTab.Padding = new System.Windows.Forms.Padding(3);
            this.addOrderTab.Size = new System.Drawing.Size(768, 375);
            this.addOrderTab.TabIndex = 0;
            this.addOrderTab.Text = "Add Order";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "(None)",
            "Cupcake(Chocolate, Vanilla, Red Velvet)",
            "Muffin(Blueberry, Chocolate, Cappacino)",
            "Scone",
            "Sandwich(Breakfast)",
            "Sandwich(Cheese & Ham)",
            "Sandwich(Cheese & Tomato)",
            "Sandwich(Cheese, Hame & Tomato)",
            "Peppermint Crisp Tart",
            "Lemon Cheese Cake"});
            this.comboBox3.Location = new System.Drawing.Point(615, 77);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(132, 24);
            this.comboBox3.TabIndex = 15;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "(None)",
            "Expresso",
            "Double Expresso",
            "Cappacino",
            "Late",
            "American",
            "Mocha",
            "Flat White",
            "Short Black",
            "Long Black",
            "White Tea",
            "Green Tea",
            "Black Tea",
            "Oolong Tea",
            "Puer"});
            this.comboBox2.Location = new System.Drawing.Point(615, 47);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(132, 24);
            this.comboBox2.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "(None)",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox1.Location = new System.Drawing.Point(615, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 24);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // table
            // 
            this.table.AutoSize = true;
            this.table.Location = new System.Drawing.Point(505, 20);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(102, 17);
            this.table.TabIndex = 11;
            this.table.Text = "Table Number:";
            // 
            // addStarter
            // 
            this.addStarter.AutoSize = true;
            this.addStarter.Location = new System.Drawing.Point(505, 80);
            this.addStarter.Name = "addStarter";
            this.addStarter.Size = new System.Drawing.Size(59, 17);
            this.addStarter.TabIndex = 5;
            this.addStarter.Text = "Nibbles:";
            // 
            // addBeverage
            // 
            this.addBeverage.AutoSize = true;
            this.addBeverage.Location = new System.Drawing.Point(505, 50);
            this.addBeverage.Name = "addBeverage";
            this.addBeverage.Size = new System.Drawing.Size(73, 17);
            this.addBeverage.TabIndex = 4;
            this.addBeverage.Text = "Beverage:";
            // 
            // addOrder
            // 
            this.addOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addOrder.ForeColor = System.Drawing.SystemColors.Desktop;
            this.addOrder.Location = new System.Drawing.Point(582, 315);
            this.addOrder.Name = "addOrder";
            this.addOrder.Size = new System.Drawing.Size(180, 44);
            this.addOrder.TabIndex = 2;
            this.addOrder.Text = "Add Order";
            this.addOrder.UseVisualStyleBackColor = true;
            this.addOrder.Click += new System.EventHandler(this.addOrder_Click);
            // 
            // orderList
            // 
            this.orderList.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.orderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderList.Location = new System.Drawing.Point(6, 6);
            this.orderList.Name = "orderList";
            this.orderList.RowHeadersWidth = 51;
            this.orderList.RowTemplate.Height = 24;
            this.orderList.Size = new System.Drawing.Size(494, 363);
            this.orderList.TabIndex = 0;
            // 
            // removeItemTab
            // 
            this.removeItemTab.BackColor = System.Drawing.Color.Black;
            this.removeItemTab.Controls.Add(this.label3);
            this.removeItemTab.Controls.Add(this.trackBar1);
            this.removeItemTab.Controls.Add(this.label2);
            this.removeItemTab.Controls.Add(this.itemBox);
            this.removeItemTab.Controls.Add(this.label1);
            this.removeItemTab.Controls.Add(this.deleteBox);
            this.removeItemTab.Controls.Add(this.dataGridView1);
            this.removeItemTab.Controls.Add(this.deleteButton);
            this.removeItemTab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeItemTab.Location = new System.Drawing.Point(4, 47);
            this.removeItemTab.Name = "removeItemTab";
            this.removeItemTab.Padding = new System.Windows.Forms.Padding(3);
            this.removeItemTab.Size = new System.Drawing.Size(768, 375);
            this.removeItemTab.TabIndex = 1;
            this.removeItemTab.Text = "Remove Item";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(506, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Amount:";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(604, 76);
            this.trackBar1.Maximum = 30;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(153, 56);
            this.trackBar1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Item:";
            // 
            // itemBox
            // 
            this.itemBox.Location = new System.Drawing.Point(615, 45);
            this.itemBox.Name = "itemBox";
            this.itemBox.Size = new System.Drawing.Size(132, 22);
            this.itemBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(506, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Table:";
            // 
            // deleteBox
            // 
            this.deleteBox.Location = new System.Drawing.Point(615, 17);
            this.deleteBox.Name = "deleteBox";
            this.deleteBox.Size = new System.Drawing.Size(132, 22);
            this.deleteBox.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(494, 363);
            this.dataGridView1.TabIndex = 1;
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.deleteButton.Location = new System.Drawing.Point(582, 315);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(180, 44);
            this.deleteButton.TabIndex = 0;
            this.deleteButton.Text = "Remove";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // timeTab
            // 
            this.timeTab.BackColor = System.Drawing.Color.Black;
            this.timeTab.Controls.Add(this.displayButton);
            this.timeTab.Controls.Add(this.label4);
            this.timeTab.Controls.Add(this.waiterBox);
            this.timeTab.Controls.Add(this.timeSchedule);
            this.timeTab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.timeTab.Location = new System.Drawing.Point(4, 47);
            this.timeTab.Name = "timeTab";
            this.timeTab.Padding = new System.Windows.Forms.Padding(3);
            this.timeTab.Size = new System.Drawing.Size(768, 375);
            this.timeTab.TabIndex = 2;
            this.timeTab.Text = "Time Schedule";
            // 
            // displayButton
            // 
            this.displayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.displayButton.Location = new System.Drawing.Point(582, 315);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(180, 44);
            this.displayButton.TabIndex = 3;
            this.displayButton.Text = "Display";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(503, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Name of waiter:";
            // 
            // waiterBox
            // 
            this.waiterBox.Location = new System.Drawing.Point(615, 17);
            this.waiterBox.Name = "waiterBox";
            this.waiterBox.Size = new System.Drawing.Size(132, 22);
            this.waiterBox.TabIndex = 1;
            // 
            // timeSchedule
            // 
            this.timeSchedule.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.timeSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timeSchedule.Location = new System.Drawing.Point(6, 6);
            this.timeSchedule.Name = "timeSchedule";
            this.timeSchedule.RowHeadersWidth = 51;
            this.timeSchedule.RowTemplate.Height = 24;
            this.timeSchedule.Size = new System.Drawing.Size(494, 363);
            this.timeSchedule.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 47);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 375);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Payment";
            // 
            // waiterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Order);
            this.Name = "waiterForm";
            this.Text = "Waiter Form";
            this.Order.ResumeLayout(false);
            this.addOrderTab.ResumeLayout(false);
            this.addOrderTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderList)).EndInit();
            this.removeItemTab.ResumeLayout(false);
            this.removeItemTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.timeTab.ResumeLayout(false);
            this.timeTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeSchedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Order;
        private System.Windows.Forms.TabPage addOrderTab;
        private System.Windows.Forms.DataGridView orderList;
        private System.Windows.Forms.TabPage removeItemTab;
        private System.Windows.Forms.Button addOrder;
        private System.Windows.Forms.TextBox deleteBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TabPage timeTab;
        private System.Windows.Forms.Label table;
        private System.Windows.Forms.Label addStarter;
        private System.Windows.Forms.Label addBeverage;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox itemBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox waiterBox;
        private System.Windows.Forms.DataGridView timeSchedule;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabPage tabPage1;
    }
}