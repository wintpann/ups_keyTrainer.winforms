using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace keyTrainer
{
    public partial class MainForm : Form
    {
        enum Mode
        {
            EN,
            RU,
            SHARP,
            NONE
        };

        Mode currentMode = Mode.NONE;
        int mistakes = 0;
        int seconds = 0;
        int symbolEntered = 0;
        bool KeyBoardHidden = false;
        InputLanguage inputLanguage;
        Random rand;
        Timer timer = new Timer();
        private List<string> textArray;
        private int currentString = 0;
        private int currentSymbol = 0;

        public MainForm()
        {
            InitializeComponent();
            TextData.GetTextData();
            rand = new Random((int)System.DateTime.Now.Ticks);
            rand.Next();
            timer.Interval = 1000;
            timer.Tick += AddSecond;
            timer.Start();
            textArray = new List<string>();
        }

        private void AddSecond(object sender, EventArgs e)
        {
            seconds++;
        }
        private void SetOutText()
        {
            if (currentString == textArray.Count - 2)
            {
                strOutTextBox.Text = textArray[currentString] + "\r\n" + textArray[currentString + 1] + "\r\n" + textArray[0];
            }
            else if (currentString == textArray.Count - 1)
            {
                strOutTextBox.Text = textArray[currentString] + "\r\n" + textArray[0] + "\r\n" + textArray[1];
            }
            else
            {
                strOutTextBox.Text = textArray[currentString] + "\r\n" + textArray[currentString + 1] + "\r\n" + textArray[currentString + 2];
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs key)
        {
            this.strInTextbox.Focus();
            key.Handled = true;
            if (key.Shift)
            {
                shiftLeft.BackColor = Color.Gray;
                shiftRight.BackColor = Color.Gray;
            }
            if (key.Control)
            {
                ctrlLeft.BackColor = Color.Gray;
                ctrlRight.BackColor = Color.Gray;
            }
            if (key.Alt)
            {
                altLeft.BackColor = Color.Gray;
                altRight.BackColor = Color.Gray;
            }
            switch (key.KeyData)
            {
                case Keys.Q:
                    q.BackColor = Color.Gray;
                    break;
                case Keys.W:
                    w.BackColor = Color.Gray;
                    break;
                case Keys.E:
                    e.BackColor = Color.Gray;
                    break;
                case Keys.R:
                    r.BackColor = Color.Gray;
                    break;
                case Keys.T:
                    t.BackColor = Color.Gray;
                    break;
                case Keys.Y:
                    y.BackColor = Color.Gray;
                    break;
                case Keys.U:
                    u.BackColor = Color.Gray;
                    break;
                case Keys.I:
                    i.BackColor = Color.Gray;
                    break;
                case Keys.O:
                    o.BackColor = Color.Gray;
                    break;
                case Keys.P:
                    p.BackColor = Color.Gray;
                    break;
                case Keys.OemOpenBrackets:
                    bracketL.BackColor = Color.Gray;
                    break;
                case Keys.OemCloseBrackets:
                    bracketR.BackColor = Color.Gray;
                    break;
                case Keys.A:
                    a.BackColor = Color.Gray;
                    break;
                case Keys.S:
                    s.BackColor = Color.Gray;
                    break;
                case Keys.D:
                    d.BackColor = Color.Gray;
                    break;
                case Keys.F:
                    f.BackColor = Color.Gray;
                    break;
                case Keys.G:
                    g.BackColor = Color.Gray;
                    break;
                case Keys.H:
                    h.BackColor = Color.Gray;
                    break;
                case Keys.J:
                    j.BackColor = Color.Gray;
                    break;
                case Keys.K:
                    k.BackColor = Color.Gray;
                    break;
                case Keys.L:
                    l.BackColor = Color.Gray;
                    break;
                case Keys.OemSemicolon:
                    colon.BackColor = Color.Gray;
                    break;
                case Keys.OemQuotes:
                    mark.BackColor = Color.Gray;
                    break;
                case Keys.Z:
                    z.BackColor = Color.Gray;
                    break;
                case Keys.X:
                    x.BackColor = Color.Gray;
                    break;
                case Keys.C:
                    c.BackColor = Color.Gray;
                    break;
                case Keys.V:
                    v.BackColor = Color.Gray;
                    break;
                case Keys.B:
                    b.BackColor = Color.Gray;
                    break;
                case Keys.N:
                    n.BackColor = Color.Gray;
                    break;
                case Keys.M:
                    m.BackColor = Color.Gray;
                    break;
                case Keys.Oemcomma:
                    lessMark.BackColor = Color.Gray;
                    break;
                case Keys.OemPeriod:
                    moreMark.BackColor = Color.Gray;
                    break;
                case Keys.OemQuestion:
                    questionMark.BackColor = Color.Gray;
                    break;
                case Keys.Oemtilde:
                    tilda.BackColor = Color.Gray;
                    break;
                case Keys.D1:
                    one.BackColor = Color.Gray;
                    break;
                case Keys.D2:
                    two.BackColor = Color.Gray;
                    break;
                case Keys.D3:
                    three.BackColor = Color.Gray;
                    break;
                case Keys.D4:
                    four.BackColor = Color.Gray;
                    break;
                case Keys.D5:
                    five.BackColor = Color.Gray;
                    break;
                case Keys.D6:
                    six.BackColor = Color.Gray;
                    break;
                case Keys.D7:
                    seven.BackColor = Color.Gray;
                    break;
                case Keys.D8:
                    eight.BackColor = Color.Gray;
                    break;
                case Keys.D9:
                    nine.BackColor = Color.Gray;
                    break;
                case Keys.D0:
                    zero.BackColor = Color.Gray;
                    break;
                case Keys.OemMinus:
                    minus.BackColor = Color.Gray;
                    break;
                case Keys.Oemplus:
                    plus.BackColor = Color.Gray;
                    break;
                case Keys.Back:
                    backspace.BackColor = Color.Gray;
                    break;
                case Keys.Tab:
                    tab.BackColor = Color.Gray;
                    break;
                case Keys.OemPipe:
                    slashes.BackColor = Color.Gray;
                    break;
                case Keys.CapsLock:
                    capsLk.BackColor = Color.Gray;
                    break;
                case Keys.Enter:
                    enter.BackColor = Color.Gray;
                    break;
                case Keys.Space:
                    space.BackColor = Color.Gray;
                    break;
            }
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs key)
        {
            key.Handled = true;
            if (!key.Shift)
            {
                shiftLeft.BackColor = Color.FromArgb(35, 35, 40);
                shiftRight.BackColor = Color.FromArgb(35, 35, 40);
            }
            if (!key.Control)
            {
                ctrlLeft.BackColor = Color.FromArgb(35, 35, 40);
                ctrlRight.BackColor = Color.FromArgb(35, 35, 40);
            }
            if (!key.Alt)
            {
                altLeft.BackColor = Color.FromArgb(35, 35, 40);
                altRight.BackColor = Color.FromArgb(35, 35, 40);
            }
            switch (key.KeyData)
            {
                case Keys.Q:
                    q.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.W:
                    w.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.E:
                    e.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.R:
                    r.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.T:
                    t.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.Y:
                    y.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.U:
                    u.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.I:
                    i.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.O:
                    o.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.P:
                    p.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.OemOpenBrackets:
                    bracketL.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.OemCloseBrackets:
                    bracketR.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.A:
                    a.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.S:
                    s.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.D:
                    d.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.F:
                    f.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.G:
                    g.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.H:
                    h.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.J:
                    j.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.K:
                    k.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.L:
                    l.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.OemSemicolon:
                    colon.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.OemQuotes:
                    mark.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.Z:
                    z.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.X:
                    x.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.C:
                    c.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.V:
                    v.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.B:
                    b.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.N:
                    n.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.M:
                    m.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.Oemcomma:
                    lessMark.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.OemPeriod:
                    moreMark.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.OemQuestion:
                    questionMark.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.Oemtilde:
                    tilda.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.D1:
                    one.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.D2:
                    two.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.D3:
                    three.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.D4:
                    four.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.D5:
                    five.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.D6:
                    six.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.D7:
                    seven.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.D8:
                    eight.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.D9:
                    nine.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.D0:
                    zero.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.OemMinus:
                    minus.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.Oemplus:
                    plus.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.Back:
                    backspace.BackColor = Color.FromArgb(35, 35, 40);
                    if (strInTextbox.Text != "")
                    {
                        symbolEntered--;
                    }
                    break;
                case Keys.Tab:
                    tab.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.OemPipe:
                    slashes.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.CapsLock:
                    capsLk.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.Enter:
                    enter.BackColor = Color.FromArgb(35, 35, 40);
                    break;
                case Keys.Space:
                    space.BackColor = Color.FromArgb(35, 35, 40);
                    break;
            }
            MarkFingerAndKey();
        }

        private void CheckMistake()
        {
            symbolEntered++;
            if (strInTextbox.BackColor == Color.Firebrick)
            {
                mistakes++;
            }
        }

        private void ChangeComparisonString()
        {
            if (strInTextbox.Text.Length == strOutTextBox.Lines[0].Length)
            {
                if (strInTextbox.Text == strOutTextBox.Lines[0])
                {
                    if (currentString == textArray.Count - 1)
                    {
                        currentString = 0;
                    }
                    else
                    {
                        currentString++;
                    }
                    SetOutText();
                    strInTextbox.Text = "";
                    labelTypo.Text = "Ошибки: " + Math.Round((double)((double)mistakes / symbolEntered) * 100) + " %";
                    labelSym.Text = "Символов в минуту: " + Math.Round((double)(symbolEntered - mistakes) / ((double)seconds / 60));
                }
            }
        }

        private void CheckCurrentEnterMatching()
        {
            if (currentSymbol < strOutTextBox.Lines[0].Length)
            {
                if (strOutTextBox.Lines[0].Substring(0, currentSymbol + 1) == strInTextbox.Text)
                {
                    strInTextbox.BackColor = Color.FromArgb(40, 40, 45);
                }
                else
                {
                    strInTextbox.BackColor = Color.Firebrick;
                }
            }
        }

        private void MarkFingerAndKey()
        {
            SetAllMarkToDefault();
            if (strInTextbox.BackColor == Color.Firebrick)
            {
                leftHand.BackgroundImage = Properties.Resources.LE;
                rightHand.BackgroundImage = Properties.Resources.R5;
                backspace.BackColor = Colors.R5;
            }
            else
            {
                inputLanguage = InputLanguage.CurrentInputLanguage;

                if (inputLanguage.Culture.TwoLetterISOLanguageName == "en")
                {
                    switch (strOutTextBox.Text[currentSymbol + 1])
                    {
                        case ' ':
                            leftHand.BackgroundImage = Properties.Resources.L1;
                            rightHand.BackgroundImage = Properties.Resources.R1;
                            space.BackColor = Colors.LR1;
                            break;
                        case '`':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.RE;
                            tilda.BackColor = Colors.L5;
                            break;
                        case '1':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.RE;
                            one.BackColor = Colors.L5;
                            break;
                        case '2':
                            leftHand.BackgroundImage = Properties.Resources.L4;
                            rightHand.BackgroundImage = Properties.Resources.RE;
                            two.BackColor = Colors.L4;
                            break;
                        case '3':
                            leftHand.BackgroundImage = Properties.Resources.L3;
                            rightHand.BackgroundImage = Properties.Resources.RE;
                            three.BackColor = Colors.L3;
                            break;
                        case '4':
                            leftHand.BackgroundImage = Properties.Resources.L2;
                            rightHand.BackgroundImage = Properties.Resources.RE;
                            four.BackColor = Colors.L2;
                            break;
                        case '5':
                            leftHand.BackgroundImage = Properties.Resources.L2;
                            rightHand.BackgroundImage = Properties.Resources.RE;
                            five.BackColor = Colors.L2;
                            break;
                        case '6':
                            leftHand.BackgroundImage = Properties.Resources.L2;
                            rightHand.BackgroundImage = Properties.Resources.RE;
                            six.BackColor = Colors.L2;
                            break;
                        case '7':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R2;
                            seven.BackColor = Colors.R2;
                            break;
                        case '8':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R3;
                            eight.BackColor = Colors.R3;
                            break;
                        case '9':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R4;
                            nine.BackColor = Colors.R4;
                            break;
                        case '0':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            zero.BackColor = Colors.R5;
                            break;
                        case '-':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            minus.BackColor = Colors.R5;
                            break;
                        case '=':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            plus.BackColor = Colors.R5;
                            break;
                        case '~':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            tilda.BackColor = Colors.L5;
                            shiftRight.BackColor = Colors.R5;
                            break;
                        case '!':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            one.BackColor = Colors.L5;
                            shiftRight.BackColor = Colors.R5;
                            break;
                        case '@':
                            leftHand.BackgroundImage = Properties.Resources.L4;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            two.BackColor = Colors.L4;
                            shiftRight.BackColor = Colors.R5;
                            break;
                        case '#':
                            leftHand.BackgroundImage = Properties.Resources.L3;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            three.BackColor = Colors.L3;
                            shiftRight.BackColor = Colors.R5;
                            break;
                        case '$':
                            leftHand.BackgroundImage = Properties.Resources.L2;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            four.BackColor = Colors.L2;
                            shiftRight.BackColor = Colors.R5;
                            break;
                        case '%':
                            leftHand.BackgroundImage = Properties.Resources.L2;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            five.BackColor = Colors.L2;
                            shiftRight.BackColor = Colors.R5;
                            break;
                        case '^':
                            leftHand.BackgroundImage = Properties.Resources.L2;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            six.BackColor = Colors.L2;
                            shiftRight.BackColor = Colors.R5;
                            break;
                        case '&':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R2;
                            seven.BackColor = Colors.R2;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        case '*':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R3;
                            eight.BackColor = Colors.R3;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        case '(':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R4;
                            nine.BackColor = Colors.R4;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        case ')':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            zero.BackColor = Colors.R5;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        case '_':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            minus.BackColor = Colors.R5;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        case '+':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            plus.BackColor = Colors.R5;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        case 'q':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.RE;
                            q.BackColor = Colors.L5;
                            break;
                        case 'w':
                            leftHand.BackgroundImage = Properties.Resources.L4;
                            rightHand.BackgroundImage = Properties.Resources.RE;
                            w.BackColor = Colors.L4;
                            break;
                        case 'e':
                            leftHand.BackgroundImage = Properties.Resources.L3;
                            rightHand.BackgroundImage = Properties.Resources.RE;
                            e.BackColor = Colors.L3;
                            break;
                        case 'r':
                            leftHand.BackgroundImage = Properties.Resources.L2;
                            rightHand.BackgroundImage = Properties.Resources.RE;
                            r.BackColor = Colors.L2;
                            break;
                        case 't':
                            leftHand.BackgroundImage = Properties.Resources.L2;
                            rightHand.BackgroundImage = Properties.Resources.RE;
                            t.BackColor = Colors.L2;
                            break;
                        case 'y':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R2;
                            y.BackColor = Colors.R2;
                            break;
                        case 'u':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R2;
                            u.BackColor = Colors.R2;
                            break;
                        case 'i':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R3;
                            i.BackColor = Colors.R3;
                            break;
                        case 'o':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R4;
                            o.BackColor = Colors.R4;
                            break;
                        case 'p':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            p.BackColor = Colors.R5;
                            break;
                        case '[':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            bracketL.BackColor = Colors.R5;
                            break;
                        case ']':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            bracketR.BackColor = Colors.R5;
                            break;
                        case '\\':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            slashes.BackColor = Colors.R5;
                            break;
                        case 'Q':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            q.BackColor = Colors.L5;
                            shiftRight.BackColor = Colors.R5;
                            break;
                        case 'W':
                            leftHand.BackgroundImage = Properties.Resources.L4;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            w.BackColor = Colors.L4;
                            shiftRight.BackColor = Colors.R5;
                            break;
                        case 'E':
                            leftHand.BackgroundImage = Properties.Resources.L3;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            e.BackColor = Colors.L3;
                            shiftRight.BackColor = Colors.R5;
                            break;
                        case 'R':
                            leftHand.BackgroundImage = Properties.Resources.L2;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            r.BackColor = Colors.L2;
                            shiftRight.BackColor = Colors.R5;
                            break;
                        case 'T':
                            leftHand.BackgroundImage = Properties.Resources.L2;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            t.BackColor = Colors.L2;
                            shiftRight.BackColor = Colors.R5;
                            break;
                        case 'Y':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R2;
                            y.BackColor = Colors.R2;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        case 'U':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R2;
                            u.BackColor = Colors.R2;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        case 'I':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R3;
                            i.BackColor = Colors.R3;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        case 'O':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R4;
                            o.BackColor = Colors.R4;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        case 'P':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            p.BackColor = Colors.R5;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        case '{':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            bracketL.BackColor = Colors.R5;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        case '}':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            bracketR.BackColor = Colors.R5;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        case '|':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            slashes.BackColor = Colors.R5;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        case 'a':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.RE;
                            a.BackColor = Colors.L5;
                            break;
                        case 's':
                            leftHand.BackgroundImage = Properties.Resources.L4;
                            rightHand.BackgroundImage = Properties.Resources.RE;
                            s.BackColor = Colors.L4;
                            break;
                        case 'd':
                            leftHand.BackgroundImage = Properties.Resources.L3;
                            rightHand.BackgroundImage = Properties.Resources.RE;
                            d.BackColor = Colors.L3;
                            break;
                        case 'f':
                            leftHand.BackgroundImage = Properties.Resources.L2;
                            rightHand.BackgroundImage = Properties.Resources.RE;
                            f.BackColor = Colors.L2;
                            break;
                        case 'g':
                            leftHand.BackgroundImage = Properties.Resources.L2;
                            rightHand.BackgroundImage = Properties.Resources.RE;
                            g.BackColor = Colors.L2;
                            break;
                        case 'h':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R2;
                            h.BackColor = Colors.R2;
                            break;
                        case 'j':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R2;
                            j.BackColor = Colors.R2;
                            break;
                        case 'k':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R3;
                            k.BackColor = Colors.R3;
                            break;
                        case 'l':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R4;
                            l.BackColor = Colors.R4;
                            break;
                        case ';':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            colon.BackColor = Colors.R5;
                            break;
                        case '\'':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            mark.BackColor = Colors.R5;
                            break;
                        case 'A':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            a.BackColor = Colors.L5;
                            shiftRight.BackColor = Colors.R5;
                            break;
                        case 'S':
                            leftHand.BackgroundImage = Properties.Resources.L4;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            s.BackColor = Colors.L4;
                            shiftRight.BackColor = Colors.R5;
                            break;
                        case 'D':
                            leftHand.BackgroundImage = Properties.Resources.L3;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            d.BackColor = Colors.L3;
                            shiftRight.BackColor = Colors.R5;
                            break;
                        case 'F':
                            leftHand.BackgroundImage = Properties.Resources.L2;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            f.BackColor = Colors.L2;
                            shiftRight.BackColor = Colors.R5;
                            break;
                        case 'G':
                            leftHand.BackgroundImage = Properties.Resources.L2;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            g.BackColor = Colors.L2;
                            shiftRight.BackColor = Colors.R5;
                            break;
                        case 'H':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R2;
                            h.BackColor = Colors.R2;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        case 'J':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R2;
                            j.BackColor = Colors.R2;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        case 'K':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R3;
                            k.BackColor = Colors.R3;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        case 'L':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R4;
                            l.BackColor = Colors.R4;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        case ':':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            colon.BackColor = Colors.R5;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        case '"':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            mark.BackColor = Colors.R5;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        case 'z':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.RE;
                            z.BackColor = Colors.L5;
                            break;
                        case 'x':
                            leftHand.BackgroundImage = Properties.Resources.L4;
                            rightHand.BackgroundImage = Properties.Resources.RE;
                            x.BackColor = Colors.L4;
                            break;
                        case 'c':
                            leftHand.BackgroundImage = Properties.Resources.L3;
                            rightHand.BackgroundImage = Properties.Resources.RE;
                            c.BackColor = Colors.L3;
                            break;
                        case 'v':
                            leftHand.BackgroundImage = Properties.Resources.L2;
                            rightHand.BackgroundImage = Properties.Resources.RE;
                            v.BackColor = Colors.L2;
                            break;
                        case 'b':
                            leftHand.BackgroundImage = Properties.Resources.L2;
                            rightHand.BackgroundImage = Properties.Resources.RE;
                            b.BackColor = Colors.L2;
                            break;
                        case 'n':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R2;
                            n.BackColor = Colors.R2;
                            break;
                        case 'm':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R2;
                            m.BackColor = Colors.R2;
                            break;
                        case ',':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R3;
                            lessMark.BackColor = Colors.R3;
                            break;
                        case '.':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R4;
                            moreMark.BackColor = Colors.R4;
                            break;
                        case '/':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            questionMark.BackColor = Colors.R5;
                            break;
                        case 'Z':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            z.BackColor = Colors.L5;
                            shiftRight.BackColor = Colors.R5;
                            break;
                        case 'X':
                            leftHand.BackgroundImage = Properties.Resources.L4;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            x.BackColor = Colors.L4;
                            shiftRight.BackColor = Colors.R5;
                            break;
                        case 'C':
                            leftHand.BackgroundImage = Properties.Resources.L3;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            c.BackColor = Colors.L3;
                            shiftRight.BackColor = Colors.R5;
                            break;
                        case 'V':
                            leftHand.BackgroundImage = Properties.Resources.L2;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            v.BackColor = Colors.L2;
                            shiftRight.BackColor = Colors.R5;
                            break;
                        case 'B':
                            leftHand.BackgroundImage = Properties.Resources.L2;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            b.BackColor = Colors.L2;
                            shiftRight.BackColor = Colors.R5;
                            break;
                        case 'N':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R2;
                            n.BackColor = Colors.R2;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        case 'M':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R2;
                            m.BackColor = Colors.R2;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        case '<':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R3;
                            lessMark.BackColor = Colors.R3;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        case '>':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R4;
                            moreMark.BackColor = Colors.R4;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        case '?':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            questionMark.BackColor = Colors.R5;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        default:
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.RE;
                            break;
                    }
                }
                else if(inputLanguage.Culture.TwoLetterISOLanguageName == "ru")
                {
                    switch (strOutTextBox.Text[currentSymbol + 1])
                    {
                        case ' ':
                            leftHand.BackgroundImage = Properties.Resources.L1;
                            rightHand.BackgroundImage = Properties.Resources.R1;
                            space.BackColor = Colors.LR1;
                            break;
                        case 'ё':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.RE;
                            tilda.BackColor = Colors.L5;
                            break;
                        case '1':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.RE;
                            one.BackColor = Colors.L5;
                            break;
                        case '2':
                            leftHand.BackgroundImage = Properties.Resources.L4;
                            rightHand.BackgroundImage = Properties.Resources.RE;
                            two.BackColor = Colors.L4;
                            break;
                        case '3':
                            leftHand.BackgroundImage = Properties.Resources.L3;
                            rightHand.BackgroundImage = Properties.Resources.RE;
                            three.BackColor = Colors.L3;
                            break;
                        case '4':
                            leftHand.BackgroundImage = Properties.Resources.L2;
                            rightHand.BackgroundImage = Properties.Resources.RE;
                            four.BackColor = Colors.L2;
                            break;
                        case '5':
                            leftHand.BackgroundImage = Properties.Resources.L2;
                            rightHand.BackgroundImage = Properties.Resources.RE;
                            five.BackColor = Colors.L2;
                            break;
                        case '6':
                            leftHand.BackgroundImage = Properties.Resources.L2;
                            rightHand.BackgroundImage = Properties.Resources.RE;
                            six.BackColor = Colors.L2;
                            break;
                        case '7':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R2;
                            seven.BackColor = Colors.R2;
                            break;
                        case '8':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R3;
                            eight.BackColor = Colors.R3;
                            break;
                        case '9':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R4;
                            nine.BackColor = Colors.R4;
                            break;
                        case '0':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            zero.BackColor = Colors.R5;
                            break;
                        case '-':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            minus.BackColor = Colors.R5;
                            break;
                        case '=':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            plus.BackColor = Colors.R5;
                            break;
                        case 'Ё':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            tilda.BackColor = Colors.L5;
                            shiftRight.BackColor = Colors.R5;
                            break;
                        case '!':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            one.BackColor = Colors.L5;
                            shiftRight.BackColor = Colors.R5;
                            break;
                        case '"':
                            leftHand.BackgroundImage = Properties.Resources.L4;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            two.BackColor = Colors.L4;
                            shiftRight.BackColor = Colors.R5;
                            break;
                        case '№':
                            leftHand.BackgroundImage = Properties.Resources.L3;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            three.BackColor = Colors.L3;
                            shiftRight.BackColor = Colors.R5;
                            break;
                        case ';':
                            leftHand.BackgroundImage = Properties.Resources.L2;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            four.BackColor = Colors.L2;
                            shiftRight.BackColor = Colors.R5;
                            break;
                        case '%':
                            leftHand.BackgroundImage = Properties.Resources.L2;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            five.BackColor = Colors.L2;
                            shiftRight.BackColor = Colors.R5;
                            break;
                        case ':':
                            leftHand.BackgroundImage = Properties.Resources.L2;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            six.BackColor = Colors.L2;
                            shiftRight.BackColor = Colors.R5;
                            break;
                        case '?':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R2;
                            seven.BackColor = Colors.R2;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        case '*':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R3;
                            eight.BackColor = Colors.R3;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        case '(':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R4;
                            nine.BackColor = Colors.R4;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        case ')':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            zero.BackColor = Colors.R5;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        case '_':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            minus.BackColor = Colors.R5;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        case '+':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            plus.BackColor = Colors.R5;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        case 'й':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.RE;
                            q.BackColor = Colors.L5;
                            break;
                        case 'ц':
                            leftHand.BackgroundImage = Properties.Resources.L4;
                            rightHand.BackgroundImage = Properties.Resources.RE;
                            w.BackColor = Colors.L4;
                            break;
                        case 'у':
                            leftHand.BackgroundImage = Properties.Resources.L3;
                            rightHand.BackgroundImage = Properties.Resources.RE;
                            e.BackColor = Colors.L3;
                            break;
                        case 'к':
                            leftHand.BackgroundImage = Properties.Resources.L2;
                            rightHand.BackgroundImage = Properties.Resources.RE;
                            r.BackColor = Colors.L2;
                            break;
                        case 'е':
                            leftHand.BackgroundImage = Properties.Resources.L2;
                            rightHand.BackgroundImage = Properties.Resources.RE;
                            t.BackColor = Colors.L2;
                            break;
                        case 'н':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R2;
                            y.BackColor = Colors.R2;
                            break;
                        case 'г':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R2;
                            u.BackColor = Colors.R2;
                            break;
                        case 'ш':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R3;
                            i.BackColor = Colors.R3;
                            break;
                        case 'щ':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R4;
                            o.BackColor = Colors.R4;
                            break;
                        case 'з':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            p.BackColor = Colors.R5;
                            break;
                        case 'х':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            bracketL.BackColor = Colors.R5;
                            break;
                        case 'ъ':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            bracketR.BackColor = Colors.R5;
                            break;
                        case '\\':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            slashes.BackColor = Colors.R5;
                            break;
                        case 'Й':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            q.BackColor = Colors.L5;
                            shiftRight.BackColor = Colors.R5;
                            break;
                        case 'Ц':
                            leftHand.BackgroundImage = Properties.Resources.L4;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            w.BackColor = Colors.L4;
                            shiftRight.BackColor = Colors.R5;
                            break;
                        case 'У':
                            leftHand.BackgroundImage = Properties.Resources.L3;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            e.BackColor = Colors.L3;
                            shiftRight.BackColor = Colors.R5;
                            break;
                        case 'К':
                            leftHand.BackgroundImage = Properties.Resources.L2;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            r.BackColor = Colors.L2;
                            shiftRight.BackColor = Colors.R5;
                            break;
                        case 'Е':
                            leftHand.BackgroundImage = Properties.Resources.L2;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            t.BackColor = Colors.L2;
                            shiftRight.BackColor = Colors.R5;
                            break;
                        case 'Н':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R2;
                            y.BackColor = Colors.R2;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        case 'Г':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R2;
                            u.BackColor = Colors.R2;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        case 'Ш':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R3;
                            i.BackColor = Colors.R3;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        case 'Щ':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R4;
                            o.BackColor = Colors.R4;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        case 'З':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            p.BackColor = Colors.R5;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        case 'Х':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            bracketL.BackColor = Colors.R5;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        case 'Ъ':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            bracketR.BackColor = Colors.R5;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        case '/':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            slashes.BackColor = Colors.R5;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        case 'ф':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.RE;
                            a.BackColor = Colors.L5;
                            break;
                        case 'ы':
                            leftHand.BackgroundImage = Properties.Resources.L4;
                            rightHand.BackgroundImage = Properties.Resources.RE;
                            s.BackColor = Colors.L4;
                            break;
                        case 'в':
                            leftHand.BackgroundImage = Properties.Resources.L3;
                            rightHand.BackgroundImage = Properties.Resources.RE;
                            d.BackColor = Colors.L3;
                            break;
                        case 'а':
                            leftHand.BackgroundImage = Properties.Resources.L2;
                            rightHand.BackgroundImage = Properties.Resources.RE;
                            f.BackColor = Colors.L2;
                            break;
                        case 'п':
                            leftHand.BackgroundImage = Properties.Resources.L2;
                            rightHand.BackgroundImage = Properties.Resources.RE;
                            g.BackColor = Colors.L2;
                            break;
                        case 'р':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R2;
                            h.BackColor = Colors.R2;
                            break;
                        case 'о':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R2;
                            j.BackColor = Colors.R2;
                            break;
                        case 'л':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R3;
                            k.BackColor = Colors.R3;
                            break;
                        case 'д':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R4;
                            l.BackColor = Colors.R4;
                            break;
                        case 'ж':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            colon.BackColor = Colors.R5;
                            break;
                        case 'э':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            mark.BackColor = Colors.R5;
                            break;
                        case 'Ф':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            a.BackColor = Colors.L5;
                            shiftRight.BackColor = Colors.R5;
                            break;
                        case 'Ы':
                            leftHand.BackgroundImage = Properties.Resources.L4;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            s.BackColor = Colors.L4;
                            shiftRight.BackColor = Colors.R5;
                            break;
                        case 'В':
                            leftHand.BackgroundImage = Properties.Resources.L3;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            d.BackColor = Colors.L3;
                            shiftRight.BackColor = Colors.R5;
                            break;
                        case 'А':
                            leftHand.BackgroundImage = Properties.Resources.L2;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            f.BackColor = Colors.L2;
                            shiftRight.BackColor = Colors.R5;
                            break;
                        case 'П':
                            leftHand.BackgroundImage = Properties.Resources.L2;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            g.BackColor = Colors.L2;
                            shiftRight.BackColor = Colors.R5;
                            break;
                        case 'Р':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R2;
                            h.BackColor = Colors.R2;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        case 'О':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R2;
                            j.BackColor = Colors.R2;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        case 'Л':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R3;
                            k.BackColor = Colors.R3;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        case 'Д':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R4;
                            l.BackColor = Colors.R4;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        case 'Ж':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            colon.BackColor = Colors.R5;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        case 'Э':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            mark.BackColor = Colors.R5;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        case 'я':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.RE;
                            z.BackColor = Colors.L5;
                            break;
                        case 'ч':
                            leftHand.BackgroundImage = Properties.Resources.L4;
                            rightHand.BackgroundImage = Properties.Resources.RE;
                            x.BackColor = Colors.L4;
                            break;
                        case 'с':
                            leftHand.BackgroundImage = Properties.Resources.L3;
                            rightHand.BackgroundImage = Properties.Resources.RE;
                            c.BackColor = Colors.L3;
                            break;
                        case 'м':
                            leftHand.BackgroundImage = Properties.Resources.L2;
                            rightHand.BackgroundImage = Properties.Resources.RE;
                            v.BackColor = Colors.L2;
                            break;
                        case 'и':
                            leftHand.BackgroundImage = Properties.Resources.L2;
                            rightHand.BackgroundImage = Properties.Resources.RE;
                            b.BackColor = Colors.L2;
                            break;
                        case 'т':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R2;
                            n.BackColor = Colors.R2;
                            break;
                        case 'ь':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R2;
                            m.BackColor = Colors.R2;
                            break;
                        case 'б':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R3;
                            lessMark.BackColor = Colors.R3;
                            break;
                        case 'ю':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R4;
                            moreMark.BackColor = Colors.R4;
                            break;
                        case '.':
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            questionMark.BackColor = Colors.R5;
                            break;
                        case 'Я':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            z.BackColor = Colors.L5;
                            shiftRight.BackColor = Colors.R5;
                            break;
                        case 'Ч':
                            leftHand.BackgroundImage = Properties.Resources.L4;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            x.BackColor = Colors.L4;
                            shiftRight.BackColor = Colors.R5;
                            break;
                        case 'С':
                            leftHand.BackgroundImage = Properties.Resources.L3;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            c.BackColor = Colors.L3;
                            shiftRight.BackColor = Colors.R5;
                            break;
                        case 'М':
                            leftHand.BackgroundImage = Properties.Resources.L2;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            v.BackColor = Colors.L2;
                            shiftRight.BackColor = Colors.R5;
                            break;
                        case 'И':
                            leftHand.BackgroundImage = Properties.Resources.L2;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            b.BackColor = Colors.L2;
                            shiftRight.BackColor = Colors.R5;
                            break;
                        case 'Т':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R2;
                            n.BackColor = Colors.R2;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        case 'Ь':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R2;
                            m.BackColor = Colors.R2;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        case 'Б':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R3;
                            lessMark.BackColor = Colors.R3;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        case 'Ю':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R4;
                            moreMark.BackColor = Colors.R4;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        case ',':
                            leftHand.BackgroundImage = Properties.Resources.L5;
                            rightHand.BackgroundImage = Properties.Resources.R5;
                            questionMark.BackColor = Colors.R5;
                            shiftLeft.BackColor = Colors.L5;
                            break;
                        default:
                            leftHand.BackgroundImage = Properties.Resources.LE;
                            rightHand.BackgroundImage = Properties.Resources.RE;
                            break;
                    }
                }
                
            }
            
        }

        private void SetAllMarkToDefault()
        {
            leftHand.BackgroundImage = Properties.Resources.LE;
            rightHand.BackgroundImage = Properties.Resources.RE;
            tilda.BackColor = Colors.ButtonStandard;
            one.BackColor = Colors.ButtonStandard;
            two.BackColor = Colors.ButtonStandard;
            three.BackColor = Colors.ButtonStandard;
            four.BackColor = Colors.ButtonStandard;
            five.BackColor = Colors.ButtonStandard;
            six.BackColor = Colors.ButtonStandard;
            seven.BackColor = Colors.ButtonStandard;
            eight.BackColor = Colors.ButtonStandard;
            nine.BackColor = Colors.ButtonStandard;
            zero.BackColor = Colors.ButtonStandard;
            minus.BackColor = Colors.ButtonStandard;
            plus.BackColor = Colors.ButtonStandard;
            backspace.BackColor = Colors.ButtonStandard;
            tab.BackColor = Colors.ButtonStandard;
            q.BackColor = Colors.ButtonStandard;
            w.BackColor = Colors.ButtonStandard;
            e.BackColor = Colors.ButtonStandard;
            r.BackColor = Colors.ButtonStandard;
            t.BackColor = Colors.ButtonStandard;
            y.BackColor = Colors.ButtonStandard;
            u.BackColor = Colors.ButtonStandard;
            i.BackColor = Colors.ButtonStandard;
            o.BackColor = Colors.ButtonStandard;
            p.BackColor = Colors.ButtonStandard;
            bracketL.BackColor = Colors.ButtonStandard;
            bracketR.BackColor = Colors.ButtonStandard;
            slashes.BackColor = Colors.ButtonStandard;
            capsLk.BackColor = Colors.ButtonStandard;
            a.BackColor = Colors.ButtonStandard;
            s.BackColor = Colors.ButtonStandard;
            d.BackColor = Colors.ButtonStandard;
            f.BackColor = Colors.ButtonStandard;
            g.BackColor = Colors.ButtonStandard;
            h.BackColor = Colors.ButtonStandard;
            j.BackColor = Colors.ButtonStandard;
            k.BackColor = Colors.ButtonStandard;
            l.BackColor = Colors.ButtonStandard;
            colon.BackColor = Colors.ButtonStandard;
            mark.BackColor = Colors.ButtonStandard;
            enter.BackColor = Colors.ButtonStandard;
            shiftLeft.BackColor = Colors.ButtonStandard;
            z.BackColor = Colors.ButtonStandard;
            x.BackColor = Colors.ButtonStandard;
            c.BackColor = Colors.ButtonStandard;
            v.BackColor = Colors.ButtonStandard;
            b.BackColor = Colors.ButtonStandard;
            n.BackColor = Colors.ButtonStandard;
            m.BackColor = Colors.ButtonStandard;
            lessMark.BackColor = Colors.ButtonStandard;
            moreMark.BackColor = Colors.ButtonStandard;
            questionMark.BackColor = Colors.ButtonStandard;
            shiftRight.BackColor = Colors.ButtonStandard;
            ctrlLeft.BackColor = Colors.ButtonStandard;
            altLeft.BackColor = Colors.ButtonStandard;
            space.BackColor = Colors.ButtonStandard;
            altRight.BackColor = Colors.ButtonStandard;
            ctrlRight.BackColor = Colors.ButtonStandard;
        }

        private void strInTextbox_TextChanged(object sender, EventArgs e)
        {
            ChangeComparisonString();
            currentSymbol = strInTextbox.Text.Length - 1;
            CheckCurrentEnterMatching();
            CheckMistake();
        }

        private void MainForm_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
        {
            MarkFingerAndKey();
        }

        private void HideTopElements()
        {
            keyboard.Visible = false;
            randomCB.Visible = false;
            mode.Visible = false;
            again.Visible = false;
            labelSym.Visible = false;
            labelTypo.Visible = false;
            leftHand.Visible = false;
            rightHand.Visible = false;
            strOutTextBox.Visible = false;
            strInTextbox.Visible = false;
        }

        private void ShowTopElements()
        {
            keyboard.Visible = true;
            mode.Visible = true;
            randomCB.Visible = true;
            again.Visible = true;
            labelSym.Visible = true;
            labelTypo.Visible = true;
            strOutTextBox.Visible = true;
            strInTextbox.Visible = true;

            if (!KeyBoardHidden)
            {
                leftHand.Visible = true;
                rightHand.Visible = true;
            }
        }

        private void mode_Click(object sender, EventArgs e)
        {
            HideTopElements();
            for (int i = 0; i < 20; i++)
            {
                modePanel.Top += 5;
                System.Threading.Thread.Sleep(6);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (currentMode != Mode.NONE)
            {
                strInTextbox.Enabled = true;
            }
            
            for (int i = 0; i < 20; i++)
            {
                modePanel.Top -= 5;
                System.Threading.Thread.Sleep(6);
            }
            modePanel.Top = -100;
            ShowTopElements();
        }

        private void modeSharp_Click(object sender, EventArgs e)
        {
            back_Click(sender, e);

            if (LoadForeignText())
            {
                currentMode = Mode.SHARP;
                strInTextbox.Enabled = true;

                textArray.Clear();

                for (int i = 0; i < TextData.csArray.Count; i++)
                {
                    textArray.Add(TextData.csArray[i]);
                }

                ModeChanged(sender, e);
            }
        }

        private bool LoadForeignText()
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Text files (*.txt)|*.txt",
                InitialDirectory = Directory.GetCurrentDirectory()
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                string foreignText = File.ReadAllText(filePath);
                TextData.GetForeignTextData(foreignText);
                return true;
            }
            else
            {
                return false;
            }
            
        }

        private void modeRu_Click(object sender, EventArgs e)
        {
            currentMode = Mode.RU;
            back_Click(sender, e);
            textArray.Clear();

            for (int i = 0; i < TextData.ruArray.Count; i++)
            {
                textArray.Add(TextData.ruArray[i]);
            }

            ModeChanged(sender, e);
        }

        private void again_Click(object sender, EventArgs e)
        {
            switch (currentMode)
            {
                case Mode.EN:
                case Mode.RU:
                case Mode.SHARP:
                    currentModeAgain(sender, e);
                    symbolEntered = 0;
                    break;
            }
        }

        private void modeEn_Click(object sender, EventArgs e)
        {
            currentMode = Mode.EN;
            back_Click(sender, e);

            textArray.Clear();
            
            for (int i = 0; i < TextData.enArray.Count; i++)
            {
                textArray.Add(TextData.enArray[i]);
            }

            ModeChanged(sender, e);
        }

        private void ModeChanged(object sender, EventArgs e)
        {
            mistakes = 0;
            symbolEntered = 0;
            seconds = 0;

            strInTextbox.Text = "";
            labelTypo.Text = "Ошибки: ";
            labelSym.Text = "Символов в минуту: ";

            if (randomCB.Checked)
            {
                currentString = rand.Next(0, textArray.Count);
            }
            else
            {
                currentString = 0;
            }

            currentSymbol = -1;

            SetOutText();
            MarkFingerAndKey();
            strInTextbox.Focus();
        }

        private void currentModeAgain(object sender, EventArgs e)
        {
            back_Click(sender, e);

            ModeChanged(sender, e);
        }

        private void keyboard_Click(object sender, EventArgs ev)
        {
            if (!KeyBoardHidden)
            {
                KeyBoardHidden = !KeyBoardHidden;
                leftHand.Visible = false;
                rightHand.Visible = false;
                tilda.Visible = false;
                one.Visible = false;
                two.Visible = false;
                three.Visible = false;
                four.Visible = false;
                five.Visible = false;
                six.Visible = false;
                seven.Visible = false;
                eight.Visible = false;
                nine.Visible = false;
                zero.Visible = false;
                minus.Visible = false;
                plus.Visible = false;
                backspace.Visible = false;
                tab.Visible = false;
                q.Visible = false;
                w.Visible = false;
                e.Visible = false;
                r.Visible = false;
                t.Visible = false;
                y.Visible = false;
                u.Visible = false;
                i.Visible = false;
                o.Visible = false;
                p.Visible = false;
                bracketL.Visible = false;
                bracketR.Visible = false;
                slashes.Visible = false;
                capsLk.Visible = false;
                a.Visible = false;
                s.Visible = false;
                d.Visible = false;
                f.Visible = false;
                g.Visible = false;
                h.Visible = false;
                j.Visible = false;
                k.Visible = false;
                l.Visible = false;
                colon.Visible = false;
                mark.Visible = false;
                enter.Visible = false;
                shiftLeft.Visible = false;
                z.Visible = false;
                x.Visible = false;
                c.Visible = false;
                v.Visible = false;
                b.Visible = false;
                n.Visible = false;
                m.Visible = false;
                lessMark.Visible = false;
                moreMark.Visible = false;
                questionMark.Visible = false;
                shiftRight.Visible = false;
                ctrlLeft.Visible = false;
                altLeft.Visible = false;
                space.Visible = false;
                altRight.Visible = false;
                ctrlRight.Visible = false;
            }
            else
            {
                KeyBoardHidden = !KeyBoardHidden;
                leftHand.Visible = true;
                rightHand.Visible = true;
                tilda.Visible = true;
                one.Visible = true;
                two.Visible = true;
                three.Visible = true;
                four.Visible = true;
                five.Visible = true;
                six.Visible = true;
                seven.Visible = true;
                eight.Visible = true;
                nine.Visible = true;
                zero.Visible = true;
                minus.Visible = true;
                plus.Visible = true;
                backspace.Visible = true;
                tab.Visible = true;
                q.Visible = true;
                w.Visible = true;
                e.Visible = true;
                r.Visible = true;
                t.Visible = true;
                y.Visible = true;
                u.Visible = true;
                i.Visible = true;
                o.Visible = true;
                p.Visible = true;
                bracketL.Visible = true;
                bracketR.Visible = true;
                slashes.Visible = true;
                capsLk.Visible = true;
                a.Visible = true;
                s.Visible = true;
                d.Visible = true;
                f.Visible = true;
                g.Visible = true;
                h.Visible = true;
                j.Visible = true;
                k.Visible = true;
                l.Visible = true;
                colon.Visible = true;
                mark.Visible = true;
                enter.Visible = true;
                shiftLeft.Visible = true;
                z.Visible = true;
                x.Visible = true;
                c.Visible = true;
                v.Visible = true;
                b.Visible = true;
                n.Visible = true;
                m.Visible = true;
                lessMark.Visible = true;
                moreMark.Visible = true;
                questionMark.Visible = true;
                shiftRight.Visible = true;
                ctrlLeft.Visible = true;
                altLeft.Visible = true;
                space.Visible = true;
                altRight.Visible = true;
                ctrlRight.Visible = true;
            }
        }
    }
}
