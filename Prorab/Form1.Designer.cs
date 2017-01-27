namespace Prorab {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.timerStep = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonStart = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelOrdersDeclined = new System.Windows.Forms.Label();
            this.labelCurrentOrders = new System.Windows.Forms.Label();
            this.labelCurrentBalance = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOrdersLimit = new System.Windows.Forms.TextBox();
            this.textBoxInitialBalance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxProrabName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ordername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerStep
            // 
            this.timerStep.Interval = 1000;
            this.timerStep.Tick += new System.EventHandler(this.timerStep_Tick);
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBox1.Location = new System.Drawing.Point(635, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(638, 670);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 570);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 100);
            this.panel1.TabIndex = 1;
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonStart.Location = new System.Drawing.Point(307, 35);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(632, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 570);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelOrdersDeclined);
            this.groupBox1.Controls.Add(this.labelCurrentOrders);
            this.groupBox1.Controls.Add(this.labelCurrentBalance);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxOrdersLimit);
            this.groupBox1.Controls.Add(this.textBoxInitialBalance);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxProrabName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prorab";
            // 
            // labelOrdersDeclined
            // 
            this.labelOrdersDeclined.AutoSize = true;
            this.labelOrdersDeclined.Location = new System.Drawing.Point(232, 58);
            this.labelOrdersDeclined.Name = "labelOrdersDeclined";
            this.labelOrdersDeclined.Size = new System.Drawing.Size(83, 13);
            this.labelOrdersDeclined.TabIndex = 8;
            this.labelOrdersDeclined.Text = "Orders Declined";
            // 
            // labelCurrentOrders
            // 
            this.labelCurrentOrders.AutoSize = true;
            this.labelCurrentOrders.Location = new System.Drawing.Point(232, 41);
            this.labelCurrentOrders.Name = "labelCurrentOrders";
            this.labelCurrentOrders.Size = new System.Drawing.Size(72, 13);
            this.labelCurrentOrders.TabIndex = 7;
            this.labelCurrentOrders.Text = "CurrentOrders";
            // 
            // labelCurrentBalance
            // 
            this.labelCurrentBalance.AutoSize = true;
            this.labelCurrentBalance.Location = new System.Drawing.Point(232, 22);
            this.labelCurrentBalance.Name = "labelCurrentBalance";
            this.labelCurrentBalance.Size = new System.Drawing.Size(80, 13);
            this.labelCurrentBalance.TabIndex = 6;
            this.labelCurrentBalance.Text = "CurrentBalance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Orders limit";
            // 
            // textBoxOrdersLimit
            // 
            this.textBoxOrdersLimit.Location = new System.Drawing.Point(96, 55);
            this.textBoxOrdersLimit.Name = "textBoxOrdersLimit";
            this.textBoxOrdersLimit.Size = new System.Drawing.Size(100, 20);
            this.textBoxOrdersLimit.TabIndex = 4;
            this.textBoxOrdersLimit.Text = "5";
            // 
            // textBoxInitialBalance
            // 
            this.textBoxInitialBalance.Location = new System.Drawing.Point(96, 36);
            this.textBoxInitialBalance.Name = "textBoxInitialBalance";
            this.textBoxInitialBalance.Size = new System.Drawing.Size(100, 20);
            this.textBoxInitialBalance.TabIndex = 3;
            this.textBoxInitialBalance.Text = "500";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Initial balance, $";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // textBoxProrabName
            // 
            this.textBoxProrabName.Location = new System.Drawing.Point(96, 19);
            this.textBoxProrabName.Name = "textBoxProrabName";
            this.textBoxProrabName.Size = new System.Drawing.Size(100, 20);
            this.textBoxProrabName.TabIndex = 0;
            this.textBoxProrabName.Tag = "";
            this.textBoxProrabName.Text = "Mihalych";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 470);
            this.panel2.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ordername,
            this.OrderState,
            this.TaskName,
            this.TaskType,
            this.TaskCost,
            this.TaskCapacity});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(632, 470);
            this.dataGridView1.TabIndex = 0;
            // 
            // Ordername
            // 
            this.Ordername.HeaderText = "Order Name";
            this.Ordername.Name = "Ordername";
            this.Ordername.ReadOnly = true;
            // 
            // OrderState
            // 
            this.OrderState.HeaderText = "Order State";
            this.OrderState.Name = "OrderState";
            this.OrderState.ReadOnly = true;
            // 
            // TaskName
            // 
            this.TaskName.HeaderText = "Task Name";
            this.TaskName.Name = "TaskName";
            this.TaskName.ReadOnly = true;
            // 
            // TaskType
            // 
            this.TaskType.HeaderText = "Task Type";
            this.TaskType.Name = "TaskType";
            this.TaskType.ReadOnly = true;
            // 
            // TaskCost
            // 
            this.TaskCost.HeaderText = "Task Cost";
            this.TaskCost.Name = "TaskCost";
            this.TaskCost.ReadOnly = true;
            // 
            // TaskCapacity
            // 
            this.TaskCapacity.HeaderText = "Task Capacity";
            this.TaskCapacity.Name = "TaskCapacity";
            this.TaskCapacity.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 670);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Prorab v.1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerStep;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxProrabName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxOrdersLimit;
        private System.Windows.Forms.TextBox textBoxInitialBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCurrentOrders;
        private System.Windows.Forms.Label labelCurrentBalance;
        private System.Windows.Forms.Label labelOrdersDeclined;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ordername;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderState;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskType;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskCapacity;


    }
}

