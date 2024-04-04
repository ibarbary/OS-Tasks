namespace fileManipulation
{
    public partial class Form1 : Form
    {
        string path = "D:\\C#";

        public Form1()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            string fileName = nameTextBox.Text;
            string filePath = Path.Combine(path, fileName + ".txt");

            if (fileName == "")
            {
                MessageBox.Show("Please provide a file name");
            }
            else if(File.Exists(filePath))
            {
                MessageBox.Show("File already exists");
            }
            else
            {
                using (File.Create(filePath))

                MessageBox.Show("File created successfully");
                MessageBox.Show(File.ReadAllText(filePath));
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string fileName = nameTextBox.Text;
            string filePath = Path.Combine(path, fileName + ".txt");

            if (fileName == "")
            {
                MessageBox.Show("Please provide a file name");
            }
            else if (!File.Exists(filePath))
            {
                MessageBox.Show("File doesn't exist");
            }
            else
            {
                File.Delete(filePath);

                MessageBox.Show("File deleted successfully");
            }
        }
    }
}