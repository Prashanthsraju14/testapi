#!/bin/bash
source /var/projectenv/config
sudo rm -rf /var/www/$ENV/testapi
sudo mkdir -p /var/www/$ENV/testapi
sudo cp -a /var/tempbuild/code/testapi/out/. /var/www/$ENV/testapi/
sudo cp -a /var/tempbuild/code/testapi/systemd/Xigify.testapi.$ENV.service /etc/systemd/system
sudo cp -a /var/www/$ENV/testapi/testapi.$ENV.appsettings.json /var/www/$ENV/testapi/testapi.appsettings.json 
sudo systemctl daemon-reload
sudo rm -rf /var/tempbuild/code/testapi