<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PeriodForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PeriodForm))
        Me.PeriodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PeriodBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PeriodBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.HW3_Project_SolutionDataSet1 = New Homework_4.HW3_Project_SolutionDataSet()
        Me.PeriodBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PeriodTableAdapter1 = New Homework_4.HW3_Project_SolutionDataSetTableAdapters.PeriodTableAdapter()
        Me.TableAdapterManager1 = New Homework_4.HW3_Project_SolutionDataSetTableAdapters.TableAdapterManager()
        Me.PeriodDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.PeriodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeriodBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeriodBindingNavigator.SuspendLayout()
        CType(Me.HW3_Project_SolutionDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeriodBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeriodDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PeriodBindingSource
        '
        Me.PeriodBindingSource.DataMember = "Period"
        '
        'PeriodBindingNavigator
        '
        Me.PeriodBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PeriodBindingNavigator.BindingSource = Me.PeriodBindingSource
        Me.PeriodBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PeriodBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PeriodBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.PeriodBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PeriodBindingNavigatorSaveItem})
        Me.PeriodBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PeriodBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PeriodBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PeriodBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PeriodBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PeriodBindingNavigator.Name = "PeriodBindingNavigator"
        Me.PeriodBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PeriodBindingNavigator.Size = New System.Drawing.Size(1004, 33)
        Me.PeriodBindingNavigator.TabIndex = 0
        Me.PeriodBindingNavigator.Text = "BindingNavigator1"
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
        'PeriodBindingNavigatorSaveItem
        '
        Me.PeriodBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PeriodBindingNavigatorSaveItem.Image = CType(resources.GetObject("PeriodBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PeriodBindingNavigatorSaveItem.Name = "PeriodBindingNavigatorSaveItem"
        Me.PeriodBindingNavigatorSaveItem.Size = New System.Drawing.Size(34, 28)
        Me.PeriodBindingNavigatorSaveItem.Text = "Save Data"
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(12, 447)
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
        'PeriodBindingSource1
        '
        Me.PeriodBindingSource1.DataMember = "Period"
        Me.PeriodBindingSource1.DataSource = Me.HW3_Project_SolutionDataSet1
        '
        'PeriodTableAdapter1
        '
        Me.PeriodTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.AssignTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.CourseTableAdapter = Nothing
        Me.TableAdapterManager1.InstructorTableAdapter = Nothing
        Me.TableAdapterManager1.PeriodTableAdapter = Me.PeriodTableAdapter1
        Me.TableAdapterManager1.RegisterTableAdapter = Nothing
        Me.TableAdapterManager1.RoomTableAdapter = Nothing
        Me.TableAdapterManager1.StudentTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = Homework_4.HW3_Project_SolutionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PeriodDataGridView
        '
        Me.PeriodDataGridView.AutoGenerateColumns = False
        Me.PeriodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PeriodDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewCheckBoxColumn2})
        Me.PeriodDataGridView.DataSource = Me.PeriodBindingSource1
        Me.PeriodDataGridView.Location = New System.Drawing.Point(12, 60)
        Me.PeriodDataGridView.Name = "PeriodDataGridView"
        Me.PeriodDataGridView.RowHeadersWidth = 62
        Me.PeriodDataGridView.RowTemplate.Height = 28
        Me.PeriodDataGridView.Size = New System.Drawing.Size(878, 325)
        Me.PeriodDataGridView.TabIndex = 14
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PeriodNo"
        Me.DataGridViewTextBoxColumn5.HeaderText = "PeriodNo"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Days"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Days"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "StartTime"
        Me.DataGridViewTextBoxColumn7.HeaderText = "StartTime"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 150
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "EndTime"
        Me.DataGridViewTextBoxColumn8.HeaderText = "EndTime"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 150
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "Assigned"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Assigned"
        Me.DataGridViewCheckBoxColumn2.MinimumWidth = 8
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.Width = 150
        '
        'PeriodForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 508)
        Me.Controls.Add(Me.PeriodDataGridView)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.PeriodBindingNavigator)
        Me.Name = "PeriodForm"
        Me.Text = "Period Table"
        CType(Me.PeriodBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeriodBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeriodBindingNavigator.ResumeLayout(False)
        Me.PeriodBindingNavigator.PerformLayout()
        CType(Me.HW3_Project_SolutionDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeriodBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeriodDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HW3_Project_SolutionDataSet As HW3_Project_SolutionDataSet
    Friend WithEvents PeriodBindingSource As BindingSource
    Friend WithEvents PeriodTableAdapter As HW3_Project_SolutionDataSetTableAdapters.PeriodTableAdapter
    Friend WithEvents TableAdapterManager As HW3_Project_SolutionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PeriodBindingNavigator As BindingNavigator
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
    Friend WithEvents PeriodBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents BackButton As Button
    Friend WithEvents HW3_Project_SolutionDataSet1 As HW3_Project_SolutionDataSet
    Friend WithEvents PeriodBindingSource1 As BindingSource
    Friend WithEvents PeriodTableAdapter1 As HW3_Project_SolutionDataSetTableAdapters.PeriodTableAdapter
    Friend WithEvents TableAdapterManager1 As HW3_Project_SolutionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PeriodDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
End Class
