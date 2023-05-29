namespace Pawnshop.Forms
{
    partial class EditForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.client_box = new System.Windows.Forms.TextBox();
            this.item_box = new System.Windows.Forms.TextBox();
            this.price_box = new System.Windows.Forms.TextBox();
            this.given_price_box = new System.Windows.Forms.TextBox();
            this.recieving_box = new System.Windows.Forms.TextBox();
            this.period_box = new System.Windows.Forms.TextBox();
            this.id_box = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(444, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cancel";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(207, 501);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 40);
            this.button2.TabIndex = 7;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // client_box
            // 
            this.client_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.client_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.client_box.Location = new System.Drawing.Point(82, 164);
            this.client_box.Name = "client_box";
            this.client_box.Size = new System.Drawing.Size(600, 34);
            this.client_box.TabIndex = 2;
            // 
            // item_box
            // 
            this.item_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.item_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.item_box.Location = new System.Drawing.Point(82, 95);
            this.item_box.Name = "item_box";
            this.item_box.Size = new System.Drawing.Size(600, 34);
            this.item_box.TabIndex = 1;
            // 
            // price_box
            // 
            this.price_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.price_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.price_box.Location = new System.Drawing.Point(82, 236);
            this.price_box.Name = "price_box";
            this.price_box.Size = new System.Drawing.Size(600, 34);
            this.price_box.TabIndex = 3;
            // 
            // given_price_box
            // 
            this.given_price_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.given_price_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.given_price_box.Location = new System.Drawing.Point(82, 379);
            this.given_price_box.Name = "given_price_box";
            this.given_price_box.Size = new System.Drawing.Size(600, 34);
            this.given_price_box.TabIndex = 5;
            // 
            // recieving_box
            // 
            this.recieving_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.recieving_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.recieving_box.Location = new System.Drawing.Point(82, 306);
            this.recieving_box.Name = "recieving_box";
            this.recieving_box.Size = new System.Drawing.Size(600, 34);
            this.recieving_box.TabIndex = 4;
            // 
            // period_box
            // 
            this.period_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.period_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.period_box.Location = new System.Drawing.Point(82, 449);
            this.period_box.Name = "period_box";
            this.period_box.Size = new System.Drawing.Size(600, 34);
            this.period_box.TabIndex = 6;
            // 
            // id_box
            // 
            this.id_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.id_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.id_box.Location = new System.Drawing.Point(82, 26);
            this.id_box.Name = "id_box";
            this.id_box.ReadOnly = true;
            this.id_box.Size = new System.Drawing.Size(600, 34);
            this.id_box.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Id";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(82, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Item";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Client";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Price";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Given price";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Receiving date";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Expiration period (days)";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.id_box);
            this.Controls.Add(this.period_box);
            this.Controls.Add(this.recieving_box);
            this.Controls.Add(this.given_price_box);
            this.Controls.Add(this.price_box);
            this.Controls.Add(this.item_box);
            this.Controls.Add(this.client_box);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox client_box;
        private TextBox item_box;
        private TextBox price_box;
        private TextBox given_price_box;
        private TextBox recieving_box;
        private TextBox period_box;
        private TextBox id_box;
        private Label label8;
        private Label label9;
        private Label label6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}