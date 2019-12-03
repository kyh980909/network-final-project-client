namespace network_final_project_client
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.chat = new System.Windows.Forms.TextBox();
            this.input = new System.Windows.Forms.TextBox();
            this.sendBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chat
            // 
            this.chat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.chat.Location = new System.Drawing.Point(13, 13);
            this.chat.Multiline = true;
            this.chat.Name = "chat";
            this.chat.ReadOnly = true;
            this.chat.Size = new System.Drawing.Size(775, 398);
            this.chat.TabIndex = 0;
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(13, 417);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(683, 21);
            this.input.TabIndex = 1;
            // 
            // sendBt
            // 
            this.sendBt.Location = new System.Drawing.Point(702, 415);
            this.sendBt.Name = "sendBt";
            this.sendBt.Size = new System.Drawing.Size(86, 23);
            this.sendBt.TabIndex = 2;
            this.sendBt.Text = "전송";
            this.sendBt.UseVisualStyleBackColor = true;
            this.sendBt.Click += new System.EventHandler(this.OnSendData);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sendBt);
            this.Controls.Add(this.input);
            this.Controls.Add(this.chat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
            this.Load += new System.EventHandler(this.OnFormLoaded);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox chat;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button sendBt;
    }
}

