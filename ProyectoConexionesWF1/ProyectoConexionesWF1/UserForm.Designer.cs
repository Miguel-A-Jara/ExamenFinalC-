namespace ProyectoConexionesWF1
{
    partial class UserForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.isInactive = new System.Windows.Forms.RadioButton();
            this.isActive = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtRepeatPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.loadUserIdButton = new System.Windows.Forms.Button();
            this.createUserButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.searchUserIdButton = new System.Windows.Forms.Button();
            this.lastButton = new System.Windows.Forms.Button();
            this.firstButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.editUserButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userStatusSelect = new System.Windows.Forms.ComboBox();
            this.usernameSelect = new System.Windows.Forms.ComboBox();
            this.tusuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conexionADODataSet = new ProyectoConexionesWF1.ConexionADODataSet();
            this.t_usuariosTableAdapter = new ProyectoConexionesWF1.ConexionADODataSetTableAdapters.t_usuariosTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tusuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexionADODataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Usuarios";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.isInactive);
            this.groupBox1.Controls.Add(this.isActive);
            this.groupBox1.Location = new System.Drawing.Point(123, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 60);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado";
            // 
            // isInactive
            // 
            this.isInactive.AutoSize = true;
            this.isInactive.Location = new System.Drawing.Point(220, 19);
            this.isInactive.Name = "isInactive";
            this.isInactive.Size = new System.Drawing.Size(63, 17);
            this.isInactive.TabIndex = 1;
            this.isInactive.TabStop = true;
            this.isInactive.Text = "Inactivo";
            this.isInactive.UseVisualStyleBackColor = true;
            // 
            // isActive
            // 
            this.isActive.AutoSize = true;
            this.isActive.Location = new System.Drawing.Point(88, 19);
            this.isActive.Name = "isActive";
            this.isActive.Size = new System.Drawing.Size(55, 17);
            this.isActive.TabIndex = 0;
            this.isActive.TabStop = true;
            this.isActive.Text = "Activo";
            this.isActive.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id. Usuario";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(123, 154);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(77, 20);
            this.txtId.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre de Usuario";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(258, 154);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Repita Contraseña";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(123, 272);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(168, 20);
            this.txtPassword.TabIndex = 8;
            // 
            // txtRepeatPassword
            // 
            this.txtRepeatPassword.Location = new System.Drawing.Point(326, 272);
            this.txtRepeatPassword.Name = "txtRepeatPassword";
            this.txtRepeatPassword.PasswordChar = '*';
            this.txtRepeatPassword.Size = new System.Drawing.Size(165, 20);
            this.txtRepeatPassword.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(391, 154);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(391, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Correo Electronico";
            // 
            // loadUserIdButton
            // 
            this.loadUserIdButton.Location = new System.Drawing.Point(123, 317);
            this.loadUserIdButton.Name = "loadUserIdButton";
            this.loadUserIdButton.Size = new System.Drawing.Size(111, 23);
            this.loadUserIdButton.TabIndex = 12;
            this.loadUserIdButton.Text = "Cargar Datos";
            this.loadUserIdButton.UseVisualStyleBackColor = true;
            this.loadUserIdButton.Click += new System.EventHandler(this.loadUserIdButton_Click);
            // 
            // createUserButton
            // 
            this.createUserButton.Enabled = false;
            this.createUserButton.Location = new System.Drawing.Point(380, 317);
            this.createUserButton.Name = "createUserButton";
            this.createUserButton.Size = new System.Drawing.Size(111, 23);
            this.createUserButton.TabIndex = 13;
            this.createUserButton.Text = "Crear Usuario";
            this.createUserButton.UseVisualStyleBackColor = true;
            this.createUserButton.Click += new System.EventHandler(this.createUserButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(216, 96);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(75, 23);
            this.previousButton.TabIndex = 14;
            this.previousButton.Text = "<";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(310, 96);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 15;
            this.nextButton.Text = ">";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // searchUserIdButton
            // 
            this.searchUserIdButton.BackgroundImage = global::ProyectoConexionesWF1.Properties.Resources.search_icon;
            this.searchUserIdButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchUserIdButton.Image = global::ProyectoConexionesWF1.Properties.Resources.search_icon;
            this.searchUserIdButton.Location = new System.Drawing.Point(206, 149);
            this.searchUserIdButton.Name = "searchUserIdButton";
            this.searchUserIdButton.Size = new System.Drawing.Size(29, 28);
            this.searchUserIdButton.TabIndex = 16;
            this.searchUserIdButton.UseVisualStyleBackColor = true;
            this.searchUserIdButton.Click += new System.EventHandler(this.searchUserIdButton_Click);
            // 
            // lastButton
            // 
            this.lastButton.Location = new System.Drawing.Point(394, 96);
            this.lastButton.Name = "lastButton";
            this.lastButton.Size = new System.Drawing.Size(42, 23);
            this.lastButton.TabIndex = 17;
            this.lastButton.Text = ">>";
            this.lastButton.UseVisualStyleBackColor = true;
            this.lastButton.Click += new System.EventHandler(this.lastButton_Click);
            // 
            // firstButton
            // 
            this.firstButton.Location = new System.Drawing.Point(168, 96);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(42, 23);
            this.firstButton.TabIndex = 18;
            this.firstButton.Text = "<<";
            this.firstButton.UseVisualStyleBackColor = true;
            // 
            // editUserButton
            // 
            this.editUserButton.Enabled = false;
            this.editUserButton.Location = new System.Drawing.Point(240, 317);
            this.editUserButton.Name = "editUserButton";
            this.editUserButton.Size = new System.Drawing.Size(134, 23);
            this.editUserButton.TabIndex = 19;
            this.editUserButton.Text = "Editar";
            this.editUserButton.UseVisualStyleBackColor = true;
            this.editUserButton.Click += new System.EventHandler(this.editUserButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 411);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(625, 238);
            this.dataGridView1.TabIndex = 20;
            // 
            // userStatusSelect
            // 
            this.userStatusSelect.FormattingEnabled = true;
            this.userStatusSelect.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.userStatusSelect.Location = new System.Drawing.Point(380, 382);
            this.userStatusSelect.Name = "userStatusSelect";
            this.userStatusSelect.Size = new System.Drawing.Size(257, 21);
            this.userStatusSelect.TabIndex = 22;
            this.userStatusSelect.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // usernameSelect
            // 
            this.usernameSelect.DataSource = this.tusuariosBindingSource;
            this.usernameSelect.DisplayMember = "login";
            this.usernameSelect.FormattingEnabled = true;
            this.usernameSelect.Location = new System.Drawing.Point(12, 382);
            this.usernameSelect.Name = "usernameSelect";
            this.usernameSelect.Size = new System.Drawing.Size(222, 21);
            this.usernameSelect.TabIndex = 23;
            this.usernameSelect.ValueMember = "Id_usuario";
            this.usernameSelect.SelectedIndexChanged += new System.EventHandler(this.usernameSelect_SelectedIndexChanged);
            // 
            // tusuariosBindingSource
            // 
            this.tusuariosBindingSource.DataMember = "t_usuarios";
            this.tusuariosBindingSource.DataSource = this.conexionADODataSet;
            // 
            // conexionADODataSet
            // 
            this.conexionADODataSet.DataSetName = "ConexionADODataSet";
            this.conexionADODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_usuariosTableAdapter
            // 
            this.t_usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(380, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Estado del Usuario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Nombre de Usuario";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 661);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.usernameSelect);
            this.Controls.Add(this.userStatusSelect);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.editUserButton);
            this.Controls.Add(this.firstButton);
            this.Controls.Add(this.lastButton);
            this.Controls.Add(this.searchUserIdButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.createUserButton);
            this.Controls.Add(this.loadUserIdButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtRepeatPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "UserForm";
            this.Text = "AbmPersonas";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tusuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexionADODataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton isInactive;
        private System.Windows.Forms.RadioButton isActive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtRepeatPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button loadUserIdButton;
        private System.Windows.Forms.Button createUserButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button searchUserIdButton;
        private System.Windows.Forms.Button lastButton;
        private System.Windows.Forms.Button firstButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button editUserButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox userStatusSelect;
        private System.Windows.Forms.ComboBox usernameSelect;
        private ConexionADODataSet conexionADODataSet;
        private System.Windows.Forms.BindingSource tusuariosBindingSource;
        private ConexionADODataSetTableAdapters.t_usuariosTableAdapter t_usuariosTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}