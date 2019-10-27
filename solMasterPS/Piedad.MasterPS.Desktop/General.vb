Imports System.IO
Imports System.Text
Imports Piedad.MasterPS.Utilerias

Module General
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="id">False => Obtiene el ID de la sucursal local. True => Obtiene la descripcion </param>
    ''' <returns></returns>
    Public Function ObtenerSucursalLocal(ByVal id As Boolean) As String
        Dim suc As String = String.Empty
        Dim path As String = "c:\masterps\config\"
        If IO.Directory.Exists(path) Then
            If IO.File.Exists(path + "suc.conf") Then
                Dim reader As New StreamReader(path + "suc.conf", Encoding.Default)
                Dim a As String
                Do
                    a = reader.ReadLine
                    If a IsNot Nothing Then
                        Try
                            Dim uncode As String
                            If id Then
                                uncode = Protection.Decrypt(a).Split("|")(1)
                            Else
                                uncode = Protection.Decrypt(a).Split("|")(2)
                            End If
                            suc = uncode
                        Catch ex As Exception
                            suc = String.Empty
                        End Try
                    End If
                Loop Until a Is Nothing
                reader.Close()
            End If
        End If
        Return suc
    End Function
End Module
