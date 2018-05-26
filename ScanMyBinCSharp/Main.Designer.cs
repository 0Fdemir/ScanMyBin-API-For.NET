using System.Windows.Forms;

namespace ScanMyBinCSharp
{
    partial class Main
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
            this.Button1 = new System.Windows.Forms.Button();
            this.fileName = new System.Windows.Forms.TextBox();
            this.resultLink = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.lblRatio = new System.Windows.Forms.Label();
            this.Button3 = new System.Windows.Forms.Button();
            this.lblProgress = new System.Windows.Forms.Label();
            this.txtMD5 = new System.Windows.Forms.TextBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.AvNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDate = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(331, 12);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(52, 23);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "Browse";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(81, 15);
            this.fileName.Name = "fileName";
            this.fileName.ReadOnly = true;
            this.fileName.Size = new System.Drawing.Size(244, 20);
            this.fileName.TabIndex = 2;
            this.fileName.Text = "c:\\file.exe";
            // 
            // resultLink
            // 
            this.resultLink.Location = new System.Drawing.Point(81, 41);
            this.resultLink.Name = "resultLink";
            this.resultLink.ReadOnly = true;
            this.resultLink.Size = new System.Drawing.Size(244, 20);
            this.resultLink.TabIndex = 3;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 45);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(63, 13);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Result Link:";
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(331, 39);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(52, 23);
            this.Button2.TabIndex = 5;
            this.Button2.Text = "Copy";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(24, 18);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(51, 13);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "File Path:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(41, 70);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(36, 13);
            this.Label3.TabIndex = 7;
            this.Label3.Text = "MD5: ";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(12, 93);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(63, 13);
            this.Label4.TabIndex = 8;
            this.Label4.Text = "Scan Ratio:";
            // 
            // lblRatio
            // 
            this.lblRatio.AutoSize = true;
            this.lblRatio.Location = new System.Drawing.Point(81, 93);
            this.lblRatio.Name = "lblRatio";
            this.lblRatio.Size = new System.Drawing.Size(24, 13);
            this.lblRatio.TabIndex = 9;
            this.lblRatio.Text = "n/n";
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(331, 65);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(52, 23);
            this.Button3.TabIndex = 12;
            this.Button3.Text = "Start";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(1, 532);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(48, 13);
            this.lblProgress.TabIndex = 13;
            this.lblProgress.Text = "Progress";
            // 
            // txtMD5
            // 
            this.txtMD5.Location = new System.Drawing.Point(81, 67);
            this.txtMD5.Name = "txtMD5";
            this.txtMD5.ReadOnly = true;
            this.txtMD5.Size = new System.Drawing.Size(244, 20);
            this.txtMD5.TabIndex = 14;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToOrderColumns = true;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AvNames,
            this.result});
            this.grid.Location = new System.Drawing.Point(4, 122);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.Size = new System.Drawing.Size(392, 407);
            this.grid.TabIndex = 16;
            this.grid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grid_CellFormatting);
            // 
            // AvNames
            // 
            this.AvNames.FillWeight = 101.5228F;
            this.AvNames.HeaderText = "Antiviruses";
            this.AvNames.Name = "AvNames";
            this.AvNames.ReadOnly = true;
            // 
            // result
            // 
            this.result.FillWeight = 98.47716F;
            this.result.HeaderText = "Results";
            this.result.Name = "result";
            this.result.ReadOnly = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(264, 93);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(61, 13);
            this.lblDate.TabIndex = 19;
            this.lblDate.Text = "yyyy-mm-dd";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(226, 93);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(36, 13);
            this.Label5.TabIndex = 18;
            this.Label5.Text = "Date: ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 550);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.txtMD5);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.lblRatio);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.resultLink);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.Button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScanMyBin for .NET";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        internal Button Button1;
        internal TextBox fileName;
        internal TextBox resultLink;
        internal Label Label1;
        internal Button Button2;
        internal Label Label2;
        internal Label Label3;
        internal Label Label4;
        internal Label lblRatio;
        internal Button Button3;
        internal Label lblProgress;
        internal TextBox txtMD5;

        #endregion

        internal DataGridView grid;
        internal DataGridViewTextBoxColumn AvNames;
        internal DataGridViewTextBoxColumn result;
        internal Label lblDate;
        internal Label Label5;
    }
}

