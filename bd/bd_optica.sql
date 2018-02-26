-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         10.1.22-MariaDB - mariadb.org binary distribution
-- SO del servidor:              Win64
-- HeidiSQL Versión:             9.4.0.5125
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Volcando estructura de base de datos para bd_optica
CREATE DATABASE IF NOT EXISTS `bd_optica` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `bd_optica`;

-- Volcando estructura para tabla bd_optica.anteojos
CREATE TABLE IF NOT EXISTS `anteojos` (
  `id_anteojos` int(11) NOT NULL AUTO_INCREMENT,
  `distancia` float NOT NULL,
  `segmentos` float NOT NULL,
  PRIMARY KEY (`id_anteojos`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla bd_optica.cierre_caja
CREATE TABLE IF NOT EXISTS `cierre_caja` (
  `id_cierre_caja` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` date NOT NULL,
  `id_productos` int(11) NOT NULL,
  `id_vale` int(11) NOT NULL,
  `abonos` float NOT NULL,
  `retiros` float NOT NULL,
  `caja` float NOT NULL,
  `ventas` float NOT NULL,
  `total` float NOT NULL,
  PRIMARY KEY (`id_cierre_caja`),
  KEY `id_productos` (`id_productos`),
  KEY `id_vale` (`id_vale`),
  CONSTRAINT `cierre_caja_ibfk_1` FOREIGN KEY (`id_productos`) REFERENCES `productos` (`id_productos`),
  CONSTRAINT `cierre_caja_ibfk_2` FOREIGN KEY (`id_vale`) REFERENCES `vales` (`id_vale`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla bd_optica.cliente
CREATE TABLE IF NOT EXISTS `cliente` (
  `id_cliente` int(11) NOT NULL AUTO_INCREMENT,
  `cedula` varchar(9) NOT NULL,
  `nombre` varchar(45) NOT NULL,
  `apellido1` varchar(45) NOT NULL,
  `apellido2` varchar(45) NOT NULL,
  `direccion` varchar(64) DEFAULT NULL,
  `telefono` varchar(8) DEFAULT NULL,
  `deuda` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla bd_optica.consultas
CREATE TABLE IF NOT EXISTS `consultas` (
  `id_consulta` int(11) NOT NULL AUTO_INCREMENT,
  `cedula` varchar(128) DEFAULT NULL,
  `nombre_paciente` varchar(128) NOT NULL,
  `telefono` varchar(50) DEFAULT NULL,
  `detalle` varchar(50) DEFAULT NULL,
  `fecha` date NOT NULL,
  `estado` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_consulta`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla bd_optica.control_trabajo
CREATE TABLE IF NOT EXISTS `control_trabajo` (
  `id_control_trabajo` int(11) NOT NULL AUTO_INCREMENT,
  `id_cliente` int(11) NOT NULL,
  `id_tarjeta` int(11) NOT NULL,
  `fecha` date NOT NULL,
  PRIMARY KEY (`id_control_trabajo`),
  KEY `id_cliente` (`id_cliente`),
  KEY `id_tarjeta` (`id_tarjeta`),
  CONSTRAINT `control_trabajo_ibfk_1` FOREIGN KEY (`id_cliente`) REFERENCES `cliente` (`id_cliente`),
  CONSTRAINT `control_trabajo_ibfk_2` FOREIGN KEY (`id_tarjeta`) REFERENCES `tarjetas` (`id_tarjeta`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla bd_optica.detalle_venta
CREATE TABLE IF NOT EXISTS `detalle_venta` (
  `id_detalle` int(11) NOT NULL AUTO_INCREMENT,
  `id_venta` int(11) NOT NULL,
  `codigoProd` varchar(50) NOT NULL,
  `cantidad` int(4) NOT NULL,
  `precio` float(10,2) NOT NULL,
  `total` float(10,2) NOT NULL,
  `estado` varchar(1) NOT NULL,
  PRIMARY KEY (`id_detalle`),
  KEY `id_venta` (`id_venta`),
  CONSTRAINT `detalle_venta_ibfk_1` FOREIGN KEY (`id_venta`) REFERENCES `venta` (`id_venta`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla bd_optica.factura
CREATE TABLE IF NOT EXISTS `factura` (
  `id_factura` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` date DEFAULT NULL,
  `id_cliente` int(11) NOT NULL,
  `id_producto` int(11) NOT NULL,
  `id_armazon` int(11) NOT NULL,
  `id_lente` int(11) NOT NULL,
  PRIMARY KEY (`id_factura`),
  KEY `id_cliente` (`id_cliente`),
  KEY `id_producto` (`id_producto`),
  KEY `id_armazon` (`id_armazon`),
  KEY `id_lente` (`id_lente`),
  CONSTRAINT `factura_ibfk_1` FOREIGN KEY (`id_cliente`) REFERENCES `cliente` (`id_cliente`),
  CONSTRAINT `factura_ibfk_2` FOREIGN KEY (`id_producto`) REFERENCES `productos` (`id_productos`),
  CONSTRAINT `factura_ibfk_3` FOREIGN KEY (`id_armazon`) REFERENCES `armazon` (`id_armazon`),
  CONSTRAINT `factura_ibfk_4` FOREIGN KEY (`id_lente`) REFERENCES `lente` (`id_lente`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla bd_optica.graduacion
CREATE TABLE IF NOT EXISTS `graduacion` (
  `id_graduacion` int(11) NOT NULL AUTO_INCREMENT,
  `esferaIzquierda` float NOT NULL,
  `cilindroIzquierda` float NOT NULL,
  `ejeIzquierda` int(4) NOT NULL,
  `adicionesIzquierda` float NOT NULL,
  `esferaDerecha` float NOT NULL,
  `cilindroDerecha` float NOT NULL,
  `ejeDerecha` int(11) NOT NULL,
  `adicionesDerecha` float NOT NULL,
  PRIMARY KEY (`id_graduacion`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla bd_optica.movimientos
CREATE TABLE IF NOT EXISTS `movimientos` (
  `id_movimientos` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` date NOT NULL,
  `id_reciboxdinero` int(11) NOT NULL,
  `id_tarjeta` int(11) NOT NULL,
  `id_cierre_caja` int(11) NOT NULL,
  `id_consulta` int(11) NOT NULL,
  PRIMARY KEY (`id_movimientos`),
  KEY `id_reciboxdinero` (`id_reciboxdinero`),
  KEY `id_tarjeta` (`id_tarjeta`),
  KEY `id_cierre_caja` (`id_cierre_caja`),
  KEY `id_consulta` (`id_consulta`),
  CONSTRAINT `movimientos_ibfk_1` FOREIGN KEY (`id_reciboxdinero`) REFERENCES `recibosxdinero` (`id_recibo`),
  CONSTRAINT `movimientos_ibfk_2` FOREIGN KEY (`id_tarjeta`) REFERENCES `tarjetas` (`id_tarjeta`),
  CONSTRAINT `movimientos_ibfk_3` FOREIGN KEY (`id_cierre_caja`) REFERENCES `cierre_caja` (`id_cierre_caja`),
  CONSTRAINT `movimientos_ibfk_4` FOREIGN KEY (`id_consulta`) REFERENCES `consultas` (`id_consulta`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla bd_optica.productos
CREATE TABLE IF NOT EXISTS `productos` (
  `id_productos` int(11) NOT NULL AUTO_INCREMENT,
  `codigo` varchar(128) NOT NULL,
  `nombre` varchar(128) NOT NULL,
  `detalle` varchar(128) NOT NULL,
  `monto` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `marca` varchar(50) NOT NULL,
  `tipo` varchar(50) NOT NULL,
  `iva` varchar(50) NOT NULL,
  `estado` varchar(128) NOT NULL,
  PRIMARY KEY (`id_productos`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla bd_optica.proforma
CREATE TABLE IF NOT EXISTS `proforma` (
  `id_proforma` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` date DEFAULT NULL,
  `id_cliente` int(11) NOT NULL,
  `id_producto` int(11) NOT NULL,
  PRIMARY KEY (`id_proforma`),
  KEY `id_cliente` (`id_cliente`),
  KEY `id_producto` (`id_producto`),
  CONSTRAINT `proforma_ibfk_1` FOREIGN KEY (`id_cliente`) REFERENCES `cliente` (`id_cliente`),
  CONSTRAINT `proforma_ibfk_2` FOREIGN KEY (`id_producto`) REFERENCES `productos` (`id_productos`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla bd_optica.tarjetas
CREATE TABLE IF NOT EXISTS `tarjetas` (
  `id_tarjeta` int(11) NOT NULL AUTO_INCREMENT,
  `id_cliente` int(11) NOT NULL,
  `id_producto_armazon` int(11) NOT NULL,
  `detalle_armazon` varchar(50) DEFAULT NULL,
  `id_producto_lente` int(11) NOT NULL,
  `detalle_lente` varchar(50) DEFAULT NULL,
  `fecha_entrega` date DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `id_graduacion` int(11) NOT NULL,
  `distancia` varchar(50) DEFAULT NULL,
  `recibida` varchar(50) DEFAULT NULL,
  `segineatos` double DEFAULT NULL,
  PRIMARY KEY (`id_tarjeta`),
  KEY `id_cliente` (`id_cliente`),
  KEY `id_anteojos` (`id_producto_armazon`),
  KEY `id_producto` (`id_producto_lente`),
  KEY `id_graduacion` (`id_graduacion`),
  CONSTRAINT `FK_tarjetas_graduacion` FOREIGN KEY (`id_graduacion`) REFERENCES `graduacion` (`id_graduacion`),
  CONSTRAINT `tarjetas_ibfk_1` FOREIGN KEY (`id_cliente`) REFERENCES `cliente` (`id_cliente`),
  CONSTRAINT `tarjetas_ibfk_3` FOREIGN KEY (`id_producto_armazon`) REFERENCES `productos` (`id_productos`),
  CONSTRAINT `tarjetas_ibfk_4` FOREIGN KEY (`id_producto_lente`) REFERENCES `productos` (`id_productos`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla bd_optica.usuario
CREATE TABLE IF NOT EXISTS `usuario` (
  `id_usuario` int(11) NOT NULL AUTO_INCREMENT,
  `cedula` varchar(9) NOT NULL,
  `contrasenna` varchar(16) NOT NULL,
  `nombre` varchar(45) NOT NULL,
  `estado` char(1) NOT NULL,
  `cargo` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla bd_optica.vales
CREATE TABLE IF NOT EXISTS `vales` (
  `id_vale` int(11) NOT NULL AUTO_INCREMENT,
  `monto` float NOT NULL,
  `descripcion` varchar(128) NOT NULL,
  `fecha` date NOT NULL,
  PRIMARY KEY (`id_vale`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla bd_optica.venta
CREATE TABLE IF NOT EXISTS `venta` (
  `id_venta` int(11) NOT NULL AUTO_INCREMENT,
  `id_cliente` int(11) NOT NULL,
  `id_usuario` int(11) NOT NULL,
  `fecha` varchar(50) NOT NULL,
  `modo_pago` int(1) NOT NULL COMMENT '1 = efectivo 2 = tarjeta',
  `saldo` double(10,2) NOT NULL,
  `estado` varchar(1) NOT NULL COMMENT 'A = activo I = inactivo',
  PRIMARY KEY (`id_venta`),
  KEY `FK_venta_cliente` (`id_cliente`),
  KEY `FK_venta_usuario` (`id_usuario`),
  CONSTRAINT `FK_venta_cliente` FOREIGN KEY (`id_cliente`) REFERENCES `cliente` (`id_cliente`),
  CONSTRAINT `FK_venta_usuario` FOREIGN KEY (`id_usuario`) REFERENCES `usuario` (`id_usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para procedimiento bd_optica.consultar_cantidadImpresoras
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `consultar_cantidadImpresoras`()
BEGIN
	SELECT COUNT(id_impresora) as cantidad FROM impresoras
	WHERE estado = "A";
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_optica.consultar_CitaCedula
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `consultar_CitaCedula`(
	IN `ced` VARCHAR(50)
)
BEGIN
 SELECT * FROM consultas
 WHERE cedula = ced;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_optica.consultar_CitaNombre
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `consultar_CitaNombre`(
	IN `nom` VARCHAR(50)
)
BEGIN
 SELECT * FROM consultas
 WHERE nombre_paciente = nom;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_optica.consultar_cita_eliminar
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `consultar_cita_eliminar`(
	IN `ced` VARCHAR(50)
)
BEGIN
 SELECT *
  FROM consultas
  WHERE cedula = @ced;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_optica.consultar_cliente
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `consultar_cliente`(
	IN `id_client` INT(16)
)
BEGIN
 SELECT id_cliente,cedula,nombre,apellido1,apellido2,direccion,telefono,deuda FROM cliente
 WHERE id_cliente = id_client;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_optica.consultar_clienteCedula
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `consultar_clienteCedula`(
	IN `ced` VARCHAR(9)
)
BEGIN
	SELECT id_cliente,cedula,nombre,apellido1,apellido2,direccion,telefono,deuda FROM cliente
	WHERE cedula = ced;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_optica.consultar_expediente
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `consultar_expediente`(
	IN `ced` int(9)
)
BEGIN
 SELECT id_cliente,nombre, cedula 
 FROM cliente
 WHERE cedula = ced;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_optica.consultar_Graduacion
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `consultar_Graduacion`(
	IN `cliente_id` VARCHAR(50)





)
BEGIN
SELECT  graduacion.esferaDerecha as ESP, graduacion.cilindroDerecha as CIL, graduacion.ejeDerecha as EJE, 
graduacion.adicionesDerecha as Adiciones FROM graduacion,cliente,tarjetas
WHERE cliente.id_cliente=cliente_id
AND cliente.id_cliente = tarjetas.id_cliente
AND graduacion.id_graduacion=tarjetas.id_graduacion
UNION
SELECT  graduacion.esferaIzquierda ,graduacion.cilindroIzquierda, graduacion.ejeIzquierda, graduacion.adicionesIzquierda
FROM graduacion,cliente,tarjetas
WHERE cliente.id_cliente=cliente_id
AND cliente.id_cliente = tarjetas.id_cliente
AND graduacion.id_graduacion=tarjetas.id_graduacion
;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_optica.consultar_producto
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `consultar_producto`(
	IN `parametro` VARCHAR(128)



)
BEGIN
	SELECT id_productos,codigo,nombre,detalle,monto,cantidad, marca, tipo, iva, estado FROM productos
	WHERE codigo LIKE parametro or nombre LIKE parametro and estado = "A"
	Order by codigo ASC;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_optica.consultar_productoCodigo
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `consultar_productoCodigo`(
	IN `cod` VARCHAR(50)


)
BEGIN
SELECT id_productos,codigo,nombre,detalle,monto,cantidad, tipo,iva, estado FROM productos
WHERE codigo LIKE cod and estado = "A";
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_optica.consultar_productoNombre
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `consultar_productoNombre`(
 IN `nomb` VARCHAR(128)


)
BEGIN
 SELECT id_productos,codigo,nombre,detalle,monto,cantidad,estado FROM productos
 WHERE nombre LIKE nomb AND estado = "A";
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_optica.consultar_tarjeta
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `consultar_tarjeta`(
	IN `id_cliente` INT







)
BEGIN
SELECT DISTINCT tarjetas.distancia,tarjetas.segineatos,tarjetas.id_producto_armazon, tarjetas.detalle_armazon, tarjetas.id_producto_lente,tarjetas.detalle_lente,tarjetas.fecha_entrega,
tarjetas.recibida, tarjetas.fecha FROM tarjetas
WHERE tarjetas.id_cliente = id_cliente;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_optica.consultar_ultimoVenta
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `consultar_ultimoVenta`()
BEGIN
	SELECT AUTO_INCREMENT as siguiente
    FROM information_schema.TABLES AS t1
    WHERE t1.TABLE_SCHEMA = 'bd_optica' and t1.TABLE_NAME = 'venta';
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_optica.consultar_usuario
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `consultar_usuario`(
	IN `id` VARCHAR(9)

)
BEGIN
	SELECT * FROM usuario
	WHERE id_usuario = id  AND estado = "A";
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_optica.inactivar_cita
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `inactivar_cita`(
	IN `ced` VARCHAR(50)
)
    NO SQL
BEGIN
 UPDATE consultas
 SET consultas.estado = "I"
 WHERE consultas.cedula = ced;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_optica.inactivar_producto
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `inactivar_producto`(IN cod VARCHAR(128))
BEGIN
 UPDATE productos
 SET estado = "I"
 WHERE codigo = cod;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_optica.inactivar_usuario
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `inactivar_usuario`(IN ced VARCHAR(9))
BEGIN
	UPDATE usuario
	SET estado = "I"
	WHERE cedula = ced;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_optica.insertar_cita
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `insertar_cita`(IN `cedula` VARCHAR(15), IN `nombre` VARCHAR(30), IN `telefono` VARCHAR(20), IN `detalle` VARCHAR(200), IN `fecha` DATE, IN `estado` VARCHAR(1))
    NO SQL
BEGIN
 INSERT INTO consultas (cedula,nombre_paciente,telefono,detalle,fecha,estado)
 VALUES(cedula,nombre,telefono,detalle,fecha,estado);
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_optica.insertar_cliente
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `insertar_cliente`(
IN cedula VARCHAR(128), 
IN nombre VARCHAR(128),
IN apellido1 VARCHAR(128),
IN apellido2 VARCHAR(128),
IN direccion VARCHAR(128), 
IN telefono VARCHAR(128), 
IN deuda INT(11)
)
BEGIN
INSERT INTO cliente (cedula,nombre,apellido1,apellido2,direccion,telefono,deuda)
VALUES(cedula,nombre,apellido1,apellido2,direccion,telefono,deuda);
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_optica.insertar_DetalleVenta
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `insertar_DetalleVenta`(
	IN `id_venta` INT(11),
	IN `codigo` VARCHAR(50),
	IN `cantidad` INT(11),
	IN `precio` DOUBLE(10,2),
	IN `subtotal` DOUBLE(10,2),
	IN `estado` VARCHAR(1)

)
BEGIN
	INSERT INTO detalle_venta(id_venta, codigoProd, cantidad, precio, total, estado)
    VALUES(id_venta, codigo, cantidad, precio, subtotal, estado);
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_optica.insertar_graduacion
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `insertar_graduacion`(
	IN `esiz` FLOAT,
	IN `ciliz` FLOAT,
	IN `ejeiz` INT,
	IN `adiz` FLOAT,
	IN `esder` FLOAT,
	IN `cilder` FLOAT,
	IN `ejeder` INT,
	IN `ader` FLOAT
)
BEGIN
	INSERT INTO graduacion(graduacion.esferaIzquierda, graduacion.cilindroIzquierda,graduacion.ejeIzquierda,graduacion.adicionesIzquierda
								 ,graduacion.esferaDerecha,graduacion.cilindroDerecha,graduacion.ejeDerecha,graduacion.adicionesDerecha)
    VALUES(esiz, ciliz, ejeiz, adiz, esder, cilder, ejeder, ader);
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_optica.insertar_producto
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `insertar_producto`(
	IN `codigo` VARCHAR(128),
	IN `nombre` VARCHAR(128),
	IN `detalle` VARCHAR(128),
	IN `monto` FLOAT,
	IN `cantidad` INT(11),
	IN `marca` VARCHAR(50),
	IN `tipo` VARCHAR(50),
	IN `iva` VARCHAR(50)
,
	IN `estado` VARCHAR(1)
)
BEGIN
	INSERT INTO productos (codigo,nombre,detalle,monto,cantidad, marca, tipo, iva, estado)
	VALUES(codigo,nombre,detalle,monto,cantidad, marca, tipo, iva, estado);
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_optica.insertar_recibo
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `insertar_recibo`(
IN fecha DATETIME,
IN id_cliente INT(11),
IN id_usuario INT(11),
IN concepto VARCHAR(256),
IN cliente_deuda FLOAT,
IN monto_abono FLOAT,
IN monto_actual FLOAT
)
BEGIN
	INSERT INTO recibosxdinero(fecha_actual, id_cliente, id_usuario, concepto, cliente_deuda, monto_abono, monto_actual)
    VALUES(fecha, id_cliente, id_usuario, concepto, cliente_deuda, monto_abono, monto_actual);
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_optica.insertar_tarjeta_nueva
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `insertar_tarjeta_nueva`(
	IN `id_cliente` INT,
	IN `id_producto_lente` INT,
	IN `detalle_lenten` VARCHAR(50),
	IN `id_producto_armazon` INT,
	IN `detalle_armazon` VARCHAR(50),
	IN `fecha_entrega` DATETIME,
	IN `fecha` DATETIME,
	IN `id_graduacion` INT,
	IN `distancia` VARCHAR(50),
	IN `recibida` VARCHAR(50),
	IN `segineatos` DOUBLE
)
BEGIN
	INSERT INTO tarjetas(tarjetas.id_cliente,tarjetas.id_producto_lente,tarjetas.detalle_lente,tarjetas.id_producto_armazon,tarjetas.detalle_armazon,tarjetas.fecha_entrega,tarjetas.fecha,tarjetas.id_graduacion,tarjetas.distancia,tarjetas.recibida,tarjetas.segineatos)
    VALUES(id_cliente, id_producto_lente, detalle_lenten, id_producto_armazon, detalle_armazon, fecha_entrega, fecha, id_graduacion,distancia,recibida,segineatos);
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_optica.insertar_usuario
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `insertar_usuario`(

IN ced VARCHAR(9), 

IN contra VARCHAR(16), 

IN nomb VARCHAR(45),

IN carg VARCHAR(50),

IN est VARCHAR(1))
BEGIN
	
INSERT INTO usuario(cedula, contrasenna,nombre,cargo,estado)
	
VALUES (ced,contra,nomb,carg,est);

END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_optica.insertar_venta
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `insertar_venta`(
	IN `id_cliente` INT(11),
	IN `id_usuario` INT(11),
	IN `fecha` VARCHAR(50),
	IN `modo_pago` INT(1),
    IN `saldo` DOUBLE(10,2), 
	IN `estado` VARCHAR(1)
)
BEGIN
	INSERT INTO venta(id_cliente, id_usuario, fecha, modo_pago, saldo, estado)
    VALUES(id_cliente, id_usuario, fecha, modo_pago, saldo, estado);
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_optica.listarCliente
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `listarCliente`()
SELECT * FROM cliente//
DELIMITER ;

-- Volcando estructura para procedimiento bd_optica.listarClienteSinTarjeta
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `listarClienteSinTarjeta`()
BEGIN
SELECT DISTINCT cliente.id_cliente, cliente.cedula, cliente.nombre , cliente.apellido1, cliente.apellido2, cliente.direccion, cliente.telefono, cliente.deuda
FROM cliente
WHERE NOT EXISTS(SELECT DISTINCT tarjetas.id_cliente FROM tarjetas WHERE tarjetas.id_cliente = cliente.id_cliente) ;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_optica.listar_citas
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `listar_citas`()
    NO SQL
BEGIN
SELECT cedula,nombre_paciente,telefono,detalle,fecha FROM consultas
 WHERE estado = "A" and fecha >= curdate() - interval 11 month;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_optica.listar_citasAnio
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `listar_citasAnio`()
BEGIN
 SELECT cedula,nombre_paciente,telefono,detalle,fecha FROM consultas
 WHERE estado = "A" and fecha <= curdate() - interval 1 year;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_optica.listar_cliente
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `listar_cliente`()
SELECT * FROM cliente//
DELIMITER ;

-- Volcando estructura para procedimiento bd_optica.listar_expediente
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `listar_expediente`()
SELECT DISTINCT cliente.id_cliente, cliente.cedula, cliente.nombre , cliente.apellido1, cliente.apellido2, cliente.direccion, cliente.telefono, cliente.deuda
FROM cliente
WHERE EXISTS(SELECT DISTINCT tarjetas.id_cliente FROM tarjetas WHERE tarjetas.id_cliente = cliente.id_cliente)//
DELIMITER ;

-- Volcando estructura para procedimiento bd_optica.listar_productos
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `listar_productos`()
BEGIN
	SELECT * FROM productos
	WHERE estado = "A";
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_optica.listar_productos_Armazon
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `listar_productos_Armazon`()
BEGIN
	SELECT * FROM productos
	WHERE estado = "A"
	AND tipo = "Armazon";
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_optica.listar_productos_lentes
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `listar_productos_lentes`()
BEGIN
	SELECT * FROM productos
	WHERE estado = "A"
	AND tipo = "Lente";
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_optica.listar_usuarios
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `listar_usuarios`()
BEGIN
	SELECT id_usuario, cedula, contrasenna, nombre, cargo, estado FROM usuario
	WHERE estado = "A";
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_optica.modificar_cita
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `modificar_cita`(
	IN `val` VARCHAR(15),
	IN `ced` VARCHAR(15),
	IN `nomb` VARCHAR(30),
	IN `tel` VARCHAR(20),
	IN `det` VARCHAR(200),
	IN `fech` DATE,
	IN `est` VARCHAR(1)



)
    NO SQL
BEGIN
 UPDATE consultas
    SET consultas.cedula=ced,consultas.nombre_paciente=nomb,consultas.telefono=tel,consultas.detalle=det,consultas.fecha=fech,consultas.estado=est
 WHERE consultas.cedula=val;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_optica.modificar_cliente
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `modificar_cliente`(
 IN `id_client` INT(11),
 IN `ced` VARCHAR(128),
 IN `nom` VARCHAR(128),
 IN `ape1` VARCHAR(128),
 IN `ape2` VARCHAR(128),
 IN `direc` VARCHAR(128),
 IN `tele` VARCHAR(128),
 IN `deu` INT(11)
)
BEGIN
 UPDATE cliente 
    SET cedula=ced,nombre=nom,apellido1=ape1,apellido2=ape2,direccion=direc,telefono=tele,deuda=deu
 WHERE id_cliente=id_client;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_optica.modificar_detalleVenta
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `modificar_detalleVenta`(
IN id_DetalleVenta INT(11),
IN id_venta INT(11),
IN id_producto INT(11),
IN cantidad INT(11),
IN precio FLOAT,
IN total FLOAT
)
BEGIN
	UPDATE detalle_venta
	SET id_venta = id_venta, id_producto = id_producto, cantidad = cantidad, precio = precio, total = total
    WHERE id_detalle = id_DetalleVenta;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_optica.modificar_graduacion
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `modificar_graduacion`(
	IN `id_client` INT
,
	IN `esiz` FLOAT,
	IN `ciliz` FLOAT,
	IN `ejeiz` INT,
	IN `adiz` FLOAT,
	IN `esder` FLOAT,
	IN `cilder` FLOAT,
	IN `ejeder` INT,
	IN `adder` FLOAT





)
BEGIN
 UPDATE graduacion, tarjetas 
    SET graduacion.esferaIzquierda=esiz,graduacion.esferaDerecha=esder,graduacion.cilindroIzquierda=ciliz,graduacion.cilindroDerecha=cilder,graduacion.ejeIzquierda=ejeiz,
	 graduacion.ejeDerecha=ejeder,graduacion.adicionesIzquierda=adiz,graduacion.adicionesDerecha=adder
 WHERE tarjetas.id_cliente= id_client 
 AND graduacion.id_graduacion=tarjetas.id_tarjeta;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_optica.modificar_producto
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `modificar_producto`(
	IN `cod` VARCHAR(128),
	IN `nomb` VARCHAR(128),
	IN `detal` VARCHAR(128),
	IN `mont` FLOAT,
	IN `cant` INT(11),
	IN `marca` VARCHAR(50),
	IN `tipo` VARCHAR(50),
	IN `iva` VARCHAR(50),
	IN `est` VARCHAR(1)
)
BEGIN
	UPDATE productos 
    SET codigo=cod,nombre=nomb,detalle=detal,monto=mont,cantidad=cant, marca = marca, tipo = tipo, iva = iva, estado=est
	WHERE codigo=cod;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_optica.modificar_tarjeta
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `modificar_tarjeta`(
	IN `id_cliente` INT
,
	IN `id_anteojos` INT,
	IN `darm` VARCHAR(50),
	IN `id_producto` INT,
	IN `dlen` VARCHAR(50),
	IN `fechE` DATETIME,
	IN `fech` DATETIME,
	IN `di` DOUBLE,
	IN `res` VARCHAR(4),
	IN `seg` DOUBLE






)
BEGIN
UPDATE tarjetas 
SET tarjetas.id_producto_lente=id_anteojos,tarjetas.detalle_lente=dlen,tarjetas.id_producto_armazon=id_producto,tarjetas.detalle_armazon=darm,tarjetas.fecha_entrega=fechE,tarjetas.fecha=fech,tarjetas.distancia=di,tarjetas.recibida=res,tarjetas.segineatos=seg
WHERE tarjetas.id_cliente=id_cliente;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_optica.modificar_usuario
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `modificar_usuario`(
IN id INT(11),

IN cedula VARCHAR(9), 

IN contrasena VARCHAR(16), 

IN nombre VARCHAR(45),

IN cargo VARCHAR(50),

IN estado VARCHAR(1))
BEGIN
	
UPDATE usuario
	
SET cedula = cedula, nombre = nombre, contrasenna = contrasena, cargo = cargo, estado = estado
	
WHERE id_usuario = id;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_optica.modificar_Venta
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `modificar_Venta`(
IN id_venta INT(11),
IN id_cliente INT(11),
IN fecha DATETIME,
IN id_usuario INT(11),
IN id_pago INT(11), 
IN estado CHAR
)
BEGIN
	UPDATE venta
	SET id_cliente = id_cliente, fecha = fecha, id_usuario = id_usuario, id_pago = id_pago, estado = estado
    WHERE id_venta = id_venta;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_optica.mostrar_ultima_graduacion
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `mostrar_ultima_graduacion`()
BEGIN
SELECT graduacion.id_graduacion FROM graduacion
ORDER BY graduacion.id_graduacion DESC LIMIT 1;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_optica.reporte_ventas_dia
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `reporte_ventas_dia`(
	IN `fecha` VARCHAR(50)

)
BEGIN
	SELECT  t1.fecha AS Fecha, t1.id_venta AS N_Recibo, t2.codigoProd AS Cod_Prod, 
    t1.modo_pago AS Modo_Pago, t3.nombre as Nombre, t2.total as Total
   FROM venta t1
   INNER JOIN detalle_venta t2 ON t1.id_venta = t2.id_venta
   INNER JOIN productos t3 ON t2.codigoProd = t3.codigo
   WHERE t1.fecha = fecha AND t1.estado = "A" 
   ORDER BY N_Recibo;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_optica.reporte_ventas_mensual
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `reporte_ventas_mensual`(IN fecha1 VARCHAR(50), IN fecha2 VARCHAR(50))
BEGIN
	SELECT  t1.fecha AS Fecha, t1.id_venta AS N_Recibo, t2.codigoProd AS Cod_Prod, 
    t1.modo_pago AS Modo_Pago, t3.nombre as Nombre, t2.total as Total
	FROM venta t1
	INNER JOIN detalle_venta t2 ON t1.id_venta = t2.id_venta
	INNER JOIN productos t3 ON t2.codigoProd = t3.codigo
	WHERE t1.fecha BETWEEN fecha1 AND fecha2 
    AND t1.estado = "A" 
	ORDER BY N_Recibo;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_optica.reporte_ventas_semanal
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `reporte_ventas_semanal`(IN fecha1 VARCHAR(50), IN fecha2 VARCHAR(50))
BEGIN
	SELECT  t1.fecha AS Fecha, t1.id_venta AS N_Recibo, t2.codigoProd AS Cod_Prod, 
    t1.modo_pago AS Modo_Pago, t3.nombre as Nombre, t2.total as Total
	FROM venta t1
	INNER JOIN detalle_venta t2 ON t1.id_venta = t2.id_venta
	INNER JOIN productos t3 ON t2.codigoProd = t3.codigo
	WHERE t1.fecha BETWEEN fecha1 AND fecha2 
    AND t1.estado = "A" 
	ORDER BY N_Recibo;
END//
DELIMITER ;

-- Volcando estructura para disparador bd_optica.venta_AFTER_INSERT
SET @OLDTMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION';
DELIMITER //
CREATE TRIGGER `venta_AFTER_INSERT` AFTER INSERT ON `venta` FOR EACH ROW BEGIN
	DECLARE monto DOUBLE;
    SET monto = 0;
	SELECT saldo INTO monto FROM venta
    WHERE id_venta = NEW.id_venta;
	UPDATE cliente SET deuda = monto
    WHERE id_cliente = NEW.id_cliente;
END//
DELIMITER ;
SET SQL_MODE=@OLDTMP_SQL_MODE;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
