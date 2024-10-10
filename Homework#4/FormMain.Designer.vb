<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.AssignRB = New System.Windows.Forms.RadioButton()
        Me.CourseRB = New System.Windows.Forms.RadioButton()
        Me.InstructorRB = New System.Windows.Forms.RadioButton()
        Me.PeriodRB = New System.Windows.Forms.RadioButton()
        Me.RegisterRB = New System.Windows.Forms.RadioButton()
        Me.RoomRB = New System.Windows.Forms.RadioButton()
        Me.StudentRB = New System.Windows.Forms.RadioButton()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'AssignRB
        '
        Me.AssignRB.AutoSize = True
        Me.AssignRB.Location = New System.Drawing.Point(48, 121)
        Me.AssignRB.Name = "AssignRB"
        Me.AssignRB.Size = New System.Drawing.Size(86, 24)
        Me.AssignRB.TabIndex = 2
        Me.AssignRB.TabStop = True
        Me.AssignRB.Text = "Assign "
        Me.AssignRB.UseVisualStyleBackColor = True
        '
        'CourseRB
        '
        Me.CourseRB.AutoSize = True
        Me.CourseRB.Location = New System.Drawing.Point(48, 151)
        Me.CourseRB.Name = "CourseRB"
        Me.CourseRB.Size = New System.Drawing.Size(85, 24)
        Me.CourseRB.TabIndex = 3
        Me.CourseRB.TabStop = True
        Me.CourseRB.Text = "Course"
        Me.CourseRB.UseVisualStyleBackColor = True
        '
        'InstructorRB
        '
        Me.InstructorRB.AutoSize = True
        Me.InstructorRB.Location = New System.Drawing.Point(48, 181)
        Me.InstructorRB.Name = "InstructorRB"
        Me.InstructorRB.Size = New System.Drawing.Size(102, 24)
        Me.InstructorRB.TabIndex = 4
        Me.InstructorRB.TabStop = True
        Me.InstructorRB.Text = "Instructor"
        Me.InstructorRB.UseVisualStyleBackColor = True
        '
        'PeriodRB
        '
        Me.PeriodRB.AutoSize = True
        Me.PeriodRB.Location = New System.Drawing.Point(48, 211)
        Me.PeriodRB.Name = "PeriodRB"
        Me.PeriodRB.Size = New System.Drawing.Size(79, 24)
        Me.PeriodRB.TabIndex = 5
        Me.PeriodRB.TabStop = True
        Me.PeriodRB.Text = "Period"
        Me.PeriodRB.UseVisualStyleBackColor = True
        '
        'RegisterRB
        '
        Me.RegisterRB.AutoSize = True
        Me.RegisterRB.Location = New System.Drawing.Point(48, 241)
        Me.RegisterRB.Name = "RegisterRB"
        Me.RegisterRB.Size = New System.Drawing.Size(94, 24)
        Me.RegisterRB.TabIndex = 6
        Me.RegisterRB.TabStop = True
        Me.RegisterRB.Text = "Register"
        Me.RegisterRB.UseVisualStyleBackColor = True
        '
        'RoomRB
        '
        Me.RoomRB.AutoSize = True
        Me.RoomRB.Location = New System.Drawing.Point(48, 271)
        Me.RoomRB.Name = "RoomRB"
        Me.RoomRB.Size = New System.Drawing.Size(77, 24)
        Me.RoomRB.TabIndex = 7
        Me.RoomRB.TabStop = True
        Me.RoomRB.Text = "Room"
        Me.RoomRB.UseVisualStyleBackColor = True
        '
        'StudentRB
        '
        Me.StudentRB.AutoSize = True
        Me.StudentRB.Location = New System.Drawing.Point(48, 301)
        Me.StudentRB.Name = "StudentRB"
        Me.StudentRB.Size = New System.Drawing.Size(91, 24)
        Me.StudentRB.TabIndex = 8
        Me.StudentRB.TabStop = True
        Me.StudentRB.Text = "Student"
        Me.StudentRB.UseVisualStyleBackColor = True
        '
        'NextButton
        '
        Me.NextButton.Location = New System.Drawing.Point(175, 373)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(109, 41)
        Me.NextButton.TabIndex = 9
        Me.NextButton.Text = "Next"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(48, 373)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(109, 41)
        Me.CloseButton.TabIndex = 10
        Me.CloseButton.Text = "Exit"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(314, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Please choose one of the following options:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Database Tables"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 476)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.StudentRB)
        Me.Controls.Add(Me.RoomRB)
        Me.Controls.Add(Me.RegisterRB)
        Me.Controls.Add(Me.PeriodRB)
        Me.Controls.Add(Me.InstructorRB)
        Me.Controls.Add(Me.CourseRB)
        Me.Controls.Add(Me.AssignRB)
        Me.Name = "FormMain"
        Me.Text = "College Schedule Database"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AssignRB As RadioButton
    Friend WithEvents CourseRB As RadioButton
    Friend WithEvents InstructorRB As RadioButton
    Friend WithEvents PeriodRB As RadioButton
    Friend WithEvents RegisterRB As RadioButton
    Friend WithEvents RoomRB As RadioButton
    Friend WithEvents StudentRB As RadioButton
    Friend WithEvents NextButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
