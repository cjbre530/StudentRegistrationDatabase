<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AssignForm
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AssignForm))
        Me.HW3_Project_SolutionDataSet1 = New Homework_4.HW3_Project_SolutionDataSet()
        Me.AssignBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AssignTableAdapter1 = New Homework_4.HW3_Project_SolutionDataSetTableAdapters.AssignTableAdapter()
        Me.TableAdapterManager1 = New Homework_4.HW3_Project_SolutionDataSetTableAdapters.TableAdapterManager()
        Me.AssignBindingSource1BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.AssignBindingSource1BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.AssignDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BackB = New System.Windows.Forms.Button()
        CType(Me.HW3_Project_SolutionDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssignBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssignBindingSource1BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AssignBindingSource1BindingNavigator.SuspendLayout()
        CType(Me.AssignDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HW3_Project_SolutionDataSet1
        '
        Me.HW3_Project_SolutionDataSet1.DataSetName = "HW3_Project_SolutionDataSet"
        Me.HW3_Project_SolutionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AssignBindingSource1
        '
        Me.AssignBindingSource1.DataMember = "Assign"
        Me.AssignBindingSource1.DataSource = Me.HW3_Project_SolutionDataSet1
        '
        'AssignTableAdapter1
        '
        Me.AssignTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.AssignTableAdapter = Me.AssignTableAdapter1
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.CourseTableAdapter = Nothing
        Me.TableAdapterManager1.InstructorTableAdapter = Nothing
        Me.TableAdapterManager1.PeriodTableAdapter = Nothing
        Me.TableAdapterManager1.RegisterTableAdapter = Nothing
        Me.TableAdapterManager1.RoomTableAdapter = Nothing
        Me.TableAdapterManager1.StudentTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = Homework_4.HW3_Project_SolutionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AssignBindingSource1BindingNavigator
        '
        Me.AssignBindingSource1BindingNavigator.AddNewItem = Me.ToolStripButton5
        Me.AssignBindingSource1BindingNavigator.BindingSource = Me.AssignBindingSource1
        Me.AssignBindingSource1BindingNavigator.CountItem = Me.ToolStripLabel1
        Me.AssignBindingSource1BindingNavigator.DeleteItem = Me.ToolStripButton6
        Me.AssignBindingSource1BindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.AssignBindingSource1BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator3, Me.ToolStripButton5, Me.ToolStripButton6, Me.AssignBindingSource1BindingNavigatorSaveItem})
        Me.AssignBindingSource1BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AssignBindingSource1BindingNavigator.MoveFirstItem = Me.ToolStripButton1
        Me.AssignBindingSource1BindingNavigator.MoveLastItem = Me.ToolStripButton4
        Me.AssignBindingSource1BindingNavigator.MoveNextItem = Me.ToolStripButton3
        Me.AssignBindingSource1BindingNavigator.MovePreviousItem = Me.ToolStripButton2
        Me.AssignBindingSource1BindingNavigator.Name = "AssignBindingSource1BindingNavigator"
        Me.AssignBindingSource1BindingNavigator.PositionItem = Me.ToolStripTextBox1
        Me.AssignBindingSource1BindingNavigator.Size = New System.Drawing.Size(758, 33)
        Me.AssignBindingSource1BindingNavigator.TabIndex = 0
        Me.AssignBindingSource1BindingNavigator.Text = "BindingNavigator1"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton5.Size = New System.Drawing.Size(34, 28)
        Me.ToolStripButton5.Text = "Add new"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(54, 28)
        Me.ToolStripLabel1.Text = "of {0}"
        Me.ToolStripLabel1.ToolTipText = "Total number of items"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton6.Size = New System.Drawing.Size(34, 28)
        Me.ToolStripButton6.Text = "Delete"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(34, 28)
        Me.ToolStripButton1.Text = "Move first"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(34, 28)
        Me.ToolStripButton2.Text = "Move previous"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 33)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Position"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 31)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.ToolTipText = "Current position"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 33)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(34, 28)
        Me.ToolStripButton3.Text = "Move next"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(34, 28)
        Me.ToolStripButton4.Text = "Move last"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 33)
        '
        'AssignBindingSource1BindingNavigatorSaveItem
        '
        Me.AssignBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AssignBindingSource1BindingNavigatorSaveItem.Image = CType(resources.GetObject("AssignBindingSource1BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AssignBindingSource1BindingNavigatorSaveItem.Name = "AssignBindingSource1BindingNavigatorSaveItem"
        Me.AssignBindingSource1BindingNavigatorSaveItem.Size = New System.Drawing.Size(34, 28)
        Me.AssignBindingSource1BindingNavigatorSaveItem.Text = "Save Data"
        '
        'AssignDataGridView1
        '
        Me.AssignDataGridView1.AutoGenerateColumns = False
        Me.AssignDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AssignDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.AssignDataGridView1.DataSource = Me.AssignBindingSource1
        Me.AssignDataGridView1.Location = New System.Drawing.Point(12, 52)
        Me.AssignDataGridView1.Name = "AssignDataGridView1"
        Me.AssignDataGridView1.RowHeadersWidth = 62
        Me.AssignDataGridView1.RowTemplate.Height = 28
        Me.AssignDataGridView1.Size = New System.Drawing.Size(611, 268)
        Me.AssignDataGridView1.TabIndex = 3
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PeriodNo"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PeriodNo"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "RoomNo"
        Me.DataGridViewTextBoxColumn5.HeaderText = "RoomNo"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CourseNo"
        Me.DataGridViewTextBoxColumn6.HeaderText = "CourseNo"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'BackB
        '
        Me.BackB.Location = New System.Drawing.Point(12, 349)
        Me.BackB.Name = "BackB"
        Me.BackB.Size = New System.Drawing.Size(81, 30)
        Me.BackB.TabIndex = 2
        Me.BackB.Text = "Back"
        Me.BackB.UseVisualStyleBackColor = True
        '
        'AssignForm
        '
        Me.ClientSize = New System.Drawing.Size(758, 414)
        Me.Controls.Add(Me.AssignDataGridView1)
        Me.Controls.Add(Me.BackB)
        Me.Controls.Add(Me.AssignBindingSource1BindingNavigator)
        Me.Name = "AssignForm"
        Me.Text = "Assign Table"
        CType(Me.HW3_Project_SolutionDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssignBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssignBindingSource1BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AssignBindingSource1BindingNavigator.ResumeLayout(False)
        Me.AssignBindingSource1BindingNavigator.PerformLayout()
        CType(Me.AssignDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HW3_Project_SolutionDataSet As HW3_Project_SolutionDataSet
    Friend WithEvents AssignBindingSource As BindingSource
    Friend WithEvents AssignTableAdapter As HW3_Project_SolutionDataSetTableAdapters.AssignTableAdapter
    Friend WithEvents TableAdapterManager As HW3_Project_SolutionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AssignBindingNavigator As BindingNavigator
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
    Friend WithEvents AssignBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents AssignDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents BackButton As Button
    Friend WithEvents NextButton As Button
    Friend WithEvents HW3_Project_SolutionDataSet1 As HW3_Project_SolutionDataSet
    Friend WithEvents AssignBindingSource1 As BindingSource
    Friend WithEvents AssignTableAdapter1 As HW3_Project_SolutionDataSetTableAdapters.AssignTableAdapter
    Friend WithEvents TableAdapterManager1 As HW3_Project_SolutionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AssignBindingSource1BindingNavigator As BindingNavigator
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents AssignBindingSource1BindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents AssignDataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents BackB As Button
End Class
