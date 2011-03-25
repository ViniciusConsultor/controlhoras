-- Se agrega campo DateTime, DiaHoraLlamadaAntesHoraEntrada
alter table horasgeneradasescalafon add column DiaHoraLlamadaAntesHoraEntrada DateTime Not Null;

-- Se actualizan todos los valores actuales de los registros existentes.
update horasgeneradasescalafon set DiaHoraLlamadaAntesHoraEntrada=ADDTIME(HoraEntrada,'-02:00:00');

-- Actualizacion del Listado: Listado de Escalafon Diario
update consultasclientes set Query="Select ser.NumeroCliente, ser.Nombre as Servicio,date_format(hge.DiaHoraLlamadaAntesHoraEntrada, '%H:%i') as Llamada,date_format(hge.HoraEntrada, '%H:%i') as Entrada,date_format(hge.HoraSalida, '%H:%i') as Salida, '             ' as Cierre, cast(concat(emp.NroEmpleado,' - ', emp.Apellido,' ', emp.Nombre) as char) as Funcionario, (select  group_concat(distinct(he.dia)) from horarioescalafon he, tiposdias td where he.TipoDia=td.Id and td.Nombre='Descanso' and he.NroEmpleado = hge.NroEmpleado) as DiaDescanso, emp.CelularenConvenio, emp.Celular as CelularParticular, emp.Telefonos from Empleados emp,horasgeneradasescalafon hge, Servicios ser where hge.FechaCorrespondiente='FECHASOLA' and hge.HoraEntrada is not null and hge.HoraSalida is not null and ser.NumeroCliente= hge.NumeroCliente and ser.NumeroServicio = hge.NumeroServicio and emp.NroEmpleado = hge.NroEmpleado group by ser.NumeroCliente, ser.Nombre,date_format(hge.DiaHoraLlamadaAntesHoraEntrada, '%H:%i'), date_format(hge.HoraEntrada, '%H:%i'),date_format(hge.HoraSalida, '%H:%i'), cast(concat(emp.NroEmpleado,' - ', emp.Nombre,' ', emp.Apellido) as char), emp.CelularenConvenio, emp.Celular order by date_format(hge.DiaHoraLlamadaAntesHoraEntrada, '%H:%i')" where idConsultaCliente=3;
