namespace ResWander
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.crawButton = new System.Windows.Forms.Button();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.choseButton = new System.Windows.Forms.Button();
            this.setbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.elseCheckBox = new System.Windows.Forms.CheckBox();
            this.mediaCheckBox = new System.Windows.Forms.CheckBox();
            this.textCheckBox = new System.Windows.Forms.CheckBox();
            this.photoCheckBox = new System.Windows.Forms.CheckBox();
            this.reChoseButton = new System.Windows.Forms.Button();
            this.selectAllButton = new System.Windows.Forms.Button();
            this.upDateButton = new System.Windows.Forms.Button();
            this.openListButton = new System.Windows.Forms.Button();
            this.resourceTabControl = new System.Windows.Forms.TabControl();
            this.resourceTabPage = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.previewTabPage = new System.Windows.Forms.TabPage();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.dataGridView9 = new System.Windows.Forms.DataGridView();
            this.dataGridView8 = new System.Windows.Forms.DataGridView();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.resourceTabControl.SuspendLayout();
            this.resourceTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.previewTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // crawButton
            // 
            this.crawButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.crawButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.crawButton.Location = new System.Drawing.Point(862, 2);
            this.crawButton.Name = "crawButton";
            this.crawButton.Size = new System.Drawing.Size(74, 28);
            this.crawButton.TabIndex = 2;
            this.crawButton.Text = "爬取";
            this.crawButton.UseVisualStyleBackColor = true;
            this.crawButton.Click += new System.EventHandler(this.CrawButton_Click);
            // 
            // urlTextBox
            // 
            this.urlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlTextBox.Location = new System.Drawing.Point(90, 3);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(757, 25);
            this.urlTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "目标URL：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "显示当前爬取的文件信息，如数量等等";
            // 
            // choseButton
            // 
            this.choseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.choseButton.Location = new System.Drawing.Point(670, 46);
            this.choseButton.Name = "choseButton";
            this.choseButton.Size = new System.Drawing.Size(100, 28);
            this.choseButton.TabIndex = 6;
            this.choseButton.Text = "筛选";
            this.choseButton.UseVisualStyleBackColor = true;
            this.choseButton.Click += new System.EventHandler(this.ChoseButton_Click);
            // 
            // setbutton
            // 
            this.setbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.setbutton.Location = new System.Drawing.Point(818, 46);
            this.setbutton.Name = "setbutton";
            this.setbutton.Size = new System.Drawing.Size(100, 28);
            this.setbutton.TabIndex = 7;
            this.setbutton.Text = "设置";
            this.setbutton.UseVisualStyleBackColor = true;
            this.setbutton.Click += new System.EventHandler(this.Button_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.urlTextBox);
            this.panel1.Controls.Add(this.crawButton);
            this.panel1.Location = new System.Drawing.Point(1, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 34);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(1, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(624, 33);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.elseCheckBox);
            this.panel3.Controls.Add(this.mediaCheckBox);
            this.panel3.Controls.Add(this.textCheckBox);
            this.panel3.Controls.Add(this.photoCheckBox);
            this.panel3.Location = new System.Drawing.Point(1, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(339, 28);
            this.panel3.TabIndex = 10;
            // 
            // elseCheckBox
            // 
            this.elseCheckBox.AutoSize = true;
            this.elseCheckBox.Location = new System.Drawing.Point(268, 3);
            this.elseCheckBox.Name = "elseCheckBox";
            this.elseCheckBox.Size = new System.Drawing.Size(59, 19);
            this.elseCheckBox.TabIndex = 3;
            this.elseCheckBox.Text = "其他";
            this.elseCheckBox.UseVisualStyleBackColor = true;
            // 
            // mediaCheckBox
            // 
            this.mediaCheckBox.AutoSize = true;
            this.mediaCheckBox.Location = new System.Drawing.Point(169, 3);
            this.mediaCheckBox.Name = "mediaCheckBox";
            this.mediaCheckBox.Size = new System.Drawing.Size(74, 19);
            this.mediaCheckBox.TabIndex = 2;
            this.mediaCheckBox.Text = "多媒体";
            this.mediaCheckBox.UseVisualStyleBackColor = true;
            // 
            // textCheckBox
            // 
            this.textCheckBox.AutoSize = true;
            this.textCheckBox.Location = new System.Drawing.Point(90, 3);
            this.textCheckBox.Name = "textCheckBox";
            this.textCheckBox.Size = new System.Drawing.Size(59, 19);
            this.textCheckBox.TabIndex = 1;
            this.textCheckBox.Text = "文本";
            this.textCheckBox.UseVisualStyleBackColor = true;
            // 
            // photoCheckBox
            // 
            this.photoCheckBox.AutoSize = true;
            this.photoCheckBox.Location = new System.Drawing.Point(11, 3);
            this.photoCheckBox.Name = "photoCheckBox";
            this.photoCheckBox.Size = new System.Drawing.Size(59, 19);
            this.photoCheckBox.TabIndex = 0;
            this.photoCheckBox.Text = "图片";
            this.photoCheckBox.UseVisualStyleBackColor = true;
            // 
            // reChoseButton
            // 
            this.reChoseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reChoseButton.Location = new System.Drawing.Point(3, 0);
            this.reChoseButton.Name = "reChoseButton";
            this.reChoseButton.Size = new System.Drawing.Size(87, 28);
            this.reChoseButton.TabIndex = 4;
            this.reChoseButton.Text = "重新筛选";
            this.reChoseButton.UseVisualStyleBackColor = true;
            this.reChoseButton.Click += new System.EventHandler(this.ReChoseButton_Click);
            // 
            // selectAllButton
            // 
            this.selectAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectAllButton.Location = new System.Drawing.Point(96, 0);
            this.selectAllButton.Name = "selectAllButton";
            this.selectAllButton.Size = new System.Drawing.Size(75, 28);
            this.selectAllButton.TabIndex = 5;
            this.selectAllButton.Text = "全选";
            this.selectAllButton.UseVisualStyleBackColor = true;
            this.selectAllButton.Click += new System.EventHandler(this.SelectAllButton_Click);
            // 
            // upDateButton
            // 
            this.upDateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.upDateButton.Location = new System.Drawing.Point(177, 0);
            this.upDateButton.Name = "upDateButton";
            this.upDateButton.Size = new System.Drawing.Size(81, 28);
            this.upDateButton.TabIndex = 6;
            this.upDateButton.Text = "下载选中";
            this.upDateButton.UseVisualStyleBackColor = true;
            this.upDateButton.Click += new System.EventHandler(this.UpDateButton_Click);
            // 
            // openListButton
            // 
            this.openListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openListButton.Location = new System.Drawing.Point(264, 0);
            this.openListButton.Name = "openListButton";
            this.openListButton.Size = new System.Drawing.Size(120, 28);
            this.openListButton.TabIndex = 7;
            this.openListButton.Text = "打开下载目录";
            this.openListButton.UseVisualStyleBackColor = true;
            this.openListButton.Click += new System.EventHandler(this.OpenListButton_Click);
            // 
            // resourceTabControl
            // 
            this.resourceTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resourceTabControl.Controls.Add(this.resourceTabPage);
            this.resourceTabControl.Controls.Add(this.previewTabPage);
            this.resourceTabControl.Location = new System.Drawing.Point(7, 117);
            this.resourceTabControl.Name = "resourceTabControl";
            this.resourceTabControl.SelectedIndex = 0;
            this.resourceTabControl.Size = new System.Drawing.Size(935, 348);
            this.resourceTabControl.TabIndex = 12;
            // 
            // resourceTabPage
            // 
            this.resourceTabPage.Controls.Add(this.dataGridView1);
            this.resourceTabPage.Location = new System.Drawing.Point(4, 25);
            this.resourceTabPage.Name = "resourceTabPage";
            this.resourceTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.resourceTabPage.Size = new System.Drawing.Size(927, 319);
            this.resourceTabPage.TabIndex = 0;
            this.resourceTabPage.Text = "资源爬取情况";
            this.resourceTabPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(928, 310);
            this.dataGridView1.TabIndex = 0;
            // 
            // previewTabPage
            // 
            this.previewTabPage.Controls.Add(this.dataGridView7);
            this.previewTabPage.Controls.Add(this.dataGridView9);
            this.previewTabPage.Controls.Add(this.dataGridView8);
            this.previewTabPage.Controls.Add(this.dataGridView6);
            this.previewTabPage.Controls.Add(this.dataGridView5);
            this.previewTabPage.Controls.Add(this.dataGridView4);
            this.previewTabPage.Controls.Add(this.dataGridView3);
            this.previewTabPage.Controls.Add(this.dataGridView2);
            this.previewTabPage.Location = new System.Drawing.Point(4, 25);
            this.previewTabPage.Name = "previewTabPage";
            this.previewTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.previewTabPage.Size = new System.Drawing.Size(927, 319);
            this.previewTabPage.TabIndex = 1;
            this.previewTabPage.Text = "预览";
            this.previewTabPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView7
            // 
            this.dataGridView7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Location = new System.Drawing.Point(242, 172);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.RowHeadersWidth = 51;
            this.dataGridView7.RowTemplate.Height = 27;
            this.dataGridView7.Size = new System.Drawing.Size(160, 130);
            this.dataGridView7.TabIndex = 8;
            // 
            // dataGridView9
            // 
            this.dataGridView9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView9.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView9.Location = new System.Drawing.Point(713, 172);
            this.dataGridView9.Name = "dataGridView9";
            this.dataGridView9.RowHeadersWidth = 51;
            this.dataGridView9.RowTemplate.Height = 27;
            this.dataGridView9.Size = new System.Drawing.Size(160, 130);
            this.dataGridView9.TabIndex = 7;
            // 
            // dataGridView8
            // 
            this.dataGridView8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView8.Location = new System.Drawing.Point(480, 172);
            this.dataGridView8.Name = "dataGridView8";
            this.dataGridView8.RowHeadersWidth = 51;
            this.dataGridView8.RowTemplate.Height = 27;
            this.dataGridView8.Size = new System.Drawing.Size(160, 130);
            this.dataGridView8.TabIndex = 6;
            // 
            // dataGridView6
            // 
            this.dataGridView6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(15, 166);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.RowHeadersWidth = 51;
            this.dataGridView6.RowTemplate.Height = 27;
            this.dataGridView6.Size = new System.Drawing.Size(160, 130);
            this.dataGridView6.TabIndex = 4;
            // 
            // dataGridView5
            // 
            this.dataGridView5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(713, 16);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 51;
            this.dataGridView5.RowTemplate.Height = 27;
            this.dataGridView5.Size = new System.Drawing.Size(160, 130);
            this.dataGridView5.TabIndex = 3;
            // 
            // dataGridView4
            // 
            this.dataGridView4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(480, 16);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 27;
            this.dataGridView4.Size = new System.Drawing.Size(160, 130);
            this.dataGridView4.TabIndex = 2;
            // 
            // dataGridView3
            // 
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(242, 16);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 27;
            this.dataGridView3.Size = new System.Drawing.Size(160, 130);
            this.dataGridView3.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(15, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(160, 130);
            this.dataGridView2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.selectAllButton);
            this.panel4.Controls.Add(this.upDateButton);
            this.panel4.Controls.Add(this.reChoseButton);
            this.panel4.Controls.Add(this.openListButton);
            this.panel4.Location = new System.Drawing.Point(567, 83);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(376, 28);
            this.panel4.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 465);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.resourceTabControl);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.setbutton);
            this.Controls.Add(this.choseButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.resourceTabControl.ResumeLayout(false);
            this.resourceTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.previewTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button crawButton;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button choseButton;
        private System.Windows.Forms.Button setbutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox elseCheckBox;
        private System.Windows.Forms.CheckBox mediaCheckBox;
        private System.Windows.Forms.CheckBox textCheckBox;
        private System.Windows.Forms.CheckBox photoCheckBox;
        private System.Windows.Forms.Button reChoseButton;
        private System.Windows.Forms.Button selectAllButton;
        private System.Windows.Forms.Button upDateButton;
        private System.Windows.Forms.Button openListButton;
        private System.Windows.Forms.TabControl resourceTabControl;
        private System.Windows.Forms.TabPage resourceTabPage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage previewTabPage;
        private System.Windows.Forms.DataGridView dataGridView9;
        private System.Windows.Forms.DataGridView dataGridView8;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView7;
    }
}

