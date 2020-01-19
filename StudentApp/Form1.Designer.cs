namespace StudentApp
{
    partial class Form1
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
            this.nameField = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.sexText = new System.Windows.Forms.Label();
            this.sexField = new System.Windows.Forms.TextBox();
            this.cityText = new System.Windows.Forms.Label();
            this.cityField = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(112, 75);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(293, 20);
            this.nameField.TabIndex = 0;
            // 
            // nameText
            // 
            this.nameText.AutoSize = true;
            this.nameText.Location = new System.Drawing.Point(48, 82);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(35, 13);
            this.nameText.TabIndex = 1;
            this.nameText.Text = "Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 300);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(713, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Read";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sexText
            // 
            this.sexText.AutoSize = true;
            this.sexText.Location = new System.Drawing.Point(48, 121);
            this.sexText.Name = "sexText";
            this.sexText.Size = new System.Drawing.Size(25, 13);
            this.sexText.TabIndex = 6;
            this.sexText.Text = "Sex";
            // 
            // sexField
            // 
            this.sexField.Location = new System.Drawing.Point(112, 114);
            this.sexField.Name = "sexField";
            this.sexField.Size = new System.Drawing.Size(293, 20);
            this.sexField.TabIndex = 5;
            // 
            // cityText
            // 
            this.cityText.AutoSize = true;
            this.cityText.Location = new System.Drawing.Point(48, 160);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(48, 13);
            this.cityText.TabIndex = 8;
            this.cityText.Text = "Birth City";
            // 
            // cityField
            // 
            this.cityField.Location = new System.Drawing.Point(112, 153);
            this.cityField.Name = "cityField";
            this.cityField.Size = new System.Drawing.Size(293, 20);
            this.cityField.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cityText);
            this.Controls.Add(this.cityField);
            this.Controls.Add(this.sexText);
            this.Controls.Add(this.sexField);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.nameField);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label nameText;
        private System.Windows.Forms.Button button1;
        protected System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label sexText;
        private System.Windows.Forms.TextBox sexField;
        private System.Windows.Forms.Label cityText;
        private System.Windows.Forms.TextBox cityField;
    }
}

