namespace EAObfuscation
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelFile = new System.Windows.Forms.Label();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.buttonReference = new System.Windows.Forms.Button();
            this.labelDescription = new System.Windows.Forms.Label();
            this.listBoxTarget = new System.Windows.Forms.CheckedListBox();
            this.buttonAll = new System.Windows.Forms.Button();
            this.buttonNone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRun
            // 
            resources.ApplyResources(this.buttonRun, "buttonRun");
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // buttonClose
            // 
            resources.ApplyResources(this.buttonClose, "buttonClose");
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelFile
            // 
            resources.ApplyResources(this.labelFile, "labelFile");
            this.labelFile.Name = "labelFile";
            // 
            // textBoxFile
            // 
            resources.ApplyResources(this.textBoxFile, "textBoxFile");
            this.textBoxFile.Name = "textBoxFile";
            // 
            // buttonReference
            // 
            resources.ApplyResources(this.buttonReference, "buttonReference");
            this.buttonReference.Name = "buttonReference";
            this.buttonReference.UseVisualStyleBackColor = true;
            this.buttonReference.Click += new System.EventHandler(this.buttonReference_Click);
            // 
            // labelDescription
            // 
            resources.ApplyResources(this.labelDescription, "labelDescription");
            this.labelDescription.Name = "labelDescription";
            // 
            // listBoxTarget
            // 
            resources.ApplyResources(this.listBoxTarget, "listBoxTarget");
            this.listBoxTarget.CheckOnClick = true;
            this.listBoxTarget.FormattingEnabled = true;
            this.listBoxTarget.Name = "listBoxTarget";
            // 
            // buttonAll
            // 
            resources.ApplyResources(this.buttonAll, "buttonAll");
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.UseVisualStyleBackColor = true;
            this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // buttonNone
            // 
            resources.ApplyResources(this.buttonNone, "buttonNone");
            this.buttonNone.Name = "buttonNone";
            this.buttonNone.UseVisualStyleBackColor = true;
            this.buttonNone.Click += new System.EventHandler(this.buttonNone_Click);
            // 
            // FormMain
            // 
            this.AcceptButton = this.buttonRun;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.Controls.Add(this.buttonNone);
            this.Controls.Add(this.buttonAll);
            this.Controls.Add(this.listBoxTarget);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.buttonReference);
            this.Controls.Add(this.textBoxFile);
            this.Controls.Add(this.labelFile);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonRun);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.Button buttonReference;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.CheckedListBox listBoxTarget;
        private System.Windows.Forms.Button buttonAll;
        private System.Windows.Forms.Button buttonNone;
    }
}

