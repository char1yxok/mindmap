namespace mindmap_MMtest
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.InputBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputBox.Font = new System.Drawing.Font("HGSｺﾞｼｯｸM", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.InputBox.Location = new System.Drawing.Point(31, 21);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(385, 25);
            this.InputBox.TabIndex = 0;
            this.InputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputBox_KeyPress);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AddButton.Location = new System.Drawing.Point(422, 21);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(90, 29);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButtonClicked);
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.treeView1.Location = new System.Drawing.Point(31, 56);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(734, 311);
            this.treeView1.TabIndex = 2;
            this.treeView1.Click += new System.EventHandler(this.treeView1_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveButton.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RemoveButton.Location = new System.Drawing.Point(518, 21);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(90, 29);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButtonClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.InputBox);
            this.Name = "Form1";
            this.Text = "mindmap_treeview";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button RemoveButton;
    }
}

