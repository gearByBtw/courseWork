namespace Pawnshop.Forms
{
    partial class SearchForm
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
            this.components = new System.ComponentModel.Container();
            this.search_button = new System.Windows.Forms.Button();
            this.search_input = new System.Windows.Forms.TextBox();
            this.search_output = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Cancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mainFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lotBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // search_button
            // 
            this.search_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.search_button.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.search_button.Location = new System.Drawing.Point(311, 95);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(123, 44);
            this.search_button.TabIndex = 2;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // search_input
            // 
            this.search_input.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.search_input.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.search_input.Location = new System.Drawing.Point(135, 48);
            this.search_input.Name = "search_input";
            this.search_input.Size = new System.Drawing.Size(483, 41);
            this.search_input.TabIndex = 1;
            // 
            // search_output
            // 
            this.search_output.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.search_output.ContextMenuStrip = this.contextMenuStrip1;
            this.search_output.DataSource = this.lotBindingSource;
            this.search_output.FormattingEnabled = true;
            this.search_output.ItemHeight = 20;
            this.search_output.Location = new System.Drawing.Point(91, 155);
            this.search_output.Name = "search_output";
            this.search_output.Size = new System.Drawing.Size(583, 344);
            this.search_output.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.sellToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 76);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // sellToolStripMenuItem
            // 
            this.sellToolStripMenuItem.Name = "sellToolStripMenuItem";
            this.sellToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.sellToolStripMenuItem.Text = "Sell";
            this.sellToolStripMenuItem.Click += new System.EventHandler(this.sellToolStripMenuItem_Click);
            // 
            // lotBindingSource
            // 
            this.lotBindingSource.DataSource = typeof(Pawnshop.Models.Lot);
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cancel.Location = new System.Drawing.Point(684, 514);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(86, 33);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.search_output);
            this.groupBox1.Controls.Add(this.Cancel);
            this.groupBox1.Controls.Add(this.search_input);
            this.groupBox1.Controls.Add(this.search_button);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.MinimumSize = new System.Drawing.Size(782, 553);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 553);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // mainFormBindingSource
            // 
            this.mainFormBindingSource.DataSource = typeof(Pawnshop.MainForm);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchForm_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lotBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button search_button;
        private TextBox search_input;
        private ListBox search_output;
        private Button Cancel;
        private GroupBox groupBox1;
        private BindingSource lotBindingSource;
        private BindingSource mainFormBindingSource;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem sellToolStripMenuItem;
    }
}