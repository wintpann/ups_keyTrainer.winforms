namespace keyTrainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.keyboard = new System.Windows.Forms.Button();
            this.labelSym = new System.Windows.Forms.Label();
            this.strInTextbox = new System.Windows.Forms.TextBox();
            this.mode = new System.Windows.Forms.Button();
            this.again = new System.Windows.Forms.Button();
            this.labelTypo = new System.Windows.Forms.Label();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.tilda = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.q = new System.Windows.Forms.Button();
            this.w = new System.Windows.Forms.Button();
            this.e = new System.Windows.Forms.Button();
            this.r = new System.Windows.Forms.Button();
            this.t = new System.Windows.Forms.Button();
            this.y = new System.Windows.Forms.Button();
            this.u = new System.Windows.Forms.Button();
            this.i = new System.Windows.Forms.Button();
            this.o = new System.Windows.Forms.Button();
            this.p = new System.Windows.Forms.Button();
            this.bracketL = new System.Windows.Forms.Button();
            this.bracketR = new System.Windows.Forms.Button();
            this.a = new System.Windows.Forms.Button();
            this.s = new System.Windows.Forms.Button();
            this.d = new System.Windows.Forms.Button();
            this.f = new System.Windows.Forms.Button();
            this.g = new System.Windows.Forms.Button();
            this.h = new System.Windows.Forms.Button();
            this.j = new System.Windows.Forms.Button();
            this.k = new System.Windows.Forms.Button();
            this.l = new System.Windows.Forms.Button();
            this.colon = new System.Windows.Forms.Button();
            this.mark = new System.Windows.Forms.Button();
            this.z = new System.Windows.Forms.Button();
            this.x = new System.Windows.Forms.Button();
            this.c = new System.Windows.Forms.Button();
            this.v = new System.Windows.Forms.Button();
            this.b = new System.Windows.Forms.Button();
            this.n = new System.Windows.Forms.Button();
            this.m = new System.Windows.Forms.Button();
            this.lessMark = new System.Windows.Forms.Button();
            this.moreMark = new System.Windows.Forms.Button();
            this.questionMark = new System.Windows.Forms.Button();
            this.slashes = new System.Windows.Forms.Button();
            this.enter = new System.Windows.Forms.Button();
            this.shiftRight = new System.Windows.Forms.Button();
            this.shiftLeft = new System.Windows.Forms.Button();
            this.tab = new System.Windows.Forms.Button();
            this.capsLk = new System.Windows.Forms.Button();
            this.ctrlLeft = new System.Windows.Forms.Button();
            this.altLeft = new System.Windows.Forms.Button();
            this.space = new System.Windows.Forms.Button();
            this.altRight = new System.Windows.Forms.Button();
            this.ctrlRight = new System.Windows.Forms.Button();
            this.strOutTextBox = new System.Windows.Forms.TextBox();
            this.leftHand = new System.Windows.Forms.PictureBox();
            this.rightHand = new System.Windows.Forms.PictureBox();
            this.modePanel = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.Button();
            this.modeSharp = new System.Windows.Forms.Button();
            this.modeRu = new System.Windows.Forms.Button();
            this.modeEn = new System.Windows.Forms.Button();
            this.randomCB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.leftHand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightHand)).BeginInit();
            this.modePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // keyboard
            // 
            this.keyboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.keyboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.keyboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.keyboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.keyboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.keyboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.keyboard.Location = new System.Drawing.Point(36, 7);
            this.keyboard.Name = "keyboard";
            this.keyboard.Size = new System.Drawing.Size(124, 35);
            this.keyboard.TabIndex = 0;
            this.keyboard.TabStop = false;
            this.keyboard.Text = "КЛАВИАТУРА";
            this.keyboard.UseVisualStyleBackColor = false;
            this.keyboard.Click += new System.EventHandler(this.keyboard_Click);
            // 
            // labelSym
            // 
            this.labelSym.BackColor = System.Drawing.Color.Transparent;
            this.labelSym.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.labelSym.Location = new System.Drawing.Point(621, 6);
            this.labelSym.Name = "labelSym";
            this.labelSym.Size = new System.Drawing.Size(206, 25);
            this.labelSym.TabIndex = 1;
            this.labelSym.Text = "Символов в минуту:";
            // 
            // strInTextbox
            // 
            this.strInTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.strInTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.strInTextbox.Enabled = false;
            this.strInTextbox.Font = new System.Drawing.Font("Calibri", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strInTextbox.ForeColor = System.Drawing.Color.Tan;
            this.strInTextbox.Location = new System.Drawing.Point(158, 69);
            this.strInTextbox.Name = "strInTextbox";
            this.strInTextbox.Size = new System.Drawing.Size(635, 22);
            this.strInTextbox.TabIndex = 2;
            this.strInTextbox.TabStop = false;
            this.strInTextbox.TextChanged += new System.EventHandler(this.strInTextbox_TextChanged);
            // 
            // mode
            // 
            this.mode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.mode.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.mode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.mode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.mode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.mode.Location = new System.Drawing.Point(166, 7);
            this.mode.Name = "mode";
            this.mode.Size = new System.Drawing.Size(83, 35);
            this.mode.TabIndex = 3;
            this.mode.TabStop = false;
            this.mode.Text = "РЕЖИМ";
            this.mode.UseVisualStyleBackColor = false;
            this.mode.Click += new System.EventHandler(this.mode_Click);
            // 
            // again
            // 
            this.again.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.again.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.again.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.again.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.again.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.again.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.again.Location = new System.Drawing.Point(255, 7);
            this.again.Name = "again";
            this.again.Size = new System.Drawing.Size(88, 35);
            this.again.TabIndex = 4;
            this.again.TabStop = false;
            this.again.Text = "ЗАНОВО";
            this.again.UseVisualStyleBackColor = false;
            this.again.Click += new System.EventHandler(this.again_Click);
            // 
            // labelTypo
            // 
            this.labelTypo.BackColor = System.Drawing.Color.Transparent;
            this.labelTypo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.labelTypo.Location = new System.Drawing.Point(621, 31);
            this.labelTypo.Name = "labelTypo";
            this.labelTypo.Size = new System.Drawing.Size(131, 25);
            this.labelTypo.TabIndex = 8;
            this.labelTypo.Text = "Ошибки:";
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.one.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.one.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.one.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.one.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.one.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.one.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.one.Location = new System.Drawing.Point(103, 206);
            this.one.Margin = new System.Windows.Forms.Padding(4);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(50, 50);
            this.one.TabIndex = 9;
            this.one.TabStop = false;
            this.one.Text = "!\n1";
            this.one.UseVisualStyleBackColor = false;
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.two.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.two.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.two.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.two.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.two.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.two.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.two.Location = new System.Drawing.Point(161, 206);
            this.two.Margin = new System.Windows.Forms.Padding(4);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(50, 50);
            this.two.TabIndex = 10;
            this.two.TabStop = false;
            this.two.Text = "@  \"\n2   ";
            this.two.UseVisualStyleBackColor = false;
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.three.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.three.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.three.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.three.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.three.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.three.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.three.Location = new System.Drawing.Point(219, 206);
            this.three.Margin = new System.Windows.Forms.Padding(4);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(50, 50);
            this.three.TabIndex = 11;
            this.three.TabStop = false;
            this.three.Text = "# №\n3   ";
            this.three.UseVisualStyleBackColor = false;
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.four.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.four.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.four.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.four.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.four.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.four.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.four.Location = new System.Drawing.Point(277, 206);
            this.four.Margin = new System.Windows.Forms.Padding(4);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(50, 50);
            this.four.TabIndex = 12;
            this.four.TabStop = false;
            this.four.Text = "$   ;\n4    ";
            this.four.UseVisualStyleBackColor = false;
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.five.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.five.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.five.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.five.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.five.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.five.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.five.Location = new System.Drawing.Point(335, 206);
            this.five.Margin = new System.Windows.Forms.Padding(4);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(50, 50);
            this.five.TabIndex = 13;
            this.five.TabStop = false;
            this.five.Text = "%   \n5   ";
            this.five.UseVisualStyleBackColor = false;
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.six.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.six.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.six.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.six.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.six.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.six.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.six.Location = new System.Drawing.Point(393, 206);
            this.six.Margin = new System.Windows.Forms.Padding(4);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(50, 50);
            this.six.TabIndex = 14;
            this.six.TabStop = false;
            this.six.Text = "^    :\n6     ";
            this.six.UseVisualStyleBackColor = false;
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.seven.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.seven.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.seven.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.seven.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.seven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seven.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.seven.Location = new System.Drawing.Point(451, 206);
            this.seven.Margin = new System.Windows.Forms.Padding(4);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(50, 50);
            this.seven.TabIndex = 15;
            this.seven.TabStop = false;
            this.seven.Text = "&&   ?\n7    ";
            this.seven.UseVisualStyleBackColor = false;
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.eight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.eight.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.eight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.eight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.eight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eight.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.eight.Location = new System.Drawing.Point(509, 206);
            this.eight.Margin = new System.Windows.Forms.Padding(4);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(50, 50);
            this.eight.TabIndex = 16;
            this.eight.TabStop = false;
            this.eight.Text = "*\n8";
            this.eight.UseVisualStyleBackColor = false;
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.nine.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.nine.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.nine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.nine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.nine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nine.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.nine.Location = new System.Drawing.Point(567, 206);
            this.nine.Margin = new System.Windows.Forms.Padding(4);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(50, 50);
            this.nine.TabIndex = 17;
            this.nine.TabStop = false;
            this.nine.Text = "(\n9";
            this.nine.UseVisualStyleBackColor = false;
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.zero.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.zero.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.zero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.zero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zero.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.zero.Location = new System.Drawing.Point(625, 206);
            this.zero.Margin = new System.Windows.Forms.Padding(4);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(50, 50);
            this.zero.TabIndex = 18;
            this.zero.TabStop = false;
            this.zero.Text = ")\n0";
            this.zero.UseVisualStyleBackColor = false;
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.minus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.minus.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.minus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.minus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.minus.Location = new System.Drawing.Point(683, 206);
            this.minus.Margin = new System.Windows.Forms.Padding(4);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(50, 50);
            this.minus.TabIndex = 19;
            this.minus.TabStop = false;
            this.minus.Text = "_ \n-";
            this.minus.UseVisualStyleBackColor = false;
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.plus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.plus.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.plus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.plus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.plus.Location = new System.Drawing.Point(741, 206);
            this.plus.Margin = new System.Windows.Forms.Padding(4);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(50, 50);
            this.plus.TabIndex = 20;
            this.plus.TabStop = false;
            this.plus.Text = "+\n=";
            this.plus.UseVisualStyleBackColor = false;
            // 
            // tilda
            // 
            this.tilda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.tilda.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tilda.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.tilda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.tilda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.tilda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tilda.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tilda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.tilda.Location = new System.Drawing.Point(45, 206);
            this.tilda.Margin = new System.Windows.Forms.Padding(4);
            this.tilda.Name = "tilda";
            this.tilda.Size = new System.Drawing.Size(50, 50);
            this.tilda.TabIndex = 21;
            this.tilda.TabStop = false;
            this.tilda.Text = "~\n` Ё";
            this.tilda.UseVisualStyleBackColor = false;
            // 
            // backspace
            // 
            this.backspace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.backspace.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.backspace.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.backspace.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.backspace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.backspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backspace.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backspace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.backspace.Location = new System.Drawing.Point(799, 206);
            this.backspace.Margin = new System.Windows.Forms.Padding(4);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(100, 50);
            this.backspace.TabIndex = 22;
            this.backspace.TabStop = false;
            this.backspace.Text = "Backspace";
            this.backspace.UseVisualStyleBackColor = false;
            // 
            // q
            // 
            this.q.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.q.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.q.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.q.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.q.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.q.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.q.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.q.Location = new System.Drawing.Point(134, 264);
            this.q.Margin = new System.Windows.Forms.Padding(4);
            this.q.Name = "q";
            this.q.Size = new System.Drawing.Size(50, 50);
            this.q.TabIndex = 23;
            this.q.TabStop = false;
            this.q.Text = "Q   \n   Й";
            this.q.UseVisualStyleBackColor = false;
            // 
            // w
            // 
            this.w.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.w.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.w.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.w.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.w.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.w.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.w.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.w.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.w.Location = new System.Drawing.Point(192, 264);
            this.w.Margin = new System.Windows.Forms.Padding(4);
            this.w.Name = "w";
            this.w.Size = new System.Drawing.Size(50, 50);
            this.w.TabIndex = 24;
            this.w.TabStop = false;
            this.w.Text = "W   \n   Ц";
            this.w.UseVisualStyleBackColor = false;
            // 
            // e
            // 
            this.e.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.e.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.e.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.e.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.e.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.e.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.e.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.e.Location = new System.Drawing.Point(250, 264);
            this.e.Margin = new System.Windows.Forms.Padding(4);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(50, 50);
            this.e.TabIndex = 25;
            this.e.TabStop = false;
            this.e.Text = "E   \n   У";
            this.e.UseVisualStyleBackColor = false;
            // 
            // r
            // 
            this.r.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.r.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.r.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.r.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.r.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.r.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.r.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.r.Location = new System.Drawing.Point(308, 264);
            this.r.Margin = new System.Windows.Forms.Padding(4);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(50, 50);
            this.r.TabIndex = 26;
            this.r.TabStop = false;
            this.r.Text = "R   \n   К";
            this.r.UseVisualStyleBackColor = false;
            // 
            // t
            // 
            this.t.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.t.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.t.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.t.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.t.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.t.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.t.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.t.Location = new System.Drawing.Point(366, 264);
            this.t.Margin = new System.Windows.Forms.Padding(4);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(50, 50);
            this.t.TabIndex = 27;
            this.t.TabStop = false;
            this.t.Text = "T   \n   Е";
            this.t.UseVisualStyleBackColor = false;
            // 
            // y
            // 
            this.y.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.y.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.y.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.y.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.y.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.y.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.y.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.y.Location = new System.Drawing.Point(424, 264);
            this.y.Margin = new System.Windows.Forms.Padding(4);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(50, 50);
            this.y.TabIndex = 28;
            this.y.TabStop = false;
            this.y.Text = "Y   \n   Н";
            this.y.UseVisualStyleBackColor = false;
            // 
            // u
            // 
            this.u.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.u.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.u.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.u.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.u.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.u.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.u.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.u.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.u.Location = new System.Drawing.Point(482, 264);
            this.u.Margin = new System.Windows.Forms.Padding(4);
            this.u.Name = "u";
            this.u.Size = new System.Drawing.Size(50, 50);
            this.u.TabIndex = 29;
            this.u.TabStop = false;
            this.u.Text = "U   \n   Г";
            this.u.UseVisualStyleBackColor = false;
            // 
            // i
            // 
            this.i.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.i.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.i.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.i.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.i.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.i.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.i.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.i.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.i.Location = new System.Drawing.Point(540, 264);
            this.i.Margin = new System.Windows.Forms.Padding(4);
            this.i.Name = "i";
            this.i.Size = new System.Drawing.Size(50, 50);
            this.i.TabIndex = 30;
            this.i.TabStop = false;
            this.i.Text = "I   \n   Ш";
            this.i.UseVisualStyleBackColor = false;
            // 
            // o
            // 
            this.o.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.o.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.o.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.o.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.o.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.o.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.o.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.o.Location = new System.Drawing.Point(598, 264);
            this.o.Margin = new System.Windows.Forms.Padding(4);
            this.o.Name = "o";
            this.o.Size = new System.Drawing.Size(50, 50);
            this.o.TabIndex = 31;
            this.o.TabStop = false;
            this.o.Text = "O   \n   Щ";
            this.o.UseVisualStyleBackColor = false;
            // 
            // p
            // 
            this.p.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.p.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.p.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.p.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.p.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.p.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.p.Location = new System.Drawing.Point(656, 264);
            this.p.Margin = new System.Windows.Forms.Padding(4);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(50, 50);
            this.p.TabIndex = 32;
            this.p.TabStop = false;
            this.p.Text = "P   \n   З";
            this.p.UseVisualStyleBackColor = false;
            // 
            // bracketL
            // 
            this.bracketL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.bracketL.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.bracketL.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.bracketL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.bracketL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.bracketL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bracketL.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bracketL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.bracketL.Location = new System.Drawing.Point(714, 264);
            this.bracketL.Margin = new System.Windows.Forms.Padding(4);
            this.bracketL.Name = "bracketL";
            this.bracketL.Size = new System.Drawing.Size(50, 50);
            this.bracketL.TabIndex = 33;
            this.bracketL.TabStop = false;
            this.bracketL.Text = "{    \n[   Х";
            this.bracketL.UseVisualStyleBackColor = false;
            // 
            // bracketR
            // 
            this.bracketR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.bracketR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.bracketR.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.bracketR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.bracketR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.bracketR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bracketR.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bracketR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.bracketR.Location = new System.Drawing.Point(772, 264);
            this.bracketR.Margin = new System.Windows.Forms.Padding(4);
            this.bracketR.Name = "bracketR";
            this.bracketR.Size = new System.Drawing.Size(50, 50);
            this.bracketR.TabIndex = 34;
            this.bracketR.TabStop = false;
            this.bracketR.Text = "}    \n]   Ъ";
            this.bracketR.UseVisualStyleBackColor = false;
            // 
            // a
            // 
            this.a.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.a.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.a.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.a.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.a.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.a.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.a.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.a.Location = new System.Drawing.Point(149, 322);
            this.a.Margin = new System.Windows.Forms.Padding(4);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(50, 50);
            this.a.TabIndex = 35;
            this.a.TabStop = false;
            this.a.Text = "A   \n   Ф";
            this.a.UseVisualStyleBackColor = false;
            // 
            // s
            // 
            this.s.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.s.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.s.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.s.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.s.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.s.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.s.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.s.Location = new System.Drawing.Point(207, 322);
            this.s.Margin = new System.Windows.Forms.Padding(4);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(50, 50);
            this.s.TabIndex = 36;
            this.s.TabStop = false;
            this.s.Text = "S   \n   Ы";
            this.s.UseVisualStyleBackColor = false;
            // 
            // d
            // 
            this.d.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.d.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.d.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.d.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.d.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.d.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.d.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.d.Location = new System.Drawing.Point(265, 322);
            this.d.Margin = new System.Windows.Forms.Padding(4);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(50, 50);
            this.d.TabIndex = 37;
            this.d.TabStop = false;
            this.d.Text = "D   \n   В";
            this.d.UseVisualStyleBackColor = false;
            // 
            // f
            // 
            this.f.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.f.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.f.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.f.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.f.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.f.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.f.Location = new System.Drawing.Point(323, 322);
            this.f.Margin = new System.Windows.Forms.Padding(4);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(50, 50);
            this.f.TabIndex = 38;
            this.f.TabStop = false;
            this.f.Text = "F   \n   А";
            this.f.UseVisualStyleBackColor = false;
            // 
            // g
            // 
            this.g.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.g.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.g.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.g.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.g.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.g.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.g.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.g.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.g.Location = new System.Drawing.Point(381, 322);
            this.g.Margin = new System.Windows.Forms.Padding(4);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(50, 50);
            this.g.TabIndex = 39;
            this.g.TabStop = false;
            this.g.Text = "G   \n   П";
            this.g.UseVisualStyleBackColor = false;
            // 
            // h
            // 
            this.h.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.h.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.h.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.h.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.h.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.h.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.h.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.h.Location = new System.Drawing.Point(439, 322);
            this.h.Margin = new System.Windows.Forms.Padding(4);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(50, 50);
            this.h.TabIndex = 40;
            this.h.TabStop = false;
            this.h.Text = "H   \n   Р";
            this.h.UseVisualStyleBackColor = false;
            // 
            // j
            // 
            this.j.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.j.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.j.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.j.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.j.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.j.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.j.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.j.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.j.Location = new System.Drawing.Point(497, 322);
            this.j.Margin = new System.Windows.Forms.Padding(4);
            this.j.Name = "j";
            this.j.Size = new System.Drawing.Size(50, 50);
            this.j.TabIndex = 41;
            this.j.TabStop = false;
            this.j.Text = "J   \n   О";
            this.j.UseVisualStyleBackColor = false;
            // 
            // k
            // 
            this.k.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.k.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.k.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.k.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.k.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.k.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.k.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.k.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.k.Location = new System.Drawing.Point(555, 322);
            this.k.Margin = new System.Windows.Forms.Padding(4);
            this.k.Name = "k";
            this.k.Size = new System.Drawing.Size(50, 50);
            this.k.TabIndex = 42;
            this.k.TabStop = false;
            this.k.Text = "K   \n   Л";
            this.k.UseVisualStyleBackColor = false;
            // 
            // l
            // 
            this.l.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.l.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.l.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.l.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.l.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.l.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.l.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.l.Location = new System.Drawing.Point(613, 322);
            this.l.Margin = new System.Windows.Forms.Padding(4);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(50, 50);
            this.l.TabIndex = 43;
            this.l.TabStop = false;
            this.l.Text = "L   \n   Д";
            this.l.UseVisualStyleBackColor = false;
            // 
            // colon
            // 
            this.colon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.colon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.colon.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.colon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.colon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.colon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colon.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.colon.Location = new System.Drawing.Point(671, 322);
            this.colon.Margin = new System.Windows.Forms.Padding(4);
            this.colon.Name = "colon";
            this.colon.Size = new System.Drawing.Size(50, 50);
            this.colon.TabIndex = 44;
            this.colon.TabStop = false;
            this.colon.Text = ":   \n ;   Ж";
            this.colon.UseVisualStyleBackColor = false;
            // 
            // mark
            // 
            this.mark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.mark.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.mark.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.mark.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.mark.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.mark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mark.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.mark.Location = new System.Drawing.Point(729, 322);
            this.mark.Margin = new System.Windows.Forms.Padding(4);
            this.mark.Name = "mark";
            this.mark.Size = new System.Drawing.Size(50, 50);
            this.mark.TabIndex = 45;
            this.mark.TabStop = false;
            this.mark.Text = "\"   \n  \'   Э";
            this.mark.UseVisualStyleBackColor = false;
            // 
            // z
            // 
            this.z.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.z.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.z.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.z.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.z.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.z.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.z.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.z.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.z.Location = new System.Drawing.Point(180, 380);
            this.z.Margin = new System.Windows.Forms.Padding(4);
            this.z.Name = "z";
            this.z.Size = new System.Drawing.Size(50, 50);
            this.z.TabIndex = 46;
            this.z.TabStop = false;
            this.z.Text = "Z   \n   Я";
            this.z.UseVisualStyleBackColor = false;
            // 
            // x
            // 
            this.x.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.x.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.x.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.x.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.x.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.x.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.x.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.x.Location = new System.Drawing.Point(238, 380);
            this.x.Margin = new System.Windows.Forms.Padding(4);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(50, 50);
            this.x.TabIndex = 47;
            this.x.TabStop = false;
            this.x.Text = "X   \n   Ч";
            this.x.UseVisualStyleBackColor = false;
            // 
            // c
            // 
            this.c.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.c.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.c.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.c.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.c.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.c.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.c.Location = new System.Drawing.Point(296, 380);
            this.c.Margin = new System.Windows.Forms.Padding(4);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(50, 50);
            this.c.TabIndex = 48;
            this.c.TabStop = false;
            this.c.Text = "C   \n   С";
            this.c.UseVisualStyleBackColor = false;
            // 
            // v
            // 
            this.v.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.v.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.v.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.v.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.v.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.v.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.v.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.v.Location = new System.Drawing.Point(354, 380);
            this.v.Margin = new System.Windows.Forms.Padding(4);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(50, 50);
            this.v.TabIndex = 49;
            this.v.TabStop = false;
            this.v.Text = "V   \n   М";
            this.v.UseVisualStyleBackColor = false;
            // 
            // b
            // 
            this.b.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.b.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.b.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.b.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.b.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.b.Location = new System.Drawing.Point(412, 380);
            this.b.Margin = new System.Windows.Forms.Padding(4);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(50, 50);
            this.b.TabIndex = 50;
            this.b.TabStop = false;
            this.b.Text = "B   \n   И";
            this.b.UseVisualStyleBackColor = false;
            // 
            // n
            // 
            this.n.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.n.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.n.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.n.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.n.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.n.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.n.Location = new System.Drawing.Point(470, 380);
            this.n.Margin = new System.Windows.Forms.Padding(4);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(50, 50);
            this.n.TabIndex = 51;
            this.n.TabStop = false;
            this.n.Text = "N   \n   Т";
            this.n.UseVisualStyleBackColor = false;
            // 
            // m
            // 
            this.m.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.m.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.m.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.m.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.m.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.m.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.m.Location = new System.Drawing.Point(528, 380);
            this.m.Margin = new System.Windows.Forms.Padding(4);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(50, 50);
            this.m.TabIndex = 52;
            this.m.TabStop = false;
            this.m.Text = "M   \n   Ь";
            this.m.UseVisualStyleBackColor = false;
            // 
            // lessMark
            // 
            this.lessMark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.lessMark.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lessMark.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.lessMark.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.lessMark.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.lessMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lessMark.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lessMark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.lessMark.Location = new System.Drawing.Point(586, 380);
            this.lessMark.Margin = new System.Windows.Forms.Padding(4);
            this.lessMark.Name = "lessMark";
            this.lessMark.Size = new System.Drawing.Size(50, 50);
            this.lessMark.TabIndex = 53;
            this.lessMark.TabStop = false;
            this.lessMark.Text = "<   \n,   Б";
            this.lessMark.UseVisualStyleBackColor = false;
            // 
            // moreMark
            // 
            this.moreMark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.moreMark.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.moreMark.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.moreMark.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.moreMark.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.moreMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moreMark.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moreMark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.moreMark.Location = new System.Drawing.Point(644, 380);
            this.moreMark.Margin = new System.Windows.Forms.Padding(4);
            this.moreMark.Name = "moreMark";
            this.moreMark.Size = new System.Drawing.Size(50, 50);
            this.moreMark.TabIndex = 54;
            this.moreMark.TabStop = false;
            this.moreMark.Text = ">   \n.   Ю";
            this.moreMark.UseVisualStyleBackColor = false;
            // 
            // questionMark
            // 
            this.questionMark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.questionMark.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.questionMark.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.questionMark.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.questionMark.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.questionMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.questionMark.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionMark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.questionMark.Location = new System.Drawing.Point(702, 380);
            this.questionMark.Margin = new System.Windows.Forms.Padding(4);
            this.questionMark.Name = "questionMark";
            this.questionMark.Size = new System.Drawing.Size(50, 50);
            this.questionMark.TabIndex = 55;
            this.questionMark.TabStop = false;
            this.questionMark.Text = "?   ,\n/   .";
            this.questionMark.UseVisualStyleBackColor = false;
            // 
            // slashes
            // 
            this.slashes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.slashes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.slashes.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.slashes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.slashes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.slashes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.slashes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slashes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.slashes.Location = new System.Drawing.Point(830, 264);
            this.slashes.Margin = new System.Windows.Forms.Padding(4);
            this.slashes.Name = "slashes";
            this.slashes.Size = new System.Drawing.Size(69, 50);
            this.slashes.TabIndex = 56;
            this.slashes.TabStop = false;
            this.slashes.Text = "|       /\n\\       \\";
            this.slashes.UseVisualStyleBackColor = false;
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.enter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.enter.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.enter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.enter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.enter.Location = new System.Drawing.Point(787, 322);
            this.enter.Margin = new System.Windows.Forms.Padding(4);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(112, 50);
            this.enter.TabIndex = 57;
            this.enter.TabStop = false;
            this.enter.Text = "Enter";
            this.enter.UseVisualStyleBackColor = false;
            // 
            // shiftRight
            // 
            this.shiftRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.shiftRight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.shiftRight.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.shiftRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.shiftRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.shiftRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shiftRight.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shiftRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.shiftRight.Location = new System.Drawing.Point(760, 380);
            this.shiftRight.Margin = new System.Windows.Forms.Padding(4);
            this.shiftRight.Name = "shiftRight";
            this.shiftRight.Size = new System.Drawing.Size(139, 50);
            this.shiftRight.TabIndex = 58;
            this.shiftRight.TabStop = false;
            this.shiftRight.Text = "Shift";
            this.shiftRight.UseVisualStyleBackColor = false;
            // 
            // shiftLeft
            // 
            this.shiftLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.shiftLeft.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.shiftLeft.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.shiftLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.shiftLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.shiftLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shiftLeft.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shiftLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.shiftLeft.Location = new System.Drawing.Point(45, 380);
            this.shiftLeft.Margin = new System.Windows.Forms.Padding(4);
            this.shiftLeft.Name = "shiftLeft";
            this.shiftLeft.Size = new System.Drawing.Size(127, 50);
            this.shiftLeft.TabIndex = 59;
            this.shiftLeft.TabStop = false;
            this.shiftLeft.Text = "Shift";
            this.shiftLeft.UseVisualStyleBackColor = false;
            // 
            // tab
            // 
            this.tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.tab.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tab.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.tab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.tab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.tab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tab.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.tab.Location = new System.Drawing.Point(45, 264);
            this.tab.Margin = new System.Windows.Forms.Padding(4);
            this.tab.Name = "tab";
            this.tab.Size = new System.Drawing.Size(81, 50);
            this.tab.TabIndex = 60;
            this.tab.TabStop = false;
            this.tab.Text = "Tab";
            this.tab.UseVisualStyleBackColor = false;
            // 
            // capsLk
            // 
            this.capsLk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.capsLk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.capsLk.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.capsLk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.capsLk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.capsLk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.capsLk.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capsLk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.capsLk.Location = new System.Drawing.Point(45, 322);
            this.capsLk.Margin = new System.Windows.Forms.Padding(4);
            this.capsLk.Name = "capsLk";
            this.capsLk.Size = new System.Drawing.Size(96, 50);
            this.capsLk.TabIndex = 61;
            this.capsLk.TabStop = false;
            this.capsLk.Text = "CapsLook";
            this.capsLk.UseVisualStyleBackColor = false;
            // 
            // ctrlLeft
            // 
            this.ctrlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.ctrlLeft.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ctrlLeft.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.ctrlLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.ctrlLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.ctrlLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctrlLeft.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.ctrlLeft.Location = new System.Drawing.Point(44, 438);
            this.ctrlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlLeft.Name = "ctrlLeft";
            this.ctrlLeft.Size = new System.Drawing.Size(109, 50);
            this.ctrlLeft.TabIndex = 62;
            this.ctrlLeft.TabStop = false;
            this.ctrlLeft.Text = "Ctrl";
            this.ctrlLeft.UseVisualStyleBackColor = false;
            // 
            // altLeft
            // 
            this.altLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.altLeft.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.altLeft.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.altLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.altLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.altLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.altLeft.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.altLeft.Location = new System.Drawing.Point(161, 438);
            this.altLeft.Margin = new System.Windows.Forms.Padding(4);
            this.altLeft.Name = "altLeft";
            this.altLeft.Size = new System.Drawing.Size(96, 50);
            this.altLeft.TabIndex = 63;
            this.altLeft.TabStop = false;
            this.altLeft.Text = "Alt";
            this.altLeft.UseVisualStyleBackColor = false;
            // 
            // space
            // 
            this.space.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.space.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.space.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.space.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.space.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.space.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.space.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.space.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.space.Location = new System.Drawing.Point(265, 438);
            this.space.Margin = new System.Windows.Forms.Padding(4);
            this.space.Name = "space";
            this.space.Size = new System.Drawing.Size(359, 50);
            this.space.TabIndex = 64;
            this.space.TabStop = false;
            this.space.UseVisualStyleBackColor = false;
            // 
            // altRight
            // 
            this.altRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.altRight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.altRight.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.altRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.altRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.altRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.altRight.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.altRight.Location = new System.Drawing.Point(632, 438);
            this.altRight.Margin = new System.Windows.Forms.Padding(4);
            this.altRight.Name = "altRight";
            this.altRight.Size = new System.Drawing.Size(82, 50);
            this.altRight.TabIndex = 65;
            this.altRight.TabStop = false;
            this.altRight.Text = "Alt";
            this.altRight.UseVisualStyleBackColor = false;
            // 
            // ctrlRight
            // 
            this.ctrlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.ctrlRight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ctrlRight.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.ctrlRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.ctrlRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.ctrlRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctrlRight.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.ctrlRight.Location = new System.Drawing.Point(722, 438);
            this.ctrlRight.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlRight.Name = "ctrlRight";
            this.ctrlRight.Size = new System.Drawing.Size(177, 50);
            this.ctrlRight.TabIndex = 66;
            this.ctrlRight.TabStop = false;
            this.ctrlRight.Text = "Ctrl";
            this.ctrlRight.UseVisualStyleBackColor = false;
            // 
            // strOutTextBox
            // 
            this.strOutTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.strOutTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.strOutTextBox.Enabled = false;
            this.strOutTextBox.Font = new System.Drawing.Font("Calibri", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strOutTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(175)))));
            this.strOutTextBox.Location = new System.Drawing.Point(153, 103);
            this.strOutTextBox.Multiline = true;
            this.strOutTextBox.Name = "strOutTextBox";
            this.strOutTextBox.ReadOnly = true;
            this.strOutTextBox.Size = new System.Drawing.Size(640, 70);
            this.strOutTextBox.TabIndex = 70;
            this.strOutTextBox.TabStop = false;
            this.strOutTextBox.Text = "\r\n";
            // 
            // leftHand
            // 
            this.leftHand.BackgroundImage = global::keyTrainer.Properties.Resources.LE;
            this.leftHand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.leftHand.Location = new System.Drawing.Point(2, 49);
            this.leftHand.Name = "leftHand";
            this.leftHand.Size = new System.Drawing.Size(150, 150);
            this.leftHand.TabIndex = 67;
            this.leftHand.TabStop = false;
            // 
            // rightHand
            // 
            this.rightHand.BackgroundImage = global::keyTrainer.Properties.Resources.RE;
            this.rightHand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rightHand.Location = new System.Drawing.Point(799, 49);
            this.rightHand.Name = "rightHand";
            this.rightHand.Size = new System.Drawing.Size(150, 150);
            this.rightHand.TabIndex = 68;
            this.rightHand.TabStop = false;
            // 
            // modePanel
            // 
            this.modePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.modePanel.Controls.Add(this.back);
            this.modePanel.Controls.Add(this.modeSharp);
            this.modePanel.Controls.Add(this.modeRu);
            this.modePanel.Controls.Add(this.modeEn);
            this.modePanel.Location = new System.Drawing.Point(0, -100);
            this.modePanel.Name = "modePanel";
            this.modePanel.Size = new System.Drawing.Size(954, 100);
            this.modePanel.TabIndex = 71;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(25)))));
            this.back.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(25)))));
            this.back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(84)))), ((int)(((byte)(45)))));
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.back.Location = new System.Drawing.Point(827, 33);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(115, 35);
            this.back.TabIndex = 76;
            this.back.TabStop = false;
            this.back.Text = "НАЗАД";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // modeSharp
            // 
            this.modeSharp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(25)))));
            this.modeSharp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.modeSharp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(25)))));
            this.modeSharp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(84)))), ((int)(((byte)(45)))));
            this.modeSharp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modeSharp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.modeSharp.Location = new System.Drawing.Point(253, 33);
            this.modeSharp.Name = "modeSharp";
            this.modeSharp.Size = new System.Drawing.Size(115, 35);
            this.modeSharp.TabIndex = 75;
            this.modeSharp.TabStop = false;
            this.modeSharp.Text = "Свой текст";
            this.modeSharp.UseVisualStyleBackColor = false;
            this.modeSharp.Click += new System.EventHandler(this.modeSharp_Click);
            // 
            // modeRu
            // 
            this.modeRu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(25)))));
            this.modeRu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.modeRu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(25)))));
            this.modeRu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(84)))), ((int)(((byte)(45)))));
            this.modeRu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modeRu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.modeRu.Location = new System.Drawing.Point(132, 33);
            this.modeRu.Name = "modeRu";
            this.modeRu.Size = new System.Drawing.Size(115, 35);
            this.modeRu.TabIndex = 74;
            this.modeRu.TabStop = false;
            this.modeRu.Text = "Русский";
            this.modeRu.UseVisualStyleBackColor = false;
            this.modeRu.Click += new System.EventHandler(this.modeRu_Click);
            // 
            // modeEn
            // 
            this.modeEn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(25)))));
            this.modeEn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.modeEn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(25)))));
            this.modeEn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(84)))), ((int)(((byte)(45)))));
            this.modeEn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modeEn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.modeEn.Location = new System.Drawing.Point(11, 33);
            this.modeEn.Name = "modeEn";
            this.modeEn.Size = new System.Drawing.Size(115, 35);
            this.modeEn.TabIndex = 73;
            this.modeEn.TabStop = false;
            this.modeEn.Text = "Английский";
            this.modeEn.UseVisualStyleBackColor = false;
            this.modeEn.Click += new System.EventHandler(this.modeEn_Click);
            // 
            // randomCB
            // 
            this.randomCB.Checked = true;
            this.randomCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.randomCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randomCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(220)))));
            this.randomCB.Location = new System.Drawing.Point(349, 7);
            this.randomCB.Name = "randomCB";
            this.randomCB.Size = new System.Drawing.Size(171, 35);
            this.randomCB.TabIndex = 72;
            this.randomCB.Text = "Случайная строка";
            this.randomCB.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(954, 501);
            this.Controls.Add(this.randomCB);
            this.Controls.Add(this.modePanel);
            this.Controls.Add(this.strOutTextBox);
            this.Controls.Add(this.ctrlRight);
            this.Controls.Add(this.altRight);
            this.Controls.Add(this.space);
            this.Controls.Add(this.altLeft);
            this.Controls.Add(this.ctrlLeft);
            this.Controls.Add(this.capsLk);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.shiftLeft);
            this.Controls.Add(this.shiftRight);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.slashes);
            this.Controls.Add(this.questionMark);
            this.Controls.Add(this.moreMark);
            this.Controls.Add(this.lessMark);
            this.Controls.Add(this.m);
            this.Controls.Add(this.n);
            this.Controls.Add(this.b);
            this.Controls.Add(this.v);
            this.Controls.Add(this.c);
            this.Controls.Add(this.x);
            this.Controls.Add(this.z);
            this.Controls.Add(this.mark);
            this.Controls.Add(this.colon);
            this.Controls.Add(this.l);
            this.Controls.Add(this.k);
            this.Controls.Add(this.j);
            this.Controls.Add(this.h);
            this.Controls.Add(this.g);
            this.Controls.Add(this.f);
            this.Controls.Add(this.d);
            this.Controls.Add(this.s);
            this.Controls.Add(this.a);
            this.Controls.Add(this.bracketR);
            this.Controls.Add(this.bracketL);
            this.Controls.Add(this.p);
            this.Controls.Add(this.o);
            this.Controls.Add(this.i);
            this.Controls.Add(this.u);
            this.Controls.Add(this.y);
            this.Controls.Add(this.t);
            this.Controls.Add(this.r);
            this.Controls.Add(this.e);
            this.Controls.Add(this.w);
            this.Controls.Add(this.q);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.tilda);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.labelTypo);
            this.Controls.Add(this.again);
            this.Controls.Add(this.mode);
            this.Controls.Add(this.strInTextbox);
            this.Controls.Add(this.labelSym);
            this.Controls.Add(this.keyboard);
            this.Controls.Add(this.leftHand);
            this.Controls.Add(this.rightHand);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Key Trainer";
            this.InputLanguageChanged += new System.Windows.Forms.InputLanguageChangedEventHandler(this.MainForm_InputLanguageChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.leftHand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightHand)).EndInit();
            this.modePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button keyboard;
        private System.Windows.Forms.Label labelSym;
        private System.Windows.Forms.TextBox strInTextbox;
        private System.Windows.Forms.Button mode;
        private System.Windows.Forms.Button again;
        private System.Windows.Forms.Label labelTypo;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button tilda;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button q;
        private System.Windows.Forms.Button w;
        private System.Windows.Forms.Button e;
        private System.Windows.Forms.Button r;
        private System.Windows.Forms.Button t;
        private System.Windows.Forms.Button y;
        private System.Windows.Forms.Button u;
        private System.Windows.Forms.Button i;
        private System.Windows.Forms.Button o;
        private System.Windows.Forms.Button p;
        private System.Windows.Forms.Button bracketL;
        private System.Windows.Forms.Button bracketR;
        private System.Windows.Forms.Button a;
        private System.Windows.Forms.Button s;
        private System.Windows.Forms.Button d;
        private System.Windows.Forms.Button f;
        private System.Windows.Forms.Button g;
        private System.Windows.Forms.Button h;
        private System.Windows.Forms.Button j;
        private System.Windows.Forms.Button k;
        private System.Windows.Forms.Button l;
        private System.Windows.Forms.Button colon;
        private System.Windows.Forms.Button mark;
        private System.Windows.Forms.Button z;
        private System.Windows.Forms.Button x;
        private System.Windows.Forms.Button c;
        private System.Windows.Forms.Button v;
        private System.Windows.Forms.Button b;
        private System.Windows.Forms.Button n;
        private System.Windows.Forms.Button m;
        private System.Windows.Forms.Button lessMark;
        private System.Windows.Forms.Button moreMark;
        private System.Windows.Forms.Button questionMark;
        private System.Windows.Forms.Button slashes;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button shiftRight;
        private System.Windows.Forms.Button shiftLeft;
        private System.Windows.Forms.Button tab;
        private System.Windows.Forms.Button capsLk;
        private System.Windows.Forms.Button ctrlLeft;
        private System.Windows.Forms.Button altLeft;
        private System.Windows.Forms.Button space;
        private System.Windows.Forms.Button altRight;
        private System.Windows.Forms.Button ctrlRight;
        private System.Windows.Forms.PictureBox leftHand;
        private System.Windows.Forms.PictureBox rightHand;
        private System.Windows.Forms.TextBox strOutTextBox;
        private System.Windows.Forms.Panel modePanel;
        private System.Windows.Forms.Button modeEn;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button modeSharp;
        private System.Windows.Forms.Button modeRu;
        private System.Windows.Forms.CheckBox randomCB;
    }
}

