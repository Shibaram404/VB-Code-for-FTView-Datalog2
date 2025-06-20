Private TagGroup As TagGroup

Private Major_Triger As Tag
Private MV06_BATCH_STARTED_BIT As Tag
Private MV06_BATCH_OVER_BIT As Tag
Private MV06_MAT1_START As Tag
Private MV06_MAT1_STOP As Tag
Private MV06_MAT2_START As Tag
Private MV06_MAT2_STOP As Tag
Private MV06_MAT3_START As Tag
Private MV06_MAT3_STOP As Tag
Private MV06_MAT4_START As Tag
Private MV06_MAT4_STOP As Tag
Private MV06_MAT5_START As Tag
Private MV06_MAT5_STOP As Tag
Private MV06_MAT6_START As Tag
Private MV06_MAT6_STOP As Tag
Private MV06_MAT7_START As Tag
Private MV06_MAT7_STOP As Tag
Private MV06_MAT8_START As Tag
Private MV06_MAT8_STOP As Tag
Private MV06_MAT9_START As Tag
Private MV06_MAT9_STOP As Tag
Private MV06_MAT10_START As Tag
Private MV06_MAT10_STOP As Tag
Private MV06_QUALITY_VISIBLE_BIT As Tag
Private MV06_QUALITY_OVER_DB_BIT As Tag

Private Value1 As Variant
Private Value2 As Variant
Private Value3 As Variant
Private Value4 As Variant
Private Value5 As Variant
Private Value6 As Variant
Private Value7 As Variant
Private Value8 As Variant
Private Value9 As Variant
Private Value10 As Variant
Private Value11 As Variant
Private Value12 As Variant
Private Value13 As Variant
Private Value14 As Variant
Private Value15 As Variant
Private Value16 As Variant
Private Value17 As Variant
Private Value18 As Variant
Private Value19 As Variant
Private Value20 As Variant
Private Value21 As Variant
Private Value22 As Variant
Private Value23 As Variant
Private Value24 As Variant
Private Value25 As Variant
Private Value26 As Variant
Private Value27 As Variant
Private Value28 As Variant
Private Value29 As Variant
Private Value30 As Variant




'--------------------------------------------------------------

'==============================================
' Tags for PO Number Write
Private Sub SetUpTagGroup()
On Error Resume Next
Err.Clear

    If TagGroup Is Nothing Then
        Set TagGroup = Application.CreateTagGroup(This, 500)
                If Err.Number Then
                    LogDiagnosticsMessage "Error Creating TagGroup.Error:" _
                    & Err.Description, ftDiagSeverityError
                    Exit Sub
                End If
        
        TagGroup.Add "[MARICO]MAJOR_LOG"
        TagGroup.Add "[MARICO]MV06_BATCH_STARTED_BIT"
        TagGroup.Add "[MARICO]MV06_BATCH_OVER_BIT"
        TagGroup.Add "[MARICO]MV06_MAT1_START"
        TagGroup.Add "[MARICO]MV06_MAT1_STOP"
        TagGroup.Add "[MARICO]MV06_MAT2_START"
        TagGroup.Add "[MARICO]MV06_MAT2_STOP"
        TagGroup.Add "[MARICO]MV06_MAT3_START"
        TagGroup.Add "[MARICO]MV06_MAT3_STOP"
        TagGroup.Add "[MARICO]MV06_MAT4_START"
        TagGroup.Add "[MARICO]MV06_MAT4_STOP"
        TagGroup.Add "[MARICO]MV06_MAT5_START"
        TagGroup.Add "[MARICO]MV06_MAT5_STOP"
        TagGroup.Add "[MARICO]MV06_MAT6_START"
        TagGroup.Add "[MARICO]MV06_MAT6_STOP"
        TagGroup.Add "[MARICO]MV06_MAT7_START"
        TagGroup.Add "[MARICO]MV06_MAT7_STOP"
        TagGroup.Add "[MARICO]MV06_MAT8_START"
        TagGroup.Add "[MARICO]MV06_MAT8_STOP"
        TagGroup.Add "[MARICO]MV06_MAT9_START"
        TagGroup.Add "[MARICO]MV06_MAT9_STOP"
        TagGroup.Add "[MARICO]MV06_MAT10_START"
        TagGroup.Add "[MARICO]MV06_MAT10_STOP"
        TagGroup.Add "[MARICO]MV06_QUALITY_VISIBLE_BIT"
        TagGroup.Add "[MARICO]MV06_QUALITY_OVER_DB_BIT"
        
        
        
        
        TagGroup.Active = True
    End If

            If Err.Description <> "" Then
                Call errorlog("Case-1: " & Err.Description)  'Error Log to Notepad
            End If
            
End Sub

Private Sub ShowTagDataInfo()
On Error Resume Next
Dim TimeStamp As Date
Dim Quality As tagQualityConstants
Dim SubStatus As tagSubStatusConstants
Dim Limit As tagLimitConstants

On Error Resume Next
If Not TagGroup Is Nothing Then


    Set Major_Triger = TagGroup.Item("[MARICO]MAJOR_LOG")
    Set MV06_BATCH_STARTED_BIT = TagGroup.Item("[MARICO]MV06_BATCH_STARTED_BIT")
    Set MV06_BATCH_OVER_BIT = TagGroup.Item("[MARICO]MV06_BATCH_OVER_BIT")
    Set MV06_MAT1_START = TagGroup.Item("[MARICO]MV06_MAT1_START")
    Set MV06_MAT1_STOP = TagGroup.Item("[MARICO]MV06_MAT1_STOP")
    Set MV06_MAT2_START = TagGroup.Item("[MARICO]MV06_MAT2_START")
    Set MV06_MAT2_STOP = TagGroup.Item("[MARICO]MV06_MAT2_STOP")
    Set MV06_MAT3_START = TagGroup.Item("[MARICO]MV06_MAT3_START")
    Set MV06_MAT3_STOP = TagGroup.Item("[MARICO]MV06_MAT3_STOP")
    Set MV06_MAT4_START = TagGroup.Item("[MARICO]MV06_MAT4_START")
    Set MV06_MAT4_STOP = TagGroup.Item("[MARICO]MV06_MAT4_STOP")
    Set MV06_MAT5_START = TagGroup.Item("[MARICO]MV06_MAT5_START")
    Set MV06_MAT5_STOP = TagGroup.Item("[MARICO]MV06_MAT5_STOP")
    Set MV06_MAT6_START = TagGroup.Item("[MARICO]MV06_MAT6_START")
    Set MV06_MAT6_STOP = TagGroup.Item("[MARICO]MV06_MAT6_STOP")
    Set MV06_MAT7_START = TagGroup.Item("[MARICO]MV06_MAT7_START")
    Set MV06_MAT7_STOP = TagGroup.Item("[MARICO]MV06_MAT7_STOP")
    Set MV06_MAT8_START = TagGroup.Item("[MARICO]MV06_MAT8_START")
    Set MV06_MAT8_STOP = TagGroup.Item("[MARICO]MV06_MAT8_STOP")
    Set MV06_MAT9_START = TagGroup.Item("[MARICO]MV06_MAT9_START")
    Set MV06_MAT9_STOP = TagGroup.Item("[MARICO]MV06_MAT9_STOP")
    Set MV06_MAT10_START = TagGroup.Item("[MARICO]MV06_MAT10_START")
    Set MV06_MAT10_STOP = TagGroup.Item("[MARICO]MV06_MAT10_STOP")
    Set MV06_QUALITY_VISIBLE_BIT = TagGroup.Item("[MARICO]MV06_QUALITY_VISIBLE_BIT")
    Set MV06_QUALITY_OVER_DB_BIT = TagGroup.Item("[MARICO]MV06_QUALITY_OVER_DB_BIT")
    
    
    
    Err.Clear
    
    Major_Triger.GetTagData Value1, TimeStamp, Quality, SubStatus, Limit, True
    MV06_BATCH_STARTED_BIT.GetTagData Value2, TimeStamp, Quality, SubStatus, Limit, True
    MV06_BATCH_OVER_BIT.GetTagData Value3, TimeStamp, Quality, SubStatus, Limit, True
    MV06_MAT1_START.GetTagData Value4, TimeStamp, Quality, SubStatus, Limit, True
    MV06_MAT1_STOP.GetTagData Value5, TimeStamp, Quality, SubStatus, Limit, True
    MV06_MAT2_START.GetTagData Value6, TimeStamp, Quality, SubStatus, Limit, True
    MV06_MAT2_STOP.GetTagData Value7, TimeStamp, Quality, SubStatus, Limit, True
    MV06_MAT3_START.GetTagData Value8, TimeStamp, Quality, SubStatus, Limit, True
    MV06_MAT3_STOP.GetTagData Value9, TimeStamp, Quality, SubStatus, Limit, True
    MV06_MAT4_START.GetTagData Value10, TimeStamp, Quality, SubStatus, Limit, True
    MV06_MAT4_STOP.GetTagData Value11, TimeStamp, Quality, SubStatus, Limit, True
    MV06_MAT5_START.GetTagData Value12, TimeStamp, Quality, SubStatus, Limit, True
    MV06_MAT5_STOP.GetTagData Value13, TimeStamp, Quality, SubStatus, Limit, True
    MV06_MAT6_START.GetTagData Value14, TimeStamp, Quality, SubStatus, Limit, True
    MV06_MAT6_STOP.GetTagData Value15, TimeStamp, Quality, SubStatus, Limit, True
    MV06_MAT7_START.GetTagData Value16, TimeStamp, Quality, SubStatus, Limit, True
    MV06_MAT7_STOP.GetTagData Value17, TimeStamp, Quality, SubStatus, Limit, True
    MV06_MAT8_START.GetTagData Value18, TimeStamp, Quality, SubStatus, Limit, True
    MV06_MAT8_STOP.GetTagData Value19, TimeStamp, Quality, SubStatus, Limit, True
    MV06_MAT9_START.GetTagData Value20, TimeStamp, Quality, SubStatus, Limit, True
    MV06_MAT9_STOP.GetTagData Value21, TimeStamp, Quality, SubStatus, Limit, True
    MV06_MAT10_START.GetTagData Value22, TimeStamp, Quality, SubStatus, Limit, True
    MV06_MAT10_STOP.GetTagData Value23, TimeStamp, Quality, SubStatus, Limit, True
    MV06_QUALITY_VISIBLE_BIT.GetTagData Value24, TimeStamp, Quality, SubStatus, Limit, True
    MV06_QUALITY_OVER_DB_BIT.GetTagData Value25, TimeStamp, Quality, SubStatus, Limit, True


    '==============================================
 
 End If
 
             If Err.Description <> "" Then
                Call errorlog("Case-2: " & Err.Description) 'Error Log to Notepad
            End If
            
