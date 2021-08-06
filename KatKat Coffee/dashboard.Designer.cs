namespace KatKat_Coffee
{
    partial class dashboard
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
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.LinkLabel();
            this.btn_Exit = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.btnUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnBill = new Guna.UI2.WinForms.Guna2Button();
            this.btnPetInfor = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddPet = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemove = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddItem = new Guna.UI2.WinForms.Guna2Button();
            this.btnPlaceOrder = new Guna.UI2.WinForms.Guna2Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.uC_UserInfor1 = new KatKat_Coffee.AllUserControls.UC_UserInfor();
            this.uC_PetInfor1 = new KatKat_Coffee.AllUserControls.UC_PetInfor();
            this.uC_AddPet1 = new KatKat_Coffee.AllUserControls.UC_AddPet();
            this.uC_Remove1 = new KatKat_Coffee.AllUserControls.UC_Remove();
            this.uC_UpdateItem1 = new KatKat_Coffee.AllUserControls.UC_UpdateItem();
            this.uC_PlaceOrder1 = new KatKat_Coffee.AllUserControls.UC_PlaceOrder();
            this.uC_AddItem1 = new KatKat_Coffee.AllUserControls.UC_AddItem();
            this.uC_Welcome1 = new KatKat_Coffee.AllUserControls.UC_Welcome();
            this.uC_Bill1 = new KatKat_Coffee.AllUserControls.UC_Bill();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(242)))));
            this.panel3.Controls.Add(this.btnLogOut);
            this.panel3.Controls.Add(this.btn_Exit);
            this.panel3.Controls.Add(this.btnUser);
            this.panel3.Controls.Add(this.btnBill);
            this.panel3.Controls.Add(this.btnPetInfor);
            this.panel3.Controls.Add(this.btnAddPet);
            this.panel3.Controls.Add(this.btnRemove);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.btnAddItem);
            this.panel3.Controls.Add(this.btnPlaceOrder);
            this.guna2Transition1.SetDecoration(this.panel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 514);
            this.panel3.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.btnLogOut.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.btnLogOut, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnLogOut.LinkColor = System.Drawing.Color.Black;
            this.btnLogOut.Location = new System.Drawing.Point(57, 479);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(78, 24);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.TabStop = true;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnLogOut_LinkClicked);
            // 
            // btn_Exit
            // 
            this.btn_Exit.CheckedState.Parent = this.btn_Exit;
            this.btn_Exit.CustomImages.Parent = this.btn_Exit;
            this.guna2Transition1.SetDecoration(this.btn_Exit, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_Exit.DisabledState.Parent = this.btn_Exit;
            this.btn_Exit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.HoverState.Parent = this.btn_Exit;
            this.btn_Exit.Location = new System.Drawing.Point(3, 2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_Exit.ShadowDecoration.Parent = this.btn_Exit;
            this.btn_Exit.Size = new System.Drawing.Size(28, 29);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.Text = "X";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btnUser
            // 
            this.btnUser.BorderRadius = 10;
            this.btnUser.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(224)))), ((int)(((byte)(254)))));
            this.btnUser.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.btnUser.CheckedState.Parent = this.btnUser;
            this.btnUser.CustomImages.Parent = this.btnUser;
            this.guna2Transition1.SetDecoration(this.btnUser, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(180)))), ((int)(((byte)(219)))));
            this.btnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)), true);
            this.btnUser.ForeColor = System.Drawing.Color.Black;
            this.btnUser.HoverState.Parent = this.btnUser;
            this.btnUser.Location = new System.Drawing.Point(55, 304);
            this.btnUser.Name = "btnUser";
            this.btnUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnUser.ShadowDecoration.Parent = this.btnUser;
            this.btnUser.Size = new System.Drawing.Size(150, 30);
            this.btnUser.TabIndex = 0;
            this.btnUser.Text = "Users Infor";
            this.btnUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnBill
            // 
            this.btnBill.BorderRadius = 10;
            this.btnBill.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(224)))), ((int)(((byte)(254)))));
            this.btnBill.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.btnBill.CheckedState.Parent = this.btnBill;
            this.btnBill.CustomImages.Parent = this.btnBill;
            this.guna2Transition1.SetDecoration(this.btnBill, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnBill.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(180)))), ((int)(((byte)(219)))));
            this.btnBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)), true);
            this.btnBill.ForeColor = System.Drawing.Color.Black;
            this.btnBill.HoverState.Parent = this.btnBill;
            this.btnBill.Location = new System.Drawing.Point(55, 268);
            this.btnBill.Name = "btnBill";
            this.btnBill.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnBill.ShadowDecoration.Parent = this.btnBill;
            this.btnBill.Size = new System.Drawing.Size(150, 30);
            this.btnBill.TabIndex = 0;
            this.btnBill.Text = "Total Bill";
            this.btnBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnPetInfor
            // 
            this.btnPetInfor.BorderRadius = 10;
            this.btnPetInfor.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(224)))), ((int)(((byte)(254)))));
            this.btnPetInfor.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.btnPetInfor.CheckedState.Parent = this.btnPetInfor;
            this.btnPetInfor.CustomImages.Parent = this.btnPetInfor;
            this.guna2Transition1.SetDecoration(this.btnPetInfor, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnPetInfor.DisabledState.Parent = this.btnPetInfor;
            this.btnPetInfor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(180)))), ((int)(((byte)(219)))));
            this.btnPetInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)), true);
            this.btnPetInfor.ForeColor = System.Drawing.Color.Black;
            this.btnPetInfor.HoverState.Parent = this.btnPetInfor;
            this.btnPetInfor.Location = new System.Drawing.Point(53, 232);
            this.btnPetInfor.Name = "btnPetInfor";
            this.btnPetInfor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnPetInfor.ShadowDecoration.Parent = this.btnPetInfor;
            this.btnPetInfor.Size = new System.Drawing.Size(150, 30);
            this.btnPetInfor.TabIndex = 0;
            this.btnPetInfor.Text = "Pet Infor";
            this.btnPetInfor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnPetInfor.Click += new System.EventHandler(this.btnPetInfor_Click);
            // 
            // btnAddPet
            // 
            this.btnAddPet.BorderRadius = 10;
            this.btnAddPet.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(224)))), ((int)(((byte)(254)))));
            this.btnAddPet.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.btnAddPet.CheckedState.Parent = this.btnAddPet;
            this.btnAddPet.CustomImages.Parent = this.btnAddPet;
            this.guna2Transition1.SetDecoration(this.btnAddPet, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnAddPet.DisabledState.Parent = this.btnAddPet;
            this.btnAddPet.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(180)))), ((int)(((byte)(219)))));
            this.btnAddPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)), true);
            this.btnAddPet.ForeColor = System.Drawing.Color.Black;
            this.btnAddPet.HoverState.Parent = this.btnAddPet;
            this.btnAddPet.Location = new System.Drawing.Point(53, 196);
            this.btnAddPet.Name = "btnAddPet";
            this.btnAddPet.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAddPet.ShadowDecoration.Parent = this.btnAddPet;
            this.btnAddPet.Size = new System.Drawing.Size(150, 30);
            this.btnAddPet.TabIndex = 0;
            this.btnAddPet.Text = "Add Pets";
            this.btnAddPet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAddPet.Click += new System.EventHandler(this.btnAddPet_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BorderRadius = 10;
            this.btnRemove.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(224)))), ((int)(((byte)(254)))));
            this.btnRemove.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.btnRemove.CheckedState.Parent = this.btnRemove;
            this.btnRemove.CustomImages.Parent = this.btnRemove;
            this.guna2Transition1.SetDecoration(this.btnRemove, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnRemove.DisabledState.Parent = this.btnRemove;
            this.btnRemove.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(180)))), ((int)(((byte)(219)))));
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)), true);
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.HoverState.Parent = this.btnRemove;
            this.btnRemove.Location = new System.Drawing.Point(53, 160);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnRemove.ShadowDecoration.Parent = this.btnRemove;
            this.btnRemove.Size = new System.Drawing.Size(150, 30);
            this.btnRemove.TabIndex = 0;
            this.btnRemove.Text = "Remove Items";
            this.btnRemove.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 10;
            this.btnUpdate.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(224)))), ((int)(((byte)(254)))));
            this.btnUpdate.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.guna2Transition1.SetDecoration(this.btnUpdate, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnUpdate.DisabledState.Parent = this.btnUpdate;
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(180)))), ((int)(((byte)(219)))));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)), true);
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Location = new System.Drawing.Point(53, 124);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(150, 30);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update Items";
            this.btnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.BorderRadius = 10;
            this.btnAddItem.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(224)))), ((int)(((byte)(254)))));
            this.btnAddItem.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.btnAddItem.CheckedState.Parent = this.btnAddItem;
            this.btnAddItem.CustomImages.Parent = this.btnAddItem;
            this.guna2Transition1.SetDecoration(this.btnAddItem, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnAddItem.DisabledState.Parent = this.btnAddItem;
            this.btnAddItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(180)))), ((int)(((byte)(219)))));
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)), true);
            this.btnAddItem.ForeColor = System.Drawing.Color.Black;
            this.btnAddItem.HoverState.Parent = this.btnAddItem;
            this.btnAddItem.Location = new System.Drawing.Point(53, 88);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAddItem.ShadowDecoration.Parent = this.btnAddItem;
            this.btnAddItem.Size = new System.Drawing.Size(150, 30);
            this.btnAddItem.TabIndex = 0;
            this.btnAddItem.Text = "Add Items";
            this.btnAddItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BorderRadius = 10;
            this.btnPlaceOrder.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(224)))), ((int)(((byte)(254)))));
            this.btnPlaceOrder.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.btnPlaceOrder.CheckedState.Parent = this.btnPlaceOrder;
            this.btnPlaceOrder.CustomImages.Parent = this.btnPlaceOrder;
            this.guna2Transition1.SetDecoration(this.btnPlaceOrder, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnPlaceOrder.DisabledState.Parent = this.btnPlaceOrder;
            this.btnPlaceOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(180)))), ((int)(((byte)(219)))));
            this.btnPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)), true);
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.Black;
            this.btnPlaceOrder.HoverState.Parent = this.btnPlaceOrder;
            this.btnPlaceOrder.Location = new System.Drawing.Point(53, 52);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnPlaceOrder.ShadowDecoration.Parent = this.btnPlaceOrder;
            this.btnPlaceOrder.Size = new System.Drawing.Size(150, 30);
            this.btnPlaceOrder.TabIndex = 0;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.uC_Bill1);
            this.panel4.Controls.Add(this.uC_UserInfor1);
            this.panel4.Controls.Add(this.uC_PetInfor1);
            this.panel4.Controls.Add(this.uC_AddPet1);
            this.panel4.Controls.Add(this.uC_Remove1);
            this.panel4.Controls.Add(this.uC_UpdateItem1);
            this.panel4.Controls.Add(this.uC_PlaceOrder1);
            this.panel4.Controls.Add(this.uC_AddItem1);
            this.panel4.Controls.Add(this.uC_Welcome1);
            this.guna2Transition1.SetDecoration(this.panel4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel4.Location = new System.Drawing.Point(211, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(781, 514);
            this.panel4.TabIndex = 1;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this.panel3;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this.panel4;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this.panel4;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlideAndRotate;
            this.guna2Transition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(50);
            animation2.RotateCoeff = 0.3F;
            animation2.RotateLimit = 0.2F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation2;
            this.guna2Transition1.MaxAnimationTime = 3000;
            // 
            // uC_UserInfor1
            // 
            this.guna2Transition1.SetDecoration(this.uC_UserInfor1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_UserInfor1.Location = new System.Drawing.Point(0, -3);
            this.uC_UserInfor1.Name = "uC_UserInfor1";
            this.uC_UserInfor1.Size = new System.Drawing.Size(781, 514);
            this.uC_UserInfor1.TabIndex = 8;
            // 
            // uC_PetInfor1
            // 
            this.uC_PetInfor1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_PetInfor1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_PetInfor1.Location = new System.Drawing.Point(0, 0);
            this.uC_PetInfor1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_PetInfor1.Name = "uC_PetInfor1";
            this.uC_PetInfor1.Size = new System.Drawing.Size(781, 587);
            this.uC_PetInfor1.TabIndex = 7;
            this.uC_PetInfor1.Load += new System.EventHandler(this.uC_PetInfor1_Load);
            // 
            // uC_AddPet1
            // 
            this.uC_AddPet1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_AddPet1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_AddPet1.Location = new System.Drawing.Point(0, 0);
            this.uC_AddPet1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_AddPet1.Name = "uC_AddPet1";
            this.uC_AddPet1.Size = new System.Drawing.Size(781, 514);
            this.uC_AddPet1.TabIndex = 6;
            // 
            // uC_Remove1
            // 
            this.uC_Remove1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_Remove1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_Remove1.Location = new System.Drawing.Point(0, 0);
            this.uC_Remove1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_Remove1.Name = "uC_Remove1";
            this.uC_Remove1.Size = new System.Drawing.Size(781, 514);
            this.uC_Remove1.TabIndex = 5;
            // 
            // uC_UpdateItem1
            // 
            this.uC_UpdateItem1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_UpdateItem1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_UpdateItem1.Location = new System.Drawing.Point(0, 0);
            this.uC_UpdateItem1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_UpdateItem1.Name = "uC_UpdateItem1";
            this.uC_UpdateItem1.Size = new System.Drawing.Size(781, 514);
            this.uC_UpdateItem1.TabIndex = 4;
            // 
            // uC_PlaceOrder1
            // 
            this.uC_PlaceOrder1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_PlaceOrder1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_PlaceOrder1.Location = new System.Drawing.Point(0, 0);
            this.uC_PlaceOrder1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_PlaceOrder1.Name = "uC_PlaceOrder1";
            this.uC_PlaceOrder1.Size = new System.Drawing.Size(781, 514);
            this.uC_PlaceOrder1.TabIndex = 3;
            // 
            // uC_AddItem1
            // 
            this.uC_AddItem1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_AddItem1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_AddItem1.Location = new System.Drawing.Point(0, 0);
            this.uC_AddItem1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_AddItem1.Name = "uC_AddItem1";
            this.uC_AddItem1.Size = new System.Drawing.Size(781, 514);
            this.uC_AddItem1.TabIndex = 2;
            // 
            // uC_Welcome1
            // 
            this.uC_Welcome1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_Welcome1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_Welcome1.Location = new System.Drawing.Point(0, 0);
            this.uC_Welcome1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_Welcome1.Name = "uC_Welcome1";
            this.uC_Welcome1.Size = new System.Drawing.Size(781, 514);
            this.uC_Welcome1.TabIndex = 1;
            // 
            // uC_Bill1
            // 
            this.guna2Transition1.SetDecoration(this.uC_Bill1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_Bill1.Location = new System.Drawing.Point(0, 0);
            this.uC_Bill1.Name = "uC_Bill1";
            this.uC_Bill1.Size = new System.Drawing.Size(781, 514);
            this.uC_Bill1.TabIndex = 9;
            // 
            // dashboard
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1004, 541);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnExit;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btnPetInfor;
        private Guna.UI2.WinForms.Guna2Button btnAddPet;
        private Guna.UI2.WinForms.Guna2Button btnRemove;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnAddItem;
        private Guna.UI2.WinForms.Guna2Button btnPlaceOrder;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btn_Exit;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private System.Windows.Forms.LinkLabel btnLogOut;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private AllUserControls.UC_Welcome uC_Welcome1;
        private AllUserControls.UC_AddItem uC_AddItem1;
        private AllUserControls.UC_PlaceOrder uC_PlaceOrder1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private AllUserControls.UC_UpdateItem uC_UpdateItem1;
        private AllUserControls.UC_Remove uC_Remove1;
        private AllUserControls.UC_AddPet uC_AddPet1;
        private AllUserControls.UC_PetInfor uC_PetInfor1;
        private Guna.UI2.WinForms.Guna2Button btnUser;
        private Guna.UI2.WinForms.Guna2Button btnBill;
        private AllUserControls.UC_UserInfor uC_UserInfor1;
        private AllUserControls.UC_Bill uC_Bill1;
    }
}