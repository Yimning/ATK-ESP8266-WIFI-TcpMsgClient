namespace TcpMsgClient
{
    partial class Form_QueryRecord
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_QueryRecord));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cb_searchitem = new System.Windows.Forms.ToolStripComboBox();
            this.txt_searchtxt = new System.Windows.Forms.ToolStripTextBox();
            this.btn_close = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Fresh = new System.Windows.Forms.ToolStripButton();
            this.btn_search = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(6, 37);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(839, 332);
            this.dataGridView1.TabIndex = 11;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cb_searchitem,
            this.txt_searchtxt,
            this.btn_close,
            this.toolStripButton_Fresh,
            this.btn_search});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(849, 39);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(56, 36);
            this.toolStripLabel1.Text = "查找项目";
            // 
            // cb_searchitem
            // 
            this.cb_searchitem.Name = "cb_searchitem";
            this.cb_searchitem.Size = new System.Drawing.Size(92, 39);
            // 
            // txt_searchtxt
            // 
            this.txt_searchtxt.AutoSize = false;
            this.txt_searchtxt.Name = "txt_searchtxt";
            this.txt_searchtxt.Size = new System.Drawing.Size(98, 23);
            // 
            // btn_close
            // 
            this.btn_close.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_close.AutoSize = false;
            this.btn_close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(73, 50);
            this.btn_close.Text = "关闭";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // toolStripButton_Fresh
            // 
            this.toolStripButton_Fresh.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton_Fresh.AutoSize = false;
            this.toolStripButton_Fresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_Fresh.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Fresh.Image")));
            this.toolStripButton_Fresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Fresh.Name = "toolStripButton_Fresh";
            this.toolStripButton_Fresh.Size = new System.Drawing.Size(73, 50);
            this.toolStripButton_Fresh.Text = "刷新";
            this.toolStripButton_Fresh.Click += new System.EventHandler(this.toolStripButton_Fresh_Click);
            // 
            // btn_search
            // 
            this.btn_search.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_search.AutoSize = false;
            this.btn_search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(73, 50);
            this.btn_search.Text = "查找";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // Form_QueryRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 373);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form_QueryRecord";
            this.Text = "Form_QueryRecord";
            this.Load += new System.EventHandler(this.Form_QueryRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cb_searchitem;
        private System.Windows.Forms.ToolStripTextBox txt_searchtxt;
        private System.Windows.Forms.ToolStripButton btn_close;
        private System.Windows.Forms.ToolStripButton toolStripButton_Fresh;
        private System.Windows.Forms.ToolStripButton btn_search;
    }
}