End Sub

'Loop-1 BATCH Start Data Insert at the time of Batch Start in table "MFG_RollUp"

Public Sub BatchStartInsert(BATCH_NO As String, PRODUCT_NAME As String, VESSEL_NAME As String, BATCH_QTY As Double, BATCH_SIZE As String, BATCH_SPGR As String)
On Error Resume Next

Dim dt As String

Dim objConnection As ADODB.Connection
Dim objCommand As ADODB.Command

Dim strConnectionString As String
Dim objRecordset1 As ADODB.Recordset
Dim objRecordset2 As ADODB.Recordset

Dim strSQL1 As String

Set objConnection = New ADODB.Connection
Set objRecordset1 = New ADODB.Recordset
Set objRecordset2 = New ADODB.Recordset

Call conn.Link
objConnection.ConnectionString = DBConn
objConnection.Open

If Err.Description <> "" Then
    'MsgBox "DATABASE CONNECTION ERROR: " & Err.Description
    Call errorlog("Case-3: " & Err.Description) 'Error Log to Notepad
    Exit Sub
Else

    dt = Format(Now, "yyyy-mm-dd HH:mm:ss")
    
                '======================================================================
                    strSQL1 = "Select BATCH_NO from MFG_RollUp_DUP where BATCH_NO = '" & BATCH_NO & "' and BATCH_START > dateadd (day, -2, getdate()) and BATCH_STOP is Null"
                    'MsgBox strSQL1
                    objRecordset1.Open strSQL1, objConnection, adOpenKeyset
                '======================================================================
       
        If objRecordset1.RecordCount = 0 Then

        
        '=======================================================

        strSQL2 = "Select Top (1) * from MFG_RollUp_DUP"
        Set objRecordset2 = CreateObject("ADODB.Recordset"): objRecordset2.Open strSQL2, objConnection, 1, 3
        objRecordset2.AddNew
            objRecordset2.Fields("DateAndTime").Value = dt
            objRecordset2.Fields("BATCH_NO").Value = BATCH_NO
            objRecordset2.Fields("BATCH_START").Value = dt
            objRecordset2.Fields("PRODUCT_NAME").Value = PRODUCT_NAME
            objRecordset2.Fields("VESSEL_NAME").Value = VESSEL_NAME
            objRecordset2.Fields("BATCH_QTY").Value = BATCH_QTY
            objRecordset2.Fields("BATCH_SIZE").Value = BATCH_SIZE
            objRecordset2.Fields("BATCH_SPGR").Value = BATCH_SPGR

        
        objRecordset2.Update
        'objRecordset2.Close: Set objRecordset2 = Nothing
       ' MsgBox Err.Description
       '===========================================================
        
        End If
        
            
            If Err.Description <> "" Then
                Call errorlog("Case-4: " & Err.Description) 'Error Log to Notepad
            End If
        


End If
           

objRecordset1.Close
objRecordset2.Close
Set objRecordset1 = Nothing
Set objRecordset2 = Nothing
objConnection.Close
Set objConnection = Nothing
Set objCommand = Nothing
End Sub



'Loop-1 BATCH End Data Update at the time of Batch Completion in table "MFG_RollUp"

Public Sub BatchStopUpdate(BATCH_NO As String, PRODUCT_NAME As String, QC_START As String)
On Error Resume Next

Dim dt As String
Dim QCST As String

Dim objConnection As ADODB.Connection
Dim objCommand As ADODB.Command

Dim strConnectionString As String
Dim objRecordset1 As ADODB.Recordset
Dim objRecordset2 As ADODB.Recordset

Dim strSQL1 As String

Set objConnection = New ADODB.Connection
Set objRecordset1 = New ADODB.Recordset
Set objRecordset2 = New ADODB.Recordset

Call conn.Link
objConnection.ConnectionString = DBConn
objConnection.Open

If Err.Description <> "" Then
    'MsgBox "DATABASE CONNECTION ERROR: " & Err.Description
    Call errorlog("Case-3: " & Err.Description) 'Error Log to Notepad
    Exit Sub
Else

    dt = Format(Now, "yyyy-mm-dd HH:mm:ss")
    QCST = Format(QC_START, "yyyy-mm-dd HH:mm:ss")
         
       
                '======================================================================
                    strSQL1 = "Update MFG_RollUp_DUP set BATCH_STOP  = '" & dt & "', LOG_DATA = 1, QC_START = cast('" & QC_START & "' as datetime), QC_STOP = '" & dt & "' where BATCH_STOP is null and BATCH_NO like '" & BATCH_NO & "' and PRODUCT_NAME like '" & PRODUCT_NAME & "' and DateAndTime between dateadd (day, -2, getdate()) and getdate()"
                    ''strSQL1 = "Update MFG_RollUp_DUP set BATCH_STOP  = '" & dt & "', LOG_DATA = 1, QC_START = '" & QCST & "', QC_STOP = '" & dt & "', where BATCH_STOP is null and BATCH_NO like '" & BATCH_NO & "' and PRODUCT_NAME like '" & PRODUCT_NAME & "' and BATCH_START > dateadd (day, -2, getdate())"
                    'MsgBox strSQL1
                    objRecordset1.Open strSQL1, objConnection, adOpenKeyset
                '======================================================================
        
            If Err.Description <> "" Then
                Call errorlog("Case-4: " & Err.Description) 'Error Log to Notepad
            
            Else
                Call SetUpTagGroup
                Call ShowTagDataInfo
    
                Major_Triger.Value = 0
            End If
        
End If
           
Set objCommand = Nothing
objConnection.Close
Set objRecordset1 = Nothing

Set objConnection = Nothing

End Sub


'Loop-1 BATCH wise MAJOR Items Addition Insert/Update at the time of material Addition in table "MFG_RollUp"

 Sub MajorAddInsert(BATCH_NO As String, BATCH_START As String, PRODUCT_NAME As String, VESSEL_NAME As String, ACT_QTY As Double, NAME As String, STD_QTY As Double, AR_NO As String, BATCH_QTY As Double, BATCH_SIZE As String, BATCH_SPGR As String)
On Error Resume Next


Dim dt As String
Dim BST As String

Dim objConnection As ADODB.Connection
Dim objCommand As ADODB.Command

