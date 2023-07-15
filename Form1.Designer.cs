namespace SqlApplication
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
         btnCreate = new Button();
         btnAddCar = new Button();
         btnAddExec = new Button();
         btnShowData = new Button();
         btnQuit = new Button();
         lbl1 = new Label();
         lbl2 = new Label();
         lblId = new Label();
         lblBuilt = new Label();
         lblModel = new Label();
         lblManuf = new Label();
         lblCarNo = new Label();
         splitContainer1 = new SplitContainer();
         panel1 = new Panel();
         dgv = new DataGridView();
         tbBuilt = new TextBox();
         tbModel = new TextBox();
         tbManuf = new TextBox();
         pictureBox1 = new PictureBox();
         btnDelete = new Button();
         dg1 = new DataGridView();
         imageList1 = new ImageList(components);
         ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
         splitContainer1.Panel1.SuspendLayout();
         splitContainer1.Panel2.SuspendLayout();
         splitContainer1.SuspendLayout();
         panel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
         ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
         ((System.ComponentModel.ISupportInitialize)dg1).BeginInit();
         SuspendLayout();
         // 
         // btnCreate
         // 
         btnCreate.Location = new Point(31, 114);
         btnCreate.Name = "btnCreate";
         btnCreate.Size = new Size(136, 23);
         btnCreate.TabIndex = 3;
         btnCreate.Text = "Create new Database";
         btnCreate.UseVisualStyleBackColor = true;
         btnCreate.Visible = false;
         btnCreate.Click += BtnCreate_Click;
         // 
         // btnAddCar
         // 
         btnAddCar.Location = new Point(31, 230);
         btnAddCar.Name = "btnAddCar";
         btnAddCar.Size = new Size(130, 23);
         btnAddCar.TabIndex = 4;
         btnAddCar.Text = "Add Car";
         btnAddCar.UseVisualStyleBackColor = true;
         btnAddCar.Visible = false;
         btnAddCar.Click += BtnAddCar_Click;
         // 
         // btnAddExec
         // 
         btnAddExec.Location = new Point(511, 217);
         btnAddExec.Name = "btnAddExec";
         btnAddExec.Size = new Size(96, 23);
         btnAddExec.TabIndex = 8;
         btnAddExec.Text = "Execute Add";
         btnAddExec.UseVisualStyleBackColor = true;
         btnAddExec.Click += BtnAddExec_Click;
         // 
         // btnShowData
         // 
         btnShowData.Location = new Point(31, 319);
         btnShowData.Name = "btnShowData";
         btnShowData.Size = new Size(136, 23);
         btnShowData.TabIndex = 10;
         btnShowData.Text = "Show Data";
         btnShowData.UseVisualStyleBackColor = true;
         btnShowData.Click += BtnShowData_Click;
         // 
         // btnQuit
         // 
         btnQuit.Location = new Point(31, 365);
         btnQuit.Name = "btnQuit";
         btnQuit.Size = new Size(136, 23);
         btnQuit.TabIndex = 11;
         btnQuit.Text = "Quit Program";
         btnQuit.UseVisualStyleBackColor = true;
         btnQuit.Click += BtnQuit_Click;
         // 
         // lbl1
         // 
         lbl1.AutoSize = true;
         lbl1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
         lbl1.ForeColor = Color.Black;
         lbl1.Location = new Point(31, 51);
         lbl1.MinimumSize = new Size(130, 0);
         lbl1.Name = "lbl1";
         lbl1.Size = new Size(130, 15);
         lbl1.TabIndex = 0;
         lbl1.Text = "null";
         lbl1.TextAlign = ContentAlignment.TopRight;
         lbl1.Visible = false;
         // 
         // lbl2
         // 
         lbl2.AutoSize = true;
         lbl2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
         lbl2.Location = new Point(31, 66);
         lbl2.MinimumSize = new Size(130, 0);
         lbl2.Name = "lbl2";
         lbl2.Size = new Size(130, 15);
         lbl2.TabIndex = 0;
         lbl2.Text = "null";
         lbl2.TextAlign = ContentAlignment.TopRight;
         lbl2.Visible = false;
         // 
         // lblId
         // 
         lblId.AutoSize = true;
         lblId.Location = new Point(155, 53);
         lblId.Name = "lblId";
         lblId.Size = new Size(27, 15);
         lblId.TabIndex = 0;
         lblId.Text = "null";
         // 
         // lblBuilt
         // 
         lblBuilt.AutoSize = true;
         lblBuilt.Location = new Point(57, 183);
         lblBuilt.Name = "lblBuilt";
         lblBuilt.Size = new Size(31, 15);
         lblBuilt.TabIndex = 0;
         lblBuilt.Text = "built";
         // 
         // lblModel
         // 
         lblModel.AutoSize = true;
         lblModel.Location = new Point(57, 133);
         lblModel.Name = "lblModel";
         lblModel.Size = new Size(41, 15);
         lblModel.TabIndex = 0;
         lblModel.Text = "Model";
         // 
         // lblManuf
         // 
         lblManuf.AutoSize = true;
         lblManuf.Location = new Point(57, 89);
         lblManuf.Name = "lblManuf";
         lblManuf.Size = new Size(79, 15);
         lblManuf.TabIndex = 0;
         lblManuf.Text = "Manufacturer";
         // 
         // lblCarNo
         // 
         lblCarNo.AutoSize = true;
         lblCarNo.Location = new Point(57, 52);
         lblCarNo.Name = "lblCarNo";
         lblCarNo.Size = new Size(45, 15);
         lblCarNo.TabIndex = 0;
         lblCarNo.Text = "car No.";
         // 
         // splitContainer1
         // 
         splitContainer1.Location = new Point(12, 12);
         splitContainer1.Name = "splitContainer1";
         // 
         // splitContainer1.Panel1
         // 
         splitContainer1.Panel1.Controls.Add(dgv);
         splitContainer1.Panel1.Controls.Add(panel1);
         splitContainer1.Panel1.Controls.Add(pictureBox1);
         // 
         // splitContainer1.Panel2
         // 
         splitContainer1.Panel2.Controls.Add(btnDelete);
         splitContainer1.Panel2.Controls.Add(btnAddCar);
         splitContainer1.Panel2.Controls.Add(lbl2);
         splitContainer1.Panel2.Controls.Add(btnQuit);
         splitContainer1.Panel2.Controls.Add(btnShowData);
         splitContainer1.Panel2.Controls.Add(btnCreate);
         splitContainer1.Panel2.Controls.Add(lbl1);
         splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
         splitContainer1.Size = new Size(1237, 615);
         splitContainer1.SplitterDistance = 984;
         splitContainer1.TabIndex = 0;
         // 
         // panel1
         // 
         panel1.Controls.Add(btnAddExec);
         panel1.Controls.Add(tbBuilt);
         panel1.Controls.Add(tbModel);
         panel1.Controls.Add(tbManuf);
         panel1.Controls.Add(lblId);
         panel1.Controls.Add(lblBuilt);
         panel1.Controls.Add(lblModel);
         panel1.Controls.Add(lblManuf);
         panel1.Controls.Add(lblCarNo);
         panel1.Location = new Point(304, 33);
         panel1.Name = "panel1";
         panel1.Size = new Size(664, 338);
         panel1.TabIndex = 0;
         panel1.Visible = false;
         // 
         // dgv
         // 
         dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         dgv.Location = new Point(27, 16);
         dgv.Name = "dgv";
         dgv.RowTemplate.Height = 25;
         dgv.Size = new Size(426, 326);
         dgv.TabIndex = 1;
         // 
         // tbBuilt
         // 
         tbBuilt.Location = new Point(155, 175);
         tbBuilt.MinimumSize = new Size(80, 0);
         tbBuilt.Name = "tbBuilt";
         tbBuilt.Size = new Size(80, 23);
         tbBuilt.TabIndex = 6;
         // 
         // tbModel
         // 
         tbModel.Location = new Point(155, 125);
         tbModel.Name = "tbModel";
         tbModel.Size = new Size(150, 23);
         tbModel.TabIndex = 5;
         // 
         // tbManuf
         // 
         tbManuf.Location = new Point(155, 81);
         tbManuf.MinimumSize = new Size(150, 0);
         tbManuf.Name = "tbManuf";
         tbManuf.Size = new Size(150, 23);
         tbManuf.TabIndex = 4;
         // 
         // pictureBox1
         // 
         pictureBox1.Anchor = AnchorStyles.None;
         pictureBox1.BackColor = SystemColors.Control;
         pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
         pictureBox1.Location = new Point(141, 201);
         pictureBox1.Name = "pictureBox1";
         pictureBox1.Size = new Size(736, 378);
         pictureBox1.TabIndex = 0;
         pictureBox1.TabStop = false;
         pictureBox1.Click += pictureBox1_Click;
         // 
         // btnDelete
         // 
         btnDelete.Location = new Point(31, 274);
         btnDelete.Name = "btnDelete";
         btnDelete.Size = new Size(136, 23);
         btnDelete.TabIndex = 9;
         btnDelete.Text = "Delete Car";
         btnDelete.UseVisualStyleBackColor = true;
         btnDelete.Visible = false;
         btnDelete.Click += btnDelete_Click;
         // 
         // dg1
         // 
         dg1.AllowUserToAddRows = false;
         dg1.AllowUserToDeleteRows = false;
         dg1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
         dg1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         dg1.Location = new Point(8, 11);
         dg1.Name = "dg1";
         dg1.ReadOnly = true;
         dg1.RowHeadersVisible = false;
         dg1.RowTemplate.Height = 25;
         dg1.Size = new Size(474, 339);
         dg1.TabIndex = 0;
         dg1.Visible = false;
         // 
         // imageList1
         // 
         imageList1.ColorDepth = ColorDepth.Depth8Bit;
         imageList1.ImageSize = new Size(16, 16);
         imageList1.TransparentColor = Color.Transparent;
         // 
         // Form1
         // 
         AutoScaleDimensions = new SizeF(7F, 15F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(1261, 639);
         Controls.Add(splitContainer1);
         Name = "Form1";
         StartPosition = FormStartPosition.CenterScreen;
         Text = "Form1";
         splitContainer1.Panel1.ResumeLayout(false);
         splitContainer1.Panel2.ResumeLayout(false);
         splitContainer1.Panel2.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
         splitContainer1.ResumeLayout(false);
         panel1.ResumeLayout(false);
         panel1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
         ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
         ((System.ComponentModel.ISupportInitialize)dg1).EndInit();
         ResumeLayout(false);
      }

      #endregion
      private Label lbl1;
      private Label lbl2;
      private Button btnCreate;
      private Button btnShowData;
      private Button btnQuit;
      private SplitContainer splitContainer1;
      private DataGridView dg1;
      private Panel panel1;
      private Label lblBuilt;
      private Label lblModel;
      private Label lblManuf;
      private Label lblCarNo;
      private TextBox tbBuilt;
      private TextBox tbModel;
      private TextBox tbManuf;
      private Label lblId;
      private Button btnAddCar;
      private Button btnAddExec;
      private Button btnDelete;
      private PictureBox pictureBox1;
      private ImageList imageList1;
      private DataGridView dgv;
   }
}