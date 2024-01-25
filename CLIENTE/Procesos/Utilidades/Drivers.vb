Imports Comunicacion

Public Class Drivers
#Region "ARTICULOS"
    Public Shared Function Articulos(objeto As Articulos) As ModeloArticulos
        Return New ModeloArticulos With {
                .IdArticulo = objeto.IdArticulo,
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
                .AscUsuarios = Usuario(objeto.AscUsuarios),
                .AscRubro = Rubros(objeto.AscRubro),
                .AscSubRubro = SubRubros(objeto.AscSubRubro)
            }
    End Function

    Public Shared Function Articulos(objeto As ModeloArticulos) As Articulos
        Return New Articulos With {
                .IdArticulo = objeto.IdArticulo,
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
                .AscUsuarios = Usuario(objeto.AscUsuarios),
                .AscRubro = Rubros(objeto.AscRubro),
                .AscSubRubro = SubRubros(objeto.AscSubRubro)
            }
    End Function

    Public Shared Function Articulos(lista As List(Of ModeloArticulos)) As List(Of Articulos)
        Dim listaTransformada As New List(Of Articulos)

        For Each item In lista
            listaTransformada.Add(Articulos(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function Articulos(lista As List(Of Articulos)) As List(Of ModeloArticulos)
        Dim listaTransformada As New List(Of ModeloArticulos)

        For Each item In lista
            listaTransformada.Add(Articulos(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "BANCOS"
    Public Shared Function Bancos(objeto As Bancos) As ModeloBancos
        Return New ModeloBancos With {
                .IdBancos = objeto.IdBancos,
                .Nombre = objeto.Nombre,
                .Eliminado = objeto.Eliminado,
                .AscUsuarios = Usuario(objeto.AscUsuarios)
            }
    End Function

    Public Shared Function Bancos(objeto As ModeloBancos) As Bancos
        Return New Bancos With {
                .IdBancos = objeto.IdBancos,
                .Nombre = objeto.Nombre,
                .Eliminado = objeto.Eliminado,
                .AscUsuarios = Usuario(objeto.AscUsuarios)
            }
    End Function

    Public Shared Function Bancos(lista As List(Of ModeloBancos)) As List(Of Bancos)
        Dim listaTransformada As New List(Of Bancos)

        For Each item In lista
            listaTransformada.Add(Bancos(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function Bancos(lista As List(Of Bancos)) As List(Of ModeloBancos)
        Dim listaTransformada As New List(Of ModeloBancos)

        For Each item In lista
            listaTransformada.Add(Bancos(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "CAJA"
    Public Shared Function Caja(objeto As Caja) As ModeloCaja
        Return New ModeloCaja With {
                .IdCaja = objeto.IdCaja,
                .Fecha = objeto.Fecha,
                .Movimiento = objeto.Movimiento,
                .Comprobante = objeto.Comprobante,
                .Descripcion = objeto.Descripcion,
                .Moneda = objeto.Moneda,
                .Ingreso = objeto.Ingreso,
                .Egreso = objeto.Egreso,
                .Observaciones = objeto.Observaciones,
                .Eliminado = objeto.Eliminado,
                .AscUsuarios = Usuario(objeto.AscUsuarios)
            }
    End Function

    Public Shared Function Caja(objeto As ModeloCaja) As Caja
        Return New Caja With {
                .IdCaja = objeto.IdCaja,
                .Fecha = objeto.Fecha,
                .Movimiento = objeto.Movimiento,
                .Comprobante = objeto.Comprobante,
                .Descripcion = objeto.Descripcion,
                .Moneda = objeto.Moneda,
                .Ingreso = objeto.Ingreso,
                .Egreso = objeto.Egreso,
                .Observaciones = objeto.Observaciones,
                .Eliminado = objeto.Eliminado,
                .AscUsuarios = Usuario(objeto.AscUsuarios)
            }
    End Function

    Public Shared Function Caja(lista As List(Of ModeloCaja)) As List(Of Caja)
        Dim listaTransformada As New List(Of Caja)

        For Each item In lista
            listaTransformada.Add(Caja(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function Caja(lista As List(Of Caja)) As List(Of ModeloCaja)
        Dim listaTransformada As New List(Of ModeloCaja)

        For Each item In lista
            listaTransformada.Add(Caja(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "CHEQUERAS"
    Public Shared Function Chequeras(objeto As Chequeras) As ModeloChequera
        Return New ModeloChequera With {
                .IdChequera = objeto.IdChequera,
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
                .AscUsuarios = Usuario(objeto.AscUsuarios)
            }
    End Function

    Public Shared Function Chequeras(objeto As ModeloChequera) As Chequeras
        Return New Chequeras With {
                .IdChequera = objeto.IdChequera,
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
                .AscUsuarios = Usuario(objeto.AscUsuarios)
            }
    End Function

    Public Shared Function Chequeras(lista As List(Of ModeloChequera)) As List(Of Chequeras)
        Dim listaTransformada As New List(Of Chequeras)

        For Each item In lista
            listaTransformada.Add(Chequeras(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function Chequeras(lista As List(Of Chequeras)) As List(Of ModeloChequera)
        Dim listaTransformada As New List(Of ModeloChequera)

        For Each item In lista
            listaTransformada.Add(Chequeras(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "CLIENTES"
    Public Shared Function Clientes(objeto As Clientes) As ModeloCliente
        Return New ModeloCliente With {
                .IdCliente = objeto.IdCliente,
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
                .AscUsuarios = Usuario(objeto.AscUsuarios)
            }
    End Function

    Public Shared Function Clientes(objeto As ModeloCliente) As Clientes
        Return New Clientes With {
                .IdCliente = objeto.IdCliente,
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
                .AscUsuarios = Usuario(objeto.AscUsuarios)
            }
    End Function

    Public Shared Function Clientes(lista As List(Of ModeloCliente)) As List(Of Clientes)
        Dim listaTransformada As New List(Of Clientes)

        For Each item In lista
            listaTransformada.Add(Clientes(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function Clientes(lista As List(Of Clientes)) As List(Of ModeloCliente)
        Dim listaTransformada As New List(Of ModeloCliente)

        For Each item In lista
            listaTransformada.Add(Clientes(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "COMPROBANTES"
    Public Shared Function Comprobantes(objeto As Comprobantes) As ModeloComprobantes
        Return New ModeloComprobantes With {
                .IdComprobantes = objeto.IdComprobantes,
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
                .AscUsuarios = Usuario(objeto.AscUsuarios)
            }
    End Function

    Public Shared Function Comprobantes(objeto As ModeloComprobantes) As Comprobantes
        Return New Comprobantes With {
                .IdComprobantes = objeto.IdComprobantes,
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
                .AscUsuarios = Usuario(objeto.AscUsuarios)
            }
    End Function

    Public Shared Function Comprobantes(lista As List(Of ModeloComprobantes)) As List(Of Comprobantes)
        Dim listaTransformada As New List(Of Comprobantes)

        For Each item In lista
            listaTransformada.Add(Comprobantes(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function Comprobantes(lista As List(Of Comprobantes)) As List(Of ModeloComprobantes)
        Dim listaTransformada As New List(Of ModeloComprobantes)

        For Each item In lista
            listaTransformada.Add(Comprobantes(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "CUENTA CORRIENTE COMPRA"
    Public Shared Function CuentaCorrienteCompra(objeto As CuentaCorrienteCompra) As ModeloCuentaCorrienteCompra
        Return New ModeloCuentaCorrienteCompra With {
                .IdCuentaCorrienteCompra = objeto.IdCuentaCorrienteCompra,
                .Fecha = objeto.Fecha,
                .FechaVto = objeto.FechaVto,
                .Comprobante = objeto.Comprobante,
                .Numero = objeto.Numero,
                .Detalle = objeto.Detalle,
                .Debito = objeto.Debito,
                .Credito = objeto.Credito,
                .Eliminado = objeto.Eliminado,
                .Visible = objeto.Visible,
                .AscProveedores = Proveedores(objeto.AscProveedores),
                .AscUsuarios = Usuario(objeto.AscUsuarios)
        }
    End Function

    Public Shared Function CuentaCorrienteCompra(objeto As ModeloCuentaCorrienteCompra) As CuentaCorrienteCompra
        Return New CuentaCorrienteCompra With {
                .IdCuentaCorrienteCompra = objeto.IdCuentaCorrienteCompra,
                .Fecha = objeto.Fecha,
                .FechaVto = objeto.FechaVto,
                .Comprobante = objeto.Comprobante,
                .Numero = objeto.Numero,
                .Detalle = objeto.Detalle,
                .Debito = objeto.Debito,
                .Credito = objeto.Credito,
                .Eliminado = objeto.Eliminado,
                .Visible = objeto.Visible,
                .AscProveedores = Proveedores(objeto.AscProveedores),
                .AscUsuarios = Usuario(objeto.AscUsuarios)
        }
    End Function

    Public Shared Function CuentaCorrienteCompra(lista As List(Of ModeloCuentaCorrienteCompra)) As List(Of CuentaCorrienteCompra)
        Dim listaTransformada As New List(Of CuentaCorrienteCompra)

        For Each item In lista
            listaTransformada.Add(CuentaCorrienteCompra(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function CuentaCorrienteCompra(lista As List(Of CuentaCorrienteCompra)) As List(Of ModeloCuentaCorrienteCompra)
        Dim listaTransformada As New List(Of ModeloCuentaCorrienteCompra)

        For Each item In lista
            listaTransformada.Add(CuentaCorrienteCompra(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "CUENTA CORRIENTE VENTA"
    Public Shared Function CuentaCorrienteVenta(objeto As CuentaCorrienteVenta) As ModeloCuentaCorrienteVenta
        Return New ModeloCuentaCorrienteVenta With {
                .IdCuentaCorrienteVentas = objeto.IdCuentaCorrienteVentas,
                .Fecha = objeto.Fecha,
                .FechaVto = objeto.FechaVto,
                .Comprobante = objeto.Comprobante,
                .Numero = objeto.Numero,
                .Detalle = objeto.Detalle,
                .Debito = objeto.Debito,
                .Credito = objeto.Credito,
                .Visible = objeto.Visible,
                .Eliminado = objeto.Eliminado,
                .AscClientes = Clientes(objeto.AscClientes),
                .AscUsuarios = Usuario(objeto.AscUsuarios)
        }
    End Function

    Public Shared Function CuentaCorrienteVenta(objeto As ModeloCuentaCorrienteVenta) As CuentaCorrienteVenta
        Return New CuentaCorrienteVenta With {
                .IdCuentaCorrienteVentas = objeto.IdCuentaCorrienteVentas,
                .Fecha = objeto.Fecha,
                .FechaVto = objeto.FechaVto,
                .Comprobante = objeto.Comprobante,
                .Numero = objeto.Numero,
                .Detalle = objeto.Detalle,
                .Debito = objeto.Debito,
                .Credito = objeto.Credito,
                .Visible = objeto.Visible,
                .Eliminado = objeto.Eliminado,
                .AscClientes = Clientes(objeto.AscClientes),
                .AscUsuarios = Usuario(objeto.AscUsuarios)
        }
    End Function

    Public Shared Function CuentaCorrienteVenta(lista As List(Of ModeloCuentaCorrienteVenta)) As List(Of CuentaCorrienteVenta)
        Dim listaTransformada As New List(Of CuentaCorrienteVenta)

        For Each item In lista
            listaTransformada.Add(CuentaCorrienteVenta(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function CuentaCorrienteVenta(lista As List(Of CuentaCorrienteVenta)) As List(Of ModeloCuentaCorrienteVenta)
        Dim listaTransformada As New List(Of ModeloCuentaCorrienteVenta)

        For Each item In lista
            listaTransformada.Add(CuentaCorrienteVenta(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "DATOS SISTEMA"
    Public Shared Function DatosSistema(objeto As DatosSistema) As ModeloDatosSistema
        Return New ModeloDatosSistema With {
                .IdDatosSistema = objeto.IdDatosSistema,
                .MonedaFacturacion = objeto.MonedaFacturacion,
                .MonedaContable = objeto.MonedaContable,
                .AlicuotaIva1 = objeto.AlicuotaIva1,
                .AlicuotaIva2 = objeto.AlicuotaIva2,
                .AlicuotaIva3 = objeto.AlicuotaIva3,
                .AlicuotaMargen = objeto.AlicuotaMargen,
                .AlicuotaDesc1 = objeto.AlicuotaDesc1,
                .AlicuotaDesc2 = objeto.AlicuotaDesc2,
                .AscUsuarios = Usuario(objeto.AscUsuarios)
            }
    End Function

    Public Shared Function DatosSistema(objeto As ModeloDatosSistema) As DatosSistema
        Return New DatosSistema With {
                .IdDatosSistema = objeto.IdDatosSistema,
                .MonedaFacturacion = objeto.MonedaFacturacion,
                .MonedaContable = objeto.MonedaContable,
                .AlicuotaIva1 = objeto.AlicuotaIva1,
                .AlicuotaIva2 = objeto.AlicuotaIva2,
                .AlicuotaIva3 = objeto.AlicuotaIva3,
                .AlicuotaMargen = objeto.AlicuotaMargen,
                .AlicuotaDesc1 = objeto.AlicuotaDesc1,
                .AlicuotaDesc2 = objeto.AlicuotaDesc2,
                .AscUsuarios = Usuario(objeto.AscUsuarios)
            }
    End Function

    Public Shared Function DatosSistema(lista As List(Of ModeloDatosSistema)) As List(Of DatosSistema)
        Dim listaTransformada As New List(Of DatosSistema)

        For Each item In lista
            listaTransformada.Add(DatosSistema(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function DatosSistema(lista As List(Of DatosSistema)) As List(Of ModeloDatosSistema)
        Dim listaTransformada As New List(Of ModeloDatosSistema)

        For Each item In lista
            listaTransformada.Add(DatosSistema(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "DEPOSITOS"
    Public Shared Function Depositos(objeto As Depositos) As ModeloDepositos
        Return New ModeloDepositos With {
                .IdDeposito = objeto.IdDeposito,
                .Nombre = objeto.Nombre,
                .Direccion = objeto.Direccion,
                .Localidad = objeto.Localidad,
                .Provincia = objeto.Provincia,
                .CodPostal = objeto.CodPostal,
                .Eliminado = objeto.Eliminado,
                .AscUsuarios = Usuario(objeto.AscUsuarios)
            }
    End Function

    Public Shared Function Depositos(objeto As ModeloDepositos) As Depositos
        Return New Depositos With {
                .IdDeposito = objeto.IdDeposito,
                .Nombre = objeto.Nombre,
                .Direccion = objeto.Direccion,
                .Localidad = objeto.Localidad,
                .Provincia = objeto.Provincia,
                .CodPostal = objeto.CodPostal,
                .Eliminado = objeto.Eliminado,
                .AscUsuarios = Usuario(objeto.AscUsuarios)
            }
    End Function

    Public Shared Function Depositos(lista As List(Of ModeloDepositos)) As List(Of Depositos)
        Dim listaTransformada As New List(Of Depositos)

        For Each item In lista
            listaTransformada.Add(Depositos(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function Depositos(lista As List(Of Depositos)) As List(Of ModeloDepositos)
        Dim listaTransformada As New List(Of ModeloDepositos)

        For Each item In lista
            listaTransformada.Add(Depositos(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "DETALLE CHEQUES"
    Public Shared Function DetalleCheque(objeto As DetalleCheque) As ModeloDetalleCheque
        Return New ModeloDetalleCheque With {
            .IdDetalleCheque = objeto.IdDetalleCheque,
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
            .AscChequera = Chequeras(objeto.AscChequera),
            .AscUsuarios = Usuario(objeto.AscUsuarios)
        }
    End Function

    Public Shared Function DetalleCheque(objeto As ModeloDetalleCheque) As DetalleCheque
        Return New DetalleCheque With {
            .IdDetalleCheque = objeto.IdDetalleCheque,
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
            .AscChequera = Chequeras(objeto.AscChequera),
            .AscUsuarios = Usuario(objeto.AscUsuarios)
        }
    End Function

    Public Shared Function DetalleCheque(lista As List(Of ModeloDetalleCheque)) As List(Of DetalleCheque)
        Dim listaTransformada As New List(Of DetalleCheque)

        For Each item In lista
            listaTransformada.Add(DetalleCheque(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function DetalleCheque(lista As List(Of DetalleCheque)) As List(Of ModeloDetalleCheque)
        Dim listaTransformada As New List(Of ModeloDetalleCheque)

        For Each item In lista
            listaTransformada.Add(DetalleCheque(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "DETALLE DEVOLUCIONES"
    Public Shared Function DetalleDevoluciones(objeto As DetalleDevoluciones) As ModeloDetalleDevoluciones
        Return New ModeloDetalleDevoluciones With {
                .IdDetalleDevoluciones = objeto.IdDetalleDevoluciones,
                .Descripcion = objeto.Descripcion,
                .Cantidad = objeto.Cantidad,
                .Unidad = objeto.Unidad,
                .Precio = objeto.Precio,
                .Importe = objeto.Importe,
                .AlicuotaIVA = objeto.AlicuotaIVA,
                .Eliminado = objeto.Eliminado,
                .AscArticulos = Articulos(objeto.AscArticulos),
                .AscDetalleRemitoVenta = DetalleRemitoVenta(objeto.AscDetalleRemitoVenta),
                .AscDevoluciones = Devoluciones(objeto.AscDevoluciones)
            }
    End Function

    Public Shared Function DetalleDevoluciones(objeto As ModeloDetalleDevoluciones) As DetalleDevoluciones
        Return New DetalleDevoluciones With {
                .IdDetalleDevoluciones = objeto.IdDetalleDevoluciones,
                .Descripcion = objeto.Descripcion,
                .Cantidad = objeto.Cantidad,
                .Unidad = objeto.Unidad,
                .Precio = objeto.Precio,
                .Importe = objeto.Importe,
                .AlicuotaIVA = objeto.AlicuotaIVA,
                .Eliminado = objeto.Eliminado,
                .AscArticulos = Articulos(objeto.AscArticulos),
                .AscDetalleRemitoVenta = DetalleRemitoVenta(objeto.AscDetalleRemitoVenta),
                .AscDevoluciones = Devoluciones(objeto.AscDevoluciones)
            }
    End Function

    Public Shared Function DetalleDevoluciones(lista As List(Of ModeloDetalleDevoluciones)) As List(Of DetalleDevoluciones)
        Dim listaTransformada As New List(Of DetalleDevoluciones)

        For Each item In lista
            listaTransformada.Add(DetalleDevoluciones(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function DetalleDevoluciones(lista As List(Of DetalleDevoluciones)) As List(Of ModeloDetalleDevoluciones)
        Dim listaTransformada As New List(Of ModeloDetalleDevoluciones)

        For Each item In lista
            listaTransformada.Add(DetalleDevoluciones(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "DETALLE REMITO COMPRA"
    Public Shared Function DetalleRemitoCompra(objeto As DetalleRemitoCompra) As ModeloDetalleRemitoCompra
        Return New ModeloDetalleRemitoCompra With {
                .IdDetalleRemitosCompra = objeto.IdDetalleRemitosCompra,
                .Descripcion = objeto.Descripcion,
                .Cantidad = objeto.Cantidad,
                .Unidad = objeto.Unidad,
                .Precio = objeto.Precio,
                .Importe = objeto.Importe,
                .AlicuotaIVA = objeto.AlicuotaIVA,
                .Facturado = objeto.Facturado,
                .Eliminado = objeto.Eliminado,
                .AscArticulos = Articulos(objeto.AscArticulos),
                .AscRemitosCompra = RemitoCompra(objeto.AscRemitosCompra)
            }
    End Function

    Public Shared Function DetalleRemitoCompra(objeto As ModeloDetalleRemitoCompra) As DetalleRemitoCompra
        Return New DetalleRemitoCompra With {
                .IdDetalleRemitosCompra = objeto.IdDetalleRemitosCompra,
                .Descripcion = objeto.Descripcion,
                .Cantidad = objeto.Cantidad,
                .Unidad = objeto.Unidad,
                .Precio = objeto.Precio,
                .Importe = objeto.Importe,
                .AlicuotaIVA = objeto.AlicuotaIVA,
                .Facturado = objeto.Facturado,
                .Eliminado = objeto.Eliminado,
                .AscArticulos = Articulos(objeto.AscArticulos),
                .AscRemitosCompra = RemitoCompra(objeto.AscRemitosCompra)
            }
    End Function

    Public Shared Function DetalleRemitoCompra(lista As List(Of ModeloDetalleRemitoCompra)) As List(Of DetalleRemitoCompra)
        Dim listaTransformada As New List(Of DetalleRemitoCompra)

        For Each item In lista
            listaTransformada.Add(DetalleRemitoCompra(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function DetalleRemitoCompra(lista As List(Of DetalleRemitoCompra)) As List(Of ModeloDetalleRemitoCompra)
        Dim listaTransformada As New List(Of ModeloDetalleRemitoCompra)

        For Each item In lista
            listaTransformada.Add(DetalleRemitoCompra(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "DETALLE REMITO VENTA"
    Public Shared Function DetalleRemitoVenta(objeto As DetalleRemitoVenta) As ModeloDetalleRemitoVenta
        Return New ModeloDetalleRemitoVenta With {
                .IdDetalleRemitosVenta = objeto.IdDetalleRemitosVenta,
                .Descripcion = objeto.Descripcion,
                .Cantidad = objeto.Cantidad,
                .Unidad = objeto.Unidad,
                .Precio = objeto.Precio,
                .Importe = objeto.Importe,
                .AlicuotaIVA = objeto.AlicuotaIVA,
                .Facturado = objeto.Facturado,
                .Eliminado = objeto.Eliminado,
                .AscArticulos = Articulos(objeto.AscArticulos),
                .AscRemitosVenta = RemitoVenta(objeto.AscRemitosVenta)
            }
    End Function

    Public Shared Function DetalleRemitoVenta(objeto As ModeloDetalleRemitoVenta) As DetalleRemitoVenta
        Return New DetalleRemitoVenta With {
                .IdDetalleRemitosVenta = objeto.IdDetalleRemitosVenta,
                .Descripcion = objeto.Descripcion,
                .Cantidad = objeto.Cantidad,
                .Unidad = objeto.Unidad,
                .Precio = objeto.Precio,
                .Importe = objeto.Importe,
                .AlicuotaIVA = objeto.AlicuotaIVA,
                .Facturado = objeto.Facturado,
                .Eliminado = objeto.Eliminado,
                .AscArticulos = Articulos(objeto.AscArticulos),
                .AscRemitosVenta = RemitoVenta(objeto.AscRemitosVenta)
            }
    End Function

    Public Shared Function DetalleRemitoVenta(lista As List(Of ModeloDetalleRemitoVenta)) As List(Of DetalleRemitoVenta)
        Dim listaTransformada As New List(Of DetalleRemitoVenta)

        For Each item In lista
            listaTransformada.Add(DetalleRemitoVenta(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function DetalleRemitoVenta(lista As List(Of DetalleRemitoVenta)) As List(Of ModeloDetalleRemitoVenta)
        Dim listaTransformada As New List(Of ModeloDetalleRemitoVenta)

        For Each item In lista
            listaTransformada.Add(DetalleRemitoVenta(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "DEVOLUCIONES"
    Public Shared Function Devoluciones(objeto As Devoluciones) As ModeloDevoluciones
        Return New ModeloDevoluciones With {
                .IdDevoluciones = objeto.IdDevoluciones,
                .NroComprobante = objeto.NroComprobante,
                .Fecha = objeto.Fecha,
                .Importe = objeto.Importe,
                .Observaciones = objeto.Observaciones,
                .ImpOriginal = objeto.ImpOriginal,
                .ImpCopia = objeto.ImpCopia,
                .Eliminado = objeto.Eliminado,
                .AscClientes = Clientes(objeto.AscClientes),
                .AscUsuarios = Usuario(objeto.AscUsuarios)
            }
    End Function

    Public Shared Function Devoluciones(objeto As ModeloDevoluciones) As Devoluciones
        Return New Devoluciones With {
                .IdDevoluciones = objeto.IdDevoluciones,
                .NroComprobante = objeto.NroComprobante,
                .Fecha = objeto.Fecha,
                .Importe = objeto.Importe,
                .Observaciones = objeto.Observaciones,
                .ImpOriginal = objeto.ImpOriginal,
                .ImpCopia = objeto.ImpCopia,
                .Eliminado = objeto.Eliminado,
                .AscClientes = Clientes(objeto.AscClientes),
                .AscUsuarios = Usuario(objeto.AscUsuarios)
            }
    End Function

    Public Shared Function Devoluciones(lista As List(Of ModeloDevoluciones)) As List(Of Devoluciones)
        Dim listaTransformada As New List(Of Devoluciones)

        For Each item In lista
            listaTransformada.Add(Devoluciones(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function Devoluciones(lista As List(Of Devoluciones)) As List(Of ModeloDevoluciones)
        Dim listaTransformada As New List(Of ModeloDevoluciones)

        For Each item In lista
            listaTransformada.Add(Devoluciones(item))
        Next

        Return listaTransformada
    End Function

#End Region

#Region "DEVOLUCIONES MONEDAS"
    Public Shared Function DevolucionesMonedas(objeto As DevolucionesMonedas) As ModeloDevolucionesMonedas
        Return New ModeloDevolucionesMonedas With {
                .IdDevolucionesMonedas = objeto.IdDevolucionesMonedas,
                .TipoCambio = objeto.TipoCambio,
                .ImporteNeto = objeto.ImporteNeto,
                .DescuentoGral = objeto.DescuentoGral,
                .BaseImponible = objeto.BaseImponible,
                .IVA = objeto.IVA,
                .ImporteTotal = objeto.ImporteTotal,
                .Eliminado = objeto.Eliminado,
                .AscDevoluciones = Devoluciones(objeto.AscDevoluciones)
            }
    End Function

    Public Shared Function DevolucionesMonedas(objeto As ModeloDevolucionesMonedas) As DevolucionesMonedas
        Return New DevolucionesMonedas With {
                .IdDevolucionesMonedas = objeto.IdDevolucionesMonedas,
                .TipoCambio = objeto.TipoCambio,
                .ImporteNeto = objeto.ImporteNeto,
                .DescuentoGral = objeto.DescuentoGral,
                .BaseImponible = objeto.BaseImponible,
                .IVA = objeto.IVA,
                .ImporteTotal = objeto.ImporteTotal,
                .Eliminado = objeto.Eliminado,
                .AscDevoluciones = Devoluciones(objeto.AscDevoluciones)
            }
    End Function

    Public Shared Function DevolucionesMonedas(lista As List(Of ModeloDevolucionesMonedas)) As List(Of DevolucionesMonedas)
        Dim listaTransformada As New List(Of DevolucionesMonedas)

        For Each item In lista
            listaTransformada.Add(DevolucionesMonedas(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function DevolucionesMonedas(lista As List(Of DevolucionesMonedas)) As List(Of ModeloDevolucionesMonedas)
        Dim listaTransformada As New List(Of ModeloDevolucionesMonedas)

        For Each item In lista
            listaTransformada.Add(DevolucionesMonedas(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "EMPRESAS"
    Public Shared Function Empresas(objeto As Empresa) As ModeloEmpresa
        Return New ModeloEmpresa With {
                .IdEmpresa = objeto.IdEmpresa,
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
                .AscUsuarios = Usuario(objeto.AscUsuarios)
            }
    End Function

    Public Shared Function Empresas(objeto As ModeloEmpresa) As Empresa
        Return New Empresa With {
                .IdEmpresa = objeto.IdEmpresa,
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
                .AscUsuarios = Usuario(objeto.AscUsuarios)
            }
    End Function

    Public Shared Function Empresas(lista As List(Of ModeloEmpresa)) As List(Of Empresa)
        Dim listaTransformada As New List(Of Empresa)

        For Each item In lista
            listaTransformada.Add(Empresas(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function Empresas(lista As List(Of Empresa)) As List(Of ModeloEmpresa)
        Dim listaTransformada As New List(Of ModeloEmpresa)

        For Each item In lista
            listaTransformada.Add(Empresas(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "FACTURA COMPRA MONEDAS"
    Public Shared Function FacturaCompraMonedas(objeto As FacturaCompraMonedas) As ModeloFacturaComMonedas
        Return New ModeloFacturaComMonedas With {
                .IdFacturaComMonedas = objeto.IdFacturaComMonedas,
                .TipoCambio = objeto.TipoCambio,
                .ImporteNeto = objeto.ImporteNeto,
                .DescuentoGral = objeto.DescuentoGral,
                .BaseImponible = objeto.BaseImponible,
                .IVA = objeto.IVA,
                .ImporteTotal = objeto.ImporteTotal,
                .Eliminado = objeto.Eliminado,
                .AscFacturaCompra = FacturaCompra(objeto.AscFacturaCompra)
            }
    End Function

    Public Shared Function FacturaCompraMonedas(objeto As ModeloFacturaComMonedas) As FacturaCompraMonedas
        Return New FacturaCompraMonedas With {
                .IdFacturaComMonedas = objeto.IdFacturaComMonedas,
                .TipoCambio = objeto.TipoCambio,
                .ImporteNeto = objeto.ImporteNeto,
                .DescuentoGral = objeto.DescuentoGral,
                .BaseImponible = objeto.BaseImponible,
                .IVA = objeto.IVA,
                .ImporteTotal = objeto.ImporteTotal,
                .Eliminado = objeto.Eliminado,
                .AscFacturaCompra = FacturaCompra(objeto.AscFacturaCompra)
            }
    End Function

    Public Shared Function FacturaCompraMonedas(lista As List(Of ModeloFacturaComMonedas)) As List(Of FacturaCompraMonedas)
        Dim listaTransformada As New List(Of FacturaCompraMonedas)

        For Each item In lista
            listaTransformada.Add(FacturaCompraMonedas(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function FacturaCompraMonedas(lista As List(Of FacturaCompraMonedas)) As List(Of ModeloFacturaComMonedas)
        Dim listaTransformada As New List(Of ModeloFacturaComMonedas)

        For Each item In lista
            listaTransformada.Add(FacturaCompraMonedas(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "FACTURA COMPRA"
    Public Shared Function FacturaCompra(objeto As FacturaCompra) As ModeloFacturaCompra
        Return New ModeloFacturaCompra With {
                .IdFacturaCompra = objeto.IdFacturaCompra,
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
                .AscUsuarios = Usuario(objeto.AscUsuarios),
                .AscProveedores = Proveedores(objeto.AscProveedores),
                .AscCuentaCorrienteCompra = CuentaCorrienteCompra(objeto.AscCuentaCorrienteCompra)
            }
    End Function

    Public Shared Function FacturaCompra(objeto As ModeloFacturaCompra) As FacturaCompra
        Return New FacturaCompra With {
                .IdFacturaCompra = objeto.IdFacturaCompra,
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
                .AscUsuarios = Usuario(objeto.AscUsuarios),
                .AscProveedores = Proveedores(objeto.AscProveedores),
                .AscCuentaCorrienteCompra = CuentaCorrienteCompra(objeto.AscCuentaCorrienteCompra)
            }
    End Function

    Public Shared Function FacturaCompra(lista As List(Of ModeloFacturaCompra)) As List(Of FacturaCompra)
        Dim listaTransformada As New List(Of FacturaCompra)

        For Each item In lista
            listaTransformada.Add(FacturaCompra(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function FacturaCompra(lista As List(Of FacturaCompra)) As List(Of ModeloFacturaCompra)
        Dim listaTransformada As New List(Of ModeloFacturaCompra)

        For Each item In lista
            listaTransformada.Add(FacturaCompra(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "FACTURA COMPRA DETALLE"
    Public Shared Function FacturaCompraDetalle(objeto As FacturaCompraDetalle) As ModeloFacturaCompraDetalle
        Return New ModeloFacturaCompraDetalle With {
                .IdFacturaCompraDetalle = objeto.IdFacturaCompraDetalle,
                .Descripcion = objeto.Descripcion,
                .Unidad = objeto.Unidad,
                .Cantidad = objeto.Cantidad,
                .Precio = objeto.Precio,
                .Importe = objeto.Importe,
                .AlicuotaIVA = objeto.AlicuotaIVA,
                .Remitado = objeto.Remitado,
                .Eliminado = objeto.Eliminado,
                .AscArticulos = Articulos(objeto.AscArticulos),
                .AscFacturaCompra = FacturaCompra(objeto.AscFacturaCompra)
            }
    End Function

    Public Shared Function FacturaCompraDetalle(objeto As ModeloFacturaCompraDetalle) As FacturaCompraDetalle
        Return New FacturaCompraDetalle With {
                .IdFacturaCompraDetalle = objeto.IdFacturaCompraDetalle,
                .Descripcion = objeto.Descripcion,
                .Unidad = objeto.Unidad,
                .Cantidad = objeto.Cantidad,
                .Precio = objeto.Precio,
                .Importe = objeto.Importe,
                .AlicuotaIVA = objeto.AlicuotaIVA,
                .Remitado = objeto.Remitado,
                .Eliminado = objeto.Eliminado,
                .AscArticulos = Articulos(objeto.AscArticulos),
                .AscFacturaCompra = FacturaCompra(objeto.AscFacturaCompra)
            }
    End Function

    Public Shared Function FacturaCompraDetalle(lista As List(Of ModeloFacturaCompraDetalle)) As List(Of FacturaCompraDetalle)
        Dim listaTransformada As New List(Of FacturaCompraDetalle)

        For Each item In lista
            listaTransformada.Add(FacturaCompraDetalle(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function FacturaCompraDetalle(lista As List(Of FacturaCompraDetalle)) As List(Of ModeloFacturaCompraDetalle)
        Dim listaTransformada As New List(Of ModeloFacturaCompraDetalle)

        For Each item In lista
            listaTransformada.Add(FacturaCompraDetalle(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "FACTURA COMPRA MOVIMIENTOS"
    Public Shared Function FacturaCompraMovimientos(objeto As FacturaCompraMovimientos) As ModeloFacturaCompraMovimientos
        Return New ModeloFacturaCompraMovimientos With {
                .IdFacturaCompraMovimientos = objeto.IdFacturaCompraMovimientos,
                .Tipo = objeto.Tipo,
                .Cantidad = objeto.Cantidad,
                .Fecha = objeto.Fecha,
                .Eliminado = objeto.Eliminado,
                .AscUsuarios = Usuario(objeto.AscUsuarios),
                .AscFacturaCompraDetalle = FacturaCompraDetalle(objeto.AscFacturaCompraDetalle)
            }
    End Function

    Public Shared Function FacturaCompraMovimientos(objeto As ModeloFacturaCompraMovimientos) As FacturaCompraMovimientos
        Return New FacturaCompraMovimientos With {
                .IdFacturaCompraMovimientos = objeto.IdFacturaCompraMovimientos,
                .Tipo = objeto.Tipo,
                .Cantidad = objeto.Cantidad,
                .Fecha = objeto.Fecha,
                .Eliminado = objeto.Eliminado,
                .AscUsuarios = Usuario(objeto.AscUsuarios),
                .AscFacturaCompraDetalle = FacturaCompraDetalle(objeto.AscFacturaCompraDetalle)
            }
    End Function

    Public Shared Function FacturaCompraMovimientos(lista As List(Of ModeloFacturaCompraMovimientos)) As List(Of FacturaCompraMovimientos)
        Dim listaTransformada As New List(Of FacturaCompraMovimientos)

        For Each item In lista
            listaTransformada.Add(FacturaCompraMovimientos(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function FacturaCompraMovimientos(lista As List(Of FacturaCompraMovimientos)) As List(Of ModeloFacturaCompraMovimientos)
        Dim listaTransformada As New List(Of ModeloFacturaCompraMovimientos)

        For Each item In lista
            listaTransformada.Add(FacturaCompraMovimientos(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "FACTURA VENTA"
    Public Shared Function FacturaVenta(objeto As FacturaVenta) As ModeloFacturaVenta
        Return New ModeloFacturaVenta With {
                .IdFacturaVenta = objeto.IdFacturaVenta,
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
                .AscUsuarios = Usuario(objeto.AscUsuarios),
                .AscClientes = Clientes(objeto.AscClientes),
                .AscCtaCteVenta = CuentaCorrienteVenta(objeto.AscCtaCteVenta)
            }
    End Function

    Public Shared Function FacturaVenta(objeto As ModeloFacturaVenta) As FacturaVenta
        Return New FacturaVenta With {
                .IdFacturaVenta = objeto.IdFacturaVenta,
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
                .AscUsuarios = Usuario(objeto.AscUsuarios),
                .AscClientes = Clientes(objeto.AscClientes),
                .AscCtaCteVenta = CuentaCorrienteVenta(objeto.AscCtaCteVenta)
            }
    End Function

    Public Shared Function FacturaVenta(lista As List(Of ModeloFacturaVenta)) As List(Of FacturaVenta)
        Dim listaTransformada As New List(Of FacturaVenta)

        For Each item In lista
            listaTransformada.Add(FacturaVenta(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function FacturaVenta(lista As List(Of FacturaVenta)) As List(Of ModeloFacturaVenta)
        Dim listaTransformada As New List(Of ModeloFacturaVenta)

        For Each item In lista
            listaTransformada.Add(FacturaVenta(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "FACTURA VENTA DETALLE"
    Public Shared Function FacturaVentaDetalle(objeto As FacturaVentaDetalle) As ModeloFacturaVentaDetalle
        Return New ModeloFacturaVentaDetalle With {
                .IdFacturaVentaDetalle = objeto.IdFacturaVentaDetalle,
                .Descripcion = objeto.Descripcion,
                .Unidad = objeto.Unidad,
                .Cantidad = objeto.Cantidad,
                .Precio = objeto.Precio,
                .Importe = objeto.Importe,
                .AlicuotaIVA = objeto.AlicuotaIVA,
                .Remitado = objeto.Remitado,
                .Eliminado = objeto.Eliminado,
                .AscArticulos = Articulos(objeto.AscArticulos),
                .AscFacturaVenta = FacturaVenta(objeto.AscFacturaVenta)
            }
    End Function

    Public Shared Function FacturaVentaDetalle(objeto As ModeloFacturaVentaDetalle) As FacturaVentaDetalle
        Return New FacturaVentaDetalle With {
                .IdFacturaVentaDetalle = objeto.IdFacturaVentaDetalle,
                .Descripcion = objeto.Descripcion,
                .Unidad = objeto.Unidad,
                .Cantidad = objeto.Cantidad,
                .Precio = objeto.Precio,
                .Importe = objeto.Importe,
                .AlicuotaIVA = objeto.AlicuotaIVA,
                .Remitado = objeto.Remitado,
                .Eliminado = objeto.Eliminado,
                .AscArticulos = Articulos(objeto.AscArticulos),
                .AscFacturaVenta = FacturaVenta(objeto.AscFacturaVenta)
            }
    End Function

    Public Shared Function FacturaVentaDetalle(lista As List(Of ModeloFacturaVentaDetalle)) As List(Of FacturaVentaDetalle)
        Dim listaTransformada As New List(Of FacturaVentaDetalle)

        For Each item In lista
            listaTransformada.Add(FacturaVentaDetalle(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function FacturaVentaDetalle(lista As List(Of FacturaVentaDetalle)) As List(Of ModeloFacturaVentaDetalle)
        Dim listaTransformada As New List(Of ModeloFacturaVentaDetalle)

        For Each item In lista
            listaTransformada.Add(FacturaVentaDetalle(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "FACTURA VENTA MOVIMIENTOS"
    Public Shared Function FacturaVentaMovimientos(objeto As FacturaVentaMovimientos) As ModeloFacturaVentaMovimientos
        Return New ModeloFacturaVentaMovimientos With {
                .IdFacturaVentaMovimientos = objeto.IdFacturaVentaMovimientos,
                .Tipo = objeto.Tipo,
                .Cantidad = objeto.Cantidad,
                .Fecha = objeto.Fecha,
                .Eliminado = objeto.Eliminado,
                .AscUsuarios = Usuario(objeto.AscUsuarios),
                .AscFacturaVentaDetalle = FacturaVentaDetalle(objeto.AscFacturaVentaDetalle)
            }
    End Function

    Public Shared Function FacturaVentaMovimientos(objeto As ModeloFacturaVentaMovimientos) As FacturaVentaMovimientos
        Return New FacturaVentaMovimientos With {
                .IdFacturaVentaMovimientos = objeto.IdFacturaVentaMovimientos,
                .Tipo = objeto.Tipo,
                .Cantidad = objeto.Cantidad,
                .Fecha = objeto.Fecha,
                .Eliminado = objeto.Eliminado,
                .AscUsuarios = Usuario(objeto.AscUsuarios),
                .AscFacturaVentaDetalle = FacturaVentaDetalle(objeto.AscFacturaVentaDetalle)
            }
    End Function

    Public Shared Function FacturaVentaMovimientos(lista As List(Of ModeloFacturaVentaMovimientos)) As List(Of FacturaVentaMovimientos)
        Dim listaTransformada As New List(Of FacturaVentaMovimientos)

        For Each item In lista
            listaTransformada.Add(FacturaVentaMovimientos(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function FacturaVentaMovimientos(lista As List(Of FacturaVentaMovimientos)) As List(Of ModeloFacturaVentaMovimientos)
        Dim listaTransformada As New List(Of ModeloFacturaVentaMovimientos)

        For Each item In lista
            listaTransformada.Add(FacturaVentaMovimientos(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "FACTURA VENTA MONEDAS"
    Public Shared Function FacturaVentaMonedas(objeto As FacturaVentaMonedas) As ModeloFacturaVentaMonedas
        Return New ModeloFacturaVentaMonedas With {
                .IdFacturaVtaMonedas = objeto.IdFacturaVtaMonedas,
                .TipoCambio = objeto.TipoCambio,
                .ImporteNeto = objeto.ImporteNeto,
                .DescuentoGral = objeto.DescuentoGral,
                .BaseImponible = objeto.BaseImponible,
                .IVA = objeto.IVA,
                .ImporteTotal = objeto.ImporteTotal,
                .Eliminado = objeto.Eliminado,
                .AscFacturaVenta = FacturaVenta(objeto.AscFacturaVenta)
            }
    End Function

    Public Shared Function FacturaVentaMonedas(objeto As ModeloFacturaVentaMonedas) As FacturaVentaMonedas
        Return New FacturaVentaMonedas With {
                .IdFacturaVtaMonedas = objeto.IdFacturaVtaMonedas,
                .TipoCambio = objeto.TipoCambio,
                .ImporteNeto = objeto.ImporteNeto,
                .DescuentoGral = objeto.DescuentoGral,
                .BaseImponible = objeto.BaseImponible,
                .IVA = objeto.IVA,
                .ImporteTotal = objeto.ImporteTotal,
                .Eliminado = objeto.Eliminado,
                .AscFacturaVenta = FacturaVenta(objeto.AscFacturaVenta)
            }
    End Function

    Public Shared Function FacturaVentaMonedas(lista As List(Of ModeloFacturaVentaMonedas)) As List(Of FacturaVentaMonedas)
        Dim listaTransformada As New List(Of FacturaVentaMonedas)

        For Each item In lista
            listaTransformada.Add(FacturaVentaMonedas(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function FacturaVentaMonedas(lista As List(Of FacturaVentaMonedas)) As List(Of ModeloFacturaVentaMonedas)
        Dim listaTransformada As New List(Of ModeloFacturaVentaMonedas)

        For Each item In lista
            listaTransformada.Add(FacturaVentaMonedas(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "MONEDAS"
    Public Shared Function Monedas(objeto As Monedas) As ModeloMonedas
        Return New ModeloMonedas With {
                .IdMonedas = objeto.IdMonedas,
                .Tipo = objeto.Tipo,
                .Moneda = objeto.Moneda,
                .Simbolo = objeto.Simbolo,
                .Eliminado = objeto.Eliminado
            }
    End Function

    Public Shared Function Monedas(objeto As ModeloMonedas) As Monedas
        Return New Monedas With {
                .IdMonedas = objeto.IdMonedas,
                .Tipo = objeto.Tipo,
                .Moneda = objeto.Moneda,
                .Simbolo = objeto.Simbolo,
                .Eliminado = objeto.Eliminado
            }
    End Function

    Public Shared Function Monedas(lista As List(Of ModeloMonedas)) As List(Of Monedas)
        Dim listaTransformada As New List(Of Monedas)

        For Each item In lista
            listaTransformada.Add(Monedas(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function Monedas(lista As List(Of Monedas)) As List(Of ModeloMonedas)
        Dim listaTransformada As New List(Of ModeloMonedas)

        For Each item In lista
            listaTransformada.Add(Monedas(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "MOVIMIENTOS_FACTURA_RESERVA"
    Public Shared Function Movimientos_Factura_Reserva(objeto As Movimientos_Factura_Reserva) As ModeloMovimientos_Factura_Reserva
        Return New ModeloMovimientos_Factura_Reserva With {
                .IdMovimientos_Factura_Reseva = objeto.IdMovimientos_Factura_Reseva,
                .Tipo = objeto.Tipo,
                .Cantidad = objeto.Cantidad,
                .Fecha = objeto.Fecha,
                .Eliminado = objeto.Eliminado,
                .AscFacturaVentaMovimientos = FacturaVentaMovimientos(objeto.AscFacturaVentaMovimientos),
                .AscPedidoMovimientos = PedidosMovimientos(objeto.AscPedidoMovimientos)
            }
    End Function

    Public Shared Function Movimientos_Factura_Reserva(objeto As ModeloMovimientos_Factura_Reserva) As Movimientos_Factura_Reserva
        Return New Movimientos_Factura_Reserva With {
                .IdMovimientos_Factura_Reseva = objeto.IdMovimientos_Factura_Reseva,
                .Tipo = objeto.Tipo,
                .Cantidad = objeto.Cantidad,
                .Fecha = objeto.Fecha,
                .Eliminado = objeto.Eliminado,
                .AscFacturaVentaMovimientos = FacturaVentaMovimientos(objeto.AscFacturaVentaMovimientos),
                .AscPedidoMovimientos = PedidosMovimientos(objeto.AscPedidoMovimientos)
            }
    End Function

    Public Shared Function Movimientos_Factura_Reserva(lista As List(Of ModeloMovimientos_Factura_Reserva)) As List(Of Movimientos_Factura_Reserva)
        Dim listaTransformada As New List(Of Movimientos_Factura_Reserva)

        For Each item In lista
            listaTransformada.Add(Movimientos_Factura_Reserva(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function Movimientos_Factura_Reserva(lista As List(Of Movimientos_Factura_Reserva)) As List(Of ModeloMovimientos_Factura_Reserva)
        Dim listaTransformada As New List(Of ModeloMovimientos_Factura_Reserva)

        For Each item In lista
            listaTransformada.Add(Movimientos_Factura_Reserva(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "MOVIMIENTOS_REMITO_FACTURA"
    Public Shared Function Movimientos_Remito_Factura(objeto As Movimientos_Remito_Factura) As ModeloMovimientos_Remito_Factura
        Return New ModeloMovimientos_Remito_Factura With {
                .IdMovimientos_Remito_Factura = objeto.IdMovimientos_Remito_Factura,
                .Tipo = objeto.Tipo,
                .Cantidad = objeto.Cantidad,
                .Fecha = objeto.Fecha,
                .Eliminado = objeto.Eliminado,
                .AscRemitosVentaMovimientos = RemitosVentaMovimientos(objeto.AscRemitosVentaMovimientos),
                .AscFacturaVentaMovimientos = FacturaVentaMovimientos(objeto.AscFacturaVentaMovimientos)
            }
    End Function

    Public Shared Function Movimientos_Remito_Factura(objeto As ModeloMovimientos_Remito_Factura) As Movimientos_Remito_Factura
        Return New Movimientos_Remito_Factura With {
                .IdMovimientos_Remito_Factura = objeto.IdMovimientos_Remito_Factura,
                .Tipo = objeto.Tipo,
                .Cantidad = objeto.Cantidad,
                .Fecha = objeto.Fecha,
                .Eliminado = objeto.Eliminado,
                .AscRemitosVentaMovimientos = RemitosVentaMovimientos(objeto.AscRemitosVentaMovimientos),
                .AscFacturaVentaMovimientos = FacturaVentaMovimientos(objeto.AscFacturaVentaMovimientos)
            }
    End Function

    Public Shared Function Movimientos_Remito_Factura(lista As List(Of ModeloMovimientos_Remito_Factura)) As List(Of Movimientos_Remito_Factura)
        Dim listaTransformada As New List(Of Movimientos_Remito_Factura)

        For Each item In lista
            listaTransformada.Add(Movimientos_Remito_Factura(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function Movimientos_Remito_Factura(lista As List(Of Movimientos_Remito_Factura)) As List(Of ModeloMovimientos_Remito_Factura)
        Dim listaTransformada As New List(Of ModeloMovimientos_Remito_Factura)

        For Each item In lista
            listaTransformada.Add(Movimientos_Remito_Factura(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "MOVIMIENTOS_REMITO COMPRA_FACTURA COMPRA"
    Public Shared Function Movimientos_RemitoCompra_FacturaCompra(objeto As Movimientos_RemitoCompra_FacturaCompra) As ModeloMovimientos_RemitoCompra_FacturaCompra
        Return New ModeloMovimientos_RemitoCompra_FacturaCompra With {
                .IdMovimientos_RemitoCompra_FacturaCompra = objeto.IdMovimientos_RemitoCompra_FacturaCompra,
                .Tipo = objeto.Tipo,
                .Cantidad = objeto.Cantidad,
                .Fecha = objeto.Fecha,
                .Eliminado = objeto.Eliminado,
                .AscRemitosCompraMovimientos = RemitosCompraMovimientos(objeto.AscRemitosCompraMovimientos),
                .AscFacturaCompraMovimientos = FacturaCompraMovimientos(objeto.AscFacturaCompraMovimientos)
            }
    End Function

    Public Shared Function Movimientos_RemitoCompra_FacturaCompra(objeto As ModeloMovimientos_RemitoCompra_FacturaCompra) As Movimientos_RemitoCompra_FacturaCompra
        Return New Movimientos_RemitoCompra_FacturaCompra With {
                .IdMovimientos_RemitoCompra_FacturaCompra = objeto.IdMovimientos_RemitoCompra_FacturaCompra,
                .Tipo = objeto.Tipo,
                .Cantidad = objeto.Cantidad,
                .Fecha = objeto.Fecha,
                .Eliminado = objeto.Eliminado,
                .AscRemitosCompraMovimientos = RemitosCompraMovimientos(objeto.AscRemitosCompraMovimientos),
                .AscFacturaCompraMovimientos = FacturaCompraMovimientos(objeto.AscFacturaCompraMovimientos)
            }
    End Function

    Public Shared Function Movimientos_RemitoCompra_FacturaCompra(lista As List(Of ModeloMovimientos_RemitoCompra_FacturaCompra)) As List(Of Movimientos_RemitoCompra_FacturaCompra)
        Dim listaTransformada As New List(Of Movimientos_RemitoCompra_FacturaCompra)

        For Each item In lista
            listaTransformada.Add(Movimientos_RemitoCompra_FacturaCompra(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function Movimientos_RemitoCompra_FacturaCompra(lista As List(Of Movimientos_RemitoCompra_FacturaCompra)) As List(Of ModeloMovimientos_RemitoCompra_FacturaCompra)
        Dim listaTransformada As New List(Of ModeloMovimientos_RemitoCompra_FacturaCompra)

        For Each item In lista
            listaTransformada.Add(Movimientos_RemitoCompra_FacturaCompra(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "MOVIMIENTOS_RESERVA_REMITO"
    Public Shared Function Movimientos_Reserva_Remito(objeto As Movimientos_Reserva_Remito) As ModeloMovimientos_Reserva_Remito
        Return New ModeloMovimientos_Reserva_Remito With {
                .IdMovimientos_Reserva_Remito = objeto.IdMovimientos_Reserva_Remito,
                .Tipo = objeto.Tipo,
                .Cantidad = objeto.Cantidad,
                .Fecha = objeto.Fecha,
                .Eliminado = objeto.Eliminado,
                .AscRemitosVentaMovimientos = RemitosVentaMovimientos(objeto.AscRemitosVentaMovimientos),
                .AscPedidosMovimientos = PedidosMovimientos(objeto.AscPedidoMovimientos)
            }
    End Function

    Public Shared Function Movimientos_Reserva_Remito(objeto As ModeloMovimientos_Reserva_Remito) As Movimientos_Reserva_Remito
        Return New Movimientos_Reserva_Remito With {
                .IdMovimientos_Reserva_Remito = objeto.IdMovimientos_Reserva_Remito,
                .Tipo = objeto.Tipo,
                .Cantidad = objeto.Cantidad,
                .Fecha = objeto.Fecha,
                .Eliminado = objeto.Eliminado,
                .AscRemitosVentaMovimientos = RemitosVentaMovimientos(objeto.AscRemitosVentaMovimientos),
                .AscPedidoMovimientos = PedidosMovimientos(objeto.AscPedidosMovimientos)
        }
    End Function

    Public Shared Function Movimientos_Reserva_Remito(lista As List(Of ModeloMovimientos_Reserva_Remito)) As List(Of Movimientos_Reserva_Remito)
        Dim listaTransformada As New List(Of Movimientos_Reserva_Remito)

        For Each item In lista
            listaTransformada.Add(Movimientos_Reserva_Remito(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function Movimientos_Reserva_Remito(lista As List(Of Movimientos_Reserva_Remito)) As List(Of ModeloMovimientos_Reserva_Remito)
        Dim listaTransformada As New List(Of ModeloMovimientos_Reserva_Remito)

        For Each item In lista
            listaTransformada.Add(Movimientos_Reserva_Remito(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "MOVIMIENTO VALORES"
    Public Shared Function MovimientoValores(objeto As MovimientoValores) As ModeloMovimientoValores
        Return New ModeloMovimientoValores With {
                .IdMovimientoValores = objeto.IdMovimientoValores,
                .Fecha = objeto.Fecha,
                .Movimiento = objeto.Movimiento,
                .OrigenDestino = objeto.OrigenDestino,
                .Eliminado = objeto.Eliminado,
                .AscCaja = Caja(objeto.AscCaja),
                .AscValoresEnCartera = ValoreEnCartera(objeto.AscValoresEnCartera)
            }
    End Function

    Public Shared Function MovimientoValores(objeto As ModeloMovimientoValores) As MovimientoValores
        Return New MovimientoValores With {
                .IdMovimientoValores = objeto.IdMovimientoValores,
                .Fecha = objeto.Fecha,
                .Movimiento = objeto.Movimiento,
                .OrigenDestino = objeto.OrigenDestino,
                .Eliminado = objeto.Eliminado,
                .AscCaja = Caja(objeto.AscCaja),
                .AscValoresEnCartera = ValoreEnCartera(objeto.AscValoresEnCartera)
            }
    End Function

    Public Shared Function MovimientoValores(lista As List(Of ModeloMovimientoValores)) As List(Of MovimientoValores)
        Dim listaTransformada As New List(Of MovimientoValores)

        For Each item In lista
            listaTransformada.Add(MovimientoValores(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function MovimientoValores(lista As List(Of MovimientoValores)) As List(Of ModeloMovimientoValores)
        Dim listaTransformada As New List(Of ModeloMovimientoValores)

        For Each item In lista
            listaTransformada.Add(MovimientoValores(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "NUMERACION"
    Public Shared Function Numeracion(objeto As Numeracion) As ModeloNumeracion
        Return New ModeloNumeracion With {
                .IdNumeracion = objeto.IdNumeracion,
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
                .AscUsuarios = Usuario(objeto.AscUsuarios)
            }
    End Function

    Public Shared Function Numeracion(objeto As ModeloNumeracion) As Numeracion
        Return New Numeracion With {
                .IdNumeracion = objeto.IdNumeracion,
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
                .AscUsuarios = Usuario(objeto.AscUsuarios)
            }
    End Function

    Public Shared Function Numeracion(lista As List(Of ModeloNumeracion)) As List(Of Numeracion)
        Dim listaTransformada As New List(Of Numeracion)

        For Each item In lista
            listaTransformada.Add(Numeracion(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function Numeracion(lista As List(Of Numeracion)) As List(Of ModeloNumeracion)
        Dim listaTransformada As New List(Of ModeloNumeracion)

        For Each item In lista
            listaTransformada.Add(Numeracion(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "ORDEN DE PAGO"
    Public Shared Function OrdenDePago(objeto As OrdenDePago) As ModeloOrdenDePago
        Return New ModeloOrdenDePago With {
                .IdOrdenDePago = objeto.IdOrdenDePago,
                .NroComprobante = objeto.NroComprobante,
                .Fecha = objeto.Fecha,
                .ImportePesos = objeto.ImportePesos,
                .ImporteDolares = objeto.ImporteDolares,
                .Observaciones = objeto.Observaciones,
                .Eliminado = objeto.Eliminado,
                .AscUsuarios = Usuario(objeto.AscUsuarios),
                .AscProveedores = Proveedores(objeto.AscProveedores),
                .AscCuentaCorrienteCompra = CuentaCorrienteCompra(objeto.AscCuentaCorrienteCompra)
            }
    End Function

    Public Shared Function OrdenDePago(objeto As ModeloOrdenDePago) As OrdenDePago
        Return New OrdenDePago With {
                .IdOrdenDePago = objeto.IdOrdenDePago,
                .NroComprobante = objeto.NroComprobante,
                .Fecha = objeto.Fecha,
                .ImportePesos = objeto.ImportePesos,
                .ImporteDolares = objeto.ImporteDolares,
                .Observaciones = objeto.Observaciones,
                .Eliminado = objeto.Eliminado,
                .AscUsuarios = Usuario(objeto.AscUsuarios),
                .AscProveedores = Proveedores(objeto.AscProveedores),
                .AscCuentaCorrienteCompra = CuentaCorrienteCompra(objeto.AscCuentaCorrienteCompra)
            }
    End Function

    Public Shared Function OrdenDePago(lista As List(Of ModeloOrdenDePago)) As List(Of OrdenDePago)
        Dim listaTransformada As New List(Of OrdenDePago)

        For Each item In lista
            listaTransformada.Add(OrdenDePago(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function OrdenDePago(lista As List(Of OrdenDePago)) As List(Of ModeloOrdenDePago)
        Dim listaTransformada As New List(Of ModeloOrdenDePago)

        For Each item In lista
            listaTransformada.Add(OrdenDePago(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "ORDEN DE PAGO MONEDAS"
    Public Shared Function OrdenDePagoMonedas(objeto As OrdenDePagoMonedas) As ModeloOrdenDePagoMonedas
        Return New ModeloOrdenDePagoMonedas With {
                .IdOrdenDePagoMonedas = objeto.IdOrdenDePagoMonedas,
                .TipoCambio = objeto.TipoCambio,
                .ImporteNeto = objeto.ImporteNeto,
                .DescuentoGral = objeto.DescuentoGral,
                .BaseImponible = objeto.BaseImponible,
                .IVA = objeto.IVA,
                .ImporteTotal = objeto.ImporteTotal,
                .Eliminado = objeto.Eliminado,
                .AscOrdenDePago = OrdenDePago(objeto.AscOrdenDePago)
            }
    End Function

    Public Shared Function OrdenDePagoMonedas(objeto As ModeloOrdenDePagoMonedas) As OrdenDePagoMonedas
        Return New OrdenDePagoMonedas With {
                .IdOrdenDePagoMonedas = objeto.IdOrdenDePagoMonedas,
                .TipoCambio = objeto.TipoCambio,
                .ImporteNeto = objeto.ImporteNeto,
                .DescuentoGral = objeto.DescuentoGral,
                .BaseImponible = objeto.BaseImponible,
                .IVA = objeto.IVA,
                .ImporteTotal = objeto.ImporteTotal,
                .Eliminado = objeto.Eliminado,
                .AscOrdenDePago = OrdenDePago(objeto.AscOrdenDePago)
            }
    End Function

    Public Shared Function OrdenDePagoMonedas(lista As List(Of ModeloOrdenDePagoMonedas)) As List(Of OrdenDePagoMonedas)
        Dim listaTransformada As New List(Of OrdenDePagoMonedas)

        For Each item In lista
            listaTransformada.Add(OrdenDePagoMonedas(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function OrdenDePagoMonedas(lista As List(Of OrdenDePagoMonedas)) As List(Of ModeloOrdenDePagoMonedas)
        Dim listaTransformada As New List(Of ModeloOrdenDePagoMonedas)

        For Each item In lista
            listaTransformada.Add(OrdenDePagoMonedas(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "ORDEN DE PAGO DETALLE"
    Public Shared Function OrdenDePagoDetalle(objeto As OrdenDePagoDetalle) As ModeloOrdenDePagoDetalle
        Return New ModeloOrdenDePagoDetalle With {
                .IdOrdenPagoDetalle = objeto.IdOrdenPagoDetalle,
                .MedioPago = objeto.MedioPago,
                .NroComprobante = objeto.NroComprobante,
                .EntidadEmisora = objeto.EntidadEmisora,
                .SucursalEntidad = objeto.SucursalEntidad,
                .Librador = objeto.Librador,
                .FechaCobro = objeto.FechaCobro,
                .Moneda = objeto.Moneda,
                .Importe = objeto.Importe,
                .Eliminado = objeto.Eliminado,
                .AscOrdenDePago = OrdenDePago(objeto.AscOrdenDePago)
            }
    End Function

    Public Shared Function OrdenDePagoDetalle(objeto As ModeloOrdenDePagoDetalle) As OrdenDePagoDetalle
        Return New OrdenDePagoDetalle With {
                .IdOrdenPagoDetalle = objeto.IdOrdenPagoDetalle,
                .MedioPago = objeto.MedioPago,
                .NroComprobante = objeto.NroComprobante,
                .EntidadEmisora = objeto.EntidadEmisora,
                .SucursalEntidad = objeto.SucursalEntidad,
                .Librador = objeto.Librador,
                .FechaCobro = objeto.FechaCobro,
                .Moneda = objeto.Moneda,
                .Importe = objeto.Importe,
                .Eliminado = objeto.Eliminado,
                .AscOrdenDePago = OrdenDePago(objeto.AscOrdenDePago)
            }
    End Function

    Public Shared Function OrdenDePagoDetalle(lista As List(Of ModeloOrdenDePagoDetalle)) As List(Of OrdenDePagoDetalle)
        Dim listaTransformada As New List(Of OrdenDePagoDetalle)

        For Each item In lista
            listaTransformada.Add(OrdenDePagoDetalle(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function OrdenDePagoDetalle(lista As List(Of OrdenDePagoDetalle)) As List(Of ModeloOrdenDePagoDetalle)
        Dim listaTransformada As New List(Of ModeloOrdenDePagoDetalle)

        For Each item In lista
            listaTransformada.Add(OrdenDePagoDetalle(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "PARIDAD CAMBIARIA"
    Public Shared Function ParidadCambiaria(objeto As ParidadCambiaria) As ModeloParidadCambiaria
        Return New ModeloParidadCambiaria With {
                .IdParidadCambiaria = objeto.IdParidadCambiaria,
                .Fecha = objeto.Fecha,
                .CotizacionCompra = objeto.CotizacionCompra,
                .CotizacionVenta = objeto.CotizacionVenta,
                .Eliminado = objeto.Eliminado,
                .AscMonedas = Monedas(objeto.AscMonedas)
            }
    End Function

    Public Shared Function ParidadCambiaria(objeto As ModeloParidadCambiaria) As ParidadCambiaria
        Return New ParidadCambiaria With {
                .IdParidadCambiaria = objeto.IdParidadCambiaria,
                .Fecha = objeto.Fecha,
                .CotizacionCompra = objeto.CotizacionCompra,
                .CotizacionVenta = objeto.CotizacionVenta,
                .Eliminado = objeto.Eliminado,
                .AscMonedas = Monedas(objeto.AscMonedas)
            }
    End Function

    Public Shared Function ParidadCambiaria(lista As List(Of ModeloParidadCambiaria)) As List(Of ParidadCambiaria)
        Dim listaTransformada As New List(Of ParidadCambiaria)

        For Each item In lista
            listaTransformada.Add(ParidadCambiaria(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function ParidadCambiaria(lista As List(Of ParidadCambiaria)) As List(Of ModeloParidadCambiaria)
        Dim listaTransformada As New List(Of ModeloParidadCambiaria)

        For Each item In lista
            listaTransformada.Add(ParidadCambiaria(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "PEDIDOS"
    Public Shared Function Reservas(objeto As Pedidos) As ModeloPedidos
        Return New ModeloPedidos With {
                .IdPedidos = objeto.IdPedidos,
                .NroPedido = objeto.NroPedido,
                .Fecha = objeto.Fecha,
                .FechaCierrePedido = objeto.FechaCierrePedido,
                .Remitado = objeto.Remitado,
                .Facturado = objeto.Facturado,
                .Observaciones = objeto.Observaciones,
                .Eliminado = objeto.Eliminado,
                .AscUsuarios = Usuario(objeto.AscUsuarios),
                .AscClientes = Clientes(objeto.AscClientes)
            }
    End Function

    Public Shared Function Reservas(objeto As ModeloPedidos) As Pedidos
        Return New Pedidos With {
                .IdPedidos = objeto.IdPedidos,
                .NroPedido = objeto.NroPedido,
                .Fecha = objeto.Fecha,
                .FechaCierrePedido = objeto.FechaCierrePedido,
                .Remitado = objeto.Remitado,
                .Facturado = objeto.Facturado,
                .Observaciones = objeto.Observaciones,
                .Eliminado = objeto.Eliminado,
                .AscUsuarios = Usuario(objeto.AscUsuarios),
                .AscClientes = Clientes(objeto.AscClientes)
            }
    End Function

    Public Shared Function Reservas(lista As List(Of ModeloPedidos)) As List(Of Pedidos)
        Dim listaTransformada As New List(Of Pedidos)

        For Each item In lista
            listaTransformada.Add(Reservas(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function Reservas(lista As List(Of Pedidos)) As List(Of ModeloPedidos)
        Dim listaTransformada As New List(Of ModeloPedidos)

        For Each item In lista
            listaTransformada.Add(Reservas(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "PEDIDOS DETALLES"
    Public Shared Function DetalleReservas(objeto As PedidosDetalle) As ModeloPedidoDetalle
        Return New ModeloPedidoDetalle With {
                .IdPedidosDetalle = objeto.IdPedidosDetalle,
                .Cantidad = objeto.Cantidad,
                .Remitado = objeto.Remitado,
                .Facturado = objeto.Facturado,
                .Eliminado = objeto.Eliminado,
                .AscArticulos = Articulos(objeto.AscArticulos),
                .AscPedidos = Reservas(objeto.AscPedidos)
            }
    End Function

    Public Shared Function DetalleReservas(objeto As ModeloPedidoDetalle) As PedidosDetalle
        Return New PedidosDetalle With {
                .IdPedidosDetalle = objeto.IdPedidosDetalle,
                .Cantidad = objeto.Cantidad,
                .Remitado = objeto.Remitado,
                .Facturado = objeto.Facturado,
                .Eliminado = objeto.Eliminado,
                .AscArticulos = Articulos(objeto.AscArticulos),
                .AscPedidos = Reservas(objeto.AscPedidos)
            }
    End Function

    Public Shared Function DetalleReservas(lista As List(Of ModeloPedidoDetalle)) As List(Of PedidosDetalle)
        Dim listaTransformada As New List(Of PedidosDetalle)

        For Each item In lista
            listaTransformada.Add(DetalleReservas(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function DetalleReservas(lista As List(Of PedidosDetalle)) As List(Of ModeloPedidoDetalle)
        Dim listaTransformada As New List(Of ModeloPedidoDetalle)

        For Each item In lista
            listaTransformada.Add(DetalleReservas(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "PEDIDOS MOVIMIENTOS"
    Public Shared Function PedidosMovimientos(objeto As PedidosMovimientos) As ModeloPedidoMovimientos
        Return New ModeloPedidoMovimientos With {
                .IdPedidosMovimientos = objeto.IdPedidosMovimientos,
                .Tipo = objeto.Tipo,
                .Cantidad = objeto.Cantidad,
                .Fecha = objeto.Fecha,
                .Eliminado = objeto.Eliminado,
                .AscUsuarios = Usuario(objeto.AscUsuarios),
                .AscPedidosDetalle = DetalleReservas(objeto.AscPedidosDetalle),
                .AscStock = Stock(objeto.AscStock)
            }
    End Function

    Public Shared Function PedidosMovimientos(objeto As ModeloPedidoMovimientos) As PedidosMovimientos
        Return New PedidosMovimientos With {
                .IdPedidosMovimientos = objeto.IdPedidosMovimientos,
                .Tipo = objeto.Tipo,
                .Cantidad = objeto.Cantidad,
                .Fecha = objeto.Fecha,
                .Eliminado = objeto.Eliminado,
                .AscUsuarios = Usuario(objeto.AscUsuarios),
                .AscPedidosDetalle = DetalleReservas(objeto.AscPedidosDetalle),
                .AscStock = Stock(objeto.AscStock)
            }
    End Function

    Public Shared Function PedidosMovimientos(lista As List(Of ModeloPedidoMovimientos)) As List(Of PedidosMovimientos)
        Dim listaTransformada As New List(Of PedidosMovimientos)

        For Each item In lista
            listaTransformada.Add(PedidosMovimientos(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function PedidosMovimientos(lista As List(Of PedidosMovimientos)) As List(Of ModeloPedidoMovimientos)
        Dim listaTransformada As New List(Of ModeloPedidoMovimientos)

        For Each item In lista
            listaTransformada.Add(PedidosMovimientos(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "PERFILES Usuario"
    Public Shared Function PerfilesUsuario(objeto As PerfilUsuario) As ModeloPerfilUsuario
        Return New ModeloPerfilUsuario With {
                .IdPerfil = objeto.IdPerfil,
                .NombrePerfil = objeto.NombrePerfil,
                .Accesos = objeto.Accesos,
                .Eliminado = objeto.Eliminado
            }
    End Function

    Public Shared Function PerfilesUsuario(objeto As ModeloPerfilUsuario) As PerfilUsuario
        Return New PerfilUsuario With {
                .IdPerfil = objeto.IdPerfil,
                .NombrePerfil = objeto.NombrePerfil,
                .Accesos = objeto.Accesos,
                .Eliminado = objeto.Eliminado
            }
    End Function

    Public Shared Function PerfilesUsuario(lista As List(Of ModeloPerfilUsuario)) As List(Of PerfilUsuario)
        Dim listaTransformada As New List(Of PerfilUsuario)

        For Each item In lista
            listaTransformada.Add(PerfilesUsuario(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function PerfilesUsuario(lista As List(Of PerfilUsuario)) As List(Of ModeloPerfilUsuario)
        Dim listaTransformada As New List(Of ModeloPerfilUsuario)

        For Each item In lista
            listaTransformada.Add(PerfilesUsuario(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "PROVEEDORES"
    Public Shared Function Proveedores(objeto As Proveedores) As ModeloProveedores
        Return New ModeloProveedores With {
                .IdProveedor = objeto.IdProveedor,
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
                .AscUsuarios = Usuario(objeto.AscUsuarios)
            }
    End Function

    Public Shared Function Proveedores(objeto As ModeloProveedores) As Proveedores
        Return New Proveedores With {
                .IdProveedor = objeto.IdProveedor,
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
                .AscUsuarios = Usuario(objeto.AscUsuarios)
            }
    End Function

    Public Shared Function Proveedores(lista As List(Of ModeloProveedores)) As List(Of Proveedores)
        Dim listaTransformada As New List(Of Proveedores)

        For Each item In lista
            listaTransformada.Add(Proveedores(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function Proveedores(lista As List(Of Proveedores)) As List(Of ModeloProveedores)
        Dim listaTransformada As New List(Of ModeloProveedores)

        For Each item In lista
            listaTransformada.Add(Proveedores(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "RECIBOS VENTA"
    Public Shared Function RecibosVenta(objeto As RecibosVenta) As ModeloRecibosVenta
        Return New ModeloRecibosVenta With {
                .IdRecibosVenta = objeto.IdRecibosVenta,
                .NroComprobante = objeto.NroComprobante,
                .Fecha = objeto.Fecha,
                .ImportePesos = objeto.ImportePesos,
                .ImporteDolares = objeto.ImporteDolares,
                .Observaciones = objeto.Observaciones,
                .Eliminado = objeto.Eliminado,
                .AscUsuarios = Usuario(objeto.AscUsuarios),
                .AscClientes = Clientes(objeto.AscClientes),
                .AscCuentaCorrienteVenta = CuentaCorrienteVenta(objeto.AscCuentaCorrienteVenta)
            }
    End Function

    Public Shared Function RecibosVenta(objeto As ModeloRecibosVenta) As RecibosVenta
        Return New RecibosVenta With {
                .IdRecibosVenta = objeto.IdRecibosVenta,
                .NroComprobante = objeto.NroComprobante,
                .Fecha = objeto.Fecha,
                .ImportePesos = objeto.ImportePesos,
                .ImporteDolares = objeto.ImporteDolares,
                .Observaciones = objeto.Observaciones,
                .Eliminado = objeto.Eliminado,
                .AscUsuarios = Usuario(objeto.AscUsuarios),
                .AscClientes = Clientes(objeto.AscClientes),
                .AscCuentaCorrienteVenta = CuentaCorrienteVenta(objeto.AscCuentaCorrienteVenta)
            }
    End Function

    Public Shared Function RecibosVenta(lista As List(Of ModeloRecibosVenta)) As List(Of RecibosVenta)
        Dim listaTransformada As New List(Of RecibosVenta)

        For Each item In lista
            listaTransformada.Add(RecibosVenta(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function RecibosVenta(lista As List(Of RecibosVenta)) As List(Of ModeloRecibosVenta)
        Dim listaTransformada As New List(Of ModeloRecibosVenta)

        For Each item In lista
            listaTransformada.Add(RecibosVenta(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "RECIBOS VENTA DETALLE"
    Public Shared Function RecibosVentaDetalle(objeto As RecibosVentaDetalle) As ModeloRecibosVentaDetalle
        Return New ModeloRecibosVentaDetalle With {
                .IdRecibosVentaDetalle = objeto.IdRecibosVentaDetalle,
                .MedioPago = objeto.MedioPago,
                .NroComprobante = objeto.NroComprobante,
                .EntidadEmisora = objeto.EntidadEmisora,
                .SucursalEntidad = objeto.SucursalEntidad,
                .Librador = objeto.Librador,
                .FechaCobro = objeto.FechaCobro,
                .Moneda = objeto.Moneda,
                .Importe = objeto.Importe,
                .Eliminado = objeto.Eliminado,
                .AscRecibosVenta = RecibosVenta(objeto.AscRecibosVenta)
            }
    End Function

    Public Shared Function RecibosVentaDetalle(objeto As ModeloRecibosVentaDetalle) As RecibosVentaDetalle
        Return New RecibosVentaDetalle With {
                .IdRecibosVentaDetalle = objeto.IdRecibosVentaDetalle,
                .MedioPago = objeto.MedioPago,
                .NroComprobante = objeto.NroComprobante,
                .EntidadEmisora = objeto.EntidadEmisora,
                .SucursalEntidad = objeto.SucursalEntidad,
                .Librador = objeto.Librador,
                .FechaCobro = objeto.FechaCobro,
                .Moneda = objeto.Moneda,
                .Importe = objeto.Importe,
                .Eliminado = objeto.Eliminado,
                .AscRecibosVenta = RecibosVenta(objeto.AscRecibosVenta)
            }
    End Function

    Public Shared Function RecibosVentaDetalle(lista As List(Of ModeloRecibosVentaDetalle)) As List(Of RecibosVentaDetalle)
        Dim listaTransformada As New List(Of RecibosVentaDetalle)

        For Each item In lista
            listaTransformada.Add(RecibosVentaDetalle(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function RecibosVentaDetalle(lista As List(Of RecibosVentaDetalle)) As List(Of ModeloRecibosVentaDetalle)
        Dim listaTransformada As New List(Of ModeloRecibosVentaDetalle)

        For Each item In lista
            listaTransformada.Add(RecibosVentaDetalle(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "RECIBOS VENTA MONEDAS"
    Public Shared Function RecibosVentaMonedas(objeto As RecibosVentaMonedas) As ModeloRecibosVentaMonedas
        Return New ModeloRecibosVentaMonedas With {
                .IdRecibosVentaMonedas = objeto.IdRecibosVentaMonedas,
                .TipoCambio = objeto.TipoCambio,
                .ImporteNeto = objeto.ImporteNeto,
                .DescuentoGral = objeto.DescuentoGral,
                .BaseImponible = objeto.BaseImponible,
                .IVA = objeto.IVA,
                .ImporteTotal = objeto.ImporteTotal,
                .Eliminado = objeto.Eliminado,
                .AscRecibosVenta = RecibosVenta(objeto.AscRecibosVenta)
            }
    End Function

    Public Shared Function RecibosVentaMonedas(objeto As ModeloRecibosVentaMonedas) As RecibosVentaMonedas
        Return New RecibosVentaMonedas With {
                .IdRecibosVentaMonedas = objeto.IdRecibosVentaMonedas,
                .TipoCambio = objeto.TipoCambio,
                .ImporteNeto = objeto.ImporteNeto,
                .DescuentoGral = objeto.DescuentoGral,
                .BaseImponible = objeto.BaseImponible,
                .IVA = objeto.IVA,
                .ImporteTotal = objeto.ImporteTotal,
                .Eliminado = objeto.Eliminado,
                .AscRecibosVenta = RecibosVenta(objeto.AscRecibosVenta)
            }
    End Function

    Public Shared Function RecibosVentaMonedas(lista As List(Of ModeloRecibosVentaMonedas)) As List(Of RecibosVentaMonedas)
        Dim listaTransformada As New List(Of RecibosVentaMonedas)

        For Each item In lista
            listaTransformada.Add(RecibosVentaMonedas(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function RecibosVentaMonedas(lista As List(Of RecibosVentaMonedas)) As List(Of ModeloRecibosVentaMonedas)
        Dim listaTransformada As New List(Of ModeloRecibosVentaMonedas)

        For Each item In lista
            listaTransformada.Add(RecibosVentaMonedas(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "REMITO COMPRA MONEDAS"
    Public Shared Function RemitoCompraMonedas(objeto As RemitoCompraMonedas) As ModeloRemitoComMonedas
        Return New ModeloRemitoComMonedas With {
                .IdRemitoComMonedas = objeto.IdRemitoComMonedas,
                .TipoCambio = objeto.TipoCambio,
                .ImporteNeto = objeto.ImporteNeto,
                .DescuentoGral = objeto.DescuentoGral,
                .BaseImponible = objeto.BaseImponible,
                .IVA = objeto.IVA,
                .ImporteTotal = objeto.ImporteTotal,
                .Eliminado = objeto.Eliminado,
                .AscRemitosCompra = RemitoCompra(objeto.AscRemitosCompra)
            }
    End Function

    Public Shared Function RemitoCompraMonedas(objeto As ModeloRemitoComMonedas) As RemitoCompraMonedas
        Return New RemitoCompraMonedas With {
                .IdRemitoComMonedas = objeto.IdRemitoComMonedas,
                .TipoCambio = objeto.TipoCambio,
                .ImporteNeto = objeto.ImporteNeto,
                .DescuentoGral = objeto.DescuentoGral,
                .BaseImponible = objeto.BaseImponible,
                .IVA = objeto.IVA,
                .ImporteTotal = objeto.ImporteTotal,
                .Eliminado = objeto.Eliminado,
                .AscRemitosCompra = RemitoCompra(objeto.AscRemitosCompra)
            }
    End Function

    Public Shared Function RemitoCompraMonedas(lista As List(Of ModeloRemitoComMonedas)) As List(Of RemitoCompraMonedas)
        Dim listaTransformada As New List(Of RemitoCompraMonedas)

        For Each item In lista
            listaTransformada.Add(RemitoCompraMonedas(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function RemitoCompraMonedas(lista As List(Of RemitoCompraMonedas)) As List(Of ModeloRemitoComMonedas)
        Dim listaTransformada As New List(Of ModeloRemitoComMonedas)

        For Each item In lista
            listaTransformada.Add(RemitoCompraMonedas(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "REMITO COMPRA"
    Public Shared Function RemitoCompra(objeto As RemitoCompra) As ModeloRemitosCompra
        Return New ModeloRemitosCompra With {
                .IdRemitosCompra = objeto.IdRemitosCompra,
                .NroComprobante = objeto.NroComprobante,
                .Fecha = objeto.Fecha,
                .Importe = objeto.Importe,
                .Observaciones = objeto.Observaciones,
                .ImpOriginal = objeto.ImpOriginal,
                .ImpCopia = objeto.ImpCopia,
                .Eliminado = objeto.Eliminado,
                .Facturado = objeto.Facturado,
                .AscProveedores = Proveedores(objeto.AscProveedores),
                .AscUsuarios = Usuario(objeto.AscUsuarios)
            }
    End Function

    Public Shared Function RemitoCompra(objeto As ModeloRemitosCompra) As RemitoCompra
        Return New RemitoCompra With {
                .IdRemitosCompra = objeto.IdRemitosCompra,
                .NroComprobante = objeto.NroComprobante,
                .Fecha = objeto.Fecha,
                .Importe = objeto.Importe,
                .Observaciones = objeto.Observaciones,
                .ImpOriginal = objeto.ImpOriginal,
                .ImpCopia = objeto.ImpCopia,
                .Eliminado = objeto.Eliminado,
                .Facturado = objeto.Facturado,
                .AscProveedores = Proveedores(objeto.AscProveedores),
                .AscUsuarios = Usuario(objeto.AscUsuarios)
            }
    End Function

    Public Shared Function RemitoCompra(lista As List(Of ModeloRemitosCompra)) As List(Of RemitoCompra)
        Dim listaTransformada As New List(Of RemitoCompra)

        For Each item In lista
            listaTransformada.Add(RemitoCompra(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function RemitoCompra(lista As List(Of RemitoCompra)) As List(Of ModeloRemitosCompra)
        Dim listaTransformada As New List(Of ModeloRemitosCompra)

        For Each item In lista
            listaTransformada.Add(RemitoCompra(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "REMITOS COMPRA MOVIMIENTOS"
    Public Shared Function RemitosCompraMovimientos(objeto As RemitoCompraMovimientos) As ModeloRemitosCompraMovimientos
        Return New ModeloRemitosCompraMovimientos With {
                .IdRemitosCompraMovimientos = objeto.IdRemitosCompraMovimientos,
                .Tipo = objeto.Tipo,
                .Cantidad = objeto.Cantidad,
                .Fecha = objeto.Fecha,
                .Eliminado = objeto.Eliminado,
                .AscUsuarios = Usuario(objeto.AscUsuarios),
                .AscDetalleRemtioCompra = DetalleRemitoCompra(objeto.AscDetalleRemtioCompra),
                .AscStock = Stock(objeto.AscStock)
            }
    End Function

    Public Shared Function RemitosCompraMovimientos(objeto As ModeloRemitosCompraMovimientos) As RemitoCompraMovimientos
        Return New RemitoCompraMovimientos With {
                .IdRemitosCompraMovimientos = objeto.IdRemitosCompraMovimientos,
                .Tipo = objeto.Tipo,
                .Cantidad = objeto.Cantidad,
                .Fecha = objeto.Fecha,
                .Eliminado = objeto.Eliminado,
                .AscUsuarios = Usuario(objeto.AscUsuarios),
                .AscDetalleRemtioCompra = DetalleRemitoCompra(objeto.AscDetalleRemtioCompra),
                .AscStock = Stock(objeto.AscStock)
            }
    End Function

    Public Shared Function RemitosCompraMovimientos(lista As List(Of ModeloRemitosCompraMovimientos)) As List(Of RemitoCompraMovimientos)
        Dim listaTransformada As New List(Of RemitoCompraMovimientos)

        For Each item In lista
            listaTransformada.Add(RemitosCompraMovimientos(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function RemitosCompraMovimientos(lista As List(Of RemitoCompraMovimientos)) As List(Of ModeloRemitosCompraMovimientos)
        Dim listaTransformada As New List(Of ModeloRemitosCompraMovimientos)

        For Each item In lista
            listaTransformada.Add(RemitosCompraMovimientos(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "REMITO VENTA"
    Public Shared Function RemitoVenta(objeto As RemitoVenta) As ModeloRemitosVenta
        Return New ModeloRemitosVenta With {
                .IdRemitosVenta = objeto.IdRemitosVenta,
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
                .AscClientes = Clientes(objeto.AscClientes),
                .AscUsuarios = Usuario(objeto.AscUsuarios)
            }
    End Function

    Public Shared Function RemitoVenta(objeto As ModeloRemitosVenta) As RemitoVenta
        Return New RemitoVenta With {
                .IdRemitosVenta = objeto.IdRemitosVenta,
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
                .AscClientes = Clientes(objeto.AscClientes),
                .AscUsuarios = Usuario(objeto.AscUsuarios)
            }
    End Function

    Public Shared Function RemitoVenta(lista As List(Of ModeloRemitosVenta)) As List(Of RemitoVenta)
        Dim listaTransformada As New List(Of RemitoVenta)

        For Each item In lista
            listaTransformada.Add(RemitoVenta(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function RemitoVenta(lista As List(Of RemitoVenta)) As List(Of ModeloRemitosVenta)
        Dim listaTransformada As New List(Of ModeloRemitosVenta)

        For Each item In lista
            listaTransformada.Add(RemitoVenta(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "REMITOS VENTA MOVIMIENTOS"
    Public Shared Function RemitosVentaMovimientos(objeto As RemitoVentaMovimientos) As ModeloRemitosVentaMovimientos
        Return New ModeloRemitosVentaMovimientos With {
                .idRemitosVentasMovimientos = objeto.IdRemitosVentasMovimientos,
                .Tipo = objeto.Tipo,
                .Cantidad = objeto.Cantidad,
                .Fecha = objeto.Fecha,
                .Eliminado = objeto.Eliminado,
                .AscUsuarios = Usuario(objeto.AscUsuarios),
                .AscDetalleRemitoVenta = DetalleRemitoVenta(objeto.AscDetalleRemitoVenta),
                .AscStock = Stock(objeto.AscStock)
            }
    End Function

    Public Shared Function RemitosVentaMovimientos(objeto As ModeloRemitosVentaMovimientos) As RemitoVentaMovimientos
        Return New RemitoVentaMovimientos With {
                .IdRemitosVentasMovimientos = objeto.idRemitosVentasMovimientos,
                .Tipo = objeto.Tipo,
                .Cantidad = objeto.Cantidad,
                .Fecha = objeto.Fecha,
                .Eliminado = objeto.Eliminado,
                .AscUsuarios = Usuario(objeto.AscUsuarios),
                .AscDetalleRemitoVenta = DetalleRemitoVenta(objeto.AscDetalleRemitoVenta),
                .AscStock = Stock(objeto.AscStock)
            }
    End Function

    Public Shared Function RemitosVentaMovimientos(lista As List(Of ModeloRemitosVentaMovimientos)) As List(Of RemitoVentaMovimientos)
        Dim listaTransformada As New List(Of RemitoVentaMovimientos)

        For Each item In lista
            listaTransformada.Add(RemitosVentaMovimientos(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function RemitosVentaMovimientos(lista As List(Of RemitoVentaMovimientos)) As List(Of ModeloRemitosVentaMovimientos)
        Dim listaTransformada As New List(Of ModeloRemitosVentaMovimientos)

        For Each item In lista
            listaTransformada.Add(RemitosVentaMovimientos(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "REMITO VENTA MONEDAS"
    Public Shared Function RemitoVentaMonedas(objeto As RemitoVentaMonedas) As ModeloRemitosVentaMonedas
        Return New ModeloRemitosVentaMonedas With {
                .IdRemitoVtaMonedas = objeto.IdRemitoVtaMonedas,
                .TipoCambio = objeto.TipoCambio,
                .ImporteNeto = objeto.ImporteNeto,
                .DescuentoGral = objeto.DescuentoGral,
                .BaseImponible = objeto.BaseImponible,
                .IVA = objeto.IVA,
                .ImporteTotal = objeto.ImporteTotal,
                .Eliminado = objeto.Eliminado,
                .AscRemitosventa = RemitoVenta(objeto.AscRemitosventa)
            }
    End Function

    Public Shared Function RemitoVentaMonedas(objeto As ModeloRemitosVentaMonedas) As RemitoVentaMonedas
        Return New RemitoVentaMonedas With {
                .IdRemitoVtaMonedas = objeto.IdRemitoVtaMonedas,
                .TipoCambio = objeto.TipoCambio,
                .ImporteNeto = objeto.ImporteNeto,
                .DescuentoGral = objeto.DescuentoGral,
                .BaseImponible = objeto.BaseImponible,
                .IVA = objeto.IVA,
                .ImporteTotal = objeto.ImporteTotal,
                .Eliminado = objeto.Eliminado,
                .AscRemitosventa = RemitoVenta(objeto.AscRemitosventa)
            }
    End Function

    Public Shared Function RemitoVentaMonedas(lista As List(Of ModeloRemitosVentaMonedas)) As List(Of RemitoVentaMonedas)
        Dim listaTransformada As New List(Of RemitoVentaMonedas)

        For Each item In lista
            listaTransformada.Add(RemitoVentaMonedas(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function RemitoVentaMonedas(lista As List(Of RemitoVentaMonedas)) As List(Of ModeloRemitosVentaMonedas)
        Dim listaTransformada As New List(Of ModeloRemitosVentaMonedas)

        For Each item In lista
            listaTransformada.Add(RemitoVentaMonedas(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "RUBROS"
    Public Shared Function Rubros(objeto As Rubros) As ModeloRubro
        Return New ModeloRubro With {
                .IdRubro = objeto.IdRubro,
                .Abrebiatura = objeto.Abrebiatura,
                .Descripcion = objeto.Descripcion,
                .Eliminado = objeto.Eliminado,
                .AscUsuarios = Usuario(objeto.AscUsuarios)
            }
    End Function
    Public Shared Function Rubros(objeto As ModeloRubro) As Rubros
        Return New Rubros With {
                .IdRubro = objeto.IdRubro,
                .Abrebiatura = objeto.Abrebiatura,
                .Descripcion = objeto.Descripcion,
                .Eliminado = objeto.Eliminado,
                .AscUsuarios = Usuario(objeto.AscUsuarios)
            }
    End Function

    Public Shared Function Rubros(lista As List(Of ModeloRubro)) As List(Of Rubros)
        Dim listaTransformada As New List(Of Rubros)

        For Each item In lista
            listaTransformada.Add(Rubros(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function Rubros(lista As List(Of Rubros)) As List(Of ModeloRubro)
        Dim listaTransformada As New List(Of ModeloRubro)

        For Each item In lista
            listaTransformada.Add(Rubros(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "STOCK"
    Public Shared Function Stock(objeto As Stock) As ModeloStock
        Return New ModeloStock With {
                .IdStock = objeto.IdStock,
                .Fecha = objeto.Fecha,
                .Movimiento = objeto.Movimiento,
                .Cantidad = objeto.Cantidad,
                .Eliminado = objeto.Eliminado,
                .AscArticulos = Articulos(objeto.AscArticulos),
                .AscDepositos = Depositos(objeto.AscDepositos),
                .AscUsuarios = Usuario(objeto.AscUsuarios)
            }
    End Function

    Public Shared Function Stock(objeto As ModeloStock) As Stock
        Return New Stock With {
                .IdStock = objeto.IdStock,
                .Fecha = objeto.Fecha,
                .Movimiento = objeto.Movimiento,
                .Cantidad = objeto.Cantidad,
                .Eliminado = objeto.Eliminado,
                .AscArticulos = Articulos(objeto.AscArticulos),
                .AscDepositos = Depositos(objeto.AscDepositos),
                .AscUsuarios = Usuario(objeto.AscUsuarios)
            }
    End Function

    Public Shared Function Stock(lista As List(Of ModeloStock)) As List(Of Stock)
        Dim listaTransformada As New List(Of Stock)

        For Each item In lista
            listaTransformada.Add(Stock(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function Stock(lista As List(Of Stock)) As List(Of ModeloStock)
        Dim listaTransformada As New List(Of ModeloStock)

        For Each item In lista
            listaTransformada.Add(Stock(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "SUB RUBROS"
    Public Shared Function SubRubros(objeto As SubRubros) As ModeloSubRubro
        Return New ModeloSubRubro With {
                .IdSubRubro = objeto.IdSubRubro,
                .Abrebiatura = objeto.Abrebiatura,
                .Descripcion = objeto.Descripcion,
                .Eliminado = objeto.Eliminado,
                .AscRubro = Rubros(objeto.AscRubro),
                .AscUsuarios = Usuario(objeto.AscUsuarios)
            }
    End Function
    Public Shared Function SubRubros(objeto As ModeloSubRubro) As SubRubros
        Return New SubRubros With {
                .IdSubRubro = objeto.IdSubRubro,
                .Abrebiatura = objeto.Abrebiatura,
                .Descripcion = objeto.Descripcion,
                .Eliminado = objeto.Eliminado,
                .AscRubro = Rubros(objeto.AscRubro),
                .AscUsuarios = Usuario(objeto.AscUsuarios)
            }
    End Function

    Public Shared Function SubRubros(lista As List(Of ModeloSubRubro)) As List(Of SubRubros)
        Dim listaTransformada As New List(Of SubRubros)

        For Each item In lista
            listaTransformada.Add(SubRubros(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function SubRubros(lista As List(Of SubRubros)) As List(Of ModeloSubRubro)
        Dim listaTransformada As New List(Of ModeloSubRubro)

        For Each item In lista
            listaTransformada.Add(SubRubros(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "Usuario"
    Public Shared Function Usuario(objeto As Usuario) As ModeloUsuario
        Return New ModeloUsuario With {
                .IdUsuarios = objeto.IdUsuario,
                .FechaAlta = objeto.FechaAlta,
                .Nombre = objeto.Nombre,
                .Tipo = objeto.Tipo,
                .Contraseña = objeto.Contraseña,
                .Imagen = objeto.Imagen,
                .Estado = objeto.Estado,
                .Token = objeto.Token,
                .Eliminado = objeto.Eliminado,
                .AscPerfilUs = PerfilesUsuario(objeto.AscPerfilUs)
            }
    End Function

    Public Shared Function Usuario(objeto As ModeloUsuario) As Usuario
        Return New Usuario With {
                .IdUsuario = objeto.IdUsuarios,
                .FechaAlta = objeto.FechaAlta,
                .Nombre = objeto.Nombre,
                .Tipo = objeto.Tipo,
                .Contraseña = objeto.Contraseña,
                .Imagen = objeto.Imagen,
                .Estado = objeto.Estado,
                .Token = objeto.Token,
                .Eliminado = objeto.Eliminado,
                .AscPerfilUs = PerfilesUsuario(objeto.AscPerfilUs)
            }
    End Function

    Public Shared Function Usuario(lista As List(Of ModeloUsuario)) As List(Of Usuario)
        Dim listaTransformada As New List(Of Usuario)

        For Each item In lista
            listaTransformada.Add(Usuario(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function Usuario(lista As List(Of Usuario)) As List(Of ModeloUsuario)
        Dim listaTransformada As New List(Of ModeloUsuario)

        For Each item In lista
            listaTransformada.Add(Usuario(item))
        Next

        Return listaTransformada
    End Function
#End Region

#Region "VALORES EN CARTERA"
    Public Shared Function ValoreEnCartera(objeto As ValoresEnCartera) As ModeloValoresEnCartera
        Return New ModeloValoresEnCartera With {
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
                .ascUsuarios = Usuario(objeto.AscUsuarios)
            }
    End Function

    Public Shared Function ValoreEnCartera(objeto As ModeloValoresEnCartera) As ValoresEnCartera
        Return New ValoresEnCartera With {
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
                .AscUsuarios = Usuario(objeto.ascUsuarios)
            }
    End Function

    Public Shared Function ValoreEnCartera(lista As List(Of ModeloValoresEnCartera)) As List(Of ValoresEnCartera)
        Dim listaTransformada As New List(Of ValoresEnCartera)

        For Each item In lista
            listaTransformada.Add(ValoreEnCartera(item))
        Next

        Return listaTransformada
    End Function

    Public Shared Function ValoreEnCartera(lista As List(Of ValoresEnCartera)) As List(Of ModeloValoresEnCartera)
        Dim listaTransformada As New List(Of ModeloValoresEnCartera)

        For Each item In lista
            listaTransformada.Add(ValoreEnCartera(item))
        Next

        Return listaTransformada
    End Function
#End Region

End Class
