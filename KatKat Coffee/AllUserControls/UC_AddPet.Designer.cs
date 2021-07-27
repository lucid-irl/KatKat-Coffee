namespace KatKat_Coffee.AllUserControls
{
    partial class UC_AddPet
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAddPet = new Guna.UI2.WinForms.Guna2Button();
            this.txtPetName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSpecies = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtColor = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtOwner = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddPet
            // 
            this.btnAddPet.BorderRadius = 26;
            this.btnAddPet.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnAddPet.CheckedState.Parent = this.btnAddPet;
            this.btnAddPet.CustomImages.Parent = this.btnAddPet;
            this.btnAddPet.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.btnAddPet.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAddPet.ForeColor = System.Drawing.Color.Black;
            this.btnAddPet.HoverState.Parent = this.btnAddPet;
            this.btnAddPet.Location = new System.Drawing.Point(295, 427);
            this.btnAddPet.Name = "btnAddPet";
            this.btnAddPet.ShadowDecoration.Parent = this.btnAddPet;
            this.btnAddPet.Size = new System.Drawing.Size(180, 51);
            this.btnAddPet.TabIndex = 11;
            this.btnAddPet.Text = "Add Pet";
            this.btnAddPet.Click += new System.EventHandler(this.btnAddPet_Click);
            // 
            // txtPetName
            // 
            this.txtPetName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPetName.DefaultText = "";
            this.txtPetName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPetName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPetName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPetName.DisabledState.Parent = this.txtPetName;
            this.txtPetName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPetName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPetName.FocusedState.Parent = this.txtPetName;
            this.txtPetName.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtPetName.ForeColor = System.Drawing.Color.Black;
            this.txtPetName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPetName.HoverState.Parent = this.txtPetName;
            this.txtPetName.Location = new System.Drawing.Point(111, 168);
            this.txtPetName.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtPetName.Name = "txtPetName";
            this.txtPetName.PasswordChar = '\0';
            this.txtPetName.PlaceholderText = "";
            this.txtPetName.SelectedText = "";
            this.txtPetName.ShadowDecoration.Parent = this.txtPetName;
            this.txtPetName.Size = new System.Drawing.Size(282, 36);
            this.txtPetName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtPetName.TabIndex = 9;
            // 
            // txtSpecies
            // 
            this.txtSpecies.BackColor = System.Drawing.Color.Transparent;
            this.txtSpecies.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtSpecies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSpecies.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSpecies.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSpecies.FocusedState.Parent = this.txtSpecies;
            this.txtSpecies.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 12F, System.Drawing.FontStyle.Bold);
            this.txtSpecies.ForeColor = System.Drawing.Color.Black;
            this.txtSpecies.HoverState.Parent = this.txtSpecies;
            this.txtSpecies.ItemHeight = 30;
            this.txtSpecies.Items.AddRange(new object[] {
            "Dog",
            "Cat",
            "Bird",
            "Mouse",
            "Fish"});
            this.txtSpecies.ItemsAppearance.Parent = this.txtSpecies;
            this.txtSpecies.Location = new System.Drawing.Point(111, 265);
            this.txtSpecies.Name = "txtSpecies";
            this.txtSpecies.ShadowDecoration.Parent = this.txtSpecies;
            this.txtSpecies.Size = new System.Drawing.Size(282, 36);
            this.txtSpecies.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSpecies.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(180)))), ((int)(((byte)(219)))));
            this.label4.Location = new System.Drawing.Point(420, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(180)))), ((int)(((byte)(219)))));
            this.label3.Location = new System.Drawing.Point(107, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pet Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(180)))), ((int)(((byte)(219)))));
            this.label2.Location = new System.Drawing.Point(107, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Species";
            // 
            // txtColor
            // 
            this.txtColor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtColor.DefaultText = "";
            this.txtColor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtColor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtColor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtColor.DisabledState.Parent = this.txtColor;
            this.txtColor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtColor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtColor.FocusedState.Parent = this.txtColor;
            this.txtColor.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtColor.ForeColor = System.Drawing.Color.Black;
            this.txtColor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtColor.HoverState.Parent = this.txtColor;
            this.txtColor.Location = new System.Drawing.Point(424, 168);
            this.txtColor.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtColor.Name = "txtColor";
            this.txtColor.PasswordChar = '\0';
            this.txtColor.PlaceholderText = "";
            this.txtColor.SelectedText = "";
            this.txtColor.ShadowDecoration.Parent = this.txtColor;
            this.txtColor.Size = new System.Drawing.Size(282, 36);
            this.txtColor.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtColor.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(270, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 41);
            this.label1.TabIndex = 7;
            this.label1.Text = "Add New Pet";
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(78)))), ((int)(((byte)(204)))));
            this.rectangleShape1.BorderWidth = 3;
            this.rectangleShape1.CornerRadius = 30;
            this.rectangleShape1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(204)))));
            this.rectangleShape1.Location = new System.Drawing.Point(14, 14);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(752, 487);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(781, 514);
            this.shapeContainer1.TabIndex = 12;
            this.shapeContainer1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(180)))), ((int)(((byte)(219)))));
            this.label5.Location = new System.Drawing.Point(420, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Gender";
            // 
            // txtGender
            // 
            this.txtGender.BackColor = System.Drawing.Color.Transparent;
            this.txtGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtGender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGender.FocusedState.Parent = this.txtGender;
            this.txtGender.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 12F, System.Drawing.FontStyle.Bold);
            this.txtGender.ForeColor = System.Drawing.Color.Black;
            this.txtGender.HoverState.Parent = this.txtGender;
            this.txtGender.ItemHeight = 30;
            this.txtGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.txtGender.ItemsAppearance.Parent = this.txtGender;
            this.txtGender.Location = new System.Drawing.Point(424, 265);
            this.txtGender.Name = "txtGender";
            this.txtGender.ShadowDecoration.Parent = this.txtGender;
            this.txtGender.Size = new System.Drawing.Size(282, 36);
            this.txtGender.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtGender.TabIndex = 8;
            // 
            // txtOwner
            // 
            this.txtOwner.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOwner.DefaultText = "";
            this.txtOwner.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOwner.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOwner.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOwner.DisabledState.Parent = this.txtOwner;
            this.txtOwner.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOwner.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOwner.FocusedState.Parent = this.txtOwner;
            this.txtOwner.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtOwner.ForeColor = System.Drawing.Color.Black;
            this.txtOwner.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOwner.HoverState.Parent = this.txtOwner;
            this.txtOwner.Location = new System.Drawing.Point(247, 364);
            this.txtOwner.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.PasswordChar = '\0';
            this.txtOwner.PlaceholderText = "";
            this.txtOwner.SelectedText = "";
            this.txtOwner.ShadowDecoration.Parent = this.txtOwner;
            this.txtOwner.Size = new System.Drawing.Size(282, 36);
            this.txtOwner.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtOwner.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(180)))), ((int)(((byte)(219)))));
            this.label6.Location = new System.Drawing.Point(243, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Owner";
            // 
            // UC_AddPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.btnAddPet);
            this.Controls.Add(this.txtSpecies);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOwner);
            this.Controls.Add(this.txtPetName);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "UC_AddPet";
            this.Size = new System.Drawing.Size(781, 514);
            this.Leave += new System.EventHandler(this.UC_AddPet_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnAddPet;
        private Guna.UI2.WinForms.Guna2TextBox txtPetName;
        private Guna.UI2.WinForms.Guna2ComboBox txtSpecies;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtColor;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox txtGender;
        private Guna.UI2.WinForms.Guna2TextBox txtOwner;
    }
}
