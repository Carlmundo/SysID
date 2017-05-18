Imports System.Management
Public Class Main
    Private Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As Integer, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Integer) As Integer

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim RAM_Total, RAM_Max, RAM_Slots, RAM_Type, RAM_Manufacturer, RAM_Capacity, strRAM_Extra As String
        Dim obj As Management.ManagementObject
        Dim objManufacturer = New ManagementObjectSearcher("Select * From Win32_BIOS").Get
        Dim objProcessor = New ManagementObjectSearcher("Select * From Win32_Processor").Get
        Dim objRAM = New ManagementObjectSearcher("Select * From Win32_PhysicalMemoryArray").Get
        Dim objRAM_Extra = New ManagementObjectSearcher("Select * From Win32_PhysicalMemory").Get
        Dim objOpticalDrive = New ManagementObjectSearcher("Select * From Win32_CDROMDrive").Get
        Dim OpticalDriveCount As Integer = 0
        Dim objGraphicsCard = New ManagementObjectSearcher("Select * From Win32_VideoController").Get
        Dim SpaceTotal = My.Computer.FileSystem.GetDriveInfo(System.Environment.ExpandEnvironmentVariables("%SystemDrive%")).TotalSize
        Dim SpaceFree = My.Computer.FileSystem.GetDriveInfo(System.Environment.ExpandEnvironmentVariables("%SystemDrive%")).TotalFreeSpace

        For Each obj In objManufacturer
            lblManufacturer.Text = obj("Manufacturer")
        Next
        If My.Computer.Registry.LocalMachine.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\OEMInformation") Is Nothing Then
            hdManufacturer.Visible = False
            hdModel.Visible = False
            lblManufacturer.Visible = False
            lblModel.Visible = False
        Else
            If My.Computer.Registry.LocalMachine.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\OEMInformation").GetValue("Manufacturer") Is Nothing Then
                hdManufacturer.Visible = False
                lblManufacturer.Visible = False
            Else
                lblManufacturer.Text = My.Computer.Registry.LocalMachine.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\OEMInformation").GetValue("Manufacturer")
            End If

            If My.Computer.Registry.LocalMachine.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\OEMInformation").GetValue("Model") Is Nothing Then
                hdModel.Visible = False
                lblModel.Visible = False
            Else
                lblModel.Text = My.Computer.Registry.LocalMachine.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\OEMInformation").GetValue("Model")
            End If

        End If

        lblOS.Text = My.Computer.Info.OSFullName
        lblOS.Text = Replace(lblOS.Text, "Microsoft ", "")

        For Each obj In objProcessor
            lblProcessor.Text = obj("Name")
        Next

        lblProcessor.Text = Replace(lblProcessor.Text, "(R)", "")
        lblProcessor.Text = Replace(lblProcessor.Text, "(TM)", "")
        lblProcessor.Text = Replace(lblProcessor.Text, "CPU", "")
        lblProcessor.Text = Replace(lblProcessor.Text, "  ", " ")
        lblProcessor.Text = Replace(lblProcessor.Text, "  ", " ")

        If My.Computer.Info.TotalPhysicalMemory < 1073741824 Then
            RAM_Total = Format(My.Computer.Info.TotalPhysicalMemory / 1024 / 1024, "###,###") & " MB"
        Else
            RAM_Total = Format(My.Computer.Info.TotalPhysicalMemory / 1024 / 1024 / 1024, "###") & " GB"
        End If

        For Each obj In objRAM
            If obj("MaxCapacity") < 1048576 Then
                RAM_Max = obj("MaxCapacity") / 1024 & " MB"
            ElseIf obj("MaxCapacity") = 0 Then
                RAM_Max = "Unknown"
            Else
                RAM_Max = obj("MaxCapacity") / 1048576 & " GB"
            End If
            RAM_Slots = obj("MemoryDevices")
        Next

        lblRAM.Text = RAM_Total & " (Max. " & RAM_Max & ")"

        Dim i
        i = 0
        For Each obj In objRAM_Extra
            If obj("Manufacturer") = "0000" Then
                RAM_Manufacturer = ""
            End If
            If obj("Capacity") >= "1073741824" Then
                RAM_Capacity = obj("Capacity") / 1073741824 & " GB"
            Else
                RAM_Capacity = obj("Capacity") / 1048576 & " MB"
            End If
            If obj("MemoryType") = 0 Or 22 Then
                RAM_Type = "DDR3"
            ElseIf obj("MemoryType") = 20 Then
                RAM_Type = "DDR"
            ElseIf obj("MemoryType") = 21 Then
                RAM_Type = "DDR2"
            Else
                RAM_Type = ""
            End If


            If strRAM_Extra <> "" Then strRAM_Extra = strRAM_Extra & vbCrLf
            strRAM_Extra = strRAM_Extra & "Slot " & i + 1 & ": " & RAM_Manufacturer & RAM_Capacity & " " & RAM_Type & " " & obj("Speed") & "Mhz"
            i = i + 1
        Next
        strRAM_Extra = "Total Slots: " & RAM_Slots & vbCrLf & "Free Slots: " & (RAM_Slots - i) & vbCrLf & vbCrLf & strRAM_Extra
        lblRAM_Extra.Text = strRAM_Extra
        Try
            For Each obj In objOpticalDrive
                OpticalDriveCount += 1
            Next
        Catch
            lblOpticalDrive.Text = "Not Detected"
        End Try
        If OpticalDriveCount = 0 Then
            lblOpticalDrive.Text = "No"
        Else
            lblOpticalDrive.Text = "Yes"
        End If

        For Each obj In objGraphicsCard
            lblGraphicsCard.Text = obj("Name")
            lblGraphicsCard.Text = Replace(lblGraphicsCard.Text, "(R)", "")
        Next


        If My.Computer.Registry.ClassesRoot.OpenSubKey("Word.Application\CurVer") Is Nothing Then
            lblOffice.Text = "Not Installed"
        Else
            Dim OfficeReg = My.Computer.Registry.ClassesRoot.OpenSubKey("Word.Application\CurVer")
            If OfficeReg.GetValue("") = "Word.Application.11" Then
                lblOffice.Text = "2003"
            ElseIf OfficeReg.GetValue("") = "Word.Application.12" Then
                lblOffice.Text = "2007"
            ElseIf OfficeReg.GetValue("") = "Word.Application.14" Then
                lblOffice.Text = "2010"
            ElseIf OfficeReg.GetValue("") = "Word.Application.15" Then
                lblOffice.Text = "2013"
            ElseIf OfficeReg.GetValue("") = "Word.Application.16" Then
                lblOffice.Text = "2016"
            Else
                lblOffice.Text = Replace(OfficeReg.GetValue(""), "Word.Application.", "Version ")
            End If
        End If

        If SpaceTotal < 1099511627776 Then
            lblTotalSpace.Text = Format(SpaceTotal / 1073741824, "##0.##") & " GB"
        ElseIf SpaceTotal >= 1099511627776 Then
            lblTotalSpace.Text = Format(SpaceTotal / 1099511627776, "###,##0.##") & " TB"
        End If

        If SpaceFree < 1073741824 Then
            lblFreeSpace.Text = Format(SpaceFree / 1048576, "##0") & " MB"
        ElseIf SpaceFree >= 1073741824 Then
            lblFreeSpace.Text = Format(SpaceFree / 1073741824, "##0.##") & " GB"
        ElseIf SpaceFree >= 1099511627776 Then
            lblFreeSpace.Text = Format(SpaceFree / 1099511627776, "###,##0.##") & " TB"
        End If
    End Sub

    Private Sub cmdExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExport.Click
        FileOpen(22, Environ("temp") & "\PC Specs.txt", OpenMode.Output)

        If lblManufacturer.Visible = True Then
            PrintLine(22, hdManufacturer.Text & ": " & lblManufacturer.Text)
        End If
        If lblModel.Visible = True Then
            PrintLine(22, hdModel.Text & ": " & lblModel.Text)
        End If
        PrintLine(22, hdOS.Text & ": " & lblOS.Text)
        PrintLine(22, hdProcessor.Text & ": " & lblProcessor.Text)
        PrintLine(22, hdRAM.Text & ": " & lblRAM.Text)
        PrintLine(22, "")
        PrintLine(22, lblRAM_Extra.Text)
        PrintLine(22, "")
        PrintLine(22, hdOpticalDrive.Text & ": " & lblOpticalDrive.Text)
        PrintLine(22, hdGraphicsCard.Text & ": " & lblGraphicsCard.Text)
        PrintLine(22, hdOffice.Text & ": " & lblOffice.Text)
        PrintLine(22, hdFreeSpace.Text & ": " & lblFreeSpace.Text)
        PrintLine(22, hdTotalSpace.Text & ": " & lblTotalSpace.Text)
        ShellExecute(0, vbNullString, "notepad", Environ("temp") & "\PC Specs.txt", vbNullString, AppWinStyle.NormalFocus)
        FileClose(22)

    End Sub

    Private Sub cbRAM_Extra_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbRAM_Extra.CheckedChanged
        If cbRAM_Extra.Checked = True Then
            lblRAM_Extra.Visible = True
        Else
            lblRAM_Extra.Visible = False
        End If
    End Sub
End Class
