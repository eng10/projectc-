namespace forntin_managment_system
{
    partial class Order
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.Dgv = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.Txt_id = new Guna.UI.WinForms.GunaTextBox();
            this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.Dtp = new System.Windows.Forms.DateTimePicker();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.txt_Cus_name = new Guna.UI.WinForms.GunaTextBox();
            this.txt_Cus_Cloth = new Guna.UI.WinForms.GunaTextBox();
            this.txt_Cus_id = new Guna.UI.WinForms.GunaTextBox();
            this.txt_Cus_paid = new Guna.UI.WinForms.GunaTextBox();
            this.txt_Cus_Balance = new Guna.UI.WinForms.GunaTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(442, 105);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(112, 28);
            this.gunaLabel5.TabIndex = 29;
            this.gunaLabel5.Text = "Cus_name";
            // 
            // Dgv
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.Dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.Dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.Dgv.ColumnHeadersHeight = 4;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv.DefaultCellStyle = dataGridViewCellStyle9;
            this.Dgv.EnableHeadersVisualStyles = false;
            this.Dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Dgv.Location = new System.Drawing.Point(39, 328);
            this.Dgv.Name = "Dgv";
            this.Dgv.RowHeadersVisible = false;
            this.Dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv.Size = new System.Drawing.Size(929, 398);
            this.Dgv.TabIndex = 28;
            this.Dgv.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.Dgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Dgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Dgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Dgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Dgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Dgv.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Dgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Dgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Dgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Dgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Dgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Dgv.ThemeStyle.HeaderStyle.Height = 4;
            this.Dgv.ThemeStyle.ReadOnly = false;
            this.Dgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Dgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Dgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Dgv.ThemeStyle.RowsStyle.Height = 22;
            this.Dgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Dgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // gunaButton3
            // 
            this.gunaButton3.AnimationHoverSpeed = 0.07F;
            this.gunaButton3.AnimationSpeed = 0.03F;
            this.gunaButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gunaButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton3.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton3.ForeColor = System.Drawing.Color.White;
            this.gunaButton3.Image = null;
            this.gunaButton3.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton3.Location = new System.Drawing.Point(875, 164);
            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton3.OnHoverImage = null;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton3.Size = new System.Drawing.Size(96, 34);
            this.gunaButton3.TabIndex = 27;
            this.gunaButton3.Text = "Delete";
            this.gunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = null;
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(875, 122);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Size = new System.Drawing.Size(96, 34);
            this.gunaButton2.TabIndex = 26;
            this.gunaButton2.Text = "Update";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(875, 82);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(96, 34);
            this.gunaButton1.TabIndex = 25;
            this.gunaButton1.Text = "Save";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(442, 187);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(85, 28);
            this.gunaLabel4.TabIndex = 24;
            this.gunaLabel4.Text = "Balance";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(651, 102);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(99, 28);
            this.gunaLabel3.TabIndex = 23;
            this.gunaLabel3.Text = "Clothtype";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(48, 187);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(136, 28);
            this.gunaLabel2.TabIndex = 22;
            this.gunaLabel2.Text = "DateReceived";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(48, 106);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(76, 28);
            this.gunaLabel1.TabIndex = 20;
            this.gunaLabel1.Text = "Ord_Id";
            // 
            // Txt_id
            // 
            this.Txt_id.BackColor = System.Drawing.Color.Transparent;
            this.Txt_id.BaseColor = System.Drawing.Color.White;
            this.Txt_id.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Txt_id.BorderSize = 1;
            this.Txt_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_id.FocusedBaseColor = System.Drawing.Color.White;
            this.Txt_id.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Txt_id.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Txt_id.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_id.Location = new System.Drawing.Point(48, 136);
            this.Txt_id.Name = "Txt_id";
            this.Txt_id.PasswordChar = '\0';
            this.Txt_id.Radius = 4;
            this.Txt_id.SelectedText = "";
            this.Txt_id.Size = new System.Drawing.Size(171, 34);
            this.Txt_id.TabIndex = 19;
            // 
            // gunaGradient2Panel1
            // 
            this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gunaGradient2Panel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gunaGradient2Panel1.Location = new System.Drawing.Point(0, 0);
            this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
            this.gunaGradient2Panel1.Size = new System.Drawing.Size(994, 67);
            this.gunaGradient2Panel1.TabIndex = 18;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(244, 187);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(123, 28);
            this.gunaLabel6.TabIndex = 29;
            this.gunaLabel6.Text = "Amountpaid";
            // 
            // Dtp
            // 
            this.Dtp.Location = new System.Drawing.Point(48, 232);
            this.Dtp.Name = "Dtp";
            this.Dtp.Size = new System.Drawing.Size(171, 20);
            this.Dtp.TabIndex = 33;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.Location = new System.Drawing.Point(244, 105);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(77, 28);
            this.gunaLabel7.TabIndex = 34;
            this.gunaLabel7.Text = "Cus_id";
            // 
            // txt_Cus_name
            // 
            this.txt_Cus_name.BackColor = System.Drawing.Color.Transparent;
            this.txt_Cus_name.BaseColor = System.Drawing.Color.White;
            this.txt_Cus_name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_Cus_name.BorderSize = 1;
            this.txt_Cus_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Cus_name.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Cus_name.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Cus_name.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Cus_name.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cus_name.Location = new System.Drawing.Point(442, 136);
            this.txt_Cus_name.Name = "txt_Cus_name";
            this.txt_Cus_name.PasswordChar = '\0';
            this.txt_Cus_name.Radius = 4;
            this.txt_Cus_name.SelectedText = "";
            this.txt_Cus_name.Size = new System.Drawing.Size(171, 34);
            this.txt_Cus_name.TabIndex = 36;
            // 
            // txt_Cus_Cloth
            // 
            this.txt_Cus_Cloth.BackColor = System.Drawing.Color.Transparent;
            this.txt_Cus_Cloth.BaseColor = System.Drawing.Color.White;
            this.txt_Cus_Cloth.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_Cus_Cloth.BorderSize = 1;
            this.txt_Cus_Cloth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Cus_Cloth.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Cus_Cloth.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Cus_Cloth.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Cus_Cloth.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cus_Cloth.Location = new System.Drawing.Point(651, 136);
            this.txt_Cus_Cloth.Name = "txt_Cus_Cloth";
            this.txt_Cus_Cloth.PasswordChar = '\0';
            this.txt_Cus_Cloth.Radius = 4;
            this.txt_Cus_Cloth.SelectedText = "";
            this.txt_Cus_Cloth.Size = new System.Drawing.Size(171, 34);
            this.txt_Cus_Cloth.TabIndex = 37;
            // 
            // txt_Cus_id
            // 
            this.txt_Cus_id.BackColor = System.Drawing.Color.Transparent;
            this.txt_Cus_id.BaseColor = System.Drawing.Color.White;
            this.txt_Cus_id.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_Cus_id.BorderSize = 1;
            this.txt_Cus_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Cus_id.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Cus_id.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Cus_id.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Cus_id.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cus_id.Location = new System.Drawing.Point(244, 136);
            this.txt_Cus_id.Name = "txt_Cus_id";
            this.txt_Cus_id.PasswordChar = '\0';
            this.txt_Cus_id.Radius = 4;
            this.txt_Cus_id.SelectedText = "";
            this.txt_Cus_id.Size = new System.Drawing.Size(171, 34);
            this.txt_Cus_id.TabIndex = 35;
            // 
            // txt_Cus_paid
            // 
            this.txt_Cus_paid.BackColor = System.Drawing.Color.Transparent;
            this.txt_Cus_paid.BaseColor = System.Drawing.Color.White;
            this.txt_Cus_paid.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_Cus_paid.BorderSize = 1;
            this.txt_Cus_paid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Cus_paid.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Cus_paid.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Cus_paid.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Cus_paid.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cus_paid.Location = new System.Drawing.Point(244, 218);
            this.txt_Cus_paid.Name = "txt_Cus_paid";
            this.txt_Cus_paid.PasswordChar = '\0';
            this.txt_Cus_paid.Radius = 4;
            this.txt_Cus_paid.SelectedText = "";
            this.txt_Cus_paid.Size = new System.Drawing.Size(171, 34);
            this.txt_Cus_paid.TabIndex = 38;
            // 
            // txt_Cus_Balance
            // 
            this.txt_Cus_Balance.BackColor = System.Drawing.Color.Transparent;
            this.txt_Cus_Balance.BaseColor = System.Drawing.Color.White;
            this.txt_Cus_Balance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_Cus_Balance.BorderSize = 1;
            this.txt_Cus_Balance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Cus_Balance.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Cus_Balance.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Cus_Balance.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Cus_Balance.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cus_Balance.Location = new System.Drawing.Point(442, 218);
            this.txt_Cus_Balance.Name = "txt_Cus_Balance";
            this.txt_Cus_Balance.PasswordChar = '\0';
            this.txt_Cus_Balance.Radius = 4;
            this.txt_Cus_Balance.SelectedText = "";
            this.txt_Cus_Balance.Size = new System.Drawing.Size(171, 34);
            this.txt_Cus_Balance.TabIndex = 39;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_Cus_Balance);
            this.Controls.Add(this.txt_Cus_paid);
            this.Controls.Add(this.txt_Cus_Cloth);
            this.Controls.Add(this.txt_Cus_name);
            this.Controls.Add(this.txt_Cus_id);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.Dtp);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.Dgv);
            this.Controls.Add(this.gunaButton3);
            this.Controls.Add(this.gunaButton2);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.Txt_id);
            this.Controls.Add(this.gunaGradient2Panel1);
            this.Name = "Order";
            this.Size = new System.Drawing.Size(994, 807);
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaDataGridView Dgv;
        private Guna.UI.WinForms.GunaButton gunaButton3;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox Txt_id;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private System.Windows.Forms.DateTimePicker Dtp;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaTextBox txt_Cus_name;
        private Guna.UI.WinForms.GunaTextBox txt_Cus_Cloth;
        private Guna.UI.WinForms.GunaTextBox txt_Cus_id;
        private Guna.UI.WinForms.GunaTextBox txt_Cus_paid;
        private Guna.UI.WinForms.GunaTextBox txt_Cus_Balance;
    }
}
