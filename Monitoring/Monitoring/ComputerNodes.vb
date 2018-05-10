Imports System
Imports System.Management
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data


Public Class ComputerNodes
        'Private ip As String
        Private StartC As Boolean
        Private IDst As Integer
        'Private OKLimit = 10
        'Private NotOKLimit = -3
        'Private LinkStatus As String = "OK"
        'Private LinkStatus_Prev As String = "OK"
        'Private LinkStatus_i As Integer = OKLimit
        'Private Linkstatus_Prev_t As Date
        'Private LinkQuality As Integer = 100
        'Private LinkQualityP As Integer

        Private strComputer As String
        Private strDomain As String
        Private strUser As String
        Private strPassword As String
        Private objSWbemLocator As Object
        Private objWMIService As Object
        Private colItems As Object
        Private CpuRate As Integer
    Private CpuRateF As Integer
    Private Memory_Total As Integer
    Private Memory_Available As Integer
    Private Free_Memory_Per As Integer
    Private Memory_Usage_Per As Integer



    WriteOnly Property ComputerName() As String
            Set(value As String)
                strComputer = value
            End Set
        End Property
        WriteOnly Property DomainName As String
            Set(value As String)
                strDomain = value
            End Set
        End Property
        WriteOnly Property UserName As String
            Set(value As String)
                strUser = value
            End Set
        End Property
        WriteOnly Property Password As String
            Set(value As String)
                strPassword = value
            End Set
        End Property
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

        'Property IpAddress() As String
        '    Get
        '        Return Me.ip
        '    End Get
        '    Set(value As String)
        '        Me.ip = value
        '    End Set
        'End Property

        Property Started() As Boolean
            Get
                Return Me.Timer1.Enabled
            End Get
            Set(value As Boolean)

                If value = True Then
                    Dim r As InfoDataSet.EventRow
                    r = InfoDataSet._Event.NewEventRow
                    With r
                        r.ObjectType = "Computer"
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
            End Set
        End Property

        Private Sub CheckLink()

        CpuRate = 0
        Dim CpuRateFt As Integer
        CpuRateFt = 0
        Try
            Dim connection As New ConnectionOptions
            'connection.Username = userNameBox.Text
            'connection.Password = passwordBox.Text
            connection.Authority = "ntlmdomain:"
            connection.Username = strUser
            connection.Password = strPassword

            Dim scope As New ManagementScope(
                "\\" + strComputer + "\root\CIMV2", connection)
            scope.Connect()

            Dim query As New ObjectQuery(
                "SELECT * FROM Win32_PerfFormattedData_PerfOS_Processor")

            Dim searcher As New ManagementObjectSearcher(scope, query)
            Dim i = 0
            Dim j = 1
            For j = 0 To 3
                For Each queryObj As ManagementObject In searcher.Get()


                    CpuRate = CpuRate + queryObj("PercentProcessorTime")
                    i = i + 1
                Next
                CpuRate = CpuRate / i
                CpuRateFt = CpuRateFt + CpuRate
            Next j
            CpuRateF = CpuRateFt / j

            Dim query2 As New ObjectQuery(
                    "SELECT * FROM Win32_PerfFormattedData_PerfOS_Memory")

            Dim searcher2 As New ManagementObjectSearcher(scope, query2)
            Dim memory_available_t As Integer
            memory_available_t = 0
            For Each queryObj2 As ManagementObject In searcher2.Get()
                Memory_Available_t = Memory_Available_t + queryObj2("AvailableMBytes")
            Next
            Memory_Available = memory_available_t

            Dim query3 As New ObjectQuery(
                    "SELECT * FROM Win32_PhysicalMemory")
            Dim searcher3 As New ManagementObjectSearcher(scope, query3)
            Dim All_Memory_T As Long
            For Each queryObj3 As ManagementObject In searcher3.Get()


                All_Memory_T = All_Memory_T + queryObj3("Capacity")
            Next
            All_Memory_T = All_Memory_T / 1024
            All_Memory_T = All_Memory_T / 1024
            Free_Memory_Per = Memory_Available / All_Memory_T * 100
            Memory_Usage_Per = 100 - Free_Memory_Per

        Catch err As ManagementException
            MessageBox.Show("An error occurred while querying for WMI data: " & err.Message)
        Catch unauthorizedErr As System.UnauthorizedAccessException

            MessageBox.Show("Connection error (user name or password might be incorrect): " & unauthorizedErr.Message)
            End Try



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
        Public Sub UpdateC()
        Select Case CpuRateF
            Case 0 To 80
                OvalShape1.FillColor = Color.Green
                lbl_CpuUsage.BackColor = Color.Green
                lbl_CpuUsage.ForeColor = Color.White
                lbl_CpuUsage.Text = CStr(CpuRateF)
            Case 80 To 90
                OvalShape1.FillColor = Color.Yellow
                lbl_CpuUsage.BackColor = Color.Yellow
                lbl_CpuUsage.ForeColor = Color.Green
                lbl_CpuUsage.Text = CStr(CpuRateF)
            Case 90 To 100
                OvalShape1.FillColor = Color.Red
                lbl_CpuUsage.BackColor = Color.Red
                lbl_CpuUsage.ForeColor = Color.White
                lbl_CpuUsage.Text = CStr(CpuRateF)
            Case Else
                OvalShape1.FillColor = Color.Red
                lbl_CpuUsage.BackColor = Color.Red
                lbl_CpuUsage.ForeColor = Color.White
                lbl_CpuUsage.Text = "?"
        End Select
        Select Case Memory_Usage_Per
            Case 0 To 80
                OvalShape2.FillColor = Color.Green
                lbl_MemUsage.BackColor = Color.Green
                lbl_MemUsage.ForeColor = Color.White
                lbl_MemUsage.Text = CStr(Memory_Usage_Per)
            Case 80 To 90
                OvalShape2.FillColor = Color.Yellow
                lbl_MemUsage.BackColor = Color.Yellow
                lbl_MemUsage.ForeColor = Color.Green
                lbl_MemUsage.Text = CStr(Memory_Usage_Per)
            Case 90 To 100
                OvalShape2.FillColor = Color.Red
                lbl_MemUsage.BackColor = Color.Red
                lbl_MemUsage.ForeColor = Color.White
                lbl_MemUsage.Text = CStr(Memory_Usage_Per)
            Case Else
                OvalShape2.FillColor = Color.Red
                lbl_MemUsage.BackColor = Color.Red
                lbl_MemUsage.ForeColor = Color.White
                lbl_MemUsage.Text = "?"
        End Select



    End Sub

    End Class

