namespace Trader
{
    public partial class Form1
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnPing = new System.Windows.Forms.Button();
            this.txtSocket = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.lblDomain = new System.Windows.Forms.Label();
            this.txtSecret = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label44 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.strategy = new System.Windows.Forms.TabControl();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.label76 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.label78 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.label80 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox24 = new System.Windows.Forms.GroupBox();
            this.label82 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.nudOrder10Qty = new System.Windows.Forms.NumericUpDown();
            this.label84 = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.nudOrder10Percent = new System.Windows.Forms.NumericUpDown();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nudOrder8Qty = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.nudOrder8Percent = new System.Windows.Forms.NumericUpDown();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.nudOrder9Qty = new System.Windows.Forms.NumericUpDown();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.nudOrder9Percent = new System.Windows.Forms.NumericUpDown();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.label40 = new System.Windows.Forms.Label();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.label41 = new System.Windows.Forms.Label();
            this.nudOrder12Percent = new System.Windows.Forms.NumericUpDown();
            this.nudOrder12Qty = new System.Windows.Forms.NumericUpDown();
            this.label56 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.label63 = new System.Windows.Forms.Label();
            this.nudOrder11Percent = new System.Windows.Forms.NumericUpDown();
            this.nudOrder11Qty = new System.Windows.Forms.NumericUpDown();
            this.label67 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.label69 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.label64 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.label58 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nudOrder4Qty = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.nudOrder4Percent = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.nudOrder7Price = new System.Windows.Forms.NumericUpDown();
            this.nudSum = new System.Windows.Forms.NumericUpDown();
            this.label31 = new System.Windows.Forms.Label();
            this.btnStopBot = new System.Windows.Forms.Button();
            this.ddlSymbol = new System.Windows.Forms.ComboBox();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.btnStartBot = new System.Windows.Forms.Button();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.label54 = new System.Windows.Forms.Label();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.label39 = new System.Windows.Forms.Label();
            this.nudOrder6Percent = new System.Windows.Forms.NumericUpDown();
            this.nudOrder6Qty = new System.Windows.Forms.NumericUpDown();
            this.label71 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.label36 = new System.Windows.Forms.Label();
            this.nudOrder5Percent = new System.Windows.Forms.NumericUpDown();
            this.nudOrder5Qty = new System.Windows.Forms.NumericUpDown();
            this.label68 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label46 = new System.Windows.Forms.Label();
            this.nudOrder2Qty = new System.Windows.Forms.NumericUpDown();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.nudOrder2Percent = new System.Windows.Forms.NumericUpDown();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label52 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudOrder3Qty = new System.Windows.Forms.NumericUpDown();
            this.label27 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.nudOrder3Percent = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nudOrder1Price = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGrind12Hour = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.refrest12CandlesGrid = new System.Windows.Forms.Button();
            this.dataGridCandles = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.Button();
            this.SocketGetOrders = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnDeleteByClorID = new System.Windows.Forms.Button();
            this.txtDeleteByClorid = new System.Windows.Forms.TextBox();
            this.tabPage1.SuspendLayout();
            this.strategy.SuspendLayout();
            this.tab2.SuspendLayout();
            this.groupBox22.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox23.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder10Qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder10Percent)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder8Qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder8Percent)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder9Qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder9Percent)).BeginInit();
            this.groupBox13.SuspendLayout();
            this.groupBox14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder12Percent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder12Qty)).BeginInit();
            this.groupBox21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder11Percent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder11Qty)).BeginInit();
            this.groupBox20.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder4Qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder4Percent)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder7Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSum)).BeginInit();
            this.groupBox15.SuspendLayout();
            this.groupBox16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder6Percent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder6Qty)).BeginInit();
            this.groupBox17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder5Percent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder5Qty)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder2Qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder2Percent)).BeginInit();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder3Qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder3Percent)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder1Price)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrind12Hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCandles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SocketGetOrders)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnPing);
            this.tabPage1.Controls.Add(this.txtSocket);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtDomain);
            this.tabPage1.Controls.Add(this.lblDomain);
            this.tabPage1.Controls.Add(this.txtSecret);
            this.tabPage1.Controls.Add(this.txtKey);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.label44);
            this.tabPage1.Controls.Add(this.label37);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1123, 671);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnPing
            // 
            this.btnPing.Location = new System.Drawing.Point(724, 67);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(75, 23);
            this.btnPing.TabIndex = 13;
            this.btnPing.Text = "ping";
            this.btnPing.UseVisualStyleBackColor = true;
            // 
            // txtSocket
            // 
            this.txtSocket.Location = new System.Drawing.Point(112, 72);
            this.txtSocket.Name = "txtSocket";
            this.txtSocket.Size = new System.Drawing.Size(526, 20);
            this.txtSocket.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "websocket Address:";
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(55, 47);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(526, 20);
            this.txtDomain.TabIndex = 10;
            // 
            // lblDomain
            // 
            this.lblDomain.AutoSize = true;
            this.lblDomain.Location = new System.Drawing.Point(3, 46);
            this.lblDomain.Name = "lblDomain";
            this.lblDomain.Size = new System.Drawing.Size(46, 13);
            this.lblDomain.TabIndex = 9;
            this.lblDomain.Text = "Domain:";
            // 
            // txtSecret
            // 
            this.txtSecret.Location = new System.Drawing.Point(39, 23);
            this.txtSecret.Name = "txtSecret";
            this.txtSecret.Size = new System.Drawing.Size(547, 20);
            this.txtSecret.TabIndex = 8;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(39, 2);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(547, 20);
            this.txtKey.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LawnGreen;
            this.btnSave.Location = new System.Drawing.Point(587, -1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 44);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(1, 23);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(41, 13);
            this.label44.TabIndex = 6;
            this.label44.Text = "Secret:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(7, 7);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(28, 13);
            this.label37.TabIndex = 4;
            this.label37.Text = "Key:";
            // 
            // strategy
            // 
            this.strategy.Controls.Add(this.tabPage1);
            this.strategy.Controls.Add(this.tab2);
            this.strategy.Controls.Add(this.tabPage2);
            this.strategy.Controls.Add(this.tabPage3);
            this.strategy.Location = new System.Drawing.Point(0, 2);
            this.strategy.Name = "strategy";
            this.strategy.SelectedIndex = 0;
            this.strategy.Size = new System.Drawing.Size(1131, 697);
            this.strategy.TabIndex = 0;
            // 
            // tab2
            // 
            this.tab2.BackColor = System.Drawing.Color.LightGray;
            this.tab2.Controls.Add(this.label76);
            this.tab2.Controls.Add(this.label74);
            this.tab2.Controls.Add(this.label77);
            this.tab2.Controls.Add(this.label75);
            this.tab2.Controls.Add(this.groupBox22);
            this.tab2.Controls.Add(this.groupBox12);
            this.tab2.Controls.Add(this.groupBox23);
            this.tab2.Controls.Add(this.groupBox2);
            this.tab2.Controls.Add(this.groupBox13);
            this.tab2.Controls.Add(this.label5);
            this.tab2.Controls.Add(this.label66);
            this.tab2.Controls.Add(this.label61);
            this.tab2.Controls.Add(this.groupBox20);
            this.tab2.Controls.Add(this.groupBox19);
            this.tab2.Controls.Add(this.label59);
            this.tab2.Controls.Add(this.groupBox18);
            this.tab2.Controls.Add(this.label49);
            this.tab2.Controls.Add(this.label57);
            this.tab2.Controls.Add(this.label53);
            this.tab2.Controls.Add(this.groupBox4);
            this.tab2.Controls.Add(this.groupBox1);
            this.tab2.Controls.Add(this.nudSum);
            this.tab2.Controls.Add(this.label31);
            this.tab2.Controls.Add(this.btnStopBot);
            this.tab2.Controls.Add(this.ddlSymbol);
            this.tab2.Controls.Add(this.btnSaveSettings);
            this.tab2.Controls.Add(this.btnStartBot);
            this.tab2.Controls.Add(this.groupBox15);
            this.tab2.Controls.Add(this.groupBox10);
            this.tab2.Controls.Add(this.groupBox5);
            this.tab2.Location = new System.Drawing.Point(4, 22);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(1123, 671);
            this.tab2.TabIndex = 2;
            this.tab2.Text = "tabPage2";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.BackColor = System.Drawing.Color.OrangeRed;
            this.label76.Location = new System.Drawing.Point(888, 556);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(89, 13);
            this.label76.TabIndex = 48;
            this.label76.Text = "Ако мине #12>>";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.BackColor = System.Drawing.Color.OrangeRed;
            this.label74.Location = new System.Drawing.Point(548, 357);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(83, 13);
            this.label74.TabIndex = 47;
            this.label74.Text = "Ако мине #8>>";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.BackColor = System.Drawing.Color.OrangeRed;
            this.label77.Location = new System.Drawing.Point(888, 471);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(89, 13);
            this.label77.TabIndex = 46;
            this.label77.Text = "Ако мине #11>>";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.BackColor = System.Drawing.Color.OrangeRed;
            this.label75.Location = new System.Drawing.Point(513, 506);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(126, 13);
            this.label75.TabIndex = 46;
            this.label75.Text = "Ако мине #9 или #10>>";
            // 
            // groupBox22
            // 
            this.groupBox22.BackColor = System.Drawing.Color.DimGray;
            this.groupBox22.Controls.Add(this.label78);
            this.groupBox22.Controls.Add(this.label79);
            this.groupBox22.Location = new System.Drawing.Point(967, 527);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(128, 71);
            this.groupBox22.TabIndex = 47;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "стъпка 4";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.BackColor = System.Drawing.Color.Gray;
            this.label78.Location = new System.Drawing.Point(15, 49);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(73, 13);
            this.label78.TabIndex = 26;
            this.label78.Text = "Край за долу";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.BackColor = System.Drawing.Color.Gray;
            this.label79.Location = new System.Drawing.Point(15, 25);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(60, 13);
            this.label79.TabIndex = 25;
            this.label79.Text = "Delete #11";
            // 
            // groupBox12
            // 
            this.groupBox12.BackColor = System.Drawing.Color.DimGray;
            this.groupBox12.Controls.Add(this.label32);
            this.groupBox12.Controls.Add(this.label33);
            this.groupBox12.Location = new System.Drawing.Point(631, 326);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(266, 71);
            this.groupBox12.TabIndex = 28;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "стъпка 3";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Gray;
            this.label32.Location = new System.Drawing.Point(15, 49);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(73, 13);
            this.label32.TabIndex = 26;
            this.label32.Text = "Край за долу";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Gray;
            this.label33.Location = new System.Drawing.Point(15, 25);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(76, 13);
            this.label33.TabIndex = 25;
            this.label33.Text = "Delete #9,#10";
            // 
            // groupBox23
            // 
            this.groupBox23.BackColor = System.Drawing.Color.DimGray;
            this.groupBox23.Controls.Add(this.label80);
            this.groupBox23.Controls.Add(this.label81);
            this.groupBox23.Location = new System.Drawing.Point(967, 442);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Size = new System.Drawing.Size(128, 71);
            this.groupBox23.TabIndex = 45;
            this.groupBox23.TabStop = false;
            this.groupBox23.Text = "стъпка 4";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.BackColor = System.Drawing.Color.Gray;
            this.label80.Location = new System.Drawing.Point(15, 49);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(73, 13);
            this.label80.TabIndex = 26;
            this.label80.Text = "Край за долу";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.BackColor = System.Drawing.Color.Gray;
            this.label81.Location = new System.Drawing.Point(15, 25);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(60, 13);
            this.label81.TabIndex = 25;
            this.label81.Text = "Delete #12";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox2.Controls.Add(this.groupBox24);
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Controls.Add(this.groupBox9);
            this.groupBox2.Location = new System.Drawing.Point(310, 317);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 274);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "стъпка2";
            // 
            // groupBox24
            // 
            this.groupBox24.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox24.Controls.Add(this.label82);
            this.groupBox24.Controls.Add(this.label83);
            this.groupBox24.Controls.Add(this.nudOrder10Qty);
            this.groupBox24.Controls.Add(this.label84);
            this.groupBox24.Controls.Add(this.label85);
            this.groupBox24.Controls.Add(this.label86);
            this.groupBox24.Controls.Add(this.nudOrder10Percent);
            this.groupBox24.Location = new System.Drawing.Point(10, 182);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Size = new System.Drawing.Size(215, 87);
            this.groupBox24.TabIndex = 37;
            this.groupBox24.TabStop = false;
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.ForeColor = System.Drawing.Color.Green;
            this.label82.Location = new System.Drawing.Point(3, 28);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(209, 13);
            this.label82.TabIndex = 36;
            this.label82.Text = "СтопЦена = (СтопЦена #1 )*(100+%)/100";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(166, 65);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(21, 13);
            this.label83.TabIndex = 35;
            this.label83.Text = "qty";
            // 
            // nudOrder10Qty
            // 
            this.nudOrder10Qty.Location = new System.Drawing.Point(6, 64);
            this.nudOrder10Qty.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudOrder10Qty.Name = "nudOrder10Qty";
            this.nudOrder10Qty.Size = new System.Drawing.Size(159, 20);
            this.nudOrder10Qty.TabIndex = 34;
            this.nudOrder10Qty.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.ForeColor = System.Drawing.Color.Red;
            this.label84.Location = new System.Drawing.Point(-1, 16);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(40, 13);
            this.label84.TabIndex = 18;
            this.label84.Text = "№ #10";
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(165, 47);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(15, 13);
            this.label85.TabIndex = 18;
            this.label85.Text = "%";
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Location = new System.Drawing.Point(37, 16);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(87, 13);
            this.label86.TabIndex = 17;
            this.label86.Text = "StopMarket BUY";
            // 
            // nudOrder10Percent
            // 
            this.nudOrder10Percent.DecimalPlaces = 14;
            this.nudOrder10Percent.Location = new System.Drawing.Point(5, 43);
            this.nudOrder10Percent.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudOrder10Percent.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.nudOrder10Percent.Name = "nudOrder10Percent";
            this.nudOrder10Percent.Size = new System.Drawing.Size(161, 20);
            this.nudOrder10Percent.TabIndex = 14;
            this.nudOrder10Percent.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label9);
            this.groupBox8.Controls.Add(this.nudOrder8Qty);
            this.groupBox8.Controls.Add(this.label13);
            this.groupBox8.Controls.Add(this.label16);
            this.groupBox8.Controls.Add(this.label19);
            this.groupBox8.Controls.Add(this.label20);
            this.groupBox8.Controls.Add(this.nudOrder8Percent);
            this.groupBox8.Location = new System.Drawing.Point(10, 11);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(215, 87);
            this.groupBox8.TabIndex = 36;
            this.groupBox8.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(166, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "qty";
            // 
            // nudOrder8Qty
            // 
            this.nudOrder8Qty.Location = new System.Drawing.Point(6, 64);
            this.nudOrder8Qty.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudOrder8Qty.Name = "nudOrder8Qty";
            this.nudOrder8Qty.Size = new System.Drawing.Size(159, 20);
            this.nudOrder8Qty.TabIndex = 34;
            this.nudOrder8Qty.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Green;
            this.label13.Location = new System.Drawing.Point(0, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(209, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "СтопЦена = (СтопЦена #1 )*(100+%)/100";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(-1, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "№ #8";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(165, 47);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(15, 13);
            this.label19.TabIndex = 18;
            this.label19.Text = "%";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(29, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(81, 13);
            this.label20.TabIndex = 17;
            this.label20.Text = "TakeProfit BUY";
            // 
            // nudOrder8Percent
            // 
            this.nudOrder8Percent.DecimalPlaces = 14;
            this.nudOrder8Percent.Location = new System.Drawing.Point(5, 43);
            this.nudOrder8Percent.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudOrder8Percent.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.nudOrder8Percent.Name = "nudOrder8Percent";
            this.nudOrder8Percent.Size = new System.Drawing.Size(161, 20);
            this.nudOrder8Percent.TabIndex = 14;
            this.nudOrder8Percent.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label22);
            this.groupBox9.Controls.Add(this.label26);
            this.groupBox9.Controls.Add(this.nudOrder9Qty);
            this.groupBox9.Controls.Add(this.label28);
            this.groupBox9.Controls.Add(this.label29);
            this.groupBox9.Controls.Add(this.label30);
            this.groupBox9.Controls.Add(this.nudOrder9Percent);
            this.groupBox9.Location = new System.Drawing.Point(10, 94);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(215, 87);
            this.groupBox9.TabIndex = 14;
            this.groupBox9.TabStop = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.Green;
            this.label22.Location = new System.Drawing.Point(3, 29);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(209, 13);
            this.label22.TabIndex = 36;
            this.label22.Text = "СтопЦена = (СтопЦена #1 )*(100+%)/100";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(166, 65);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(21, 13);
            this.label26.TabIndex = 35;
            this.label26.Text = "qty";
            // 
            // nudOrder9Qty
            // 
            this.nudOrder9Qty.Location = new System.Drawing.Point(6, 64);
            this.nudOrder9Qty.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudOrder9Qty.Name = "nudOrder9Qty";
            this.nudOrder9Qty.Size = new System.Drawing.Size(159, 20);
            this.nudOrder9Qty.TabIndex = 34;
            this.nudOrder9Qty.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.ForeColor = System.Drawing.Color.Red;
            this.label28.Location = new System.Drawing.Point(-1, 16);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(34, 13);
            this.label28.TabIndex = 18;
            this.label28.Text = "№ #9";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(165, 47);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(15, 13);
            this.label29.TabIndex = 18;
            this.label29.Text = "%";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(29, 16);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(87, 13);
            this.label30.TabIndex = 17;
            this.label30.Text = "StopMarket BUY";
            // 
            // nudOrder9Percent
            // 
            this.nudOrder9Percent.DecimalPlaces = 14;
            this.nudOrder9Percent.Location = new System.Drawing.Point(5, 43);
            this.nudOrder9Percent.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudOrder9Percent.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.nudOrder9Percent.Name = "nudOrder9Percent";
            this.nudOrder9Percent.Size = new System.Drawing.Size(161, 20);
            this.nudOrder9Percent.TabIndex = 14;
            this.nudOrder9Percent.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // groupBox13
            // 
            this.groupBox13.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox13.Controls.Add(this.label40);
            this.groupBox13.Controls.Add(this.groupBox14);
            this.groupBox13.Controls.Add(this.groupBox21);
            this.groupBox13.Location = new System.Drawing.Point(628, 402);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(271, 198);
            this.groupBox13.TabIndex = 27;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "стъпка 3";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.BackColor = System.Drawing.Color.DimGray;
            this.label40.Location = new System.Drawing.Point(15, 25);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(54, 13);
            this.label40.TabIndex = 25;
            this.label40.Text = "Delete #8";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.label41);
            this.groupBox14.Controls.Add(this.nudOrder12Percent);
            this.groupBox14.Controls.Add(this.nudOrder12Qty);
            this.groupBox14.Controls.Add(this.label56);
            this.groupBox14.Controls.Add(this.label60);
            this.groupBox14.Controls.Add(this.label62);
            this.groupBox14.Location = new System.Drawing.Point(6, 119);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(240, 78);
            this.groupBox14.TabIndex = 24;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "StopMarket SELL";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(156, 48);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(21, 13);
            this.label41.TabIndex = 39;
            this.label41.Text = "qty";
            // 
            // nudOrder12Percent
            // 
            this.nudOrder12Percent.DecimalPlaces = 14;
            this.nudOrder12Percent.Location = new System.Drawing.Point(6, 24);
            this.nudOrder12Percent.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudOrder12Percent.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.nudOrder12Percent.Name = "nudOrder12Percent";
            this.nudOrder12Percent.Size = new System.Drawing.Size(148, 20);
            this.nudOrder12Percent.TabIndex = 23;
            this.nudOrder12Percent.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudOrder12Qty
            // 
            this.nudOrder12Qty.Location = new System.Drawing.Point(6, 47);
            this.nudOrder12Qty.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudOrder12Qty.Name = "nudOrder12Qty";
            this.nudOrder12Qty.Size = new System.Drawing.Size(148, 20);
            this.nudOrder12Qty.TabIndex = 38;
            this.nudOrder12Qty.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.ForeColor = System.Drawing.Color.Green;
            this.label56.Location = new System.Drawing.Point(6, 13);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(209, 13);
            this.label56.TabIndex = 29;
            this.label56.Text = "СтопЦена = (СтопЦена #9 )*(100+%)/100";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.ForeColor = System.Drawing.Color.Red;
            this.label60.Location = new System.Drawing.Point(92, 0);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(40, 13);
            this.label60.TabIndex = 25;
            this.label60.Text = "№ #12";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(152, 28);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(15, 13);
            this.label62.TabIndex = 21;
            this.label62.Text = "%";
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.label63);
            this.groupBox21.Controls.Add(this.nudOrder11Percent);
            this.groupBox21.Controls.Add(this.nudOrder11Qty);
            this.groupBox21.Controls.Add(this.label67);
            this.groupBox21.Controls.Add(this.label72);
            this.groupBox21.Controls.Add(this.label73);
            this.groupBox21.Location = new System.Drawing.Point(6, 46);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(240, 79);
            this.groupBox21.TabIndex = 0;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "TakeProfit SELL";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(150, 51);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(21, 13);
            this.label63.TabIndex = 37;
            this.label63.Text = "qty";
            // 
            // nudOrder11Percent
            // 
            this.nudOrder11Percent.DecimalPlaces = 14;
            this.nudOrder11Percent.Location = new System.Drawing.Point(6, 27);
            this.nudOrder11Percent.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudOrder11Percent.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.nudOrder11Percent.Name = "nudOrder11Percent";
            this.nudOrder11Percent.Size = new System.Drawing.Size(142, 20);
            this.nudOrder11Percent.TabIndex = 23;
            this.nudOrder11Percent.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudOrder11Qty
            // 
            this.nudOrder11Qty.Location = new System.Drawing.Point(6, 50);
            this.nudOrder11Qty.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudOrder11Qty.Name = "nudOrder11Qty";
            this.nudOrder11Qty.Size = new System.Drawing.Size(142, 20);
            this.nudOrder11Qty.TabIndex = 36;
            this.nudOrder11Qty.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.ForeColor = System.Drawing.Color.Green;
            this.label67.Location = new System.Drawing.Point(1, 13);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(209, 13);
            this.label67.TabIndex = 27;
            this.label67.Text = "СтопЦена = (СтопЦена #9 )*(100+%)/100";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.ForeColor = System.Drawing.Color.Red;
            this.label72.Location = new System.Drawing.Point(92, 0);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(40, 13);
            this.label72.TabIndex = 26;
            this.label72.Text = "№ #11";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(149, 31);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(15, 13);
            this.label73.TabIndex = 21;
            this.label73.Text = "%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(222, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Ако мине #7>>";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.BackColor = System.Drawing.Color.OrangeRed;
            this.label66.Location = new System.Drawing.Point(888, 230);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(83, 13);
            this.label66.TabIndex = 44;
            this.label66.Text = "Ако мине #6>>";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.BackColor = System.Drawing.Color.OrangeRed;
            this.label61.Location = new System.Drawing.Point(888, 145);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(83, 13);
            this.label61.TabIndex = 42;
            this.label61.Text = "Ако мине #5>>";
            // 
            // groupBox20
            // 
            this.groupBox20.BackColor = System.Drawing.Color.DimGray;
            this.groupBox20.Controls.Add(this.label69);
            this.groupBox20.Controls.Add(this.label70);
            this.groupBox20.Location = new System.Drawing.Point(967, 201);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(128, 71);
            this.groupBox20.TabIndex = 43;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "стъпка 4";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.BackColor = System.Drawing.Color.Gray;
            this.label69.Location = new System.Drawing.Point(15, 49);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(73, 13);
            this.label69.TabIndex = 26;
            this.label69.Text = "Край за горе";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.BackColor = System.Drawing.Color.Gray;
            this.label70.Location = new System.Drawing.Point(15, 25);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(54, 13);
            this.label70.TabIndex = 25;
            this.label70.Text = "Delete #5";
            // 
            // groupBox19
            // 
            this.groupBox19.BackColor = System.Drawing.Color.DimGray;
            this.groupBox19.Controls.Add(this.label64);
            this.groupBox19.Controls.Add(this.label65);
            this.groupBox19.Location = new System.Drawing.Point(967, 116);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(128, 71);
            this.groupBox19.TabIndex = 41;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "стъпка 4";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.BackColor = System.Drawing.Color.Gray;
            this.label64.Location = new System.Drawing.Point(15, 49);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(73, 13);
            this.label64.TabIndex = 26;
            this.label64.Text = "Край за горе";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.BackColor = System.Drawing.Color.Gray;
            this.label65.Location = new System.Drawing.Point(15, 25);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(54, 13);
            this.label65.TabIndex = 25;
            this.label65.Text = "Delete #6";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.BackColor = System.Drawing.Color.OrangeRed;
            this.label59.Location = new System.Drawing.Point(550, 36);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(83, 13);
            this.label59.TabIndex = 40;
            this.label59.Text = "Ако мине #2>>";
            // 
            // groupBox18
            // 
            this.groupBox18.BackColor = System.Drawing.Color.DimGray;
            this.groupBox18.Controls.Add(this.label58);
            this.groupBox18.Controls.Add(this.label55);
            this.groupBox18.Location = new System.Drawing.Point(633, 6);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(266, 71);
            this.groupBox18.TabIndex = 26;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "стъпка 3";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.BackColor = System.Drawing.Color.Gray;
            this.label58.Location = new System.Drawing.Point(15, 49);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(73, 13);
            this.label58.TabIndex = 26;
            this.label58.Text = "Край за горе";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.BackColor = System.Drawing.Color.Gray;
            this.label55.Location = new System.Drawing.Point(15, 25);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(70, 13);
            this.label55.TabIndex = 25;
            this.label55.Text = "Delete #3,#4";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.BackColor = System.Drawing.Color.OrangeRed;
            this.label49.Location = new System.Drawing.Point(515, 185);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(120, 13);
            this.label49.TabIndex = 39;
            this.label49.Text = "Ако мине #3 или #4>>";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.BackColor = System.Drawing.Color.OrangeRed;
            this.label57.Location = new System.Drawing.Point(225, 45);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(83, 13);
            this.label57.TabIndex = 38;
            this.label57.Text = "Ако мине #1>>";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(0, 0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(41, 13);
            this.label53.TabIndex = 37;
            this.label53.Text = "label53";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.nudOrder4Qty);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.nudOrder4Percent);
            this.groupBox4.Location = new System.Drawing.Point(310, 183);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(215, 87);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Green;
            this.label12.Location = new System.Drawing.Point(3, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(209, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "СтопЦена = (СтопЦена #1 )*(100+%)/100";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(166, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "qty";
            // 
            // nudOrder4Qty
            // 
            this.nudOrder4Qty.Location = new System.Drawing.Point(6, 64);
            this.nudOrder4Qty.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudOrder4Qty.Name = "nudOrder4Qty";
            this.nudOrder4Qty.Size = new System.Drawing.Size(159, 20);
            this.nudOrder4Qty.TabIndex = 34;
            this.nudOrder4Qty.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(-1, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "№ #4";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(165, 47);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(15, 13);
            this.label23.TabIndex = 18;
            this.label23.Text = "%";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(29, 16);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(91, 13);
            this.label24.TabIndex = 17;
            this.label24.Text = "StopMarket SELL";
            // 
            // nudOrder4Percent
            // 
            this.nudOrder4Percent.DecimalPlaces = 14;
            this.nudOrder4Percent.Location = new System.Drawing.Point(5, 43);
            this.nudOrder4Percent.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudOrder4Percent.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.nudOrder4Percent.Name = "nudOrder4Percent";
            this.nudOrder4Percent.Size = new System.Drawing.Size(161, 20);
            this.nudOrder4Percent.TabIndex = 14;
            this.nudOrder4Percent.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(6, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 186);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "стъпка 1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label34);
            this.groupBox3.Controls.Add(this.label45);
            this.groupBox3.Controls.Add(this.nudOrder7Price);
            this.groupBox3.Location = new System.Drawing.Point(9, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(205, 92);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Долу";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(-1, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 13);
            this.label17.TabIndex = 17;
            this.label17.Text = "№ #7";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(135, 62);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(13, 13);
            this.label18.TabIndex = 19;
            this.label18.Text = "$";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(29, 24);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(119, 13);
            this.label34.TabIndex = 12;
            this.label34.Text = "За StopMarket SELL $:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.ForeColor = System.Drawing.Color.Green;
            this.label45.Location = new System.Drawing.Point(2, 44);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(192, 13);
            this.label45.TabIndex = 2;
            this.label45.Text = "ЦЕНА :минимумПоследна Свещ + $:";
            // 
            // nudOrder7Price
            // 
            this.nudOrder7Price.DecimalPlaces = 14;
            this.nudOrder7Price.Location = new System.Drawing.Point(5, 60);
            this.nudOrder7Price.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudOrder7Price.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.nudOrder7Price.Name = "nudOrder7Price";
            this.nudOrder7Price.Size = new System.Drawing.Size(129, 20);
            this.nudOrder7Price.TabIndex = 3;
            this.nudOrder7Price.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // nudSum
            // 
            this.nudSum.Location = new System.Drawing.Point(65, 8);
            this.nudSum.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudSum.Name = "nudSum";
            this.nudSum.Size = new System.Drawing.Size(120, 20);
            this.nudSum.TabIndex = 33;
            this.nudSum.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(9, 12);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(53, 13);
            this.label31.TabIndex = 31;
            this.label31.Text = "StartSum:";
            // 
            // btnStopBot
            // 
            this.btnStopBot.BackColor = System.Drawing.Color.Red;
            this.btnStopBot.Location = new System.Drawing.Point(83, 537);
            this.btnStopBot.Name = "btnStopBot";
            this.btnStopBot.Size = new System.Drawing.Size(75, 23);
            this.btnStopBot.TabIndex = 32;
            this.btnStopBot.Text = "Stop bot";
            this.btnStopBot.UseVisualStyleBackColor = false;
            // 
            // ddlSymbol
            // 
            this.ddlSymbol.FormattingEnabled = true;
            this.ddlSymbol.Location = new System.Drawing.Point(191, 9);
            this.ddlSymbol.Name = "ddlSymbol";
            this.ddlSymbol.Size = new System.Drawing.Size(74, 21);
            this.ddlSymbol.TabIndex = 31;
            this.ddlSymbol.SelectedIndexChanged += new System.EventHandler(this.DdlSymbol_SelectedIndexChanged);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(20, 577);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSettings.TabIndex = 30;
            this.btnSaveSettings.Text = "Save";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.BtnSaveSettings_Click);
            // 
            // btnStartBot
            // 
            this.btnStartBot.BackColor = System.Drawing.Color.Lime;
            this.btnStartBot.ForeColor = System.Drawing.Color.Black;
            this.btnStartBot.Location = new System.Drawing.Point(6, 537);
            this.btnStartBot.Name = "btnStartBot";
            this.btnStartBot.Size = new System.Drawing.Size(75, 23);
            this.btnStartBot.TabIndex = 29;
            this.btnStartBot.Text = "Start Bot";
            this.btnStartBot.UseVisualStyleBackColor = false;
            this.btnStartBot.Click += new System.EventHandler(this.btnStartBot_Click);
            // 
            // groupBox15
            // 
            this.groupBox15.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox15.Controls.Add(this.label54);
            this.groupBox15.Controls.Add(this.groupBox16);
            this.groupBox15.Controls.Add(this.groupBox17);
            this.groupBox15.Location = new System.Drawing.Point(630, 82);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(271, 198);
            this.groupBox15.TabIndex = 17;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "стъпка 3";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.BackColor = System.Drawing.Color.DimGray;
            this.label54.Location = new System.Drawing.Point(15, 25);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(54, 13);
            this.label54.TabIndex = 25;
            this.label54.Text = "Delete #2";
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.label39);
            this.groupBox16.Controls.Add(this.nudOrder6Percent);
            this.groupBox16.Controls.Add(this.nudOrder6Qty);
            this.groupBox16.Controls.Add(this.label71);
            this.groupBox16.Controls.Add(this.label42);
            this.groupBox16.Controls.Add(this.label35);
            this.groupBox16.Location = new System.Drawing.Point(6, 119);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(240, 78);
            this.groupBox16.TabIndex = 24;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "StopMarketBUY";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(156, 48);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(21, 13);
            this.label39.TabIndex = 39;
            this.label39.Text = "qty";
            // 
            // nudOrder6Percent
            // 
            this.nudOrder6Percent.DecimalPlaces = 14;
            this.nudOrder6Percent.Location = new System.Drawing.Point(6, 24);
            this.nudOrder6Percent.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudOrder6Percent.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.nudOrder6Percent.Name = "nudOrder6Percent";
            this.nudOrder6Percent.Size = new System.Drawing.Size(148, 20);
            this.nudOrder6Percent.TabIndex = 23;
            this.nudOrder6Percent.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudOrder6Qty
            // 
            this.nudOrder6Qty.Location = new System.Drawing.Point(6, 47);
            this.nudOrder6Qty.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudOrder6Qty.Name = "nudOrder6Qty";
            this.nudOrder6Qty.Size = new System.Drawing.Size(148, 20);
            this.nudOrder6Qty.TabIndex = 38;
            this.nudOrder6Qty.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.ForeColor = System.Drawing.Color.Green;
            this.label71.Location = new System.Drawing.Point(6, 13);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(209, 13);
            this.label71.TabIndex = 29;
            this.label71.Text = "СтопЦена = (СтопЦена #4 )*(100+%)/100";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.ForeColor = System.Drawing.Color.Red;
            this.label42.Location = new System.Drawing.Point(92, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(34, 13);
            this.label42.TabIndex = 25;
            this.label42.Text = "№ #6";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(152, 28);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(15, 13);
            this.label35.TabIndex = 21;
            this.label35.Text = "%";
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.label36);
            this.groupBox17.Controls.Add(this.nudOrder5Percent);
            this.groupBox17.Controls.Add(this.nudOrder5Qty);
            this.groupBox17.Controls.Add(this.label68);
            this.groupBox17.Controls.Add(this.label43);
            this.groupBox17.Controls.Add(this.label38);
            this.groupBox17.Location = new System.Drawing.Point(6, 46);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(240, 79);
            this.groupBox17.TabIndex = 0;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "TakeProfitBUY";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(150, 51);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(21, 13);
            this.label36.TabIndex = 37;
            this.label36.Text = "qty";
            // 
            // nudOrder5Percent
            // 
            this.nudOrder5Percent.DecimalPlaces = 14;
            this.nudOrder5Percent.Location = new System.Drawing.Point(6, 27);
            this.nudOrder5Percent.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudOrder5Percent.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.nudOrder5Percent.Name = "nudOrder5Percent";
            this.nudOrder5Percent.Size = new System.Drawing.Size(142, 20);
            this.nudOrder5Percent.TabIndex = 23;
            this.nudOrder5Percent.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudOrder5Qty
            // 
            this.nudOrder5Qty.Location = new System.Drawing.Point(6, 50);
            this.nudOrder5Qty.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudOrder5Qty.Name = "nudOrder5Qty";
            this.nudOrder5Qty.Size = new System.Drawing.Size(142, 20);
            this.nudOrder5Qty.TabIndex = 36;
            this.nudOrder5Qty.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.ForeColor = System.Drawing.Color.Green;
            this.label68.Location = new System.Drawing.Point(1, 13);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(209, 13);
            this.label68.TabIndex = 27;
            this.label68.Text = "СтопЦена = (СтопЦена #4 )*(100+%)/100";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.ForeColor = System.Drawing.Color.Red;
            this.label43.Location = new System.Drawing.Point(92, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(34, 13);
            this.label43.TabIndex = 26;
            this.label43.Text = "№ #5";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(149, 31);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(15, 13);
            this.label38.TabIndex = 21;
            this.label38.Text = "%";
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox10.Controls.Add(this.groupBox6);
            this.groupBox10.Controls.Add(this.groupBox11);
            this.groupBox10.Location = new System.Drawing.Point(301, 6);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(232, 274);
            this.groupBox10.TabIndex = 16;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "стъпка2";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label46);
            this.groupBox6.Controls.Add(this.nudOrder2Qty);
            this.groupBox6.Controls.Add(this.label47);
            this.groupBox6.Controls.Add(this.label48);
            this.groupBox6.Controls.Add(this.label50);
            this.groupBox6.Controls.Add(this.label51);
            this.groupBox6.Controls.Add(this.nudOrder2Percent);
            this.groupBox6.Location = new System.Drawing.Point(10, 11);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(215, 87);
            this.groupBox6.TabIndex = 36;
            this.groupBox6.TabStop = false;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(166, 65);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(21, 13);
            this.label46.TabIndex = 35;
            this.label46.Text = "qty";
            // 
            // nudOrder2Qty
            // 
            this.nudOrder2Qty.Location = new System.Drawing.Point(6, 64);
            this.nudOrder2Qty.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudOrder2Qty.Name = "nudOrder2Qty";
            this.nudOrder2Qty.Size = new System.Drawing.Size(159, 20);
            this.nudOrder2Qty.TabIndex = 34;
            this.nudOrder2Qty.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.ForeColor = System.Drawing.Color.Green;
            this.label47.Location = new System.Drawing.Point(0, 29);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(209, 13);
            this.label47.TabIndex = 29;
            this.label47.Text = "СтопЦена = (СтопЦена #1 )*(100+%)/100";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.ForeColor = System.Drawing.Color.Red;
            this.label48.Location = new System.Drawing.Point(-1, 16);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(34, 13);
            this.label48.TabIndex = 18;
            this.label48.Text = "№ #2";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(165, 47);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(15, 13);
            this.label50.TabIndex = 18;
            this.label50.Text = "%";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(29, 16);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(85, 13);
            this.label51.TabIndex = 17;
            this.label51.Text = "TakeProfit SELL";
            // 
            // nudOrder2Percent
            // 
            this.nudOrder2Percent.DecimalPlaces = 14;
            this.nudOrder2Percent.Location = new System.Drawing.Point(5, 43);
            this.nudOrder2Percent.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudOrder2Percent.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.nudOrder2Percent.Name = "nudOrder2Percent";
            this.nudOrder2Percent.Size = new System.Drawing.Size(161, 20);
            this.nudOrder2Percent.TabIndex = 14;
            this.nudOrder2Percent.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label52);
            this.groupBox11.Controls.Add(this.label7);
            this.groupBox11.Controls.Add(this.nudOrder3Qty);
            this.groupBox11.Controls.Add(this.label27);
            this.groupBox11.Controls.Add(this.label11);
            this.groupBox11.Controls.Add(this.label21);
            this.groupBox11.Controls.Add(this.nudOrder3Percent);
            this.groupBox11.Location = new System.Drawing.Point(10, 94);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(215, 87);
            this.groupBox11.TabIndex = 14;
            this.groupBox11.TabStop = false;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.ForeColor = System.Drawing.Color.Green;
            this.label52.Location = new System.Drawing.Point(3, 29);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(209, 13);
            this.label52.TabIndex = 36;
            this.label52.Text = "СтопЦена = (СтопЦена #1 )*(100+%)/100";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "qty";
            // 
            // nudOrder3Qty
            // 
            this.nudOrder3Qty.Location = new System.Drawing.Point(6, 64);
            this.nudOrder3Qty.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudOrder3Qty.Name = "nudOrder3Qty";
            this.nudOrder3Qty.Size = new System.Drawing.Size(159, 20);
            this.nudOrder3Qty.TabIndex = 34;
            this.nudOrder3Qty.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.ForeColor = System.Drawing.Color.Red;
            this.label27.Location = new System.Drawing.Point(-1, 16);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(34, 13);
            this.label27.TabIndex = 18;
            this.label27.Text = "№ #3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(165, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "%";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(29, 16);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(91, 13);
            this.label21.TabIndex = 17;
            this.label21.Text = "StopMarket SELL";
            // 
            // nudOrder3Percent
            // 
            this.nudOrder3Percent.DecimalPlaces = 14;
            this.nudOrder3Percent.Location = new System.Drawing.Point(5, 43);
            this.nudOrder3Percent.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudOrder3Percent.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.nudOrder3Percent.Name = "nudOrder3Percent";
            this.nudOrder3Percent.Size = new System.Drawing.Size(161, 20);
            this.nudOrder3Percent.TabIndex = 14;
            this.nudOrder3Percent.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Location = new System.Drawing.Point(6, 29);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(222, 168);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "стъпка 1";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label25);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.nudOrder1Price);
            this.groupBox7.Location = new System.Drawing.Point(7, 13);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(205, 136);
            this.groupBox7.TabIndex = 14;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Горе";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.Color.Red;
            this.label25.Location = new System.Drawing.Point(-2, 21);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(34, 13);
            this.label25.TabIndex = 21;
            this.label25.Text = "№ #1";
            this.label25.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(130, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "За StopMarket BUY $:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(0, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(199, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "ЦЕНА :МаксимумПоследна Свещ + $:";
            // 
            // nudOrder1Price
            // 
            this.nudOrder1Price.DecimalPlaces = 14;
            this.nudOrder1Price.Location = new System.Drawing.Point(9, 56);
            this.nudOrder1Price.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudOrder1Price.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.nudOrder1Price.Name = "nudOrder1Price";
            this.nudOrder1Price.Size = new System.Drawing.Size(119, 20);
            this.nudOrder1Price.TabIndex = 14;
            this.nudOrder1Price.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGrind12Hour);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.refrest12CandlesGrid);
            this.tabPage2.Controls.Add(this.dataGridCandles);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.refresh);
            this.tabPage2.Controls.Add(this.SocketGetOrders);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1123, 671);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGrind12Hour
            // 
            this.dataGrind12Hour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrind12Hour.Location = new System.Drawing.Point(17, 573);
            this.dataGrind12Hour.Name = "dataGrind12Hour";
            this.dataGrind12Hour.Size = new System.Drawing.Size(895, 51);
            this.dataGrind12Hour.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 557);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "12hour-builded-candle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "refrest12-1hour-build 1-12hourCandlesGrid";
            // 
            // refrest12CandlesGrid
            // 
            this.refrest12CandlesGrid.Location = new System.Drawing.Point(39, 285);
            this.refrest12CandlesGrid.Name = "refrest12CandlesGrid";
            this.refrest12CandlesGrid.Size = new System.Drawing.Size(128, 23);
            this.refrest12CandlesGrid.TabIndex = 8;
            this.refrest12CandlesGrid.Text = "refrest12CandlesGrid";
            this.refrest12CandlesGrid.UseVisualStyleBackColor = true;
            this.refrest12CandlesGrid.Click += new System.EventHandler(this.Refrest12CandlesGrid_Click);
            // 
            // dataGridCandles
            // 
            this.dataGridCandles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCandles.Location = new System.Drawing.Point(17, 314);
            this.dataGridCandles.Name = "dataGridCandles";
            this.dataGridCandles.Size = new System.Drawing.Size(895, 234);
            this.dataGridCandles.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "OrdersFromServer";
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(399, 3);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 5;
            this.refresh.Text = "refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // SocketGetOrders
            // 
            this.SocketGetOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SocketGetOrders.Location = new System.Drawing.Point(17, 32);
            this.SocketGetOrders.Name = "SocketGetOrders";
            this.SocketGetOrders.Size = new System.Drawing.Size(895, 234);
            this.SocketGetOrders.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnDeleteByClorID);
            this.tabPage3.Controls.Add(this.txtDeleteByClorid);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1123, 671);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnDeleteByClorID
            // 
            this.btnDeleteByClorID.Location = new System.Drawing.Point(211, 92);
            this.btnDeleteByClorID.Name = "btnDeleteByClorID";
            this.btnDeleteByClorID.Size = new System.Drawing.Size(113, 23);
            this.btnDeleteByClorID.TabIndex = 1;
            this.btnDeleteByClorID.Text = "btnDeleteByClorID";
            this.btnDeleteByClorID.UseVisualStyleBackColor = true;
            this.btnDeleteByClorID.Click += new System.EventHandler(this.BtnDeleteByClorID_Click);
            // 
            // txtDeleteByClorid
            // 
            this.txtDeleteByClorid.Location = new System.Drawing.Point(211, 66);
            this.txtDeleteByClorid.Name = "txtDeleteByClorid";
            this.txtDeleteByClorid.Size = new System.Drawing.Size(113, 20);
            this.txtDeleteByClorid.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 701);
            this.Controls.Add(this.strategy);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.strategy.ResumeLayout(false);
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            this.groupBox22.ResumeLayout(false);
            this.groupBox22.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox23.ResumeLayout(false);
            this.groupBox23.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox24.ResumeLayout(false);
            this.groupBox24.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder10Qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder10Percent)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder8Qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder8Percent)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder9Qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder9Percent)).EndInit();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder12Percent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder12Qty)).EndInit();
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder11Percent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder11Qty)).EndInit();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder4Qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder4Percent)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder7Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSum)).EndInit();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder6Percent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder6Qty)).EndInit();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder5Percent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder5Qty)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder2Qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder2Percent)).EndInit();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder3Qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder3Percent)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder1Price)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrind12Hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCandles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SocketGetOrders)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TextBox txtSecret;
        public System.Windows.Forms.TextBox txtKey;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Label label44;
        public System.Windows.Forms.Label label37;
        public System.Windows.Forms.TabControl strategy;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.Label lblDomain;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtSocket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPing;
        private System.Windows.Forms.DataGridView SocketGetOrders;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button refrest12CandlesGrid;
        private System.Windows.Forms.DataGridView dataGridCandles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGrind12Hour;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnDeleteByClorID;
        private System.Windows.Forms.TextBox txtDeleteByClorid;
        public System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.Label label61;
        public System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.Label label66;
        public System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label59;
        public System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label53;
        public System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.NumericUpDown nudOrder4Qty;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label23;
        public System.Windows.Forms.Label label24;
        public System.Windows.Forms.NumericUpDown nudOrder4Percent;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.Label label18;
        public System.Windows.Forms.Label label34;
        public System.Windows.Forms.Label label45;
        public System.Windows.Forms.NumericUpDown nudOrder7Price;
        public System.Windows.Forms.NumericUpDown nudSum;
        public System.Windows.Forms.Label label31;
        private System.Windows.Forms.Button btnStopBot;
        private System.Windows.Forms.ComboBox ddlSymbol;
        public System.Windows.Forms.Button btnSaveSettings;
        public System.Windows.Forms.Button btnStartBot;
        public System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.Label label54;
        public System.Windows.Forms.GroupBox groupBox16;
        public System.Windows.Forms.Label label39;
        public System.Windows.Forms.NumericUpDown nudOrder6Percent;
        public System.Windows.Forms.NumericUpDown nudOrder6Qty;
        public System.Windows.Forms.Label label71;
        public System.Windows.Forms.Label label42;
        public System.Windows.Forms.Label label35;
        public System.Windows.Forms.GroupBox groupBox17;
        public System.Windows.Forms.Label label36;
        public System.Windows.Forms.NumericUpDown nudOrder5Percent;
        public System.Windows.Forms.NumericUpDown nudOrder5Qty;
        public System.Windows.Forms.Label label68;
        public System.Windows.Forms.Label label43;
        public System.Windows.Forms.Label label38;
        public System.Windows.Forms.GroupBox groupBox10;
        public System.Windows.Forms.GroupBox groupBox6;
        public System.Windows.Forms.Label label46;
        public System.Windows.Forms.NumericUpDown nudOrder2Qty;
        public System.Windows.Forms.Label label47;
        public System.Windows.Forms.Label label48;
        public System.Windows.Forms.Label label50;
        public System.Windows.Forms.Label label51;
        public System.Windows.Forms.NumericUpDown nudOrder2Percent;
        public System.Windows.Forms.GroupBox groupBox11;
        public System.Windows.Forms.Label label52;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.NumericUpDown nudOrder3Qty;
        public System.Windows.Forms.Label label27;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label21;
        public System.Windows.Forms.NumericUpDown nudOrder3Percent;
        public System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.GroupBox groupBox7;
        public System.Windows.Forms.Label label25;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.NumericUpDown nudOrder1Price;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label label75;
        public System.Windows.Forms.GroupBox groupBox22;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label label79;
        public System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        public System.Windows.Forms.GroupBox groupBox23;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Label label81;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.GroupBox groupBox24;
        public System.Windows.Forms.Label label82;
        public System.Windows.Forms.Label label83;
        public System.Windows.Forms.NumericUpDown nudOrder10Qty;
        public System.Windows.Forms.Label label84;
        public System.Windows.Forms.Label label85;
        public System.Windows.Forms.Label label86;
        public System.Windows.Forms.NumericUpDown nudOrder10Percent;
        public System.Windows.Forms.GroupBox groupBox8;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.NumericUpDown nudOrder8Qty;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label label19;
        public System.Windows.Forms.Label label20;
        public System.Windows.Forms.NumericUpDown nudOrder8Percent;
        public System.Windows.Forms.GroupBox groupBox9;
        public System.Windows.Forms.Label label22;
        public System.Windows.Forms.Label label26;
        public System.Windows.Forms.NumericUpDown nudOrder9Qty;
        public System.Windows.Forms.Label label28;
        public System.Windows.Forms.Label label29;
        public System.Windows.Forms.Label label30;
        public System.Windows.Forms.NumericUpDown nudOrder9Percent;
        public System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Label label40;
        public System.Windows.Forms.GroupBox groupBox14;
        public System.Windows.Forms.Label label41;
        public System.Windows.Forms.NumericUpDown nudOrder12Percent;
        public System.Windows.Forms.NumericUpDown nudOrder12Qty;
        public System.Windows.Forms.Label label56;
        public System.Windows.Forms.Label label60;
        public System.Windows.Forms.Label label62;
        public System.Windows.Forms.GroupBox groupBox21;
        public System.Windows.Forms.Label label63;
        public System.Windows.Forms.NumericUpDown nudOrder11Percent;
        public System.Windows.Forms.NumericUpDown nudOrder11Qty;
        public System.Windows.Forms.Label label67;
        public System.Windows.Forms.Label label72;
        public System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label label5;
    }
}

