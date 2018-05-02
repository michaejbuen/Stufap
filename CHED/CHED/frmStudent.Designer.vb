<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim params As CreateParams = MyBase.CreateParams
            params.ExStyle = params.ExStyle Or &H2000000
            Return params
        End Get
    End Property



    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStudent))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblAMPM = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pi_panel = New System.Windows.Forms.Panel()
        Me.txt_mailad = New System.Windows.Forms.RichTextBox()
        Me.txt_tdis = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_hyr = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.SType = New System.Windows.Forms.Label()
        Me.lblSAdd = New System.Windows.Forms.Label()
        Me.lblSName = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_ctzn = New System.Windows.Forms.TextBox()
        Me.txt_zip = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_mobile = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_fname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_mname = New System.Windows.Forms.TextBox()
        Me.txt_lname = New System.Windows.Forms.TextBox()
        Me.dtp_dob = New System.Windows.Forms.DateTimePicker()
        Me.rbt_male = New System.Windows.Forms.RadioButton()
        Me.rbt_married = New System.Windows.Forms.RadioButton()
        Me.rbt_female = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rbt_single = New System.Windows.Forms.RadioButton()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.add_stpi = New System.Windows.Forms.Button()
        Me.tab = New System.Windows.Forms.Panel()
        Me.add_stfb = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.fb_panel = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbt_fdec = New System.Windows.Forms.RadioButton()
        Me.rbt_fliv = New System.Windows.Forms.RadioButton()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.txt_faeduc = New System.Windows.Forms.TextBox()
        Me.txt_faoc = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txt_fainc = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txt_faname = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pi_panel.SuspendLayout()
        Me.fb_panel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Myriad Pro Light", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(34, 719)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(449, 26)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Student Financial Assistance Programs (StuFAPs)"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(1294, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "_"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblAMPM
        '
        Me.lblAMPM.AutoSize = True
        Me.lblAMPM.BackColor = System.Drawing.Color.Transparent
        Me.lblAMPM.Font = New System.Drawing.Font("Palatino Linotype", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAMPM.ForeColor = System.Drawing.Color.White
        Me.lblAMPM.Image = CType(resources.GetObject("lblAMPM.Image"), System.Drawing.Image)
        Me.lblAMPM.Location = New System.Drawing.Point(1266, 709)
        Me.lblAMPM.Name = "lblAMPM"
        Me.lblAMPM.Size = New System.Drawing.Size(67, 38)
        Me.lblAMPM.TabIndex = 15
        Me.lblAMPM.Text = "AM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(1242, 709)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 38)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "|"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Palatino Linotype", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Image = CType(resources.GetObject("lblTime.Image"), System.Drawing.Image)
        Me.lblTime.Location = New System.Drawing.Point(1129, 709)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(101, 38)
        Me.lblTime.TabIndex = 13
        Me.lblTime.Text = "Label1"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Myriad Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Image = CType(resources.GetObject("lblDate.Image"), System.Drawing.Image)
        Me.lblDate.Location = New System.Drawing.Point(1142, 122)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(51, 18)
        Me.lblDate.TabIndex = 12
        Me.lblDate.Text = "Label1"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.MidnightBlue
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(0, 692)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1367, 77)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.MidnightBlue
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1145, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(221, 196)
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1175, 196)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(32, 224)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(1302, 444)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 18
        Me.PictureBox4.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(50, 230)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 130)
        Me.Button2.TabIndex = 19
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Myriad Pro Light", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(197, 254)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 29)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Add Student"
        '
        'pi_panel
        '
        Me.pi_panel.BackColor = System.Drawing.Color.Transparent
        Me.pi_panel.BackgroundImage = CType(resources.GetObject("pi_panel.BackgroundImage"), System.Drawing.Image)
        Me.pi_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pi_panel.Controls.Add(Me.txt_mailad)
        Me.pi_panel.Controls.Add(Me.txt_tdis)
        Me.pi_panel.Controls.Add(Me.Label17)
        Me.pi_panel.Controls.Add(Me.txt_hyr)
        Me.pi_panel.Controls.Add(Me.Label18)
        Me.pi_panel.Controls.Add(Me.SType)
        Me.pi_panel.Controls.Add(Me.lblSAdd)
        Me.pi_panel.Controls.Add(Me.lblSName)
        Me.pi_panel.Controls.Add(Me.Button4)
        Me.pi_panel.Controls.Add(Me.Label15)
        Me.pi_panel.Controls.Add(Me.Label14)
        Me.pi_panel.Controls.Add(Me.Label16)
        Me.pi_panel.Controls.Add(Me.txt_ctzn)
        Me.pi_panel.Controls.Add(Me.txt_zip)
        Me.pi_panel.Controls.Add(Me.Label9)
        Me.pi_panel.Controls.Add(Me.txt_email)
        Me.pi_panel.Controls.Add(Me.Label10)
        Me.pi_panel.Controls.Add(Me.txt_mobile)
        Me.pi_panel.Controls.Add(Me.Label11)
        Me.pi_panel.Controls.Add(Me.Label12)
        Me.pi_panel.Controls.Add(Me.Label13)
        Me.pi_panel.Controls.Add(Me.txt_fname)
        Me.pi_panel.Controls.Add(Me.Label5)
        Me.pi_panel.Controls.Add(Me.Label6)
        Me.pi_panel.Controls.Add(Me.Label7)
        Me.pi_panel.Controls.Add(Me.txt_mname)
        Me.pi_panel.Controls.Add(Me.txt_lname)
        Me.pi_panel.Controls.Add(Me.dtp_dob)
        Me.pi_panel.Controls.Add(Me.rbt_male)
        Me.pi_panel.Controls.Add(Me.rbt_married)
        Me.pi_panel.Controls.Add(Me.rbt_female)
        Me.pi_panel.Controls.Add(Me.Label4)
        Me.pi_panel.Controls.Add(Me.rbt_single)
        Me.pi_panel.Controls.Add(Me.Label40)
        Me.pi_panel.Controls.Add(Me.Label8)
        Me.pi_panel.Font = New System.Drawing.Font("Myriad Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pi_panel.ForeColor = System.Drawing.Color.White
        Me.pi_panel.Location = New System.Drawing.Point(202, 296)
        Me.pi_panel.Name = "pi_panel"
        Me.pi_panel.Size = New System.Drawing.Size(1098, 348)
        Me.pi_panel.TabIndex = 21
        '
        'txt_mailad
        '
        Me.txt_mailad.Location = New System.Drawing.Point(226, 167)
        Me.txt_mailad.Name = "txt_mailad"
        Me.txt_mailad.Size = New System.Drawing.Size(479, 32)
        Me.txt_mailad.TabIndex = 63
        Me.txt_mailad.Text = ""
        '
        'txt_tdis
        '
        Me.txt_tdis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tdis.Location = New System.Drawing.Point(718, 304)
        Me.txt_tdis.Name = "txt_tdis"
        Me.txt_tdis.Size = New System.Drawing.Size(317, 22)
        Me.txt_tdis.TabIndex = 62
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Myriad Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(496, 306)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(209, 18)
        Me.Label17.TabIndex = 60
        Me.Label17.Text = "Type of Disability (If applicable):"
        '
        'txt_hyr
        '
        Me.txt_hyr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hyr.Location = New System.Drawing.Point(172, 304)
        Me.txt_hyr.Name = "txt_hyr"
        Me.txt_hyr.Size = New System.Drawing.Size(294, 22)
        Me.txt_hyr.TabIndex = 61
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Myriad Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(36, 310)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(127, 18)
        Me.Label18.TabIndex = 59
        Me.Label18.Text = "Higher Grade/Year:"
        '
        'SType
        '
        Me.SType.AutoSize = True
        Me.SType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SType.Location = New System.Drawing.Point(633, 250)
        Me.SType.Name = "SType"
        Me.SType.Size = New System.Drawing.Size(11, 16)
        Me.SType.TabIndex = 58
        Me.SType.Text = "."
        '
        'lblSAdd
        '
        Me.lblSAdd.AutoSize = True
        Me.lblSAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSAdd.Location = New System.Drawing.Point(149, 277)
        Me.lblSAdd.Name = "lblSAdd"
        Me.lblSAdd.Size = New System.Drawing.Size(11, 16)
        Me.lblSAdd.TabIndex = 57
        Me.lblSAdd.Text = "."
        '
        'lblSName
        '
        Me.lblSName.AutoSize = True
        Me.lblSName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSName.Location = New System.Drawing.Point(135, 250)
        Me.lblSName.Name = "lblSName"
        Me.lblSName.Size = New System.Drawing.Size(11, 16)
        Me.lblSName.TabIndex = 56
        Me.lblSName.Text = "."
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button4.Location = New System.Drawing.Point(39, 211)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(246, 24)
        Me.Button4.TabIndex = 55
        Me.Button4.Text = "Select School"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Myriad Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(539, 250)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(85, 18)
        Me.Label15.TabIndex = 54
        Me.Label15.Text = "School Type:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Myriad Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(36, 250)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 18)
        Me.Label14.TabIndex = 53
        Me.Label14.Text = "School Name:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Myriad Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(36, 277)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(106, 18)
        Me.Label16.TabIndex = 52
        Me.Label16.Text = "School Address:"
        '
        'txt_ctzn
        '
        Me.txt_ctzn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ctzn.Location = New System.Drawing.Point(138, 119)
        Me.txt_ctzn.Name = "txt_ctzn"
        Me.txt_ctzn.Size = New System.Drawing.Size(147, 22)
        Me.txt_ctzn.TabIndex = 48
        '
        'txt_zip
        '
        Me.txt_zip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_zip.Location = New System.Drawing.Point(819, 164)
        Me.txt_zip.Name = "txt_zip"
        Me.txt_zip.Size = New System.Drawing.Size(98, 22)
        Me.txt_zip.TabIndex = 47
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Myriad Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(35, 122)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 18)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Citizenship:"
        '
        'txt_email
        '
        Me.txt_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(819, 115)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(253, 22)
        Me.txt_email.TabIndex = 50
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Myriad Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(369, 121)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 18)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Mobile Number:"
        '
        'txt_mobile
        '
        Me.txt_mobile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mobile.Location = New System.Drawing.Point(487, 118)
        Me.txt_mobile.Name = "txt_mobile"
        Me.txt_mobile.Size = New System.Drawing.Size(163, 22)
        Me.txt_mobile.TabIndex = 49
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Myriad Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(704, 117)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 18)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "E-mail Address:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Myriad Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(740, 167)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 18)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Zip Code:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Myriad Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(36, 167)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(184, 18)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "Permanent Mailing Address:"
        '
        'txt_fname
        '
        Me.txt_fname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fname.Location = New System.Drawing.Point(138, 21)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.Size = New System.Drawing.Size(198, 22)
        Me.txt_fname.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Myriad Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(36, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 18)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Date of Birth:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Myriad Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(369, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 18)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Sex:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Myriad Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(617, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 18)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Civil Status:"
        '
        'txt_mname
        '
        Me.txt_mname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mname.Location = New System.Drawing.Point(484, 20)
        Me.txt_mname.Name = "txt_mname"
        Me.txt_mname.Size = New System.Drawing.Size(198, 22)
        Me.txt_mname.TabIndex = 36
        '
        'txt_lname
        '
        Me.txt_lname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lname.Location = New System.Drawing.Point(797, 20)
        Me.txt_lname.Name = "txt_lname"
        Me.txt_lname.Size = New System.Drawing.Size(198, 22)
        Me.txt_lname.TabIndex = 35
        '
        'dtp_dob
        '
        Me.dtp_dob.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_dob.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_dob.Location = New System.Drawing.Point(138, 71)
        Me.dtp_dob.Name = "dtp_dob"
        Me.dtp_dob.Size = New System.Drawing.Size(198, 22)
        Me.dtp_dob.TabIndex = 37
        '
        'rbt_male
        '
        Me.rbt_male.AutoSize = True
        Me.rbt_male.Font = New System.Drawing.Font("Myriad Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbt_male.ForeColor = System.Drawing.Color.White
        Me.rbt_male.Location = New System.Drawing.Point(409, 73)
        Me.rbt_male.Name = "rbt_male"
        Me.rbt_male.Size = New System.Drawing.Size(57, 22)
        Me.rbt_male.TabIndex = 38
        Me.rbt_male.TabStop = True
        Me.rbt_male.Text = "Male"
        Me.rbt_male.UseVisualStyleBackColor = True
        '
        'rbt_married
        '
        Me.rbt_married.AutoSize = True
        Me.rbt_married.Font = New System.Drawing.Font("Myriad Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbt_married.ForeColor = System.Drawing.Color.White
        Me.rbt_married.Location = New System.Drawing.Point(770, 72)
        Me.rbt_married.Name = "rbt_married"
        Me.rbt_married.Size = New System.Drawing.Size(75, 22)
        Me.rbt_married.TabIndex = 41
        Me.rbt_married.TabStop = True
        Me.rbt_married.Text = "Married"
        Me.rbt_married.UseVisualStyleBackColor = True
        '
        'rbt_female
        '
        Me.rbt_female.AutoSize = True
        Me.rbt_female.Font = New System.Drawing.Font("Myriad Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbt_female.ForeColor = System.Drawing.Color.White
        Me.rbt_female.Location = New System.Drawing.Point(480, 73)
        Me.rbt_female.Name = "rbt_female"
        Me.rbt_female.Size = New System.Drawing.Size(73, 22)
        Me.rbt_female.TabIndex = 39
        Me.rbt_female.TabStop = True
        Me.rbt_female.Text = "Female"
        Me.rbt_female.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Myriad Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(369, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 18)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Middle Name:"
        '
        'rbt_single
        '
        Me.rbt_single.AutoSize = True
        Me.rbt_single.Font = New System.Drawing.Font("Myriad Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbt_single.ForeColor = System.Drawing.Color.White
        Me.rbt_single.Location = New System.Drawing.Point(699, 73)
        Me.rbt_single.Name = "rbt_single"
        Me.rbt_single.Size = New System.Drawing.Size(65, 22)
        Me.rbt_single.TabIndex = 40
        Me.rbt_single.TabStop = True
        Me.rbt_single.Text = "Single"
        Me.rbt_single.UseVisualStyleBackColor = True
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Myriad Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.White
        Me.Label40.Location = New System.Drawing.Point(35, 25)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(79, 18)
        Me.Label40.TabIndex = 29
        Me.Label40.Text = "First Name:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Myriad Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(715, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 18)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Last Name:"
        '
        'add_stpi
        '
        Me.add_stpi.BackColor = System.Drawing.Color.Transparent
        Me.add_stpi.BackgroundImage = CType(resources.GetObject("add_stpi.BackgroundImage"), System.Drawing.Image)
        Me.add_stpi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.add_stpi.FlatAppearance.BorderSize = 0
        Me.add_stpi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_stpi.Font = New System.Drawing.Font("Myriad Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_stpi.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.add_stpi.Location = New System.Drawing.Point(57, 382)
        Me.add_stpi.Name = "add_stpi"
        Me.add_stpi.Size = New System.Drawing.Size(134, 31)
        Me.add_stpi.TabIndex = 22
        Me.add_stpi.Text = "Personal Info"
        Me.add_stpi.UseVisualStyleBackColor = False
        '
        'tab
        '
        Me.tab.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.tab.Location = New System.Drawing.Point(47, 382)
        Me.tab.Name = "tab"
        Me.tab.Size = New System.Drawing.Size(5, 31)
        Me.tab.TabIndex = 63
        '
        'add_stfb
        '
        Me.add_stfb.BackColor = System.Drawing.Color.Transparent
        Me.add_stfb.BackgroundImage = CType(resources.GetObject("add_stfb.BackgroundImage"), System.Drawing.Image)
        Me.add_stfb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.add_stfb.FlatAppearance.BorderSize = 0
        Me.add_stfb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_stfb.Font = New System.Drawing.Font("Myriad Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_stfb.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.add_stfb.Location = New System.Drawing.Point(57, 419)
        Me.add_stfb.Name = "add_stfb"
        Me.add_stfb.Size = New System.Drawing.Size(134, 31)
        Me.add_stfb.TabIndex = 64
        Me.add_stfb.Text = "Family Background"
        Me.add_stfb.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Myriad Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button6.Location = New System.Drawing.Point(57, 451)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(134, 31)
        Me.Button6.TabIndex = 65
        Me.Button6.Text = "%%"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'fb_panel
        '
        Me.fb_panel.BackColor = System.Drawing.Color.Transparent
        Me.fb_panel.BackgroundImage = CType(resources.GetObject("fb_panel.BackgroundImage"), System.Drawing.Image)
        Me.fb_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.fb_panel.Controls.Add(Me.GroupBox1)
        Me.fb_panel.Controls.Add(Me.GroupBox3)
        Me.fb_panel.Font = New System.Drawing.Font("Myriad Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fb_panel.ForeColor = System.Drawing.Color.White
        Me.fb_panel.Location = New System.Drawing.Point(202, 296)
        Me.fb_panel.Name = "fb_panel"
        Me.fb_panel.Size = New System.Drawing.Size(1098, 348)
        Me.fb_panel.TabIndex = 66
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.RichTextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Location = New System.Drawing.Point(558, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(507, 297)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Myriad Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(232, 34)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(88, 22)
        Me.RadioButton1.TabIndex = 57
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Deceased"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Myriad Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(156, 35)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(64, 22)
        Me.RadioButton2.TabIndex = 56
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Living"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Myriad Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(27, 39)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(57, 18)
        Me.Label19.TabIndex = 55
        Me.Label19.Text = "Mother:"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Location = New System.Drawing.Point(170, 102)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(306, 42)
        Me.RichTextBox2.TabIndex = 54
        Me.RichTextBox2.Text = ""
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(183, 203)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(293, 22)
        Me.TextBox1.TabIndex = 53
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(170, 167)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(306, 22)
        Me.TextBox2.TabIndex = 52
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Myriad Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(27, 245)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(174, 18)
        Me.Label20.TabIndex = 50
        Me.Label20.Text = "Total Parent Gross Income:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Myriad Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(27, 207)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(148, 18)
        Me.Label21.TabIndex = 49
        Me.Label21.Text = "Education Attainment:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Myriad Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(27, 169)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(84, 18)
        Me.Label22.TabIndex = 48
        Me.Label22.Text = "Occupation:"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(232, 243)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(109, 22)
        Me.TextBox3.TabIndex = 47
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Myriad Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(27, 104)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(61, 18)
        Me.Label23.TabIndex = 46
        Me.Label23.Text = "Address:"
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(170, 69)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(306, 22)
        Me.TextBox4.TabIndex = 45
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Myriad Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(27, 71)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(49, 18)
        Me.Label24.TabIndex = 41
        Me.Label24.Text = "Name:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbt_fdec)
        Me.GroupBox3.Controls.Add(Me.rbt_fliv)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.RichTextBox1)
        Me.GroupBox3.Controls.Add(Me.txt_faeduc)
        Me.GroupBox3.Controls.Add(Me.txt_faoc)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.txt_fainc)
        Me.GroupBox3.Controls.Add(Me.Label29)
        Me.GroupBox3.Controls.Add(Me.txt_faname)
        Me.GroupBox3.Controls.Add(Me.Label30)
        Me.GroupBox3.Location = New System.Drawing.Point(33, 26)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(507, 297)
        Me.GroupBox3.TabIndex = 45
        Me.GroupBox3.TabStop = False
        '
        'rbt_fdec
        '
        Me.rbt_fdec.AutoSize = True
        Me.rbt_fdec.Font = New System.Drawing.Font("Myriad Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbt_fdec.Location = New System.Drawing.Point(232, 34)
        Me.rbt_fdec.Name = "rbt_fdec"
        Me.rbt_fdec.Size = New System.Drawing.Size(88, 22)
        Me.rbt_fdec.TabIndex = 57
        Me.rbt_fdec.TabStop = True
        Me.rbt_fdec.Text = "Deceased"
        Me.rbt_fdec.UseVisualStyleBackColor = True
        '
        'rbt_fliv
        '
        Me.rbt_fliv.AutoSize = True
        Me.rbt_fliv.Font = New System.Drawing.Font("Myriad Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbt_fliv.Location = New System.Drawing.Point(156, 35)
        Me.rbt_fliv.Name = "rbt_fliv"
        Me.rbt_fliv.Size = New System.Drawing.Size(64, 22)
        Me.rbt_fliv.TabIndex = 56
        Me.rbt_fliv.TabStop = True
        Me.rbt_fliv.Text = "Living"
        Me.rbt_fliv.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Myriad Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(27, 39)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(50, 18)
        Me.Label25.TabIndex = 55
        Me.Label25.Text = "Father:"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(170, 108)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(306, 42)
        Me.RichTextBox1.TabIndex = 54
        Me.RichTextBox1.Text = ""
        '
        'txt_faeduc
        '
        Me.txt_faeduc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_faeduc.Location = New System.Drawing.Point(183, 205)
        Me.txt_faeduc.Name = "txt_faeduc"
        Me.txt_faeduc.Size = New System.Drawing.Size(293, 22)
        Me.txt_faeduc.TabIndex = 53
        '
        'txt_faoc
        '
        Me.txt_faoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_faoc.Location = New System.Drawing.Point(170, 167)
        Me.txt_faoc.Name = "txt_faoc"
        Me.txt_faoc.Size = New System.Drawing.Size(306, 22)
        Me.txt_faoc.TabIndex = 52
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Myriad Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(27, 245)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(174, 18)
        Me.Label26.TabIndex = 50
        Me.Label26.Text = "Total Parent Gross Income:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Myriad Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(27, 207)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(148, 18)
        Me.Label27.TabIndex = 49
        Me.Label27.Text = "Education Attainment:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Myriad Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(27, 169)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(84, 18)
        Me.Label28.TabIndex = 48
        Me.Label28.Text = "Occupation:"
        '
        'txt_fainc
        '
        Me.txt_fainc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fainc.Location = New System.Drawing.Point(232, 243)
        Me.txt_fainc.Name = "txt_fainc"
        Me.txt_fainc.Size = New System.Drawing.Size(116, 22)
        Me.txt_fainc.TabIndex = 47
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Myriad Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(27, 104)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(61, 18)
        Me.Label29.TabIndex = 46
        Me.Label29.Text = "Address:"
        '
        'txt_faname
        '
        Me.txt_faname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_faname.Location = New System.Drawing.Point(170, 69)
        Me.txt_faname.Name = "txt_faname"
        Me.txt_faname.Size = New System.Drawing.Size(306, 22)
        Me.txt_faname.TabIndex = 45
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Myriad Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(27, 71)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(49, 18)
        Me.Label30.TabIndex = 41
        Me.Label30.Text = "Name:"
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.Location = New System.Drawing.Point(1327, 12)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(27, 23)
        Me.Button7.TabIndex = 16
        Me.Button7.Text = "X"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'frmStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.fb_panel)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.add_stfb)
        Me.Controls.Add(Me.tab)
        Me.Controls.Add(Me.add_stpi)
        Me.Controls.Add(Me.pi_panel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblAMPM)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmStudent"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pi_panel.ResumeLayout(False)
        Me.pi_panel.PerformLayout()
        Me.fb_panel.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lblAMPM As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents pi_panel As Panel
    Friend WithEvents txt_ctzn As TextBox
    Friend WithEvents txt_zip As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_mobile As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_fname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_mname As TextBox
    Friend WithEvents txt_lname As TextBox
    Friend WithEvents dtp_dob As DateTimePicker
    Friend WithEvents rbt_male As RadioButton
    Friend WithEvents rbt_married As RadioButton
    Friend WithEvents rbt_female As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents rbt_single As RadioButton
    Friend WithEvents Label40 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents add_stpi As Button
    Friend WithEvents txt_tdis As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txt_hyr As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents SType As Label
    Friend WithEvents lblSAdd As Label
    Friend WithEvents lblSName As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents tab As Panel
    Friend WithEvents add_stfb As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents fb_panel As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label19 As Label
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rbt_fdec As RadioButton
    Friend WithEvents rbt_fliv As RadioButton
    Friend WithEvents Label25 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents txt_faeduc As TextBox
    Friend WithEvents txt_faoc As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents txt_fainc As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents txt_faname As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents txt_mailad As RichTextBox
End Class
