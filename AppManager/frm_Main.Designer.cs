namespace AppManager
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.lst_Apps = new System.Windows.Forms.ListBox();
            this.gb_ControlBox = new System.Windows.Forms.GroupBox();
            this.but_OpenApp = new System.Windows.Forms.Button();
            this.but_EditApp = new System.Windows.Forms.Button();
            this.but_DeleteApp = new System.Windows.Forms.Button();
            this.but_AddApp = new System.Windows.Forms.Button();
            this.gb_ControlBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lst_Apps
            // 
            this.lst_Apps.FormattingEnabled = true;
            this.lst_Apps.ItemHeight = 16;
            this.lst_Apps.Location = new System.Drawing.Point(13, 13);
            this.lst_Apps.Margin = new System.Windows.Forms.Padding(4);
            this.lst_Apps.Name = "lst_Apps";
            this.lst_Apps.Size = new System.Drawing.Size(191, 452);
            this.lst_Apps.TabIndex = 0;
            this.lst_Apps.SelectedIndexChanged += new System.EventHandler(this.Lst_Apps_SelectedIndexChanged);
            // 
            // gb_ControlBox
            // 
            this.gb_ControlBox.Controls.Add(this.but_OpenApp);
            this.gb_ControlBox.Controls.Add(this.but_EditApp);
            this.gb_ControlBox.Controls.Add(this.but_DeleteApp);
            this.gb_ControlBox.Controls.Add(this.but_AddApp);
            this.gb_ControlBox.Location = new System.Drawing.Point(211, 13);
            this.gb_ControlBox.Name = "gb_ControlBox";
            this.gb_ControlBox.Size = new System.Drawing.Size(139, 452);
            this.gb_ControlBox.TabIndex = 1;
            this.gb_ControlBox.TabStop = false;
            this.gb_ControlBox.Text = "操作栏";
            // 
            // but_OpenApp
            // 
            this.but_OpenApp.Enabled = false;
            this.but_OpenApp.Location = new System.Drawing.Point(20, 25);
            this.but_OpenApp.Name = "but_OpenApp";
            this.but_OpenApp.Size = new System.Drawing.Size(99, 32);
            this.but_OpenApp.TabIndex = 0;
            this.but_OpenApp.Text = "打开应用";
            this.but_OpenApp.UseVisualStyleBackColor = true;
            this.but_OpenApp.Click += new System.EventHandler(this.But_OpenApp_Click);
            // 
            // but_EditApp
            // 
            this.but_EditApp.Enabled = false;
            this.but_EditApp.Location = new System.Drawing.Point(20, 101);
            this.but_EditApp.Name = "but_EditApp";
            this.but_EditApp.Size = new System.Drawing.Size(99, 32);
            this.but_EditApp.TabIndex = 0;
            this.but_EditApp.Text = "编辑应用";
            this.but_EditApp.UseVisualStyleBackColor = true;
            this.but_EditApp.Click += new System.EventHandler(this.But_EditApp_Click);
            // 
            // but_DeleteApp
            // 
            this.but_DeleteApp.Enabled = false;
            this.but_DeleteApp.Location = new System.Drawing.Point(20, 63);
            this.but_DeleteApp.Name = "but_DeleteApp";
            this.but_DeleteApp.Size = new System.Drawing.Size(99, 32);
            this.but_DeleteApp.TabIndex = 0;
            this.but_DeleteApp.Text = "删除应用";
            this.but_DeleteApp.UseVisualStyleBackColor = true;
            this.but_DeleteApp.Click += new System.EventHandler(this.But_DeleteApp_Click);
            // 
            // but_AddApp
            // 
            this.but_AddApp.Location = new System.Drawing.Point(20, 139);
            this.but_AddApp.Name = "but_AddApp";
            this.but_AddApp.Size = new System.Drawing.Size(99, 32);
            this.but_AddApp.TabIndex = 0;
            this.but_AddApp.Text = "添加应用";
            this.but_AddApp.UseVisualStyleBackColor = true;
            this.but_AddApp.Click += new System.EventHandler(this.But_AddApp_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 487);
            this.Controls.Add(this.gb_ControlBox);
            this.Controls.Add(this.lst_Apps);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_Main";
            this.Text = "应用程序管理器";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.Resize += new System.EventHandler(this.Frm_Main_Resize);
            this.gb_ControlBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst_Apps;
        private System.Windows.Forms.GroupBox gb_ControlBox;
        private System.Windows.Forms.Button but_OpenApp;
        private System.Windows.Forms.Button but_EditApp;
        private System.Windows.Forms.Button but_DeleteApp;
        private System.Windows.Forms.Button but_AddApp;
    }
}

