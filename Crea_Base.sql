/****** Object:  Table [dbo].[Tbl_VentaServicio]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_VentaServicio]') AND type in (N'U'))
DROP TABLE [dbo].[Tbl_VentaServicio]
GO
/****** Object:  Table [dbo].[Tbl_VentaProducto]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_VentaProducto]') AND type in (N'U'))
DROP TABLE [dbo].[Tbl_VentaProducto]
GO
/****** Object:  Table [dbo].[Tbl_Venta]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_Venta]') AND type in (N'U'))
DROP TABLE [dbo].[Tbl_Venta]
GO
/****** Object:  Table [dbo].[Tbl_Usuario]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_Usuario]') AND type in (N'U'))
DROP TABLE [dbo].[Tbl_Usuario]
GO
/****** Object:  Table [dbo].[Tbl_Servicio]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_Servicio]') AND type in (N'U'))
DROP TABLE [dbo].[Tbl_Servicio]
GO
/****** Object:  Table [dbo].[Tbl_RolFormulario]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_RolFormulario]') AND type in (N'U'))
DROP TABLE [dbo].[Tbl_RolFormulario]
GO
/****** Object:  Table [dbo].[Tbl_Rol]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_Rol]') AND type in (N'U'))
DROP TABLE [dbo].[Tbl_Rol]
GO
/****** Object:  Table [dbo].[Tbl_Proveedor]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_Proveedor]') AND type in (N'U'))
DROP TABLE [dbo].[Tbl_Proveedor]
GO
/****** Object:  Table [dbo].[Tbl_Producto]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_Producto]') AND type in (N'U'))
DROP TABLE [dbo].[Tbl_Producto]
GO
/****** Object:  Table [dbo].[Tbl_PagoFactura]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_PagoFactura]') AND type in (N'U'))
DROP TABLE [dbo].[Tbl_PagoFactura]
GO
/****** Object:  Table [dbo].[Tbl_Licencia]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_Licencia]') AND type in (N'U'))
DROP TABLE [dbo].[Tbl_Licencia]
GO
/****** Object:  Table [dbo].[Tbl_Inventario]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_Inventario]') AND type in (N'U'))
DROP TABLE [dbo].[Tbl_Inventario]
GO
/****** Object:  Table [dbo].[Tbl_Gasto]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_Gasto]') AND type in (N'U'))
DROP TABLE [dbo].[Tbl_Gasto]
GO
/****** Object:  Table [dbo].[Tbl_Formulario]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_Formulario]') AND type in (N'U'))
DROP TABLE [dbo].[Tbl_Formulario]
GO
/****** Object:  Table [dbo].[Tbl_Deposito]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_Deposito]') AND type in (N'U'))
DROP TABLE [dbo].[Tbl_Deposito]
GO
/****** Object:  Table [dbo].[Tbl_Correo]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_Correo]') AND type in (N'U'))
DROP TABLE [dbo].[Tbl_Correo]
GO
/****** Object:  Table [dbo].[Tbl_Cliente]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_Cliente]') AND type in (N'U'))
DROP TABLE [dbo].[Tbl_Cliente]
GO
/****** Object:  Table [dbo].[Tbl_Auditoria]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_Auditoria]') AND type in (N'U'))
DROP TABLE [dbo].[Tbl_Auditoria]
GO
/****** Object:  Table [dbo].[Tbl_AdelantoInsentivo]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_AdelantoInsentivo]') AND type in (N'U'))
DROP TABLE [dbo].[Tbl_AdelantoInsentivo]
GO
/****** Object:  Table [dbo].[Tbl_AccionRegistro]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_AccionRegistro]') AND type in (N'U'))
DROP TABLE [dbo].[Tbl_AccionRegistro]
GO
/****** Object:  StoredProcedure [dbo].[SpModificaVenta]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpModificaVenta]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SpModificaVenta]
GO
/****** Object:  StoredProcedure [dbo].[SpModificaUsuario]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpModificaUsuario]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SpModificaUsuario]
GO
/****** Object:  StoredProcedure [dbo].[SpModificaServicio]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpModificaServicio]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SpModificaServicio]
GO
/****** Object:  StoredProcedure [dbo].[SpModificaProveedor]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpModificaProveedor]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SpModificaProveedor]
GO
/****** Object:  StoredProcedure [dbo].[SpModificaProducto]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpModificaProducto]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SpModificaProducto]
GO
/****** Object:  StoredProcedure [dbo].[SpModificaPagoFactura]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpModificaPagoFactura]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SpModificaPagoFactura]
GO
/****** Object:  StoredProcedure [dbo].[SpModificaInventario]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpModificaInventario]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SpModificaInventario]
GO
/****** Object:  StoredProcedure [dbo].[SpModificaGasto]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpModificaGasto]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SpModificaGasto]
GO
/****** Object:  StoredProcedure [dbo].[SpModificaDeposito]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpModificaDeposito]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SpModificaDeposito]
GO
/****** Object:  StoredProcedure [dbo].[SpModificaCliente]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpModificaCliente]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SpModificaCliente]
GO
/****** Object:  StoredProcedure [dbo].[SpModificaAdelantoInsentivo]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpModificaAdelantoInsentivo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SpModificaAdelantoInsentivo]
GO
/****** Object:  StoredProcedure [dbo].[SpInsertaLicencia]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpInsertaLicencia]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SpInsertaLicencia]
GO
/****** Object:  StoredProcedure [dbo].[SpInsertaAuditoria]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpInsertaAuditoria]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SpInsertaAuditoria]
GO
/****** Object:  StoredProcedure [dbo].[SpCreaVenta]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpCreaVenta]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SpCreaVenta]
GO
/****** Object:  StoredProcedure [dbo].[SpCreaUsuario]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpCreaUsuario]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SpCreaUsuario]
GO
/****** Object:  StoredProcedure [dbo].[SpCreaServicio]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpCreaServicio]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SpCreaServicio]
GO
/****** Object:  StoredProcedure [dbo].[SpCreaProveedor]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpCreaProveedor]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SpCreaProveedor]
GO
/****** Object:  StoredProcedure [dbo].[SpCreaProducto]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpCreaProducto]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SpCreaProducto]
GO
/****** Object:  StoredProcedure [dbo].[SpCreaPagoFactura]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpCreaPagoFactura]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SpCreaPagoFactura]
GO
/****** Object:  StoredProcedure [dbo].[SpCreaInventario]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpCreaInventario]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SpCreaInventario]
GO
/****** Object:  StoredProcedure [dbo].[SpCreaGasto]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpCreaGasto]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SpCreaGasto]
GO
/****** Object:  StoredProcedure [dbo].[SpCreaDeposito]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpCreaDeposito]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SpCreaDeposito]
GO
/****** Object:  StoredProcedure [dbo].[SpCreaCliente]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpCreaCliente]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SpCreaCliente]
GO
/****** Object:  StoredProcedure [dbo].[SpCreaAdelantoInsentivo]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpCreaAdelantoInsentivo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SpCreaAdelantoInsentivo]
GO
/****** Object:  StoredProcedure [dbo].[SpConsultaVentas]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpConsultaVentas]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SpConsultaVentas]
GO
/****** Object:  StoredProcedure [dbo].[SpConsultaUsuarioLogin]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpConsultaUsuarioLogin]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SpConsultaUsuarioLogin]
GO
/****** Object:  StoredProcedure [dbo].[SpConsultaUsuario]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpConsultaUsuario]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SpConsultaUsuario]
GO
/****** Object:  StoredProcedure [dbo].[SpConsultaServicio]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpConsultaServicio]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SpConsultaServicio]
GO
/****** Object:  StoredProcedure [dbo].[SpConsultaProveedor]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpConsultaProveedor]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SpConsultaProveedor]
GO
/****** Object:  StoredProcedure [dbo].[SpConsultaProductosServicios]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpConsultaProductosServicios]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SpConsultaProductosServicios]
GO
/****** Object:  StoredProcedure [dbo].[SpConsultaProducto]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpConsultaProducto]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SpConsultaProducto]
GO
/****** Object:  StoredProcedure [dbo].[SpConsultaPagoFactura]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpConsultaPagoFactura]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SpConsultaPagoFactura]
GO
/****** Object:  StoredProcedure [dbo].[SpConsultaLicencia]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpConsultaLicencia]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SpConsultaLicencia]
GO
/****** Object:  StoredProcedure [dbo].[SpConsultaInventario]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpConsultaInventario]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SpConsultaInventario]
GO
/****** Object:  StoredProcedure [dbo].[SpConsultaGasto]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpConsultaGasto]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SpConsultaGasto]
GO
/****** Object:  StoredProcedure [dbo].[SpConsultaDeposito]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpConsultaDeposito]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SpConsultaDeposito]
GO
/****** Object:  StoredProcedure [dbo].[SpConsultaCorreo]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpConsultaCorreo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SpConsultaCorreo]
GO
/****** Object:  StoredProcedure [dbo].[SpConsultaCliente]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpConsultaCliente]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SpConsultaCliente]
GO
/****** Object:  StoredProcedure [dbo].[SpConsultaAdelantoInsentivo]    Script Date: 21/09/2016 11:09:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpConsultaAdelantoInsentivo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SpConsultaAdelantoInsentivo]
GO
/****** Object:  StoredProcedure [dbo].[SpConsultaAdelantoInsentivo]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpConsultaAdelantoInsentivo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		WILINTON BAQUERO
-- Create date: 2016-09-04
-- =============================================
CREATE PROCEDURE [dbo].[SpConsultaAdelantoInsentivo]
	@FechaInicial varchar(8)='''',@FechaFinal varchar(8)=''''
AS
BEGIN

	BEGIN TRY
		
		--exec SpConsultaAdelantoInsentivo ''20160810'',''''

		select 1 Resultado  

		select AdelantoInsentivoID,UsuarioAdelantoInsentivoID,u.Nombre+'' ''+u.Apellido NombreUsuario,u.CodigoUsuario,ValorAdelantoInsentivo,Adelanto,v.Activo
		from Tbl_AdelantoInsentivo v
		inner join Tbl_Usuario u on v.UsuarioAdelantoInsentivoID=u.UsuarioID
		where convert(varchar(8), v.FechaModifica,112)>= case when @FechaInicial='''' then convert(varchar(8), GETDATE(),112) else @FechaInicial end
			and
			convert(varchar(8), v.FechaModifica,112)<= case when @FechaFinal='''' then convert(varchar(8), GETDATE(),112) else @FechaFinal end

		select * from Tbl_Usuario where RolID=4

	END TRY  
  
  
	BEGIN CATCH  
  
		select 0 Resultado, CONVERT(varchar(max),ERROR_MESSAGE())+''      
		Error en la linea: ''+CONVERT(varchar(max),ERROR_LINE()) Mensaje  
  
	END CATCH 

END


' 
END
GO
/****** Object:  StoredProcedure [dbo].[SpConsultaCliente]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpConsultaCliente]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		WILINTON BAQUERO
-- Create date: 2016-09-04
-- =============================================
create PROCEDURE [dbo].[SpConsultaCliente]
AS
BEGIN

	BEGIN TRY
	
		select 1 Resultado  

		select * from Tbl_Cliente 

	END TRY  
  
  
	BEGIN CATCH  
  
		select 0 Resultado, CONVERT(varchar(max),ERROR_MESSAGE())+''      
		Error en la linea: ''+CONVERT(varchar(max),ERROR_LINE()) Mensaje  
  
	END CATCH 

END


' 
END
GO
/****** Object:  StoredProcedure [dbo].[SpConsultaCorreo]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpConsultaCorreo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		WILINTON BAQUERO
-- Create date: 2016-07-20
-- =============================================
CREATE PROCEDURE [dbo].[SpConsultaCorreo]
AS
BEGIN

	BEGIN TRY
	
		select 1 Resultado  

		select * from Tbl_Correo


	END TRY  
  
  
	BEGIN CATCH  
  
		select 0 Resultado, CONVERT(varchar(max),ERROR_MESSAGE())+''      
		Error en la linea: ''+CONVERT(varchar(max),ERROR_LINE()) Mensaje  
  
	END CATCH 

END



' 
END
GO
/****** Object:  StoredProcedure [dbo].[SpConsultaDeposito]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpConsultaDeposito]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		WILINTON BAQUERO
-- Create date: 2016-09-04
-- =============================================
CREATE PROCEDURE [dbo].[SpConsultaDeposito]
	@FechaInicial varchar(8)='''',@FechaFinal varchar(8)=''''
AS
BEGIN

	BEGIN TRY
		
		--exec SpConsultaDeposito ''20160810'',''''

		select 1 Resultado  

		select * 
		from Tbl_Deposito v
		where convert(varchar(8), v.FechaModifica,112)>= case when @FechaInicial='''' then convert(varchar(8), GETDATE(),112) else @FechaInicial end
			and
			convert(varchar(8), v.FechaModifica,112)<= case when @FechaFinal='''' then convert(varchar(8), GETDATE(),112) else @FechaFinal end

	END TRY  
  
  
	BEGIN CATCH  
  
		select 0 Resultado, CONVERT(varchar(max),ERROR_MESSAGE())+''      
		Error en la linea: ''+CONVERT(varchar(max),ERROR_LINE()) Mensaje  
  
	END CATCH 

END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[SpConsultaGasto]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpConsultaGasto]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		WILINTON BAQUERO
-- Create date: 2016-09-04
-- =============================================
CREATE PROCEDURE [dbo].[SpConsultaGasto]
	@FechaInicial varchar(8)='''',@FechaFinal varchar(8)=''''
AS
BEGIN

	BEGIN TRY
		
		--exec SpConsultaGasto ''20160810'',''''

		select 1 Resultado  

		select * 
		from Tbl_Gasto v
		where convert(varchar(8), v.FechaModifica,112)>= case when @FechaInicial='''' then convert(varchar(8), GETDATE(),112) else @FechaInicial end
			and
			convert(varchar(8), v.FechaModifica,112)<= case when @FechaFinal='''' then convert(varchar(8), GETDATE(),112) else @FechaFinal end

	END TRY  
  
  
	BEGIN CATCH  
  
		select 0 Resultado, CONVERT(varchar(max),ERROR_MESSAGE())+''      
		Error en la linea: ''+CONVERT(varchar(max),ERROR_LINE()) Mensaje  
  
	END CATCH 

END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[SpConsultaInventario]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpConsultaInventario]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		WILINTON BAQUERO
-- Create date: 2016-07-28
-- =============================================
CREATE PROCEDURE [dbo].[SpConsultaInventario]
AS
BEGIN

	BEGIN TRY 

		
		select 1 Resultado, ''Consulta exitosa'' Mensaje

		select 
			isnull( i.InventarioID,0) InventarioID,p.ProductoID,p.Nombre Producto,ISNULL(i.CantidadUnidad,0) CantidadUnidad,p.Activo
		from Tbl_Producto p
		left join Tbl_Inventario i on i.ProductoID=p.ProductoID
		 
	END TRY  
  
  
	BEGIN CATCH  
  
		select 0 Resultado, CONVERT(varchar(max),ERROR_MESSAGE())+''      
		Error en la linea: ''+CONVERT(varchar(max),ERROR_LINE()) Mensaje  
  
	END CATCH 

END


' 
END
GO
/****** Object:  StoredProcedure [dbo].[SpConsultaLicencia]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpConsultaLicencia]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		WILINTON BAQUERO
-- Create date: 2016-07-13
-- =============================================
CREATE PROCEDURE [dbo].[SpConsultaLicencia]
	@Board varchar(max),@Mac varchar(max)
AS
BEGIN
	SET NOCOUNT ON;

    BEGIN TRY
		
		--exec SpConsultaLicencia ''1'',''006073AB6523''

		IF EXISTS( select * from Tbl_Licencia where convert(varchar(max),DECRYPTBYPASSPHRASE(''b@qu3r096'',Board))= @Board and
					convert(varchar(max),DECRYPTBYPASSPHRASE(''b@qu3r096'',Mac))= @Mac )
		BEGIN

			select ''1'' Resultado,''Licencia Valida'' Mensaje

		END
		ELSE
		BEGIN

			select ''0'' Resultado,''Licencia no Valida'' Mensaje
			
		END

		

	END TRY  
  
  
	BEGIN CATCH  
  
		select 0 Resultado, CONVERT(varchar(max),ERROR_MESSAGE())+''      
		Error en la linea: ''+CONVERT(varchar(max),ERROR_LINE()) Mensaje  
  
	END CATCH 
END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[SpConsultaPagoFactura]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpConsultaPagoFactura]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		WILINTON BAQUERO
-- Create date: 2016-09-04
-- =============================================
CREATE PROCEDURE [dbo].[SpConsultaPagoFactura]
	@FechaInicial varchar(8)='''',@FechaFinal varchar(8)=''''
AS
BEGIN

	BEGIN TRY
		
		--exec SpConsultaPagoFactuta ''20160810'',''''

		select 1 Resultado  

		select PagoFacturaID,isnull(v.ProveedorID,0) ProveedorID,p.Nombre Proveedor,NumeroFactura,ValorPagoFactura,v.Activo
		from Tbl_PagoFactura v
		inner join Tbl_Proveedor p on v.ProveedorID=p.ProveedorID
		where convert(varchar(8), v.FechaModifica,112)>= case when @FechaInicial='''' then convert(varchar(8), GETDATE(),112) else @FechaInicial end
			and
			convert(varchar(8), v.FechaModifica,112)<= case when @FechaFinal='''' then convert(varchar(8), GETDATE(),112) else @FechaFinal end

		select * from Tbl_Proveedor

	END TRY  
  
  
	BEGIN CATCH  
  
		select 0 Resultado, CONVERT(varchar(max),ERROR_MESSAGE())+''      
		Error en la linea: ''+CONVERT(varchar(max),ERROR_LINE()) Mensaje  
  
	END CATCH 

END


' 
END
GO
/****** Object:  StoredProcedure [dbo].[SpConsultaProducto]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpConsultaProducto]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		WILINTON BAQUERO
-- Create date: 2016-07-13
-- Modificate date: 2016-09-04
-- =============================================
CREATE PROCEDURE [dbo].[SpConsultaProducto]
AS
BEGIN

	BEGIN TRY
	
		select 1 Resultado  

		select
			ProductoID,p.Nombre,isnull(p.ProveedorID,0) ProveedorID,isnull(r.Nombre,''...'') Proveedor,UnidadxProducto,ValorCompra,ValorVentaXUnidad,PorcentajeVentaPublico,
			DescuentoVentaInterna,Insumo,CodigoProducto,p.Activo
		from Tbl_Producto p
		left join Tbl_Proveedor r on p.ProveedorID=r.ProveedorID

		select * from Tbl_Proveedor 

	END TRY  
  
  
	BEGIN CATCH  
  
		select 0 Resultado, CONVERT(varchar(max),ERROR_MESSAGE())+''      
		Error en la linea: ''+CONVERT(varchar(max),ERROR_LINE()) Mensaje  
  
	END CATCH 

END


' 
END
GO
/****** Object:  StoredProcedure [dbo].[SpConsultaProductosServicios]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpConsultaProductosServicios]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		WILINTON BAQUERO
-- Create date: 2016-07-16
-- Modificate date: 2016-08-28
-- =============================================
CREATE PROCEDURE [dbo].[SpConsultaProductosServicios]
AS
BEGIN

	BEGIN TRY 

		select 1 Resultado, ''Consulta exitosa'' Mensaje

		select UsuarioID,CodigoUsuario,Nombre +'' ''+Apellido Nombre
		from Tbl_Usuario where Activo=1 and RolID=4

		select * from Tbl_Servicio where Activo=1

		select * from Tbl_Producto where Activo=1 

	END TRY  
  
  
	BEGIN CATCH  
  
		select 0 Resultado, CONVERT(varchar(max),ERROR_MESSAGE())+''      
		Error en la linea: ''+CONVERT(varchar(max),ERROR_LINE()) Mensaje  
  
	END CATCH 

END


' 
END
GO
/****** Object:  StoredProcedure [dbo].[SpConsultaProveedor]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpConsultaProveedor]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		WILINTON BAQUERO
-- Create date: 2016-09-04
-- =============================================
CREATE PROCEDURE [dbo].[SpConsultaProveedor]
AS
BEGIN

	BEGIN TRY
	
		select 1 Resultado  

		select * from Tbl_Proveedor 

	END TRY  
  
  
	BEGIN CATCH  
  
		select 0 Resultado, CONVERT(varchar(max),ERROR_MESSAGE())+''      
		Error en la linea: ''+CONVERT(varchar(max),ERROR_LINE()) Mensaje  
  
	END CATCH 

END


' 
END
GO
/****** Object:  StoredProcedure [dbo].[SpConsultaServicio]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpConsultaServicio]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		WILINTON BAQUERO
-- Create date: 2016-07-13
-- Modificate date: 2016-08-28
-- =============================================
CREATE PROCEDURE [dbo].[SpConsultaServicio]
AS
BEGIN

	BEGIN TRY
	
		select 1 Resultado  

		select ServicioID,Nombre,ValorVenta,PorcentajeEstilista,Variable,CodigoServicio,Activo
		from Tbl_Servicio

		--select
		--	ProductoID,Nombre,UnidadxProducto,ValorCompra,ValorVentaXUnidad,PorcentajeVentaPublico,DescuentoVentaInterna,Insumo,CodigoProducto,Activo
		--from Tbl_Producto

	END TRY  
  
  
	BEGIN CATCH  
  
		select 0 Resultado, CONVERT(varchar(max),ERROR_MESSAGE())+''      
		Error en la linea: ''+CONVERT(varchar(max),ERROR_LINE()) Mensaje  
  
	END CATCH 

END' 
END
GO
/****** Object:  StoredProcedure [dbo].[SpConsultaUsuario]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpConsultaUsuario]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		WILINTON BAQUERO
-- Create date: 2016-07-06
-- Modificate date: 2016-08-28
-- =============================================
CREATE PROCEDURE [dbo].[SpConsultaUsuario]
AS
BEGIN

	BEGIN TRY
	
		select 1 Resultado  

		select 
			UsuarioID,u.Nombre +'' ''+u.Apellido NombreCompleto,u.Nombre,Apellido,CodigoUsuario,NombreUsuario,Clave,Documento,Telefono,Direccion,Activo,
			isnull(u.RolID,0) RolID, isnull(r.Nombre,'''') Rol 
		from Tbl_Usuario u
		left join Tbl_Rol r on u.RolID=r.RolID

		select
			RolID,Nombre
		from Tbl_Rol

	END TRY  
  
  
	BEGIN CATCH  
  
		select 0 Resultado, CONVERT(varchar(max),ERROR_MESSAGE())+''      
		Error en la linea: ''+CONVERT(varchar(max),ERROR_LINE()) Mensaje  
  
	END CATCH 

END



' 
END
GO
/****** Object:  StoredProcedure [dbo].[SpConsultaUsuarioLogin]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpConsultaUsuarioLogin]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		WILINTON BAQUERO
-- Create date: 2016-07-06
-- =============================================
CREATE PROCEDURE [dbo].[SpConsultaUsuarioLogin]
	@NombreUsuario varchar(50),@Clave varchar(50)
AS
BEGIN

	BEGIN TRY
	
		IF(select count(*) from Tbl_Usuario where NombreUsuario=@NombreUsuario and Clave=@Clave and Activo=1)=1
		BEGIN
		
			select 1 Resultado  

			select 
				UsuarioID,u.Nombre + '''' +Apellido NombreCompleto,u.Nombre,Apellido,NombreUsuario,Clave,Documento,Telefono,Direccion,Activo,u.RolID, 
				r.Nombre Rol 
			from Tbl_Usuario u
			left join Tbl_Rol r on u.RolID=r.RolID
			where NombreUsuario=@NombreUsuario and Clave=@Clave

			select f.*
			from Tbl_RolFormulario rf
			inner join Tbl_Formulario f on rf.FormularioID=f.FormularioID
			inner join Tbl_Rol r on r.RolID=rf.RolID
			inner join Tbl_Usuario u on r.RolID=u.RolID
			where NombreUsuario=@NombreUsuario and Clave=@Clave and Activo=1
		END
		ELSE
		BEGIN

			select 0 Resultado, ''Usuario no Valido'' Mensaje

		END

	END TRY  
  
  
	BEGIN CATCH  
  
		select 0 Resultado, CONVERT(varchar(max),ERROR_MESSAGE())+''      
		Error en la linea: ''+CONVERT(varchar(max),ERROR_LINE()) Mensaje  
  
	END CATCH 

END



' 
END
GO
/****** Object:  StoredProcedure [dbo].[SpConsultaVentas]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpConsultaVentas]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		WILINTON BAQUERO
-- Create date: 2016-07-17
-- Modifcate date: 2016-09-05
-- =============================================
CREATE PROCEDURE [dbo].[SpConsultaVentas]
	@TipoReporte smallint=0,@FechaInicial varchar(8)='''',@FechaFinal varchar(8)=''''
AS
BEGIN

	BEGIN TRY
		
		select distinct
			v.VentaID,v.ValorVenta VentaFactura,v.UsuarioCreaID,c.Nombre+'' ''+c.Apellido UsuarioCrea,convert(varchar(8), 
			v.Fecha,112) Fecha,v.Interna,v.Activo,v.NumeroVentaDia,
			isnull(s.ServicioID,0)ServicioID,
			isnull(s.Nombre,''...'') Servicio,
			isnull(s.ValorVenta,0) ValorVentaServicio,
			isnull(s.PorcentajeEstilista,0) PorcentajeEstilista,
			isnull(s.CodigoServicio,''...'') CodigoServicio,
			convert(float,ISNULL(s.Cantidad,0)) CantidadServicio,
			case when isnull(s.CodigoTrabajo,''...'')='''' then ''...'' else isnull(s.CodigoTrabajo,''...'') end CodigoTrabajoServicio,
			isnull(s.UsuarioID,0) UsuarioServicioID,
			isnull(e.Nombre+'' ''+e.Apellido,''...'') UsuarioServicio,
			convert(float,isnull(i.VentaServicioID,0)) VentaServicioID,
			case when isnull(i.VentaServicioID,0)>0 then isnull(i.ProductoID,0) else isnull(p.ProductoID,0) end ProductoID,
			case when isnull(i.VentaServicioID,0)>0 then isnull(i.Nombre,''...'') else isnull(p.Nombre,''...'') end Producto,
			convert(float,case when isnull(i.VentaServicioID,0)>0 then isnull(i.Cantidad,0) else isnull(p.Cantidad,0) end) CantidadProducto,
			convert(float,case when isnull(i.VentaServicioID,0)>0 then isnull(i.ValorxUnidad,0) else isnull(p.ValorxUnidad,0) end) ValorxUnidad,
			convert(float,case when isnull(i.VentaServicioID,0)>0 then isnull(i.ValorVentaXUnidad,0) else isnull(p.ValorVentaXUnidad,0) end) ValorVentaXUnidad,
			convert(float,case when isnull(i.VentaServicioID,0)>0 then isnull(i.PorcentajeVentaPublico,0) 
								else isnull(p.PorcentajeVentaPublico,0) end) PorcentajeVentaPublico,
			convert(float,case when isnull(i.VentaServicioID,0)>0 then isnull(i.DescuentoVentaInterna,0) else isnull(p.DescuentoVentaInterna,0) end) DescuentoVentaInterna,
			case when isnull(i.VentaServicioID,0)>0 then isnull(i.CodigoProducto,0) else isnull(p.CodigoProducto,0) end CodigoProducto,
			case when isnull(i.VentaServicioID,0)>0 then ''...'' 
				else case when isnull(p.CodigoTrabajo,''...'')='''' then ''...'' else isnull(p.CodigoTrabajo,''...'') end
			end CodigoTrabajoProducto,
			case when isnull(i.VentaServicioID,0)>0 then 0 else isnull(p.UsuarioID,0) end UsuarioProductoID,
			case when isnull(i.VentaServicioID,0)>0 then ''...'' else isnull(r.Nombre+'' ''+r.Apellido,''...'') end UsuarioProducto
			into #Reporte
		from Tbl_Venta v
		left join Tbl_VentaServicio s on v.VentaID=s.VentaID
		left join Tbl_VentaProducto i on s.VentaServicioID=i.VentaServicioID
		left join Tbl_VentaProducto p on v.VentaID=p.VentaID and p.VentaServicioID=0
		left join Tbl_Usuario c on v.UsuarioCreaID=c.UsuarioID
		left join Tbl_Usuario e on s.UsuarioID=e.UsuarioID
		left join Tbl_Usuario r on p.UsuarioID=r.UsuarioID
		where convert(varchar(8), v.Fecha,112)>= case when @FechaInicial='''' then convert(varchar(8), GETDATE(),112) else @FechaInicial end
			and
			convert(varchar(8), v.Fecha,112)<= case when @FechaFinal='''' then convert(varchar(8), GETDATE(),112) else @FechaFinal end

		select 1 Resultado , ''Consulta exitosa'' Mensaje 

		IF( @TipoReporte=0)	--Consulta de ventas del día  
		BEGIN
			--exec SpConsultaVentas 0  
			--exec SpConsultaVentas 0 ,''20160718'' 
			--exec SpConsultaVentas 0 ,''20160717'',''20160723''
			
			select 
				VentaID,
				NumeroVentaDia,
				Servicio ServicioProducto,
				CodigoServicio CodigoServicioProducto,
				CodigoTrabajoServicio Baucher,
				CantidadServicio CantidadServicioProducto,
				ValorVentaServicio*CantidadServicio ValorVenta,
				ValorVentaServicio ValorServicioProducto,
				VentaServicioID,
				((ValorVentaServicio-sum(ValorVentaXUnidad*CantidadProducto))*(convert(float,1)-(PorcentajeEstilista/convert(float,100))))*CantidadServicio +
				sum((ValorVentaXUnidad-ValorxUnidad)*CantidadProducto)*CantidadServicio Utilidad,	
				sum(ValorVentaXUnidad*CantidadProducto)*CantidadServicio ValorProducto,
				sum((ValorVentaXUnidad-ValorxUnidad)*CantidadProducto)*CantidadServicio UtilidadProducto,
				((ValorVentaServicio-sum(ValorVentaXUnidad*CantidadProducto))*(PorcentajeEstilista/convert(float,100)))*CantidadServicio Nomina,
				Interna,
				Fecha
				into #venta
			from #Reporte
			where Activo=1 and ServicioID>0
			group by VentaID, NumeroVentaDia,ServicioID,Servicio,CodigoServicio,CodigoTrabajoServicio,CantidadServicio,VentaServicioID,PorcentajeEstilista,
			ValorVentaServicio,Interna,Fecha

			union

			select 
				VentaID,
				NumeroVentaDia,
				Producto ServicioProducto,
				CodigoProducto CodigoServicioProducto,
				CodigoTrabajoProducto Baucher,
				CantidadProducto CantidadServicioProducto,
				case when Interna=0 then ValorVentaXUnidad*CantidadProducto 
					else (ValorVentaXUnidad*(convert(float,1)-(DescuentoVentaInterna/convert(float,100))))*CantidadProducto end ValorVenta,
				ValorVentaXUnidad ValorServicioProducto,
				VentaServicioID,
				case when Interna=0 
					then ((ValorVentaXUnidad*(convert(float,1)-(PorcentajeVentaPublico/(convert(float,100)))))-ValorxUnidad)*CantidadProducto 
						+ (ValorVentaXUnidad-ValorxUnidad)*CantidadProducto
					else ((ValorVentaXUnidad*(convert(float,1)-(DescuentoVentaInterna/convert(float,100))))-ValorxUnidad)*CantidadProducto end Utilidad,	
				ValorxUnidad*CantidadProducto ValorProducto,
				(ValorVentaXUnidad-ValorxUnidad)*CantidadProducto UtilidadProducto,
				case when Interna=0 then (ValorVentaXUnidad*((PorcentajeVentaPublico/(convert(float,100)))))*CantidadProducto
					else 0 end Nomina,
				Interna,
				Fecha
			from #Reporte
			where Activo=1 and ServicioID=0 --and ProductoID>0
			group by VentaID, NumeroVentaDia,ProductoID,Producto,CodigoProducto,CodigoTrabajoProducto,CantidadProducto,VentaServicioID,PorcentajeVentaPublico,
			DescuentoVentaInterna,ValorxUnidad,ValorVentaXUnidad,Interna,Fecha


			select 
				VentaID,NumeroVentaDia,
				convert(int,sum(ValorVenta)) ValorVenta,
				convert(int,SUM(Utilidad)) Utilidad,	
				convert(int,SUM(ValorProducto)) ValorProducto,
				convert(int,SUM(UtilidadProducto)) UtilidadProducto,
				convert(int,SUM(Nomina)) Nomina,
				sum(isnull(g.ValorGasto,0)) Compras,
				Fecha
			from #venta v
			left join Tbl_Gasto g on v.Fecha=convert(varchar(8),g.FechaModifica,112) and g.Activo=1
			group by VentaID,NumeroVentaDia,Fecha

			select * from #venta

			select
				isnull(sum(ValorVenta),0) VentaTotal,
				isnull(sum(Utilidad),0) Utilidad,
				isnull(sum(isnull(g.ValorGasto,0)),0) Compras,
				isnull(sum(Utilidad),0)-isnull(sum(isnull(g.ValorGasto,0)),0) UtilidadTotal 
			from #venta v
			left join Tbl_Gasto g on v.Fecha=convert(varchar(8),g.FechaModifica,112) and g.Activo=1
			--select * from #Reporte
		END
		ELSE
		BEGIN

			
			IF( @TipoReporte=1)	--Consulta del  Valor de Nomina del día  
			BEGIN

				--exec SpConsultaVentas 1  
				--exec SpConsultaVentas 1 ,''20160718'' 
				--exec SpConsultaVentas 1 ,''20160717'',''20160728''

				select 
					VentaID,
					NumeroVentaDia,
					UsuarioServicio Estilista,
					Servicio ServicioProducto,
					CodigoServicio CodigoServicioProducto,
					CodigoTrabajoServicio Baucher,
					CantidadServicio CantidadServicioProducto,
					ValorVentaServicio*CantidadServicio ValorVenta,
					ValorVentaServicio ValorServicioProducto,
					VentaServicioID,
					((ValorVentaServicio-sum(ValorVentaXUnidad*CantidadProducto))*(convert(float,1)-(PorcentajeEstilista/convert(float,100))))*CantidadServicio +
					sum((ValorVentaXUnidad-ValorxUnidad)*CantidadProducto)*CantidadServicio Utilidad,	
					sum(ValorVentaXUnidad*CantidadProducto)*CantidadServicio ValorProducto,
					sum((ValorVentaXUnidad-ValorxUnidad)*CantidadProducto)*CantidadServicio UtilidadProducto,
					((ValorVentaServicio-sum(ValorVentaXUnidad*CantidadProducto))*(PorcentajeEstilista/convert(float,100)))*CantidadServicio Nomina,
					Interna,
					Fecha
					into #Nomina
				from #Reporte
				where Activo=1 and ServicioID>0 and UsuarioServicioID>0
				group by VentaID, NumeroVentaDia,ServicioID,Servicio,CodigoServicio,CodigoTrabajoServicio,CantidadServicio,VentaServicioID,PorcentajeEstilista,
				ValorVentaServicio,Interna,Fecha,UsuarioServicio

				union

				select 
					VentaID,
					NumeroVentaDia,
					UsuarioProducto Estilista,
					Producto ServicioProducto,
					CodigoProducto CodigoServicioProducto,
					CodigoTrabajoProducto Baucher,
					CantidadProducto CantidadServicioProducto,
					case when Interna=0 then ValorVentaXUnidad*CantidadProducto 
						else (ValorVentaXUnidad*(convert(float,1)-(DescuentoVentaInterna/convert(float,100))))*CantidadProducto end ValorVenta,
					ValorVentaXUnidad ValorServicioProducto,
					VentaServicioID,
					case when Interna=0 
						then ((ValorVentaXUnidad*(convert(float,1)-(PorcentajeVentaPublico/(convert(float,100)))))-ValorxUnidad)*CantidadProducto 
							+ (ValorVentaXUnidad-ValorxUnidad)*CantidadProducto
						else ((ValorVentaXUnidad*(convert(float,1)-(DescuentoVentaInterna/convert(float,100))))-ValorxUnidad)*CantidadProducto end Utilidad,	
					ValorxUnidad*CantidadProducto ValorProducto,
					(ValorVentaXUnidad-ValorxUnidad)*CantidadProducto UtilidadProducto,
					case when Interna=0 then (ValorVentaXUnidad*((PorcentajeVentaPublico/(convert(float,100)))))*CantidadProducto
						else 0 end Nomina,
					Interna,
					Fecha
				from #Reporte
				where Activo=1 and ServicioID=0 and UsuarioProductoID>0 and Interna=0
				group by VentaID, NumeroVentaDia,ProductoID,Producto,CodigoProducto,CodigoTrabajoProducto,CantidadProducto,VentaServicioID,PorcentajeVentaPublico,
				DescuentoVentaInterna,ValorxUnidad,ValorVentaXUnidad,Interna,Fecha,UsuarioProducto

				select * from #Nomina

				select 
					Estilista,
					sum(CantidadServicioProducto) CantidadServicioProducto,
					sum(Nomina) Nomina,
					sum(ISNULL(g.ValorAdelantoInsentivo,0)) Adelanto,
					sum(ISNULL(g1.ValorAdelantoInsentivo,0)) Insentivo,
					Fecha
				from #Nomina v
				left join Tbl_AdelantoInsentivo g on v.Fecha=convert(varchar(8),g.FechaModifica,112) and g.Activo=1 and g.Adelanto=1
				left join Tbl_AdelantoInsentivo g1 on v.Fecha=convert(varchar(8),g1.FechaModifica,112) and g1.Activo=1 and g1.Adelanto=0
				group by Estilista,Fecha

				select 
					Estilista,
					sum(Nomina) NominaTotal,
					isnull(sum(ISNULL(g.ValorAdelantoInsentivo,0)),0) AdelantoTotal,
					isnull(sum(ISNULL(g1.ValorAdelantoInsentivo,0)),0) InsentivoTotal
				from #Nomina v
				left join Tbl_AdelantoInsentivo g on v.Fecha=convert(varchar(8),g.FechaModifica,112) and g.Activo=1 and g.Adelanto=1
				left join Tbl_AdelantoInsentivo g1 on v.Fecha=convert(varchar(8),g1.FechaModifica,112) and g1.Activo=1 and g1.Adelanto=0
				group by Estilista
				
				--select * from #Reporte where ServicioID>0
			END

		END
		
		--select * from #Reporte

	END TRY  
  
  
	BEGIN CATCH  
  
		select 0 Resultado, CONVERT(varchar(max),ERROR_MESSAGE())+''      
		Error en la linea: ''+CONVERT(varchar(max),ERROR_LINE()) Mensaje  
  
	END CATCH 

END



' 
END
GO
/****** Object:  StoredProcedure [dbo].[SpCreaAdelantoInsentivo]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpCreaAdelantoInsentivo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		WILINTON BAQUERO
-- Create date: 2016-08-18
-- Modificate date: 2016-09-04
-- =============================================
CREATE PROCEDURE [dbo].[SpCreaAdelantoInsentivo]
	@AdelantoInsentivoID int,@UsuarioAdelantoInsentivoID int, @ValorAdelantoInsentivo int,@Adelanto bit, @Activo bit, @UsuarioCreaID int
AS
BEGIN

	BEGIN TRY 

		--exec SpCreaAdelantoInsentivo 0,3,999000,1,1,1
		--exec SpCreaAdelantoInsentivo 0,3,888000,0,1,1

		declare @Mensaje varchar(max)='''',@XmlInicial varchar(max),@XmlFinal varchar(max),@InventarioID int
		declare @AdelantoInsentivo table (AdelantoInsentivoID int,UsuarioAdelantoInsentivoID int,ValorAdelantoInsentivo int,Adelanto bit,Activo bit,UsuarioCreaID int,
		UsuarioModificaID int,FechaCrea datetime,FechaModifica datetime)

		declare @tabla table(Resultado int, Mensaje varchar(max),AuditoriaID int)
		
		insert into @AdelantoInsentivo(UsuarioAdelantoInsentivoID,ValorAdelantoInsentivo,Adelanto,Activo , UsuarioCreaID ,FechaCrea,UsuarioModificaID,FechaModifica  )
		values(@UsuarioAdelantoInsentivoID,@ValorAdelantoInsentivo,@Adelanto,@Activo , @UsuarioCreaID ,GETDATE(),@UsuarioCreaID ,GETDATE())

		set @XmlFinal=convert(varchar(max),
		(select 
			isnull(AdelantoInsentivoID,0) AdelantoInsentivoID,
			isnull(UsuarioAdelantoInsentivoID,0) UsuarioAdelantoInsentivoID,
			isnull(ValorAdelantoInsentivo,0) ValorAdelantoInsentivo,
			isnull(Adelanto,0) Adelanto,
			isnull(Activo,0) Activo,
			isnull(UsuarioCreaID,0) UsuarioCreaID,
			isnull(UsuarioModificaID,0) UsuarioModificaID,
			isnull(FechaCrea,'''') FechaCrea,
			isnull(FechaModifica,'''') FechaModifica 
		from @AdelantoInsentivo for xml raw,elements))

		delete from @tabla

		insert into @tabla
		exec SpInsertaAuditoria @UsuarioCreaID,''Tbl_AdelantoInsentivo'','''',@UsuarioCreaID,@XmlFinal,1,@XmlInicial

		IF(select Resultado from @tabla)=1
		BEGIN

			insert into Tbl_AdelantoInsentivo (UsuarioAdelantoInsentivoID,ValorAdelantoInsentivo,Adelanto ,Activo , UsuarioCreaID ,FechaCrea,UsuarioModificaID,FechaModifica)
			values(@UsuarioAdelantoInsentivoID,@ValorAdelantoInsentivo,@Adelanto,@Activo , @UsuarioCreaID ,GETDATE(),@UsuarioCreaID ,GETDATE())

			set @AdelantoInsentivoID=SCOPE_IDENTITY()

			update Tbl_Auditoria set IdTabla = @AdelantoInsentivoID where AuditoriaID = (select  AuditoriaID from @tabla)

			select 1 Resultado, ''Adelanto/Insentivo correctamente creado.'' Mensaje

		END
		ELSE
		BEGIN
					
			select Resultado, Mensaje from @tabla

		END

		
		 
	END TRY  
  
  
	BEGIN CATCH  
  
		select 0 Resultado, CONVERT(varchar(max),ERROR_MESSAGE())+''      
		Error en la linea: ''+CONVERT(varchar(max),ERROR_LINE()) Mensaje  
  
	END CATCH 

END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[SpCreaCliente]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpCreaCliente]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		WILINTON BAQUERO
-- Create date: 2016-08-18
-- =============================================
CREATE PROCEDURE [dbo].[SpCreaCliente]
	@ClienteID int, @Nombre varchar(100), @Correo varchar(150), @Telefono varchar(100), @Activo bit, @UsuarioCreaID int
AS
BEGIN

	BEGIN TRY 

		--exec SpCreaCliente 0,''Carlos Mora'',1,1

		declare @Mensaje varchar(max)='''',@XmlInicial varchar(max),@XmlFinal varchar(max),@InventarioID int
		declare @Cliente table (ClienteID int,Nombre varchar(100),Correo varchar(150), Telefono varchar(100),Activo bit,UsuarioCreaID int,
		UsuarioModificaID int,FechaCrea datetime,FechaModifica datetime)

		declare @tabla table(Resultado int, Mensaje varchar(max),AuditoriaID int)
		
		IF NOT EXISTS (select * from Tbl_Cliente where LTRIM(RTRIM(REPLACE(Nombre,''  '','' '')))=LTRIM(RTRIM(REPLACE(@Nombre,''  '','' ''))))
		BEGIN

			insert into @Cliente(Nombre,Correo,Telefono ,Activo , UsuarioCreaID ,FechaCrea  )
			values(LTRIM(RTRIM(REPLACE(@Nombre,''  '','' ''))) ,@Correo, @Telefono,@Activo , @UsuarioCreaID ,GETDATE())

			set @XmlFinal=convert(varchar(max),
			(select 
				isnull(ClienteID,0) ClienteID,
				isnull(Nombre,'''') Nombre,
				isnull(Correo,'''') Correo,
				isnull(Telefono,'''') Telefono,
				isnull(Activo,0) Activo,
				isnull(UsuarioCreaID,0) UsuarioCreaID,
				isnull(UsuarioModificaID,0) UsuarioModificaID,
				isnull(FechaCrea,'''') FechaCrea,
				isnull(FechaModifica,'''') FechaModifica 
			from @Cliente for xml raw,elements))

			delete from @tabla

			insert into @tabla
			exec SpInsertaAuditoria @UsuarioCreaID,''Tbl_Cliente'','''',@UsuarioCreaID,@XmlFinal,1,@XmlInicial

			IF(select Resultado from @tabla)=1
			BEGIN

				insert into Tbl_Cliente (Nombre ,Correo,Telefono ,Activo , UsuarioCreaID ,FechaCrea)
				values(LTRIM(RTRIM(REPLACE(@Nombre,''  '','' ''))) ,@Correo, @Telefono ,@Activo , @UsuarioCreaID ,GETDATE())

				set @ClienteID=SCOPE_IDENTITY()

				update Tbl_Auditoria set IdTabla = @ClienteID where AuditoriaID = (select  AuditoriaID from @tabla)

				select 1 Resultado, ''Cliente correctamente creado.'' Mensaje

			END
			ELSE
			BEGIN
					
				select Resultado, Mensaje from @tabla

			END

		END
		ELSE
		BEGIN

			select 0 Resultado, ''Ya existe un Cliente con el mismo nombre.'' Mensaje

		END
		 
	END TRY  
  
  
	BEGIN CATCH  
  
		select 0 Resultado, CONVERT(varchar(max),ERROR_MESSAGE())+''      
		Error en la linea: ''+CONVERT(varchar(max),ERROR_LINE()) Mensaje  
  
	END CATCH 

END





' 
END
GO
/****** Object:  StoredProcedure [dbo].[SpCreaDeposito]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpCreaDeposito]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		WILINTON BAQUERO
-- Create date: 2016-08-18
-- Modifcate date: 2016-09-04
-- =============================================
CREATE PROCEDURE [dbo].[SpCreaDeposito]
	@DepositoID int, @ValorDeposito int, @Activo bit, @UsuarioCreaID int
AS
BEGIN

	BEGIN TRY 

		--exec SpCreaDeposito 0,725000,1,1

		declare @Mensaje varchar(max)='''',@XmlInicial varchar(max),@XmlFinal varchar(max),@InventarioID int
		declare @Deposito table (DepositoID int,ValorDeposito int,Activo bit,UsuarioCreaID int,
		UsuarioModificaID int,FechaCrea datetime,FechaModifica datetime)

		declare @tabla table(Resultado int, Mensaje varchar(max),AuditoriaID int)
		
		

		insert into @Deposito(ValorDeposito,Activo , UsuarioCreaID ,FechaCrea,UsuarioModificaID,FechaModifica  )
		values(@ValorDeposito,@Activo , @UsuarioCreaID ,GETDATE(),@UsuarioCreaID ,GETDATE())

		set @XmlFinal=convert(varchar(max),
		(select 
			isnull(DepositoID,0) DepositoID,
			isnull(ValorDeposito,0) ValorDeposito,
			isnull(Activo,0) Activo,
			isnull(UsuarioCreaID,0) UsuarioCreaID,
			isnull(UsuarioModificaID,0) UsuarioModificaID,
			isnull(FechaCrea,'''') FechaCrea,
			isnull(FechaModifica,'''') FechaModifica 
		from @Deposito for xml raw,elements))

		delete from @tabla

		insert into @tabla
		exec SpInsertaAuditoria @UsuarioCreaID,''Tbl_Deposito'','''',@UsuarioCreaID,@XmlFinal,1,@XmlInicial

		IF(select Resultado from @tabla)=1
		BEGIN

			insert into Tbl_Deposito (ValorDeposito ,Activo , UsuarioCreaID ,FechaCrea,UsuarioModificaID,FechaModifica)
			values(@ValorDeposito,@Activo , @UsuarioCreaID ,GETDATE(),@UsuarioCreaID ,GETDATE())

			set @DepositoID=SCOPE_IDENTITY()

			update Tbl_Auditoria set IdTabla = @DepositoID where AuditoriaID = (select  AuditoriaID from @tabla)

			select 1 Resultado, ''Deposito correctamente creado.'' Mensaje

		END
		ELSE
		BEGIN
					
			select Resultado, Mensaje from @tabla

		END

		
		 
	END TRY  
  
  
	BEGIN CATCH  
  
		select 0 Resultado, CONVERT(varchar(max),ERROR_MESSAGE())+''      
		Error en la linea: ''+CONVERT(varchar(max),ERROR_LINE()) Mensaje  
  
	END CATCH 

END






' 
END
GO
/****** Object:  StoredProcedure [dbo].[SpCreaGasto]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpCreaGasto]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		WILINTON BAQUERO
-- Create date: 2016-08-19
-- Modificate date: 2016-09-04
-- =============================================
CREATE PROCEDURE [dbo].[SpCreaGasto]
	@GastoID int,@Detalle varchar(300), @ValorGasto int, @Activo bit, @UsuarioCreaID int
AS
BEGIN

	BEGIN TRY 

		--exec SpCreaGasto 0,''Compra de bebidas para los clientes.'',725000,1,1

		declare @Mensaje varchar(max)='''',@XmlInicial varchar(max),@XmlFinal varchar(max),@InventarioID int
		declare @Gasto table (GastoID int,Detalle varchar(300),ValorGasto int,Activo bit,UsuarioCreaID int,
		UsuarioModificaID int,FechaCrea datetime,FechaModifica datetime)

		declare @tabla table(Resultado int, Mensaje varchar(max),AuditoriaID int)
		
		

		insert into @Gasto(Detalle,ValorGasto,Activo , UsuarioCreaID ,FechaCrea,UsuarioModificaID,FechaModifica)
		values(@Detalle,@ValorGasto,@Activo , @UsuarioCreaID ,GETDATE(), @UsuarioCreaID ,GETDATE())

		set @XmlFinal=convert(varchar(max),
		(select 
			isnull(GastoID,0) GastoID,
			isnull(Detalle,'''') Detalle,
			isnull(ValorGasto,0) ValorGasto,
			isnull(Activo,0) Activo,
			isnull(UsuarioCreaID,0) UsuarioCreaID,
			isnull(UsuarioModificaID,0) UsuarioModificaID,
			isnull(FechaCrea,'''') FechaCrea,
			isnull(FechaModifica,'''') FechaModifica 
		from @Gasto for xml raw,elements))

		delete from @tabla

		insert into @tabla
		exec SpInsertaAuditoria @UsuarioCreaID,''Tbl_Gasto'','''',@UsuarioCreaID,@XmlFinal,1,@XmlInicial

		IF(select Resultado from @tabla)=1
		BEGIN

			insert into Tbl_Gasto (Detalle,ValorGasto ,Activo , UsuarioCreaID ,FechaCrea,UsuarioModificaID,FechaModifica)
			values(@Detalle,@ValorGasto,@Activo , @UsuarioCreaID ,GETDATE(), @UsuarioCreaID ,GETDATE())

			set @GastoID=SCOPE_IDENTITY()

			update Tbl_Auditoria set IdTabla = @GastoID where AuditoriaID = (select  AuditoriaID from @tabla)

			select 1 Resultado, ''Gasto correctamente creado.'' Mensaje

		END
		ELSE
		BEGIN
					
			select Resultado, Mensaje from @tabla

		END

		
		 
	END TRY  
  
  
	BEGIN CATCH  
  
		select 0 Resultado, CONVERT(varchar(max),ERROR_MESSAGE())+''      
		Error en la linea: ''+CONVERT(varchar(max),ERROR_LINE()) Mensaje  
  
	END CATCH 

END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[SpCreaInventario]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpCreaInventario]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		WILINTON BAQUERO
-- Create date: 2016-08-03
-- =============================================
CREATE PROCEDURE [dbo].[SpCreaInventario]
	@ProductoID int,@CantidadUnidad int,@UsuarioID int, @return bit=0
AS
BEGIN

	BEGIN TRY 

		--exec SpCreaInventario 16,5,1,1

		declare @Mensaje varchar(max)='''',@XmlInicial varchar(max),@XmlFinal varchar(max),@InventarioID int
		declare @inventario table (InventarioID int,ProductoID int,CantidadUnidad int,UsuarioID int,FechaModifica datetime)
		declare @tabla table(Resultado int, Mensaje varchar(max),AuditoriaID int)
		
		insert into @inventario(InventarioID ,ProductoID ,CantidadUnidad ,UsuarioID ,FechaModifica )
		values(0, @ProductoID ,@CantidadUnidad ,@UsuarioID,GETDATE() )

		set @XmlFinal=convert(varchar(max),
		(select 
			isnull(InventarioID,0) InventarioID,
			isnull(ProductoID,0) ProductoID,
			isnull(CantidadUnidad,0) CantidadUnidad,
			isnull(UsuarioID,0) UsuarioID,
			isnull(FechaModifica,'''') FechaModifica 
		from @inventario for xml raw,elements))
				
		insert into @tabla
		exec SpInsertaAuditoria @UsuarioID,''Tbl_Inventario'','''',0,@XmlFinal,1,@XmlInicial
				
		IF(select Resultado from @tabla)=1
		BEGIN

			insert into Tbl_Inventario(ProductoID ,CantidadUnidad ,UsuarioID ,FechaModifica )
			values( @ProductoID ,@CantidadUnidad ,@UsuarioID,GETDATE() )

			set @InventarioID=SCOPE_IDENTITY()

			update Tbl_Auditoria set IdTabla = @InventarioID where AuditoriaID = (select  AuditoriaID from @tabla)

			IF( @return=1 )
			BEGIN

				select 1 Resultado, ''Inventario correctamente creado.'' Mensaje 

			END

		END
		ELSE
		BEGIN
					
			select Resultado, Mensaje from @tabla

		END
		
		 
	END TRY  
  
  
	BEGIN CATCH  
  
		select 0 Resultado, CONVERT(varchar(max),ERROR_MESSAGE())+''      
		Error en la linea: ''+CONVERT(varchar(max),ERROR_LINE()) Mensaje  
  
	END CATCH 

END



' 
END
GO
/****** Object:  StoredProcedure [dbo].[SpCreaPagoFactura]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpCreaPagoFactura]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		WILINTON BAQUERO
-- Create date: 2016-08-19
-- Modifica date: 2016-09-04
-- =============================================
CREATE PROCEDURE [dbo].[SpCreaPagoFactura]
	@PagoFacturaID int,@ProveedorID int,@NumeroFactura varchar(20), @ValorPagoFactura int, @Activo bit, @UsuarioCreaID int
AS
BEGIN

	BEGIN TRY 

		--exec SpCreaPagoFactura 0,1,''5465454Q'',725000,1,1

		declare @Mensaje varchar(max)='''',@XmlInicial varchar(max),@XmlFinal varchar(max),@InventarioID int
		declare @PagoFactura table (PagoFacturaID int,ProveedorID int,NumeroFactura varchar(20),ValorPagoFactura int,Activo bit,UsuarioCreaID int,
		UsuarioModificaID int,FechaCrea datetime,FechaModifica datetime)

		declare @tabla table(Resultado int, Mensaje varchar(max),AuditoriaID int)
		
		

		insert into @PagoFactura(ProveedorID,NumeroFactura,ValorPagoFactura,Activo , UsuarioCreaID ,FechaCrea,UsuarioModificaID,FechaModifica)
		values(@ProveedorID,@NumeroFactura,@ValorPagoFactura,@Activo , @UsuarioCreaID ,GETDATE(),@UsuarioCreaID ,GETDATE())

		set @XmlFinal=convert(varchar(max),
		(select 
			isnull(PagoFacturaID,0) PagoFacturaID,
			isnull(ProveedorID,0) ProveedorID,
			isnull(NumeroFactura,'''') NumeroFactura,
			isnull(ValorPagoFactura,0) ValorPagoFactura,
			isnull(Activo,0) Activo,
			isnull(UsuarioCreaID,0) UsuarioCreaID,
			isnull(UsuarioModificaID,0) UsuarioModificaID,
			isnull(FechaCrea,'''') FechaCrea,
			isnull(FechaModifica,'''') FechaModifica 
		from @PagoFactura for xml raw,elements))

		delete from @tabla

		insert into @tabla
		exec SpInsertaAuditoria @UsuarioCreaID,''Tbl_PagoFactura'','''',@UsuarioCreaID,@XmlFinal,1,@XmlInicial

		IF(select Resultado from @tabla)=1
		BEGIN

			insert into Tbl_PagoFactura (ProveedorID,NumeroFactura,ValorPagoFactura ,Activo , UsuarioCreaID ,FechaCrea,UsuarioModificaID,FechaModifica)
			values(@ProveedorID,@NumeroFactura,@ValorPagoFactura,@Activo , @UsuarioCreaID ,GETDATE(),@UsuarioCreaID ,GETDATE())

			set @PagoFacturaID=SCOPE_IDENTITY()

			update Tbl_Auditoria set IdTabla = @PagoFacturaID where AuditoriaID = (select  AuditoriaID from @tabla)

			select 1 Resultado, ''Pago de Factura correctamente creado.'' Mensaje

		END
		ELSE
		BEGIN
					
			select Resultado, Mensaje from @tabla

		END

		
		 
	END TRY  
  
  
	BEGIN CATCH  
  
		select 0 Resultado, CONVERT(varchar(max),ERROR_MESSAGE())+''      
		Error en la linea: ''+CONVERT(varchar(max),ERROR_LINE()) Mensaje  
  
	END CATCH 

END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[SpCreaProducto]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpCreaProducto]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		WILINTON BAQUERO
-- Create date: 2016-07-12
-- Modificate date: 2016-09-04
-- =============================================
CREATE PROCEDURE [dbo].[SpCreaProducto]
	@ProductoID int, @Nombre varchar(100),@UnidadxProducto int, @ValorCompra int,@ValorVentaXUnidad int, @PorcentajeVentaPublico int, @DescuentoVentaInterna int,
	@Insumo bit,@CodigoProducto varchar(5),@Activo bit, @UsuarioCreaID int,@ProveedorID int=0
AS
BEGIN

	BEGIN TRY 

		--exec SpCreaProducto 0,''Producto 1'',10,10000,1200,20,10,0,''Pro1'',1,1

		declare @Mensaje varchar(max)='''',@XmlInicial varchar(max),@XmlFinal varchar(max),@InventarioID int
		declare @producto table (ProductoID int,Nombre varchar(100),ProveedorID int,UnidadxProducto int,ValorCompra int,ValorVentaXUnidad int,
						PorcentajeVentaPublico int, DescuentoVentaInterna int,Insumo bit,CodigoProducto varchar(5),Activo bit,
						UsuarioCreaID int,UsuarioModificaID int,FechaCrea datetime,FechaModifica datetime)

		declare @inventario table (InventarioID int,ProductoID int,CantidadUnidad int,UsuarioID int,FechaModifica datetime)

		declare @tabla table(Resultado int, Mensaje varchar(max),AuditoriaID int)
		
		IF NOT EXISTS (select * from Tbl_Producto 
						where LTRIM(RTRIM(REPLACE(Nombre,''  '','' '')))=LTRIM(RTRIM(REPLACE(@Nombre,''  '','' '')))
							or LTRIM(RTRIM(REPLACE(CodigoProducto,''  '','' '')))=LTRIM(RTRIM(REPLACE(@CodigoProducto,''  '','' ''))))
		BEGIN

			insert into @producto(Nombre,ProveedorID ,UnidadxProducto ,ValorCompra ,ValorVentaXUnidad ,PorcentajeVentaPublico, DescuentoVentaInterna,Insumo,
								CodigoProducto,Activo ,UsuarioCreaID ,FechaCrea  )
			values(LTRIM(RTRIM(REPLACE(@Nombre,''  '','' ''))),@ProveedorID ,@UnidadxProducto ,@ValorCompra ,@ValorVentaXUnidad,@PorcentajeVentaPublico, @DescuentoVentaInterna,
			@Insumo,@CodigoProducto,@Activo , @UsuarioCreaID ,GETDATE())

			set @XmlFinal=convert(varchar(max),
			(select 
				isnull(ProductoID,0) ProductoID,
				isnull(Nombre,'''') Nombre,
				isnull(ProveedorID,0) ProveedorID,
				isnull(UnidadxProducto,0) UnidadxProducto,
				isnull(ValorCompra,0) ValorCompra,
				isnull(ValorVentaXUnidad,0) ValorVentaXUnidad,
				isnull(PorcentajeVentaPublico,0) PorcentajeVentaPublico,
				isnull(DescuentoVentaInterna,0) DescuentoVentaInterna,
				isnull(Insumo,0) Insumo,
				isnull(CodigoProducto,'''') CodigoProducto,
				isnull(Activo,0) Activo,
				isnull(UsuarioCreaID,0) UsuarioCreaID,
				isnull(UsuarioModificaID,0) UsuarioModificaID,
				isnull(FechaCrea,'''') FechaCrea,
				isnull(FechaModifica,'''') FechaModifica 
			from @producto for xml raw,elements))

			delete from @tabla

			insert into @tabla
			exec SpInsertaAuditoria @UsuarioCreaID,''Tbl_Producto'','''',@UsuarioCreaID,@XmlFinal,1,@XmlInicial

			IF(select Resultado from @tabla)=1
			BEGIN

				insert into Tbl_Producto (Nombre ,ProveedorID,UnidadxProducto ,ValorCompra ,ValorVentaXUnidad,PorcentajeVentaPublico, DescuentoVentaInterna,Insumo,
				CodigoProducto,Activo , UsuarioCreaID ,FechaCrea)
				values(LTRIM(RTRIM(REPLACE(@Nombre,''  '','' ''))),@ProveedorID,@UnidadxProducto ,@ValorCompra ,@ValorVentaXUnidad,@PorcentajeVentaPublico,
				@DescuentoVentaInterna,@Insumo,@CodigoProducto ,@Activo , @UsuarioCreaID ,GETDATE())

				set @ProductoID=SCOPE_IDENTITY()

				update Tbl_Auditoria set IdTabla = @ProductoID where AuditoriaID = (select  AuditoriaID from @tabla)

				exec SpCreaInventario @ProductoID,@UnidadxProducto,@UsuarioCreaID,0

				select 1 Resultado, ''Producto correctamente creado.'' Mensaje

			END
			ELSE
			BEGIN
					
				select Resultado, Mensaje from @tabla

			END

		END
		ELSE
		BEGIN

			select 0 Resultado, ''Ya existe un Producto con el mismo Nombre y/o Codigo.'' Mensaje

		END
		 
	END TRY  
  
  
	BEGIN CATCH  
  
		select 0 Resultado, CONVERT(varchar(max),ERROR_MESSAGE())+''      
		Error en la linea: ''+CONVERT(varchar(max),ERROR_LINE()) Mensaje  
  
	END CATCH 

END





' 
END
GO
/****** Object:  StoredProcedure [dbo].[SpCreaProveedor]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpCreaProveedor]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		WILINTON BAQUERO
-- Create date: 2016-08-18
-- =============================================
CREATE PROCEDURE [dbo].[SpCreaProveedor]
	@ProveedorID int, @Nombre varchar(100), @Activo bit, @UsuarioCreaID int
AS
BEGIN

	BEGIN TRY 

		--exec SpCreaProveedor 0,''Marcell France'',1,1

		declare @Mensaje varchar(max)='''',@XmlInicial varchar(max),@XmlFinal varchar(max),@InventarioID int
		declare @Proveedor table (ProveedorID int,Nombre varchar(100),Activo bit,UsuarioCreaID int,UsuarioModificaID int,FechaCrea datetime,FechaModifica datetime)

		declare @tabla table(Resultado int, Mensaje varchar(max),AuditoriaID int)
		
		IF NOT EXISTS (select * from Tbl_Proveedor where LTRIM(RTRIM(REPLACE(Nombre,''  '','' '')))=LTRIM(RTRIM(REPLACE(@Nombre,''  '','' ''))))
		BEGIN

			insert into @Proveedor(Nombre ,Activo , UsuarioCreaID ,FechaCrea  )
			values(LTRIM(RTRIM(REPLACE(@Nombre,''  '','' ''))) ,@Activo , @UsuarioCreaID ,GETDATE())

			set @XmlFinal=convert(varchar(max),
			(select 
				isnull(ProveedorID,0) ProveedorID,
				isnull(Nombre,'''') Nombre,
				isnull(Activo,0) Activo,
				isnull(UsuarioCreaID,0) UsuarioCreaID,
				isnull(UsuarioModificaID,0) UsuarioModificaID,
				isnull(FechaCrea,'''') FechaCrea,
				isnull(FechaModifica,'''') FechaModifica 
			from @Proveedor for xml raw,elements))

			delete from @tabla

			insert into @tabla
			exec SpInsertaAuditoria @UsuarioCreaID,''Tbl_Proveedor'','''',@UsuarioCreaID,@XmlFinal,1,@XmlInicial

			IF(select Resultado from @tabla)=1
			BEGIN

				insert into Tbl_Proveedor (Nombre ,Activo , UsuarioCreaID ,FechaCrea)
				values(LTRIM(RTRIM(REPLACE(@Nombre,''  '','' '')))  ,@Activo , @UsuarioCreaID ,GETDATE())

				set @ProveedorID=SCOPE_IDENTITY()

				update Tbl_Auditoria set IdTabla = @ProveedorID where AuditoriaID = (select  AuditoriaID from @tabla)

				select 1 Resultado, ''Proveedor correctamente creado.'' Mensaje

			END
			ELSE
			BEGIN
					
				select Resultado, Mensaje from @tabla

			END

		END
		ELSE
		BEGIN

			select 0 Resultado, ''Ya existe un Proveedor con el mismo nombre.'' Mensaje

		END
		 
	END TRY  
  
  
	BEGIN CATCH  
  
		select 0 Resultado, CONVERT(varchar(max),ERROR_MESSAGE())+''      
		Error en la linea: ''+CONVERT(varchar(max),ERROR_LINE()) Mensaje  
  
	END CATCH 

END




' 
END
GO
/****** Object:  StoredProcedure [dbo].[SpCreaServicio]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpCreaServicio]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		WILINTON BAQUERO
-- Create date: 2016-07-12
-- Modificate date: 2016-08-27
-- =============================================
CREATE PROCEDURE [dbo].[SpCreaServicio]
	@ServicioID int,@Nombre varchar(200),@ValorVenta int,@PorcentajeEstilista smallint,@CodigoServicio varchar(5),@Variable bit,@Activo bit,@UsuarioCreaID int
AS
BEGIN

	BEGIN TRY 

		--exec SpCreaServicio 0,''Servicio 1'',10000,60,''Ser1'',0,1,1

		declare @Mensaje varchar(max)='''',@XmlInicial varchar(max),@XmlFinal varchar(max),@ProductoID int
		declare @Servicio table (ServicioID	int,Nombre varchar(200),ValorVenta int,PorcentajeEstilista smallint,CodigoServicio varchar(5),Variable bit,
								Activo bit,UsuarioCreaID int,UsuarioModificaID int,FechaCrea datetime,FechaModifica datetime)
		declare @producto table (ProductoID int)
		declare @ServicioProducto table (ServicioProductoID int,ServicioID int,ProductoID int,UsuarioCreaID int,FechaCrea datetime)
		

		declare @tabla table(Resultado int, Mensaje varchar(max),AuditoriaID int)
		
		IF NOT EXISTS (select * from Tbl_Servicio where LTRIM(RTRIM(REPLACE(Nombre,''  '','' '')))=LTRIM(RTRIM(REPLACE(@Nombre,''  '','' ''))))
		BEGIN

			--IF convert(varchar(max) ,@XmlProducto)<>''''
			--BEGIN

			--	insert into @producto(ProductoID)
			--	select 
			--		fila.value(''ProductoID[1]'',''int'') ProductoID
			--	from @XmlProducto.nodes(''//row'') as T(fila)
			--END

			insert into @Servicio(Nombre,ValorVenta,PorcentajeEstilista,CodigoServicio,Variable,Activo,UsuarioCreaID,FechaCrea)
			values(LTRIM(RTRIM(REPLACE(@Nombre,''  '','' ''))) ,@ValorVenta,@PorcentajeEstilista,@CodigoServicio,@Variable,@Activo , @UsuarioCreaID ,
			GETDATE())

			set @XmlFinal=convert(varchar(max),
			(select 
				isnull(ServicioID,0) ServicioID,
				isnull(Nombre,'''') Nombre,
				isnull(ValorVenta,0) ValorVenta,
				isnull(PorcentajeEstilista,0) PorcentajeEstilista,
				isnull(CodigoServicio,'''') CodigoServicio,
				isnull(Variable,0) Variable,
				isnull(Activo,0) Activo,
				isnull(UsuarioCreaID,0) UsuarioCreaID,
				isnull(UsuarioModificaID,0) UsuarioModificaID,
				isnull(FechaCrea,'''') FechaCrea,
				isnull(FechaModifica,'''') FechaModifica 
			from @Servicio for xml raw,elements))

			delete from @tabla

			insert into @tabla
			exec SpInsertaAuditoria @UsuarioCreaID,''Tbl_Servicio'','''',@ServicioID,@XmlFinal,1,@XmlInicial

			IF(select Resultado from @tabla)=1
			BEGIN

				insert into Tbl_Servicio (Nombre ,ValorVenta,PorcentajeEstilista,CodigoServicio,Variable ,Activo , UsuarioCreaID ,FechaCrea)
				values(LTRIM(RTRIM(REPLACE(@Nombre,''  '','' ''))) ,@ValorVenta,@PorcentajeEstilista,@CodigoServicio,@Variable,@Activo ,
				 @UsuarioCreaID ,GETDATE())

				set @ServicioID= SCOPE_IDENTITY()

				update Tbl_Auditoria set IdTabla = @ServicioID where AuditoriaID = (select  AuditoriaID from @tabla)

				--IF (select count(*) from @producto)>0
				--BEGIN

				--	WHILE (select count(*) from @producto)>0
				--	BEGIN					

				--		select @ProductoID= min(ProductoID) from @producto

				--		insert into @ServicioProducto (ServicioID,ProductoID,UsuarioCreaID,FechaCrea)
				--		select @ServicioID,ProductoID,@UsuarioCreaID,GETDATE() from @producto where ProductoID=@ProductoID

				--		set @XmlFinal=convert(varchar(max),
				--		(select 
				--			isnull(ServicioID,0) ServicioID,
				--			isnull(ProductoID,0) ProductoID,
				--			isnull(UsuarioCreaID,0) UsuarioCreaID,
				--			isnull(FechaCrea,'''') FechaCrea
				--		from @ServicioProducto for xml raw,elements))

				--		delete from @tabla

				--		insert into @tabla
				--		exec SpInsertaAuditoria @UsuarioCreaID,''Tbl_ServicioProducto'','''',@ServicioID,@XmlFinal,1,@XmlInicial

				--		IF(select Resultado from @tabla)=1
				--		BEGIN

				--			insert into Tbl_ServicioProducto(ServicioID,ProductoID,UsuarioCreaID,FechaCrea)
				--			select @ServicioID,ProductoID,@UsuarioCreaID,GETDATE() from @producto where ProductoID=@ProductoID

				--			update Tbl_Auditoria set IdTabla = SCOPE_IDENTITY() where AuditoriaID = (select  AuditoriaID from @tabla)

				--		END

				--		delete from @producto where ProductoID=@ProductoID

				--	END

				--END

				select 1 Resultado, ''Servicio correctamente creado.'' Mensaje

			END
			ELSE
			BEGIN
					
				select Resultado, Mensaje from @tabla

			END

		END
		ELSE
		BEGIN

			select 0 Resultado, ''Ya existe un Servicio con el mismo nombre.'' Mensaje

		END
		 
	END TRY  
  
  
	BEGIN CATCH  
  
		select 0 Resultado, CONVERT(varchar(max),ERROR_MESSAGE())+''      
		Error en la linea: ''+CONVERT(varchar(max),ERROR_LINE()) Mensaje  
  
	END CATCH 

END



' 
END
GO
/****** Object:  StoredProcedure [dbo].[SpCreaUsuario]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpCreaUsuario]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'----------------------------------------------------------------------------------
-- =============================================
-- Author:		WILINTON BAQUERO
-- Create date: 2016-07-06
-- Modificate date: 2016-08-27
-- =============================================
CREATE PROCEDURE [dbo].[SpCreaUsuario]
	@UsuarioID int,@Nombre varchar(50), @Apellido varchar(50),@CodigoUsuario varchar(5),@NombreUsuario varchar(50),@Clave varchar(50),
	@Documento varchar(50),@Telefono varchar(50),@Direccion varchar(50),@RolID int,@Activo bit,@UsuarioCreaID int
AS
BEGIN

	BEGIN TRY  

		--exec SpCreaUsuario 0,''Administrador'',''Sistema'',''A1'',''Admin'',''Admin123*'','''','''','''',1,1,1
		--exec SpCreaUsuario 0,''Juan David'',''Calderon'',''G1'',''JCalderon'',''123*'','''','''','''',2,1,1

		declare @Mensaje varchar(max)='''',@XmlInicial varchar(max),@XmlFinal varchar(max)
		declare @usuario table(UsuarioID int,Nombre varchar(50),Apellido varchar(50),CodigoUsuario varchar(5),NombreUsuario varchar(50),Clave varchar(50),
							Documento varchar(50),
							Telefono varchar(20),Direccion varchar(200),RolID int,Activo bit,UsuarioCreaID int,FechaCrea datetime,UsuarioModificaID int,
							FechaModifica datetime)

		declare @tabla table(Resultado int, Mensaje varchar(max),AuditoriaID int)


		IF NOT EXISTS( select * from Tbl_Usuario where (Nombre=@Nombre and Apellido=@Apellido) or CodigoUsuario=@CodigoUsuario)
		BEGIN

			IF NOT EXISTS( select * from Tbl_Usuario where NombreUsuario=@NombreUsuario and NombreUsuario<>'''' )
			BEGIN

				insert into @usuario (Nombre,Apellido,CodigoUsuario,NombreUsuario,Clave,Documento,Telefono,Direccion,RolID,
				UsuarioCreaID,FechaCrea)
				values(@Nombre,@Apellido,@CodigoUsuario,@NombreUsuario,@Clave,@Documento,@Telefono,@Direccion,@RolID,
				@UsuarioCreaID,getdate())

				
				set @XmlFinal=convert(varchar(max),
				(select
					isnull(UsuarioID,0) UsuarioID,
					isnull(Nombre,'''') Nombre,
					isnull(Apellido,'''') Apellido,
					isnull(CodigoUsuario,'''') CodigoUsuario,
					isnull(NombreUsuario,'''') NombreUsuario,
					isnull(Clave,'''') Clave,
					isnull(Documento,'''') Documento,
					isnull(Telefono,'''') Telefono,
					isnull(Direccion,'''') Direccion,
					isnull(RolID,0) RolID,
					isnull(Activo,0) Activo,
					isnull(UsuarioCreaID,0) UsuarioCreaID,
					isnull(FechaCrea,'''') FechaCrea,
					isnull(UsuarioModificaID,0) UsuarioModificaID,
					isnull(FechaModifica,'''') FechaModifica
				from @usuario for xml raw, elements))

				delete from @tabla

				insert into @tabla
				exec SpInsertaAuditoria @UsuarioCreaID,''Tbl_Usuario'','''',@UsuarioID,@XmlFinal,1,@XmlInicial

				IF(select Resultado from @tabla)=1
				BEGIN

					insert into Tbl_Usuario (Nombre,Apellido,CodigoUsuario,NombreUsuario,Clave,Documento,Telefono,Direccion,RolID,Activo,
					UsuarioCreaID,FechaCrea)
					values(@Nombre,@Apellido,@CodigoUsuario,@NombreUsuario,@Clave,@Documento,@Telefono,@Direccion,@RolID,@Activo,
					@UsuarioCreaID,getdate())

					update Tbl_Auditoria set IdTabla = SCOPE_IDENTITY() where AuditoriaID = (select  AuditoriaID from @tabla)

					select 1 Resultado, ''Usuario correctamente creado.'' Mensaje

				END
				ELSE
				BEGIN
					
					select Resultado, Mensaje from @tabla

				END

			END
			ELSE
			BEGIN

				select 0 Resultado, ''Ya existe un Usuario con el mismo Nombre de Usuario.'' Mensaje

			END

		END
		ELSE
		BEGIN

			select 0 Resultado, ''Ya existe un Usuario con el mismo Nombre y/o Código.'' Mensaje

		END

	END TRY  
  
  
	BEGIN CATCH  
  
		select 0 Resultado, CONVERT(varchar(max),ERROR_MESSAGE())+''      
		Error en la linea: ''+CONVERT(varchar(max),ERROR_LINE()) Mensaje  
  
	END CATCH 

END



' 
END
GO
/****** Object:  StoredProcedure [dbo].[SpCreaVenta]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpCreaVenta]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		WILINTON BAQUERO
-- Create date: 2016-07-16
-- Modificate date: 2016-09-03
-- =============================================
CREATE PROCEDURE [dbo].[SpCreaVenta]
	@XmlVenta xml,@ValorTotal int,@UsuarioCreaID int,@Interna bit
AS
BEGIN

	BEGIN TRY 

		declare @inventario table (InventarioID int,ProductoID int,CantidadUnidad int,UsuarioID int,FechaModifica datetime)
		declare @inventario2 table (InventarioID int,ProductoID int,CantidadUnidad int,UsuarioID int,FechaModifica datetime)
		declare @venta table (VentaID int,ValorVenta int,UsuarioCreaID int,Fecha datetime,Interna bit, Activo bit,NumeroVentaDia int)
		declare @venta2 table (VentaID int,ValorVenta int,UsuarioCreaID int,Fecha datetime,Interna bit, Activo bit, NumeroVentaDia int)
		declare @XmlInical varchar(max),@XmlFinal varchar(max),@InventarioID int,@ProductoID int,@Cantidad int
		declare @tabla table(Resultado int, Mensaje varchar(max),AuditoriaID int)
		--declare @tabla2 table(Resultado int, Mensaje varchar(max))

		select
			fila.value(''ID[1]'',''int'') ID,
			fila.value(''CodigoTrabajo[1]'',''varchar(20)'') CodigoTrabajo,
			fila.value(''ServicioID[1]'',''int'') ServicioID,
			fila.value(''ProductoID[1]'',''int'') ProductoID,
			fila.value(''UsuarioID[1]'',''int'') UsuarioID,
			fila.value(''Cantidad[1]'',''int'') Cantidad,
			fila.value(''ValorVenta[1]'',''int'') ValorVenta
			into #venta
		from @XmlVenta.nodes(''//row'') as T(fila)

		select
			fila.value(''ID[1]'',''int'') ID,
			fila.value(''ServicioID[1]'',''int'') ServicioID,
			fila.value(''ProductoID[1]'',''int'') ProductoID,
			fila.value(''Cantidad[1]'',''int'') Cantidad
			into #ventaProd
		from @XmlVenta.nodes(''//row2'') as T(fila)

		insert into @venta(VentaID,ValorVenta,UsuarioCreaID,Fecha,Interna,Activo,NumeroVentaDia)
		values(0,@ValorTotal,@UsuarioCreaID,GETDATE(),@Interna,1,
		(select count(*)+1 from Tbl_Venta where convert(varchar(8),Fecha,112)=convert(varchar(8),GETDATE(),112)))

		set @XmlFinal=convert(varchar(max),
		(select 
			isnull(VentaID,0) VentaID,
			isnull(ValorVenta,0) ValorVenta,
			isnull(UsuarioCreaID,0) UsuarioCreaID,
			isnull(Fecha,'''') Fecha,
			isnull(Interna,0) Interna,
			isnull(Activo,0) Activo,
			isnull(NumeroVentaDia,0) NumeroVentaDia
		from @venta
		for xml raw, elements
		))

		insert into @tabla
		exec SpInsertaAuditoria @UsuarioCreaID,''Tbl_Venta'','''',0,@XmlFinal,1,''''
		
		IF (select Resultado from @tabla)=1 
		BEGIN

			insert into Tbl_Venta(ValorVenta,UsuarioCreaID,Fecha,Interna,Activo,NumeroVentaDia)
			values(@ValorTotal,@UsuarioCreaID,GETDATE(),@Interna,1,
			(select count(*)+1 from Tbl_Venta where convert(varchar(8),Fecha,112)=convert(varchar(8),GETDATE(),112))
			)

			declare @VentaID int,@XmlServicio varchar(max)='''',@XmlProducto varchar(max)='''',@ID int,@VentaServicioID int
			set @VentaID=SCOPE_IDENTITY()

			update Tbl_Auditoria set IdTabla = @VentaID where AuditoriaID = (select  AuditoriaID from @tabla)

			WHILE (select COUNT(*) from #venta)>0
			BEGIN

				select @ID=MIN(ID) from #venta

				set @VentaServicioID=0
				
				IF(select ServicioID from #venta where ID=@ID)>0
				BEGIN

					insert into Tbl_VentaServicio(VentaID,Cantidad,ServicioID,Nombre,ValorVenta,PorcentajeEstilista,CodigoServicio,CodigoTrabajo,UsuarioID)
					select @VentaID,v.Cantidad,s.ServicioID,s.Nombre,case when s.Variable=0 then s.ValorVenta else v.ValorVenta end,
					s.PorcentajeEstilista,s.CodigoServicio,v.CodigoTrabajo,v.UsuarioID 
					from Tbl_Servicio s 
					inner join #venta v on s.ServicioID=v.ServicioID
					where v.ID=@ID

					set @VentaServicioID=SCOPE_IDENTITY()

					IF (select COUNT(*) from #ventaProd where ID=@ID)>0
					BEGIN
						
						WHILE(select COUNT(*) from #ventaProd where ID=@ID)>0
						BEGIN

							select @ProductoID=min(ProductoID) from #ventaProd where ID=@ID

							insert into Tbl_VentaProducto(VentaID,VentaServicioID,Cantidad,ProductoID,Nombre,ValorxUnidad,ValorVentaXUnidad,PorcentajeVentaPublico,
							DescuentoVentaInterna,Insumo,CodigoProducto,UsuarioID)
							select @VentaID,@VentaServicioID,v.Cantidad,p.ProductoID,p.Nombre,
							case when p.UnidadxProducto>0 then (p.ValorCompra/p.UnidadxProducto) else p.ValorCompra end ,p.ValorVentaXUnidad,p.PorcentajeVentaPublico,
							p.DescuentoVentaInterna,p.Insumo,p.CodigoProducto,0
							from Tbl_Producto p 
							inner join #ventaProd v on p.ProductoID=v.ProductoID
							where v.ProductoID=@ProductoID

							select @ProductoID= x.ProductoID
								,@Cantidad=x.Cantidad*v.Cantidad
							from #ventaProd x
							inner join #venta v on x.ID=v.ID
							where x.ProductoID=@ProductoID

							exec SpModificaInventario @ProductoID,@Cantidad,@UsuarioCreaID,0

							delete from #ventaProd where ProductoID=@ProductoID

						END

					END

				END

				IF(select ProductoID from #venta where ID=@ID)>0
				BEGIN

					insert into Tbl_VentaProducto(VentaID,VentaServicioID,Cantidad,ProductoID,Nombre,ValorxUnidad,ValorVentaXUnidad,PorcentajeVentaPublico,
					DescuentoVentaInterna,Insumo,CodigoProducto,CodigoTrabajo,UsuarioID)
					select @VentaID,@VentaServicioID,v.Cantidad,p.ProductoID,p.Nombre,
					case when p.UnidadxProducto>0 then (p.ValorCompra/p.UnidadxProducto) else p.ValorCompra end ,p.ValorVentaXUnidad,p.PorcentajeVentaPublico,
					p.DescuentoVentaInterna,p.Insumo,p.CodigoProducto,v.CodigoTrabajo,case when v.ServicioID>0 then 0 else v.UsuarioID end
					from Tbl_Producto p 
					inner join #venta v on p.ProductoID=v.ProductoID
					where v.ID=@ID

					select @ProductoID= x.ProductoID
						,@Cantidad=x.Cantidad
					from #venta x
					where x.ID=@ID

					exec SpModificaInventario @ProductoID,@Cantidad,@UsuarioCreaID,0

				END

				delete from #venta where ID=@ID

			END 

			select 1 Resultado, ''Venta guardada con éxito'' Mensaje

			select @ProductoID,@Cantidad

		END
		ELSE
		BEGIN
					
			select Resultado, Mensaje from @tabla

		END

		

	END TRY  
  
  
	BEGIN CATCH  
  
		select 0 Resultado, CONVERT(varchar(max),ERROR_MESSAGE())+''      
		Error en la linea: ''+CONVERT(varchar(max),ERROR_LINE()) Mensaje  
  
	END CATCH 

END


' 
END
GO
/****** Object:  StoredProcedure [dbo].[SpInsertaAuditoria]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpInsertaAuditoria]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- ============================================================================
-- Author:		WILINTON BAQUERO	
-- Create date: 2016-07-06
-- ============================================================================
CREATE PROCEDURE [dbo].[SpInsertaAuditoria]
	@UsuarioID int, @NombreTabla varchar(max),@Campos varchar(max)='''',@IdTabla int=-1,@ValorFinal varchar(max)='''',@AccionRegistroID int,
	@ValorInicial varchar(max)=''''
AS
BEGIN
	SET NOCOUNT ON;

	--declare @ValorInicial varchar(max), 
	declare @campoid varchar(max), @id varchar(max),@IdAuditoria int
	declare @rta table (Valores varchar(max)) 
	declare @rta1 table (Valores varchar(max))

	/*2015-05-07*/
	--select @campoid= c.name 
	--from sys.all_columns c
	--inner join sys.tables t on c.object_id=t.object_id
	--where t.name=@NombreTabla and c.is_identity=1

	SELECT @campoid =isc.COLUMN_NAME 
	FROM INFORMATION_SCHEMA.COLUMNS AS isc 
	INNER JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE AS kcs ON isc.TABLE_NAME = kcs.TABLE_NAME AND isc.COLUMN_NAME = kcs.COLUMN_NAME 
	AND LEFT(kcs.CONSTRAINT_NAME, 2) = ''PK'' and isc.TABLE_NAME=@NombreTabla
	
	
	IF @AccionRegistroID<>1
	BEGIN
		declare @p varchar(max)=''''
		SELECT @p = @p + Campos + '';''
		FROM (select name Campos from sys.all_columns where object_id = (select object_id from sys.tables where name=@NombreTabla)) ff

		set @Campos = substring(@p,1,(len(@p)-1))
	END

	BEGIN TRY

		IF @AccionRegistroID=1 --Inserción
		BEGIN

			insert into Tbl_Auditoria (UsuarioID,NombreTabla,Campos,IdTabla,CampoID,ValorInicial,ValorFinal,AccionRegistroID,FechaCambio)
			values(@UsuarioID,@NombreTabla,@Campos,@IdTabla,@campoid,null,@ValorFinal,@AccionRegistroID,GETDATE())

			select @IdAuditoria=SCOPE_IDENTITY()

		END
		ELSE
		BEGIN

			IF @AccionRegistroID=3 --Eliminación
			BEGIN

				insert into Tbl_Auditoria (UsuarioID,NombreTabla,Campos,IdTabla,CampoID,ValorInicial,ValorFinal,AccionRegistroID,FechaCambio)
				values(@UsuarioID,@NombreTabla,@Campos,@IdTabla,@campoid,@ValorInicial,null,@AccionRegistroID,GETDATE())

				select @IdAuditoria=SCOPE_IDENTITY()

			END
			ELSE
			BEGIN

				IF @AccionRegistroID=2 --Actualización
				BEGIN

					insert into Tbl_Auditoria (UsuarioID,NombreTabla,Campos,IdTabla,CampoID,ValorInicial,ValorFinal,AccionRegistroID,FechaCambio)
					values(@UsuarioID,@NombreTabla,@Campos,@IdTabla,@campoid,@ValorInicial,@ValorFinal,@AccionRegistroID,GETDATE())

					select @IdAuditoria=SCOPE_IDENTITY()

				END

			END

		END
		
		SELECT 1 Resultado,''Proceso de auditoria terminado con Éxito'' Mensaje, @IdAuditoria IdAuditoria     

	END TRY
	BEGIN CATCH

		select 0 Resultado, CONVERT(varchar(max),ERROR_MESSAGE())+''    
		Error en la linea: ''+CONVERT(varchar(max),ERROR_LINE()) Mensaje, null IdAuditoria    

	END CATCH

END






' 
END
GO
/****** Object:  StoredProcedure [dbo].[SpInsertaLicencia]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpInsertaLicencia]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		WILINTON BAQUERO
-- Create date: 2016-07-13
-- =============================================
CREATE PROCEDURE [dbo].[SpInsertaLicencia]
	@Board varchar(max),@Mac varchar(max)
AS
BEGIN
	SET NOCOUNT ON;

    BEGIN TRY

		--exec SpInsertaLicencia ''1'',''006073AB6523''
		
		IF NOT EXISTS( select * from Tbl_Licencia where convert(varchar(max),DECRYPTBYPASSPHRASE(''b@qu3r096'',Board))= @Board and
					convert(varchar(max),DECRYPTBYPASSPHRASE(''b@qu3r096'',Mac))= @Mac )
		BEGIN

			insert into Tbl_Licencia
			values(ENCRYPTBYPASSPHRASE(''b@qu3r096'',convert(varchar(max),@Board)),ENCRYPTBYPASSPHRASE(''b@qu3r096'',convert(varchar(max),@Mac)))

			select ''1'' Resultado,''Licencia correctamente insertada'' Mensaje

		END
		ELSE
		BEGIN

			select ''0'' Resultado,''Licencia ya insertada'' Mensaje
			
		END

		

	END TRY  
  
  
	BEGIN CATCH  
  
		select 0 Resultado, CONVERT(varchar(max),ERROR_MESSAGE())+''      
		Error en la linea: ''+CONVERT(varchar(max),ERROR_LINE()) Mensaje  
  
	END CATCH 
END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[SpModificaAdelantoInsentivo]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpModificaAdelantoInsentivo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		WILINTON BAQUERO
-- Create date: 2016-08-18
-- Modificate date> 2016-09-04
-- =============================================
CREATE PROCEDURE [dbo].[SpModificaAdelantoInsentivo]
	@AdelantoInsentivoID int,@UsuarioAdelantoInsentivoID int, @ValorAdelantoInsentivo int,@Adelanto bit, @Activo bit, @UsuarioModificaID int
AS
BEGIN

	BEGIN TRY 

		--exec SpModificaAdelantoInsentivo 1,3,555000,1,1,1
		--exec SpModificaAdelantoInsentivo 2,3,444000,0,1,1

		declare @Mensaje varchar(max)='''',@XmlInicial varchar(max),@XmlFinal varchar(max)
		declare @AdelantoInsentivo table (AdelantoInsentivoID int,UsuarioAdelantoInsentivoID int,ValorAdelantoInsentivo int,Adelanto bit,Activo bit,UsuarioCreaID int,
		UsuarioModificaID int,FechaCrea datetime,FechaModifica datetime)
		declare @AdelantoInsentivo2 table (AdelantoInsentivoID int,UsuarioAdelantoInsentivoID int,ValorAdelantoInsentivo int,Adelanto bit,Activo bit,UsuarioCreaID int,
		UsuarioModificaID int,FechaCrea datetime,FechaModifica datetime)

		declare @tabla table(Resultado int, Mensaje varchar(max),AuditoriaID int)


		insert into @AdelantoInsentivo(AdelantoInsentivoID,UsuarioAdelantoInsentivoID,ValorAdelantoInsentivo,Adelanto,Activo,UsuarioCreaID,UsuarioModificaID,
		FechaCrea,FechaModifica)
		select AdelantoInsentivoID,UsuarioAdelantoInsentivoID,ValorAdelantoInsentivo,Adelanto,Activo,UsuarioCreaID,UsuarioModificaID,FechaCrea,FechaModifica
		from Tbl_AdelantoInsentivo where AdelantoInsentivoID=@AdelantoInsentivoID
		insert into @AdelantoInsentivo2(AdelantoInsentivoID,UsuarioAdelantoInsentivoID,ValorAdelantoInsentivo,Adelanto,Activo,UsuarioCreaID,UsuarioModificaID,
		FechaCrea,FechaModifica)
		select AdelantoInsentivoID,UsuarioAdelantoInsentivoID,ValorAdelantoInsentivo,Adelanto,Activo,UsuarioCreaID,UsuarioModificaID,FechaCrea,FechaModifica
		from Tbl_AdelantoInsentivo where AdelantoInsentivoID=@AdelantoInsentivoID

		update @AdelantoInsentivo2 set ValorAdelantoInsentivo=@ValorAdelantoInsentivo,UsuarioAdelantoInsentivoID=@UsuarioAdelantoInsentivoID,
							Activo=@Activo , UsuarioModificaID=@UsuarioModificaID ,FechaModifica=GETDATE()

		set @XmlInicial=convert(varchar(max),
		(select 
			isnull(AdelantoInsentivoID,0) AdelantoInsentivoID,
			ISNULL(UsuarioAdelantoInsentivoID,0) UsuarioAdelantoInsentivoID,
			isnull(ValorAdelantoInsentivo,0) ValorAdelantoInsentivo,
			isnull(Adelanto,0) Adelanto,
			isnull(Activo,0) Activo,
			isnull(UsuarioCreaID,0) UsuarioCreaID,
			isnull(UsuarioModificaID,0) UsuarioModificaID,
			isnull(FechaCrea,'''') FechaCrea,
			isnull(FechaModifica,'''') FechaModifica 
		from @AdelantoInsentivo for xml raw,elements))

		set @XmlFinal=convert(varchar(max),
		(select 
			isnull(AdelantoInsentivoID,0) AdelantoInsentivoID,
			ISNULL(UsuarioAdelantoInsentivoID,0) UsuarioAdelantoInsentivoID,
			isnull(ValorAdelantoInsentivo,0) ValorAdelantoInsentivo,
			isnull(Adelanto,0) Adelanto,
			isnull(Activo,0) Activo,
			isnull(UsuarioCreaID,0) UsuarioCreaID,
			isnull(UsuarioModificaID,0) UsuarioModificaID,
			isnull(FechaCrea,'''') FechaCrea,
			isnull(FechaModifica,'''') FechaModifica 
		from @AdelantoInsentivo2 for xml raw,elements))

		insert into @tabla
		exec SpInsertaAuditoria @UsuarioModificaID,''Tbl_AdelantoInsentivo'','''',@AdelantoInsentivoID,@XmlFinal,2,@XmlInicial

		IF(select Resultado from @tabla)=1
		BEGIN

			update Tbl_AdelantoInsentivo set ValorAdelantoInsentivo=@ValorAdelantoInsentivo,@Adelanto=Adelanto,UsuarioAdelantoInsentivoID=@UsuarioAdelantoInsentivoID,
							Activo=@Activo , UsuarioModificaID=@UsuarioModificaID ,FechaModifica=GETDATE()
							where AdelantoInsentivoID=@AdelantoInsentivoID

			select 1 Resultado, ''Adelanto/Insentivo correctamente actualizado.'' Mensaje

		END
		ELSE
		BEGIN
					
			select Resultado, Mensaje from @tabla

		END 

		
	END TRY  
  
	BEGIN CATCH  
  
		select 0 Resultado, CONVERT(varchar(max),ERROR_MESSAGE())+''      
		Error en la linea: ''+CONVERT(varchar(max),ERROR_LINE()) Mensaje  
  
	END CATCH 

END




' 
END
GO
/****** Object:  StoredProcedure [dbo].[SpModificaCliente]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpModificaCliente]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		WILINTON BAQUERO
-- Create date: 2016-08-18
-- =============================================
CREATE PROCEDURE [dbo].[SpModificaCliente]
	@ClienteID int, @Nombre varchar(100),@Correo varchar(150), @Telefono varchar(100), @Activo bit, @UsuarioModificaID int
AS
BEGIN

	BEGIN TRY 

		--exec SpModificaCliente 1,''Carlos Moreno'','''','''',1,1

		declare @Mensaje varchar(max)='''',@XmlInicial varchar(max),@XmlFinal varchar(max)
		declare @Cliente table (ClienteID int,Nombre varchar(100),Correo varchar(150), Telefono varchar(100),Activo bit,UsuarioCreaID int,
		UsuarioModificaID int,FechaCrea datetime,FechaModifica datetime)
		declare @Cliente2 table (ClienteID int,Nombre varchar(100),Correo varchar(150), Telefono varchar(100),Activo bit,UsuarioCreaID int,
		UsuarioModificaID int,FechaCrea datetime,FechaModifica datetime)

		declare @tabla table(Resultado int, Mensaje varchar(max),AuditoriaID int)

		IF NOT EXISTS (select * from Tbl_Cliente where LTRIM(RTRIM(REPLACE(Nombre,''  '','' '')))=LTRIM(RTRIM(REPLACE(@Nombre,''  '','' ''))) and ClienteID <>@ClienteID)
		BEGIN

			insert into @Cliente(ClienteID,Nombre,Correo,Telefono,Activo,UsuarioCreaID,UsuarioModificaID,FechaCrea,FechaModifica)
			select ClienteID,Nombre,Correo,Telefono,Activo,UsuarioCreaID,UsuarioModificaID,FechaCrea,FechaModifica
			from Tbl_Cliente where ClienteID=@ClienteID
			insert into @Cliente2(ClienteID,Nombre,Correo,Telefono,Activo,UsuarioCreaID,UsuarioModificaID,FechaCrea,FechaModifica)
			select ClienteID,Nombre,Correo,Telefono,Activo,UsuarioCreaID,UsuarioModificaID,FechaCrea,FechaModifica
			from Tbl_Cliente where ClienteID=@ClienteID

			update @Cliente2 set Nombre=LTRIM(RTRIM(REPLACE(@Nombre,''  '','' ''))) ,Correo=@Correo,Telefono=@Telefono,
								Activo=@Activo , UsuarioModificaID=@UsuarioModificaID ,FechaModifica=GETDATE()

			set @XmlInicial=convert(varchar(max),
			(select 
				isnull(ClienteID,0) ClienteID,
				isnull(Nombre,'''') Nombre,
				isnull(Correo,'''') Correo,
				isnull(Telefono,'''') Telefono,
				isnull(Activo,0) Activo,
				isnull(UsuarioCreaID,0) UsuarioCreaID,
				isnull(UsuarioModificaID,0) UsuarioModificaID,
				isnull(FechaCrea,'''') FechaCrea,
				isnull(FechaModifica,'''') FechaModifica 
			from @Cliente for xml raw,elements))

			set @XmlFinal=convert(varchar(max),
			(select 
				isnull(ClienteID,0) ClienteID,
				isnull(Nombre,'''') Nombre,
				isnull(Correo,'''') Correo,
				isnull(Telefono,'''') Telefono,
				isnull(Activo,0) Activo,
				isnull(UsuarioCreaID,0) UsuarioCreaID,
				isnull(UsuarioModificaID,0) UsuarioModificaID,
				isnull(FechaCrea,'''') FechaCrea,
				isnull(FechaModifica,'''') FechaModifica 
			from @Cliente2 for xml raw,elements))

			insert into @tabla
			exec SpInsertaAuditoria @UsuarioModificaID,''Tbl_Cliente'','''',@ClienteID,@XmlFinal,2,@XmlInicial

			IF(select Resultado from @tabla)=1
			BEGIN

				update Tbl_Cliente set Nombre=LTRIM(RTRIM(REPLACE(@Nombre,''  '','' ''))) ,Correo=@Correo,Telefono=@Telefono,
								Activo=@Activo , UsuarioModificaID=@UsuarioModificaID ,FechaModifica=GETDATE()
								where ClienteID=@ClienteID

				select 1 Resultado, ''Cliente correctamente actualizado.'' Mensaje

			END
			ELSE
			BEGIN
					
				select Resultado, Mensaje from @tabla

			END 

		END
		ELSE
		BEGIN

			select 0 Resultado, ''Ya existe un Cliente con el mismo nombre.'' Mensaje

		END

	END TRY  
  
	BEGIN CATCH  
  
		select 0 Resultado, CONVERT(varchar(max),ERROR_MESSAGE())+''      
		Error en la linea: ''+CONVERT(varchar(max),ERROR_LINE()) Mensaje  
  
	END CATCH 

END


' 
END
GO
/****** Object:  StoredProcedure [dbo].[SpModificaDeposito]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpModificaDeposito]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		WILINTON BAQUERO
-- Create date: 2016-08-18
-- =============================================
CREATE PROCEDURE [dbo].[SpModificaDeposito]
	@DepositoID int, @ValorDeposito int, @Activo bit, @UsuarioModificaID int
AS
BEGIN

	BEGIN TRY 

		--exec SpModificaDeposito 1,845000,1,1

		declare @Mensaje varchar(max)='''',@XmlInicial varchar(max),@XmlFinal varchar(max)
		declare @Deposito table (DepositoID int,ValorDeposito int,Activo bit,UsuarioCreaID int,
		UsuarioModificaID int,FechaCrea datetime,FechaModifica datetime)
		declare @Deposito2 table (DepositoID int,ValorDeposito int,Activo bit,UsuarioCreaID int,
		UsuarioModificaID int,FechaCrea datetime,FechaModifica datetime)

		declare @tabla table(Resultado int, Mensaje varchar(max),AuditoriaID int)


		insert into @Deposito(DepositoID,ValorDeposito,Activo,UsuarioCreaID,UsuarioModificaID,FechaCrea,FechaModifica)
		select DepositoID,ValorDeposito,Activo,UsuarioCreaID,UsuarioModificaID,FechaCrea,FechaModifica
		from Tbl_Deposito where DepositoID=@DepositoID
		insert into @Deposito2(DepositoID,ValorDeposito,Activo,UsuarioCreaID,UsuarioModificaID,FechaCrea,FechaModifica)
		select DepositoID,ValorDeposito,Activo,UsuarioCreaID,UsuarioModificaID,FechaCrea,FechaModifica
		from Tbl_Deposito where DepositoID=@DepositoID

		update @Deposito2 set ValorDeposito=@ValorDeposito,
							Activo=@Activo , UsuarioModificaID=@UsuarioModificaID ,FechaModifica=GETDATE()

		set @XmlInicial=convert(varchar(max),
		(select 
			isnull(DepositoID,0) DepositoID,
			isnull(ValorDeposito,0) ValorDeposito,
			isnull(Activo,0) Activo,
			isnull(UsuarioCreaID,0) UsuarioCreaID,
			isnull(UsuarioModificaID,0) UsuarioModificaID,
			isnull(FechaCrea,'''') FechaCrea,
			isnull(FechaModifica,'''') FechaModifica 
		from @Deposito for xml raw,elements))

		set @XmlFinal=convert(varchar(max),
		(select 
			isnull(DepositoID,0) DepositoID,
			isnull(ValorDeposito,0) ValorDeposito,
			isnull(Activo,0) Activo,
			isnull(UsuarioCreaID,0) UsuarioCreaID,
			isnull(UsuarioModificaID,0) UsuarioModificaID,
			isnull(FechaCrea,'''') FechaCrea,
			isnull(FechaModifica,'''') FechaModifica 
		from @Deposito2 for xml raw,elements))

		insert into @tabla
		exec SpInsertaAuditoria @UsuarioModificaID,''Tbl_Deposito'','''',@DepositoID,@XmlFinal,2,@XmlInicial

		IF(select Resultado from @tabla)=1
		BEGIN

			update Tbl_Deposito set ValorDeposito=@ValorDeposito,
							Activo=@Activo , UsuarioModificaID=@UsuarioModificaID ,FechaModifica=GETDATE()
							where DepositoID=@DepositoID

			select 1 Resultado, ''Deposito correctamente actualizado.'' Mensaje

		END
		ELSE
		BEGIN
					
			select Resultado, Mensaje from @tabla

		END 

		
	END TRY  
  
	BEGIN CATCH  
  
		select 0 Resultado, CONVERT(varchar(max),ERROR_MESSAGE())+''      
		Error en la linea: ''+CONVERT(varchar(max),ERROR_LINE()) Mensaje  
  
	END CATCH 

END


' 
END
GO
/****** Object:  StoredProcedure [dbo].[SpModificaGasto]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpModificaGasto]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		WILINTON BAQUERO
-- Create date: 2016-08-18
-- =============================================
CREATE PROCEDURE [dbo].[SpModificaGasto]
	@GastoID int,@Detalle varchar(300), @ValorGasto int, @Activo bit, @UsuarioModificaID int
AS
BEGIN

	BEGIN TRY 

		--exec SpModificaGasto 1,''Compra de bebidas calientes.'',45000,1,1

		declare @Mensaje varchar(max)='''',@XmlInicial varchar(max),@XmlFinal varchar(max)
		declare @Gasto table (GastoID int,Detalle varchar(300),ValorGasto int,Activo bit,UsuarioCreaID int,
		UsuarioModificaID int,FechaCrea datetime,FechaModifica datetime)
		declare @Gasto2 table (GastoID int,Detalle varchar(300),ValorGasto int,Activo bit,UsuarioCreaID int,
		UsuarioModificaID int,FechaCrea datetime,FechaModifica datetime)

		declare @tabla table(Resultado int, Mensaje varchar(max),AuditoriaID int)


		insert into @Gasto(GastoID,Detalle,ValorGasto,Activo,UsuarioCreaID,UsuarioModificaID,FechaCrea,FechaModifica)
		select GastoID,Detalle,ValorGasto,Activo,UsuarioCreaID,UsuarioModificaID,FechaCrea,FechaModifica
		from Tbl_Gasto where GastoID=@GastoID
		insert into @Gasto2(GastoID,Detalle,ValorGasto,Activo,UsuarioCreaID,UsuarioModificaID,FechaCrea,FechaModifica)
		select GastoID,Detalle,ValorGasto,Activo,UsuarioCreaID,UsuarioModificaID,FechaCrea,FechaModifica
		from Tbl_Gasto where GastoID=@GastoID

		update @Gasto2 set ValorGasto=@ValorGasto,Detalle=@Detalle,
							Activo=@Activo , UsuarioModificaID=@UsuarioModificaID ,FechaModifica=GETDATE()

		set @XmlInicial=convert(varchar(max),
		(select 
			isnull(GastoID,0) GastoID,
			isnull(Detalle,'''') Detalle,
			isnull(ValorGasto,0) ValorGasto,
			isnull(Activo,0) Activo,
			isnull(UsuarioCreaID,0) UsuarioCreaID,
			isnull(UsuarioModificaID,0) UsuarioModificaID,
			isnull(FechaCrea,'''') FechaCrea,
			isnull(FechaModifica,'''') FechaModifica 
		from @Gasto for xml raw,elements))

		set @XmlFinal=convert(varchar(max),
		(select 
			isnull(GastoID,0) GastoID,
			isnull(Detalle,'''') Detalle,
			isnull(ValorGasto,0) ValorGasto,
			isnull(Activo,0) Activo,
			isnull(UsuarioCreaID,0) UsuarioCreaID,
			isnull(UsuarioModificaID,0) UsuarioModificaID,
			isnull(FechaCrea,'''') FechaCrea,
			isnull(FechaModifica,'''') FechaModifica 
		from @Gasto2 for xml raw,elements))

		insert into @tabla
		exec SpInsertaAuditoria @UsuarioModificaID,''Tbl_Gasto'','''',@GastoID,@XmlFinal,2,@XmlInicial

		IF(select Resultado from @tabla)=1
		BEGIN

			update Tbl_Gasto set ValorGasto=@ValorGasto,Detalle=@Detalle,
							Activo=@Activo , UsuarioModificaID=@UsuarioModificaID ,FechaModifica=GETDATE()
							where GastoID=@GastoID

			select 1 Resultado, ''Gasto correctamente actualizado.'' Mensaje

		END
		ELSE
		BEGIN
					
			select Resultado, Mensaje from @tabla

		END 

		
	END TRY  
  
	BEGIN CATCH  
  
		select 0 Resultado, CONVERT(varchar(max),ERROR_MESSAGE())+''      
		Error en la linea: ''+CONVERT(varchar(max),ERROR_LINE()) Mensaje  
  
	END CATCH 

END



' 
END
GO
/****** Object:  StoredProcedure [dbo].[SpModificaInventario]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpModificaInventario]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		WILINTON BAQUERO
-- Create date: 2016-08-02
-- Modificate date: 2016-09-03
-- =============================================
CREATE PROCEDURE [dbo].[SpModificaInventario]
	@ProductoID int,@CantidadUnidad int,@UsuarioID int, @Adiciona bit, @return bit=0
AS
BEGIN

	BEGIN TRY 

		--exec SpModificaProducto 11,''Producto Prueba 2'',10,20000,1200,1,1

		declare @Mensaje varchar(max)='''',@XmlInicial varchar(max),@XmlFinal varchar(max),@InventarioID int

		select @InventarioID=InventarioID from Tbl_Inventario where ProductoID=@ProductoID

		declare @inventario table (InventarioID int,ProductoID int,CantidadUnidad int,UsuarioID int,FechaModifica datetime)
		declare @inventario2 table (InventarioID int,ProductoID int,CantidadUnidad int,UsuarioID int,FechaModifica datetime)

		declare @tabla table(Resultado int, Mensaje varchar(max),AuditoriaID int)

		insert into @inventario(InventarioID ,ProductoID ,CantidadUnidad ,UsuarioID ,FechaModifica )
		select InventarioID, ProductoID ,CantidadUnidad ,UsuarioID ,FechaModifica 
		from Tbl_Inventario where ProductoID=@ProductoID

		insert into @inventario2(InventarioID ,ProductoID ,CantidadUnidad ,UsuarioID ,FechaModifica )
		select InventarioID,ProductoID ,
		CantidadUnidad+(case when @Adiciona=1 then @CantidadUnidad else (-1)*@CantidadUnidad end) ,
		@UsuarioID ,getdate() 
		from Tbl_Inventario where ProductoID=@ProductoID


		set @XmlInicial=convert(varchar(max),
		(select 
			isnull(InventarioID,0) InventarioID,
			isnull(ProductoID,0) ProductoID,
			isnull(CantidadUnidad,0) CantidadUnidad,
			isnull(UsuarioID,0) UsuarioID,
			isnull(FechaModifica,'''') FechaModifica 
		from @inventario for xml raw,elements))

		set @XmlFinal=convert(varchar(max),
		(select 
			isnull(InventarioID,0) InventarioID,
			isnull(ProductoID,0) ProductoID,
			isnull(CantidadUnidad,0) CantidadUnidad,
			isnull(UsuarioID,0) UsuarioID,
			isnull(FechaModifica,'''') FechaModifica 
		from @inventario2 for xml raw,elements))

		insert into @tabla
		exec SpInsertaAuditoria @UsuarioID,''Tbl_Inventario'','''',@ProductoID,@XmlFinal,2,@XmlInicial

		IF(select Resultado from @tabla)=1
		BEGIN

			update Tbl_Inventario 
			set CantidadUnidad=CantidadUnidad+(case when @Adiciona=1 then @CantidadUnidad else (-1)*@CantidadUnidad end),
				UsuarioID=@UsuarioID,
				FechaModifica=GETDATE()
			where ProductoID=@ProductoID

			IF( @return=1 )
			BEGIN

				select 1 Resultado, ''Inventario correctamente actualizado.'' Mensaje 

			END

		END
		ELSE
		BEGIN
					
			select Resultado, Mensaje from @tabla

		END 

		
	END TRY  
  
	BEGIN CATCH  
  
		select 0 Resultado, CONVERT(varchar(max),ERROR_MESSAGE())+''      
		Error en la linea: ''+CONVERT(varchar(max),ERROR_LINE()) Mensaje  
  
	END CATCH 

END



' 
END
GO
/****** Object:  StoredProcedure [dbo].[SpModificaPagoFactura]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpModificaPagoFactura]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		WILINTON BAQUERO
-- Create date: 2016-08-19
-- =============================================
CREATE PROCEDURE [dbo].[SpModificaPagoFactura]
	@PagoFacturaID int,@ProveedorID int,@NumeroFactura varchar(20), @ValorPagoFactura int, @Activo bit, @UsuarioModificaID int
AS
BEGIN

	BEGIN TRY 

		--exec SpModificaPagoFactura 1,2,''416546A'',45000,1,1

		declare @Mensaje varchar(max)='''',@XmlInicial varchar(max),@XmlFinal varchar(max)
		declare @PagoFactura table (PagoFacturaID int,ProveedorID int,NumeroFactura varchar(20),ValorPagoFactura int,Activo bit,UsuarioCreaID int,
		UsuarioModificaID int,FechaCrea datetime,FechaModifica datetime)
		declare @PagoFactura2 table (PagoFacturaID int,ProveedorID int,NumeroFactura varchar(20),ValorPagoFactura int,Activo bit,UsuarioCreaID int,
		UsuarioModificaID int,FechaCrea datetime,FechaModifica datetime)

		declare @tabla table(Resultado int, Mensaje varchar(max),AuditoriaID int)


		insert into @PagoFactura(PagoFacturaID,ProveedorID,NumeroFactura,ValorPagoFactura,Activo,UsuarioCreaID,UsuarioModificaID,FechaCrea,FechaModifica)
		select PagoFacturaID,ProveedorID,NumeroFactura,ValorPagoFactura,Activo,UsuarioCreaID,UsuarioModificaID,FechaCrea,FechaModifica
		from Tbl_PagoFactura where PagoFacturaID=@PagoFacturaID
		insert into @PagoFactura2(PagoFacturaID,ProveedorID,NumeroFactura,ValorPagoFactura,Activo,UsuarioCreaID,UsuarioModificaID,FechaCrea,FechaModifica)
		select PagoFacturaID,ProveedorID,NumeroFactura,ValorPagoFactura,Activo,UsuarioCreaID,UsuarioModificaID,FechaCrea,FechaModifica
		from Tbl_PagoFactura where PagoFacturaID=@PagoFacturaID

		update @PagoFactura2 set ValorPagoFactura=@ValorPagoFactura,NumeroFactura=@NumeroFactura,ProveedorID=@ProveedorID,
							Activo=@Activo , UsuarioModificaID=@UsuarioModificaID ,FechaModifica=GETDATE()

		set @XmlInicial=convert(varchar(max),
		(select 
			isnull(PagoFacturaID,0) PagoFacturaID,
			isnull(ProveedorID,0) ProveedorID,
			isnull(NumeroFactura,'''') NumeroFactura,
			isnull(ValorPagoFactura,0) ValorPagoFactura,
			isnull(Activo,0) Activo,
			isnull(UsuarioCreaID,0) UsuarioCreaID,
			isnull(UsuarioModificaID,0) UsuarioModificaID,
			isnull(FechaCrea,'''') FechaCrea,
			isnull(FechaModifica,'''') FechaModifica 
		from @PagoFactura for xml raw,elements))

		set @XmlFinal=convert(varchar(max),
		(select 
			isnull(PagoFacturaID,0) PagoFacturaID,
			isnull(ProveedorID,0) ProveedorID,
			isnull(NumeroFactura,'''') NumeroFactura,
			isnull(ValorPagoFactura,0) ValorPagoFactura,
			isnull(Activo,0) Activo,
			isnull(UsuarioCreaID,0) UsuarioCreaID,
			isnull(UsuarioModificaID,0) UsuarioModificaID,
			isnull(FechaCrea,'''') FechaCrea,
			isnull(FechaModifica,'''') FechaModifica 
		from @PagoFactura2 for xml raw,elements))

		insert into @tabla
		exec SpInsertaAuditoria @UsuarioModificaID,''Tbl_PagoFactura'','''',@PagoFacturaID,@XmlFinal,2,@XmlInicial

		IF(select Resultado from @tabla)=1
		BEGIN

			update Tbl_PagoFactura set ValorPagoFactura=@ValorPagoFactura,NumeroFactura=@NumeroFactura,ProveedorID=@ProveedorID,
							Activo=@Activo , UsuarioModificaID=@UsuarioModificaID ,FechaModifica=GETDATE()
							where PagoFacturaID=@PagoFacturaID

			select 1 Resultado, ''Pago de Factura correctamente actualizado.'' Mensaje

		END
		ELSE
		BEGIN
					
			select Resultado, Mensaje from @tabla

		END 

		
	END TRY  
  
	BEGIN CATCH  
  
		select 0 Resultado, CONVERT(varchar(max),ERROR_MESSAGE())+''      
		Error en la linea: ''+CONVERT(varchar(max),ERROR_LINE()) Mensaje  
  
	END CATCH 

END



' 
END
GO
/****** Object:  StoredProcedure [dbo].[SpModificaProducto]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpModificaProducto]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		WILINTON BAQUERO
-- Create date: 2016-07-12
-- Modificate date: 2016-09-04
-- =============================================
CREATE PROCEDURE [dbo].[SpModificaProducto]
	@ProductoID int, @Nombre varchar(100),@UnidadxProducto int, @ValorCompra int,@ValorVentaXUnidad int, @PorcentajeVentaPublico int, @DescuentoVentaInterna int,
	@Insumo bit,@CodigoProducto varchar(5),@Activo bit, @UsuarioModificaID int,@ProveedorID int=0
AS
BEGIN

	BEGIN TRY 

		--exec SpModificaProducto 1,''Producto 1'',10,10000,1200,20,10,0,''Pro3'',1,1

		declare @Mensaje varchar(max)='''',@XmlInicial varchar(max),@XmlFinal varchar(max)
		declare @producto table (ProductoID int,Nombre varchar(100),ProveedorID int,UnidadxProducto int,ValorCompra int,ValorVentaXUnidad int,
						PorcentajeVentaPublico int, DescuentoVentaInterna int,Insumo bit,CodigoProducto varchar(5),Activo bit,
						UsuarioCreaID int,UsuarioModificaID int,FechaCrea datetime,FechaModifica datetime)
		declare @producto2 table (ProductoID int,Nombre varchar(100),ProveedorID int,UnidadxProducto int,ValorCompra int,ValorVentaXUnidad int,
						PorcentajeVentaPublico int, DescuentoVentaInterna int,Insumo bit,CodigoProducto varchar(5),Activo bit,
						UsuarioCreaID int,UsuarioModificaID int,FechaCrea datetime,FechaModifica datetime)

		declare @tabla table(Resultado int, Mensaje varchar(max),AuditoriaID int)

		IF NOT EXISTS (select * from Tbl_Producto 
						where (LTRIM(RTRIM(REPLACE(Nombre,''  '','' '')))=LTRIM(RTRIM(REPLACE(@Nombre,''  '','' '')))
							or LTRIM(RTRIM(REPLACE(CodigoProducto,''  '','' '')))=LTRIM(RTRIM(REPLACE(@CodigoProducto,''  '','' ''))))
						and ProductoID <>@ProductoID)
		BEGIN

			insert into @producto(ProductoID,Nombre,ProveedorID,UnidadxProducto,ValorCompra,ValorVentaXUnidad,PorcentajeVentaPublico,DescuentoVentaInterna,Insumo,
						CodigoProducto,Activo,UsuarioCreaID,UsuarioModificaID,FechaCrea,FechaModifica)
			select ProductoID,Nombre,ProveedorID,UnidadxProducto,ValorCompra,ValorVentaXUnidad,PorcentajeVentaPublico,DescuentoVentaInterna,Insumo,
					CodigoProducto,Activo,UsuarioCreaID,UsuarioModificaID,FechaCrea,FechaModifica
			from Tbl_Producto where ProductoID=@ProductoID
			insert into @producto2(ProductoID,Nombre,ProveedorID,UnidadxProducto,ValorCompra,ValorVentaXUnidad,PorcentajeVentaPublico,DescuentoVentaInterna,Insumo,
						CodigoProducto,Activo,UsuarioCreaID,UsuarioModificaID,FechaCrea,FechaModifica)
			select ProductoID,Nombre,ProveedorID,UnidadxProducto,ValorCompra,ValorVentaXUnidad,PorcentajeVentaPublico,DescuentoVentaInterna,Insumo,
					CodigoProducto,Activo,UsuarioCreaID,UsuarioModificaID,FechaCrea,FechaModifica
			from Tbl_Producto where ProductoID=@ProductoID

			update @producto2 set Nombre=LTRIM(RTRIM(REPLACE(@Nombre,''  '','' ''))) ,UnidadxProducto=@UnidadxProducto ,							
								ValorCompra=@ValorCompra ,ValorVentaXUnidad=@ValorVentaXUnidad ,ProveedorID=@ProveedorID,
								PorcentajeVentaPublico=@PorcentajeVentaPublico,DescuentoVentaInterna=@DescuentoVentaInterna,
								Insumo=@Insumo,CodigoProducto=@CodigoProducto,
								Activo=@Activo , UsuarioModificaID=@UsuarioModificaID ,FechaModifica=GETDATE()

			set @XmlInicial=convert(varchar(max),
			(select 
				isnull(ProductoID,0) ProductoID,
				isnull(Nombre,'''') Nombre,
				ISNULL(ProveedorID,0) ProveedorID,
				isnull(UnidadxProducto,0) UnidadxProducto,
				isnull(ValorCompra,0) ValorCompra,
				isnull(ValorVentaXUnidad,0) ValorVentaXUnidad,
				isnull(PorcentajeVentaPublico,0) PorcentajeVentaPublico,
				isnull(DescuentoVentaInterna,0) DescuentoVentaInterna,
				isnull(Insumo,0) Insumo,
				isnull(CodigoProducto,'''') CodigoProducto,
				isnull(Activo,0) Activo,
				isnull(UsuarioCreaID,0) UsuarioCreaID,
				isnull(UsuarioModificaID,0) UsuarioModificaID,
				isnull(FechaCrea,'''') FechaCrea,
				isnull(FechaModifica,'''') FechaModifica 
			from @producto for xml raw,elements))

			set @XmlFinal=convert(varchar(max),
			(select 
				isnull(ProductoID,0) ProductoID,
				isnull(Nombre,'''') Nombre,
				isnull(ProveedorID,0) ProveedorID,
				isnull(UnidadxProducto,0) UnidadxProducto,
				isnull(ValorCompra,0) ValorCompra,
				isnull(ValorVentaXUnidad,0) ValorVentaXUnidad,
				isnull(PorcentajeVentaPublico,0) PorcentajeVentaPublico,
				isnull(DescuentoVentaInterna,0) DescuentoVentaInterna,
				isnull(Insumo,0) Insumo,
				isnull(CodigoProducto,'''') CodigoProducto,
				isnull(Activo,0) Activo,
				isnull(UsuarioCreaID,0) UsuarioCreaID,
				isnull(UsuarioModificaID,0) UsuarioModificaID,
				isnull(FechaCrea,'''') FechaCrea,
				isnull(FechaModifica,'''') FechaModifica 
			from @producto2 for xml raw,elements))

			insert into @tabla
			exec SpInsertaAuditoria @UsuarioModificaID,''Tbl_Producto'','''',@ProductoID,@XmlFinal,2,@XmlInicial

			IF(select Resultado from @tabla)=1
			BEGIN

				update Tbl_Producto set Nombre=LTRIM(RTRIM(REPLACE(@Nombre,''  '','' ''))) ,UnidadxProducto=@UnidadxProducto ,ValorCompra=@ValorCompra ,
								ValorVentaXUnidad=@ValorVentaXUnidad ,ProveedorID=@ProveedorID,
								PorcentajeVentaPublico=@PorcentajeVentaPublico,DescuentoVentaInterna=@DescuentoVentaInterna,
								Insumo=@Insumo,CodigoProducto=@CodigoProducto,
								Activo=@Activo , UsuarioModificaID=@UsuarioModificaID ,FechaModifica=GETDATE()
								where ProductoID=@ProductoID

				

				select 1 Resultado, ''Producto correctamente actualizado.'' Mensaje

			END
			ELSE
			BEGIN
					
				select Resultado, Mensaje from @tabla

			END 

		END
		ELSE
		BEGIN

			select 0 Resultado, ''Ya existe un Producto con el mismo Nombre y/o Codigo.'' Mensaje

		END

	END TRY  
  
	BEGIN CATCH  
  
		select 0 Resultado, CONVERT(varchar(max),ERROR_MESSAGE())+''      
		Error en la linea: ''+CONVERT(varchar(max),ERROR_LINE()) Mensaje  
  
	END CATCH 

END



' 
END
GO
/****** Object:  StoredProcedure [dbo].[SpModificaProveedor]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpModificaProveedor]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		WILINTON BAQUERO
-- Create date: 2016-08-18
-- =============================================
CREATE PROCEDURE [dbo].[SpModificaProveedor]
	@ProveedorID int, @Nombre varchar(100), @Activo bit, @UsuarioModificaID int
AS
BEGIN

	BEGIN TRY 

		--exec SpModificaProveedor 1,''Marcell France'',1,1

		declare @Mensaje varchar(max)='''',@XmlInicial varchar(max),@XmlFinal varchar(max)
		declare @Proveedor table (ProveedorID int,Nombre varchar(100),Activo bit,UsuarioCreaID int,UsuarioModificaID int,FechaCrea datetime,FechaModifica datetime)
		declare @Proveedor2 table (ProveedorID int,Nombre varchar(100),Activo bit,UsuarioCreaID int,UsuarioModificaID int,FechaCrea datetime,FechaModifica datetime)

		declare @tabla table(Resultado int, Mensaje varchar(max),AuditoriaID int)

		IF NOT EXISTS (select * from Tbl_Proveedor where LTRIM(RTRIM(REPLACE(Nombre,''  '','' '')))=LTRIM(RTRIM(REPLACE(@Nombre,''  '','' ''))) and ProveedorID <>@ProveedorID)
		BEGIN

			insert into @Proveedor(ProveedorID,Nombre,Activo,UsuarioCreaID,UsuarioModificaID,FechaCrea,FechaModifica)
			select ProveedorID,Nombre,Activo,UsuarioCreaID,UsuarioModificaID,FechaCrea,FechaModifica
			from Tbl_Proveedor where ProveedorID=@ProveedorID
			insert into @Proveedor2(ProveedorID,Nombre,Activo,UsuarioCreaID,UsuarioModificaID,FechaCrea,FechaModifica)
			select ProveedorID,Nombre,Activo,UsuarioCreaID,UsuarioModificaID,FechaCrea,FechaModifica
			from Tbl_Proveedor where ProveedorID=@ProveedorID

			update @Proveedor2 set Nombre=LTRIM(RTRIM(REPLACE(@Nombre,''  '','' ''))) ,
								Activo=@Activo , UsuarioModificaID=@UsuarioModificaID ,FechaModifica=GETDATE()

			set @XmlInicial=convert(varchar(max),
			(select 
				isnull(ProveedorID,0) ProveedorID,
				isnull(Nombre,'''') Nombre,
				isnull(Activo,0) Activo,
				isnull(UsuarioCreaID,0) UsuarioCreaID,
				isnull(UsuarioModificaID,0) UsuarioModificaID,
				isnull(FechaCrea,'''') FechaCrea,
				isnull(FechaModifica,'''') FechaModifica 
			from @Proveedor for xml raw,elements))

			set @XmlFinal=convert(varchar(max),
			(select 
				isnull(ProveedorID,0) ProveedorID,
				isnull(Nombre,'''') Nombre,
				isnull(Activo,0) Activo,
				isnull(UsuarioCreaID,0) UsuarioCreaID,
				isnull(UsuarioModificaID,0) UsuarioModificaID,
				isnull(FechaCrea,'''') FechaCrea,
				isnull(FechaModifica,'''') FechaModifica 
			from @Proveedor2 for xml raw,elements))

			insert into @tabla
			exec SpInsertaAuditoria @UsuarioModificaID,''Tbl_Proveedor'','''',@ProveedorID,@XmlFinal,2,@XmlInicial

			IF(select Resultado from @tabla)=1
			BEGIN

				update Tbl_Proveedor set Nombre=LTRIM(RTRIM(REPLACE(@Nombre,''  '','' ''))) ,
								Activo=@Activo , UsuarioModificaID=@UsuarioModificaID ,FechaModifica=GETDATE()
								where ProveedorID=@ProveedorID

				select 1 Resultado, ''Proveedor correctamente actualizado.'' Mensaje

			END
			ELSE
			BEGIN
					
				select Resultado, Mensaje from @tabla

			END 

		END
		ELSE
		BEGIN

			select 0 Resultado, ''Ya existe un Proveedor con el mismo nombre.'' Mensaje

		END

	END TRY  
  
	BEGIN CATCH  
  
		select 0 Resultado, CONVERT(varchar(max),ERROR_MESSAGE())+''      
		Error en la linea: ''+CONVERT(varchar(max),ERROR_LINE()) Mensaje  
  
	END CATCH 

END


' 
END
GO
/****** Object:  StoredProcedure [dbo].[SpModificaServicio]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpModificaServicio]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		WILINTON BAQUERO
-- Create date: 2016-07-12
-- Modificate date: 2016-08-28
-- =============================================
CREATE PROCEDURE [dbo].[SpModificaServicio]
	@ServicioID int,@Nombre varchar(200),@ValorVenta int,@PorcentajeEstilista smallint,@CodigoServicio varchar(5),@Variable bit,@Activo bit,@UsuarioModificaID int
AS
BEGIN
	
	BEGIN TRY 

		--exec SpModificaServicio 1,''Servicio 1'',10000,60,''Serf1'',0,1,1

		declare @Mensaje varchar(max)='''',@XmlInicial varchar(max),@XmlFinal varchar(max),@ProductoID int
		declare @Servicio table (ServicioID	int,Nombre varchar(200),ValorVenta int,PorcentajeEstilista smallint,CodigoServicio varchar(5),Variable bit,
								Activo bit,UsuarioCreaID int,UsuarioModificaID int,FechaCrea datetime,FechaModifica datetime)
		declare @Servicio2 table (ServicioID	int,Nombre varchar(200),ValorVenta int,PorcentajeEstilista smallint,CodigoServicio varchar(5),Variable bit,
								Activo bit,UsuarioCreaID int,UsuarioModificaID int,FechaCrea datetime,FechaModifica datetime)
		declare @producto table (ProductoID int)
		declare @ServicioProducto table (ServicioProductoID int,ServicioID int,ProductoID int,UsuarioCreaID int,FechaCrea datetime)
		

		declare @tabla table(Resultado int, Mensaje varchar(max),AuditoriaID int)

		IF NOT EXISTS (select * from Tbl_Servicio where LTRIM(RTRIM(REPLACE(Nombre,''  '','' '')))=LTRIM(RTRIM(REPLACE(@Nombre,''  '','' ''))) and ServicioID <>@ServicioID)
		BEGIN

			insert into @Servicio(ServicioID,Nombre,ValorVenta,PorcentajeEstilista,CodigoServicio,Variable,Activo,UsuarioCreaID,UsuarioModificaID
			,FechaCrea,FechaModifica)
			select ServicioID,Nombre,ValorVenta,PorcentajeEstilista,CodigoServicio,Variable,Activo,UsuarioCreaID,UsuarioModificaID
			,FechaCrea,FechaModifica
			from Tbl_Servicio where ServicioID=@ServicioID

			insert into @Servicio2(ServicioID,Nombre,ValorVenta,PorcentajeEstilista,CodigoServicio,Variable,Activo,UsuarioCreaID,UsuarioModificaID
			,FechaCrea,FechaModifica)
			select ServicioID,Nombre,ValorVenta,PorcentajeEstilista,CodigoServicio,Variable,Activo,UsuarioCreaID,UsuarioModificaID
			,FechaCrea,FechaModifica
			from Tbl_Servicio where ServicioID=@ServicioID

			update @Servicio2 set Nombre=LTRIM(RTRIM(REPLACE(@Nombre,''  '','' ''))) ,ValorVenta=@ValorVenta ,
								PorcentajeEstilista=@PorcentajeEstilista,CodigoServicio=@CodigoServicio,Variable=@Variable,
								Activo=@Activo , UsuarioModificaID=@UsuarioModificaID ,FechaModifica=GETDATE()

			set @XmlInicial=convert(varchar(max),
			(select 
				isnull(ServicioID,0) ServicioID,
				isnull(Nombre,'''') Nombre,
				isnull(ValorVenta,0) ValorVenta,
				isnull(PorcentajeEstilista,0) PorcentajeEstilista,
				isnull(CodigoServicio,'''') CodigoServicio,
				isnull(Variable,0) Variable,
				isnull(Activo,0) Activo,
				isnull(UsuarioCreaID,0) UsuarioCreaID,
				isnull(UsuarioModificaID,0) UsuarioModificaID,
				isnull(FechaCrea,'''') FechaCrea,
				isnull(FechaModifica,'''') FechaModifica 
			from @Servicio for xml raw,elements))

			set @XmlFinal=convert(varchar(max),
			(select 
				isnull(ServicioID,0) ServicioID,
				isnull(Nombre,'''') Nombre,
				isnull(ValorVenta,0) ValorVenta,
				isnull(PorcentajeEstilista,0) PorcentajeEstilista,
				isnull(CodigoServicio,'''') CodigoServicio,
				isnull(Variable,0) Variable,
				isnull(Activo,0) Activo,
				isnull(UsuarioCreaID,0) UsuarioCreaID,
				isnull(UsuarioModificaID,0) UsuarioModificaID,
				isnull(FechaCrea,'''') FechaCrea,
				isnull(FechaModifica,'''') FechaModifica 
			from @Servicio2 for xml raw,elements))

			insert into @tabla
			exec SpInsertaAuditoria @UsuarioModificaID,''Tbl_Servicio'','''',@ServicioID,@XmlFinal,2,@XmlInicial

			IF(select Resultado from @tabla)=1
			BEGIN

				update Tbl_Servicio set Nombre=LTRIM(RTRIM(REPLACE(@Nombre,''  '','' ''))) ,ValorVenta=@ValorVenta ,
								PorcentajeEstilista=@PorcentajeEstilista,CodigoServicio=@CodigoServicio,Variable=@Variable,
								Activo=@Activo , UsuarioModificaID=@UsuarioModificaID ,FechaModifica=GETDATE()
								where ServicioID=@ServicioID

				select 1 Resultado, ''Servicio correctamente actualizado.'' Mensaje

			END
			ELSE
			BEGIN
					
				select Resultado, Mensaje from @tabla

			END

		END
		ELSE
		BEGIN

			select 0 Resultado, ''Ya existe un Servicio con el mismo nombre.'' Mensaje

		END

	END TRY  
  
	BEGIN CATCH  
  
		select 0 Resultado, CONVERT(varchar(max),ERROR_MESSAGE())+''      
		Error en la linea: ''+CONVERT(varchar(max),ERROR_LINE()) Mensaje  
  
	END CATCH 

END' 
END
GO
/****** Object:  StoredProcedure [dbo].[SpModificaUsuario]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpModificaUsuario]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		WILINTON BAQUERO
-- Create date: 2016-07-06
-- Modificate date: 2016-08-27
-- =============================================
CREATE PROCEDURE [dbo].[SpModificaUsuario]
	@UsuarioID int,@Nombre varchar(50), @Apellido varchar(50),@CodigoUsuario varchar(5),@NombreUsuario varchar(50),@Clave varchar(50),
	@Documento varchar(50),@Telefono varchar(50),@Direccion varchar(50),@RolID int,@Activo bit,@UsuarioModificaID int
AS
BEGIN

	BEGIN TRY  

		--exec SpModificaUsuario 2,''Juan David'',''Calderon'',''G1'',''JCalderon'',''123*'','''','''','''',2,1,1

		declare @Mensaje varchar(max)='''',@XmlInicial varchar(max),@XmlFinal varchar(max)
		declare @usuario table(UsuarioID int,Nombre varchar(50),Apellido varchar(50),CodigoUsuario varchar(5),NombreUsuario varchar(50),Clave varchar(50),
							Documento varchar(50),
							Telefono varchar(20),Direccion varchar(200),RolID int,Activo bit,UsuarioCreaID int,FechaCrea datetime,UsuarioModificaID int,
							FechaModifica datetime)
		declare @usuario2 table(UsuarioID int,Nombre varchar(50),Apellido varchar(50),CodigoUsuario varchar(5),NombreUsuario varchar(50),Clave varchar(50),
							Documento varchar(50),
							Telefono varchar(20),Direccion varchar(200),RolID int,Activo bit,UsuarioCreaID int,FechaCrea datetime,UsuarioModificaID int,
							FechaModifica datetime)
		declare @tabla table(Resultado int, Mensaje varchar(max),IdAuditoria int)


		IF NOT EXISTS( select * from Tbl_Usuario where ((Nombre=@Nombre and Apellido=@Apellido) or CodigoUsuario=@CodigoUsuario) and UsuarioID<>@UsuarioID)
		BEGIN

			IF NOT EXISTS( select * from Tbl_Usuario where NombreUsuario=@NombreUsuario and UsuarioID<>@UsuarioID and NombreUsuario<>'''')
			BEGIN

				insert into @usuario(UsuarioID,Nombre,Apellido,CodigoUsuario,NombreUsuario,Clave,Documento,Telefono,Direccion,RolID,Activo,UsuarioCreaID,FechaCrea,
				UsuarioModificaID,FechaModifica)
				select UsuarioID,Nombre,Apellido,CodigoUsuario,NombreUsuario,Clave,Documento,Telefono,Direccion,RolID,Activo,UsuarioCreaID,FechaCrea,
				UsuarioModificaID,FechaModifica
				from Tbl_Usuario where UsuarioID=@UsuarioID

				insert into @usuario2(UsuarioID,Nombre,Apellido,CodigoUsuario,NombreUsuario,Clave,Documento,Telefono,Direccion,RolID,Activo,UsuarioCreaID,FechaCrea,
				UsuarioModificaID,FechaModifica)
				select UsuarioID,Nombre,Apellido,CodigoUsuario,NombreUsuario,Clave,Documento,Telefono,Direccion,RolID,Activo,UsuarioCreaID,FechaCrea,
				UsuarioModificaID,FechaModifica
				from Tbl_Usuario where UsuarioID=@UsuarioID

				update @usuario2 set Nombre=@Nombre,Apellido=@Apellido,NombreUsuario=@NombreUsuario,Clave=@Clave,CodigoUsuario=@CodigoUsuario,
									Documento=@Documento,Telefono=@Telefono,Direccion=@Direccion,RolID=@RolID,Activo=@Activo,
									UsuarioModificaID=@UsuarioModificaID,FechaModifica=GETDATE()
									where UsuarioID=@UsuarioID

				set @XmlInicial=convert(varchar(max),
				(select
					isnull(UsuarioID,0) UsuarioID,
					isnull(Nombre,'''') Nombre,
					isnull(Apellido,'''') Apellido,
					isnull(CodigoUsuario,'''') CodigoUsuario,
					isnull(NombreUsuario,'''') NombreUsuario,
					isnull(Clave,'''') Clave,
					isnull(Documento,'''') Documento,
					isnull(Telefono,'''') Telefono,
					isnull(Direccion,'''') Direccion,
					isnull(RolID,0) RolID,
					isnull(Activo,0) Activo,
					isnull(UsuarioCreaID,0) UsuarioCreaID,
					isnull(FechaCrea,'''') FechaCrea,
					isnull(UsuarioModificaID,0) UsuarioModificaID,
					isnull(FechaModifica,'''') FechaModifica
				from @usuario for xml raw, elements))

				set @XmlFinal=convert(varchar(max),
				(select
					isnull(UsuarioID,0) UsuarioID,
					isnull(Nombre,'''') Nombre,
					isnull(Apellido,'''') Apellido,
					isnull(CodigoUsuario,'''') CodigoUsuario,
					isnull(NombreUsuario,'''') NombreUsuario,
					isnull(Clave,'''') Clave,
					isnull(Documento,'''') Documento,
					isnull(Telefono,'''') Telefono,
					isnull(Direccion,'''') Direccion,
					isnull(RolID,0) RolID,
					isnull(Activo,0) Activo,
					isnull(UsuarioCreaID,0) UsuarioCreaID,
					isnull(FechaCrea,'''') FechaCrea,
					isnull(UsuarioModificaID,0) UsuarioModificaID,
					isnull(FechaModifica,'''') FechaModifica
				from @usuario2 for xml raw, elements))

				insert into @tabla
				exec SpInsertaAuditoria @UsuarioModificaID,''Tbl_Usuario'','''',@UsuarioID,@XmlFinal,2,@XmlInicial

				IF(select Resultado from @tabla)=1
				BEGIN

					update Tbl_Usuario set Nombre=@Nombre,Apellido=@Apellido,NombreUsuario=@NombreUsuario,Clave=@Clave,CodigoUsuario=@CodigoUsuario,
									Documento=@Documento,Telefono=@Telefono,Direccion=@Direccion,RolID=@RolID,Activo=@Activo,
									UsuarioModificaID=@UsuarioModificaID,FechaCrea=GETDATE()
									where UsuarioID=@UsuarioID

					select 1 Resultado, ''Usuario correctamente actualizado.'' Mensaje

				END
				ELSE
				BEGIN
					
					select Resultado, Mensaje from @tabla

				END
				

			END
			ELSE
			BEGIN

				select 0 Resultado, ''Ya existe un Usuario con el mismo Nombre de Usuario.'' Mensaje

			END

		END
		ELSE
		BEGIN

			select 0 Resultado, ''Ya existe un Usuario con el mismo Nombre y/o Código.'' Mensaje

		END

	END TRY  
  
  
	BEGIN CATCH  
  
		select 0 Resultado, CONVERT(varchar(max),ERROR_MESSAGE())+''      
		Error en la linea: ''+CONVERT(varchar(max),ERROR_LINE()) Mensaje  
  
	END CATCH 

END



' 
END
GO
/****** Object:  StoredProcedure [dbo].[SpModificaVenta]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SpModificaVenta]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		WILINTON BAQUERO
-- Create date: 2016-07-17
-- Modificate date: 2016-09-03
-- =============================================
CREATE PROCEDURE [dbo].[SpModificaVenta]
	@VentaID int,@UsuarioID int
AS
BEGIN
	SET NOCOUNT ON;

    BEGIN TRY
		
		declare @venta table  (VentaID int,ValorVenta int,UsuarioCreaID int,Fecha datetime,Interna bit, Activo bit,NumeroVentaDia int)
		declare @venta2 table  (VentaID int,ValorVenta int,UsuarioCreaID int,Fecha datetime,Interna bit, Activo bit,NumeroVentaDia int)
		declare @XmlInical varchar(max),@XmlFinal varchar(max),@ProductoID int,@Cantidad int
		declare @tabla table(Resultado int, Mensaje varchar(max),AuditoriaID int)
		declare @tabla2 table(Resultado int, Mensaje varchar(max))
		declare @VentaServicioID int

		insert into @venta(VentaID,ValorVenta,UsuarioCreaID,Fecha,Activo,NumeroVentaDia)
		select VentaID,ValorVenta,UsuarioCreaID,Fecha,Activo,NumeroVentaDia from Tbl_Venta where VentaID=@VentaID

		insert into @venta2(VentaID,ValorVenta,UsuarioCreaID,Fecha,Activo,NumeroVentaDia)
		select VentaID,ValorVenta,@UsuarioID,GETDATE(),0,NumeroVentaDia from Tbl_Venta where VentaID=@VentaID

		set @XmlInical=convert(varchar(max),
		(select 
			isnull(VentaID,0) VentaID,
			isnull(ValorVenta,0) ValorVenta,
			isnull(UsuarioCreaID,0) UsuarioCreaID,
			isnull(Fecha,'''') Fecha,
			isnull(Interna,0) Interna,
			isnull(Activo,0) Activo,
			isnull(NumeroVentaDia,0) NumeroVentaDia
		from @venta
		for xml raw, elements
		))

		set @XmlFinal=convert(varchar(max),
		(select 
			isnull(VentaID,0) VentaID,
			isnull(ValorVenta,0) ValorVenta,
			isnull(UsuarioCreaID,0) UsuarioCreaID,
			isnull(Fecha,'''') Fecha,
			isnull(Interna,0) Interna,
			isnull(Activo,0) Activo,
			isnull(NumeroVentaDia,0) NumeroVentaDia
		from @venta2
		for xml raw, elements
		))

		insert into @tabla
		exec SpInsertaAuditoria @UsuarioID,''Tbl_Venta'','''',@VentaID,@XmlFinal,2,@XmlInical
		
		IF (select Resultado from @tabla)=1 
		BEGIN

			update Tbl_Venta 
			set Activo=0,UsuarioCreaID=@UsuarioID,Fecha=GETDATE()
			where VentaID=@VentaID
			
			
			--Actualización de inventarios
			select * into #venta from Tbl_VentaServicio where VentaID=@VentaID

			WHILE( (select count(*) from #venta)>0 )
			BEGIN

				select @VentaServicioID=min(VentaServicioID) from #venta

				select * into #ventaProd from Tbl_VentaProducto where VentaServicioID=@VentaServicioID

				IF (select COUNT(*) from #ventaProd)>0
				BEGIN
						
					WHILE(select COUNT(*) from #ventaProd)>0
					BEGIN

						select @ProductoID=min(ProductoID) from #ventaProd

						select @ProductoID= x.ProductoID
							,@Cantidad=x.Cantidad*v.Cantidad
						from #ventaProd x
						inner join #venta v on x.VentaServicioID=v.VentaServicioID
						where x.ProductoID=@ProductoID

						exec SpModificaInventario @ProductoID,@Cantidad,@UsuarioID,1

						delete from #ventaProd where ProductoID=@ProductoID

					END

				END 

				delete from #venta where VentaServicioID=@VentaServicioID
			END

			select * into #Prod from Tbl_VentaProducto where VentaID=@VentaID and isnull(VentaServicioID,0)=0

			WHILE(select COUNT(*) from #Prod)>0
			BEGIN

				select @ProductoID=min(ProductoID) from #Prod

				select @ProductoID= x.ProductoID
					,@Cantidad=x.Cantidad
				from #ventaProd x
				where x.ProductoID=@ProductoID

				exec SpModificaInventario @ProductoID,@Cantidad,@UsuarioID,1

				delete from #Prod where ProductoID=@ProductoID

			END

			

			
			select 1 Resultado, ''Venta eliminada con Exito'' Mensaje 
		END
		ELSE
		BEGIN
					
			select Resultado, Mensaje from @tabla

		END
		

	END TRY  
  
  
	BEGIN CATCH  
  
		select 0 Resultado, CONVERT(varchar(max),ERROR_MESSAGE())+''      
		Error en la linea: ''+CONVERT(varchar(max),ERROR_LINE()) Mensaje  
  
	END CATCH 
END







' 
END
GO
/****** Object:  Table [dbo].[Tbl_AccionRegistro]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_AccionRegistro]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Tbl_AccionRegistro](
	[AccionRegistroID] [int] IDENTITY(1,1) NOT NULL,
	[NombreAccionRegistro] [varchar](50) NOT NULL,
	[Codigo] [varchar](3) NOT NULL,
 CONSTRAINT [PK_TBL_TAM_ACCION_RESGISTRO] PRIMARY KEY CLUSTERED 
(
	[AccionRegistroID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_AdelantoInsentivo]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_AdelantoInsentivo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Tbl_AdelantoInsentivo](
	[AdelantoInsentivoID] [int] IDENTITY(1,1) NOT NULL,
	[UsuarioAdelantoInsentivoID] [int] NOT NULL,
	[ValorAdelantoInsentivo] [int] NOT NULL,
	[Adelanto] [bit] NULL,
	[Activo] [bit] NOT NULL,
	[UsuarioCreaID] [int] NULL,
	[UsuarioModificaID] [int] NULL,
	[FechaCrea] [datetime] NULL,
	[FechaModifica] [datetime] NULL,
 CONSTRAINT [PK_Tbl_AdelantoInsentivo] PRIMARY KEY CLUSTERED 
(
	[AdelantoInsentivoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Tbl_Auditoria]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_Auditoria]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Tbl_Auditoria](
	[AuditoriaID] [int] IDENTITY(1,1) NOT NULL,
	[UsuarioID] [int] NOT NULL,
	[NombreTabla] [varchar](300) NOT NULL,
	[Campos] [varchar](max) NULL,
	[IdTabla] [int] NOT NULL,
	[CampoID] [varchar](max) NOT NULL,
	[ValorInicial] [xml] NULL,
	[ValorFinal] [xml] NULL,
	[AccionRegistroID] [int] NOT NULL,
	[FechaCambio] [datetime] NOT NULL,
 CONSTRAINT [PK_TBL_TAM_AUDITORIA] PRIMARY KEY CLUSTERED 
(
	[AuditoriaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_Cliente]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_Cliente]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Tbl_Cliente](
	[ClienteID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Correo] [varchar](200) NOT NULL,
	[Telefono] [varchar](100) NOT NULL,
	[Activo] [bit] NOT NULL,
	[UsuarioCreaID] [int] NULL,
	[UsuarioModificaID] [int] NULL,
	[FechaCrea] [datetime] NULL,
	[FechaModifica] [datetime] NULL,
 CONSTRAINT [PK_Tbl_Cliente] PRIMARY KEY CLUSTERED 
(
	[ClienteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_Correo]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_Correo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Tbl_Correo](
	[CorreoID] [int] IDENTITY(1,1) NOT NULL,
	[Cuenta] [varchar](300) NOT NULL,
	[Contrasenha] [varchar](50) NOT NULL,
	[Servidor] [varchar](50) NULL,
	[Puerto] [int] NULL,
	[Origen] [bit] NOT NULL,
 CONSTRAINT [PK_Tbl_Correo] PRIMARY KEY CLUSTERED 
(
	[CorreoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_Deposito]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_Deposito]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Tbl_Deposito](
	[DepositoID] [int] IDENTITY(1,1) NOT NULL,
	[ValorDeposito] [int] NOT NULL,
	[Activo] [bit] NOT NULL,
	[UsuarioCreaID] [int] NULL,
	[UsuarioModificaID] [int] NULL,
	[FechaCrea] [datetime] NULL,
	[FechaModifica] [datetime] NULL,
 CONSTRAINT [PK_Tbl_Deposito] PRIMARY KEY CLUSTERED 
(
	[DepositoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Tbl_Formulario]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_Formulario]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Tbl_Formulario](
	[FormularioID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Tbl_Fomulario] PRIMARY KEY CLUSTERED 
(
	[FormularioID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_Gasto]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_Gasto]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Tbl_Gasto](
	[GastoID] [int] IDENTITY(1,1) NOT NULL,
	[Detalle] [varchar](300) NOT NULL,
	[ValorGasto] [int] NOT NULL,
	[Activo] [bit] NOT NULL,
	[UsuarioCreaID] [int] NULL,
	[UsuarioModificaID] [int] NULL,
	[FechaCrea] [datetime] NULL,
	[FechaModifica] [datetime] NULL,
 CONSTRAINT [PK_Tbl_Gasto] PRIMARY KEY CLUSTERED 
(
	[GastoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_Inventario]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_Inventario]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Tbl_Inventario](
	[InventarioID] [int] IDENTITY(1,1) NOT NULL,
	[ProductoID] [int] NOT NULL,
	[CantidadUnidad] [int] NOT NULL,
	[UsuarioID] [int] NOT NULL,
	[FechaModifica] [datetime] NOT NULL,
 CONSTRAINT [PK_Tbl_Inventario] PRIMARY KEY CLUSTERED 
(
	[InventarioID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Tbl_Licencia]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_Licencia]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Tbl_Licencia](
	[LicenciaID] [int] IDENTITY(1,1) NOT NULL,
	[Board] [varchar](max) NOT NULL,
	[Mac] [varchar](max) NOT NULL,
 CONSTRAINT [PK_Tbl_Licencia] PRIMARY KEY CLUSTERED 
(
	[LicenciaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_PagoFactura]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_PagoFactura]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Tbl_PagoFactura](
	[PagoFacturaID] [int] IDENTITY(1,1) NOT NULL,
	[ProveedorID] [int] NOT NULL,
	[NumeroFactura] [varchar](20) NOT NULL,
	[ValorPagoFactura] [int] NOT NULL,
	[Activo] [bit] NOT NULL,
	[UsuarioCreaID] [int] NULL,
	[UsuarioModificaID] [int] NULL,
	[FechaCrea] [datetime] NULL,
	[FechaModifica] [datetime] NULL,
 CONSTRAINT [PK_Tbl_PagoFactura] PRIMARY KEY CLUSTERED 
(
	[PagoFacturaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_Producto]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_Producto]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Tbl_Producto](
	[ProductoID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[ProveedorID] [int] NULL,
	[UnidadxProducto] [int] NOT NULL,
	[ValorCompra] [int] NULL,
	[ValorVentaXUnidad] [int] NULL,
	[PorcentajeVentaPublico] [int] NULL,
	[DescuentoVentaInterna] [int] NULL,
	[Insumo] [bit] NOT NULL,
	[CodigoProducto] [varchar](5) NOT NULL,
	[Activo] [bit] NOT NULL,
	[UsuarioCreaID] [int] NULL,
	[UsuarioModificaID] [int] NULL,
	[FechaCrea] [datetime] NULL,
	[FechaModifica] [datetime] NULL,
 CONSTRAINT [PK_Tbl_Producto] PRIMARY KEY CLUSTERED 
(
	[ProductoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_Proveedor]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_Proveedor]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Tbl_Proveedor](
	[ProveedorID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Activo] [bit] NOT NULL,
	[UsuarioCreaID] [int] NULL,
	[UsuarioModificaID] [int] NULL,
	[FechaCrea] [datetime] NULL,
	[FechaModifica] [datetime] NULL,
 CONSTRAINT [PK_Tbl_Proveedor] PRIMARY KEY CLUSTERED 
(
	[ProveedorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_Rol]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_Rol]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Tbl_Rol](
	[RolID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
 CONSTRAINT [PK_Tbl_Rol] PRIMARY KEY CLUSTERED 
(
	[RolID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_RolFormulario]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_RolFormulario]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Tbl_RolFormulario](
	[RolFormularioID] [int] IDENTITY(1,1) NOT NULL,
	[RolID] [int] NOT NULL,
	[FormularioID] [int] NOT NULL,
 CONSTRAINT [PK_Tbl_RolFormulario] PRIMARY KEY CLUSTERED 
(
	[RolFormularioID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Tbl_Servicio]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_Servicio]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Tbl_Servicio](
	[ServicioID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](200) NOT NULL,
	[ValorVenta] [int] NOT NULL,
	[PorcentajeEstilista] [smallint] NULL,
	[Variable] [bit] NOT NULL,
	[CodigoServicio] [varchar](5) NOT NULL,
	[Activo] [bit] NOT NULL,
	[UsuarioCreaID] [int] NULL,
	[UsuarioModificaID] [int] NULL,
	[FechaCrea] [datetime] NULL,
	[FechaModifica] [datetime] NULL,
 CONSTRAINT [PK_Tbl_Servicio] PRIMARY KEY CLUSTERED 
(
	[ServicioID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_Usuario]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_Usuario]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Tbl_Usuario](
	[UsuarioID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[CodigoUsuario] [varchar](50) NOT NULL,
	[NombreUsuario] [varchar](50) NULL,
	[Clave] [varchar](50) NULL,
	[Documento] [varchar](50) NULL,
	[Telefono] [varchar](20) NULL,
	[Direccion] [varchar](200) NULL,
	[RolID] [int] NULL,
	[Activo] [bit] NULL,
	[UsuarioCreaID] [int] NOT NULL,
	[FechaCrea] [datetime] NOT NULL,
	[UsuarioModificaID] [int] NULL,
	[FechaModifica] [datetime] NULL,
 CONSTRAINT [PK_Tbl_Usuario] PRIMARY KEY CLUSTERED 
(
	[UsuarioID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_Venta]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_Venta]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Tbl_Venta](
	[VentaID] [int] IDENTITY(1,1) NOT NULL,
	[ValorVenta] [int] NOT NULL,
	[UsuarioCreaID] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Interna] [bit] NULL,
	[Activo] [bit] NULL,
	[NumeroVentaDia] [int] NULL,
 CONSTRAINT [PK_Tbl_Venta] PRIMARY KEY CLUSTERED 
(
	[VentaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Tbl_VentaProducto]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_VentaProducto]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Tbl_VentaProducto](
	[VentaProductoID] [int] IDENTITY(1,1) NOT NULL,
	[VentaID] [int] NOT NULL,
	[VentaServicioID] [int] NULL,
	[Cantidad] [int] NOT NULL,
	[ProductoID] [int] NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[ValorxUnidad] [int] NOT NULL,
	[ValorVentaXUnidad] [int] NOT NULL,
	[PorcentajeVentaPublico] [int] NULL,
	[DescuentoVentaInterna] [int] NULL,
	[Insumo] [bit] NOT NULL,
	[CodigoProducto] [varchar](5) NOT NULL,
	[CodigoTrabajo] [varchar](20) NULL,
	[UsuarioID] [int] NULL,
 CONSTRAINT [PK_Tbl_VentaProducto] PRIMARY KEY CLUSTERED 
(
	[VentaProductoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_VentaServicio]    Script Date: 21/09/2016 11:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_VentaServicio]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Tbl_VentaServicio](
	[VentaServicioID] [int] IDENTITY(1,1) NOT NULL,
	[VentaID] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[ServicioID] [int] NOT NULL,
	[Nombre] [varchar](200) NOT NULL,
	[ValorVenta] [int] NOT NULL,
	[PorcentajeEstilista] [smallint] NULL,
	[CodigoServicio] [varchar](5) NOT NULL,
	[CodigoTrabajo] [varchar](20) NOT NULL,
	[UsuarioID] [int] NOT NULL,
 CONSTRAINT [PK_Tbl_VentaServicio] PRIMARY KEY CLUSTERED 
(
	[VentaServicioID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_AccionRegistro] ON 

INSERT [dbo].[Tbl_AccionRegistro] ([AccionRegistroID], [NombreAccionRegistro], [Codigo]) VALUES (1, N'Inserción', N'INS')
INSERT [dbo].[Tbl_AccionRegistro] ([AccionRegistroID], [NombreAccionRegistro], [Codigo]) VALUES (2, N'Actualización', N'UPD')
INSERT [dbo].[Tbl_AccionRegistro] ([AccionRegistroID], [NombreAccionRegistro], [Codigo]) VALUES (3, N'Eliminación', N'DEL')
SET IDENTITY_INSERT [dbo].[Tbl_AccionRegistro] OFF
SET IDENTITY_INSERT [dbo].[Tbl_Correo] ON 

INSERT [dbo].[Tbl_Correo] ([CorreoID], [Cuenta], [Contrasenha], [Servidor], [Puerto], [Origen]) VALUES (1, N'peluqueriacalderonortiz@gmail.com', N'PelCalOr0', N'smtp.gmail.com', 587, 1)
INSERT [dbo].[Tbl_Correo] ([CorreoID], [Cuenta], [Contrasenha], [Servidor], [Puerto], [Origen]) VALUES (2, N'willys96@gmail.com', N'', N'', 0, 0)
SET IDENTITY_INSERT [dbo].[Tbl_Correo] OFF
SET IDENTITY_INSERT [dbo].[Tbl_Formulario] ON 

INSERT [dbo].[Tbl_Formulario] ([FormularioID], [Nombre]) VALUES (1, N'RadFormUsuarios')
INSERT [dbo].[Tbl_Formulario] ([FormularioID], [Nombre]) VALUES (2, N'RadFormProductos')
INSERT [dbo].[Tbl_Formulario] ([FormularioID], [Nombre]) VALUES (3, N'RadFormServicios')
INSERT [dbo].[Tbl_Formulario] ([FormularioID], [Nombre]) VALUES (4, N'RadFormVentas')
INSERT [dbo].[Tbl_Formulario] ([FormularioID], [Nombre]) VALUES (5, N'RadFormInventario')
INSERT [dbo].[Tbl_Formulario] ([FormularioID], [Nombre]) VALUES (6, N'RadFormReporte')
INSERT [dbo].[Tbl_Formulario] ([FormularioID], [Nombre]) VALUES (7, N'RadFormAdelantoInsentivo')
INSERT [dbo].[Tbl_Formulario] ([FormularioID], [Nombre]) VALUES (8, N'RadFormDeposito')
INSERT [dbo].[Tbl_Formulario] ([FormularioID], [Nombre]) VALUES (9, N'RadFormGasto')
INSERT [dbo].[Tbl_Formulario] ([FormularioID], [Nombre]) VALUES (10, N'RadFormPagoFactura')
INSERT [dbo].[Tbl_Formulario] ([FormularioID], [Nombre]) VALUES (11, N'RadFormProveedor')
INSERT [dbo].[Tbl_Formulario] ([FormularioID], [Nombre]) VALUES (12, N'RadFormCliente')
SET IDENTITY_INSERT [dbo].[Tbl_Formulario] OFF
SET IDENTITY_INSERT [dbo].[Tbl_Rol] ON 

INSERT [dbo].[Tbl_Rol] ([RolID], [Nombre]) VALUES (1, N'SuperAdministrador')
INSERT [dbo].[Tbl_Rol] ([RolID], [Nombre]) VALUES (2, N'Gerente')
INSERT [dbo].[Tbl_Rol] ([RolID], [Nombre]) VALUES (3, N'Administrador')
INSERT [dbo].[Tbl_Rol] ([RolID], [Nombre]) VALUES (4, N'Estilista')
SET IDENTITY_INSERT [dbo].[Tbl_Rol] OFF
SET IDENTITY_INSERT [dbo].[Tbl_RolFormulario] ON 

INSERT [dbo].[Tbl_RolFormulario] ([RolFormularioID], [RolID], [FormularioID]) VALUES (1, 1, 1)
INSERT [dbo].[Tbl_RolFormulario] ([RolFormularioID], [RolID], [FormularioID]) VALUES (2, 1, 2)
INSERT [dbo].[Tbl_RolFormulario] ([RolFormularioID], [RolID], [FormularioID]) VALUES (3, 1, 3)
INSERT [dbo].[Tbl_RolFormulario] ([RolFormularioID], [RolID], [FormularioID]) VALUES (4, 1, 4)
INSERT [dbo].[Tbl_RolFormulario] ([RolFormularioID], [RolID], [FormularioID]) VALUES (5, 2, 1)
INSERT [dbo].[Tbl_RolFormulario] ([RolFormularioID], [RolID], [FormularioID]) VALUES (6, 2, 2)
INSERT [dbo].[Tbl_RolFormulario] ([RolFormularioID], [RolID], [FormularioID]) VALUES (7, 2, 3)
INSERT [dbo].[Tbl_RolFormulario] ([RolFormularioID], [RolID], [FormularioID]) VALUES (8, 2, 4)
INSERT [dbo].[Tbl_RolFormulario] ([RolFormularioID], [RolID], [FormularioID]) VALUES (9, 3, 1)
INSERT [dbo].[Tbl_RolFormulario] ([RolFormularioID], [RolID], [FormularioID]) VALUES (10, 3, 2)
INSERT [dbo].[Tbl_RolFormulario] ([RolFormularioID], [RolID], [FormularioID]) VALUES (11, 3, 3)
INSERT [dbo].[Tbl_RolFormulario] ([RolFormularioID], [RolID], [FormularioID]) VALUES (12, 3, 4)
INSERT [dbo].[Tbl_RolFormulario] ([RolFormularioID], [RolID], [FormularioID]) VALUES (1002, 1, 5)
INSERT [dbo].[Tbl_RolFormulario] ([RolFormularioID], [RolID], [FormularioID]) VALUES (1003, 1, 6)
INSERT [dbo].[Tbl_RolFormulario] ([RolFormularioID], [RolID], [FormularioID]) VALUES (1004, 2, 5)
INSERT [dbo].[Tbl_RolFormulario] ([RolFormularioID], [RolID], [FormularioID]) VALUES (1005, 2, 6)
INSERT [dbo].[Tbl_RolFormulario] ([RolFormularioID], [RolID], [FormularioID]) VALUES (1006, 3, 5)
INSERT [dbo].[Tbl_RolFormulario] ([RolFormularioID], [RolID], [FormularioID]) VALUES (1007, 3, 6)
INSERT [dbo].[Tbl_RolFormulario] ([RolFormularioID], [RolID], [FormularioID]) VALUES (1008, 1, 7)
INSERT [dbo].[Tbl_RolFormulario] ([RolFormularioID], [RolID], [FormularioID]) VALUES (1009, 1, 8)
INSERT [dbo].[Tbl_RolFormulario] ([RolFormularioID], [RolID], [FormularioID]) VALUES (1010, 1, 9)
INSERT [dbo].[Tbl_RolFormulario] ([RolFormularioID], [RolID], [FormularioID]) VALUES (1011, 1, 10)
INSERT [dbo].[Tbl_RolFormulario] ([RolFormularioID], [RolID], [FormularioID]) VALUES (1012, 2, 7)
INSERT [dbo].[Tbl_RolFormulario] ([RolFormularioID], [RolID], [FormularioID]) VALUES (1013, 2, 8)
INSERT [dbo].[Tbl_RolFormulario] ([RolFormularioID], [RolID], [FormularioID]) VALUES (1014, 2, 9)
INSERT [dbo].[Tbl_RolFormulario] ([RolFormularioID], [RolID], [FormularioID]) VALUES (1015, 2, 10)
INSERT [dbo].[Tbl_RolFormulario] ([RolFormularioID], [RolID], [FormularioID]) VALUES (1016, 3, 7)
INSERT [dbo].[Tbl_RolFormulario] ([RolFormularioID], [RolID], [FormularioID]) VALUES (1017, 3, 8)
INSERT [dbo].[Tbl_RolFormulario] ([RolFormularioID], [RolID], [FormularioID]) VALUES (1018, 3, 9)
INSERT [dbo].[Tbl_RolFormulario] ([RolFormularioID], [RolID], [FormularioID]) VALUES (1019, 3, 10)
INSERT [dbo].[Tbl_RolFormulario] ([RolFormularioID], [RolID], [FormularioID]) VALUES (1020, 1, 11)
INSERT [dbo].[Tbl_RolFormulario] ([RolFormularioID], [RolID], [FormularioID]) VALUES (1021, 1, 12)
INSERT [dbo].[Tbl_RolFormulario] ([RolFormularioID], [RolID], [FormularioID]) VALUES (1022, 2, 11)
INSERT [dbo].[Tbl_RolFormulario] ([RolFormularioID], [RolID], [FormularioID]) VALUES (1023, 2, 12)
INSERT [dbo].[Tbl_RolFormulario] ([RolFormularioID], [RolID], [FormularioID]) VALUES (1024, 3, 11)
INSERT [dbo].[Tbl_RolFormulario] ([RolFormularioID], [RolID], [FormularioID]) VALUES (1025, 3, 12)
SET IDENTITY_INSERT [dbo].[Tbl_RolFormulario] OFF
SET IDENTITY_INSERT [dbo].[Tbl_Usuario] ON 

INSERT [dbo].[Tbl_Usuario] ([UsuarioID], [Nombre], [Apellido], [CodigoUsuario], [NombreUsuario], [Clave], [Documento], [Telefono], [Direccion], [RolID], [Activo], [UsuarioCreaID], [FechaCrea], [UsuarioModificaID], [FechaModifica]) VALUES (1, N'Administrador', N'Sistema', N'A1', N'Admin', N'Admin123*', N'', N'', N'', 1, 1, 1, CAST(0x0000A66F009085BA AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Tbl_Usuario] OFF
GO
