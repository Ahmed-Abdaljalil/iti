namespace ado_lab1
{
    partial class connectedMode
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
            this.btn_add = new System.Windows.Forms.Button();
            this.dgv_course = new System.Windows.Forms.DataGridView();
            this.co_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.num_duration = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.combo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.up_date = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_course)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_duration)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(783, 155);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dgv_course
            // 
            this.dgv_course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_course.Location = new System.Drawing.Point(6, 245);
            this.dgv_course.Name = "dgv_course";
            this.dgv_course.RowHeadersWidth = 51;
            this.dgv_course.RowTemplate.Height = 24;
            this.dgv_course.Size = new System.Drawing.Size(1010, 250);
            this.dgv_course.TabIndex = 1;
            this.dgv_course.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_course_RowHeaderMouseDoubleClick);
            // 
            // co_name
            // 
            this.co_name.Location = new System.Drawing.Point(180, 45);
            this.co_name.Name = "co_name";
            this.co_name.Size = new System.Drawing.Size(100, 22);
            this.co_name.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "course Name";
            // 
            // num_duration
            // 
            this.num_duration.Location = new System.Drawing.Point(449, 48);
            this.num_duration.Name = "num_duration";
            this.num_duration.Size = new System.Drawing.Size(120, 22);
            this.num_duration.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Duration";
            // 
            // combo
            // 
            this.combo.FormattingEnabled = true;
            this.combo.Location = new System.Drawing.Point(766, 48);
            this.combo.Name = "combo";
            this.combo.Size = new System.Drawing.Size(121, 24);
            this.combo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(682, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Topics";
            // 
            // up_date
            // 
            this.up_date.Location = new System.Drawing.Point(643, 155);
            this.up_date.Name = "up_date";
            this.up_date.Size = new System.Drawing.Size(75, 23);
            this.up_date.TabIndex = 8;
            this.up_date.Text = "update";
            this.up_date.UseVisualStyleBackColor = true;
            this.up_date.Click += new System.EventHandler(this.up_date_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(518, 154);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 544);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.up_date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num_duration);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.co_name);
            this.Controls.Add(this.dgv_course);
            this.Controls.Add(this.btn_add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_course)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_duration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dgv_course;
        private System.Windows.Forms.TextBox co_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_duration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button up_date;
        private System.Windows.Forms.Button btn_delete;
    }
}

