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
            this.item_box = new System.Windows.Forms.TextBox();
            this.price_box = new System.Windows.Forms.TextBox();
            this.client_box = new System.Windows.Forms.TextBox();
            this.given_price_box = new System.Windows.Forms.TextBox();
            this.period_box = new System.Windows.Forms.TextBox();
            this.submit_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // item_box
            // 
            this.item_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.item_box.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.item_box.Location = new System.Drawing.Point(96, 39);
            this.item_box.Name = "item_box";
            this.item_box.PlaceholderText = "item";
            this.item_box.Size = new System.Drawing.Size(600, 41);
            this.item_box.TabIndex = 1;
            // 
            // price_box
            // 
            this.price_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.price_box.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.price_box.Location = new System.Drawing.Point(96, 213);
            this.price_box.Name = "price_box";
            this.price_box.PlaceholderText = "9,99";
            this.price_box.Size = new System.Drawing.Size(600, 41);
            this.price_box.TabIndex = 3;
            // 
            // client_box
            // 
            this.client_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.client_box.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.client_box.Location = new System.Drawing.Point(96, 123);
            this.client_box.Name = "client_box";
            this.client_box.PlaceholderText = "name";
            this.client_box.Size = new System.Drawing.Size(600, 41);
            this.client_box.TabIndex = 2;
            // 
            // given_price_box
            // 
            this.given_price_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.given_price_box.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.given_price_box.Location = new System.Drawing.Point(96, 303);
            this.given_price_box.Name = "given_price_box";
            this.given_price_box.PlaceholderText = "9,99";
            this.given_price_box.Size = new System.Drawing.Size(600, 41);
            this.given_price_box.TabIndex = 4;
            // 
            // period_box
            // 
            this.period_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.period_box.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.period_box.Location = new System.Drawing.Point(96, 398);
            this.period_box.Name = "period_box";
            this.period_box.PlaceholderText = "3";
            this.period_box.Size = new System.Drawing.Size(600, 41);
            this.period_box.TabIndex = 5;
            // 
            // submit_button
            // 
            this.submit_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.submit_button.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.submit_button.Location = new System.Drawing.Point(200, 464);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(150, 55);
            this.submit_button.TabIndex = 6;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.given_price_box);
            this.groupBox1.Controls.Add(this.submit_button);
            this.groupBox1.Controls.Add(this.item_box);
            this.groupBox1.Controls.Add(this.period_box);
            this.groupBox1.Controls.Add(this.client_box);
            this.groupBox1.Controls.Add(this.price_box);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 553);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(96, 375);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Expiration period (days)";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(96, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Given price";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(96, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Price";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(96, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Client";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Item";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(441, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 55);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cancel";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddForm_FormClosing_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox item_box;
        private TextBox price_box;
        private TextBox client_box;
        private TextBox given_price_box;
        private TextBox period_box;
        private Button submit_button;
        private GroupBox groupBox1;
        private Button button1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
    }
}