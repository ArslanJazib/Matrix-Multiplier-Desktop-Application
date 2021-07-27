namespace VPAssignment4
{
    partial class MatrixForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatrixForm));
            this.matrix_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addition_btn = new System.Windows.Forms.ToolStripButton();
            this.multiplication_btn = new System.Windows.Forms.ToolStripButton();
            this.inverse_btn = new System.Windows.Forms.ToolStripButton();
            this.transpose_btn = new System.Windows.Forms.ToolStripButton();
            this.identity = new System.Windows.Forms.ToolStripButton();
            this.row_tbox = new System.Windows.Forms.TextBox();
            this.col_tbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.submit_btn = new System.Windows.Forms.Button();
            this.mode_lbl = new System.Windows.Forms.Label();
            this.mulOperator = new System.Windows.Forms.PictureBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.plusOperator = new System.Windows.Forms.PictureBox();
            this.matrix_dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.col2_tbox = new System.Windows.Forms.TextBox();
            this.row2_tbox = new System.Windows.Forms.TextBox();
            this.matrix2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.matrix_dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mulOperator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plusOperator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrix_dataGridView2)).BeginInit();
            this.matrix2.SuspendLayout();
            this.SuspendLayout();
            // 
            // matrix_dataGridView1
            // 
            this.matrix_dataGridView1.AllowUserToAddRows = false;
            this.matrix_dataGridView1.AllowUserToDeleteRows = false;
            this.matrix_dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.matrix_dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.matrix_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.matrix_dataGridView1.ColumnHeadersVisible = false;
            this.matrix_dataGridView1.Location = new System.Drawing.Point(22, 329);
            this.matrix_dataGridView1.Name = "matrix_dataGridView1";
            this.matrix_dataGridView1.RowHeadersVisible = false;
            this.matrix_dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.matrix_dataGridView1.RowTemplate.Height = 28;
            this.matrix_dataGridView1.Size = new System.Drawing.Size(271, 246);
            this.matrix_dataGridView1.TabIndex = 0;
            this.matrix_dataGridView1.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addition_btn,
            this.multiplication_btn,
            this.inverse_btn,
            this.transpose_btn,
            this.identity});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(966, 31);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addition_btn
            // 
            this.addition_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addition_btn.Image = ((System.Drawing.Image)(resources.GetObject("addition_btn.Image")));
            this.addition_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addition_btn.Name = "addition_btn";
            this.addition_btn.Size = new System.Drawing.Size(28, 28);
            this.addition_btn.Text = "Addition";
            this.addition_btn.Click += new System.EventHandler(this.addition_btn_Click);
            // 
            // multiplication_btn
            // 
            this.multiplication_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.multiplication_btn.Image = ((System.Drawing.Image)(resources.GetObject("multiplication_btn.Image")));
            this.multiplication_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.multiplication_btn.Name = "multiplication_btn";
            this.multiplication_btn.Size = new System.Drawing.Size(28, 28);
            this.multiplication_btn.Text = "Multiplication";
            this.multiplication_btn.Click += new System.EventHandler(this.multiplication_btn_Click);
            // 
            // inverse_btn
            // 
            this.inverse_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.inverse_btn.Image = ((System.Drawing.Image)(resources.GetObject("inverse_btn.Image")));
            this.inverse_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.inverse_btn.Name = "inverse_btn";
            this.inverse_btn.Size = new System.Drawing.Size(28, 28);
            this.inverse_btn.Text = "Inverse";
            this.inverse_btn.Click += new System.EventHandler(this.inverse_btn_Click);
            // 
            // transpose_btn
            // 
            this.transpose_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.transpose_btn.Image = ((System.Drawing.Image)(resources.GetObject("transpose_btn.Image")));
            this.transpose_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.transpose_btn.Name = "transpose_btn";
            this.transpose_btn.Size = new System.Drawing.Size(28, 28);
            this.transpose_btn.Text = "Transpose";
            this.transpose_btn.Click += new System.EventHandler(this.transpose_btn_Click);
            // 
            // identity
            // 
            this.identity.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.identity.Image = ((System.Drawing.Image)(resources.GetObject("identity.Image")));
            this.identity.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.identity.Name = "identity";
            this.identity.Size = new System.Drawing.Size(28, 28);
            this.identity.Text = "Identity";
            this.identity.Click += new System.EventHandler(this.identity_Click);
            // 
            // row_tbox
            // 
            this.row_tbox.Location = new System.Drawing.Point(322, 80);
            this.row_tbox.Name = "row_tbox";
            this.row_tbox.Size = new System.Drawing.Size(132, 26);
            this.row_tbox.TabIndex = 4;
            // 
            // col_tbox
            // 
            this.col_tbox.Location = new System.Drawing.Point(322, 123);
            this.col_tbox.Name = "col_tbox";
            this.col_tbox.Size = new System.Drawing.Size(132, 26);
            this.col_tbox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Rows";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cols";
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(408, 191);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(132, 47);
            this.submit_btn.TabIndex = 8;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // mode_lbl
            // 
            this.mode_lbl.AutoSize = true;
            this.mode_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mode_lbl.Location = new System.Drawing.Point(12, 50);
            this.mode_lbl.Name = "mode_lbl";
            this.mode_lbl.Size = new System.Drawing.Size(86, 32);
            this.mode_lbl.TabIndex = 9;
            this.mode_lbl.Text = "Mode";
            // 
            // mulOperator
            // 
            this.mulOperator.Image = ((System.Drawing.Image)(resources.GetObject("mulOperator.Image")));
            this.mulOperator.Location = new System.Drawing.Point(300, 441);
            this.mulOperator.Name = "mulOperator";
            this.mulOperator.Size = new System.Drawing.Size(49, 50);
            this.mulOperator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mulOperator.TabIndex = 10;
            this.mulOperator.TabStop = false;
            this.mulOperator.Visible = false;
            this.mulOperator.Click += new System.EventHandler(this.mulOperators_Click);
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(769, 525);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(185, 50);
            this.Calculate.TabIndex = 11;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // plusOperator
            // 
            this.plusOperator.Image = ((System.Drawing.Image)(resources.GetObject("plusOperator.Image")));
            this.plusOperator.Location = new System.Drawing.Point(300, 441);
            this.plusOperator.Name = "plusOperator";
            this.plusOperator.Size = new System.Drawing.Size(49, 50);
            this.plusOperator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.plusOperator.TabIndex = 12;
            this.plusOperator.TabStop = false;
            this.plusOperator.Visible = false;
            this.plusOperator.Click += new System.EventHandler(this.plusOperator_Click);
            // 
            // matrix_dataGridView2
            // 
            this.matrix_dataGridView2.AllowUserToAddRows = false;
            this.matrix_dataGridView2.AllowUserToDeleteRows = false;
            this.matrix_dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.matrix_dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.matrix_dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.matrix_dataGridView2.ColumnHeadersVisible = false;
            this.matrix_dataGridView2.Location = new System.Drawing.Point(355, 329);
            this.matrix_dataGridView2.Name = "matrix_dataGridView2";
            this.matrix_dataGridView2.RowHeadersVisible = false;
            this.matrix_dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.matrix_dataGridView2.RowTemplate.Height = 28;
            this.matrix_dataGridView2.Size = new System.Drawing.Size(271, 246);
            this.matrix_dataGridView2.TabIndex = 13;
            this.matrix_dataGridView2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cols";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Rows";
            // 
            // col2_tbox
            // 
            this.col2_tbox.Location = new System.Drawing.Point(65, 89);
            this.col2_tbox.Name = "col2_tbox";
            this.col2_tbox.Size = new System.Drawing.Size(132, 26);
            this.col2_tbox.TabIndex = 15;
            // 
            // row2_tbox
            // 
            this.row2_tbox.Location = new System.Drawing.Point(65, 46);
            this.row2_tbox.Name = "row2_tbox";
            this.row2_tbox.Size = new System.Drawing.Size(132, 26);
            this.row2_tbox.TabIndex = 14;
            // 
            // matrix2
            // 
            this.matrix2.Controls.Add(this.col2_tbox);
            this.matrix2.Controls.Add(this.label3);
            this.matrix2.Controls.Add(this.row2_tbox);
            this.matrix2.Controls.Add(this.label4);
            this.matrix2.Location = new System.Drawing.Point(460, 34);
            this.matrix2.Name = "matrix2";
            this.matrix2.Size = new System.Drawing.Size(200, 121);
            this.matrix2.TabIndex = 18;
            this.matrix2.Visible = false;
            // 
            // MatrixForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 587);
            this.Controls.Add(this.matrix2);
            this.Controls.Add(this.matrix_dataGridView2);
            this.Controls.Add(this.plusOperator);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.mulOperator);
            this.Controls.Add(this.mode_lbl);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.col_tbox);
            this.Controls.Add(this.row_tbox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.matrix_dataGridView1);
            this.Name = "MatrixForm";
            this.Text = "Matrix Manipulator";
            this.Load += new System.EventHandler(this.Matrix_Load);
            ((System.ComponentModel.ISupportInitialize)(this.matrix_dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mulOperator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plusOperator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrix_dataGridView2)).EndInit();
            this.matrix2.ResumeLayout(false);
            this.matrix2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView matrix_dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addition_btn;
        private System.Windows.Forms.ToolStripButton multiplication_btn;
        private System.Windows.Forms.ToolStripButton inverse_btn;
        private System.Windows.Forms.ToolStripButton transpose_btn;
        private System.Windows.Forms.ToolStripButton identity;
        private System.Windows.Forms.TextBox row_tbox;
        private System.Windows.Forms.TextBox col_tbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.Label mode_lbl;
        private System.Windows.Forms.PictureBox mulOperator;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.PictureBox plusOperator;
        private System.Windows.Forms.DataGridView matrix_dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox col2_tbox;
        private System.Windows.Forms.TextBox row2_tbox;
        private System.Windows.Forms.Panel matrix2;
    }
}

