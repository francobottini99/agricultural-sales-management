Public Class Peticiones
    'ABREVIACIONES ----------------------------------------------------------------------------------------------
    Public Const ABREVIACIONES_EXISTE = "Abreviaciones/Existe"

    'ARTICULOS ----------------------------------------------------------------------------------------------
    Public Const ARTICULOS_ACTUALIZAR_PRECIO = "Articulos/ActualizarPrecio"
    Public Const ARTICULOS_ACTUALIZAR_COSTO = "Articulos/ActualizarCosto"
    Public Const ARTICULOS_INSERTAR = "Articulos/Insertar"
    Public Const ARTICULOS_ULTIMO_ID = "Articulos/UltimoID"
    Public Const ARTICULOS_TODOS_SIN_IMAGENES = "Articulos/Todos_SinImagenes"
    Public Const ARTICULOS_ELIMINAR = "Articulos/Eliminar"
    Public Const ARTICULOS_CONSULTAR_IMAGEN = "Articulos/ConsultarImagen"
    Public Const ARTICULOS_FILTRAR_ID = "Articulos/Filtrar_idArticulo"
    Public Const ARTICULOS_MODIFICAR = "Articulos/Modificar"
    Public Const ARTICULOS_SERVICIO_INSERTAR = "Articulos/ServicioInsertar"
    Public Const ARTICULOS_SERVICIO_MODIFICAR = "Articulos/ServicioModificar"
    Public Const ARTICULOS_ACTUALIZAR_COSTOS = "Articulos/ArticulosActulizarCostos"

    'BANCOS ----------------------------------------------------------------------------------------------
    Public Const BANCOS_TODOS = "Bancos/Todos"
    Public Const BANCOS_INSERTAR = "Bancos/Insertar"
    Public Const BANCOS_EXISTE = "Bancos/Existe"
    Public Const BANCOS_ELIMINAR = "Bancos/Eliminar"
    Public Const BANCOS_MODIFICAR = "Bancos/Modificar"
    Public Const BANCOS_SERVICIO_INSERTAR = "Bancos/ServicioInsertar"
    Public Const BANCOS_SERVICIO_MODIFICAR = "Bancos/ServicioModificar"

    'CAJA ----------------------------------------------------------------------------------------------
    Public Const CAJA_TODOS = "Caja/Todos"
    Public Const CAJA_INSERTAR = "Caja/Insertar"
    Public Const CAJA_ELIMINAR = "Caja/Eliminar"
    Public Const CAJA_MODIFICAR = "Caja/Modificar"
    Public Const CAJA_LISTADO_POR_FECHAS = "Caja/ListadoPorFechas"
    Public Const CAJA_SALDO_PESOS = "Caja/SaldoPesos"
    Public Const CAJA_SALDO_DOLARES = "Caja/SaldoDolares"
    Public Const CAJA_MAX_FECHA = "Caja/MaxFecha"
    Public Const CAJA_MIN_FECHA = "Caja/MinFecha"

    'CHEQUERA ----------------------------------------------------------------------------------------------
    Public Const CHEQUERA_EXISTE = "Chequera/Existe"
    Public Const CHEQUERA_INSERTAR = "Chequera/Insertar"
    Public Const CHEQUERA_MODIFCAR = "Chequera/Modificar"
    Public Const CHEQUERA_ELIMINAR = "Chequera/Eliminar"
    Public Const CHEQUERA_ELIMINAR_CHEQUES = "Chequera/Eliminar_Cheques_Chequera"
    Public Const CHEQUERA_TODOS = "Chequera/Todos"
    Public Const CHEQUERA_ULTIMO_ID = "Chequera/UltimoID"
    Public Const CHEQUERA_SERVICIO_INSERTAR = "Chequera/ServicioInsertar"
    Public Const CHEQUERA_SERVICIO_MODIFICAR = "Chequera/ServicioModificar"
    Public Const CHEQUERA_SERVICIO_ELIMINAR = "Chequera/ServicioEliminar"
    Public Const CHEQUERA_LISTADO_SIN_COMPLETAR = "Chequera/ListadoSinCompletar"

    'CLIENTES ----------------------------------------------------------------------------------------------
    Public Const CLIENTES_EXISTE = "Clientes/Existe"
    Public Const CLIENTES_TODOS = "Clientes/Todos"
    Public Const CLIENTES_INSERTAR = "Clientes/Insertar"
    Public Const CLIENTES_RECUPERAR = "Clientes/Recuperar"
    Public Const CLIENTES_MODIFICAR = "Clientes/Modificar"
    Public Const CLIENTES_ELIMINAR = "Clientes/Eliminar"
    Public Const CLIENTES_FILTRAR_POR_ID_DE_CLIENTE = "Clientes/Filtrar_idCliente"
    Public Const CLIENTES_SERVICIO_INSERTAR = "Clientes/ServicioInsertar"
    Public Const CLIENTES_SERVICIO_MODIFICAR = "Clientes/ServicioModificar"

    'COMPROBANTES ----------------------------------------------------------------------------------------------
    Public Const COMPROBANTES_TODOS = "Comprobantes/Todos"
    Public Const COMPROBANTES_INSERTAR = "Comprobantes/Insertar"
    Public Const COMPROBANTES_MODIFICAR = "Comprobantes/Modificar"
    Public Const COMPROBANTES_ELIMINAR = "Comprobantes/Eliminar"

    'CUENTA CORRIENTE DE COMPRA ----------------------------------------------------------------------------------------------
    Public Const CUENTA_CORRIENTE_DE_COMPRA_INSERTAR = "CuentaCorrienteCompra/Insertar"
    Public Const CUENTA_CORRIENTE_DE_COMPRA_ULTIMO_ID = "CuentaCorrienteCompra/UltimoID"
    Public Const CUENTA_CORRIENTE_DE_COMPRA_ELIMINAR = "CuentaCorrienteCompra/Eliminar"
    Public Const CUENTA_CORRIENTE_DE_COMPRA_FILTRAR_POR_ID_PROVEEDOR = "CuentaCorrienteCompra/Filtrar_idProveedor"

    'CUENTA CORRIENTE DE VENTA ----------------------------------------------------------------------------------------------
    Public Const CUENTA_CORRIENTE_DE_VENTA_INSERTAR = "CuentaCorrienteVenta/Insertar"
    Public Const CUENTA_CORRIENTE_DE_VENTA_ULTIMO_ID = "CuentaCorrienteVenta/UltimoID"
    Public Const CUENTA_CORRIENTE_DE_VENTA_ELIMINAR = "CuentaCorrienteVenta/Eliminar"
    Public Const CUENTA_CORRIENTE_DE_VENTA_FILTRAR_POR_ID_CLIENTE = "CuentaCorrienteVenta/Filtrar_idCliente"

    'DATOS DEL SISTEMA ----------------------------------------------------------------------------------------------
    Public Const DATOS_DEL_SISTEMA_CONSULTAR = "DatosSistema/Consultar"

    'DEPOSITOS ----------------------------------------------------------------------------------------------
    Public Const DEPOSITOS_TODOS = "Depositos/Todos"
    Public Const DEPOSITOS_INSERTAR = "Depositos/Insertar"
    Public Const DEPOSITOS_EXISTE = "Depositos/Existe"
    Public Const DEPOSITOS_ELIMINAR = "Depositos/Eliminar"
    Public Const DEPOSITOS_MODIFICAR = "Depositos/Modificar"
    Public Const DEPOSITOS_SERVICIO_INSERTAR = "Depositos/ServicioInsertar"
    Public Const DEPOSITOS_SERVICIO_MODIFICAR = "Depositos/ServicioModificar"

    'DETALLE CHEQUES ----------------------------------------------------------------------------------------------
    Public Const DETALLE_CHEQUES_INSERTAR = "DetalleCheque/Insertar"
    Public Const DETALLE_CHEQUES_MODIFICAR = "DetalleCheque/Modificar"
    Public Const DETALLE_CHEQUES_ELIMINAR = "DetalleCheque/Eliminar"
    Public Const DETALLE_CHEQUES_CHEQUES_POR_CHEQUERA = "DetalleCheque/ChequesPorChequera"
    Public Const DETALLE_CHEQUES_ELIMINAR_POR_ID_CHEQUERA = "Chequera/Eliminar_Cheques_Chequera"

    'DETALLE REMITOS DE COMPRA ----------------------------------------------------------------------------------------------
    Public Const DETALLE_REMITOS_DE_COMPRA_INSERTAR = "DetalleRemitosCompra/Insertar"
    Public Const DETALLE_REMITOS_DE_COMPRA_FILTRAR_POR_ID_DE_REMITO_DE_COMPRA = "DetalleRemitosCompra/Filtrar_idRemitosCompra"
    Public Const DETALLE_REMITOS_DE_COMPRA_ELIMINAR_POR_ID_DE_REMITO_DE_COMPRA = "DetalleRemitosCompra/Eliminar_idRemitosCompra"
    Public Const DETALLE_REMITOS_DE_COMPRA_ELIMINAR_POR_ID_DE_ARTICULO_Y_POR_ID_DE_REMITO_DE_COMPRA = "DetalleRemitosCompra/Eliminar_idArticulo_idRemitosCompra"
    Public Const DETALLE_REMITOS_DE_COMPRA_ULTIMO_ID = "DetalleRemitosCompra/UltimoID"
    Public Const DETALLE_REMITOS_DE_COMPRA_FACTURACION = "DetalleRemitosCompra/Facturacion"
    Public Const DETALLE_REMITOS_DE_COMPRA_MODIFICAR_CANTIDAD_FACTURADA = "DetalleRemitosCompra/ModificarCantidadFacturada"
    Public Const DETALLE_REMITOS_DE_COMPRA_CANTIDAD_FACTURADA = "DetalleRemitosCompra/CantidadFacturada"
    Public Const DETALLE_REMITOS_DE_COMPRA_CANTIDAD = "DetalleRemitosCompra/Cantidad"
    Public Const DETALLE_REMITOS_DE_COMPRA_SIN_FACTURAR_PROVEEDOR = "DetalleRemitosCompra/ListadoSinFacturarProveedor"

    'DETALLE REMITOS DE VENTA ----------------------------------------------------------------------------------------------
    Public Const DETALLE_REMITOS_DE_VENTA_INSERTAR = "DetalleRemitoVta/Insertar"
    Public Const DETALLE_REMITOS_DE_VENTA_FILTRAR_POR_ID_DE_REMITO_DE_VENTA = "DetalleRemitoVta/Filtrar_idRemitosVenta"
    Public Const DETALLE_REMITOS_DE_VENTA_FILTRAR_POR_ID_CLIENTE_FACTURADO = "DetalleRemitoVta/Filtrar_idCliente_Facturado"
    Public Const DETALLE_REMITOS_DE_VENTA_FILTRAR_POR_ID_CLIENTE = "DetalleRemitoVta/Filtrar_idCliente"
    Public Const DETALLE_REMITOS_DE_VENTA_ELIMINAR_POR_ID_DE_REMITO_DE_VENTA = "DetalleRemitoVta/Eliminar_idRemitosVenta"
    Public Const DETALLE_REMITOS_DE_VENTA_ELIMINAR_POR_ID_DE_ARTICULO_Y_POR_ID_DE_REMITO_DE_VENTA = "DetalleRemitoVta/Eliminar_idArticulo_idRemitosVenta"
    Public Const DETALLE_REMITOS_DE_VENTA_FILTRAR_POR_ID_DETALLE_REMITO_VENTA = "DetalleRemitoVta/Filtrar_idDetalleRemitosVenta"
    Public Const DETALLE_REMITOS_DE_VENTA_ULTIMO_ID = "DetalleRemitoVta/UltimoID"
    Public Const DETALLE_REMITOS_DE_VENTA_FACTURACION = "DetalleRemitoVta/Facturacion"
    Public Const DETALLE_REMITOS_SIN_FACTURAR_CLIENTE = "DetalleRemitoVta/ListadoSinFacturarCliente"

    'DEVOLUCIONES ----------------------------------------------------------------------------------------------
    Public Const DEVOLUCIONES_SERVICIO_INSERTAR = "Devoluciones/ServicioInsertar"

    'EMPRESA ----------------------------------------------------------------------------------------------
    Public Const EMPRESA_INSERTAR = "Empresa/Insertar"
    Public Const EMPRESA_MODIFICAR = "Empresa/Modificar"
    Public Const EMPRESA_ELIMINAR = "Empresa/Eliminar"
    Public Const EMPRESA_CONSULTAR = "Empresa/Consultar"

    'FACTURA DE COMPRA MONEDAS ----------------------------------------------------------------------------------------------
    Public Const FACTURA_DE_COMPRA_MONEDAS_INSERTAR = "FacturaComMonedas/Insertar"
    Public Const FACTURA_DE_COMPRA_MONEDAS_ELIMINAR_POR_ID_FACTURA_DE_COMPRA = "FacturaComMonedas/Eliminar_idFacturaCompra"
    Public Const FACTURA_DE_COMPRA_MONEDAS_FILTRAR_POR_ID_FACTURA_DE_COMPRA = "FacturaComMonedas/Filtrar_idFacturaCompra"

    'FACTURA DE COMPRA ----------------------------------------------------------------------------------------------
    Public Const FACTURA_DE_COMPRA_INSERTAR = "FacturaCompra/Insertar"
    Public Const FACTURA_DE_COMPRA_ULTIMO_ID = "FacturaCompra/UltimoID"
    Public Const FACTURA_DE_COMPRA_ELIMINAR = "FacturaCompra/Eliminar"
    Public Const FACTURA_DE_COMPRA_MODIFICAR = "FacturaCompra/Modificar"
    Public Const FACTURA_DE_COMPRA_TODOS = "FacturaCompra/Todos"
    Public Const FACTURA_DE_COMPRA_SERVCIO_ELIMINAR = "FacturaCompra/ServicioEliminar"
    Public Const FACTURA_DE_COMPRA_SERVCIO_INSERTAR = "FacturaCompra/ServicioInsertar"
    Public Const FACTURA_DE_COMPRA_SERVCIO_MODIFICAR = "FacturaCompra/ServicioModificar"

    'FACTURA DE COMPRA DETALLE ----------------------------------------------------------------------------------------------
    Public Const FACTURA_DE_COMPRA_DETALLE_INSERTAR = "FacturaCompraDetalle/Insertar"
    Public Const FACTURA_DE_COMPRA_DETALLE_ELIMINAR_POR_ID_FACTURA_DE_COMPRA = "FacturaCompraDetalle/Eliminar_idFacturaCompra"
    Public Const FACTURA_DE_COMPRA_DETALLE_FILTRAR_POR_ID_FACTURA_DE_COMPRA = "FacturaCompraDetalle/Filtrar_idFacturaCompra"
    Public Const FACTURA_DE_COMPRA_DETALLE_SIN_REMITAR_PROVEEDOR = "FacturaCompraDetalle/ListadoSinRemitarProveedor"

    'FACTURA DE COMPRA MOVIMIENTOS ----------------------------------------------------------------------------------------------
    Public Const FACTURA_COMPRA_MOVIMIENTOS_FILTRAR_POR_ID_FACTURA_DE_COMPRA = "FacturaCompraMovimientos/Filtrar_idFacturaCompra"

    'FACTURA DE VENTA ----------------------------------------------------------------------------------------------
    Public Const FACTURA_DE_VENTA_INSERTAR = "FacturaVenta/Insertar"
    Public Const FACTURA_DE_VENTA_MODIFICAR = "FacturaVenta/Modificar"
    Public Const FACTURA_DE_VENTA_ULTIMO_ID = "FacturaVenta/UltimoID"
    Public Const FACTURA_DE_VENTA_ELIMINAR = "FacturaVenta/Eliminar"
    Public Const FACTURA_DE_VENTA_TODOS = "FacturaVenta/Todos"
    Public Const FACTURA_DE_VENTA_FILTRAR_SIN_REMITRAR = "FacturaVenta/Filtrar_Sin_Remitar"
    Public Const FACTURA_DE_VENTA_SERVICIO_INSERTAR = "FacturaVenta/ServicioInsertar"

    'FACTURA DE VENTA DETALLE ----------------------------------------------------------------------------------------------
    Public Const FACTURA_DE_VENTA_DETALLE_INSERTAR = "FacturaVentaDetalle/Insertar"
    Public Const FACTURA_DE_VENTA_DETALLE_ELIMINAR_POR_ID_FACTURA_DE_VENTA = "FacturaVentaDetalle/Eliminar_idFacturaVenta"
    Public Const FACTURA_DE_VENTA_DETALLE_FILTRAR_POR_ID_FACTURA_DE_VENTA = "FacturaVentaDetalle/Filtrar_idFacturaVenta"
    Public Const FACTURA_DE_VENTA_DETALLE_SIN_REMITAR_CLIENTE = "FacturaVentaDetalle/ListadoSinRemitarCliente"
    Public Const FACTURA_DE_VENTA_DETALLE_REMITADO_CLIENTE = "FacturaVentaDetalle/ListadoRemitadoCliente"
    Public Const FACTURA_DE_VENTA_DETALLE_FILTRAR_POR_ID_CLIENTE = "FacturaVentaDetalle/Filtrar_idCliente"

    'FACTURA DE VENTA MONEDAS ----------------------------------------------------------------------------------------------
    Public Const FACTURA_DE_VENTA_MONEDAS_INSERTAR = "FacturaVtaMonedas/Insertar"
    Public Const FACTURA_DE_VENTA_MONEDAS_ELIMINAR_POR_ID_FACTURA_DE_VENTA = "FacturaVtaMonedas/Eliminar_idFacturaVenta"
    Public Const FACTURA_DE_VENTA_MONEDAS_FILTRAR_POR_ID_FACTURA_DE_VENTA = "FacturaVtaMonedas/Filtrar_idFacturaVenta"
    Public Const FACTURA_DE_VENTA_MONEDAS_TODOS = "FacturaVtaMonedas/Todos"

    'MONEDAS ----------------------------------------------------------------------------------------------
    Public Const MONEDAS_TODOS = "Monedas/Todos"

    'MOVIMIENTOS REMITO FACTURA ----------------------------------------------------------------------------------------------
    Public Const MOVIMIENTOS_REMITO_FACTURA_FILTRAR_POR_ID_REMITO_DE_VENTA = "Movimientos_Remito_Factura/Filtrar_idRemitosVenta"

    'MOVIMIENTOS REMITO COMPRA FACTURA COMPRA ----------------------------------------------------------------------------------------------
    Public Const MOVIMIENTOS_REMITO_COMPRA_FACTURA_COMPRA_FILTRAR_POR_ID_REMITO_DE_COMPRA = "Movimientos_RemitoCompra_FacturaCompra/Filtrar_idRemitosCompra"
    Public Const MOVIMIENTOS_REMITO_COMPRA_FACTURA_COMPRA_FILTRAR_POR_ID_FACTURA_DE_COMPRA = "Movimientos_RemitoCompra_FacturaCompra/Filtrar_idFacturaCompra"

    'MOVIMIENTOS RESERVA REMITO ----------------------------------------------------------------------------------------------
    Public Const MOVIMIENTOS_RESERVA_REMITO_FILTRAR_POR_ID_REMITO_DE_VENTA = "Movimientos_Reserva_Remito/Filtrar_idRemitosVenta"

    'NUMERACION ----------------------------------------------------------------------------------------------
    Public Const NUMERACION_TODOS = "Numeracion/Todos"
    Public Const NUMERACION_INSERTAR = "Numeracion/Insertar"
    Public Const NUMERACION_ELIMINAR = "Numeracion/Eliminar"
    Public Const NUMERACION_MODIFICAR = "Numeracion/Modificar"

    'ORDEN DE PAGO ----------------------------------------------------------------------------------------------
    Public Const ORDEN_DE_PAGO_TODOS = "OrdenDePago/Todos"
    Public Const ORDEN_DE_PAGO_INSERTAR = "OrdenDePago/Insertar"
    Public Const ORDEN_DE_PAGO_ELIMINAR = "OrdenDePago/Eliminar"
    Public Const ORDEN_DE_PAGO_MODIFICAR = "OrdenDePago/Modificar"
    Public Const ORDEN_DE_PAGO_SERVICIO_INSERTAR = "OrdenDePago/ServicioInsertar"

    'ORDEN DE PAGO DETALLE ----------------------------------------------------------------------------------------------
    Public Const ORDEN_DE_PAGO_DETALLE_TODOS = "OrdenDePagoDetalle/Todos"
    Public Const ORDEN_DE_PAGO_DETALLE_INSERTAR = "OrdenDePagoDetalle/Insertar"
    Public Const ORDEN_DE_PAGO_DETALLE_ELIMINAR = "OrdenDePagoDetalle/Eliminar"
    Public Const ORDEN_DE_PAGO_DETALLE_MODIFICAR = "OrdenDePagoDetalle/Modificar"

    'ORDEN DE PAGO MONEDAS ----------------------------------------------------------------------------------------------
    Public Const ORDEN_DE_PAGO_MONEDAS_TODOS = "OrdenDePagoMonedas/Todos"
    Public Const ORDEN_DE_PAGO_MONEDAS_INSERTAR = "OrdenDePagoMonedas/Insertar"
    Public Const ORDEN_DE_PAGO_MONEDAS_ELIMINAR = "OrdenDePagoMonedas/Eliminar"
    Public Const ORDEN_DE_PAGO_MONEDAS_MODIFICAR = "OrdenDePagoMonedas/Modificar"
    Public Const ORDEN_DE_PAGO_MONEDAS_ELIMINAR_POR_ID_ORDEN_DE_PAGO = "OrdenDePagoMonedas/Eliminar_idOrdenDePago"
    Public Const ORDEN_DE_PAGO_MONEDAS_FILTRAR_POR_ID_ORDEN_DE_PAGO = "OrdenDePagoMonedas/Filtrar_idOrdenDePago"

    'PARIDAD CAMBIARIA ----------------------------------------------------------------------------------------------
    Public Const PARIDAD_CAMBIARIA_FILTRAR_POR_ID_MONEDA = "ParidadCambiaria/Filtrar_idMoneda"
    Public Const PARIDAD_CAMBIARIA_INSERTAR = "PPal/GuardarDolar"

    'MOVIMIENTO VALORES ----------------------------------------------------------------------------------------------
    Public Const MOVIMIENTO_VALORES_INSERTAR = "MovimientoValores/Insertar"
    Public Const MOVIMIENTO_VALORES_SERVICIO_INSERTAR = "MovimientoValores/ServicioInsertar"
    Public Const MOVIMIENTO_VALORES_MODIFICAR = "MovimientoValores/Modificar"
    Public Const MOVIMIENTO_VALORES_ELIMINAR = "MovimientoValores/Eliminar"
    Public Const MOVIMIENTO_VALORES_SERVICIO_ELIMINAR = "MovimientoValores/ServicioEliminar"
    Public Const MOVIMIENTO_VALORES_TODOS = "MovimientoValores/Todos"

    'PEDIDOS ----------------------------------------------------------------------------------------------
    Public Const PEDIDOS_INSERTAR = "Pedidos/Insertar"
    Public Const PEDIDOS_MODIFICAR = "Pedidos/Modificar"
    Public Const PEDIDOS_MODIFICAR_FECHA_CIERRE_PEDIDO = "Pedidos/Modificar_FechaCierrePedido"
    Public Const PEDIDOS_ELIMINAR = "Pedidos/Eliminar"
    Public Const PEDIDOS_ULTIMO_ID = "Pedidos/UltimoID"
    Public Const PEDIDOS_TODOS = "Pedidos/Todos"
    Public Const PEDIDOS_LISTADO_MOD_ELIM = "Pedidos/ListadoModElim"
    Public Const PEDIDOS_LISTADO_SIN_COMPLETAR = "Pedidos/ListadoSinCompletar"
    Public Const PEDIDOS_SERVICIO_INSERRTAR = "Pedidos/ServicioInsertar"
    Public Const PEDIDOS_SERVICIO_MODIFICAR = "Pedidos/ServicioModificar"
    Public Const PEDIDOS_SERVICIO_ELIMINAR = "Pedidos/ServicioEliminar"

    'PEDIDOS DETALLE ----------------------------------------------------------------------------------------------
    Public Const PEDIDOS_DETALLE_INSERTAR = "PedidosDetalle/Insertar"
    Public Const PEDIDOS_DETALLE_MODIFICAR = "PedidosDetalle/Modificar"
    Public Const PEDIDOS_DETALLE_MODIFICAR_CANTIDADES = "PedidosDetalle/Modificar_Cantidades"
    Public Const PEDIDOS_DETALLE_ELIMINAR = "PedidosDetalle/Eliminar"
    Public Const PEDIDOS_DETALLE_TODOS = "PedidosDetalle/Todos"
    Public Const PEDIDOS_DETALLE_FILTRAR_POR_ID_PEDIDOS = "PedidosDetalle/Filtrar_idPedidos"
    Public Const PEDIDOS_DETALLE_FILTRAR_POR_ID_PEDIDOS_DETALLE = "PedidosDetalle/Filtrar_idPedidosDetalle"
    Public Const PEDIDOS_DETALLE_FILTRAR_POR_ID_CLIENTE = "PedidosDetalle/Filtrar_idCliente"
    Public Const PEDIDOS_DETALLE_FILTRAR_POR_ID_CLIENTE_REMITADO = "PedidosDetalle/Filtrar_idCliente_Remitado"
    Public Const PEDIDOS_DETALLE_FILTRAR_POR_ID_CLIENTE_FACTURADO = "PedidosDetalle/Filtrar_idCliente_Facturado"
    Public Const PEDIDOS_DETALLE_SIN_REMITAR_CLIENTE = "PedidosDetalle/ListadoSinRemitarCliente"
    Public Const PEDIDOS_DETALLE_SIN_FACTURAR_CLIENTE = "PedidosDetalle/ListadoSinFacturarCliente"

    'PEDIDOS MOVIMIENTOS ----------------------------------------------------------------------------------------------
    Public Const PEDIDOS_MOVIMIENTOS_INSERTAR = "PedidosMovimientos/Insertar"
    Public Const PEDIDOS_MOVIMIENTOS_MODIFICAR = "PedidosMovimientos/Modificar"
    Public Const PEDIDOS_MOVIMIENTOS_ELIMINAR = "PedidosMovimientos/Eliminar"
    Public Const PEDIDOS_MOVIMIENTOS_ELIMINAR_POR_ID_PEDIDOS_DETALLE = "PedidosMovimientos/Eliminar_idPedidosDetalle"
    Public Const PEDIDOS_MOVIMIENTOS_ELIMINAR_POR_MOVIMIENTO_CANTIDAD_ID_PEDIDOS_DETALLE = "PedidosMovimientos/Eliminar_Movimiento_Cantidad_idPedidosDetalle"
    Public Const PEDIDOS_MOVIMIENTOS_FILTRAR_POR_ID_PEDIDOS_DETALLE = "PedidosMovimientos/Filtrar_idPedidosDetalle"

    'PERFIL DE USUARIO ----------------------------------------------------------------------------------------------
    Public Const PERFIL_DE_USUARIO_INSERTAR = "PerfilesUsuario/Insertar"
    Public Const PERFIL_DE_USUARIO_SERVICIO_INSERTAR = "PerfilesUsuario/ServicioInsertar"
    Public Const PERFIL_DE_USUARIO_FILTRAR_POR_ID_PERFIL_DE_USUARIO = "PerfilesUsuario/Filtrar_idPerfil"
    Public Const PERFIL_DE_USUARIO_MODIFICAR = "PerfilesUsuario/Modificar"
    Public Const PERFIL_DE_USUARIO_SERVICIO_MODIFICAR = "PerfilesUsuario/ServicioModificar"
    Public Const PERFIL_DE_USUARIO_TODOS = "PerfilesUsuario/Todos"
    Public Const PERFIL_DE_USUARIO_ELIMINAR = "PerfilesUsuario/Eliminar"
    Public Const PERFIL_DE_USUARIO_SERVICIO_ELIMINAR = "PerfilesUsuario/ServicioEliminar"
    Public Const PERFIL_DE_USUARIO_EXISTE = "PerfilesUsuario/Existe"

    'PROVEEDORES ----------------------------------------------------------------------------------------------
    Public Const PROVEEDORES_INSERTAR = "Proveedores/Insertar"
    Public Const PROVEEDORES_RECUPERAR = "Proveedores/Recuperar"
    Public Const PROVEEDORES_EXISTE = "Proveedores/Existe"
    Public Const PROVEEDORES_MODIFICAR = "Proveedores/Modificar"
    Public Const PROVEEDORES_TODOS = "Proveedores/Todos"
    Public Const PROVEEDORES_ELIMINAR = "Proveedores/Eliminar"
    Public Const PROVEEDORES_SERVICIO_INSERTAR = "Proveedores/ServicioInsertar"
    Public Const PROVEEDORES_SERVICIO_MODIFICAR = "Proveedores/ServicioModificar"

    'RECIBOS VENTA ----------------------------------------------------------------------------------------------
    Public Const RECIBOS_VENTA_SERVICIO_INSERTAR = "RecibosVenta/ServicioInsertar"

    'REGISTRO DE OPERACIONES ----------------------------------------------------------------------------------------------
    Public Const REGISTRO_OPERACIONES_INSERTAR = "RegistroOperaciones/Insertar"

    'REMITO DE COMPRA MONEDAS ----------------------------------------------------------------------------------------------
    Public Const REMITO_DE_COMPRA_MONEDAS_INSERTAR = "RemitoComMonedas/Insertar"
    Public Const REMITO_DE_COMPRA_MONEDAS_ELIMINAR_POR_ID_REMITO_DE_COMPRA = "RemitoComMonedas/Eliminar_idRemitosCompra"
    Public Const REMITO_DE_COMPRA_MONEDAS_FILTRAR_POR_ID_REMITO_DE_COMPRA = "RemitoComMonedas/Filtrar_idRemitosCompra"

    'REMITO DE COMPRA ----------------------------------------------------------------------------------------------
    Public Const REMITO_DE_COMPRA_INSERTAR = "RemitosCompra/Insertar"
    Public Const REMITO_DE_COMPRA_ULTIMO_ID = "RemitosCompra/UltimoID"
    Public Const REMITO_DE_COMPRA_TODOS = "RemitosCompra/Todos"
    Public Const REMITO_DE_COMPRA_SIN_FACTURAR = "RemitosCompra/SinFacturar"
    Public Const REMITO_DE_COMPRA_ELIMINAR = "RemitosCompra/Eliminar"
    Public Const REMITO_DE_COMPRA_MODIFICAR = "RemitosCompra/Modificar"
    Public Const REMITO_DE_COMPRA_FACTURACION = "RemitosCompra/Facturacion"
    Public Const REMITO_DE_COMPRA_FILTRAR_POR_ID_REMITO_DE_COMPRA = "RemitosCompra/Filtrar_idRemitosCompra"
    Public Const REMITO_DE_COMPRA_SERVICIO_INSERTAR = "RemitosCompra/ServicioInsertar"
    Public Const REMITO_DE_COMPRA_SERVICIO_MODIFICAR = "RemitosCompra/ServicioModificar"
    Public Const REMITO_DE_COMPRA_SERVICIO_ELIMINAR = "RemitosCompra/ServicioEliminar"

    'REMITO COMPRA MOVIMIENTOS ----------------------------------------------------------------------------------------------
    Public Const REMITO_COMPRA_MOVIMIENTOS_FILTRAR_POR_ID_REMITO_DE_COMPRA = "RemitosCompraMovimientos/Filtrar_idRemitosCompra"

    'REMITO DE VENTA ----------------------------------------------------------------------------------------------
    Public Const REMITO_DE_VENTA_INSERTAR = "RemitosVenta/Insertar"
    Public Const REMITO_DE_VENTA_INSERTAR_COMPLETO = "RemitosVenta/Insertar_Completo"
    Public Const REMITO_DE_VENTA_MODIFCIAR = "RemitosVenta/Modificar"
    Public Const REMITO_DE_VENTA_ELIMINAR = "RemitosVenta/Eliminar"
    Public Const REMITO_DE_VENTA_ULTIMO_ID = "RemitosVenta/UltimoID"
    Public Const REMITO_DE_VENTA_TODOS = "RemitosVenta/Todos"
    Public Const REMITO_DE_VENTA_SIN_FACTURAR = "RemitosVenta/SinFacturar"
    Public Const REMITO_DE_VENTA_FACTURACION = "RemitosVenta/Facturacion"
    Public Const REMITO_DE_VENTA_SERVICIO_INSERTAR = "RemitosVenta/ServicioInsertar"
    Public Const REMITO_DE_VENTA_SERVICIO_MODIFICAR = "RemitosVenta/ServicioModificar"
    Public Const REMITO_DE_VENTA_SERVICIO_ELIMINAR = "RemitosVenta/ServicioEliminar"

    'REMITO DE VENTA MONEDAS ----------------------------------------------------------------------------------------------
    Public Const REMITO_DE_VENTA_MONEDAS_INSERTAR = "RemitoVtaMonedas/Insertar"
    Public Const REMITO_DE_VENTA_MONEDAS_ELIMINAR_POR_ID_REMITO_DE_VENTA = "RemitoVtaMonedas/Eliminar_idRemitosVenta"
    Public Const REMITO_DE_VENTA_MONEDAS_FILTRAR_POR_ID_REMITO_DE_VENTA = "RemitoVtaMonedas/Filtrar_idRemitosVenta"
    Public Const REMITO_DE_VENTA_MONEDAS_TODOS = "RemitoVtaMonedas/Todos"

    'REMITO VENTA MOVIMIENTOS ----------------------------------------------------------------------------------------------
    Public Const REMITO_VENTA_MOVIMIENTOS_FILTRAR_POR_ID_REMITO_DE_VENTA = "RemitosVentaMovimientos/Filtrar_idRemitosVenta"

    'RUBRO ----------------------------------------------------------------------------------------------
    Public Const RUBRO_INSERTAR = "Rubro/Insertar"
    Public Const RUBRO_TODOS = "Rubro/Todos"
    Public Const RUBRO_EXISTE = "Rubro/Existe"
    Public Const RUBRO_ELIMINAR = "Rubro/Eliminar"
    Public Const RUBRO_MODIFICAR = "Rubro/Modificar"
    Public Const RUBRO_SERVICIO_INSERTAR = "Rubro/ServicioInsertar"
    Public Const RUBRO_SERVICIO_ELIMINAR = "Rubro/ServicioEliminar"
    Public Const RUBRO_SERVICIO_MODIFICAR = "Rubro/ServicioModificar"

    'STOCK ----------------------------------------------------------------------------------------------
    Public Const STOCK_INSERTAR = "Stock/Insertar"
    Public Const STOCK_ULTIMO_ID = "Stock/UltimoID"
    Public Const STOCK_FISICO = "Stock/StockFisico"
    Public Const STOCK_FISICO_DEPOSITO = "Stock/StockFisicoDeposito"
    Public Const STOCK_FILTRAR_POR_ID_DE_DEPOSITO = "Stock/StockFisicoDeposito"
    Public Const STOCK_RESERVADO = "Stock/StockReservado"
    Public Const STOCK_ELIMINAR = "Stock/Eliminar"
    Public Const STOCK_ELIMINAR_POR_FECHA_MOVIMIENTO_CANTIDAD_ID_ARTICULO_ID_DEPOSITO = "Stock/Eliminar_Fecha_Movimiento_Cantidad_idArticulo_idDeposito"
    Public Const STOCK_FILTRAR_POR_ID_DE_ARTICULO = "Stock/Filtrar_idArticulo"

    'SUB RUBRO ----------------------------------------------------------------------------------------------
    Public Const SUB_RUBRO_INSERTAR = "SubRubro/Insertar"
    Public Const SUB_RUBRO_TODOS = "SubRubro/Todos"
    Public Const SUB_RUBRO_EXISTE_POR_ID_DE_RUBRO = "SubRubro/Existe_idRubro"
    Public Const SUB_RUBRO_EXISTE = "SubRubro/Existe"
    Public Const SUB_RUBRO_ELIMINAR = "SubRubro/Eliminar"
    Public Const SUB_RUBRO_MODIFICAR = "SubRubro/Modificar"
    Public Const SUB_RUBRO_SERVICIO_INSERTAR = "SubRubro/ServicioInsertar"
    Public Const SUB_RUBRO_SERVICIO_MODIFICAR = "SubRubro/ServicioModificar"

    'USUARIO ----------------------------------------------------------------------------------------------
    Public Const USUARIO_INSERTAR = "Usuarios/Insertar"
    Public Const USUARIO_LOGIN = "Usuarios/Login"
    Public Const USUARIO_TODOS = "Usuarios/Todos"
    Public Const USUARIO_ELIMINAR = "Usuarios/Eliminar"
    Public Const USUARIO_MODIFICAR = "Usuarios/Modificar"
    Public Const USUARIO_EXISTE = "Usuarios/Existe"
    Public Const USUARIO_FILTRAR_POR_ID_PERFIL_DE_USUARIO = "Usuarios/Filtrar_idPerfil"
    Public Const USUARIO_SERVICIO_INSERTAR = "Usuarios/ServicioInsertar"
    Public Const USUARIO_SERVICIO_MODIFICAR = "Usuarios/ServicioModificar"
    Public Const USUARIO_FINALIZAR_SESION = "Usuarios/FinalizarSesion"

    'VALORES EN CARTERA ----------------------------------------------------------------------------------------------
    Public Const VALORES_EN_CARTERA_TODOS = "ValoresEnCartera/Todos"
    Public Const VALORES_EN_CARTERA_INSERTAR = "ValoresEnCartera/Insertar"
    Public Const VALORES_EN_CARTERA_MODIFICAR = "ValoresEnCartera/Modificar"
    Public Const VALORES_EN_CARTERA_ELIMINAR = "ValoresEnCartera/Eliminar"
    Public Const VALORES_EN_CARTERA_LISTADO_DISPONIBLE = "ValoresEnCartera/ListadoDisponible"
    Public Const VALORES_EN_CARTERA_SALDO_PESOS = "ValoresEnCartera/SaldoPesos"
    Public Const VALORES_EN_CARTERA_SALDO_DOLARES = "ValoresEnCartera/SaldoDolares"
End Class
