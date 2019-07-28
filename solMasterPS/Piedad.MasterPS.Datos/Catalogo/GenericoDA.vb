Imports Piedad.MasterPS.Clases
Imports Piedad.MasterPS.DataAccess
Public Class GenericoDA
    Private cadenaConex As String
    Private tipoGen As TipoGenerico
    Private almacena As String
    Private actualiza As String
    Private elimina As String
    Private obtener_ As String
    Private obtenerTodos_ As String

    Public Sub New(ByVal cadenaConexion As String, ByVal tipo As TipoGenerico)
        cadenaConex = cadenaConexion
        tipoGen = tipo
        Select Case tipo
            Case TipoGenerico.Caja
                almacena = ""
                actualiza = "dbo.sp_ActualizarCaja"
                elimina = ""
                obtener_ = ""
                obtenerTodos_ = ""
                Exit Select
            Case TipoGenerico.Antiguedad
                almacena = ""
                actualiza = ""
                elimina = ""
                obtener_ = ""
                obtenerTodos_ = ""
                Exit Select
            Case TipoGenerico.Arte
                almacena = ""
                actualiza = ""
                elimina = ""
                obtener_ = ""
                obtenerTodos_ = ""
                Exit Select
            Case TipoGenerico.MovimientoEmpenio
                almacena = ""
                actualiza = ""
                elimina = ""
                obtener_ = ""
                obtenerTodos_ = ""
                Exit Select
            Case TipoGenerico.Estado
                almacena = ""
                actualiza = ""
                elimina = ""
                obtener_ = ""
                obtenerTodos_ = ""
                Exit Select
            Case TipoGenerico.EstatusApartado
                almacena = ""
                actualiza = ""
                elimina = ""
                obtener_ = ""
                obtenerTodos_ = ""
                Exit Select
            Case TipoGenerico.EstatusEmpenio
                almacena = ""
                actualiza = ""
                elimina = ""
                obtener_ = ""
                obtenerTodos_ = ""
                Exit Select
            Case TipoGenerico.EstatusInventario
                almacena = ""
                actualiza = ""
                elimina = ""
                obtener_ = ""
                obtenerTodos_ = ""
                Exit Select
            Case TipoGenerico.EstatusMensaje
                almacena = ""
                actualiza = ""
                elimina = ""
                obtener_ = ""
                obtenerTodos_ = ""
                Exit Select
            Case TipoGenerico.EstatusVenta
                almacena = ""
                actualiza = ""
                elimina = ""
                obtener_ = ""
                obtenerTodos_ = ""
                Exit Select
            Case TipoGenerico.Familia_TipoKilataje
                almacena = ""
                actualiza = ""
                elimina = ""
                obtener_ = ""
                obtenerTodos_ = ""
                Exit Select
            Case TipoGenerico.Marca_EstadoMetal
                almacena = ""
                actualiza = ""
                elimina = ""
                obtener_ = ""
                obtenerTodos_ = ""
                Exit Select
            Case TipoGenerico.MedioEnterado
                almacena = ""
                actualiza = ""
                elimina = ""
                obtener_ = ""
                obtenerTodos_ = ""
                Exit Select
            Case TipoGenerico.MotivoChecador
                almacena = ""
                actualiza = ""
                elimina = ""
                obtener_ = ""
                obtenerTodos_ = ""
                Exit Select
            Case TipoGenerico.Municipio
                almacena = ""
                actualiza = ""
                elimina = ""
                obtener_ = ""
                obtenerTodos_ = ""
                Exit Select
            Case TipoGenerico.NivelCombustible
                almacena = ""
                actualiza = ""
                elimina = ""
                obtener_ = ""
                obtenerTodos_ = ""
                Exit Select
            Case TipoGenerico.Ocupacion
                almacena = ""
                actualiza = ""
                elimina = ""
                obtener_ = ""
                obtenerTodos_ = ""
                Exit Select
            Case TipoGenerico.Pais
                almacena = ""
                actualiza = ""
                elimina = ""
                obtener_ = ""
                obtenerTodos_ = ""
                Exit Select
            Case TipoGenerico.Periodo
                almacena = ""
                actualiza = ""
                elimina = ""
                obtener_ = ""
                obtenerTodos_ = ""
                Exit Select
            Case TipoGenerico.Rol
                almacena = ""
                actualiza = ""
                elimina = ""
                obtener_ = ""
                obtenerTodos_ = ""
                Exit Select
            Case TipoGenerico.Sexo
                almacena = ""
                actualiza = ""
                elimina = ""
                obtener_ = ""
                obtenerTodos_ = ""
                Exit Select
            Case TipoGenerico.Telefono
                almacena = ""
                actualiza = ""
                elimina = ""
                obtener_ = ""
                obtenerTodos_ = ""
                Exit Select
            Case TipoGenerico.TipoCancelacionApartado
                almacena = ""
                actualiza = ""
                elimina = ""
                obtener_ = ""
                obtenerTodos_ = ""
                Exit Select
            Case TipoGenerico.TipoDocumento
                almacena = ""
                actualiza = ""
                elimina = ""
                obtener_ = ""
                obtenerTodos_ = ""
                Exit Select
            Case TipoGenerico.TipoEmpenio
                almacena = ""
                actualiza = ""
                elimina = ""
                obtener_ = ""
                obtenerTodos_ = ""
                Exit Select
            Case TipoGenerico.TipoFormaDiamante
                almacena = ""
                actualiza = ""
                elimina = ""
                obtener_ = ""
                obtenerTodos_ = ""
                Exit Select
            Case TipoGenerico.TipoIdentificacion
                almacena = ""
                actualiza = ""
                elimina = ""
                obtener_ = ""
                obtenerTodos_ = ""
                Exit Select
            Case TipoGenerico.TipoIngreso
                almacena = ""
                actualiza = ""
                elimina = ""
                obtener_ = ""
                obtenerTodos_ = ""
                Exit Select
            Case TipoGenerico.TipoMercancia_Metal
                almacena = ""
                actualiza = ""
                elimina = ""
                obtener_ = ""
                obtenerTodos_ = ""
                Exit Select
            Case TipoGenerico.TipoMotor
                almacena = ""
                actualiza = ""
                elimina = ""
                obtener_ = ""
                obtenerTodos_ = ""
                Exit Select
            Case TipoGenerico.TipoOperacionEmpenio
                almacena = ""
                actualiza = ""
                elimina = ""
                obtener_ = ""
                obtenerTodos_ = ""
                Exit Select
            Case TipoGenerico.TipoTasa
                almacena = ""
                actualiza = ""
                elimina = ""
                obtener_ = ""
                obtenerTodos_ = ""
                Exit Select
            Case TipoGenerico.TipoTelefono
                almacena = ""
                actualiza = ""
                elimina = ""
                obtener_ = ""
                obtenerTodos_ = ""
                Exit Select
        End Select
    End Sub
    Public Sub Almacenar(ByVal generic As Generico)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando(almacena)
            objDA.AgregarParametro("@id", generic.IdGenerico)
            objDA.AgregarParametro("@valor", generic.Descripcion)
            If tipoGen = TipoGenerico.Caja Or tipoGen = TipoGenerico.TipoMercancia_Metal Or
                tipoGen = TipoGenerico.Telefono Or tipoGen = TipoGenerico.Familia_TipoKilataje Or
                tipoGen = TipoGenerico.Marca_EstadoMetal Or tipoGen = TipoGenerico.Municipio Then
                objDA.AgregarParametro("@idAuxiliarUno", generic.IdAuxiliarUno)
            ElseIf tipoGen = TipoGenerico.TipoFormaDiamante Then
                objDA.AgregarParametro("@auxiliarUno", generic.AuxiliarUno)
            End If
            objDA.EjecutaComando()
        End Using
    End Sub

    Public Sub Actualizar(ByVal generic As Generico)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando(actualiza)
            objDA.AgregarParametro("@id", generic.IdGenerico)
            objDA.AgregarParametro("@valor", generic.Descripcion)
            If tipoGen = TipoGenerico.Caja Or tipoGen = TipoGenerico.TipoMercancia_Metal Or
                tipoGen = TipoGenerico.Telefono Or tipoGen = TipoGenerico.Familia_TipoKilataje Or
                tipoGen = TipoGenerico.Marca_EstadoMetal Or tipoGen = TipoGenerico.Municipio Then
                objDA.AgregarParametro("@idAuxiliarUno", generic.IdAuxiliarUno)
            ElseIf tipoGen = TipoGenerico.TipoFormaDiamante Then
                objDA.AgregarParametro("@auxiliarUno", generic.AuxiliarUno)
            End If
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Sub Eliminar(ByVal generic As Generico)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando(elimina)
            objDA.AgregarParametro("@id", generic.IdGenerico)
            objDA.EjecutaComando()
        End Using
    End Sub
    Public Function Obtener(ByVal generic As Generico) As Generico
        Dim gen As Generico = Nothing
        Dim lst As List(Of Generico)
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando(obtener_)
            objDA.AgregarParametro("@id", generic.IdGenerico)
            lst = objDA.ObtenerResultados(Of Generico)()
            gen = New Generico()
            gen = lst(0)
        End Using
        Return gen
    End Function

    Public Function ObtenerTodos() As Genericos
        Dim lst As Genericos = Nothing
        Using objDA As New ConexDB(cadenaConex)
            objDA.CrearComando(obtenerTodos_)
            Dim lista As New List(Of Generico)
            lista = objDA.ObtenerResultados(Of Generico)()
            For Each gen As Generico In lista
                lst.Add(gen)
            Next
        End Using
        Return lst
    End Function
End Class
