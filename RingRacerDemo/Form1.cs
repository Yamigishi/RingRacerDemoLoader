namespace RingRacerDemo
{
    public partial class RingRacerDemoLoader : Form
    {
        public RingRacerDemoLoader()
        {
            InitializeComponent();
        }

        private void DragDropPanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void DragDropPanel_DragDrop(object sender, DragEventArgs e)
        {
            string[] filesPath = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            ReadFile(filesPath[0]);
        }

        private void DragDropPanel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.Filter = "Replay files (*.lmp)|*.lmp";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string selectedFileName = openFileDialog1.FileName;
            ReadFile(selectedFileName);
        }

        private void ReadFile(string fileName)
        {
            byte[] fileAsBytes = File.ReadAllBytes(fileName);
            string selectedExePath = "";
            string args = additionalArgs.Text + " -playdemo " + "\"" + fileName + "\"";
            if (fileAsBytes.Length <= 12)
            {
                MessageBox.Show("The selected file isn't a valid replay file", "File is invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (fileAsBytes[12] == 2)
            {
                switch (fileAsBytes[13])
                {
                    case 0:
                        selectedExePath = version2_0_exe.Text;
                        break;
                    case 1:
                        selectedExePath = version2_1_exe.Text;
                        break;
                    case 2:
                        selectedExePath = version2_2_exe.Text;
                        break;
                    case 3:
                        selectedExePath = version2_3_exe.Text;
                        break;
                    default:
                        MessageBox.Show("The selected file version isn't supported", "Version is unsupported", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }
            } else
            {
                MessageBox.Show("The selected file version isn't supported", "Version is unsupported", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var proc = System.Diagnostics.Process.Start(selectedExePath, args);
        }

        private void RingRacerDemoLoader_Load(object sender, EventArgs e)
        {
            if (File.Exists(Directory.GetCurrentDirectory() + "/.config.txt"))
            {
                string[] configFile = File.ReadAllLines(Directory.GetCurrentDirectory() + "/.config.txt");
                version2_0_exe.Text = configFile[0];
                version2_1_exe.Text = configFile[1];
                version2_2_exe.Text = configFile[2];
                version2_3_exe.Text = configFile[3];
            }
            else
            {
                FileStream file = File.Create(Directory.GetCurrentDirectory() + "/.config.txt");
                String placeholderString = Directory.GetCurrentDirectory() + "/sonic.exe";
                StreamWriter writer = new StreamWriter(file);
                writer.Write(placeholderString + "\n" + placeholderString + "\n" + placeholderString + "\n" + placeholderString);
                version2_0_exe.Text = placeholderString;
                version2_1_exe.Text = placeholderString;
                version2_2_exe.Text = placeholderString;
                version2_3_exe.Text = placeholderString;
                writer.Close();
            }
        }

        private void version2_0_exe_Click(object sender, EventArgs e)
        {
            SelectExe(version2_0_exe, 0);
        }

        private void version2_1_exe_Click(object sender, EventArgs e)
        {
            SelectExe(version2_1_exe, 1);
        }

        private void version2_2_exe_Click(object sender, EventArgs e)
        {
            SelectExe(version2_2_exe, 2);
        }

        private void version2_3_exe_Click(object sender, EventArgs e)
        {
            SelectExe(version2_3_exe, 3);
        }

        private void SelectExe(TextBox versionTextBox, int version)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.Filter = "Exe file (*.exe)|*.exe";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string selectedFileName = openFileDialog1.FileName;
            versionTextBox.Text = selectedFileName;
            // replaces exe path in config file
            string[] arrLine = File.ReadAllLines(Directory.GetCurrentDirectory() + "/.config.txt");
            arrLine[version] = selectedFileName;
            File.WriteAllLines(Directory.GetCurrentDirectory() + "/.config.txt", arrLine);
        }
    }
}