Dim strConnectionString As String
Dim objRecordset1 As ADODB.Recordset
Dim objRecordset2 As ADODB.Recordset
Dim objRecordset3 As ADODB.Recordset


Dim strSQL1 As String
Dim strSQL2 As String
Dim strSQL3 As String

Set objConnection = New ADODB.Connection
Set objRecordset1 = New ADODB.Recordset
Set objRecordset2 = New ADODB.Recordset
Set objRecordset3 = New ADODB.Recordset


Call conn.Link
objConnection.ConnectionString = DBConn
objConnection.Open

If Err.Description <> "" Then
    'MsgBox "DATABASE CONNECTION ERROR: " & Err.Description
    Call errorlog("Case-3: " & Err.Description) 'Error Log to Notepad
    Exit Sub
Else

    dt = Format(Now, "yyyy-mm-dd HH:mm:ss")
   
    BATCH_START = dt
    
                '======================================================================
                    strSQL1 = "Select top (1) * from MFG_RollUp_DUP where BATCH_NO like '" & BATCH_NO & "' and BATCH_START is not Null and BATCH_START between dateadd (day, -2, getdate()) and getdate() and BATCH_STOP is  Null order by DateAndTime Desc"
                    'MsgBox strSQL1
                    objRecordset1.Open strSQL1, objConnection, adOpenKeyset
                '======================================================================

         If objRecordset1.RecordCount > 0 Then
         
            '======================================================================
                strSQL1 = "Select top (1) * from MFG_RollUp_DUP where BATCH_NO like '" & BATCH_NO & "' and PRODUCT_NAME = '" & PRODUCT_NAME & "' and BATCH_START is not Null and BATCH_START between dateadd (day, -2, getdate()) and getdate() order by DateAndTime Desc"
                'MsgBox strSQL1
                objRecordset3.Open strSQL1, objConnection, adOpenKeyset
            '======================================================================
         
            BATCH_START = objRecordset3.Fields("BATCH_START").Value
            PRODUCT_NAME = objRecordset3.Fields("PRODUCT_NAME").Value
            BATCH_NO = objRecordset3.Fields("BATCH_NO").Value
            VESSEL_NAME = objRecordset3.Fields("VESSEL_NAME").Value
            NAME = objRecordset3.Fields("NAME").Value
            
            If objRecordset1.Fields("BATCH_QTY").Value <> 0 Then
                BATCH_QTY = objRecordset3.Fields("BATCH_QTY").Value
            End If
            
            If objRecordset1.Fields("BATCH_SIZE").Value <> 0 Then
                BATCH_SIZE = objRecordset3.Fields("BATCH_SIZE").Value
            End If
            
            If objRecordset1.Fields("BATCH_SPGR").Value <> 0 Then
                BATCH_SPGR = objRecordset3.Fields("BATCH_SPGR").Value
            End If
            
            
        End If

            
        strSQL2 = "INSERT INTO MFG_RollUp_DUP (DateAndTime, BATCH_NO, BATCH_START, PRODUCT_NAME, VESSEL_NAME, NAME, START_TIME, STD_QTY, AR_NO, BATCH_QTY, BATCH_SIZE, BATCH_SPGR) VALUES "
        strSQL2 = strSQL2 & "('" & dt & "', '" & BATCH_NO & "', Cast('" & BATCH_START & "' as datetime), '" & PRODUCT_NAME & "', '" & VESSEL_NAME & "', '" & NAME & "', '" & dt & "', " & STD_QTY & ", '" & AR_NO & "', " & BATCH_QTY & ", '" & BATCH_SIZE & "', '" & BATCH_SPGR & "')"
        ''MsgBox strSQL2
        objRecordset2.Open strSQL2, objConnection, adOpenKeyset
        '=======================================================

       ' strSQL2 = "Select Top (1) * from MFG_RollUp_DUP"
       ' Set objRecordset2 = CreateObject("ADODB.Recordset"): objRecordset2.Open strSQL2, objConnection, 1, 3
       ' objRecordset2.AddNew
         '   objRecordset2.Fields("DateAndTime").Value = dt
         '   objRecordset2.Fields("BATCH_NO").Value = BATCH_NO
          '  objRecordset2.Fields("BATCH_START").Value = BST
           ' objRecordset2.Fields("PRODUCT_NAME").Value = PRODUCT_NAME
        '    objRecordset2.Fields("VESSEL_NAME").Value = VESSEL_NAME
         '   objRecordset2.Fields("NAME").Value = NAME
          '  objRecordset2.Fields("START_TIME").Value = dt
           ' objRecordset2.Fields("STD_QTY").Value = STD_QTY
       '     objRecordset2.Fields("AR_NO").Value = AR_NO
        '    objRecordset2.Fields("BATCH_QTY").Value = BATCH_QTY
         '   objRecordset2.Fields("BATCH_SIZE").Value = BATCH_SIZE
          '  objRecordset2.Fields("BATCH_SPGR").Value = BATCH_SPGR
      '  objRecordset2.Update
       ' objRecordset2.Close: Set objRecordset2 = Nothing
        
       '===========================================================
        
            If Err.Description <> "" Then
                Call errorlog("Case-4: " & Err.Description) 'Error Log to Notepad
            End If
        

End If
           
Set objCommand = Nothing
objRecordset1.Close
Set objRecordset1 = Nothing

objRecordset2.Close
Set objRecordset2 = Nothing

objRecordset3.Close
Set objRecordset3 = Nothing

objConnection.Close
Set objConnection = Nothing

End Sub




'Loop-1 BATCH wise MAJOR Items Addition Insert/Update at the End of material Addition in table "MFG_RollUp"

 Sub MajorAddUpdate(BATCH_NO As String, BATCH_START As String, PRODUCT_NAME As String, VESSEL_NAME As String, ACT_QTY As Double, NAME As String, START_TIME As String, STD_QTY As Double, AR_NO As String, BATCH_QTY As Double, BATCH_SIZE As String, BATCH_SPGR As String)
On Error Resume Next


Dim dt As String
Dim ST As String

Dim objConnection As ADODB.Connection
Dim objCommand As ADODB.Command

Dim strConnectionString As String
Dim objRecordset1 As ADODB.Recordset
Dim objRecordset2 As ADODB.Recordset
Dim objRecordset3 As ADODB.Recordset


Dim strSQL1 As String
Dim strSQL2 As String
Dim strSQL3 As String

Set objConnection = New ADODB.Connection
Set objRecordset1 = New ADODB.Recordset
Set objRecordset2 = New ADODB.Recordset
Set objRecordset3 = New ADODB.Recordset


Call conn.Link
objConnection.ConnectionString = DBConn
objConnection.Open

If Err.Description <> "" Then
    'MsgBox "DATABASE CONNECTION ERROR: " & Err.Description
    Call errorlog("Case-3: " & Err.Description) 'Error Log to Notepad
    Exit Sub
Else

    dt = Format(Now, "yyyy-mm-dd HH:mm:ss")
    ST = Format(START_TIME, "yyyy-mm-dd HH:mm:ss")
    
    
    
''Dim theDate As Date

''Dim yyyy1 As Integer
''Dim mm1 As Integer
''Dim dd1 As Integer
''Dim hh1 As Integer
''Dim mn1 As Integer

''yyyy1 = Mid(BATCH_START, 1, 4)
''MsgBox yyyy1
''mm1 = Mid(BATCH_START, 6, 1)
''MsgBox mm1
''dd1 = Mid(BATCH_START, 8, 2)
''MsgBox dd1

''hh1 = Mid(BATCH_START, 11, 2)
''MsgBox hh1
''mn1 = Mid(BATCH_START, 14, 2)
''MsgBox mn1

