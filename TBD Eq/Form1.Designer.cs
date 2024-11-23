
namespace TBD_Eq
{
    partial class FormHub
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHead = new System.Windows.Forms.Panel();
            this.pbHead = new System.Windows.Forms.PictureBox();
            this.pbShoppingCart = new System.Windows.Forms.PictureBox();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.pnlFormsCenter = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnModifyProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.pnlHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShoppingCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.pnlFormsCenter.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHead
            // 
            this.pnlHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(196)))));
            this.pnlHead.Controls.Add(this.pbHead);
            this.pnlHead.Controls.Add(this.pbShoppingCart);
            this.pnlHead.Controls.Add(this.pbUser);
            this.pnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHead.Location = new System.Drawing.Point(0, 0);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(972, 71);
            this.pnlHead.TabIndex = 0;
            // 
            // pbHead
            // 
            this.pbHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(205)))), ((int)(((byte)(191)))));
            this.pbHead.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbHead.Image = global::TBD_Eq.Properties.Resources.Logo1;
            this.pbHead.Location = new System.Drawing.Point(0, 0);
            this.pbHead.Name = "pbHead";
            this.pbHead.Size = new System.Drawing.Size(819, 71);
            this.pbHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHead.TabIndex = 2;
            this.pbHead.TabStop = false;
            this.pbHead.Click += new System.EventHandler(this.pbHead_Click);
            // 
            // pbShoppingCart
            // 
            this.pbShoppingCart.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbShoppingCart.Image = global::TBD_Eq.Properties.Resources.Carrito;
            this.pbShoppingCart.Location = new System.Drawing.Point(828, 0);
            this.pbShoppingCart.Name = "pbShoppingCart";
            this.pbShoppingCart.Size = new System.Drawing.Size(71, 71);
            this.pbShoppingCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbShoppingCart.TabIndex = 1;
            this.pbShoppingCart.TabStop = false;
            // 
            // pbUser
            // 
            this.pbUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbUser.Image = global::TBD_Eq.Properties.Resources.User1;
            this.pbUser.Location = new System.Drawing.Point(899, 0);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(73, 71);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUser.TabIndex = 0;
            this.pbUser.TabStop = false;
            this.pbUser.Click += new System.EventHandler(this.pbUser_Click);
            // 
            // pnlFormsCenter
            // 
            this.pnlFormsCenter.AutoScroll = true;
            this.pnlFormsCenter.AutoScrollMargin = new System.Drawing.Size(0, 10);
            this.pnlFormsCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(210)))), ((int)(((byte)(191)))));
            this.pnlFormsCenter.Controls.Add(this.pnlMenu);
            this.pnlFormsCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormsCenter.Location = new System.Drawing.Point(0, 0);
            this.pnlFormsCenter.Name = "pnlFormsCenter";
            this.pnlFormsCenter.Size = new System.Drawing.Size(972, 614);
            this.pnlFormsCenter.TabIndex = 1;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnLogOut);
            this.pnlMenu.Controls.Add(this.btnModifyProduct);
            this.pnlMenu.Controls.Add(this.btnAddProduct);
            this.pnlMenu.Controls.Add(this.btnProfile);
            this.pnlMenu.Location = new System.Drawing.Point(828, 71);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(140, 214);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(0, 170);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(140, 43);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnModifyProduct
            // 
            this.btnModifyProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModifyProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModifyProduct.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyProduct.Location = new System.Drawing.Point(0, 104);
            this.btnModifyProduct.Name = "btnModifyProduct";
            this.btnModifyProduct.Size = new System.Drawing.Size(140, 66);
            this.btnModifyProduct.TabIndex = 4;
            this.btnModifyProduct.Text = "Modificar Producto";
            this.btnModifyProduct.UseVisualStyleBackColor = true;
            this.btnModifyProduct.Click += new System.EventHandler(this.btnModifyProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Location = new System.Drawing.Point(0, 40);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(140, 64);
            this.btnAddProduct.TabIndex = 3;
            this.btnAddProduct.Text = "Agregar Producto";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProfile.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Location = new System.Drawing.Point(0, 0);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(140, 40);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.Text = "Perfil";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // FormHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 614);
            this.Controls.Add(this.pnlHead);
            this.Controls.Add(this.pnlFormsCenter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormHub";
            this.Text = "VELONIA";
            this.pnlHead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShoppingCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.pnlFormsCenter.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHead;
        private System.Windows.Forms.Panel pnlFormsCenter;
        private System.Windows.Forms.PictureBox pbHead;
        private System.Windows.Forms.PictureBox pbShoppingCart;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnModifyProduct;
        private System.Windows.Forms.Button btnAddProduct;
    }
}

