namespace KutuphaneOtomasyon
{
    partial class MemberForm
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
            this.btn_memberSearch = new System.Windows.Forms.Button();
            this.btn_refreshMember = new System.Windows.Forms.Button();
            this.textBox_memberBook = new System.Windows.Forms.TextBox();
            this.btn_memberQuit = new System.Windows.Forms.Button();
            this.dataGridView_member = new System.Windows.Forms.DataGridView();
            this.bookİd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_writer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookLanguage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piece = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicationYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_member)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_memberSearch
            // 
            this.btn_memberSearch.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_memberSearch.Location = new System.Drawing.Point(12, 36);
            this.btn_memberSearch.Name = "btn_memberSearch";
            this.btn_memberSearch.Size = new System.Drawing.Size(216, 39);
            this.btn_memberSearch.TabIndex = 0;
            this.btn_memberSearch.Text = "Search";
            this.btn_memberSearch.UseVisualStyleBackColor = true;
            this.btn_memberSearch.Click += new System.EventHandler(this.btn_memberSearch_Click);
            // 
            // btn_refreshMember
            // 
            this.btn_refreshMember.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refreshMember.Location = new System.Drawing.Point(524, 36);
            this.btn_refreshMember.Name = "btn_refreshMember";
            this.btn_refreshMember.Size = new System.Drawing.Size(211, 39);
            this.btn_refreshMember.TabIndex = 0;
            this.btn_refreshMember.Text = "Refresh";
            this.btn_refreshMember.UseVisualStyleBackColor = true;
            this.btn_refreshMember.Click += new System.EventHandler(this.btn_refreshMember_Click);
            // 
            // textBox_memberBook
            // 
            this.textBox_memberBook.Location = new System.Drawing.Point(249, 36);
            this.textBox_memberBook.Multiline = true;
            this.textBox_memberBook.Name = "textBox_memberBook";
            this.textBox_memberBook.Size = new System.Drawing.Size(252, 39);
            this.textBox_memberBook.TabIndex = 1;
            // 
            // btn_memberQuit
            // 
            this.btn_memberQuit.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_memberQuit.Location = new System.Drawing.Point(249, 393);
            this.btn_memberQuit.Name = "btn_memberQuit";
            this.btn_memberQuit.Size = new System.Drawing.Size(274, 45);
            this.btn_memberQuit.TabIndex = 3;
            this.btn_memberQuit.Text = "Quit";
            this.btn_memberQuit.UseVisualStyleBackColor = true;
            this.btn_memberQuit.Click += new System.EventHandler(this.btn_memberQuit_Click);
            // 
            // dataGridView_member
            // 
            this.dataGridView_member.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_member.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookİd,
            this.bookName,
            this.book_writer,
            this.bookLanguage,
            this.book_type,
            this.publisher,
            this.piece,
            this.publicationYear,
            this.pageCount});
            this.dataGridView_member.Location = new System.Drawing.Point(12, 98);
            this.dataGridView_member.Name = "dataGridView_member";
            this.dataGridView_member.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_member.Size = new System.Drawing.Size(720, 289);
            this.dataGridView_member.TabIndex = 6;
            this.dataGridView_member.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_member_CellContentClick);
            // 
            // bookİd
            // 
            this.bookİd.HeaderText = "BOOK İD";
            this.bookİd.Name = "bookİd";
            this.bookİd.Width = 75;
            // 
            // bookName
            // 
            this.bookName.HeaderText = "BOOK NAME";
            this.bookName.Name = "bookName";
            this.bookName.Width = 75;
            // 
            // book_writer
            // 
            this.book_writer.HeaderText = "WRİTER";
            this.book_writer.Name = "book_writer";
            this.book_writer.Width = 75;
            // 
            // bookLanguage
            // 
            this.bookLanguage.HeaderText = "LANGUAGE";
            this.bookLanguage.Name = "bookLanguage";
            this.bookLanguage.Width = 75;
            // 
            // book_type
            // 
            this.book_type.HeaderText = "BOOK TYPE";
            this.book_type.Name = "book_type";
            this.book_type.Width = 75;
            // 
            // publisher
            // 
            this.publisher.HeaderText = "PUBLİSHER";
            this.publisher.Name = "publisher";
            this.publisher.Width = 75;
            // 
            // piece
            // 
            this.piece.HeaderText = "PİECE";
            this.piece.Name = "piece";
            this.piece.Width = 75;
            // 
            // publicationYear
            // 
            this.publicationYear.HeaderText = "PUBLİCATİON YEAR";
            this.publicationYear.Name = "publicationYear";
            this.publicationYear.Width = 75;
            // 
            // pageCount
            // 
            this.pageCount.HeaderText = "PAGE COUNT";
            this.pageCount.Name = "pageCount";
            this.pageCount.Width = 75;
            // 
            // MemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(746, 443);
            this.Controls.Add(this.dataGridView_member);
            this.Controls.Add(this.btn_memberQuit);
            this.Controls.Add(this.textBox_memberBook);
            this.Controls.Add(this.btn_refreshMember);
            this.Controls.Add(this.btn_memberSearch);
            this.Name = "MemberForm";
            this.Text = "MemberForm";
            this.Load += new System.EventHandler(this.MemberForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_member)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_memberSearch;
        private System.Windows.Forms.Button btn_refreshMember;
        private System.Windows.Forms.TextBox textBox_memberBook;
        private System.Windows.Forms.Button btn_memberQuit;
        private System.Windows.Forms.DataGridView dataGridView_member;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookİd;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_writer;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookLanguage;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn piece;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicationYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn pageCount;
    }
}