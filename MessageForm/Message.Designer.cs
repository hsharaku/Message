
namespace Message
{
    partial class MessageForm
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
            this.lb_message = new System.Windows.Forms.Label();
            this.b_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_message
            // 
            this.lb_message.AutoSize = true;
            this.lb_message.Location = new System.Drawing.Point(9, 7);
            this.lb_message.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_message.Name = "lb_message";
            this.lb_message.Size = new System.Drawing.Size(50, 12);
            this.lb_message.TabIndex = 0;
            this.lb_message.Text = "Message";
            // 
            // b_ok
            // 
            this.b_ok.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.b_ok.Location = new System.Drawing.Point(327, 159);
            this.b_ok.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.b_ok.Name = "b_ok";
            this.b_ok.Size = new System.Drawing.Size(95, 46);
            this.b_ok.TabIndex = 1;
            this.b_ok.Text = "OK";
            this.b_ok.UseVisualStyleBackColor = true;
            this.b_ok.Click += new System.EventHandler(this.b_ok_Click);
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 215);
            this.ControlBox = false;
            this.Controls.Add(this.b_ok);
            this.Controls.Add(this.lb_message);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MessageForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_message;
        private System.Windows.Forms.Button b_ok;
    }
}

