<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IPOutageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InfoDataSet1 = New Monitoring.InfoDataSet()
        Me.InfoDataSet = New Monitoring.InfoDataSet()
        Me.IPNodesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IPNodesTableAdapter = New Monitoring.InfoDataSetTableAdapters.IPNodesTableAdapter()
        Me.TableAdapterManager = New Monitoring.InfoDataSetTableAdapters.TableAdapterManager()
        Me.ComputerNodesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComputerNodeTableAdapter = New Monitoring.InfoDataSetTableAdapters.ComputerNodeTableAdapter()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.IPOutageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InfoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InfoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IPNodesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComputerNodesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(596, 321)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(588, 295)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "IP"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(588, 295)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Computer"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "MEM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CPU"
        '
        'IPOutageBindingSource
        '
        Me.IPOutageBindingSource.DataMember = "IPOutage"
        Me.IPOutageBindingSource.DataSource = Me.InfoDataSet1
        '
        'InfoDataSet1
        '
        Me.InfoDataSet1.DataSetName = "InfoDataSet"
        Me.InfoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InfoDataSet
        '
        Me.InfoDataSet.DataSetName = "InfoDataSet"
        Me.InfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IPNodesBindingSource
        '
        Me.IPNodesBindingSource.DataMember = "IPNodes"
        Me.IPNodesBindingSource.DataSource = Me.InfoDataSet
        '
        'IPNodesTableAdapter
        '
        Me.IPNodesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ComputerNodeTableAdapter = Nothing
        Me.TableAdapterManager.EventTableAdapter = Nothing
        Me.TableAdapterManager.IPNodesTableAdapter = Me.IPNodesTableAdapter
        Me.TableAdapterManager.UpdateOrder = Monitoring.InfoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ComputerNodesBindingSource
        '
        Me.ComputerNodesBindingSource.DataMember = "ComputerNode"
        Me.ComputerNodesBindingSource.DataSource = Me.InfoDataSet
        '
        'ComputerNodeTableAdapter
        '
        Me.ComputerNodeTableAdapter.ClearBeforeFill = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 321)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmMain"
        Me.Text = "Monitoring"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.IPOutageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InfoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InfoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IPNodesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComputerNodesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents InfoDataSet As InfoDataSet
    Friend WithEvents IPNodesBindingSource As BindingSource
    Friend WithEvents IPNodesTableAdapter As InfoDataSetTableAdapters.IPNodesTableAdapter
    Friend WithEvents TableAdapterManager As InfoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents IPOutageBindingSource As BindingSource
    Friend WithEvents InfoDataSet1 As InfoDataSet
    Friend WithEvents ComputerNodesBindingSource As BindingSource
    Friend WithEvents ComputerNodeTableAdapter As InfoDataSetTableAdapters.ComputerNodeTableAdapter
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
