/* Consulta de cantidad de hs trabajadas por funcionario en un rango de fecha dado. 
select hg.FechaCorrespondiente,hg.NroEmpleado, emp.Apellido, emp.Nombre,cli.Nombre as Cliente, ser.NumeroServicio, hg.HoraEntrada, hg.HoraSalida, cast(TIME_FORMAT(SEC_TO_TIME(SUM(TIME_TO_SEC(TIMEDIFF(hg.HoraSalida,hg.HoraEntrada)))),'%H:%i') as CHAR) as Horas from horasgeneradasescalafon hg, clientes cli, empleados emp, servicios ser where hg.NumeroCliente=cli.NumeroCliente and hg.NumeroCliente=ser.NumeroCliente and hg.NumeroServicio=ser.NumeroServicio and hg.NroEmpleado=emp.NroEmpleado and hg.NroEmpleado=NROEMPLEADO and hg.FechaCorrespondiente between 'FECHADESDE' and 'FECHAHASTA' group by hg.FechaCorrespondiente, hg.NroEmpleado,emp.Apellido,emp.Nombre,hg.NumeroCliente,cli.Nombre,ser.Nombre;
*/

-- Cant Hs por Usuario por Cliente/Servicio
update consultasclientes set Query="select emp.NroEmpleado,emp.Nombre, emp.Apellido, emp.NumeroDocumento, emp.Turno, CAST(TIME_FORMAT(SEC_TO_TIME(SUM(TIME_TO_SEC(TIMEDIFF(hge.HoraSalida,hge.HoraEntrada)))),'%H:%i') as CHAR) as Horas from Empleados emp, horasgeneradasescalafon hge where hge.NumeroCliente=NROCLIENTE and hge.NumeroServicio=NROSERVICIO and MONTH('FECHASOLA')= MONTH(hge.FechaCorrespondiente) and YEAR('FECHASOLA') = YEAR(hge.FechaCorrespondiente) and emp.NroEmpleado = hge.NroEmpleado group by emp.NroEmpleado,emp.Nombre, emp.Apellido, emp.NumeroDocumento, emp.Turno" where idConsultaCliente=10;


-- Extras Liquidacion en consultasempleados.
insert into consultasempleados values (0,"Extras Liquidacion - Descuentos y Bonos", "Devuelve la lista de Descuentos y Bonos de los empleados en el rango de Fecha Dado. Para todos los empleados o para uno si se pone el NroEmpleado","select emp.NroEmpleado, emp.Apellido, emp.Nombre, (select Fecha from cuotasextrasliquidacion tmpcuota where tmpcuota.IdExtraLiquidacion = extra.IdExtraLiquidacion and tmpcuota.NumeroCuota=1) as Fecha, extra.Descripcion, if(extra.signo=0,'-','+') as Signo, cuotas.ValorCuota, cuotas.NumeroCuota,extra.CantidadCuotas from CuotasExtrasLiquidacion cuotas, Empleados emp, ExtrasLiquidacion extra where extra.IdEmpleado =emp.NroEmpleado and extra.IdExtraLiquidacion = cuotas.IdExtraLiquidacion and cuotas.Fecha between 'FECHADESDE' and 'FECHAHASTA' IFNROEMPLEADO order by emp.NroEmpleado",1);

-- Se borra la consulta Extras Liquidacion de consultasclientes
delete from consultasclientes where idconsultacliente=11 and Nombre="Extras Liquidacion - Descuentos y Bonos";


-- HistorialEmpleado 
insert into consultasempleados values (0,"Historial de Empleado","Muestra el historial de uno o varios empleados en un rango de fecha dado.","select emp.NroEmpleado, emp.Apellido, emp.Nombre, the.Nombre as Tipo, ehe.Descripcion, ehe.FechaInicio, ehe.FechaFin from EventosHistorialEmpleado ehe, Empleados emp, TiposEventoHistorial teh where ehe.IdEmpleado=emp.NroEmpleado and ehe.IdTipoEvento = teh.IdTipoEventoHistorial and (FechaInicio between 'FECHADESDE' and 'FECHAHASTA' or FechaFin between 'FECHADESDE' and 'FECHAHASTA') IFNROEMPLEADO",1);