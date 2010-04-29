select @rownum:=@rownum+1 AS Nro, emp.Apellido AS Apellidos, emp.Nombre AS Nombres, emp.ServicioActual,
emp.Turno, emp.NumeroDocumento, ADDDATE(emp.FechaIngreso, -1) AS FeachaAprobCurso,
IF(emp.CapacitadoPortarArma=1, 'SI', 'NO') AS CursoServicioArmado, IF(emp.EnServicioArmado=1, 'SI', 'NO') AS EnServicioArmado,
emp.CAJ_Numero, IF(emp.ConstanciaDomicilio=1, 'SI', 'NO') AS ConstanciaDomicilio
from (SELECT @rownum:=0) r, empleados emp 
where emp.Activo=1;
