sqlcmd -S localhost -U sa -P PassDB@1234 -i db-struct\init-db.sql
sqlcmd -S localhost -U sa -P PassDB@1234 -i db-struct\init-tb.sql
sqlcmd -S localhost -U sa -P PassDB@1234 -i db-data\init-data.sql