<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CourseLevelForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CourseLevelForm))
        Me.HW3_Project_SolutionDataSet = New Homework_4.HW3_Project_SolutionDataSet()
        Me.P7_Course_by_Department_and_LevelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.P7_Course_by_Department_and_LevelTableAdapter = New Homework_4.HW3_Project_SolutionDataSetTableAdapters.P7_Course_by_Department_and_LevelTableAdapter()
        Me.TableAdapterManager = New Homework_4.HW3_Project_SolutionDataSetTableAdapters.TableAdapterManager()
        Me.P7_Course_by_Department_and_LevelBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.P7_Course_by_Department_and_LevelBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FillToolStrip = New System.Windows.Forms.ToolStrip()
        Me.DepartmentToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.DepartmentToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.CoureLevelToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CoureLevelToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.P7_Course_by_Department_and_LevelDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BackButton = New System.Windows.Forms.Button()
        CType(Me.HW3_Project_SolutionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P7_Course_by_Department_and_LevelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P7_Course_by_Department_and_LevelBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.P7_Course_by_Department_and_LevelBindingNavigator.SuspendLayout()
        Me.FillToolStrip.SuspendLayout()
        CType(Me.P7_Course_by_Department_and_LevelDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HW3_Project_SolutionDataSet
        '
        Me.HW3_Project_SolutionDataSet.DataSetName = "HW3_Project_SolutionDataSet"
        Me.HW3_Project_SolutionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'P7_Course_by_Department_and_LevelBindingSource
        '
        Me.P7_Course_by_Department_and_LevelBindingSource.DataMember = "P7 Course by Department and Level"
        Me.P7_Course_by_Department_and_LevelBindingSource.DataSource = Me.HW3_Project_SolutionDataSet
        '
        'P7_Course_by_Department_and_LevelTableAdapter
        '
        Me.P7_Course_by_Department_and_LevelTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AssignTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.CourseTableAdapter = Nothing
        Me.TableAdapterManager.InstructorTableAdapter = Nothing
        Me.TableAdapterManager.PeriodTableAdapter = Nothing
        Me.TableAdapterManager.RegisterTableAdapter = Nothing
        Me.TableAdapterManager.RoomTableAdapter = Nothing
        Me.TableAdapterManager.StudentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Homework_4.HW3_Project_SolutionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'P7_Course_by_Department_and_LevelBindingNavigator
        '
        Me.P7_Course_by_Department_and_LevelBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.P7_Course_by_Department_and_LevelBindingNavigator.BindingSource = Me.P7_Course_by_Department_and_LevelBindingSource
        Me.P7_Course_by_Department_and_LevelBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.P7_Course_by_Department_and_LevelBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.P7_Course_by_Department_and_LevelBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.P7_Course_by_Department_and_LevelBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.P7_Course_by_Department_and_LevelBindingNavigatorSaveItem})
        Me.P7_Course_by_Department_and_LevelBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.P7_Course_by_Department_and_LevelBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.P7_Course_by_Department_and_LevelBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.P7_Course_by_Department_and_LevelBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.P7_Course_by_Department_and_LevelBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.P7_Course_by_Department_and_LevelBindingNavigator.Name = "P7_Course_by_Department_and_LevelBindingNavigator"
        Me.P7_Course_by_Department_and_LevelBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.P7_Course_by_Department_and_LevelBindingNavigator.Size = New System.Drawing.Size(1280, 33)
        Me.P7_Course_by_Department_and_LevelBindingNavigator.TabIndex = 0
        Me.P7_Course_by_Department_and_LevelBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(34, 20)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(34, 20)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 31)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(54, 25)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'P7_Course_by_Department_and_LevelBindingNavigatorSaveItem
        '
        Me.P7_Course_by_Department_and_LevelBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.P7_Course_by_Department_and_LevelBindingNavigatorSaveItem.Enabled = False
        Me.P7_Course_by_Department_and_LevelBindingNavigatorSaveItem.Image = CType(resources.GetObject("P7_Course_by_Department_and_LevelBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.P7_Course_by_Department_and_LevelBindingNavigatorSaveItem.Name = "P7_Course_by_Department_and_LevelBindingNavigatorSaveItem"
        Me.P7_Course_by_Department_and_LevelBindingNavigatorSaveItem.Size = New System.Drawing.Size(34, 28)
        Me.P7_Course_by_Department_and_LevelBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FillToolStrip
        '
        Me.FillToolStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.FillToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DepartmentToolStripLabel, Me.DepartmentToolStripTextBox, Me.CoureLevelToolStripLabel, Me.CoureLevelToolStripTextBox, Me.FillToolStripButton})
        Me.FillToolStrip.Location = New System.Drawing.Point(0, 33)
        Me.FillToolStrip.Name = "FillToolStrip"
        Me.FillToolStrip.Size = New System.Drawing.Size(1280, 34)
        Me.FillToolStrip.TabIndex = 1
        Me.FillToolStrip.Text = "FillToolStrip"
        '
        'DepartmentToolStripLabel
        '
        Me.DepartmentToolStripLabel.Name = "DepartmentToolStripLabel"
        Me.DepartmentToolStripLabel.Size = New System.Drawing.Size(111, 25)
        Me.DepartmentToolStripLabel.Text = "Department:"
        '
        'DepartmentToolStripTextBox
        '
        Me.DepartmentToolStripTextBox.Name = "DepartmentToolStripTextBox"
        Me.DepartmentToolStripTextBox.Size = New System.Drawing.Size(100, 31)
        '
        'CoureLevelToolStripLabel
        '
        Me.CoureLevelToolStripLabel.Name = "CoureLevelToolStripLabel"
        Me.CoureLevelToolStripLabel.Size = New System.Drawing.Size(102, 25)
        Me.CoureLevelToolStripLabel.Text = "CoureLevel:"
        '
        'CoureLevelToolStripTextBox
        '
        Me.CoureLevelToolStripTextBox.Name = "CoureLevelToolStripTextBox"
        Me.CoureLevelToolStripTextBox.Size = New System.Drawing.Size(100, 31)
        '
        'FillToolStripButton
        '
        Me.FillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillToolStripButton.Name = "FillToolStripButton"
        Me.FillToolStripButton.Size = New System.Drawing.Size(37, 29)
        Me.FillToolStripButton.Text = "Fill"
        '
        'P7_Course_by_Department_and_LevelDataGridView
        '
        Me.P7_Course_by_Department_and_LevelDataGridView.AutoGenerateColumns = False
        Me.P7_Course_by_Department_and_LevelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.P7_Course_by_Department_and_LevelDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.P7_Course_by_Department_and_LevelDataGridView.DataSource = Me.P7_Course_by_Department_and_LevelBindingSource
        Me.P7_Course_by_Department_and_LevelDataGridView.Location = New System.Drawing.Point(12, 111)
        Me.P7_Course_by_Department_and_LevelDataGridView.Name = "P7_Course_by_Department_and_LevelDataGridView"
        Me.P7_Course_by_Department_and_LevelDataGridView.RowHeadersWidth = 62
        Me.P7_Course_by_Department_and_LevelDataGridView.RowTemplate.Height = 28
        Me.P7_Course_by_Department_and_LevelDataGridView.Size = New System.Drawing.Size(1111, 184)
        Me.P7_Course_by_Department_and_LevelDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CourseNo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CourseNo"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Days"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Days"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "StartTime"
        Me.DataGridViewTextBoxColumn3.HeaderText = "StartTime"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "EndTime"
        Me.DataGridViewTextBoxColumn4.HeaderText = "EndTime"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Department"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Department"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CoureLevel"
        Me.DataGridViewTextBoxColumn6.HeaderText = "CoureLevel"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(25, 379)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(109, 41)
        Me.BackButton.TabIndex = 17
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'CourseLevelForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 454)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.P7_Course_by_Department_and_LevelDataGridView)
        Me.Controls.Add(Me.FillToolStrip)
        Me.Controls.Add(Me.P7_Course_by_Department_and_LevelBindingNavigator)
        Me.Name = "CourseLevelForm"
        Me.Text = "Course by Department and Level"
        CType(Me.HW3_Project_SolutionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P7_Course_by_Department_and_LevelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P7_Course_by_Department_and_LevelBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.P7_Course_by_Department_and_LevelBindingNavigator.ResumeLayout(False)
        Me.P7_Course_by_Department_and_LevelBindingNavigator.PerformLayout()
        Me.FillToolStrip.ResumeLayout(False)
        Me.FillToolStrip.PerformLayout()
        CType(Me.P7_Course_by_Department_and_LevelDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HW3_Project_SolutionDataSet As HW3_Project_SolutionDataSet
    Friend WithEvents P7_Course_by_Department_and_LevelBindingSource As BindingSource
    Friend WithEvents P7_Course_by_Department_and_LevelTableAdapter As HW3_Project_SolutionDataSetTableAdapters.P7_Course_by_Department_and_LevelTableAdapter
    Friend WithEvents TableAdapterManager As HW3_Project_SolutionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents P7_Course_by_Department_and_LevelBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents P7_Course_by_Department_and_LevelBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents FillToolStrip As ToolStrip
    Friend WithEvents DepartmentToolStripLabel As ToolStripLabel
    Friend WithEvents DepartmentToolStripTextBox As ToolStripTextBox
    Friend WithEvents CoureLevelToolStripLabel As ToolStripLabel
    Friend WithEvents CoureLevelToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillToolStripButton As ToolStripButton
    Friend WithEvents P7_Course_by_Department_and_LevelDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents BackButton As Button
End Class
