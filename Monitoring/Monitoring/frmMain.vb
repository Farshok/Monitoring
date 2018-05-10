Public Class frmMain
    Dim ctlNodes() As IPNodes
    Dim ctlComputers() As ComputerNodes




    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim i As Integer
        For i = 0 To ctlNodes.Count - 2
            ctlNodes(i).updateC()

        Next i
        For i = 0 To ctlComputers.Count - 2
            ctlComputers(i).UpdateC()
        Next i

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InfoDataSet.ComputerNode' table. You can move, or remove it, as needed.
        Me.ComputerNodeTableAdapter.Fill(Me.InfoDataSet.ComputerNode)
        'TODO: This line of code loads data into the 'InfoDataSet.IPNodes' table. You can move, or remove it, as needed.
        Me.IPNodesTableAdapter.Fill(Me.InfoDataSet.IPNodes)
        Dim i, j, x As Integer
        Dim i_C, j_C, x_C As Integer
        '  InfoDataSet.BeginInit()
        IPNodesTableAdapter.Fill(InfoDataSet.IPNodes)
        ComputerNodeTableAdapter.Fill(InfoDataSet.ComputerNode)
        i = InfoDataSet.Tables("IPNodes").Rows.Count
        i_C = InfoDataSet.Tables("ComputerNode").Rows.Count
        ' MsgBox(i.ToString)

        ReDim ctlNodes(i)
        ReDim ctlComputers(i_C)


        Dim R As InfoDataSet.IPNodesRow
        x = Me.TabPage1.Size.Height
        x = x / 40
        x = x * 40
        x = x - 40
        Dim h, w As Integer
        w = 20
        h = 5
        For j = 0 To i - 1
            If h > x Then
                h = 5
                w = w + 400
            End If
            ctlNodes(j) = New IPNodes
            ctlNodes(j).Left = w
            ctlNodes(j).Top = h

            ctlNodes(j).Parent = Me.TabPage1
            ctlNodes(j).Show()
            R = InfoDataSet.Tables("IPNodes").Rows(j)
            ctlNodes(j).DES = R.Description
            ctlNodes(j).IpAddress = R.IPAddress
            ctlNodes(j).IP_DES = R.IPAddress.ToString
            ctlNodes(j).IDs = R.ID
            ctlNodes(j).Started = True
            h = h + 40
            '   ctlNodes(j - 1).Datase = InfoDataSet
        Next j

        Dim R_C As InfoDataSet.ComputerNodeRow
        x_C = Me.TabPage3.Size.Height
        x_C = x_C / 40
        x_C = x_C * 40
        x_C = x_C - 40
        Dim h_C, w_C As Integer
        w_C = 20
        h_C = 15
        For j_C = 0 To i_C - 1
            If h_C > x_C Then
                h_C = 15
                w_C = w_C + 400
            End If
            ctlComputers(j_C) = New ComputerNodes
            ctlComputers(j_C).Left = w_C
            ctlComputers(j_C).Top = h_C

            ctlComputers(j_C).Parent = Me.TabPage3
            ctlComputers(j_C).Show()
            R_C = InfoDataSet.Tables("ComputerNode").Rows(j_C)
            ctlComputers(j_C).IDs = R_C.ID
            ctlComputers(j_C).ComputerName = R_C.ComputerIP
            ctlComputers(j_C).DES = R_C.Description
            ctlComputers(j_C).UserName = R_C.UserNameT
            ctlComputers(j_C).Password = R_C.PasswordT
            ctlComputers(j_C).Started = True
            h_C = h_C + 40

        Next j_C



    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs)
        Dim i As Integer
        Dim r As InfoDataSet.IPOutageRow

        For i = 0 To 10
            r = InfoDataSet1.IPOutage.NewIPOutageRow

            r.IPName = "goor"
            r.From = Now
            r._To = Now
            r.Duration = r.From - r._To
            InfoDataSet1.IPOutage.AddIPOutageRow(r)
        Next

    End Sub
End Class
