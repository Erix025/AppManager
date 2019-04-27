namespace AppManager
{
    partial class frm_Edit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Path = new System.Windows.Forms.TextBox();
            this.but_Confirm = new System.Windows.Forms.Button();
            this.but_Canel = new System.Windows.Forms.Button();
            this.but_Preview = new System.Windows.Forms.Button();
            this.ofd_Main = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "应用程序名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "程序路径";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(122, 6);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(164, 26);
            this.txt_Name.TabIndex = 0;
            // 
            // txt_Path
            // 
            this.txt_Path.Location = new System.Drawing.Point(90, 52);
            this.txt_Path.Name = "txt_Path";
            this.txt_Path.Size = new System.Drawing.Size(315, 26);
            this.txt_Path.TabIndex = 1;
            // 
            // but_Confirm
            // 
            this.but_Confirm.Location = new System.Drawing.Point(295, 95);
            this.but_Confirm.Name = "but_Confirm";
            this.but_Confirm.Size = new System.Drawing.Size(75, 29);
            this.but_Confirm.TabIndex = 2;
            this.but_Confirm.Text = "确认";
            this.but_Confirm.UseVisualStyleBackColor = true;
            this.but_Confirm.Click += new System.EventHandler(this.But_Confirm_Click);
            // 
            // but_Canel
            // 
            this.but_Canel.Location = new System.Drawing.Point(376, 95);
            this.but_Canel.Name = "but_Canel";
            this.but_Canel.Size = new System.Drawing.Size(75, 29);
            this.but_Canel.TabIndex = 2;
            this.but_Canel.Text = "取消";
            this.but_Canel.UseVisualStyleBackColor = true;
            this.but_Canel.Click += new System.EventHandler(this.But_Canel_Click);
            // 
            // but_Preview
            // 
            this.but_Preview.Location = new System.Drawing.Point(411, 50);
            this.but_Preview.Name = "but_Preview";
            this.but_Preview.Size = new System.Drawing.Size(40, 26);
            this.but_Preview.TabIndex = 3;
            this.but_Preview.Text = "...";
            this.but_Preview.UseVisualStyleBackColor = true;
            this.but_Preview.Click += new System.EventHandler(this.But_Preview_Click);
            // 
            // ofd_Main
            // 
            this.ofd_Main.Filter = "可执行文件|*.exe|所有文件|*.*";
            // 
            // frm_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 135);
            this.ControlBox = false;
            this.Controls.Add(this.but_Preview);
            this.Controls.Add(this.but_Canel);
            this.Controls.Add(this.but_Confirm);
            this.Controls.Add(this.txt_Path);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Path;
        private System.Windows.Forms.Button but_Confirm;
        private System.Windows.Forms.Button but_Canel;
        private System.Windows.Forms.Button but_Preview;
        private System.Windows.Forms.OpenFileDialog ofd_Main;
    }
}