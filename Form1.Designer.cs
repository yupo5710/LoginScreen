namespace LoginScreen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAppName = new Label();
            txtID = new TextBox();
            txtPW = new TextBox();
            btnLogin = new Button();
            lblErrorMsg = new Label();
            chkShowPW = new CheckBox();
            btnClearAll = new Button();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("맑은 고딕", 24F, FontStyle.Bold);
            lblAppName.Location = new Point(269, 32);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(207, 86);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Login";
            // 
            // txtID
            // 
            txtID.Font = new Font("맑은 고딕", 13.875F);
            txtID.ForeColor = Color.FromArgb(224, 224, 224);
            txtID.Location = new Point(226, 171);
            txtID.Name = "txtID";
            txtID.Size = new Size(324, 57);
            txtID.TabIndex = 2;
            txtID.Text = "아이디";
            txtID.Enter += txtID_Enter;
            txtID.KeyDown += txtID_KeyDown;
            txtID.Leave += txtID_Leave;
            // 
            // txtPW
            // 
            txtPW.Font = new Font("맑은 고딕", 13.875F);
            txtPW.ForeColor = Color.FromArgb(224, 224, 224);
            txtPW.Location = new Point(226, 261);
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(324, 57);
            txtPW.TabIndex = 3;
            txtPW.Text = "패스워드";
            txtPW.Enter += txtPW_Enter;
            txtPW.KeyDown += txtPW_KeyDown;
            txtPW.Leave += txtPW_Leave;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(288, 401);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(188, 76);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblErrorMsg
            // 
            lblErrorMsg.AutoSize = true;
            lblErrorMsg.ForeColor = Color.Red;
            lblErrorMsg.Location = new Point(166, 347);
            lblErrorMsg.Name = "lblErrorMsg";
            lblErrorMsg.Size = new Size(451, 32);
            lblErrorMsg.TabIndex = 4;
            lblErrorMsg.Text = "아이디 또는 비밀번호가 잘못되었습니다.";
            // 
            // chkShowPW
            // 
            chkShowPW.AutoSize = true;
            chkShowPW.Location = new Point(508, 278);
            chkShowPW.Name = "chkShowPW";
            chkShowPW.Size = new Size(28, 27);
            chkShowPW.TabIndex = 5;
            chkShowPW.UseVisualStyleBackColor = true;
            chkShowPW.CheckedChanged += chkShowPW_CheckedChanged;
            // 
            // btnClearAll
            // 
            btnClearAll.Location = new Point(550, 119);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(150, 46);
            btnClearAll.TabIndex = 6;
            btnClearAll.Text = "Clear ALL";
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 511);
            Controls.Add(btnClearAll);
            Controls.Add(chkShowPW);
            Controls.Add(lblErrorMsg);
            Controls.Add(btnLogin);
            Controls.Add(txtPW);
            Controls.Add(txtID);
            Controls.Add(lblAppName);
            Name = "Form1";
            Text = "Login Screen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private TextBox txtID;
        private TextBox txtPW;
        private Button btnLogin;
        private Label lblErrorMsg;
        private CheckBox chkShowPW;
        private Button btnClearAll;
    }
}
