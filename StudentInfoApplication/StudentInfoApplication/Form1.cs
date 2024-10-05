namespace StudentInfoApplication
{
    public partial class frmStudentInfo : Form
    {
        public frmStudentInfo()
        {
            InitializeComponent();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String StudentId = textBox1.Text;
            String lname = textBox2.Text;
            String fname = textBox3.Text;

            StudentInfo student = new StudentInfo(fname, lname, StudentId);

            StudentIDList.Items.Add(student.StudID);
            FirstnameList.Items.Add(student.FirstName); 
            LastnameList.Items.Add (student.LastName);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }
    }
}