''theDate = DateSerial(yyyy1, mm1, dd1) + TimeSerial(hh1, mm1, 1)
    
                '======================================================================
                    strSQL1 = "Select top (1) * from MFG_RollUp_DUP where BATCH_NO like '" & BATCH_NO & "' and NAME = '" & NAME & "' and BATCH_START between dateadd (day, -2, getdate()) and getdate() and BATCH_STOP is Null"
                    ''MsgBox strSQL1
                    objRecordset1.Open strSQL1, objConnection, adOpenKeyset
                '======================================================================
         ''MsgBox objRecordset1.RecordCount
        
         If objRecordset1.RecordCount > 0 Then
                '======================================================================
                    strSQL1 = "Update MFG_RollUp_DUP set STOP_TIME  = '" & dt & "', AR_NO = '" & AR_NO & "', LOG_DATA = 1, ACT_QTY = " & ACT_QTY & " where BATCH_STOP is null and STOP_TIME is null and BATCH_NO like '" & BATCH_NO & "' and BATCH_START between dateadd (day, -2, getdate()) and getdate() and NAME = '" & NAME & "'"
                    ''MsgBox strSQL1
                    objRecordset3.Open strSQL1, objConnection, adOpenKeyset
                '======================================================================

      Else
            
        strSQL2 = "INSERT INTO MFG_RollUp_DUP (DateAndTime, BATCH_NO, BATCH_START, LOG_DATA, PRODUCT_NAME, VESSEL_NAME, ACT_QTY, NAME, START_TIME, STD_QTY, STOP_TIME, AR_NO) VALUES "
        strSQL2 = strSQL2 & "('" & dt & "', '" & BATCH_NO & "', Cast('" & BATCH_START & "' as datetime), 1, '" & PRODUCT_NAME & "', '" & VESSEL_NAME & "', " & ACT_QTY & ", '" & NAME & "', Cast('" & START_TIME & "' as datetime), " & STD_QTY & ", '" & dt & "', '" & AR_NO & "')"
        'MsgBox strSQL2
        objRecordset2.Open strSQL2, objConnection, adOpenKeyset
        '=======================================================
        'MsgBox Err.Description
        

        End If
        
            If Err.Description <> "" Then
                Call errorlog("Case-4: " & Err.Description) 'Error Log to Notepad
            End If
        

End If
           
Set objCommand = Nothing
objRecordset1.Close
Set objRecordset1 = Nothing

objRecordset2.Close
Set objRecordset2 = Nothing

objRecordset3.Close
Set objRecordset3 = Nothing

objConnection.Close
Set objConnection = Nothing

End Sub

Private Sub Button6_Released()

End Sub


'Loop-1 BATCH wise QA Start Insert at the Begening of QA Start in table "MFG_RollUp"

 Sub QualityStart(BATCH_NO As String, PRODUCT_NAME As String, QC_START As String)
On Error Resume Next


Dim dt As String

Dim objConnection As ADODB.Connection
Dim objCommand As ADODB.Command

Dim strConnectionString As String
Dim objRecordset1 As ADODB.Recordset
Dim objRecordset2 As ADODB.Recordset
Dim objRecordset3 As ADODB.Recordset


Dim strSQL1 As String
Dim strSQL2 As String
Dim strSQL3 As String

Set objConnection = New ADODB.Connection
Set objRecordset1 = New ADODB.Recordset
'Set objRecordset2 = New ADODB.Recordset
Set objRecordset3 = New ADODB.Recordset


Call conn.Link
objConnection.ConnectionString = DBConn
objConnection.Open

If Err.Description <> "" Then
    'MsgBox "DATABASE CONNECTION ERROR: " & Err.Description
    Call errorlog("Case-3: " & Err.Description) 'Error Log to Notepad
    Exit Sub
Else

    dt = Format(Now, "yyyy-mm-dd HH:mm:ss")
    
    
                '======================================================================
                    strSQL1 = "Update MFG_RollUp_DUP set QC_START  = '" & dt & "' where BATCH_NO like '" & BATCH_NO & "' and PRODUCT_NAME like '" & PRODUCT_NAME & "' and BATCH_START > dateadd (day, -2, getdate()) and QC_START is Null"
                    'MsgBox strSQL1
                    objRecordset1.Open strSQL1, objConnection, adOpenKeyset
                '======================================================================
         
        
            If Err.Description <> "" Then
                Call errorlog("Case-4: " & Err.Description) 'Error Log to Notepad
            End If
        


End If
           
Set objCommand = Nothing
objRecordset1.Close
Set objRecordset1 = Nothing

'objRecordset2.Close
'Set objRecordset2 = Nothing

objConnection.Close
Set objConnection = Nothing

End Sub


'Loop-1 BATCH wise QA Over Update at the End of QA Start in table "MFG_RollUp"

 Sub QualityOver(BATCH_NO As String, PRODUCT_NAME As String, QC_START As String, BATCH_QTY As Double, BATCH_SIZE As String, BATCH_SPGR As String)
On Error Resume Next


Dim dt As String

Dim objConnection As ADODB.Connection
Dim objCommand As ADODB.Command

Dim strConnectionString As String
Dim objRecordset1 As ADODB.Recordset
Dim objRecordset2 As ADODB.Recordset
Dim objRecordset3 As ADODB.Recordset


Dim strSQL1 As String
Dim strSQL2 As String
Dim strSQL3 As String

Set objConnection = New ADODB.Connection
Set objRecordset1 = New ADODB.Recordset
'Set objRecordset2 = New ADODB.Recordset
Set objRecordset3 = New ADODB.Recordset


Call conn.Link
objConnection.ConnectionString = DBConn
objConnection.Open

If Err.Description <> "" Then
    'MsgBox "DATABASE CONNECTION ERROR: " & Err.Description
    Call errorlog("Case-3: " & Err.Description) 'Error Log to Notepad
    Exit Sub
Else

    dt = Format(Now, "yyyy-mm-dd HH:mm:ss")
    
    
                '======================================================================
                    strSQL1 = "Update MFG_RollUp_DUP set QC_START  = Cast('" & QC_START & "' as Datetime), QC_STOP  = '" & dt & "', BATCH_QTY = " & BATCH_QTY & ", BATCH_SIZE = '" & BATCH_SIZE & "', BATCH_SPGR = '" & BATCH_SPGR & "' where BATCH_NO like '" & BATCH_NO & "' and PRODUCT_NAME like '" & PRODUCT_NAME & "' and BATCH_START > dateadd (day, -2, getdate())"
                    'MsgBox strSQL1
                    objRecordset1.Open strSQL1, objConnection, adOpenKeyset
                '======================================================================
         
        
            If Err.Description <> "" Then
                Call errorlog("Case-4: " & Err.Description) 'Error Log to Notepad
            End If
        

End If
           
Set objCommand = Nothing
objRecordset1.Close
Set objRecordset1 = Nothing

'objRecordset2.Close
'Set objRecordset2 = Nothing

objConnection.Close
Set objConnection = Nothing

End Sub




Private Sub errorlog(error As String)
    Dim fileName As String
    fileName = "D:\SCADA ErrorLogFile\ErrorLogfile_" & Format(Now(), "yyyy-MM-dd") & ".txt"
    
    Open fileName For Append As #1
    Write #1, Now, error
    Close #1
    
    
    'Call SetUpTagGroup
    'Call ShowTagDataInfo
    'VBA_Triger.Value = 1
End Sub



Private Sub Button2_Released()

Dim BATCH_NO As String
Dim PRODUCT_NAME As String
Dim VESSEL_NAME As String
Dim NAME As String
Dim STD_QTY As Double
Dim AR_NO As String

Dim BATCH_QTY As Double
Dim BATCH_SIZE As String
Dim BATCH_SPGR As String

BATCH_NO = "Batch1"
PRODUCT_NAME = "Product1"
VESSEL_NAME = "Mix_01"

BATCH_QTY = 2000
BATCH_SIZE = "1000"
BATCH_SPGR = "246784.21"

Call BatchStartInsert(BATCH_NO, PRODUCT_NAME, VESSEL_NAME, BATCH_QTY, BATCH_SIZE, BATCH_SPGR)

End Sub


Private Sub Button3_Released()

Dim BATCH_NO As String
Dim QC_START As String
Dim PRODUCT_NAME As String



    BATCH_NO = SD0.Value
    PRODUCT_NAME = SD4.Value
    QC_START = SD56.Value
    
    Call BatchStopUpdate(BATCH_NO, PRODUCT_NAME, QC_START)
    ''Call SetUpTagGroup
    ''Call ShowTagDataInfo
    ''MV06_BATCH_OVER_BIT.Value = 0
    
    

End Sub
Private Sub Button4_Released()

Dim BATCH_NO As String
Dim PRODUCT_NAME As String
Dim VESSEL_NAME As String
Dim NAME As String
Dim STD_QTY As Double
Dim AR_NO As String
Dim ACT_QTY As Double
Dim BATCH_START As String
Dim BATCH_QTY As Double
Dim BATCH_SIZE As String
Dim BATCH_SPGR As String


    BATCH_NO = SD0.Value
    PRODUCT_NAME = SD4.Value
    VESSEL_NAME = SD5.Value
    BATCH_QTY = ND74.Value
    BATCH_SIZE = ND58.Value
    BATCH_SPGR = ND75.Value
    NAME = SD7.Value
    STD_QTY = ND9.Value
    ACT_QTY = ND6.Value
    AR_NO = SD64.Value

    Call MajorAddInsert(BATCH_NO, BATCH_START, PRODUCT_NAME, VESSEL_NAME, ACT_QTY, NAME, STD_QTY, AR_NO, BATCH_QTY, BATCH_SIZE, BATCH_SPGR)
    
    
