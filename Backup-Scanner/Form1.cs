using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Threading;
using System.Xml;
using System.IO;
using System.Collections;
using System.Collections.ObjectModel;

namespace Backup_Scanner
{
    public partial class DefaultWindow : Form
    {
        private bool connected = false;
        private Runspace rs;
        private PowerShell ps = PowerShell.Create();
        private RunspaceConfiguration rsc = RunspaceConfiguration.Create();
        private String bc = "", server = "", domain = "";
        private XmlDocument settings;
        private PSSnapInException snapEx = null;
        private PSSnapInInfo psinfo;

        public DefaultWindow()
        {
            InitializeComponent();
            connectLabel.BackColorChanged += connectChanged;
            reloadGUI();
            try
            {
                psinfo = rsc.AddPSSnapIn("VeeamPSSnapin", out snapEx);
                rs = RunspaceFactory.CreateRunspace(rsc);
                rs.Open();
                ps.Runspace = rs;
                ps.Streams.Error.DataAdded += Error_DataAdded;
            } catch (PSArgumentException pse)
            {
                MessageBox.Show(null, pse.Message, "Error");
                MessageBox.Show(null, "Please make sure, that you have the \"VeeamPSSnapin\" installed! Verify your \"Veeam Backup & Replication\" installation", "Missing PSSnapin?");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            this.ActiveControl = usernameTextBox;
        }

        private void connectChanged(object sender, EventArgs e)
        {
            if (sender is Label) {
                Label conn = (Label)sender;
                switch (conn.BackColor.Name)
                {
                    case "Red":
                        conn.Text = "Not connected";
                        connected = false;
                        inputTextBox.ReadOnly = true;
                        break;
                    case "Green":
                        conn.Text = "Connected";
                        connected = true;
                        inputTextBox.ReadOnly = false;
                        break;
                    case "Gold":
                        conn.Text = "Connecting";
                        break;
                }
            }
            //throw new NotImplementedException();
        }

        private void reloadGUI()
        {
            settings = loadConfigDocument();
            if (settings.DocumentElement.SelectSingleNode("/configuration/backupServer") != null)
            {
                if (server != settings.DocumentElement.SelectSingleNode("/configuration/backupServer").InnerText)
                {
                    if (connected)
                    {
                        ps.AddScript("Disconnect-VBRServer");
                        connectLabel.BackColor = Color.Red;
                    }
                    server = settings.DocumentElement.SelectSingleNode("/configuration/backupServer").InnerText;
                }
            }
            if (settings.DocumentElement.SelectSingleNode("/configuration/domainName") != null)
                domain = settings.DocumentElement.SelectSingleNode("/configuration/domainName").InnerText;
            XmlNode xml = settings.DocumentElement.SelectSingleNode("displayValues");
            XmlNodeList displayValues = xml.ChildNodes;
            foreach (XmlNode att in displayValues)
            {
                switch (att.Name)
                {
                    case "barcode":
                        if (att.InnerText == "1")
                        {
                            barcodeLabel.Visible = true;
                            barcodeTextBox.Visible = true;
                        }
                        else
                        {
                            barcodeLabel.Visible = false;
                            barcodeTextBox.Visible = false;
                        }
                        break;
                    case "location":
                        if (att.InnerText == "1")
                        {
                            locationLabel.Visible = true;
                            locationTextBox.Visible = true;
                        }
                        else
                        {
                            locationLabel.Visible = false;
                            locationTextBox.Visible = false;
                        }
                        break;
                    case "vault":
                        if (att.InnerText == "1")
                        {
                            vaultLabel.Visible = true;
                            vaultTextBox.Visible = true;
                        }
                        else
                        {
                            vaultLabel.Visible = false;
                            vaultTextBox.Visible = false;
                        }
                        break;
                    case "isFree":
                        if (att.InnerText == "1")
                        {
                            freeLabel.Visible = true;
                            freeTextBox.Visible = true;
                        }
                        else
                        {
                            freeLabel.Visible = false;
                            freeTextBox.Visible = false;
                        }
                        break;
                    case "isExpired":
                        if (att.InnerText == "1")
                        {
                            expiredLabel.Visible = true;
                            expiredTextBox.Visible = true;
                        }
                        else
                        {
                            expiredLabel.Visible = false;
                            expiredTextBox.Visible = false;
                        }
                        break;
                    case "expirationDate":
                        if (att.InnerText == "1")
                        {
                            expirationDateLabel.Visible = true;
                            expirationDateTextBox.Visible = true;
                        }
                        else
                        {
                            expirationDateLabel.Visible = false;
                            expirationDateTextBox.Visible = false;
                        }
                        break;
                    case "outputLog":
                        if (att.InnerText == "1")
                            outputTextBox.Visible = true;
                        else
                            outputTextBox.Visible = false;
                        break;
                }
            }
        }

        private void Error_DataAdded(object sender, DataAddedEventArgs e)
        {
            writeToOutput(System.Environment.NewLine + ps.Streams.Error.ElementAt(0).Exception.Message + System.Environment.NewLine);
            ps.Streams.Error.RemoveAt(0);
            changeBarcodeTextBox("ERROR");
            changeExpirationDateTextBox("");
            changeExpiredTextBox("");
            changeFreeTextBox("");
            changeLocationTextBox("");
            changeFreeTextBox();
            changeExpiredTextBox();
            //throw new NotImplementedException();
        }

        private void login_clicked(object sender, EventArgs e)
        {
            if (usernameTextBox.Text.Length == 0)
            {
                writeToOutput("No username entered" + System.Environment.NewLine);
            }
            else if (passwordTextBox.Text.Length == 0)
            {
                writeToOutput("No password entered" + System.Environment.NewLine);
            }
            else
            {
                connectLabel.BackColor = Color.Gold;
                String user = usernameTextBox.Text;
                String pass = passwordTextBox.Text;
                if (domain != "")
                {
                    char[] dom = user.Take(domain.ToLower().Length + 1).ToArray();
                    bool[] addDom = new bool[domain.Length + 1];
                    for (int i = 0; i < dom.Length; i++)
                    {
                        if (i < domain.Length)
                        {
                            if (dom[i].ToString().ToLower() != domain[i].ToString().ToLower())
                                addDom[i] = true;
                            else
                                addDom[i] = false;
                        }
                        else
                        {
                            if (dom[i] == '\\')
                            {
                                addDom[i] = false;
                            }
                        }
                    }
                    if (addDom.Where(c => c).Count() == (domain.Length))
                        user = domain + "\\" + user;
                }
                Console.WriteLine(user);
                try
                {
                    ps.AddScript("Connect-VBRServer -Server " + server + " -User \"" + user + "\" -Password \"" + pass + "\"");
                    ps.AddScript("Get-VBRServerSession");
                    IEnumerable<PSObject> results = ps.Invoke();
                    PSDataCollection<ErrorRecord> stream = ps.Streams.Error;
                    foreach (ErrorRecord err in stream)
                    {
                        writeToOutput(err.Exception.Message);
                        ps.Streams.Error.Remove(err);
                        connectLabel.BackColor = Color.Red;
                    }
                    foreach (var result in results)
                    {
                        writeToOutput("Connected as " + result.Properties["User"].Value.ToString() + System.Environment.NewLine);
                        connected = true;
                        connectLabel.BackColor = Color.Green;
                        loginButton.Enabled = false;
                        usernameTextBox.ReadOnly = true;
                        passwordTextBox.ReadOnly = true;
                        inputTextBox.ReadOnly = false;
                    }
                }
                catch (Exception ex)
                {
                    connected = false;
                    connectLabel.BackColor = Color.Red;
                    writeToOutput("Could not connect to server. Wrong credentials?" + System.Environment.NewLine);
                    loginButton.Enabled = true;
                    usernameTextBox.ReadOnly = false;
                    passwordTextBox.ReadOnly = false;
                    inputTextBox.ReadOnly = true;
                }
                ps.Commands.Commands.Clear();
            }
        }

        private void formClose(object sender, FormClosedEventArgs e)
        {
            try
            {
                ps.Stop();
                rs.Close();
            }
            catch (Exception ex)
            {
            }
        }

        private void getTapeInfo(object sender, EventArgs e)
        {
            Thread t = new Thread(TapeInfo);
            if (connected && inputTextBox.Text.Length > 0 &&inputTextBox.ReadOnly == false)
            {
                bc = inputTextBox.Text;
                if (t.ThreadState == ThreadState.Unstarted)
                {
                    t.Start();
                } 
            }
        }

        private void TapeInfo()
        {
            inputReadOnly();
            ps.AddScript("Get-VBRTapeMedium -Name \"" + bc + "\" | Select Barcode,Location,Vault,isFree,isExpired,ExpirationDate");
            try
            {
                IEnumerable<PSObject> results = ps.Invoke();
                foreach (PSObject result in results)
                {
                    writeToOutput("---" + System.Environment.NewLine);
                    if (result.Properties["Barcode"].Value != null)
                    {
                        String barcode = result.Properties["Barcode"].Value.ToString();
                        changeBarcodeTextBox(barcode);
                        writeToOutput("Barcode: " + barcode + System.Environment.NewLine);
                    }
                    else
                    {
                        writeToOutput("Barcode \"" + bc + "\"not found" + System.Environment.NewLine);
                    }
                    if (result.Properties["Location"].Value != null)
                    {
                        String location = result.Properties["Location"].Value.ToString();
                        changeLocationTextBox(location);
                        writeToOutput("Location: " + location + System.Environment.NewLine);
                    }
                    if (result.Properties["Vault"].Value != null)
                    {
                        String vault = result.Properties["Vault"].Value.ToString();
                        changeVaultTextBox(vault);
                        writeToOutput("Vault: " + vault + System.Environment.NewLine);
                    }
                    if (result.Properties["isFree"].Value != null)
                    {
                        String free = result.Properties["isFree"].Value.ToString();
                        changeFreeTextBox(free);
                        changeFreeTextBox();
                        writeToOutput("isFree: " + free + System.Environment.NewLine);
                    }
                    if (result.Properties["isExpired"].Value != null)
                    {
                        String expired = result.Properties["isExpired"].Value.ToString();
                        changeExpiredTextBox(expired);
                        changeExpiredTextBox();
                        if (expiredTextBox.Text == "False") { expiredTextBox.BackColor = Color.Red; }
                        else if (expiredTextBox.Text == "True") { expiredTextBox.BackColor = Color.Green; }
                        else { expiredTextBox.BackColor = DefaultWindow.DefaultBackColor; }
                        writeToOutput("isExpired: " + expired + System.Environment.NewLine);
                    }
                    if (result.Properties["ExpirationDate"].Value != null)
                    {
                        String expDate = result.Properties["ExpirationDate"].Value.ToString();
                        changeExpirationDateTextBox(expDate);
                        writeToOutput("ExpirationDate: " + expDate + System.Environment.NewLine);
                    }
                    writeToOutput("---");
                }
            }
            catch (Exception ex)
            {
                writeToOutput(ex.Message);
            }
            changeInputTextBox("");
            ps.Commands.Commands.Clear();
            inputReadOnly();
        }

        private void loginPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                login_clicked(sender, e);
        }

