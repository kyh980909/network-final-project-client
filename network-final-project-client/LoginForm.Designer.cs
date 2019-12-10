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
            this.LoginBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(98, 189);
            this.id.MaxLength = 20;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(104, 21);
            this.id.TabIndex = 0;
            // 
            // pw
            // 
            this.pw.Location = new System.Drawing.Point(98, 214);
            this.pw.MaxLength = 20;
            this.pw.Name = "pw";
            this.pw.Size = new System.Drawing.Size(104, 21);
            this.pw.TabIndex = 1;
            // 
            // LoginBt
            // 
            this.LoginBt.Image = global::network_final_project_client.Properties.Resources.LoginButton;
            this.LoginBt.Location = new System.Drawing.Point(206, 187);
            this.LoginBt.Name = "LoginBt";
            this.LoginBt.Size = new System.Drawing.Size(80, 46);
            this.LoginBt.TabIndex = 2;
            this.LoginBt.UseVisualStyleBackColor = true;
            this.LoginBt.Click += new System.EventHandler(this.LoginBt_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::network_final_project_client.Properties.Resources.LoginImage;
            this.ClientSize = new System.Drawing.Size(301, 295);
            this.Controls.Add(this.LoginBt);
            this.Controls.Add(this.pw);
            this.Controls.Add(this.id);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox pw;
        private System.Windows.Forms.Button LoginBt;
    }
}