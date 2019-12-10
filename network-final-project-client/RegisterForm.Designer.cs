namespace network_final_project_client
{
    partial class RegisterForm
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
            this.registerBt = new System.Windows.Forms.PictureBox();
            this.pw = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.registerBt)).BeginInit();
            this.SuspendLayout();
            // 
            // registerBt
            // 
            this.registerBt.BackgroundImage = global::network_final_project_client.Properties.Resources.LoginButton;
            this.registerBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.registerBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerBt.Location = new System.Drawing.Point(235, 233);
            this.registerBt.Name = "registerBt";
            this.registerBt.Size = new System.Drawing.Size(86, 57);
            this.registerBt.TabIndex = 6;
            this.registerBt.TabStop = false;
            this.registerBt.Click += new System.EventHandler(this.RegisterBt_Click);
            // 
            // pw
            // 
            this.pw.Location = new System.Drawing.Point(111, 265);
            this.pw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pw.MaxLength = 20;
            this.pw.Name = "pw";
            this.pw.PasswordChar = '*';
            this.pw.Size = new System.Drawing.Size(118, 25);
            this.pw.TabIndex = 5;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(111, 233);
            this.id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.id.MaxLength = 20;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(118, 25);
            this.id.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 10F);
            this.label1.Location = new System.Drawing.Point(239, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "회원가입";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Location = new System.Drawing.Point(212, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "로그인";
            this.label2.Click += new System.EventHandler(this.LoginBt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "계정이 있으신가요?";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::network_final_project_client.Properties.Resources.LoginImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(344, 369);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registerBt);
            this.Controls.Add(this.pw);
            this.Controls.Add(this.id);
            this.Name = "RegisterForm";
            this.Text = "회원가입";
            ((System.ComponentModel.ISupportInitialize)(this.registerBt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox registerBt;
        private System.Windows.Forms.TextBox pw;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}