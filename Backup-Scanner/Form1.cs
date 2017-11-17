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
        /// <summary>
        /// variable that saves the connection state
        /// </summary>
        private bool connected = false;
        private Runspace rs;
        private PowerShell ps = PowerShell.Create();
        private RunspaceConfiguration rsc = RunspaceConfiguration.Create();
        /// <summary>
        /// save the server name
        /// </summary>
        private String server = "";
        /// <summary>
        /// save the domain name
        /// </summary>
        private String domain = "";
        private String bc = "";
        private XmlDocument settings;
        private PSSnapInException snapEx = null;
        private PSSnapInInfo psinfo;

        public DefaultWindow()
        {
            InitializeComponent();
            
            //add an eventhandler to change the text in the connectLabel
            connectLabel.BackColorChanged += connectChanged;
            reloadGUI();
            //try adding the VeeamPSSnapin to the Powershell
            try
            {
                psinfo = rsc.AddPSSnapIn("VeeamPSSnapin", out snapEx);
                rs = RunspaceFactory.CreateRunspace(rsc);
                rs.Open();
                ps.Runspace = rs;
                ps.Streams.Error.DataAdded += Error_DataAdded;
            } catch (PSArgumentException pse)
            {
                //shows message boxes when addin could not be added
                MessageBox.Show(null, pse.Message, "Error");
                MessageBox.Show(null, "Please make sure, that you have the \"VeeamPSSnapin\" installed! Verify your \"Veeam Backup & Replication\" installation", "Missing PSSnapin?");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            this.ActiveControl = usernameTextBox;
        }

        /// <summary>
        /// eventHandler that changes the text in the connectLabel based on the current color
        /// </summary>
        /// <param name="sender">connectLabel</param>
        /// <param name="e"></param>
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
                        conn.Text = "Connecting to " + server;
                        break;
                }
            }
            //throw new NotImplementedException();
        }

        /// <summary>
        /// change the visibility of elements in the gui based on the settings file
        /// </summary>
        private void reloadGUI()
        {
            settings = loadConfigDocument();
            //check if the backupserver name has changed
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
            //save the domain name from the settings file
            if (settings.DocumentElement.SelectSingleNode("/configuration/domainName") != null)
                domain = settings.DocumentElement.SelectSingleNode("/configuration/domainName").InnerText;
            //display or hide fields based on the settings file
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

        /// <summary>
        /// eventHandler for the PowerShell when an error occured while searching for a tape
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// perform login when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void login_clicked(object sender, EventArgs e)
        {
            //check for entered username and password
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
                //if a domain is specified in the settings it must be verified that the user did not entered the domain in the username field
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
                        user = domain + '\\' + user;
                }
                Console.WriteLine(user);
                try
                {
                    //connecting to the specified server with username and password
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

        /// <summary>
        /// close the Powershell when closing the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// starts a new thread to search for the tape.
        /// the thread is required to disable the input field while the search is running
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void getTapeInfo(object sender, EventArgs e)
        {
            Thread t = new Thread(TapeInfo);
            if (connected && inputTextBox.Text.Length > 0 && inputTextBox.ReadOnly == false)
            {
                bc = inputTextBox.Text;
                if (t.ThreadState == ThreadState.Unstarted)
                {
                    t.Start();
                } 
            }
        }

        /// <summary>
        /// searches for the given tape name and writes the values to the gui
        /// </summary>
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

        /// <summary>
        /// perform the login when pressing enter in the login fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                login_clicked(sender, e);
        }

        /// <summary>
        /// start a new search when hitting the enter key in the input field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void inputKeyPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                getTapeInfo(sender, e);
        }

        /// <summary>
        /// changing the text of the inputTextBox
        /// </summary>
        /// <param name="text">text to write</param>
        private void changeInputTextBox(String text)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(changeInputTextBox), new object[] { text });
                return;
            }
            inputTextBox.Text = text;
        }

        /// <summary>
        /// changing the text of the barcodeTextBox
        /// </summary>
        /// <param name="text">text to write</param>
        private void changeBarcodeTextBox(String text)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(changeBarcodeTextBox), new object[] { text });
                return;
            }
            barcodeTextBox.Text = text;
        }

        /// <summary>
        /// changing the text of the locationTextBox
        /// </summary>
        /// <param name="text">text to write</param>
        private void changeLocationTextBox(String text)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(changeLocationTextBox), new object[] { text });
                return;
            }
            locationTextBox.Text = text;
        }

        /// <summary>
        /// changing the text of the vaultTextBox
        /// </summary>
        /// <param name="text">text to write</param>
        private void changeVaultTextBox(String text)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(changeVaultTextBox), new object[] { text });
                return;
            }
            vaultTextBox.Text = text;
        }

        /// <summary>
        /// changing the text of the freeTextBox
        /// </summary>
        /// <param name="text">text to write</param>
        private void changeFreeTextBox(String text)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(changeFreeTextBox), new object[] { text });
                return;
            }
            freeTextBox.Text = text;
        }

        /// <summary>
        /// changing the color of the freeTextBox based on the content
        /// </summary>
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

        /// <summary>
        /// changing the text of the expiredTextBox
        /// </summary>
        /// <param name="text">text to write</param>
        private void changeExpiredTextBox(String text)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(changeExpiredTextBox), new object[] { text });
                return;
            }
            expiredTextBox.Text = text;
        }

        /// <summary>
        /// changing the color of the expiredTextBox based on the content
        /// </summary>
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

        /// <summary>
        /// changing the text of the expirationDateTextBox
        /// </summary>
        /// <param name="text">text to write</param>
        private void changeExpirationDateTextBox(String text)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(changeExpirationDateTextBox), new object[] { text });
                return;
            }
            expirationDateTextBox.Text = text;
        }

        /// <summary>
        /// enables or disables the inputTextBox
        /// </summary>
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

        /// <summary>
        /// adding text to the outoutTextBox
        /// </summary>
        /// <param name="message">text to add</param>
        private void writeToOutput(String message)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(writeToOutput), new object[] { message });
                return;
            }
            outputTextBox.AppendText(message);
        }

        /// <summary>
        /// loads the config file
        /// </summary>
        /// <returns>XmlDocument config file</returns>
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

        /// <summary>
        /// searching for the config file. primary in localAppData, secondary in programfiles directory
        /// </summary>
        /// <returns>String path to the found config file</returns>
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

        /// <summary>
        /// open the SettingsForm from the Main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm(settings);
            sf.FormClosing += new FormClosingEventHandler(this.sfClosing);
            sf.Show();
            this.Enabled = false;
        }

        /// <summary>
        /// reload the Gui when the SettingsForm is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sfClosing(object sender, FormClosingEventArgs e)
        {
            this.Enabled = true;
            reloadGUI();
        }
    }
}
