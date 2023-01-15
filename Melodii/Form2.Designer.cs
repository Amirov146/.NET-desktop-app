namespace Melodii
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuButton5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.melodiiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.melodiiDataSet = new Melodii.melodiiDataSet();
            this.melodiiTableAdapter = new Melodii.melodiiDataSetTableAdapters.MelodiiTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button10 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.melodiiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.melodiiDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(6, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Înapoi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bunifuButton5
            // 
            this.bunifuButton5.AllowAnimations = true;
            this.bunifuButton5.AllowMouseEffects = true;
            this.bunifuButton5.AllowToggling = false;
            this.bunifuButton5.AnimationSpeed = 200;
            this.bunifuButton5.AutoGenerateColors = false;
            this.bunifuButton5.AutoRoundBorders = false;
            this.bunifuButton5.AutoSizeLeftIcon = true;
            this.bunifuButton5.AutoSizeRightIcon = true;
            this.bunifuButton5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton5.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bunifuButton5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton5.BackgroundImage")));
            this.bunifuButton5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton5.ButtonText = "TOP 3 melodii";
            this.bunifuButton5.ButtonTextMarginLeft = 0;
            this.bunifuButton5.ColorContrastOnClick = 45;
            this.bunifuButton5.ColorContrastOnHover = 45;
            this.bunifuButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.bunifuButton5.CustomizableEdges = borderEdges3;
            this.bunifuButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton5.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton5.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuButton5.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton5.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuButton5.ForeColor = System.Drawing.Color.Black;
            this.bunifuButton5.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton5.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton5.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton5.IconMarginLeft = 11;
            this.bunifuButton5.IconPadding = 10;
            this.bunifuButton5.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton5.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton5.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton5.IconSize = 25;
            this.bunifuButton5.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bunifuButton5.IdleBorderRadius = 1;
            this.bunifuButton5.IdleBorderThickness = 1;
            this.bunifuButton5.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bunifuButton5.IdleIconLeftImage = null;
            this.bunifuButton5.IdleIconRightImage = null;
            this.bunifuButton5.IndicateFocus = false;
            this.bunifuButton5.Location = new System.Drawing.Point(428, -78);
            this.bunifuButton5.Name = "bunifuButton5";
            this.bunifuButton5.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton5.OnDisabledState.BorderRadius = 1;
            this.bunifuButton5.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton5.OnDisabledState.BorderThickness = 1;
            this.bunifuButton5.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuButton5.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton5.OnDisabledState.IconLeftImage = null;
            this.bunifuButton5.OnDisabledState.IconRightImage = null;
            this.bunifuButton5.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton5.onHoverState.BorderRadius = 1;
            this.bunifuButton5.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton5.onHoverState.BorderThickness = 1;
            this.bunifuButton5.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton5.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton5.onHoverState.IconLeftImage = null;
            this.bunifuButton5.onHoverState.IconRightImage = null;
            this.bunifuButton5.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bunifuButton5.OnIdleState.BorderRadius = 1;
            this.bunifuButton5.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton5.OnIdleState.BorderThickness = 1;
            this.bunifuButton5.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bunifuButton5.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.bunifuButton5.OnIdleState.IconLeftImage = null;
            this.bunifuButton5.OnIdleState.IconRightImage = null;
            this.bunifuButton5.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton5.OnPressedState.BorderRadius = 1;
            this.bunifuButton5.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton5.OnPressedState.BorderThickness = 1;
            this.bunifuButton5.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton5.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton5.OnPressedState.IconLeftImage = null;
            this.bunifuButton5.OnPressedState.IconRightImage = null;
            this.bunifuButton5.Size = new System.Drawing.Size(231, 39);
            this.bunifuButton5.TabIndex = 20;
            this.bunifuButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton5.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton5.TextMarginLeft = 0;
            this.bunifuButton5.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton5.UseDefaultRadiusAndThickness = true;
            // 
            // melodiiBindingSource
            // 
            this.melodiiBindingSource.DataMember = "Melodii";
            this.melodiiBindingSource.DataSource = this.melodiiDataSet;
            // 
            // melodiiDataSet
            // 
            this.melodiiDataSet.DataSetName = "melodiiDataSet";
            this.melodiiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // melodiiTableAdapter
            // 
            this.melodiiTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.Location = new System.Drawing.Point(12, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1012, 506);
            this.tabControl1.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::Melodii.Properties.Resources._50_Beautiful_and_Minimalist_Presentation_Backgrounds_031;
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage1.ForeColor = System.Drawing.Color.Teal;
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1004, 469);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inregistrare";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(497, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(233, 60);
            this.button3.TabIndex = 19;
            this.button3.Text = "Integistrarea intervievatului";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(197, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 60);
            this.button2.TabIndex = 18;
            this.button2.Text = "Inregistrarea melodiei";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::Melodii.Properties.Resources._50_Beautiful_and_Minimalist_Presentation_Backgrounds_031;
            this.tabPage2.Controls.Add(this.button9);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.bunifuButton5);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1004, 469);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Afisare";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button9.ForeColor = System.Drawing.Color.Teal;
            this.button9.Location = new System.Drawing.Point(7, 202);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(269, 56);
            this.button9.TabIndex = 31;
            this.button9.Text = "Melodiile pe primele 3 locuri";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button7.ForeColor = System.Drawing.Color.Teal;
            this.button7.Location = new System.Drawing.Point(13, 273);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(254, 58);
            this.button7.TabIndex = 30;
            this.button7.Text = "Lista participanților la concurs";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.ForeColor = System.Drawing.Color.Teal;
            this.button6.Location = new System.Drawing.Point(7, 131);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(269, 56);
            this.button6.TabIndex = 29;
            this.button6.Text = "Persoanele de pe primele 5 locuri";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.ForeColor = System.Drawing.Color.Teal;
            this.button5.Location = new System.Drawing.Point(26, 77);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(231, 43);
            this.button5.TabIndex = 28;
            this.button5.Text = "Afișarea intervievaților";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.ForeColor = System.Drawing.Color.Teal;
            this.button4.Location = new System.Drawing.Point(26, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(231, 43);
            this.button4.TabIndex = 27;
            this.button4.Text = "Afișarea melodiilor";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(568, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 33);
            this.label1.TabIndex = 26;
            this.label1.Text = "DataGridView";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(348, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(625, 341);
            this.dataGridView1.TabIndex = 25;
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::Melodii.Properties.Resources._50_Beautiful_and_Minimalist_Presentation_Backgrounds_031;
            this.tabPage3.Controls.Add(this.button10);
            this.tabPage3.Controls.Add(this.button8);
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1004, 469);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Excludere";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button10.ForeColor = System.Drawing.Color.Teal;
            this.button10.Location = new System.Drawing.Point(549, 43);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(269, 43);
            this.button10.TabIndex = 29;
            this.button10.Text = "Excluderea intervievatului";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button8.ForeColor = System.Drawing.Color.Teal;
            this.button8.Location = new System.Drawing.Point(164, 43);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(269, 43);
            this.button8.TabIndex = 28;
            this.button8.Text = "Excluderea melodiei";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = global::Melodii.Properties.Resources._50_Beautiful_and_Minimalist_Presentation_Backgrounds_031;
            this.tabPage4.Controls.Add(this.button12);
            this.tabPage4.Controls.Add(this.button11);
            this.tabPage4.Location = new System.Drawing.Point(4, 33);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1004, 469);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Adăugare puncte";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button12.ForeColor = System.Drawing.Color.Teal;
            this.button12.Location = new System.Drawing.Point(560, 44);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(260, 50);
            this.button12.TabIndex = 30;
            this.button12.Text = "Intervievati";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button11.ForeColor = System.Drawing.Color.Teal;
            this.button11.Location = new System.Drawing.Point(158, 44);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(260, 50);
            this.button11.TabIndex = 29;
            this.button11.Text = "Melodii";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Melodii.Properties.Resources._50_Beautiful_and_Minimalist_Presentation_Backgrounds_031;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1036, 545);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meniu";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.melodiiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.melodiiDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton5;
        private melodiiDataSet melodiiDataSet;
        private System.Windows.Forms.BindingSource melodiiBindingSource;
        private melodiiDataSetTableAdapters.MelodiiTableAdapter melodiiTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
    }
}