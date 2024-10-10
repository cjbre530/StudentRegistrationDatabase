<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UnassignedForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UnassignedForm))
        Me.HW3_Project_SolutionDataSet = New Homework_4.HW3_Project_SolutionDataSet()
        Me.P5b_UnsassignedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.P5b_UnsassignedTableAdapter = New Homework_4.HW3_Project_SolutionDataSetTableAdapters.P5b_UnsassignedTableAdapter()
        Me.TableAdapterManager = New Homework_4.HW3_Project_SolutionDataSetTableAdapters.TableAdapterManager()
        Me.P5b_UnsassignedBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.P5b_UnsassignedBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.P5b_UnsassignedDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BackButton = New System.Windows.Forms.Button()
        CType(Me.HW3_Project_SolutionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P5b_UnsassignedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P5b_UnsassignedBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.P5b_UnsassignedBindingNavigator.SuspendLayout()
        CType(Me.P5b_UnsassignedDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HW3_Project_SolutionDataSet
        '
        Me.HW3_Project_SolutionDataSet.DataSetName = "HW3_Project_SolutionDataSet"
        Me.HW3_Project_SolutionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'P5b_UnsassignedBindingSource
        '
        Me.P5b_UnsassignedBindingSource.DataMember = "P5b Unsassigned"
        Me.P5b_UnsassignedBindingSource.DataSource = Me.HW3_Project_SolutionDataSet
        '
        'P5b_UnsassignedTableAdapter
        '
        Me.P5b_UnsassignedTableAdapter.ClearBeforeFill = True
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
        'P5b_UnsassignedBindingNavigator
        '
        Me.P5b_UnsassignedBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.P5b_UnsassignedBindingNavigator.BindingSource = Me.P5b_UnsassignedBindingSource
        Me.P5b_UnsassignedBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.P5b_UnsassignedBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.P5b_UnsassignedBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.P5b_UnsassignedBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.P5b_UnsassignedBindingNavigatorSaveItem})
        Me.P5b_UnsassignedBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.P5b_UnsassignedBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.P5b_UnsassignedBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.P5b_UnsassignedBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.P5b_UnsassignedBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.P5b_UnsassignedBindingNavigator.Name = "P5b_UnsassignedBindingNavigator"
        Me.P5b_UnsassignedBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.P5b_UnsassignedBindingNavigator.Size = New System.Drawing.Size(1151, 33)
        Me.P5b_UnsassignedBindingNavigator.TabIndex = 0
        Me.P5b_UnsassignedBindingNavigator.Text = "BindingNavigator1"
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
        'P5b_UnsassignedBindingNavigatorSaveItem
        '
        Me.P5b_UnsassignedBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.P5b_UnsassignedBindingNavigatorSaveItem.Enabled = False
        Me.P5b_UnsassignedBindingNavigatorSaveItem.Image = CType(resources.GetObject("P5b_UnsassignedBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.P5b_UnsassignedBindingNavigatorSaveItem.Name = "P5b_UnsassignedBindingNavigatorSaveItem"
        Me.P5b_UnsassignedBindingNavigatorSaveItem.Size = New System.Drawing.Size(34, 28)
        Me.P5b_UnsassignedBindingNavigatorSaveItem.Text = "Save Data"
        '
        'P5b_UnsassignedDataGridView
        '
        Me.P5b_UnsassignedDataGridView.AutoGenerateColumns = False
        Me.P5b_UnsassignedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.P5b_UnsassignedDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.P5b_UnsassignedDataGridView.DataSource = Me.P5b_UnsassignedBindingSource
        Me.P5b_UnsassignedDataGridView.Location = New System.Drawing.Point(12, 80)
        Me.P5b_UnsassignedDataGridView.Name = "P5b_UnsassignedDataGridView"
        Me.P5b_UnsassignedDataGridView.RowHeadersWidth = 62
        Me.P5b_UnsassignedDataGridView.RowTemplate.Height = 28
        Me.P5b_UnsassignedDataGridView.Size = New System.Drawing.Size(1108, 220)
        Me.P5b_UnsassignedDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "RoomNo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "RoomNo"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PeriodNo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "PeriodNo"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Days"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Days"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "StartTime"
        Me.DataGridViewTextBoxColumn4.HeaderText = "StartTime"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "EndTime"
        Me.DataGridViewTextBoxColumn5.HeaderText = "EndTime"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(12, 379)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(109, 41)
        Me.BackButton.TabIndex = 16
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'UnassignedForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1151, 460)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.P5b_UnsassignedDataGridView)
        Me.Controls.Add(Me.P5b_UnsassignedBindingNavigator)
        Me.Name = "UnassignedForm"
        Me.Text = "Unassigned Courses"
        CType(Me.HW3_Project_SolutionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P5b_UnsassignedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P5b_UnsassignedBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.P5b_UnsassignedBindingNavigator.ResumeLayout(False)
        Me.P5b_UnsassignedBindingNavigator.PerformLayout()
        CType(Me.P5b_UnsassignedDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HW3_Project_SolutionDataSet As HW3_Project_SolutionDataSet
    Friend WithEvents P5b_UnsassignedBindingSource As BindingSource
    Friend WithEvents P5b_UnsassignedTableAdapter As HW3_Project_SolutionDataSetTableAdapters.P5b_UnsassignedTableAdapter
    Friend WithEvents TableAdapterManager As HW3_Project_SolutionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents P5b_UnsassignedBindingNavigator As BindingNavigator
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
    Friend WithEvents P5b_UnsassignedBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents P5b_UnsassignedDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents BackButton As Button
End Class
