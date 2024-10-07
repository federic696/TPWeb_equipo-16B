## Stored Procedure: `listarArticulos`

### Consulta SQL

```sql
USE PROMOS_DB
CREATE PROCEDURE listarArticulos AS
    SELECT
        a.Id,
        a.Codigo AS Codigo,
        a.Nombre,
        a.Descripcion,
        MIN(i.ImagenUrl) AS UrlImagen,
        m.Descripcion AS Marca,
        c.Descripcion AS Categoria,
        a.IdMarca,
        a.IdCategoria,
        a.Precio
    FROM
        ARTICULOS a
    INNER JOIN
        MARCAS m ON a.IdMarca = m.Id
    INNER JOIN
        CATEGORIAS c ON a.IdCategoria = c.Id
    LEFT JOIN
        IMAGENES i ON a.Id = i.IdArticulo
    GROUP BY
        a.Id, a.Codigo, a.Nombre, a.Descripcion, m.Descripcion, c.Descripcion, a.IdMarca, a.IdCategoria, a.Precio
GO
```

---

```sql
EXEC listarArticulos
```
