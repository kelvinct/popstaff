<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim IDLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim NamechnLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim AccessIDLabel As System.Windows.Forms.Label
        Dim Ext_NoLabel As System.Windows.Forms.Label
        Dim LocationLabel As System.Windows.Forms.Label
        Dim PCIPLabel As System.Windows.Forms.Label
        Dim PCIP1Label As System.Windows.Forms.Label
        Dim PCIP2Label As System.Windows.Forms.Label
        Dim PCIP3Label As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim OfficeEmailLabel1 As System.Windows.Forms.Label
        Dim Email1Label As System.Windows.Forms.Label
        Me.Staff = New Popstaff.staff()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.StaffBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.NamechnTextBox = New System.Windows.Forms.TextBox()
        Me.AccessIDTextBox = New System.Windows.Forms.TextBox()
        Me.LocationTextBox = New System.Windows.Forms.TextBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox3 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox4 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox5 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox6 = New System.Windows.Forms.MaskedTextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.OfficeEmailTextBox = New System.Windows.Forms.TextBox()
        Me.Email1TextBox = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        IDLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        NamechnLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        AccessIDLabel = New System.Windows.Forms.Label()
        Ext_NoLabel = New System.Windows.Forms.Label()
        LocationLabel = New System.Windows.Forms.Label()
        PCIPLabel = New System.Windows.Forms.Label()
        PCIP1Label = New System.Windows.Forms.Label()
        PCIP2Label = New System.Windows.Forms.Label()
        PCIP3Label = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        OfficeEmailLabel1 = New System.Windows.Forms.Label()
        Email1Label = New System.Windows.Forms.Label()
        CType(Me.Staff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StaffBindingNavigator.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Staff
        '
        Me.Staff.DataSetName = "staff"
        Me.Staff.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "staff"
        Me.StaffBindingSource.DataSource = Me.Staff
        '
        'StaffBindingNavigator
        '
        Me.StaffBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.StaffBindingNavigator.BindingSource = Me.StaffBindingSource
        Me.StaffBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.StaffBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.StaffBindingNavigator.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.StaffBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.StaffBindingNavigatorSaveItem})
        Me.StaffBindingNavigator.Location = New System.Drawing.Point(0, 35)
        Me.StaffBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.StaffBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.StaffBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.StaffBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.StaffBindingNavigator.Name = "StaffBindingNavigator"
        Me.StaffBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.StaffBindingNavigator.Size = New System.Drawing.Size(817, 35)
        Me.StaffBindingNavigator.TabIndex = 0
        Me.StaffBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 27)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 27)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 30)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 35)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(63, 27)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 30)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 27)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 27)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 30)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 32)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 27)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'StaffBindingNavigatorSaveItem
        '
        Me.StaffBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StaffBindingNavigatorSaveItem.Image = CType(resources.GetObject("StaffBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.StaffBindingNavigatorSaveItem.Name = "StaffBindingNavigatorSaveItem"
        Me.StaffBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 27)
        Me.StaffBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        IDLabel.Location = New System.Drawing.Point(20, 89)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(36, 21)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "ID", True))
        Me.IDTextBox.Enabled = False
        Me.IDTextBox.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(144, 77)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(247, 33)
        Me.IDTextBox.TabIndex = 2
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        NameLabel.Location = New System.Drawing.Point(20, 128)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(58, 21)
        NameLabel.TabIndex = 3
        NameLabel.Text = "name:"
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "name", True))
        Me.NameTextBox.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(144, 116)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(247, 33)
        Me.NameTextBox.TabIndex = 4
        '
        'NamechnLabel
        '
        NamechnLabel.AutoSize = True
        NamechnLabel.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        NamechnLabel.Location = New System.Drawing.Point(20, 173)
        NamechnLabel.Name = "NamechnLabel"
        NamechnLabel.Size = New System.Drawing.Size(87, 21)
        NamechnLabel.TabIndex = 5
        NamechnLabel.Text = "namechn:"
        '
        'NamechnTextBox
        '
        Me.NamechnTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "namechn", True))
        Me.NamechnTextBox.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.NamechnTextBox.Location = New System.Drawing.Point(144, 161)
        Me.NamechnTextBox.Name = "NamechnTextBox"
        Me.NamechnTextBox.Size = New System.Drawing.Size(247, 33)
        Me.NamechnTextBox.TabIndex = 6
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        PhoneLabel.Location = New System.Drawing.Point(20, 370)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(65, 21)
        PhoneLabel.TabIndex = 11
        PhoneLabel.Text = "Phone:"
        '
        'AccessIDLabel
        '
        AccessIDLabel.AutoSize = True
        AccessIDLabel.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        AccessIDLabel.Location = New System.Drawing.Point(20, 418)
        AccessIDLabel.Name = "AccessIDLabel"
        AccessIDLabel.Size = New System.Drawing.Size(98, 21)
        AccessIDLabel.TabIndex = 13
        AccessIDLabel.Text = "Access ID:"
        '
        'AccessIDTextBox
        '
        Me.AccessIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "AccessID", True))
        Me.AccessIDTextBox.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.AccessIDTextBox.Location = New System.Drawing.Point(144, 406)
        Me.AccessIDTextBox.Name = "AccessIDTextBox"
        Me.AccessIDTextBox.Size = New System.Drawing.Size(247, 33)
        Me.AccessIDTextBox.TabIndex = 16
        '
        'Ext_NoLabel
        '
        Ext_NoLabel.AutoSize = True
        Ext_NoLabel.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Ext_NoLabel.Location = New System.Drawing.Point(18, 464)
        Ext_NoLabel.Name = "Ext_NoLabel"
        Ext_NoLabel.Size = New System.Drawing.Size(71, 21)
        Ext_NoLabel.TabIndex = 15
        Ext_NoLabel.Text = "Ext No:"
        '
        'LocationLabel
        '
        LocationLabel.AutoSize = True
        LocationLabel.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        LocationLabel.Location = New System.Drawing.Point(18, 504)
        LocationLabel.Name = "LocationLabel"
        LocationLabel.Size = New System.Drawing.Size(85, 21)
        LocationLabel.TabIndex = 17
        LocationLabel.Text = "Location:"
        '
        'LocationTextBox
        '
        Me.LocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Location", True))
        Me.LocationTextBox.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LocationTextBox.Location = New System.Drawing.Point(144, 501)
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.Size = New System.Drawing.Size(247, 33)
        Me.LocationTextBox.TabIndex = 22
        '
        'PCIPLabel
        '
        PCIPLabel.AutoSize = True
        PCIPLabel.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        PCIPLabel.Location = New System.Drawing.Point(24, 211)
        PCIPLabel.Name = "PCIPLabel"
        PCIPLabel.Size = New System.Drawing.Size(57, 21)
        PCIPLabel.TabIndex = 19
        PCIPLabel.Text = "PCIP:"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Phone", True))
        Me.MaskedTextBox1.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(144, 358)
        Me.MaskedTextBox1.Mask = "(000)9000-0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(247, 33)
        Me.MaskedTextBox1.TabIndex = 14
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Ext_No", True))
        Me.MaskedTextBox2.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.MaskedTextBox2.Location = New System.Drawing.Point(144, 452)
        Me.MaskedTextBox2.Mask = "(00)"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(247, 33)
        Me.MaskedTextBox2.TabIndex = 18
        '
        'MaskedTextBox3
        '
        Me.MaskedTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "PCIP", True))
        Me.MaskedTextBox3.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.MaskedTextBox3.Location = New System.Drawing.Point(144, 199)
        Me.MaskedTextBox3.Mask = "000.000.000.000"
        Me.MaskedTextBox3.Name = "MaskedTextBox3"
        Me.MaskedTextBox3.Size = New System.Drawing.Size(247, 33)
        Me.MaskedTextBox3.TabIndex = 8
        '
        'PCIP1Label
        '
        PCIP1Label.AutoSize = True
        PCIP1Label.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        PCIP1Label.Location = New System.Drawing.Point(415, 202)
        PCIP1Label.Name = "PCIP1Label"
        PCIP1Label.Size = New System.Drawing.Size(67, 21)
        PCIP1Label.TabIndex = 22
        PCIP1Label.Text = "PCIP1:"
        '
        'PCIP2Label
        '
        PCIP2Label.AutoSize = True
        PCIP2Label.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        PCIP2Label.Location = New System.Drawing.Point(22, 250)
        PCIP2Label.Name = "PCIP2Label"
        PCIP2Label.Size = New System.Drawing.Size(67, 21)
        PCIP2Label.TabIndex = 23
        PCIP2Label.Text = "PCIP2:"
        '
        'PCIP3Label
        '
        PCIP3Label.AutoSize = True
        PCIP3Label.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        PCIP3Label.Location = New System.Drawing.Point(412, 250)
        PCIP3Label.Name = "PCIP3Label"
        PCIP3Label.Size = New System.Drawing.Size(67, 21)
        PCIP3Label.TabIndex = 25
        PCIP3Label.Text = "PCIP3:"
        '
        'MaskedTextBox4
        '
        Me.MaskedTextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "PCIP1", True))
        Me.MaskedTextBox4.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.MaskedTextBox4.Location = New System.Drawing.Point(488, 202)
        Me.MaskedTextBox4.Mask = "000.000.000.000"
        Me.MaskedTextBox4.Name = "MaskedTextBox4"
        Me.MaskedTextBox4.Size = New System.Drawing.Size(226, 33)
        Me.MaskedTextBox4.TabIndex = 26
        '
        'MaskedTextBox5
        '
        Me.MaskedTextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "PCIP2", True))
        Me.MaskedTextBox5.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.MaskedTextBox5.Location = New System.Drawing.Point(144, 238)
        Me.MaskedTextBox5.Mask = "000.000.000.000"
        Me.MaskedTextBox5.Name = "MaskedTextBox5"
        Me.MaskedTextBox5.Size = New System.Drawing.Size(247, 33)
        Me.MaskedTextBox5.TabIndex = 27
        '
        'MaskedTextBox6
        '
        Me.MaskedTextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "PCIP3", True))
        Me.MaskedTextBox6.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.MaskedTextBox6.Location = New System.Drawing.Point(488, 241)
        Me.MaskedTextBox6.Mask = "000.000.000.000"
        Me.MaskedTextBox6.Name = "MaskedTextBox6"
        Me.MaskedTextBox6.Size = New System.Drawing.Size(226, 33)
        Me.MaskedTextBox6.TabIndex = 28
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        EmailLabel.Location = New System.Drawing.Point(20, 331)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(61, 21)
        EmailLabel.TabIndex = 28
        EmailLabel.Text = "Email:"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Email", True))
        Me.EmailTextBox.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.EmailTextBox.Location = New System.Drawing.Point(144, 319)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(247, 33)
        Me.EmailTextBox.TabIndex = 29
        '
        'OfficeEmailLabel1
        '
        OfficeEmailLabel1.AutoSize = True
        OfficeEmailLabel1.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        OfficeEmailLabel1.Location = New System.Drawing.Point(20, 289)
        OfficeEmailLabel1.Name = "OfficeEmailLabel1"
        OfficeEmailLabel1.Size = New System.Drawing.Size(117, 21)
        OfficeEmailLabel1.TabIndex = 29
        OfficeEmailLabel1.Text = "Office Email:"
        '
        'OfficeEmailTextBox
        '
        Me.OfficeEmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "OfficeEmail", True))
        Me.OfficeEmailTextBox.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.OfficeEmailTextBox.Location = New System.Drawing.Point(144, 277)
        Me.OfficeEmailTextBox.Name = "OfficeEmailTextBox"
        Me.OfficeEmailTextBox.Size = New System.Drawing.Size(247, 33)
        Me.OfficeEmailTextBox.TabIndex = 30
        '
        'Email1Label
        '
        Email1Label.AutoSize = True
        Email1Label.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Email1Label.Location = New System.Drawing.Point(408, 322)
        Email1Label.Name = "Email1Label"
        Email1Label.Size = New System.Drawing.Size(71, 21)
        Email1Label.TabIndex = 30
        Email1Label.Text = "Email1:"
        '
        'Email1TextBox
        '
        Me.Email1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Email1", True))
        Me.Email1TextBox.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Email1TextBox.Location = New System.Drawing.Point(488, 319)
        Me.Email1TextBox.Name = "Email1TextBox"
        Me.Email1TextBox.Size = New System.Drawing.Size(226, 33)
        Me.Email1TextBox.TabIndex = 31
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(817, 35)
        Me.MenuStrip1.TabIndex = 32
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(86, 31)
        Me.ToolStripMenuItem1.Text = "About"
        Me.ToolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(817, 590)
        Me.Controls.Add(Email1Label)
        Me.Controls.Add(Me.Email1TextBox)
        Me.Controls.Add(OfficeEmailLabel1)
        Me.Controls.Add(Me.OfficeEmailTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.MaskedTextBox6)
        Me.Controls.Add(Me.MaskedTextBox5)
        Me.Controls.Add(Me.MaskedTextBox4)
        Me.Controls.Add(PCIP3Label)
        Me.Controls.Add(PCIP2Label)
        Me.Controls.Add(PCIP1Label)
        Me.Controls.Add(Me.MaskedTextBox3)
        Me.Controls.Add(Me.MaskedTextBox2)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(PCIPLabel)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(NamechnLabel)
        Me.Controls.Add(Me.NamechnTextBox)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(AccessIDLabel)
        Me.Controls.Add(Me.AccessIDTextBox)
        Me.Controls.Add(Ext_NoLabel)
        Me.Controls.Add(LocationLabel)
        Me.Controls.Add(Me.LocationTextBox)
        Me.Controls.Add(Me.StaffBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Staff Record"
        CType(Me.Staff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StaffBindingNavigator.ResumeLayout(False)
        Me.StaffBindingNavigator.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Staff As Popstaff.staff
    Friend WithEvents StaffBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StaffBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StaffBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NamechnTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AccessIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox3 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox4 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox5 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox6 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OfficeEmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Email1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem


End Class
