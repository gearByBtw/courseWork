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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.client_box = new System.Windows.Forms.TextBox();
            this.item_box = new System.Windows.Forms.TextBox();
            this.price_box = new System.Windows.Forms.TextBox();
            this.given_price_box = new System.Windows.Forms.TextBox();
            this.recieving_box = new System.Windows.Forms.TextBox();
            this.period_box = new System.Windows.Forms.TextBox();
            this.id_box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(697, 516);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cancel";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 390);
            this.label5.MaximumSize = new System.Drawing.Size(300, 100);
            this.label5.MinimumSize = new System.Drawing.Size(100, 65);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5);
            this.label5.Size = new System.Drawing.Size(300, 65);
            this.label5.TabIndex = 11;
            this.label5.Text = "Expiration period:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 260);
            this.label4.MaximumSize = new System.Drawing.Size(300, 100);
            this.label4.MinimumSize = new System.Drawing.Size(100, 65);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5);
            this.label4.Size = new System.Drawing.Size(300, 65);
            this.label4.TabIndex = 10;
            this.label4.Text = "Given price:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 195);
            this.label3.MaximumSize = new System.Drawing.Size(300, 100);
            this.label3.MinimumSize = new System.Drawing.Size(100, 65);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(300, 65);
            this.label3.TabIndex = 9;
            this.label3.Text = "Price:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.MaximumSize = new System.Drawing.Size(300, 100);
            this.label2.MinimumSize = new System.Drawing.Size(100, 65);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(300, 65);
            this.label2.TabIndex = 8;
            this.label2.Text = "Client:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.MaximumSize = new System.Drawing.Size(300, 100);
            this.label1.MinimumSize = new System.Drawing.Size(100, 65);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(300, 65);
            this.label1.TabIndex = 7;
            this.label1.Text = "Item:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 325);
            this.label7.MaximumSize = new System.Drawing.Size(300, 100);
            this.label7.MinimumSize = new System.Drawing.Size(100, 65);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(5);
            this.label7.Size = new System.Drawing.Size(300, 65);
            this.label7.TabIndex = 13;
            this.label7.Text = "Recieving date:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(472, 476);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 50);
            this.button2.TabIndex = 14;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // client_box
            // 
            this.client_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.client_box.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.client_box.Location = new System.Drawing.Point(341, 145);
            this.client_box.Name = "client_box";
            this.client_box.Size = new System.Drawing.Size(402, 41);
            this.client_box.TabIndex = 16;
            // 
            // item_box
            // 
            this.item_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.item_box.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.item_box.Location = new System.Drawing.Point(341, 80);
            this.item_box.Name = "item_box";
            this.item_box.Size = new System.Drawing.Size(402, 41);
            this.item_box.TabIndex = 17;
            // 
            // price_box
            // 
            this.price_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.price_box.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.price_box.Location = new System.Drawing.Point(341, 210);
            this.price_box.Name = "price_box";
            this.price_box.Size = new System.Drawing.Size(402, 41);
            this.price_box.TabIndex = 18;
            // 
            // given_price_box
            // 
            this.given_price_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.given_price_box.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.given_price_box.Location = new System.Drawing.Point(341, 275);
            this.given_price_box.Name = "given_price_box";
            this.given_price_box.Size = new System.Drawing.Size(402, 41);
            this.given_price_box.TabIndex = 19;
            // 
            // recieving_box
            // 
            this.recieving_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.recieving_box.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.recieving_box.Location = new System.Drawing.Point(341, 340);
            this.recieving_box.Name = "recieving_box";
            this.recieving_box.Size = new System.Drawing.Size(402, 41);
            this.recieving_box.TabIndex = 20;
            // 
            // period_box
            // 
            this.period_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.period_box.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.period_box.Location = new System.Drawing.Point(341, 405);
            this.period_box.Name = "period_box";
            this.period_box.Size = new System.Drawing.Size(402, 41);
            this.period_box.TabIndex = 21;
            // 
            // id_box
            // 
            this.id_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.id_box.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.id_box.Location = new System.Drawing.Point(341, 24);
            this.id_box.Name = "id_box";
            this.id_box.ReadOnly = true;
            this.id_box.Size = new System.Drawing.Size(402, 41);
            this.id_box.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.MaximumSize = new System.Drawing.Size(300, 100);
            this.label6.MinimumSize = new System.Drawing.Size(100, 65);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(5);
            this.label6.Size = new System.Drawing.Size(300, 65);
            this.label6.TabIndex = 22;
            this.label6.Text = "Id:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.id_box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.period_box);
            this.Controls.Add(this.recieving_box);
            this.Controls.Add(this.given_price_box);
            this.Controls.Add(this.price_box);
            this.Controls.Add(this.item_box);
            this.Controls.Add(this.client_box);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private Button button2;
        private TextBox client_box;
        private TextBox item_box;
        private TextBox price_box;
        private TextBox given_price_box;
        private TextBox recieving_box;
        private TextBox period_box;
        private TextBox id_box;
        private Label label6;
    }
}