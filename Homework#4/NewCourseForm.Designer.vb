<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewCourseForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewCourseForm))
        Me.P5a_New_CourseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.P5a_New_CourseBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.P5a_New_CourseBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.HW3_Project_SolutionDataSet1 = New Homework_4.HW3_Project_SolutionDataSet()
        Me.P5a_New_CourseBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.P5a_New_CourseTableAdapter1 = New Homework_4.HW3_Project_SolutionDataSetTableAdapters.P5a_New_CourseTableAdapter()
        Me.TableAdapterManager1 = New Homework_4.HW3_Project_SolutionDataSetTableAdapters.TableAdapterManager()
        Me.P5a_New_CourseDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.P5a_New_CourseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P5a_New_CourseBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.P5a_New_CourseBindingNavigator.SuspendLayout()
        CType(Me.HW3_Project_SolutionDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P5a_New_CourseBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P5a_New_CourseDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'P5a_New_CourseBindingSource
        '
        Me.P5a_New_CourseBindingSource.DataMember = "P5a New Course"
        '
        'P5a_New_CourseBindingNavigator
        '
        Me.P5a_New_CourseBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.P5a_New_CourseBindingNavigator.BindingSource = Me.P5a_New_CourseBindingSource
        Me.P5a_New_CourseBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.P5a_New_CourseBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.P5a_New_CourseBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.P5a_New_CourseBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.P5a_New_CourseBindingNavigatorSaveItem})
        Me.P5a_New_CourseBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.P5a_New_CourseBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.P5a_New_CourseBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.P5a_New_CourseBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.P5a_New_CourseBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.P5a_New_CourseBindingNavigator.Name = "P5a_New_CourseBindingNavigator"
        Me.P5a_New_CourseBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.P5a_New_CourseBindingNavigator.Size = New System.Drawing.Size(800, 33)
        Me.P5a_New_CourseBindingNavigator.TabIndex = 0
        Me.P5a_New_CourseBindingNavigator.Text = "BindingNavigator1"
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
        'P5a_New_CourseBindingNavigatorSaveItem
        '
        Me.P5a_New_CourseBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.P5a_New_CourseBindingNavigatorSaveItem.Enabled = False
        Me.P5a_New_CourseBindingNavigatorSaveItem.Image = CType(resources.GetObject("P5a_New_CourseBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.P5a_New_CourseBindingNavigatorSaveItem.Name = "P5a_New_CourseBindingNavigatorSaveItem"
        Me.P5a_New_CourseBindingNavigatorSaveItem.Size = New System.Drawing.Size(34, 28)
        Me.P5a_New_CourseBindingNavigatorSaveItem.Text = "Save Data"
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(12, 379)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(109, 41)
        Me.BackButton.TabIndex = 15
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'HW3_Project_SolutionDataSet1
        '
        Me.HW3_Project_SolutionDataSet1.DataSetName = "HW3_Project_SolutionDataSet"
        Me.HW3_Project_SolutionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'P5a_New_CourseBindingSource1
        '
        Me.P5a_New_CourseBindingSource1.DataMember = "P5a New Course"
        Me.P5a_New_CourseBindingSource1.DataSource = Me.HW3_Project_SolutionDataSet1
        '
        'P5a_New_CourseTableAdapter1
        '
        Me.P5a_New_CourseTableAdapter1.ClearBeforeFill = True
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
        'P5a_New_CourseDataGridView
        '
        Me.P5a_New_CourseDataGridView.AutoGenerateColumns = False
        Me.P5a_New_CourseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.P5a_New_CourseDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewCheckBoxColumn2})
        Me.P5a_New_CourseDataGridView.DataSource = Me.P5a_New_CourseBindingSource1
        Me.P5a_New_CourseDataGridView.Location = New System.Drawing.Point(12, 70)
        Me.P5a_New_CourseDataGridView.Name = "P5a_New_CourseDataGridView"
        Me.P5a_New_CourseDataGridView.RowHeadersWidth = 62
        Me.P5a_New_CourseDataGridView.RowTemplate.Height = 28
        Me.P5a_New_CourseDataGridView.Size = New System.Drawing.Size(761, 280)
        Me.P5a_New_CourseDataGridView.TabIndex = 15
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CourseNo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CourseNo"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CourseTitle"
        Me.DataGridViewTextBoxColumn4.HeaderText = "CourseTitle"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "NewOffer"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "NewOffer"
        Me.DataGridViewCheckBoxColumn2.MinimumWidth = 8
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.Width = 150
        '
        'NewCourseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.P5a_New_CourseDataGridView)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.P5a_New_CourseBindingNavigator)
        Me.Name = "NewCourseForm"
        Me.Text = "New Course"
        CType(Me.P5a_New_CourseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P5a_New_CourseBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.P5a_New_CourseBindingNavigator.ResumeLayout(False)
        Me.P5a_New_CourseBindingNavigator.PerformLayout()
        CType(Me.HW3_Project_SolutionDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P5a_New_CourseBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P5a_New_CourseDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HW3_Project_SolutionDataSet As HW3_Project_SolutionDataSet
    Friend WithEvents P5a_New_CourseBindingSource As BindingSource
    Friend WithEvents P5a_New_CourseTableAdapter As HW3_Project_SolutionDataSetTableAdapters.P5a_New_CourseTableAdapter
    Friend WithEvents TableAdapterManager As HW3_Project_SolutionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents P5a_New_CourseBindingNavigator As BindingNavigator
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
    Friend WithEvents P5a_New_CourseBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents BackButton As Button
    Friend WithEvents HW3_Project_SolutionDataSet1 As HW3_Project_SolutionDataSet
    Friend WithEvents P5a_New_CourseBindingSource1 As BindingSource
    Friend WithEvents P5a_New_CourseTableAdapter1 As HW3_Project_SolutionDataSetTableAdapters.P5a_New_CourseTableAdapter
    Friend WithEvents TableAdapterManager1 As HW3_Project_SolutionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents P5a_New_CourseDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
End Class
