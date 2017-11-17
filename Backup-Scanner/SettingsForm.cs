using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Backup_Scanner
{
    public partial class SettingsForm : Form
    {
        private XmlDocument settings;

        public SettingsForm(XmlDocument doc)
        {
            InitializeComponent();
            settings = doc;
            loadValues();
        }

        private void loadValues()
        {
            if (settings.DocumentElement.SelectSingleNode("/configuration/backupServer") != null)
                serverTextBox.Text = settings.DocumentElement.SelectSingleNode("/configuration/backupServer").InnerText;
            if (settings.DocumentElement.SelectSingleNode("/configuration/domainName") != null)
                domainTextBox.Text = settings.DocumentElement.SelectSingleNode("/configuration/domainName").InnerText;

            XmlNode xml = settings.DocumentElement.SelectSingleNode("displayValues");
            XmlNodeList displayValues = xml.ChildNodes;
            foreach (XmlNode att in displayValues)
            {
                switch (att.Name)
                {
                    case "barcode":
                        if (att.InnerText == "1")
                            barcodeCheckBox.Checked = true;
                        else
                            barcodeCheckBox.Checked = false;
                        break;
                    case "location":
                        if (att.InnerText == "1")
                            locationCheckBox.Checked = true;
                        else
                            locationCheckBox.Checked = false;
                        break;
                    case "vault":
                        if (att.InnerText == "1")
                            vaultCheckBox.Checked = true;
                        else
                            vaultCheckBox.Checked = false;
                        break;
                    case "isFree":
                        if (att.InnerText == "1")
                            freeCheckBox.Checked = true;
                        else
                            freeCheckBox.Checked = false;
                        break;
                    case "isExpired":
                        if (att.InnerText == "1")
                            expiredCheckBox.Checked = true;
                        else
                            expiredCheckBox.Checked = false;
                        break;
                    case "expirationDate":
                        if (att.InnerText == "1")
                            expirationDatecheckBox.Checked = true;
                        else
                            expirationDatecheckBox.Checked = false;
                        break;
                    case "outputLog":
                        if (att.InnerText == "1")
                            outputCheckBox.Checked = true;
                        else
                            outputCheckBox.Checked = false;
                        break;
                }
            }
        }

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            XmlNode xml = settings.DocumentElement.SelectSingleNode("displayValues");
            XmlNodeList displayValues = xml.ChildNodes;
            foreach (XmlNode att in displayValues)
            {
                switch (att.Name)
                {
                    case "barcode":
                        if (barcodeCheckBox.Checked)
                            settings.DocumentElement.SelectSingleNode("/configuration/displayValues/barcode").InnerText = "1";
                        else
                            settings.DocumentElement.SelectSingleNode("/configuration/displayValues/barcode").InnerText = "0";
                        break;
                    case "location":
                        if (locationCheckBox.Checked)
                            settings.DocumentElement.SelectSingleNode("/configuration/displayValues/location").InnerText = "1";
                        else
                            settings.DocumentElement.SelectSingleNode("/configuration/displayValues/location").InnerText = "0";
                        break;
                    case "vault":
                        if (vaultCheckBox.Checked)
                            settings.DocumentElement.SelectSingleNode("/configuration/displayValues/vault").InnerText = "1";
                        else
                            settings.DocumentElement.SelectSingleNode("/configuration/displayValues/vault").InnerText = "0";
                        break;
                    case "isFree":
                        if (freeCheckBox.Checked)
                            settings.DocumentElement.SelectSingleNode("/configuration/displayValues/isFree").InnerText = "1";
                        else
                            settings.DocumentElement.SelectSingleNode("/configuration/displayValues/isFree").InnerText = "0";
                        break;
                    case "isExpired":
                        if (expiredCheckBox.Checked)
                            settings.DocumentElement.SelectSingleNode("/configuration/displayValues/isExpired").InnerText = "1";
                        else
                            settings.DocumentElement.SelectSingleNode("/configuration/displayValues/isExpired").InnerText = "0";
                        break;
                    case "expirationDate":
                        if (expirationDatecheckBox.Checked)
                            settings.DocumentElement.SelectSingleNode("/configuration/displayValues/expirationDate").InnerText = "1";
                        else
                            settings.DocumentElement.SelectSingleNode("/configuration/displayValues/expirationDate").InnerText = "0";
                        break;
                    case "outputLog":
                        if (outputCheckBox.Checked)
                            settings.DocumentElement.SelectSingleNode("/configuration/displayValues/outputLog").InnerText = "1";
                        else
                            settings.DocumentElement.SelectSingleNode("/configuration/displayValues/outputLog").InnerText = "0";
                        break;
                }
            }
            if (settings.DocumentElement.SelectSingleNode("/configuration/backupServer") != null)
                settings.DocumentElement.SelectSingleNode("/configuration/backupServer").InnerText = serverTextBox.Text;
            else
            {
                XmlNode newElem;
                newElem = settings.CreateNode(XmlNodeType.Element, "backupServer", "");
                newElem.InnerText = serverTextBox.Text;
                XmlElement root = settings.DocumentElement;
                root.AppendChild(newElem);
            }
            if (settings.DocumentElement.SelectSingleNode("/configuration/domainName") != null)
                settings.DocumentElement.SelectSingleNode("/configuration/domainName").InnerText = domainTextBox.Text;
            else
            {
                XmlNode newElem;
                newElem = settings.CreateNode(XmlNodeType.Element, "domainName", "");
                newElem.InnerText = domainTextBox.Text;
                XmlElement root = settings.DocumentElement;
                root.AppendChild(newElem);
            }
            settings.Save(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + Path.DirectorySeparatorChar + "Backup-Scanner" + Path.DirectorySeparatorChar + "Settings.config");
        }
    }
}
