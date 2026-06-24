namespace Sinema_Buffet_Sales_App
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtWater = new System.Windows.Forms.TextBox();
            this.TxtPopcorn = new System.Windows.Forms.TextBox();
            this.TxtTea = new System.Windows.Forms.TextBox();
            this.TxtTicket = new System.Windows.Forms.TextBox();
            this.lblwater = new System.Windows.Forms.Label();
            this.lblpopcorn = new System.Windows.Forms.Label();
            this.lbltea = new System.Windows.Forms.Label();
            this.lblticket = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.Price_button = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Case = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightCoral;
            this.groupBox1.Controls.Add(this.TxtTicket);
            this.groupBox1.Controls.Add(this.TxtTea);
            this.groupBox1.Controls.Add(this.TxtPopcorn);
            this.groupBox1.Controls.Add(this.TxtWater);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 368);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Quantity";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SandyBrown;
            this.groupBox2.Controls.Add(this.lblticket);
            this.groupBox2.Controls.Add(this.lbltea);
            this.groupBox2.Controls.Add(this.lblpopcorn);
            this.groupBox2.Controls.Add(this.lblwater);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(315, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 368);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Price Chart";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(55, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Water:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(72, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tea:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(38, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Popcorn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Movie Ticket:";
            // 
            // TxtWater
            // 
            this.TxtWater.Location = new System.Drawing.Point(138, 55);
            this.TxtWater.Name = "TxtWater";
            this.TxtWater.Size = new System.Drawing.Size(121, 30);
            this.TxtWater.TabIndex = 4;
            // 
            // TxtPopcorn
            // 
            this.TxtPopcorn.Location = new System.Drawing.Point(138, 102);
            this.TxtPopcorn.Name = "TxtPopcorn";
            this.TxtPopcorn.Size = new System.Drawing.Size(121, 30);
            this.TxtPopcorn.TabIndex = 5;
            // 
            // TxtTea
            // 
            this.TxtTea.Location = new System.Drawing.Point(138, 157);
            this.TxtTea.Name = "TxtTea";
            this.TxtTea.Size = new System.Drawing.Size(121, 30);
            this.TxtTea.TabIndex = 6;
            // 
            // TxtTicket
            // 
            this.TxtTicket.Location = new System.Drawing.Point(138, 211);
            this.TxtTicket.Name = "TxtTicket";
            this.TxtTicket.Size = new System.Drawing.Size(121, 30);
            this.TxtTicket.TabIndex = 7;
            // 
            // lblwater
            // 
            this.lblwater.AutoSize = true;
            this.lblwater.Location = new System.Drawing.Point(33, 51);
            this.lblwater.Name = "lblwater";
            this.lblwater.Size = new System.Drawing.Size(98, 25);
            this.lblwater.TabIndex = 0;
            this.lblwater.Text = "Water: 2$";
            // 
            // lblpopcorn
            // 
            this.lblpopcorn.AutoSize = true;
            this.lblpopcorn.Location = new System.Drawing.Point(33, 102);
            this.lblpopcorn.Name = "lblpopcorn";
            this.lblpopcorn.Size = new System.Drawing.Size(118, 25);
            this.lblpopcorn.TabIndex = 1;
            this.lblpopcorn.Text = "Popcorn: 5$";
            // 
            // lbltea
            // 
            this.lbltea.AutoSize = true;
            this.lbltea.Location = new System.Drawing.Point(33, 157);
            this.lbltea.Name = "lbltea";
            this.lbltea.Size = new System.Drawing.Size(96, 25);
            this.lbltea.TabIndex = 2;
            this.lbltea.Text = "Tea: 2.5$";
            // 
            // lblticket
            // 
            this.lblticket.AutoSize = true;
            this.lblticket.Location = new System.Drawing.Point(33, 206);
            this.lblticket.Name = "lblticket";
            this.lblticket.Size = new System.Drawing.Size(156, 25);
            this.lblticket.TabIndex = 3;
            this.lblticket.Text = "Movie Ticket: 7$";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.Case);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.Price_button);
            this.groupBox3.Controls.Add(this.TotalPriceLabel);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(583, 104);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(293, 368);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cash Register";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(58, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "Total Price:";
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TotalPriceLabel.Location = new System.Drawing.Point(193, 60);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(45, 25);
            this.TotalPriceLabel.TabIndex = 2;
            this.TotalPriceLabel.Text = "00$";
            // 
            // Price_button
            // 
            this.Price_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Price_button.Location = new System.Drawing.Point(90, 115);
            this.Price_button.Name = "Price_button";
            this.Price_button.Size = new System.Drawing.Size(148, 52);
            this.Price_button.TabIndex = 3;
            this.Price_button.Text = "Price";
            this.Price_button.UseVisualStyleBackColor = true;
            this.Price_button.Click += new System.EventHandler(this.Price_button_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(43, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(423, 38);
            this.label11.TabIndex = 3;
            this.label11.Text = "Cinema Buffet Sales Panel";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(599, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(104, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Case:";
            // 
            // Case
            // 
            this.Case.AutoSize = true;
            this.Case.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Case.Location = new System.Drawing.Point(193, 261);
            this.Case.Name = "Case";
            this.Case.Size = new System.Drawing.Size(45, 25);
            this.Case.TabIndex = 5;
            this.Case.Text = "00$";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(90, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 484);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Cinema Buffet";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtTicket;
        private System.Windows.Forms.TextBox TxtTea;
        private System.Windows.Forms.TextBox TxtPopcorn;
        private System.Windows.Forms.TextBox TxtWater;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblwater;
        private System.Windows.Forms.Label lblticket;
        private System.Windows.Forms.Label lbltea;
        private System.Windows.Forms.Label lblpopcorn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label TotalPriceLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Price_button;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Case;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

