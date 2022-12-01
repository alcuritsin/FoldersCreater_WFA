using FoldersCreater_WFA.DataBase;
using System.Reflection;

namespace FoldersCreater_WFA
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelClientName = new System.Windows.Forms.Label();
            this.groupBoxNewOject = new System.Windows.Forms.GroupBox();
            this.checkBoxLocationAsFolder = new System.Windows.Forms.CheckBox();
            this.textBoxAditionalParametr = new System.Windows.Forms.TextBox();
            this.comboBoxHouseNumber = new System.Windows.Forms.ComboBox();
            this.comboBoxStreet = new System.Windows.Forms.ComboBox();
            this.labelAdditionalParamet = new System.Windows.Forms.Label();
            this.comboBoxLocation = new System.Windows.Forms.ComboBox();
            this.labelHouseNumber = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelStreet = new System.Windows.Forms.Label();
            this.comboBoxClientName = new System.Windows.Forms.ComboBox();
            this.groupBoxFolderCreate = new System.Windows.Forms.GroupBox();
            this.textBoxUserVersionFolderName = new System.Windows.Forms.TextBox();
            this.checkBoxUserVersionFolderName = new System.Windows.Forms.CheckBox();
            this.checkBoxApprovalInAdministration = new System.Windows.Forms.CheckBox();
            this.checkBoxProject = new System.Windows.Forms.CheckBox();
            this.checkBoxDesign = new System.Windows.Forms.CheckBox();
            this.checkBoxPhoto = new System.Windows.Forms.CheckBox();
            this.checkBoxDocument = new System.Windows.Forms.CheckBox();
            this.groupBoxClientObjects = new System.Windows.Forms.GroupBox();
            this.listBoxClientObjects = new System.Windows.Forms.ListBox();
            this.linkLabelVersion = new System.Windows.Forms.LinkLabel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonCreatFolder = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.groupBoxNewOject.SuspendLayout();
            this.groupBoxFolderCreate.SuspendLayout();
            this.groupBoxClientObjects.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelClientName
            // 
            this.labelClientName.AutoSize = true;
            this.labelClientName.Location = new System.Drawing.Point(7, 7);
            this.labelClientName.Margin = new System.Windows.Forms.Padding(0);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(137, 15);
            this.labelClientName.TabIndex = 0;
            this.labelClientName.Text = "Наименование клиента";
            // 
            // groupBoxNewOject
            // 
            this.groupBoxNewOject.Controls.Add(this.checkBoxLocationAsFolder);
            this.groupBoxNewOject.Controls.Add(this.textBoxAditionalParametr);
            this.groupBoxNewOject.Controls.Add(this.comboBoxHouseNumber);
            this.groupBoxNewOject.Controls.Add(this.comboBoxStreet);
            this.groupBoxNewOject.Controls.Add(this.labelAdditionalParamet);
            this.groupBoxNewOject.Controls.Add(this.comboBoxLocation);
            this.groupBoxNewOject.Controls.Add(this.labelHouseNumber);
            this.groupBoxNewOject.Controls.Add(this.labelLocation);
            this.groupBoxNewOject.Controls.Add(this.labelStreet);
            this.groupBoxNewOject.Location = new System.Drawing.Point(10, 57);
            this.groupBoxNewOject.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxNewOject.Name = "groupBoxNewOject";
            this.groupBoxNewOject.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxNewOject.Size = new System.Drawing.Size(308, 234);
            this.groupBoxNewOject.TabIndex = 1;
            this.groupBoxNewOject.TabStop = false;
            this.groupBoxNewOject.Text = "Новый объект";
            // 
            // checkBoxLocationAsFolder
            // 
            this.checkBoxLocationAsFolder.AutoSize = true;
            this.checkBoxLocationAsFolder.Location = new System.Drawing.Point(7, 205);
            this.checkBoxLocationAsFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxLocationAsFolder.Name = "checkBoxLocationAsFolder";
            this.checkBoxLocationAsFolder.Size = new System.Drawing.Size(248, 19);
            this.checkBoxLocationAsFolder.TabIndex = 10;
            this.checkBoxLocationAsFolder.Text = "НП - как папка, например у \"МОНЕТКА\"";
            this.checkBoxLocationAsFolder.UseVisualStyleBackColor = true;
            // 
            // textBoxAditionalParametr
            // 
            this.textBoxAditionalParametr.Location = new System.Drawing.Point(7, 175);
            this.textBoxAditionalParametr.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxAditionalParametr.Name = "textBoxAditionalParametr";
            this.textBoxAditionalParametr.Size = new System.Drawing.Size(293, 23);
            this.textBoxAditionalParametr.TabIndex = 9;
            // 
            // comboBoxHouseNumber
            // 
            this.comboBoxHouseNumber.FormattingEnabled = true;
            this.comboBoxHouseNumber.Location = new System.Drawing.Point(7, 129);
            this.comboBoxHouseNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxHouseNumber.Name = "comboBoxHouseNumber";
            this.comboBoxHouseNumber.Size = new System.Drawing.Size(293, 23);
            this.comboBoxHouseNumber.TabIndex = 8;
            // 
            // comboBoxStreet
            // 
            this.comboBoxStreet.FormattingEnabled = true;
            this.comboBoxStreet.Location = new System.Drawing.Point(7, 83);
            this.comboBoxStreet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxStreet.Name = "comboBoxStreet";
            this.comboBoxStreet.Size = new System.Drawing.Size(293, 23);
            this.comboBoxStreet.TabIndex = 7;
            // 
            // labelAdditionalParamet
            // 
            this.labelAdditionalParamet.AutoSize = true;
            this.labelAdditionalParamet.Location = new System.Drawing.Point(7, 157);
            this.labelAdditionalParamet.Margin = new System.Windows.Forms.Padding(0);
            this.labelAdditionalParamet.Name = "labelAdditionalParamet";
            this.labelAdditionalParamet.Size = new System.Drawing.Size(168, 15);
            this.labelAdditionalParamet.TabIndex = 6;
            this.labelAdditionalParamet.Text = "Дополнительные параметры";
            // 
            // comboBoxLocation
            // 
            this.comboBoxLocation.FormattingEnabled = true;
            this.comboBoxLocation.Location = new System.Drawing.Point(7, 37);
            this.comboBoxLocation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxLocation.Name = "comboBoxLocation";
            this.comboBoxLocation.Size = new System.Drawing.Size(293, 23);
            this.comboBoxLocation.TabIndex = 3;
            // 
            // labelHouseNumber
            // 
            this.labelHouseNumber.AutoSize = true;
            this.labelHouseNumber.Location = new System.Drawing.Point(7, 111);
            this.labelHouseNumber.Margin = new System.Windows.Forms.Padding(0);
            this.labelHouseNumber.Name = "labelHouseNumber";
            this.labelHouseNumber.Size = new System.Drawing.Size(76, 15);
            this.labelHouseNumber.TabIndex = 5;
            this.labelHouseNumber.Text = "Номер дома";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(7, 18);
            this.labelLocation.Margin = new System.Windows.Forms.Padding(0);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(140, 15);
            this.labelLocation.TabIndex = 3;
            this.labelLocation.Text = "Населённый пункт (НП)";
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new System.Drawing.Point(7, 65);
            this.labelStreet.Margin = new System.Windows.Forms.Padding(0);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(41, 15);
            this.labelStreet.TabIndex = 4;
            this.labelStreet.Text = "Улица";
            // 
            // comboBoxClientName
            // 
            this.comboBoxClientName.FormattingEnabled = true;
            this.comboBoxClientName.Location = new System.Drawing.Point(10, 25);
            this.comboBoxClientName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxClientName.Name = "comboBoxClientName";
            this.comboBoxClientName.Size = new System.Drawing.Size(307, 23);
            this.comboBoxClientName.Sorted = true;
            this.comboBoxClientName.TabIndex = 2;
            // 
            // groupBoxFolderCreate
            // 
            this.groupBoxFolderCreate.Controls.Add(this.textBoxUserVersionFolderName);
            this.groupBoxFolderCreate.Controls.Add(this.checkBoxUserVersionFolderName);
            this.groupBoxFolderCreate.Controls.Add(this.checkBoxApprovalInAdministration);
            this.groupBoxFolderCreate.Controls.Add(this.checkBoxProject);
            this.groupBoxFolderCreate.Controls.Add(this.checkBoxDesign);
            this.groupBoxFolderCreate.Controls.Add(this.checkBoxPhoto);
            this.groupBoxFolderCreate.Controls.Add(this.checkBoxDocument);
            this.groupBoxFolderCreate.Location = new System.Drawing.Point(10, 309);
            this.groupBoxFolderCreate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxFolderCreate.Name = "groupBoxFolderCreate";
            this.groupBoxFolderCreate.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxFolderCreate.Size = new System.Drawing.Size(308, 183);
            this.groupBoxFolderCreate.TabIndex = 3;
            this.groupBoxFolderCreate.TabStop = false;
            this.groupBoxFolderCreate.Text = "Создать папки";
            // 
            // textBoxUserVersionFolderName
            // 
            this.textBoxUserVersionFolderName.Location = new System.Drawing.Point(28, 151);
            this.textBoxUserVersionFolderName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxUserVersionFolderName.Name = "textBoxUserVersionFolderName";
            this.textBoxUserVersionFolderName.Size = new System.Drawing.Size(272, 23);
            this.textBoxUserVersionFolderName.TabIndex = 6;
            // 
            // checkBoxUserVersionFolderName
            // 
            this.checkBoxUserVersionFolderName.AutoSize = true;
            this.checkBoxUserVersionFolderName.Location = new System.Drawing.Point(7, 155);
            this.checkBoxUserVersionFolderName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxUserVersionFolderName.Name = "checkBoxUserVersionFolderName";
            this.checkBoxUserVersionFolderName.Size = new System.Drawing.Size(15, 14);
            this.checkBoxUserVersionFolderName.TabIndex = 5;
            this.checkBoxUserVersionFolderName.UseVisualStyleBackColor = true;
            // 
            // checkBoxApprovalInAdministration
            // 
            this.checkBoxApprovalInAdministration.AutoSize = true;
            this.checkBoxApprovalInAdministration.Location = new System.Drawing.Point(7, 128);
            this.checkBoxApprovalInAdministration.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxApprovalInAdministration.Name = "checkBoxApprovalInAdministration";
            this.checkBoxApprovalInAdministration.Size = new System.Drawing.Size(218, 19);
            this.checkBoxApprovalInAdministration.TabIndex = 4;
            this.checkBoxApprovalInAdministration.Text = "05 Согласование в администрации";
            this.checkBoxApprovalInAdministration.UseVisualStyleBackColor = true;
            // 
            // checkBoxProject
            // 
            this.checkBoxProject.AutoSize = true;
            this.checkBoxProject.Location = new System.Drawing.Point(7, 102);
            this.checkBoxProject.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxProject.Name = "checkBoxProject";
            this.checkBoxProject.Size = new System.Drawing.Size(81, 19);
            this.checkBoxProject.TabIndex = 3;
            this.checkBoxProject.Text = "04 Проект";
            this.checkBoxProject.UseVisualStyleBackColor = true;
            // 
            // checkBoxDesign
            // 
            this.checkBoxDesign.AutoSize = true;
            this.checkBoxDesign.Location = new System.Drawing.Point(7, 75);
            this.checkBoxDesign.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxDesign.Name = "checkBoxDesign";
            this.checkBoxDesign.Size = new System.Drawing.Size(81, 19);
            this.checkBoxDesign.TabIndex = 2;
            this.checkBoxDesign.Text = "03 Дизайн";
            this.checkBoxDesign.UseVisualStyleBackColor = true;
            // 
            // checkBoxPhoto
            // 
            this.checkBoxPhoto.AutoSize = true;
            this.checkBoxPhoto.Location = new System.Drawing.Point(7, 48);
            this.checkBoxPhoto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxPhoto.Name = "checkBoxPhoto";
            this.checkBoxPhoto.Size = new System.Drawing.Size(69, 19);
            this.checkBoxPhoto.TabIndex = 1;
            this.checkBoxPhoto.Text = "02 Фото";
            this.checkBoxPhoto.UseVisualStyleBackColor = true;
            // 
            // checkBoxDocument
            // 
            this.checkBoxDocument.AutoSize = true;
            this.checkBoxDocument.Location = new System.Drawing.Point(7, 22);
            this.checkBoxDocument.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxDocument.Name = "checkBoxDocument";
            this.checkBoxDocument.Size = new System.Drawing.Size(104, 19);
            this.checkBoxDocument.TabIndex = 0;
            this.checkBoxDocument.Text = "01 Документы";
            this.checkBoxDocument.UseVisualStyleBackColor = true;
            // 
            // groupBoxClientObjects
            // 
            this.groupBoxClientObjects.Controls.Add(this.listBoxClientObjects);
            this.groupBoxClientObjects.Location = new System.Drawing.Point(326, 57);
            this.groupBoxClientObjects.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxClientObjects.Name = "groupBoxClientObjects";
            this.groupBoxClientObjects.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxClientObjects.Size = new System.Drawing.Size(308, 436);
            this.groupBoxClientObjects.TabIndex = 4;
            this.groupBoxClientObjects.TabStop = false;
            this.groupBoxClientObjects.Text = "Существующие объекты клиента";
            // 
            // listBoxClientObjects
            // 
            this.listBoxClientObjects.FormattingEnabled = true;
            this.listBoxClientObjects.ItemHeight = 15;
            this.listBoxClientObjects.Location = new System.Drawing.Point(7, 16);
            this.listBoxClientObjects.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxClientObjects.Name = "listBoxClientObjects";
            this.listBoxClientObjects.Size = new System.Drawing.Size(293, 409);
            this.listBoxClientObjects.TabIndex = 0;
            // 
            // linkLabelVersion
            // 
            this.linkLabelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelVersion.Location = new System.Drawing.Point(284, 578);
            this.linkLabelVersion.Margin = new System.Windows.Forms.Padding(0);
            this.linkLabelVersion.Name = "linkLabelVersion";
            this.linkLabelVersion.Size = new System.Drawing.Size(350, 15);
            this.linkLabelVersion.TabIndex = 5;
            this.linkLabelVersion.TabStop = true;
            this.linkLabelVersion.Text = "VersionLable";
            this.linkLabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(546, 500);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(88, 27);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonCreatFolder
            // 
            this.buttonCreatFolder.Location = new System.Drawing.Point(398, 500);
            this.buttonCreatFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCreatFolder.Name = "buttonCreatFolder";
            this.buttonCreatFolder.Size = new System.Drawing.Size(141, 27);
            this.buttonCreatFolder.TabIndex = 6;
            this.buttonCreatFolder.Text = "Создать каталоги";
            this.buttonCreatFolder.UseVisualStyleBackColor = true;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(7, 530);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(53, 15);
            this.labelInfo.TabIndex = 7;
            this.labelInfo.Text = "labelInfo";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 603);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonCreatFolder);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.linkLabelVersion);
            this.Controls.Add(this.groupBoxClientObjects);
            this.Controls.Add(this.groupBoxFolderCreate);
            this.Controls.Add(this.comboBoxClientName);
            this.Controls.Add(this.groupBoxNewOject);
            this.Controls.Add(this.labelClientName);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "Создание каталогов по стандарту \"РТ групп\"";
            this.groupBoxNewOject.ResumeLayout(false);
            this.groupBoxNewOject.PerformLayout();
            this.groupBoxFolderCreate.ResumeLayout(false);
            this.groupBoxFolderCreate.PerformLayout();
            this.groupBoxClientObjects.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

            AppData.Clients = FileSistemOptions.GetListFolders();
            this.comboBoxClientName.DataSource = AppData.Clients;

            this.linkLabelVersion.Text = AppData.VersionApp;

            this.Init();
        }

        #endregion

        private System.Windows.Forms.Label labelClientName;
        private System.Windows.Forms.GroupBox groupBoxNewOject;
        private System.Windows.Forms.CheckBox checkBoxLocationAsFolder;
        private System.Windows.Forms.TextBox textBoxAditionalParametr;
        private System.Windows.Forms.ComboBox comboBoxHouseNumber;
        private System.Windows.Forms.ComboBox comboBoxStreet;
        private System.Windows.Forms.Label labelAdditionalParamet;
        private System.Windows.Forms.ComboBox comboBoxLocation;
        private System.Windows.Forms.Label labelHouseNumber;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.ComboBox comboBoxClientName;
        private System.Windows.Forms.GroupBox groupBoxFolderCreate;
        private System.Windows.Forms.TextBox textBoxUserVersionFolderName;
        private System.Windows.Forms.CheckBox checkBoxUserVersionFolderName;
        private System.Windows.Forms.CheckBox checkBoxApprovalInAdministration;
        private System.Windows.Forms.CheckBox checkBoxProject;
        private System.Windows.Forms.CheckBox checkBoxDesign;
        private System.Windows.Forms.CheckBox checkBoxPhoto;
        private System.Windows.Forms.CheckBox checkBoxDocument;
        private System.Windows.Forms.GroupBox groupBoxClientObjects;
        private System.Windows.Forms.LinkLabel linkLabelVersion;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonCreatFolder;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.ListBox listBoxClientObjects;


        private List<String> LocationNames = new List<String>();

        public void Init()
        {

            //DataJsonHelpers.LocationsFromJSON();

            //if (AppData.Locations == null) return;

            //comboBoxClientName.Items.Clear();

            //LocationNames.Add(AppData.Locations.Locations.First<>);

            //foreach (var location in AppData.Locations.Locations)
            //{
            //    //if (LocationNames.Count == 0) LocationNames.Add(location.LocationName);

            //    foreach (var loc in LocationNames)
            //    {
            //        if (!location.LocationName.Equals(loc))
            //        {
            //            LocationNames.Add(location.LocationName);
            //        }
            //    }
            //}

            //this.comboBoxLocation.DataSource = LocationNames;
        }
    }
}