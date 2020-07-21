'Matthew Ware
'MattWareLab4 file
'July 20 2020
'Durham College NETD 2202
Option Strict On
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCarInventory
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
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblMake = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblNew = New System.Windows.Forms.Label()
        Me.chkNew = New System.Windows.Forms.CheckBox()
        Me.cbxMake = New System.Windows.Forms.ComboBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.numYear = New System.Windows.Forms.NumericUpDown()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ttHelp = New System.Windows.Forms.ToolTip(Me.components)
        Me.lsvCars = New System.Windows.Forms.ListView()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.numYear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(101, 32)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(0, 420)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lblMake, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblModel, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblYear, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lblPrice, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.lblNew, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.chkNew, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.cbxMake, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtModel, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.numYear, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txtPrice, 1, 3)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(13, 10)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(387, 229)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'lblMake
        '
        Me.lblMake.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMake.Location = New System.Drawing.Point(3, 0)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(110, 45)
        Me.lblMake.TabIndex = 0
        Me.lblMake.Text = "Ma&ke:"
        Me.lblMake.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblModel
        '
        Me.lblModel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblModel.Location = New System.Drawing.Point(3, 45)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(110, 45)
        Me.lblModel.TabIndex = 1
        Me.lblModel.Text = "&Model:"
        Me.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblYear
        '
        Me.lblYear.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblYear.Location = New System.Drawing.Point(3, 90)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(110, 45)
        Me.lblYear.TabIndex = 2
        Me.lblYear.Text = "&Year:"
        Me.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPrice
        '
        Me.lblPrice.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPrice.Location = New System.Drawing.Point(3, 135)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(110, 45)
        Me.lblPrice.TabIndex = 3
        Me.lblPrice.Text = "&Price:"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNew
        '
        Me.lblNew.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNew.Location = New System.Drawing.Point(3, 180)
        Me.lblNew.Name = "lblNew"
        Me.lblNew.Size = New System.Drawing.Size(110, 49)
        Me.lblNew.TabIndex = 4
        Me.lblNew.Text = "&New:"
        Me.lblNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkNew
        '
        Me.chkNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkNew.AutoSize = True
        Me.chkNew.Location = New System.Drawing.Point(119, 197)
        Me.chkNew.Name = "chkNew"
        Me.chkNew.Size = New System.Drawing.Size(265, 14)
        Me.chkNew.TabIndex = 4
        Me.ttHelp.SetToolTip(Me.chkNew, "Check this box if the Car is New")
        Me.chkNew.UseVisualStyleBackColor = True
        '
        'cbxMake
        '
        Me.cbxMake.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbxMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxMake.FormattingEnabled = True
        Me.cbxMake.ItemHeight = 13
        Me.cbxMake.Items.AddRange(New Object() {"Lincoln", "Dodge", "Jeep", "Chevrolet", "Chrysler", "GMC", "Ram", "Tesla", "Cadillac", "Volvo"})
        Me.cbxMake.Location = New System.Drawing.Point(119, 12)
        Me.cbxMake.MaxDropDownItems = 5
        Me.cbxMake.MaxLength = 5
        Me.cbxMake.Name = "cbxMake"
        Me.cbxMake.Size = New System.Drawing.Size(265, 21)
        Me.cbxMake.TabIndex = 0
        Me.ttHelp.SetToolTip(Me.cbxMake, "Select the Make of the Car ")
        '
        'txtModel
        '
        Me.txtModel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtModel.Location = New System.Drawing.Point(119, 57)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(265, 20)
        Me.txtModel.TabIndex = 1
        Me.ttHelp.SetToolTip(Me.txtModel, "Enter the Model of the Car")
        '
        'numYear
        '
        Me.numYear.AllowDrop = True
        Me.numYear.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numYear.Location = New System.Drawing.Point(119, 102)
        Me.numYear.Maximum = New Decimal(New Integer() {2020, 0, 0, 0})
        Me.numYear.Minimum = New Decimal(New Integer() {1920, 0, 0, 0})
        Me.numYear.Name = "numYear"
        Me.numYear.Size = New System.Drawing.Size(265, 20)
        Me.numYear.TabIndex = 2
        Me.ttHelp.SetToolTip(Me.numYear, "Select the Year of the Car")
        Me.numYear.Value = New Decimal(New Integer() {2020, 0, 0, 0})
        '
        'txtPrice
        '
        Me.txtPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPrice.Location = New System.Drawing.Point(119, 147)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(265, 20)
        Me.txtPrice.TabIndex = 3
        Me.ttHelp.SetToolTip(Me.txtPrice, "Enter the Price of the Car")
        '
        'lblOutput
        '
        Me.lblOutput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Location = New System.Drawing.Point(3, 255)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(719, 127)
        Me.lblOutput.TabIndex = 1
        Me.ttHelp.SetToolTip(Me.lblOutput, "Indicates the Results of Validation on Input")
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.lblOutput, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 2)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(11, 246)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(725, 425)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.btnEnter, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btnReset, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btnExit, 2, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(339, 385)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(383, 37)
        Me.TableLayoutPanel4.TabIndex = 2
        '
        'btnEnter
        '
        Me.btnEnter.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnter.Location = New System.Drawing.Point(3, 3)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(112, 31)
        Me.btnEnter.TabIndex = 0
        Me.btnEnter.Text = "&Enter"
        Me.ttHelp.SetToolTip(Me.btnEnter, "Adds a Car to the List")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(121, 3)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(131, 31)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "&Reset"
        Me.ttHelp.SetToolTip(Me.btnReset, "Clears the  Input to the Text Boxes")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(258, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(122, 31)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.ttHelp.SetToolTip(Me.btnExit, "Exits the Program")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lsvCars
        '
        Me.lsvCars.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsvCars.FullRowSelect = True
        ListViewGroup1.Header = "ListViewGroup"
        ListViewGroup1.Name = "ListViewGroup1"
        Me.lsvCars.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1})
        Me.lsvCars.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lsvCars.HideSelection = False
        Me.lsvCars.Location = New System.Drawing.Point(12, 245)
        Me.lsvCars.MultiSelect = False
        Me.lsvCars.Name = "lsvCars"
        Me.lsvCars.Size = New System.Drawing.Size(720, 256)
        Me.lsvCars.TabIndex = 3
        Me.ttHelp.SetToolTip(Me.lsvCars, "This is the Collection of Cars in the Inventory")
        Me.lsvCars.UseCompatibleStateImageBehavior = False
        Me.lsvCars.View = System.Windows.Forms.View.Details
        '
        'frmCarInventory
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(748, 684)
        Me.Controls.Add(Me.lsvCars)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCarInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Inventory"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.numYear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lblMake As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblNew As Label
    Friend WithEvents chkNew As CheckBox
    Friend WithEvents cbxMake As ComboBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents numYear As NumericUpDown
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lblOutput As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents ttHelp As ToolTip
    'Exit the program when the exit button is pressed
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
    'Call the Reset function when the reset button is pressed
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Reset()
    End Sub
    'The Reset Function setting all of the variables to null or default in the case of year
    Function Reset() As Boolean
        cbxMake.SelectedIndex = -1
        txtModel.Text = String.Empty
        numYear.Value = 2020
        txtPrice.Text = String.Empty
        chkNew.Checked = False
        lblOutput.Text = String.Empty
        Return True
    End Function
    'Function used to validate the form for valid input before adding a new car to the list
    Function ValidateInput(cbxMake As ComboBox, txtModel As TextBox, txtPrice As TextBox, numYear As NumericUpDown) As Boolean
        Dim Valid As Boolean = True     'Test to see if input validated
        Dim tempPrice As Decimal        'Hold the price in a temporary variable for processing
        lblOutput.Text = String.Empty   'Clear the Output box
        If (cbxMake.SelectedIndex = -1) Then    'Checks if a selection is made from a predefined list of Makes of cars
            lblOutput.Text += "You must select a valid Make for the car." + Environment.NewLine
            Valid = False
        End If
        If (txtModel.Text = String.Empty) Then  'Checks if the Model name is empty
            lblOutput.Text += "You must enter a valid Model name for the car." + Environment.NewLine
            Valid = False
        End If
        If (numYear.Text = String.Empty) Then   'Checks if the Year value is empty
            lblOutput.Text += "You must enter a Year the car was made." + Environment.NewLine
            Valid = False
        End If
        If (numYear.Value < 1920 Or numYear.Value > 2020) Then  'Makes sure the valid range is within the last century
            lblOutput.Text += "You must enter a year between 1920 and 2020." + Environment.NewLine
            Valid = False
        End If
        If (txtPrice.Text = String.Empty) Then      'Checks if the Price box is empty
            lblOutput.Text += "You must enter a Price." + Environment.NewLine
            Valid = False
        End If
        If (Trim(txtPrice.Text) = String.Empty) Then    'Checks if the price box is empty space
            tempPrice = 0
            Valid = False
        Else
            tempPrice = Convert.ToDecimal(Trim(txtPrice.Text))  'Ensures that the price is a valid positive number
            If (tempPrice < 0) Then
                lblOutput.Text += "You must enter a positive real number for the Price." + Environment.NewLine
                Valid = False
            End If
        End If
        Return Valid    'If the validation did not fail then proceed
    End Function

    Friend WithEvents lsvCars As ListView   'Create a list view to store the results
    'Main function execution when the enter button is pressed
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim cars As New List(Of Car)    'Create a list object composed of car objects
        If (ValidateInput(cbxMake, txtModel, txtPrice, numYear)) Then   'Run the input validation function
            Dim newCar As Car       'Placeholder Object called newCar
            newCar = New Car(cbxMake.Text, txtModel.Text, Convert.ToInt32(Trim(numYear.Value.ToString)), Convert.ToDecimal(Trim(txtPrice.Text)), chkNew.Checked) 'Instantiates newCar Object
            cars.Add(newCar)        'Add the new car to the list
            Reset()                 'Clear the input fields
            lblOutput.Text = "It Worked!"   'Register Success
            lsvCars.Columns.Clear() 'Clears the previous columns
            Dim lvItem(6) As ListViewItem   'Creates a list view item array with 6 fields
            lsvCars.Columns.Add("New Car", 70, HorizontalAlignment.Center)      'Field 0
            lsvCars.Columns.Add("Car ID", 50, HorizontalAlignment.Center)       'Field 1
            lsvCars.Columns.Add("Car Make", 200, HorizontalAlignment.Center)    'Field 2
            lsvCars.Columns.Add("Car Model", 200, HorizontalAlignment.Center)   'Field 3
            lsvCars.Columns.Add("Car Year", 60, HorizontalAlignment.Center)     'Field 4
            lsvCars.Columns.Add("Car Price", 100, HorizontalAlignment.Center)   'Field 5

            Dim j As Integer            'Placeholder to itterate over
            Dim carNumber As Integer    'Number of the car to processes subitems from
            For carNumber = 0 To cars.Count - 1 'Loop over all cars in the list
                For j = 0 To lvItem.Length - 1  'Loop over each field for each car
                    lvItem(j) = New ListViewItem    'Create a default ListViewItem
                    lvItem(j).SubItems.Add(cars(carNumber).GetCarData(j))   'Assign a string to each ListViewItem using the GetCarData Function
                Next j
            Next carNumber

            lsvCars.Items.AddRange(lvItem)  'Put the values together for display
        End If
        '
    End Sub
End Class
