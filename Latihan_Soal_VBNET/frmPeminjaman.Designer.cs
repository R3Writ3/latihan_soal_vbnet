
namespace Latihan_Soal_VBNET
{
    partial class frmPeminjaman
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
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.ViewPDF = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtJudul = new System.Windows.Forms.TextBox();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.comGenre = new System.Windows.Forms.ComboBox();
            this.richtxtsinopsis = new System.Windows.Forms.RichTextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ViewPDF});
            this.dgv1.Location = new System.Drawing.Point(74, 87);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 62;
            this.dgv1.RowTemplate.Height = 28;
            this.dgv1.Size = new System.Drawing.Size(666, 173);
            this.dgv1.TabIndex = 0;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            this.dgv1.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv1_CellMouseUp);
            // 
            // ViewPDF
            // 
            this.ViewPDF.HeaderText = "View Book";
            this.ViewPDF.MinimumWidth = 8;
            this.ViewPDF.Name = "ViewPDF";
            this.ViewPDF.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewPDF.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // txtJudul
            // 
            this.txtJudul.Location = new System.Drawing.Point(413, 274);
            this.txtJudul.Name = "txtJudul";
            this.txtJudul.Size = new System.Drawing.Size(216, 26);
            this.txtJudul.TabIndex = 1;
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(413, 507);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(121, 26);
            this.txtFile.TabIndex = 2;
            // 
            // comGenre
            // 
            this.comGenre.FormattingEnabled = true;
            this.comGenre.Items.AddRange(new object[] {
            "Novel",
            "Light Novel",
            "Jurnal"});
            this.comGenre.Location = new System.Drawing.Point(413, 306);
            this.comGenre.Name = "comGenre";
            this.comGenre.Size = new System.Drawing.Size(121, 28);
            this.comGenre.TabIndex = 3;
            // 
            // richtxtsinopsis
            // 
            this.richtxtsinopsis.Location = new System.Drawing.Point(413, 340);
            this.richtxtsinopsis.Name = "richtxtsinopsis";
            this.richtxtsinopsis.Size = new System.Drawing.Size(216, 147);
            this.richtxtsinopsis.TabIndex = 4;
            this.richtxtsinopsis.Text = "";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(540, 507);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(89, 37);
            this.btnUpload.TabIndex = 5;
            this.btnUpload.Text = "Browse";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Judul";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Genre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sinopsis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 507);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "File";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 556);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(521, 556);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 33);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmPeminjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 766);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.richtxtsinopsis);
            this.Controls.Add(this.comGenre);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.txtJudul);
            this.Controls.Add(this.dgv1);
            this.Name = "frmPeminjaman";
            this.Text = "frmPeminjaman";
            this.Load += new System.EventHandler(this.frmPeminjaman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.TextBox txtJudul;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.ComboBox comGenre;
        private System.Windows.Forms.RichTextBox richtxtsinopsis;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewButtonColumn ViewPDF;
        private System.Windows.Forms.Button btnDelete;
    }
}