namespace StudentMVCApp.View.Forms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            txtSearch = new CuoreUI.Controls.cuiTextBox();
            lsStudents = new MaterialSkin.Controls.MaterialListBox();
            btnSearch = new MaterialSkin.Controls.MaterialButton();
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            label2 = new Label();
            label1 = new Label();
            txtAge = new CuoreUI.Controls.cuiTextBox();
            txtName = new CuoreUI.Controls.cuiTextBox();
            btnViewAll = new MaterialSkin.Controls.MaterialButton();
            btnDelete = new MaterialSkin.Controls.MaterialButton();
            btnAdd = new MaterialSkin.Controls.MaterialButton();
            btnEdit = new MaterialSkin.Controls.MaterialButton();
            tabPage2 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            materialTabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(txtSearch);
            splitContainer1.Panel1.Controls.Add(lsStudents);
            splitContainer1.Panel1.Controls.Add(btnSearch);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.FromArgb(16, 22, 35);
            splitContainer1.Panel2.Controls.Add(materialTabControl1);
            splitContainer1.Size = new Size(1038, 522);
            splitContainer1.SplitterDistance = 479;
            splitContainer1.TabIndex = 3;
            // 
            // txtSearch
            // 
            txtSearch.BackgroundColor = Color.White;
            txtSearch.Content = "";
            txtSearch.FocusBackgroundColor = Color.White;
            txtSearch.FocusImageTint = Color.White;
            txtSearch.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            txtSearch.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.Gray;
            txtSearch.Image = null;
            txtSearch.ImageExpand = new Point(0, 0);
            txtSearch.ImageOffset = new Point(0, 0);
            txtSearch.Location = new Point(44, 37);
            txtSearch.Margin = new Padding(4);
            txtSearch.Multiline = false;
            txtSearch.Name = "txtSearch";
            txtSearch.NormalImageTint = Color.White;
            txtSearch.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtSearch.Padding = new Padding(15, 11, 15, 0);
            txtSearch.PasswordChar = false;
            txtSearch.PlaceholderColor = SystemColors.WindowText;
            txtSearch.PlaceholderText = "";
            txtSearch.Rounding = new Padding(8);
            txtSearch.Size = new Size(247, 36);
            txtSearch.TabIndex = 1;
            txtSearch.TextOffset = new Size(0, 0);
            txtSearch.UnderlinedStyle = true;
            // 
            // lsStudents
            // 
            lsStudents.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lsStudents.BackColor = Color.FromArgb(23, 30, 41);
            lsStudents.BorderColor = Color.Transparent;
            lsStudents.Depth = 0;
            lsStudents.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lsStudents.Location = new Point(44, 92);
            lsStudents.MouseState = MaterialSkin.MouseState.HOVER;
            lsStudents.Name = "lsStudents";
            lsStudents.SelectedIndex = -1;
            lsStudents.SelectedItem = null;
            lsStudents.Size = new Size(389, 390);
            lsStudents.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.AutoSize = false;
            btnSearch.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSearch.Depth = 0;
            btnSearch.HighEmphasis = true;
            btnSearch.Icon = null;
            btnSearch.Location = new Point(299, 37);
            btnSearch.Margin = new Padding(4, 6, 4, 6);
            btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            btnSearch.Name = "btnSearch";
            btnSearch.NoAccentTextColor = Color.Empty;
            btnSearch.Size = new Size(134, 36);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Search";
            btnSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSearch.UseAccentColor = false;
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabPage1);
            materialTabControl1.Controls.Add(tabPage2);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.Location = new Point(0, 0);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(555, 522);
            materialTabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(16, 22, 27);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtAge);
            tabPage1.Controls.Add(txtName);
            tabPage1.Controls.Add(btnViewAll);
            tabPage1.Controls.Add(btnDelete);
            tabPage1.Controls.Add(btnAdd);
            tabPage1.Controls.Add(btnEdit);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(547, 494);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(16, 68);
            label2.Name = "label2";
            label2.Size = new Size(492, 15);
            label2.TabIndex = 3;
            label2.Text = "_________________________________________________________________________________________________";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(11, 31);
            label1.Name = "label1";
            label1.Size = new Size(335, 37);
            label1.TabIndex = 2;
            label1.Text = "Student Basic Information";
            // 
            // txtAge
            // 
            txtAge.BackgroundColor = Color.White;
            txtAge.Content = "";
            txtAge.FocusBackgroundColor = Color.White;
            txtAge.FocusImageTint = Color.White;
            txtAge.FocusOutlineColor = Color.FromArgb(128, 128, 255);
            txtAge.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAge.ForeColor = Color.Gray;
            txtAge.Image = null;
            txtAge.ImageExpand = new Point(0, 0);
            txtAge.ImageOffset = new Point(0, 0);
            txtAge.Location = new Point(16, 166);
            txtAge.Margin = new Padding(4);
            txtAge.Multiline = false;
            txtAge.Name = "txtAge";
            txtAge.NormalImageTint = Color.White;
            txtAge.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtAge.Padding = new Padding(15, 11, 15, 0);
            txtAge.PasswordChar = false;
            txtAge.PlaceholderColor = Color.Silver;
            txtAge.PlaceholderText = "Enter your age";
            txtAge.Rounding = new Padding(8);
            txtAge.Size = new Size(306, 36);
            txtAge.TabIndex = 1;
            txtAge.TextOffset = new Size(0, 0);
            txtAge.UnderlinedStyle = true;
            // 
            // txtName
            // 
            txtName.BackgroundColor = Color.White;
            txtName.Content = "";
            txtName.FocusBackgroundColor = Color.White;
            txtName.FocusImageTint = Color.White;
            txtName.FocusOutlineColor = Color.FromArgb(128, 128, 255);
            txtName.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.Gray;
            txtName.Image = null;
            txtName.ImageExpand = new Point(0, 0);
            txtName.ImageOffset = new Point(0, 0);
            txtName.Location = new Point(16, 115);
            txtName.Margin = new Padding(4);
            txtName.Multiline = false;
            txtName.Name = "txtName";
            txtName.NormalImageTint = Color.White;
            txtName.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtName.Padding = new Padding(15, 11, 15, 0);
            txtName.PasswordChar = false;
            txtName.PlaceholderColor = Color.Silver;
            txtName.PlaceholderText = "Enter your full name";
            txtName.Rounding = new Padding(8);
            txtName.Size = new Size(306, 36);
            txtName.TabIndex = 1;
            txtName.TextOffset = new Size(0, 0);
            txtName.UnderlinedStyle = true;
            // 
            // btnViewAll
            // 
            btnViewAll.AutoSize = false;
            btnViewAll.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnViewAll.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnViewAll.Depth = 0;
            btnViewAll.HighEmphasis = true;
            btnViewAll.Icon = null;
            btnViewAll.Location = new Point(351, 268);
            btnViewAll.Margin = new Padding(4, 6, 4, 6);
            btnViewAll.MouseState = MaterialSkin.MouseState.HOVER;
            btnViewAll.Name = "btnViewAll";
            btnViewAll.NoAccentTextColor = Color.Empty;
            btnViewAll.Size = new Size(154, 36);
            btnViewAll.TabIndex = 0;
            btnViewAll.Text = "View All";
            btnViewAll.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnViewAll.UseAccentColor = false;
            btnViewAll.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = false;
            btnDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDelete.Depth = 0;
            btnDelete.HighEmphasis = true;
            btnDelete.Icon = null;
            btnDelete.Location = new Point(351, 217);
            btnDelete.Margin = new Padding(4, 6, 4, 6);
            btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            btnDelete.Name = "btnDelete";
            btnDelete.NoAccentTextColor = Color.Empty;
            btnDelete.Size = new Size(154, 36);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Delete";
            btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDelete.UseAccentColor = false;
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = false;
            btnAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdd.Depth = 0;
            btnAdd.HighEmphasis = true;
            btnAdd.Icon = null;
            btnAdd.Location = new Point(351, 115);
            btnAdd.Margin = new Padding(4, 6, 4, 6);
            btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            btnAdd.Name = "btnAdd";
            btnAdd.NoAccentTextColor = Color.Empty;
            btnAdd.Size = new Size(154, 36);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAdd.UseAccentColor = false;
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.AutoSize = false;
            btnEdit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEdit.Depth = 0;
            btnEdit.HighEmphasis = true;
            btnEdit.Icon = null;
            btnEdit.Location = new Point(351, 166);
            btnEdit.Margin = new Padding(4, 6, 4, 6);
            btnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            btnEdit.Name = "btnEdit";
            btnEdit.NoAccentTextColor = Color.Empty;
            btnEdit.Size = new Size(154, 36);
            btnEdit.TabIndex = 0;
            btnEdit.Text = "Edit";
            btnEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEdit.UseAccentColor = false;
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(16, 22, 27);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(547, 494);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(16, 22, 27);
            ClientSize = new Size(1038, 522);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            materialTabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private SplitContainer splitContainer1;
        private MaterialSkin.Controls.MaterialListBox lsStudents;
        private MaterialSkin.Controls.MaterialButton btnSearch;
        private CuoreUI.Controls.cuiTextBox txtSearch;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private Label label1;
        private CuoreUI.Controls.cuiTextBox txtAge;
        private CuoreUI.Controls.cuiTextBox txtName;
        private MaterialSkin.Controls.MaterialButton btnViewAll;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialButton btnEdit;
        private TabPage tabPage2;
        private Label label2;
    }
}
