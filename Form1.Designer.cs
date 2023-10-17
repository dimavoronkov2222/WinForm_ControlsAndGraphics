namespace WinForm_ControlsAndGraphics
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
            components = new System.ComponentModel.Container();
            tabControl = new TabControl();
            tabHome = new TabPage();
            button1 = new Button();
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            NUD_Amount = new NumericUpDown();
            tb_PriceAll = new TextBox();
            dateTimePicker = new DateTimePicker();
            tb_PricePerOne = new TextBox();
            tb_Desc = new TextBox();
            tb_GoodName = new TextBox();
            listOfGoods = new ListBox();
            tabAnalitics = new TabPage();
            toolTip1 = new ToolTip(components);
            tabControl.SuspendLayout();
            tabHome.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_Amount).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabHome);
            tabControl.Controls.Add(tabAnalitics);
            tabControl.ItemSize = new Size(200, 20);
            tabControl.Location = new Point(2, 3);
            tabControl.Margin = new Padding(3, 4, 3, 4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1346, 717);
            tabControl.TabIndex = 0;
            // 
            // tabHome
            // 
            tabHome.BackColor = Color.FromArgb(33, 33, 33);
            tabHome.Controls.Add(button1);
            tabHome.Controls.Add(panel1);
            tabHome.Controls.Add(groupBox1);
            tabHome.Controls.Add(listOfGoods);
            tabHome.Location = new Point(4, 24);
            tabHome.Margin = new Padding(3, 4, 3, 4);
            tabHome.Name = "tabHome";
            tabHome.Padding = new Padding(3, 4, 3, 4);
            tabHome.Size = new Size(1338, 689);
            tabHome.TabIndex = 0;
            tabHome.Text = "General";
            // 
            // button1
            // 
            button1.Location = new Point(69, 620);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(470, 48);
            button1.TabIndex = 3;
            button1.Text = "Print check";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(7, 321);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(586, 291);
            panel1.TabIndex = 2;
            // 
            // button4
            // 
            button4.BackColor = Color.OrangeRed;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(62, 188);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(470, 56);
            button4.TabIndex = 2;
            button4.Text = "Delete product";
            button4.UseVisualStyleBackColor = false;
            button4.Click += RomoveGoodFromList;
            // 
            // button3
            // 
            button3.BackColor = Color.Orange;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(62, 100);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(470, 56);
            button3.TabIndex = 1;
            button3.Text = "Edit product";
            button3.UseVisualStyleBackColor = false;
            button3.Click += EditGoodItem;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGreen;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(62, 19);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(470, 56);
            button2.TabIndex = 0;
            button2.Text = "Add product";
            button2.UseVisualStyleBackColor = false;
            button2.Click += AddGood_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(NUD_Amount);
            groupBox1.Controls.Add(tb_PriceAll);
            groupBox1.Controls.Add(dateTimePicker);
            groupBox1.Controls.Add(tb_PricePerOne);
            groupBox1.Controls.Add(tb_Desc);
            groupBox1.Controls.Add(tb_GoodName);
            groupBox1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.Control;
            groupBox1.Location = new Point(7, 8);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(586, 305);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Product";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(40, 248);
            label8.Name = "label8";
            label8.Size = new Size(53, 25);
            label8.TabIndex = 13;
            label8.Text = "Data";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(29, 189);
            label7.Name = "label7";
            label7.Size = new Size(130, 25);
            label7.TabIndex = 12;
            label7.Text = "General Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(207, 139);
            label6.Name = "label6";
            label6.Size = new Size(179, 25);
            label6.TabIndex = 11;
            label6.Text = "PRICE PER PIECE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(29, 142);
            label5.Name = "label5";
            label5.Size = new Size(80, 25);
            label5.TabIndex = 10;
            label5.Text = "Amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(19, 91);
            label4.Name = "label4";
            label4.Size = new Size(109, 25);
            label4.TabIndex = 9;
            label4.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(29, 39);
            label3.Name = "label3";
            label3.Size = new Size(64, 25);
            label3.TabIndex = 8;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(451, 188);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 7;
            label2.Text = "UAH";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(505, 139);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 6;
            label1.Text = "UAH";
            // 
            // NUD_Amount
            // 
            NUD_Amount.Enabled = false;
            NUD_Amount.Location = new Point(122, 136);
            NUD_Amount.Margin = new Padding(3, 4, 3, 4);
            NUD_Amount.Name = "NUD_Amount";
            NUD_Amount.Size = new Size(79, 34);
            NUD_Amount.TabIndex = 5;
            NUD_Amount.ValueChanged += AmountChanged;
            // 
            // tb_PriceAll
            // 
            tb_PriceAll.Enabled = false;
            tb_PriceAll.Location = new Point(173, 183);
            tb_PriceAll.Margin = new Padding(3, 4, 3, 4);
            tb_PriceAll.Name = "tb_PriceAll";
            tb_PriceAll.Size = new Size(271, 34);
            tb_PriceAll.TabIndex = 4;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(110, 239);
            dateTimePicker.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(383, 34);
            dateTimePicker.TabIndex = 3;
            // 
            // tb_PricePerOne
            // 
            tb_PricePerOne.Enabled = false;
            tb_PricePerOne.Location = new Point(392, 135);
            tb_PricePerOne.Margin = new Padding(3, 4, 3, 4);
            tb_PricePerOne.Name = "tb_PricePerOne";
            tb_PricePerOne.Size = new Size(115, 34);
            tb_PricePerOne.TabIndex = 2;
            tb_PricePerOne.TextChanged += PricePerOneChanged;
            // 
            // tb_Desc
            // 
            tb_Desc.Location = new Point(131, 89);
            tb_Desc.Margin = new Padding(3, 4, 3, 4);
            tb_Desc.Name = "tb_Desc";
            tb_Desc.Size = new Size(399, 34);
            tb_Desc.TabIndex = 1;
            // 
            // tb_GoodName
            // 
            tb_GoodName.Location = new Point(94, 39);
            tb_GoodName.Margin = new Padding(3, 4, 3, 4);
            tb_GoodName.Name = "tb_GoodName";
            tb_GoodName.Size = new Size(399, 34);
            tb_GoodName.TabIndex = 0;
            tb_GoodName.TextChanged += NameChanged;
            // 
            // listOfGoods
            // 
            listOfGoods.FormattingEnabled = true;
            listOfGoods.ItemHeight = 20;
            listOfGoods.Location = new Point(599, 0);
            listOfGoods.Margin = new Padding(3, 4, 3, 4);
            listOfGoods.Name = "listOfGoods";
            listOfGoods.Size = new Size(733, 724);
            listOfGoods.TabIndex = 0;
            listOfGoods.SelectedValueChanged += SelectedValue;
            // 
            // tabAnalitics
            // 
            tabAnalitics.BackColor = Color.FromArgb(33, 33, 33);
            tabAnalitics.BorderStyle = BorderStyle.FixedSingle;
            tabAnalitics.Location = new Point(4, 24);
            tabAnalitics.Margin = new Padding(3, 4, 3, 4);
            tabAnalitics.Name = "tabAnalitics";
            tabAnalitics.Padding = new Padding(3, 4, 3, 4);
            tabAnalitics.Size = new Size(1338, 689);
            tabAnalitics.TabIndex = 1;
            tabAnalitics.Text = "Analytics";
            tabAnalitics.ToolTipText = "Загальна сторінка інформації";
            tabAnalitics.Paint += OnPaint;
            // 
            // toolTip1
            // 
            toolTip1.Tag = "1";
            toolTip1.ToolTipTitle = "Підказка";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            ClientSize = new Size(1349, 721);
            Controls.Add(tabControl);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Foxstrot 2.0";
            tabControl.ResumeLayout(false);
            tabHome.ResumeLayout(false);
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_Amount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabHome;
        private TabPage tabAnalitics;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker;
        private TextBox tb_PricePerOne;
        private TextBox tb_Desc;
        private TextBox tb_GoodName;
        private ListBox listOfGoods;
        private Label label2;
        private Label label1;
        private NumericUpDown NUD_Amount;
        private TextBox tb_PriceAll;
        private ToolTip toolTip1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label8;
        private Label label7;
        private Label label6;
        private Panel panel1;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
    }
}