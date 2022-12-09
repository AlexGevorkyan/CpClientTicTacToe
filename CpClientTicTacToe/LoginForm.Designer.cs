namespace CpClientTicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxPort = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxIpAddress = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pbEmpty = new System.Windows.Forms.PictureBox();
            this.btSelectEmpty = new System.Windows.Forms.Button();
            this.pbCircle = new System.Windows.Forms.PictureBox();
            this.pbCross = new System.Windows.Forms.PictureBox();
            this.btSelectCircle = new System.Windows.Forms.Button();
            this.btSelectCross = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCross)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "User name:";
            // 
            // tbxUserName
            // 
            this.tbxUserName.Location = new System.Drawing.Point(107, 15);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(400, 29);
            this.tbxUserName.TabIndex = 1;
            this.tbxUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(27, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Port:";
            // 
            // tbxPort
            // 
            this.tbxPort.Location = new System.Drawing.Point(148, 59);
            this.tbxPort.Name = "tbxPort";
            this.tbxPort.Size = new System.Drawing.Size(400, 29);
            this.tbxPort.TabIndex = 1;
            this.tbxPort.Text = "8888";
            this.tbxPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(575, 297);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 38);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLogin.Location = new System.Drawing.Point(488, 297);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(81, 38);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(27, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ip address:";
            // 
            // tbxIpAddress
            // 
            this.tbxIpAddress.Location = new System.Drawing.Point(148, 18);
            this.tbxIpAddress.Name = "tbxIpAddress";
            this.tbxIpAddress.Size = new System.Drawing.Size(400, 29);
            this.tbxIpAddress.TabIndex = 1;
            this.tbxIpAddress.Text = "127.0.0.1";
            this.tbxIpAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(672, 377);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pbEmpty);
            this.tabPage1.Controls.Add(this.btSelectEmpty);
            this.tabPage1.Controls.Add(this.pbCircle);
            this.tabPage1.Controls.Add(this.pbCross);
            this.tabPage1.Controls.Add(this.btSelectCircle);
            this.tabPage1.Controls.Add(this.btSelectCross);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnLogin);
            this.tabPage1.Controls.Add(this.btnCancel);
            this.tabPage1.Controls.Add(this.tbxUserName);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(664, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Login";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pbEmpty
            // 
            this.pbEmpty.Image = ((System.Drawing.Image)(resources.GetObject("pbEmpty.Image")));
            this.pbEmpty.Location = new System.Drawing.Point(269, 68);
            this.pbEmpty.Name = "pbEmpty";
            this.pbEmpty.Size = new System.Drawing.Size(100, 100);
            this.pbEmpty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEmpty.TabIndex = 8;
            this.pbEmpty.TabStop = false;
            // 
            // btSelectEmpty
            // 
            this.btSelectEmpty.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btSelectEmpty.Location = new System.Drawing.Point(269, 174);
            this.btSelectEmpty.Name = "btSelectEmpty";
            this.btSelectEmpty.Size = new System.Drawing.Size(100, 29);
            this.btSelectEmpty.TabIndex = 7;
            this.btSelectEmpty.Text = "Select Empty";
            this.btSelectEmpty.UseVisualStyleBackColor = true;
            this.btSelectEmpty.Click += new System.EventHandler(this.btSelectEmpty_Click);
            // 
            // pbCircle
            // 
            this.pbCircle.Image = ((System.Drawing.Image)(resources.GetObject("pbCircle.Image")));
            this.pbCircle.Location = new System.Drawing.Point(150, 68);
            this.pbCircle.Name = "pbCircle";
            this.pbCircle.Size = new System.Drawing.Size(100, 100);
            this.pbCircle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCircle.TabIndex = 6;
            this.pbCircle.TabStop = false;
            // 
            // pbCross
            // 
            this.pbCross.Image = ((System.Drawing.Image)(resources.GetObject("pbCross.Image")));
            this.pbCross.Location = new System.Drawing.Point(34, 68);
            this.pbCross.Name = "pbCross";
            this.pbCross.Size = new System.Drawing.Size(100, 100);
            this.pbCross.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCross.TabIndex = 5;
            this.pbCross.TabStop = false;
            // 
            // btSelectCircle
            // 
            this.btSelectCircle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btSelectCircle.Location = new System.Drawing.Point(150, 174);
            this.btSelectCircle.Name = "btSelectCircle";
            this.btSelectCircle.Size = new System.Drawing.Size(100, 29);
            this.btSelectCircle.TabIndex = 4;
            this.btSelectCircle.Text = "Select Circle";
            this.btSelectCircle.UseVisualStyleBackColor = true;
            this.btSelectCircle.Click += new System.EventHandler(this.btSelectCircle_Click);
            // 
            // btSelectCross
            // 
            this.btSelectCross.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btSelectCross.Location = new System.Drawing.Point(34, 174);
            this.btSelectCross.Name = "btSelectCross";
            this.btSelectCross.Size = new System.Drawing.Size(100, 29);
            this.btSelectCross.TabIndex = 3;
            this.btSelectCross.Text = "Select Cross";
            this.btSelectCross.UseVisualStyleBackColor = true;
            this.btSelectCross.Click += new System.EventHandler(this.btSelectCross_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.tbxPort);
            this.tabPage2.Controls.Add(this.tbxIpAddress);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(664, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 377);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(324, 203);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCross)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxPort;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxIpAddress;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pbEmpty;
        private System.Windows.Forms.Button btSelectEmpty;
        private System.Windows.Forms.PictureBox pbCircle;
        private System.Windows.Forms.PictureBox pbCross;
        private System.Windows.Forms.Button btSelectCircle;
        private System.Windows.Forms.Button btSelectCross;
        private System.Windows.Forms.TabPage tabPage2;
    }
}