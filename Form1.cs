using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Renci.SshNet;


namespace appTest
{
    public partial class Form1 : Form
    {
        private List<string> filePaths = new List<string>();
        private List<string> encryptedfilesPaths = new List<string>();

        private SymmetricAlgorithm algorithm;
        private byte[] manualOrGenearatedKey;
        private byte[] manualOrGenearatedIV;

        private string algoParamFileName;

        public Form1()
        {
            InitializeComponent();
            comboBoxAlgorithm.Items.AddRange(new string[] { "AES", "DES" });
            comboBoxAlgorithm.SelectedIndex = 0;
        }

        // >>> Files Handle >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> FilesHandle
        private void btnSelectFiles_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "Text|*.txt|All|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePaths.AddRange(openFileDialog.FileNames);
                    
                    //Log("Selected files: " + string.Join(", ", openFileDialog.FileNames));
                    //listBoxFiles.Items.Add("Selected files: " + string.Join(", ", openFileDialog.FileNames));
                    foreach (string file in openFileDialog.FileNames)
                    {
                        listBoxFiles.Items.Add(file);
                        //FileTxt(file);
                        //FileHandle(file);
                    }
                }
            }
        }
        private void btnSelectEncryptedFiles_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "Text|*.txt|All|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    encryptedfilesPaths.AddRange(openFileDialog.FileNames);

                    foreach (string file in openFileDialog.FileNames)
                    {
                        listBoxEncryptedFiles.Items.Add(file);
                    }
                }
            }
        }
        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string[] files = Directory.GetFiles(folderBrowserDialog.SelectedPath, "*.txt",SearchOption.AllDirectories);// AllDirectories czy TopDirectoryOnly
                    filePaths.AddRange(files);
                    //Log("Selected folder: " + folderBrowserDialog.SelectedPath);

                    foreach (string file in files)
                    {
                        listBoxFiles.Items.Add(file);
                    }
                }
            }
        }
        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(listBoxFiles);
            selectedItems = listBoxFiles.SelectedItems;

            if (listBoxFiles.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                { 
                    listBoxFiles.Items.Remove(selectedItems[i]);
                    filePaths.RemoveAt(i);
                }
            }
            else
            { 
                MessageBox.Show("wybierz elementy z listy");
            } 
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            listBoxFiles.Items.Clear();
            filePaths.Clear();
        }
        private void FileHandle(string filePath)
        {
            try
            {
                string prefix = "_Encrypted";
                string newFileName = Path.Combine(Path.GetDirectoryName(filePath), (prefix + Path.GetFileName(filePath)));
                //File.Copy(filePath, newFileName);

                using (FileStream sourceStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                  using (FileStream destinationStream = new FileStream(newFileName, FileMode.Create, FileAccess.Write))
                    {
                        byte[] buffer = new byte[4096];
                        int bytesRead;

                        while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            destinationStream.Write(buffer, 0, bytesRead);
                        }
                       
                    }
                }
            }
            catch (FileNotFoundException)
            {
                textBox_fileTxt.Text = "Plik nie został znaleziony.";
            }
            catch (Exception ex)
            {
                textBox_fileTxt.Text = ex.Message;
            }
        }
        private string FileTxt(string filePath)
        {
            //string filePath = "C:/Users/Daniel-/source/repos/dotNet_lab1/tekst.txt";
            string prefix = "Encrypted_";
            string newFileName = Path.Combine(Path.GetDirectoryName(filePath), (prefix + Path.GetFileName(filePath)));

            try
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader streamReader = new StreamReader(fileStream))
                    {
                        string content = streamReader.ReadToEnd();
                        textBox_fileTxt.Text = content;

                        //File.WriteAllText(newFileName, content);
                        return newFileName;
                    }
                }
            }
            catch (FileNotFoundException)
            {
                textBox_fileTxt.Text = "Plik nie został znaleziony.";
                return "Plik nie został znaleziony.";
            }
            catch (Exception ex)
            {
                textBox_fileTxt.Text = ex.Message;
                return ex.Message;
            }
        }
        void listBoxFiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBoxFiles.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                //MessageBox.Show(index.ToString());
                //MessageBox.Show(listBoxFiles.GetItemText(listBoxFiles.SelectedItem));
                FileTxt(listBoxFiles.GetItemText(listBoxFiles.SelectedItem));
            }
        }

        // <<< Files Handle <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< FilesHandle

        //>>> AllFile >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> AllFile
        private void btnTest_Click(object sender, EventArgs e)
        {
            /* foreach (var f in filePaths)
             {
                 txtLog.AppendText(f);
             }*/

            //---
            /*  foreach (string filePath in encryptedfilesPaths)
              {
                  Log($"Elementy w liście encryptedfilesPaths : {filePath}");
              }*/
            //---
            /*string path = Path.GetFileName(filePaths.First());
            int pFrom = path.IndexOf("Encrypted_") + "Encrypted_".Length;
            int pTo = path.LastIndexOf("_dot");
            string result = path.Substring(pFrom, pTo - pFrom);
            Log($"Elementy w liście encryptedfilesPaths : {result}");*/
            //---
            
            //DecryptAll();


        }
        private void EncryptAllFiles_Click(object sender, EventArgs e)
        {
            EncryptAll();
            
        }
        private void btnDecryptAll_Click(object sender, EventArgs e)
        {
            DecryptAll();
        }
        private string FileContent(string filePath)
        {
            try
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader streamReader = new StreamReader(fileStream))
                    {
                        string content = streamReader.ReadToEnd();
                        return content;
                    }
                }
            }
            catch (FileNotFoundException)
            {
                textBox_fileTxt.Text = "Plik nie został znaleziony.";
                return "Plik nie został znaleziony";
            }
            catch (Exception ex)
            {
                textBox_fileTxt.Text = ex.Message;
                return ex.Message;
            }
        }
        private void EncryptAll()
        {
            encryptedfilesPaths.Clear();

            if (textBoxKey.Text == "" || textBoxIV.Text == "" || textBoxAlgoPrefix.Text == "" 
                || scpHost.Text == "Host" || scpUsername.Text == "" || scpPassword.Text == "" || scpRemotePath.Text == "")
            {
                MessageBox.Show("Proszę wygeneruj Klucze, sufix oraz parametry do wysyłki");
                return;
            }

            string prefix = "Encrypted_";
            string algoPrefix = textBoxAlgoPrefix.Text;

            foreach (string filePath in filePaths)
            {
                string content = FileContent(filePath);
                byte[] encryptedContent = EncryptStringToBytes(content, manualOrGenearatedKey, manualOrGenearatedIV);
                
                string newfilePath = Path.Combine(Path.GetDirectoryName(filePath), (prefix + algoPrefix + "_" + Path.GetFileName(filePath)));
                content = BitConverter.ToString(encryptedContent).Replace("-", "");
                
                File.WriteAllText(newfilePath, content);

                encryptedfilesPaths.Add(newfilePath);
                listBoxEncryptedFiles.Items.Add(newfilePath);

                //string encryptedFilePath = filePath + ".enc";
                //File.WriteAllBytes(encryptedFilePath, encryptedContent);


                Log($"Encrypted: {filePath} -> {newfilePath}");
            }
            SCPUpload(); 
        }
        private void DecryptAll()
        {
            //filePaths.Clear();
            

            if (textBoxKey.Text == "" || textBoxIV.Text == "" || textBoxAlgoPrefix.Text == "")
            {
                MessageBox.Show("Proszę wgraj Klucze");
                return;
            }

            string prefix = "Dencrypted_";

            foreach (string filePath in encryptedfilesPaths)
            {
                string content = FileContent(filePath);

                byte[] encryptedBytes = StringToByteArray(content);
                string decryptedText = DecryptStringFromBytes(encryptedBytes, manualOrGenearatedKey, manualOrGenearatedIV);

                string newfilePath = Path.Combine(Path.GetDirectoryName(filePath), (prefix + Path.GetFileName(filePath)));
                File.WriteAllText(newfilePath, decryptedText);

                filePaths.Add(newfilePath);
                listBoxFiles.Items.Add(newfilePath);

                Log($"Encrypted: {filePath} -> {newfilePath}");
            }
        }

        private void SCPUpload()
        {
            Task.Run(() => UploadFiles());
        }
        private async Task UploadFiles()
        {
            foreach (string filePath in encryptedfilesPaths)
            {
                try
                {
                    
                    string remotefilePath = Path.Combine(scpRemotePath.Text, (Path.GetFileName(filePath)));
                    await UploadFile(scpHost.Text, scpUsername.Text, scpPassword.Text, filePath, remotefilePath);
                    Log($"Uploaded: {remotefilePath}");

                    //listBoxEncryptedFiles.Items.Remove(filePath);
                    
                }
                catch (Exception ex)
                {
                    Log($"Error uploading file {filePath}: {ex.Message}");
                }
            }
            
        }
        private async Task UploadFile(string host, string username, string password, string localFilePath, string remotePath)
        {
            using (var scp = new ScpClient(host, username, password))
            {
                scp.Connect();
                scp.Upload(new FileInfo(localFilePath), remotePath);
                scp.Disconnect();
            }
        }
        private void Log(string message)
        {
            if (txtLog.InvokeRequired)
            {
                txtLog.Invoke(new Action<string>(Log), message);
            }
            else
            {
                txtLog.AppendText(message + Environment.NewLine);
            }
        }

        // <<< AllFile <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< AllFile

        // >>> SymmetricAlgorithm >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> SymmetricAlgorithm
        private SymmetricAlgorithm GetAlgorithm()
        {
            switch (comboBoxAlgorithm.SelectedItem.ToString())
            {
                case "AES":
                    return Aes.Create();
                case "DES":
                    return DES.Create();
                default:
                    throw new NotImplementedException();
            }
        }
        private void GenerateKeys()
        {
            algorithm = GetAlgorithm();
            algorithm.GenerateKey();
            algorithm.GenerateIV();

            textBoxKey.Text = BitConverter.ToString(algorithm.Key).Replace("-", "");//---ok
            textBoxIV.Text = BitConverter.ToString(algorithm.IV).Replace("-", "");//---ok

            manualOrGenearatedKey = algorithm.Key;
            manualOrGenearatedIV = algorithm.IV;
        }
        private void buttonGenerateKeys_Click(object sender, EventArgs e)
        {
            GenerateKeys();
        }
        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            //if (algorithm == null)
            if (textBoxKey.Text == "" || textBoxIV.Text == "")
            {
                MessageBox.Show("Proszę wygeneruj Klucze.");
                return;
            }

            string plainText = textBox_fileTxt.Text;
            byte[] encryptedBytes = EncryptStringToBytes(plainText, manualOrGenearatedKey, manualOrGenearatedIV);

            textBox_fileEncryptTxt.Text = BitConverter.ToString(encryptedBytes).Replace("-", "");



        }
        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            //if (algorithm == null)
            if (textBoxKey.Text == "" || textBoxIV.Text == "")
            {
                MessageBox.Show("Wprowadź klucze.");
                return;
            }

            try
            {
                byte[] encryptedBytes = StringToByteArray(textBox_fileEncryptTxt.Text);
                string decryptedText = DecryptStringFromBytes(encryptedBytes, manualOrGenearatedKey, manualOrGenearatedIV);
                //Log(decryptedText);
                textBox_fileTxt.Text = decryptedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Odszyfrowanie nie powiodło się: {ex.Message}");
            }
            //buttonDecrypt.Enabled = false;
            //buttonEncrypt.Enabled = true;
        }
        private byte[] EncryptStringToBytes(string plainText, byte[] Key, byte[] IV)
        {
            using (var encryptor = algorithm.CreateEncryptor(Key, IV))
            //using (var encryptor = algorithm.CreateEncryptor(manualKey, manualIV))// --- for manual input TEST
            using (var ms = new MemoryStream())
            {
                using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                using (var sw = new StreamWriter(cs))
                {
                    sw.Write(plainText);
                }
                return ms.ToArray();
            }
        }
        private string DecryptStringFromBytes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            using (var decryptor = algorithm.CreateDecryptor(Key, IV))
            using (var ms = new MemoryStream(cipherText))
            using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
            using (var sr = new StreamReader(cs))
            {
                return sr.ReadToEnd();
            }
        }
        private byte[] StringToByteArray(string hex)
        {
            int numberChars = hex.Length;
            byte[] bytes = new byte[numberChars / 2];
            for (int i = 0; i < numberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }

        // <<< SymmetricAlgorithm <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< SymmetricAlgorithm

        // >>> Serialize >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Serialize
        private void SaveAlgoData(object sender, EventArgs e)
        {
            if (textBoxKey.Text == "" || textBoxIV.Text == "" || textBoxAlgoPrefix.Text == "" || filePaths.Any()==false)
            {
                MessageBox.Show("Proszę wygeneruj Klucze, wprowadź prefix dla parametrów Algo oraz wybierz plik do zaszyfrowania");
                return;
            }
            try
            {
                int aType = comboBoxAlgorithm.SelectedIndex;
                string aKey = textBoxKey.Text; 
                string aIV = textBoxIV.Text;
                string aSufix = textBoxAlgoPrefix.Text;


                AlgoData algoData = new AlgoData(aType, aKey, aIV, aSufix);

                string algoPrefix = textBoxAlgoPrefix.Text;
                string algoParam = $"algoParam_{algoPrefix}.bin";
                //string path = "C:/Users/Daniel-/OneDrive/Dokumenty/My/";
                string path = Path.GetDirectoryName(filePaths.First()); // zapisuje w lokalizacji pierwszego pliku w liscie
                string fullPath = Path.Combine(path,algoParam);

                using (FileStream fileStream = new FileStream(fullPath, FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, algoData);
                }

                Log($"Zapisano plik z parametrami Algorytmu : {fullPath}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}");
            }
        }

        private void buttonLoadAlgoData_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = false;
                openFileDialog.Filter = "Text|*.bin|All|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string file = openFileDialog.FileName;

                    LoadAlgoData(file);

                    
                }
            }
        }
        private void LoadAlgoData(string file)
        {
            try
            {
                using (FileStream fileStream = new FileStream(file, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    AlgoData algoData = (AlgoData)formatter.Deserialize(fileStream);

                    comboBoxAlgorithm.SelectedIndex = algoData.AlgoType;
                    textBoxKey.Text = algoData.AlgoKey;
                    textBoxIV.Text = algoData.AlgoIV;
                    textBoxAlgoPrefix.Text = algoData.Sufix;

                    manualOrGenearatedKey = StringToByteArray(algoData.AlgoKey);
                    manualOrGenearatedIV = StringToByteArray(algoData.AlgoIV);

                    algorithm = GetAlgorithm();

                }
                
                /*int pFrom = file.IndexOf("algoParam_") + "algoParam_".Length;
                int pTo = file.LastIndexOf(".");
                string result = file.Substring(pFrom, pTo - pFrom);
                textBoxAlgoPrefix.Text = result;*/
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Plik nie został znaleziony.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}");
            }
        }
        // <<< Serialize <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< Serialize

        // >>> Server >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Server

        public void UploadFileUsingScp(string host, string username, string password, string localFilePath, string remotePath)
        {
            using (var scp = new ScpClient(host, username, password))
            {
                scp.Connect();
                scp.Upload(new FileInfo(localFilePath), remotePath);
                scp.Disconnect();
            }
        }

        


        // <<< Server <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< Server


    } // --- Form1


    [Serializable]
    class AlgoData
    {
        public int AlgoType { get; set; }
        public string AlgoKey { get; set; }
        public string AlgoIV { get; set; }
        public string Sufix { get; set; }

        public AlgoData(int algoType, string algoKey, string algoIV, string sufix)
        {
            AlgoType = algoType;
            AlgoKey = algoKey;
            AlgoIV = algoIV;
            Sufix = sufix;
        }
    }


}
