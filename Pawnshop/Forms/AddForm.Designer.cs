namespace Pawnshop.Forms
{
    partial class AddForm
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
            this.Cancel = new System.Windows.Forms.Button();
            this.item_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.price_box = new System.Windows.Forms.TextBox();
            this.client_box = new System.Windows.Forms.TextBox();
            this.given_price_box = new System.Windows.Forms.TextBox();
            this.period_box = new System.Windows.Forms.TextBox();
            this.submit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel.BackColor = System.Drawing.SystemColors.Control;
            this.Cancel.Location = new System.Drawing.Point(701, 512);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(69, 29);
            this.Cancel.TabIndex = 0;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // item_box
            // 
            this.item_box.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.item_box.Location = new System.Drawing.Point(335, 28);
            this.item_box.Name = "item_box";
            this.item_box.PlaceholderText = "item";
            this.item_box.Size = new System.Drawing.Size(341, 41);
            this.item_box.TabIndex = 1;
            this.item_box.TextChanged += new System.EventHandler(this.item_box_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.MaximumSize = new System.Drawing.Size(300, 100);
            this.label1.MinimumSize = new System.Drawing.Size(100, 50);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(300, 90);
            this.label1.TabIndex = 2;
            this.label1.Text = "Item:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.MaximumSize = new System.Drawing.Size(300, 100);
            this.label2.MinimumSize = new System.Drawing.Size(100, 50);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(300, 90);
            this.label2.TabIndex = 3;
            this.label2.Text = "Client:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 174);
            this.label3.MaximumSize = new System.Drawing.Size(300, 100);
            this.label3.MinimumSize = new System.Drawing.Size(100, 50);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(300, 90);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 264);
            this.label4.MaximumSize = new System.Drawing.Size(300, 100);
            this.label4.MinimumSize = new System.Drawing.Size(100, 50);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5);
            this.label4.Size = new System.Drawing.Size(300, 90);
            this.label4.TabIndex = 5;
            this.label4.Text = "Given price:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 354);
            this.label5.MaximumSize = new System.Drawing.Size(300, 120);
            this.label5.MinimumSize = new System.Drawing.Size(100, 100);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5);
            this.label5.Size = new System.Drawing.Size(300, 100);
            this.label5.TabIndex = 6;
            this.label5.Text = "Expiration period\r\n(days):";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // price_box
            // 
            this.price_box.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.price_box.Location = new System.Drawing.Point(335, 202);
            this.price_box.Name = "price_box";
            this.price_box.PlaceholderText = "9.99";
            this.price_box.Size = new System.Drawing.Size(341, 41);
            this.price_box.TabIndex = 7;
            // 
            // client_box
            // 
            this.client_box.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.client_box.Location = new System.Drawing.Point(335, 112);
            this.client_box.Name = "client_box";
            this.client_box.PlaceholderText = "Robert Brown";
            this.client_box.Size = new System.Drawing.Size(341, 41);
            this.client_box.TabIndex = 8;
            // 
            // given_price_box
            // 
            this.given_price_box.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.given_price_box.Location = new System.Drawing.Point(335, 292);
            this.given_price_box.Name = "given_price_box";
            this.given_price_box.PlaceholderText = "9.99";
            this.given_price_box.Size = new System.Drawing.Size(341, 41);
            this.given_price_box.TabIndex = 9;
            // 
            // period_box
            // 
            this.period_box.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.period_box.Location = new System.Drawing.Point(335, 387);
            this.period_box.Name = "period_box";
            this.period_box.PlaceholderText = "3";
            this.period_box.Size = new System.Drawing.Size(341, 41);
            this.period_box.TabIndex = 10;
            // 
            // submit_button
            // 
            this.submit_button.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.submit_button.Location = new System.Drawing.Point(411, 465);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(175, 60);
            this.submit_button.TabIndex = 11;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.period_box);
            this.Controls.Add(this.given_price_box);
            this.Controls.Add(this.client_box);
            this.Controls.Add(this.price_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.item_box);
            this.Controls.Add(this.Cancel);
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddForm_FormClosing_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Cancel;
        private TextBox item_box;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox price_box;
        private TextBox client_box;
        private TextBox given_price_box;
        private TextBox period_box;
        private Button submit_button;
    }
}