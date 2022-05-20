namespace Test2
{
    partial class Client
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.AddBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.del = new System.Windows.Forms.Button();
            this.UpdBtn1 = new System.Windows.Forms.Button();
            this.Updform = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.UpdTableBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(720, 212);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 242);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(720, 212);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(841, 562);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(93, 23);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 460);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(49, 22);
            this.textBox1.TabIndex = 3;
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(67, 459);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(75, 23);
            this.del.TabIndex = 4;
            this.del.Text = "Удалить";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // UpdBtn1
            // 
            this.UpdBtn1.Location = new System.Drawing.Point(640, 562);
            this.UpdBtn1.Name = "UpdBtn1";
            this.UpdBtn1.Size = new System.Drawing.Size(180, 23);
            this.UpdBtn1.TabIndex = 5;
            this.UpdBtn1.Text = "Редактировать";
            this.UpdBtn1.UseVisualStyleBackColor = true;
            this.UpdBtn1.Click += new System.EventHandler(this.UpdBtn_Click);
            // 
            // Updform
            // 
            this.Updform.Location = new System.Drawing.Point(292, 551);
            this.Updform.Name = "Updform";
            this.Updform.Size = new System.Drawing.Size(183, 23);
            this.Updform.TabIndex = 6;
            this.Updform.Text = "редакт";
            this.Updform.UseVisualStyleBackColor = true;
            this.Updform.Click += new System.EventHandler(this.Updform_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(806, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // UpdTableBtn
            // 
            this.UpdTableBtn.Location = new System.Drawing.Point(379, 480);
            this.UpdTableBtn.Name = "UpdTableBtn";
            this.UpdTableBtn.Size = new System.Drawing.Size(152, 40);
            this.UpdTableBtn.TabIndex = 8;
            this.UpdTableBtn.Text = "UpdTableBtn";
            this.UpdTableBtn.UseVisualStyleBackColor = true;
            this.UpdTableBtn.Click += new System.EventHandler(this.UpdTableBtn_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 597);
            this.Controls.Add(this.UpdTableBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Updform);
            this.Controls.Add(this.UpdBtn1);
            this.Controls.Add(this.del);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Client";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Client_FormClosed);
            this.Load += new System.EventHandler(this.Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button UpdBtn1;
        private System.Windows.Forms.Button Updform;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button UpdTableBtn;
    }
}

