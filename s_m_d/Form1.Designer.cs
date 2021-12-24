
namespace ödev_1
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
            this.components = new System.ComponentModel.Container();
            this.text1 = new System.Windows.Forms.TextBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(104, 54);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(330, 20);
            this.text1.TabIndex = 0;
            this.text1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cümle Girişi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kelime Sayısı";
            this.label2.Visible = false;
            // 
            // text2
            // 
            this.text2.Location = new System.Drawing.Point(107, 161);
            this.text2.Name = "text2";
            this.text2.ReadOnly = true;
            this.text2.Size = new System.Drawing.Size(63, 20);
            this.text2.TabIndex = 4;
            this.text2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kelimeler";
            this.label3.Visible = false;
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(105, 187);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.ReadOnly = true;
            this.TextBox1.Size = new System.Drawing.Size(135, 132);
            this.TextBox1.TabIndex = 6;
            this.TextBox1.Text = "";
            this.TextBox1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(246, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 25);
            this.button2.TabIndex = 7;
            this.button2.Text = "Yeni Giriş";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(342, 94);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 25);
            this.button3.TabIndex = 8;
            this.button3.Text = "Çıkış";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 344);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text1);
            this.Name = "Form1";
            this.Text = "Harf Arama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox TextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

