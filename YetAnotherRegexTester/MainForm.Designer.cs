namespace YetAnotherRegexTester
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Bell \\a");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Backspace \\b");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Tab \\t");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Carriage return \\r");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Vertical return \\v");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Form feed \\f");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("New line \\n");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Escape \\e");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("ASCII character as Octal \\040");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("ASCII character as Hex \\x20");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Control character \\cC");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Unicode character \\u0020");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Dollar sign $$");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Character Escapes", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Value of matched group by group number $number");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Value of matched group by group name $name");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Entire match $&");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("All text before match $`");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("All text after match $\'");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Last group captured $+");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Entire input string $_");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Substitutions", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21});
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Any character .");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Any character in the set [aeiou]");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Any character not in the set [^aeiou]");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Character range [0-9a-fA-F]");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Unicode group \\p{name}");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Not in Unicode group \\P{name}");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Any word character \\w");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Nonword character \\W");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("White-space character \\s");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Non-white-space character \\S");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Digit \\d");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Non-digit \\D");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Character Classes", new System.Windows.Forms.TreeNode[] {
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode26,
            treeNode27,
            treeNode28,
            treeNode29,
            treeNode30,
            treeNode31,
            treeNode32,
            treeNode33,
            treeNode34});
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Match start of string ^");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Match end of string $");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Match start of string (ignore Multiline) \\A");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Match before end of string (ignore Multiline) \\Z");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Match end of string (ignore Multiline) \\z");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Match where previous match ended \\G");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Boundary \\b");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Non-boundary \\B");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Atomic Zero-Width Assertions", new System.Windows.Forms.TreeNode[] {
            treeNode36,
            treeNode37,
            treeNode38,
            treeNode39,
            treeNode40,
            treeNode41,
            treeNode42,
            treeNode43});
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Zero or more matches *");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("One or more matches +");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("Zero or one match ?");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("Exactly n matches {n}");
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("At least n matches {n,}");
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("At least n and no more than m matches {n,m}");
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("First match with few repeats as possible *?");
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("As few repeats but at least one +?");
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("Zero repeats if possible ??");
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("Lazy {n} {n}?");
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("Lazy {n,} {n,}?");
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("Lazy {n,m} {n,m}?");
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("Quantifiers", new System.Windows.Forms.TreeNode[] {
            treeNode45,
            treeNode46,
            treeNode47,
            treeNode48,
            treeNode49,
            treeNode50,
            treeNode51,
            treeNode52,
            treeNode53,
            treeNode54,
            treeNode55,
            treeNode56});
            System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("Group ()");
            System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode("Named group (?<name>)");
            System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("Balancing group (?<name1-name2>)");
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("Noncapturing group (?:)");
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("Positive lookahead (?=)");
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("Negative lookahead (?!)");
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("Positive lookbehind (?<=)");
            System.Windows.Forms.TreeNode treeNode65 = new System.Windows.Forms.TreeNode("Negative lookbehind (?<!)");
            System.Windows.Forms.TreeNode treeNode66 = new System.Windows.Forms.TreeNode("Nonbacktracking subexpression (?>)");
            System.Windows.Forms.TreeNode treeNode67 = new System.Windows.Forms.TreeNode("Group constructs", new System.Windows.Forms.TreeNode[] {
            treeNode58,
            treeNode59,
            treeNode60,
            treeNode61,
            treeNode62,
            treeNode63,
            treeNode64,
            treeNode65,
            treeNode66});
            System.Windows.Forms.TreeNode treeNode68 = new System.Windows.Forms.TreeNode("Backreference \\n");
            System.Windows.Forms.TreeNode treeNode69 = new System.Windows.Forms.TreeNode("Named backreference \\k<name>");
            System.Windows.Forms.TreeNode treeNode70 = new System.Windows.Forms.TreeNode("Backreference Constructs", new System.Windows.Forms.TreeNode[] {
            treeNode68,
            treeNode69});
            System.Windows.Forms.TreeNode treeNode71 = new System.Windows.Forms.TreeNode("Or |");
            System.Windows.Forms.TreeNode treeNode72 = new System.Windows.Forms.TreeNode("Conditional (?(expression)yes|no)");
            System.Windows.Forms.TreeNode treeNode73 = new System.Windows.Forms.TreeNode("Capture test (?(name)yes|no)");
            System.Windows.Forms.TreeNode treeNode74 = new System.Windows.Forms.TreeNode("Alternation Constructs", new System.Windows.Forms.TreeNode[] {
            treeNode71,
            treeNode72,
            treeNode73});
            System.Windows.Forms.TreeNode treeNode75 = new System.Windows.Forms.TreeNode("Comment (?#yourcomment)");
            System.Windows.Forms.TreeNode treeNode76 = new System.Windows.Forms.TreeNode("Single line Comment #");
            System.Windows.Forms.TreeNode treeNode77 = new System.Windows.Forms.TreeNode("Miscellaneous Constructs", new System.Windows.Forms.TreeNode[] {
            treeNode75,
            treeNode76});
            System.Windows.Forms.TreeNode treeNode78 = new System.Windows.Forms.TreeNode("IgnoreCase on (?i:)");
            System.Windows.Forms.TreeNode treeNode79 = new System.Windows.Forms.TreeNode("IgnoreCase off (?-i:)");
            System.Windows.Forms.TreeNode treeNode80 = new System.Windows.Forms.TreeNode("Multiline on (?m:)");
            System.Windows.Forms.TreeNode treeNode81 = new System.Windows.Forms.TreeNode("Multiline off (?-m:)");
            System.Windows.Forms.TreeNode treeNode82 = new System.Windows.Forms.TreeNode("ExplicitCapture on (?n:)");
            System.Windows.Forms.TreeNode treeNode83 = new System.Windows.Forms.TreeNode("ExplicitCapture off (?-n:)");
            System.Windows.Forms.TreeNode treeNode84 = new System.Windows.Forms.TreeNode("SingleLine on (?s:)");
            System.Windows.Forms.TreeNode treeNode85 = new System.Windows.Forms.TreeNode("SingleLine off (?-s:)");
            System.Windows.Forms.TreeNode treeNode86 = new System.Windows.Forms.TreeNode("IgnorePatternWhitespace on (?x:)");
            System.Windows.Forms.TreeNode treeNode87 = new System.Windows.Forms.TreeNode("IgnorePatternWhitespace off (?-x:)");
            System.Windows.Forms.TreeNode treeNode88 = new System.Windows.Forms.TreeNode("Options", new System.Windows.Forms.TreeNode[] {
            treeNode78,
            treeNode79,
            treeNode80,
            treeNode81,
            treeNode82,
            treeNode83,
            treeNode84,
            treeNode85,
            treeNode86,
            treeNode87});
            System.Windows.Forms.TreeNode treeNode89 = new System.Windows.Forms.TreeNode("Email");
            System.Windows.Forms.TreeNode treeNode90 = new System.Windows.Forms.TreeNode("Guid");
            System.Windows.Forms.TreeNode treeNode91 = new System.Windows.Forms.TreeNode("Examples", new System.Windows.Forms.TreeNode[] {
            treeNode89,
            treeNode90});
            PresentationControls.CheckBoxProperties checkBoxProperties1 = new PresentationControls.CheckBoxProperties();
            this.regexTextBox = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.inputDataTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.matchesTreeView = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.matchButton = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.regexOptionsComboBox = new PresentationControls.CheckBoxComboBox();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // regexTextBox
            // 
            this.regexTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regexTextBox.Location = new System.Drawing.Point(3, 13);
            this.regexTextBox.Multiline = true;
            this.regexTextBox.Name = "regexTextBox";
            this.regexTextBox.Size = new System.Drawing.Size(575, 85);
            this.regexTextBox.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Size = new System.Drawing.Size(914, 351);
            this.splitContainer1.SplitterDistance = 581;
            this.splitContainer1.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer2.Size = new System.Drawing.Size(581, 351);
            this.splitContainer2.SplitterDistance = 130;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.regexOptionsComboBox);
            this.groupBox1.Controls.Add(this.matchButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.regexTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Regex";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.inputDataTextBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(581, 217);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input data";
            // 
            // inputDataTextBox
            // 
            this.inputDataTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputDataTextBox.Location = new System.Drawing.Point(3, 16);
            this.inputDataTextBox.Multiline = true;
            this.inputDataTextBox.Name = "inputDataTextBox";
            this.inputDataTextBox.Size = new System.Drawing.Size(575, 198);
            this.inputDataTextBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.treeView1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(329, 351);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Regex builder";
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(3, 16);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Tag = "\\a";
            treeNode1.Text = "Bell \\a";
            treeNode2.Name = "Node2";
            treeNode2.Tag = "\\b";
            treeNode2.Text = "Backspace \\b";
            treeNode3.Name = "Node3";
            treeNode3.Tag = "\\t";
            treeNode3.Text = "Tab \\t";
            treeNode4.Name = "Node4";
            treeNode4.Tag = "\\r";
            treeNode4.Text = "Carriage return \\r";
            treeNode5.Name = "Node6";
            treeNode5.Tag = "\\v";
            treeNode5.Text = "Vertical return \\v";
            treeNode6.Name = "Node7";
            treeNode6.Tag = "\\f";
            treeNode6.Text = "Form feed \\f";
            treeNode7.Name = "Node8";
            treeNode7.Tag = "\\n";
            treeNode7.Text = "New line \\n";
            treeNode8.Name = "Node9";
            treeNode8.Tag = "\\e";
            treeNode8.Text = "Escape \\e";
            treeNode9.Name = "Node10";
            treeNode9.Tag = "\\040";
            treeNode9.Text = "ASCII character as Octal \\040";
            treeNode10.Name = "Node11";
            treeNode10.Tag = "\\x20";
            treeNode10.Text = "ASCII character as Hex \\x20";
            treeNode11.Name = "Node12";
            treeNode11.Tag = "\\cC";
            treeNode11.Text = "Control character \\cC";
            treeNode12.Name = "Node14";
            treeNode12.Tag = "\\u0020";
            treeNode12.Text = "Unicode character \\u0020";
            treeNode13.Name = "Node24";
            treeNode13.Tag = "$$";
            treeNode13.Text = "Dollar sign $$";
            treeNode14.Name = "Node0";
            treeNode14.Text = "Character Escapes";
            treeNode15.Name = "Node16";
            treeNode15.Tag = "$n";
            treeNode15.Text = "Value of matched group by group number $number";
            treeNode16.Name = "Node17";
            treeNode16.Tag = "$name";
            treeNode16.Text = "Value of matched group by group name $name";
            treeNode17.Name = "Node18";
            treeNode17.Tag = "$&";
            treeNode17.Text = "Entire match $&";
            treeNode18.Name = "Node19";
            treeNode18.Tag = "$`";
            treeNode18.Text = "All text before match $`";
            treeNode19.Name = "Node20";
            treeNode19.Tag = "$\'";
            treeNode19.Text = "All text after match $\'";
            treeNode20.Name = "Node21";
            treeNode20.Tag = "$+";
            treeNode20.Text = "Last group captured $+";
            treeNode21.Name = "Node22";
            treeNode21.Tag = "$_";
            treeNode21.Text = "Entire input string $_";
            treeNode22.Name = "Node15";
            treeNode22.Text = "Substitutions";
            treeNode23.Name = "Node34";
            treeNode23.Tag = ".";
            treeNode23.Text = "Any character .";
            treeNode24.Name = "Node35";
            treeNode24.Tag = "[aeiou]";
            treeNode24.Text = "Any character in the set [aeiou]";
            treeNode25.Name = "Node36";
            treeNode25.Tag = "[^aeiou]";
            treeNode25.Text = "Any character not in the set [^aeiou]";
            treeNode26.Name = "Node37";
            treeNode26.Tag = "[0-9a-fA-F]";
            treeNode26.Text = "Character range [0-9a-fA-F]";
            treeNode27.Name = "Node38";
            treeNode27.Tag = "\\p{name}";
            treeNode27.Text = "Unicode group \\p{name}";
            treeNode28.Name = "Node39";
            treeNode28.Tag = "\\P{name}";
            treeNode28.Text = "Not in Unicode group \\P{name}";
            treeNode29.Name = "Node40";
            treeNode29.Tag = "\\w";
            treeNode29.Text = "Any word character \\w";
            treeNode30.Name = "Node41";
            treeNode30.Tag = "\\W";
            treeNode30.Text = "Nonword character \\W";
            treeNode31.Name = "Node42";
            treeNode31.Tag = "\\s";
            treeNode31.Text = "White-space character \\s";
            treeNode32.Name = "Node43";
            treeNode32.Tag = "\\S";
            treeNode32.Text = "Non-white-space character \\S";
            treeNode33.Name = "Node44";
            treeNode33.Tag = "\\d";
            treeNode33.Text = "Digit \\d";
            treeNode34.Name = "Node45";
            treeNode34.Tag = "\\D";
            treeNode34.Text = "Non-digit \\D";
            treeNode35.Name = "Node25";
            treeNode35.Text = "Character Classes";
            treeNode36.Name = "Node46";
            treeNode36.Tag = "^";
            treeNode36.Text = "Match start of string ^";
            treeNode37.Name = "Node47";
            treeNode37.Tag = "$";
            treeNode37.Text = "Match end of string $";
            treeNode38.Name = "Node48";
            treeNode38.Tag = "\\A";
            treeNode38.Text = "Match start of string (ignore Multiline) \\A";
            treeNode39.Name = "Node49";
            treeNode39.Tag = "\\Z";
            treeNode39.Text = "Match before end of string (ignore Multiline) \\Z";
            treeNode40.Name = "Node50";
            treeNode40.Tag = "\\z";
            treeNode40.Text = "Match end of string (ignore Multiline) \\z";
            treeNode41.Name = "Node51";
            treeNode41.Tag = "\\G";
            treeNode41.Text = "Match where previous match ended \\G";
            treeNode42.Name = "Node52";
            treeNode42.Tag = "\\b";
            treeNode42.Text = "Boundary \\b";
            treeNode43.Name = "Node53";
            treeNode43.Tag = "\\B";
            treeNode43.Text = "Non-boundary \\B";
            treeNode44.Name = "Node26";
            treeNode44.Text = "Atomic Zero-Width Assertions";
            treeNode45.Name = "Node55";
            treeNode45.Tag = "*";
            treeNode45.Text = "Zero or more matches *";
            treeNode46.Name = "Node56";
            treeNode46.Tag = "+";
            treeNode46.Text = "One or more matches +";
            treeNode47.Name = "Node57";
            treeNode47.Tag = "?";
            treeNode47.Text = "Zero or one match ?";
            treeNode48.Name = "Node58";
            treeNode48.Tag = "{n}";
            treeNode48.Text = "Exactly n matches {n}";
            treeNode49.Name = "Node59";
            treeNode49.Tag = "{n,}";
            treeNode49.Text = "At least n matches {n,}";
            treeNode50.Name = "Node60";
            treeNode50.Tag = "{n,m}";
            treeNode50.Text = "At least n and no more than m matches {n,m}";
            treeNode51.Name = "Node61";
            treeNode51.Tag = "*?";
            treeNode51.Text = "First match with few repeats as possible *?";
            treeNode52.Name = "Node62";
            treeNode52.Tag = "+?";
            treeNode52.Text = "As few repeats but at least one +?";
            treeNode53.Name = "Node63";
            treeNode53.Tag = "??";
            treeNode53.Text = "Zero repeats if possible ??";
            treeNode54.Name = "Node64";
            treeNode54.Tag = "{n}?";
            treeNode54.Text = "Lazy {n} {n}?";
            treeNode55.Name = "Node65";
            treeNode55.Tag = "{n,}?";
            treeNode55.Text = "Lazy {n,} {n,}?";
            treeNode56.Name = "Node66";
            treeNode56.Tag = "{n,m}?";
            treeNode56.Text = "Lazy {n,m} {n,m}?";
            treeNode57.Name = "Node27";
            treeNode57.Text = "Quantifiers";
            treeNode58.Name = "Node69";
            treeNode58.Tag = "()";
            treeNode58.Text = "Group ()";
            treeNode59.Name = "Node70";
            treeNode59.Tag = "(?<name>)";
            treeNode59.Text = "Named group (?<name>)";
            treeNode60.Name = "Node71";
            treeNode60.Tag = "(?<name1-name2>)";
            treeNode60.Text = "Balancing group (?<name1-name2>)";
            treeNode61.Name = "Node72";
            treeNode61.Tag = "(?:)";
            treeNode61.Text = "Noncapturing group (?:)";
            treeNode62.Name = "Node73";
            treeNode62.Tag = "(?=)";
            treeNode62.Text = "Positive lookahead (?=)";
            treeNode63.Name = "Node74";
            treeNode63.Tag = "(?!)";
            treeNode63.Text = "Negative lookahead (?!)";
            treeNode64.Name = "Node75";
            treeNode64.Tag = "(?<=)";
            treeNode64.Text = "Positive lookbehind (?<=)";
            treeNode65.Name = "Node78";
            treeNode65.Tag = "(?<!)";
            treeNode65.Text = "Negative lookbehind (?<!)";
            treeNode66.Name = "Node79";
            treeNode66.Tag = "(?>)";
            treeNode66.Text = "Nonbacktracking subexpression (?>)";
            treeNode67.Name = "Node28";
            treeNode67.Text = "Group constructs";
            treeNode68.Name = "Node80";
            treeNode68.Tag = "\\n";
            treeNode68.Text = "Backreference \\n";
            treeNode69.Name = "Node81";
            treeNode69.Tag = "\\k<name>";
            treeNode69.Text = "Named backreference \\k<name>";
            treeNode70.Name = "Node29";
            treeNode70.Text = "Backreference Constructs";
            treeNode71.Name = "Node82";
            treeNode71.Tag = "|";
            treeNode71.Text = "Or |";
            treeNode72.Name = "Node83";
            treeNode72.Tag = "(?(expression)yes|no)";
            treeNode72.Text = "Conditional (?(expression)yes|no)";
            treeNode73.Name = "Node84";
            treeNode73.Tag = "(?(name)yes|no)";
            treeNode73.Text = "Capture test (?(name)yes|no)";
            treeNode74.Name = "Node30";
            treeNode74.Text = "Alternation Constructs";
            treeNode75.Name = "Node85";
            treeNode75.Tag = "(?#yourcomment)";
            treeNode75.Text = "Comment (?#yourcomment)";
            treeNode76.Name = "Node86";
            treeNode76.Tag = "#";
            treeNode76.Text = "Single line Comment #";
            treeNode77.Name = "Node31";
            treeNode77.Text = "Miscellaneous Constructs";
            treeNode78.Name = "Node87";
            treeNode78.Tag = "(?i:)";
            treeNode78.Text = "IgnoreCase on (?i:)";
            treeNode79.Name = "Node88";
            treeNode79.Tag = "(?-i:)";
            treeNode79.Text = "IgnoreCase off (?-i:)";
            treeNode80.Name = "Node89";
            treeNode80.Tag = "(?m:)";
            treeNode80.Text = "Multiline on (?m:)";
            treeNode81.Name = "Node90";
            treeNode81.Tag = "(?-m:)";
            treeNode81.Text = "Multiline off (?-m:)";
            treeNode82.Name = "Node91";
            treeNode82.Tag = "(?n:)";
            treeNode82.Text = "ExplicitCapture on (?n:)";
            treeNode83.Name = "Node92";
            treeNode83.Tag = "(?-n:)";
            treeNode83.Text = "ExplicitCapture off (?-n:)";
            treeNode84.Name = "Node93";
            treeNode84.Tag = "(?s:)";
            treeNode84.Text = "SingleLine on (?s:)";
            treeNode85.Name = "Node94";
            treeNode85.Tag = "(?-s:)";
            treeNode85.Text = "SingleLine off (?-s:)";
            treeNode86.Name = "Node95";
            treeNode86.Tag = "(?x:)";
            treeNode86.Text = "IgnorePatternWhitespace on (?x:)";
            treeNode87.Name = "Node96";
            treeNode87.Tag = "(?-x:)";
            treeNode87.Text = "IgnorePatternWhitespace off (?-x:)";
            treeNode88.Name = "Node32";
            treeNode88.Text = "Options";
            treeNode89.Name = "Node97";
            treeNode89.Tag = "(?<localPart>[a-z0-9!#$%&\'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&\'*+/=?^_`{|}~-]+)*)@(?<" +
    "domain>(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)";
            treeNode89.Text = "Email";
            treeNode90.Name = "Node98";
            treeNode90.Tag = "[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}";
            treeNode90.Text = "Guid";
            treeNode91.Name = "Node33";
            treeNode91.Text = "Examples";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode22,
            treeNode35,
            treeNode44,
            treeNode57,
            treeNode67,
            treeNode70,
            treeNode74,
            treeNode77,
            treeNode88,
            treeNode91});
            this.treeView1.Size = new System.Drawing.Size(323, 332);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // matchesTreeView
            // 
            this.matchesTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matchesTreeView.Location = new System.Drawing.Point(3, 16);
            this.matchesTreeView.Name = "matchesTreeView";
            this.matchesTreeView.Size = new System.Drawing.Size(908, 114);
            this.matchesTreeView.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Regex options: ";
            // 
            // matchButton
            // 
            this.matchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.matchButton.Location = new System.Drawing.Point(500, 104);
            this.matchButton.Name = "matchButton";
            this.matchButton.Size = new System.Drawing.Size(75, 23);
            this.matchButton.TabIndex = 3;
            this.matchButton.Text = "Test";
            this.matchButton.UseVisualStyleBackColor = true;
            this.matchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer3.Size = new System.Drawing.Size(914, 488);
            this.splitContainer3.SplitterDistance = 351;
            this.splitContainer3.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.matchesTreeView);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(914, 133);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Matches";
            // 
            // regexOptionsComboBox
            // 
            this.regexOptionsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            checkBoxProperties1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.regexOptionsComboBox.CheckBoxProperties = checkBoxProperties1;
            this.regexOptionsComboBox.DisplayMemberSingleItem = "";
            this.regexOptionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.regexOptionsComboBox.FormattingEnabled = true;
            this.regexOptionsComboBox.Location = new System.Drawing.Point(91, 106);
            this.regexOptionsComboBox.Name = "regexOptionsComboBox";
            this.regexOptionsComboBox.Size = new System.Drawing.Size(121, 21);
            this.regexOptionsComboBox.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 488);
            this.Controls.Add(this.splitContainer3);
            this.Name = "MainForm";
            this.Text = "Yet Another Regex Tester";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox regexTextBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox inputDataTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TreeView matchesTreeView;
        private System.Windows.Forms.Button matchButton;
        private System.Windows.Forms.Label label1;
        private PresentationControls.CheckBoxComboBox regexOptionsComboBox;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

