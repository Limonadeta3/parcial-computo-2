USE SistemaUsuariosDB;
GO

SELECT
    idUsuario,
    usuario,
    clave,
    nombre,
    [dirección],
    [teléfono]
FROM dbo.usuarios_Usss039026
ORDER BY idUsuario;

use SistemaUsuariosDB
select * from dbo.usuarios_Usss039026