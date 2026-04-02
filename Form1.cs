namespace LoginScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 정답 정보 (실습 예시: admin & superman)
            string myID = "admin";
            string myPW = "superman";

            // 아이디와 패스워드가 모두 맞아야 로그인 성공 (&& 연산자 사용)
            if (txtID.Text == myID && txtPW.Text == myPW)
            {
                // 성공 메시지 박스 출력
                MessageBox.Show("로그인성공!", "로그인", MessageBoxButtons.OK);
            }
            else
            {
                // 실패 시: 메시지 박스 대신 라벨 표시
                MessageBox.Show("로그인실패~", "로그인", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            if (txtID.Text == "아이디") // 플레이스홀더 텍스트가 있을 때만 초기화
            {
                txtID.Text = ""; // 글자 사라짐
                txtID.ForeColor = Color.Black; // 입력 시 검정색
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                txtID.Text = "아이디";
                txtID.ForeColor = Color.Silver;
            }
        }

        private void txtPW_Enter(object sender, EventArgs e)
        {
            if (txtPW.Text == "패스워드")
            {
                txtPW.Text = "";
                txtPW.ForeColor = Color.Black;
                txtPW.UseSystemPasswordChar = true; // 입력 시작 시 마스킹 활성화

            }
        }

        private void txtPW_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPW.Text))
            {
                txtPW.UseSystemPasswordChar = false; // 힌트 표시 위해 마스킹 해제
                txtPW.Text = "패스워드";
                txtPW.ForeColor = Color.Silver;
            }
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // 기본비프음방지txtPW.Focus(); // 패스워드입력창이포커스를갖게끔}
            }
        }

        private void txtPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // 기본비프음방지btnLogin.PerformClick(); // 버튼이눌린것처럼만들기}
            }
        }
    }
}

    
