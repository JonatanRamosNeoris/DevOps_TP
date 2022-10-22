FROM octopusdeploy/mssql-server-windows-express

EXPOSE 1433

COPY ./init-db.sql /docker-init/db-struct/init-db.sql
COPY ./init-tb.sql /docker-init/db-struct/init-tb.sql
COPY ./init-data.sql /docker-init/db-data/init-data.sql
COPY ./init.cmd /docker-init/init.cmd