End Sub
Private Sub Button5_Released()

Dim BATCH_NO As String
Dim PRODUCT_NAME As String
Dim VESSEL_NAME As String
Dim NAME As String
Dim STD_QTY As Double
Dim AR_NO As String
Dim ACT_QTY As Double

Dim BATCH_START As String
Dim START_TIME As String

Dim BATCH_QTY As Double
Dim BATCH_SIZE As String
Dim BATCH_SPGR As String

    BATCH_NO = SD0.Value
    PRODUCT_NAME = SD4.Value
    VESSEL_NAME = SD5.Value
    BATCH_QTY = ND74.Value
    BATCH_SIZE = ND58.Value
    BATCH_SPGR = ND75.Value
    NAME = SD7.Value
    STD_QTY = ND9.Value
    AR_NO = SD64.Value
    ACT_QTY = ND6.Value
    START_TIME = SD8.Value
    BATCH_START = SD1.Value

    Call MajorAddUpdate(BATCH_NO, BATCH_START, PRODUCT_NAME, VESSEL_NAME, ACT_QTY, NAME, START_TIME, STD_QTY, AR_NO, BATCH_QTY, BATCH_SIZE, BATCH_SPGR)
    
End Sub








Private Sub Display_AnimationStart()

End Sub

''Batch Start

Private Sub ND1_Change()

Dim BATCH_NO As String
Dim PRODUCT_NAME As String
Dim VESSEL_NAME As String
Dim NAME As String
Dim STD_QTY As Double
Dim AR_NO As String

Dim BATCH_QTY As Double
Dim BATCH_SIZE As String
Dim BATCH_SPGR As String

If ND1.Value = 1 Then

    BATCH_NO = SD0.Value
    PRODUCT_NAME = SD4.Value
    VESSEL_NAME = SD5.Value
    BATCH_QTY = ND74.Value
    BATCH_SIZE = ND58.Value
    BATCH_SPGR = ND75.Value

    Call BatchStartInsert(BATCH_NO, PRODUCT_NAME, VESSEL_NAME, BATCH_QTY, BATCH_SIZE, BATCH_SPGR)
    Call SetUpTagGroup
    Call ShowTagDataInfo
    
    MV06_BATCH_STARTED_BIT.Value = 0
    
    
End If
End Sub

Private Sub ND11_Change()

End Sub

Private Sub ND14_Change()

End Sub

Private Sub ND16_Change()

End Sub


Private Sub ND19_Change()

End Sub

''Batch Stop
Private Sub ND2_Change()

Dim BATCH_NO As String
Dim QC_START As String
Dim PRODUCT_NAME As String

If ND2.Value = 1 Then

    BATCH_NO = SD0.Value
    PRODUCT_NAME = SD4.Value
    QC_START = SD56.Value
    
    Call BatchStopUpdate(BATCH_NO, PRODUCT_NAME, QC_START)
    Call SetUpTagGroup
    Call ShowTagDataInfo
    MV06_BATCH_OVER_BIT.Value = 0
    
    
End If
End Sub

Private Sub ND21_Change()

End Sub

Private Sub ND24_Change()

End Sub

Private Sub ND26_Change()

End Sub

Private Sub ND29_Change()

End Sub

Private Sub ND3_Change()

End Sub

Private Sub ND31_Change()

End Sub

Private Sub ND34_Change()

End Sub

Private Sub ND36_Change()

End Sub

'====================================================Quality visible==============================================='
Private Sub ND37_Change()
Dim BATCH_NO As String
Dim QC_START As String
Dim PRODUCT_NAME As String

If ND37.Value = 1 Then

    BATCH_NO = SD0.Value
    QC_START = SD56.Value
    PRODUCT_NAME = SD4.Value
    
    Call QualityStart(BATCH_NO, PRODUCT_NAME, QC_START)
    Call SetUpTagGroup
    Call ShowTagDataInfo
    
    MV06_QUALITY_VISIBLE_BIT.Value = 0
End If
End Sub

Private Sub ND38_Change()
Dim BATCH_NO As String
Dim QC_START As String
Dim PRODUCT_NAME As String
Dim BATCH_QTY As Double
Dim BATCH_SIZE As String
Dim BATCH_SPGR As String

If ND38.Value = 1 Then

    BATCH_NO = SD0.Value
    QC_START = SD56.Value
    PRODUCT_NAME = SD4.Value
    
    BATCH_QTY = ND74.Value
    BATCH_SIZE = ND58.Value
    BATCH_SPGR = ND75.Value
    
    Call QualityOver(BATCH_NO, PRODUCT_NAME, QC_START, BATCH_QTY, BATCH_SIZE, BATCH_SPGR)
    Call SetUpTagGroup
    Call ShowTagDataInfo
    
    MV06_QUALITY_OVER_DB_BIT.Value = 0
End If
End Sub


''Majoring - 1 satart

Private Sub ND39_Change()

End Sub

Private Sub ND4_Change()

Dim BATCH_NO As String
Dim PRODUCT_NAME As String
Dim VESSEL_NAME As String
Dim NAME As String
Dim STD_QTY As Double
Dim AR_NO As String
Dim ACT_QTY As Double
Dim BATCH_START As String
Dim BATCH_QTY As Double
Dim BATCH_SIZE As String
Dim BATCH_SPGR As String

If ND4.Value = 1 Then

    BATCH_NO = SD0.Value
    PRODUCT_NAME = SD4.Value
    VESSEL_NAME = SD5.Value
    BATCH_QTY = ND74.Value
    BATCH_SIZE = ND58.Value
    BATCH_SPGR = ND75.Value
    NAME = SD7.Value
    STD_QTY = ND9.Value
    ACT_QTY = ND6.Value
    AR_NO = SD64.Value

    Call MajorAddInsert(BATCH_NO, BATCH_START, PRODUCT_NAME, VESSEL_NAME, ACT_QTY, NAME, STD_QTY, AR_NO, BATCH_QTY, BATCH_SIZE, BATCH_SPGR)
    Call SetUpTagGroup
    Call ShowTagDataInfo
    
    MV06_MAT1_START.Value = 0


End If


End Sub

Private Sub ND41_Change()

End Sub

Private Sub ND44_Change()

End Sub

Private Sub ND46_Change()

End Sub

Private Sub ND49_Change()

End Sub

'' Majoring-1 Stop

Private Sub ND5_Change()

Dim BATCH_NO As String
Dim PRODUCT_NAME As String
Dim VESSEL_NAME As String
Dim NAME As String
Dim STD_QTY As Double
Dim AR_NO As String
Dim ACT_QTY As Double

Dim BATCH_START As String
Dim START_TIME As String

Dim BATCH_QTY As Double
Dim BATCH_SIZE As String
Dim BATCH_SPGR As String

If ND5.Value = 1 Then
    BATCH_NO = SD0.Value
    PRODUCT_NAME = SD4.Value
    VESSEL_NAME = SD5.Value
    BATCH_QTY = ND74.Value
    BATCH_SIZE = ND58.Value
    BATCH_SPGR = ND75.Value
    NAME = SD7.Value
    STD_QTY = ND9.Value
    AR_NO = SD64.Value
    ACT_QTY = ND6.Value
    START_TIME = SD8.Value
    BATCH_START = SD1.Value

    Call MajorAddUpdate(BATCH_NO, BATCH_START, PRODUCT_NAME, VESSEL_NAME, ACT_QTY, NAME, START_TIME, STD_QTY, AR_NO, BATCH_QTY, BATCH_SIZE, BATCH_SPGR)
    
    Call SetUpTagGroup
    Call ShowTagDataInfo
    
    MV06_MAT1_STOP.Value = 0


    
End If
End Sub

Private Sub ND51_Change()

End Sub

Private Sub ND54_Change()

End Sub

Private Sub ND58_Change()

End Sub

Private Sub ND6_Change()

End Sub

'' Majoring-2 start
Private Sub ND7_Change()

Dim BATCH_NO As String
Dim PRODUCT_NAME As String
Dim VESSEL_NAME As String
Dim NAME As String
Dim STD_QTY As Double
Dim ACT_QTY As Double
Dim AR_NO As String
Dim BATCH_START As String
Dim BATCH_QTY As Double
Dim BATCH_SIZE As String
Dim BATCH_SPGR As String

