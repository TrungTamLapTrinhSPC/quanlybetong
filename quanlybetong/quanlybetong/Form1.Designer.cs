namespace quanlybetong
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Thongtin = new System.Windows.Forms.GroupBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lb_ketqua = new System.Windows.Forms.Label();
            this.txt_h = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_l = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_dientich = new System.Windows.Forms.TextBox();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgr_danhsach = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.col_stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_l = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_H = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_S = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_danhsach)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Thongtin
            // 
            this.Thongtin.Controls.Add(this.btn_sua);
            this.Thongtin.Controls.Add(this.txt_name);
            this.Thongtin.Controls.Add(this.lb_ketqua);
            this.Thongtin.Controls.Add(this.txt_h);
            this.Thongtin.Controls.Add(this.label7);
            this.Thongtin.Controls.Add(this.txt_l);
            this.Thongtin.Controls.Add(this.label6);
            this.Thongtin.Controls.Add(this.btn_xoa);
            this.Thongtin.Controls.Add(this.btn_them);
            this.Thongtin.Controls.Add(this.txt_dientich);
            this.Thongtin.Controls.Add(this.txt_b);
            this.Thongtin.Controls.Add(this.label5);
            this.Thongtin.Controls.Add(this.label3);
            this.Thongtin.Controls.Add(this.label2);
            this.Thongtin.Controls.Add(this.label1);
            this.Thongtin.Location = new System.Drawing.Point(27, 33);
            this.Thongtin.Name = "Thongtin";
            this.Thongtin.Size = new System.Drawing.Size(340, 203);
            this.Thongtin.TabIndex = 0;
            this.Thongtin.TabStop = false;
            this.Thongtin.Text = "Thông tin";
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(123, 174);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(81, 23);
            this.btn_sua.TabIndex = 20;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(76, 28);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(52, 20);
            this.txt_name.TabIndex = 19;
            // 
            // lb_ketqua
            // 
            this.lb_ketqua.AutoSize = true;
            this.lb_ketqua.Location = new System.Drawing.Point(242, 62);
            this.lb_ketqua.Name = "lb_ketqua";
            this.lb_ketqua.Size = new System.Drawing.Size(43, 13);
            this.lb_ketqua.TabIndex = 18;
            this.lb_ketqua.Text = "______";
            // 
            // txt_h
            // 
            this.txt_h.Location = new System.Drawing.Point(46, 123);
            this.txt_h.Name = "txt_h";
            this.txt_h.Size = new System.Drawing.Size(36, 20);
            this.txt_h.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "h (mm):";
            // 
            // txt_l
            // 
            this.txt_l.Location = new System.Drawing.Point(46, 94);
            this.txt_l.Name = "txt_l";
            this.txt_l.Size = new System.Drawing.Size(36, 20);
            this.txt_l.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "l (mm):";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(216, 174);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(81, 23);
            this.btn_xoa.TabIndex = 12;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(26, 174);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(81, 23);
            this.btn_them.TabIndex = 11;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_dientich
            // 
            this.txt_dientich.Location = new System.Drawing.Point(245, 28);
            this.txt_dientich.Name = "txt_dientich";
            this.txt_dientich.Size = new System.Drawing.Size(78, 20);
            this.txt_dientich.TabIndex = 10;
            this.txt_dientich.Text = "400";
            this.txt_dientich.TextChanged += new System.EventHandler(this.txt_dientich_TextChanged);
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(46, 62);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(36, 20);
            this.txt_b.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "S(TC) = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Điều kiện:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "b (mm):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên cấu kiện: ";
            // 
            // dgr_danhsach
            // 
            this.dgr_danhsach.AllowUserToAddRows = false;
            this.dgr_danhsach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgr_danhsach.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgr_danhsach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgr_danhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_danhsach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_stt,
            this.col_name,
            this.col_b,
            this.col_l,
            this.col_H,
            this.cl_S});
            this.dgr_danhsach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgr_danhsach.Location = new System.Drawing.Point(3, 16);
            this.dgr_danhsach.Name = "dgr_danhsach";
            this.dgr_danhsach.RowHeadersVisible = false;
            this.dgr_danhsach.RowHeadersWidth = 51;
            this.dgr_danhsach.Size = new System.Drawing.Size(553, 167);
            this.dgr_danhsach.TabIndex = 1;
            this.dgr_danhsach.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgr_danhsach_CellFormatting);
            this.dgr_danhsach.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgr_danhsach_CellMouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgr_danhsach);
            this.groupBox2.Location = new System.Drawing.Point(27, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(559, 186);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // col_stt
            // 
            this.col_stt.HeaderText = "STT";
            this.col_stt.MinimumWidth = 6;
            this.col_stt.Name = "col_stt";
            // 
            // col_name
            // 
            this.col_name.HeaderText = "Tên Cấu Kiện";
            this.col_name.MinimumWidth = 6;
            this.col_name.Name = "col_name";
            // 
            // col_b
            // 
            this.col_b.HeaderText = "B (mm)";
            this.col_b.MinimumWidth = 6;
            this.col_b.Name = "col_b";
            // 
            // col_l
            // 
            this.col_l.HeaderText = "L (mm)";
            this.col_l.MinimumWidth = 6;
            this.col_l.Name = "col_l";
            // 
            // col_H
            // 
            this.col_H.HeaderText = "H (mm)";
            this.col_H.MinimumWidth = 6;
            this.col_H.Name = "col_H";
            // 
            // cl_S
            // 
            this.cl_S.HeaderText = "S (m2)";
            this.cl_S.Name = "cl_S";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 452);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Thongtin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Thongtin.ResumeLayout(false);
            this.Thongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_danhsach)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Thongtin;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox txt_dientich;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgr_danhsach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_h;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_l;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lb_ketqua;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_b;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_l;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_H;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_S;
    }
}

