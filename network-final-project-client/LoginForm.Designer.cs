namespace network_final_project_client
{
    partial class LoginForm
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
            this.id = new System.Windows.Forms.TextBox();
            this.pw = new System.Windows.Forms.TextBox();
            this.loginBt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.loginBt)).BeginInit();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(110, 233);
            this.id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.id.MaxLength = 20;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(118, 25);
            this.id.TabIndex = 0;
            // 
            // pw
            // 
            this.pw.Location = new System.Drawing.Point(110, 265);
            this.pw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pw.MaxLength = 20;
            this.pw.Name = "pw";
            this.pw.Size = new System.Drawing.Size(118, 25);
            this.pw.TabIndex = 1;
            // 
            // loginBt
            // 
            this.loginBt.BackgroundImage = global::network_final_project_client.Properties.Resources.LoginButton;
            this.loginBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBt.Location = new System.Drawing.Point(234, 233);
            this.loginBt.Name = "loginBt";
            this.loginBt.Size = new System.Drawing.Size(86, 57);
            this.loginBt.TabIndex = 3;
            this.loginBt.TabStop = false;
            this.loginBt.Click += new System.EventHandler(this.LoginBt_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::network_final_project_client.Properties.Resources.LoginImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(344, 369);
            this.Controls.Add(this.loginBt);
            this.Controls.Add(this.pw);
            this.Controls.Add(this.id);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.loginBt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox pw;
        private System.Windows.Forms.PictureBox loginBt;
    }
}