If ND7.Value = 1 Then

    BATCH_NO = SD0.Value
    PRODUCT_NAME = SD4.Value
    VESSEL_NAME = SD5.Value
    BATCH_QTY = ND74.Value
    BATCH_SIZE = ND58.Value
    BATCH_SPGR = ND75.Value
    NAME = SD12.Value
    STD_QTY = ND14.Value
    ACT_QTY = ND11.Value
    AR_NO = SD65.Value

    Call MajorAddInsert(BATCH_NO, BATCH_START, PRODUCT_NAME, VESSEL_NAME, ACT_QTY, NAME, STD_QTY, AR_NO, BATCH_QTY, BATCH_SIZE, BATCH_SPGR)
    Call SetUpTagGroup
    Call ShowTagDataInfo
    
    MV06_MAT2_START.Value = 0
    
End If


End Sub

Private Sub ND74_Change()

End Sub

Private Sub ND75_Change()

End Sub

'' Majoring-2 stop

Private Sub ND8_Change()

Dim BATCH_NO As String
Dim PRODUCT_NAME As String
Dim VESSEL_NAME As String
Dim NAME As String
Dim STD_QTY As Double
Dim AR_NO As String
Dim ACT_QTY As Double
Dim BATCH_START As String
Dim START_TIME As String
Dim BATCH_QTY As Double
Dim BATCH_SIZE As String
Dim BATCH_SPGR As String

If ND8.Value = 1 Then
    BATCH_NO = SD0.Value
    PRODUCT_NAME = SD4.Value
    VESSEL_NAME = SD5.Value
    BATCH_QTY = ND74.Value
    BATCH_SIZE = ND58.Value
    BATCH_SPGR = ND75.Value
    NAME = SD12.Value
    STD_QTY = ND14.Value
    AR_NO = SD65.Value
    ACT_QTY = ND11.Value
    START_TIME = SD13.Value
    BATCH_START = SD1.Value

    Call MajorAddUpdate(BATCH_NO, BATCH_START, PRODUCT_NAME, VESSEL_NAME, ACT_QTY, NAME, START_TIME, STD_QTY, AR_NO, BATCH_QTY, BATCH_SIZE, BATCH_SPGR)
    Call SetUpTagGroup
    Call ShowTagDataInfo
    
    MV06_MAT2_STOP.Value = 0
End If
End Sub

'' Majoring-3 start
Private Sub ND10_Change()

Dim BATCH_NO As String
Dim PRODUCT_NAME As String
Dim VESSEL_NAME As String
Dim NAME As String
Dim STD_QTY As Double
Dim ACT_QTY As Double
Dim AR_NO As String
Dim BATCH_START As String
Dim BATCH_QTY As Double
Dim BATCH_SIZE As String
Dim BATCH_SPGR As String

If ND10.Value = 1 Then

    BATCH_NO = SD0.Value
    PRODUCT_NAME = SD4.Value
    VESSEL_NAME = SD5.Value
    BATCH_QTY = ND74.Value
    BATCH_SIZE = ND58.Value
    BATCH_SPGR = ND75.Value
    NAME = SD17.Value
    STD_QTY = ND19.Value
    ACT_QTY = ND16.Value
    AR_NO = SD66.Value

    Call MajorAddInsert(BATCH_NO, BATCH_START, PRODUCT_NAME, VESSEL_NAME, ACT_QTY, NAME, STD_QTY, AR_NO, BATCH_QTY, BATCH_SIZE, BATCH_SPGR)
    Call SetUpTagGroup
    Call ShowTagDataInfo
    
    MV06_MAT3_START.Value = 0


End If


End Sub

'' Majoring-3 stop
Private Sub ND12_Change()

Dim BATCH_NO As String
Dim PRODUCT_NAME As String
Dim VESSEL_NAME As String
Dim NAME As String
Dim STD_QTY As Double
Dim AR_NO As String
Dim ACT_QTY As Double
Dim BATCH_START As String
Dim START_TIME As String
Dim BATCH_QTY As Double
Dim BATCH_SIZE As String
Dim BATCH_SPGR As String

If ND12.Value = 1 Then
    BATCH_NO = SD0.Value
    PRODUCT_NAME = SD4.Value
    VESSEL_NAME = SD5.Value
    BATCH_QTY = ND74.Value
    BATCH_SIZE = ND58.Value
    BATCH_SPGR = ND75.Value
    NAME = SD17.Value
    STD_QTY = ND19.Value
    AR_NO = SD64.Value
    ACT_QTY = ND16.Value
    START_TIME = SD18.Value
    BATCH_START = SD1.Value

    Call MajorAddUpdate(BATCH_NO, BATCH_START, PRODUCT_NAME, VESSEL_NAME, ACT_QTY, NAME, START_TIME, STD_QTY, AR_NO, BATCH_QTY, BATCH_SIZE, BATCH_SPGR)
    Call SetUpTagGroup
    Call ShowTagDataInfo
    
    MV06_MAT3_STOP.Value = 0
End If
End Sub

'' Major-4 start

Private Sub ND13_Change()

Dim BATCH_NO As String
Dim PRODUCT_NAME As String
Dim VESSEL_NAME As String
Dim NAME As String
Dim STD_QTY As Double
Dim ACT_QTY As Double
Dim AR_NO As String
Dim BATCH_START As String
Dim BATCH_QTY As Double
Dim BATCH_SIZE As String
Dim BATCH_SPGR As String

If ND13.Value = 1 Then

    BATCH_NO = SD0.Value
    PRODUCT_NAME = SD4.Value
    VESSEL_NAME = SD5.Value
    BATCH_QTY = ND74.Value
    BATCH_SIZE = ND58.Value
    BATCH_SPGR = ND75.Value
    NAME = SD22.Value
    STD_QTY = ND24.Value
    ACT_QTY = ND21.Value
    AR_NO = SD67.Value

    Call MajorAddInsert(BATCH_NO, BATCH_START, PRODUCT_NAME, VESSEL_NAME, ACT_QTY, NAME, STD_QTY, AR_NO, BATCH_QTY, BATCH_SIZE, BATCH_SPGR)
    Call SetUpTagGroup
    Call ShowTagDataInfo
    
    MV06_MAT4_START.Value = 0
End If

End Sub

'' Major-4 stop

Private Sub ND15_Change()

Dim BATCH_NO As String
Dim PRODUCT_NAME As String
Dim VESSEL_NAME As String
Dim NAME As String
Dim STD_QTY As Double
Dim AR_NO As String
Dim ACT_QTY As Double
Dim BATCH_START As String
Dim START_TIME As String
Dim BATCH_QTY As Double
Dim BATCH_SIZE As String
Dim BATCH_SPGR As String

If ND15.Value = 1 Then
    BATCH_NO = SD0.Value
    PRODUCT_NAME = SD4.Value
    VESSEL_NAME = SD5.Value
    BATCH_QTY = ND74.Value
    BATCH_SIZE = ND58.Value
    BATCH_SPGR = ND75.Value
    NAME = SD22.Value
    STD_QTY = ND24.Value
    AR_NO = SD67.Value
    ACT_QTY = ND21.Value
    START_TIME = SD23.Value
    BATCH_START = SD1.Value

    Call MajorAddUpdate(BATCH_NO, BATCH_START, PRODUCT_NAME, VESSEL_NAME, ACT_QTY, NAME, START_TIME, STD_QTY, AR_NO, BATCH_QTY, BATCH_SIZE, BATCH_SPGR)
    Call SetUpTagGroup
    Call ShowTagDataInfo
    
    MV06_MAT4_STOP.Value = 0
End If

End Sub
''Major-5 start
Private Sub ND17_Change()

Dim BATCH_NO As String
Dim PRODUCT_NAME As String
Dim VESSEL_NAME As String
Dim NAME As String
Dim STD_QTY As Double
Dim ACT_QTY As Double
Dim AR_NO As String
Dim BATCH_START As String
Dim BATCH_QTY As Double
Dim BATCH_SIZE As String
Dim BATCH_SPGR As String

If ND17.Value = 1 Then

    BATCH_NO = SD0.Value
    PRODUCT_NAME = SD4.Value
    VESSEL_NAME = SD5.Value
    BATCH_QTY = ND74.Value
    BATCH_SIZE = ND58.Value
    BATCH_SPGR = ND75.Value
    NAME = SD27.Value
    STD_QTY = ND29.Value
    ACT_QTY = ND26.Value
    AR_NO = SD68.Value

    Call MajorAddInsert(BATCH_NO, BATCH_START, PRODUCT_NAME, VESSEL_NAME, ACT_QTY, NAME, STD_QTY, AR_NO, BATCH_QTY, BATCH_SIZE, BATCH_SPGR)
    Call SetUpTagGroup
    Call ShowTagDataInfo
    
    MV06_MAT5_START.Value = 0
