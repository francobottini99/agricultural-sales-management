Imports AccesoDatos

Public Class Drivers

#Region "ARTICULOS"
    Public Shared Function Articulos(objeto As TablaArticulos) As ModeloArticulos
        Return New ModeloArticulos With {
                .IdArticulo = objeto.idArticulo,
                .CodArticulo = objeto.CodArticulo,
                .Detalle = objeto.Detalle,
                .Unidad = objeto.Unidad,
                .Costo = objeto.Costo,
                .FechaActCosto = objeto.FechaActCosto,
                .Precio = objeto.Precio,
                .FechaActPrec = objeto.FechaActPrec,
                .AlicuotaIVA = objeto.AlicuotaIVA,
                .StkMinimo = objeto.StkMinimo,
                .Observaciones = objeto.Observaciones,
                .Imagen = objeto.Imagen,
                .Eliminado = objeto.Eliminado,
                .AscUsuarios = Usuarios(objeto.ascUsuarios),
                .AscRubro = Rubros(objeto.ascRubro),
                .AscSubRubro = SubRubros(objeto.ascSubRubro)
            }
    End Function

    Public Shared Function Articulos(objeto As ModeloArticulos) As TablaArticulos
        Return New TablaArticulos With {
                .idArticulo = objeto.IdArticulo,
                .CodArticulo = objeto.CodArticulo,
                .Detalle = objeto.Detalle,
                .Unidad = objeto.Unidad,
                .Costo = objeto.Costo,
                .FechaActCosto = objeto.FechaActCosto,
                .Precio = objeto.Precio,
                .FechaActPrec = objeto.FechaActPrec,
                .AlicuotaIVA = objeto.AlicuotaIVA,
                .StkMinimo = objeto.StkMinimo,
                .Observaciones = objeto.Observaciones,
                .Imagen = objeto.Imagen,
                .Eliminado = objeto.Eliminado,
                .ascUsuarios = Usuarios(objeto.AscUsuarios),
                .ascRubro = Rubros(objeto.AscRubro),
                .ascSubRubro = SubRubros(objeto.AscSubRubro)
            }
    End Function

    Public Shared Function Articulos(lista As List(Of ModeloArticulos)) As List(Of TablaArticulos)
        Dim listaTransformada As New List(Of TablaArticulos)

        For Each item In lista
            listaTransformada.Add(Articulos(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function Articulos(lista As List(Of TablaArticulos)) As List(Of ModeloArticulos)
        Dim listaTransformada As New List(Of ModeloArticulos)

        For Each item In lista
            listaTransformada.Add(Articulos(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "BANCOS"
    Public Shared Function Bancos(objeto As TablaBancos) As ModeloBancos
        Return New ModeloBancos With {
                .IdBancos = objeto.idBancos,
                .Nombre = objeto.Nombre,
                .Eliminado = objeto.Eliminado,
                .AscUsuarios = Usuarios(objeto.ascUsuarios)
            }
    End Function

    Public Shared Function Bancos(objeto As ModeloBancos) As TablaBancos
        Return New TablaBancos With {
                .idBancos = objeto.IdBancos,
                .Nombre = objeto.Nombre,
                .Eliminado = objeto.Eliminado,
                .ascUsuarios = Usuarios(objeto.AscUsuarios)
            }
    End Function

    Public Shared Function Bancos(lista As List(Of ModeloBancos)) As List(Of TablaBancos)
        Dim listaTransformada As New List(Of TablaBancos)

        For Each item In lista
            listaTransformada.Add(Bancos(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function Bancos(lista As List(Of TablaBancos)) As List(Of ModeloBancos)
        Dim listaTransformada As New List(Of ModeloBancos)

        For Each item In lista
            listaTransformada.Add(Bancos(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "CAJA"
    Public Shared Function Caja(objeto As TablaCaja) As ModeloCaja
        Return New ModeloCaja With {
                .IdCaja = objeto.idCaja,
                .Fecha = objeto.Fecha,
                .Movimiento = objeto.Movimiento,
                .Comprobante = objeto.Comprobante,
                .Descripcion = objeto.Detalle,
                .Moneda = objeto.Moneda,
                .Ingreso = objeto.Ingreso,
                .Egreso = objeto.Egreso,
                .Observaciones = objeto.Observaciones,
                .Eliminado = objeto.Eliminado,
                .AscUsuarios = Usuarios(objeto.ascUsuarios)
            }
    End Function

    Public Shared Function Caja(objeto As ModeloCaja) As TablaCaja
        Return New TablaCaja With {
                .idCaja = objeto.IdCaja,
                .Fecha = objeto.Fecha,
                .Movimiento = objeto.Movimiento,
                .Comprobante = objeto.Comprobante,
                .Detalle = objeto.Descripcion,
                .Moneda = objeto.Moneda,
                .Ingreso = objeto.Ingreso,
                .Egreso = objeto.Egreso,
                .Observaciones = objeto.Observaciones,
                .Eliminado = objeto.Eliminado,
                .ascUsuarios = Usuarios(objeto.AscUsuarios)
            }
    End Function

    Public Shared Function Caja(lista As List(Of ModeloCaja)) As List(Of TablaCaja)
        Dim listaTransformada As New List(Of TablaCaja)

        For Each item In lista
            listaTransformada.Add(Caja(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function Caja(lista As List(Of TablaCaja)) As List(Of ModeloCaja)
        Dim listaTransformada As New List(Of ModeloCaja)

        For Each item In lista
            listaTransformada.Add(Caja(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "CHEQUERAS"
    Public Shared Function Chequeras(objeto As TablaChequera) As ModeloChequera
        Return New ModeloChequera With {
                .IdChequera = objeto.idChequera,
                .NroCuenta = objeto.NroCuenta,
                .FechaAlta = objeto.FechaAlta,
                .Banco = objeto.Banco,
                .NroChqInicial = objeto.NroChqInicial,
                .CantidadChq = objeto.CantidadChq,
                .ChqEmitidos = objeto.ChqEmitidos,
                .ChqAnulados = objeto.ChqAnulados,
                .ChqDisponibles = objeto.ChqDisponibles,
                .Observaciones = objeto.Observaciones,
                .Eliminada = objeto.Eliminada,
                .AscUsuarios = Usuarios(objeto.ascUsuarios)
            }
    End Function

    Public Shared Function Chequeras(objeto As ModeloChequera) As TablaChequera
        Return New TablaChequera With {
                .idChequera = objeto.IdChequera,
                .NroCuenta = objeto.NroCuenta,
                .FechaAlta = objeto.FechaAlta,
                .Banco = objeto.Banco,
                .NroChqInicial = objeto.NroChqInicial,
                .CantidadChq = objeto.CantidadChq,
                .ChqEmitidos = objeto.ChqEmitidos,
                .ChqAnulados = objeto.ChqAnulados,
                .ChqDisponibles = objeto.ChqDisponibles,
                .Observaciones = objeto.Observaciones,
                .Eliminada = objeto.Eliminada,
                .ascUsuarios = Usuarios(objeto.AscUsuarios)
            }
    End Function

    Public Shared Function Chequeras(lista As List(Of ModeloChequera)) As List(Of TablaChequera)
        Dim listaTransformada As New List(Of TablaChequera)

        For Each item In lista
            listaTransformada.Add(Chequeras(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function Chequeras(lista As List(Of TablaChequera)) As List(Of ModeloChequera)
        Dim listaTransformada As New List(Of ModeloChequera)

        For Each item In lista
            listaTransformada.Add(Chequeras(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "CLIENTES"
    Public Shared Function Clientes(objeto As TablaClientes) As ModeloCliente
        Return New ModeloCliente With {
                .IdCliente = objeto.idCliente,
                .FechaAlta = objeto.FechaAlta,
                .RazonSocial = objeto.RazonSocial,
                .Direccion = objeto.Direccion,
                .Localidad = objeto.Localidad,
                .Provincia = objeto.Provincia,
                .CodPostal = objeto.CodPostal,
                .Pais = objeto.Pais,
                .Telefono = objeto.Telefono,
                .Mail = objeto.Mail,
                .Web = objeto.Web,
                .CUIT = objeto.CUIT,
                .IIBB = objeto.IIBB,
                .SituacionIVA = objeto.SituacionIVA,
                .CreditoAsignado = objeto.CreditoAsignado,
                .CreditoConsumido = objeto.CreditoConsumido,
                .Estado = objeto.Estado,
                .Clasificacion = objeto.Clasificacion,
                .Eliminado = objeto.Eliminado,
                .AscUsuarios = Usuarios(objeto.ascUsuarios)
            }
    End Function

    Public Shared Function Clientes(objeto As ModeloCliente) As TablaClientes
        Return New TablaClientes With {
                .idCliente = objeto.IdCliente,
                .FechaAlta = objeto.FechaAlta,
                .RazonSocial = objeto.RazonSocial,
                .Direccion = objeto.Direccion,
                .Localidad = objeto.Localidad,
                .Provincia = objeto.Provincia,
                .CodPostal = objeto.CodPostal,
                .Pais = objeto.Pais,
                .Telefono = objeto.Telefono,
                .Mail = objeto.Mail,
                .Web = objeto.Web,
                .CUIT = objeto.CUIT,
                .IIBB = objeto.IIBB,
                .SituacionIVA = objeto.SituacionIVA,
                .CreditoAsignado = objeto.CreditoAsignado,
                .CreditoConsumido = objeto.CreditoConsumido,
                .Estado = objeto.Estado,
                .Clasificacion = objeto.Clasificacion,
                .Eliminado = objeto.Eliminado,
                .ascUsuarios = Usuarios(objeto.AscUsuarios)
            }
    End Function

    Public Shared Function Clientes(lista As List(Of ModeloCliente)) As List(Of TablaClientes)
        Dim listaTransformada As New List(Of TablaClientes)

        For Each item In lista
            listaTransformada.Add(Clientes(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function Clientes(lista As List(Of TablaClientes)) As List(Of ModeloCliente)
        Dim listaTransformada As New List(Of ModeloCliente)

        For Each item In lista
            listaTransformada.Add(Clientes(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "COMPROBANTES"
    Public Shared Function Comprobantes(objeto As TablaComprobantes) As ModeloComprobantes
        Return New ModeloComprobantes With {
                .IdComprobantes = objeto.idComprobantes,
                .Nombre = objeto.Nombre,
                .Tipo = objeto.Tipo,
                .Copias = objeto.Copias,
                .Leyenda = objeto.Leyenda,
                .Encabezado = objeto.Encabezado,
                .LeyendaEnc = objeto.LeyendaEnc,
                .Pie = objeto.Pie,
                .LeyendaPie = objeto.LeyendaPie,
                .CantidadCompEmitidos = objeto.CantidadCompEmitidos,
                .CantidadCopiasComp = objeto.CantidadCopiasComp,
                .Eliminado = objeto.Eliminado,
                .AscUsuarios = Usuarios(objeto.ascUsuarios)
            }
    End Function

    Public Shared Function Comprobantes(objeto As ModeloComprobantes) As TablaComprobantes
        Return New TablaComprobantes With {
                .idComprobantes = objeto.IdComprobantes,
                .Nombre = objeto.Nombre,
                .Tipo = objeto.Tipo,
                .Copias = objeto.Copias,
                .Leyenda = objeto.Leyenda,
                .Encabezado = objeto.Encabezado,
                .LeyendaEnc = objeto.LeyendaEnc,
                .Pie = objeto.Pie,
                .LeyendaPie = objeto.LeyendaPie,
                .CantidadCompEmitidos = objeto.CantidadCompEmitidos,
                .CantidadCopiasComp = objeto.CantidadCopiasComp,
                .Eliminado = objeto.Eliminado,
                .ascUsuarios = Usuarios(objeto.AscUsuarios)
            }
    End Function

    Public Shared Function Comprobantes(lista As List(Of ModeloComprobantes)) As List(Of TablaComprobantes)
        Dim listaTransformada As New List(Of TablaComprobantes)

        For Each item In lista
            listaTransformada.Add(Comprobantes(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function Comprobantes(lista As List(Of TablaComprobantes)) As List(Of ModeloComprobantes)
        Dim listaTransformada As New List(Of ModeloComprobantes)

        For Each item In lista
            listaTransformada.Add(Comprobantes(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "CUENTA CORRIENTE COMPRA"
    Public Shared Function CuentaCorrienteCompra(objeto As TablaCuentaCorrienteCompra) As ModeloCuentaCorrienteCompra
        Return New ModeloCuentaCorrienteCompra With {
                .IdCuentaCorrienteCompra = objeto.idCuentaCorrienteCompra,
                .Fecha = objeto.Fecha,
                .FechaVto = objeto.FechaVto,
                .Comprobante = objeto.Comprobante,
                .Numero = objeto.Numero,
                .Detalle = objeto.Detalle,
                .Debito = objeto.Debito,
                .Credito = objeto.Credito,
                .Eliminado = objeto.Eliminado,
                .Visible = objeto.Visible,
                .AscProveedores = Proveedores(objeto.ascProveedores),
                .AscUsuarios = Usuarios(objeto.ascUsuarios)
        }
    End Function

    Public Shared Function CuentaCorrienteCompra(objeto As ModeloCuentaCorrienteCompra) As TablaCuentaCorrienteCompra
        Return New TablaCuentaCorrienteCompra With {
                .idCuentaCorrienteCompra = objeto.IdCuentaCorrienteCompra,
                .Fecha = objeto.Fecha,
                .FechaVto = objeto.FechaVto,
                .Comprobante = objeto.Comprobante,
                .Numero = objeto.Numero,
                .Detalle = objeto.Detalle,
                .Debito = objeto.Debito,
                .Credito = objeto.Credito,
                .Eliminado = objeto.Eliminado,
                .Visible = objeto.Visible,
                .ascProveedores = Proveedores(objeto.AscProveedores),
                .ascUsuarios = Usuarios(objeto.AscUsuarios)
        }
    End Function

    Public Shared Function CuentaCorrienteCompra(lista As List(Of ModeloCuentaCorrienteCompra)) As List(Of TablaCuentaCorrienteCompra)
        Dim listaTransformada As New List(Of TablaCuentaCorrienteCompra)

        For Each item In lista
            listaTransformada.Add(CuentaCorrienteCompra(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function CuentaCorrienteCompra(lista As List(Of TablaCuentaCorrienteCompra)) As List(Of ModeloCuentaCorrienteCompra)
        Dim listaTransformada As New List(Of ModeloCuentaCorrienteCompra)

        For Each item In lista
            listaTransformada.Add(CuentaCorrienteCompra(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "CUENTA CORRIENTE VENTA"
    Public Shared Function CuentaCorrienteVenta(objeto As TablaCuentaCorrienteVenta) As ModeloCuentaCorrienteVenta
        Return New ModeloCuentaCorrienteVenta With {
                .IdCuentaCorrienteVentas = objeto.idCuentaCorrienteVentas,
                .Fecha = objeto.Fecha,
                .FechaVto = objeto.FechaVto,
                .Comprobante = objeto.Comprobante,
                .Numero = objeto.Numero,
                .Detalle = objeto.Detalle,
                .Debito = objeto.Debito,
                .Credito = objeto.Credito,
                .Visible = objeto.Visible,
                .Eliminado = objeto.Eliminado,
                .AscClientes = Clientes(objeto.ascClientes),
                .AscUsuarios = Usuarios(objeto.ascUsuarios)
        }
    End Function

    Public Shared Function CuentaCorrienteVenta(objeto As ModeloCuentaCorrienteVenta) As TablaCuentaCorrienteVenta
        Return New TablaCuentaCorrienteVenta With {
                .idCuentaCorrienteVentas = objeto.IdCuentaCorrienteVentas,
                .Fecha = objeto.Fecha,
                .FechaVto = objeto.FechaVto,
                .Comprobante = objeto.Comprobante,
                .Numero = objeto.Numero,
                .Detalle = objeto.Detalle,
                .Debito = objeto.Debito,
                .Credito = objeto.Credito,
                .Visible = objeto.Visible,
                .Eliminado = objeto.Eliminado,
                .ascClientes = Clientes(objeto.AscClientes),
                .ascUsuarios = Usuarios(objeto.AscUsuarios)
        }
    End Function

    Public Shared Function CuentaCorrienteVenta(lista As List(Of ModeloCuentaCorrienteVenta)) As List(Of TablaCuentaCorrienteVenta)
        Dim listaTransformada As New List(Of TablaCuentaCorrienteVenta)

        For Each item In lista
            listaTransformada.Add(CuentaCorrienteVenta(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function CuentaCorrienteVenta(lista As List(Of TablaCuentaCorrienteVenta)) As List(Of ModeloCuentaCorrienteVenta)
        Dim listaTransformada As New List(Of ModeloCuentaCorrienteVenta)

        For Each item In lista
            listaTransformada.Add(CuentaCorrienteVenta(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "DATOS SISTEMA"
    Public Shared Function DatosSistema(objeto As TablaDatosSistema) As ModeloDatosSistema
        Return New ModeloDatosSistema With {
                .IdDatosSistema = objeto.idDatosSistema,
                .MonedaFacturacion = objeto.MonedaFacturacion,
                .MonedaContable = objeto.MonedaContable,
                .AlicuotaIva1 = objeto.AlicuotaIva1,
                .AlicuotaIva2 = objeto.AlicuotaIva2,
                .AlicuotaIva3 = objeto.AlicuotaIva3,
                .AlicuotaMargen = objeto.AlicuotaMargen,
                .AlicuotaDesc1 = objeto.AlicuotaDesc1,
                .AlicuotaDesc2 = objeto.AlicuotaDesc2,
                .AscUsuarios = Usuarios(objeto.ascUsuarios)
            }
    End Function

    Public Shared Function DatosSistema(objeto As ModeloDatosSistema) As TablaDatosSistema
        Return New TablaDatosSistema With {
                .idDatosSistema = objeto.IdDatosSistema,
                .MonedaFacturacion = objeto.MonedaFacturacion,
                .MonedaContable = objeto.MonedaContable,
                .AlicuotaIva1 = objeto.AlicuotaIva1,
                .AlicuotaIva2 = objeto.AlicuotaIva2,
                .AlicuotaIva3 = objeto.AlicuotaIva3,
                .AlicuotaMargen = objeto.AlicuotaMargen,
                .AlicuotaDesc1 = objeto.AlicuotaDesc1,
                .AlicuotaDesc2 = objeto.AlicuotaDesc2,
                .ascUsuarios = Usuarios(objeto.AscUsuarios)
            }
    End Function

    Public Shared Function DatosSistema(lista As List(Of ModeloDatosSistema)) As List(Of TablaDatosSistema)
        Dim listaTransformada As New List(Of TablaDatosSistema)

        For Each item In lista
            listaTransformada.Add(DatosSistema(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function DatosSistema(lista As List(Of TablaDatosSistema)) As List(Of ModeloDatosSistema)
        Dim listaTransformada As New List(Of ModeloDatosSistema)

        For Each item In lista
            listaTransformada.Add(DatosSistema(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "DEPOSITOS"
    Public Shared Function Depositos(objeto As TablaDepositos) As ModeloDepositos
        Return New ModeloDepositos With {
                .IdDeposito = objeto.idDeposito,
                .Nombre = objeto.Nombre,
                .Direccion = objeto.Direccion,
                .Localidad = objeto.Localidad,
                .Provincia = objeto.Provincia,
                .CodPostal = objeto.CodPostal,
                .Eliminado = objeto.Eliminado,
                .AscUsuarios = Usuarios(objeto.ascUsuarios)
            }
    End Function

    Public Shared Function Depositos(objeto As ModeloDepositos) As TablaDepositos
        Return New TablaDepositos With {
                .idDeposito = objeto.IdDeposito,
                .Nombre = objeto.Nombre,
                .Direccion = objeto.Direccion,
                .Localidad = objeto.Localidad,
                .Provincia = objeto.Provincia,
                .CodPostal = objeto.CodPostal,
                .Eliminado = objeto.Eliminado,
                .ascUsuarios = Usuarios(objeto.AscUsuarios)
            }
    End Function

    Public Shared Function Depositos(lista As List(Of ModeloDepositos)) As List(Of TablaDepositos)
        Dim listaTransformada As New List(Of TablaDepositos)

        For Each item In lista
            listaTransformada.Add(Depositos(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function Depositos(lista As List(Of TablaDepositos)) As List(Of ModeloDepositos)
        Dim listaTransformada As New List(Of ModeloDepositos)

        For Each item In lista
            listaTransformada.Add(Depositos(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "DETALLE CHEQUES"
    Public Shared Function DetalleCheque(objeto As TablaDetalleCheque) As ModeloDetalleCheque
        Return New ModeloDetalleCheque With {
            .IdDetalleCheque = objeto.idDetalleCheque,
            .Numero = objeto.Numero,
            .FechaEmision = objeto.FechaEmision,
            .FechaCobro = objeto.FechaCobro,
            .PlazoDias = objeto.PlazoDias,
            .Importe = objeto.Importe,
            .Destino = objeto.Destino,
            .EnDisponiblidad = objeto.EnDisponiblidad,
            .Cobrado = objeto.Cobrado,
            .Anulado = objeto.Anulado,
            .Modificado = objeto.Modificado,
            .Modificacion = objeto.Modificacion,
            .Observaciones = objeto.Observaciones,
            .Eliminado = objeto.Eliminado,
            .AscChequera = Chequeras(objeto.ascChequera),
            .AscUsuarios = Usuarios(objeto.ascUsuarios)
        }
    End Function

    Public Shared Function DetalleCheque(objeto As ModeloDetalleCheque) As TablaDetalleCheque
        Return New TablaDetalleCheque With {
            .idDetalleCheque = objeto.IdDetalleCheque,
            .Numero = objeto.Numero,
            .FechaEmision = objeto.FechaEmision,
            .FechaCobro = objeto.FechaCobro,
            .PlazoDias = objeto.PlazoDias,
            .Importe = objeto.Importe,
            .Destino = objeto.Destino,
            .EnDisponiblidad = objeto.EnDisponiblidad,
            .Cobrado = objeto.Cobrado,
            .Anulado = objeto.Anulado,
            .Modificado = objeto.Modificado,
            .Modificacion = objeto.Modificacion,
            .Observaciones = objeto.Observaciones,
            .Eliminado = objeto.Eliminado,
            .ascChequera = Chequeras(objeto.AscChequera),
            .ascUsuarios = Usuarios(objeto.AscUsuarios)
        }
    End Function

    Public Shared Function DetalleCheque(lista As List(Of ModeloDetalleCheque)) As List(Of TablaDetalleCheque)
        Dim listaTransformada As New List(Of TablaDetalleCheque)

        For Each item In lista
            listaTransformada.Add(DetalleCheque(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function DetalleCheque(lista As List(Of TablaDetalleCheque)) As List(Of ModeloDetalleCheque)
        Dim listaTransformada As New List(Of ModeloDetalleCheque)

        For Each item In lista
            listaTransformada.Add(DetalleCheque(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "DETALLE DEVOLUCIONES"
    Public Shared Function DetalleDevoluciones(objeto As TablaDetalleDevoluciones) As ModeloDetalleDevoluciones
        Return New ModeloDetalleDevoluciones With {
                .IdDetalleDevoluciones = objeto.idDetalleDevoluciones,
                .Descripcion = objeto.Descripcion,
                .Cantidad = objeto.Cantidad,
                .Unidad = objeto.Unidad,
                .Precio = objeto.Precio,
                .Importe = objeto.Importe,
                .AlicuotaIVA = objeto.AlicuotaIVA,
                .Eliminado = objeto.Eliminado,
                .AscArticulos = Articulos(objeto.ascArticulos),
                .AscDetalleRemitoVenta = DetalleRemitoVenta(objeto.ascDetalleRemitoVenta),
                .AscDevoluciones = Devoluciones(objeto.ascDevoluciones)
            }
    End Function

    Public Shared Function DetalleDevoluciones(objeto As ModeloDetalleDevoluciones) As TablaDetalleDevoluciones
        Return New TablaDetalleDevoluciones With {
                .idDetalleDevoluciones = objeto.IdDetalleDevoluciones,
                .Descripcion = objeto.Descripcion,
                .Cantidad = objeto.Cantidad,
                .Unidad = objeto.Unidad,
                .Precio = objeto.Precio,
                .Importe = objeto.Importe,
                .AlicuotaIVA = objeto.AlicuotaIVA,
                .Eliminado = objeto.Eliminado,
                .ascArticulos = Articulos(objeto.AscArticulos),
                .ascDetalleRemitoVenta = DetalleRemitoVenta(objeto.AscDetalleRemitoVenta),
                .ascDevoluciones = Devoluciones(objeto.AscDevoluciones)
            }
    End Function

    Public Shared Function DetalleDevoluciones(lista As List(Of ModeloDetalleDevoluciones)) As List(Of TablaDetalleDevoluciones)
        Dim listaTransformada As New List(Of TablaDetalleDevoluciones)

        For Each item In lista
            listaTransformada.Add(DetalleDevoluciones(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function DetalleDevoluciones(lista As List(Of TablaDetalleDevoluciones)) As List(Of ModeloDetalleDevoluciones)
        Dim listaTransformada As New List(Of ModeloDetalleDevoluciones)

        For Each item In lista
            listaTransformada.Add(DetalleDevoluciones(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "DETALLE REMITO COMPRA"
    Public Shared Function DetalleRemitoCompra(objeto As TablaDetalleRemitoCompra) As ModeloDetalleRemitoCompra
        Return New ModeloDetalleRemitoCompra With {
                .IdDetalleRemitosCompra = objeto.idDetalleRemitosCompra,
                .Descripcion = objeto.Descripcion,
                .Cantidad = objeto.Cantidad,
                .Unidad = objeto.Unidad,
                .Precio = objeto.Precio,
                .Importe = objeto.Importe,
                .AlicuotaIVA = objeto.AlicuotaIVA,
                .Facturado = objeto.Facturado,
                .Eliminado = objeto.Eliminado,
                .AscArticulos = Articulos(objeto.ascArticulos),
                .AscRemitosCompra = RemitoCompra(objeto.ascRemitosCompra)
            }
    End Function

    Public Shared Function DetalleRemitoCompra(objeto As ModeloDetalleRemitoCompra) As TablaDetalleRemitoCompra
        Return New TablaDetalleRemitoCompra With {
                .idDetalleRemitosCompra = objeto.IdDetalleRemitosCompra,
                .Descripcion = objeto.Descripcion,
                .Cantidad = objeto.Cantidad,
                .Unidad = objeto.Unidad,
                .Precio = objeto.Precio,
                .Importe = objeto.Importe,
                .AlicuotaIVA = objeto.AlicuotaIVA,
                .Facturado = objeto.Facturado,
                .Eliminado = objeto.Eliminado,
                .ascArticulos = Articulos(objeto.AscArticulos),
                .ascRemitosCompra = RemitoCompra(objeto.AscRemitosCompra)
            }
    End Function

    Public Shared Function DetalleRemitoCompra(lista As List(Of ModeloDetalleRemitoCompra)) As List(Of TablaDetalleRemitoCompra)
        Dim listaTransformada As New List(Of TablaDetalleRemitoCompra)

        For Each item In lista
            listaTransformada.Add(DetalleRemitoCompra(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function DetalleRemitoCompra(lista As List(Of TablaDetalleRemitoCompra)) As List(Of ModeloDetalleRemitoCompra)
        Dim listaTransformada As New List(Of ModeloDetalleRemitoCompra)

        For Each item In lista
            listaTransformada.Add(DetalleRemitoCompra(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "DETALLE REMITO VENTA"
    Public Shared Function DetalleRemitoVenta(objeto As TablaDetalleRemitoVenta) As ModeloDetalleRemitoVenta
        Return New ModeloDetalleRemitoVenta With {
                .IdDetalleRemitosVenta = objeto.idDetalleRemitosVenta,
                .Descripcion = objeto.Descripcion,
                .Cantidad = objeto.Cantidad,
                .Unidad = objeto.Unidad,
                .Precio = objeto.Precio,
                .Importe = objeto.Importe,
                .AlicuotaIVA = objeto.AlicuotaIVA,
                .Facturado = objeto.Facturado,
                .Eliminado = objeto.Eliminado,
                .AscArticulos = Articulos(objeto.ascArticulos),
                .AscRemitosVenta = RemitoVenta(objeto.ascRemitosVenta)
            }
    End Function

    Public Shared Function DetalleRemitoVenta(objeto As ModeloDetalleRemitoVenta) As TablaDetalleRemitoVenta
        Return New TablaDetalleRemitoVenta With {
                .idDetalleRemitosVenta = objeto.IdDetalleRemitosVenta,
                .Descripcion = objeto.Descripcion,
                .Cantidad = objeto.Cantidad,
                .Unidad = objeto.Unidad,
                .Precio = objeto.Precio,
                .Importe = objeto.Importe,
                .AlicuotaIVA = objeto.AlicuotaIVA,
                .Facturado = objeto.Facturado,
                .Eliminado = objeto.Eliminado,
                .ascArticulos = Articulos(objeto.AscArticulos),
                .ascRemitosVenta = RemitoVenta(objeto.AscRemitosVenta)
            }
    End Function

    Public Shared Function DetalleRemitoVenta(lista As List(Of ModeloDetalleRemitoVenta)) As List(Of TablaDetalleRemitoVenta)
        Dim listaTransformada As New List(Of TablaDetalleRemitoVenta)

        For Each item In lista
            listaTransformada.Add(DetalleRemitoVenta(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function DetalleRemitoVenta(lista As List(Of TablaDetalleRemitoVenta)) As List(Of ModeloDetalleRemitoVenta)
        Dim listaTransformada As New List(Of ModeloDetalleRemitoVenta)

        For Each item In lista
            listaTransformada.Add(DetalleRemitoVenta(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "DEVOLUCIONES"
    Public Shared Function Devoluciones(objeto As TablaDevoluciones) As ModeloDevoluciones
        Return New ModeloDevoluciones With {
                .IdDevoluciones = objeto.idDevoluciones,
                .NroComprobante = objeto.NroComprobante,
                .Fecha = objeto.Fecha,
                .Importe = objeto.Importe,
                .Observaciones = objeto.Observaciones,
                .ImpOriginal = objeto.ImpOriginal,
                .ImpCopia = objeto.ImpCopia,
                .Eliminado = objeto.Eliminado,
                .AscClientes = Clientes(objeto.ascClientes),
                .AscUsuarios = Usuarios(objeto.ascUsuarios)
            }
    End Function

    Public Shared Function Devoluciones(objeto As ModeloDevoluciones) As TablaDevoluciones
        Return New TablaDevoluciones With {
                .idDevoluciones = objeto.IdDevoluciones,
                .NroComprobante = objeto.NroComprobante,
                .Fecha = objeto.Fecha,
                .Importe = objeto.Importe,
                .Observaciones = objeto.Observaciones,
                .ImpOriginal = objeto.ImpOriginal,
                .ImpCopia = objeto.ImpCopia,
                .Eliminado = objeto.Eliminado,
                .ascClientes = Clientes(objeto.AscClientes),
                .ascUsuarios = Usuarios(objeto.AscUsuarios)
            }
    End Function

    Public Shared Function Devoluciones(lista As List(Of ModeloDevoluciones)) As List(Of TablaDevoluciones)
        Dim listaTransformada As New List(Of TablaDevoluciones)

        For Each item In lista
            listaTransformada.Add(Devoluciones(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function Devoluciones(lista As List(Of TablaDevoluciones)) As List(Of ModeloDevoluciones)
        Dim listaTransformada As New List(Of ModeloDevoluciones)

        For Each item In lista
            listaTransformada.Add(Devoluciones(item))
        Next

        Return listaTransformada
    End Function

#End Region

#Region "DEVOLUCIONES MONEDAS"
    Public Shared Function DevolucionesMonedas(objeto As TablaDevolucionesMonedas) As ModeloDevolucionesMonedas
        Return New ModeloDevolucionesMonedas With {
                .IdDevolucionesMonedas = objeto.idDevolucionesMonedas,
                .TipoCambio = objeto.TipoCambio,
                .ImporteNeto = objeto.ImporteNeto,
                .DescuentoGral = objeto.DescuentoGral,
                .BaseImponible = objeto.BaseImponible,
                .IVA = objeto.IVA,
                .ImporteTotal = objeto.ImporteTotal,
                .Eliminado = objeto.Eliminado,
                .AscDevoluciones = Devoluciones(objeto.ascDevoluciones)
            }
    End Function

    Public Shared Function DevolucionesMonedas(objeto As ModeloDevolucionesMonedas) As TablaDevolucionesMonedas
        Return New TablaDevolucionesMonedas With {
                .idDevolucionesMonedas = objeto.IdDevolucionesMonedas,
                .TipoCambio = objeto.TipoCambio,
                .ImporteNeto = objeto.ImporteNeto,
                .DescuentoGral = objeto.DescuentoGral,
                .BaseImponible = objeto.BaseImponible,
                .IVA = objeto.IVA,
                .ImporteTotal = objeto.ImporteTotal,
                .Eliminado = objeto.Eliminado,
                .ascDevoluciones = Devoluciones(objeto.AscDevoluciones)
            }
    End Function

    Public Shared Function DevolucionesMonedas(lista As List(Of ModeloDevolucionesMonedas)) As List(Of TablaDevolucionesMonedas)
        Dim listaTransformada As New List(Of TablaDevolucionesMonedas)

        For Each item In lista
            listaTransformada.Add(DevolucionesMonedas(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function DevolucionesMonedas(lista As List(Of TablaDevolucionesMonedas)) As List(Of ModeloDevolucionesMonedas)
        Dim listaTransformada As New List(Of ModeloDevolucionesMonedas)

        For Each item In lista
            listaTransformada.Add(DevolucionesMonedas(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "EMPRESAS"
    Public Shared Function Empresas(objeto As TablaEmpresa) As ModeloEmpresa
        Return New ModeloEmpresa With {
                .IdEmpresa = objeto.idEmpresa,
                .RazonSocial = objeto.RazonSocial,
                .Direccion = objeto.Direccion,
                .Localidad = objeto.Localidad,
                .Provincia = objeto.Provincia,
                .CodPostal = objeto.CodPostal,
                .Pais = objeto.Pais,
                .TE = objeto.TE,
                .Mail = objeto.Mail,
                .CUIT = objeto.CUIT,
                .IIBB = objeto.IIBB,
                .InicioActividad = objeto.InicioActividad,
                .PrefijoFacturacion = objeto.PrefijoFacturacion,
                .Web = objeto.Web,
                .CondicionIVA = objeto.CondicionIVA,
                .Logo = objeto.Logo,
                .AscUsuarios = Usuarios(objeto.ascUsuarios)
            }
    End Function

    Public Shared Function Empresas(objeto As ModeloEmpresa) As TablaEmpresa
        Return New TablaEmpresa With {
                .idEmpresa = objeto.IdEmpresa,
                .RazonSocial = objeto.RazonSocial,
                .Direccion = objeto.Direccion,
                .Localidad = objeto.Localidad,
                .Provincia = objeto.Provincia,
                .CodPostal = objeto.CodPostal,
                .Pais = objeto.Pais,
                .TE = objeto.TE,
                .Mail = objeto.Mail,
                .CUIT = objeto.CUIT,
                .IIBB = objeto.IIBB,
                .InicioActividad = objeto.InicioActividad,
                .PrefijoFacturacion = objeto.PrefijoFacturacion,
                .Web = objeto.Web,
                .CondicionIVA = objeto.CondicionIVA,
                .Logo = objeto.Logo,
                .ascUsuarios = Usuarios(objeto.AscUsuarios)
            }
    End Function

    Public Shared Function Empresas(lista As List(Of ModeloEmpresa)) As List(Of TablaEmpresa)
        Dim listaTransformada As New List(Of TablaEmpresa)

        For Each item In lista
            listaTransformada.Add(Empresas(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function Empresas(lista As List(Of TablaEmpresa)) As List(Of ModeloEmpresa)
        Dim listaTransformada As New List(Of ModeloEmpresa)

        For Each item In lista
            listaTransformada.Add(Empresas(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "FACTURA COMPRA MONEDAS"
    Public Shared Function FacturaCompraMonedas(objeto As TablaFacturaComMonedas) As ModeloFacturaComMonedas
        Return New ModeloFacturaComMonedas With {
                .IdFacturaComMonedas = objeto.idFacturaComMonedas,
                .TipoCambio = objeto.TipoCambio,
                .ImporteNeto = objeto.ImporteNeto,
                .DescuentoGral = objeto.DescuentoGral,
                .BaseImponible = objeto.BaseImponible,
                .IVA = objeto.IVA,
                .ImporteTotal = objeto.ImporteTotal,
                .Eliminado = objeto.Eliminado,
                .AscFacturaCompra = FacturaCompra(objeto.ascFacturaCompra)
            }
    End Function

    Public Shared Function FacturaCompraMonedas(objeto As ModeloFacturaComMonedas) As TablaFacturaComMonedas
        Return New TablaFacturaComMonedas With {
                .idFacturaComMonedas = objeto.IdFacturaComMonedas,
                .TipoCambio = objeto.TipoCambio,
                .ImporteNeto = objeto.ImporteNeto,
                .DescuentoGral = objeto.DescuentoGral,
                .BaseImponible = objeto.BaseImponible,
                .IVA = objeto.IVA,
                .ImporteTotal = objeto.ImporteTotal,
                .Eliminado = objeto.Eliminado,
                .ascFacturaCompra = FacturaCompra(objeto.AscFacturaCompra)
            }
    End Function

    Public Shared Function FacturaCompraMonedas(lista As List(Of ModeloFacturaComMonedas)) As List(Of TablaFacturaComMonedas)
        Dim listaTransformada As New List(Of TablaFacturaComMonedas)

        For Each item In lista
            listaTransformada.Add(FacturaCompraMonedas(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function FacturaCompraMonedas(lista As List(Of TablaFacturaComMonedas)) As List(Of ModeloFacturaComMonedas)
        Dim listaTransformada As New List(Of ModeloFacturaComMonedas)

        For Each item In lista
            listaTransformada.Add(FacturaCompraMonedas(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "FACTURA COMPRA"
    Public Shared Function FacturaCompra(objeto As TablaFacturaCompra) As ModeloFacturaCompra
        Return New ModeloFacturaCompra With {
                .IdFacturaCompra = objeto.idFacturaCompra,
                .TipoComprobante = objeto.TipoComprobante,
                .ClaseComprobante = objeto.ClaseComprobante,
                .Fecha = objeto.Fecha,
                .FechaVto = objeto.FechaVto,
                .Prefijo = objeto.Prefijo,
                .NroComprobante = objeto.NroComprobante,
                .ImporteNeto = objeto.ImporteNeto,
                .DescuentoGral = objeto.DescuentoGral,
                .BaseImponible = objeto.BaseImponible,
                .Iva = objeto.Iva,
                .ImporteTotal = objeto.ImporteTotal,
                .Observaciones = objeto.Observaciones,
                .Remitado = objeto.Remitado,
                .Eliminado = objeto.Eliminado,
                .AscUsuarios = Usuarios(objeto.ascUsuarios),
                .AscProveedores = Proveedores(objeto.ascProveedores),
                .AscCuentaCorrienteCompra = CuentaCorrienteCompra(objeto.ascCuentaCorrienteCompra)
            }
    End Function

    Public Shared Function FacturaCompra(objeto As ModeloFacturaCompra) As TablaFacturaCompra
        Return New TablaFacturaCompra With {
                .idFacturaCompra = objeto.IdFacturaCompra,
                .TipoComprobante = objeto.TipoComprobante,
                .ClaseComprobante = objeto.ClaseComprobante,
                .Fecha = objeto.Fecha,
                .FechaVto = objeto.FechaVto,
                .Prefijo = objeto.Prefijo,
                .NroComprobante = objeto.NroComprobante,
                .ImporteNeto = objeto.ImporteNeto,
                .DescuentoGral = objeto.DescuentoGral,
                .BaseImponible = objeto.BaseImponible,
                .Iva = objeto.Iva,
                .Observaciones = objeto.Observaciones,
                .Remitado = objeto.Remitado,
                .ImporteTotal = objeto.ImporteTotal,
                .Eliminado = objeto.Eliminado,
                .ascUsuarios = Usuarios(objeto.AscUsuarios),
                .ascProveedores = Proveedores(objeto.AscProveedores),
                .ascCuentaCorrienteCompra = CuentaCorrienteCompra(objeto.AscCuentaCorrienteCompra)
            }
    End Function

    Public Shared Function FacturaCompra(lista As List(Of ModeloFacturaCompra)) As List(Of TablaFacturaCompra)
        Dim listaTransformada As New List(Of TablaFacturaCompra)

        For Each item In lista
            listaTransformada.Add(FacturaCompra(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function FacturaCompra(lista As List(Of TablaFacturaCompra)) As List(Of ModeloFacturaCompra)
        Dim listaTransformada As New List(Of ModeloFacturaCompra)

        For Each item In lista
            listaTransformada.Add(FacturaCompra(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "FACTURA COMPRA DETALLE"
    Public Shared Function FacturaCompraDetalle(objeto As TablaFacturaCompraDetalle) As ModeloFacturaCompraDetalle
        Return New ModeloFacturaCompraDetalle With {
                .IdFacturaCompraDetalle = objeto.idFacturaCompraDetalle,
                .Descripcion = objeto.Descripcion,
                .Unidad = objeto.Unidad,
                .Cantidad = objeto.Cantidad,
                .Precio = objeto.Precio,
                .Importe = objeto.Importe,
                .AlicuotaIVA = objeto.AlicuotaIVA,
                .Remitado = objeto.Remitado,
                .Eliminado = objeto.Eliminado,
                .AscArticulos = Articulos(objeto.ascArticulos),
                .AscFacturaCompra = FacturaCompra(objeto.ascFacturaCompra)
            }
    End Function

    Public Shared Function FacturaCompraDetalle(objeto As ModeloFacturaCompraDetalle) As TablaFacturaCompraDetalle
        Return New TablaFacturaCompraDetalle With {
                .idFacturaCompraDetalle = objeto.IdFacturaCompraDetalle,
                .Descripcion = objeto.Descripcion,
                .Unidad = objeto.Unidad,
                .Cantidad = objeto.Cantidad,
                .Precio = objeto.Precio,
                .Importe = objeto.Importe,
                .AlicuotaIVA = objeto.AlicuotaIVA,
                .Remitado = objeto.Remitado,
                .Eliminado = objeto.Eliminado,
                .ascArticulos = Articulos(objeto.AscArticulos),
                .ascFacturaCompra = FacturaCompra(objeto.AscFacturaCompra)
            }
    End Function

    Public Shared Function FacturaCompraDetalle(lista As List(Of ModeloFacturaCompraDetalle)) As List(Of TablaFacturaCompraDetalle)
        Dim listaTransformada As New List(Of TablaFacturaCompraDetalle)

        For Each item In lista
            listaTransformada.Add(FacturaCompraDetalle(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function FacturaCompraDetalle(lista As List(Of TablaFacturaCompraDetalle)) As List(Of ModeloFacturaCompraDetalle)
        Dim listaTransformada As New List(Of ModeloFacturaCompraDetalle)

        For Each item In lista
            listaTransformada.Add(FacturaCompraDetalle(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "FACTURA COMPRA MOVIMIENTOS"
    Public Shared Function FacturaCompraMovimientos(objeto As TablaFacturaCompraMovimientos) As ModeloFacturaCompraMovimientos
        Return New ModeloFacturaCompraMovimientos With {
                .IdFacturaCompraMovimientos = objeto.idFacturaCompraMovimientos,
                .Tipo = objeto.Tipo,
                .Cantidad = objeto.Cantidad,
                .Fecha = objeto.Fecha,
                .Eliminado = objeto.Eliminado,
                .AscUsuarios = Usuarios(objeto.ascUsuarios),
                .AscFacturaCompraDetalle = FacturaCompraDetalle(objeto.ascFacturaCompraDetalle)
            }
    End Function

    Public Shared Function FacturaCompraMovimientos(objeto As ModeloFacturaCompraMovimientos) As TablaFacturaCompraMovimientos
        Return New TablaFacturaCompraMovimientos With {
                .idFacturaCompraMovimientos = objeto.IdFacturaCompraMovimientos,
                .Tipo = objeto.Tipo,
                .Cantidad = objeto.Cantidad,
                .Fecha = objeto.Fecha,
                .Eliminado = objeto.Eliminado,
                .ascUsuarios = Usuarios(objeto.AscUsuarios),
                .ascFacturaCompraDetalle = FacturaCompraDetalle(objeto.AscFacturaCompraDetalle)
            }
    End Function

    Public Shared Function FacturaCompraMovimientos(lista As List(Of ModeloFacturaCompraMovimientos)) As List(Of TablaFacturaCompraMovimientos)
        Dim listaTransformada As New List(Of TablaFacturaCompraMovimientos)

        For Each item In lista
            listaTransformada.Add(FacturaCompraMovimientos(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function FacturaCompraMovimientos(lista As List(Of TablaFacturaCompraMovimientos)) As List(Of ModeloFacturaCompraMovimientos)
        Dim listaTransformada As New List(Of ModeloFacturaCompraMovimientos)

        For Each item In lista
            listaTransformada.Add(FacturaCompraMovimientos(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "FACTURA VENTA"
    Public Shared Function FacturaVenta(objeto As TablaFacturaVenta) As ModeloFacturaVenta
        Return New ModeloFacturaVenta With {
                .IdFacturaVenta = objeto.idFacturaVenta,
                .Fecha = objeto.Fecha,
                .FechaVto = objeto.FechaVto,
                .Prefijo = objeto.Prefijo,
                .NroComprobante = objeto.NroComprobante,
                .ClaseComprobante = objeto.ClaseComprobante,
                .ImporteNeto = objeto.ImporteNeto,
                .DescuentoGral = objeto.DescuentoGral,
                .BaseImponible = objeto.BaseImponible,
                .Iva = objeto.Iva,
                .ImporteTotal = objeto.ImporteTotal,
                .Observaciones = objeto.Observaciones,
                .CAE = objeto.CAE,
                .FechaVtoCAE = objeto.FechaVtoCAE,
                .Eliminado = objeto.Eliminado,
                .TipoComprobante = objeto.TipoComprobante,
                .Remitado = objeto.Remitado,
                .AscUsuarios = Usuarios(objeto.ascUsuarios),
                .AscClientes = Clientes(objeto.ascClientes),
                .AscCtaCteVenta = CuentaCorrienteVenta(objeto.ascCtaCteVenta)
            }
    End Function

    Public Shared Function FacturaVenta(objeto As ModeloFacturaVenta) As TablaFacturaVenta
        Return New TablaFacturaVenta With {
                .idFacturaVenta = objeto.IdFacturaVenta,
                .Fecha = objeto.Fecha,
                .FechaVto = objeto.FechaVto,
                .Prefijo = objeto.Prefijo,
                .NroComprobante = objeto.NroComprobante,
                .ClaseComprobante = objeto.ClaseComprobante,
                .ImporteNeto = objeto.ImporteNeto,
                .DescuentoGral = objeto.DescuentoGral,
                .BaseImponible = objeto.BaseImponible,
                .Iva = objeto.Iva,
                .ImporteTotal = objeto.ImporteTotal,
                .Observaciones = objeto.Observaciones,
                .CAE = objeto.CAE,
                .FechaVtoCAE = objeto.FechaVtoCAE,
                .Eliminado = objeto.Eliminado,
                .TipoComprobante = objeto.TipoComprobante,
                .Remitado = objeto.Remitado,
                .ascUsuarios = Usuarios(objeto.AscUsuarios),
                .ascClientes = Clientes(objeto.AscClientes),
                .ascCtaCteVenta = CuentaCorrienteVenta(objeto.AscCtaCteVenta)
            }
    End Function

    Public Shared Function FacturaVenta(lista As List(Of ModeloFacturaVenta)) As List(Of TablaFacturaVenta)
        Dim listaTransformada As New List(Of TablaFacturaVenta)

        For Each item In lista
            listaTransformada.Add(FacturaVenta(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function FacturaVenta(lista As List(Of TablaFacturaVenta)) As List(Of ModeloFacturaVenta)
        Dim listaTransformada As New List(Of ModeloFacturaVenta)

        For Each item In lista
            listaTransformada.Add(FacturaVenta(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "FACTURA VENTA DETALLE"
    Public Shared Function FacturaVentaDetalle(objeto As TablaFacturaVentaDetalle) As ModeloFacturaVentaDetalle
        Return New ModeloFacturaVentaDetalle With {
                .IdFacturaVentaDetalle = objeto.idFacturaVentaDetalle,
                .Descripcion = objeto.Descripcion,
                .Unidad = objeto.Unidad,
                .Cantidad = objeto.Cantidad,
                .Precio = objeto.Precio,
                .Importe = objeto.Importe,
                .AlicuotaIVA = objeto.AlicuotaIVA,
                .Remitado = objeto.Remitado,
                .Eliminado = objeto.Eliminado,
                .AscArticulos = Articulos(objeto.ascArticulos),
                .AscFacturaVenta = FacturaVenta(objeto.ascFacturaVenta)
            }
    End Function

    Public Shared Function FacturaVentaDetalle(objeto As ModeloFacturaVentaDetalle) As TablaFacturaVentaDetalle
        Return New TablaFacturaVentaDetalle With {
                .idFacturaVentaDetalle = objeto.IdFacturaVentaDetalle,
                .Descripcion = objeto.Descripcion,
                .Unidad = objeto.Unidad,
                .Cantidad = objeto.Cantidad,
                .Precio = objeto.Precio,
                .Importe = objeto.Importe,
                .AlicuotaIVA = objeto.AlicuotaIVA,
                .Remitado = objeto.Remitado,
                .Eliminado = objeto.Eliminado,
                .ascArticulos = Articulos(objeto.AscArticulos),
                .ascFacturaVenta = FacturaVenta(objeto.AscFacturaVenta)
            }
    End Function

    Public Shared Function FacturaVentaDetalle(lista As List(Of ModeloFacturaVentaDetalle)) As List(Of TablaFacturaVentaDetalle)
        Dim listaTransformada As New List(Of TablaFacturaVentaDetalle)

        For Each item In lista
            listaTransformada.Add(FacturaVentaDetalle(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function FacturaVentaDetalle(lista As List(Of TablaFacturaVentaDetalle)) As List(Of ModeloFacturaVentaDetalle)
        Dim listaTransformada As New List(Of ModeloFacturaVentaDetalle)

        For Each item In lista
            listaTransformada.Add(FacturaVentaDetalle(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "FACTURA VENTA MOVIMIENTOS"
    Public Shared Function FacturaVentaMovimientos(objeto As TablaFacturaVentaMovimientos) As ModeloFacturaVentaMovimientos
        Return New ModeloFacturaVentaMovimientos With {
                .IdFacturaVentaMovimientos = objeto.idFacturaVentaMovimientos,
                .Tipo = objeto.Tipo,
                .Cantidad = objeto.Cantidad,
                .Fecha = objeto.Fecha,
                .Eliminado = objeto.Eliminado,
                .AscUsuarios = Usuarios(objeto.ascUsuarios),
                .AscFacturaVentaDetalle = FacturaVentaDetalle(objeto.ascFacturaVentaDetalle)
            }
    End Function

    Public Shared Function FacturaVentaMovimientos(objeto As ModeloFacturaVentaMovimientos) As TablaFacturaVentaMovimientos
        Return New TablaFacturaVentaMovimientos With {
                .idFacturaVentaMovimientos = objeto.IdFacturaVentaMovimientos,
                .Tipo = objeto.Tipo,
                .Cantidad = objeto.Cantidad,
                .Fecha = objeto.Fecha,
                .Eliminado = objeto.Eliminado,
                .ascUsuarios = Usuarios(objeto.AscUsuarios),
                .ascFacturaVentaDetalle = FacturaVentaDetalle(objeto.AscFacturaVentaDetalle)
            }
    End Function

    Public Shared Function FacturaVentaMovimientos(lista As List(Of ModeloFacturaVentaMovimientos)) As List(Of TablaFacturaVentaMovimientos)
        Dim listaTransformada As New List(Of TablaFacturaVentaMovimientos)

        For Each item In lista
            listaTransformada.Add(FacturaVentaMovimientos(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function FacturaVentaMovimientos(lista As List(Of TablaFacturaVentaMovimientos)) As List(Of ModeloFacturaVentaMovimientos)
        Dim listaTransformada As New List(Of ModeloFacturaVentaMovimientos)

        For Each item In lista
            listaTransformada.Add(FacturaVentaMovimientos(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "FACTURA VENTA MONEDAS"
    Public Shared Function FacturaVentaMonedas(objeto As TablaFacturaVentaMonedas) As ModeloFacturaVentaMonedas
        Return New ModeloFacturaVentaMonedas With {
                .IdFacturaVtaMonedas = objeto.idFacturaVtaMonedas,
                .TipoCambio = objeto.TipoCambio,
                .ImporteNeto = objeto.ImporteNeto,
                .DescuentoGral = objeto.DescuentoGral,
                .BaseImponible = objeto.BaseImponible,
                .IVA = objeto.IVA,
                .ImporteTotal = objeto.ImporteTotal,
                .Eliminado = objeto.Eliminado,
                .AscFacturaVenta = FacturaVenta(objeto.ascFacturaVenta)
            }
    End Function

    Public Shared Function FacturaVentaMonedas(objeto As ModeloFacturaVentaMonedas) As TablaFacturaVentaMonedas
        Return New TablaFacturaVentaMonedas With {
                .idFacturaVtaMonedas = objeto.IdFacturaVtaMonedas,
                .TipoCambio = objeto.TipoCambio,
                .ImporteNeto = objeto.ImporteNeto,
                .DescuentoGral = objeto.DescuentoGral,
                .BaseImponible = objeto.BaseImponible,
                .IVA = objeto.IVA,
                .ImporteTotal = objeto.ImporteTotal,
                .Eliminado = objeto.Eliminado,
                .ascFacturaVenta = FacturaVenta(objeto.AscFacturaVenta)
            }
    End Function

    Public Shared Function FacturaVentaMonedas(lista As List(Of ModeloFacturaVentaMonedas)) As List(Of TablaFacturaVentaMonedas)
        Dim listaTransformada As New List(Of TablaFacturaVentaMonedas)

        For Each item In lista
            listaTransformada.Add(FacturaVentaMonedas(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function FacturaVentaMonedas(lista As List(Of TablaFacturaVentaMonedas)) As List(Of ModeloFacturaVentaMonedas)
        Dim listaTransformada As New List(Of ModeloFacturaVentaMonedas)

        For Each item In lista
            listaTransformada.Add(FacturaVentaMonedas(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "MONEDAS"
    Public Shared Function Monedas(objeto As TablaMonedas) As ModeloMonedas
        Return New ModeloMonedas With {
                .IdMonedas = objeto.idMonedas,
                .Tipo = objeto.Tipo,
                .Moneda = objeto.Moneda,
                .Simbolo = objeto.Simbolo,
                .Eliminado = objeto.Eliminado
            }
    End Function

    Public Shared Function Monedas(objeto As ModeloMonedas) As TablaMonedas
        Return New TablaMonedas With {
                .idMonedas = objeto.IdMonedas,
                .Tipo = objeto.Tipo,
                .Moneda = objeto.Moneda,
                .Simbolo = objeto.Simbolo,
                .Eliminado = objeto.Eliminado
            }
    End Function

    Public Shared Function Monedas(lista As List(Of ModeloMonedas)) As List(Of TablaMonedas)
        Dim listaTransformada As New List(Of TablaMonedas)

        For Each item In lista
            listaTransformada.Add(Monedas(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function Monedas(lista As List(Of TablaMonedas)) As List(Of ModeloMonedas)
        Dim listaTransformada As New List(Of ModeloMonedas)

        For Each item In lista
            listaTransformada.Add(Monedas(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "MOVIMIENTOS_FACTURA_RESERVA"
    Public Shared Function Movimientos_Factura_Reserva(objeto As TablaMovimientos_Factura_Reserva) As ModeloMovimientos_Factura_Reserva
        Return New ModeloMovimientos_Factura_Reserva With {
                .IdMovimientos_Factura_Reseva = objeto.idMovimientos_Factura_Reseva,
                .Tipo = objeto.Tipo,
                .Cantidad = objeto.Cantidad,
                .Fecha = objeto.Fecha,
                .Eliminado = objeto.Eliminado,
                .AscFacturaVentaMovimientos = FacturaVentaMovimientos(objeto.ascFacturaVentaMovimientos),
                .AscPedidoMovimientos = PedidosMovimientos(objeto.ascPedidoMovimientos)
            }
    End Function

    Public Shared Function Movimientos_Factura_Reserva(objeto As ModeloMovimientos_Factura_Reserva) As TablaMovimientos_Factura_Reserva
        Return New TablaMovimientos_Factura_Reserva With {
                .idMovimientos_Factura_Reseva = objeto.IdMovimientos_Factura_Reseva,
                .Tipo = objeto.Tipo,
                .Cantidad = objeto.Cantidad,
                .Fecha = objeto.Fecha,
                .Eliminado = objeto.Eliminado,
                .ascFacturaVentaMovimientos = FacturaVentaMovimientos(objeto.AscFacturaVentaMovimientos),
                .ascPedidoMovimientos = PedidosMovimientos(objeto.AscPedidoMovimientos)
            }
    End Function

    Public Shared Function Movimientos_Factura_Reserva(lista As List(Of ModeloMovimientos_Factura_Reserva)) As List(Of TablaMovimientos_Factura_Reserva)
        Dim listaTransformada As New List(Of TablaMovimientos_Factura_Reserva)

        For Each item In lista
            listaTransformada.Add(Movimientos_Factura_Reserva(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function Movimientos_Factura_Reserva(lista As List(Of TablaMovimientos_Factura_Reserva)) As List(Of ModeloMovimientos_Factura_Reserva)
        Dim listaTransformada As New List(Of ModeloMovimientos_Factura_Reserva)

        For Each item In lista
            listaTransformada.Add(Movimientos_Factura_Reserva(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "MOVIMIENTOS_REMITO_FACTURA"
    Public Shared Function Movimientos_Remito_Factura(objeto As TablaMovimientos_Remito_Factura) As ModeloMovimientos_Remito_Factura
        Return New ModeloMovimientos_Remito_Factura With {
                .IdMovimientos_Remito_Factura = objeto.idMovimientos_Remito_Factura,
                .Tipo = objeto.Tipo,
                .Cantidad = objeto.Cantidad,
                .Fecha = objeto.Fecha,
                .Eliminado = objeto.Eliminado,
                .AscRemitosVentaMovimientos = RemitosVentaMovimientos(objeto.ascRemitosVentaMovimientos),
                .AscFacturaVentaMovimientos = FacturaVentaMovimientos(objeto.ascFacturaVentaMovimientos)
            }
    End Function

    Public Shared Function Movimientos_Remito_Factura(objeto As ModeloMovimientos_Remito_Factura) As TablaMovimientos_Remito_Factura
        Return New TablaMovimientos_Remito_Factura With {
                .idMovimientos_Remito_Factura = objeto.IdMovimientos_Remito_Factura,
                .Tipo = objeto.Tipo,
                .Cantidad = objeto.Cantidad,
                .Fecha = objeto.Fecha,
                .Eliminado = objeto.Eliminado,
                .ascRemitosVentaMovimientos = RemitosVentaMovimientos(objeto.AscRemitosVentaMovimientos),
                .ascFacturaVentaMovimientos = FacturaVentaMovimientos(objeto.AscFacturaVentaMovimientos)
            }
    End Function

    Public Shared Function Movimientos_Remito_Factura(lista As List(Of ModeloMovimientos_Remito_Factura)) As List(Of TablaMovimientos_Remito_Factura)
        Dim listaTransformada As New List(Of TablaMovimientos_Remito_Factura)

        For Each item In lista
            listaTransformada.Add(Movimientos_Remito_Factura(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function Movimientos_Remito_Factura(lista As List(Of TablaMovimientos_Remito_Factura)) As List(Of ModeloMovimientos_Remito_Factura)
        Dim listaTransformada As New List(Of ModeloMovimientos_Remito_Factura)

        For Each item In lista
            listaTransformada.Add(Movimientos_Remito_Factura(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "MOVIMIENTOS_REMITO COMPRA_FACTURA COMPRA"
    Public Shared Function Movimientos_RemitoCompra_FacturaCompra(objeto As TablaMovimientos_RemitoCompra_FacturaCompra) As ModeloMovimientos_RemitoCompra_FacturaCompra
        Return New ModeloMovimientos_RemitoCompra_FacturaCompra With {
                .IdMovimientos_RemitoCompra_FacturaCompra = objeto.idMovimientos_RemitoCompra_FacturaCompra,
                .Tipo = objeto.Tipo,
                .Cantidad = objeto.Cantidad,
                .Fecha = objeto.Fecha,
                .Eliminado = objeto.Eliminado,
                .AscRemitosCompraMovimientos = RemitosCompraMovimientos(objeto.ascRemitosCompraMovimientos),
                .AscFacturaCompraMovimientos = FacturaCompraMovimientos(objeto.ascFacturaCompraMovimientos)
            }
    End Function

    Public Shared Function Movimientos_RemitoCompra_FacturaCompra(objeto As ModeloMovimientos_RemitoCompra_FacturaCompra) As TablaMovimientos_RemitoCompra_FacturaCompra
        Return New TablaMovimientos_RemitoCompra_FacturaCompra With {
                .idMovimientos_RemitoCompra_FacturaCompra = objeto.IdMovimientos_RemitoCompra_FacturaCompra,
                .Tipo = objeto.Tipo,
                .Cantidad = objeto.Cantidad,
                .Fecha = objeto.Fecha,
                .Eliminado = objeto.Eliminado,
                .ascRemitosCompraMovimientos = RemitosCompraMovimientos(objeto.AscRemitosCompraMovimientos),
                .ascFacturaCompraMovimientos = FacturaCompraMovimientos(objeto.AscFacturaCompraMovimientos)
            }
    End Function

    Public Shared Function Movimientos_RemitoCompra_FacturaCompra(lista As List(Of ModeloMovimientos_RemitoCompra_FacturaCompra)) As List(Of TablaMovimientos_RemitoCompra_FacturaCompra)
        Dim listaTransformada As New List(Of TablaMovimientos_RemitoCompra_FacturaCompra)

        For Each item In lista
            listaTransformada.Add(Movimientos_RemitoCompra_FacturaCompra(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function Movimientos_RemitoCompra_FacturaCompra(lista As List(Of TablaMovimientos_RemitoCompra_FacturaCompra)) As List(Of ModeloMovimientos_RemitoCompra_FacturaCompra)
        Dim listaTransformada As New List(Of ModeloMovimientos_RemitoCompra_FacturaCompra)

        For Each item In lista
            listaTransformada.Add(Movimientos_RemitoCompra_FacturaCompra(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "MOVIMIENTOS_RESERVA_REMITO"
    Public Shared Function Movimientos_Reserva_Remito(objeto As TablaMovimientos_Reserva_Remito) As ModeloMovimientos_Reserva_Remito
        Return New ModeloMovimientos_Reserva_Remito With {
                .IdMovimientos_Reserva_Remito = objeto.idMovimientos_Reserva_Remito,
                .Tipo = objeto.Tipo,
                .Cantidad = objeto.Cantidad,
                .Fecha = objeto.Fecha,
                .Eliminado = objeto.Eliminado,
                .AscRemitosVentaMovimientos = RemitosVentaMovimientos(objeto.ascRemitosVentaMovimientos),
                .AscPedidosMovimientos = PedidosMovimientos(objeto.ascPedidosMovimientos)
            }
    End Function

    Public Shared Function Movimientos_Reserva_Remito(objeto As ModeloMovimientos_Reserva_Remito) As TablaMovimientos_Reserva_Remito
        Return New TablaMovimientos_Reserva_Remito With {
                .idMovimientos_Reserva_Remito = objeto.IdMovimientos_Reserva_Remito,
                .Tipo = objeto.Tipo,
                .Cantidad = objeto.Cantidad,
                .Fecha = objeto.Fecha,
                .Eliminado = objeto.Eliminado,
                .ascRemitosVentaMovimientos = RemitosVentaMovimientos(objeto.AscRemitosVentaMovimientos),
                .ascPedidosMovimientos = PedidosMovimientos(objeto.AscPedidosMovimientos)
        }
    End Function

    Public Shared Function Movimientos_Reserva_Remito(lista As List(Of ModeloMovimientos_Reserva_Remito)) As List(Of TablaMovimientos_Reserva_Remito)
        Dim listaTransformada As New List(Of TablaMovimientos_Reserva_Remito)

        For Each item In lista
            listaTransformada.Add(Movimientos_Reserva_Remito(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function Movimientos_Reserva_Remito(lista As List(Of TablaMovimientos_Reserva_Remito)) As List(Of ModeloMovimientos_Reserva_Remito)
        Dim listaTransformada As New List(Of ModeloMovimientos_Reserva_Remito)

        For Each item In lista
            listaTransformada.Add(Movimientos_Reserva_Remito(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "MOVIMIENTO VALORES"
    Public Shared Function MovimientoValores(objeto As TablaMovimientoValores) As ModeloMovimientoValores
        Return New ModeloMovimientoValores With {
                .IdMovimientoValores = objeto.idMovimientoValores,
                .Fecha = objeto.Fecha,
                .Movimiento = objeto.Movimiento,
                .OrigenDestino = objeto.OrigenDestino,
                .Eliminado = objeto.Eliminado,
                .AscCaja = Caja(objeto.ascCaja),
                .AscValoresEnCartera = ValoreEnCartera(objeto.ascValoresEnCartera)
            }
    End Function

    Public Shared Function MovimientoValores(objeto As ModeloMovimientoValores) As TablaMovimientoValores
        Return New TablaMovimientoValores With {
                .idMovimientoValores = objeto.IdMovimientoValores,
                .Fecha = objeto.Fecha,
                .Movimiento = objeto.Movimiento,
                .OrigenDestino = objeto.OrigenDestino,
                .Eliminado = objeto.Eliminado,
                .ascCaja = Caja(objeto.AscCaja),
                .ascValoresEnCartera = ValoreEnCartera(objeto.AscValoresEnCartera)
            }
    End Function

    Public Shared Function MovimientoValores(lista As List(Of ModeloMovimientoValores)) As List(Of TablaMovimientoValores)
        Dim listaTransformada As New List(Of TablaMovimientoValores)

        For Each item In lista
            listaTransformada.Add(MovimientoValores(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function MovimientoValores(lista As List(Of TablaMovimientoValores)) As List(Of ModeloMovimientoValores)
        Dim listaTransformada As New List(Of ModeloMovimientoValores)

        For Each item In lista
            listaTransformada.Add(MovimientoValores(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "NUMERACION"
    Public Shared Function Numeracion(objeto As TablaNumeracion) As ModeloNumeracion
        Return New ModeloNumeracion With {
                .IdNumeracion = objeto.idNumeracion,
                .PuntoVenta = objeto.PuntoVenta,
                .Descripcion = objeto.Descripcion,
                .NroReserva = objeto.NroReserva,
                .NroRemito = objeto.NroRemito,
                .NroDevolucion = objeto.NroDevolucion,
                .NroFacturaA = objeto.NroFacturaA,
                .NroFacturaB = objeto.NroFacturaB,
                .NroFacturaC = objeto.NroFacturaC,
                .NroFacturaX = objeto.NroFacturaX,
                .NroNotaCreditoA = objeto.NroNotaCreditoA,
                .NroNotaCreditoB = objeto.NroNotaCreditoB,
                .NroNotaCreditoC = objeto.NroNotaCreditoC,
                .NroNotaCreditoX = objeto.NroNotaCreditoX,
                .NroNotaDebitoA = objeto.NroNotaDebitoA,
                .NroNotaDebitoB = objeto.NroNotaDebitoB,
                .NroNotaDebitoC = objeto.NroNotaDebitoC,
                .NroNotaDebitoX = objeto.NroNotaDebitoX,
                .NroRecibo = objeto.NroRecibo,
                .NroOrdenCompra = objeto.NroOrdenCompra,
                .Eliminado = objeto.Eliminado,
                .AscUsuarios = Usuarios(objeto.ascUsuarios)
            }
    End Function

    Public Shared Function Numeracion(objeto As ModeloNumeracion) As TablaNumeracion
        Return New TablaNumeracion With {
                .idNumeracion = objeto.IdNumeracion,
                .PuntoVenta = objeto.PuntoVenta,
                .Descripcion = objeto.Descripcion,
                .NroReserva = objeto.NroReserva,
                .NroRemito = objeto.NroRemito,
                .NroDevolucion = objeto.NroDevolucion,
                .NroFacturaA = objeto.NroFacturaA,
                .NroFacturaB = objeto.NroFacturaB,
                .NroFacturaC = objeto.NroFacturaC,
                .NroFacturaX = objeto.NroFacturaX,
                .NroNotaCreditoA = objeto.NroNotaCreditoA,
                .NroNotaCreditoB = objeto.NroNotaCreditoB,
                .NroNotaCreditoC = objeto.NroNotaCreditoC,
                .NroNotaCreditoX = objeto.NroNotaCreditoX,
                .NroNotaDebitoA = objeto.NroNotaDebitoA,
                .NroNotaDebitoB = objeto.NroNotaDebitoB,
                .NroNotaDebitoC = objeto.NroNotaDebitoC,
                .NroNotaDebitoX = objeto.NroNotaDebitoX,
                .NroRecibo = objeto.NroRecibo,
                .NroOrdenCompra = objeto.NroOrdenCompra,
                .Eliminado = objeto.Eliminado,
                .ascUsuarios = Usuarios(objeto.AscUsuarios)
            }
    End Function

    Public Shared Function Numeracion(lista As List(Of ModeloNumeracion)) As List(Of TablaNumeracion)
        Dim listaTransformada As New List(Of TablaNumeracion)

        For Each item In lista
            listaTransformada.Add(Numeracion(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function Numeracion(lista As List(Of TablaNumeracion)) As List(Of ModeloNumeracion)
        Dim listaTransformada As New List(Of ModeloNumeracion)

        For Each item In lista
            listaTransformada.Add(Numeracion(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "ORDEN DE PAGO"
    Public Shared Function OrdenDePago(objeto As TablaOrdenDePago) As ModeloOrdenDePago
        Return New ModeloOrdenDePago With {
                .IdOrdenDePago = objeto.idOrdenDePago,
                .NroComprobante = objeto.NroComprobante,
                .Fecha = objeto.Fecha,
                .ImportePesos = objeto.ImportePesos,
                .ImporteDolares = objeto.ImporteDolares,
                .Observaciones = objeto.Observaciones,
                .Eliminado = objeto.Eliminado,
                .AscUsuarios = Usuarios(objeto.ascUsuarios),
                .AscProveedores = Proveedores(objeto.ascProveedores),
                .AscCuentaCorrienteCompra = CuentaCorrienteCompra(objeto.ascCuentaCorrienteCompra)
            }
    End Function

    Public Shared Function OrdenDePago(objeto As ModeloOrdenDePago) As TablaOrdenDePago
        Return New TablaOrdenDePago With {
                .idOrdenDePago = objeto.IdOrdenDePago,
                .NroComprobante = objeto.NroComprobante,
                .Fecha = objeto.Fecha,
                .ImportePesos = objeto.ImportePesos,
                .ImporteDolares = objeto.ImporteDolares,
                .Observaciones = objeto.Observaciones,
                .Eliminado = objeto.Eliminado,
                .ascUsuarios = Usuarios(objeto.AscUsuarios),
                .ascProveedores = Proveedores(objeto.AscProveedores),
                .ascCuentaCorrienteCompra = CuentaCorrienteCompra(objeto.AscCuentaCorrienteCompra)
            }
    End Function

    Public Shared Function OrdenDePago(lista As List(Of ModeloOrdenDePago)) As List(Of TablaOrdenDePago)
        Dim listaTransformada As New List(Of TablaOrdenDePago)

        For Each item In lista
            listaTransformada.Add(OrdenDePago(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function OrdenDePago(lista As List(Of TablaOrdenDePago)) As List(Of ModeloOrdenDePago)
        Dim listaTransformada As New List(Of ModeloOrdenDePago)

        For Each item In lista
            listaTransformada.Add(OrdenDePago(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "ORDEN DE PAGO MONEDAS"
    Public Shared Function OrdenDePagoMonedas(objeto As TablaOrdenDePagoMonedas) As ModeloOrdenDePagoMonedas
        Return New ModeloOrdenDePagoMonedas With {
                .IdOrdenDePagoMonedas = objeto.idOrdenDePagoMonedas,
                .TipoCambio = objeto.TipoCambio,
                .ImporteNeto = objeto.ImporteNeto,
                .DescuentoGral = objeto.DescuentoGral,
                .BaseImponible = objeto.BaseImponible,
                .IVA = objeto.IVA,
                .ImporteTotal = objeto.ImporteTotal,
                .Eliminado = objeto.Eliminado,
                .AscOrdenDePago = OrdenDePago(objeto.ascOrdenDePago)
            }
    End Function

    Public Shared Function OrdenDePagoMonedas(objeto As ModeloOrdenDePagoMonedas) As TablaOrdenDePagoMonedas
        Return New TablaOrdenDePagoMonedas With {
                .idOrdenDePagoMonedas = objeto.IdOrdenDePagoMonedas,
                .TipoCambio = objeto.TipoCambio,
                .ImporteNeto = objeto.ImporteNeto,
                .DescuentoGral = objeto.DescuentoGral,
                .BaseImponible = objeto.BaseImponible,
                .IVA = objeto.IVA,
                .ImporteTotal = objeto.ImporteTotal,
                .Eliminado = objeto.Eliminado,
                .ascOrdenDePago = OrdenDePago(objeto.AscOrdenDePago)
            }
    End Function

    Public Shared Function OrdenDePagoMonedas(lista As List(Of ModeloOrdenDePagoMonedas)) As List(Of TablaOrdenDePagoMonedas)
        Dim listaTransformada As New List(Of TablaOrdenDePagoMonedas)

        For Each item In lista
            listaTransformada.Add(OrdenDePagoMonedas(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function OrdenDePagoMonedas(lista As List(Of TablaOrdenDePagoMonedas)) As List(Of ModeloOrdenDePagoMonedas)
        Dim listaTransformada As New List(Of ModeloOrdenDePagoMonedas)

        For Each item In lista
            listaTransformada.Add(OrdenDePagoMonedas(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "ORDEN DE PAGO DETALLE"
    Public Shared Function OrdenDePagoDetalle(objeto As TablaOrdenDePagoDetalle) As ModeloOrdenDePagoDetalle
        Return New ModeloOrdenDePagoDetalle With {
                .IdOrdenPagoDetalle = objeto.idOrdenPagoDetalle,
                .MedioPago = objeto.MedioPago,
                .NroComprobante = objeto.NroComprobante,
                .EntidadEmisora = objeto.EntidadEmisora,
                .SucursalEntidad = objeto.SucursalEntidad,
                .Librador = objeto.Librador,
                .FechaCobro = objeto.FechaCobro,
                .Moneda = objeto.Moneda,
                .Importe = objeto.Importe,
                .Eliminado = objeto.Eliminado,
                .AscOrdenDePago = OrdenDePago(objeto.ascOrdenDePago)
            }
    End Function

    Public Shared Function OrdenDePagoDetalle(objeto As ModeloOrdenDePagoDetalle) As TablaOrdenDePagoDetalle
        Return New TablaOrdenDePagoDetalle With {
                .idOrdenPagoDetalle = objeto.IdOrdenPagoDetalle,
                .MedioPago = objeto.MedioPago,
                .NroComprobante = objeto.NroComprobante,
                .EntidadEmisora = objeto.EntidadEmisora,
                .SucursalEntidad = objeto.SucursalEntidad,
                .Librador = objeto.Librador,
                .FechaCobro = objeto.FechaCobro,
                .Moneda = objeto.Moneda,
                .Importe = objeto.Importe,
                .Eliminado = objeto.Eliminado,
                .ascOrdenDePago = OrdenDePago(objeto.AscOrdenDePago)
            }
    End Function

    Public Shared Function OrdenDePagoDetalle(lista As List(Of ModeloOrdenDePagoDetalle)) As List(Of TablaOrdenDePagoDetalle)
        Dim listaTransformada As New List(Of TablaOrdenDePagoDetalle)

        For Each item In lista
            listaTransformada.Add(OrdenDePagoDetalle(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function OrdenDePagoDetalle(lista As List(Of TablaOrdenDePagoDetalle)) As List(Of ModeloOrdenDePagoDetalle)
        Dim listaTransformada As New List(Of ModeloOrdenDePagoDetalle)

        For Each item In lista
            listaTransformada.Add(OrdenDePagoDetalle(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "PARIDAD CAMBIARIA"
    Public Shared Function ParidadCambiaria(objeto As TablaParidadCambiaria) As ModeloParidadCambiaria
        Return New ModeloParidadCambiaria With {
                .IdParidadCambiaria = objeto.idParidadCambiaria,
                .Fecha = objeto.Fecha,
                .CotizacionCompra = objeto.CotizacionCompra,
                .CotizacionVenta = objeto.CotizacionVenta,
                .Eliminado = objeto.Eliminado,
                .AscMonedas = Monedas(objeto.ascMonedas)
            }
    End Function

    Public Shared Function ParidadCambiaria(objeto As ModeloParidadCambiaria) As TablaParidadCambiaria
        Return New TablaParidadCambiaria With {
                .idParidadCambiaria = objeto.IdParidadCambiaria,
                .Fecha = objeto.Fecha,
                .CotizacionCompra = objeto.CotizacionCompra,
                .CotizacionVenta = objeto.CotizacionVenta,
                .Eliminado = objeto.Eliminado,
                .ascMonedas = Monedas(objeto.AscMonedas)
            }
    End Function

    Public Shared Function ParidadCambiaria(lista As List(Of ModeloParidadCambiaria)) As List(Of TablaParidadCambiaria)
        Dim listaTransformada As New List(Of TablaParidadCambiaria)

        For Each item In lista
            listaTransformada.Add(ParidadCambiaria(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function ParidadCambiaria(lista As List(Of TablaParidadCambiaria)) As List(Of ModeloParidadCambiaria)
        Dim listaTransformada As New List(Of ModeloParidadCambiaria)

        For Each item In lista
            listaTransformada.Add(ParidadCambiaria(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "PEDIDOS"
    Public Shared Function Reservas(objeto As TablaPedidos) As ModeloPedidos
        Return New ModeloPedidos With {
                .IdPedidos = objeto.idPedidos,
                .NroPedido = objeto.NroPedido,
                .Fecha = objeto.Fecha,
                .FechaCierrePedido = objeto.FechaCierrePedido,
                .Remitado = objeto.Remitado,
                .Facturado = objeto.Facturado,
                .Observaciones = objeto.Observaciones,
                .Eliminado = objeto.Eliminado,
                .AscUsuarios = Usuarios(objeto.ascUsuarios),
                .AscClientes = Clientes(objeto.ascClientes)
            }
    End Function

    Public Shared Function Reservas(objeto As ModeloPedidos) As TablaPedidos
        Return New TablaPedidos With {
                .idPedidos = objeto.IdPedidos,
                .NroPedido = objeto.NroPedido,
                .Fecha = objeto.Fecha,
                .FechaCierrePedido = objeto.FechaCierrePedido,
                .Remitado = objeto.Remitado,
                .Facturado = objeto.Facturado,
                .Observaciones = objeto.Observaciones,
                .Eliminado = objeto.Eliminado,
                .ascUsuarios = Usuarios(objeto.AscUsuarios),
                .ascClientes = Clientes(objeto.AscClientes)
            }
    End Function

    Public Shared Function Reservas(lista As List(Of ModeloPedidos)) As List(Of TablaPedidos)
        Dim listaTransformada As New List(Of TablaPedidos)

        For Each item In lista
            listaTransformada.Add(Reservas(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function Reservas(lista As List(Of TablaPedidos)) As List(Of ModeloPedidos)
        Dim listaTransformada As New List(Of ModeloPedidos)

        For Each item In lista
            listaTransformada.Add(Reservas(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "PEDIDOS DETALLES"
    Public Shared Function DetalleReservas(objeto As TablaPedidoDetalle) As ModeloPedidoDetalle
        Return New ModeloPedidoDetalle With {
                .IdPedidosDetalle = objeto.idPedidosDetalle,
                .Cantidad = objeto.Cantidad,
                .Remitado = objeto.Remitado,
                .Facturado = objeto.Facturado,
                .Eliminado = objeto.Eliminado,
                .AscArticulos = Articulos(objeto.ascArticulos),
                .AscPedidos = Reservas(objeto.ascPedidos)
            }
    End Function

    Public Shared Function DetalleReservas(objeto As ModeloPedidoDetalle) As TablaPedidoDetalle
        Return New TablaPedidoDetalle With {
                .idPedidosDetalle = objeto.IdPedidosDetalle,
                .Cantidad = objeto.Cantidad,
                .Remitado = objeto.Remitado,
                .Facturado = objeto.Facturado,
                .Eliminado = objeto.Eliminado,
                .ascArticulos = Articulos(objeto.AscArticulos),
                .ascPedidos = Reservas(objeto.AscPedidos)
            }
    End Function

    Public Shared Function DetalleReservas(lista As List(Of ModeloPedidoDetalle)) As List(Of TablaPedidoDetalle)
        Dim listaTransformada As New List(Of TablaPedidoDetalle)

        For Each item In lista
            listaTransformada.Add(DetalleReservas(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function DetalleReservas(lista As List(Of TablaPedidoDetalle)) As List(Of ModeloPedidoDetalle)
        Dim listaTransformada As New List(Of ModeloPedidoDetalle)

        For Each item In lista
            listaTransformada.Add(DetalleReservas(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "PEDIDOS MOVIMIENTOS"
    Public Shared Function PedidosMovimientos(objeto As TablaPedidoMovimientos) As ModeloPedidoMovimientos
        Return New ModeloPedidoMovimientos With {
                .IdPedidosMovimientos = objeto.idPedidosMovimientos,
                .Tipo = objeto.Tipo,
                .Cantidad = objeto.Cantidad,
                .Fecha = objeto.Fecha,
                .Eliminado = objeto.Eliminado,
                .AscUsuarios = Usuarios(objeto.ascUsuarios),
                .AscPedidosDetalle = DetalleReservas(objeto.ascPedidosDetalle),
                .AscStock = Stock(objeto.ascStock)
            }
    End Function

    Public Shared Function PedidosMovimientos(objeto As ModeloPedidoMovimientos) As TablaPedidoMovimientos
        Return New TablaPedidoMovimientos With {
                .idPedidosMovimientos = objeto.IdPedidosMovimientos,
                .Tipo = objeto.Tipo,
                .Cantidad = objeto.Cantidad,
                .Fecha = objeto.Fecha,
                .Eliminado = objeto.Eliminado,
                .ascUsuarios = Usuarios(objeto.AscUsuarios),
                .ascPedidosDetalle = DetalleReservas(objeto.AscPedidosDetalle),
                .ascStock = Stock(objeto.AscStock)
            }
    End Function

    Public Shared Function PedidosMovimientos(lista As List(Of ModeloPedidoMovimientos)) As List(Of TablaPedidoMovimientos)
        Dim listaTransformada As New List(Of TablaPedidoMovimientos)

        For Each item In lista
            listaTransformada.Add(PedidosMovimientos(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function PedidosMovimientos(lista As List(Of TablaPedidoMovimientos)) As List(Of ModeloPedidoMovimientos)
        Dim listaTransformada As New List(Of ModeloPedidoMovimientos)

        For Each item In lista
            listaTransformada.Add(PedidosMovimientos(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "PERFILES USUARIOS"
    Public Shared Function PerfilesUsuarios(objeto As TablaPerfilUsuario) As ModeloPerfilUsuario
        Return New ModeloPerfilUsuario With {
                .IdPerfil = objeto.IdPerfil,
                .NombrePerfil = objeto.NombrePerfil,
                .Accesos = objeto.Accesos,
                .Eliminado = objeto.Eliminado
            }
    End Function

    Public Shared Function PerfilesUsuarios(objeto As ModeloPerfilUsuario) As TablaPerfilUsuario
        Return New TablaPerfilUsuario With {
                .IdPerfil = objeto.IdPerfil,
                .NombrePerfil = objeto.NombrePerfil,
                .Accesos = objeto.Accesos,
                .Eliminado = objeto.Eliminado
            }
    End Function

    Public Shared Function PerfilesUsuarios(lista As List(Of ModeloPerfilUsuario)) As List(Of TablaPerfilUsuario)
        Dim listaTransformada As New List(Of TablaPerfilUsuario)

        For Each item In lista
            listaTransformada.Add(PerfilesUsuarios(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function PerfilesUsuarios(lista As List(Of TablaPerfilUsuario)) As List(Of ModeloPerfilUsuario)
        Dim listaTransformada As New List(Of ModeloPerfilUsuario)

        For Each item In lista
            listaTransformada.Add(PerfilesUsuarios(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "PROVEEDORES"
    Public Shared Function Proveedores(objeto As TablaProveedores) As ModeloProveedores
        Return New ModeloProveedores With {
                .IdProveedor = objeto.idProveedor,
                .FechaAlta = objeto.FechaAlta,
                .RazonSocial = objeto.RazonSocial,
                .Direccion = objeto.Direccion,
                .Localidad = objeto.Localidad,
                .Provincia = objeto.Provincia,
                .CodPostal = objeto.CodPostal,
                .Pais = objeto.Pais,
                .Telefono = objeto.Telefono,
                .Mail = objeto.Mail,
                .Web = objeto.Web,
                .CUIT = objeto.CUIT,
                .IIBB = objeto.IIBB,
                .SituacionIVA = objeto.SituacionIVA,
                .Estado = objeto.Estado,
                .Eliminado = objeto.Eliminado,
                .AscUsuarios = Usuarios(objeto.ascUsuarios)
            }
    End Function

    Public Shared Function Proveedores(objeto As ModeloProveedores) As TablaProveedores
        Return New TablaProveedores With {
                .idProveedor = objeto.IdProveedor,
                .FechaAlta = objeto.FechaAlta,
                .RazonSocial = objeto.RazonSocial,
                .Direccion = objeto.Direccion,
                .Localidad = objeto.Localidad,
                .Provincia = objeto.Provincia,
                .CodPostal = objeto.CodPostal,
                .Pais = objeto.Pais,
                .Telefono = objeto.Telefono,
                .Mail = objeto.Mail,
                .Web = objeto.Web,
                .CUIT = objeto.CUIT,
                .IIBB = objeto.IIBB,
                .SituacionIVA = objeto.SituacionIVA,
                .Estado = objeto.Estado,
                .Eliminado = objeto.Eliminado,
                .ascUsuarios = Usuarios(objeto.AscUsuarios)
            }
    End Function

    Public Shared Function Proveedores(lista As List(Of ModeloProveedores)) As List(Of TablaProveedores)
        Dim listaTransformada As New List(Of TablaProveedores)

        For Each item In lista
            listaTransformada.Add(Proveedores(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function Proveedores(lista As List(Of TablaProveedores)) As List(Of ModeloProveedores)
        Dim listaTransformada As New List(Of ModeloProveedores)

        For Each item In lista
            listaTransformada.Add(Proveedores(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "RECIBOS VENTA"
    Public Shared Function RecibosVenta(objeto As TablaRecibosVenta) As ModeloRecibosVenta
        Return New ModeloRecibosVenta With {
                .IdRecibosVenta = objeto.idRecibosVenta,
                .NroComprobante = objeto.NroComprobante,
                .Fecha = objeto.Fecha,
                .ImportePesos = objeto.ImportePesos,
                .ImporteDolares = objeto.ImporteDolares,
                .Observaciones = objeto.Observaciones,
                .Eliminado = objeto.Eliminado,
                .AscUsuarios = Usuarios(objeto.ascUsuarios),
                .AscClientes = Clientes(objeto.ascClientes),
                .AscCuentaCorrienteVenta = CuentaCorrienteVenta(objeto.ascCuentaCorrienteVenta)
            }
    End Function

    Public Shared Function RecibosVenta(objeto As ModeloRecibosVenta) As TablaRecibosVenta
        Return New TablaRecibosVenta With {
                .idRecibosVenta = objeto.IdRecibosVenta,
                .NroComprobante = objeto.NroComprobante,
                .Fecha = objeto.Fecha,
                .ImportePesos = objeto.ImportePesos,
                .ImporteDolares = objeto.ImporteDolares,
                .Observaciones = objeto.Observaciones,
                .Eliminado = objeto.Eliminado,
                .ascUsuarios = Usuarios(objeto.AscUsuarios),
                .ascClientes = Clientes(objeto.AscClientes),
                .ascCuentaCorrienteVenta = CuentaCorrienteVenta(objeto.AscCuentaCorrienteVenta)
            }
    End Function

    Public Shared Function RecibosVenta(lista As List(Of ModeloRecibosVenta)) As List(Of TablaRecibosVenta)
        Dim listaTransformada As New List(Of TablaRecibosVenta)

        For Each item In lista
            listaTransformada.Add(RecibosVenta(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function RecibosVenta(lista As List(Of TablaRecibosVenta)) As List(Of ModeloRecibosVenta)
        Dim listaTransformada As New List(Of ModeloRecibosVenta)

        For Each item In lista
            listaTransformada.Add(RecibosVenta(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "RECIBOS VENTA DETALLE"
    Public Shared Function RecibosVentaDetalle(objeto As TablaRecibosVentaDetalle) As ModeloRecibosVentaDetalle
        Return New ModeloRecibosVentaDetalle With {
                .IdRecibosVentaDetalle = objeto.idRecibosVentaDetalle,
                .MedioPago = objeto.MedioPago,
                .NroComprobante = objeto.NroComprobante,
                .EntidadEmisora = objeto.EntidadEmisora,
                .SucursalEntidad = objeto.SucursalEntidad,
                .Librador = objeto.Librador,
                .FechaCobro = objeto.FechaCobro,
                .Moneda = objeto.Moneda,
                .Importe = objeto.Importe,
                .Eliminado = objeto.Eliminado,
                .AscRecibosVenta = RecibosVenta(objeto.ascRecibosVenta)
            }
    End Function

    Public Shared Function RecibosVentaDetalle(objeto As ModeloRecibosVentaDetalle) As TablaRecibosVentaDetalle
        Return New TablaRecibosVentaDetalle With {
                .idRecibosVentaDetalle = objeto.IdRecibosVentaDetalle,
                .MedioPago = objeto.MedioPago,
                .NroComprobante = objeto.NroComprobante,
                .EntidadEmisora = objeto.EntidadEmisora,
                .SucursalEntidad = objeto.SucursalEntidad,
                .Librador = objeto.Librador,
                .FechaCobro = objeto.FechaCobro,
                .Moneda = objeto.Moneda,
                .Importe = objeto.Importe,
                .Eliminado = objeto.Eliminado,
                .ascRecibosVenta = RecibosVenta(objeto.AscRecibosVenta)
            }
    End Function

    Public Shared Function RecibosVentaDetalle(lista As List(Of ModeloRecibosVentaDetalle)) As List(Of TablaRecibosVentaDetalle)
        Dim listaTransformada As New List(Of TablaRecibosVentaDetalle)

        For Each item In lista
            listaTransformada.Add(RecibosVentaDetalle(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function RecibosVentaDetalle(lista As List(Of TablaRecibosVentaDetalle)) As List(Of ModeloRecibosVentaDetalle)
        Dim listaTransformada As New List(Of ModeloRecibosVentaDetalle)

        For Each item In lista
            listaTransformada.Add(RecibosVentaDetalle(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "RECIBOS VENTA MONEDAS"
    Public Shared Function RecibosVentaMonedas(objeto As TablaRecibosVentaMonedas) As ModeloRecibosVentaMonedas
        Return New ModeloRecibosVentaMonedas With {
                .IdRecibosVentaMonedas = objeto.idRecibosVentaMonedas,
                .TipoCambio = objeto.TipoCambio,
                .ImporteNeto = objeto.ImporteNeto,
                .DescuentoGral = objeto.DescuentoGral,
                .BaseImponible = objeto.BaseImponible,
                .IVA = objeto.IVA,
                .ImporteTotal = objeto.ImporteTotal,
                .Eliminado = objeto.Eliminado,
                .AscRecibosVenta = RecibosVenta(objeto.ascRecibosVenta)
            }
    End Function

    Public Shared Function RecibosVentaMonedas(objeto As ModeloRecibosVentaMonedas) As TablaRecibosVentaMonedas
        Return New TablaRecibosVentaMonedas With {
                .idRecibosVentaMonedas = objeto.IdRecibosVentaMonedas,
                .TipoCambio = objeto.TipoCambio,
                .ImporteNeto = objeto.ImporteNeto,
                .DescuentoGral = objeto.DescuentoGral,
                .BaseImponible = objeto.BaseImponible,
                .IVA = objeto.IVA,
                .ImporteTotal = objeto.ImporteTotal,
                .Eliminado = objeto.Eliminado,
                .ascRecibosVenta = RecibosVenta(objeto.AscRecibosVenta)
            }
    End Function

    Public Shared Function RecibosVentaMonedas(lista As List(Of ModeloRecibosVentaMonedas)) As List(Of TablaRecibosVentaMonedas)
        Dim listaTransformada As New List(Of TablaRecibosVentaMonedas)

        For Each item In lista
            listaTransformada.Add(RecibosVentaMonedas(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function RecibosVentaMonedas(lista As List(Of TablaRecibosVentaMonedas)) As List(Of ModeloRecibosVentaMonedas)
        Dim listaTransformada As New List(Of ModeloRecibosVentaMonedas)

        For Each item In lista
            listaTransformada.Add(RecibosVentaMonedas(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "REMITO COMPRA MONEDAS"
    Public Shared Function RemitoCompraMonedas(objeto As TablaRemitoComMonedas) As ModeloRemitoComMonedas
        Return New ModeloRemitoComMonedas With {
                .IdRemitoComMonedas = objeto.idRemitoComMonedas,
                .TipoCambio = objeto.TipoCambio,
                .ImporteNeto = objeto.ImporteNeto,
                .DescuentoGral = objeto.DescuentoGral,
                .BaseImponible = objeto.BaseImponible,
                .IVA = objeto.IVA,
                .ImporteTotal = objeto.ImporteTotal,
                .Eliminado = objeto.Eliminado,
                .AscRemitosCompra = RemitoCompra(objeto.ascRemitosCompra)
            }
    End Function

    Public Shared Function RemitoCompraMonedas(objeto As ModeloRemitoComMonedas) As TablaRemitoComMonedas
        Return New TablaRemitoComMonedas With {
                .idRemitoComMonedas = objeto.IdRemitoComMonedas,
                .TipoCambio = objeto.TipoCambio,
                .ImporteNeto = objeto.ImporteNeto,
                .DescuentoGral = objeto.DescuentoGral,
                .BaseImponible = objeto.BaseImponible,
                .IVA = objeto.IVA,
                .ImporteTotal = objeto.ImporteTotal,
                .Eliminado = objeto.Eliminado,
                .ascRemitosCompra = RemitoCompra(objeto.AscRemitosCompra)
            }
    End Function

    Public Shared Function RemitoCompraMonedas(lista As List(Of ModeloRemitoComMonedas)) As List(Of TablaRemitoComMonedas)
        Dim listaTransformada As New List(Of TablaRemitoComMonedas)

        For Each item In lista
            listaTransformada.Add(RemitoCompraMonedas(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function RemitoCompraMonedas(lista As List(Of TablaRemitoComMonedas)) As List(Of ModeloRemitoComMonedas)
        Dim listaTransformada As New List(Of ModeloRemitoComMonedas)

        For Each item In lista
            listaTransformada.Add(RemitoCompraMonedas(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "REMITO COMPRA"
    Public Shared Function RemitoCompra(objeto As TablaRemitosCompra) As ModeloRemitosCompra
        Return New ModeloRemitosCompra With {
                .IdRemitosCompra = objeto.idRemitosCompra,
                .NroComprobante = objeto.NroComprobante,
                .Fecha = objeto.Fecha,
                .Importe = objeto.Importe,
                .Observaciones = objeto.Observaciones,
                .ImpOriginal = objeto.ImpOriginal,
                .ImpCopia = objeto.ImpCopia,
                .Eliminado = objeto.Eliminado,
                .Facturado = objeto.Facturado,
                .AscProveedores = Proveedores(objeto.ascProveedores),
                .AscUsuarios = Usuarios(objeto.ascUsuarios)
            }
    End Function

    Public Shared Function RemitoCompra(objeto As ModeloRemitosCompra) As TablaRemitosCompra
        Return New TablaRemitosCompra With {
                .idRemitosCompra = objeto.IdRemitosCompra,
                .NroComprobante = objeto.NroComprobante,
                .Fecha = objeto.Fecha,
                .Importe = objeto.Importe,
                .Observaciones = objeto.Observaciones,
                .ImpOriginal = objeto.ImpOriginal,
                .ImpCopia = objeto.ImpCopia,
                .Eliminado = objeto.Eliminado,
                .Facturado = objeto.Facturado,
                .ascProveedores = Proveedores(objeto.AscProveedores),
                .ascUsuarios = Usuarios(objeto.AscUsuarios)
            }
    End Function

    Public Shared Function RemitoCompra(lista As List(Of ModeloRemitosCompra)) As List(Of TablaRemitosCompra)
        Dim listaTransformada As New List(Of TablaRemitosCompra)

        For Each item In lista
            listaTransformada.Add(RemitoCompra(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function RemitoCompra(lista As List(Of TablaRemitosCompra)) As List(Of ModeloRemitosCompra)
        Dim listaTransformada As New List(Of ModeloRemitosCompra)

        For Each item In lista
            listaTransformada.Add(RemitoCompra(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "REMITOS COMPRA MOVIMIENTOS"
    Public Shared Function RemitosCompraMovimientos(objeto As TablaRemitosCompraMovimientos) As ModeloRemitosCompraMovimientos
        Return New ModeloRemitosCompraMovimientos With {
                .IdRemitosCompraMovimientos = objeto.idRemitosCompraMovimientos,
                .Tipo = objeto.Tipo,
                .Cantidad = objeto.Cantidad,
                .Fecha = objeto.Fecha,
                .Eliminado = objeto.Eliminado,
                .AscUsuarios = Usuarios(objeto.ascUsuarios),
                .AscDetalleRemtioCompra = DetalleRemitoCompra(objeto.ascDetalleRemtioCompra),
                .AscStock = Stock(objeto.ascStock)
            }
    End Function

    Public Shared Function RemitosCompraMovimientos(objeto As ModeloRemitosCompraMovimientos) As TablaRemitosCompraMovimientos
        Return New TablaRemitosCompraMovimientos With {
                .idRemitosCompraMovimientos = objeto.IdRemitosCompraMovimientos,
                .Tipo = objeto.Tipo,
                .Cantidad = objeto.Cantidad,
                .Fecha = objeto.Fecha,
                .Eliminado = objeto.Eliminado,
                .ascUsuarios = Usuarios(objeto.AscUsuarios),
                .ascDetalleRemtioCompra = DetalleRemitoCompra(objeto.AscDetalleRemtioCompra),
                .ascStock = Stock(objeto.AscStock)
            }
    End Function

    Public Shared Function RemitosCompraMovimientos(lista As List(Of ModeloRemitosCompraMovimientos)) As List(Of TablaRemitosCompraMovimientos)
        Dim listaTransformada As New List(Of TablaRemitosCompraMovimientos)

        For Each item In lista
            listaTransformada.Add(RemitosCompraMovimientos(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function RemitosCompraMovimientos(lista As List(Of TablaRemitosCompraMovimientos)) As List(Of ModeloRemitosCompraMovimientos)
        Dim listaTransformada As New List(Of ModeloRemitosCompraMovimientos)

        For Each item In lista
            listaTransformada.Add(RemitosCompraMovimientos(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "REMITO VENTA"
    Public Shared Function RemitoVenta(objeto As TablaRemitosVenta) As ModeloRemitosVenta
        Return New ModeloRemitosVenta With {
                .IdRemitosVenta = objeto.idRemitosVenta,
                .NroComprobante = objeto.NroComprobante,
                .Fecha = objeto.Fecha,
                .Importe = objeto.Importe,
                .Observaciones = objeto.Observaciones,
                .ImpOriginal = objeto.ImpOriginal,
                .ImpCopia = objeto.ImpCopia,
                .Facturado = objeto.Facturado,
                .Eliminado = objeto.Eliminado,
                .CAE = objeto.CAE,
                .FechaVtoCAE = objeto.FechaVtoCAE,
                .AscClientes = Clientes(objeto.ascClientes),
                .AscUsuarios = Usuarios(objeto.ascUsuarios)
            }
    End Function

    Public Shared Function RemitoVenta(objeto As ModeloRemitosVenta) As TablaRemitosVenta
        Return New TablaRemitosVenta With {
                .idRemitosVenta = objeto.IdRemitosVenta,
                .NroComprobante = objeto.NroComprobante,
                .Fecha = objeto.Fecha,
                .Importe = objeto.Importe,
                .Observaciones = objeto.Observaciones,
                .ImpOriginal = objeto.ImpOriginal,
                .ImpCopia = objeto.ImpCopia,
                .Eliminado = objeto.Eliminado,
                .CAE = objeto.CAE,
                .FechaVtoCAE = objeto.FechaVtoCAE,
                .Facturado = objeto.Facturado,
                .ascClientes = Clientes(objeto.AscClientes),
                .ascUsuarios = Usuarios(objeto.AscUsuarios)
            }
    End Function

    Public Shared Function RemitoVenta(lista As List(Of ModeloRemitosVenta)) As List(Of TablaRemitosVenta)
        Dim listaTransformada As New List(Of TablaRemitosVenta)

        For Each item In lista
            listaTransformada.Add(RemitoVenta(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function RemitoVenta(lista As List(Of TablaRemitosVenta)) As List(Of ModeloRemitosVenta)
        Dim listaTransformada As New List(Of ModeloRemitosVenta)

        For Each item In lista
            listaTransformada.Add(RemitoVenta(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "REMITOS VENTA MOVIMIENTOS"
    Public Shared Function RemitosVentaMovimientos(objeto As TablaRemitosVentaMovimientos) As ModeloRemitosVentaMovimientos
        Return New ModeloRemitosVentaMovimientos With {
                .IdRemitosVentasMovimientos = objeto.idRemitosVentasMovimientos,
                .Tipo = objeto.Tipo,
                .Cantidad = objeto.Cantidad,
                .Fecha = objeto.Fecha,
                .Eliminado = objeto.Eliminado,
                .AscUsuarios = Usuarios(objeto.ascUsuarios),
                .AscDetalleRemitoVenta = DetalleRemitoVenta(objeto.ascDetalleRemitoVenta),
                .AscStock = Stock(objeto.ascStock)
            }
    End Function

    Public Shared Function RemitosVentaMovimientos(objeto As ModeloRemitosVentaMovimientos) As TablaRemitosVentaMovimientos
        Return New TablaRemitosVentaMovimientos With {
                .idRemitosVentasMovimientos = objeto.IdRemitosVentasMovimientos,
                .Tipo = objeto.Tipo,
                .Cantidad = objeto.Cantidad,
                .Fecha = objeto.Fecha,
                .Eliminado = objeto.Eliminado,
                .ascUsuarios = Usuarios(objeto.AscUsuarios),
                .ascDetalleRemitoVenta = DetalleRemitoVenta(objeto.AscDetalleRemitoVenta),
                .ascStock = Stock(objeto.AscStock)
            }
    End Function

    Public Shared Function RemitosVentaMovimientos(lista As List(Of ModeloRemitosVentaMovimientos)) As List(Of TablaRemitosVentaMovimientos)
        Dim listaTransformada As New List(Of TablaRemitosVentaMovimientos)

        For Each item In lista
            listaTransformada.Add(RemitosVentaMovimientos(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function RemitosVentaMovimientos(lista As List(Of TablaRemitosVentaMovimientos)) As List(Of ModeloRemitosVentaMovimientos)
        Dim listaTransformada As New List(Of ModeloRemitosVentaMovimientos)

        For Each item In lista
            listaTransformada.Add(RemitosVentaMovimientos(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "REMITO VENTA MONEDAS"
    Public Shared Function RemitoVentaMonedas(objeto As TablaRemitosVentaMonedas) As ModeloRemitosVentaMonedas
        Return New ModeloRemitosVentaMonedas With {
                .IdRemitoVtaMonedas = objeto.idRemitoVtaMonedas,
                .TipoCambio = objeto.TipoCambio,
                .ImporteNeto = objeto.ImporteNeto,
                .DescuentoGral = objeto.DescuentoGral,
                .BaseImponible = objeto.BaseImponible,
                .IVA = objeto.IVA,
                .ImporteTotal = objeto.ImporteTotal,
                .Eliminado = objeto.Eliminado,
                .AscRemitosventa = RemitoVenta(objeto.ascRemitosventa)
            }
    End Function

    Public Shared Function RemitoVentaMonedas(objeto As ModeloRemitosVentaMonedas) As TablaRemitosVentaMonedas
        Return New TablaRemitosVentaMonedas With {
                .idRemitoVtaMonedas = objeto.IdRemitoVtaMonedas,
                .TipoCambio = objeto.TipoCambio,
                .ImporteNeto = objeto.ImporteNeto,
                .DescuentoGral = objeto.DescuentoGral,
                .BaseImponible = objeto.BaseImponible,
                .IVA = objeto.IVA,
                .ImporteTotal = objeto.ImporteTotal,
                .Eliminado = objeto.Eliminado,
                .ascRemitosventa = RemitoVenta(objeto.AscRemitosventa)
            }
    End Function

    Public Shared Function RemitoVentaMonedas(lista As List(Of ModeloRemitosVentaMonedas)) As List(Of TablaRemitosVentaMonedas)
        Dim listaTransformada As New List(Of TablaRemitosVentaMonedas)

        For Each item In lista
            listaTransformada.Add(RemitoVentaMonedas(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function RemitoVentaMonedas(lista As List(Of TablaRemitosVentaMonedas)) As List(Of ModeloRemitosVentaMonedas)
        Dim listaTransformada As New List(Of ModeloRemitosVentaMonedas)

        For Each item In lista
            listaTransformada.Add(RemitoVentaMonedas(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "RUBROS"
    Public Shared Function Rubros(objeto As TablaRubro) As ModeloRubro
        Return New ModeloRubro With {
                .IdRubro = objeto.idRubro,
                .Abrebiatura = objeto.Abrebiatura,
                .Descripcion = objeto.Descripcion,
                .Eliminado = objeto.Eliminado,
                .AscUsuarios = Usuarios(objeto.ascUsuarios)
            }
    End Function
    Public Shared Function Rubros(objeto As ModeloRubro) As TablaRubro
        Return New TablaRubro With {
                .idRubro = objeto.IdRubro,
                .Abrebiatura = objeto.Abrebiatura,
                .Descripcion = objeto.Descripcion,
                .Eliminado = objeto.Eliminado,
                .ascUsuarios = Usuarios(objeto.AscUsuarios)
            }
    End Function

    Public Shared Function Rubros(lista As List(Of ModeloRubro)) As List(Of TablaRubro)
        Dim listaTransformada As New List(Of TablaRubro)

        For Each item In lista
            listaTransformada.Add(Rubros(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function Rubros(lista As List(Of TablaRubro)) As List(Of ModeloRubro)
        Dim listaTransformada As New List(Of ModeloRubro)

        For Each item In lista
            listaTransformada.Add(Rubros(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "STOCK"
    Public Shared Function Stock(objeto As TablaStock) As ModeloStock
        Return New ModeloStock With {
                .IdStock = objeto.idStock,
                .Fecha = objeto.Fecha,
                .Movimiento = objeto.Movimiento,
                .Cantidad = objeto.Cantidad,
                .Eliminado = objeto.Eliminado,
                .AscArticulos = Articulos(objeto.ascArticulos),
                .AscDepositos = Depositos(objeto.ascDepositos),
                .AscUsuarios = Usuarios(objeto.ascUsuarios)
            }
    End Function

    Public Shared Function Stock(objeto As ModeloStock) As TablaStock
        Return New TablaStock With {
                .idStock = objeto.IdStock,
                .Fecha = objeto.Fecha,
                .Movimiento = objeto.Movimiento,
                .Cantidad = objeto.Cantidad,
                .Eliminado = objeto.Eliminado,
                .ascArticulos = Articulos(objeto.AscArticulos),
                .ascDepositos = Depositos(objeto.AscDepositos),
                .ascUsuarios = Usuarios(objeto.AscUsuarios)
            }
    End Function

    Public Shared Function Stock(lista As List(Of ModeloStock)) As List(Of TablaStock)
        Dim listaTransformada As New List(Of TablaStock)

        For Each item In lista
            listaTransformada.Add(Stock(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function Stock(lista As List(Of TablaStock)) As List(Of ModeloStock)
        Dim listaTransformada As New List(Of ModeloStock)

        For Each item In lista
            listaTransformada.Add(Stock(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "SUB RUBROS"
    Public Shared Function SubRubros(objeto As TablaSubRubro) As ModeloSubRubro
        Return New ModeloSubRubro With {
                .IdSubRubro = objeto.idSubRubro,
                .Abrebiatura = objeto.Abrebiatura,
                .Descripcion = objeto.Descripcion,
                .Eliminado = objeto.Eliminado,
                .AscRubro = Rubros(objeto.ascRubro),
                .AscUsuarios = Usuarios(objeto.ascUsuarios)
            }
    End Function
    Public Shared Function SubRubros(objeto As ModeloSubRubro) As TablaSubRubro
        Return New TablaSubRubro With {
                .idSubRubro = objeto.IdSubRubro,
                .Abrebiatura = objeto.Abrebiatura,
                .Descripcion = objeto.Descripcion,
                .Eliminado = objeto.Eliminado,
                .ascRubro = Rubros(objeto.AscRubro),
                .ascUsuarios = Usuarios(objeto.AscUsuarios)
            }
    End Function

    Public Shared Function SubRubros(lista As List(Of ModeloSubRubro)) As List(Of TablaSubRubro)
        Dim listaTransformada As New List(Of TablaSubRubro)

        For Each item In lista
            listaTransformada.Add(SubRubros(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function SubRubros(lista As List(Of TablaSubRubro)) As List(Of ModeloSubRubro)
        Dim listaTransformada As New List(Of ModeloSubRubro)

        For Each item In lista
            listaTransformada.Add(SubRubros(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "USUARIOS"
    Public Shared Function Usuarios(objeto As TablaUsuarios) As ModeloUsuario
        Return New ModeloUsuario With {
                .IdUsuarios = objeto.idUsuario,
                .FechaAlta = objeto.FechaAlta,
                .Nombre = objeto.Nombre,
                .Tipo = objeto.Tipo,
                .Contraseña = objeto.Contraseña,
                .Imagen = objeto.Imagen,
                .Estado = objeto.Estado,
                .Token = objeto.Token,
                .Eliminado = objeto.Eliminado,
                .AscPerfilUs = PerfilesUsuarios(objeto.ascPerfilUs)
            }
    End Function

    Public Shared Function Usuarios(objeto As ModeloUsuario) As TablaUsuarios
        Return New TablaUsuarios With {
                .idUsuario = objeto.IdUsuarios,
                .FechaAlta = objeto.FechaAlta,
                .Nombre = objeto.Nombre,
                .Tipo = objeto.Tipo,
                .Contraseña = objeto.Contraseña,
                .Imagen = objeto.Imagen,
                .Estado = objeto.Estado,
                .Token = objeto.Token,
                .Eliminado = objeto.Eliminado,
                .ascPerfilUs = PerfilesUsuarios(objeto.AscPerfilUs)
            }
    End Function

    Public Shared Function Usuarios(lista As List(Of ModeloUsuario)) As List(Of TablaUsuarios)
        Dim listaTransformada As New List(Of TablaUsuarios)

        For Each item In lista
            listaTransformada.Add(Usuarios(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function Usuarios(lista As List(Of TablaUsuarios)) As List(Of ModeloUsuario)
        Dim listaTransformada As New List(Of ModeloUsuario)

        For Each item In lista
            listaTransformada.Add(Usuarios(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "VALORES EN CARTERA"
    Public Shared Function ValoreEnCartera(objeto As TablaValoresEnCartera) As ModeloValoresEnCartera
        Return New ModeloValoresEnCartera With {
                .IdValoresEnCartera = objeto.idValoresEnCartera,
                .TipoValor = objeto.TipoValor,
                .Banco = objeto.Banco,
                .Sucursal = objeto.Sucursal,
                .Numero = objeto.Numero,
                .Librador = objeto.Librador,
                .FechaCobro = objeto.FechaCobro,
                .Moneda = objeto.Moneda,
                .Importe = objeto.Importe,
                .Disponible = objeto.Disponible,
                .Eliminado = objeto.Eliminado,
                .AscUsuarios = Usuarios(objeto.ascUsuarios)
            }
    End Function

    Public Shared Function ValoreEnCartera(objeto As ModeloValoresEnCartera) As TablaValoresEnCartera
        Return New TablaValoresEnCartera With {
                .idValoresEnCartera = objeto.IdValoresEnCartera,
                .TipoValor = objeto.TipoValor,
                .Banco = objeto.Banco,
                .Sucursal = objeto.Sucursal,
                .Numero = objeto.Numero,
                .Librador = objeto.Librador,
                .FechaCobro = objeto.FechaCobro,
                .Moneda = objeto.Moneda,
                .Importe = objeto.Importe,
                .Disponible = objeto.Disponible,
                .Eliminado = objeto.Eliminado,
                .ascUsuarios = Usuarios(objeto.AscUsuarios)
            }
    End Function

    Public Shared Function ValoreEnCartera(lista As List(Of ModeloValoresEnCartera)) As List(Of TablaValoresEnCartera)
        Dim listaTransformada As New List(Of TablaValoresEnCartera)

        For Each item In lista
            listaTransformada.Add(ValoreEnCartera(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function ValoreEnCartera(lista As List(Of TablaValoresEnCartera)) As List(Of ModeloValoresEnCartera)
        Dim listaTransformada As New List(Of ModeloValoresEnCartera)

        For Each item In lista
            listaTransformada.Add(ValoreEnCartera(item))
        Next

        Return listaTransformada
    End Function
#End Region
End Class
