using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace UNCCStudentIDHolder
{
    public partial class FRM_UNCCStudentIDs : Form
    {
        private BsonDocument result;
        private static MongoClient client;
        private static IMongoDatabase idDatabase;
        private static IMongoDatabase nameDatabase;
        private IMongoCollection<BsonDocument> idCollection;
        private IMongoCollection<BsonDocument> nameCollection;
        private int idConversionVal;
        private bool activeConversionVal;
        private String UserNameInput;
        private String PasswordInput;
        public FRM_UNCCStudentIDs()
        {
            InitializeComponent();
        }

        private void FRM_UNCCStudentIDs_Load(object sender, EventArgs e)
        {
            ShowOrHideComponents(2);
        }

        private bool CheckLogin(String username, String password)
        {
            client = new MongoClient("xxxxxxxxxxxxxxxxxxxxxxxxxxx");
            nameDatabase = client.GetDatabase("Accounts");
            nameCollection = nameDatabase.GetCollection<BsonDocument>("Users");
            FilterDefinition<BsonDocument> userFiler = Builders<BsonDocument>.Filter.Eq("name", username);
            result = nameCollection.Find(userFiler).FirstOrDefault();
            if (result == null)
            {
                return false;
            }
            else
            {
                if ((result.GetValue("password") + "").Equals(password))
                return true;
            }
            return false;
        }

        private void ObtainEntries(String UserName, String Password, bool ActivateClient)
        {
            if (ActivateClient)
            {
                if (!CheckLogin(TXT_UsernameInput.Text, TXT_PasswordInput.Text))
                {
                    MessageBox.Show("Please enter the correct username or password!", " Login Error");
                    client = null;
                    nameDatabase = null;
                    nameCollection = null;
                    GC.Collect();
                    return;
                }
                idDatabase = client.GetDatabase("StudentIDs");
                idCollection = idDatabase.GetCollection<BsonDocument>("IDs");
            }

            LST_Entries.Items.Clear();
            try
            {
                IAsyncCursor<BsonDocument> cursor = idCollection.Find(new BsonDocument()).ToCursor();

                foreach (BsonDocument document in cursor.ToEnumerable())
                {
                    LST_Entries.Items.Add(new IDFormatter(document));
                }

                cursor = null;
                GC.Collect();
                if (ActivateClient)
                    ShowOrHideComponents(1);
                UserNameInput = UserName;
                PasswordInput = Password;
            }
            catch (System.TimeoutException)
            {
                MessageBox.Show("Error connecting to the server, try again", "Error");
                client = null;
                idDatabase = null;
                idCollection = null;
            }
            catch (MongoDB.Driver.MongoAuthenticationException)
            {
                MessageBox.Show("Provide a valid username and password!", "Error");
                client = null;
                idDatabase = null;
                idCollection = null;
            }
            GC.Collect();
        }

        private BsonDocument ReturnDocument(int index)
        {
            IAsyncCursor<BsonDocument> cursor = idCollection.Find(new BsonDocument()).ToCursor();
            BsonDocument result = cursor.ToList()[index];
            return result;
        }

        private int ReturnDocumentIndex(String name, int choice)
        {
            int index = 0;
            try
            {
                switch (choice)
                {
                    case 1:
                        foreach (IDFormatter format in LST_Entries.Items)
                        {
                            if (format.getName().Equals(name))
                                return index;

                            index++;
                        }
                        break;
                    case 2:
                        foreach (IDFormatter format in LST_Entries.Items)
                        {
                            if (format.getID().Equals(name))
                                return index;

                            index++;
                        }
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please do not use any letters or symbols in your input!", "Error");
                return -1;
            }
            return -1;
        }

        private void BTN_Search_Click(object sender, EventArgs e)
        {
            if (!TXT_SearchInput.Equals(""))
            {
                if (RAD_Name.Checked)
                    LST_Entries.SelectedIndex = ReturnDocumentIndex(TXT_SearchInput.Text, 1);
                else if (RAD_ID.Checked)
                    LST_Entries.SelectedIndex = ReturnDocumentIndex(TXT_SearchInput.Text, 2);
            }
        }

        private void BTN_View_Click(object sender, EventArgs e)
        {
            BsonDocument docToView;
            if (CheckIfItemIsSelected())
            {
                docToView = ReturnDocument(LST_Entries.SelectedIndex);
                MessageBox.Show("Name: " + docToView.GetValue("name")
                    + "\nID: " + docToView.GetValue("id")
                    + "\nActive? " + docToView.GetValue("active"),
                    "Information for user \"" + docToView.GetValue("name") + "\"");
            }
            docToView = null;
        }

        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            switch (int.Parse(result.GetValue("permissions") + ""))
            {
                case 2:
                    if (CheckIfItemIsSelected())
                    {
                        try
                        {
                            string item = LST_Entries.Items[LST_Entries.SelectedIndex].ToString();
                            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq("name", item.Substring(0, item.LastIndexOf(" - ")));
                            LST_Entries.Items.RemoveAt(LST_Entries.SelectedIndex);
                            idCollection.DeleteOne(filter);
                            ObtainEntries(UserNameInput, PasswordInput, false);
                            filter = null;
                            GC.Collect();
                        }
                        catch (MongoDB.Driver.MongoCommandException)
                        {
                            MessageBox.Show("You do not have the proper permission to do this!");
                        }
                    }
                    break;
                default:
                    MessageBox.Show("You do not have the proper permission to do this!");
                    break;
            }
        }

        private void BTN_Edit_Click(object sender, EventArgs e)
        {
            switch (int.Parse(result.GetValue("permissions") + ""))
            {
                case 2:
                    if (CheckIfItemIsSelected())
                    {
                        try
                        {
                            BsonDocument docToDelete = ReturnDocument(LST_Entries.SelectedIndex);
                            string choice = Microsoft.VisualBasic.Interaction.InputBox("What would you like to edit for this user?"
                                + "\n\nType 1 for Name" +
                                "\nType 2 for ID" +
                                "\nType 3 for Active Status\n", "Edit Information");

                            switch (choice)
                            {
                                case "1":
                                    string newName = Microsoft.VisualBasic.Interaction.InputBox("What is the new name you want to put for this user?", "Edit Name");
                                    if (!newName.Equals(""))
                                    {
                                        FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq("name", docToDelete.GetValue("name"));
                                        UpdateDefinition<BsonDocument> update = Builders<BsonDocument>.Update.Set("name", newName);
                                        idCollection.UpdateOne(filter, update);
                                        filter = null;
                                        update = null;
                                        newName = null;
                                    }
                                    break;
                                case "2":
                                    string id = Microsoft.VisualBasic.Interaction.InputBox("What is the new id you want to put for this user?", "Edit ID");
                                    if (!id.Equals("") && Int32.TryParse(id, out idConversionVal) && !(id.Length != 9))
                                    {
                                        FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq("id", docToDelete.GetValue("id"));
                                        UpdateDefinition<BsonDocument> update = Builders<BsonDocument>.Update.Set("id", idConversionVal);
                                        idCollection.UpdateOne(filter, update);
                                        filter = null;
                                        update = null;
                                        id = null;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Invalid input!", "Error");
                                    }
                                    break;
                                case "3":
                                    string active = Microsoft.VisualBasic.Interaction.InputBox("What is the active status you want to put for this user?", "Edit Active Status");
                                    if (!active.Equals("") && Boolean.TryParse(active, out activeConversionVal))
                                    {
                                        FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq("active", docToDelete.GetValue("active"));
                                        UpdateDefinition<BsonDocument> update = Builders<BsonDocument>.Update.Set("active", activeConversionVal);
                                        idCollection.UpdateOne(filter, update);
                                        filter = null;
                                        update = null;
                                        active = null;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Invalid input!", "Error");
                                    }
                                    break;
                            }
                            ObtainEntries(UserNameInput, PasswordInput, false);
                            docToDelete = null;
                        }
                        catch (MongoDB.Driver.MongoCommandException)
                        {
                            MessageBox.Show("You do not have the proper permission to do this!");
                        }
                        GC.Collect();
                    }
                    break;
                default:
                    MessageBox.Show("You do not have the proper permission to do this!");
                    break;
            }
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            switch (int.Parse(result.GetValue("permissions") + ""))
            {
                case 2:
                    if (!TXT_NameInput.Text.Equals("") && !(TXT_IDInput.Text.Equals("")))
                    {
                        bool IsActive = true;

                        if (RAD_No.Checked)
                        {
                            IsActive = false;
                        }

                        if (TXT_IDInput.Text.Length == 9 && Int32.TryParse(TXT_IDInput.Text, out idConversionVal))
                        {
                            try
                            {
                                switch (int.Parse(result.GetValue("permissions") + ""))
                                {
                                    case 2:
                                        BsonDocument document = new BsonDocument
                                        {
                                            { "name", TXT_NameInput.Text },
                                            { "id", TXT_IDInput.Text },
                                            { "active", IsActive}
                                        };
                                        idCollection.InsertOne(document);
                                        ObtainEntries(UserNameInput, PasswordInput, false);
                                        document = null;
                                        GC.Collect();
                                        break;
                                    default:
                                        MessageBox.Show("You do not have the proper permission to do this!");
                                        break;
                                }
                            }
                            catch (MongoDB.Driver.MongoCommandException)
                            {
                                MessageBox.Show("You do not have the proper permission to do this!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter in a valid ID!", "Error");
                        }
                    }
                    break;
                default:
                    MessageBox.Show("You do not have the proper permission to do this!");
                    break;
            }
        }

        private bool CheckIfItemIsSelected()
        {
            if (LST_Entries.Items.Count <= 0)
            {
                MessageBox.Show("You cannot delete an entry from an empty list!", "Error");
                return false;
            }

            if (LST_Entries.SelectedIndex < 0 || LST_Entries.SelectedIndex >= LST_Entries.Items.Count)
            {
                MessageBox.Show("You cannot select an unknown index!", "Error");
                return false;
            }

            return true;
        }

        private void BTN_Login_Click(object sender, EventArgs e)
        {
            if (!TXT_UsernameInput.Text.Equals("") && !TXT_PasswordInput.Text.Equals(""))
            {
                UserNameInput = TXT_UsernameInput.Text;
                PasswordInput = TXT_PasswordInput.Text;
                ObtainEntries(TXT_UsernameInput.Text, TXT_PasswordInput.Text, true);
                return;
            }
            MessageBox.Show("Do not leave any fields blank!", "Error");
        }

        private void MNUSTRP_Restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void MNUSTRP_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MNUSTRP_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A program that can save public data from students at UNCC" +
                "\nAnd a test to see my abilities with databases" +
                "\n\nCreated by Hashim Qureshi (DefyTheRush)", "About this program");
        }

        private void MNUSTRP_Export_Click(object sender, EventArgs e)
        {
            string extension = Microsoft.VisualBasic.Interaction.InputBox("What is the file extension you would like to make for the exported document?" +
                "\n\nNotes:" +
                "\n- The file will be where the program (.exe) was run" +
                "\n- Only type the extension, without the dot in front" +
                "\n\nExamples include: txt, json, etc.", "Export File Type");
            if (!extension.Equals(""))
            {
                StreamWriter writer = new StreamWriter(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\data." + extension.ToLower());
                var cursor = idCollection.Find(new BsonDocument()).ToCursor();
                foreach (BsonDocument document in cursor.ToEnumerable())
                    writer.WriteLine(document);
                writer.Close();
            }
        }

        private void ShowOrHideComponents(int choice)
        {
            switch (choice)
            {
                case 1:
                    TABCTRL_Main.Visible = true;
                    GRPBOX_Users.Visible = true;
                    BTN_Search.Visible = true;
                    BTN_Add.Visible = true;
                    BTN_Edit.Visible = true;
                    BTN_View.Visible = true;
                    BTN_Delete.Visible = true;
                    MNUSTRIP_Bar.Visible = true;
                    TABPAGE_Welcome.Visible = true;
                    TABPAGE_Welcome.Text = "Main Page";
                    TABPAGE_Login.Visible = false;
                    TABCTRL_Controls.SelectTab(TABPAGE_Welcome);
                    LBL_EnterUsername.Visible = false;
                    LBL_EnterPassword.Visible = false;
                    TXT_UsernameInput.Visible = false;
                    TXT_UsernameInput.Text = "";
                    TXT_PasswordInput.Visible = false;
                    TXT_PasswordInput.Text = "";
                    BTN_Login.Visible = false;
                    LBL_WelcomeText.Visible = false;
                    this.Text = this.Text + " - " + UserNameInput;
                    (TABCTRL_Controls.TabPages[0] as TabPage).Enabled = true;
                    (TABCTRL_Controls.TabPages[1] as TabPage).Enabled = false;
                    TABCTRL_Controls.SelectTab(TABPAGE_Welcome);
                    this.MaximizeBox = true;
                    this.FormBorderStyle = FormBorderStyle.Sizable;
                    break;
                case 2:
                    TABCTRL_Main.Visible = false;
                    GRPBOX_Users.Visible = false;
                    BTN_Search.Visible = false;
                    BTN_Add.Visible = false;
                    BTN_Edit.Visible = false;
                    BTN_View.Visible = false;
                    BTN_Delete.Visible = false;
                    MNUSTRIP_Bar.Visible = false;
                    TABPAGE_Welcome.Visible = false;
                    TABPAGE_Welcome.Text = "Login First!";
                    (TABCTRL_Controls.TabPages[0] as TabPage).Enabled = false;
                    TABCTRL_Controls.SelectTab(TABPAGE_Login);
                    RAD_Name.Checked = true;
                    RAD_Yes.Checked = true;
                    this.MaximizeBox = false;
                    this.FormBorderStyle = FormBorderStyle.FixedSingle;
                    break;
            }
        }

        private void TABCTRL_Controls_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!e.TabPage.Enabled)
                e.Cancel = true;
        }
    }
}
