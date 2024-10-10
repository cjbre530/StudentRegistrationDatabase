<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentSearchForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentSearchForm))
        Me.BackButton = New System.Windows.Forms.Button()
        Me.HW3_Project_SolutionDataSet = New Homework_4.HW3_Project_SolutionDataSet()
        Me.P2_Students_ScheduleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.P2_Students_ScheduleTableAdapter = New Homework_4.HW3_Project_SolutionDataSetTableAdapters.P2_Students_ScheduleTableAdapter()
        Me.TableAdapterManager = New Homework_4.HW3_Project_SolutionDataSetTableAdapters.TableAdapterManager()
        Me.P2_Students_ScheduleBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.P2_Students_ScheduleBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FillToolStrip = New System.Windows.Forms.ToolStrip()
        Me.StudentIDToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.StudentIDToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.P2_Students_ScheduleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.HW3_Project_SolutionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P2_Students_ScheduleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P2_Students_ScheduleBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.P2_Students_ScheduleBindingNavigator.SuspendLayout()
        Me.FillToolStrip.SuspendLayout()
        CType(Me.P2_Students_ScheduleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(25, 373)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(109, 41)
        Me.BackButton.TabIndex = 16
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'HW3_Project_SolutionDataSet
        '
        Me.HW3_Project_SolutionDataSet.DataSetName = "HW3_Project_SolutionDataSet"
        Me.HW3_Project_SolutionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'P2_Students_ScheduleBindingSource
        '
        Me.P2_Students_ScheduleBindingSource.DataMember = "P2 Students Schedule"
        Me.P2_Students_ScheduleBindingSource.DataSource = Me.HW3_Project_SolutionDataSet
        '
        'P2_Students_ScheduleTableAdapter
        '
        Me.P2_Students_ScheduleTableAdapter.ClearBeforeFill = True
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
        'P2_Students_ScheduleBindingNavigator
        '
        Me.P2_Students_ScheduleBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.P2_Students_ScheduleBindingNavigator.BindingSource = Me.P2_Students_ScheduleBindingSource
        Me.P2_Students_ScheduleBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.P2_Students_ScheduleBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.P2_Students_ScheduleBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.P2_Students_ScheduleBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.P2_Students_ScheduleBindingNavigatorSaveItem})
        Me.P2_Students_ScheduleBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.P2_Students_ScheduleBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.P2_Students_ScheduleBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.P2_Students_ScheduleBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.P2_Students_ScheduleBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.P2_Students_ScheduleBindingNavigator.Name = "P2_Students_ScheduleBindingNavigator"
        Me.P2_Students_ScheduleBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.P2_Students_ScheduleBindingNavigator.Size = New System.Drawing.Size(1034, 33)
        Me.P2_Students_ScheduleBindingNavigator.TabIndex = 17
        Me.P2_Students_ScheduleBindingNavigator.Text = "BindingNavigator1"
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
        'P2_Students_ScheduleBindingNavigatorSaveItem
        '
        Me.P2_Students_ScheduleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.P2_Students_ScheduleBindingNavigatorSaveItem.Enabled = False
        Me.P2_Students_ScheduleBindingNavigatorSaveItem.Image = CType(resources.GetObject("P2_Students_ScheduleBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.P2_Students_ScheduleBindingNavigatorSaveItem.Name = "P2_Students_ScheduleBindingNavigatorSaveItem"
        Me.P2_Students_ScheduleBindingNavigatorSaveItem.Size = New System.Drawing.Size(34, 28)
        Me.P2_Students_ScheduleBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FillToolStrip
        '
        Me.FillToolStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.FillToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentIDToolStripLabel, Me.StudentIDToolStripTextBox, Me.FillToolStripButton})
        Me.FillToolStrip.Location = New System.Drawing.Point(0, 33)
        Me.FillToolStrip.Name = "FillToolStrip"
        Me.FillToolStrip.Size = New System.Drawing.Size(1034, 34)
        Me.FillToolStrip.TabIndex = 18
        Me.FillToolStrip.Text = "FillToolStrip"
        '
        'StudentIDToolStripLabel
        '
        Me.StudentIDToolStripLabel.Name = "StudentIDToolStripLabel"
        Me.StudentIDToolStripLabel.Size = New System.Drawing.Size(95, 25)
        Me.StudentIDToolStripLabel.Text = "StudentID:"
        '
        'StudentIDToolStripTextBox
        '
        Me.StudentIDToolStripTextBox.Name = "StudentIDToolStripTextBox"
        Me.StudentIDToolStripTextBox.Size = New System.Drawing.Size(100, 31)
        '
        'FillToolStripButton
        '
        Me.FillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillToolStripButton.Name = "FillToolStripButton"
        Me.FillToolStripButton.Size = New System.Drawing.Size(37, 29)
        Me.FillToolStripButton.Text = "Fill"
        '
        'P2_Students_ScheduleDataGridView
        '
        Me.P2_Students_ScheduleDataGridView.AutoGenerateColumns = False
        Me.P2_Students_ScheduleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.P2_Students_ScheduleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.P2_Students_ScheduleDataGridView.DataSource = Me.P2_Students_ScheduleBindingSource
        Me.P2_Students_ScheduleDataGridView.Location = New System.Drawing.Point(12, 107)
        Me.P2_Students_ScheduleDataGridView.Name = "P2_Students_ScheduleDataGridView"
        Me.P2_Students_ScheduleDataGridView.RowHeadersWidth = 62
        Me.P2_Students_ScheduleDataGridView.RowTemplate.Height = 28
        Me.P2_Students_ScheduleDataGridView.Size = New System.Drawing.Size(973, 225)
        Me.P2_Students_ScheduleDataGridView.TabIndex = 18
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
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "StudentID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "StudentID"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'StudentSearchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 450)
        Me.Controls.Add(Me.P2_Students_ScheduleDataGridView)
        Me.Controls.Add(Me.FillToolStrip)
        Me.Controls.Add(Me.P2_Students_ScheduleBindingNavigator)
        Me.Controls.Add(Me.BackButton)
        Me.Name = "StudentSearchForm"
        Me.Text = "Student Schedule Search"
        CType(Me.HW3_Project_SolutionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P2_Students_ScheduleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P2_Students_ScheduleBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.P2_Students_ScheduleBindingNavigator.ResumeLayout(False)
        Me.P2_Students_ScheduleBindingNavigator.PerformLayout()
        Me.FillToolStrip.ResumeLayout(False)
        Me.FillToolStrip.PerformLayout()
        CType(Me.P2_Students_ScheduleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackButton As Button
    Friend WithEvents HW3_Project_SolutionDataSet As HW3_Project_SolutionDataSet
    Friend WithEvents P2_Students_ScheduleBindingSource As BindingSource
    Friend WithEvents P2_Students_ScheduleTableAdapter As HW3_Project_SolutionDataSetTableAdapters.P2_Students_ScheduleTableAdapter
    Friend WithEvents TableAdapterManager As HW3_Project_SolutionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents P2_Students_ScheduleBindingNavigator As BindingNavigator
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
    Friend WithEvents P2_Students_ScheduleBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents FillToolStrip As ToolStrip
    Friend WithEvents StudentIDToolStripLabel As ToolStripLabel
    Friend WithEvents StudentIDToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillToolStripButton As ToolStripButton
    Friend WithEvents P2_Students_ScheduleDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class
