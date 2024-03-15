#!/bin/bash

/opt/mssql-tools/bin/sqlcmd -S mssql -U SA -P Pass@135! -d master -i /opt/mssql_scripts/20240314_db.up.sql