        private void inputKeyPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                getTapeInfo(sender, e);
        }

        private void changeInputTextBox(String text)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(changeInputTextBox), new object[] { text });
                return;
            }
            inputTextBox.Text = text;
        }

        private void changeBarcodeTextBox(String text)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(changeBarcodeTextBox), new object[] { text });
                return;
            }
            barcodeTextBox.Text = text;
        }

        private void changeLocationTextBox(String text)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(changeLocationTextBox), new object[] { text });
                return;
            }
            locationTextBox.Text = text;
        }

        private void changeVaultTextBox(String text)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(changeVaultTextBox), new object[] { text });
                return;
            }
            vaultTextBox.Text = text;
        }

        private void changeFreeTextBox(String text)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(changeFreeTextBox), new object[] { text });
                return;
            }
            freeTextBox.Text = text;
        }

        private void changeFreeTextBox()
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action(changeFreeTextBox));
                return;
            }
            if (freeTextBox.Text == "False") { freeTextBox.BackColor = Color.Red; }
            else if (freeTextBox.Text == "True") { freeTextBox.BackColor = Color.Green; }
            else { freeTextBox.BackColor = DefaultWindow.DefaultBackColor; }
        }

        private void changeExpiredTextBox(String text)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(changeExpiredTextBox), new object[] { text });
                return;
            }
            expiredTextBox.Text = text;
        }

        private void changeExpiredTextBox()
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action(changeExpiredTextBox));
                return;
            }
            if (expiredTextBox.Text == "False") { expiredTextBox.BackColor = Color.Red; }
            else if (expiredTextBox.Text == "True") { expiredTextBox.BackColor = Color.Green; }
            else { expiredTextBox.BackColor = DefaultWindow.DefaultBackColor; }
        }

        private void changeExpirationDateTextBox(String text)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(changeExpirationDateTextBox), new object[] { text });
                return;
            }
            expirationDateTextBox.Text = text;
        }

        private void inputReadOnly()
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action(inputReadOnly));
                return;
            }
            if (inputTextBox.ReadOnly == true) { inputTextBox.ReadOnly = false; }
            else { inputTextBox.ReadOnly = true; }
        }

        private void writeToOutput(String message)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(writeToOutput), new object[] { message });
                return;
            }
            outputTextBox.AppendText(message);
        }

        private static XmlDocument loadConfigDocument()
        {
            XmlDocument doc = null;
            try
            {
                doc = new XmlDocument();
                doc.Load(getConfigFilePath());
                return doc;
            }
            catch (System.IO.FileNotFoundException e)
            {
                throw new Exception("No configuration file found.", e);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private static String getConfigFilePath()
        {
            String output;
            try
            {
                if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + Path.DirectorySeparatorChar + "Backup-Scanner" + Path.DirectorySeparatorChar + "Settings.config"))
                    output = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + Path.DirectorySeparatorChar + "Backup-Scanner" + Path.DirectorySeparatorChar + "Settings.config";
                else if (File.Exists(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "Settings.config"))
                    output = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "Settings.config";
                else
                    throw new IOException("File not found");
            }
            catch (Exception ex)
            {
                return null;
            }
            return output;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm(settings);
            sf.FormClosing += new FormClosingEventHandler(this.sfClosing);
            sf.Show();
            this.Enabled = false;
        }

        private void sfClosing(object sender, FormClosingEventArgs e)
        {
            this.Enabled = true;
            reloadGUI();
        }
    }
}
