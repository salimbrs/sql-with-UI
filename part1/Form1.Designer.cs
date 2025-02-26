
namespace part1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ViewGrid_bt = new System.Windows.Forms.Button();
            this.Insert_bt = new System.Windows.Forms.Button();
            this.update_bt = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.RegNo_tx = new System.Windows.Forms.TextBox();
            this.Name_tx = new System.Windows.Forms.TextBox();
            this.Adress_tx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-6, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(804, 236);
            this.dataGridView1.TabIndex = 0;
            // 
            // ViewGrid_bt
            // 
            this.ViewGrid_bt.Location = new System.Drawing.Point(26, 370);
            this.ViewGrid_bt.Name = "ViewGrid_bt";
            this.ViewGrid_bt.Size = new System.Drawing.Size(75, 23);
            this.ViewGrid_bt.TabIndex = 1;
            this.ViewGrid_bt.Text = "View";
            this.ViewGrid_bt.UseVisualStyleBackColor = true;
            this.ViewGrid_bt.Click += new System.EventHandler(this.ViewGrid_bt_Click);
            // 
            // Insert_bt
            // 
            this.Insert_bt.Location = new System.Drawing.Point(144, 370);
            this.Insert_bt.Name = "Insert_bt";
            this.Insert_bt.Size = new System.Drawing.Size(75, 23);
            this.Insert_bt.TabIndex = 2;
            this.Insert_bt.Text = "Insert";
            this.Insert_bt.UseVisualStyleBackColor = true;
            this.Insert_bt.Click += new System.EventHandler(this.Insert_bt_Click);
            // 
            // update_bt
            // 
            this.update_bt.Location = new System.Drawing.Point(272, 370);
            this.update_bt.Name = "update_bt";
            this.update_bt.Size = new System.Drawing.Size(75, 23);
            this.update_bt.TabIndex = 3;
            this.update_bt.Text = "Update";
            this.update_bt.UseVisualStyleBackColor = true;
            this.update_bt.Click += new System.EventHandler(this.update_bt_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(438, 370);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 4;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(605, 370);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "View";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // RegNo_tx
            // 
            this.RegNo_tx.Location = new System.Drawing.Point(26, 308);
            this.RegNo_tx.Name = "RegNo_tx";
            this.RegNo_tx.Size = new System.Drawing.Size(100, 20);
            this.RegNo_tx.TabIndex = 6;
            // 
            // Name_tx
            // 
            this.Name_tx.Location = new System.Drawing.Point(200, 308);
            this.Name_tx.Name = "Name_tx";
            this.Name_tx.Size = new System.Drawing.Size(100, 20);
            this.Name_tx.TabIndex = 7;
            // 
            // Adress_tx
            // 
            this.Adress_tx.Location = new System.Drawing.Point(388, 308);
            this.Adress_tx.Name = "Adress_tx";
            this.Adress_tx.Size = new System.Drawing.Size(100, 20);
            this.Adress_tx.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Reg No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Student Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Adress";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Adress_tx);
            this.Controls.Add(this.Name_tx);
            this.Controls.Add(this.RegNo_tx);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.update_bt);
            this.Controls.Add(this.Insert_bt);
            this.Controls.Add(this.ViewGrid_bt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ViewGrid_bt;
        private System.Windows.Forms.Button Insert_bt;
        private System.Windows.Forms.Button update_bt;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox RegNo_tx;
        private System.Windows.Forms.TextBox Name_tx;
        private System.Windows.Forms.TextBox Adress_tx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

