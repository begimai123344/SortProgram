namespace SortProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void Button_Click(object sender, EventArgs e)
        {
            // �������� ��������� ������ �����
            Form2 form2 = new Form2();

            // �������� ������ ����� � ������� ������� ����� (Form1)
            form2.Show();
            this.Hide();

            // ��� ���� ����� ������� ������� �����, �� ������ ������������ form2.FormClosed ������� �� Form2
            form2.FormClosed += (s, args) => this.Close();
        }
        private void Button_Click1(object sender, EventArgs e)
        {
            
            Form3 form3 = new Form3();

            
            form3.Show();
            this.Hide();

            
            form3.FormClosed += (s, args) => this.Close();
        }
        private void Button_Click2(object sender, EventArgs e)
        {
            // �������� ��������� ������ �����
            Form4 form4 = new Form4();

            // �������� ������ ����� � ������� ������� ����� (Form1)
            form4.Show();
            this.Hide();

            // ��� ���� ����� ������� ������� �����, �� ������ ������������ form2.FormClosed ������� �� Form2
            form4.FormClosed += (s, args) => this.Close();
        }
        private void Button_Click3(object sender, EventArgs e)
        {
            // �������� ��������� ������ �����
            Form5 form5 = new Form5();

            // �������� ������ ����� � ������� ������� ����� (Form1)
            form5.Show();
            this.Hide();

            // ��� ���� ����� ������� ������� �����, �� ������ ������������ form2.FormClosed ������� �� Form2
            form5.FormClosed += (s, args) => this.Close();
        }


    }
}