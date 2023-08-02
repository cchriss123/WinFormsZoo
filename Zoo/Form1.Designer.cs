namespace Zoo
{
    partial class Form1
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
            this.textBoxHours = new System.Windows.Forms.TextBox();
            this.textBoxFee = new System.Windows.Forms.TextBox();
            this.confirmOpeningHours = new System.Windows.Forms.Button();
            this.confirmEntranceFee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxProperties = new System.Windows.Forms.TextBox();
            this.textBoxVisitorName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.confirmAddVisitor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxVisitors = new System.Windows.Forms.ListBox();
            this.listBoxAnimals = new System.Windows.Forms.ListBox();
            this.textBoxAnimalName = new System.Windows.Forms.TextBox();
            this.textBoxAnimalAge = new System.Windows.Forms.TextBox();
            this.comboBoxAnimalType = new System.Windows.Forms.ComboBox();
            this.confirmAddAnimal = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.callZooKeeper = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxKeeperResponse = new System.Windows.Forms.TextBox();
            this.buttonFeed = new System.Windows.Forms.Button();
            this.buttonInteract = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxHours
            // 
            this.textBoxHours.Location = new System.Drawing.Point(380, 76);
            this.textBoxHours.Name = "textBoxHours";
            this.textBoxHours.Size = new System.Drawing.Size(100, 20);
            this.textBoxHours.TabIndex = 0;
            // 
            // textBoxFee
            // 
            this.textBoxFee.Location = new System.Drawing.Point(380, 115);
            this.textBoxFee.Name = "textBoxFee";
            this.textBoxFee.Size = new System.Drawing.Size(100, 20);
            this.textBoxFee.TabIndex = 1;
            // 
            // confirmOpeningHours
            // 
            this.confirmOpeningHours.Location = new System.Drawing.Point(503, 75);
            this.confirmOpeningHours.Name = "confirmOpeningHours";
            this.confirmOpeningHours.Size = new System.Drawing.Size(93, 23);
            this.confirmOpeningHours.TabIndex = 2;
            this.confirmOpeningHours.Text = "Ändra öppettider";
            this.confirmOpeningHours.UseVisualStyleBackColor = true;
            this.confirmOpeningHours.Click += new System.EventHandler(this.ConfirmOpeningHours_Click);
            // 
            // confirmEntranceFee
            // 
            this.confirmEntranceFee.Location = new System.Drawing.Point(503, 114);
            this.confirmEntranceFee.Name = "confirmEntranceFee";
            this.confirmEntranceFee.Size = new System.Drawing.Size(93, 23);
            this.confirmEntranceFee.TabIndex = 3;
            this.confirmEntranceFee.Text = "Ändra pris";
            this.confirmEntranceFee.UseVisualStyleBackColor = true;
            this.confirmEntranceFee.Click += new System.EventHandler(this.ConfirmEntranceFee_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Skriv in öppettider";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Skriv in pris";
            // 
            // textBoxProperties
            // 
            this.textBoxProperties.Location = new System.Drawing.Point(20, 76);
            this.textBoxProperties.Name = "textBoxProperties";
            this.textBoxProperties.ReadOnly = true;
            this.textBoxProperties.Size = new System.Drawing.Size(333, 20);
            this.textBoxProperties.TabIndex = 6;
            // 
            // textBoxVisitorName
            // 
            this.textBoxVisitorName.Location = new System.Drawing.Point(20, 221);
            this.textBoxVisitorName.Name = "textBoxVisitorName";
            this.textBoxVisitorName.Size = new System.Drawing.Size(100, 20);
            this.textBoxVisitorName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Skriv in namn";
            // 
            // confirmAddVisitor
            // 
            this.confirmAddVisitor.Location = new System.Drawing.Point(20, 259);
            this.confirmAddVisitor.Name = "confirmAddVisitor";
            this.confirmAddVisitor.Size = new System.Drawing.Size(100, 23);
            this.confirmAddVisitor.TabIndex = 10;
            this.confirmAddVisitor.Text = "Lägg till besökare";
            this.confirmAddVisitor.UseVisualStyleBackColor = true;
            this.confirmAddVisitor.Click += new System.EventHandler(this.ConfirmNewVisitor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Välj besökare";
            // 
            // listBoxVisitors
            // 
            this.listBoxVisitors.FormattingEnabled = true;
            this.listBoxVisitors.Location = new System.Drawing.Point(20, 322);
            this.listBoxVisitors.Name = "listBoxVisitors";
            this.listBoxVisitors.Size = new System.Drawing.Size(172, 173);
            this.listBoxVisitors.TabIndex = 12;
            // 
            // listBoxAnimals
            // 
            this.listBoxAnimals.Location = new System.Drawing.Point(253, 322);
            this.listBoxAnimals.Name = "listBoxAnimals";
            this.listBoxAnimals.Size = new System.Drawing.Size(435, 173);
            this.listBoxAnimals.TabIndex = 0;
            // 
            // textBoxAnimalName
            // 
            this.textBoxAnimalName.Location = new System.Drawing.Point(253, 220);
            this.textBoxAnimalName.Name = "textBoxAnimalName";
            this.textBoxAnimalName.Size = new System.Drawing.Size(100, 20);
            this.textBoxAnimalName.TabIndex = 13;
            // 
            // textBoxAnimalAge
            // 
            this.textBoxAnimalAge.Location = new System.Drawing.Point(380, 221);
            this.textBoxAnimalAge.Name = "textBoxAnimalAge";
            this.textBoxAnimalAge.Size = new System.Drawing.Size(100, 20);
            this.textBoxAnimalAge.TabIndex = 14;
            // 
            // comboBoxAnimalType
            // 
            this.comboBoxAnimalType.FormattingEnabled = true;
            this.comboBoxAnimalType.Location = new System.Drawing.Point(253, 261);
            this.comboBoxAnimalType.Name = "comboBoxAnimalType";
            this.comboBoxAnimalType.Size = new System.Drawing.Size(100, 21);
            this.comboBoxAnimalType.TabIndex = 15;
            // 
            // confirmAddAnimal
            // 
            this.confirmAddAnimal.Location = new System.Drawing.Point(380, 257);
            this.confirmAddAnimal.Name = "confirmAddAnimal";
            this.confirmAddAnimal.Size = new System.Drawing.Size(100, 23);
            this.confirmAddAnimal.TabIndex = 16;
            this.confirmAddAnimal.Text = "Lägg till djur";
            this.confirmAddAnimal.UseVisualStyleBackColor = true;
            this.confirmAddAnimal.Click += new System.EventHandler(this.confirmAddAnimal_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Skriv in namn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(377, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Skriv in ålder";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(250, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Välj djurart";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(250, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Välj djur";
            // 
            // callZooKeeper
            // 
            this.callZooKeeper.Location = new System.Drawing.Point(57, 524);
            this.callZooKeeper.Name = "callZooKeeper";
            this.callZooKeeper.Size = new System.Drawing.Size(107, 23);
            this.callZooKeeper.TabIndex = 21;
            this.callZooKeeper.Text = "Anropa djurskötare";
            this.callZooKeeper.UseVisualStyleBackColor = true;
            this.callZooKeeper.Click += new System.EventHandler(this.callZooKeeper_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Öppettider och pris";
            // 
            // textBoxKeeperResponse
            // 
            this.textBoxKeeperResponse.Location = new System.Drawing.Point(253, 525);
            this.textBoxKeeperResponse.Multiline = true;
            this.textBoxKeeperResponse.Name = "textBoxKeeperResponse";
            this.textBoxKeeperResponse.ReadOnly = true;
            this.textBoxKeeperResponse.Size = new System.Drawing.Size(435, 51);
            this.textBoxKeeperResponse.TabIndex = 23;
            // 
            // buttonFeed
            // 
            this.buttonFeed.Location = new System.Drawing.Point(23, 553);
            this.buttonFeed.Name = "buttonFeed";
            this.buttonFeed.Size = new System.Drawing.Size(75, 23);
            this.buttonFeed.TabIndex = 24;
            this.buttonFeed.Text = "Feed ";
            this.buttonFeed.UseVisualStyleBackColor = true;
            this.buttonFeed.Visible = false;
            this.buttonFeed.Click += new System.EventHandler(this.buttonFeed_Click);
            // 
            // buttonInteract
            // 
            this.buttonInteract.Location = new System.Drawing.Point(120, 553);
            this.buttonInteract.Name = "buttonInteract";
            this.buttonInteract.Size = new System.Drawing.Size(75, 23);
            this.buttonInteract.TabIndex = 25;
            this.buttonInteract.Text = "Interact";
            this.buttonInteract.UseVisualStyleBackColor = true;
            this.buttonInteract.Visible = false;
            this.buttonInteract.Click += new System.EventHandler(this.buttonInteract_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(250, 509);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Händelselog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 695);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonInteract);
            this.Controls.Add(this.buttonFeed);
            this.Controls.Add(this.textBoxKeeperResponse);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.callZooKeeper);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.confirmAddAnimal);
            this.Controls.Add(this.comboBoxAnimalType);
            this.Controls.Add(this.textBoxAnimalAge);
            this.Controls.Add(this.textBoxAnimalName);
            this.Controls.Add(this.listBoxAnimals);
            this.Controls.Add(this.listBoxVisitors);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.confirmAddVisitor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxVisitorName);
            this.Controls.Add(this.textBoxProperties);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmEntranceFee);
            this.Controls.Add(this.confirmOpeningHours);
            this.Controls.Add(this.textBoxFee);
            this.Controls.Add(this.textBoxHours);
            this.Name = "Form1";
            this.Text = "ZooApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxHours;
        private System.Windows.Forms.TextBox textBoxFee;
        private System.Windows.Forms.Button confirmOpeningHours;
        private System.Windows.Forms.Button confirmEntranceFee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxProperties;
        private System.Windows.Forms.TextBox textBoxVisitorName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button confirmAddVisitor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxVisitors;
        private System.Windows.Forms.ListBox listBoxAnimals;
        private System.Windows.Forms.TextBox textBoxAnimalName;
        private System.Windows.Forms.TextBox textBoxAnimalAge;
        private System.Windows.Forms.ComboBox comboBoxAnimalType;
        private System.Windows.Forms.Button confirmAddAnimal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button callZooKeeper;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxKeeperResponse;
        private System.Windows.Forms.Button buttonFeed;
        private System.Windows.Forms.Button buttonInteract;
        private System.Windows.Forms.Label label10;
    }
}

