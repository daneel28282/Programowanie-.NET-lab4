namespace appTest
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelectFiles = new System.Windows.Forms.Button();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.textBox_fileTxt = new System.Windows.Forms.TextBox();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.textBoxIV = new System.Windows.Forms.TextBox();
            this.comboBoxAlgorithm = new System.Windows.Forms.ComboBox();
            this.buttonGenerateKeys = new System.Windows.Forms.Button();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.textBox_fileEncryptTxt = new System.Windows.Forms.TextBox();
            this.buttonSaveAlgoData = new System.Windows.Forms.Button();
            this.buttonLoadAlgoData = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnEncryptAll = new System.Windows.Forms.Button();
            this.textBoxAlgoPrefix = new System.Windows.Forms.TextBox();
            this.listBoxEncryptedFiles = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.scpHost = new System.Windows.Forms.TextBox();
            this.scpUsername = new System.Windows.Forms.TextBox();
            this.scpPassword = new System.Windows.Forms.TextBox();
            this.scpLocalPath = new System.Windows.Forms.TextBox();
            this.scpRemotePath = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSelectEncryptedFiles = new System.Windows.Forms.Button();
            this.btnDecryptAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelectFiles
            // 
            this.btnSelectFiles.Location = new System.Drawing.Point(717, 28);
            this.btnSelectFiles.Name = "btnSelectFiles";
            this.btnSelectFiles.Size = new System.Drawing.Size(120, 23);
            this.btnSelectFiles.TabIndex = 0;
            this.btnSelectFiles.Text = "Add Files";
            this.btnSelectFiles.UseVisualStyleBackColor = true;
            this.btnSelectFiles.Click += new System.EventHandler(this.btnSelectFiles_Click);
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.Location = new System.Drawing.Point(11, 28);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxFiles.Size = new System.Drawing.Size(700, 134);
            this.listBoxFiles.TabIndex = 1;
            this.listBoxFiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxFiles_MouseDoubleClick);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(11, 698);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(1157, 96);
            this.txtLog.TabIndex = 2;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(717, 57);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(120, 23);
            this.btnSelectFolder.TabIndex = 3;
            this.btnSelectFolder.Text = "Add Folder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // textBox_fileTxt
            // 
            this.textBox_fileTxt.Location = new System.Drawing.Point(9, 414);
            this.textBox_fileTxt.Multiline = true;
            this.textBox_fileTxt.Name = "textBox_fileTxt";
            this.textBox_fileTxt.Size = new System.Drawing.Size(399, 260);
            this.textBox_fileTxt.TabIndex = 4;
            this.textBox_fileTxt.Text = "Kliknij na element z listy \"Plików do Zaszyfrowania\" aby zobaczyć zawartość";
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(467, 512);
            this.textBoxKey.Multiline = true;
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(240, 40);
            this.textBoxKey.TabIndex = 5;
            // 
            // textBoxIV
            // 
            this.textBoxIV.Location = new System.Drawing.Point(467, 571);
            this.textBoxIV.Multiline = true;
            this.textBoxIV.Name = "textBoxIV";
            this.textBoxIV.Size = new System.Drawing.Size(240, 20);
            this.textBoxIV.TabIndex = 6;
            // 
            // comboBoxAlgorithm
            // 
            this.comboBoxAlgorithm.FormattingEnabled = true;
            this.comboBoxAlgorithm.Location = new System.Drawing.Point(467, 472);
            this.comboBoxAlgorithm.Name = "comboBoxAlgorithm";
            this.comboBoxAlgorithm.Size = new System.Drawing.Size(240, 21);
            this.comboBoxAlgorithm.TabIndex = 7;
            // 
            // buttonGenerateKeys
            // 
            this.buttonGenerateKeys.Location = new System.Drawing.Point(470, 414);
            this.buttonGenerateKeys.Name = "buttonGenerateKeys";
            this.buttonGenerateKeys.Size = new System.Drawing.Size(239, 23);
            this.buttonGenerateKeys.TabIndex = 8;
            this.buttonGenerateKeys.Text = "Generate Keys";
            this.buttonGenerateKeys.UseVisualStyleBackColor = true;
            this.buttonGenerateKeys.Click += new System.EventHandler(this.buttonGenerateKeys_Click);
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(470, 443);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(100, 23);
            this.buttonEncrypt.TabIndex = 9;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(609, 443);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(100, 23);
            this.buttonDecrypt.TabIndex = 10;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // textBox_fileEncryptTxt
            // 
            this.textBox_fileEncryptTxt.Location = new System.Drawing.Point(768, 414);
            this.textBox_fileEncryptTxt.Multiline = true;
            this.textBox_fileEncryptTxt.Name = "textBox_fileEncryptTxt";
            this.textBox_fileEncryptTxt.Size = new System.Drawing.Size(400, 250);
            this.textBox_fileEncryptTxt.TabIndex = 11;
            // 
            // buttonSaveAlgoData
            // 
            this.buttonSaveAlgoData.Location = new System.Drawing.Point(607, 636);
            this.buttonSaveAlgoData.Name = "buttonSaveAlgoData";
            this.buttonSaveAlgoData.Size = new System.Drawing.Size(100, 23);
            this.buttonSaveAlgoData.TabIndex = 12;
            this.buttonSaveAlgoData.Text = "Save Algo Data";
            this.buttonSaveAlgoData.UseVisualStyleBackColor = true;
            this.buttonSaveAlgoData.Click += new System.EventHandler(this.SaveAlgoData);
            // 
            // buttonLoadAlgoData
            // 
            this.buttonLoadAlgoData.Location = new System.Drawing.Point(467, 636);
            this.buttonLoadAlgoData.Name = "buttonLoadAlgoData";
            this.buttonLoadAlgoData.Size = new System.Drawing.Size(100, 23);
            this.buttonLoadAlgoData.TabIndex = 13;
            this.buttonLoadAlgoData.Text = "Load Algo Data";
            this.buttonLoadAlgoData.UseVisualStyleBackColor = true;
            this.buttonLoadAlgoData.Click += new System.EventHandler(this.buttonLoadAlgoData_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(717, 86);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(120, 23);
            this.btnRemoveItem.TabIndex = 14;
            this.btnRemoveItem.Text = "Remove Selected";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnEncryptAll
            // 
            this.btnEncryptAll.Location = new System.Drawing.Point(11, 168);
            this.btnEncryptAll.Name = "btnEncryptAll";
            this.btnEncryptAll.Size = new System.Drawing.Size(700, 23);
            this.btnEncryptAll.TabIndex = 15;
            this.btnEncryptAll.Text = "Zaszyfruj i Wyślij Wszystkie Pliki z Listy";
            this.btnEncryptAll.UseVisualStyleBackColor = true;
            this.btnEncryptAll.Click += new System.EventHandler(this.EncryptAllFiles_Click);
            // 
            // textBoxAlgoPrefix
            // 
            this.textBoxAlgoPrefix.Location = new System.Drawing.Point(467, 610);
            this.textBoxAlgoPrefix.Name = "textBoxAlgoPrefix";
            this.textBoxAlgoPrefix.Size = new System.Drawing.Size(240, 20);
            this.textBoxAlgoPrefix.TabIndex = 16;
            // 
            // listBoxEncryptedFiles
            // 
            this.listBoxEncryptedFiles.FormattingEnabled = true;
            this.listBoxEncryptedFiles.Location = new System.Drawing.Point(9, 221);
            this.listBoxEncryptedFiles.Name = "listBoxEncryptedFiles";
            this.listBoxEncryptedFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxEncryptedFiles.Size = new System.Drawing.Size(700, 134);
            this.listBoxEncryptedFiles.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Pliki do zaszyfrowania";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Pliki zaszyfrowane";
            // 
            // scpHost
            // 
            this.scpHost.Location = new System.Drawing.Point(918, 46);
            this.scpHost.Name = "scpHost";
            this.scpHost.Size = new System.Drawing.Size(250, 20);
            this.scpHost.TabIndex = 20;
            // 
            // scpUsername
            // 
            this.scpUsername.Location = new System.Drawing.Point(918, 89);
            this.scpUsername.Name = "scpUsername";
            this.scpUsername.Size = new System.Drawing.Size(250, 20);
            this.scpUsername.TabIndex = 21;
            // 
            // scpPassword
            // 
            this.scpPassword.Location = new System.Drawing.Point(918, 132);
            this.scpPassword.Name = "scpPassword";
            this.scpPassword.Size = new System.Drawing.Size(250, 20);
            this.scpPassword.TabIndex = 22;
            // 
            // scpLocalPath
            // 
            this.scpLocalPath.Enabled = false;
            this.scpLocalPath.Location = new System.Drawing.Point(918, 175);
            this.scpLocalPath.Name = "scpLocalPath";
            this.scpLocalPath.Size = new System.Drawing.Size(250, 20);
            this.scpLocalPath.TabIndex = 23;
            // 
            // scpRemotePath
            // 
            this.scpRemotePath.Location = new System.Drawing.Point(918, 218);
            this.scpRemotePath.Name = "scpRemotePath";
            this.scpRemotePath.Size = new System.Drawing.Size(250, 20);
            this.scpRemotePath.TabIndex = 24;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(718, 116);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 23);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(918, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Host";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(918, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(918, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(918, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Local File Path";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(918, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Remote File Path";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(921, 362);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(247, 23);
            this.btnTest.TabIndex = 31;
            this.btnTest.Text = "tmp test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(467, 496);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Key";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(467, 555);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "IV";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(467, 594);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Sufix";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 683);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Log";
            // 
            // btnSelectEncryptedFiles
            // 
            this.btnSelectEncryptedFiles.Location = new System.Drawing.Point(718, 221);
            this.btnSelectEncryptedFiles.Name = "btnSelectEncryptedFiles";
            this.btnSelectEncryptedFiles.Size = new System.Drawing.Size(119, 23);
            this.btnSelectEncryptedFiles.TabIndex = 36;
            this.btnSelectEncryptedFiles.Text = "Add Files";
            this.btnSelectEncryptedFiles.UseVisualStyleBackColor = true;
            this.btnSelectEncryptedFiles.Click += new System.EventHandler(this.btnSelectEncryptedFiles_Click);
            // 
            // btnDecryptAll
            // 
            this.btnDecryptAll.Location = new System.Drawing.Point(9, 362);
            this.btnDecryptAll.Name = "btnDecryptAll";
            this.btnDecryptAll.Size = new System.Drawing.Size(698, 23);
            this.btnDecryptAll.TabIndex = 37;
            this.btnDecryptAll.Text = "Odszyfruj Wszystkie Pliki z Listy";
            this.btnDecryptAll.UseVisualStyleBackColor = true;
            this.btnDecryptAll.Click += new System.EventHandler(this.btnDecryptAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 806);
            this.Controls.Add(this.btnDecryptAll);
            this.Controls.Add(this.btnSelectEncryptedFiles);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.scpRemotePath);
            this.Controls.Add(this.scpLocalPath);
            this.Controls.Add(this.scpPassword);
            this.Controls.Add(this.scpUsername);
            this.Controls.Add(this.scpHost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxEncryptedFiles);
            this.Controls.Add(this.textBoxAlgoPrefix);
            this.Controls.Add(this.btnEncryptAll);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.buttonLoadAlgoData);
            this.Controls.Add(this.buttonSaveAlgoData);
            this.Controls.Add(this.textBox_fileEncryptTxt);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.buttonGenerateKeys);
            this.Controls.Add(this.comboBoxAlgorithm);
            this.Controls.Add(this.textBoxIV);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.textBox_fileTxt);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.listBoxFiles);
            this.Controls.Add(this.btnSelectFiles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFiles;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.TextBox textBox_fileTxt;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.TextBox textBoxIV;
        private System.Windows.Forms.ComboBox comboBoxAlgorithm;
        private System.Windows.Forms.Button buttonGenerateKeys;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.TextBox textBox_fileEncryptTxt;
        private System.Windows.Forms.Button buttonSaveAlgoData;
        private System.Windows.Forms.Button buttonLoadAlgoData;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnEncryptAll;
        private System.Windows.Forms.TextBox textBoxAlgoPrefix;
        private System.Windows.Forms.ListBox listBoxEncryptedFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox scpHost;
        private System.Windows.Forms.TextBox scpUsername;
        private System.Windows.Forms.TextBox scpPassword;
        private System.Windows.Forms.TextBox scpLocalPath;
        private System.Windows.Forms.TextBox scpRemotePath;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSelectEncryptedFiles;
        private System.Windows.Forms.Button btnDecryptAll;
    }
}