End If

End Sub
''Major-5 stop
Private Sub ND18_Change()

Dim BATCH_NO As String
Dim PRODUCT_NAME As String
Dim VESSEL_NAME As String
Dim NAME As String
Dim STD_QTY As Double
Dim AR_NO As String
Dim ACT_QTY As Double
Dim BATCH_START As String
Dim START_TIME As String
Dim BATCH_QTY As Double
Dim BATCH_SIZE As String
Dim BATCH_SPGR As String

If ND18.Value = 1 Then
    BATCH_NO = SD0.Value
    PRODUCT_NAME = SD4.Value
    VESSEL_NAME = SD5.Value
    BATCH_QTY = ND74.Value
    BATCH_SIZE = ND58.Value
    BATCH_SPGR = ND75.Value
    NAME = SD27.Value
    STD_QTY = ND29.Value
    AR_NO = SD68.Value
    ACT_QTY = ND26.Value
    START_TIME = SD28.Value
    BATCH_START = SD1.Value

    Call MajorAddUpdate(BATCH_NO, BATCH_START, PRODUCT_NAME, VESSEL_NAME, ACT_QTY, NAME, START_TIME, STD_QTY, AR_NO, BATCH_QTY, BATCH_SIZE, BATCH_SPGR)
    Call SetUpTagGroup
    Call ShowTagDataInfo
    
    MV06_MAT5_STOP.Value = 0
End If
End Sub

''Major-6 start

Private Sub ND20_Change()

Dim BATCH_NO As String
Dim PRODUCT_NAME As String
Dim VESSEL_NAME As String
Dim NAME As String
Dim STD_QTY As Double
Dim ACT_QTY As Double
Dim AR_NO As String
Dim BATCH_START As String
Dim BATCH_QTY As Double
Dim BATCH_SIZE As String
Dim BATCH_SPGR As String

If ND20.Value = 1 Then

    BATCH_NO = SD0.Value
    PRODUCT_NAME = SD4.Value
    VESSEL_NAME = SD5.Value
    BATCH_QTY = ND74.Value
    BATCH_SIZE = ND58.Value
    BATCH_SPGR = ND75.Value
    NAME = SD32.Value
    STD_QTY = ND34.Value
    ACT_QTY = ND31.Value
    AR_NO = SD69.Value

    Call MajorAddInsert(BATCH_NO, BATCH_START, PRODUCT_NAME, VESSEL_NAME, ACT_QTY, NAME, STD_QTY, AR_NO, BATCH_QTY, BATCH_SIZE, BATCH_SPGR)
    Call SetUpTagGroup
    Call ShowTagDataInfo
    
    MV06_MAT6_START.Value = 0
End If
End Sub

''Major-6 stop
Private Sub ND22_Change()

Dim BATCH_NO As String
Dim PRODUCT_NAME As String
Dim VESSEL_NAME As String
Dim NAME As String
Dim STD_QTY As Double
Dim AR_NO As String
Dim ACT_QTY As Double
Dim BATCH_START As String
Dim START_TIME As String
Dim BATCH_QTY As Double
Dim BATCH_SIZE As String
Dim BATCH_SPGR As String

If ND22.Value = 1 Then
    BATCH_NO = SD0.Value
    PRODUCT_NAME = SD4.Value
    VESSEL_NAME = SD5.Value
    BATCH_QTY = ND74.Value
    BATCH_SIZE = ND58.Value
    BATCH_SPGR = ND75.Value
    NAME = SD32.Value
    STD_QTY = ND34.Value
    AR_NO = SD69.Value
    ACT_QTY = ND31.Value
    START_TIME = SD33.Value
    BATCH_START = SD1.Value

    Call MajorAddUpdate(BATCH_NO, BATCH_START, PRODUCT_NAME, VESSEL_NAME, ACT_QTY, NAME, START_TIME, STD_QTY, AR_NO, BATCH_QTY, BATCH_SIZE, BATCH_SPGR)
    Call SetUpTagGroup
    Call ShowTagDataInfo
    
    MV06_MAT6_STOP.Value = 0
End If

End Sub

''Major-7 start
Private Sub ND23_Change()

Dim BATCH_NO As String
Dim PRODUCT_NAME As String
Dim VESSEL_NAME As String
Dim NAME As String
Dim STD_QTY As Double
Dim ACT_QTY As Double
Dim AR_NO As String
Dim BATCH_START As String
Dim BATCH_QTY As Double
Dim BATCH_SIZE As String
Dim BATCH_SPGR As String

If ND23.Value = 1 Then

    BATCH_NO = SD0.Value
    PRODUCT_NAME = SD4.Value
    VESSEL_NAME = SD5.Value
    BATCH_QTY = ND74.Value
    BATCH_SIZE = ND58.Value
    BATCH_SPGR = ND75.Value
    NAME = SD36.Value
    STD_QTY = ND39.Value
    ACT_QTY = ND36.Value
    AR_NO = SD70.Value

    Call MajorAddInsert(BATCH_NO, BATCH_START, PRODUCT_NAME, VESSEL_NAME, ACT_QTY, NAME, STD_QTY, AR_NO, BATCH_QTY, BATCH_SIZE, BATCH_SPGR)
    Call SetUpTagGroup
    Call ShowTagDataInfo
    
    MV06_MAT7_START.Value = 0
End If

End Sub

''Major-7 stop

Private Sub ND25_Change()

Dim BATCH_NO As String
Dim PRODUCT_NAME As String
Dim VESSEL_NAME As String
Dim NAME As String
Dim STD_QTY As Double
Dim AR_NO As String
Dim ACT_QTY As Double
Dim BATCH_START As String
Dim START_TIME As String
Dim BATCH_QTY As Double
Dim BATCH_SIZE As String
Dim BATCH_SPGR As String

If ND25.Value = 1 Then
    BATCH_NO = SD0.Value
    PRODUCT_NAME = SD4.Value
    VESSEL_NAME = SD5.Value
    BATCH_QTY = ND74.Value
    BATCH_SIZE = ND58.Value
    BATCH_SPGR = ND75.Value
    NAME = SD36.Value
    STD_QTY = ND34.Value
    AR_NO = SD70.Value
    ACT_QTY = ND36.Value
    START_TIME = SD38.Value
    BATCH_START = SD1.Value

    Call MajorAddUpdate(BATCH_NO, BATCH_START, PRODUCT_NAME, VESSEL_NAME, ACT_QTY, NAME, START_TIME, STD_QTY, AR_NO, BATCH_QTY, BATCH_SIZE, BATCH_SPGR)
    Call SetUpTagGroup
    Call ShowTagDataInfo
    
    MV06_MAT7_STOP.Value = 0
End If
End Sub

''Major-8 start

Private Sub ND27_Change()

Dim BATCH_NO As String
Dim PRODUCT_NAME As String
Dim VESSEL_NAME As String
Dim NAME As String
Dim STD_QTY As Double
Dim ACT_QTY As Double
Dim AR_NO As String
Dim BATCH_START As String
Dim BATCH_QTY As Double
Dim BATCH_SIZE As String
Dim BATCH_SPGR As String

If ND27.Value = 1 Then

    BATCH_NO = SD0.Value
    PRODUCT_NAME = SD4.Value
    VESSEL_NAME = SD5.Value
    BATCH_QTY = ND74.Value
    BATCH_SIZE = ND58.Value
    BATCH_SPGR = ND75.Value
    NAME = SD42.Value
    STD_QTY = ND44.Value
    ACT_QTY = ND41.Value
    AR_NO = SD71.Value

    Call MajorAddInsert(BATCH_NO, BATCH_START, PRODUCT_NAME, VESSEL_NAME, ACT_QTY, NAME, STD_QTY, AR_NO, BATCH_QTY, BATCH_SIZE, BATCH_SPGR)
    Call SetUpTagGroup
    Call ShowTagDataInfo
    
    MV06_MAT8_START.Value = 0
End If

End Sub

''Major-8 stop

Private Sub ND28_Change()

Dim BATCH_NO As String
Dim PRODUCT_NAME As String
Dim VESSEL_NAME As String
Dim NAME As String
Dim STD_QTY As Double
Dim AR_NO As String
Dim ACT_QTY As Double
Dim BATCH_START As String
Dim START_TIME As String
Dim BATCH_QTY As Double
Dim BATCH_SIZE As String
Dim BATCH_SPGR As String

