<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CourseSummaryForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CourseSummaryForm))
        Me.P4_Course_SummaryBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.P4_Course_SummaryBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.HW3_Project_SolutionDataSet1 = New Homework_4.HW3_Project_SolutionDataSet()
        Me.P4_Course_SummaryBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.P4_Course_SummaryTableAdapter1 = New Homework_4.HW3_Project_SolutionDataSetTableAdapters.P4_Course_SummaryTableAdapter()
        Me.TableAdapterManager1 = New Homework_4.HW3_Project_SolutionDataSetTableAdapters.TableAdapterManager()
        Me.P4_Course_SummaryDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.P4_Course_SummaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.P4_Course_SummaryBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.P4_Course_SummaryBindingNavigator.SuspendLayout()
        CType(Me.HW3_Project_SolutionDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P4_Course_SummaryBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P4_Course_SummaryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P4_Course_SummaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'P4_Course_SummaryBindingNavigator
        '
        Me.P4_Course_SummaryBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.P4_Course_SummaryBindingNavigator.BindingSource = Me.P4_Course_SummaryBindingSource
        Me.P4_Course_SummaryBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.P4_Course_SummaryBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.P4_Course_SummaryBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.P4_Course_SummaryBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.P4_Course_SummaryBindingNavigatorSaveItem})
        Me.P4_Course_SummaryBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.P4_Course_SummaryBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.P4_Course_SummaryBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.P4_Course_SummaryBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.P4_Course_SummaryBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.P4_Course_SummaryBindingNavigator.Name = "P4_Course_SummaryBindingNavigator"
        Me.P4_Course_SummaryBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.P4_Course_SummaryBindingNavigator.Size = New System.Drawing.Size(1069, 33)
        Me.P4_Course_SummaryBindingNavigator.TabIndex = 0
        Me.P4_Course_SummaryBindingNavigator.Text = "BindingNavigator1"
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
        'P4_Course_SummaryBindingNavigatorSaveItem
        '
        Me.P4_Course_SummaryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.P4_Course_SummaryBindingNavigatorSaveItem.Enabled = False
        Me.P4_Course_SummaryBindingNavigatorSaveItem.Image = CType(resources.GetObject("P4_Course_SummaryBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.P4_Course_SummaryBindingNavigatorSaveItem.Name = "P4_Course_SummaryBindingNavigatorSaveItem"
        Me.P4_Course_SummaryBindingNavigatorSaveItem.Size = New System.Drawing.Size(34, 28)
        Me.P4_Course_SummaryBindingNavigatorSaveItem.Text = "Save Data"
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(30, 425)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(109, 41)
        Me.BackButton.TabIndex = 14
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'HW3_Project_SolutionDataSet1
        '
        Me.HW3_Project_SolutionDataSet1.DataSetName = "HW3_Project_SolutionDataSet"
        Me.HW3_Project_SolutionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'P4_Course_SummaryBindingSource1
        '
        Me.P4_Course_SummaryBindingSource1.DataMember = "P4 Course Summary"
        Me.P4_Course_SummaryBindingSource1.DataSource = Me.HW3_Project_SolutionDataSet1
        '
        'P4_Course_SummaryTableAdapter1
        '
        Me.P4_Course_SummaryTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.AssignTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.CourseTableAdapter = Nothing
        Me.TableAdapterManager1.InstructorTableAdapter = Nothing
        Me.TableAdapterManager1.PeriodTableAdapter = Nothing
        Me.TableAdapterManager1.RegisterTableAdapter = Nothing
        Me.TableAdapterManager1.RoomTableAdapter = Nothing
        Me.TableAdapterManager1.StudentTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = Homework_4.HW3_Project_SolutionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'P4_Course_SummaryDataGridView
        '
        Me.P4_Course_SummaryDataGridView.AutoGenerateColumns = False
        Me.P4_Course_SummaryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.P4_Course_SummaryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.P4_Course_SummaryDataGridView.DataSource = Me.P4_Course_SummaryBindingSource1
        Me.P4_Course_SummaryDataGridView.Location = New System.Drawing.Point(12, 63)
        Me.P4_Course_SummaryDataGridView.Name = "P4_Course_SummaryDataGridView"
        Me.P4_Course_SummaryDataGridView.RowHeadersWidth = 62
        Me.P4_Course_SummaryDataGridView.RowTemplate.Height = 28
        Me.P4_Course_SummaryDataGridView.Size = New System.Drawing.Size(975, 305)
        Me.P4_Course_SummaryDataGridView.TabIndex = 14
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CourseNo"
        Me.DataGridViewTextBoxColumn6.HeaderText = "CourseNo"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Total Register# of Students"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Total Register# of Students"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 150
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "RoomNo"
        Me.DataGridViewTextBoxColumn8.HeaderText = "RoomNo"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 150
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Capacity"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Capacity"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 150
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "FeasureDescription"
        Me.DataGridViewTextBoxColumn10.HeaderText = "FeasureDescription"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 150
        '
        'P4_Course_SummaryBindingSource
        '
        Me.P4_Course_SummaryBindingSource.DataMember = "P4 Course Summary"
        '
        'CourseSummaryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 526)
        Me.Controls.Add(Me.P4_Course_SummaryDataGridView)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.P4_Course_SummaryBindingNavigator)
        Me.Name = "CourseSummaryForm"
        Me.Text = "Course Summary"
        CType(Me.P4_Course_SummaryBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.P4_Course_SummaryBindingNavigator.ResumeLayout(False)
        Me.P4_Course_SummaryBindingNavigator.PerformLayout()
        CType(Me.HW3_Project_SolutionDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P4_Course_SummaryBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P4_Course_SummaryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P4_Course_SummaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HW3_Project_SolutionDataSet As HW3_Project_SolutionDataSet
    Friend WithEvents P4_Course_SummaryBindingSource As BindingSource
    Friend WithEvents P4_Course_SummaryTableAdapter As HW3_Project_SolutionDataSetTableAdapters.P4_Course_SummaryTableAdapter
    Friend WithEvents TableAdapterManager As HW3_Project_SolutionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents P4_Course_SummaryBindingNavigator As BindingNavigator
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
    Friend WithEvents P4_Course_SummaryBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents BackButton As Button
    Friend WithEvents HW3_Project_SolutionDataSet1 As HW3_Project_SolutionDataSet
    Friend WithEvents P4_Course_SummaryBindingSource1 As BindingSource
    Friend WithEvents P4_Course_SummaryTableAdapter1 As HW3_Project_SolutionDataSetTableAdapters.P4_Course_SummaryTableAdapter
    Friend WithEvents TableAdapterManager1 As HW3_Project_SolutionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents P4_Course_SummaryDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
End Class
