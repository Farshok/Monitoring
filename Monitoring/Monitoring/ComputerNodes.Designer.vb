<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComputerNodes
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.OvalShape3 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape2 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.InfoDataSet = New Monitoring.InfoDataSet()
        Me.EventTableAdapter = New Monitoring.InfoDataSetTableAdapters.EventTableAdapter()
        Me.TableAdapterManager = New Monitoring.InfoDataSetTableAdapters.TableAdapterManager()
        Me.lbl_CpuUsage = New System.Windows.Forms.Label()
        Me.lbl_MemUsage = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InfoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.OvalShape1, Me.OvalShape3, Me.OvalShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(400, 40)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'OvalShape3
        '
        Me.OvalShape3.FillColor = System.Drawing.Color.Red
        Me.OvalShape3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.OvalShape3.Location = New System.Drawing.Point(101, 0)
        Me.OvalShape3.Name = "OvalShape3"
        Me.OvalShape3.Size = New System.Drawing.Size(36, 36)
        Me.OvalShape3.Visible = False
        '
        'OvalShape2
        '
        Me.OvalShape2.FillColor = System.Drawing.Color.Red
        Me.OvalShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.OvalShape2.Location = New System.Drawing.Point(54, 1)
        Me.OvalShape2.Name = "OvalShape2"
        Me.OvalShape2.Size = New System.Drawing.Size(36, 36)
        '
        'OvalShape1
        '
        Me.OvalShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.OvalShape1.FillColor = System.Drawing.Color.Red
        Me.OvalShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.OvalShape1.Location = New System.Drawing.Point(7, 1)
        Me.OvalShape1.Name = "OvalShape1"
        Me.OvalShape1.Size = New System.Drawing.Size(36, 36)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Monitoring.My.Resources.Resources._25610_black_circle_gradienti
        Me.PictureBox1.Location = New System.Drawing.Point(192, 12)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 21)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Lime
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(215, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Label1"
        '
        'Timer1
        '
        Me.Timer1.Interval = 10000
        '
        'BackgroundWorker1
        '
        '
        'InfoDataSet
        '
        Me.InfoDataSet.DataSetName = "InfoDataSet"
        Me.InfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EventTableAdapter
        '
        Me.EventTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ComputerNodeTableAdapter = Nothing
        Me.TableAdapterManager.EventTableAdapter = Me.EventTableAdapter
        Me.TableAdapterManager.IPNodesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Monitoring.InfoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'lbl_CpuUsage
        '
        Me.lbl_CpuUsage.AutoSize = True
        Me.lbl_CpuUsage.BackColor = System.Drawing.Color.Transparent
        Me.lbl_CpuUsage.ForeColor = System.Drawing.Color.Blue
        Me.lbl_CpuUsage.Location = New System.Drawing.Point(11, 12)
        Me.lbl_CpuUsage.Name = "lbl_CpuUsage"
        Me.lbl_CpuUsage.Size = New System.Drawing.Size(29, 16)
        Me.lbl_CpuUsage.TabIndex = 7
        Me.lbl_CpuUsage.Text = "100"
        '
        'lbl_MemUsage
        '
        Me.lbl_MemUsage.AutoSize = True
        Me.lbl_MemUsage.BackColor = System.Drawing.Color.Transparent
        Me.lbl_MemUsage.Location = New System.Drawing.Point(57, 11)
        Me.lbl_MemUsage.Name = "lbl_MemUsage"
        Me.lbl_MemUsage.Size = New System.Drawing.Size(29, 16)
        Me.lbl_MemUsage.TabIndex = 8
        Me.lbl_MemUsage.Text = "100"
        '
        'ComputerNodes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_CpuUsage)
        Me.Controls.Add(Me.lbl_MemUsage)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ComputerNodes"
        Me.Size = New System.Drawing.Size(400, 40)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InfoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents OvalShape1 As PowerPacks.OvalShape
    Friend WithEvents OvalShape3 As PowerPacks.OvalShape
    Friend WithEvents OvalShape2 As PowerPacks.OvalShape
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents InfoDataSet As InfoDataSet
    Friend WithEvents EventTableAdapter As InfoDataSetTableAdapters.EventTableAdapter
    Friend WithEvents TableAdapterManager As InfoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents lbl_CpuUsage As Label
    Friend WithEvents lbl_MemUsage As Label
End Class
