<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InstructorSearchForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InstructorSearchForm))
        Me.BackButton = New System.Windows.Forms.Button()
        Me.HW3_Project_SolutionDataSet = New Homework_4.HW3_Project_SolutionDataSet()
        Me.P1_Professors_ScheduleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.P1_Professors_ScheduleTableAdapter = New Homework_4.HW3_Project_SolutionDataSetTableAdapters.P1_Professors_ScheduleTableAdapter()
        Me.TableAdapterManager = New Homework_4.HW3_Project_SolutionDataSetTableAdapters.TableAdapterManager()
        Me.P1_Professors_ScheduleBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.P1_Professors_ScheduleBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FillToolStrip = New System.Windows.Forms.ToolStrip()
        Me.NameToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.NameToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.P1_Professors_ScheduleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.HW3_Project_SolutionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P1_Professors_ScheduleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P1_Professors_ScheduleBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.P1_Professors_ScheduleBindingNavigator.SuspendLayout()
        Me.FillToolStrip.SuspendLayout()
        CType(Me.P1_Professors_ScheduleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(26, 373)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(109, 41)
        Me.BackButton.TabIndex = 15
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'HW3_Project_SolutionDataSet
        '
        Me.HW3_Project_SolutionDataSet.DataSetName = "HW3_Project_SolutionDataSet"
        Me.HW3_Project_SolutionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'P1_Professors_ScheduleBindingSource
        '
        Me.P1_Professors_ScheduleBindingSource.DataMember = "P1 Professors Schedule"
        Me.P1_Professors_ScheduleBindingSource.DataSource = Me.HW3_Project_SolutionDataSet
        '
        'P1_Professors_ScheduleTableAdapter
        '
        Me.P1_Professors_ScheduleTableAdapter.ClearBeforeFill = True
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
        'P1_Professors_ScheduleBindingNavigator
        '
        Me.P1_Professors_ScheduleBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.P1_Professors_ScheduleBindingNavigator.BindingSource = Me.P1_Professors_ScheduleBindingSource
        Me.P1_Professors_ScheduleBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.P1_Professors_ScheduleBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.P1_Professors_ScheduleBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.P1_Professors_ScheduleBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.P1_Professors_ScheduleBindingNavigatorSaveItem})
        Me.P1_Professors_ScheduleBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.P1_Professors_ScheduleBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.P1_Professors_ScheduleBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.P1_Professors_ScheduleBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.P1_Professors_ScheduleBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.P1_Professors_ScheduleBindingNavigator.Name = "P1_Professors_ScheduleBindingNavigator"
        Me.P1_Professors_ScheduleBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.P1_Professors_ScheduleBindingNavigator.Size = New System.Drawing.Size(894, 33)
        Me.P1_Professors_ScheduleBindingNavigator.TabIndex = 16
        Me.P1_Professors_ScheduleBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(54, 28)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 33)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 31)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 33)
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 33)
        '
        'P1_Professors_ScheduleBindingNavigatorSaveItem
        '
        Me.P1_Professors_ScheduleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.P1_Professors_ScheduleBindingNavigatorSaveItem.Enabled = False
        Me.P1_Professors_ScheduleBindingNavigatorSaveItem.Image = CType(resources.GetObject("P1_Professors_ScheduleBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.P1_Professors_ScheduleBindingNavigatorSaveItem.Name = "P1_Professors_ScheduleBindingNavigatorSaveItem"
        Me.P1_Professors_ScheduleBindingNavigatorSaveItem.Size = New System.Drawing.Size(34, 28)
        Me.P1_Professors_ScheduleBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FillToolStrip
        '
        Me.FillToolStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.FillToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NameToolStripLabel, Me.NameToolStripTextBox, Me.FillToolStripButton})
        Me.FillToolStrip.Location = New System.Drawing.Point(0, 33)
        Me.FillToolStrip.Name = "FillToolStrip"
        Me.FillToolStrip.Size = New System.Drawing.Size(894, 34)
        Me.FillToolStrip.TabIndex = 17
        Me.FillToolStrip.Text = "FillToolStrip"
        '
        'NameToolStripLabel
        '
        Me.NameToolStripLabel.Name = "NameToolStripLabel"
        Me.NameToolStripLabel.Size = New System.Drawing.Size(63, 29)
        Me.NameToolStripLabel.Text = "Name:"
        '
        'NameToolStripTextBox
        '
        Me.NameToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NameToolStripTextBox.Name = "NameToolStripTextBox"
        Me.NameToolStripTextBox.Size = New System.Drawing.Size(100, 34)
        '
        'FillToolStripButton
        '
        Me.FillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillToolStripButton.Name = "FillToolStripButton"
        Me.FillToolStripButton.Size = New System.Drawing.Size(37, 29)
        Me.FillToolStripButton.Text = "Fill"
        '
        'P1_Professors_ScheduleDataGridView
        '
        Me.P1_Professors_ScheduleDataGridView.AutoGenerateColumns = False
        Me.P1_Professors_ScheduleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.P1_Professors_ScheduleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.P1_Professors_ScheduleDataGridView.DataSource = Me.P1_Professors_ScheduleBindingSource
        Me.P1_Professors_ScheduleDataGridView.Location = New System.Drawing.Point(12, 103)
        Me.P1_Professors_ScheduleDataGridView.Name = "P1_Professors_ScheduleDataGridView"
        Me.P1_Professors_ScheduleDataGridView.RowHeadersWidth = 62
        Me.P1_Professors_ScheduleDataGridView.RowTemplate.Height = 28
        Me.P1_Professors_ScheduleDataGridView.Size = New System.Drawing.Size(824, 220)
        Me.P1_Professors_ScheduleDataGridView.TabIndex = 17
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Days"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Days"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "StartTime"
        Me.DataGridViewTextBoxColumn2.HeaderText = "StartTime"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "EndTime"
        Me.DataGridViewTextBoxColumn3.HeaderText = "EndTime"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'InstructorSearchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 450)
        Me.Controls.Add(Me.P1_Professors_ScheduleDataGridView)
        Me.Controls.Add(Me.FillToolStrip)
        Me.Controls.Add(Me.P1_Professors_ScheduleBindingNavigator)
        Me.Controls.Add(Me.BackButton)
        Me.Name = "InstructorSearchForm"
        Me.Text = "Instructor Schedule Search"
        CType(Me.HW3_Project_SolutionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P1_Professors_ScheduleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P1_Professors_ScheduleBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.P1_Professors_ScheduleBindingNavigator.ResumeLayout(False)
        Me.P1_Professors_ScheduleBindingNavigator.PerformLayout()
        Me.FillToolStrip.ResumeLayout(False)
        Me.FillToolStrip.PerformLayout()
        CType(Me.P1_Professors_ScheduleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackButton As Button
    Friend WithEvents HW3_Project_SolutionDataSet As HW3_Project_SolutionDataSet
    Friend WithEvents P1_Professors_ScheduleBindingSource As BindingSource
    Friend WithEvents P1_Professors_ScheduleTableAdapter As HW3_Project_SolutionDataSetTableAdapters.P1_Professors_ScheduleTableAdapter
    Friend WithEvents TableAdapterManager As HW3_Project_SolutionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents P1_Professors_ScheduleBindingNavigator As BindingNavigator
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
    Friend WithEvents P1_Professors_ScheduleBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents FillToolStrip As ToolStrip
    Friend WithEvents NameToolStripLabel As ToolStripLabel
    Friend WithEvents NameToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillToolStripButton As ToolStripButton
    Friend WithEvents P1_Professors_ScheduleDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
