#!/bin/bash

echo "Configuring audit trail and restarting database..."

# Kết nối và cấu hình
sqlplus -s sys/oracle@//localhost:1521/XE as sysdba <<EOF
ALTER SYSTEM SET audit_trail = DB SCOPE = SPFILE;
SHOW PARAMETER audit_trail;
EXIT;
EOF

echo "Audit trail configuration completed!"