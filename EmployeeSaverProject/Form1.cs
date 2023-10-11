namespace EmployeeSaverProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string folderWay;
        private void btnChoosePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Jpg (.jpg)|*.jpg|Png (.png)|*.png";
            ofd.ShowDialog();
            folderWay = ofd.FileName;
            pictureBox1.ImageLocation = folderWay;
        }

        List<Employee> workers = new List<Employee>();
        private void btnSave_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Id = int.Parse(txtEmpId.Text);
            employee.Name = txtName.Text;
            employee.Surname = txtSurname.Text;
            employee.BirthDate = dtpBirthDate.Value;
            employee.PhoneNumber = mtxtPhone.Text;
            employee.Email = txtEmail.Text;
            employee.Address = rtxtAddress.Text;
            employee.StartingToWorkDate = dtpWorkStart.Value;
            employee.PictureFolderWay = pictureBox1.ImageLocation;
            bool situation = CheckInputAndShowMessage(employee.Id, employee.Email,
                employee.BirthDate, employee.StartingToWorkDate);
            if (situation == true)
            {

            }
            else
            {
                workers.Add(employee);
            }
            FillTheListView();
        }

        private void FillTheListView()
        {
            lvEmployee.Items.Clear();
            foreach (Employee employee in workers)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = employee.Id.ToString();
                lvi.SubItems.Add(employee.Name);
                lvi.SubItems.Add(employee.Surname);
                lvi.SubItems.Add(employee.BirthDate.ToString());
                lvi.SubItems.Add(employee.PhoneNumber);
                lvi.SubItems.Add(employee.Email);
                lvi.SubItems.Add(employee.PictureFolderWay);

                lvEmployee.Items.Add(lvi);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "D:\\EmpSavPic\\defaultpic.png";
        }

        private bool CheckEmployeeIdLength(int id)
        {
            string tempId = id.ToString();
            if (tempId.Length < 5) return true;
            else return false;
        }

        private bool CheckEmailConcept(string email)
        {
            if (!email.EndsWith("@gmail.com")) return true;
            else return false;
        }

        private bool CheckIsAgeUnder18(DateTime date1)
        {
            int age = DateTime.Now.Year - date1.Year;
            if (age < 18) return true;
            else return false;
        }

        private bool CheckIsStartOfWorkDateValid(DateTime date2)
        {
            if (date2 > DateTime.Now) return true;
            else return false;
        }

        private bool CheckInputAndShowMessage(int employeeId, string email, DateTime date1, DateTime date2)
        {
            bool isInvalidId = CheckEmployeeIdLength(employeeId);
            bool isInvalidEmail = CheckEmailConcept(email);
            bool isUnder18 = CheckIsAgeUnder18(date1);
            bool isInvalidStartDate = CheckIsStartOfWorkDateValid(date2);

            if (isInvalidId)
            {
                MessageBox.Show("Geçersiz çalisan ID. ID uzunlugu en az 5 olmalidir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (isInvalidEmail)
            {
                MessageBox.Show("Geçersiz e-mail adresi. E-posta adresi '@gmail.com' ile bitmelidir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (isUnder18)
            {
                MessageBox.Show("Hatali dogum tarihi seçtiniz. Çalisan kisinin yasi 18'den buyuk olmalidir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (isInvalidStartDate)
            {
                MessageBox.Show("Geçersiz baslangiç tarihi seçtiniz. Gelecek zaman diliminden seçim yapiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (isInvalidId || isInvalidEmail || isUnder18 || isInvalidStartDate)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
}