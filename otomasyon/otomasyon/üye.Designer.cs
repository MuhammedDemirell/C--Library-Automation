
namespace otomasyon
{
    partial class üye
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
            this.x1 = new System.Windows.Forms.Button();
            this.x2 = new System.Windows.Forms.Button();
            this.z1 = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.kitapid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YAZAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DİL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YAYINEVİ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TÜR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SAYFA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BYIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // x1
            // 
            this.x1.Location = new System.Drawing.Point(91, 10);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(75, 23);
            this.x1.TabIndex = 1;
            this.x1.Text = "Ara";
            this.x1.UseVisualStyleBackColor = true;
            this.x1.Click += new System.EventHandler(this.x1_Click);
            // 
            // x2
            // 
            this.x2.Location = new System.Drawing.Point(297, 12);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(75, 23);
            this.x2.TabIndex = 2;
            this.x2.Text = "Yenile";
            this.x2.UseVisualStyleBackColor = true;
            this.x2.Click += new System.EventHandler(this.x2_Click);
            // 
            // z1
            // 
            this.z1.Location = new System.Drawing.Point(181, 12);
            this.z1.Name = "z1";
            this.z1.Size = new System.Drawing.Size(100, 20);
            this.z1.TabIndex = 3;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(71, 369);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 4;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitapid,
            this.Column1,
            this.YAZAR,
            this.DİL,
            this.YAYINEVİ,
            this.TÜR,
            this.ADET,
            this.SAYFA,
            this.BYIL});
            this.dataGridView2.Location = new System.Drawing.Point(26, 74);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(743, 150);
            this.dataGridView2.TabIndex = 19;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // kitapid
            // 
            this.kitapid.HeaderText = "KİTAPID";
            this.kitapid.Name = "kitapid";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "K.İSİM";
            this.Column1.Name = "Column1";
            // 
            // YAZAR
            // 
            this.YAZAR.HeaderText = "yazar";
            this.YAZAR.Name = "YAZAR";
            // 
            // DİL
            // 
            this.DİL.HeaderText = "DİL";
            this.DİL.Name = "DİL";
            // 
            // YAYINEVİ
            // 
            this.YAYINEVİ.HeaderText = "YAYINEVİ";
            this.YAYINEVİ.Name = "YAYINEVİ";
            // 
            // TÜR
            // 
            this.TÜR.HeaderText = "TÜR";
            this.TÜR.Name = "TÜR";
            // 
            // ADET
            // 
            this.ADET.HeaderText = "ADET";
            this.ADET.Name = "ADET";
            // 
            // SAYFA
            // 
            this.SAYFA.HeaderText = "SAYFA";
            this.SAYFA.Name = "SAYFA";
            // 
            // BYIL
            // 
            this.BYIL.HeaderText = "BYIL";
            this.BYIL.Name = "BYIL";
            // 
            // üye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.z1);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.x1);
            this.Name = "üye";
            this.Text = "üye";
            this.Load += new System.EventHandler(this.üye_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button x1;
        private System.Windows.Forms.Button x2;
        private System.Windows.Forms.TextBox z1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn YAZAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DİL;
        private System.Windows.Forms.DataGridViewTextBoxColumn YAYINEVİ;
        private System.Windows.Forms.DataGridViewTextBoxColumn TÜR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADET;
        private System.Windows.Forms.DataGridViewTextBoxColumn SAYFA;
        private System.Windows.Forms.DataGridViewTextBoxColumn BYIL;
    }
}