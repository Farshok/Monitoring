Imports System.Net.NetworkInformation
Public Class IPNodes

    Private ip As String
    Private StartC As Boolean
    Private IDst As Integer
    Private OKLimit = 10
    Private NotOKLimit = -3
    Private LinkStatus As String = "OK"
    Private LinkStatus_Prev As String = "OK"
    Private LinkStatus_i As Integer = OKLimit
    Private Linkstatus_Prev_t As Date
    Private LinkQuality As Integer = 100
    Private LinkQualityP As Integer

    WriteOnly Property IDs As Integer
        Set(value As Integer)
            IDst = value
        End Set

    End Property

    Property DES() As String
        Get
            Return Me.Label1.Text
        End Get
        Set(value As String)
            Me.Label1.Text = value
        End Set
    End Property
    Property IP_DES() As String
        Get
            Return Me.Label2.Text
        End Get
        Set(value As String)
            Me.Label2.Text = value
        End Set
    End Property
    Property IpAddress() As String
            Get
                Return Me.ip
            End Get
            Set(value As String)
                Me.ip = value
            End Set
        End Property
        Property Started() As Boolean
            Get
                Return Me.Timer1.Enabled
            End Get
            Set(value As Boolean)

            If value = True Then
                Dim r As InfoDataSet.EventRow
                r = InfoDataSet._Event.NewEventRow
                With r
                    r.ObjectType = "IP Address"
                    r.ObjectID = IDst
                    r.DateTime = Now()
                    r.EventTypeID = 1
                    r.Des = "Started"
                End With

                InfoDataSet._Event.AddEventRow(r)
                Me.EventTableAdapter.Update(InfoDataSet)

                Me.Timer1.Enabled = value
                Timer1.Start()
            Else
                    Timer1.Stop()
                End If
                '  Me.Label1.Text = Me.Timer1.Enabled.ToString
            End Set
        End Property

    Public Sub updateC()
        If LinkStatus = "NotOK" Then
            Me.OvalShape1.FillColor = Color.Red
            Me.Label3.BackColor = Color.Red
            Me.Label3.ForeColor = Color.Yellow
            Me.BackColor = SystemColors.ControlDarkDark
        End If

        If LinkStatus = "OK" Then
            Me.OvalShape1.FillColor = Color.Green
            Me.Label3.BackColor = Color.Green
            Me.Label3.ForeColor = Color.Yellow
            Me.BackColor = SystemColors.Control
        End If
        If LinkStatus = "UnStable" Then
            Me.OvalShape1.FillColor = Color.Yellow
            Me.Label3.BackColor = Color.Yellow
            Me.Label3.ForeColor = Color.Red
            Me.BackColor = SystemColors.ControlDark
        End If
        Me.Label3.Text = LinkQualityP.ToString
    End Sub

    Private Sub CheckLink()
        Dim p As New Ping
        Dim r As PingReply
        Try
            r = p.Send(Me.ip)
            If r.Status <> IPStatus.Success Then
                LinkStatus_i = LinkStatus_i - 1
                LinkQuality = LinkQuality - 1
                If LinkStatus_i < NotOKLimit Then
                    LinkStatus_i = NotOKLimit
                End If

            Else
                LinkStatus_i = LinkStatus_i + 1
                LinkQuality = LinkQuality + 1
                If LinkStatus_i > OKLimit Then
                    LinkStatus_i = OKLimit
                End If
            End If
            Exit Try
        Catch
            LinkStatus_i = LinkStatus_i - 1
            LinkQuality = LinkQuality - 1
            If LinkStatus_i < NotOKLimit Then
                LinkStatus_i = NotOKLimit
            End If
        End Try

        Select Case LinkStatus_i
            Case = OKLimit, OKLimit - 1
                LinkStatus = "OK"
                Exit Select
            Case = NotOKLimit
                LinkStatus = "NotOK"
                Exit Select
            Case Else
                LinkStatus = "UnStable"
        End Select

        If LinkStatus = LinkStatus_Prev Then
            Linkstatus_Prev_t = Now
        End If
        If LinkStatus <> LinkStatus_Prev And LinkStatus <> "UnStable" Then
            Dim re As InfoDataSet.EventRow
            re = InfoDataSet._Event.NewEventRow
            With re
                re.ObjectType = "IP Address"
                re.ObjectID = IDst
                re.DateTime = Now()
                re.EventTypeID = 2
                re.Des = "Link Status Change from" + " " + LinkStatus_Prev + " To " + LinkStatus
            End With

            InfoDataSet._Event.AddEventRow(re)
            Me.EventTableAdapter.Update(InfoDataSet)
            LinkStatus_Prev = LinkStatus
            Linkstatus_Prev_t = Now
        End If


        If LinkQuality < 0 Then
            LinkQuality = 0
        End If
        If LinkQuality > 100 Then
            LinkQuality = 100
        End If
        LinkQualityP = LinkQuality / 5
        LinkQualityP = LinkQualityP * 5


    End Sub

        Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.PictureBox1.Visible = False Then
            Me.PictureBox1.Visible = True
        Else
            Me.PictureBox1.Visible = False
        End If
        If BackgroundWorker1.IsBusy = False Then


            BackgroundWorker1.RunWorkerAsync()
        Else

        End If
        End Sub

        Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        CheckLink()

    End Sub


End Class

