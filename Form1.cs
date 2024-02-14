using System.Security.Cryptography;
using System.Text;
using System.Linq;
using System.Security;
using System.Drawing.Drawing2D;
using static System.Net.Mime.MediaTypeNames;

//-----------------------------------------------------
//-----------------------------------------------------

// Jei naudojate jau esanti data123.txt tai naudokite si slaptazodi
//PASSWORD: password123

//-----------------------------------------------------
//-----------------------------------------------------

namespace Password_vault_GUI
{
    public partial class PasswordVault : Form
    {
        public PasswordVault()
        {
            InitializeComponent();
            //string[] data = File.ReadAllLines("data.txt");
            //Security ob = new Security();
            this.FormClosing += Form1_FormClosing;
            checker();
        }

        public List<string> data;
        int indexMemory;
        Security ob = new Security();
        String pass;
        bool check;

        public void checker()
        {
            if (File.Exists("data123.txt"))
            {
                check = true;
            }
            else 
            {
                check = false;
                accessContext.Text = "Please type a password to protect your vault";
                connectionBtn.Text = "Create";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pass = pswdField.Text;

            if(check == true)
            {
                string package = ob.Decrypt(pass);
                if (package == null)
                {
                    accessContext.Text = "Wrong password";
                    return;
                }

                data = package.Split(new char[] { '\n', }).ToList();
            }
            else
            {
                data = new List<string> {};
                FileStream fs = File.Create("data123.txt");
            }

            connectionPanel.Visible = false;

            optionCreator();
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            ob.Encrypt(pass, data);
            data = null;
            pass = null;
        }

        private void Global_Button_Click(object sender, EventArgs e)
        {
            string name = ((Button)sender).Name.ToString();
            indexMemory = data.IndexOf(name);
            vaultContext.Text = name + "has been selected";
            displayData();
        }

        public void optionCreator()
        {
            //vaultContext.Text = data.Count.ToString();
            if (data.Count <= 0) return;
            for (int i = 0; i < data.Count-1; i += 3)
            {
                Button newButton = new Button();
                newButton.Text = data[i];
                newButton.Name = data[i];
                newButton.Width = 230;
                newButton.Height = 40;
                newButton.BackColor = Color.White;
                newButton.Click += Global_Button_Click;
                tableLayoutPanel1.Controls.Add(newButton);
            }
        }

        public void displayData()
        {
            saveBtn.Visible = true;
            deleteBtn.Visible = true;

            keyWordTextBox.Visible = true;
            userIDTextBox.Visible = true;
            passwordTextBox.Visible = true;
            passwordLabel.Visible = true;
            userIDLabel.Visible = true;
            keyWordLabel.Visible = true;

            keyWordTextBox.Text = data[indexMemory];
            userIDTextBox.Text = data[indexMemory + 1];
            passwordTextBox.Text = data[indexMemory + 2];

            vaultContext.Text = data[indexMemory] + " has been selected";

        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {

            confirmBtn.Visible = true;
            cancelBtn.Visible = true;

            keyWordTextBox.Visible = true;
            userIDTextBox.Visible = true;
            passwordTextBox.Visible = true;
            passwordLabel.Visible = true;
            userIDLabel.Visible = true;
            keyWordLabel.Visible = true;

            keyWordTextBox.Text = "";
            userIDTextBox.Text = "";
            passwordTextBox.Text = "";

            indexMemory = -1;

            saveBtn.Visible = false;
            deleteBtn.Visible = false;

            vaultContext.Text = "Please add data to save";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

            if (keyWordTextBox.Text == "" || userIDTextBox.Text == "" || passwordTextBox.Text == "")
            {
                vaultContext.Text = "All the text field must be filed before saving";
                return;
            }

            data[indexMemory] = keyWordTextBox.Text;
            data[indexMemory + 1] = userIDTextBox.Text;
            data[indexMemory + 2] = passwordTextBox.Text;

            keyWordTextBox.Visible = false;
            userIDTextBox.Visible = false;
            passwordTextBox.Visible = false;
            passwordLabel.Visible = false;
            userIDLabel.Visible = false;
            keyWordLabel.Visible = false;

            saveBtn.Visible = false;
            deleteBtn.Visible = false;

            vaultContext.Text = "Saved successfully";

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)tableLayoutPanel1.Controls[data[indexMemory]];
            data.RemoveAt(indexMemory+2);
            data.RemoveAt(indexMemory+1);
            data.RemoveAt(indexMemory);
            keyWordTextBox.Text = "";
            userIDTextBox.Text = "";
            passwordTextBox.Text = "";
            tableLayoutPanel1.Controls.Remove(btn);

            keyWordTextBox.Visible = false;
            userIDTextBox.Visible = false;
            passwordTextBox.Visible = false;
            passwordLabel.Visible = false;
            userIDLabel.Visible = false;
            keyWordLabel.Visible = false;

            saveBtn.Visible = false;
            deleteBtn.Visible = false;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {

            if (keyWordTextBox.Text == "" || userIDTextBox.Text == "" || passwordTextBox.Text == "")
            {
                vaultContext.Text = "All the text field must be filed before saving";
                return;
            }

            if (data.Contains(keyWordTextBox.Text))
            {
                vaultContext.Text = "The ID must be unique";
                return;
            }

            data.Add(keyWordTextBox.Text);
            data.Add(userIDTextBox.Text);
            data.Add(passwordTextBox.Text);

            Button newButton = new Button();
            newButton.Text = keyWordTextBox.Text;
            newButton.Name = keyWordTextBox.Text;
            newButton.Width = 271;
            newButton.Height = 40;
            newButton.BackColor = Color.White;
            newButton.Click += Global_Button_Click;
            tableLayoutPanel1.Controls.Add(newButton);

            keyWordTextBox.Text = "";
            userIDTextBox.Text = "";
            passwordTextBox.Text = "";

            confirmBtn.Visible = false;
            cancelBtn.Visible = false;

            keyWordTextBox.Visible = false;
            userIDTextBox.Visible = false;
            passwordTextBox.Visible = false;
            passwordLabel.Visible = false;
            userIDLabel.Visible = false;
            keyWordLabel.Visible = false;

            vaultContext.Text = "Saved successfully";
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            keyWordTextBox.Text = "";
            userIDTextBox.Text = "";
            passwordTextBox.Text = "";

            confirmBtn.Visible = false;
            cancelBtn.Visible = false;

            keyWordTextBox.Visible = false;
            userIDTextBox.Visible = false;
            passwordTextBox.Visible = false;
            passwordLabel.Visible = false;
            userIDLabel.Visible = false;
            keyWordLabel.Visible = false;
        }
    }


    class Security
    {

        private const int SaltSize = 8;

        public void Encrypt(string phrase, List<string> data)
        {

            FileInfo targetFile = new FileInfo("data123.txt");

            var keyGenerator = new Rfc2898DeriveBytes(phrase, SaltSize);
            var rijndael = Rijndael.Create();

            // BlockSize, KeySize in bit --> divide by 8
            rijndael.IV = keyGenerator.GetBytes(rijndael.BlockSize / 8);
            rijndael.Key = keyGenerator.GetBytes(rijndael.KeySize / 8);

            using (var fileStream = targetFile.Create())
            {
                // write random salt
                fileStream.Write(keyGenerator.Salt, 0, SaltSize);

                using (var cryptoStream = new CryptoStream(fileStream, rijndael.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    using (var swEncrypt = new StreamWriter(cryptoStream))
                    {
                        for (int i = 0; i < data.Count; i++)
                        {
                            swEncrypt.WriteLine(data[i]);
                        }
                    }
                }
            }

        }

        public string Decrypt(string phrase)
        {
            FileInfo targetFile = new FileInfo("data123.txt");

            string decrypted;

            // read salt
            var fileStream = targetFile.OpenRead();
            var salt = new byte[SaltSize];
            fileStream.Read(salt, 0, SaltSize);

            // initialize algorithm with salt
            try
            {
                var keyGenerator = new Rfc2898DeriveBytes(phrase, salt);
                var rijndael = Rijndael.Create();
                rijndael.IV = keyGenerator.GetBytes(rijndael.BlockSize / 8);
                rijndael.Key = keyGenerator.GetBytes(rijndael.KeySize / 8);

                // decrypt
                using (var cryptoStream = new CryptoStream(fileStream, rijndael.CreateDecryptor(), CryptoStreamMode.Read))
                {
                    using (StreamReader srDecrypt = new StreamReader(cryptoStream))
                    {
                        decrypted = srDecrypt.ReadToEnd();
                    }
                }
            }
            catch
            {
                decrypted = null;
                return decrypted;
            }

            return decrypted;
        }
    }
}