If ND28.Value = 1 Then
    BATCH_NO = SD0.Value
    PRODUCT_NAME = SD4.Value
    VESSEL_NAME = SD5.Value
    BATCH_QTY = ND74.Value
    BATCH_SIZE = ND58.Value
    BATCH_SPGR = ND75.Value
    NAME = SD42.Value
    STD_QTY = ND44.Value
    AR_NO = SD71.Value
    ACT_QTY = ND41.Value
    START_TIME = SD43.Value
    BATCH_START = SD1.Value

    Call MajorAddUpdate(BATCH_NO, BATCH_START, PRODUCT_NAME, VESSEL_NAME, ACT_QTY, NAME, START_TIME, STD_QTY, AR_NO, BATCH_QTY, BATCH_SIZE, BATCH_SPGR)
    Call SetUpTagGroup
    Call ShowTagDataInfo
    
    MV06_MAT8_STOP.Value = 0
End If
End Sub

''Major-9 start
Private Sub ND30_Change()

Dim BATCH_NO As String
Dim PRODUCT_NAME As String
Dim VESSEL_NAME As String
Dim NAME As String
Dim STD_QTY As Double
Dim ACT_QTY As Double
Dim AR_NO As String
Dim BATCH_START As String
Dim BATCH_QTY As Double
Dim BATCH_SIZE As String
Dim BATCH_SPGR As String

If ND30.Value = 1 Then

    BATCH_NO = SD0.Value
    PRODUCT_NAME = SD4.Value
    VESSEL_NAME = SD5.Value
    BATCH_QTY = ND74.Value
    BATCH_SIZE = ND58.Value
    BATCH_SPGR = ND75.Value
    NAME = SD47.Value
    STD_QTY = ND49.Value
    ACT_QTY = ND46.Value
    AR_NO = SD72.Value

    Call MajorAddInsert(BATCH_NO, BATCH_START, PRODUCT_NAME, VESSEL_NAME, ACT_QTY, NAME, STD_QTY, AR_NO, BATCH_QTY, BATCH_SIZE, BATCH_SPGR)
    Call SetUpTagGroup
    Call ShowTagDataInfo
    
    MV06_MAT9_START.Value = 0
End If
End Sub

''Major-9 Stop
Private Sub ND32_Change()

Dim BATCH_NO As String
Dim PRODUCT_NAME As String
Dim VESSEL_NAME As String
Dim NAME As String
Dim STD_QTY As Double
Dim AR_NO As String
Dim ACT_QTY As Double
Dim BATCH_START As String
Dim START_TIME As String
Dim BATCH_QTY As Double
Dim BATCH_SIZE As String
Dim BATCH_SPGR As String

If ND32.Value = 1 Then
    BATCH_NO = SD0.Value
    PRODUCT_NAME = SD4.Value
    VESSEL_NAME = SD5.Value
    BATCH_QTY = ND74.Value
    BATCH_SIZE = ND58.Value
    BATCH_SPGR = ND75.Value
    NAME = SD47.Value
    STD_QTY = ND49.Value
    AR_NO = SD72.Value
    ACT_QTY = ND46.Value
    START_TIME = SD48.Value
    BATCH_START = SD1.Value

    Call MajorAddUpdate(BATCH_NO, BATCH_START, PRODUCT_NAME, VESSEL_NAME, ACT_QTY, NAME, START_TIME, STD_QTY, AR_NO, BATCH_QTY, BATCH_SIZE, BATCH_SPGR)
    Call SetUpTagGroup
    Call ShowTagDataInfo
    
    MV06_MAT9_STOP.Value = 0
End If
End Sub

''Major-10 start
Private Sub ND33_Change()

Dim BATCH_NO As String
Dim PRODUCT_NAME As String
Dim VESSEL_NAME As String
Dim NAME As String
Dim STD_QTY As Double
Dim ACT_QTY As Double
Dim AR_NO As String
Dim BATCH_START As String
Dim BATCH_QTY As Double
Dim BATCH_SIZE As String
Dim BATCH_SPGR As String

If ND30.Value = 1 Then

    BATCH_NO = SD0.Value
    PRODUCT_NAME = SD4.Value
    VESSEL_NAME = SD5.Value
    BATCH_QTY = ND74.Value
    BATCH_SIZE = ND58.Value
    BATCH_SPGR = ND75.Value
    NAME = SD52.Value
    STD_QTY = ND54.Value
    ACT_QTY = ND51.Value
    AR_NO = SD73.Value

    Call MajorAddInsert(BATCH_NO, BATCH_START, PRODUCT_NAME, VESSEL_NAME, ACT_QTY, NAME, STD_QTY, AR_NO, BATCH_QTY, BATCH_SIZE, BATCH_SPGR)
    Call SetUpTagGroup
    Call ShowTagDataInfo
    
    MV06_MAT10_START.Value = 0
End If
End Sub


'' Major-10 stop
Private Sub ND35_Change()
Dim BATCH_NO As String
Dim PRODUCT_NAME As String
Dim VESSEL_NAME As String
Dim NAME As String
Dim STD_QTY As Double
Dim AR_NO As String
Dim ACT_QTY As Double
Dim BATCH_START As String
Dim START_TIME As String
Dim BATCH_QTY As Double
Dim BATCH_SIZE As String
Dim BATCH_SPGR As String

If ND35.Value = 1 Then
    BATCH_NO = SD0.Value
    PRODUCT_NAME = SD4.Value
    VESSEL_NAME = SD5.Value
    BATCH_QTY = ND74.Value
    BATCH_SIZE = ND58.Value
    BATCH_SPGR = ND75.Value
    NAME = SD52.Value
    STD_QTY = ND54.Value
    AR_NO = SD73.Value
    ACT_QTY = ND51.Value
    START_TIME = SD53.Value
    BATCH_START = SD1.Value

    Call MajorAddUpdate(BATCH_NO, BATCH_START, PRODUCT_NAME, VESSEL_NAME, ACT_QTY, NAME, START_TIME, STD_QTY, AR_NO, BATCH_QTY, BATCH_SIZE, BATCH_SPGR)
    Call SetUpTagGroup
    Call ShowTagDataInfo
    
    MV06_MAT10_STOP.Value = 0
End If
End Sub

Private Sub ND9_Change()

End Sub

Private Sub SD0_Change()

End Sub

Private Sub SD1_Change()

End Sub

Private Sub SD10_Change()

End Sub

Private Sub SD12_Change()

End Sub

Private Sub SD13_Change()

End Sub

Private Sub SD15_Change()

End Sub

Private Sub SD17_Change()

End Sub

Private Sub SD18_Change()

End Sub

Private Sub SD2_Change()

End Sub

Private Sub SD20_Change()

End Sub

Private Sub SD22_Change()

End Sub

Private Sub SD23_Change()

End Sub

Private Sub SD25_Change()

End Sub

Private Sub SD27_Change()

End Sub

Private Sub SD28_Change()

End Sub

Private Sub SD30_Change()

End Sub

Private Sub SD32_Change()

End Sub

Private Sub SD33_Change()

End Sub

Private Sub SD35_Change()

End Sub

Private Sub SD37_Change()

End Sub

Private Sub SD38_Change()

End Sub

Private Sub SD4_Change()

End Sub

Private Sub SD40_Change()

End Sub

Private Sub SD42_Change()

End Sub

Private Sub SD43_Change()

End Sub

Private Sub SD45_Change()

End Sub

Private Sub SD47_Change()

End Sub

Private Sub SD48_Change()

End Sub

Private Sub SD5_Change()

End Sub

Private Sub SD50_Change()

End Sub

Private Sub SD52_Change()

End Sub

Private Sub SD53_Change()

End Sub

Private Sub SD55_Change()

End Sub

Private Sub SD56_Change()

End Sub

Private Sub SD57_Change()

End Sub

Private Sub SD64_Change()

End Sub

Private Sub SD65_Change()

End Sub

Private Sub SD66_Change()

End Sub

Private Sub SD67_Change()

End Sub

Private Sub SD68_Change()

End Sub

Private Sub SD69_Change()

End Sub

Private Sub SD7_Change()

End Sub

Private Sub SD70_Change()

End Sub

Private Sub SD71_Change()

End Sub

Private Sub SD72_Change()

End Sub

Private Sub SD73_Change()

End Sub

Private Sub SD8_Change()

End Sub
