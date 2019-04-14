namespace WindowsFormsApp2
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workspace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(855, 24);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(139, 22);
            this.textBox3.TabIndex = 3;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(638, 7);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(177, 62);
            this.button6.TabIndex = 16;
            this.button6.Text = "Видалити робітника";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(195, 7);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(177, 62);
            this.button7.TabIndex = 17;
            this.button7.Text = "Оновити данні робітника";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.surname,
            this.workspace,
            this.type_A,
            this.type_b,
            this.type_c});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(12, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(982, 582);
            this.dataGridView1.TabIndex = 22;
            // 
            // id
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.id.DefaultCellStyle = dataGridViewCellStyle11;
            this.id.HeaderText = "Ідентифікатор";
            this.id.MinimumWidth = 105;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 105;
            // 
            // surname
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.surname.DefaultCellStyle = dataGridViewCellStyle12;
            this.surname.HeaderText = "Прізвище";
            this.surname.MinimumWidth = 150;
            this.surname.Name = "surname";
            this.surname.ReadOnly = true;
            this.surname.Width = 150;
            // 
            // workspace
            // 
            this.workspace.HeaderText = "Номер цеху";
            this.workspace.MinimumWidth = 130;
            this.workspace.Name = "workspace";
            this.workspace.ReadOnly = true;
            this.workspace.Width = 130;
            // 
            // type_A
            // 
            this.type_A.HeaderText = "Кі-сть деталей типу А";
            this.type_A.MinimumWidth = 105;
            this.type_A.Name = "type_A";
            this.type_A.ReadOnly = true;
            this.type_A.Width = 105;
            // 
            // type_b
            // 
            this.type_b.HeaderText = "Кі-сть деталей типу Б";
            this.type_b.MinimumWidth = 105;
            this.type_b.Name = "type_b";
            this.type_b.ReadOnly = true;
            this.type_b.Width = 105;
            // 
            // type_c
            // 
            this.type_c.HeaderText = "Кі-сть деталей типу С";
            this.type_c.MinimumWidth = 105;
            this.type_c.Name = "type_c";
            this.type_c.ReadOnly = true;
            this.type_c.Width = 105;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 62);
            this.button2.TabIndex = 23;
            this.button2.Text = "Додати користувача";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(821, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "ІД";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 60);
            this.button1.TabIndex = 25;
            this.button1.Text = "Оновити";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn workspace;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_A;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_b;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_c;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

